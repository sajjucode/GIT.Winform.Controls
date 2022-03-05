using GIT.Winform.Controls.CommonSettings;
namespace GIT.Winform.Controls
{
    partial class gitFormHeader
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
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.cmdMinimuze = new System.Windows.Forms.Button();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdHeadingButton = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.SearchgitTextBox = new GIT.Winform.Controls.gitTextBox();
            this.pnlHeader.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackgroundImage = Stylings.FormHeadingProperites.HeadingBG;
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.Controls.Add(this.pnlSearch);
            this.pnlHeader.Controls.Add(this.cmdHeadingButton);
            this.pnlHeader.Controls.Add(this.lblHeading);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 30);
            this.pnlHeader.TabIndex = 1;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = Stylings.FormHeadingProperites.SearchPanelBG;
            this.pnlSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSearch.Controls.Add(this.cmdMinimuze);
            this.pnlSearch.Controls.Add(this.SearchgitTextBox);
            this.pnlSearch.Controls.Add(this.cmdSearch);
            this.pnlSearch.Controls.Add(this.cmdClose);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSearch.Location = new System.Drawing.Point(436, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(364, 30);
            this.pnlSearch.TabIndex = 5;
            // 
            // cmdMinimuze
            // 
            this.cmdMinimuze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMinimuze.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources.minimizebutton;
            this.cmdMinimuze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdMinimuze.FlatAppearance.BorderSize = 0;
            this.cmdMinimuze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdMinimuze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdMinimuze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMinimuze.Location = new System.Drawing.Point(309, 6);
            this.cmdMinimuze.Name = "cmdMinimuze";
            this.cmdMinimuze.Size = new System.Drawing.Size(18, 18);
            this.cmdMinimuze.TabIndex = 3;
            this.cmdMinimuze.UseVisualStyleBackColor = true;
            this.cmdMinimuze.Click += new System.EventHandler(this.cmdMinimuze_Click);
            // 
            // cmdSearch
            // 
            this.cmdSearch.BackgroundImage = Stylings.FormHeadingProperites.SearchButtonBG;
            this.cmdSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdSearch.FlatAppearance.BorderSize = 0;
            this.cmdSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSearch.Location = new System.Drawing.Point(0, 0);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(39, 30);
            this.cmdSearch.TabIndex = 1;
            this.cmdSearch.UseVisualStyleBackColor = true;
            // 
            // cmdClose
            // 
            this.cmdClose.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources.CloseRed;
            this.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdClose.FlatAppearance.BorderSize = 0;
            this.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Location = new System.Drawing.Point(333, 0);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(31, 30);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdHeadingButton
            // 
            this.cmdHeadingButton.BackgroundImage = Stylings.FormHeadingProperites.HeadingButtonBG;
            this.cmdHeadingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdHeadingButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdHeadingButton.FlatAppearance.BorderSize = 0;
            this.cmdHeadingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdHeadingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdHeadingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdHeadingButton.Location = new System.Drawing.Point(0, 0);
            this.cmdHeadingButton.Name = "cmdHeadingButton";
            this.cmdHeadingButton.Size = new System.Drawing.Size(39, 30);
            this.cmdHeadingButton.TabIndex = 4;
            this.cmdHeadingButton.UseVisualStyleBackColor = true;
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeading.Font = Stylings.FormHeadingProperites.HeadingTitleFont;
            this.lblHeading.ForeColor = Stylings.FormHeadingProperites.HeadingTitleForeColor;
            this.lblHeading.Location = new System.Drawing.Point(45, 2);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(312, 26);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "Heading...";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchgitTextBox
            // 
            this.SearchgitTextBox.AllowNumberIncremenent = false;
            this.SearchgitTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchgitTextBox.Font = Stylings.FormHeadingProperites.SearchTextBoxFont;
            this.SearchgitTextBox.IncrementStep = 1D;
            this.SearchgitTextBox.InputDataType = GIT.Winform.Controls.gitTextBox.DataType.Text;
            this.SearchgitTextBox.isRequired = false;
            this.SearchgitTextBox.isUseCurrentStyle = true;
            this.SearchgitTextBox.Location = new System.Drawing.Point(45, 2);
            this.SearchgitTextBox.MaximumValue = null;
            this.SearchgitTextBox.MinimumValue = null;
            this.SearchgitTextBox.Name = "SearchgitTextBox";
            this.SearchgitTextBox.NonEditable = false;
            this.SearchgitTextBox.OnEnterNextControl = null;
            this.SearchgitTextBox.onFocusBackGround = System.Drawing.Color.Purple;
            this.SearchgitTextBox.onFocusColor = System.Drawing.Color.White;
            this.SearchgitTextBox.onFocusFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SearchgitTextBox.onLostBackGround = System.Drawing.Color.Silver;
            this.SearchgitTextBox.onLostColor = System.Drawing.Color.White;
            this.SearchgitTextBox.onLostFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SearchgitTextBox.Size = new System.Drawing.Size(232, 26);
            this.SearchgitTextBox.TabIndex = 2;
            // 
            // gitFormHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlHeader);
            this.Name = "gitFormHeader";
            this.Size = new System.Drawing.Size(800, 30);
            this.pnlHeader.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSearch;
        protected internal System.Windows.Forms.Button cmdMinimuze;
        private gitTextBox SearchgitTextBox;
        private System.Windows.Forms.Button cmdSearch;
        protected internal System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdHeadingButton;
        protected internal System.Windows.Forms.Label lblHeading;
    }
}
