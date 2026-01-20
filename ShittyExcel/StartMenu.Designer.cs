namespace ShittyExcel
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Internet_Properties;
            pictureBox1.Location = new Point(32, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(356, 135);
            label1.TabIndex = 1;
            label1.Text = "Excel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 121);
            label2.Name = "label2";
            label2.Size = new Size(289, 54);
            label2.TabIndex = 2;
            label2.Text = "Shit Edition™";
            // 
            // button1
            // 
            button1.BackColor = Color.Khaki;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(523, 223);
            button1.Name = "button1";
            button1.Size = new Size(251, 37);
            button1.TabIndex = 3;
            button1.Text = "New  project";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Khaki;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(523, 266);
            button2.Name = "button2";
            button2.Size = new Size(251, 37);
            button2.TabIndex = 4;
            button2.Text = "Open  project";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Khaki;
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(523, 309);
            button3.Name = "button3";
            button3.Size = new Size(251, 37);
            button3.TabIndex = 5;
            button3.Text = "About";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Khaki;
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(523, 352);
            button4.Name = "button4";
            button4.Size = new Size(251, 37);
            button4.TabIndex = 6;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(555, 413);
            label3.Name = "label3";
            label3.Size = new Size(219, 28);
            label3.TabIndex = 7;
            label3.Text = "Megamer Office© 2026";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.List_File;
            pictureBox2.Location = new Point(539, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(235, 218);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // StartMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
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
            Name = "StartMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartMenu";
            MouseDown += StartMenu_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
        private PictureBox pictureBox2;
    }
}