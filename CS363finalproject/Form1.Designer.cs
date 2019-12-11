namespace CS363finalproject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.case1Button = new System.Windows.Forms.Button();
            this.case2Button = new System.Windows.Forms.Button();
            this.case3Button = new System.Windows.Forms.Button();
            this.case4Button = new System.Windows.Forms.Button();
            this.topographicChecked = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.infoFlight = new System.Windows.Forms.Label();
            this.infoDestination = new System.Windows.Forms.Label();
            this.infoStatus = new System.Windows.Forms.Label();
            this.infoAltitude = new System.Windows.Forms.TextBox();
            this.infoSpeed = new System.Windows.Forms.TextBox();
            this.infoHeading = new System.Windows.Forms.TextBox();
            this.aircraftCount = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.emergencyLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.airplane3 = new System.Windows.Forms.PictureBox();
            this.airplane2 = new System.Windows.Forms.PictureBox();
            this.airplane1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.airplane4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelair1 = new System.Windows.Forms.Label();
            this.labelair2 = new System.Windows.Forms.Label();
            this.labelair3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.airplane3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplane2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplane4)).BeginInit();
            this.SuspendLayout();
            // 
            // case1Button
            // 
            this.case1Button.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.case1Button.Location = new System.Drawing.Point(633, 398);
            this.case1Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.case1Button.Name = "case1Button";
            this.case1Button.Size = new System.Drawing.Size(75, 23);
            this.case1Button.TabIndex = 2;
            this.case1Button.Text = "Case 1";
            this.case1Button.UseVisualStyleBackColor = true;
            this.case1Button.Click += new System.EventHandler(this.Case1Button_Click);
            // 
            // case2Button
            // 
            this.case2Button.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.case2Button.Location = new System.Drawing.Point(712, 396);
            this.case2Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.case2Button.Name = "case2Button";
            this.case2Button.Size = new System.Drawing.Size(75, 23);
            this.case2Button.TabIndex = 3;
            this.case2Button.Text = "Case 2";
            this.case2Button.UseVisualStyleBackColor = true;
            this.case2Button.Click += new System.EventHandler(this.Case2Button_Click);
            // 
            // case3Button
            // 
            this.case3Button.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.case3Button.Location = new System.Drawing.Point(633, 422);
            this.case3Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.case3Button.Name = "case3Button";
            this.case3Button.Size = new System.Drawing.Size(75, 23);
            this.case3Button.TabIndex = 4;
            this.case3Button.Text = "Case 3";
            this.case3Button.UseVisualStyleBackColor = true;
            this.case3Button.Click += new System.EventHandler(this.Case3Button_Click);
            // 
            // case4Button
            // 
            this.case4Button.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.case4Button.Location = new System.Drawing.Point(712, 422);
            this.case4Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.case4Button.Name = "case4Button";
            this.case4Button.Size = new System.Drawing.Size(75, 23);
            this.case4Button.TabIndex = 5;
            this.case4Button.Text = "Case 4";
            this.case4Button.UseVisualStyleBackColor = true;
            this.case4Button.Click += new System.EventHandler(this.Case4Button_Click);
            // 
            // topographicChecked
            // 
            this.topographicChecked.AutoSize = true;
            this.topographicChecked.BackColor = System.Drawing.Color.Black;
            this.topographicChecked.ForeColor = System.Drawing.Color.White;
            this.topographicChecked.Location = new System.Drawing.Point(653, 87);
            this.topographicChecked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topographicChecked.Name = "topographicChecked";
            this.topographicChecked.Size = new System.Drawing.Size(110, 21);
            this.topographicChecked.TabIndex = 7;
            this.topographicChecked.Text = "Topographic";
            this.topographicChecked.UseVisualStyleBackColor = false;
            this.topographicChecked.CheckedChanged += new System.EventHandler(this.TopographicChecked_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(621, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "NextGen Air Traffic Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(624, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Aircraft Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(633, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Aircraft Count:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(653, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Dec. 2, 2019";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(677, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "1:15pm";
            // 
            // infoFlight
            // 
            this.infoFlight.AutoSize = true;
            this.infoFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFlight.ForeColor = System.Drawing.Color.White;
            this.infoFlight.Location = new System.Drawing.Point(676, 180);
            this.infoFlight.Name = "infoFlight";
            this.infoFlight.Size = new System.Drawing.Size(73, 25);
            this.infoFlight.TabIndex = 22;
            this.infoFlight.Text = "AA263";
            this.infoFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoDestination
            // 
            this.infoDestination.AutoSize = true;
            this.infoDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoDestination.ForeColor = System.Drawing.Color.White;
            this.infoDestination.Location = new System.Drawing.Point(688, 204);
            this.infoDestination.Name = "infoDestination";
            this.infoDestination.Size = new System.Drawing.Size(50, 25);
            this.infoDestination.TabIndex = 23;
            this.infoDestination.Text = "AEJ";
            this.infoDestination.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoStatus
            // 
            this.infoStatus.AutoSize = true;
            this.infoStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoStatus.ForeColor = System.Drawing.Color.White;
            this.infoStatus.Location = new System.Drawing.Point(703, 229);
            this.infoStatus.Name = "infoStatus";
            this.infoStatus.Size = new System.Drawing.Size(26, 25);
            this.infoStatus.TabIndex = 24;
            this.infoStatus.Text = "A";
            this.infoStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoAltitude
            // 
            this.infoAltitude.BackColor = System.Drawing.Color.Black;
            this.infoAltitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoAltitude.ForeColor = System.Drawing.Color.White;
            this.infoAltitude.Location = new System.Drawing.Point(661, 258);
            this.infoAltitude.Margin = new System.Windows.Forms.Padding(4);
            this.infoAltitude.Name = "infoAltitude";
            this.infoAltitude.Size = new System.Drawing.Size(68, 23);
            this.infoAltitude.TabIndex = 28;
            this.infoAltitude.Text = "2000";
            this.infoAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // infoSpeed
            // 
            this.infoSpeed.BackColor = System.Drawing.Color.Black;
            this.infoSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoSpeed.ForeColor = System.Drawing.Color.White;
            this.infoSpeed.Location = new System.Drawing.Point(661, 284);
            this.infoSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.infoSpeed.Name = "infoSpeed";
            this.infoSpeed.Size = new System.Drawing.Size(68, 23);
            this.infoSpeed.TabIndex = 29;
            this.infoSpeed.Text = "185";
            this.infoSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // infoHeading
            // 
            this.infoHeading.BackColor = System.Drawing.Color.Black;
            this.infoHeading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoHeading.ForeColor = System.Drawing.Color.White;
            this.infoHeading.Location = new System.Drawing.Point(661, 310);
            this.infoHeading.Margin = new System.Windows.Forms.Padding(4);
            this.infoHeading.Name = "infoHeading";
            this.infoHeading.Size = new System.Drawing.Size(68, 23);
            this.infoHeading.TabIndex = 30;
            this.infoHeading.Text = "0";
            this.infoHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // aircraftCount
            // 
            this.aircraftCount.AutoSize = true;
            this.aircraftCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aircraftCount.ForeColor = System.Drawing.Color.White;
            this.aircraftCount.Location = new System.Drawing.Point(765, 119);
            this.aircraftCount.Name = "aircraftCount";
            this.aircraftCount.Size = new System.Drawing.Size(20, 24);
            this.aircraftCount.TabIndex = 31;
            this.aircraftCount.Text = "3";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(609, 342);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(183, 39);
            this.warningLabel.TabIndex = 32;
            this.warningLabel.Text = "WARNING";
            // 
            // emergencyLabel
            // 
            this.emergencyLabel.AutoSize = true;
            this.emergencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergencyLabel.ForeColor = System.Drawing.Color.Red;
            this.emergencyLabel.Location = new System.Drawing.Point(552, 342);
            this.emergencyLabel.Name = "emergencyLabel";
            this.emergencyLabel.Size = new System.Drawing.Size(237, 39);
            this.emergencyLabel.TabIndex = 33;
            this.emergencyLabel.Text = "EMERGENCY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(732, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "feet";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(732, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "knots";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(732, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "deg";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // airplane3
            // 
            this.airplane3.BackColor = System.Drawing.Color.Transparent;
            this.airplane3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.airplane3.Image = ((System.Drawing.Image)(resources.GetObject("airplane3.Image")));
            this.airplane3.Location = new System.Drawing.Point(147, 258);
            this.airplane3.Margin = new System.Windows.Forms.Padding(4);
            this.airplane3.Name = "airplane3";
            this.airplane3.Size = new System.Drawing.Size(47, 37);
            this.airplane3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.airplane3.TabIndex = 21;
            this.airplane3.TabStop = false;
            // 
            // airplane2
            // 
            this.airplane2.BackColor = System.Drawing.Color.Transparent;
            this.airplane2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.airplane2.Image = global::CS363finalproject.Properties.Resources.airplaneRed;
            this.airplane2.Location = new System.Drawing.Point(293, 18);
            this.airplane2.Margin = new System.Windows.Forms.Padding(4);
            this.airplane2.Name = "airplane2";
            this.airplane2.Size = new System.Drawing.Size(47, 37);
            this.airplane2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.airplane2.TabIndex = 20;
            this.airplane2.TabStop = false;
            // 
            // airplane1
            // 
            this.airplane1.BackColor = System.Drawing.Color.Transparent;
            this.airplane1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.airplane1.Image = global::CS363finalproject.Properties.Resources.airplaneWhite;
            this.airplane1.Location = new System.Drawing.Point(440, 338);
            this.airplane1.Margin = new System.Windows.Forms.Padding(4);
            this.airplane1.Name = "airplane1";
            this.airplane1.Size = new System.Drawing.Size(47, 37);
            this.airplane1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.airplane1.TabIndex = 19;
            this.airplane1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CS363finalproject.Properties.Resources.black;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(616, 450);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // airplane4
            // 
            this.airplane4.BackColor = System.Drawing.Color.Transparent;
            this.airplane4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.airplane4.Image = global::CS363finalproject.Properties.Resources.airplaneWhite;
            this.airplane4.Location = new System.Drawing.Point(414, 257);
            this.airplane4.Margin = new System.Windows.Forms.Padding(4);
            this.airplane4.Name = "airplane4";
            this.airplane4.Size = new System.Drawing.Size(44, 38);
            this.airplane4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.airplane4.TabIndex = 37;
            this.airplane4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(294, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 38;
            this.label7.Text = "AA256";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelair1
            // 
            this.labelair1.AutoSize = true;
            this.labelair1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelair1.ForeColor = System.Drawing.Color.Snow;
            this.labelair1.Location = new System.Drawing.Point(445, 119);
            this.labelair1.Name = "labelair1";
            this.labelair1.Size = new System.Drawing.Size(63, 21);
            this.labelair1.TabIndex = 39;
            this.labelair1.Text = "AA263";
            // 
            // labelair2
            // 
            this.labelair2.AutoSize = true;
            this.labelair2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelair2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelair2.Location = new System.Drawing.Point(445, 153);
            this.labelair2.Name = "labelair2";
            this.labelair2.Size = new System.Drawing.Size(63, 21);
            this.labelair2.TabIndex = 40;
            this.labelair2.Text = "SP455";
            // 
            // labelair3
            // 
            this.labelair3.AutoSize = true;
            this.labelair3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelair3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelair3.Location = new System.Drawing.Point(445, 188);
            this.labelair3.Name = "labelair3";
            this.labelair3.Size = new System.Drawing.Size(66, 21);
            this.labelair3.TabIndex = 41;
            this.labelair3.Text = "GH543";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelair3);
            this.Controls.Add(this.labelair2);
            this.Controls.Add(this.labelair1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.airplane4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emergencyLabel);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.aircraftCount);
            this.Controls.Add(this.infoHeading);
            this.Controls.Add(this.infoSpeed);
            this.Controls.Add(this.infoAltitude);
            this.Controls.Add(this.infoStatus);
            this.Controls.Add(this.infoDestination);
            this.Controls.Add(this.infoFlight);
            this.Controls.Add(this.airplane3);
            this.Controls.Add(this.airplane2);
            this.Controls.Add(this.airplane1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topographicChecked);
            this.Controls.Add(this.case1Button);
            this.Controls.Add(this.case4Button);
            this.Controls.Add(this.case3Button);
            this.Controls.Add(this.case2Button);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RADAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airplane3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplane2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplane4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button case1Button;
        private System.Windows.Forms.Button case2Button;
        private System.Windows.Forms.Button case3Button;
        private System.Windows.Forms.Button case4Button;
        private System.Windows.Forms.CheckBox topographicChecked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox airplane1;
        private System.Windows.Forms.PictureBox airplane2;
        private System.Windows.Forms.PictureBox airplane3;
        private System.Windows.Forms.Label infoFlight;
        private System.Windows.Forms.Label infoDestination;
        private System.Windows.Forms.Label infoStatus;
        private System.Windows.Forms.TextBox infoAltitude;
        private System.Windows.Forms.TextBox infoSpeed;
        private System.Windows.Forms.TextBox infoHeading;
        private System.Windows.Forms.Label aircraftCount;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label emergencyLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox airplane4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelair1;
        private System.Windows.Forms.Label labelair2;
        private System.Windows.Forms.Label labelair3;
    }
}

