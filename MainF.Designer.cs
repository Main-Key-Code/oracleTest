namespace OracleTest
{
    partial class MainF
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
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(37, 23);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(111, 28);
            button1.TabIndex = 0;
            button1.Text = "Connetion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(37, 101);
            richTextBox1.Margin = new Padding(4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(943, 399);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 26);
            textBox1.TabIndex = 2;
            textBox1.Text = "192.168.0.103";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(232, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 26);
            textBox2.TabIndex = 2;
            textBox2.Text = "1521";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(433, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 26);
            textBox3.TabIndex = 2;
            textBox3.Text = "orcl";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(629, 58);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(177, 26);
            textBox4.TabIndex = 2;
            textBox4.Text = "KORIFOODADM";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(812, 58);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(177, 26);
            textBox5.TabIndex = 2;
            textBox5.Text = "KORIFOODADM";
            // 
            // button2
            // 
            button2.Location = new Point(184, 23);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(174, 28);
            button2.TabIndex = 0;
            button2.Text = "Terminate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MainF
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 540);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "MainF";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button2;
    }
}
