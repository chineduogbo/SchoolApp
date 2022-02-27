using System;

namespace SchoolAppForUcheApi.Model
{
    public class Chatresponse
{
    public int Id { get; set; }
        public string ChatMessage { get; set; }
        public int ChatId { get; set; }
        public virtual Chat Chat { get; set; }
        public DateTime Date { get; set; }
    };
}
