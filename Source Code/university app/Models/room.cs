using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace university_app.Models
{
    public class room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Roomname { get; set; }
        public int size { get; set; }
        public bool isavilable { get; set; }
        public string location { get; set; }
    }
}