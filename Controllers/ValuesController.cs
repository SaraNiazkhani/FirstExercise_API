using FirstExercise_API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;


namespace FirstExercise_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private LoginHistory _history;
        public ValuesController(LoginHistory history)
        {
            _history= history;
        }

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
            _history.people.Add(person);
            return Ok(person);

        }

        [HttpGet]
        public IActionResult GetHistor()
        {
            var itemres = new List<LogItem>();
            foreach (Person person in _history.people)
            {
                var item = new LogItem();
                item.DateTime = DateTime.Now;
                item.Person = person;
                itemres.Add(item);
            }
            return Ok(itemres);
        }


    }
}


