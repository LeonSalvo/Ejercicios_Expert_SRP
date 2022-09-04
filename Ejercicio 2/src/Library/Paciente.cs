using System;
using System.Text;
namespace Library
{
    public class Paciente
    {
        public string Name {get; set;}
        public string Id {get; set;}
        public string PhoneNumber {get; set;}
        public string Age {get; set;}
        public bool IsValid {get; set;}


        public Paciente(string name, string id, string phoneNumber, string age )
        {
            this.IsValid = true;
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Nombre del paciente inválido.");
                this.Name = null;
                this.IsValid = false;
            }
            else
            {
                this.Name = name;
            }

            if (string.IsNullOrEmpty(id))
            {
                Console.WriteLine("Id inválida.");
                this.Id = null;
                this.IsValid = false;
            }
            else
            {
                this.Id = id;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                Console.WriteLine("Número de teléfono invalido");
                this.PhoneNumber = null;
                this.IsValid = false;
            }
            else
            {
                this.PhoneNumber = phoneNumber;
            }
            if (string.IsNullOrEmpty(age))
            {
                Console.WriteLine("Edad inválida.");
                this.Age = null;
                this.IsValid = false;
            }
            else
            {
                this.Age = age;
            }
        }
    }
}