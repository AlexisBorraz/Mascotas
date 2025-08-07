﻿using System;

namespace MiMascota
{
    // Definimos la clase MiMascota
    class MiMascota
    {
        // Atributos privados
        private string nombre;
        private int edad; // 1-25
        private string tipo; // "perro" o "gato"
        private string sonido;

        // Constructor
        public MiMascota(string nom, int ed, string ti, string sound)
        {
            nombre = nom;
            edad = ed;
            tipo = ti.ToLower();
            sonido = sound;
        }

        // Método MostrarInformación
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Sonido: " + sonido);
        }

        // Método GetEdad
        public int GetEdad()
        {
            return edad;
        }

        // Método SetEdad
        public void SetEdad(int nuevaEdad)
        {
            if (nuevaEdad >= 0 && nuevaEdad <= 25)
            {
                edad = nuevaEdad;
            }
            else
            {
                Console.WriteLine("Edad inválida. Debe estar entre 0 y 25.");
            }
        }

        // Método CalcularEdadHumana
        public int CalcularEdadHumana()
        {
            if (tipo == "perro")
            {
                return edad * 7;
            }
            else if (tipo == "gato")
            {
                return edad * 6;
            }
            else
            {
                return edad; // si no se reconoce el tipo
            }
        }

        // Método de ejemplo adicional: hacer jugo (no es propio de mascota, solo de ejemplo)
        public void HacerJugo(string fruta)
        {
            Console.WriteLine($"{nombre} ha hecho jugo de {fruta} (aunque no tenga mucho sentido jaja)");
        }
    }

    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            // Mascota 1
            MiMascota m1 = new MiMascota("Hassel", 7, "perro", "ladra");
            m1.MostrarInformacion();
            Console.WriteLine("Edad humana: " + m1.CalcularEdadHumana());

            // Cambiando edad
            Console.WriteLine("Cambiando edad de Hassel...");
            m1.SetEdad(5);
            Console.WriteLine("Nueva edad: " + m1.GetEdad());
            Console.WriteLine("Nueva edad humana: " + m1.CalcularEdadHumana());

            m1.HacerJugo("naranja");
            Console.WriteLine();

            // Mascota 2
            MiMascota m2 = new MiMascota("Pelusa", 3, "gato", "maulla");
            m2.MostrarInformacion();
            Console.WriteLine("Edad humana: " + m2.CalcularEdadHumana());

            // Cambiar edad de m2
            Console.WriteLine("Cambiando edad de Pelusa...");
            Console.WriteLine("Edad humana antes: " + m2.CalcularEdadHumana());

            m2.SetEdad(4);

            Console.WriteLine("Nueva edad: " + m2.GetEdad());
            Console.WriteLine("Edad humana después: " + m2.CalcularEdadHumana());
            Console.WriteLine();

            // Mascota 3
            MiMascota m3 = new MiMascota("Patán", 5, "gato", "ronronea");
            m3.MostrarInformacion();
            Console.WriteLine("Edad humana: " + m3.CalcularEdadHumana());

            // Cambiar edad de m3
            Console.WriteLine("Cambiando edad de Patán...");
            Console.WriteLine("Edad humana antes: " + m3.CalcularEdadHumana());

            m3.SetEdad(4);

            Console.WriteLine("Nueva edad: " + m3.GetEdad());
            Console.WriteLine("Edad humana después: " + m3.CalcularEdadHumana());
        }
    }
}
