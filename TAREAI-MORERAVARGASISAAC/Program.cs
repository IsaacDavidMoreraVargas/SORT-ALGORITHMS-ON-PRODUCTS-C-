using System;


namespace TAREAI_MORERAVARGASISAAC
{
   class Menu
   {
        public static void Main(string[] args)
        {
            try
            {
                bool banderaBool = false;//evaluador para obligar primero a la introduccion de datos
                int bandera=20, ubicacion = 0, opcionMenu;
                int[] preciolista = new int[bandera];//array que guarda lista de precios
                string[] nombrelista = new string[bandera];//array que guarda lista de nombres
                int[] temppreciolista = new int[bandera];//array que guarda lista temporal de precios ingresados y no seran ordenados
                string[] tempnombrelista = new string[bandera];//array que guarda lista temporal de nombres ingresados y no seran ordenados

                do
                {
                    //UNIVERSIDAD ESTATUAL A DISTANCIA
                    //PROGRAMACION AVANZADA
                    //ISAAC D. MORERA V
                    //TAREA I
                    //GRUPO 01
                    //CEDULA: 116200798
                    
                    Console.Clear();
                    Console.WriteLine("Bienvenido al programa de productos.\n\n1.Registrar articulos.\n2.Ordenar articulos de mayor a menor.\n3.Ordenar articulos de menor a mayor.\n4.Imprimir articulos ordenados.\n5.Imprimir articulos ingresados.\n6.Salir.");
                    Console.WriteLine("Solo se permiten\n1.Palabras alfanumericas sin simbolos\n2.Palabras con 10 letras o menos\n3.Palabras no repetidas");         
                    Console.WriteLine("\nElija>>");
                    opcionMenu = Convert.ToInt32(Console.ReadLine());

                    if (opcionMenu == 1)//condicion para forzar el orden de introducir primero datos
                    {
                        banderaBool = true;
                    }

                    if (banderaBool == false)//condicion que niega acceso si no se a introducido datos primero
                    {
                        while (opcionMenu != 1)
                        {
                            Console.Clear();
                            Console.WriteLine("El programa no puede iniciar si no a introducido datos aunque sea por primera vez o si lo desea puede salir del programa \n\n1.Para introducir datos \n6.Para salir del programa");
                            Console.WriteLine("\nDigite>>");
                            opcionMenu = Convert.ToInt32(Console.ReadLine());

                            if (opcionMenu == 1)//condicion para usar el programa al forzar introducir datos primero
                            {
                                banderaBool = true;

                            } else if (opcionMenu == 6)//fuerza condicion para salir si no se quiere salir el orden
                            {
                                System.Environment.Exit(0);
                            }
                        }
                    }

                    if ((opcionMenu < 1 || opcionMenu > 6))//codicion si se digita un numero que no existe en opciones
                    {
                        while (opcionMenu < 1 || opcionMenu > 6)
                        {
                            Console.Clear();
                            Console.WriteLine("No digito una opcion valida, Digite de nuevo");
                            Console.WriteLine("\nDigite>>");
                            opcionMenu = Convert.ToInt32(Console.ReadLine());
                        }

                        Menu llamadaOpciones = new Menu();
                        llamadaOpciones.MenuPrincipal(opcionMenu, ubicacion, bandera, preciolista, nombrelista, temppreciolista, tempnombrelista);

                    }
                    else if ((opcionMenu >= 1 || opcionMenu <= 6) && banderaBool == true)//condicion si se elige una opcion existente y  si ya se a introducido los datos 
                    {
                        Menu llamadaOpciones = new Menu();
                        llamadaOpciones.MenuPrincipal(opcionMenu, ubicacion, bandera, preciolista, nombrelista, temppreciolista, tempnombrelista);
                    }

                } while (opcionMenu != 6);

            } catch (FormatException exception)//catch al no introducir numero
            {
                 Console.WriteLine("Sucedio un error\nNo se digito un numero\n"+ exception);
                 Console.ReadKey();
            }
            catch (ArithmeticException exception)//catch al no introducir numeros
            {
                Console.WriteLine("Sucedio un error\nSe digito un numero de formato no entero\n" + exception);
                Console.ReadKey();
            }
            catch (Exception exception)//catch para enventos inesperados
            {
                Console.WriteLine("Sucedio un error Inesperado\n\n" + exception);
                Console.ReadKey();
            }
        }

        public void MenuPrincipal(int opcionMenu, int ubicacion, int bandera, int[] preciolista, string[] nombrelista, int[] temppreciolista, string[] tempnombrelista)//funcion que recibe diferentes parametros para el funcionamiento de los constructores
        {

                switch (opcionMenu)//catch al no introducir swtich del menu
            {
                    case 1:

                        Ingresar_articulo llamadogeneralA = new Ingresar_articulo();//constructor y llamado a llenar nombres y lista de insumos
                        llamadogeneralA.IngresarNombreArticulos(ubicacion, bandera, nombrelista);
                        llamadogeneralA.IngresarPrecioArticulos(ubicacion, bandera, nombrelista, preciolista);
                       

                    for (ubicacion = 0; ubicacion < bandera; ubicacion++)//pasara los datos ingresados a un array auxiliar que no sera ordenado nunca
                        {
                            tempnombrelista[ubicacion] = nombrelista[ubicacion];
                            temppreciolista[ubicacion] = preciolista[ubicacion];
                        }

                    break;

                    case 2:

                        BurbujaAscente llamadoMetodoBurbujaAscA = new BurbujaAscente();//constructor y llamado para ordenar ascendentemente array
                        llamadoMetodoBurbujaAscA.BurbujaOrdenarAscendente(preciolista, nombrelista);
                        break;

                    case 3:

                        BurbujaDescendente llamadoMetodoBurbujaDesA = new BurbujaDescendente();//constructor y llamado para ordenar descendentemente array
                        llamadoMetodoBurbujaDesA.BurbujaOrdenarDescendente(preciolista, nombrelista);
                        break;

                    case 4:

                        ImprimirArticulosOrdenados llamadoImprimirArticulosOrdenadosA = new ImprimirArticulosOrdenados();//constructor y llamado a imprimir articulos ordenados
                        llamadoImprimirArticulosOrdenadosA.ImprimirArticulosOrdenado(preciolista, nombrelista);
                        break;

                    case 5:

                        ImprimirArticulosIngresados llamadoImprimirArticulosIngresadosA = new ImprimirArticulosIngresados();//constructor y llamado a imprimir articulos no ordenados
                        llamadoImprimirArticulosIngresadosA.ImprimirArticulosIngresado(temppreciolista, tempnombrelista);
                        break;

                    case 6://opcion para salir del programa

                        System.Environment.Exit(0);

                        break;

                }
        }
   }
}
