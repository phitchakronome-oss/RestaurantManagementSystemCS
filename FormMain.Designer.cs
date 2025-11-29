namespace final
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ฐานขอมลToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ลกคาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.รายการอาหารToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ปิดโปรแกรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.ฐานขอมลToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ฐานขอมลToolStripMenuItem
            // 
            this.ฐานขอมลToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ลกคาToolStripMenuItem,
            this.รายการอาหารToolStripMenuItem});
            this.ฐานขอมลToolStripMenuItem.Name = "ฐานขอมลToolStripMenuItem";
            this.ฐานขอมลToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ฐานขอมลToolStripMenuItem.Text = "ฐานข้อมูล";
            // 
            // ลกคาToolStripMenuItem
            // 
            this.ลกคาToolStripMenuItem.Name = "ลกคาToolStripMenuItem";
            this.ลกคาToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ลกคาToolStripMenuItem.Text = "ลูกค้า";
            this.ลกคาToolStripMenuItem.Click += new System.EventHandler(this.ลกคาToolStripMenuItem_Click);
            // 
            // รายการอาหารToolStripMenuItem
            // 
            this.รายการอาหารToolStripMenuItem.Name = "รายการอาหารToolStripMenuItem";
            this.รายการอาหารToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.รายการอาหารToolStripMenuItem.Text = "รายการอาหาร";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.ปิดโปรแกรมToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // ปิดโปรแกรมToolStripMenuItem
            // 
            this.ปิดโปรแกรมToolStripMenuItem.Name = "ปิดโปรแกรมToolStripMenuItem";
            this.ปิดโปรแกรมToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ปิดโปรแกรมToolStripMenuItem.Text = "ปิดโปรแกรม";
            this.ปิดโปรแกรมToolStripMenuItem.Click += new System.EventHandler(this.ออกจากโปรแกรมToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 517);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "โปรแกรมร้านอาหาร";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ฐานขอมลToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ลกคาToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายการอาหารToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ปิดโปรแกรมToolStripMenuItem;
    }
}