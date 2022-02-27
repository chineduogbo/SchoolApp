namespace SchoolAppForUcheApi.Model
{
    public class Test
{
    public int Id { get; set; }
        public bool Active { get; set; }
        public int SubjectAssignmentId { get; set; }
        public virtual SubjectAssignment SubjectAssignment { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public string Score { get; set; }
    };


}
