using System;
namespace cinema
{
    public class Ingreco
    {
        public String lugar { get; set; }
        public int sala { get; set; }
        public double valor { get; set; } = 12;
        public virtual void imprimeValor(){
            Console.WriteLine("VALOR DO INGRESSO: " + valor);
        }
        public Ingreco()
        {
        }
    }
}
