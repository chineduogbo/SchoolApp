namespace SchoolAppForUcheApi.Model
{
    public class Studentclass
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public int ClasssubgroupId { get; set; }
        public virtual Classsubgroup Classsubgroup {get;set;}
        public int StudentId { get; set; }
        public virtual Student Student {get;set;}
        public int ActivetermId { get; set; }
        public virtual Activeterm Activeterm { get; set; }
    };
  
}
