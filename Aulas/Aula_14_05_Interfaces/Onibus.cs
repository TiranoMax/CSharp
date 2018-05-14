using System;


namespace Aula_14_05_Interfaces
{
    class Onibus : IMeioTransporte
    {
        public int Velocidade { get; set; }

        //chave para objeto Marca
        public int MarcaID { get; set; }

        //propriedade de navegacao

        public virtual Marca _Marca { get; set; }

        public void Acelerar()
        {
            Velocidade += 5;
        }

        public void Desacelerar()
        {
            Velocidade -= 3;
        }

        public string ImprimirInfo()
        {
            return "Onibus, Velocidade atual: " + Velocidade;
        }
    }
}
