//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineCourse.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course_table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course_table()
        {
            this.Course_Enrolled = new HashSet<Course_Enrolled>();
        }
    
        public int Course_Id { get; set; }
        public string Course_Name { get; set; }
        public string Course_Description { get; set; }
        public Nullable<System.DateTime> Course_StartDate { get; set; }
        public string Course_Author { get; set; }
        public string Course_Duration { get; set; }
        public string Course_Difficulty { get; set; }
        public string credit_score { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_Enrolled> Course_Enrolled { get; set; }
    }
}
