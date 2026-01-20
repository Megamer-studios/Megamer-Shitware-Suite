using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShittyExcel
{
    public partial class TextInput : Form
    {

        public string InputText;
        public TextInput(string form, string label)
        {
            InitializeComponent();
            this.Text = form;
            this.label1.Text = label;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.InputText = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TextInput_Load(object sender, EventArgs e)
        {

        }
    }
}
