Algoritmo lecc35act1inc3
	Definir eleccionUsuario, eleccionComp Como Entero
    Definir respuesta Como Cadena
    
    Repetir
        Escribir "=== PIEDRA, PAPEL O TIJERAS ==="
        Escribir "1. Piedra"
        Escribir "2. Papel"
        Escribir "3. Tijeras"
        Escribir "Elija su opción (1-3):"
        Leer eleccionUsuario
        
        eleccionComp <- Aleatorio(1, 3)
        
        Escribir "Tú elegiste: ", eleccionUsuario
        Escribir "La computadora eligió: ", eleccionComp
        
        Si eleccionUsuario = eleccionComp Entonces
            Escribir "¡Es un EMPATE!"
        Sino Si (eleccionUsuario = 1 Y eleccionComp = 3) O (eleccionUsuario = 2 Y eleccionComp = 1) O (eleccionUsuario = 3 Y eleccionComp = 2) Entonces
				Escribir "¡Felicidades, GANASTE!"
			Sino
				Escribir "¡Gana la COMPUTADORA!"
			FinSi
			
			Escribir "¿Desea jugar de nuevo? (s/n):"
			Leer respuesta
		Hasta Que respuesta <> "s" Y respuesta <> "S"
FinAlgoritmo
