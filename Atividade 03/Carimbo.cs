using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_03
{
    class Carimbo:Interacao
    {
        private string cor;
        private string texto;
        private int carga;

        public Carimbo(string TTexto, string CCor, int CCarga, int ent2)
        {
            if ( ent2 == 1)
            {
                Usar();
            }

            if ( ent2 == 2)
            {
                Carregar(CCor, CCarga);
            }

            if ( ent2 == 3)
            {
                TrocarCor( CCor);
            }

            if ( ent2 == 4)
            {
                TrocarTexto(TTexto);
            }
        }

        private string Cor
        {
            get { return cor; }
            set { cor = value;  }
        }
        private string Texto
        {
            get { return texto;  }
            set { texto = value;  }
        }
        private int Carga
        {
            get { return carga; }
            set { carga = value; }
        }

        public void Usar()
        {
            if (carga >= 1)
            {
                if (!String.IsNullOrEmpty(Texto))
                {
                    if (!String.IsNullOrEmpty(Cor))
                    {
                        Console.Write("(" + Texto + ") na cor " + Cor);
                        carga--;
                    }
                    else
                    {
                        Console.Write("Impossível Carimbar - [Sem Cor] ");
                    }
                }
                else
                {
                    Console.Write("Impossível Carimbar - [Sem Texto]");
                }
            }
            else
            {
                Console.Write("Impossível Carimbar - [Sem Carga]");
            }
        }
        public void Carregar(string CCor, int CCarga)
        {
            TrocarCor(CCor);
            if ((CCarga < 1 && CCarga > 10) && ((Carga + CCarga) > 10))
            {
                Console.WriteLine("Carga atual: [" + Carga + "] - Carga deve estar entre 1 e 10.");
            }
            else
            {
                this.Carga = CCarga;
            }
        }
        public void TrocarCor(string CCor)
        {
            if (CCor == Cor)
            {
                Console.Write("Carimbo já se encontra com essa cor.");
            }
            else
            {
               this.Cor = CCor;
            }
        }
        public void TrocarTexto(string TTexto)
        {
            if (TTexto == Texto)
            {
                Console.Write("Carimbo já se encontra com esse texto.");
            }
            else
            {
                this.Texto = TTexto;
            }
        }
    }
}