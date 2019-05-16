namespace SyncPlayer.SignForms
{
    partial class ForgotPasswordForm
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
            this.ForgotPassEmailTB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SendBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // ForgotPassEmailTB
            // 
            this.ForgotPassEmailTB.Depth = 0;
            this.ForgotPassEmailTB.Hint = "Email";
            this.ForgotPassEmailTB.Location = new System.Drawing.Point(43, 139);
            this.ForgotPassEmailTB.MaxLength = 32767;
            this.ForgotPassEmailTB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ForgotPassEmailTB.Name = "ForgotPassEmailTB";
            this.ForgotPassEmailTB.PasswordChar = '\0';
            this.ForgotPassEmailTB.SelectedText = "";
            this.ForgotPassEmailTB.SelectionLength = 0;
            this.ForgotPassEmailTB.SelectionStart = 0;
            this.ForgotPassEmailTB.Size = new System.Drawing.Size(209, 23);
            this.ForgotPassEmailTB.TabIndex = 0;
            this.ForgotPassEmailTB.TabStop = false;
            this.ForgotPassEmailTB.UseSystemPasswordChar = false;
            // 
            // SendBTN
            // 
            this.SendBTN.AutoSize = true;
            this.SendBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SendBTN.Depth = 0;
            this.SendBTN.Icon = null;
            this.SendBTN.Location = new System.Drawing.Point(97, 246);
            this.SendBTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.Primary = true;
            this.SendBTN.Size = new System.Drawing.Size(156, 36);
            this.SendBTN.TabIndex = 1;
            this.SendBTN.Text = "Send me password";
            this.SendBTN.UseVisualStyleBackColor = true;
            this.SendBTN.Click += new System.EventHandler(this.SendBTN_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 8F);
            this.materialLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel2.Location = new System.Drawing.Point(204, 362);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(49, 14);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Register";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(43, 358);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(209, 1);
            this.materialDivider1.TabIndex = 7;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 400);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.SendBTN);
            this.Controls.Add(this.ForgotPassEmailTB);
            this.MaximumSize = new System.Drawing.Size(280, 400);
            this.MinimumSize = new System.Drawing.Size(280, 400);
            this.Name = "ForgotPasswordForm";
            this.Text = "ForgotPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField ForgotPassEmailTB;
        private MaterialSkin.Controls.MaterialRaisedButton SendBTN;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}