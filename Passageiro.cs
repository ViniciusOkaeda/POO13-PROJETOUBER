using System;
using System.Threading;
namespace AULA14PROJETOUBER
{
    public class Passageiro : Corrida
    {
      public string SolicitarMotorista(){
            return "Procurando motorista...";
            Thread.Sleep(2000);
        }

        public bool Pagar(string statusCorrida){

            if(statusCorrida == "Finalizada"){
                return true;
            }

            return false;
        }

    }
}