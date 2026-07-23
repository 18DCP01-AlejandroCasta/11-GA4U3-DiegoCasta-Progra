Algoritmo lecc34act1inc2
	Definir peso, altura, imc Como Real
    
    Escribir "Ingrese su peso en kilogramos (kg):"
    Leer peso
    
    Escribir "Ingrese su altura en metros (m):"
    Leer altura
    
    imc <- peso / (altura * altura)
    
    Escribir "---------------------------------------"
    Escribir "Su IMC es: ", imc
    
    Si imc < 18.5 Entonces
        Escribir "Estado: Bajo peso"
	FinSi
	
    Si imc >= 18.5 Y imc < 25 Entonces
		Escribir "Estado: Peso normal"
	FinSi
	
    Si imc >= 25 Y imc < 30 Entonces
				Escribir "Estado: Sobrepeso"
			Sino
				Escribir "Estado: Obesidad"
			FinSi
FinAlgoritmo
