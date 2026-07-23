Algoritmo lec32act3pag117
	Definir lado1, lado2, lado3 Como Real
    
    Escribir "Ingrese la longitud del primer lado:"
    Leer lado1
    Escribir "Ingrese la longitud del segundo lado:"
    Leer lado2
    Escribir "Ingrese la longitud del tercer lado:"
    Leer lado3
    
    Si (lado1 = lado2 Y lado2 = lado3) Entonces
        Escribir "El triángulo es EQUILÁTERO (3 lados iguales)."
	FinSi
	
    Si (lado1 <> lado2 Y lado2 <> lado3 Y lado1 <> lado3) Entonces
			Escribir "El triángulo es ESCALENO (3 lados desiguales)."
		Sino
			Escribir "El triángulo es ISÓSCELES (2 lados iguales)."
		FinSi
FinAlgoritmo
