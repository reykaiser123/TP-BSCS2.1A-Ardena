namespace WordGuessing
{
    partial class Label1
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
            WordIdentifier = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            label2 = new Label();
            button2 = new Button();
            cheat = new Button();
            label3 = new Label();
            listBox2 = new ListBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Font = new Font("Segoe UI Light", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(296, 284);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 0;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // WordIdentifier
            // 
            WordIdentifier.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WordIdentifier.ForeColor = Color.Violet;
            WordIdentifier.Location = new Point(296, 183);
            WordIdentifier.Name = "WordIdentifier";
            WordIdentifier.Size = new Size(256, 54);
            WordIdentifier.TabIndex = 1;
            WordIdentifier.Text = "Label1";
            WordIdentifier.TextAlign = ContentAlignment.MiddleCenter;
            WordIdentifier.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Light", 14F);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(296, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 39);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(609, 200);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(343, 364);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(464, 284);
            button2.Name = "button2";
            button2.Size = new Size(94, 38);
            button2.TabIndex = 4;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // cheat
            // 
            cheat.BackColor = Color.DarkSeaGreen;
            cheat.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cheat.ForeColor = Color.White;
            cheat.Location = new Point(380, 328);
            cheat.Name = "cheat";
            cheat.Size = new Size(94, 34);
            cheat.TabIndex = 5;
            cheat.Text = "Cheat";
            cheat.UseVisualStyleBackColor = false;
            cheat.Click += cheat_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Violet;
            label3.Location = new Point(612, 143);
            label3.Name = "label3";
            label3.Size = new Size(340, 54);
            label3.TabIndex = 6;
            label3.Text = "Wrong Attempts";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(54, 200);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(226, 364);
            listBox2.TabIndex = 7;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Violet;
            label4.Location = new Point(54, 143);
            label4.Name = "label4";
            label4.Size = new Size(226, 54);
            label4.TabIndex = 8;
            label4.Text = "cheats Notes";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightPink;
            label5.Location = new Point(160, 28);
            label5.Name = "label5";
            label5.Size = new Size(661, 54);
            label5.TabIndex = 9;
            label5.Text = "Word Guessing Game";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1032, 608);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(label3);
            Controls.Add(cheat);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(WordIdentifier);
            Controls.Add(button1);
            Name = "Label1";
            Text = "WordGuessing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label WordIdentifier;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label2;
        private Button button2;
        private Button cheat;
        private Label label3;
        private ListBox listBox2;
        private Label label4;
        private Label label5;
    }
}
