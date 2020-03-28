using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int ent1;
            
            do
            {
                Console.WriteLine("----- SELECIONE A FUNÇÃO DESEJADA -----");
                Console.WriteLine("              1 - Carimbar             ");
                Console.WriteLine("              2 - Escrever             ");
                Console.WriteLine("              3 - Sair                 ");


                ent1 = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

               if ( ent1 != 3)
                {
                    Console.WriteLine("----- SELECIONE A ACAO DESEJADA -----");
                    Console.WriteLine("           1 - Usar                  ");
                    Console.WriteLine("           2 - Carregar              ");
                    Console.WriteLine("           3 - Trocar cor            ");
                    Console.WriteLine("           4 - Trocar texto          ");


                    int ent2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    string CCor = "Preto";
                    string TTexto = "Boa noite !";
                    int CCarga = 4;

                    switch (ent2)
                    {
                        case 1:
                            Console.WriteLine("Enter para carimbar.... ");
                            Console.ReadKey();
                            Console.Clear();

                            break;

                        case 2:

                            Console.WriteLine("Digite qual a quantidade de carga que deseja adicionar: ");
                            CCarga = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter para adicionar a carga.... ");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 3:

                            Console.WriteLine("Digite a cor desejada: ");
                            CCor = System.Console.ReadLine();
                            Console.WriteLine("Enter para trocar a cor.... ");
                            Console.ReadKey();
                            Console.Clear();
                            break;


                        case 4:

                            Console.WriteLine("Digite o texto desejado: ");
                            TTexto = System.Console.ReadLine();
                            Console.WriteLine("Enter para trocar o texto.... ");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                    }

                    if (ent2 == 1)
                    {
                        Carimbo car = new Carimbo(TTexto, CCor, CCarga, ent2);
                    }

                    else
                    {
                        Caneta can = new Caneta(TTexto, CCor, CCarga, ent2);
                    }
                }
                   
                                                                         
           
            } while (ent1 != 3);
            

        }
    }
}