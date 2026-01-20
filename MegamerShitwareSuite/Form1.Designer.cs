namespace MegamerShitwareSuite
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowLayoutPanel1 = new FlowLayoutPanel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripSplitButton();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            toolStripSplitButton1 = new ToolStripSplitButton();
            addTextToolStripMenuItem = new ToolStripMenuItem();
            addImageToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            changeTextboxHeightToolStripMenuItem = new ToolStripMenuItem();
            changeTexboxFontToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripButton2 = new ToolStripButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(89, 31);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(609, 420);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.MouseClick += flowLayoutPanel1_MouseClick;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSplitButton1, toolStripDropDownButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem });
            toolStripButton1.Image = ShitWord.Properties.Resources.File;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(71, 24);
            toolStripButton1.Text = "File";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = ShitWord.Properties.Resources.Folder_Open;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(125, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Image = ShitWord.Properties.Resources.Folder_Closed;
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(125, 26);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { addTextToolStripMenuItem, addImageToolStripMenuItem });
            toolStripSplitButton1.Image = ShitWord.Properties.Resources.Display;
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(76, 24);
            toolStripSplitButton1.Text = "Add";
            // 
            // addTextToolStripMenuItem
            // 
            addTextToolStripMenuItem.Image = ShitWord.Properties.Resources.Manage_Your_Servers;
            addTextToolStripMenuItem.Name = "addTextToolStripMenuItem";
            addTextToolStripMenuItem.Size = new Size(166, 26);
            addTextToolStripMenuItem.Text = "Add text";
            addTextToolStripMenuItem.Click += addTextToolStripMenuItem_Click;
            // 
            // addImageToolStripMenuItem
            // 
            addImageToolStripMenuItem.Image = ShitWord.Properties.Resources.Monitor;
            addImageToolStripMenuItem.Name = "addImageToolStripMenuItem";
            addImageToolStripMenuItem.Size = new Size(166, 26);
            addImageToolStripMenuItem.Text = "Add image";
            addImageToolStripMenuItem.Click += addImageToolStripMenuItem_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { changeTextboxHeightToolStripMenuItem, changeTexboxFontToolStripMenuItem, toolStripMenuItem1 });
            toolStripDropDownButton1.Image = ShitWord.Properties.Resources.User_Personalization;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(123, 24);
            toolStripDropDownButton1.Text = "Appearance";
            // 
            // changeTextboxHeightToolStripMenuItem
            // 
            changeTextboxHeightToolStripMenuItem.Image = ShitWord.Properties.Resources.Game_Controller;
            changeTextboxHeightToolStripMenuItem.Name = "changeTextboxHeightToolStripMenuItem";
            changeTextboxHeightToolStripMenuItem.Size = new Size(247, 26);
            changeTextboxHeightToolStripMenuItem.Text = "Change Textbox Height";
            changeTextboxHeightToolStripMenuItem.Click += changeTextboxHeightToolStripMenuItem_Click;
            // 
            // changeTexboxFontToolStripMenuItem
            // 
            changeTexboxFontToolStripMenuItem.Image = ShitWord.Properties.Resources.Hearts;
            changeTexboxFontToolStripMenuItem.Name = "changeTexboxFontToolStripMenuItem";
            changeTexboxFontToolStripMenuItem.Size = new Size(247, 26);
            changeTexboxFontToolStripMenuItem.Text = "Change Texbox Font";
            changeTexboxFontToolStripMenuItem.Click += changeTexboxFontToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            toolStripMenuItem1.Image = ShitWord.Properties.Resources.Earth;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(247, 26);
            toolStripMenuItem1.Text = "Change Textbox Colour";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = ShitWord.Properties.Resources.Monitor;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(171, 26);
            toolStripMenuItem2.Text = "Foreground";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Image = ShitWord.Properties.Resources.Manage_Your_Servers;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(171, 26);
            toolStripMenuItem3.Text = "Background";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = ShitWord.Properties.Resources.Folder_Closed;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(77, 24);
            toolStripButton2.Text = "Delete";
            toolStripButton2.Click += toolStripButton2_Click_1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 24);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shitty Word";
            WindowState = FormWindowState.Maximized;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            Resize += Form1_Resize;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private ToolStrip toolStrip1;
        private ToolStripSplitButton toolStripButton1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem addTextToolStripMenuItem;
        private ToolStripMenuItem addImageToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem changeTextboxHeightToolStripMenuItem;
        private ToolStripMenuItem changeTexboxFontToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripButton toolStripButton2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}
