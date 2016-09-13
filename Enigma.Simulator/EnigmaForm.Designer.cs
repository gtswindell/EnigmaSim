namespace Enigma.Simulator
{
    partial class EnigmaForm
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
            this.reflectorName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.slowName = new System.Windows.Forms.ComboBox();
            this.middleName = new System.Windows.Forms.ComboBox();
            this.fastName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.slowStart = new System.Windows.Forms.ComboBox();
            this.middleStart = new System.Windows.Forms.ComboBox();
            this.fastStart = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reflectorName
            // 
            this.reflectorName.FormattingEnabled = true;
            this.reflectorName.Location = new System.Drawing.Point(12, 41);
            this.reflectorName.Name = "reflectorName";
            this.reflectorName.Size = new System.Drawing.Size(135, 21);
            this.reflectorName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reflector";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // slowName
            // 
            this.slowName.FormattingEnabled = true;
            this.slowName.Location = new System.Drawing.Point(153, 41);
            this.slowName.Name = "slowName";
            this.slowName.Size = new System.Drawing.Size(121, 21);
            this.slowName.TabIndex = 2;
            // 
            // middleName
            // 
            this.middleName.FormattingEnabled = true;
            this.middleName.Location = new System.Drawing.Point(280, 41);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(121, 21);
            this.middleName.TabIndex = 3;
            // 
            // fastName
            // 
            this.fastName.FormattingEnabled = true;
            this.fastName.Location = new System.Drawing.Point(407, 41);
            this.fastName.Name = "fastName";
            this.fastName.Size = new System.Drawing.Size(121, 21);
            this.fastName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Slow Wheel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Middle Wheel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fast Wheel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Start Position";
            // 
            // slowStart
            // 
            this.slowStart.FormattingEnabled = true;
            this.slowStart.Location = new System.Drawing.Point(153, 68);
            this.slowStart.Name = "slowStart";
            this.slowStart.Size = new System.Drawing.Size(50, 21);
            this.slowStart.TabIndex = 9;
            // 
            // middleStart
            // 
            this.middleStart.FormattingEnabled = true;
            this.middleStart.Location = new System.Drawing.Point(280, 68);
            this.middleStart.Name = "middleStart";
            this.middleStart.Size = new System.Drawing.Size(50, 21);
            this.middleStart.TabIndex = 10;
            // 
            // fastStart
            // 
            this.fastStart.FormattingEnabled = true;
            this.fastStart.Location = new System.Drawing.Point(407, 68);
            this.fastStart.Name = "fastStart";
            this.fastStart.Size = new System.Drawing.Size(50, 21);
            this.fastStart.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Input";
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(18, 148);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(256, 95);
            this.inputText.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Encode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(280, 148);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(256, 95);
            this.outputText.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Output";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Set Wheels";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EnigmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 279);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fastStart);
            this.Controls.Add(this.middleStart);
            this.Controls.Add(this.slowStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fastName);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.slowName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reflectorName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "EnigmaForm";
            this.Text = "Enigma Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox reflectorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox slowName;
        private System.Windows.Forms.ComboBox middleName;
        private System.Windows.Forms.ComboBox fastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox slowStart;
        private System.Windows.Forms.ComboBox middleStart;
        private System.Windows.Forms.ComboBox fastStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}

