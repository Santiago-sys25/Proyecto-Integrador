
Algoritmo AsistenteComponentes
    Definir cpuNom, cpuSock, plNom, plSock, plTipo, ramNom, ramTipo Como Caracter
    Definir sintoma, causa, accion Como Caracter
    Definir cpuPre, cpuW, plPre, ramPre, ramGB Como Entero
    Definir opcion, uso, minRAM, i, j, k, mejorC, mejorP, mejorR, s, consumo, recomendado Como Entero
    Definir presupuesto, total, mejorTotal Como Real
    Dimension cpuNom[3], cpuSock[3], cpuPre[3], cpuW[3]
    Dimension plNom[3], plSock[3], plTipo[3], plPre[3]
    Dimension ramNom[3], ramTipo[3], ramGB[3], ramPre[3]
    Dimension sintoma[5], causa[5], accion[5]


    cpuNom[1] <- "CPU AM4 basico"
    cpuSock[1] <- "AM4"
    cpuPre[1] <- 280000
    cpuW[1] <- 65
    cpuNom[2] <- "CPU AM4 intermedio"
    cpuSock[2] <- "AM4"
    cpuPre[2] <- 450000
    cpuW[2] <- 65
    cpuNom[3] <- "CPU AM5 intermedio"
    cpuSock[3] <- "AM5"
    cpuPre[3] <- 650000
    cpuW[3] <- 105
    plNom[1] <- "Placa AM4 DDR4"
    plSock[1] <- "AM4"
    plTipo[1] <- "DDR4"
    plPre[1] <- 350000
    plNom[2] <- "Placa AM4 DDR4 mATX"
    plSock[2] <- "AM4"
    plTipo[2] <- "DDR4"
    plPre[2] <- 300000
    plNom[3] <- "Placa AM5 DDR5"
    plSock[3] <- "AM5"
    plTipo[3] <- "DDR5"
    plPre[3] <- 650000
    ramNom[1] <- "RAM DDR4 8 GB"
    ramTipo[1] <- "DDR4"
    ramGB[1] <- 8
    ramPre[1] <- 90000
    ramNom[2] <- "RAM DDR4 16 GB"
    ramTipo[2] <- "DDR4"
    ramGB[2] <- 16
    ramPre[2] <- 160000
    ramNom[3] <- "RAM DDR5 16 GB"
    ramTipo[3] <- "DDR5"
    ramGB[3] <- 16
    ramPre[3] <- 220000
    sintoma[1] <- "El equipo esta lento"
    causa[1]   <- "CPU, RAM, almacenamiento o software"
    accion[1]  <- "Revisar programas de inicio y el uso de RAM, CPU y disco."
    sintoma[2] <- "El equipo se calienta"
    causa[2]   <- "Disipador, ventiladores o fuente"
    accion[2]  <- "Limpiar el polvo y verificar que los ventiladores giren."
    sintoma[3] <- "El equipo no enciende"
    causa[3]   <- "Fuente, placa base, RAM o conexiones"
    accion[3]  <- "Revisar cables, toma electrica y reasentar la RAM."
    sintoma[4] <- "No hay imagen en el monitor"
    causa[4]   <- "Monitor, GPU o cableado"
    accion[4]  <- "Probar otro cable o puerto de video."
    sintoma[5] <- "Olor a quemado"
    causa[5]   <- "Fuente o componentes electricos"
    accion[5]  <- "ALERTA: apagar, desconectar y buscar asistencia tecnica."


    Repetir
        Escribir ""
        Escribir "===== ASISTENTE DE COMPONENTES ====="
        Escribir "1. Recomendar placa, CPU y RAM (segun perfil y presupuesto)"
        Escribir "2. Diagnosticar un problema"
        Escribir "3. Estimar la fuente de poder necesaria"
        Escribir "4. Salir"
        Repetir
            Escribir Sin Saltar "Opcion (1-4): "
            Leer opcion
            Si opcion < 1 O opcion > 4 Entonces
                Escribir "Opcion invalida."
            FinSi
        Hasta Que opcion >= 1 Y opcion <= 4

        Segun opcion Hacer
            1:
   
                Escribir "Perfil: 1. Oficina  2. Programacion  3. Videojuegos"
                Repetir
                    Escribir Sin Saltar "Seleccione (1-3): "
                    Leer uso
                Hasta Que uso >= 1 Y uso <= 3
                Si uso = 1 Entonces
                    minRAM <- 8
                Sino
                    minRAM <- 16
                FinSi
                Repetir
                    Escribir Sin Saltar "Presupuesto en COP (mayor que 0): "
                    Leer presupuesto
                Hasta Que presupuesto > 0

                mejorTotal <- 0
                mejorC <- 0
                mejorP <- 0
                mejorR <- 0
                Para j <- 1 Hasta 3 Con Paso 1 Hacer
                    Para i <- 1 Hasta 3 Con Paso 1 Hacer
                        Para k <- 1 Hasta 3 Con Paso 1 Hacer
                            // Reglas: mismo socket, mismo tipo de RAM y RAM minima del perfil
                            Si cpuSock[i] = plSock[j] Y plTipo[j] = ramTipo[k] Y ramGB[k] >= minRAM Entonces
                                total <- plPre[j] + cpuPre[i] + ramPre[k]
                                Si total <= presupuesto Y total > mejorTotal Entonces
                                    mejorTotal <- total
                                    mejorC <- i
                                    mejorP <- j
                                    mejorR <- k
                                FinSi
                            FinSi
                        FinPara
                    FinPara
                FinPara

                Si mejorC = 0 Entonces
                    Escribir "No hay una combinacion compatible dentro del presupuesto."
                Sino
                    Escribir "Placa base: ", plNom[mejorP], " - $", plPre[mejorP]
                    Escribir "Procesador: ", cpuNom[mejorC], " - $", cpuPre[mejorC]
                    Escribir "Memoria RAM: ", ramNom[mejorR], " - $", ramPre[mejorR]
                    Escribir "Total: $", mejorTotal
                    Escribir "Dinero restante: $", presupuesto - mejorTotal
                    Escribir "Verifique BIOS, gabinete y fuente antes de comprar."
                FinSi
            2:
				
                Escribir "Seleccione el sintoma:"
                Para s <- 1 Hasta 5 Con Paso 1 Hacer
                    Escribir s, ". ", sintoma[s]
                FinPara
                Repetir
                    Escribir Sin Saltar "Sintoma (1-5): "
                    Leer s
                Hasta Que s >= 1 Y s <= 5
                Escribir "Posibles causas: ", causa[s]
                Escribir "Orientacion: ", accion[s]
                Escribir "Son causas posibles, no una confirmacion de falla."
            3:
                Escribir Sin Saltar "Consumo del procesador en W: "
                Leer consumo
                consumo <- consumo + 100
                recomendado <- trunc((consumo * 13 + 9) / 10)
                Escribir "Potencia recomendada de la fuente: ", recomendado, " W"
                Escribir "Es una estimacion preliminar, no una certificacion electrica."
            4:
                Escribir "Fin del programa."
        FinSegun
    Hasta Que opcion = 4
FinAlgoritmo
