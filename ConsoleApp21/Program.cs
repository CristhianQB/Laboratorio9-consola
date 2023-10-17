using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
     
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool continuar = true;
            while (continuar)
            {
                MostrarMenuPrincipal();
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion) {
                    case 1:
                        RegistrarVenta();
                        int valor2 = int.Parse(Console.ReadLine());
                        switch (valor2)
                        {
                            case 1:
                                Registrarventalimpieza();
                                break;
                            case 2:
                                Registrarventaabarrotes();
                                break;
                            case 3:
                                Registrarventagasolinas();
                                break;
                            case 4:
                                Registrarventaelectronicos();
                                break;
                        }
                        break;
                    case 2:
                        Registrardevolución();
                        int valor3 = int.Parse(Console.ReadLine());
                        switch (valor3)
                        {
                            case 1:
                                Registrardevolucionlimpieza();
                                break;
                            case 2:
                                Registrardevolucionabarrotes();
                                break;
                            case 3:
                                Registrardevoluciongasolinas();
                                break;
                            case 4:
                                Registrardevolucionelectronicos();
                                break;
                        }
                        break;

                    case 3:
                        Cerrarcaja();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                        Console.ReadKey();
                        break;
                }
            }

        }
        static void nombrar(string nombre)
        {
            Console.WriteLine(nombre);
        }
        static void nombrar2(string nombre1)
        {
            Console.Write(nombre1);
        }
        static void nombrar3(string nombre3, string nombre4)
        {
            Console.WriteLine(nombre3, nombre4);
        }

        public static class global
        {
            public static float totallimpieza = 0;
            public static float totallimpieza2 = 0;
            public static float vendidoslimpieza = 0;
            public static float devueltoslimpieza = 0;
            public static float quedanencajalimpieza = 0;
            public static float encajajalimpieza = 0;

            public static float totalabarrotes = 0;
            public static float totalabarrotes2 = 0;
            public static float vendidosabarrotes = 0;
            public static float devueltosabarrotes = 0;
            public static float quedanencajaabarrotes = 0;
            public static float encajaabarrotes = 0;

            public static float totalgasolinas = 0;
            public static float totalgasolinas2 = 0;
            public static float vendidosgasolinas = 0;
            public static float devueltosgasolinas = 0;
            public static float quedanencajagasolinas = 0;
            public static float encajagasolinas = 0;

            public static float totalelectronicos = 0;
            public static float totalelectronicos2 = 0;
            public static float vendidoselectronicos = 0;
            public static float devueltoselectronicos = 0;
            public static float quedanencajaelectronicos = 0;
            public static float encajaelectronicos = 0;
        }

        public static void MostrarMenuPrincipal()
        {
            Console.Clear();
            nombrar("================================");
            nombrar("Tienda de Don Lucas");
            nombrar("================================");
            nombrar("1: Registrar venta");
            nombrar("2: Registrar devolución");
            nombrar("3: Cerrar Caja");
            nombrar("================================");
            Console.Write("Ingrese una opción: ");
        }
        public static void RegistrarVenta()
        {
            Console.Clear();
            nombrar("================================");
            nombrar("Registrar Venta de:");
            nombrar("================================");
            nombrar("1: Limpieza");
            nombrar("2: Abarrotes");
            nombrar("3: Golosinas");
            nombrar("4: Electrónicos");
            nombrar("5: <- Regresar");
            nombrar("================================");
            Console.Write("Ingrese una opción: ");
        }

        public static void Registrarventalimpieza()
        {
            Console.Clear();
            nombrar("================================");
            nombrar("Registrar venta de Limpieza");
            nombrar("================================");
            nombrar2("Ingrese cantidad (unidades): ");
            float unidades1 = float.Parse(Console.ReadLine());
            nombrar2("Ingrese precio: ");
            float precio1 = float.Parse(Console.ReadLine());
            float total1 = precio1 * unidades1;
            nombrar("================================");
            nombrar("Se han ingresado " + unidades1 + " unidades");
            nombrar("Se han ingresado S/ " + total1 + " en caja");
            nombrar("================================");
            nombrar("1: Registrar más productos de limpieza");
            nombrar("2: <- Regresar");
            nombrar("================================");
            Console.Write("Ingrese una opción: ");
            global.vendidoslimpieza = precio1 * unidades1;
            global.totallimpieza = global.totallimpieza + (int)unidades1;
            global.quedanencajalimpieza = global.totallimpieza - global.totallimpieza2;
            global.encajajalimpieza = global.encajajalimpieza + global.vendidoslimpieza;
            int valor4 = int.Parse(Console.ReadLine());
            if (valor4 == 1)
            {
                Registrarventalimpieza();
            }
        }

        public static void Registrarventaabarrotes()
        {
            Console.Clear();
            nombrar("================================");
            nombrar("Registrar venta de Abarrotes");
            nombrar("================================");
            nombrar2("Ingrese cantidad (unidades): ");
            float unidades2 = float.Parse(Console.ReadLine());
            nombrar2("Ingrese precio: ");
            float precio2 = float.Parse(Console.ReadLine());
            float total2 = precio2 * unidades2;
            nombrar("================================");
            nombrar("Se han ingresado " + unidades2 + " unidades");
            nombrar("Se han ingresado S/ " + total2 + " en caja");
            nombrar("================================");
            nombrar("1: Registrar más productos de limpieza");
            nombrar("2: <- Regresar");
            nombrar("================================");
            Console.Write("Ingrese una opción: ");
            global.vendidosabarrotes = precio2 * unidades2;
            global.totalabarrotes = global.totalabarrotes + (int)unidades2;
            global.quedanencajaabarrotes = global.totalabarrotes - global.totalabarrotes2;
            global.encajaabarrotes = global.encajaabarrotes + global.vendidosabarrotes;
            int valor5 = int.Parse(Console.ReadLine());
            if (valor5 == 1)
            {
                Registrarventaabarrotes();
            }
        }
        public static void Registrarventagasolinas()
        {
            Console.Clear();
            nombrar("================================");
            nombrar("Registrar venta de Gasolinas");
            nombrar("================================");
            nombrar2("Ingrese cantidad (unidades): ");
            float unidades3 = float.Parse(Console.ReadLine());
            nombrar2("Ingrese precio: ");
            float precio3 = float.Parse(Console.ReadLine());
            float total3 = precio3 * unidades3;
            nombrar("================================");
            nombrar("Se han ingresado " + unidades3 + " unidades");
            nombrar("Se han ingresado S/ " + total3 + " en caja");
            nombrar("================================");
            nombrar("1: Registrar más productos de limpieza");
            nombrar("2: <- Regresar");
            nombrar("================================");
            Console.Write("Ingrese una opción: ");
            global.vendidosgasolinas = precio3 * unidades3;
            global.totalgasolinas = global.totalgasolinas + (int)unidades3;
            global.quedanencajagasolinas = global.totalgasolinas - global.totalgasolinas;
            global.encajagasolinas = global.encajagasolinas + global.vendidosgasolinas;
            int valor6 = int.Parse(Console.ReadLine());
            if (valor6 == 1)
            {
                Registrarventagasolinas();
            }
        }
        public static void Registrarventaelectronicos()
        {
            Console.Clear();
            nombrar("================================");
            nombrar("Registrar venta de Electrónicos");
            nombrar("================================");
            nombrar2("Ingrese cantidad (unidades): ");
            float unidades4 = float.Parse(Console.ReadLine());
            nombrar2("Ingrese precio: ");
            float precio4 = float.Parse(Console.ReadLine());
            float total4 = precio4 * unidades4;
            nombrar("================================");
            nombrar("Se han ingresado " + unidades4 + " unidades");
            nombrar("Se han ingresado S/ " + total4 + " en caja");
            nombrar("================================");
            nombrar("1: Registrar más productos de limpieza");
            nombrar("2: <- Regresar");
            nombrar("================================");
            Console.Write("Ingrese una opción: ");
            global.vendidoselectronicos = precio4 * unidades4;
            global.totalelectronicos = global.totalelectronicos + (int)unidades4;
            global.quedanencajaelectronicos = global.totalelectronicos - global.totalelectronicos;
            global.encajaelectronicos = global.encajaelectronicos + global.vendidoselectronicos;
            int valor7 = int.Parse(Console.ReadLine());
            if (valor7 == 1)
            {
                Registrarventaelectronicos();
            }
        }


        public static void Registrardevolución()
        {
            Console.Clear();
            nombrar("================================");
            nombrar("Registrar devolución de:");
            nombrar("================================");
            nombrar("1: Limpieza");
            nombrar("2: Abarrotes");
            nombrar("3: Golosinas");
            nombrar("4: Electrónicos");
            nombrar("5: <- Regresar");
            nombrar("================================");
            Console.Write("Ingrese una opción: ");
        }

        public static void Registrardevolucionlimpieza()
        {
            Console.Clear();
            nombrar("================================");
            nombrar("Registrar devolucion de Limpieza");
            nombrar("================================");
            nombrar2("Ingrese cantidad (unidades): ");
            float unidades1 = float.Parse(Console.ReadLine());
            nombrar2("Ingrese precio: ");
            float precio1 = float.Parse(Console.ReadLine());
            float total1 = precio1 * unidades1;
            nombrar("================================");
            nombrar("Se han regresado " + unidades1 + " unidades");
            nombrar("Se han devuelto S/ " + total1 + " en caja");
            nombrar("================================");
            nombrar("1: Devolver más productos de limpieza");
            nombrar("2: <- Regresar");
            nombrar("================================");
            Console.Write("Ingrese una opción: ");
            global.devueltoslimpieza = precio1 * unidades1;
            global.totallimpieza2 = global.totallimpieza2 + (int)unidades1;
            global.quedanencajalimpieza = global.totallimpieza - global.totallimpieza2;
            global.encajajalimpieza = global.encajajalimpieza - global.devueltoslimpieza;
            int valor4 = int.Parse(Console.ReadLine());
            if (valor4 == 1)
            {
                Registrardevolucionlimpieza();
            }
        }

        public static void Registrardevolucionabarrotes()
        {
            Console.Clear();
            nombrar("================================");
            nombrar("Registrar devolución de Abarrotes");
            nombrar("================================");
            nombrar2("Ingrese cantidad (unidades): ");
            float unidades2 = float.Parse(Console.ReadLine());
            nombrar2("Ingrese precio: ");
            float precio2 = float.Parse(Console.ReadLine());
            float total2 = precio2 * unidades2;
            nombrar("================================");
            nombrar("Se han regresado " + unidades2 + " unidades");
            nombrar("Se han devuelto S/ " + total2 + " en caja");
            nombrar("================================");
            nombrar("1: Devolver más productos de limpieza");
            nombrar("2: <- Regresar");
            nombrar("================================");
            Console.Write("Ingrese una opción: ");
            global.vendidosabarrotes = precio2 * unidades2;
            global.totalabarrotes2 = global.totalabarrotes2 + (int)unidades2;
            global.quedanencajaabarrotes = global.totalabarrotes - global.totalabarrotes2;
            global.encajaabarrotes = global.encajaabarrotes - global.vendidosabarrotes;
            int valor5 = int.Parse(Console.ReadLine());
            if (valor5 == 1)
            {
                Registrardevolucionabarrotes();
            }
        }
        public static void Registrardevoluciongasolinas()
        {
            Console.Clear();
            nombrar("================================");
            nombrar("Registrar dovolución de Gasolinas");
            nombrar("================================");
            nombrar2("Ingrese cantidad (unidades): ");
            float unidades3 = float.Parse(Console.ReadLine());
            nombrar2("Ingrese precio: ");
            float precio3 = float.Parse(Console.ReadLine());
            float total3 = precio3 * unidades3;
            nombrar("================================");
            nombrar("Se han regresado " + unidades3 + " unidades");
            nombrar("Se han devuelto S/ " + total3 + " en caja");
            nombrar("================================");
            nombrar("1: Devolver más productos de limpieza");
            nombrar("2: <- Regresar");
            nombrar("================================");
            Console.Write("Ingrese una opción: ");
            global.vendidosgasolinas = precio3 * unidades3;
            global.totalgasolinas2 = global.totalgasolinas2 + (int)unidades3;
            global.quedanencajagasolinas = global.totalgasolinas - global.totalgasolinas2;
            global.encajagasolinas = global.encajagasolinas - global.vendidosgasolinas;
            int valor6 = int.Parse(Console.ReadLine());
            if (valor6 == 1)
            {
                Registrardevoluciongasolinas();
            }
        }
        public static void Registrardevolucionelectronicos()
        {
            Console.Clear();
            nombrar("================================");
            nombrar("Registrar devolución de Electrónicos");
            nombrar("================================");
            nombrar2("Ingrese cantidad (unidades): ");
            float unidades4 = float.Parse(Console.ReadLine());
            nombrar2("Ingrese precio: ");
            float precio4 = float.Parse(Console.ReadLine());
            float total4 = precio4 * unidades4;
            nombrar("================================");
            nombrar("Se han regresado " + unidades4 + " unidades");
            nombrar("Se han devuelto S/ " + total4 + " en caja");
            nombrar("================================");
            nombrar("1: Devolver más productos de limpieza");
            nombrar("2: <- Regresar");
            nombrar("================================");
            Console.Write("Ingrese una opción: ");
            global.vendidoselectronicos = precio4 * unidades4;
            global.totalelectronicos2 = global.totalelectronicos2 + (int)unidades4;
            global.quedanencajaelectronicos = global.totalelectronicos - global.totalelectronicos2;
            global.encajaelectronicos = global.encajaelectronicos - global.vendidoselectronicos;
            int valor7 = int.Parse(Console.ReadLine());
            if (valor7 == 1)
            {
                Registrardevolucionelectronicos();
            }
        }

        public static void Cerrarcaja()
        {
            Console.Clear();
            nombrar("================================");
            nombrar("Tienda de Don Lucas");
            nombrar("================================");
            nombrar("1: Registrar venta");
            nombrar("2: Registrar devolución");
            nombrar("3: Cerrar Caja");
            nombrar("================================");
            nombrar("Cerrando Caja");
            nombrar("================================");
            nombrar("Totales");
            nombrar("================================");
            nombrar3("{0,31}", "|      " + global.totallimpieza + " vendidos");
            nombrar("Limpieza      |      " + global.totallimpieza2 + " devueltos");
            nombrar3("{0,31}", "|      " + global.quedanencajalimpieza + " en total");
            nombrar3("{0,33}", "|      S/" + global.encajajalimpieza + " en caja");
            nombrar("================================");
            nombrar3("{0,31}", "|      " + global.totalabarrotes + " vendidos");
            nombrar("Abarrotes     |      " + global.totalabarrotes2 + " devueltos");
            nombrar3("{0,31}", "|      " + global.quedanencajaabarrotes + " en total");
            nombrar3("{0,33}", "|      S/" + global.encajaabarrotes + " en caja");
            nombrar("================================");
            nombrar3("{0,31}", "|      " + global.totalgasolinas + " vendidos");
            nombrar("Gasolinas     |      " + global.totalgasolinas2 + " devueltos");
            nombrar3("{0,31}", "|      " + global.quedanencajagasolinas + " en total");
            nombrar3("{0,33}", "|      S/" + global.encajagasolinas + " en caja");
            nombrar("================================");
            nombrar3("{0,31}", "|      " + global.totalelectronicos + " vendidos");
            nombrar("Electro       |      " + global.totalelectronicos2 + " devueltos");
            nombrar3("{0,31}", "|      " + global.quedanencajaelectronicos + " en total");
            nombrar3("{0,33}", "|      S/" + global.encajaelectronicos + " en caja");
            float total100 = global.encajajalimpieza + global.encajaabarrotes + global.encajaelectronicos
                             + global.encajagasolinas;
            nombrar("Queda en caja s/" + total100);
            Console.ReadKey();
        }

    }
}




