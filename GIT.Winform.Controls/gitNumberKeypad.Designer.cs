namespace GIT.Winform.Controls
{
    partial class gitNumberKeypad
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
            this.gbFooter = new System.Windows.Forms.GroupBox();
            this.cmdEnter = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdBackspace = new System.Windows.Forms.Button();
            this.gbShorts = new System.Windows.Forms.GroupBox();
            this.cmdNum50 = new System.Windows.Forms.Button();
            this.cmdNum30 = new System.Windows.Forms.Button();
            this.cmdNum20 = new System.Windows.Forms.Button();
            this.cmdNum10 = new System.Windows.Forms.Button();
            this.gbNumbers = new System.Windows.Forms.GroupBox();
            this.cmdNum9 = new System.Windows.Forms.Button();
            this.cmdNum6 = new System.Windows.Forms.Button();
            this.cndNum00 = new System.Windows.Forms.Button();
            this.cmdNum3 = new System.Windows.Forms.Button();
            this.cmdNum8 = new System.Windows.Forms.Button();
            this.cmdNum5 = new System.Windows.Forms.Button();
            this.cmdNum2 = new System.Windows.Forms.Button();
            this.cmdNumPoint = new System.Windows.Forms.Button();
            this.cmdNum0 = new System.Windows.Forms.Button();
            this.cmdNum7 = new System.Windows.Forms.Button();
            this.cmdNum4 = new System.Windows.Forms.Button();
            this.cmdNum1 = new System.Windows.Forms.Button();
            this.gbFooter.SuspendLayout();
            this.gbShorts.SuspendLayout();
            this.gbNumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFooter
            // 
            this.gbFooter.Controls.Add(this.cmdEnter);
            this.gbFooter.Controls.Add(this.cmdClear);
            this.gbFooter.Controls.Add(this.cmdBackspace);
            this.gbFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbFooter.Location = new System.Drawing.Point(0, 208);
            this.gbFooter.Name = "gbFooter";
            this.gbFooter.Size = new System.Drawing.Size(250, 52);
            this.gbFooter.TabIndex = 4;
            this.gbFooter.TabStop = false;
            // 
            // cmdEnter
            // 
            this.cmdEnter.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources.ok;
            this.cmdEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdEnter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cmdEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdEnter.Location = new System.Drawing.Point(162, 9);
            this.cmdEnter.Name = "cmdEnter";
            this.cmdEnter.Size = new System.Drawing.Size(84, 43);
            this.cmdEnter.TabIndex = 2;
            this.cmdEnter.UseVisualStyleBackColor = true;
            this.cmdEnter.Click += new System.EventHandler(this.cmdEnter_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources.Cancel;
            this.cmdClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cmdClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdClear.Location = new System.Drawing.Point(6, 9);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(54, 43);
            this.cmdClear.TabIndex = 3;
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdBackspace
            // 
            this.cmdBackspace.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources.backspace;
            this.cmdBackspace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBackspace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdBackspace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cmdBackspace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdBackspace.Location = new System.Drawing.Point(72, 9);
            this.cmdBackspace.Name = "cmdBackspace";
            this.cmdBackspace.Size = new System.Drawing.Size(84, 43);
            this.cmdBackspace.TabIndex = 2;
            this.cmdBackspace.UseVisualStyleBackColor = true;
            this.cmdBackspace.Click += new System.EventHandler(this.cmdBackspace_Click);
            // 
            // gbShorts
            // 
            this.gbShorts.Controls.Add(this.cmdNum50);
            this.gbShorts.Controls.Add(this.cmdNum30);
            this.gbShorts.Controls.Add(this.cmdNum20);
            this.gbShorts.Controls.Add(this.cmdNum10);
            this.gbShorts.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbShorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbShorts.Location = new System.Drawing.Point(188, 0);
            this.gbShorts.Name = "gbShorts";
            this.gbShorts.Size = new System.Drawing.Size(62, 208);
            this.gbShorts.TabIndex = 5;
            this.gbShorts.TabStop = false;
            // 
            // cmdNum50
            // 
            this.cmdNum50.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources._50;
            this.cmdNum50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNum50.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdNum50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cmdNum50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdNum50.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdNum50.Location = new System.Drawing.Point(4, 159);
            this.cmdNum50.Name = "cmdNum50";
            this.cmdNum50.Size = new System.Drawing.Size(54, 43);
            this.cmdNum50.TabIndex = 3;
            this.cmdNum50.UseVisualStyleBackColor = true;
            this.cmdNum50.Click += new System.EventHandler(this.cmdNum50_Click);
            // 
            // cmdNum30
            // 
            this.cmdNum30.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources._30;
            this.cmdNum30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNum30.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdNum30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cmdNum30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdNum30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdNum30.Location = new System.Drawing.Point(4, 113);
            this.cmdNum30.Name = "cmdNum30";
            this.cmdNum30.Size = new System.Drawing.Size(54, 43);
            this.cmdNum30.TabIndex = 3;
            this.cmdNum30.UseVisualStyleBackColor = true;
            this.cmdNum30.Click += new System.EventHandler(this.cmdNum30_Click);
            // 
            // cmdNum20
            // 
            this.cmdNum20.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources._20;
            this.cmdNum20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNum20.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdNum20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cmdNum20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdNum20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdNum20.Location = new System.Drawing.Point(4, 66);
            this.cmdNum20.Name = "cmdNum20";
            this.cmdNum20.Size = new System.Drawing.Size(54, 43);
            this.cmdNum20.TabIndex = 3;
            this.cmdNum20.UseVisualStyleBackColor = true;
            this.cmdNum20.Click += new System.EventHandler(this.cmdNum20_Click);
            // 
            // cmdNum10
            // 
            this.cmdNum10.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources._10;
            this.cmdNum10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNum10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdNum10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cmdNum10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdNum10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdNum10.Location = new System.Drawing.Point(4, 19);
            this.cmdNum10.Name = "cmdNum10";
            this.cmdNum10.Size = new System.Drawing.Size(54, 43);
            this.cmdNum10.TabIndex = 3;
            this.cmdNum10.UseVisualStyleBackColor = true;
            this.cmdNum10.Click += new System.EventHandler(this.cmdNum10_Click);
            // 
            // gbNumbers
            // 
            this.gbNumbers.Controls.Add(this.cmdNum9);
            this.gbNumbers.Controls.Add(this.cmdNum6);
            this.gbNumbers.Controls.Add(this.cndNum00);
            this.gbNumbers.Controls.Add(this.cmdNum3);
            this.gbNumbers.Controls.Add(this.cmdNum8);
            this.gbNumbers.Controls.Add(this.cmdNum5);
            this.gbNumbers.Controls.Add(this.cmdNum2);
            this.gbNumbers.Controls.Add(this.cmdNumPoint);
            this.gbNumbers.Controls.Add(this.cmdNum0);
            this.gbNumbers.Controls.Add(this.cmdNum7);
            this.gbNumbers.Controls.Add(this.cmdNum4);
            this.gbNumbers.Controls.Add(this.cmdNum1);
            this.gbNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNumbers.Location = new System.Drawing.Point(0, 0);
            this.gbNumbers.Name = "gbNumbers";
            this.gbNumbers.Size = new System.Drawing.Size(188, 208);
            this.gbNumbers.TabIndex = 6;
            this.gbNumbers.TabStop = false;
            // 
            // cmdNum9
            // 
            this.cmdNum9.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources._9;
            this.cmdNum9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNum9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdNum9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cmdNum9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdNum9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdNum9.Location = new System.Drawing.Point(126, 113);
            this.cmdNum9.Name = "cmdNum9";
            this.cmdNum9.Size = new System.Drawing.Size(54, 43);
            this.cmdNum9.TabIndex = 1;
            this.cmdNum9.UseVisualStyleBackColor = true;
            this.cmdNum9.Click += new System.EventHandler(this.cmdNum9_Click);
            // 
            // cmdNum6
            // 
            this.cmdNum6.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources._6;
            this.cmdNum6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNum6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdNum6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cmdNum6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdNum6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdNum6.Location = new System.Drawing.Point(125, 66);
            this.cmdNum6.Name = "cmdNum6";
            this.cmdNum6.Size = new System.Drawing.Size(54, 43);
            this.cmdNum6.TabIndex = 1;
            this.cmdNum6.UseVisualStyleBackColor = true;
            this.cmdNum6.Click += new System.EventHandler(this.cmdNum6_Click);
            // 
            // cndNum00
            // 
            this.cndNum00.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources._00;
            this.cndNum00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cndNum00.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cndNum00.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cndNum00.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cndNum00.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cndNum00.Location = new System.Drawing.Point(125, 159);
            this.cndNum00.Name = "cndNum00";
            this.cndNum00.Size = new System.Drawing.Size(54, 43);
            this.cndNum00.TabIndex = 3;
            this.cndNum00.UseVisualStyleBackColor = true;
            this.cndNum00.Click += new System.EventHandler(this.cndNum00_Click);
            // 
            // cmdNum3
            // 
            this.cmdNum3.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources._3;
            this.cmdNum3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNum3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdNum3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cmdNum3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdNum3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdNum3.Location = new System.Drawing.Point(125, 19);
            this.cmdNum3.Name = "cmdNum3";
            this.cmdNum3.Size = new System.Drawing.Size(54, 43);
            this.cmdNum3.TabIndex = 1;
            this.cmdNum3.UseVisualStyleBackColor = true;
            this.cmdNum3.Click += new System.EventHandler(this.cmdNum3_Click);
            // 
            // cmdNum8
            // 
            this.cmdNum8.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources._8;
            this.cmdNum8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNum8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdNum8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cmdNum8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdNum8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdNum8.Location = new System.Drawing.Point(66, 113);
            this.cmdNum8.Name = "cmdNum8";
            this.cmdNum8.Size = new System.Drawing.Size(54, 43);
            this.cmdNum8.TabIndex = 2;
            this.cmdNum8.UseVisualStyleBackColor = true;
            this.cmdNum8.Click += new System.EventHandler(this.cmdNum8_Click);
            // 
            // cmdNum5
            // 
            this.cmdNum5.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources._5;
            this.cmdNum5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNum5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdNum5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cmdNum5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdNum5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdNum5.Location = new System.Drawing.Point(65, 66);
            this.cmdNum5.Name = "cmdNum5";
            this.cmdNum5.Size = new System.Drawing.Size(54, 43);
            this.cmdNum5.TabIndex = 2;
            this.cmdNum5.UseVisualStyleBackColor = true;
            this.cmdNum5.Click += new System.EventHandler(this.cmdNum5_Click);
            // 
            // cmdNum2
            // 
            this.cmdNum2.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources._2;
            this.cmdNum2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNum2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdNum2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cmdNum2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdNum2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdNum2.Location = new System.Drawing.Point(65, 19);
            this.cmdNum2.Name = "cmdNum2";
            this.cmdNum2.Size = new System.Drawing.Size(54, 43);
            this.cmdNum2.TabIndex = 2;
            this.cmdNum2.UseVisualStyleBackColor = true;
            this.cmdNum2.Click += new System.EventHandler(this.cmdNum2_Click);
            // 
            // cmdNumPoint
            // 
            this.cmdNumPoint.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources.dot;
            this.cmdNumPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNumPoint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdNumPoint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cmdNumPoint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdNumPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdNumPoint.Location = new System.Drawing.Point(65, 159);
            this.cmdNumPoint.Name = "cmdNumPoint";
            this.cmdNumPoint.Size = new System.Drawing.Size(54, 43);
            this.cmdNumPoint.TabIndex = 3;
            this.cmdNumPoint.UseVisualStyleBackColor = true;
            this.cmdNumPoint.Click += new System.EventHandler(this.cmdNumPoint_Click);
            // 
            // cmdNum0
            // 
            this.cmdNum0.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources._0;
            this.cmdNum0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNum0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdNum0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cmdNum0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdNum0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdNum0.Location = new System.Drawing.Point(6, 159);
            this.cmdNum0.Name = "cmdNum0";
            this.cmdNum0.Size = new System.Drawing.Size(54, 43);
            this.cmdNum0.TabIndex = 3;
            this.cmdNum0.UseVisualStyleBackColor = true;
            this.cmdNum0.Click += new System.EventHandler(this.cmdNum0_Click);
            // 
            // cmdNum7
            // 
            this.cmdNum7.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources._7;
            this.cmdNum7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNum7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdNum7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cmdNum7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdNum7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdNum7.Location = new System.Drawing.Point(6, 113);
            this.cmdNum7.Name = "cmdNum7";
            this.cmdNum7.Size = new System.Drawing.Size(54, 43);
            this.cmdNum7.TabIndex = 3;
            this.cmdNum7.UseVisualStyleBackColor = true;
            this.cmdNum7.Click += new System.EventHandler(this.cmdNum7_Click);
            // 
            // cmdNum4
            // 
            this.cmdNum4.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources._4;
            this.cmdNum4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNum4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdNum4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cmdNum4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdNum4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdNum4.Location = new System.Drawing.Point(5, 66);
            this.cmdNum4.Name = "cmdNum4";
            this.cmdNum4.Size = new System.Drawing.Size(54, 43);
            this.cmdNum4.TabIndex = 3;
            this.cmdNum4.UseVisualStyleBackColor = true;
            this.cmdNum4.Click += new System.EventHandler(this.cmdNum4_Click);
            // 
            // cmdNum1
            // 
            this.cmdNum1.BackgroundImage = global::GIT.Winform.Controls.Properties.Resources._1;
            this.cmdNum1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNum1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdNum1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cmdNum1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cmdNum1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdNum1.Location = new System.Drawing.Point(5, 19);
            this.cmdNum1.Name = "cmdNum1";
            this.cmdNum1.Size = new System.Drawing.Size(54, 43);
            this.cmdNum1.TabIndex = 3;
            this.cmdNum1.UseVisualStyleBackColor = true;
            this.cmdNum1.Click += new System.EventHandler(this.cmdNum1_Click);
            // 
            // gitNumberKeypad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.gbNumbers);
            this.Controls.Add(this.gbShorts);
            this.Controls.Add(this.gbFooter);
            this.Name = "gitNumberKeypad";
            this.Size = new System.Drawing.Size(250, 260);
            this.gbFooter.ResumeLayout(false);
            this.gbShorts.ResumeLayout(false);
            this.gbNumbers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFooter;
        private System.Windows.Forms.GroupBox gbShorts;
        private System.Windows.Forms.GroupBox gbNumbers;
        public System.Windows.Forms.Button cmdEnter;
        public System.Windows.Forms.Button cmdNum9;
        public System.Windows.Forms.Button cmdNum6;
        public System.Windows.Forms.Button cmdNum3;
        public System.Windows.Forms.Button cmdBackspace;
        public System.Windows.Forms.Button cmdNum8;
        public System.Windows.Forms.Button cmdNum5;
        public System.Windows.Forms.Button cmdNum2;
        public System.Windows.Forms.Button cmdNum0;
        public System.Windows.Forms.Button cmdNum7;
        public System.Windows.Forms.Button cmdNum4;
        public System.Windows.Forms.Button cmdNum1;
        public System.Windows.Forms.Button cmdNum50;
        public System.Windows.Forms.Button cmdNum30;
        public System.Windows.Forms.Button cmdNum20;
        public System.Windows.Forms.Button cmdNum10;
        public System.Windows.Forms.Button cmdClear;
        public System.Windows.Forms.Button cndNum00;
        public System.Windows.Forms.Button cmdNumPoint;

    }
}
