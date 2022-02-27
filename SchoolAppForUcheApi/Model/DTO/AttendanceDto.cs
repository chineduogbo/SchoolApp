using System;

namespace SchoolAppForUcheApi.Model.DTO
{
    public class AttendanceDto
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public int SubjectAssignmentId { get; set; }
        public int ClasssubgroupId { get; set; }
        public string ClasssubgroupName { get; set; }
        public string ClassName { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public int Studentid { get; set; }
        public string StudentFirstname { get; set; }
        public string StudentLastname { get; set; }
        public string StudentOthername { get; set; }
        public DateTime Date { get; set; }
    };
}
