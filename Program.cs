﻿using System;

namespace MiMascota
{
    // Definimos la clase MiMascota
    class MiMascota
    {
        // Atributos o propiedades privadas
        private string nombre;
        private int Edad;
        private string tipo; // "perro" o "gato"
        private string sonido; // "ladra", "maulla" o "ronrronea"

        // Constructor para inicializar los atributos de MiMascota
        public MiMascota(string nom, int dias, string ti, string sound)
        {
        	nombre =  nom;
        	diasDeVida =  dias;
        	tipo = ti;
            sonido = sound;
        }

        // Método público para mostrar la información de MiMascota
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Sonido: " + sonido);
        }
    }

    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de tipo MiMascota
            Producto MiMascota = new MiMascota("Hassel", 7, "perro", "ladra");

            // Mostrar la información del producto
            MiMascota.MostrarInformacion();

        }
    }
}