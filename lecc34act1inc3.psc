Algoritmo lecc34act1inc3
	Definir celsius, fahrenheit, kelvin Como Real
    Definir op Como Cadena
    
    Escribir "Ingrese la temperatura en grados Centígrados (°C):"
    Leer celsius
    
    Escribir "¿A qué unidad desea convertir?"
    Escribir "a) Fahrenheit"
    Escribir "b) Celsius"
    Escribir "c) Kelvin"
    Leer op
    
    Segun opcion Hacer
        "a", "A":
            fahrenheit <- (celsius * 9 / 5) + 32
            Escribir celsius, " °C equivalen a ", fahrenheit, " °F."
        "b", "B":
            Escribir celsius, " °C equivalen a ", celsius, " °C."
        "c", "C":
            kelvin <- celsius + 273.15
            Escribir celsius, " °C equivalen a ", kelvin, " K."
        De Otro Modo:
            Escribir "Opción no válida."
    FinSegun
FinAlgoritmo
