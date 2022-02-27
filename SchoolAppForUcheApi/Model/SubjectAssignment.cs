namespace SchoolAppForUcheApi.Model
{
    public class SubjectAssignment
{
    public int Id { get; set; }
        public bool Active { get; set; }
        public int ClasssubgroupId { get; set; }
        public virtual Classsubgroup Classsubgroup { get; set; }
        public int SubjectId { get; set; }
        public virtual Subjects Subjects { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    };
  
}
