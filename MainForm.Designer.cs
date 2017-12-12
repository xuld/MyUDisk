namespace MyUDisk {
    partial class MainForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.explorer = new CodeArtEng.Controls.FileExplorer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // explorer
            // 
            this.explorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorer.FileView = System.Windows.Forms.View.LargeIcon;
            this.explorer.HideSystemFolder = true;
            this.explorer.Location = new System.Drawing.Point(0, 24);
            this.explorer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.explorer.Name = "explorer";
            this.explorer.Size = new System.Drawing.Size(679, 454);
            this.explorer.SplitterDistance = 25;
            this.explorer.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 478);
            this.Controls.Add(this.explorer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "我的 U 盘 - by xuld";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CodeArtEng.Controls.FileExplorer explorer;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

