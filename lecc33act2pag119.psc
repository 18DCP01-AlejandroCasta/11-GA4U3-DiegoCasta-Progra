Algoritmo lecc33act2pag119
	Definir frase, textoInvertido Como Cadena
    Definir i, len Como Entero
    
    Escribir "Ingrese una frase:"
    Leer frase
    
    textoInvertido <- ""
    len <- Longitud(frase)
    
    Para i <- len Hasta 1 Con Paso -1 Hacer
	textoInvertido <- Concatenar(textoInvertido, Subcadena(frase, i, i))
    FinPara
    
    Escribir "Frase original:  ", frase
    Escribir "Frase invertida: ", textoInvertido
FinAlgoritmo
