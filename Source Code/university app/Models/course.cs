using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace university_app.Models
{
    public class course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string courseName { get; set; }
        public string CourseCode { get; set; }
        public bool isAvilable { get; set; }

        public int TeachId { get; set; }
        [ForeignKey("TeachId")]
        public teacher teacher { get; set; }

        public int RoomId { get; set; }
        [ForeignKey("RoomId")]
        public room room { get; set; }
    }
}