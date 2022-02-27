using Microsoft.AspNetCore.Http;
using System;

namespace SchoolAppForUcheApi.Model
{
    public class Announcements
{
    public int Id { get; set; }
     public bool Active { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
};

  
}
