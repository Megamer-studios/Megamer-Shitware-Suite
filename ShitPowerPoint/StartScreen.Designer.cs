namespace ShitPowerPoint
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            label3 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(562, 418);
            label3.Name = "label3";
            label3.Size = new Size(219, 28);
            label3.TabIndex = 16;
            label3.Text = "Megamer Office© 2026";
            // 
            // button4
            // 
            button4.BackColor = Color.DeepSkyBlue;
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(530, 357);
            button4.Name = "button4";
            button4.Size = new Size(251, 37);
            button4.TabIndex = 15;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(530, 314);
            button3.Name = "button3";
            button3.Size = new Size(251, 37);
            button3.TabIndex = 14;
            button3.Text = "About";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(530, 271);
            button2.Name = "button2";
            button2.Size = new Size(251, 37);
            button2.TabIndex = 13;
            button2.Text = "Open  project";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(530, 228);
            button1.Name = "button1";
            button1.Size = new Size(251, 37);
            button1.TabIndex = 12;
            button1.Text = "New  project";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 126);
            label2.Name = "label2";
            label2.Size = new Size(289, 54);
            label2.TabIndex = 11;
            label2.Text = "Shit Edition™";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 14);
            label1.Name = "label1";
            label1.Size = new Size(682, 135);
            label1.TabIndex = 10;
            label1.Text = "PowerPoint";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Display;
            pictureBox1.Location = new Point(36, 207);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StartScreen";
            Text = "StartScreen";
            MouseDown += StartScreen_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}