﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_basics.Models
{
    [Table ("tblEmployees")]
    public class Employee
    {
       public int EmployeeId { get; set;}
       public string Name { get; set; }
       public string Gender { get; set; }
       public string City { get; set; }
    }
}