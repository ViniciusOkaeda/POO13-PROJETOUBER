using System;
namespace AULA14PROJETOUBER
{
    public class Usuario : Passageiro
    {
 // Propriedade resumida
        public string Nome { get; set; }

        private string loginAdm = "vinicius@adm.com";
        private string senhaAdm = "123";
        private string loginPass = "vinicius@gmail.com";
        private string senhaPass = "123";
        private string loginMotorista = "vinicius@uber.com";
        private string senhaMotorista = "123";


        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; } 
        public string TipoAcesso { get; set; }

        public bool LoginAdm(string loginAdm, string senhaAdm){
            if( this.loginAdm == loginAdm && this.senhaAdm == senhaAdm ){
                TokenLogin = "uy23gyu42guy23g4yu23g4uy324g23uyg48234t";
                return true;
            }
            return false;
        }
                public bool LoginPass(string loginPass, string senhaPass){
            if( this.loginPass == loginPass && this.senhaPass == senhaPass ){
                TokenLogin = "uy23gyu42guy23g4yu23g4uy324g23uyg48234t";
                return true;
            }
            return false;
        }        
        public bool LoginMotorista(string loginMotorista, string senhaMotorista){
            if( this.loginMotorista == loginMotorista && this.senhaMotorista == senhaMotorista ){
                TokenLogin = "uy23gyu42guy23g4yu23g4uy324g23uyg48234t";
                return true;
            }
            return false;
        }



        public string Logout(){
            TokenLogin = "";
            return "Obrigado por usar nosso sistema de transporte!" ;

        }


    }
}