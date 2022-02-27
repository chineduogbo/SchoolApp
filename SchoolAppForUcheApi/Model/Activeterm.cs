namespace SchoolAppForUcheApi.Model
{
    public class Activeterm
{
    public int Id { get; set; }
        public bool Active { get; set; }
        public int TermId { get; set; }
        public virtual Term Term { get; set; }
        public int SessionId { get; set; }
        public virtual Session Session { get; set; }
    };
   
}
