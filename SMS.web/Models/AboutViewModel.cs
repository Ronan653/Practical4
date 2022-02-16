namespace SMS.web.Models
{
    public class AboutViewModel
    {
        public string Title {get; set;}

        public string Message {get; set;}

        public DateTime Formed { get; set; }
   
        public string FormedStr => Formed.ToShortDateString();
   
        public int Days => DateTime.Now.Subtract(Formed).Days;


    }
}