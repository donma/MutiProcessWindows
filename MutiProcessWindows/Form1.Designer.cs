namespace MutiProcessWindows
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCreateFormA = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCreateFormB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUsToolStripMenuItem
            // 
            this.mENUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCreateFormA,
            this.menuItemCreateFormB});
            this.mENUsToolStripMenuItem.Name = "mENUsToolStripMenuItem";
            this.mENUsToolStripMenuItem.Size = new System.Drawing.Size(109, 38);
            this.mENUsToolStripMenuItem.Text = "MENUs";
            // 
            // menuItemCreateFormA
            // 
            this.menuItemCreateFormA.Name = "menuItemCreateFormA";
            this.menuItemCreateFormA.Size = new System.Drawing.Size(187, 38);
            this.menuItemCreateFormA.Text = "FormA";
            this.menuItemCreateFormA.Click += new System.EventHandler(this.menuItemCreateFormA_Click);
            // 
            // menuItemCreateFormB
            // 
            this.menuItemCreateFormB.Name = "menuItemCreateFormB";
            this.menuItemCreateFormB.Size = new System.Drawing.Size(269, 38);
            this.menuItemCreateFormB.Text = "FormB";
            this.menuItemCreateFormB.Click += new System.EventHandler(this.menuItemCreateFormB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 644);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreateFormA;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreateFormB;
    }
}

