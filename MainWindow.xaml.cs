using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Prog_122_W23_Lecture_6_Class_Methods
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Student> students = new List<Student>();

        Course csi122;


        //Optional: 

        //What is method overloading?
        //What needs to be different to overload a method?
        public MainWindow()
        {
            InitializeComponent();
            csi122 = new Course("CSI 122", "Will Cram");
            new DataExample.DataExample().Show();

        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudentToList();

            int lastStudentEntered = students.Count - 1;
            Student lastStudent = students[lastStudentEntered];


            csi122.EnrollStudent(lastStudent);
           
            runDisplay.Text = "";
            runDisplay.Text = csi122.CourseName + " " + csi122.Teacher + "\n";
            MessageBox.Show(csi122.RosterAverage().ToString());


            foreach (Student student in csi122.CourseRoster)
            {
                runDisplay.Text += student + "\n";
            }

            //DisplayStudents();

        } // btnAddStudent_Click


        public void AddStudentToList()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            double csiGrade = double.Parse(txtCSIGrade.Text);
            double genEdGrade = double.Parse(txtGenEdGrade.Text);

            //Student student = new Student(firstName, lastName, csiGrade, genEdGrade);

            // Add student to my list of students
            students.Add(new Student(firstName, lastName, csiGrade, genEdGrade));

            
        } // 

        public void DisplayStudents()
        {
            // CLears our display
            runDisplay.Text = "";

            // Shows all of our students
            for (int i = 0; i < students.Count; i++)
            {
                runDisplay.Text += students[i] + "\n";
               
            }
        }

    }
}
