using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Data
{
    public class StudentRepository
    {
        private string _filePath;

        public StudentRepository(string filePath)
        {
            _filePath = filePath;
        }

        //list, add, edit, delete
        public List<Student> List()
        {
            List<Student> students = new List<Student>();

            using (StreamReader sr = new StreamReader(_filePath))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Student newStudent = new Student();
                    string[] columns = line.Split(',');
                    newStudent.FirstName = columns[0];
                    newStudent.LastName = columns[1];
                    newStudent.Major = columns[2];
                    newStudent.GPA = decimal.Parse(columns[3]);
                    students.Add(newStudent);
                }
            } 
            return students;
        }

        public void Add(Student student)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, true))
            {
                string line = string.Format("{0},{1},{2},{3}", student.FirstName, student.LastName, student.Major,
                    student.GPA.ToString());
                sw.WriteLine(line);
            }
        }

        public void Edit(Student student, int index)
        {
            throw new NotImplementedException();
        }

        public void Delete(int index)
        {
            throw new NotImplementedException();
        }
    }
}
