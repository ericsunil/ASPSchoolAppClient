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

    public partial class Image
    {
        public long ImageID { get; set; }
        public string ImageToken { get; set; }
        public string Location { get; set; }
        [DisplayName("Image")]
        public string ImagePath { get; set; }

        //to work with file
        //this property is not inside our table so NotMapped property is added
        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }

        //for the default image path
        public Image()
        {
            ImagePath = "~/AppFiles/Images/Default/default_slider.jpg";
        }
    }
}
