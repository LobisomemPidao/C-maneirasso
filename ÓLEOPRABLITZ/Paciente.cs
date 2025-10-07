using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ÓLEOPRABLITZ
{
    public class Paciente
    {
        public string Nome;
        public string Idade;
        public string Deficiencia;
        public string Prioridade;
    public static void Cadastrar()
        {
            Console.WriteLine("Escreva o nome");
            string Nome = Console.ReadLine();
            Console.WriteLine("Digite a Idade, maiores de 60 Anos ou menores de 12 serão prioridade.");
            string Idade = Console.ReadLine();
            Console.WriteLine("O paciente tem alguma deficiencia?");
            string Deficiencia = Console.ReadLine();
            Console.WriteLine("O paciente é prioritário? Prioridade 1: Urgencia, Prioridade 2: Emergencia, Prioridade 3: Não-Prioritário");
            string Prioridade = Console.ReadLine();

            Console.WriteLine($"Cadastro feito! nome = {Nome}, idade = {Idade}, deficiencia = {Deficiencia}, prioridade = {Prioridade}");
        }
    }
}

