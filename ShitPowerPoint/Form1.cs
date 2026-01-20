namespace ShitPowerPoint
{
    public partial class Form1 : Form
    {
        List<PictureBox> images = new List<PictureBox>();
        bool DeleteMode = false;
        public Form1(string fileloc)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(fileloc)) { 
                string base64 = File.ReadAllText(fileloc);
                byte[] data = Convert.FromBase64String(base64);
                using (MemoryStream ms = new MemoryStream(data))
                {
                    using (BinaryReader reader = new BinaryReader(ms))
                    {
                        int count = reader.ReadInt32();
                        images.Clear();
                        flowLayoutPanel1.Controls.Clear();
                        for (int i = 0; i < count; i++)
                        {
                            int imgLength = reader.ReadInt32();
                            byte[] imgBytes = reader.ReadBytes(imgLength);
                            using (MemoryStream imgStream = new MemoryStream(imgBytes))
                            {
                                PictureBox pb = new PictureBox();
                                pb.Image = Image.FromStream(imgStream);
                                pb.SizeMode = PictureBoxSizeMode.Zoom;
                                pb.Height = 100;
                                pb.Width = 100;
                                pb.MouseClick += FocusOnMe;
                                images.Add(pb);
                                flowLayoutPanel1.Controls.Add(pb);
                            }
                        }
                    }
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in ofd.FileNames)
                {
                    PictureBox pb = new PictureBox();
                    pb.Image = Image.FromFile(file);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Height = 100;
                    pb.Width = 100;
                    pb.MouseClick += FocusOnMe;
                    images.Add(pb);
                    flowLayoutPanel1.Controls.Add(pb);
                }




            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMode = !DeleteMode;
            if (DeleteMode)
            {
                deleteToolStripMenuItem.Text = "Exit Delete Mode";
                foreach (var img in images)
                {
                    img.Cursor = Cursors.Cross;
                    img.Click += Img_Click;
                }
            }
            else
            {
                deleteToolStripMenuItem.Text = "Delete";
                foreach (var img in images)
                {
                    img.Cursor = Cursors.Default;
                    img.Click -= Img_Click;
                }
            }
        }

        private void Img_Click(object? sender, EventArgs e)
        {
            if (DeleteMode && sender is PictureBox pb)
            {
                flowLayoutPanel1.Controls.Remove(pb);
                images.Remove(pb);
                deleteToolStripMenuItem.Text = "Delete";
                foreach (var img in images)
                {
                    img.Cursor = Cursors.Default;
                    img.Click -= Img_Click;
                }
                pb.Dispose();

            }
        }
        private void FocusOnMe(object? sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pictureBox1.Image = pb.Image;
            }
        }

        private void fullscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (images.Count != 0)
            {
                Presentation pres = new Presentation(images, true);
                pres.ShowDialog();
            }

        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (images.Count != 0)
            {
                Presentation pres = new Presentation(images, false);
                pres.ShowDialog();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (images.Count != 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "ShitPowerPoint Presentation|*.spp";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    byte[] data;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (BinaryWriter writer = new BinaryWriter(ms))
                        {
                            writer.Write(images.Count);
                            foreach (var img in images)
                            {
                                using (MemoryStream imgStream = new MemoryStream())
                                {
                                    img.Image.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png);
                                    byte[] imgBytes = imgStream.ToArray();
                                    writer.Write(imgBytes.Length);
                                    writer.Write(imgBytes);
                                }
                            }
                        }
                        data = ms.ToArray();
                        string base64 = Convert.ToBase64String(data);
                        File.WriteAllText(sfd.FileName, base64);
                    }
                   

                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ShitPowerPoint Presentation|*.spp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                string base64 = File.ReadAllText(ofd.FileName);
                byte[] data = Convert.FromBase64String(base64);
                using (MemoryStream ms = new MemoryStream(data))
                {
                    using (BinaryReader reader = new BinaryReader(ms))
                    {
                        int count = reader.ReadInt32();
                        images.Clear();
                        flowLayoutPanel1.Controls.Clear();
                        for (int i = 0; i < count; i++)
                        {
                            int imgLength = reader.ReadInt32();
                            byte[] imgBytes = reader.ReadBytes(imgLength);
                            using (MemoryStream imgStream = new MemoryStream(imgBytes))
                            {
                                PictureBox pb = new PictureBox();
                                pb.Image = Image.FromStream(imgStream);
                                pb.SizeMode = PictureBoxSizeMode.Zoom;
                                pb.Height = 100;
                                pb.Width = 100;
                                pb.MouseClick += FocusOnMe;
                                images.Add(pb);
                                flowLayoutPanel1.Controls.Add(pb);
                            }
                        }
                    }
                }
            }
        }
    }
}
