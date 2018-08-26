//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASPSchoolAppClient.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class Student
    {
        public long StudentID { get; set; }
        public string SchoolToken { get; set; }
        public string GradeToken { get; set; }
        public string ParentToken { get; set; }
        public string ImageToken { get; set; }
        public string StudentName { get; set; }
        [DisplayName("Image")]
        public string ImagePath { get; set; }

        //to work with file
        //this property is not inside our table so NotMapped property is added
        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }

        //for the default image path
        public Student()
        {
            ImagePath = "~/AppFiles/Images/Default/default.png";
        }
    }
}
