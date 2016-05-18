namespace assistant_of_the_player
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btViewFile = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tbhW = new System.Windows.Forms.TrackBar();
            this.tbvH = new System.Windows.Forms.TrackBar();
            this.lWidHeight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDop = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cbFontSize = new System.Windows.Forms.ComboBox();
            this.cbFonts = new System.Windows.Forms.ComboBox();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.btSave = new System.Windows.Forms.Button();
            this.cbMultyImage = new System.Windows.Forms.CheckBox();
            this.nudValue2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbhW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbvH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(58, 10);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(411, 20);
            this.tbFilePath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Файл:";
            // 
            // btViewFile
            // 
            this.btViewFile.Location = new System.Drawing.Point(630, 8);
            this.btViewFile.Name = "btViewFile";
            this.btViewFile.Size = new System.Drawing.Size(75, 23);
            this.btViewFile.TabIndex = 2;
            this.btViewFile.Text = "Обзор";
            this.btViewFile.UseVisualStyleBackColor = true;
            this.btViewFile.Click += new System.EventHandler(this.btViewFile_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pbImage.Location = new System.Drawing.Point(58, 92);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(647, 249);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 3;
            this.pbImage.TabStop = false;
            // 
            // tbhW
            // 
            this.tbhW.Location = new System.Drawing.Point(58, 37);
            this.tbhW.Name = "tbhW";
            this.tbhW.Size = new System.Drawing.Size(647, 45);
            this.tbhW.TabIndex = 4;
            this.tbhW.Scroll += new System.EventHandler(this.tbhW_Scroll);
            // 
            // tbvH
            // 
            this.tbvH.Location = new System.Drawing.Point(7, 92);
            this.tbvH.Maximum = 0;
            this.tbvH.Name = "tbvH";
            this.tbvH.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbvH.Size = new System.Drawing.Size(45, 249);
            this.tbvH.TabIndex = 5;
            this.tbvH.Scroll += new System.EventHandler(this.tbvH_Scroll);
            // 
            // lWidHeight
            // 
            this.lWidHeight.AutoSize = true;
            this.lWidHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lWidHeight.Location = new System.Drawing.Point(3, 37);
            this.lWidHeight.Name = "lWidHeight";
            this.lWidHeight.Size = new System.Drawing.Size(44, 20);
            this.lWidHeight.TabIndex = 6;
            this.lWidHeight.Text = "0 / 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цифра:";
            // 
            // cbDop
            // 
            this.cbDop.AutoSize = true;
            this.cbDop.Location = new System.Drawing.Point(228, 349);
            this.cbDop.Name = "cbDop";
            this.cbDop.Size = new System.Drawing.Size(106, 17);
            this.cbDop.TabIndex = 9;
            this.cbDop.Text = "Дополнительно";
            this.cbDop.UseVisualStyleBackColor = true;
            this.cbDop.CheckedChanged += new System.EventHandler(this.cbDop_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(340, 349);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Часть";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(340, 373);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Эпизод";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(340, 396);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(32, 17);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "#";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Цвет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbFontSize
            // 
            this.cbFontSize.FormattingEnabled = true;
            this.cbFontSize.Items.AddRange(new object[] {
            "72",
            "100",
            "125",
            "150",
            "175",
            "200",
            "250",
            "300",
            "400",
            "800"});
            this.cbFontSize.Location = new System.Drawing.Point(58, 373);
            this.cbFontSize.Name = "cbFontSize";
            this.cbFontSize.Size = new System.Drawing.Size(49, 21);
            this.cbFontSize.TabIndex = 14;
            this.cbFontSize.Text = "72";
            this.cbFontSize.SelectedIndexChanged += new System.EventHandler(this.cbFontSize_SelectedIndexChanged);
            // 
            // cbFonts
            // 
            this.cbFonts.FormattingEnabled = true;
            this.cbFonts.Location = new System.Drawing.Point(114, 373);
            this.cbFonts.Name = "cbFonts";
            this.cbFonts.Size = new System.Drawing.Size(121, 21);
            this.cbFonts.TabIndex = 15;
            this.cbFonts.Text = "Arial";
            this.cbFonts.SelectedIndexChanged += new System.EventHandler(this.cbFonts_SelectedIndexChanged);
            // 
            // nudValue
            // 
            this.nudValue.Location = new System.Drawing.Point(58, 348);
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(164, 20);
            this.nudValue.TabIndex = 16;
            this.nudValue.ValueChanged += new System.EventHandler(this.nudValue_ValueChanged);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(630, 384);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 17;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbMultyImage
            // 
            this.cbMultyImage.AutoSize = true;
            this.cbMultyImage.Location = new System.Drawing.Point(541, 349);
            this.cbMultyImage.Name = "cbMultyImage";
            this.cbMultyImage.Size = new System.Drawing.Size(85, 17);
            this.cbMultyImage.TabIndex = 18;
            this.cbMultyImage.Text = "Несколько:";
            this.cbMultyImage.UseVisualStyleBackColor = true;
            this.cbMultyImage.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nudValue2
            // 
            this.nudValue2.Enabled = false;
            this.nudValue2.Location = new System.Drawing.Point(663, 350);
            this.nudValue2.Name = "nudValue2";
            this.nudValue2.Size = new System.Drawing.Size(42, 20);
            this.nudValue2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(632, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "До:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 419);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudValue2);
            this.Controls.Add(this.cbMultyImage);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.cbFonts);
            this.Controls.Add(this.cbFontSize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cbDop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lWidHeight);
            this.Controls.Add(this.tbvH);
            this.Controls.Add(this.tbhW);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btViewFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Асистент игрока";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbhW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbvH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btViewFile;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TrackBar tbhW;
        private System.Windows.Forms.TrackBar tbvH;
        private System.Windows.Forms.Label lWidHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbDop;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbFontSize;
        private System.Windows.Forms.ComboBox cbFonts;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.CheckBox cbMultyImage;
        private System.Windows.Forms.NumericUpDown nudValue2;
        private System.Windows.Forms.Label label2;
    }
}

