namespace SyncPlayer.WorkerForms
{
    partial class ConnectToRoomForm
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
            this.RoomNameTB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RoomPasswordTB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.ConnectBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DirecoryPathTB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DirectoryRTB = new System.Windows.Forms.RichTextBox();
            this.ChooseDirectoryBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.CreateRoomBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // RoomNameTB
            // 
            this.RoomNameTB.Depth = 0;
            this.RoomNameTB.Hint = "Room name";
            this.RoomNameTB.Location = new System.Drawing.Point(12, 115);
            this.RoomNameTB.MaxLength = 32767;
            this.RoomNameTB.MouseState = MaterialSkin.MouseState.HOVER;
            this.RoomNameTB.Name = "RoomNameTB";
            this.RoomNameTB.PasswordChar = '\0';
            this.RoomNameTB.SelectedText = "";
            this.RoomNameTB.SelectionLength = 0;
            this.RoomNameTB.SelectionStart = 0;
            this.RoomNameTB.Size = new System.Drawing.Size(238, 23);
            this.RoomNameTB.TabIndex = 0;
            this.RoomNameTB.TabStop = false;
            this.RoomNameTB.UseSystemPasswordChar = false;
            // 
            // RoomPasswordTB
            // 
            this.RoomPasswordTB.Depth = 0;
            this.RoomPasswordTB.Hint = "Room password";
            this.RoomPasswordTB.Location = new System.Drawing.Point(12, 176);
            this.RoomPasswordTB.MaxLength = 32767;
            this.RoomPasswordTB.MouseState = MaterialSkin.MouseState.HOVER;
            this.RoomPasswordTB.Name = "RoomPasswordTB";
            this.RoomPasswordTB.PasswordChar = '\0';
            this.RoomPasswordTB.SelectedText = "";
            this.RoomPasswordTB.SelectionLength = 0;
            this.RoomPasswordTB.SelectionStart = 0;
            this.RoomPasswordTB.Size = new System.Drawing.Size(238, 23);
            this.RoomPasswordTB.TabIndex = 1;
            this.RoomPasswordTB.TabStop = false;
            this.RoomPasswordTB.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(281, 76);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1, 210);
            this.materialDivider1.TabIndex = 2;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // ConnectBTN
            // 
            this.ConnectBTN.AutoSize = true;
            this.ConnectBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConnectBTN.Depth = 0;
            this.ConnectBTN.Icon = null;
            this.ConnectBTN.Location = new System.Drawing.Point(12, 231);
            this.ConnectBTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConnectBTN.Name = "ConnectBTN";
            this.ConnectBTN.Primary = true;
            this.ConnectBTN.Size = new System.Drawing.Size(84, 36);
            this.ConnectBTN.TabIndex = 3;
            this.ConnectBTN.Text = "Connect";
            this.ConnectBTN.UseVisualStyleBackColor = true;
            this.ConnectBTN.Click += new System.EventHandler(this.ConnectBTN_Click);
            // 
            // DirecoryPathTB
            // 
            this.DirecoryPathTB.Depth = 0;
            this.DirecoryPathTB.Hint = "Directory path";
            this.DirecoryPathTB.Location = new System.Drawing.Point(289, 155);
            this.DirecoryPathTB.MaxLength = 32767;
            this.DirecoryPathTB.MouseState = MaterialSkin.MouseState.HOVER;
            this.DirecoryPathTB.Name = "DirecoryPathTB";
            this.DirecoryPathTB.PasswordChar = '\0';
            this.DirecoryPathTB.SelectedText = "";
            this.DirecoryPathTB.SelectionLength = 0;
            this.DirecoryPathTB.SelectionStart = 0;
            this.DirecoryPathTB.Size = new System.Drawing.Size(283, 23);
            this.DirecoryPathTB.TabIndex = 4;
            this.DirecoryPathTB.TabStop = false;
            this.DirecoryPathTB.UseSystemPasswordChar = false;
            // 
            // DirectoryRTB
            // 
            this.DirectoryRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DirectoryRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectoryRTB.Location = new System.Drawing.Point(289, 99);
            this.DirectoryRTB.Name = "DirectoryRTB";
            this.DirectoryRTB.Size = new System.Drawing.Size(283, 39);
            this.DirectoryRTB.TabIndex = 5;
            this.DirectoryRTB.Text = "Выберите папку, которая содержит файлы форматов avi, mp3, mp4 и прочих медиа форм" +
    "атов";
            // 
            // ChooseDirectoryBTN
            // 
            this.ChooseDirectoryBTN.AutoSize = true;
            this.ChooseDirectoryBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChooseDirectoryBTN.Depth = 0;
            this.ChooseDirectoryBTN.Icon = null;
            this.ChooseDirectoryBTN.Location = new System.Drawing.Point(289, 231);
            this.ChooseDirectoryBTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChooseDirectoryBTN.Name = "ChooseDirectoryBTN";
            this.ChooseDirectoryBTN.Primary = true;
            this.ChooseDirectoryBTN.Size = new System.Drawing.Size(151, 36);
            this.ChooseDirectoryBTN.TabIndex = 6;
            this.ChooseDirectoryBTN.Text = "Choose directory";
            this.ChooseDirectoryBTN.UseVisualStyleBackColor = true;
            this.ChooseDirectoryBTN.Click += new System.EventHandler(this.ChooseDirectoryBTN_Click);
            // 
            // CreateRoomBTN
            // 
            this.CreateRoomBTN.AutoSize = true;
            this.CreateRoomBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateRoomBTN.Depth = 0;
            this.CreateRoomBTN.Icon = null;
            this.CreateRoomBTN.Location = new System.Drawing.Point(191, 231);
            this.CreateRoomBTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateRoomBTN.Name = "CreateRoomBTN";
            this.CreateRoomBTN.Primary = true;
            this.CreateRoomBTN.Size = new System.Drawing.Size(71, 36);
            this.CreateRoomBTN.TabIndex = 7;
            this.CreateRoomBTN.Text = "Create";
            this.CreateRoomBTN.UseVisualStyleBackColor = true;
            this.CreateRoomBTN.Click += new System.EventHandler(this.CreateRoomBTN_Click);
            // 
            // ConnectToRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 295);
            this.Controls.Add(this.CreateRoomBTN);
            this.Controls.Add(this.ChooseDirectoryBTN);
            this.Controls.Add(this.DirectoryRTB);
            this.Controls.Add(this.DirecoryPathTB);
            this.Controls.Add(this.ConnectBTN);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.RoomPasswordTB);
            this.Controls.Add(this.RoomNameTB);
            this.Name = "ConnectToRoomForm";
            this.Text = "ConnectToRoomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField RoomNameTB;
        private MaterialSkin.Controls.MaterialSingleLineTextField RoomPasswordTB;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton ConnectBTN;
        private MaterialSkin.Controls.MaterialSingleLineTextField DirecoryPathTB;
        private System.Windows.Forms.RichTextBox DirectoryRTB;
        private MaterialSkin.Controls.MaterialRaisedButton ChooseDirectoryBTN;
        private System.Windows.Forms.FolderBrowserDialog DirectoryDialog;
        private MaterialSkin.Controls.MaterialRaisedButton CreateRoomBTN;
    }
}