using Microsoft.AspNetCore.Mvc;
using RestSharp;
namespace FirstExercise_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetUserInfo()
        {
            Console.WriteLine("Please Enter FirstName: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please Enter LastName:");
            string lastName = Console.ReadLine();
            string fullName = ($"FullName:{firstName} + ''+{lastName}");
            Random random = new Random();
            int age = random.Next(1, 120);
            string[] addresses = { "تهران ،خ بهشتی ،کوچه دهم،", "اصفهان،بلوار معلم", "مشهد،خ مدرس" };
            string address = addresses[random.Next(addresses.Length)];
            var options = new RestClientOptions("https://eample.com/api");
            var client = new RestClient(options);
            var request = new RestRequest("", Method.Get);
            RestResponse response = client.Execute(request);
            return Ok(response);

        }
    }
}
