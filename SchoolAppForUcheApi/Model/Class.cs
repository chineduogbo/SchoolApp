using System.ComponentModel.DataAnnotations;

namespace SchoolAppForUcheApi.Model
{
    public class Class
{
       
       public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    };
   
}
