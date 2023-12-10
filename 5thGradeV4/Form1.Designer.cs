namespace _5thGradeV4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Translator = new Button();
            inputNumber = new TextBox();
            fromSS = new TextBox();
            toSS = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Disket Mono", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 104);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 18);
            label1.TabIndex = 0;
            label1.Text = "your number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Disket Mono", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 165);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 1;
            label2.Text = "from ss";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Disket Mono", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(59, 226);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 18);
            label3.TabIndex = 2;
            label3.Text = "into ss";
            // 
            // Translator
            // 
            Translator.BackColor = Color.White;
            Translator.BackgroundImage = (Image)resources.GetObject("Translator.BackgroundImage");
            Translator.BackgroundImageLayout = ImageLayout.None;
            Translator.FlatStyle = FlatStyle.Popup;
            Translator.Font = new Font("Disket Mono", 8F, FontStyle.Bold, GraphicsUnit.Point);
            Translator.ForeColor = Color.White;
            Translator.Location = new Point(21, 430);
            Translator.Margin = new Padding(4, 3, 4, 3);
            Translator.Name = "Translator";
            Translator.Size = new Size(156, 26);
            Translator.TabIndex = 3;
            Translator.Text = "Translate";
            Translator.UseVisualStyleBackColor = false;
            Translator.Click += Translator_Click;
            // 
            // inputNumber
            // 
            inputNumber.BackColor = Color.FromArgb(71, 71, 88);
            inputNumber.BorderStyle = BorderStyle.None;
            inputNumber.Location = new Point(13, 74);
            inputNumber.Margin = new Padding(4, 3, 4, 3);
            inputNumber.Name = "inputNumber";
            inputNumber.Size = new Size(176, 17);
            inputNumber.TabIndex = 4;
            inputNumber.TextChanged += inputNumber_TextChanged;
            // 
            // fromSS
            // 
            fromSS.BackColor = Color.FromArgb(71, 71, 88);
            fromSS.BorderStyle = BorderStyle.None;
            fromSS.Location = new Point(13, 135);
            fromSS.Margin = new Padding(4, 3, 4, 3);
            fromSS.Name = "fromSS";
            fromSS.Size = new Size(176, 17);
            fromSS.TabIndex = 5;
            fromSS.TextChanged += fromSS_TextChanged;
            // 
            // toSS
            // 
            toSS.BackColor = Color.FromArgb(71, 71, 88);
            toSS.BorderStyle = BorderStyle.None;
            toSS.Location = new Point(13, 195);
            toSS.Margin = new Padding(4, 3, 4, 3);
            toSS.Name = "toSS";
            toSS.Size = new Size(176, 17);
            toSS.TabIndex = 6;
            toSS.TextChanged += toSS_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(51, 52, 76);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(544, 320);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 17);
            textBox1.TabIndex = 7;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(71, 71, 88);
            label4.Font = new Font("Disket Mono", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(438, 320);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 18);
            label4.TabIndex = 8;
            label4.Text = "РЕЗУЛЬТАТ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 52, 76);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(fromSS);
            panel1.Controls.Add(inputNumber);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Translator);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(toSS);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 473);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(37, 37);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(438, 30);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(381, 235);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1007, 473);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Font = new Font("Disket Mono", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "5th Grade Calculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button Translator;
        private TextBox inputNumber;
        private TextBox fromSS;
        private TextBox toSS;
        private TextBox textBox1;
        private Label label4;
        private Panel panel1;
        private Button button1;
        private TextBox textBox2;
    }
}