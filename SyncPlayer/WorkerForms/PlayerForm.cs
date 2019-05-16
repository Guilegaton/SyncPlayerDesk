using SyncPlayer.Helpers;
using SyncPlayer.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using System.Threading.Tasks;

namespace SyncPlayer.WorkerForms
{
    public partial class PlayerForm : MaterialSkin.Controls.MaterialForm
    {
        #region Private Fields

        public HubConnection _connection;
        private List<string> _roomUsers;
        private bool IsPlaying = false;

        #endregion Private Fields

        #region Public Constructors

        public PlayerForm(IEnumerable<Media> Playlist)
        {
            InitializeComponent();
            Player.Ctlcontrols.stop();
            Player.uiMode = "none";
            Player.enableContextMenu = false;
            string url = ConfigurationManager.AppSettings["ServerHost"] + "room/";
            _connection = new HubConnectionBuilder()
                .WithUrl(url, options =>
                {
                    options.AccessTokenProvider = () => {
                        return Task.FromResult(GetToken());
                    };
                })
                .Build();


            Task.Run(async () => {


                _connection.Closed += (O_O) =>
                {
                    this.Close();
                    return Task.CompletedTask;
                };
                _connection.On<string, string>("Receive", (userName, message) => AddTextToChat(userName, message));
                _connection.On<string>("UserDisconect", (username) => { _roomUsers.Remove(username); UpdateUserList(); });
                _connection.On<string>("UserConnect", (username) => { _roomUsers.Add(username); UpdateUserList(); });
                await _connection.StartAsync();
            });

            //_roomUsers = new HttpHelper().Request<List<string>, object>(null, ConfigurationManager.AppSettings["ServerHost"] + "/room/GetUserList", SessionHelper.ActiveUser.AccessToken);
        }


        public static string GetToken()
        {
            return "Bearer " + SessionHelper.ActiveUser.AccessToken;

        }

        #endregion Public Constructors

        #region Private Methods
        delegate void SetTextCallback(string userName, string message);
        private void AddTextToChat(string userName, string message)
        {
            if (this.ChatRTB.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AddTextToChat);
                this.Invoke(d, new object[] { userName, message });
            }
            else
            {
                this.ChatRTB.Text += userName + ": " + message + "\r\n";
            }
        }

        private void ChatBTN_Click(object sender, EventArgs e)
        {
            _connection.SendAsync("Message", ChatTB.Text).Wait();
            ChatTB.Text = string.Empty;
        }

        private void ChatTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _connection.InvokeAsync("Message", ChatTB.Text);
                ChatTB.Text = string.Empty;
            }
        }

        private void PlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _connection.InvokeAsync("Disconnect", SessionHelper.ActiveUser.Username).Wait();
            _connection.StopAsync();
        }

        private void PlayPauseBTN_Click(object sender, EventArgs e)
        {
            if (!IsPlaying)
            {
                PlayPauseBTN.Text = "stop";
                Player.Ctlcontrols.play();
                IsPlaying = true;
            }
            else
            {
                PlayPauseBTN.Text = "play";
                Player.Ctlcontrols.pause();
                IsPlaying = false;
            }
        }

        private void UpdateUserList() => UserLV.Text = _roomUsers.Aggregate((cur, next) => $"{cur}\n\r{next}");

        #endregion Private Methods
    }
}