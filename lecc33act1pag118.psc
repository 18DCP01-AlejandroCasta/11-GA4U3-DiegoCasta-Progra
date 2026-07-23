Algoritmo lecc33act1pag118
	Dimension nombres[10]
    Dimension telefonos[10]
    Definir i, posicion Como Entero
    
    Escribir "=== REGISTRO DE AGENDA TELEFÓNICA ==="
    Para i <- 1 Hasta 10 Con Paso 1 Hacer
        Escribir "Contacto #", i, ":"
        Escribir "Nombre:"
        Leer nombres[i]
        Escribir "Teléfono:"
        Leer telefonos[i]
    FinPara
    
    Escribir "-------------------------------------------"
    Escribir "Ingrese la posición a consultar (1 al 10):"
    Leer posicion
    
    Si posicion >= 1 Y posicion <= 10 Entonces
        Escribir "[Contacto en posición ", posicion, "]"
        Escribir "Nombre:   ", nombres[posicion]
        Escribir "Teléfono: ", telefonos[posicion]
    Sino
        Escribir "Posición no válida. Debe ser entre 1 y 10."
    FinSi
FinAlgoritmo
