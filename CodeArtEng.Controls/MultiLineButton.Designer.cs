﻿namespace CodeArtEng.Controls
{
    partial class MultiLineButton
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
                drawBrush.Dispose();
                drawPen.Dispose();
                mainTitleFont.Dispose();
                subTitleFont.Dispose();
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Badge
            // 
            this.Name = "Badge";
            this.Size = new System.Drawing.Size(185, 37);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
