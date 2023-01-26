using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using System.IO;
using CsvHelper.Configuration.Attributes;

namespace Prog_122_W23_Lecture_6_Class_Methods.DataExample
{
    /// <summary>
    /// Interaction logic for DataExample.xaml
    /// </summary>
    public partial class DataExample : Window
    {
        public DataExample()
        {
            InitializeComponent();
            SaveTwo();
        
        }

        public void SaveTwo()
        {

            var records = new List<User>
                {
                    new User("Will", "Cram", "Teacher"),
                    new User("Anne", "Nguyen", "Teacher"),
                    new User("Jon", "Reed", "Teacher"),
                };

            using (var writer = new StreamWriter("../../../DataExample/users2.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }
        }

        public void LoadData()
        {
            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = false,
                Comment = '#',
                AllowComments = true,
                Delimiter = ",",
            };

            using var streamReader = File.OpenText("../../../DataExample/users.csv");
            using var csvReader = new CsvReader(streamReader, csvConfig);

            while (csvReader.Read())
            {
                var firstName = csvReader.GetField(0);
                var lastName = csvReader.GetField(1);
                var occupation = csvReader.GetField(2);

                runDisplay.Text += $"{firstName} {lastName} is {occupation}\n";
            }
        } // LoadData()

        public void SaveData()
        {
            var users = new List<User>
{
            new ("John", "Doe", "gardener"),
            new ("Roger", "Roe", "driver"),
            new ("Lucy", "Smith", "teacher"),
            new ("Will", "Cram", "teacher")
            };

            using var mem = new MemoryStream();
            using var writer = new StreamWriter(mem);
            using var csvWriter = new CsvWriter(writer, CultureInfo.CurrentCulture);

            csvWriter.WriteField("FirstName");
            csvWriter.WriteField("LastName");
            csvWriter.WriteField("Occupation");
            csvWriter.NextRecord();

            foreach (var user in users)
            {
                csvWriter.WriteField(user.FirstName);
                csvWriter.WriteField(user.LastName);
                csvWriter.WriteField(user.Occupation);
                csvWriter.NextRecord();
            }

            writer.Flush();
            var res = Encoding.UTF8.GetString(mem.ToArray());
            Console.WriteLine(res);

            //record User(string FirstName, string LastName, string Occupation);
        }
    }
}
