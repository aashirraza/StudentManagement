//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    public partial class student_Tbl
    {
        public int id { get; set; }
        [DisplayName("Student Name")]
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [DisplayName("Father Name")]
        [Required(ErrorMessage = "Father Name is required")]
        public string FatherName { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        [DisplayName("Student Image")]
        public string image_path { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
    }
}
