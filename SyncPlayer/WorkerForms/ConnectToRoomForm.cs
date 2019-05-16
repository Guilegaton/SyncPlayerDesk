using SyncPlayer.Models;
using SyncPlayer.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SyncPlayer.WorkerForms
{
    public partial class ConnectToRoomForm : MaterialSkin.Controls.MaterialForm
    {
        #region Private Fields

        private List<Media> Playlist;

        #endregion Private Fields

        #region Public Constructors

        public ConnectToRoomForm()
        {
            InitializeComponent();
            Playlist = new List<Media>();
        }

        #endregion Public Constructors

        #region Private Methods

        private void ChooseDirectoryBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (DirectoryDialog.ShowDialog() == DialogResult.OK)
                {
                    Playlist.Clear();
                    string[] formats = { "*.mp3","*.wav", "*.ogg",
                                         "*.avi","*.flv", "*.mkv", "*.mp4" };
                    var mediaService = new MediaService();
                    foreach (string format in formats)
                    {
                        foreach (var filePath in Directory.GetFiles(DirectoryDialog.SelectedPath, format, SearchOption.AllDirectories))
                        {
                            Playlist.Add(mediaService.GetMedia(filePath));
                        }
                    }
                    DirecoryPathTB.Text = DirectoryDialog.SelectedPath;
                }
            }
            catch
            {
                MessageBox.Show("Нет доступа к одной из выбранных папок", "System");
            }
        }

        private void ConnectBTN_Click(object sender, EventArgs e)
        {
            if (Playlist.Count != 0)
            {
                var room = new Room { UniqName = RoomNameTB.Text, Name = RoomNameTB.Text, Password = RoomPasswordTB.Text };
                if (room.ConntectToRoom())
                {
                    PlayerForm playerForm = new PlayerForm(Playlist);
                    playerForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    //error message
                }
            }
            else
            {
                MessageBox.Show("Fill playlist", "Filmst");
            }
        }

        #endregion Private Methods

        private void CreateRoomBTN_Click(object sender, EventArgs e)
        {
            if (Playlist.Count != 0)
            {
                var room = new Room
                {
                    UniqName = RoomNameTB.Text,
                    Name = RoomNameTB.Text,
                    Password = RoomPasswordTB.Text,
                    Medias = Playlist
                };
                if (room.CreateRoom())
                {
                    PlayerForm playerForm = new PlayerForm(Playlist);
                    playerForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong....", "Filmst");
                }
            }
            else
            {
                MessageBox.Show("Fill playlist", "Filmst");
            }
        }
    }
}