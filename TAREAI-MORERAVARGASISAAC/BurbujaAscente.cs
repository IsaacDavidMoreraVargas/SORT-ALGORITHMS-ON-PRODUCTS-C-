using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREAI_MORERAVARGASISAAC
{
    class BurbujaAscente
    {

        public void BurbujaOrdenarAscendente(int[] preciolista, string[] nombrelista)//funcion metodo burbuja que recibe parametros
        {

            for (int a = 1; a < nombrelista.Length; a++)
            {
                int temporalprecio = preciolista[a];
                string temporalnombre = nombrelista[a];

                for (int b = nombrelista.Length - 1; b >= a; b--)
                {
                    if (preciolista[b - 1] > preciolista[b])
                    {
                        temporalprecio = preciolista[b - 1];
                        temporalnombre = nombrelista[b - 1];
                        preciolista[b - 1] = preciolista[b];
                        nombrelista[b - 1] = nombrelista[b];
                        preciolista[b] = temporalprecio;
                        nombrelista[b] = temporalnombre;
                    }
                }

            }

            Console.Clear();
            Console.WriteLine("SE FINALIZO AL ORDENAR LA LISTA DE MENOR A MAYOR\nPRESIONE UNA TECLA PARA SEGUIR");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
