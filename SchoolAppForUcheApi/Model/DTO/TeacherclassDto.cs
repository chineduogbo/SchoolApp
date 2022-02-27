public class TeacherclassDto
{
    public int Id { get; set; }
    public bool Active { get; set; }

    public int UserId { get; set; }
    public string Username { get; set; }

    public int ActivetermId { get; set; }
    public string ActivetermName { get; set; }

    public int TermId { get; set; }
    public string TermName { get; set; }
    public int SessionId { get; set; }
    public string SessionName { get; set; }

    public int ClasssubgroupId { get; set; }
    public string ClasssubgroupName { get; set; }
    public string ClassName { get; set; }

};
