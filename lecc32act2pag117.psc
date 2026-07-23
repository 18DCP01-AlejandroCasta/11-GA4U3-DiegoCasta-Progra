Algoritmo lecc32act2pag117
	Definir mes, dia Como Entero
    Definir signo, horoscopoTexto Como Cadena
    
    Escribir "Ingrese su mes de nacimiento (1-12):"
    Leer mes
    Escribir "Ingrese su día de nacimiento (1-31):"
    Leer dia
    
    Si (mes = 3 Y dia >= 21) O (mes = 4 Y dia <= 19) Entonces
        signo <- "Aries"
        horoscopoTexto <- "Hoy es un gran día para iniciar nuevos proyectos."
    Sino Si (mes = 4 Y dia >= 20) O (mes = 5 Y dia <= 20) Entonces
			signo <- "Tauro"
			horoscopoTexto <- "La paciencia será tu mejor aliada para alcanzar tus metas."
		Sino Si (mes = 5 Y dia >= 21) O (mes = 6 Y dia <= 20) Entonces
				signo <- "Géminis"
				horoscopoTexto <- "Tu creatividad brillará; comparte tus ideas con los demás."
			Sino Si (mes = 6 Y dia >= 21) O (mes = 7 Y dia <= 22) Entonces
					signo <- "Cáncer"
					horoscopoTexto <- "Dedica tiempo a conectar con tu familia y seres queridos."
				Sino Si (mes = 7 Y dia >= 23) O (mes = 8 Y dia <= 22) Entonces
						signo <- "Leo"
						horoscopoTexto <- "Tu confianza te abrirá puertas importantes en lo personal."
					Sino Si (mes = 8 Y dia >= 23) O (mes = 9 Y dia <= 22) Entonces
							signo <- "Virgo"
							horoscopoTexto <- "El orden y la disciplina te traerán grandes resultados."
						Sino Si (mes = 9 Y dia >= 23) O (mes = 10 Y dia <= 22) Entonces
								signo <- "Libra"
								horoscopoTexto <- "Busca el equilibrio y la armonía en tu día a día."
							Sino Si (mes = 10 Y dia >= 23) O (mes = 11 Y dia <= 21) Entonces
									signo <- "Escorpio"
									horoscopoTexto <- "Tu intuición te guiará correctamente al tomar decisiones."
								Sino Si (mes = 11 Y dia >= 22) O (mes = 12 Y dia <= 21) Entonces
										signo <- "Sagitario"
										horoscopoTexto <- "Una buena oportunidad de aprendizaje se acerca."
									Sino Si (mes = 12 Y dia >= 22) O (mes = 1 Y dia <= 19) Entonces
											signo <- "Capricornio"
											horoscopoTexto <- "Tu esfuerzo constante pronto dará frutos positivos."
										Sino Si (mes = 1 Y dia >= 20) O (mes = 2 Y dia <= 18) Entonces
												signo <- "Acuario"
												horoscopoTexto <- "Sorprenderás a todos con tu visión original de las cosas."
											Sino Si (mes = 2 Y dia >= 19) O (mes = 3 Y dia <= 20) Entonces
													signo <- "Piscis"
													horoscopoTexto <- "Confía en tu empatía y sensibilidad para resolver conflictos."
												Sino
													signo <- "Fecha no válida"
													horoscopoTexto <- "Por favor, ingresa un día y mes válidos."
												FinSi
												
												Escribir "-------------------------------------------"
												Escribir "Tu signo zodiacal es: ", signo
												Escribir "Horóscopo: ", horoscopoTexto
												Escribir "-------------------------------------------"
FinAlgoritmo
