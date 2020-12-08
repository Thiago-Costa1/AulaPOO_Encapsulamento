namespace Encapsulamento.Classes
{
    public class Cartao
    {
        private string numero;
        public string Numero{
            get{return numero;} // Capturar o valor
            set{numero = value;} // Definir o Valor
        }
       
        public string Bandeira{
            get{return bandeira;}
            set{bandeira = value;}
        }
        private string nomeTitular;
        public string NomeTitular{
            get{return nomeTitular;}
            set{nomeTitular = value;}
        }

          public string Token{
            get{return token;}
        }                  
        private string nome;
        private string bandeira;

        protected string token = "qwertyui";
        private string cvv;
        protected float limte = 5000;
            

            //Métodos
            public string RegistrarCompra(bool validacao){
                return "";
                
            }
         
             public string ReceberNome(string nomeDigitado){
                 return this.nomeTitular = nomeDigitado;


             }

             public void ExibirNome(){
                 System.Console.WriteLine(this.nomeTitular);
             }

            }

            }
        

