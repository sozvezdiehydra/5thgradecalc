namespace _5thGradeV4
{
    partial class fMenu
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(71, 71, 86);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Disket Mono", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(28, 64);
            button1.Name = "button1";
            button1.Size = new Size(232, 59);
            button1.TabIndex = 0;
            button1.Text = "Default Calculator";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(71, 71, 86);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Disket Mono", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(28, 180);
            button2.Name = "button2";
            button2.Size = new Size(232, 59);
            button2.TabIndex = 1;
            button2.Text = "RIM Calculator";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(71, 71, 86);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Disket Mono", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(28, 299);
            button3.Name = "button3";
            button3.Size = new Size(232, 59);
            button3.TabIndex = 2;
            button3.Text = "sum, diff";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // fMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "fMenu";
            Text = "fMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}