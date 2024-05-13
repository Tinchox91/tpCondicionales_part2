using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_Condicionales
{
    internal class Incio
    {
        static void Main(string[] args)
        {
            Boolean salir=false;
            do
            {
                Calculo calculo = new Calculo();
                Console.WriteLine("Ingrese numero segun opcion deseada...");
                Console.WriteLine("1.Calculadora basica");
                Console.WriteLine("2.Dias de la semana");
                Console.WriteLine("3.Copnversion de clasificaciones a letras");
                Console.WriteLine("4.Clasificaion de triangulos");
                Console.WriteLine("5.Estaciones del año");
                Console.WriteLine("6.Dias de un mes");
                Console.WriteLine("7.Conversion de unidades de medida");
                Console.WriteLine("8.descuento segun la cantidad de compra");
                Console.WriteLine("9.Clasificacion de numeros positivos, negativos o cero");
                Console.WriteLine("10.Clasificacion para el juego acuatico en el parque de diversiones");
                Console.WriteLine("11.Salir");
                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1: calculo.calculadora(); Console.Clear(); break;
                    case 2: calculo.diasSemana(); Console.Clear(); break;
                    case 3: calculo.letras(); Console.Clear(); break;
                    case 4: calculo.triangulo(); Console.Clear(); break;
                    case 5: calculo.estaciones(); Console.Clear(); break;
                    case 6: calculo.meses(); Console.Clear(); break;
                    case 7: calculo.conersor(); Console.Clear(); break;
                    case 8: calculo.descuentoCantidad(); Console.Clear(); break;
                    case 9: calculo.clasificarNumeros(); Console.Clear(); break;
                    case 10: calculo.parqueAcuatico(); Console.Clear(); break;
                    case 11: salir=true; break;
                        default: Console.Clear(); Console.WriteLine("numero erroneo!");  break;
                }
            } while (!salir);

            }
            
        }
}
