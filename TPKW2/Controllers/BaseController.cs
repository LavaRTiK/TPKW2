using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TPKW2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        public static List<Student> ClassRoom = new List<Student> { 
        
            new Student("test1","asdasd"),
            new Student("test2","asdasd")
        };
        // GET: <BaseController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            //return new string[] { "value1", "value2" };
            return ClassRoom;
        }

        // GET <BaseController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return ClassRoom.FirstOrDefault(x => x.GetId() == id);
        }

        // POST <BaseController>
        [HttpPost]
        public void Post([FromBody] Student student)
        {
            ClassRoom.Add(student);
        }

        // PUT <BaseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value1,string value2)
        {
            //хз что делать
            ClassRoom.Find(x => x.Id == id).FirstName = value1;
            ClassRoom.Find(x => x.Id == id).LastName = value2;
        }


        // DELETE api/<BaseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ClassRoom.RemoveAll(x => x.Id == id);
        }
    }
}
