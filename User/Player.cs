using System.Diagnostics;

namespace User{
    public class Player
    {

        public Player(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = null;
            Phone = null;
        }

        public string? FirstName{ get; set;}
        public string? LastName{ get; set;}
        public int? Age { get; set;}

        public string? Email {get; set;}
        public string? Phone {get; set;}

        public override string ToString()
        {
            return $"FirstName: {FirstName}\nLastName{LastName}\nAge: {Age}\n" + (Email !?? "Email: {Email}\n") + (Phone !?? "Phone: {Phone}");
        }
    }
}