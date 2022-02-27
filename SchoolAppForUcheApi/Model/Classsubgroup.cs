namespace SchoolAppForUcheApi.Model
{
    public class Classsubgroup
{
    public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
    };

   
}
