
namespace Aula_14_05_Interfaces
{
    interface IMeioTransporte
    {
        int Velocidade { get; set; }
        void Acelerar();
        void Desacelerar();

        string ImprimirInfo();


    }
}
