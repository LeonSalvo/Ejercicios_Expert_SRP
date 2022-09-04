using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor("Armand", "Neurocirujano");
            Paciente paciente = new Paciente("Steve Jhonson","555-555-555" ,"986782342", "45");
            Consulta consulta = new Consulta(doctor,paciente,"Wall Street");
            Console.WriteLine(consulta.Consult);
            Console.WriteLine(consulta.Identificador);

            Doctor doctor2 = new Doctor("", "");
            Paciente paciente2 = new Paciente("Ralf Manson","555-555-555","","81");
            Consulta consulta2 = new Consulta(doctor2, paciente2, "Queen Street");
            Console.WriteLine(consulta2.Consult);
            Console.WriteLine(consulta2.Identificador);
        }
    }
}
