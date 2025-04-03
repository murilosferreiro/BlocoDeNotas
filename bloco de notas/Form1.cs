using System.Diagnostics;

namespace bloco_de_notas
{
    public partial class Form1 : Form
    {
        string nomearq = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nomearq = openFileDialog1.FileName;
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nomearq = saveFileDialog1.FileName;
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            }
        }

        private void salvarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (nomearq != "")
            {

                File.WriteAllText(nomearq, textBox1.Text);
            }
            else
            {
                salvarToolStripMenuItem_Click(sender, e);
            }
        }

        private void substituirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2(this);
            F2.ShowDialog();
        }

        private void pesquisarNaInternetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.google.com/search?q=" + textBox1.SelectedText,
                UseShellExecute = true
            });
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.SelectedText) == false)
            {
                Clipboard.SetText(textBox1.SelectedText);
            }

        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int pos = textBox1.SelectionStart;
            Apagar();
            textBox1.Text = textBox1.Text.Insert(textBox1.SelectionStart, Clipboard.GetText());
            textBox1.SelectionStart = pos;
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiarToolStripMenuItem_Click(sender, e);
            Apagar();

        }

        private void Apagar()
        {
            int pos = textBox1.SelectionStart;
            int tamanho = textBox1.SelectionLength;
            textBox1.Text = textBox1.Text.Remove(pos, tamanho);
            textBox1.SelectionStart = pos;
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apagar();
        }
    }
}
