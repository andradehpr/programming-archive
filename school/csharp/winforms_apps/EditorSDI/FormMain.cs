using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorSDI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        // Class assignment — SDI text editor with file menu actions.
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                File.WriteAllText(saveFileDialog1.FileName, txtEditor.Text);
            }
            else
            {
                MessageBox.Show("Não selecionou nome de ficheiro", "Oh N00b!!!!", MessageBoxButtons.OK);
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                txtEditor.Text = File.ReadAllText(openFileDialog1.FileName);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("N00b! Não existe esse ficheiro!", "Erro!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void helpMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHelp help = new FrmHelp();
            help.Show();
        }

        private void MoldarOuDesmoldarTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            txtEditor.WordWrap = !txtEditor.WordWrap;

            if (txtEditor.WordWrap)
            {
                MoldarOuDesmoldarTextoToolStripMenuItem.Text = "&Desmoldar texto";
            }
            else
            {
                MoldarOuDesmoldarTextoToolStripMenuItem.Text = "&Moldar texto";
            }
                


        }

        private void txtEditor_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Total de caracteres: {txtEditor.Text.Length}";
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Deseja mesmo sair?",
                                   "Não vás... fica!!!!",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (x != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
