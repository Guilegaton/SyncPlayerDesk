namespace SyncPlayer.WorkerForms
{
    partial class PlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.PlayPauseBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PlayListLV = new MaterialSkin.Controls.MaterialListView();
            this.PlaylistCL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChatTB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ChatBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ChatRTB = new System.Windows.Forms.RichTextBox();
            this.UserLV = new MaterialSkin.Controls.MaterialListView();
            this.UserCL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(211, 70);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(559, 327);
            this.Player.TabIndex = 0;
            // 
            // PlayPauseBTN
            // 
            this.PlayPauseBTN.AutoSize = true;
            this.PlayPauseBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlayPauseBTN.Depth = 0;
            this.PlayPauseBTN.Icon = null;
            this.PlayPauseBTN.Location = new System.Drawing.Point(715, 404);
            this.PlayPauseBTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.PlayPauseBTN.Name = "PlayPauseBTN";
            this.PlayPauseBTN.Primary = true;
            this.PlayPauseBTN.Size = new System.Drawing.Size(55, 36);
            this.PlayPauseBTN.TabIndex = 1;
            this.PlayPauseBTN.Text = "Play";
            this.PlayPauseBTN.UseVisualStyleBackColor = true;
            this.PlayPauseBTN.Click += new System.EventHandler(this.PlayPauseBTN_Click);
            // 
            // PlayListLV
            // 
            this.PlayListLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayListLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PlaylistCL});
            this.PlayListLV.Depth = 0;
            this.PlayListLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.PlayListLV.FullRowSelect = true;
            this.PlayListLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PlayListLV.Location = new System.Drawing.Point(777, 70);
            this.PlayListLV.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PlayListLV.MouseState = MaterialSkin.MouseState.OUT;
            this.PlayListLV.Name = "PlayListLV";
            this.PlayListLV.OwnerDraw = true;
            this.PlayListLV.Size = new System.Drawing.Size(210, 210);
            this.PlayListLV.TabIndex = 2;
            this.PlayListLV.UseCompatibleStateImageBehavior = false;
            this.PlayListLV.View = System.Windows.Forms.View.Details;
            // 
            // PlaylistCL
            // 
            this.PlaylistCL.Text = "Playlist";
            this.PlaylistCL.Width = 210;
            // 
            // ChatTB
            // 
            this.ChatTB.Depth = 0;
            this.ChatTB.Hint = "Text";
            this.ChatTB.Location = new System.Drawing.Point(5, 404);
            this.ChatTB.MaxLength = 32767;
            this.ChatTB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChatTB.Name = "ChatTB";
            this.ChatTB.PasswordChar = '\0';
            this.ChatTB.SelectedText = "";
            this.ChatTB.SelectionLength = 0;
            this.ChatTB.SelectionStart = 0;
            this.ChatTB.Size = new System.Drawing.Size(137, 23);
            this.ChatTB.TabIndex = 4;
            this.ChatTB.TabStop = false;
            this.ChatTB.UseSystemPasswordChar = false;
            this.ChatTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChatTB_KeyDown);
            // 
            // ChatBTN
            // 
            this.ChatBTN.AutoSize = true;
            this.ChatBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChatBTN.Depth = 0;
            this.ChatBTN.Icon = null;
            this.ChatBTN.Location = new System.Drawing.Point(148, 404);
            this.ChatBTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChatBTN.Name = "ChatBTN";
            this.ChatBTN.Primary = true;
            this.ChatBTN.Size = new System.Drawing.Size(57, 36);
            this.ChatBTN.TabIndex = 5;
            this.ChatBTN.Text = "Chat";
            this.ChatBTN.UseVisualStyleBackColor = true;
            this.ChatBTN.Click += new System.EventHandler(this.ChatBTN_Click);
            // 
            // ChatRTB
            // 
            this.ChatRTB.BackColor = System.Drawing.SystemColors.Control;
            this.ChatRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatRTB.Enabled = false;
            this.ChatRTB.Location = new System.Drawing.Point(5, 70);
            this.ChatRTB.Name = "ChatRTB";
            this.ChatRTB.Size = new System.Drawing.Size(200, 327);
            this.ChatRTB.TabIndex = 6;
            this.ChatRTB.Text = "";
            // 
            // UserLV
            // 
            this.UserLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserCL});
            this.UserLV.Depth = 0;
            this.UserLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.UserLV.FullRowSelect = true;
            this.UserLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.UserLV.Location = new System.Drawing.Point(777, 287);
            this.UserLV.MouseLocation = new System.Drawing.Point(-1, -1);
            this.UserLV.MouseState = MaterialSkin.MouseState.OUT;
            this.UserLV.Name = "UserLV";
            this.UserLV.OwnerDraw = true;
            this.UserLV.Size = new System.Drawing.Size(210, 151);
            this.UserLV.TabIndex = 7;
            this.UserLV.UseCompatibleStateImageBehavior = false;
            this.UserLV.View = System.Windows.Forms.View.Details;
            // 
            // UserCL
            // 
            this.UserCL.Text = "Users list";
            this.UserCL.Width = 210;
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.UserLV);
            this.Controls.Add(this.ChatRTB);
            this.Controls.Add(this.ChatBTN);
            this.Controls.Add(this.ChatTB);
            this.Controls.Add(this.PlayListLV);
            this.Controls.Add(this.PlayPauseBTN);
            this.Controls.Add(this.Player);
            this.Name = "PlayerForm";
            this.Text = "PlayerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayerForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Player;
        private MaterialSkin.Controls.MaterialRaisedButton PlayPauseBTN;
        private MaterialSkin.Controls.MaterialListView PlayListLV;
        private System.Windows.Forms.ColumnHeader PlaylistCL;
        private MaterialSkin.Controls.MaterialSingleLineTextField ChatTB;
        private MaterialSkin.Controls.MaterialRaisedButton ChatBTN;
        private System.Windows.Forms.RichTextBox ChatRTB;
        private MaterialSkin.Controls.MaterialListView UserLV;
        private System.Windows.Forms.ColumnHeader UserCL;
    }
}