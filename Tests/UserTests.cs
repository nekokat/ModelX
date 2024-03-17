using System;
using User;

namespace User.Tests
{
    public class UserTests
    {
        [SetUp]
        public void Setup()
        {
            Player User = new("Maxim","Khalyapin", 35);
            Console.WriteLine(User.ToString());
        }

        Player User {get; set;}

        [Test]
        public void EmailIsNull()
        {
            Setup();
            Assert.That(this.User.Email, Is.Null);
        }
        
        [Test]
        public void EmailNotEmpty()
        {
            Setup();
            string email = "nekokat89@gmail.com";
            this.User.Email = email;
            Assert.That(this.User.Email, Is.EqualTo(email));
        }
        
        [Test]
        public void UserToString()
        {
            Setup();
            string email = "nekokat89@gmail.com";
            string phone = "89202395397";
            Assert.That(User.ToString(), Is.EqualTo($"FirstName: Maxim\nLastName: Khalyapin\nAge: 35\nEmail: {email}\nPhone: {phone}"));
        }
    }
}