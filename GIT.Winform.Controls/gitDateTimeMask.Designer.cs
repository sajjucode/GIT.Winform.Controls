namespace GIT.Winform.Controls
{
    partial class gitDateTimeMask
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
            this.lblDateTimeFormat = new System.Windows.Forms.Label();
            this.IcondateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.InputDateTimemaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblDateTimeFormat
            // 
            this.lblDateTimeFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTimeFormat.ForeColor = System.Drawing.Color.Red;
            this.lblDateTimeFormat.Location = new System.Drawing.Point(0, 21);
            this.lblDateTimeFormat.Name = "lblDateTimeFormat";
            this.lblDateTimeFormat.Size = new System.Drawing.Size(163, 13);
            this.lblDateTimeFormat.TabIndex = 2;
            this.lblDateTimeFormat.Text = "MM/dd/yyyy";
            // 
            // IcondateTimePicker
            // 
            this.IcondateTimePicker.Dock = System.Windows.Forms.DockStyle.Right;
            this.IcondateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.IcondateTimePicker.Location = new System.Drawing.Point(175, 0);
            this.IcondateTimePicker.Name = "IcondateTimePicker";
            this.IcondateTimePicker.Size = new System.Drawing.Size(14, 21);
            this.IcondateTimePicker.TabIndex = 1;
            this.IcondateTimePicker.ValueChanged += new System.EventHandler(this.IcondateTimePicker_ValueChanged);
            // 
            // InputDateTimemaskedTextBox
            // 
            this.InputDateTimemaskedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputDateTimemaskedTextBox.Location = new System.Drawing.Point(0, 0);
            this.InputDateTimemaskedTextBox.Name = "InputDateTimemaskedTextBox";
            this.InputDateTimemaskedTextBox.Size = new System.Drawing.Size(175, 21);
            this.InputDateTimemaskedTextBox.TabIndex = 0;
            this.InputDateTimemaskedTextBox.Enter += new System.EventHandler(this.InputDateTimemaskedTextBox_Enter);
            this.InputDateTimemaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputDateTimemaskedTextBox_KeyPress);
            this.InputDateTimemaskedTextBox.Leave += new System.EventHandler(this.InputDateTimemaskedTextBox_Leave);
            this.InputDateTimemaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.InputDateTimemaskedTextBox_Validating);
            this.InputDateTimemaskedTextBox.Validated += new System.EventHandler(this.InputDateTimemaskedTextBox_Validated);
            // 
            // gitDateTimeMask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.InputDateTimemaskedTextBox);
            this.Controls.Add(this.IcondateTimePicker);
            this.Controls.Add(this.lblDateTimeFormat);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "gitDateTimeMask";
            this.Size = new System.Drawing.Size(189, 34);
            this.Load += new System.EventHandler(this.gitDateTimeMask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateTimeFormat;
        private System.Windows.Forms.DateTimePicker IcondateTimePicker;
        private System.Windows.Forms.MaskedTextBox InputDateTimemaskedTextBox;
    }
}
