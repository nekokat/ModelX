using Newtonsoft.Json;
using System;

namespace ModelX.User
{    
    [JsonObject(MemberSerialization.OptIn)]
    public class Profile
    {
        public Profile(string firstName, string lastName, int age, string? email, string? phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
            Phone = phone;
        }
        
        public Profile(string firstName, string lastName, int age) : this(firstName, lastName, age, null, null){}

        [JsonProperty]
        public string? FirstName{ get; set;}
        [JsonProperty]
        public string? LastName{ get; set;}
        [JsonProperty]
        public int? Age { get; set;}
        [JsonProperty]
        public string? Email {get; set;}
        [JsonProperty]
        public string? Phone {get; set;}

        public override string ToString()
        {
            return $"FirstName: {FirstName}\nLastName: {LastName}\nAge: {Age}\nEmail: {Email !?? "Empty"}\nPhone: {Phone !?? "Empty"}";
        }
    }
}