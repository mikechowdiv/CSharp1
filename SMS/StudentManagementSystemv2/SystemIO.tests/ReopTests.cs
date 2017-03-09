using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;
using System.IO;

namespace SystemIO.tests
{
    [TestFixture]
    public class ReopTests
    {
       private const string _filePath = @"E:\workspace\SG-works\assignments\SMS\Data\SystemIO\StudentTest.txt";
        private const string _originalDate = @"E:\workspace\SG-works\assignments\SMS\Data\SystemIO\StudentTestSeed.txt";


        [SetUp]
        public void Setup()
        {
            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }
            File.Copy(_originalDate,_filePath);
        }

        [Test]
        public void CanReadFile()
        {
            StudentRepository repo = new StudentRepository(_filePath);
            List<Student> students = repo.List();
            Assert.AreEqual(4,students.Count());

            Student check = students[2];
            Assert.AreEqual("Jane",check.FirstName);
            Assert.AreEqual("Doe",check.LastName);
            Assert.AreEqual("Computer Science",check.Major);
            Assert.AreEqual(4.0M,check.GPA);
        }

        [Test]
        public void CanAddStudent()
        {
            StudentRepository repo = new StudentRepository(_filePath);
            Student newStudent = new Student();
            newStudent.FirstName = "Testy";
            newStudent.LastName = "Tester";
            newStudent.Major = "Research";
            newStudent.GPA = 3.2M;

            repo.Add(newStudent);

            List<Student> students = repo.List();

            Assert.AreEqual(5,students.Count());

            Student check = students[4];

            Assert.AreEqual("Testy", check.FirstName);
            Assert.AreEqual("Tester", check.LastName);
            Assert.AreEqual("Research", check.Major);
            Assert.AreEqual(3.2M, check.GPA);
        }
    }
}
