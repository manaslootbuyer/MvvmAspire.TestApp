using System;

namespace TestApp.Models
{
    public class UserModel
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleIntial { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }
        public int Age { get; set; }
    }
}