using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShitWord
{
    public partial class NumInput : Form
    {

        public int RsltValue;

        
        public NumInput(string label, string description)
        {
            InitializeComponent();
            this.label1.Text = description;
            this.Text = label;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RsltValue = (int)numericUpDown1.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
