using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cedula;
            string nombre;
            int tipoEmpleado;
            float salarioPorhora;
            int horasTrabajadas;
            float salarioOrdinario;
            float aumento;
            float salarioBruto;
            const float porcentajeCCSS = 0.0917f;
            float deduccionCCSS;
            float salarioNeto;

            Console.WriteLine("Ingrese la cédula del empleado:");
            cedula = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del empleado:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de empleado(1: Operario, 2: Tecnico o 3: Profesional):");
            tipoEmpleado = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el salario por hora:");
            salarioPorhora = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese las horas trabajadas:");
            horasTrabajadas = int.Parse(Console.ReadLine());

            salarioOrdinario = salarioPorhora * horasTrabajadas;
            
            if (tipoEmpleado == 1)
            {
                aumento = salarioOrdinario * 0.15f;
            }
            else if (tipoEmpleado == 2)
            {
                aumento = salarioOrdinario * 0.10f;
            }
            else
            {
                aumento = salarioOrdinario * 0.05f;
            }


            salarioBruto = salarioOrdinario + aumento;
            deduccionCCSS = salarioBruto * porcentajeCCSS;
            salarioNeto = salarioBruto - deduccionCCSS;

            Console.WriteLine($"Cédula: {cedula}");
            Console.WriteLine($"Nombre Empleado: {nombre}");
            if (tipoEmpleado == 1)
            {
                Console.WriteLine($"Tipo de Empleado: Operario");
            }
            else if (tipoEmpleado == 2)
            {
                Console.WriteLine($"Tipo de Empleado: Técnico");
            }
            else
            {
                Console.WriteLine($"Tipo de Empleado: Profesional");
            }
            Console.WriteLine($"Salario por hora: {salarioPorhora}");
            Console.WriteLine($"Horas trabajadas: {horasTrabajadas}");
            Console.WriteLine($"Salario Ordinario: {salarioOrdinario}");
            Console.WriteLine($"Aumento: {aumento}");
            Console.WriteLine($"Salario Bruto: {salarioBruto}");
            Console.WriteLine($"Deducción CCSS: {deduccionCCSS}");
            Console.WriteLine($"Salario Neto: {salarioNeto}");


        }
    }
}
