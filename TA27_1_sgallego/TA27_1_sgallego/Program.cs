using System;

namespace Jobs
{
    class Jobs
    {
        
        public class Personal
        {

            private String _Nombre;
            private double _Sueldo;
            private double _SueldoNeto;
            private double _Anual;
            private double _AnualNeto;

            public double comprobarSueldo(int min, int max, double sueldo)
            {

                if (!(sueldo > min && sueldo < max))
                {
                    throw new Exception("El sueldo no se encuentra dentro los limites establecidos.");
                }

                return sueldo;
            }

            public double bonusAnual(double anual)
            {
                Console.WriteLine("Bonus anual aplicado");
                return anual + (anual * 0.1);
            }

            public String nombre
            {
                get { return _Nombre; }
                set { _Nombre = value; }
            }

            public double sueldo
            {
                get { return _Sueldo; }
                set { _Sueldo = value; }
            }

            public double sueldo_neto
            {
                get { return _SueldoNeto; }
                set { _SueldoNeto = value; }
            }

            public double anual
            {
                get { return _Anual; }
                set { _Anual = value; }
            }
            public double anual_neto
            {
                get { return _AnualNeto; }
                set { _AnualNeto = value; }
            }

            public Personal(String pNombre, double pSueldo) { 
                nombre = pNombre;
                sueldo = pSueldo;
            }

            public class Manager : Personal
            {
                public double comprobarSueldo(double pSueldo)
                {
                    return base.comprobarSueldo(3000, 5000, sueldo);
                }
                public Manager(String pNombre, double pSueldo) : base(pNombre, pSueldo)
                {
                    sueldo = pSueldo + (pSueldo * 0.1);
                    comprobarSueldo(sueldo);
                    sueldo_neto = sueldo - (sueldo * 0.26);
                    anual = sueldo * 12;
                    anual_neto = anual - (anual * 0.26);

                    base.bonusAnual(anual);

                }

            }

            public class Boss : Personal
            {
                public double comprobarSueldo(double pSueldo)
                {
                    return base.comprobarSueldo(8000, (int)Math.Round(sueldo) + 1, sueldo);
                }
                public Boss(String pNombre, double pSueldo) :base(pNombre, pSueldo)
                {
                    sueldo = pSueldo + (pSueldo * 0.5);
                    comprobarSueldo(sueldo);
                    sueldo_neto = sueldo - (sueldo * 0.32);
                    anual = sueldo * 12;
                    anual_neto = anual - (anual * 0.32);

                    base.bonusAnual(anual);

                }

            }

            public class Employee : Personal
            {
                public Employee(String pNombre, double pSueldo) : base(pNombre, pSueldo)
                {
                    sueldo = pSueldo - (pSueldo * 0.15);
                }

            }

            public class Volunteer : Personal
            {
                public double comprobarSueldo(double pSueldo)
                {
                    return base.comprobarSueldo(0, 0, sueldo);
                }
                public Volunteer(String pNombre, double pSueldo) : base(pNombre, pSueldo)
                {
                    sueldo = 0;
                    comprobarSueldo(sueldo);
                    sueldo += 300;
                    Console.WriteLine("Sueldo: " + sueldo + " ayuda");
                }
            }

            public class Junior : Personal
            {
                public double comprobarSueldo(double pSueldo)
                {
                    return base.comprobarSueldo(900, 1600, sueldo);
                }
                public Junior(String pNombre, double pSueldo) : base(pNombre, pSueldo)
                {
                    sueldo = pSueldo - (pSueldo * 0.05);
                    comprobarSueldo(sueldo);
                    sueldo_neto = sueldo - (sueldo * 0.02);
                    anual = sueldo * 12;
                    anual_neto = anual - (anual * 0.02);

                    base.bonusAnual(anual);
                }
            }

            public class Mid: Personal
            {
                public double comprobarSueldo(double pSueldo)
                {
                    return base.comprobarSueldo(1800, 2500, sueldo);
                }
                public Mid(String pNombre, double pSueldo) : base(pNombre, pSueldo)
                {
                    sueldo = pSueldo - (pSueldo * 0.10);
                    comprobarSueldo(sueldo);
                    sueldo_neto = sueldo - (sueldo * 0.15);
                    anual = sueldo * 12;
                    anual_neto = anual - (anual * 0.15);

                    base.bonusAnual(anual);
                }
            }

            public class Senior : Personal
            {
                public double comprobarSueldo(double pSueldo)
                {
                    return base.comprobarSueldo(2700, 4000, sueldo);
                }
                public Senior(String pNombre, double pSueldo) : base(pNombre, pSueldo)
                {
                    sueldo = pSueldo - (pSueldo * 0.10);
                    comprobarSueldo(sueldo);
                    sueldo_neto = sueldo - (sueldo * 0.24);
                    anual = sueldo * 12;
                    anual_neto = anual - (anual * 0.24);

                    base.bonusAnual(anual);

                }
            }

            static void Main(String[] args)
            {
                //MILESTONE 1
                Personal _Personal = new Personal("Personal1", 100);
                Manager _Manager = new Manager("Manager1", 3000);
                Boss _Boss = new Boss("Boss1", 8000);
                Employee _Employee = new Employee("Employee1", 100);
                Junior _Junior = new Junior("Junior1", 1000);
                Mid _Mid = new Mid("Mid1", 2100);
                Senior _Senior = new Senior("Senior1", 3200);

                Console.WriteLine("Comparacion de sueldos: ");
                Console.WriteLine("Personal: " + _Personal.sueldo);
                Console.WriteLine("Boss: " + _Boss.sueldo);
                Console.WriteLine("Employee: " + _Employee.sueldo);
                Console.WriteLine("Manager: " + _Manager.sueldo);

                //MILESTONE 2
                Console.WriteLine("Junior: " + _Junior.sueldo);
                Console.WriteLine("Mid: " + _Mid.sueldo);
                Console.WriteLine("Senior: " + _Senior.sueldo);

                //Descomentar para comprobar excepcion
                /*Volunteer _Volunteer = new Volunteer("Volunteer1", 100);
                Console.WriteLine("Volunteer: " + _Volunteer.sueldo);*/ 

                //MILESTONE 3
                Console.WriteLine("Manager: " + _Manager.sueldo);
                Console.WriteLine("Manager: " + _Manager.anual);
            }
        }
    }
}