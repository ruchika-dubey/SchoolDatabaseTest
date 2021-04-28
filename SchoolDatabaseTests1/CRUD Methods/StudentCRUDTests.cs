using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using SchoolDatabase.CRUD_Methods;
using SchoolDatabase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDatabase.CRUD_Methods.Tests
{
    [TestFixture()]
    public class StudentCRUDTests
    {
        [TestMethod()]
        public void AddNewStudentTest()
        {
            Student student = new Student();
            student.ID = "STUD-001";
            student.Name = "Prateek Tiwary";
            student.Class = "5th B";
            bool flag = StudentCRUD.AddNewStudent(student);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(true, flag);
        }

        [Test()]
        public void DeleteStudentTest()
        {
            string student = "STUD-001";
            bool flag = StudentCRUD.DeleteStudent(student);
            Assert.AreEqual(true, flag);
        }

        [Test()]
        public void UpdateStudentTest()
        {
            Student student = new Student();
            student.ID = "STUD-001";
            student.Name = "Ruchika Dubey";
            student.Class = "10th B";
            bool flag = StudentCRUD.UpdateStudent(student);
            Assert.AreEqual(true, flag);
        }
        }
}