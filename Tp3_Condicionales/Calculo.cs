using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_Condicionales
{
    internal class Calculo
    {
        public static string formar(double palabra)
        {
            string result = Convert.ToString(palabra);
            string result2 = "";
            if (result.Length > 3 && result.Length < 7)
            {
                var sb = new StringBuilder(result);
                sb.Insert(result.Length - 3, ".");
                return sb.ToString();
            }
            else if (result.Length > 7)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (i % 3 == 0 && i > 0)
                    {
                        result2 += ".";
                    }
                    result2 += result[i];
                }

                return result2.ToString();
            }
            else
            {
                string resultado = result.ToString();

                return resultado;
            }



        }





        public void calculadora()
        {
            double num, num2, total;
            Console.WriteLine("Ingrese el primer numero:");
            num = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero segun la opcion:");
            Console.WriteLine("1.SUMAR");
            Console.WriteLine("2.RESTAR");
            Console.WriteLine("3.DIVIDIR");
            Console.WriteLine("4.MULTIPLICAR");
            string op = Console.ReadLine();
            switch (op)
            {
                case "1":
                    total = num + num2;
                    Console.WriteLine($"El total es: {total}");
                    Console.ReadKey();

                    break;
                case "2":
                    total = num - num2;
                    Console.WriteLine($"El total es: {total}");
                    Console.ReadKey();
                    break;
                case
                    "3":

                    total = num / num2;
                    Console.WriteLine($"El total es: {total}");
                    Console.ReadKey();
                    break;
                case
                    "4":
                    total = num * num2;
                    Console.WriteLine($"El total es: {total}");
                    Console.ReadKey();
                    break;
            }
        }
        public void diasSemana()
        {
            List<string> dias = new List<string>() { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes","Sabado","Domingo" };
            int num;
            string op;

            Boolean val;
            do
            {
                val = false;
                Console.WriteLine("Ingrese un numero del 1 al 7");
                num = int.Parse(Console.ReadLine());
                if (num > 7 || num <= 0)
                {

                    val = true;
                }

            } while (val);
            switch (num)
            {
                case 1:
                    Console.WriteLine($"El dia de la semana es: {dias[0]}");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine($"El dia de la semana es: {dias[1]}");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine($"El dia de la semana es: {dias[2]}");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine($"El dia de la semana es: {dias[3]}");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine($"El dia de la semana es: {dias[4]}");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine($"El dia de la semana es: {dias[5]}");
                    Console.ReadKey();
                    break;
                case 7:
                    Console.WriteLine($"El dia de la semana es: {dias[6]}");
                    Console.ReadKey();
                    break;
            }



        }
        public void letras()
        {

            int num;
            Boolean val;
            do
            {
                val = false;
                Console.WriteLine("Ingrese un numero del 1 al 10");
                num = int.Parse(Console.ReadLine());
                if (num > 10 || num <= 0)
                {

                    val = true;
                }

            } while (val);
            switch (num)
            {
                case 1:
                    Console.WriteLine($"La nota para un {num} es : 'A' ");
                    break;
                case 2:
                    Console.WriteLine($"La nota para un {num} es : 'B' ");
                    break;
                case 3:
                    Console.WriteLine($"La nota para un {num} es : 'C' ");
                    break;
                case 4:
                    Console.WriteLine($"La nota para un {num} es : 'D' ");
                    break;
                case 5:
                    Console.WriteLine($"La nota para un {num} es : 'E' ");
                    break;
                case 6:
                    Console.WriteLine($"La nota para un {num} es : 'F' ");
                    break;
                case 7:
                    Console.WriteLine($"La nota para un {num} es : 'G' ");
                    break;
                case 8:
                    Console.WriteLine($"La nota para un {num} es : 'H' ");
                    break;
                case 9:
                    Console.WriteLine($"La nota para un {num} es : 'I' ");
                    break;
                case 10:
                    Console.WriteLine($"La nota para un {num} es : 'J' ");
                    break;
            }


        }
        public void triangulo()
        {
            Boolean val = false;
            int triangulo = 0;
            double tt, v1, v2, v3;
            string op;
            do
            {
                Console.WriteLine("Ingrese el valor de los 3 lados:");
                v1 = double.Parse(Console.ReadLine());
                v2 = double.Parse(Console.ReadLine());
                v3 = double.Parse(Console.ReadLine());

                if (v1 == v2 && v2 == v3)
                {
                    triangulo = 1;
                }
                else if (v1 != v2 && v2 != v3 && v1 != v3)

                {
                    triangulo = 2;
                }
                else
                {
                    triangulo = 0;
                }

                switch (triangulo)
                {
                    case 0: Console.WriteLine("El triangulo es isoceles"); break;
                    case 1: Console.WriteLine("Es equilatero"); break;
                    case 2:
                        Console.WriteLine("El triangulo es escaleno");
                        break;
                }
                Console.WriteLine("Para salir oprima 'S'");
                op = Console.ReadLine();
                if (op == "s" || op == "S")
                {
                    val = true;
                }
                else
                {
                    val = false;
                }
            } while (!val);
            // Console.ReadKey();

        }
        public void estaciones()
        {
            int mes;
            Boolean val;
            do
            {
                val = false;
                Console.WriteLine("Ingrese un numero del 1 al 12");
                mes = int.Parse(Console.ReadLine());
                if (mes > 12 || mes <= 0)
                {

                    val = true;
                }

            } while (val);
            switch (mes)
            {
                case 1: Console.WriteLine("Corresponde Verano!"); break;
                case 2: Console.WriteLine("Corresponde Verano!"); break;
                case 3: Console.WriteLine("Corresponde Otoño!"); break;
                case 4: Console.WriteLine("Corresponde Otoño!"); break;
                case 5: Console.WriteLine("Corresponde Otoño!"); break;
                case 6: Console.WriteLine("Corresponde Invierno!"); break;
                case 7: Console.WriteLine("Corresponde Invierno!"); break;
                case 8: Console.WriteLine("Corresponde Invierno!"); break;
                case 9: Console.WriteLine("Corresponde Primavera!"); break;
                case 10: Console.WriteLine("Corresponde Primavera!"); break;
                case 11: Console.WriteLine("Corresponde Primavera!"); break;
                case 12: Console.WriteLine("Corresponde Verano!"); break;

            }
            Console.ReadKey();
        }
        public void meses()
        {

            Console.WriteLine("Ingrese el numero del mes:");
            int mes = int.Parse(Console.ReadLine());
            int mesfe;
            switch (mes)
            {
                case 1: Console.WriteLine("El mes de enero tiene 31 dias"); break;
                case 2:
                    Console.WriteLine("Indica con '1' si es año bisiesto y con '2' si no lo es");
                    mesfe = int.Parse(Console.ReadLine());
                    if (mesfe == 1) Console.WriteLine("Febrero Tiene 29 dias");
                    if (mesfe == 2) Console.WriteLine("Febrero Tiene 28 dias");
                    Console.ReadKey();
                    break;
                case 3: Console.WriteLine("Marzo tiene 31 dias"); Console.ReadKey(); break;
                case 4: Console.WriteLine("Abril tiene 30 dias"); Console.ReadKey(); break;
                case 5: Console.WriteLine("Mayo tiene 31 dias"); Console.ReadKey(); break;
                case 6: Console.WriteLine("Junio tiene 30 dias"); Console.ReadKey(); break;
                case 7: Console.WriteLine("Julio tiene 31 dias"); Console.ReadKey(); break;
                case 8: Console.WriteLine("Agosto tiene 31 dias"); Console.ReadKey(); break;
                case 9: Console.WriteLine("Septiembre tiene 30 dias"); Console.ReadKey(); break;
                case 10: Console.WriteLine("Octubre tiene 31 dias"); Console.ReadKey(); break;
                case 11: Console.WriteLine("Nobiembre tiene 30 dias"); Console.ReadKey(); break;
                case 12: Console.WriteLine("Diciembre tiene 31 dias"); Console.ReadKey(); break;

            }
        }
        public void conersor()
        {
            double unidad, conver;
            Console.WriteLine("Elija la opcion:");
            Console.WriteLine("1.Convertir cm a Kilometros");
            Console.WriteLine("2.Convertir KM a Centimetros");
            Console.WriteLine("3.Convertir cm a Metros");
            Console.WriteLine("4.Convertir metros a centimetros");
            string eleccion = Console.ReadLine();
            string result, total;

            switch (eleccion)
            {
                case "1":
                    Console.WriteLine("Ingrese la unidad en cm a convertir");
                    unidad = double.Parse(Console.ReadLine());
                    conver = unidad / 100000;
                    total = formar(conver);
                    Console.WriteLine($"el total es {total} kilometros");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Ingrese la unidad en kms a convertir");
                    unidad = double.Parse(Console.ReadLine());
                    conver = unidad * 100000;
                    total = formar(conver);
                    Console.WriteLine($"el total es {total} centimetros");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("Ingrese la unidad en cm a convertir");
                    unidad = double.Parse(Console.ReadLine());
                    conver = unidad / 100;
                    total = formar(conver);
                    Console.WriteLine($"el total es {total} metros");
                    Console.ReadKey();
                    break;
                case "4":
                    Console.WriteLine("Ingrese la unidad en metros a convertir");
                    unidad = double.Parse(Console.ReadLine());
                    conver = unidad * 100;
                    total = formar(conver);
                    Console.WriteLine($"el total es {total} centimetros");
                    Console.ReadKey();
                    break;

            }
        }
        public void descuentoCantidad()
        {
            double importe, descuento;
            string opc, result;
            int opcion = 0;
            Console.WriteLine("Se aplicara un descuento del 15% si el importe es mayor a $10.000 y un descuento del 20% si el importe es mayor a $50.000");
            Console.WriteLine("Si es menor a $10.000 se aplicara un descuento del 10% si es efectivo");
            Console.WriteLine("Ingrese el importe");
            importe = double.Parse(Console.ReadLine());

            if (importe != 0 && importe > 10000 && importe < 50000)
            {
                opcion = 1;
            }
            else if (importe != 0 && importe > 50000)
            {
                opcion = 2;

            }
            else if (importe != 0 && importe < 10000)
            {
                opcion = 3;
            }
            switch (opcion)
            {
                case 1:
                    descuento = importe - (importe * 0.15);
                    result = formar(descuento);
                    Console.WriteLine($"El importe total es de $ {result} y se aplico un descuento del 15%");
                    Console.ReadKey();
                    break;
                case 2:
                    descuento = importe - (importe * 0.2);
                    result = formar(descuento);
                    Console.WriteLine($"El importe total es de $ {result} y se aplico un descuento del 20%");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Ingrese 1 si es efectivo y 2 si es otro medio de pago");
                    opc = Console.ReadLine();

                    switch (opc)
                    {
                        case "1":
                            descuento = importe - (importe * 0.1);
                            result = formar(descuento);
                            Console.WriteLine($"El importe total es de $ {result} y se aplico un descuento del 10%");
                            Console.ReadKey();
                            break;

                        case "2":
                            result = formar(importe);
                            Console.WriteLine($"NO se aplicara descuento porque el importe es menor a $10.000, el importe a pagar es $ {result}");
                            Console.ReadKey();
                            break;
                        default: Console.WriteLine("INGRESO ERRONEO"); break;
                    }

                    break;
                default: Console.WriteLine("INGRESO ERRONEO"); break;

            }

        }
        public void clasificarNumeros()
        {
            Console.WriteLine("ingrese el numero");
            int num = int.Parse(Console.ReadLine());
            int clasificacion=0;
            if (num == 0) { clasificacion = 0; }
            if (num > 0) {  clasificacion = 1; }
            if(num < 0) {  clasificacion = 2; }
            switch (clasificacion) {
                case 0: Console.WriteLine("Ees un numeo 0");Console.ReadKey(); break;
                    case 1: Console.WriteLine("Es un numero positivo"); Console.ReadKey(); break;
                    case 2: Console.WriteLine("Es un numero negativo"); Console.ReadKey(); break;
                 

            }
        }
        public void parqueAcuatico()
        {
            int edad;
            double altura, peso;
            Boolean apto=false;
            string clasif="nada";
            Console.WriteLine("Ingrese la edad:");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            altura= double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el peso");
            peso = double.Parse(Console.ReadLine());  
            if (edad< 12) { clasif = "niño"; }
            else if (edad == 12 && edad <= 17) { clasif = "adolecente"; }
            else if (edad > 17 && edad <= 64) { clasif = "adulto"; }
            else if (edad > 64) { clasif = "adulto mayor"; }
            if (altura > 1.5 && peso<120) {apto = true; }
            switch (clasif)
            {
                case "niño": Console.WriteLine($"Clasificacion:{clasif.ToString()}");
                    if (apto) { Console.WriteLine("Esta apto para entrar"); } else { Console.WriteLine("No esta apto"); } 
                    Console.ReadKey();
                    break;
                case "adolecente":
                    Console.WriteLine($"Clasificacion:{clasif.ToString()}");
                    if (apto) { Console.WriteLine("Esta apto para entrar"); } else { Console.WriteLine("No esta apto"); }
                    Console.ReadKey();
                    break;
                case "adulto":
                    Console.WriteLine($"Clasificacion:{clasif.ToString()}");
                    if (apto) { Console.WriteLine("Esta apto para entrar"); } else { Console.WriteLine("No esta apto"); }
                    Console.ReadKey();
                    break;
                case "adulto mayor":
                    Console.WriteLine($"Clasificacion:{clasif.ToString()}");
                    if (apto) { Console.WriteLine("Esta apto para entrar"); } else { Console.WriteLine("No esta apto"); }
                    Console.ReadKey();
                    break;
            }
            











        }
    }
}
