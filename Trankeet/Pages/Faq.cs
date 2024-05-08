namespace TrankeetWeb.Pages
{
    public class Faq(string question, string answer, bool isActive = false)
    {
        public string Question { get; set; } = question;
        public string Answer { get; set; } = answer;

        public bool IsActive { get; set; } = isActive;
    }
}
