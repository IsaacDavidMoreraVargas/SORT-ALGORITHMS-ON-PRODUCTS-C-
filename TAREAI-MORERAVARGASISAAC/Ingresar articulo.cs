using System;
using System.Linq;


namespace TAREAI_MORERAVARGASISAAC
{
    class Ingresar_articulo
    {

        int precio=0, temporal=0;
        string nombre;


        public String[] IngresarNombreArticulos(int ubicacion, int bandera, String[] nombrelista)//array que recibe diferentes parametros para poder llenar el array de nombres productos, inicio for, fin for y array a devolver
        {
            try
            {
                for (temporal = ubicacion; temporal < bandera; temporal++)//metodo para llenar el array nombre de productos
                {
                    Console.Clear();
                    Console.WriteLine("Bienvenido al programa para introducir productos y sus precios\n");
                    Console.Clear();
                    Console.WriteLine("Por favor digite el nombre del producto: " + temporal);
                    nombre = Console.ReadLine();

                    bool esLetra = nombre.Any(char.IsLetter);//evalua si hay una letra en el nombre
                    bool esNume = nombre.Any(char.IsNumber);//evalua si hay un numero en el nombre


                    for (int comprobarnombre = 0; comprobarnombre < bandera; comprobarnombre++)//metodo para evaluar nombres repetidos
                    {
                        if (nombre == nombrelista[comprobarnombre])
                        {
                            Console.WriteLine("\nEl producto '" + nombre + "' ya esta en lista, Posicion: " + comprobarnombre + " ,no se puede anadir \nDigite un nombre adecuado o salga del programa digitando N");

                            while (nombre == nombrelista[comprobarnombre])
                             {
                                for (int comprobarnombrebucle = 0; comprobarnombrebucle < bandera; comprobarnombrebucle++)//metodo para evaluar nombres repetidos en bucle
                                {
                                    nombre = Console.ReadLine();

                                    if (nombre == "N" || nombre == "n")
                                    {
                                        Console.WriteLine("Se saldra del programa");
                                        Console.ReadKey();
                                        System.Environment.Exit(0);
                                    }

                                    Console.WriteLine("Digite de nuevo");
                                }
                             }
                        }
                    }

                    if ((esLetra == true || esNume == true) && nombre.Length <= 10)//si palabra cumple con formato y cumple con tamano de palabra anadira a array
                    {
                        nombrelista[temporal] = nombre;
                    }
                    else
                    {
                        while ((nombre.Length > 10) || (esLetra == false && esNume == false))//si no cumple con alguna condicion pedira nombre hasta que cumpla con las reglas
                        {
                            Console.Clear();
                            Console.WriteLine("1.Digito un simbolo que no son letras o numeros en el nombre \n2.Solo se permiten 10 caracteres o menos\n\nPalabra: " + nombre + " ,Cantidad:" + nombre.Length + "\nPor favor redigite la palabra numero: " + ubicacion);
                            nombre = Console.ReadLine();
                            esLetra = nombre.Any(char.IsLetter);
                            esNume = nombre.Any(char.IsNumber);
                        }

                        nombrelista[temporal] = nombre;
                    }

                }
            }
            catch (FormatException exception)//catch al no introducir numero
            {
                Console.WriteLine("Sucedio un error\nNo se digito un numero\n" + exception);
                Console.ReadKey();
            }
            catch (ArithmeticException exception)//catch al no introducir numeros
            {
                Console.WriteLine("Sucedio un error\nSe digito un numero de formato no entero\n" + exception);
                Console.ReadKey();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Sucedio un error Inesperado\n\n" + exception);//catch para enventos inesperados
                Console.ReadKey();
            }

            Console.Clear();

                 return nombrelista;//devuelve valores de array
        }

        public int[] IngresarPrecioArticulos(int ubicacion, int bandera, String[] nombrelista, int[] preciolista)//array que recibe diferentes parametros para poder llenar el array de precios,inicio for, fin for y array a devolver
        {
                int temporalnumb;

                try
                {

                    Console.Clear();
                    for (temporalnumb = ubicacion; temporalnumb < bandera; temporalnumb++)
                    {
                        Console.WriteLine("Por favor digite el precio anual del producto: " + nombrelista[temporalnumb]);
                        precio = Convert.ToInt32(Console.ReadLine());

                        if (precio >= 1 && precio < 10000)//condicion si cumple con que el digito sea entre 1-10000
                        {
                            preciolista[temporalnumb] = precio;//anade precio a array precio
                        }
                        else
                        {
                            while (precio <= 0 && precio < 10000)//condicion si no cumple con que el digito sea entre 1-10000
                        {
                                Console.WriteLine("Por favor digite un precio mayor a 0 y menor a 10000");
                                Console.WriteLine("Producto: " + nombre);
                                precio = Convert.ToInt32(Console.ReadLine());
                            }

                            preciolista[temporalnumb] = precio;//anade precio a array precio
                    }
                    }

                    Console.Clear();
                }
                catch (FormatException exception)//catch al no introducir numero
            {
                    Console.WriteLine("Sucedio un error\nNo se digito un numero\n" + exception);
                    Console.ReadKey();
                }
                catch (ArithmeticException exception)//catch al no introducir numeros
            {
                   Console.WriteLine("Sucedio un error\nSe digito un numero de formato no entero\n" + exception);
                   Console.ReadKey();
                }
                catch (Exception exception)
                {
                  Console.WriteLine("Sucedio un error Inesperado\n\n" + exception);//catch para enventos inesperados
                Console.ReadKey();
                }

            return preciolista;//devuelve valores de array
        }
       
    }
}
