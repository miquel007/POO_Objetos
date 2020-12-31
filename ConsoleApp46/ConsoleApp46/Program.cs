using System;
using System.Collections.Generic;


namespace ConsoleApp46
{
    class Program
    {
        public class Alumne
        {
            string nom;
            int edad;

            public Alumne(string e, int i)
            {
                nom = e;
                edad = i;
            }

            public void escribir()
            {
                Console.WriteLine("En {0} te {1} anys", nom, edad);

                if (edad < 18)
                    Console.WriteLine("En menor de edad");
                else
                    Console.WriteLine("En mayor de edad");
            }

        }

        public class Empleado
        {
            string nom;
            int sou;

            public Empleado(string e, int i)
            {
                nom = e;
                sou = i;
            }

            public void escribir()
            {
                Console.WriteLine("El empleado {0} tiene un sueldo {1} euros", nom, sou);
            }

            public void comprovant()
            {
                if (this.sou > 3000)
                    Console.WriteLine("El empleado no esta excempto de impuestos");
                else
                    Console.WriteLine("El emppleado esta excempto de impuestos");
            }
        }

        public class Operaciones
        {
            double valor1;
            double valor2;

            public Operaciones(int n,int i)
            {
                valor1 = n;
                valor2 = i;
            }

            public void suma()
            {
                double op = this.valor1 + this.valor2;
                Console.WriteLine("La suma = {0}",op);
            }

            public void resta()
            {
                double op = this.valor1 - this.valor2;
                Console.WriteLine("La resta = {0}", op);
            }

            public void multi()
            {
                double op = this.valor1 * this.valor2;
                Console.WriteLine("La multiplicacion = {0}", op);
            }

            public void division()
            {                
                double op = this.valor1 / this.valor2;
                Console.WriteLine("La division = {0}", op);                                
            }
        }

        public class Libro
        {
            private string autor;
            private string titol;
            private string ubicacio;

            public Libro(string e,string i,string u)
            {
                autor = e;
                titol = i;
                ubicacio = u;
            }

            public void escriure()
            {
                Console.WriteLine("El llibre {0} escrit per l'autor {1} esta ubicat a {2}",titol,autor,ubicacio);
            }

            public string PropertyNom
            {
                get
                {
                    return autor;
                }
                set
                {                    
                    autor = value;
                }
            }

            public string PropertyTitol
            {
                get
                {
                    return titol;
                }
                set
                {
                    titol = value;
                }
            }

            public string PropertyUbicacio
            {
                get
                {
                    return ubicacio;
                }
                set
                {
                    ubicacio = value;
                }
            }
        }

        public class Coche
        {
            private string marca;
            private string modelo;
            private int cilindrada;
            private double potencia;

            public Coche(string mar,string mod,int cil,double pot)
            {
                marca = mar;
                modelo = mod;
                cilindrada = cil;
                potencia = pot;
            }

            public void escribir()
            {
                Console.WriteLine("El coxhe de marca {0} modelo {1} de cilindrada {2} y potencia {3}", marca, modelo, cilindrada,potencia);

            }
        }

        public class Persona
        {
            private string nom = "";
            private int edad = 0;
            private int DNI;
            private int pos = 0;
            private double peso = 0;
            private double altura = 0;
            private string[] sexo = { "H -> hombre", "M -> mujer" };

            public Persona(int D)
            {
                DNI = D;                
            }

            public Persona(string n, int e, int D, int sexo)
            {
                nom = n;
                edad = e;
                DNI = D;
                pos = sexo;
            }

            public Persona(string n,int e,int D,int sexo,double p,double a)
            {
                nom = n;
                edad = e;
                DNI = D;
                pos = sexo;
                peso = p;
                altura = a;
            }

            public void escribir()
            {
                Console.WriteLine("La persona {0} amb la edad {1} amb el DNI {2} de sexe {3} amb pes {4} i amb altura {5}", nom, edad, DNI, sexo[pos], peso, altura);
            }

        }

        public class Password
        {
            private int longitud = 8;
            private string contraseña = "";

            public Password()
            {
                generar();
            }

            public Password(int lon)
            {
                longitud = lon;
                generar();
            }

            private void generar()
            {
                for (int i = 0; i < longitud; i++)
                {
                    Random rnd = new Random();
                    contraseña = contraseña + (char)rnd.Next('a', 'z');
                }
            }

            public void escribir()
            {
                Console.WriteLine("La contraseña generada es {0}", contraseña);
            }
        }

        public class Electrodomestico
        {
            private double precio = 100;
            private string color = "blanco";
            private int pos = 5;
            private char[] consumo = { 'A','B','C','D','E','F'};
            private int peso = 5;
            private string[] opciones = { "blanco","negro","rojo","azul","gris" };

            public Electrodomestico()
            {

            }

            public Electrodomestico(int price, int pes)
            {
                precio = price;
                peso = pes;
            }

            public Electrodomestico(int price, int pes,int posi,string colour)
            {
                precio = price;
                peso = pes;
                pos = posi;
                color = comprovar(colour);
            }

            public string comprovar(string e)
            {
                bool trobat = false;

                foreach (string i in opciones)
                {
                    if (i.Equals(e))
                        trobat = true;
                }

                if (!trobat)
                    e = "Blanco";

                return e;
            }

            public void escribir()
            {
                Console.WriteLine("el producto de precio {0} de coler {1} con un consumo {2} y con peso {3}", precio,color,consumo[pos],peso);
            }

        }

        public class Serie
        {
            private string titulo = "";
            private int temporadas = 3;
            private bool entregado = false;
            private string genero = "";
            private string creador = "";

            public Serie()
            {

            }

            public Serie(string tit,string autor)
            {
                titulo = tit;
                creador = autor;
            }

            public Serie(string tit, string autor, int temp,bool entr)
            {
                titulo = tit;
                creador = autor;
                temporadas = temp;
                entregado = entr;
            }

            public void escribir()
            {
                if (entregado)
                    Console.WriteLine("La serie {0} con {1} temporadas de genero {2} del creador {3} ha sido entregada",titulo,temporadas,genero,creador);
                else
                    Console.WriteLine("La serie {0} con {1} temporadas de genero {2} del creador {3} no ha sido entregada", titulo, temporadas, genero, creador);
            }
        }

        static void Main(string[] args)
        {
            //ex1();

            //ex2();

            //ex3();

            //ex4();

            //ex5();

            //ex6();

            //ex7();

            //ex8();

            //ex9();

            //ex10();
        }
        public static void ex10()
        {
            Serie item1 = new Serie();
            item1.escribir();

            Serie item2 = new Serie("Ramoneta","Spilver");
            item2.escribir();

            Serie item3 = new Serie("Ramoneta", "Spilver",5,true);
            item3.escribir();
        }

        public static void ex9()
        {
            Electrodomestico new_item = new Electrodomestico();
            new_item.escribir();

            Electrodomestico new_item2 = new Electrodomestico(500, 10);
            new_item2.escribir();

            Electrodomestico new_item3 = new Electrodomestico(500, 10, 3, "naranja");
            new_item3.escribir();

        }

        public static void ex8()
        {
            Password pass = new Password();

            pass.escribir();

            Password pass2 = new Password(5);

            pass2.escribir();
        }

        public static void ex7()
        {
            Console.WriteLine("DNI de la persona?");
            String Kfake = Console.ReadLine();
            int DNI = Convert.ToInt32(Kfake);

            Persona nova = new Persona(DNI);

            nova.escribir();

            Console.WriteLine("Nombre de la persona?");
            String nom = Console.ReadLine();

            Console.WriteLine("Edad de la persona?");
            Kfake = Console.ReadLine();
            int edad = Convert.ToInt32(Kfake);

            Console.WriteLine("Sexo de la persona? 1) Hombre 2)Mujer");
            Kfake = Console.ReadLine();
            int pos = Convert.ToInt32(Kfake);

            Persona nova2 = new Persona(nom, edad, DNI, pos-1);
            nova2.escribir();

            Console.WriteLine("Peso de la persona?");
            Kfake = Console.ReadLine();
            double peso = Convert.ToDouble(Kfake);

            Console.WriteLine("Altura de la persona?");
            Kfake = Console.ReadLine();
            double altura = Convert.ToDouble(Kfake);

            Persona nova3 = new Persona(nom, edad, DNI, pos-1, peso, altura);
            nova3.escribir();
        }

        public static void ex6()
        {
            List<Coche> array = new List<Coche>();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Com es diu marca del coche?");
                String marca = Console.ReadLine();

                Console.WriteLine("Com es diu el model?");
                String modelo = Console.ReadLine();

                Console.WriteLine("cilindrada del coche?");
                String kfake = Console.ReadLine();
                int cilindrada = Convert.ToInt32(kfake);

                Console.WriteLine("potencia del coche?");
                String lfake = Console.ReadLine();
                double potencia = Convert.ToDouble(lfake);

                Coche e = new Coche(marca,modelo,cilindrada,potencia);

                array.Add(e);
            }

            foreach (Coche p in array)
                p.escribir();
        }

        public static void ex5()
        {

            Console.WriteLine("Com es diu el autor del llibre?");
            String nom = Console.ReadLine();
            
            Console.WriteLine("Com es diu el titol del llibre?");
            String titol = Console.ReadLine();

            Console.WriteLine("On es la ubicacio del llibre?");
            String ubicacio = Console.ReadLine();

            Libro new_item = new Libro(nom, titol, ubicacio);

            new_item.escriure();

            new_item.PropertyNom="Pep" ;
            new_item.PropertyUbicacio = "Venecia";

            new_item.escriure();
        }
        
        public static void ex4()
        {
            List<persona.Persona> array = new List<persona.Persona>();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Com es diu la persona?");
                String nom = Console.ReadLine();
            
                persona.Persona e = new persona.Persona(nom);

                array.Add(e);
            }

            foreach (persona.Persona p in array)
                p.Saludar();          
        }
    
        public static void ex3()
        {
            List<Operaciones> array = new List<Operaciones>();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Valor 1");
                String nom = Console.ReadLine();
                int valor1 = Convert.ToInt32(nom);

                Console.WriteLine("Valor 2");
                string kfake = Console.ReadLine();
                int valor2 = Convert.ToInt32(kfake);

                Operaciones e = new Operaciones(valor1, valor2);

                array.Add(e);
            }

            foreach (Operaciones p in array)
            {
                p.suma();
                p.resta();
                p.multi();
                p.division();
            }
        }

        public static void ex2()
        {
            List<Empleado> array = new List<Empleado>();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Com es diu el empleat?");
                String nom = Console.ReadLine();

                Console.WriteLine("Quin sou te?");
                string kfake = Console.ReadLine();
                int sou = Convert.ToInt32(kfake);

                Empleado e = new Empleado(nom, sou);

                array.Add(e);
            }

            foreach (Empleado p in array)
            {
                p.comprovant();
                p.escribir();
            }
        }

        public static void ex1()
        {
            List<Alumne> array = new List<Alumne>();

            for (int i = 0; i< 2; i++)
            {
                Console.WriteLine("Com es diu el alumne?");
                String nom = Console.ReadLine();

                Console.WriteLine("Quants anys te?");
                string kfake = Console.ReadLine();
                int edad = Convert.ToInt32(kfake);

                Alumne e = new Alumne(nom, edad);

                array.Add(e);
            }

            foreach (Alumne p in array)
                p.escribir();
        } 



    }
}
