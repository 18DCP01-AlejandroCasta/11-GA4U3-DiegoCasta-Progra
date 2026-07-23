Algoritmo lecc35act1inc1
	Definir cantidadLocal, usd, eur, mxn, jpy, gbp Como Real
    Definir respuesta Como Cadena
    
    Repetir
        Escribir "Ingrese la cantidad en moneda local:"
        Leer cantidadLocal
        
        usd <- cantidadLocal * 0.13
        eur <- cantidadLocal * 0.12
        mxn <- cantidadLocal * 2.30
        jpy <- cantidadLocal * 20.5
        gbp <- cantidadLocal * 0.10
        
        Escribir "EQUIVALENCIA EN 5 PAÍSES"
        Escribir "1. Estados Unidos (USD): $", usd
        Escribir "2. Unión Europea (EUR) : ?", eur
        Escribir "3. México (MXN)        : $", mxn
        Escribir "4. Japón (JPY)         : ¥", jpy
        Escribir "5. Reino Unido (GBP)   : £", gbp
        
        Escribir "¿Desea convertir otra cantidad? (s/n):"
        Leer respuesta
    Hasta Que respuesta <> "s" Y respuesta <> "S"
FinAlgoritmo
