namespace _5thGradeV4
{
    partial class fRIM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRIM));
            button2 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Disket Mono", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(104, 346);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(156, 26);
            button2.TabIndex = 16;
            button2.Text = "TranslateRIM";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(71, 71, 70);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(163, 88);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(176, 20);
            textBox3.TabIndex = 15;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(71, 71, 88);
            label4.Font = new Font("Disket Mono", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(150, 313);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 18);
            label4.TabIndex = 14;
            label4.Text = "РЕЗУЛЬТАТ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(51, 52, 76);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(256, 311);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 20);
            textBox1.TabIndex = 13;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // fRIM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Name = "fRIM";
            Text = "fRIM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox1;
    }
}