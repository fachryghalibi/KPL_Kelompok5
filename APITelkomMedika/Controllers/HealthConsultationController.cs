using APITelkomMedika;
using Microsoft.AspNetCore.Mvc;

namespace APITelkomMedika.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthConsultationController : ControllerBase
    {
        private static List<APITelkomMedikaa> listMahasiswa = new List<APITelkomMedikaa>
    {
        new APITelkomMedikaa(" Fachruddin Ghalibi", "1302223107", "Monday", "09:00"),
        new APITelkomMedikaa(" Muhammad Fadlan Kamal", "1302223095", "Tuesday", "14:00"),
        new APITelkomMedikaa(" Ihsan Maulana", "1302223139", "Tuesday", "10:00"),
    };
        [HttpGet]

        public IEnumerable<APITelkomMedikaa> Get()
        {
            return listMahasiswa;
        }

        [HttpGet("{id}")]
        public APITelkomMedikaa Get(int id)
        {
            return listMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] APITelkomMedikaa mahasiswa)
        {
            listMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMahasiswa.RemoveAt(id);
        }
    }
}
