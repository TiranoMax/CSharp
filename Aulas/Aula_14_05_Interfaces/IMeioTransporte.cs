﻿
namespace Aula_14_05_Interfaces
{
    interface IMeioTransporte
    {
        int Velocidade { get; set; }
        string  Modelo { get; set; }
        void Acelerar();
        void Desacelerar();

        string ImprimirInfo();


    }
}
