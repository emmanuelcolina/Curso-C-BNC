using Microsoft.EntityFrameworkCore;
using PresentacionClinica.Models;
using System;


namespace PresentacionClinica
{

    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new clinicaContext())
            {
                var medico = new Medico();

                var especialidad = new Especialidad();

                var paciente = new Paciente();

                /************************Medico*********************************/
                //Ingresar en BD

                /*medico.Nombre = "Pedro";
                medico.Apellido = "Moran";
                medico.Matricula = "17669111";
                context.Medicos.Add(medico);

                context.SaveChanges();*/

                //Actualizar en la BD

                /*var update = context.Medicos.Find(2);
                update.Matricula = "17579943";
                context.Entry(update).State = EntityState.Modified;
                context.SaveChanges();*/

                //Eliminar en la BD
                /*var delete = context.Medicos.Find(2);               
                context.Remove(delete);
                context.SaveChanges();*/

                /************************Especialidad*********************************/

                /*especialidad.Nombre = "Traumatologo";
               
                context.Especialidads.Add(especialidad);

                context.SaveChanges();*/

                /************************Paciente*********************************/

                /*paciente.Nombre = "Esther";
                paciente.Apellido = "Chirinos";
                paciente.Nohistoriaclinica = "0345";
                context.Pacientes.Add(paciente);

                context.SaveChanges();*/



                Console.WriteLine("Lista de Medicos: ");
                foreach (var m in context.Medicos.ToList())
                {
                    Console.WriteLine(m.Id + " " + m.Nombre + " " + m.Apellido + ", Matricula: " + m.Matricula);
                }

                Console.WriteLine("\n");
                Console.WriteLine("Lista de Pacientes: ");
                foreach (var m in context.Pacientes.ToList())
                {
                    Console.WriteLine(m.Id + " " + m.Nombre + " " + m.Apellido + ", Historia Clinica: " + m.Nohistoriaclinica);
                }

                Console.WriteLine("\n");
                Console.WriteLine("Lista de Especialidades: ");
                foreach (var m in context.Especialidads.ToList())
                {
                    Console.WriteLine(m.Id + " " + m.Nombre);
                }
            }
        }
    }
}
