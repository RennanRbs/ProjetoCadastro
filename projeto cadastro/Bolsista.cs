using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_cadastro
{
    class Bolsista
    {
        public string IdLit { get; set; }
        public string Nome { get; set; }
        public double Matricula { get; set; }
        public string Telefone { get; set; }
        public int Celular { get; set; }
        public String Endereço { get; set; }
        public String Bairro { get; set; }
        public int Cep { get; set; }
        public int RG { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public int DataDENAsc { set; get; }
        public string Curso { get; set; }
        //////////////////////metodos para receber dados do bolsista///////////////////////////////////////
        public void ReceberDataDENacs(int datadeNasc) { this.DataDENAsc = datadeNasc;}

        public void ReceberCurso(string curso) { this.Curso = curso; }

        public void ReceberEmail(string email){ this.Email = email;}

        public void ReceberIdLit(string idlit) { this.IdLit = idlit; }

        public void ReceberNome(string nome){this.Nome = nome;}

        public void ReceberCpf(int cpf){this.CPF = cpf;}

        public void ReceberRg(int rg){this.RG = rg;}

        public void ReceberMatricula(double matricula) {this.Matricula = matricula;}

        public void ReceberCep(int cep){this.Cep = cep;}

        public void Receberbairro(string bairro){this.Bairro = bairro;}

        public void ReceberEndereço(string endereço){this.Endereço = endereço;}

        public void ReceberTelefoneCel(int celular) { this.Celular = celular; }

        public void ReceberTelefoneFixo(string telefone){this.Telefone = telefone;}

///////////////////////////////////////////////////////////////////////////////////////////////
    }
}
