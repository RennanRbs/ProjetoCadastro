using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bolsista bolsa = new Bolsista();

            bolsa.ReceberNome("Rennan Rebouças");
            bolsa.ReceberMatricula(20162015020458);
            bolsa.ReceberTelefoneCel(999305878);
            bolsa.ReceberTelefoneFixo("nada");
            bolsa.Receberbairro("Guararapes");
            bolsa.ReceberCpf(00000000000);
            bolsa.ReceberRg(0000000000);
            bolsa.ReceberCep(60123456);
            bolsa.ReceberEndereço("Porto das dunas n100 ");

            MessageBox.Show("Nome do Bolsista: " + bolsa.Nome ,"Cadastro Aluno");
            MessageBox.Show("RG do Bolsista: " + bolsa.RG, "Cadastro Aluno");
            MessageBox.Show("CPF do Bolsista: " + bolsa.CPF, "Cadastro Aluno");
            MessageBox.Show("endereço do Bolsista: " + bolsa.Endereço, "Cadastro Aluno");
            MessageBox.Show("Cep do Bolsista: " + bolsa.Cep, "Cadastro Aluno");
            MessageBox.Show(" matricula do Bolsista: " + bolsa.Matricula, "Cadastro Aluno");
            MessageBox.Show("telefone Celular do Bolsista: " + bolsa.Celular, "Cadastro Aluno");
            MessageBox.Show("   telefone fixo do Bolsista: " + bolsa.Telefone, "Cadastro Aluno");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
