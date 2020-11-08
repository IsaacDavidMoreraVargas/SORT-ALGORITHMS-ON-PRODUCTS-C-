using System;


namespace TAREAI_MORERAVARGASISAAC
{
    class ImprimirArticulosOrdenados
    {
   
        public void ImprimirArticulosOrdenado(int[] preciolista, string[] nombrelista)//funcion metodo imprimir de articulos ordenados que recibe parametros
        {
            Console.Clear();

            for (int banderaImprimir = 0; banderaImprimir < nombrelista.Length; banderaImprimir++)
            {
                Console.WriteLine("Posicion en lista, Nombre: " + banderaImprimir + "\nProducto: " + nombrelista[banderaImprimir] + " \nPrecio anual: " + preciolista[banderaImprimir] + "\n\n");
            }

            Console.WriteLine("AQUI TERMINA LA IMPRESION\nPRESIONE UNA TECLA PARA SEGUIR");
            Console.ReadKey();
            Console.Clear();

        }

    }
}
