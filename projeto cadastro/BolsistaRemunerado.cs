using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_cadastro
{
    class BolsistaRemunerado : Bolsista
    {
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public string Projeto { get; set; }
        public string Orientador { get; set; }


        public void ReceberAgencia(int agencia){
            this.Agencia = agencia;}

        public void ReceberConta(int conta){
            this.Conta = conta;}

        public void ReceberProjeto(string projeto){
            this.Projeto = projeto;}

        public void ReceberOrientador(string orientador){
            this.Orientador = orientador;}
    }
}
