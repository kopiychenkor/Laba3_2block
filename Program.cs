using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace struck_lab_student
{
    partial class Program
    {
        static void СonsolOutput(Student student, int studsNum)
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}",
                student.surName, student.firstName, student.patronymic, student.sex, student.dateOfBirth,
                student.mathematicsMark, student.physicsMark, student.informaticsMark, student.scholarship, studsNum);
        }
        static void Audit(Student student, int studsNum)
        {
            string[] dataFromFile = File.ReadAllLines("data.txt");
            if (student.sex == 'М') 
            {
                if ((student.mathematicsMark == '-') && (student.physicsMark == '-'))
                {
                    Student[] resStudent = new Student[dataFromFile.Length];
                    for (int i = 0; i < dataFromFile.Length; i++)
                    {
                        resStudent[i] = new Student(dataFromFile[i]);
                    }
                    for (int i = 0; i < resStudent.Length; i++)
                        СonsolOutput(resStudent[i], i + 1);
                }
                if((student.physicsMark == '-') && (student.informaticsMark == '-'))
                {
                    Student[] resStudent = new Student[dataFromFile.Length];
                    for (int i = 0; i < dataFromFile.Length; i++)
                    {
                        resStudent[i] = new Student(dataFromFile[i]);
                    }
                    for (int i = 0; i < resStudent.Length; i++)
                        СonsolOutput(resStudent[i], i + 1);
                }
                if((student.mathematicsMark == '-') && (student.informaticsMark == '-'))
                {
                    Student[] resStudent = new Student[dataFromFile.Length];
                    for (int i = 0; i < dataFromFile.Length; i++)
                    {
                        resStudent[i] = new Student(dataFromFile[i]);
                    }
                    for (int i = 0; i < resStudent.Length; i++)
                        СonsolOutput(resStudent[i], i + 1);
                }
            }
        }

        static Student[] ReadData(string fileName)
        {
            string[] dataFromFile = File.ReadAllLines("data.txt");
            Student[] resStud = new Student[dataFromFile.Length];
            for (int i = 0; i < dataFromFile.Length; i++)
            {
                resStud[i] = new Student(dataFromFile[i]);
                
            }
            for (int i = 0; i < resStud.Length; i++)
                    СonsolOutput(resStud[i], i + 1);
            return resStud;
        }
        static void runMenu(Student[] studs)
        {
            
        }
        static void Main()
        {
            Student[] studs = ReadData("data.txt");
            runMenu(studs);
            Console.ReadKey();
        }
    }
}
