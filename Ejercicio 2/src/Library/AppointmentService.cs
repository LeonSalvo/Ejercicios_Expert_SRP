using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public string appoinmentPlace {get; set;}

        public static string CreateAppointment(DateTime date, string appoinmentPlace, Doctor doctor, Paciente paciente)
        {
            StringBuilder stringBuilder = new StringBuilder("Creando consulta...\n");
            Boolean isValid = true;

            if (doctor.IsValid == false)
            {
                stringBuilder.Append("No es posible crear la consulta, faltan datos del doctor\n");
                isValid = false;
            }
            if (paciente.IsValid == false)
            {
                stringBuilder.Append("No es posible crear la consulta, faltan datos del paciente\n");
                isValid = false;
            }
            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("No es posible crear la consulta, falta el lugar de la consulta\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Consulta creada.");
            }
            return stringBuilder.ToString();
        }


    }
}

