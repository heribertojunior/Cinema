using System;
namespace sis
{
    public abstract class Cliente
    {
        //Classe base
        public void validarDados(){
            Console.WriteLine("Validando dados ...");
        }
        public abstract String ob();
        public virtual String dizOi(){
            return "dodizendo";
        }
        public Cliente()
        {
        }
    }
}
