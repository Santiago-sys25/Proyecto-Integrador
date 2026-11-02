using System;

class Program
{
    // Catalogo: los arreglos paralelos comparten el mismo indice.
    // Los precios y consumos son ilustrativos; no representan modelos comerciales exactos.

    static string[] nombres =
    {
        "CPU AM4 basico", "CPU AM4 intermedio", "CPU AM5 intermedio",
        "RAM DDR4 8 GB", "RAM DDR4 16 GB", "RAM DDR5 16 GB",
        "SSD SATA 480 GB", "SSD NVMe 500 GB", "SSD NVMe 1 TB",
        "GPU basica", "GPU intermedia", "GPU superior",
        "Placa AM4 DDR4", "Placa AM5 DDR5", "Fuente 650 W",
        "CPU AM4 con graficos integrados", "CPU Intel LGA1700 basico", "CPU Intel LGA1700 intermedio",
        "RAM DDR4 32 GB", "RAM DDR5 32 GB",
        "Fuente 550 W", "Fuente 750 W", "Fuente 850 W",
        "HDD SATA 1 TB", "HDD SATA 2 TB",
        "Placa AM4 DDR4 mATX basica", "Placa AM4 DDR4 ATX con Wi-Fi",
        "Placa AM5 DDR5 mATX con Wi-Fi", "Placa LGA1700 DDR4 mATX", "Placa LGA1700 DDR5 ATX con Wi-Fi",
        "Gabinete ATX (acepta ATX y mATX)", "Gabinete mATX compacto",
        "Disipador CPU AM4", "Disipador CPU AM5", "Disipador CPU LGA1700",
        "Tarjeta Wi-Fi PCIe", "Monitor 24 pulgadas", "Teclado", "Mouse"
    };

    static string[] categorias =
    {
        "CPU","CPU","CPU","RAM","RAM","RAM","SSD","SSD","SSD","GPU","GPU","GPU",
        "Placa","Placa","Fuente","CPU","CPU","CPU","RAM","RAM","Fuente","Fuente","Fuente",
        "HDD","HDD","Placa","Placa","Placa","Placa","Placa","Gabinete","Gabinete",
        "Disipador","Disipador","Disipador","Wifi","Monitor","Teclado","Mouse"
    };

    static decimal[] precios =
    {
        280000m,450000m,650000m,90000m,160000m,220000m,100000m,160000m,280000m,
        350000m,800000m,1500000m,350000m,650000m,250000m,330000m,320000m,600000m,
        300000m,420000m,210000m,300000m,380000m,170000m,240000m,300000m,450000m,
        600000m,380000m,700000m,230000m,150000m,90000m,110000m,100000m,80000m,
        550000m,60000m,40000m
    };

    static string[] socket =
    {
        "AM4", "AM4", "AM5", "", "", "", "", "", "", "", "", "", "AM4", "AM5", "", "AM4", "LGA1700", "LGA1700", "", "", "", "", "", "", "", "AM4", "AM4", "AM5", "LGA1700", "LGA1700", "", "", "AM4", "AM5", "LGA1700", "", "", "", ""
    };

    static string[] tipoRAM =
    {
        "", "", "", "DDR4", "DDR4", "DDR5", "", "", "", "", "", "", "DDR4", "DDR5", "", "", "", "", "DDR4", "DDR5", "", "", "", "", "", "DDR4", "DDR4", "DDR5", "DDR4", "DDR5", "", "", "", "", "", "", "", "", ""
    };

    // En placas: SATA+NVMe significa que admite ambos tipos.
    // En unidades: SATA o NVMe indica su interfaz.
    static string[] interfazSSD =
    {
        "","","","","","","SATA","NVMe","NVMe","","","","SATA+NVMe","SATA+NVMe","",
        "","","","","","","","","SATA","SATA","SATA","SATA+NVMe","SATA+NVMe",
        "SATA+NVMe","SATA+NVMe","","","","","","","","",""
    };

    static int[] capacidadGB =
    {
        0,0,0,8,16,16,480,500,1000,0,0,0,0,0,0,0,0,0,32,32,
        0,0,0,1000,2000,0,0,0,0,0,0,0,0,0,0,0,0,0,0
    };

    static string[] formato =
    {
        "","","","","","","","","","","","","ATX","ATX","","","","","","",
        "","","","","","mATX","ATX","mATX","mATX","ATX","ATX","mATX",
        "","","","","","",""
    };

    static int[] potenciaW =
    {
        65,65,105,0,0,0,0,0,0,120,220,320,0,0,650,65,65,125,0,0,
        550,750,850,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
    };

    static string[] graficosIntegrados =
    {
        "No","No","Si","","","","","","","","","","","","",
        "Si","Si","Si","","","","","","","","","","","","",
        "","","","","","","","",""
    };

    static string[] incluyeDisipador =
    {
        "Si","Si","No","","","","","","","","","","","","",
        "Si","Si","No","","","","","","","","","","","","",
        "","","","","","","","",""
    };

    static string[] wifiIntegrado =
    {
        "","","","","","","","","","","","","No","No","","","","","","",
        "","","","","","No","Si","Si","No","Si","","","","","","","","",""
    };

    static string[] usos =
    {
        "Oficina y uso diario","Programacion","Videojuegos","Diseno y tareas graficas"
    };

    static string[] problemas =
    {
        "El equipo esta lento","El disco esta casi lleno","La memoria RAM parece insuficiente",
        "El equipo se calienta","No enciende","Se reinicia","No hay imagen","Hace mucho ruido",
        "Los programas tardan en abrir","No reconoce el almacenamiento","Pantallazo azul",
        "Se congela o no responde","Pitidos al encender","Se apaga solo",
        "Rayas o fallos de imagen en pantalla","Bajo rendimiento en juegos",
        "Ventiladores giran, pero no arrancan","La hora y la fecha se desconfiguran",
        "El disco hace ruidos de clic","No hay sonido","Sin internet o Wi-Fi",
        "Los puertos USB no reconocen dispositivos","Olor a quemado"
    };

    static string[] categoriasProblema =
    {
        "Rendimiento","Almacenamiento","Memoria","Temperatura","Alimentacion","Estabilidad",
        "Video","Refrigeracion","Rendimiento","Almacenamiento","Sistema","Estabilidad",
        "Arranque","Alimentacion","Video","Videojuegos","Arranque","Placa base",
        "Almacenamiento","Audio","Conectividad","Conectividad","Seguridad electrica"
    };

    static string[] soluciones =
    {
        "Revisar programas de inicio, uso de CPU, RAM y almacenamiento.",
        "Revisar espacio disponible y considerar mayor capacidad de almacenamiento.",
        "Revisar consumo de memoria y compatibilidad antes de ampliar la RAM.",
        "Revisar ventilacion y temperaturas; solicitar limpieza tecnica si es necesario.",
        "Revisar toma electrica, cableado y fuente con ayuda tecnica.",
        "Revisar temperaturas, memoria, controladores y alimentacion.",
        "Revisar cable, monitor, GPU y conexiones.",
        "Revisar ventiladores y posibles vibraciones.",
        "Revisar almacenamiento, RAM y programas en segundo plano.",
        "Verificar conexiones, interfaz y estado de la unidad.",
        "Revisar controladores, memoria y temperaturas; analizar el codigo de error.",
        "Revisar temperaturas, RAM y estado del almacenamiento.",
        "Consultar el codigo de pitidos en el manual de la placa.",
        "Revisar temperaturas y fuente mediante asistencia tecnica.",
        "Revisar cable, monitor, controladores y GPU.",
        "Comprobar requisitos del juego, uso de GPU/CPU y controladores.",
        "Revisar RAM, conexiones y fuente con asistencia tecnica.",
        "Revisar la pila CMOS y la configuracion de la placa.",
        "Hacer copia de seguridad cuanto antes; podria existir una falla del HDD.",
        "Revisar controladores de audio y conexiones.",
        "Revisar adaptador, controladores y router.",
        "Revisar controladores y conexiones USB.",
        "Apagar y desconectar de inmediato. No volver a encender ni abrir la fuente; buscar asistencia tecnica."
    };

    static bool alternativaAceptada = false;

    // PRESENTACION
    static void Encabezado(string titulo)
    {
        int ancho = Math.Max(50, titulo.Length + 4);
        int izq = (ancho - titulo.Length) / 2;
        int der = ancho - titulo.Length - izq;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("╔" + new string('═', ancho) + "╗");
        Console.WriteLine("║" + new string(' ', izq) + titulo + new string(' ', der) + "║");
        Console.WriteLine("╚" + new string('═', ancho) + "╝");
        Console.ResetColor();
        Console.WriteLine();
    }

    // ENTRADAS
    static int LeerEntero(string mensaje, int minimo, int maximo)
    {
        int valor;
        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out valor) && valor >= minimo && valor <= maximo)
                return valor;
            Console.WriteLine("Entrada invalida. Escriba un numero entre " + minimo + " y " + maximo + ".");
        }
    }

    static decimal LeerPresupuesto()
    {
        decimal valor;
        while (true)
        {
            Console.Write("Ingrese su presupuesto en COP (mayor que 0): ");
            if (decimal.TryParse(Console.ReadLine(), out valor) && valor > 0)
                return valor;
            Console.WriteLine("Presupuesto invalido. Ingrese un valor numerico mayor que cero.");
        }
    }

    static bool PreguntarSiNo(string pregunta)
    {
        Console.WriteLine(pregunta);
        Console.WriteLine("1. Si");
        Console.WriteLine("2. No");
        return LeerEntero("Opcion (1 o 2): ", 1, 2) == 1;
    }

    static int LeerUso()
    {
        Console.WriteLine("Cual es el uso principal?");
        for (int i = 0; i < usos.Length; i++)
            Console.WriteLine((i + 1) + ". " + usos[i]);
        return LeerEntero("Seleccione (1-" + usos.Length + "): ", 1, usos.Length);
    }

    // CATALOGO Y CONSULTAS
    static bool VerificarCatalogo()
    {
        int n = nombres.Length;
        return categorias.Length == n && precios.Length == n && socket.Length == n &&
            tipoRAM.Length == n && interfazSSD.Length == n && capacidadGB.Length == n &&
            formato.Length == n && potenciaW.Length == n && graficosIntegrados.Length == n &&
            incluyeDisipador.Length == n && wifiIntegrado.Length == n &&
            problemas.Length == soluciones.Length && problemas.Length == categoriasProblema.Length;
    }

    static int ContarCategoria(string categoria)
    {
        int cantidad = 0;
        for (int i = 0; i < categorias.Length; i++)
            if (categorias[i] == categoria) cantidad++;
        return cantidad;
    }

    static int IndiceCategoria(string categoria, int n)
    {
        int contador = 0;
        for (int i = 0; i < categorias.Length; i++)
        {
            if (categorias[i] == categoria)
            {
                if (contador == n) return i;
                contador++;
            }
        }
        return -1;
    }

    static decimal SumarSiExiste(int indice)
    {
        return indice >= 0 && indice < precios.Length ? precios[indice] : 0m;
    }

    static void MostrarLinea(string etiqueta, int indice)
    {
        if (indice >= 0 && indice < nombres.Length)
            Console.WriteLine("- " + etiqueta + ": " + nombres[indice] + " - $" + precios[indice] + " COP");
    }

    static int ListarCategoria(string categoria)
    {
        int cantidad = ContarCategoria(categoria);
        for (int i = 0; i < cantidad; i++)
        {
            int indice = IndiceCategoria(categoria, i);
            Console.WriteLine((i + 1) + ". " + nombres[indice] + " - $" + precios[indice] + " COP");
        }
        return cantidad;
    }

    // COMPATIBILIDAD: false significa incompatible o no demostrable con el catalogo.
    static bool CompatibleCPUPlaca(int cpu, int placa)
    {
        return cpu >= 0 && placa >= 0 && socket[cpu] != "" &&
            socket[placa] != "" && socket[cpu] == socket[placa];
    }

    static bool CompatibleRAMPlaca(int ram, int placa)
    {
        return ram >= 0 && placa >= 0 && tipoRAM[ram] != "" &&
            tipoRAM[placa] != "" && tipoRAM[ram] == tipoRAM[placa];
    }

    static bool PlacaAdmiteNVMe(int placa)
    {
        return placa >= 0 && interfazSSD[placa].Contains("NVMe");
    }

    static bool PlacaAdmiteSATA(int placa)
    {
        return placa >= 0 && interfazSSD[placa].Contains("SATA");
    }

    static bool CompatibleSSD(int ssd, int placa)
    {
        if (ssd < 0 || placa < 0) return false;
        if (interfazSSD[ssd] == "SATA") return PlacaAdmiteSATA(placa);
        if (interfazSSD[ssd] == "NVMe") return PlacaAdmiteNVMe(placa);
        return false;
    }

    static bool CompatibleCajaPlaca(int caja, int placa)
    {
        if (caja < 0 || placa < 0 || formato[caja] == "" || formato[placa] == "")
            return false;
        if (formato[caja] == "ATX") return true;
        return formato[caja] == "mATX" && formato[placa] == "mATX";
    }

    static int EstimarPotencia(int cpu, int gpu)
    {
        int consumo = potenciaW[cpu] + 100;
        if (gpu >= 0) consumo += potenciaW[gpu];
        return (consumo * 13 + 9) / 10;
    }

    static int ElegirFuente(int vatiosNecesarios)
    {
        int mejor = -1;
        for (int i = 0; i < nombres.Length; i++)
            if (categorias[i] == "Fuente" && potenciaW[i] >= vatiosNecesarios &&
                (mejor == -1 || potenciaW[i] < potenciaW[mejor]))
                mejor = i;
        return mejor;
    }

    static int BuscarMasBarato(string categoria, int cpu, int placa)
    {
        int mejor = -1;
        for (int i = 0; i < nombres.Length; i++)
        {
            if (categorias[i] != categoria) continue;
            bool sirve = false;
            if (categoria == "Disipador")
                sirve = socket[i] != "" && socket[i] == socket[cpu];
            else if (categoria == "Gabinete")
                sirve = CompatibleCajaPlaca(i, placa);

            if (sirve && (mejor == -1 || precios[i] < precios[mejor])) mejor = i;
        }
        return mejor;
    }

    static int IndiceTarjetaWifi(int placa, bool quiereWifi)
    {
        if (placa < 0 || !quiereWifi || wifiIntegrado[placa] == "Si") return -1;
        if (wifiIntegrado[placa] == "No") return IndiceCategoria("Wifi", 0);
        return -1;
    }

    // PERFILES: criterios verificables con los campos existentes.
    // No se atribuye rendimiento comparativo a CPU/GPU porque el catalogo no contiene benchmarks.
    static bool CumplePerfil(int uso, int cpu, int ram, int ssd, int gpu, int placa)
    {
        if (!CompatibleCPUPlaca(cpu, placa) || !CompatibleRAMPlaca(ram, placa) ||
            !CompatibleSSD(ssd, placa)) return false;

        if (uso == 1)
            return capacidadGB[ram] >= 8 && (graficosIntegrados[cpu] == "Si" || gpu >= 0);
        if (uso == 2)
            return capacidadGB[ram] >= 16 && capacidadGB[ssd] >= 480 &&
                (graficosIntegrados[cpu] == "Si" || gpu >= 0);
        if (uso == 3)
            return capacidadGB[ram] >= 16 && gpu >= 0;
        if (uso == 4)
            return capacidadGB[ram] >= 32 && gpu >= 0;
        return false;
    }

    static string TextoPerfil(int uso)
    {
        if (uso == 1) return "Minimo verificable: 8 GB RAM y almacenamiento SSD; graficos integrados o dedicados.";
        if (uso == 2) return "Minimo verificable: 16 GB RAM y SSD; no se dispone de benchmarks para medir velocidad de CPU.";
        if (uso == 3) return "Minimo verificable: 16 GB RAM y GPU dedicada; el catalogo no registra resolucion ni FPS.";
        return "Minimo verificable: 32 GB RAM y GPU dedicada; el catalogo no registra memoria de video ni rendimiento profesional.";
    }

    // BUSQUEDA DE EQUIPO NUEVO
    // [0] CPU [1] RAM [2] SSD [3] GPU [4] placa [5] fuente [6] caja
    // [7] disipador [8] wifi [9] combinaciones validas dentro del presupuesto.
    static decimal BuscarMejorEquipo(int uso, decimal presupuestoTorre, bool quiereWifi, int[] mejor)
    {
        for (int i = 0; i < mejor.Length; i++) mejor[i] = -1;
        mejor[9] = 0;
        decimal mejorPrecio = 0m;
        int cantidadCPU = ContarCategoria("CPU");
        int cantidadRAM = ContarCategoria("RAM");
        int cantidadSSD = ContarCategoria("SSD");
        int cantidadGPU = ContarCategoria("GPU");
        int cantidadPlaca = ContarCategoria("Placa");

        for (int a = 0; a < cantidadCPU; a++)
        for (int b = 0; b < cantidadRAM; b++)
        for (int d = 0; d < cantidadSSD; d++)
        for (int e = -1; e < cantidadGPU; e++)
        for (int f = 0; f < cantidadPlaca; f++)
        {
            int cpu = IndiceCategoria("CPU", a);
            int ram = IndiceCategoria("RAM", b);
            int ssd = IndiceCategoria("SSD", d);
            int gpu = e < 0 ? -1 : IndiceCategoria("GPU", e);
            int placa = IndiceCategoria("Placa", f);

            // Oficina/programacion priorizan graficos integrados; juegos/diseno exigen GPU.
            if ((uso <= 2 && (gpu >= 0 || graficosIntegrados[cpu] != "Si")) ||
                (uso >= 3 && gpu < 0)) continue;

            if (!CumplePerfil(uso, cpu, ram, ssd, gpu, placa)) continue;

            int caja = BuscarMasBarato("Gabinete", cpu, placa);
            int fuente = ElegirFuente(EstimarPotencia(cpu, gpu));
            int disipador = incluyeDisipador[cpu] == "Si" ? -1 : BuscarMasBarato("Disipador", cpu, placa);
            int wifi = IndiceTarjetaWifi(placa, quiereWifi);

            if (caja < 0 || fuente < 0 ||
                (incluyeDisipador[cpu] != "Si" && disipador < 0) ||
                (quiereWifi && wifiIntegrado[placa] != "Si" && wifi < 0)) continue;

            decimal total = precios[cpu] + precios[ram] + precios[ssd] + precios[placa] +
                precios[caja] + precios[fuente] + SumarSiExiste(gpu) +
                SumarSiExiste(disipador) + SumarSiExiste(wifi);

            if (total <= presupuestoTorre)
            {
                mejor[9]++;
                if (total > mejorPrecio)
                {
                    mejorPrecio = total;
                    mejor[0] = cpu; mejor[1] = ram; mejor[2] = ssd; mejor[3] = gpu;
                    mejor[4] = placa; mejor[5] = fuente; mejor[6] = caja;
                    mejor[7] = disipador; mejor[8] = wifi;
                }
            }
        }
        return mejorPrecio;
    }

    static void PedirOpcionales(string titulo, int[] opciones)
    {
        Encabezado(titulo);
        Console.WriteLine("COMPLEMENTOS OPCIONALES");
        Console.WriteLine("Desea agregar un HDD como almacenamiento adicional?");
        int cantidadHDD = ListarCategoria("HDD");
        int opcionHDD = LeerEntero("Opcion (0-" + cantidadHDD + ", 0 = no): ", 0, cantidadHDD);
        opciones[0] = opcionHDD == 0 ? -1 : IndiceCategoria("HDD", opcionHDD - 1);
        opciones[1] = PreguntarSiNo("Desea Wi-Fi si la placa no lo trae integrado?") ? 1 : 0;

        string[] perifericos = { "Monitor", "Teclado", "Mouse" };
        for (int i = 0; i < perifericos.Length; i++)
        {
            int indice = IndiceCategoria(perifericos[i], 0);
            opciones[i + 2] = PreguntarSiNo("Desea agregar " + nombres[indice] + " ($" + precios[indice] + ")?")
                ? indice : -1;
        }
    }

    static bool FlujoEquipoNuevo(int uso, decimal presupuesto, int[] opciones, string titulo)
    {
        decimal costoHDD = SumarSiExiste(opciones[0]);
        decimal costoPerifericos = SumarSiExiste(opciones[2]) + SumarSiExiste(opciones[3]) + SumarSiExiste(opciones[4]);
        decimal presupuestoTorre = presupuesto - costoHDD - costoPerifericos;
        int[] mejor = new int[10];
        decimal precioTorre = BuscarMejorEquipo(uso, presupuestoTorre, opciones[1] == 1, mejor);

        Encabezado(titulo);
        if (mejor[0] < 0)
        {
            Console.WriteLine("No se encontro una combinacion que cumpla el perfil y el presupuesto.");
            Console.WriteLine("Presupuesto total: $" + presupuesto + " COP");
            Console.WriteLine("Complementos seleccionados: $" + (costoHDD + costoPerifericos) + " COP");
            Console.WriteLine("Disponible para la torre: $" + presupuestoTorre + " COP");
            Console.WriteLine("Revise el presupuesto o los complementos. No se relajan las reglas de compatibilidad.");
            return false;
        }

        int cpu = mejor[0], ram = mejor[1], ssd = mejor[2], gpu = mejor[3];
        int placa = mejor[4], fuente = mejor[5], caja = mejor[6], disipador = mejor[7], wifi = mejor[8];
        decimal totalTorre = precioTorre;
        decimal totalTorreConHDD = totalTorre + costoHDD;
        decimal total = totalTorreConHDD + costoPerifericos;

        Console.WriteLine("Perfil: " + usos[uso - 1]);
        Console.WriteLine(TextoPerfil(uso));
        Console.WriteLine("\nCOMPONENTES RECOMENDADOS (TORRE)");
        MostrarLinea("Procesador", cpu);
        MostrarLinea("Placa base", placa);
        MostrarLinea("Memoria RAM", ram);
        MostrarLinea("SSD", ssd);
        if (gpu >= 0) MostrarLinea("Tarjeta grafica", gpu);
        else Console.WriteLine("- Tarjeta grafica dedicada: no incluida; se utilizan graficos integrados.");
        if (disipador >= 0) MostrarLinea("Disipador", disipador);
        else Console.WriteLine("- Disipador: incluido con el procesador segun el catalogo.");
        MostrarLinea("Gabinete", caja);
        MostrarLinea("Fuente", fuente);
        if (wifi >= 0) MostrarLinea("Tarjeta Wi-Fi", wifi);
        else if (opciones[1] == 1) Console.WriteLine("- Wi-Fi integrado en la placa.");

        Console.WriteLine("\nPotencia estimada con margen: " + EstimarPotencia(cpu, gpu) + " W");
        Console.WriteLine("Subtotal torre base: $" + totalTorre + " COP");
        if (opciones[0] >= 0) MostrarLinea("HDD adicional opcional", opciones[0]);
        Console.WriteLine("Subtotal torre con HDD: $" + totalTorreConHDD + " COP");
        if (costoPerifericos > 0)
        {
            Console.WriteLine("\nPERIFERICOS");
            for (int i = 2; i < 5; i++) MostrarLinea("Complemento", opciones[i]);
            Console.WriteLine("Subtotal perifericos: $" + costoPerifericos + " COP");
        }
        Console.WriteLine("\nTotal general: $" + total + " COP");
        Console.WriteLine("Presupuesto: $" + presupuesto + " COP");
        Console.WriteLine("Dinero restante: $" + (presupuesto - total) + " COP");
        Console.WriteLine("Combinaciones validas dentro del presupuesto: " + mejor[9]);
        Console.WriteLine("Se eligio la combinacion de mayor costo entre las que cumplen las reglas registradas.");
        Console.WriteLine("LIMITACIONES: no hay benchmarks, conectores exactos, dimensiones detalladas ni versiones BIOS en el catalogo.");
        Console.WriteLine("Verifique los modelos exactos con sus fabricantes antes de comprar.");
        return true;
    }

    // DIAGNOSTICO
    static string ConstruirDiagnostico(int sintoma)
    {
        string texto = "Categoria: " + categoriasProblema[sintoma - 1] + "\n";
        texto += "Sintoma: " + problemas[sintoma - 1] + "\n";
        texto += "Orientacion inicial: " + soluciones[sintoma - 1] + "\n";
        texto += "Posibles componentes relacionados: " + ComponentesRelacionados(sintoma) + "\n";
        texto += "Importante: son causas posibles, no una confirmacion de falla.";
        return texto;
    }

    static string ComponentesRelacionados(int sintoma)
    {
        if (sintoma == 1 || sintoma == 9 || sintoma == 12) return "CPU, RAM, SSD/HDD y software.";
        if (sintoma == 2 || sintoma == 10 || sintoma == 19) return "SSD/HDD, conexiones y placa base.";
        if (sintoma == 3) return "RAM, placa base y procesos del sistema.";
        if (sintoma == 4 || sintoma == 8 || sintoma == 14) return "Disipador, ventiladores, CPU, GPU y fuente.";
        if (sintoma == 5 || sintoma == 6 || sintoma == 13 || sintoma == 17) return "Fuente, placa base, RAM y conexiones.";
        if (sintoma == 7 || sintoma == 15 || sintoma == 16) return "Monitor, GPU, cableado y controladores.";
        if (sintoma == 18) return "Pila CMOS y placa base.";
        if (sintoma == 20) return "Dispositivo de audio, placa base y controladores.";
        if (sintoma == 21) return "Adaptador Wi-Fi, tarjeta de red y router.";
        if (sintoma == 22) return "Puertos USB, placa base y controladores.";
        if (sintoma == 23) return "Fuente, cableado o componentes electricos. No manipular internamente.";
        return "Requiere revision tecnica.";
    }

    static void MostrarSugerenciaDiagnostico(int sintoma, string tipoMemoria, int soporteInterfaz)
    {
        if (sintoma == 2)
            Console.WriteLine("\nOpciones de almacenamiento de 1 TB o mas:");
        else if (sintoma == 3)
            Console.WriteLine("\nOpciones de RAM de 16 GB o mas:");
        else
            return;

        for (int i = 0; i < nombres.Length; i++)
        {
            bool mostrar = false;
            string estado = "requiere verificar compatibilidad";
            if (sintoma == 2 && categorias[i] == "SSD" && capacidadGB[i] >= 1000)
            {
                mostrar = true;
                if (soporteInterfaz == 1 && interfazSSD[i] == "SATA") estado = "interfaz SATA declarada por el usuario";
                else if (soporteInterfaz == 2 && interfazSSD[i] == "NVMe") estado = "interfaz NVMe declarada por el usuario";
                else if (soporteInterfaz == 3) estado = "la placa declara soporte SATA y NVMe";
                else if (soporteInterfaz == 0) estado = "pendiente: confirmar SATA o M.2 NVMe";
                else estado = "no coincide con la interfaz indicada";
            }
            else if (sintoma == 3 && categorias[i] == "RAM" && capacidadGB[i] >= 16)
            {
                mostrar = true;
                if (tipoMemoria == "") estado = "pendiente: confirmar DDR4 o DDR5";
                else if (tipoRAM[i] == tipoMemoria) estado = "tipo de memoria coincide; verificar placa y ranuras";
                else estado = "no coincide con el tipo de memoria indicado";
            }
            if (mostrar) Console.WriteLine("- " + nombres[i] + " - $" + precios[i] + " COP (" + estado + ")");
        }
        Console.WriteLine("Estas son referencias del catalogo, no una confirmacion de que la pieza este dañada o sea necesaria.");
    }

    static void FlujoDiagnostico(string titulo)
    {
        Encabezado(titulo);
        Console.WriteLine("DIAGNOSTICO ORIENTATIVO");
        for (int i = 0; i < problemas.Length; i++)
            Console.WriteLine((i + 1) + ". " + problemas[i]);
        int sintoma = LeerEntero("Seleccione (1-" + problemas.Length + "): ", 1, problemas.Length);
        Encabezado(titulo);
        Console.WriteLine(ConstruirDiagnostico(sintoma));

        if (sintoma == 2)
        {
            Console.WriteLine("\nInterfaz que admite la placa: 1. SATA  2. NVMe  3. Ambas  4. No se");
            int interfaz = LeerEntero("Opcion (1-4): ", 1, 4);
            MostrarSugerenciaDiagnostico(sintoma, "", interfaz == 4 ? 0 : interfaz);
        }
        else if (sintoma == 3)
        {
            Console.WriteLine("\nTipo de RAM: 1. DDR4  2. DDR5  3. No se");
            int memoria = LeerEntero("Opcion (1-3): ", 1, 3);
            string tipo = memoria == 1 ? "DDR4" : memoria == 2 ? "DDR5" : "";
            MostrarSugerenciaDiagnostico(sintoma, tipo, 0);
        }

        if (sintoma == 23)
            Console.WriteLine("\nALERTA: apague y desconecte el equipo. No lo vuelva a encender ni abra la fuente. Solicite asistencia tecnica.");
        Console.WriteLine("\nNo compre piezas basandose solo en este sintoma. Confirme la causa mediante pruebas tecnicas.");
    }

    // ACTUALIZACION
    static string NombreSocket(int opcion)
    {
        if (opcion == 1) return "AM4";
        if (opcion == 2) return "AM5";
        if (opcion == 3) return "LGA1700";
        return "";
    }

    static bool CompatibleConEquipoActual(int indice, string categoria, string socketActual,
        string tipoMemoria, int soporteInterfaz, int potenciaFuenteActual, int potenciaNecesaria,
        string formatoPlacaActual, int disponibilidadPCIe)
    {
        if (categoria == "RAM") return tipoMemoria != "" && tipoRAM[indice] == tipoMemoria;
        if (categoria == "SSD" || categoria == "HDD")
        {
            if (soporteInterfaz == 1) return interfazSSD[indice] == "SATA";
            if (soporteInterfaz == 2) return interfazSSD[indice] == "NVMe";
            if (soporteInterfaz == 3) return interfazSSD[indice] == "SATA" || interfazSSD[indice] == "NVMe";
            return false;
        }
        if (categoria == "CPU") return socketActual != "" && socket[indice] == socketActual;
        if (categoria == "Placa")
            return socketActual != "" && tipoMemoria != "" &&
                socket[indice] == socketActual && tipoRAM[indice] == tipoMemoria;
        if (categoria == "Disipador") return socketActual != "" && socket[indice] == socketActual;
        if (categoria == "Gabinete")
        {
            if (formatoPlacaActual == "") return false;
            return formato[indice] == "ATX" || (formato[indice] == "mATX" && formatoPlacaActual == "mATX");
        }
        if (categoria == "GPU")
            return potenciaFuenteActual > 0 && potenciaW[indice] + 200 <= potenciaFuenteActual;
        if (categoria == "Fuente") return potenciaNecesaria > 0 && potenciaW[indice] >= potenciaNecesaria;
        if (categoria == "Wifi") return disponibilidadPCIe == 1;
        return true;
    }

    static int PuntuarObjetivo(int indice, string categoria, int objetivo, int uso)
    {
        // Puntaje de pertinencia: no representa benchmarks ni rendimiento medido.
        int puntaje = 0;
        if (objetivo == 1)
        {
            if (categoria == "CPU") puntaje = 5;
            else if (categoria == "RAM") puntaje = capacidadGB[indice] >= 16 ? 4 : 2;
            else if (categoria == "SSD") puntaje = interfazSSD[indice] == "NVMe" ? 5 : 3;
        }
        else if (objetivo == 2)
        {
            if (categoria == "GPU") puntaje = 5;
            else if (categoria == "CPU") puntaje = 3;
            else if (categoria == "RAM" && capacidadGB[indice] >= 16) puntaje = 2;
        }
        else if (objetivo == 3)
        {
            if (categoria == "SSD" || categoria == "HDD") puntaje = capacidadGB[indice];
        }
        else if (objetivo == 4)
        {
            if (categoria == "Placa" || categoria == "Wifi" || categoria == "Fuente") puntaje = 5;
        }

        // Ajuste por perfil usando solo capacidad e interfaz conocidas.
        if (categoria == "RAM")
        {
            if (uso == 4 && capacidadGB[indice] >= 32) puntaje += 3;
            else if ((uso == 2 || uso == 3) && capacidadGB[indice] >= 16) puntaje += 2;
            else if (uso == 1 && capacidadGB[indice] >= 8) puntaje += 1;
        }
        if (categoria == "SSD" && interfazSSD[indice] == "NVMe" && uso != 1) puntaje++;
        if (categoria == "GPU" && (uso == 3 || uso == 4)) puntaje++;
        return puntaje;
    }


    // CAMBIO DE PLATAFORMA: evalua placa, procesador y RAM como un conjunto.
    // No presupone que una placa nueva pueda conservar el CPU o la RAM anteriores.
    static void FlujoCambioPlataforma(int uso, decimal presupuesto, string titulo)
    {
        int mejorCPU = -1, mejorRAM = -1, mejorPlaca = -1;
        decimal mejorTotal = -1m;
        int mejorCapacidadRAM = -1;
        int minRAM = uso == 1 ? 8 : (uso == 2 || uso == 3 ? 16 : 32);
        int cantidadCPU = ContarCategoria("CPU");
        int cantidadRAM = ContarCategoria("RAM");
        int cantidadPlacas = ContarCategoria("Placa");
        int combinaciones = 0;

        for (int p = 0; p < cantidadPlacas; p++)
        for (int c = 0; c < cantidadCPU; c++)
        for (int r = 0; r < cantidadRAM; r++)
        {
            int placa = IndiceCategoria("Placa", p);
            int cpu = IndiceCategoria("CPU", c);
            int ram = IndiceCategoria("RAM", r);
            if (!CompatibleCPUPlaca(cpu, placa) || !CompatibleRAMPlaca(ram, placa)) continue;
            if (capacidadGB[ram] < minRAM) continue;

            decimal total = precios[placa] + precios[cpu] + precios[ram];
            if (total > presupuesto) continue;
            combinaciones++;

            // Se aprovecha el presupuesto sin afirmar que el precio equivale a rendimiento.
            if (total > mejorTotal ||
                (total == mejorTotal && capacidadGB[ram] > mejorCapacidadRAM))
            {
                mejorTotal = total;
                mejorCPU = cpu;
                mejorRAM = ram;
                mejorPlaca = placa;
                mejorCapacidadRAM = capacidadGB[ram];
            }
        }

        Encabezado(titulo);
        Console.WriteLine("EVALUACION DE CAMBIO DE PLATAFORMA");
        Console.WriteLine("Se evalua la placa base junto con un procesador y una RAM compatibles.");
        Console.WriteLine("Perfil: " + usos[uso - 1]);
        Console.WriteLine("Presupuesto del conjunto: $" + presupuesto + " COP");
        Console.WriteLine("Criterio de RAM: minimo " + minRAM + " GB para este perfil.");
        Console.WriteLine("Combinaciones compatibles dentro del presupuesto: " + combinaciones);

        if (mejorPlaca < 0)
        {
            Console.WriteLine("No se encontro una combinacion completa de placa, CPU y RAM dentro del presupuesto.");
            Console.WriteLine("Aumente el presupuesto o revise el perfil seleccionado.");
            return;
        }

        Console.WriteLine("\nCONJUNTO RECOMENDADO");
        MostrarLinea("Placa base", mejorPlaca);
        Console.WriteLine("- Socket: " + socket[mejorPlaca] + ". Tipo de memoria: " + tipoRAM[mejorPlaca] + ". Formato: " + formato[mejorPlaca] + ".");
        MostrarLinea("Procesador compatible", mejorCPU);
        Console.WriteLine("- Socket del procesador: " + socket[mejorCPU] + ". Verifique compatibilidad de BIOS y lista oficial de CPU admitidos.");
        MostrarLinea("Memoria RAM compatible", mejorRAM);
        Console.WriteLine("- Tipo: " + tipoRAM[mejorRAM] + ". Capacidad: " + capacidadGB[mejorRAM] + " GB.");
        Console.WriteLine("- Total del conjunto: $" + mejorTotal + " COP");
        Console.WriteLine("- Dinero restante: $" + (presupuesto - mejorTotal) + " COP");
        Console.WriteLine("\nIMPORTANTE: este conjunto reemplaza la placa, el CPU y la RAM considerados.");
        Console.WriteLine("Revise tambien gabinete, disipador, fuente, conectores, BIOS y dimensiones antes de comprar.");
        Console.WriteLine("El catalogo no contiene benchmarks; el precio no se interpreta como medida de rendimiento.");
    }

    static int LeerConectorCPU(string mensaje)
    {
        Console.WriteLine(mensaje);
        Console.WriteLine("1. ATX12V de 4 pines  2. EPS de 8 pines (4+4)  3. Dos EPS de 8 pines  4. No se");
        return LeerEntero("Opcion (1-4): ", 1, 4);
    }

    static int LeerConectorGPU(string mensaje)
    {
        Console.WriteLine(mensaje);
        Console.WriteLine("1. No requiere conector adicional  2. PCIe de 6 pines  3. PCIe de 8 pines");
        Console.WriteLine("4. Dos PCIe de 8 pines  5. 12VHPWR / 12V-2x6  6. No se");
        return LeerEntero("Opcion (1-6): ", 1, 6);
    }

    static string TextoConectorCPU(int opcion)
    {
        if (opcion == 1) return "ATX12V 4 pines";
        if (opcion == 2) return "EPS 8 pines (4+4)";
        if (opcion == 3) return "2 conectores EPS 8 pines";
        return "Desconocido";
    }

    static string TextoConectorGPU(int opcion)
    {
        if (opcion == 1) return "No requiere conector adicional";
        if (opcion == 2) return "PCIe 6 pines";
        if (opcion == 3) return "PCIe 8 pines";
        if (opcion == 4) return "2 conectores PCIe 8 pines";
        if (opcion == 5) return "12VHPWR / 12V-2x6";
        return "Desconocido";
    }

    static int BuscarFuentePorPotencia(int vatiosNecesarios)
    {
        int mejor = -1;
        for (int i = 0; i < nombres.Length; i++)
            if (categorias[i] == "Fuente" && potenciaW[i] >= vatiosNecesarios &&
                (mejor == -1 || potenciaW[i] < potenciaW[mejor]))
                mejor = i;
        return mejor;
    }

    // ESTIMACION ELECTRICA: usa TDP/consumos de referencia del catalogo y una reserva del 30%.
    // Los conectores se comparan con la informacion que aporta el usuario del modelo exacto.
    static void FlujoConsumoElectrico(string titulo)
    {
        Encabezado(titulo);
        Console.WriteLine("ESTIMACION DE CONSUMO Y VERIFICACION DE FUENTE");
        Console.WriteLine("Seleccione el procesador de su equipo (valores de referencia del catalogo):");
        ListarCategoria("CPU");
        int cpuPos = LeerEntero("Procesador (1-" + ContarCategoria("CPU") + "): ", 1, ContarCategoria("CPU"));
        int cpu = IndiceCategoria("CPU", cpuPos - 1);

        Console.WriteLine("\nSeleccione la GPU. 0 significa que no tiene GPU dedicada:");
        ListarCategoria("GPU");
        int gpuPos = LeerEntero("GPU (0-" + ContarCategoria("GPU") + "): ", 0, ContarCategoria("GPU"));
        int gpu = gpuPos == 0 ? -1 : IndiceCategoria("GPU", gpuPos - 1);

        int otrosW = LeerEntero("Consumo estimado de placa, RAM, discos, ventiladores y otros (W, 0-1000): ", 0, 1000);
        int consumoBase = potenciaW[cpu] + (gpu >= 0 ? potenciaW[gpu] : 0) + otrosW;
        int recomendado = (consumoBase * 13 + 9) / 10;
        int fuenteCatalogo = BuscarFuentePorPotencia(recomendado);

        Console.WriteLine("\nIndique los conectores que exige el modelo exacto del procesador/placa y GPU.");
        int requeridoCPU = LeerConectorCPU("Conector de alimentacion CPU requerido:");
        int requeridoGPU = gpu < 0 ? 1 : LeerConectorGPU("Conector de alimentacion requerido por la GPU:");
        int disponibleCPU = LeerConectorCPU("Conector CPU disponible en la fuente:");
        int disponibleGPU = gpu < 0 ? 1 : LeerConectorGPU("Conector PCIe/12VHPWR disponible en la fuente:");
        int potenciaFuenteActual = LeerEntero("Potencia nominal de la fuente actual en W (0 si no se conoce): ", 0, 2000);

        Encabezado(titulo);
        Console.WriteLine("RESULTADO DE LA ESTIMACION ELECTRICA");
        Console.WriteLine("- Consumo CPU de referencia: " + potenciaW[cpu] + " W");
        Console.WriteLine("- Consumo GPU de referencia: " + (gpu >= 0 ? potenciaW[gpu] : 0) + " W");
        Console.WriteLine("- Otros componentes: " + otrosW + " W");
        Console.WriteLine("- Consumo base estimado: " + consumoBase + " W");
        Console.WriteLine("- Potencia recomendada con reserva aproximada del 30%: " + recomendado + " W");
        Console.WriteLine("- Conector CPU requerido: " + TextoConectorCPU(requeridoCPU));
        Console.WriteLine("- Conector CPU disponible: " + TextoConectorCPU(disponibleCPU));
        Console.WriteLine("- Conector GPU requerido: " + TextoConectorGPU(requeridoGPU));
        Console.WriteLine("- Conector GPU disponible: " + TextoConectorGPU(disponibleGPU));

        bool datosConectores = requeridoCPU != 4 && disponibleCPU != 4 &&
            (gpu < 0 || (requeridoGPU != 6 && disponibleGPU != 6));
        bool conectoresOK = datosConectores && requeridoCPU == disponibleCPU && requeridoGPU == disponibleGPU;
        bool potenciaOK = potenciaFuenteActual >= recomendado && potenciaFuenteActual > 0;
        if (fuenteCatalogo >= 0)
            MostrarLinea("Fuente del catalogo que alcanza la estimacion", fuenteCatalogo);
        else
            Console.WriteLine("- El catalogo no contiene una fuente con potencia suficiente para esta estimacion.");

        if (potenciaFuenteActual == 0)
            Console.WriteLine("No se puede confirmar la fuente actual porque no se conoce su potencia nominal.");
        else
            Console.WriteLine(potenciaOK ? "La potencia nominal declarada alcanza la estimacion." : "La potencia nominal declarada no alcanza la estimacion.");

        if (!datosConectores)
            Console.WriteLine("No se pueden confirmar los conectores: falta conocer algun conector del modelo exacto.");
        else
            Console.WriteLine(conectoresOK ? "Los conectores indicados coinciden." : "Los conectores indicados no coinciden; no conecte adaptadores improvisados.");

        Console.WriteLine("\nADVERTENCIA: esta es una estimacion preliminar, no una certificacion electrica.");
        Console.WriteLine("Los vatios del catalogo son ilustrativos. Verifique TDP, picos, calidad de fuente, cableado, cantidad real de conectores y recomendaciones del fabricante.");
        Console.WriteLine("No use adaptadores dudosos ni fuerce conectores.");
    }

    static void FlujoActualizacion(string titulo)
    {
        Encabezado(titulo);
        Console.WriteLine("CUESTIONARIO PARA ACTUALIZAR SU EQUIPO");
        Console.WriteLine("El diagnostico de fallas se encuentra en un modulo independiente.");
        Console.WriteLine("\nQue desea cambiar?");
        Console.WriteLine("1. RAM\n2. SSD\n3. HDD\n4. CPU\n5. GPU\n6. Placa base / cambio de plataforma\n7. Fuente\n8. Gabinete\n9. Disipador\n10. Wi-Fi o perifericos\n11. Estimar consumo y verificar conectores de la fuente");
        int opcion = LeerEntero("Opcion (1-11): ", 1, 11);
        if (opcion == 11)
        {
            FlujoConsumoElectrico(titulo);
            return;
        }
        string categoria = opcion == 1 ? "RAM" : opcion == 2 ? "SSD" : opcion == 3 ? "HDD" :
            opcion == 4 ? "CPU" : opcion == 5 ? "GPU" : opcion == 6 ? "Placa" :
            opcion == 7 ? "Fuente" : opcion == 8 ? "Gabinete" : opcion == 9 ? "Disipador" : "Wifi";
        if (opcion == 10)
        {
            Console.WriteLine("1. Wi-Fi\n2. Monitor\n3. Teclado\n4. Mouse");
            int perif = LeerEntero("Opcion (1-4): ", 1, 4);
            categoria = perif == 1 ? "Wifi" : perif == 2 ? "Monitor" : perif == 3 ? "Teclado" : "Mouse";
        }

        Encabezado(titulo);
        int uso = LeerUso();
        if (categoria == "Placa")
        {
            Console.WriteLine("\nIngrese el presupuesto total para la nueva placa, el procesador y la RAM.");
            decimal presupuestoPlataforma = LeerPresupuesto();
            FlujoCambioPlataforma(uso, presupuestoPlataforma, titulo);
            return;
        }
        Console.WriteLine("\nQue busca principalmente?");
        Console.WriteLine("1. Mas velocidad\n2. Mejor rendimiento grafico/juegos\n3. Mas almacenamiento\n4. Compatibilidad o conectividad");
        int objetivo = LeerEntero("Opcion (1-4): ", 1, 4);
        decimal presupuesto = LeerPresupuesto();

        string socketActual = "", tipoMemoria = "", formatoPlacaActual = "";
        int soporteInterfaz = 0, potenciaFuenteActual = 0, potenciaNecesaria = 0;
        int disponibilidadPCIe = 0;

        if (categoria == "RAM" || categoria == "CPU" || categoria == "Placa" || categoria == "Disipador")
        {
            Console.WriteLine("\nPlataforma actual: 1. AM4  2. AM5  3. LGA1700  4. No se");
            socketActual = NombreSocket(LeerEntero("Opcion (1-4): ", 1, 4));
        }
        if (categoria == "RAM" || categoria == "Placa")
        {
            Console.WriteLine("Tipo de RAM actual: 1. DDR4  2. DDR5  3. No se");
            int mem = LeerEntero("Opcion (1-3): ", 1, 3);
            tipoMemoria = mem == 1 ? "DDR4" : mem == 2 ? "DDR5" : "";
        }
        if (categoria == "SSD" || categoria == "HDD")
        {
            Console.WriteLine("Que interfaz de almacenamiento admite su placa?");
            Console.WriteLine("1. SATA");
            Console.WriteLine("2. M.2 NVMe");
            Console.WriteLine("3. SATA y M.2 NVMe");
            Console.WriteLine("4. No lo se");
            soporteInterfaz = LeerEntero("Opcion (1-4): ", 1, 4);
            if (soporteInterfaz == 4) soporteInterfaz = 0;
        }
        if (categoria == "GPU")
        {
            Console.WriteLine("Potencia nominal de la fuente actual (0 si no la conoce):");
            potenciaFuenteActual = LeerEntero("Vatios (0-2000): ", 0, 2000);
        }
        if (categoria == "Fuente")
        {
            Console.WriteLine("Potencia minima recomendada para el equipo actual segun sus componentes (0 si no la conoce):");
            potenciaNecesaria = LeerEntero("Vatios requeridos (0-2000): ", 0, 2000);
        }
        if (categoria == "Gabinete")
        {
            Console.WriteLine("Formato de la placa actual: 1. ATX  2. mATX  3. No se");
            int f = LeerEntero("Opcion (1-3): ", 1, 3);
            formatoPlacaActual = f == 1 ? "ATX" : f == 2 ? "mATX" : "";
        }
        if (categoria == "Wifi")
        {
            Console.WriteLine("Tiene una ranura PCIe disponible? 1. Si  2. No  3. No se");
            disponibilidadPCIe = LeerEntero("Opcion (1-3): ", 1, 3);
        }

        int mejor = -1, mejorPuntaje = -1, compatibles = 0;
        bool hayPendientes = false;
        for (int i = 0; i < nombres.Length; i++)
        {
            if (categorias[i] != categoria || precios[i] > presupuesto) continue;
            bool datosSuficientes = true;
            bool compatible = CompatibleConEquipoActual(i, categoria, socketActual, tipoMemoria,
                soporteInterfaz, potenciaFuenteActual, potenciaNecesaria, formatoPlacaActual, disponibilidadPCIe);

            if ((categoria == "RAM" && tipoMemoria == "") ||
                ((categoria == "CPU" || categoria == "Disipador") && socketActual == "") ||
                (categoria == "Placa" && (socketActual == "" || tipoMemoria == "")) ||
                ((categoria == "SSD" || categoria == "HDD") && soporteInterfaz == 0) ||
                (categoria == "GPU" && potenciaFuenteActual == 0) ||
                (categoria == "Fuente" && potenciaNecesaria == 0) ||
                (categoria == "Gabinete" && formatoPlacaActual == "") ||
                (categoria == "Wifi" && disponibilidadPCIe != 1))
                datosSuficientes = false;

            if (!datosSuficientes) hayPendientes = true;
            if (compatible && datosSuficientes)
            {
                compatibles++;
                int puntaje = PuntuarObjetivo(i, categoria, objetivo, uso);
                if (mejor == -1 || puntaje > mejorPuntaje ||
                    (puntaje == mejorPuntaje && precios[i] < precios[mejor]))
                {
                    mejor = i;
                    mejorPuntaje = puntaje;
                }
            }
        }

        Encabezado(titulo);
        Console.WriteLine("RESUMEN");
        Console.WriteLine("- Componente: " + categoria);
        Console.WriteLine("- Uso: " + usos[uso - 1]);
        string[] objetivos = { "Mas velocidad", "Mejor rendimiento grafico/juegos", "Mas almacenamiento", "Compatibilidad/conectividad" };
        Console.WriteLine("- Objetivo: " + objetivos[objetivo - 1]);
        Console.WriteLine("- Presupuesto: $" + presupuesto + " COP");

        if (categoria == "Placa")
            Console.WriteLine("\nIMPORTANTE: cambiar la placa puede exigir cambiar tambien el procesador (socket) o la RAM (DDR4/DDR5), ademas de revisar gabinete y conectores.");

        if (mejor < 0)
        {
            Console.WriteLine("\nNo hay una recomendacion cuya compatibilidad pueda confirmarse con los datos suministrados.");
            if (hayPendientes) Console.WriteLine("Faltan datos tecnicos. Consulte el manual o la etiqueta del equipo antes de seleccionar.");
            Console.WriteLine("Puede modificar el presupuesto o completar la informacion de compatibilidad.");
            return;
        }

        Console.WriteLine("\nRECOMENDACION PRINCIPAL");
        MostrarLinea("Producto", mejor);
        Console.WriteLine("- Opciones compatibles confirmadas dentro del presupuesto: " + compatibles);
        Console.WriteLine("- La seleccion considera el objetivo y los datos registrados; el precio solo desempata.");
        if (categoria == "RAM")
            Console.WriteLine("- " + tipoRAM[mejor] + ", " + capacidadGB[mejor] + " GB. Confirme ranuras y capacidad maxima.");
        else if (categoria == "SSD" || categoria == "HDD")
            Console.WriteLine("- Interfaz " + interfazSSD[mejor] + ", capacidad " + capacidadGB[mejor] + " GB. Confirme el conector exacto.");
        else if (categoria == "CPU")
            Console.WriteLine("- Socket " + socket[mejor] + ". Verifique BIOS y lista de procesadores admitidos.");
        else if (categoria == "Placa")
            Console.WriteLine("- Socket " + socket[mejor] + ", " + tipoRAM[mejor] + ", formato " + formato[mejor] + ". Revisar CPU y RAM que se conservaran.");
        else if (categoria == "GPU")
            Console.WriteLine("- Consumo de referencia " + potenciaW[mejor] + " W. El filtro usa GPU + 200 W como reserva aproximada; no reemplaza el calculo completo del equipo. Verifique conectores y dimensiones.");
        else if (categoria == "Fuente")
            Console.WriteLine("- Capacidad nominal " + potenciaW[mejor] + " W. Verifique calidad, conectores y dimensiones.");
        else if (categoria == "Wifi")
            Console.WriteLine("- Confirme ranura PCIe disponible y espacio para antenas.");
        Console.WriteLine("- Dinero restante: $" + (presupuesto - precios[mejor]) + " COP");
        Console.WriteLine("La recomendacion no sustituye la verificacion del modelo exacto.");
    }

    static void Main()
    {
        if (!VerificarCatalogo())
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR: los arreglos del catalogo no tienen la misma longitud.");
            Console.ResetColor();
            Console.ReadKey();
            return;
        }

        string tituloBase = "ASISTENTE PARA LA SELECCION Y RECOMENDACION DE COMPONENTES";
        bool salir = false;
        while (!salir)
        {
            Encabezado(tituloBase);
            Console.WriteLine("Precios ilustrativos en pesos colombianos (COP).\n");
            Console.WriteLine("1. Recomendar componentes para un equipo nuevo");
            Console.WriteLine("2. Actualizar componentes de un equipo existente");
            Console.WriteLine("3. Diagnosticar un problema del equipo");
            Console.WriteLine("4. Salir");
            int opcion = 0;
            do
            {
                Console.Write("> Opcion (1-4): ");
                if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opcion invalida. Presione una tecla...");
                    Console.ResetColor();
                    Console.ReadKey(true);
                    opcion = 0;
                }
            } while (opcion < 1 || opcion > 4);

            if (opcion == 1)
            {
                string titulo = "RECOMENDACION DE EQUIPO NUEVO";
                Encabezado(titulo);
                int uso = LeerUso();
                decimal presupuesto = LeerPresupuesto();
                int[] opciones = new int[5];
                PedirOpcionales(titulo, opciones);
                bool encontrado = false, salirFlujo = false;
                while (!encontrado && !salirFlujo)
                {
                    encontrado = FlujoEquipoNuevo(uso, presupuesto, opciones, titulo);
                    if (!encontrado)
                    {
                        Console.WriteLine("\n1. Cambiar presupuesto\n2. Cambiar perfil\n3. Volver al menu");
                        int r = LeerEntero("Opcion (1-3): ", 1, 3);
                        if (r == 1) presupuesto = LeerPresupuesto();
                        else if (r == 2) uso = LeerUso();
                        else salirFlujo = true;
                    }
                }
            }
            else if (opcion == 2)
                FlujoActualizacion("CUESTIONARIO DE ACTUALIZACION DE EQUIPO");
            else if (opcion == 3)
                FlujoDiagnostico("DIAGNOSTICO INDEPENDIENTE");
            else
                salir = true;

            if (!salir)
            {
                Console.WriteLine("\nPresione una tecla para volver al menu principal.");
                Console.ReadKey(true);
            }
        }

        Console.WriteLine("\nCatalogo y precios simplificados para fines academicos.");
        Console.WriteLine("Verifique las especificaciones del fabricante antes de comprar componentes.");
    }
}
