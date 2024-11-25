using static BlazorAppPlayGround1.Components.Pages.Home;

namespace BlazorAppPlayGround1

{
    public class PersonService

    {
        public Person person { get; set; } = new Person();
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
