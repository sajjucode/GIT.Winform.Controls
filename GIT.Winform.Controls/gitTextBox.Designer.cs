﻿namespace GIT.Winform.Controls
{
    partial class gitTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // gitTextBox
            // 
            this.Enter += new System.EventHandler(this.gitTextBox_Enter);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gitTextBox_KeyPress);
            this.Leave += new System.EventHandler(this.gitTextBox_Leave);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gitTextBox_MouseDoubleClick);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.gitTextBox_Validating);
            this.Validated += new System.EventHandler(this.gitTextBox_Validated);            
            this.ResumeLayout(false);

        }

        #endregion
    }
}
