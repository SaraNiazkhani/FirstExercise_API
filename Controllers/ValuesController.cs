using FirstExercise_API.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
namespace FirstExercise_API.Controllers
{
    [Route("api/[controller]")]
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
                var options = new RestClientOptions("https://reqres.in");
                List<Person> persons = new List<Person>();
                Person person = new Person();
                person.FullName = ($"{firstName} {lastName}");
                person.Address = address;
                person.Age = age;
                persons.Add(person);


                return Ok(persons);

            }

        }
    }

