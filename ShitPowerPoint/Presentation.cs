using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShitPowerPoint
{
    public partial class Presentation : Form
    {
        public List<PictureBox> Images = new List<PictureBox>();
        public int CurrentSlide = 0;
        public Presentation(List<PictureBox> images, bool Maximized)
        {
            InitializeComponent();
            Images = images;
            if (Maximized)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
            ShowSlide();
        }

        private void Presentation_Load(object sender, EventArgs e)
        {

        }

        private void Presentation_MouseClick(object sender, MouseEventArgs e)
        {

        }

        public void ShowSlide()
        {

            pictureBox1.Image = Images[CurrentSlide].Image;

        }

        public void NextSlide()
        {
            if (CurrentSlide < Images.Count - 1)
            {
                CurrentSlide++;
                ShowSlide();
            }
            else
            {
                CurrentSlide = 0;
                ShowSlide();
            }
        }
        public void PreviousSlide()
        {
            if (CurrentSlide > 0)
            {
                CurrentSlide--;
                ShowSlide();
            }
            else
            {
                CurrentSlide = 0;
                ShowSlide();
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            NextSlide();
        }

        private void Presentation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Space)
            {
                NextSlide();
            }
            else if (e.KeyCode == Keys.Left)
            {
                PreviousSlide();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
