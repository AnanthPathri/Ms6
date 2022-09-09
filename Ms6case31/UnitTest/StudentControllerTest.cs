using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ms6case3.Controllers;
using Ms6case3.Core.Interface;
using Ms6case3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class StudentControllerTest
    {
        private Mock<IStudent> studentmock;
        private Fixture fixture;
        private StudentController controller;

        public StudentControllerTest()
        {
            fixture = new Fixture();
            studentmock = new Mock<IStudent>();
        }
        [TestMethod]
        public async Task GetStudents()
        {
            var studentList = fixture.CreateMany<StudentModel>().ToList();
            studentmock.Setup(repo => repo.GetStudent()).ReturnsAsync(studentList);
            controller = new StudentController(studentmock.Object);
            var result = controller.GetStudent();
            var obj = result as ObjectResult;
            Assert.AreEqual(200, obj.StatusCode);
        }
        public async Task GetStudentsThrowException()
        {
            studentmock.Setup(repo=>repo.GetStudent()).Throws(new Exception())
        }
    }
}
