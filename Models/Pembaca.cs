using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Perpustakaan.Models;
using Microsoft.AspNetCore.Identity;

namespace Perpustakaan.Models
{
    public class Pembaca:IdentityUser
    {
         public string Name { get; set; }
         
    }
    
}
