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
    
    public partial class User_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_Table()
        {
            this.Course_Enrolled = new HashSet<Course_Enrolled>();
        }
    
        public int User_Id { get; set; }
        public string UserName { get; set; }
        public string Mobile_Number { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public Nullable<int> Age { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string isAdmin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_Enrolled> Course_Enrolled { get; set; }
    }
}
