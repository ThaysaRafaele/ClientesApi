using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ListarTodos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Clientes.ObterClientes();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            var cliente = new Clientes();

            if (TxtId.Text == null || TxtId.Text == string.Empty)
            {
                //Console.WriteLine("Você deve informar um Id!");
                MessageBox.Show("Você deve informar um Id!");
            }
            else if (TxtNome.Text == null || TxtNome.Text == string.Empty)
            {
                //Console.WriteLine("Você deve informar um Nome!");
                MessageBox.Show("Você deve informar o Nome!");
            }
            else if (TxtRazao.Text == null || TxtRazao.Text == string.Empty)
            {
                //Console.WriteLine("Você deve informar um Nome!");
                MessageBox.Show("Você deve informar a Razão Social!");
            }
            else
            {
                cliente.Id = Convert.ToInt32("0" + TxtId.Text);
                cliente.Nome = TxtNome.Text;
                cliente.Razao = TxtRazao.Text;
                cliente.Inclusao = Convert.ToDateTime(TxtInclusao.Text);
                cliente.Ativo = checkAtivo.Checked;

                cliente.Editar(cliente);

                MessageBox.Show("Alterado com sucesso!");
            }
        }

        private void Incluir_Click(object sender, EventArgs e)
        {
            var cliente = new Clientes();

            if (TxtId.Text == null || TxtId.Text == string.Empty)
            {
                //Console.WriteLine("Você deve informar um Id!");
                MessageBox.Show("Você deve informar um Id!");
            }
            else if (TxtNome.Text == null || TxtNome.Text == string.Empty)
            {
                //Console.WriteLine("Você deve informar um Nome!");
                MessageBox.Show("Você deve informar o Nome!");
            }
            else if (TxtRazao.Text == null || TxtRazao.Text == string.Empty)
            {
                //Console.WriteLine("Você deve informar um Nome!");
                MessageBox.Show("Você deve informar a Razão Social!");
            }
            else
            {
                cliente.Id = Convert.ToInt32("0" + TxtId.Text);
                cliente.Nome = TxtNome.Text;
                cliente.Razao = TxtRazao.Text;
                cliente.Inclusao = Convert.ToDateTime(TxtInclusao.Text);
                cliente.Ativo = checkAtivo.Checked;

                cliente.Incluir(cliente);

                MessageBox.Show("Incluído com sucesso!");
            }
        }

        private void checkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Inclusao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            var cliente = new Clientes();

            if (TxtId.Text == null || TxtId.Text == string.Empty)
            {
                //Console.WriteLine("Você deve informar um Id para busca!");
                MessageBox.Show("Você deve informar um Id para busca!");
            }
            else
            {
                cliente = cliente.Buscar(Convert.ToInt32(TxtId.Text)); //o TxtId é o Id recebido no campo de texto, como string. Por isso, a conversão para int

                TxtId.Text = cliente.Id.ToString();
                TxtNome.Text = cliente.Nome;
                TxtRazao.Text = cliente.Razao;
                TxtInclusao.Text = cliente.Inclusao.ToString();
                checkAtivo.Checked = cliente.Ativo;
            }

        }

        private void Excluir_Click(object sender, EventArgs e)
        {

        }
    }
}
