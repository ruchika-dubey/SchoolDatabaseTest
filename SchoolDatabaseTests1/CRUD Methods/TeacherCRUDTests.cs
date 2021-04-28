using NUnit.Framework;
using SchoolDatabase.CRUD_Methods;
using SchoolDatabase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDatabase.CRUD_Methods.Tests
{
    [TestFixture()]
    public class TeacherCRUDTests
    {
        [Test()]
        public void AddNewTeacherTest()
        {
            Teacher teacher = new Teacher();
            teacher.ID = "TEACH-001";
            teacher.Name = "Mr Tiwary";
            teacher.Qualification = "BSC";
            bool flag = TeacherCRUD.AddNewTeacher(teacher);
            Assert.AreEqual(true, flag);
        }

        [Test()]
        public void DeleteTeacherTest()
        {
            string teacher = "TEACH-001";
            bool flag = TeacherCRUD.DeleteTeacher(teacher);
            Assert.AreEqual(true, flag);
        }

            [Test()]
        public void UpdateTeacherTest()
        {
            Teacher teacher = new Teacher();
            teacher.ID = "TEACH-001";
            teacher.Name = "Ms Dubey";
            teacher.Qualification = "PHD";

            bool flag = TeacherCRUD.UpdateTeacher(teacher);
            Assert.AreEqual(true, flag);
        }
    }
}