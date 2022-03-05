namespace GIT.WinForm.Control.Examples
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            GIT.Winform.Controls.CommonSettings.FormHeadingProperties formHeadingProperties2 = new GIT.Winform.Controls.CommonSettings.FormHeadingProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.gitTabControl1 = new GIT.Winform.Controls.gitTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gitNumberKeypad1 = new GIT.Winform.Controls.gitNumberKeypad();
            this.gitTextBox2 = new GIT.Winform.Controls.gitTextBox();
            this.gitTextBox3 = new GIT.Winform.Controls.gitTextBox();
            this.gitDateTimeMask1 = new GIT.Winform.Controls.gitDateTimeMask();
            this.gitDateTimeMask2 = new GIT.Winform.Controls.gitDateTimeMask();
            this.gitDateTimeMask3 = new GIT.Winform.Controls.gitDateTimeMask();
            this.gitDateTimePicker1 = new GIT.Winform.Controls.gitDateTimePicker();
            this.gitComboBox1 = new GIT.Winform.Controls.gitComboBox();
            this.gitRadioButton1 = new GIT.Winform.Controls.gitRadioButton();
            this.gitCheckBox1 = new GIT.Winform.Controls.gitCheckBox();
            this.gitTextBox1 = new GIT.Winform.Controls.gitTextBox();
            this.appearanceStyle1 = new GIT.Winform.Controls.AppearanceStyle();
            this.gitFormHeader1 = new GIT.Winform.Controls.gitFormHeader();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gitTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(514, 519);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(236, 20);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // gitTabControl1
            // 
            this.gitTabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.gitTabControl1.Controls.Add(this.tabPage1);
            this.gitTabControl1.Controls.Add(this.tabPage2);
            this.gitTabControl1.Location = new System.Drawing.Point(241, 294);
            this.gitTabControl1.Name = "gitTabControl1";
            this.gitTabControl1.SelectedIndex = 0;
            this.gitTabControl1.Size = new System.Drawing.Size(200, 100);
            this.gitTabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 71);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gitNumberKeypad1
            // 
            this.gitNumberKeypad1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gitNumberKeypad1.InputTextBox = this.gitTextBox2;
            this.gitNumberKeypad1.Location = new System.Drawing.Point(514, 229);
            this.gitNumberKeypad1.Name = "gitNumberKeypad1";
            this.gitNumberKeypad1.Size = new System.Drawing.Size(246, 260);
            this.gitNumberKeypad1.TabIndex = 10;
            // 
            // gitTextBox2
            // 
            this.gitTextBox2.AllowNumberIncremenent = false;
            this.gitTextBox2.IncrementStep = 1D;
            this.gitTextBox2.InputDataType = GIT.Winform.Controls.gitTextBox.DataType.Text;
            this.gitTextBox2.isRequired = false;
            this.gitTextBox2.isUseCurrentStyle = false;
            this.gitTextBox2.Location = new System.Drawing.Point(194, 35);
            this.gitTextBox2.MaximumValue = null;
            this.gitTextBox2.MinimumValue = null;
            this.gitTextBox2.Name = "gitTextBox2";
            this.gitTextBox2.NonEditable = false;
            this.gitTextBox2.OnEnterNextControl = this.gitTextBox3;
            this.gitTextBox2.onFocusBackGround = System.Drawing.Color.Empty;
            this.gitTextBox2.onFocusColor = System.Drawing.Color.Empty;
            this.gitTextBox2.onFocusFont = null;
            this.gitTextBox2.onLostBackGround = System.Drawing.Color.Empty;
            this.gitTextBox2.onLostColor = System.Drawing.Color.Empty;
            this.gitTextBox2.onLostFont = null;
            this.gitTextBox2.Size = new System.Drawing.Size(115, 20);
            this.gitTextBox2.TabIndex = 1;
            // 
            // gitTextBox3
            // 
            this.gitTextBox3.AllowNumberIncremenent = false;
            this.gitTextBox3.IncrementStep = 1D;
            this.gitTextBox3.InputDataType = GIT.Winform.Controls.gitTextBox.DataType.Number;
            this.gitTextBox3.isRequired = true;
            this.gitTextBox3.isUseCurrentStyle = true;
            this.gitTextBox3.Location = new System.Drawing.Point(350, 35);
            this.gitTextBox3.MaximumValue = null;
            this.gitTextBox3.MinimumValue = null;
            this.gitTextBox3.Name = "gitTextBox3";
            this.gitTextBox3.NonEditable = false;
            this.gitTextBox3.OnEnterNextControl = this.gitDateTimeMask1;
            this.gitTextBox3.onFocusBackGround = System.Drawing.Color.Green;
            this.gitTextBox3.onFocusColor = System.Drawing.Color.Yellow;
            this.gitTextBox3.onFocusFont = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gitTextBox3.onLostBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gitTextBox3.onLostColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gitTextBox3.onLostFont = new System.Drawing.Font("OCR-B-Seagull", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gitTextBox3.Size = new System.Drawing.Size(178, 20);
            this.gitTextBox3.TabIndex = 2;
            // 
            // gitDateTimeMask1
            // 
            this.gitDateTimeMask1.BackColor = System.Drawing.Color.Transparent;
            this.gitDateTimeMask1.CustomerDateTimeFormat = "MM/dd/yyyy";
            this.gitDateTimeMask1.DateTimeFormat = GIT.Winform.Controls.gitDateTimeMask._DateTimeFormat.Date;
            this.gitDateTimeMask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gitDateTimeMask1.isRequired = false;
            this.gitDateTimeMask1.isUseCurrentStyle = false;
            this.gitDateTimeMask1.Location = new System.Drawing.Point(44, 101);
            this.gitDateTimeMask1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gitDateTimeMask1.Name = "gitDateTimeMask1";
            this.gitDateTimeMask1.OnEnterNextControl = this.gitDateTimeMask2;
            this.gitDateTimeMask1.onFocusBackGround = System.Drawing.Color.Empty;
            this.gitDateTimeMask1.onFocusColor = System.Drawing.Color.Empty;
            this.gitDateTimeMask1.onFocusFont = null;
            this.gitDateTimeMask1.onLostBackGround = System.Drawing.Color.Empty;
            this.gitDateTimeMask1.onLostColor = System.Drawing.Color.Empty;
            this.gitDateTimeMask1.onLostFont = null;
            this.gitDateTimeMask1.Size = new System.Drawing.Size(201, 47);
            this.gitDateTimeMask1.TabIndex = 4;
            this.gitDateTimeMask1.UseCommonDateFormat = false;
            this.gitDateTimeMask1.value = new System.DateTime(2016, 4, 3, 0, 0, 0, 0);
            // 
            // gitDateTimeMask2
            // 
            this.gitDateTimeMask2.BackColor = System.Drawing.Color.Transparent;
            this.gitDateTimeMask2.CustomerDateTimeFormat = "MM/dd/yyyy";
            this.gitDateTimeMask2.DateTimeFormat = GIT.Winform.Controls.gitDateTimeMask._DateTimeFormat.Date;
            this.gitDateTimeMask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gitDateTimeMask2.isRequired = false;
            this.gitDateTimeMask2.isUseCurrentStyle = false;
            this.gitDateTimeMask2.Location = new System.Drawing.Point(44, 190);
            this.gitDateTimeMask2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gitDateTimeMask2.Name = "gitDateTimeMask2";
            this.gitDateTimeMask2.OnEnterNextControl = this.gitDateTimeMask3;
            this.gitDateTimeMask2.onFocusBackGround = System.Drawing.Color.Empty;
            this.gitDateTimeMask2.onFocusColor = System.Drawing.Color.Empty;
            this.gitDateTimeMask2.onFocusFont = null;
            this.gitDateTimeMask2.onLostBackGround = System.Drawing.Color.Empty;
            this.gitDateTimeMask2.onLostColor = System.Drawing.Color.Empty;
            this.gitDateTimeMask2.onLostFont = null;
            this.gitDateTimeMask2.Size = new System.Drawing.Size(201, 47);
            this.gitDateTimeMask2.TabIndex = 4;
            this.gitDateTimeMask2.UseCommonDateFormat = false;
            this.gitDateTimeMask2.value = new System.DateTime(2016, 4, 3, 0, 0, 0, 0);
            this.gitDateTimeMask2.Load += new System.EventHandler(this.gitDateTimeMask2_Load);
            // 
            // gitDateTimeMask3
            // 
            this.gitDateTimeMask3.BackColor = System.Drawing.Color.Transparent;
            this.gitDateTimeMask3.CustomerDateTimeFormat = "MM/dd/yyyy";
            this.gitDateTimeMask3.DateTimeFormat = GIT.Winform.Controls.gitDateTimeMask._DateTimeFormat.Date;
            this.gitDateTimeMask3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gitDateTimeMask3.isRequired = true;
            this.gitDateTimeMask3.isUseCurrentStyle = false;
            this.gitDateTimeMask3.Location = new System.Drawing.Point(381, 101);
            this.gitDateTimeMask3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gitDateTimeMask3.Name = "gitDateTimeMask3";
            this.gitDateTimeMask3.OnEnterNextControl = this.gitDateTimePicker1;
            this.gitDateTimeMask3.onFocusBackGround = System.Drawing.Color.Empty;
            this.gitDateTimeMask3.onFocusColor = System.Drawing.Color.Empty;
            this.gitDateTimeMask3.onFocusFont = null;
            this.gitDateTimeMask3.onLostBackGround = System.Drawing.Color.Empty;
            this.gitDateTimeMask3.onLostColor = System.Drawing.Color.Empty;
            this.gitDateTimeMask3.onLostFont = null;
            this.gitDateTimeMask3.Size = new System.Drawing.Size(201, 47);
            this.gitDateTimeMask3.TabIndex = 4;
            this.gitDateTimeMask3.UseCommonDateFormat = false;
            this.gitDateTimeMask3.value = new System.DateTime(2016, 4, 3, 0, 0, 0, 0);
            this.gitDateTimeMask3.Load += new System.EventHandler(this.gitDateTimeMask2_Load);
            this.gitDateTimeMask3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gitDateTimeMask3_KeyPress);
            // 
            // gitDateTimePicker1
            // 
            this.gitDateTimePicker1.Location = new System.Drawing.Point(381, 190);
            this.gitDateTimePicker1.Name = "gitDateTimePicker1";
            this.gitDateTimePicker1.OnEnterNextControl = this.gitComboBox1;
            this.gitDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.gitDateTimePicker1.TabIndex = 6;
            // 
            // gitComboBox1
            // 
            this.gitComboBox1.FormattingEnabled = true;
            this.gitComboBox1.isUseCurrentStyle = false;
            this.gitComboBox1.Location = new System.Drawing.Point(44, 257);
            this.gitComboBox1.Name = "gitComboBox1";
            this.gitComboBox1.OnEnterNextControl = this.gitRadioButton1;
            this.gitComboBox1.onFocusAutoDropDown = true;
            this.gitComboBox1.onFocusBackGround = System.Drawing.Color.Empty;
            this.gitComboBox1.onFocusColor = System.Drawing.Color.Empty;
            this.gitComboBox1.onFocusFont = null;
            this.gitComboBox1.onLostBackGround = System.Drawing.Color.Empty;
            this.gitComboBox1.onLostColor = System.Drawing.Color.Empty;
            this.gitComboBox1.onLostFont = null;
            this.gitComboBox1.Size = new System.Drawing.Size(201, 21);
            this.gitComboBox1.TabIndex = 7;
            // 
            // gitRadioButton1
            // 
            this.gitRadioButton1.AutoSize = true;
            this.gitRadioButton1.isUseCurrentStyle = false;
            this.gitRadioButton1.Location = new System.Drawing.Point(44, 294);
            this.gitRadioButton1.Name = "gitRadioButton1";
            this.gitRadioButton1.OnEnterNextControl = this.gitCheckBox1;
            this.gitRadioButton1.onFocusBackGround = System.Drawing.Color.Empty;
            this.gitRadioButton1.onFocusColor = System.Drawing.Color.Empty;
            this.gitRadioButton1.onFocusFont = null;
            this.gitRadioButton1.onLostBackGround = System.Drawing.Color.Empty;
            this.gitRadioButton1.onLostColor = System.Drawing.Color.Empty;
            this.gitRadioButton1.onLostFont = null;
            this.gitRadioButton1.Size = new System.Drawing.Size(101, 17);
            this.gitRadioButton1.TabIndex = 8;
            this.gitRadioButton1.TabStop = true;
            this.gitRadioButton1.Text = "gitRadioButton1";
            this.gitRadioButton1.UseVisualStyleBackColor = true;
            // 
            // gitCheckBox1
            // 
            this.gitCheckBox1.AutoSize = true;
            this.gitCheckBox1.isUseCurrentStyle = false;
            this.gitCheckBox1.Location = new System.Drawing.Point(44, 334);
            this.gitCheckBox1.Name = "gitCheckBox1";
            this.gitCheckBox1.OnEnterNextControl = this.gitTextBox1;
            this.gitCheckBox1.onFocusBackGround = System.Drawing.Color.Empty;
            this.gitCheckBox1.onFocusColor = System.Drawing.Color.Empty;
            this.gitCheckBox1.onFocusFont = null;
            this.gitCheckBox1.onLostBackGround = System.Drawing.Color.Empty;
            this.gitCheckBox1.onLostColor = System.Drawing.Color.Empty;
            this.gitCheckBox1.onLostFont = null;
            this.gitCheckBox1.Size = new System.Drawing.Size(92, 17);
            this.gitCheckBox1.TabIndex = 9;
            this.gitCheckBox1.Text = "gitCheckBox1";
            this.gitCheckBox1.UseVisualStyleBackColor = true;
            // 
            // gitTextBox1
            // 
            this.gitTextBox1.AllowNumberIncremenent = false;
            this.gitTextBox1.IncrementStep = 1D;
            this.gitTextBox1.InputDataType = GIT.Winform.Controls.gitTextBox.DataType.Text;
            this.gitTextBox1.isRequired = true;
            this.gitTextBox1.isUseCurrentStyle = false;
            this.gitTextBox1.Location = new System.Drawing.Point(12, 35);
            this.gitTextBox1.MaximumValue = null;
            this.gitTextBox1.MinimumValue = null;
            this.gitTextBox1.Name = "gitTextBox1";
            this.gitTextBox1.NonEditable = false;
            this.gitTextBox1.OnEnterNextControl = this.gitTextBox2;
            this.gitTextBox1.onFocusBackGround = System.Drawing.Color.Empty;
            this.gitTextBox1.onFocusColor = System.Drawing.Color.Empty;
            this.gitTextBox1.onFocusFont = null;
            this.gitTextBox1.onLostBackGround = System.Drawing.Color.Empty;
            this.gitTextBox1.onLostColor = System.Drawing.Color.Empty;
            this.gitTextBox1.onLostFont = null;
            this.gitTextBox1.Size = new System.Drawing.Size(100, 20);
            this.gitTextBox1.TabIndex = 0;
            // 
            // appearanceStyle1
            // 
            this.appearanceStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            formHeadingProperties2.HeadingBG = ((System.Drawing.Image)(resources.GetObject("formHeadingProperties2.HeadingBG")));
            formHeadingProperties2.HeadingButtonBG = ((System.Drawing.Image)(resources.GetObject("formHeadingProperties2.HeadingButtonBG")));
            formHeadingProperties2.HeadingTitleFont = new System.Drawing.Font("OCR-B-Seagull", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formHeadingProperties2.HeadingTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            formHeadingProperties2.SearchButtonBG = ((System.Drawing.Image)(resources.GetObject("formHeadingProperties2.SearchButtonBG")));
            formHeadingProperties2.SearchPanelBG = System.Drawing.Color.Lavender;
            formHeadingProperties2.SearchTextBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appearanceStyle1.FormHeadingProperties = formHeadingProperties2;
            this.appearanceStyle1.Location = new System.Drawing.Point(109, 499);
            this.appearanceStyle1.Name = "appearanceStyle1";
            this.appearanceStyle1.onFocusBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.appearanceStyle1.onFocusColor = System.Drawing.Color.Red;
            this.appearanceStyle1.onFocusFont = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appearanceStyle1.onLostBackGround = System.Drawing.Color.White;
            this.appearanceStyle1.onLostColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appearanceStyle1.onLostFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.appearanceStyle1.Size = new System.Drawing.Size(136, 55);
            this.appearanceStyle1.TabIndex = 3;
            // 
            // gitFormHeader1
            // 
            this.gitFormHeader1.BackColor = System.Drawing.Color.Transparent;
            this.gitFormHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gitFormHeader1.Heading = "Heading 1...";
            this.gitFormHeader1.Location = new System.Drawing.Point(0, 0);
            this.gitFormHeader1.Name = "gitFormHeader1";
            this.gitFormHeader1.Size = new System.Drawing.Size(821, 30);
            this.gitFormHeader1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 618);
            this.Controls.Add(this.gitFormHeader1);
            this.Controls.Add(this.gitTabControl1);
            this.Controls.Add(this.gitNumberKeypad1);
            this.Controls.Add(this.gitCheckBox1);
            this.Controls.Add(this.gitRadioButton1);
            this.Controls.Add(this.gitComboBox1);
            this.Controls.Add(this.gitDateTimePicker1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.gitDateTimeMask3);
            this.Controls.Add(this.gitDateTimeMask2);
            this.Controls.Add(this.gitDateTimeMask1);
            this.Controls.Add(this.gitTextBox3);
            this.Controls.Add(this.gitTextBox2);
            this.Controls.Add(this.gitTextBox1);
            this.Controls.Add(this.appearanceStyle1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gitTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Winform.Controls.AppearanceStyle appearanceStyle1;
        private Winform.Controls.gitTextBox gitTextBox1;
        private Winform.Controls.gitTextBox gitTextBox2;
        private Winform.Controls.gitTextBox gitTextBox3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Winform.Controls.gitDateTimeMask gitDateTimeMask1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private Winform.Controls.gitDateTimeMask gitDateTimeMask3;
        private Winform.Controls.gitDateTimeMask gitDateTimeMask2;
        private Winform.Controls.gitDateTimePicker gitDateTimePicker1;
        private Winform.Controls.gitCheckBox gitCheckBox1;
        private Winform.Controls.gitComboBox gitComboBox1;
        private Winform.Controls.gitRadioButton gitRadioButton1;
        private Winform.Controls.gitNumberKeypad gitNumberKeypad1;
        private Winform.Controls.gitTabControl gitTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Winform.Controls.gitFormHeader gitFormHeader1;
    }
}

