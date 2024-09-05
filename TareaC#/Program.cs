using System;

class Proyecto
{
    static void Main(string[] args)

    {
        Console.WriteLine("Bienvenido al sistema de ventas Abarroteria Hernandez");
        Console.WriteLine("Ingrese su Nombre");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Favor Ingrese Edad");
        int Edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Seleccione la Categoria del Producto a comprar");
        Console.WriteLine("1. Carnes");
        Console.WriteLine("2. Refrescos");
        Console.WriteLine("3. Cereales");
        string categoria = Console.ReadLine();
        double Precio = 0;


        string producto;
        if (categoria == "1")
        {
            Console.WriteLine("Tenemos los siguientes Productos, escriba el numero deseado");
            Console.WriteLine("1. Tajo Premiun 110 Lps");
            Console.WriteLine("2. Carne para bistec 90 Lps");
            Console.WriteLine("3. Pollo deshuesado 60 Lps");
            Console.WriteLine("4. costilla de cerdo 130 Lps");
            Console.WriteLine("5. Chuleta de cerdo 85 Lps");
            Console.WriteLine("6. Res Molida 70 Lps");
            Console.WriteLine("7. Pechuga de pollo 65 Lps");
            Console.WriteLine("8. Pavo 120 Lps");
            Console.WriteLine("9. Chorizo 55 Lps");
            Console.WriteLine("10. Pierna de res 95 Lps");
            producto = Console.ReadLine();

            if (producto == "1")
            {
                Precio = 110;
            }
            else if (producto == "2")
            {
                Precio = 90;
            }
            else if (producto == "3")
            {
                Precio = 60;
            }
            else if (producto == "4")
            {
                Precio = 130;
            }
            else if (producto == "5")
            {
                Precio = 85;
            }
            else if (producto == "6")
            {
                Precio = 70;
            }
            else if (producto == "7")
            {
                Precio = 120;
            }
            else if (producto == "8")
            {
                Precio = 85;
            }
            else if (producto == "9")
            {
                Precio = 55;
            }
            else if (producto == "10")
            {
                Precio = 95;
            }
            else
            {
                Console.WriteLine("no tenemos el producto seleccionado");
            }
        }
        else if (categoria == "2")
        {
            Console.WriteLine("Tenemos los siguientes Productos, escriba el numero deseado");
            Console.WriteLine("1. Coca Cola 25Lps");
            Console.WriteLine("2. Fresca 23 Lps");
            Console.WriteLine("3. Canada Dry 28 Lps");
            Console.WriteLine("4. Pepsi 27 Lps");
            Console.WriteLine("5. Fanta 24 Lps");
            Console.WriteLine("6. Sprite 26 Lps");
            Console.WriteLine("7. Mirinda 22 Lps");
            Console.WriteLine("8. 7Up 25 Lps");
            Console.WriteLine("9. Red Bull 45 Lps");
            Console.WriteLine("10. Powerade 30 Lps");
            Console.WriteLine("11. Monster 50 Lps");
            Console.WriteLine("12. Mountain Dew 35 Lps");
            Console.WriteLine("13. Jarritos 18 Lps");
            Console.WriteLine("14. Jumex 20 Lps");
            Console.WriteLine("15. Topo Chico 40 Lps");
            Console.WriteLine("16. Sidral Mundet 22 Lps");
            Console.WriteLine("17. Gatorade 28 Lps");
            Console.WriteLine("18. Lipton Tea 30 Lps");
            Console.WriteLine("19. Arizona 32 Lps");
            Console.WriteLine("20. Clipper 26 Lps");
            producto = Console.ReadLine();

            if (producto == "1")
            {
                Precio = 25;
            }
            else if (producto == "2")
            {
                Precio = 23;
            }
            else if (producto == "3")
            {
                Precio = 28;
            }
            else if (producto == "4")
            {
                Precio = 27;
            }
            else if (producto == "5")
            {
                Precio = 24;
            }
            else if (producto == "6")
            {
                Precio = 26;
            }
            else if (producto == "7")
            {
                Precio = 22;
            }
            else if (producto == "8")
            {
                Precio = 25;
            }
            else if (producto == "9")
            {
                Precio = 45;
            }
            else if (producto == "10")
            {
                Precio = 30;
            }
            else if (producto == "11")
            {
                Precio = 50;
            }
            else if (producto == "12")
            {
                Precio = 35;
            }
            else if (producto == "13")
            {
                Precio = 18;
            }
            else if (producto == "14")
            {
                Precio = 20;
            }
            else if (producto == "15")
            {
                Precio = 40;
            }
            else if (producto == "16")
            {
                Precio = 22;
            }
            else if (producto == "17")
            {
                Precio = 28;
            }
            else if (producto == "18")
            {
                Precio = 30;
            }
            else if (producto == "19")
            {
                Precio = 32;
            }
            else if (producto == "20")
            {
                Precio = 26;
            }
            else
            {
                Console.WriteLine("no tenemos el producto seleccionado");
            }

        }
        else if (categoria == "3")
        {
            Console.WriteLine("Tenemos los siguientes Productos, escriba el numero deseado");
            Console.WriteLine("1. Zucaritas 80 Lps");
            Console.WriteLine("2. Fruts Loops 95 Lps");
            Console.WriteLine("3. Choco Crispis 110 Lps");
            Console.WriteLine("4. Corn Flakes 70 Lps");
            Console.WriteLine("5. All Bran 85 Lps");
            Console.WriteLine("6. Honey Bunches 90 Lps");
            Console.WriteLine("7. Special K 100 Lps");
            Console.WriteLine("8. Cheerios 105 Lps");
            Console.WriteLine("9. Cocoa Pebbles 95 Lps");
            Console.WriteLine("10. Lucky Charms 120 Lps");
            Console.WriteLine("11. Raisin Bran 90 Lps");
            Console.WriteLine("12. Captain Crunch 110 Lps");
            Console.WriteLine("13. Trix 100 Lps");
            Console.WriteLine("14. Golden Grahams 95 Lps");
            Console.WriteLine("15. Wheaties 80 Lps");
            Console.WriteLine("16. Frosted Flakes 85 Lps");
            Console.WriteLine("17. Apple Jacks 90 Lps");
            Console.WriteLine("18. Cinnamon Toast Crunch 105 Lps");
            Console.WriteLine("19. Fiber One 95 Lps");
            Console.WriteLine("20. Honey Nut Cheerios 115 Lps");
            producto = Console.ReadLine();

            if (producto == "1")
            {
                Precio = 80;
            }
            else if (producto == "2")
            {
                Precio = 95;
            }
            else if (producto == "3")
            {
                Precio = 110;
            }
            else if (producto == "4")
            {
                Precio = 70;
            }
            else if (producto == "5")
            {
                Precio = 85;
            }
            else if (producto == "6")
            {
                Precio = 90;
            }
            else if (producto == "7")
            {
                Precio = 100;
            }
            else if (producto == "8")
            {
                Precio = 105;
            }
            else if (producto == "9")
            {
                Precio = 95;
            }
            else if (producto == "10")
            {
                Precio = 120;
            }
            else
            {
                Console.WriteLine("no tenemos el producto seleccionado");
            }
        }
        else
        {
            Console.WriteLine("El numero de producto seleccionado no existe");
        }
        if (Edad >= 60)
        {
            double descunto = Precio * 0.15;
            Precio -= descunto;
            Console.WriteLine("Sele aplico un descuento de la tercera edad ");
        }
        Console.WriteLine("El precio del producto es:" + Precio + "lps");
    }
