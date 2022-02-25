using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstApi.Models;

namespace FirstApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("AllStudents")]
        public ActionResult<List<BhramarSbaccount>> getAllStudents(){
            using (var db = new DatabaseTrainingContext()){
                var stud = db.BhramarSbaccounts.ToList();
                return Ok(stud);
            }
        }

        [HttpGet]   
        [Route("StudentById/{id}")]
        public async Task<ActionResult<BhramarSbaccount>> getStudentById(int id){
            using (var data = new DatabaseTrainingContext()){
                BhramarSbaccount sb = data.BhramarSbaccounts.Find(id);
                return Ok(sb);
            }
        }

        [HttpPost]
        [Route("AddStudent")]
        // public async Task<ActionResult> AddStudent(BhramarSbaccount sb){
        public async Task<ActionResult<BhramarSbaccount>> AddStudent(BhramarSbaccount sb){
            using (var db = new DatabaseTrainingContext()){
                db.BhramarSbaccounts.Add(sb);
                // await db.SaveChanges.Async();
                db.SaveChanges();
                return Ok(sb);
            }
        } 

        [HttpPut]
        // public async Task<ActionResult> ModifyAccount(int id, BhramarSbaccount e){
        [Route("UpdateAccount")]
        // public async Task<ActionResult> ModifyAccount(int id){
        public async Task<ActionResult> ModifyAccount(int id, BhramarSbaccount e){
            using(var db = new DatabaseTrainingContext()){
                db.BhramarSbaccounts.Update(e);
                await db.SaveChangesAsync();
                return Ok(e);
            }
        }

        [HttpDelete]
        [Route("DeleteAccount")]
        // public async Task<ActionResult> DeleteAccount(int id, BhramarSbaccount e){
        public async Task<ActionResult> DeleteAccount(int id, BhramarSbaccount e){
            using(var db = new DatabaseTrainingContext()){
                db.BhramarSbaccounts.Remove(e);
                await db.SaveChangesAsync();
                return Ok(e);
            }
        }
    }
}