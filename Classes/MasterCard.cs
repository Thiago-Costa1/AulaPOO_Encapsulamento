namespace Encapsulamento.Classes
{
    public class MasterCard : Cartao
    {
        private int parcelas;
        private bool limite;

        public void ExibirLimite(){
          System.Console.WriteLine(this.limite);
        } 
    }
}