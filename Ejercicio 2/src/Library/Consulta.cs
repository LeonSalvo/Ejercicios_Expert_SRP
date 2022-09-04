using System;
namespace Library
{
    public class Consulta
    {
        public int Identificador {get; set;}
        public Doctor Doc {get; set;}
        public Paciente Pac{get; set;}
        public string AppoinmentPlace {get; set;}
        public string Consult {get; set;}
        public static int Contador = 0;
        public Consulta(Doctor doctor, Paciente paciente, string appointmentPlace)
        {
            this.Consult = AppointmentService.CreateAppointment(DateTime.Now, appointmentPlace, doctor, paciente);
            this.Doc = doctor;
            this.Pac = paciente;
            this.AppoinmentPlace = appointmentPlace;
            this.Identificador = Contador;
            Contador++;
        }

    }   
}