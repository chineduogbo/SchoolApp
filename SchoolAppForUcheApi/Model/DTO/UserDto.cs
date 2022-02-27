using System;

namespace SchoolAppForUcheApi.Model
{

    public class UserDto
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Othername { get; set; }
    public string Phonenumber { get; set; }
    public string Address { get; set; }
    public int RoleId { get; set; }
    public string RoleName { get; set; }
};
    public class LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
