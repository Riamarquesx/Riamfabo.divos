using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace blocoDeNotasSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Arquivo de Texto (*.txt)|*.txt";
            abrir.Title = "Abrir arquivo";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                txtConteudo.Text = File.ReadAllText(abrir.FileName);
                MessageBox.Show("Arquivo carregado com sucesso!", "Abrir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Filter = "Arquivo de Texto (*.txt)|*.txt";
            salvar.Title = "Salvar como";

            if (salvar.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(salvar.FileName, txtConteudo.Text);
                MessageBox.Show("Arquivo salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtConteudo.Clear();
        }
    }
}
