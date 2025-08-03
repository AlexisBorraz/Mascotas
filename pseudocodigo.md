Inicio del programa

Definir clase MiMascota
    Atributos privados:
        - nombre (cadena)
        - Edad (entero)
        - tipo (cadena) // Puede ser "perro" o "gato"
        - sonido (cadena) // Puede ser "ladra", "maulla" o "ronronea"

    Método Constructor MiMascota(nom, ed, tip)
        Asignar nom a nombre
        Asignar ed a Edad
        Asignar tip a tipo
        Asignar sound a sonido

    Método MostrarInformacion()
        Imprimir "Nombre: " + nombre
        Imprimir "Edad: " + Edad
        Imprimir "Tipo: " + tipo
        Imprimir "Sonido: " + sonido
Fin clase Producto

Definir clase principal Program
    Método Main()
        Crear objeto miMascota de tipo MiMascota con valores:
            - nombre = "Hassel"
            - Edad = 7
            - tipo = "perro"
            - sonido = "ladra"

        Llamar al método MostrarInformacion() del objeto miMascota
Fin clase Program

Fin del programa
