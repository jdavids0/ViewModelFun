#pragma warning disable CS8618
namespace ViewModelFun.Models;
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;
        }
 }