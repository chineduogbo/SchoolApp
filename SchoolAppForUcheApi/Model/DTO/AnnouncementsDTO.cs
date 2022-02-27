using System;

namespace SchoolAppForUcheApi.Model.DTO
{
    public class AnnouncementsDTO
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Imagelink { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Othername { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }
        public string RoleName { get; set; }
        public int RoleId { get; set; }
    };
}
