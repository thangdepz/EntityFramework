//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _21115053120145_HuynhKimThang_EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public Nullable<int> StudentAge { get; set; }
        public string StudentGender { get; set; }
        public Nullable<int> FacultyId { get; set; }
    
        public virtual Faculty Faculty { get; set; }
    }
}
