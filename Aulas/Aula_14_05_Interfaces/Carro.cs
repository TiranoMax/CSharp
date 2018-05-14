using System;


namespace Aula_14_05_Interfaces
{
    class Carro : IMeioTransporte
    {
        public int Velocidade { get; set; }
        //chave para objeto Marca
        public int MarcaID { get; set; }

        //propriedade de navegacao

        public virtual Marca _Marca { get; set; }

        public Carro()
        {
            Velocidade = 0;
        }

        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Desacelerar()
        {
            Velocidade -= 5;
        }

        public string ImprimirInfo()
        {
            return "Carro, Velocidade atual: " + Velocidade;
        }
    }
}
