using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace StudentApp.Models
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string City { get; set; }
        //[DataMember]
        public string Department { get; set; }
        //[DataMember]
        public double Average { get; set; }
    }

}