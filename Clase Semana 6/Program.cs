try
{
    //Inicio solicitando la contraseña
    contrasenia();

//En esta parte realice el menu.

    static void menu(string name)
    {
        int op;
        do
        {

            Console.WriteLine($"\nHola {name}, a continuación selecciona una opción insertando el numero correspondiente a la opción que deseas.");
            Console.WriteLine("\n1) Euros");
            Console.WriteLine("2) Dolares");
            Console.WriteLine("3) Quetzales");
            Console.WriteLine("4) Salir");
            Console.WriteLine();
            op = Convert.ToInt32(Console.ReadLine());

            //Un switch para ir variando entre las diferentes opciones, del "1" al "3" y "4" para salir del programa y/o terminar el proceso.
            switch (op)
            {
                case 1:
                    Console.WriteLine("\nIngrese la cantidad deseada en Euros: ");
                    decimal euros = 8.50M, quet;
                    quet = Convert.ToDecimal(Console.ReadLine());
                    quet *= euros;
                    desglose(quet);
                    CleanC();
                    break;

                case 2:
                    Console.WriteLine("\nIngrese la cantidad deseada en Dolares: ");
                    decimal dolares = 7.80M;
                    quet = Convert.ToDecimal(Console.ReadLine());
                    quet *= dolares;
                    desglose(quet);
                    CleanC();
                    break;

                case 3:
                    Console.WriteLine("\nIngrese la cantidad deseada en Quetzales: ");
                    quet = Convert.ToDecimal(Console.ReadLine());
                    desglose(quet);
                    CleanC();
                    break;

                case 4:
                    Console.WriteLine($"\n¡Gracias por tu tiempo!.");
                    CleanC();
                    break;

                default:
                    Console.WriteLine("\nEl dato insertado no es valido.");
                    break;
            }
        } while (op != 4);

    }

//Parte donde hice la parte de los billetes y monedas.
static void desglose(decimal quet)
{

    int CAN, C200, C100, C50, C20, C10, C5;
    CAN = C200 = C100 = C50 = C20 = C10 = C5 = 0;
    int CAND, DC50, DC25, DC10, DC5;
    CAND = DC50 = DC25 = DC10 = DC5 = 0;
    
  
    decimal p_entera = Math.Truncate(quet);
    CAN = Convert.ToInt32(p_entera); 
    
    if ((CAN >= 200))
    {
        C200 = (CAN / 200);
        CAN = CAN - (C200 * 200);
    }
    if ((CAN >= 100))
    {
        C100 = (CAN / 100);
        CAN = CAN - (C100 * 100);
    }

    if ((CAN >= 50))
    {
        C50 = (CAN / 50);
        CAN = CAN - (C50 * 50);
    }

    if ((CAN >= 20))
    {
        C20 = (CAN / 20);
        CAN = CAN - (C20 * 20);
    }

    if ((CAN >= 10))
    {
        C10 = (CAN / 10);
        CAN = CAN - (C10 * 10);
    }
    if ((CAN >= 5))
    {
        C5 = (CAN / 5);
        CAN = CAN - (C5 * 5);
    }

    //Aquí hice la parte de los decimales.
    decimal p_decimal = quet - p_entera;
    CAND = Convert.ToInt32(p_decimal*100);
    if ((CAND >= 50))
    {
        DC50 = (CAND / 50);
        CAND = CAND - (DC50 * 50);
    }
    if ((CAND >= 25))
    {
        DC25 = (CAND / 25);
        CAND = CAND - (DC25 * 25);
    }
    if ((CAND >= 10))
    {
        DC10 = (CAND / 10);
        CAND = CAND - (DC10 * 10);
    }
    if ((CAND >= 5))
    {
        DC5 = (CAND / 5);
        CAND = CAND - (DC5 * 5);
    }

    Console.WriteLine($"\n---ESTOS SON TUS BILLETES---");
    Console.WriteLine($"\nBILLETES DE 200: {C200}");
    Console.WriteLine($"BILLETES DE 100: {C100}");
    Console.WriteLine($"BILLETES DE 50: {C50}");
    Console.WriteLine($"BILLETES DE 20: {C20}");
    Console.WriteLine($"BILLETES DE 10: {C10}");
    Console.WriteLine($"BILLETES DE 5: {C5}");
    Console.WriteLine($"BILLETES DE 1: {CAN}");

    Console.WriteLine($"\n---ESTAS SON TUS MONEDAS---");
    Console.WriteLine($"\nMONEDAS DE 0.50: {DC50}");
    Console.WriteLine($"MONEDAS DE 0.25: {DC25}");
    Console.WriteLine($"MONEDAS DE 0.10: {DC10}");
    Console.WriteLine($"MONEDAS DE 0.5: {DC5}");
    Console.WriteLine("\nPresiona la tecla enter para continuar...");
}

//En esta parte realice lo de la contrasenia
static void contrasenia()
{
    byte oportunidades, tienepermiso;
    string clave;
        tienepermiso = 0;
        oportunidades = 0;

    do
    {
       Console.WriteLine("Digite la Clave: ");
            clave = HideCharacter().Replace("\r", "");
       Console.WriteLine();
        if((clave.Equals("J444")))
            {
                tienepermiso = 1;
            } 
            else 
            { 
            oportunidades++;
            }
    } 
    

    while (((oportunidades<3)& (tienepermiso==0)));
    
    if (tienepermiso == 1)
    {
        string name;
            Console.WriteLine("\nHola, bienvenid@ a continuación inserta tu nombre: ");
                name = Console.ReadLine();
            menu(name);
    }
    else 
    {
        Console.WriteLine("Oportunidades terminadas.");
    }        
}

//Aquí oculto los caracteres y los remplazo por un "*"
static string HideCharacter()
{
    ConsoleKeyInfo Key;
        String code = "";
    do
    {
        Key = Console.ReadKey(true);
            if (Char.IsLetterOrDigit(Key.KeyChar))
            {
                Console.Write("*");
            }
        code += Key.KeyChar;
    } 
    
    while (Key.Key != ConsoleKey.Enter);
    return code;
}

//Este static es para así limpiar la consola.
static void CleanC()
{
    Console.ReadKey();
    Console.Clear();
}


}
catch
{
    Console.WriteLine("El dato, o acción realizada no es valida. ");
}
//Habilitarlo para que acepte billetes de 200 (Listo)
//Que acepte el desgloce de monedas (Listo)
//Al momento que recibamos una cantidad desglosar en un lado los billetes y en otra las monedas. (Listo)
//Le pondremos un menu con multiples opciones (Listp)
//Cambiar para que la contraseña sea alfanumerica (Listo).




