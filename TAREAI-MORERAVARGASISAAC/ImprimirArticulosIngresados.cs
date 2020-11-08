using System;


namespace TAREAI_MORERAVARGASISAAC
{
    class ImprimirArticulosIngresados
    {
        
        public void ImprimirArticulosIngresado(int[] temppreciolista, string[] tempnombrelista)//funcion metodo imprimir de articulos ordenados que recibe parametros
        {
            Console.Clear();
            for (int banderaImprimir = 0; banderaImprimir < tempnombrelista.Length; banderaImprimir++)
            {
                Console.WriteLine("Posicion en lista, Nombre: " + banderaImprimir + "\nProducto: " + tempnombrelista[banderaImprimir] + " \nPrecio anual: " + temppreciolista[banderaImprimir] + "\n\n");
            }

            Console.WriteLine("AQUI TERMINA LA IMPRESION\nPRESIONE UNA TECLA PARA SEGUIR");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
