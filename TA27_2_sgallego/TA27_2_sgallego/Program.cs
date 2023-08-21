using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Vehicles
{
    public class Vehicle
    {
        private Titular _Titular;
        private List<Persona> _Personas;
        private String _Matricula;
        private String _Marca;
        private String _Color;
        private String _MarcaDelanteras;
        private String _MarcaTraseras;
        private double _DiametroDelanteras;
        private double _DiametroTraseras;

        public String matricula
        {
            get { return _Matricula; }
            set { _Matricula = value; }
        }

        public String marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }
        public String color
        {
            get { return _Color; }
            set { _Color = value; }
        }
        public String marca_delanteras
        {
            get { return _MarcaDelanteras; }
            set { _MarcaDelanteras = value; }
        }

        public String marca_traseras
        {
            get { return _MarcaTraseras; }
            set { _MarcaTraseras = value; }
        }

        public double diametro_delanteras
        {
            get { return _DiametroDelanteras; }
            set { _DiametroDelanteras = value; }
        }

        public double diametro_traseras
        {
            get { return _DiametroTraseras; }
            set { _DiametroTraseras = value; }
        }

        public Titular titular
        {
            get { return _Titular; }
            set { _Titular = value; }
        }

        public List<Persona> personas
        {
            get { return _Personas; }
            set { _Personas = value; }
        }

        public Vehicle(String pMatricula, String pMarca, String pColor, Titular pTitular, List<Persona> pPersonas) {

            if (Regex.IsMatch(pMatricula, "^[0-9]{4}[A-Za-z]{2,3}$"))
            {
                matricula = pMatricula;
            }
            else
            {
                throw new Exception("El numero de matricula no es válido");
            }
            marca = pMarca;
            color = pColor;
            titular = pTitular;
            personas = pPersonas;
            marca_delanteras = "";
            diametro_delanteras = 0;
            marca_traseras = "";
            diametro_traseras = 0;
        }

        public void agreagrRuedas()
        {
            Console.WriteLine("Introduce la marca de las ruedas delanteras: ");
            String marcaDelanteras = Console.ReadLine();
            Console.WriteLine("Introduce el diametro de las ruedas delanteras: ");
            double diametroDelanteras = double.Parse(Console.ReadLine());

            if (diametroDelanteras < 0.4 || diametroDelanteras > 4)
            {
                throw new Exception("El diametro no es válido");
            }

            marca_delanteras = marcaDelanteras;
            diametro_delanteras = diametroDelanteras;

            Console.WriteLine("Introduce la marca de las ruedas traseras: ");
            String marcaTraseras = Console.ReadLine();
            Console.WriteLine("Introduce el diametro de las ruedas traseras: ");
            double diametroTraseras = double.Parse(Console.ReadLine());

            if (diametroTraseras < 0.4 || diametroTraseras > 4)
            {
                throw new Exception("El diametro no es válido");
            }

            marca_traseras = marcaTraseras;
            diametro_traseras = diametroTraseras;

        }

    }
    public class Coche : Vehicle
    {
        public Coche(String pMatricula, String pModelo, String pColor, Titular pTitular, List<Persona> pPersonas) : base(pMatricula, pModelo, pColor, pTitular, pPersonas) { }
    }

    public class Camion : Vehicle
    {
        public Camion(String pMatricula, String pModelo, String pColor, Titular pTitular, List<Persona> pPersonas) : base(pMatricula, pModelo, pColor, pTitular, pPersonas) { }
    }

    public class Moto : Vehicle
    {
        int numDelanteras;
        int numTraseras;
        public Moto(String pMatricula, String pModelo, String pColor, int pNumDelanteras, int pNumTraseras, Titular pTitular, List<Persona> pPersonas) : base(pMatricula, pModelo, pColor, pTitular, pPersonas) { 
        
            numDelanteras = pNumDelanteras;
            numTraseras = pNumTraseras;
        
        }
    }

    public class Persona
    {
        private String _Nombre;
        private String _Apellidos;
        private String _Nacimiento;
        private Licencia _Licencia;

        public String nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public String apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }

        public String nacimiento
        {
            get { return _Nacimiento; }
            set { _Nacimiento = value; }
        }

        public Licencia licencia
        {
            get { return _Licencia; }
            set { _Licencia = value; }
        }

        public Persona(String pNombre, String pApellidos, String pNacimiento, Licencia pLicencia)
        {
            nombre = pNombre;
            apellidos = pApellidos;
            nacimiento = pNacimiento;
            licencia = pLicencia;
        }

    }

    public class Licencia
    {
        private int _Id;
        private String _TipoLicencia;
        private String _NombreCompleto;
        private String _Caducidad;

        public int id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public String tipo_licencia
        {
            get { return _TipoLicencia;  }
            set { _TipoLicencia  = value; }
        }
        public String nombre_completo
        {
            get { return _NombreCompleto;  }
            set { _NombreCompleto = value; }
        }
        public String caducidad
        {
            get { return _Caducidad; }
            set { _Caducidad = value; }
        }
        public Licencia(int pId, String pTipoLicencia, String pNombreCompleto, String pCaducidad)
        {
            id = pId;
            tipo_licencia = pTipoLicencia;
            nombre_completo = pNombreCompleto;
            caducidad = pCaducidad;
        }
    }

    public class Titular : Persona
    {
        public Titular(String pNombre, String pApellidos, String pNacimiento, Licencia pLicencia): base(pNombre, pApellidos, pNacimiento, pLicencia)
        {

        }
    }

    public class Conductor : Persona
    {
        private Boolean _Aseguranza;
        private Boolean _Garaje;

        public Boolean aseguranza
        {
            get { return _Aseguranza; }
            set { _Aseguranza = value; }
        }

        public Boolean garaje
        {
            get { return _Garaje; }
            set { _Garaje = value; }
        }
        public Conductor(String pNombre, String pApellidos, String pNacimiento, Licencia pLicencia, Boolean pAseguranza, Boolean pGaraje) : base(pNombre, pApellidos, pNacimiento, pLicencia)
        {
            aseguranza = pAseguranza;
            garaje = pGaraje;
        }
    }

    public class Program {

        static void Main(String[] args)
        {
            //Seleccion de usuario
            List<Persona> listaPersonas = new List<Persona>();
            List<Vehicle> listaVehiculos = new List<Vehicle>();
            Boolean acabar = false;
            String tipoVehiculo;

            while (!acabar)
            {
                Console.WriteLine("Qué quieres crear (Usuario / Vehiculo) : ");
                String eleccion = Console.ReadLine();

                if (eleccion == "Usuario")
                {

                    Console.WriteLine("LICENCIA");
                    Console.WriteLine("Introduce el identificador: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el tipo de licencia: ");
                    String tipo = Console.ReadLine();
                    Console.WriteLine("Introduce el nombre completo del titular de la licencia: ");
                    String nombreCompleto = Console.ReadLine();
                    Console.WriteLine("Introduce su fecha de caducidad: ");
                    String caducidad = Console.ReadLine();

                    Licencia l1 = new Licencia(id, tipo, nombreCompleto, caducidad);

                    Console.WriteLine("USUARIO");
                    Console.WriteLine("Introduce el nombre de usuario: ");
                    String nombre = Console.ReadLine();
                    Console.WriteLine("Introduce los apellidos del usuario: ");
                    String apellidos = Console.ReadLine();
                    Console.WriteLine("Introduce su fecha de nacimiento: ");
                    String nacimiento = Console.ReadLine();

                    Titular p1 = new Titular(nombre, apellidos, nacimiento, l1);
                    listaPersonas.Add(p1);
                }
                else if (eleccion == "Vehiculo")
                {
                    //Asignar usuarios al vehiculo
                    Console.WriteLine("LICENCIA");
                    Console.WriteLine("Introduce el identificador: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el tipo de licencia: ");
                    String tipo = Console.ReadLine();
                    Console.WriteLine("Introduce el nombre completo del titular de la licencia: ");
                    String nombreCompleto = Console.ReadLine();
                    Console.WriteLine("Introduce su fecha de caducidad: ");
                    String caducidad = Console.ReadLine();

                    Licencia l1 = new Licencia(id, tipo, nombreCompleto, caducidad);

                    Console.WriteLine("USUARIO");
                    Console.WriteLine("Introduce el nombre de usuario: ");
                    String nombre = Console.ReadLine();
                    Console.WriteLine("Introduce los apellidos del usuario: ");
                    String apellidos = Console.ReadLine();
                    Console.WriteLine("Introduce su fecha de nacimiento: ");
                    String nacimiento = Console.ReadLine();

                    Titular p1 = new Titular(nombre, apellidos, nacimiento, l1);
                    listaPersonas.Add(p1);
                    //Añadir vehiculo
                    Console.WriteLine("Selecciona un vehiculo (Coche/Moto/Camion): ");
                    String vehiculo = Console.ReadLine();
                    Console.WriteLine("Introduce la matricula: ");
                    String matricula = Console.ReadLine();
                    Console.WriteLine("Introduce la marca: ");
                    String marca = Console.ReadLine();
                    Console.WriteLine("Introduce el color: ");
                    String color = Console.ReadLine();
                    Vehicle v1;
                    if (vehiculo == "Coche")
                    {
                        v1 = new Coche(matricula, marca, color, p1, listaPersonas);
                        tipoVehiculo = "Coche";
                    }
                    else if (vehiculo == "Camion")
                    {
                        v1 = new Coche(matricula, marca, color, p1, listaPersonas);
                        tipoVehiculo = "Camion";
                    }
                    else if (vehiculo == "Moto")
                    {
                        Console.WriteLine("Indica el numero de ruedas delanteras: ");
                        int numDelanteras = int.Parse(Console.ReadLine());
                        Console.WriteLine("Indica el numero de ruedas traseras: ");
                        int numTraseras = int.Parse(Console.ReadLine());
                        v1 = new Moto(matricula, marca, color, numDelanteras, numTraseras, p1, listaPersonas);
                        tipoVehiculo = "Moto";
                    }
                    else
                    {
                        throw new Exception("Vehiculo o Tipo de licencia no válido");
                    }
                    v1.agreagrRuedas();
                    listaVehiculos.Add(v1);
                    Console.WriteLine("INFORMACION DEL VEHICULO: ");
                    Console.WriteLine("Matricula: " + v1.matricula + " Marca: " + v1.marca + " Color: " + v1.color + " Delanteras: " + v1.marca_delanteras + " " + v1.diametro_delanteras + " Traseras: " + v1.marca_traseras + " " + v1.diametro_traseras);
                }
                else
                {
                    Console.WriteLine("Comando no válido, inténtalo de nuevo");
                }

                Console.WriteLine("Quieres continuar? (S/N)");
                String decision = Console.ReadLine();
                if (decision == "N")
                {
                    acabar = true;
                }

            }
            Console.WriteLine("Personas almacenadas:");
            foreach (Persona persona in listaPersonas)
            {
                Console.WriteLine($"Nombre: {persona.nombre}, Apellidos: {persona.apellidos}");
            }

            Console.WriteLine("Vehículos almacenados:");
            foreach (Vehicle vehiculo in listaVehiculos)
            {
                Console.WriteLine($"Matrícula: {vehiculo.matricula}, Marca: {vehiculo.marca}");
            }
        }
    }
}