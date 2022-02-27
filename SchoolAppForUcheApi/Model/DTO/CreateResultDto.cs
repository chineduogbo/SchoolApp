namespace SchoolAppForUcheApi.Model.DTO
{
    public class CreateResultDto
    {
        public int Id { get; set; }
        public int SubjectAssignmentId { get; set; }
        public int UserId { get; set; }
        public int StudentId { get; set; }
        public string Score { get; set; }
    };
}
