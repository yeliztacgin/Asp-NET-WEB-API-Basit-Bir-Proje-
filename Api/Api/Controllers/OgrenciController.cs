using Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OgrenciController : Controller
    {

        static List<Ogrenci> ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 1, AdSoyad = "Ali Sancak" },
            new Ogrenci { Id = 2, AdSoyad = "Aylin Vekil" },
            new Ogrenci { Id = 3, AdSoyad = "Veli Can" },
            new Ogrenci { Id = 4, AdSoyad = "Kenan Veli" },
            new Ogrenci { Id = 5, AdSoyad = "Murat Ak" },
            new Ogrenci { Id = 6, AdSoyad = "Hasan Bulut" }


        };


        [HttpGet]
        public List<Ogrenci> Get()
        {
            {
                return ogrenciler;


            }
        }

            [HttpGet("{id}")]
            
           public Ogrenci Get(int id)
        {
            return ogrenciler.FirstOrDefault(o => o.Id == id);

        }

        [HttpPost]
        public Ogrenci Post(Ogrenci ogrenci)
        {
            ogrenciler.Add(ogrenci);
            return ogrenci;
        }
        }
    }
