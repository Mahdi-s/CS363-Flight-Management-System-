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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.case1Button = new System.Windows.Forms.Button();
            this.case2Button = new System.Windows.Forms.Button();
            this.case3Button = new System.Windows.Forms.Button();
            this.case4Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.topographicChecked = new System.Windows.Forms.CheckBox();
            this.airplaneInfoTitleText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(624, 450);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // case1Button
            // 
            this.case1Button.Location = new System.Drawing.Point(630, 161);
            this.case1Button.Name = "case1Button";
            this.case1Button.Size = new System.Drawing.Size(75, 23);
            this.case1Button.TabIndex = 2;
            this.case1Button.Text = "Case 1";
            this.case1Button.UseVisualStyleBackColor = true;
            // 
            // case2Button
            // 
            this.case2Button.Location = new System.Drawing.Point(713, 161);
            this.case2Button.Name = "case2Button";
            this.case2Button.Size = new System.Drawing.Size(75, 23);
            this.case2Button.TabIndex = 3;
            this.case2Button.Text = "Case 2";
            this.case2Button.UseVisualStyleBackColor = true;
            // 
            // case3Button
            // 
            this.case3Button.Location = new System.Drawing.Point(630, 202);
            this.case3Button.Name = "case3Button";
            this.case3Button.Size = new System.Drawing.Size(75, 23);
            this.case3Button.TabIndex = 4;
            this.case3Button.Text = "Case 3";
            this.case3Button.UseVisualStyleBackColor = true;
            // 
            // case4Button
            // 
            this.case4Button.Location = new System.Drawing.Point(713, 202);
            this.case4Button.Name = "case4Button";
            this.case4Button.Size = new System.Drawing.Size(75, 23);
            this.case4Button.TabIndex = 5;
            this.case4Button.Text = "Case 4";
            this.case4Button.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(623, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "NextGen ATC";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // topographicChecked
            // 
            this.topographicChecked.AutoSize = true;
            this.topographicChecked.BackColor = System.Drawing.Color.Black;
            this.topographicChecked.ForeColor = System.Drawing.Color.White;
            this.topographicChecked.Location = new System.Drawing.Point(653, 87);
            this.topographicChecked.Name = "topographicChecked";
            this.topographicChecked.Size = new System.Drawing.Size(110, 21);
            this.topographicChecked.TabIndex = 7;
            this.topographicChecked.Text = "Topographic";
            this.topographicChecked.UseVisualStyleBackColor = false;
            // 
            // airplaneInfoTitleText
            // 
            this.airplaneInfoTitleText.BackColor = System.Drawing.Color.Black;
            this.airplaneInfoTitleText.ForeColor = System.Drawing.Color.White;
            this.airplaneInfoTitleText.Location = new System.Drawing.Point(623, 297);
            this.airplaneInfoTitleText.Name = "airplaneInfoTitleText";
            this.airplaneInfoTitleText.Size = new System.Drawing.Size(175, 22);
            this.airplaneInfoTitleText.TabIndex = 8;
            this.airplaneInfoTitleText.Text = "Airplane Information";
            this.airplaneInfoTitleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.airplaneInfoTitleText);
            this.Controls.Add(this.topographicChecked);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.case1Button);
            this.Controls.Add(this.case4Button);
            this.Controls.Add(this.case3Button);
            this.Controls.Add(this.case2Button);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RADAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button case1Button;
        private System.Windows.Forms.Button case2Button;
        private System.Windows.Forms.Button case3Button;
        private System.Windows.Forms.Button case4Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox topographicChecked;
        private System.Windows.Forms.TextBox airplaneInfoTitleText;
    }
}

