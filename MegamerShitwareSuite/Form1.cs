using ShitWord;
using System.Text.Json;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace MegamerShitwareSuite
{
    public partial class Form1 : Form
    {
        bool isDeleting = false;

        public Form1(string fileloc)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(fileloc) && File.Exists(fileloc))
            {
                var json = File.ReadAllText(fileloc);
                var state = JsonConvert.DeserializeObject<FlowLayoutPanelState>(json)!;
                flowLayoutPanel1.Controls.Clear();
                foreach (var cs in state.Controls)
                {
                    var type = Type.GetType(cs.Type)!;
                    var control = (Control)Activator.CreateInstance(type)!;
                    control.Name = cs.Name;
                    control.Text = cs.Text;
                    control.Size = new Size(cs.Width, cs.Height);
                    control.BackColor = Color.FromArgb(cs.BackColorArgb);
                    control.ForeColor = Color.FromArgb(cs.ForeColorArgb);


                    if (cs.FontFamily != null)
                        control.Font = new Font(cs.FontFamily, cs.FontSize, cs.FontStyle);


                    if (control is PictureBox pb && cs.ImageBase64 != null)
                    {
                        var bytes = Convert.FromBase64String(cs.ImageBase64);
                        using var ms = new MemoryStream(bytes);
                        pb.Image = Image.FromStream(ms);
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                    }


                    if (control is RichTextBox rtb)
                    {
                        rtb.Multiline = cs.Multiline;
                        rtb.ScrollBars = cs.ScrollBars;
                        rtb.BorderStyle = cs.BorderStyle;

                        if (cs.FontFamily != null)
                            rtb.Font = new Font(cs.FontFamily, cs.FontSize, cs.FontStyle);

                        rtb.BackColor = Color.FromArgb(cs.BackColorArgb);
                        rtb.ForeColor = Color.FromArgb(cs.ForeColorArgb);
                    }
                    else
                    {
                        if (cs.FontFamily != null)
                            control.Font = new Font(cs.FontFamily, cs.FontSize, cs.FontStyle);

                        control.BackColor = Color.FromArgb(cs.BackColorArgb);
                        control.ForeColor = Color.FromArgb(cs.ForeColorArgb);
                    }

                    flowLayoutPanel1.Controls.Add(control);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void addTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBox rtb = new RichTextBox();
                rtb.Visible = true;
                rtb.Height = 100;
                rtb.Width = flowLayoutPanel1.Width - 10;
                rtb.Text = "New TextBox";
                rtb.BorderStyle = BorderStyle.None;
                rtb.Font = fontDialog.Font;

                rtb.Multiline = true;
                rtb.ScrollBars = RichTextBoxScrollBars.None;
                flowLayoutPanel1.Controls.Add(rtb);
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                ctrl.Width = flowLayoutPanel1.Width - 10;
                if (ctrl is PictureBox pb && pb.Image != null)
                {
                    pb.Height = pb.Image.Height * (flowLayoutPanel1.Width - 10) / pb.Image.Width;
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void changeTexboxFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox? selectedRtb = flowLayoutPanel1.Controls.OfType<RichTextBox>().FirstOrDefault(rtb => rtb.Focused);
            if (selectedRtb != null)
            {
                FontDialog fontDialog = new FontDialog();
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedRtb.Font = fontDialog.Font;
                }
            }
            else
            {
                MessageBox.Show("Please select a textbox to change its font.", "Font change", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void changeTextboxHeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumInput numInput = new NumInput("Change Textbox Height", "Enter new height for the selected textbox:");
            if (numInput.ShowDialog() == DialogResult.OK)
            {
                int newHeight = numInput.RsltValue;
                RichTextBox? selectedRtb = flowLayoutPanel1.Controls.OfType<RichTextBox>().FirstOrDefault(rtb => rtb.Focused);
                if (selectedRtb != null)
                {
                    selectedRtb.Height = newHeight;
                }
                else
                {
                    MessageBox.Show("Please select a textbox to change its height.", "Textbox height change", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Megamer Shit Word Files | *.msv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var state = new FlowLayoutPanelState
                {
                    Controls = flowLayoutPanel1.Controls.Cast<Control>().Select(c =>
                    {
                        string? imageBase64 = null;
                        if (c is PictureBox pb && pb.Image != null)
                        {
                            using var ms = new MemoryStream();
                            pb.Image.Save(ms, pb.Image.RawFormat);
                            imageBase64 = Convert.ToBase64String(ms.ToArray());
                        }

                        return new ControlState
                        {
                            Type = c.GetType().AssemblyQualifiedName!,
                            Name = c.Name,
                            Text = c.Text,
                            Width = c.Width,
                            Height = c.Height,
                            BackColorArgb = c.BackColor.ToArgb(),
                            ForeColorArgb = c.ForeColor.ToArgb(),
                            FontFamily = c.Font?.FontFamily.Name,
                            FontSize = c.Font?.Size ?? 8f,
                            FontStyle = c.Font?.Style ?? FontStyle.Regular,
                            ImageBase64 = imageBase64,
                            BorderStyle = c is TextBoxBase tb ? tb.BorderStyle : BorderStyle.None,
                            Multiline = c is RichTextBox rtb ? rtb.Multiline : false,
                            ScrollBars = c is RichTextBox rtb2 ? rtb2.ScrollBars : RichTextBoxScrollBars.None
                        };
                    }).ToList()
                };

                string result = JsonConvert.SerializeObject(state, Formatting.Indented);
                File.WriteAllText(saveFileDialog.FileName, result);
            }
        }

        private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox.Height = pictureBox.Image.Height * (flowLayoutPanel1.Width - 10) / pictureBox.Image.Width;
                pictureBox.Width = flowLayoutPanel1.Width - 10;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                flowLayoutPanel1.Controls.Add(pictureBox);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Megamer Shit Word Files | *.msv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var json = File.ReadAllText(openFileDialog.FileName);
                var state = JsonConvert.DeserializeObject<FlowLayoutPanelState>(json)!;

                flowLayoutPanel1.Controls.Clear();
                foreach (var cs in state.Controls)
                {
                    var type = Type.GetType(cs.Type)!;
                    var control = (Control)Activator.CreateInstance(type)!;
                    control.Name = cs.Name;
                    control.Text = cs.Text;
                    control.Size = new Size(cs.Width, cs.Height);
                    control.BackColor = Color.FromArgb(cs.BackColorArgb);
                    control.ForeColor = Color.FromArgb(cs.ForeColorArgb);


                    if (cs.FontFamily != null)
                        control.Font = new Font(cs.FontFamily, cs.FontSize, cs.FontStyle);


                    if (control is PictureBox pb && cs.ImageBase64 != null)
                    {
                        var bytes = Convert.FromBase64String(cs.ImageBase64);
                        using var ms = new MemoryStream(bytes);
                        pb.Image = Image.FromStream(ms);
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                    }


                    if (control is RichTextBox rtb)
                    {
                        rtb.Multiline = cs.Multiline;
                        rtb.ScrollBars = cs.ScrollBars;
                        rtb.BorderStyle = cs.BorderStyle;

                        if (cs.FontFamily != null)
                            rtb.Font = new Font(cs.FontFamily, cs.FontSize, cs.FontStyle);

                        rtb.BackColor = Color.FromArgb(cs.BackColorArgb);
                        rtb.ForeColor = Color.FromArgb(cs.ForeColorArgb);
                    }
                    else
                    {
                        if (cs.FontFamily != null)
                            control.Font = new Font(cs.FontFamily, cs.FontSize, cs.FontStyle);

                        control.BackColor = Color.FromArgb(cs.BackColorArgb);
                        control.ForeColor = Color.FromArgb(cs.ForeColorArgb);
                    }

                    flowLayoutPanel1.Controls.Add(control);
                }
            }
        }
        public class ControlState
        {
            public string Type { get; set; } = "";
            public string Name { get; set; } = "";

            public string? Text { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public int BackColorArgb { get; init; }
            public int ForeColorArgb { get; init; }

            public string? FontFamily { get; set; }
            public float FontSize { get; set; }
            public FontStyle FontStyle { get; set; }


            public string? ImageBase64 { get; set; }

            public BorderStyle BorderStyle { get; init; }

            public bool Multiline { get; set; }
            public RichTextBoxScrollBars ScrollBars { get; set; }
        }

        public record FlowLayoutPanelState
        {
            public List<ControlState> Controls { get; init; } = new();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            isDeleting = !isDeleting;
            if (isDeleting)
            {
                toolStripButton2.BackColor = Color.Red;
                flowLayoutPanel1.Cursor = Cursors.Cross;
                foreach (Control ctrl in flowLayoutPanel1.Controls)
                {
                    ctrl.Cursor = Cursors.Cross;
                    ctrl.MouseClick += flowLayoutPanel1_MouseClick;
                }

            }
            else
            {
                toolStripButton2.BackColor = SystemColors.Control;
                flowLayoutPanel1.Cursor = Cursors.Default;
                foreach (Control ctrl in flowLayoutPanel1.Controls)
                {
                    ctrl.Cursor = Cursors.Default;

                    ctrl.MouseClick -= flowLayoutPanel1_MouseClick;

                }

            }
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (isDeleting)
            {
                var clickedControl = flowLayoutPanel1.GetChildAtPoint(e.Location);
                if (clickedControl != null)
                {
                    flowLayoutPanel1.Controls.Remove(clickedControl);
                }
                isDeleting = false;
                toolStripButton2.BackColor = SystemColors.Control;
                flowLayoutPanel1.Cursor = Cursors.Default;
                foreach (Control ctrl in flowLayoutPanel1.Controls)
                {
                    ctrl.Cursor = Cursors.Default;
                    ctrl.MouseClick -= flowLayoutPanel1_MouseClick;

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RichTextBox? selectedRtb = flowLayoutPanel1.Controls.OfType<RichTextBox>().FirstOrDefault(rtb => rtb.Focused);
            if (selectedRtb != null)
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedRtb.ForeColor = colorDialog.Color;
                }
            }
            else
            {
                MessageBox.Show("Please select a textbox to change its colour.", "Textbox color change", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RichTextBox? selectedRtb = flowLayoutPanel1.Controls.OfType<RichTextBox>().FirstOrDefault(rtb => rtb.Focused);
            if (selectedRtb != null)
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedRtb.BackColor = colorDialog.Color;
                }
            }
            else
            {
                MessageBox.Show("Please select a textbox to change its colour.", "Textbox color change", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
