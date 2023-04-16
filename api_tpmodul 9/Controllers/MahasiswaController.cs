using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_tpmodul_9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaData = new List<Mahasiswa>
        {
            new Mahasiswa("Hermawan Saputra", "1302213080"),
            new Mahasiswa("Triani Putri Mumpuni", "130221"),
            new Mahasiswa("Dhafa Arizki Gusman", "130221"),
            new Mahasiswa("Arzaq Ajradika", "130221"),
            new Mahasiswa("Yesa Kristanto", "130221")
        };
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaData;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaData[id];
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            mahasiswaData.Add(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa value)
        {
            mahasiswaData[id] = value;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswaData.RemoveAt(id);
        }
    }
}
