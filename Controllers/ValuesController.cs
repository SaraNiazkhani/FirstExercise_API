using Microsoft.AspNetCore.Mvc;
using RestSharp;
namespace FirstExercise_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        

        [HttpGet]
        public IActionResult GetUserInfo (Method Method)
        {
            Console.WriteLine("Please Enter FirstName: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please Enter LastName:");
            string lastName = Console.ReadLine();
            string fullName = ($"FullName:{firstName} + ''+{lastName}" );
            Random random = new Random();
            int age = random.Next(1, 120);
            string[] addresses = { "تهران ،خ بهشتی ،کوچه دهم،", "اصفهان،بلوار معلم", "مشهد،خ مدرس" };
            string address = addresses[random.Next(addresses.Length)];
            var options = new RestClinetOptions("https://reqres.in");
            var request =new RestRequest ("/api",Method.Get);
            request.AddParameter("FullName", firstName + "" + lastName);
            request.AddParameter("Address", address);
            request.AddParameter("Age", age);
            //var response=client.Equals(request);
            RestResponse response = client.Execute(request);
            //var options = new RestClientOptions("https://reqres.in");
            //var client = new RestClient(options);
            //var request = new RestRequest("/api/users?page=2", Method.Get);
            //return Ok(response.Content);



        }

    }
}
