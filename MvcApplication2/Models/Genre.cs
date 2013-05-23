using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data.Entity;
using MvcApplication2.Models;
using MvcApplication2.Controllers;

namespace MvcApplication2.Models
{
    public class Genre
    {
        [Key]
        public string ID_G {get; set;}
       
    }
}