using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BridgeTableInManyToManyRelationship
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentCourseDBContex studentCourseDBContex = new StudentCourseDBContex();
            var query = from course in studentCourseDBContex.Courses
                        from studentName in course.StudentCourses
                        select new
                        {
                            StudentName = studentName.Student.StudentName,
                            CourseName = course.CourseName,
                            EnrollDates = studentName.EnrolledDate

                        };
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }
    }
}