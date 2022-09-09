using Microsoft.AspNetCore.Mvc;
using Ms6case3.Controllers;
using Ms6case3.Core.Interface;
using Ms6case3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ms6case3.Core.ImplementInterface
{
    public class Student : IStudent
    {
        StudentController studentController;
        public async Task<ActionResult<StudentModel>> DeleteStudent(int id)
        {
            return studentController.DeleteStudent(id);
        }

        public async Task<List<StudentModel>> GetStudent()
        {
            return studentController.GetStudent();
        }

        public async Task<ActionResult<StudentModel>> InsertStudent(StudentModel studentModel)
        {
            return studentController.InsertStudent(studentModel);
        }

        public async Task<ActionResult<StudentModel>> UpdateStudent(StudentModel studentModel)
        {
            return studentController.UpdateStudent(studentModel);
        }
    }
}
