using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest20_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite número de funcionários");
            int numero_de_funcionarios = Convert.ToInt32(Console.ReadLine());
            double ir =0;
            double vt;
            double vr;
            double soma_salario = 0;
            double salario_liquido;

            while(numero_de_funcionarios > 0)
            {
                Console.WriteLine("Digite o salário do funcionário:");
                double salario_bruto= Convert.ToDouble(Console.ReadLine());
                vr = salario_bruto * 0.02;
                vt = salario_bruto * 0.01;
               
                if(salario_bruto < 3000)
                {
                    ir = salario_bruto * 0.12;
                    
                }
                else if(salario_bruto >= 3001 && salario_bruto <= 5500) {
                    ir = salario_bruto * 0.17;
                    
                }
                else if (salario_bruto >= 5501 )
                {
                    ir = salario_bruto * 0.275;
                   
                }
                salario_liquido = salario_bruto - vt - vr - ir;
                soma_salario += salario_liquido;

                numero_de_funcionarios--;
               
               

            }
            Console.WriteLine("Soma dos salários liquidos:" + soma_salario);
            Console.ReadLine();
        }
    }
}
