﻿namespace GIT.Winform.Controls
{
    partial class gitCheckBox
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
            // gitCheckBox
            // 
            this.Enter += new System.EventHandler(this.gitCheckBox_Enter);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gitCheckBox_KeyPress);
            this.Leave += new System.EventHandler(this.gitCheckBox_Leave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
