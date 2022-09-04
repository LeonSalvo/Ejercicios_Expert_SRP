using System;
using System.Text;
namespace Library
{
    public class Doctor
    {
        public string Name {get; set;}
        public string Specialty {get; set;}
        public bool IsValid {get; set;}

        public Doctor(string name, string specialty)
        {
            this.IsValid = true;
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Nombre del doctor inválido.");
                this.Name = null;
                this.IsValid = false;
            }
            else
            {
                this.Name = name;
            }
            if (string.IsNullOrEmpty(specialty))
            {
                Console.WriteLine("Especialidad inválida.");
                this.Specialty = null;
                this.IsValid = false;
            }
            else
            {
                this.Specialty = specialty;
            }
        }
    }
}