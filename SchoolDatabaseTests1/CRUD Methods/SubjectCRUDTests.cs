using NUnit.Framework;
using SchoolDatabase.CRUD_Methods;
using SchoolDatabase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDatabase.CRUD_Methods.Tests
{
    [TestFixture()]
    public class SubjectCRUDTests
    {
        [Test()]
        public void AddNewSubjectTest()
        {
            Subject subject = new Subject();
            subject.ID = "SUB-001";
            subject.Name = "MPMC";
            subject.Stream = "ETC";
            bool flag = SubjectCRUD.AddNewSubject(subject);
            Assert.AreEqual(true, flag);
        }

        [Test()]
        public void DeleteSubjectTest()
        {
            string subject = "SUB-001";
            bool flag = SubjectCRUD.DeleteSubject(subject);
            Assert.AreEqual(true, flag);
        }

            [Test()]
        public void UpdateSubjectTest()
        {
            Subject subject = new Subject();
            subject.ID = "SUB001";
            subject.Name = "OOPS";
            subject.Stream = "CS";
            bool flag = SubjectCRUD.UpdateSubject(subject);
            Assert.AreEqual(true, flag);
        }
    }
}