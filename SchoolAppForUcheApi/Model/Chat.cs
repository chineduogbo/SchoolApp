namespace SchoolAppForUcheApi.Model
{
    public class Chat
{
    public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int ResponseId { get; set; }
        public virtual User Response { get; set; }
    };
}
