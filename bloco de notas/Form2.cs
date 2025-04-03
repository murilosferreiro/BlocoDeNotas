using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bloco_de_notas
{
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2(Form1 frm)
        {
            InitializeComponent();
            this.form1 = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.textBox1.Text = form1.textBox1.Text.Replace(textBox1.Text, textBox2.Text);
        }
    }
}
