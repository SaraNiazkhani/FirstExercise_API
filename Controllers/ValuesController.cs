using FirstExercise_API.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
namespace FirstExercise_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    { 

            [HttpGet]
            public IActionResult GetUserInfo(string firstName, string lastName)
            {
                Random random = new Random();
                int age = random.Next(1, 120);
                string[] addresses = { "تهران ،خ بهشتی ،کوچه دهم،", "اصفهان،بلوار معلم", "مشهد،خ مدرس" };
                string address = addresses[random.Next(addresses.Length)];
                Person person = new Person();
                person.FullName = ($"{firstName} {lastName}");
                person.Address = address;
                person.Age = age;
                return Ok(person);

            }
        [HttpGet]
        public IActionResult GetHistory()
        {
            return Ok();
        }

        }
    }

