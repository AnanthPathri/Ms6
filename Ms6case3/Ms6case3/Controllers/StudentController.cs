using Microsoft.AspNetCore.Mvc;
using Ms6case3.DataAccess;
using Ms6case3.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Ms6case3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentDbContext context = null;
        //Constructor to inisialize the ItemDbContext
        public StudentController(StudentDbContext context)
        {
            this.context = context;
        }
        //Displaying 
        [HttpGet("Items Display")]
        public List<StudentModel> GetStudent()
        {
            var Medlist = context.studentModels.ToList();
            return Medlist;
        }
        //Inserting 
        [HttpPost("Insert Items")]
        public ActionResult InsertStudent(StudentModel studentModel)
        {
            try
            {
                context.studentModels.Add(studentModel);
                context.SaveChanges();
                return Ok("Student Added");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }
        //Updating 
        [HttpPut("Update Item")]
        public ActionResult UpdateStudent(StudentModel studentModel)
        {
            try
            {
                var shopList = context.studentModels.ToList();
                foreach (var i in shopList)
                {
                    if (i.id == studentModel.id)
                    {
                        i.name = studentModel.name;
                        i.marks = studentModel.marks;
                    }
                }
                context.SaveChanges();
                return Ok("Updated Successfull");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        //Deleting useless Items if Admin
        [HttpDelete("Delete Item")]
        public ActionResult DeleteStudent(int id)
        {
            try
            {
                var shopDetails = context.studentModels.Where(i => i.id == id).First();
                context.studentModels.Remove(shopDetails);
                context.SaveChanges();
                return Ok($"Id : {id} student Removed");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
