using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Course A = new Course("OOP", "C1122", "CSE");
            Course B= new Course("OOP2", "C1123", "CSE");
            Course C = new Course("DLC", "E0001", "EEE");
            Course D = new Course("ACCOUNTING", "B3301", "Buisness");
            Course E = new Course("Numerical Method", "M2004", "Mathmatics");

            Student x = new Student("Bishowjit", "18-38250-2", "3-02-2000", 3.76f, 98);
            Student y = new Student("John", "18-38255-3", "9-02-1999", 3.70f, 100);
            Student z = new Student("Zannat", "18-38302-2", "23-09-1999", 3.80f, 102);
            Student p = new Student("Karan", "18-3800-1", "12-12-2001", 3.56f, 90);

            x.AddingCourse(A, B, C, D, E);
           
            x.DelCourse(B);
           
          

            //y.AddingCourse(B, D, E);

            // z.AddingCourse(A, C, D);
            //z.DelCourse(C);


            A.EnrollStudent(x, y, z, p);
            B.EnrollStudent(x,y);
            C.EnrollStudent(z, p);
            D.EnrollStudent(x, z, y);
            E.EnrollStudent(y);

            x.Show();
            //y.Show();
            // z.Show();
            //A.StudentInfo();
           // B.StudentInfo();
            C.StudentInfo();
            E.StudentInfo();

        }
    }
}
