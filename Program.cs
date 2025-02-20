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
        public string Detalles;
        public DateTime Fecha;
        public Historial(string detalles, DateTime fecha)
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
            Console.Write("Ingrese el nombre de la mascota: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la raza de la mascota: ");
            string raza = Console.ReadLine();

            Console.Write("Ingrese la edad");
            int edad = int.Parse(Console.ReadLine());

            Mascota mascota = new (nombre, raza, edad);

            listaMascotas.Add(mascota);

            for (int i = 0; i < listaMascotas.Count; i++)
            {
                Console.WriteLine(listaMascotas[i]);
                for (int i = 0; i < listaMascotas[i].historiales.Count; i++)
                {

                }
            }
        }

        public void menu()
        {
            Console.WriteLine("------------- HISTORIAL CLINICO -------------\n" +
                              "\n" +
                              "1. Registrar mascota." +
                              "2. Añadir antecedente." +
                              "3. ");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("------------- BIENVENIDOS A PIPO'S VETERINARY -------------");
            string opcion = Console.ReadLine();
        }
    }
}
