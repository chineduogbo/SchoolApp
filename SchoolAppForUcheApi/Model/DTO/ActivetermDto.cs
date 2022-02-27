namespace SchoolAppForUcheApi.Model.DTO
{
    public class ActivetermDto
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public int TermId { get; set; }
        public string TermName { get; set; }
        public int SessionId { get; set; }
        public string SessionTermName { get; set; }
    };
}
