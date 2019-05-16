namespace SyncPlayer.SignForms
{
    partial class SignUpForm
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
            this.tbox_repeatPasw = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_register = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // tbox_email
            // 
            this.tbox_email.Depth = 0;
            this.tbox_email.Hint = "Email";
            this.tbox_email.Location = new System.Drawing.Point(28, 134);
            this.tbox_email.MaxLength = 32767;
            this.tbox_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_email.Name = "tbox_email";
            this.tbox_email.PasswordChar = '\0';
            this.tbox_email.SelectedText = "";
            this.tbox_email.SelectionLength = 0;
            this.tbox_email.SelectionStart = 0;
            this.tbox_email.Size = new System.Drawing.Size(224, 23);
            this.tbox_email.TabIndex = 0;
            this.tbox_email.TabStop = false;
            this.tbox_email.UseSystemPasswordChar = false;
            // 
            // tbox_password
            // 
            this.tbox_password.Depth = 0;
            this.tbox_password.Hint = "Password";
            this.tbox_password.Location = new System.Drawing.Point(28, 186);
            this.tbox_password.MaxLength = 32767;
            this.tbox_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_password.Name = "tbox_password";
            this.tbox_password.PasswordChar = '\0';
            this.tbox_password.SelectedText = "";
            this.tbox_password.SelectionLength = 0;
            this.tbox_password.SelectionStart = 0;
            this.tbox_password.Size = new System.Drawing.Size(224, 23);
            this.tbox_password.TabIndex = 1;
            this.tbox_password.TabStop = false;
            this.tbox_password.UseSystemPasswordChar = false;
            // 
            // tbox_repeatPasw
            // 
            this.tbox_repeatPasw.Depth = 0;
            this.tbox_repeatPasw.Hint = "Repeat password";
            this.tbox_repeatPasw.Location = new System.Drawing.Point(28, 244);
            this.tbox_repeatPasw.MaxLength = 32767;
            this.tbox_repeatPasw.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_repeatPasw.Name = "tbox_repeatPasw";
            this.tbox_repeatPasw.PasswordChar = '\0';
            this.tbox_repeatPasw.SelectedText = "";
            this.tbox_repeatPasw.SelectionLength = 0;
            this.tbox_repeatPasw.SelectionStart = 0;
            this.tbox_repeatPasw.Size = new System.Drawing.Size(224, 23);
            this.tbox_repeatPasw.TabIndex = 2;
            this.tbox_repeatPasw.TabStop = false;
            this.tbox_repeatPasw.UseSystemPasswordChar = false;
            // 
            // btn_register
            // 
            this.btn_register.AutoSize = true;
            this.btn_register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_register.Depth = 0;
            this.btn_register.Icon = null;
            this.btn_register.Location = new System.Drawing.Point(171, 305);
            this.btn_register.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_register.Name = "btn_register";
            this.btn_register.Primary = true;
            this.btn_register.Size = new System.Drawing.Size(83, 36);
            this.btn_register.TabIndex = 3;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(208, 372);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Login";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(47, 368);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(209, 1);
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 400);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.tbox_repeatPasw);
            this.Controls.Add(this.tbox_password);
            this.Controls.Add(this.tbox_email);
            this.MaximumSize = new System.Drawing.Size(280, 400);
            this.MinimumSize = new System.Drawing.Size(280, 400);
            this.Name = "SignUpForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_email;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_password;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_repeatPasw;
        private MaterialSkin.Controls.MaterialRaisedButton btn_register;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}