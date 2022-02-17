using System;
/// <summary>
/// Nombre: Sara Daniela Parra Betancur
/// Fecha: 16/02/2022
/// nombreProyecto: punto20
/// </summary>

namespace tallerConceptosFundamentales
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, caso;
            int diasLaborados;
            double bonoProfesional, bonoAlimentacion, ganaciasTotales, sueldoTotal, deducciones;
            double sueldoQuincenal = 1050000;
            double bonoTransporte = 120000;
            double seguroColectivo = (sueldoQuincenal / 100) * 2;
            double eps = (sueldoQuincenal / 100) * 2;
            double paroForzoso = (sueldoQuincenal / 100) * 1;
            double cajaDeCompensacion = (sueldoQuincenal / 100) * 2;

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine(nombre + " si tiene un titulo universitario escriba 1 y si no tiene escriba 2.");
            caso = Console.ReadLine();

            switch (caso)
            {
                case "1":

                    Console.WriteLine(nombre + " durante esta quincena, ¿Cuántos días trabajó?");
                    diasLaborados = Convert.ToInt16(Console.ReadLine());
                    bonoAlimentacion = diasLaborados * 25000;
                    bonoProfesional = (sueldoQuincenal / 100) * 10;
                    ganaciasTotales = sueldoQuincenal + bonoProfesional + bonoAlimentacion;
                    deducciones = seguroColectivo + eps + paroForzoso + cajaDeCompensacion;
                    sueldoTotal = ganaciasTotales - deducciones;


                    Console.WriteLine(nombre + " su sueldo fijo quincenal es " + sueldoQuincenal);
                    Console.WriteLine(nombre + " su bono de transporte quincenal es " + bonoTransporte);
                    Console.WriteLine(nombre + " su bono de alimentacion quincenal es " + bonoAlimentacion);
                    Console.WriteLine(nombre + " su bono por profesionalización es " + bonoProfesional);
                    Console.WriteLine("");
                    Console.WriteLine(nombre + " sus ganancias totales durante esta quincena son " + ganaciasTotales);
                    Console.WriteLine("");
                    Console.WriteLine(nombre + " su descuento por EPS es de " + eps);
                    Console.WriteLine(nombre + " su descuento por seguro colectivo es de " + seguroColectivo);
                    Console.WriteLine(nombre + " su descuento por paro forzoso es de " + paroForzoso);
                    Console.WriteLine(nombre + " su descuento por caja de compensación es de " + cajaDeCompensacion);
                    Console.WriteLine("");
                    Console.WriteLine(nombre + " el total de sus deducciones son de " + deducciones);
                    Console.WriteLine("");
                    Console.WriteLine(nombre + " su sueldo total durante esta quincena es de  " + sueldoTotal);


                    break;


                case "2":

                    Console.WriteLine(nombre + " durante esta quincena, ¿Cuantos dias trabajó");
                    diasLaborados = Convert.ToInt32(Console.ReadLine());
                    bonoAlimentacion = diasLaborados * 25000;
                    ganaciasTotales = sueldoQuincenal + bonoAlimentacion;
                    deducciones = seguroColectivo + eps + paroForzoso + cajaDeCompensacion;
                    sueldoTotal = ganaciasTotales - deducciones;


                    Console.WriteLine(nombre + " su sueldo fijo quincenal es " + sueldoQuincenal);
                    Console.WriteLine(nombre + " su bono de transporte quincenal es " + bonoTransporte);
                    Console.WriteLine(nombre + " su bono de alimentacion quincenal es " + bonoAlimentacion);
                    Console.WriteLine(nombre + " usted no cuenta con derechos a bono de profesionalización");
                    Console.WriteLine("");
                    Console.WriteLine(nombre + " sus ganancias totales durante esta quincena son " + ganaciasTotales);
                    Console.WriteLine("");
                    Console.WriteLine(nombre + " su descuento por EPS es de " + eps);
                    Console.WriteLine(nombre + " su descuento por seguro colectivo es de " + seguroColectivo);
                    Console.WriteLine(nombre + " su descuento por paro forzoso es de " + paroForzoso);
                    Console.WriteLine(nombre + " su descuento por caja de compensación es de " + cajaDeCompensacion);
                    Console.WriteLine("");
                    Console.WriteLine(nombre + " el total de sus deducciones son de " + deducciones);
                    Console.WriteLine("");
                    Console.WriteLine(nombre + "su sueldo total durante esta quincena es de  " + sueldoTotal);


                    break;

            }


            Console.ReadKey();
        }
    }
}
