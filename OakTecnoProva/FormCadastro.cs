using OakTecnoProva.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OakTecnoProva
{
    public partial class FormCadastro : Form
    {
        List<string> disponibilidade = new List<string>();        

        private void InitializeDisp()
        {
            disponibilidade.Add("Sim");
            disponibilidade.Add("Não");
            comboBoxDisp.DataSource = disponibilidade;
        }

        public FormCadastro()
        {
            InitializeComponent();
            InitializeDisp();
        }        

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemSelecionado = comboBoxDisp.SelectedItem.ToString();
        }        

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Produto novoProduto = new Produto();
            novoProduto.Codigo = Convert.ToInt16(textBox1.Text);
        }
    }
}
