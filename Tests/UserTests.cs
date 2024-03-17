using System;
using User;

namespace User.Tests
{
    public class UserTests
    {
        [SetUp]
        public void Setup()
        {
            User = new("Maxim","Khalyapin", 35);
            Console.WriteLine(User.ToString());
        }

        Player User {get; set;}

        [Test]
        public void EmailIsNull()
        {
            Setup();
            Assert.That(User.Email, Is.Null);
        }
        
        [Test]
        public void EmailNotEmpty()
        {
            Setup();
            string email = "nekokat89@gmail.com";
            this.User.Email = email;
            Assert.That(User.Email, Is.Not.Empty);
            Assert.That(User.Email, Is.EqualTo(email));
        }
        
        [Test]
        public void UserToStringFull()
        {
            Setup();
            string email = "nekokat89@gmail.com";
            string phone = "89202395397";
            User.Email = email;
            User.Phone = phone;
            Assert.That(User.ToString(), Is.EqualTo($"FirstName: {User.FirstName}\nLastName: {User.LastName}\nAge: {User.Age}\nEmail: {email}\nPhone: {phone}"));
        }
        
        [Test]
        public void UserToStringDefault()
        {
            Setup();
            Assert.That(User.Email, Is.Null);
            Assert.That(User.Phone, Is.Null);
            Assert.That(User.ToString(), Is.EqualTo($"FirstName: {User.FirstName}\nLastName: {User.LastName}\nAge: {User.Age}\nEmail: Empty\nPhone: Empty"));
        }
    }
}