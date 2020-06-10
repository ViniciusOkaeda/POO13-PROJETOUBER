using System.Threading;
using System;
namespace AULA14PROJETOUBER
{
    public class Cartao : Conta
    {
        public float numero = 9894757212341234;
        public string titular = "Vinicius Okaeda";
        public string bandeira = "MasterCard";
        public string cvv = "334";

        public string Cadastrar(){
            return "Cadastro em andamento...";
            Thread.Sleep(5000);
            Console.Clear();
        }

        public string ExcluirCartao(){
            return "Cartão cadastrado excluido";
        }
    }
}