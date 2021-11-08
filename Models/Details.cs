using System;
using System.ComponentModel.DataAnnotations;

namespace Perpustakaan.Models
{
    public class Details
    {
        public int Id { get; set; }
        public string Judul { get; set; }

        public string Pengarang { get; set; }
        
        [DataType(DataType.Date)]
        public string TahunTerbit { get; set; }
    }
}