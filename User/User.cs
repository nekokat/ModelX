
namespace User{

    public class Player
    {

        public Player(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        protected string FirstName{ get; set;}
        protected string LastName{ get; set;}
        protected int Age { get; set;}

        protected string? Email {get; set;}
        protected string? Phone {get; set;}

        void Add(Enum fieldType, string value)
        {
            var a = fieldType switch {
                ExtraOption.Email => Email = value,
                ExtraOption.Phone => Phone = value,
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
