using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace LMS_Learn_Project.Models
{
    public class Student
    {
        private static SqlConnection con;
        SqlDataAdapter apt = new SqlDataAdapter("select * from Studentregistertbl", con);

        [ Key]
        public Guid STUDENT_ID { get; set; }
        [Required]
        public String STUDENT_name { get; set; }
        [Required] 
        public String STUDENT_email { get; set; }
        public String STUDENT_phone { get; set; }
        public String STUDENT_age { get; set; }
        public String STUDENT_branch { get; set; }
    }
}
