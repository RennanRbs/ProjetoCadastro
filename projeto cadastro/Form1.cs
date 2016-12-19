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

           // bolsa.ReceberNome("Rennan Rebouças");
            //bolsa.ReceberMatricula(20162015020458);
            //bolsa.ReceberTelefoneCel(999305878);
            //bolsa.ReceberTelefoneFixo("nada");
            //bolsa.Receberbairro("Guararapes");
            //bolsa.ReceberCpf(00000000000);
            //bolsa.ReceberRg(0000000000);
            //bolsa.ReceberCep(60123456);
            //bolsa.ReceberEndereço("Porto das dunas n100 ");
                
           // MessageBox.Show("Nome do Bolsista: " + bolsa.Nome ,"Cadastro Aluno");
            //MessageBox.Show("RG do Bolsista: " + bolsa.RG, "Cadastro Aluno");
            //MessageBox.Show("CPF do Bolsista: " + bolsa.CPF, "Cadastro Aluno");
            //MessageBox.Show("endereço do Bolsista: " + bolsa.Endereço, "Cadastro Aluno");
            //MessageBox.Show("Cep do Bolsista: " + bolsa.Cep, "Cadastro Aluno");
            //MessageBox.Show(" matricula do Bolsista: " + bolsa.Matricula, "Cadastro Aluno");
            //MessageBox.Show("telefone Celular do Bolsista: " + bolsa.Celular, "Cadastro Aluno");
            //MessageBox.Show("   telefone fixo do Bolsista: " + bolsa.Telefone, "Cadastro Aluno");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Arquivo;
            Stream saida = File.Open("entrada.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida);
            escritor.Write("ID LIT:@ ");
            escritor.WriteLine(entradaid.Text);
            escritor.Write("Nome:@ ");
            escritor.WriteLine(entradanome.Text);
            escritor.Write("Matrícula:@ ");
            escritor.WriteLine(entradamatricula.Text);
            escritor.Write("Endereço:@ ");
            escritor.WriteLine(entradaendereço.Text);
            escritor.Write("Bairro:@ ");
            escritor.WriteLine(entradabairro.Text);
            
            escritor.Close();
            saida.Close();
            Arquivo = entradaid.Text;

            MessageBox.Show("Bolsista Salvo ");
            File.Copy("entrada.txt", "C:\\Users\\Rennan\\Desktop\\Alunos cadastro\\"+Arquivo + ".txt" );
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            string Arquivo;
            Arquivo = entradaid.Text;
            if (File.Exists("C:\\Users\\Rennan\\Desktop\\Alunos cadastro\\" + Arquivo + ".txt"))
            {
                StreamReader sr = new StreamReader("C:\\Users\\Rennan\\Desktop\\Alunos cadastro\\" + Arquivo + ".txt");
                string[] linhas = new string[10];
                

                for (int i =0;i<5;i++) {
                    linhas[i] = sr.ReadLine();}

                sr.Close();
                entradamatricula.Clear();
                entradamatricula.AppendText(linhas[2]);
                entradaendereço.AppendText(linhas[3]);
                entradanome.AppendText(linhas[1]);
                entradabairro.AppendText(linhas[4]) ;


                MessageBox.Show("bolsista encontrado");
                // entradanome.AppendText(Arquivo) ;
                //entradanome.AppendText("C:\\Users\\Rennan\\Desktop\\Alunos cadastro\\" + Arquivo + ".txt");
              
                //entrada.Close();
               // leitor.Close();

            }
            else { MessageBox.Show("Bolsista  Não encotrado"); }
        }

        private void entradaid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
