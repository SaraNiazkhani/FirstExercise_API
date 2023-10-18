namespace FirstExercise_API.Models
{
    public  class LoginHistory
    {
        public LoginHistory()
        {
            people = new List<Person>();
        }

        public  List<Person> people { get; set; }

    }
}
