using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateEngine.Docx;

namespace Повышение_квалификации
{
    class Templater
    {
        public void Maketemplate(string outPath)
        {
            DbWorker dbWorker = new DbWorker();
    
            string appPath = Directory.GetCurrentDirectory();

            if (File.Exists(appPath + outPath))
            {
                File.Delete(Path.GetFullPath(appPath + outPath));
            }

            File.Copy(Path.GetFullPath(appPath + "\\Template\\шаблон.docx"), appPath + outPath);

            Dictionary<string, string> req = dbWorker.GetSertificateData();
            if (req != null)
            {
                var valuesToFill = new Content(
                new FieldContent("CoursTipe", req["CoursType"]),
                new FieldContent("LastName", req["LastName"]),
                new FieldContent("FirstName", req["FirstName"]),
                new FieldContent("MiddleName", req["MiddleName"]),
                new FieldContent("DateFrom", req["StartDate"]),
                new FieldContent("DateEnd", req["EndDate"]),
                new FieldContent("EducationType", req["CoursType"]),
                new FieldContent("CoursName", req["CoursName"]),
                new FieldContent("Volume", req["Volume"]),
                new FieldContent("DateNow", DateTime.Now.ToString()),
                new FieldContent("RegisterNumber", req["RegisterNumber"])

            );

                using (var outputDocument = new TemplateProcessor(appPath + outPath)
                .SetRemoveContentControls(true))
                {
                    outputDocument.FillContent(valuesToFill);
                    outputDocument.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Данных по обучающимся не найдено!");
            }

        }
    }
}
