using System;
namespace cinema
{
    public class Vip:Ingreco
    {
        public Vip(String lugar, int sala)
        {
            this.lugar = lugar;
            this.sala = sala;
            this.valor = valor * 2;
        }
    }
}
