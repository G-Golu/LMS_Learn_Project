namespace LMS_Learn_Project.Models
{
    public class Course
    {
        public string Title { get; set; }
        public string Creator { get; set; }
        public int Lectures { get; set; }
        public string Level { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
