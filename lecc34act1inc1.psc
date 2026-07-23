Algoritmo lecc34act1inc1
	Definir opcion, numDecimal, residuo, baseValor, i Como Entero
    Definir binarioStr Como Cadena
    
    Escribir "CONVERTIDOR DECIMAL o BINARIO"
    Escribir "1. Convertir de Decimal a Binario"
    Escribir "2. Convertir de Binario a Decimal"
    Escribir "(1 o 2):"
    Leer opcion
    
    Si opcion = 1 Entonces
        Escribir "Ingrese un número entero decimal positivo:"
        Leer numDecimal
	Finsi
        
        Si numDecimal = 0 Entonces
            binarioStr <- "0"
        Sino
            binarioStr <- ""
            Mientras numDecimal > 0 Hacer
                residuo <- numDecimal MOD 2
                binarioStr <- Concatenar(ConvertirATexto(residuo), binarioStr)
                numDecimal <- TRUNC(numDecimal / 2)
            FinMientras
        FinSi
        Escribir "El número en binario es: ", binarioStr
        
    Si opcion = 2 Entonces
			Escribir "Ingrese un número binario (solo 0s y 1s):"
			Leer binarioStr
			
			numDecimal <- 0
			baseValor <- 1
			
			Para i <- Longitud(binarioStr) Hasta 1 Con Paso -1 Hacer
				Si Subcadena(binarioStr, i, i) = "1" Entonces
					numDecimal <- numDecimal + baseValor
				FinSi
				baseValor <- baseValor * 2
			FinPara
			
			Escribir "El número en decimal es: ", numDecimal
		Sino
			Escribir "Opción no válida."
		FinSi
FinAlgoritmo
