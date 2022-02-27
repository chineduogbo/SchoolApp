using System;

namespace SchoolAppForUcheApi.Model
{
    public class Attendance
{
    public int Id { get; set; }
        public bool Active { get; set; }
        public int SubjectAssignmentId { get; set; }
        public virtual SubjectAssignment SubjectAssignment { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int Studentid { get; set; }
        public virtual Student Student { get; set; }
        public DateTime  Date { get; set; }
    };
  
}
