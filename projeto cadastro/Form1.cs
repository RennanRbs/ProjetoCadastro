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
using System.Data.SqlClient;
using System.Data.Sql;

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

            SqlConnection comando = new SqlConnection("Data Source=JARVIS-RENNAN;Initial Catalog=Projetocadastro;Integrated Security=True");
            string pessoa = "INSER INTO Pessoa(Nome,Cpf,Celular,Email)VALUES(@nome,@cpf,@celular,@email)";
            string bolsista = "INSERT INTO Bolsista(Endereço,Bairro,Rg,Cep.Telefone,Curso,Matricula)VALUES(@endereço,@bairro,@rg,@cep,@telefone,@curso,@matriculaq)";



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
                

            }
            else { MessageBox.Show("Bolsista  Não encotrado"); }
        }

        private void entradaid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
