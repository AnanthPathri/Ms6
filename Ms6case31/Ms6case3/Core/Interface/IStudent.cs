using Microsoft.AspNetCore.Mvc;
using Ms6case3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ms6case3.Core.Interface
{
    public interface IStudent
    {
        Task<List<StudentModel>> GetStudent();
        Task<ActionResult<StudentModel>> InsertStudent(StudentModel studentModel);
        Task<ActionResult<StudentModel>> UpdateStudent(StudentModel studentModel);
        Task<ActionResult<StudentModel>> DeleteStudent(int id);
    }
}
