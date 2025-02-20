using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HistorialClinico
{
    class Mascota
    {
        public string Nombre, Raza;
        public int Edad;
        public List<Historial> historiales;
        public Mascota(string nombre, string raza, int edad)
        {
            Nombre = nombre;
            Raza = raza;
            Edad = edad;
            historiales = new List<Historial>();
        }
    }

    class Historial
    {
        public string Detalles, Fecha;
        public Historial(string detalles, string fecha)
        {
            Detalles = detalles;
            Fecha = fecha;
        }
    }

    internal class Program
    {

        public List<Mascota> listaMascotas = new List<Mascota>();

        public void registrarMascota()
        {
            Console.Write("\nIngrese el nombre de la mascota: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la raza de la mascota: ");
            string raza = Console.ReadLine();

            Console.Write("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());

            Mascota mascota = new (nombre, raza, edad);

            listaMascotas.Add(mascota);


            menu();
        }



        public void añadirAntecedente()
        {
            if (validarLista())
            {
                Console.Write("\nIngrese el indice de la mascota a añadir el antecendente: ");
                int indice = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la informacion de el antecendente: ");
                string detalles = Console.ReadLine();

                Console.Write("Ingrese la fecha de el antecendente (DD/MM/AAAA): ");
                string fechaString = Console.ReadLine();

                Historial historial = new Historial(detalles, fechaString);
                listaMascotas[indice - 1].historiales.Add(historial);
            }
            else
            {
                Console.WriteLine("NO SE HA REGISTRADO NINGUNA MASCOTA, NO SE PUEDE AÑADIR UN HISTORIAL\n");
            }
        }

        public void mostrarAntecedentes()
        {
            if (validarLista())
            {
                Console.Write("\nIngrese el indice de la mascota a mostrar el antecedente: ");
                int indice = int.Parse(Console.ReadLine());

                List<Historial> historial = listaMascotas[indice - 1].historiales;

                if (historial.Count > 0)
                {
                    for (int i = 0; i < historial.Count; i++)
                    {
                        Console.WriteLine($"-HISTORIAL {i+1}. Fecha: {historial[i].Fecha} \n" +
                            $"Descripcion: {historial[i].Detalles}");
                    }
                }
                else
                {
                    Console.WriteLine("\nLA MASCOTA NO TIENE HISTORIAL\n");

                }

            }
            else
            {
                Console.WriteLine("NO SE HA REGISTRADO NINGUNA MASCOTA, NO HAY HISTORIAL PARA MOSTRAR\n");
            }

        }

        public bool validarLista()
        {
            return listaMascotas.Count > 0;
        }

        public void mostrarMascotas()
        {
            Console.WriteLine("\n--------- LISTA DE MASCOTAS ---------\n");

            if (validarLista())
            {
                for (int i = 0; i < listaMascotas.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {listaMascotas[i].Nombre}");
                }
            }
            else
            {
                Console.WriteLine("NO SE HA REGISTRADO NINGUNA MASCOTA\n");
            }
        }

        public void eliminarMascota()
        {
            if (validarLista())
            {
                while (true)
                {
                    Console.Write("Ingrese el indice de la mascota a eliminar: ");
                    int indice = int.Parse(Console.ReadLine());

                    if (indice > 0 && indice <= listaMascotas.Count)
                    {
                        listaMascotas.RemoveAt(indice - 1);
                        Console.WriteLine("MASCOTA ELIMINADA CORRECTAMENTE");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("INDICE INEXSISTENTE");

                    }
                }
            }
            else
            {
                Console.WriteLine("NO SE HA REGISTRADO NINGUNA MASCOTA, NO SE PUEDE ELIMINAR UNA MASCOTA SI NO EXISTEN MASCOTAS\n");
            }
        }

        //registrar, añadir, mostrarmascotas y antecedentes, eliminar mascota

        public void menu()
        {
            Console.Write("\n" +
                              "MENU: \n" +
                              "\n" +
                              "1. Registrar mascota.\n" +
                              "2. Añadir historial a una mascota.\n" +
                              "3. Mostrar mascotas.\n" +
                              "4. Mostrar historial de una mascota.\n" +
                              "5. Eliminar mascota.\n"+
                              "0. Salir.\n" +
                              "\n" +
                              "Ingrese la opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    registrarMascota();
                    menu();
                    break;
                case 2:
                    añadirAntecedente();
                    menu();
                    break;
                case 3:
                    mostrarMascotas();
                    menu();
                    break;
                case 4:
                    mostrarAntecedentes();
                    menu();
                    break;
                case 5:
                    eliminarMascota();
                    menu();
                    break;
                case 0:
                    Console.WriteLine("FINALIZO EL PROGRAMA");
                    break;
                default:

                    Console.WriteLine("\nERROR: INGRESO UNA OPCION INVALIDA!!!");
                    menu();
                    break;
            }
        }

        static void Main(string[] args)
        {
            Program pers1 = new Program();
            Console.WriteLine("------------- BIENVENIDOS A PIPO'S VETERINARY -------------");
            pers1.menu();
            //Console.Write("Ingrese la fecha de el antecendente (DD/MM/AAAA): ");
            //string fechaString = Console.ReadLine();
            //DateTime fecha = DateTime.Parse(fechaString);
            //string fecha2 = fecha.ToString("d");
            //Console.WriteLine(fecha2);

            //List<int> lista = new List<int>();
            //Console.WriteLine(lista.Count);
        }
    }
}
