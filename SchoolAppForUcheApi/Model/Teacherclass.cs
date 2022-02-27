namespace SchoolAppForUcheApi.Model
{
    public class Teacherclass
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public int ClasssubgroupId { get; set; }
        public virtual Classsubgroup Classsubgroup { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int ActivetermId { get; set; }
        public virtual Activeterm Activeterm { get; set; }
    };
}