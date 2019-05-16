namespace SyncPlayer.SignForms
{
    partial class SignInForm
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
            this.tbox_email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbox_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbox_remMe = new MaterialSkin.Controls.MaterialCheckBox();
            this.linkLab_forgotPasw = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.RegisterLB = new MaterialSkin.Controls.MaterialLabel();
            this.btn_login = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // tbox_email
            // 
            this.tbox_email.Depth = 0;
            this.tbox_email.Hint = "Email";
            this.tbox_email.Location = new System.Drawing.Point(35, 123);
            this.tbox_email.MaxLength = 32767;
            this.tbox_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_email.Name = "tbox_email";
            this.tbox_email.PasswordChar = '\0';
            this.tbox_email.SelectedText = "";
            this.tbox_email.SelectionLength = 0;
            this.tbox_email.SelectionStart = 0;
            this.tbox_email.Size = new System.Drawing.Size(209, 23);
            this.tbox_email.TabIndex = 0;
            this.tbox_email.TabStop = false;
            this.tbox_email.UseSystemPasswordChar = false;
            // 
            // tbox_password
            // 
            this.tbox_password.Depth = 0;
            this.tbox_password.Hint = "Password";
            this.tbox_password.Location = new System.Drawing.Point(35, 187);
            this.tbox_password.MaxLength = 32767;
            this.tbox_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_password.Name = "tbox_password";
            this.tbox_password.PasswordChar = '\0';
            this.tbox_password.SelectedText = "";
            this.tbox_password.SelectionLength = 0;
            this.tbox_password.SelectionStart = 0;
            this.tbox_password.Size = new System.Drawing.Size(209, 23);
            this.tbox_password.TabIndex = 1;
            this.tbox_password.TabStop = false;
            this.tbox_password.UseSystemPasswordChar = false;
            // 
            // cbox_remMe
            // 
            this.cbox_remMe.AutoSize = true;
            this.cbox_remMe.Depth = 0;
            this.cbox_remMe.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbox_remMe.Location = new System.Drawing.Point(35, 245);
            this.cbox_remMe.Margin = new System.Windows.Forms.Padding(0);
            this.cbox_remMe.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbox_remMe.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbox_remMe.Name = "cbox_remMe";
            this.cbox_remMe.Ripple = true;
            this.cbox_remMe.Size = new System.Drawing.Size(120, 30);
            this.cbox_remMe.TabIndex = 2;
            this.cbox_remMe.Text = "Remember me";
            this.cbox_remMe.UseVisualStyleBackColor = true;
            // 
            // linkLab_forgotPasw
            // 
            this.linkLab_forgotPasw.AutoSize = true;
            this.linkLab_forgotPasw.BackColor = System.Drawing.Color.Transparent;
            this.linkLab_forgotPasw.Depth = 0;
            this.linkLab_forgotPasw.Font = new System.Drawing.Font("Roboto", 11F);
            this.linkLab_forgotPasw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLab_forgotPasw.Location = new System.Drawing.Point(32, 367);
            this.linkLab_forgotPasw.MouseState = MaterialSkin.MouseState.HOVER;
            this.linkLab_forgotPasw.Name = "linkLab_forgotPasw";
            this.linkLab_forgotPasw.Size = new System.Drawing.Size(122, 19);
            this.linkLab_forgotPasw.TabIndex = 3;
            this.linkLab_forgotPasw.Text = "Forgot password";
            this.linkLab_forgotPasw.Click += new System.EventHandler(this.linkLab_forgotPasw_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(35, 354);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(209, 1);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // RegisterLB
            // 
            this.RegisterLB.AutoSize = true;
            this.RegisterLB.BackColor = System.Drawing.Color.Transparent;
            this.RegisterLB.Depth = 0;
            this.RegisterLB.Font = new System.Drawing.Font("Roboto", 11F);
            this.RegisterLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RegisterLB.Location = new System.Drawing.Point(195, 367);
            this.RegisterLB.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterLB.Name = "RegisterLB";
            this.RegisterLB.Size = new System.Drawing.Size(64, 19);
            this.RegisterLB.TabIndex = 5;
            this.RegisterLB.Text = "Register";
            this.RegisterLB.Click += new System.EventHandler(this.RegisterLB_Click);
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = true;
            this.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_login.Depth = 0;
            this.btn_login.Icon = null;
            this.btn_login.Location = new System.Drawing.Point(183, 297);
            this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login.Name = "btn_login";
            this.btn_login.Primary = true;
            this.btn_login.Size = new System.Drawing.Size(61, 36);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 400);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.RegisterLB);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.linkLab_forgotPasw);
            this.Controls.Add(this.cbox_remMe);
            this.Controls.Add(this.tbox_password);
            this.Controls.Add(this.tbox_email);
            this.MaximumSize = new System.Drawing.Size(280, 400);
            this.MinimumSize = new System.Drawing.Size(280, 400);
            this.Name = "SignInForm";
            this.Text = "Sign in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_email;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_password;
        private MaterialSkin.Controls.MaterialCheckBox cbox_remMe;
        private MaterialSkin.Controls.MaterialLabel linkLab_forgotPasw;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel RegisterLB;
        private MaterialSkin.Controls.MaterialRaisedButton btn_login;
    }
}