using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula08_JSON.Controller;
using Aula08_JSON.Model;

namespace Aula08_JSON
{
    public partial class Form1 : Form
    {
        private ControllerCliente cc = new ControllerCliente();
        public Form1()
        {
            InitializeComponent();
            AtualizarListar();
            dgv_Mostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void AtualizarListar()
        {
            List<Cliente> clientes = cc.CarregarDados();
            dgv_Mostrar.DataSource = null;
            dgv_Mostrar.DataSource = clientes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string nome = txt_Nome.Text;
            string email = txt_Email.Text;
            int idade = int.Parse(txt_Idade.Text);
            cc.CadastrarCliente(nome, email, idade);
            AtualizarListar();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            AtualizarListar();
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dgv_Mostrar.SelectedRows[0];
            int id = Convert.ToInt32(linhaSelecionada.Cells[0].Value.ToString());
            MessageBox.Show( cc.RemoverLista(id));
            AtualizarListar();
        }

        private void dgv_Mostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
