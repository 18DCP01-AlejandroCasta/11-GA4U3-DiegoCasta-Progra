Algoritmo lecc35act1inc2
	Definir precio, pago, cambio Como Entero
    Definir b200, b100, b50, b20, monedas Como Entero
    
    Escribir "Ingrese el precio del producto:"
    Leer precio
    
    Escribir "Ingrese el monto recibido (pago):"
    Leer pago
    
    Si pago < precio Entonces
        Escribir "Error: El dinero ingresado es insuficiente."
    Sino
        cambio <- pago - precio
        Escribir "Cambio total a devolver: $", cambio
        
        b200 <- TRUNC(cambio / 200)
        cambio <- cambio MOD 200
        
        b100 <- TRUNC(cambio / 100)
        cambio <- cambio MOD 100
        
        b50 <- TRUNC(cambio / 50)
        cambio <- cambio MOD 50
        
        b20 <- TRUNC(cambio / 20)
        cambio <- cambio MOD 20
        
        monedas <- cambio
        
        Escribir "Desglose del cambio:"
        Escribir "- Billetes de 200: ", b200
        Escribir "- Billetes de 100: ", b100
        Escribir "- Billetes de 50 : ", b50
        Escribir "- Billetes de 20 : ", b20
        Escribir "- Monedas        : ", monedas
    FinSi
FinAlgoritmo
