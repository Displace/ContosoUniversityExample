using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //Navigation Properties
        //Navigation properties are typically defined as virtual so that 
        //they can take advantage of certain Entity Framework functionality such as lazy loading. 

        //If a navigation property can hold multiple entities (as in many-to-many or one-to-many relationships), 
        //its type must be a list in which entries can be added, deleted, and updated, such as ICollection.
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        
    }
}