namespace final
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBUser = new System.Windows.Forms.TextBox();
            this.TBPW = new System.Windows.Forms.TextBox();
            this.CBShow = new System.Windows.Forms.CheckBox();
            this.BTLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // TBUser
            // 
            this.TBUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUser.Location = new System.Drawing.Point(178, 68);
            this.TBUser.MaxLength = 10;
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(185, 22);
            this.TBUser.TabIndex = 2;
            // 
            // TBPW
            // 
            this.TBPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPW.Location = new System.Drawing.Point(178, 119);
            this.TBPW.MaxLength = 12;
            this.TBPW.Name = "TBPW";
            this.TBPW.PasswordChar = '*';
            this.TBPW.Size = new System.Drawing.Size(185, 22);
            this.TBPW.TabIndex = 3;
            // 
            // CBShow
            // 
            this.CBShow.AutoSize = true;
            this.CBShow.Location = new System.Drawing.Point(389, 121);
            this.CBShow.Name = "CBShow";
            this.CBShow.Size = new System.Drawing.Size(91, 17);
            this.CBShow.TabIndex = 4;
            this.CBShow.Text = "แสดงรหัสผ่าน";
            this.CBShow.UseVisualStyleBackColor = true;
            this.CBShow.CheckedChanged += new System.EventHandler(this.CBShow_CheckedChanged);
            // 
            // BTLogin
            // 
            this.BTLogin.Location = new System.Drawing.Point(214, 179);
            this.BTLogin.Name = "BTLogin";
            this.BTLogin.Size = new System.Drawing.Size(75, 28);
            this.BTLogin.TabIndex = 5;
            this.BTLogin.Text = "Login";
            this.BTLogin.UseVisualStyleBackColor = true;
            this.BTLogin.Click += new System.EventHandler(this.BTLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 249);
            this.Controls.Add(this.BTLogin);
            this.Controls.Add(this.CBShow);
            this.Controls.Add(this.TBPW);
            this.Controls.Add(this.TBUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBUser;
        private System.Windows.Forms.TextBox TBPW;
        private System.Windows.Forms.CheckBox CBShow;
        private System.Windows.Forms.Button BTLogin;
    }
}