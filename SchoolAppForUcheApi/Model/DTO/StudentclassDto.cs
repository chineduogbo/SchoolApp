namespace SchoolAppForUcheApi.Model.DTO
{
    public class StudentclassDto
    {
        public int Id { get; set; }
        public bool Active { get; set; }

        public int ActivetermId { get; set; }
        public string ActivetermName { get; set; }

        public int TermId { get; set; }
        public string TermName { get; set; }
        public int SessionId { get; set; }
        public string SessionName { get; set; }

        public int ClasssubgroupId { get; set; }
        public string ClasssubgroupName { get; set; }
        public string ClassName { get; set; }


        public int Studentid { get; set; }
        public string StudentFirstname { get; set; }
        public string StudentLastname { get; set; }
        public string StudentOthername { get; set; }
    };
}
