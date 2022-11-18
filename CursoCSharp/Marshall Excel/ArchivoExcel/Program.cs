using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using ArchivoExcel.Entidades;

namespace ArchivoExcel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Paciente> pacientes = Paciente.Pacientes();
            List<Medico> medicos = Medico.Medicos();
            List<Especialidad> especialidades = Especialidad.Especialidades();

            Excel.Application xaPP = new Excel.Application();

            if (xaPP == null)
            {
                Console.WriteLine("Error");
                return;
            }

            Excel.Workbook xlWorkbookM;
            Excel.Worksheet xlWorksheet;
           
            object misValue = System.Reflection.Missing.Value;

            xlWorkbookM = xaPP.Workbooks.Add(misValue);

            /*******************************Paciente*************************************/

            xlWorksheet = (Excel.Worksheet)xlWorkbookM.Worksheets.get_Item(1);
            xlWorksheet.Name = "Paciente";

            int i = 2;

            xlWorksheet.Cells[1, 1] = "ID";
            xlWorksheet.Cells[1, 2] = "NOMBRE";
            xlWorksheet.Cells[1, 3] = "APELLIDO";
            xlWorksheet.Cells[1, 4] = "No HISTORIA CLINICA";

            foreach (var paciente in pacientes)
            {
                
                xlWorksheet.Cells[i, 1] = paciente.Id;
                xlWorksheet.Cells[i, 2] = paciente.Nombre;
                xlWorksheet.Cells[i, 3] = paciente.Apellido;
                xlWorksheet.Cells[i, 4] = paciente.Nohistoriaclinica;

                i = i+1;
            }
            

            /********************************Medico************************************/

            xlWorksheet = (Excel.Worksheet)xlWorkbookM.Worksheets.Add();
            xlWorksheet.Name = "Medico";

            int j = 2;

            xlWorksheet.Cells[1, 1] = "ID";
            xlWorksheet.Cells[1, 2] = "NOMBRE";
            xlWorksheet.Cells[1, 3] = "APELLIDO";

            foreach (var medico in medicos)
            {

                xlWorksheet.Cells[j, 1] = medico.Id;
                xlWorksheet.Cells[j, 2] = medico.Nombre;
                xlWorksheet.Cells[j, 3] = medico.Apellido;

                j = j + 1;
            }


            /*********************************Especialidad***********************************/

            xlWorksheet = (Excel.Worksheet)xlWorkbookM.Worksheets.Add();
            xlWorksheet.Name = "Especialidad";

            int k = 2;

            xlWorksheet.Cells[1, 1] = "ID";
            xlWorksheet.Cells[1, 2] = "NOMBRE";
         

            foreach (var especialidade in especialidades)
            {

                xlWorksheet.Cells[k, 1] = especialidade.Id;
                xlWorksheet.Cells[k, 2] = especialidade.Nombre;
                

                k = k + 1;
            }


            xlWorkbookM.SaveAs("C:\\Users\\ecolina\\Desktop\\Excel\\prueba.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            xlWorkbookM.Close(true, misValue, misValue);
            xaPP.Quit();

            releaseObject(xlWorkbookM);
            releaseObject(xlWorksheet);
            releaseObject(xaPP);

            Console.WriteLine("El archivo Excel fue creado exitosamente");

            Console.ReadLine();
        }

        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception e)
            {
                obj = null;
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
