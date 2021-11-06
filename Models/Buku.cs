using System;
using System.ComponentModel.DataAnnotations;

namespace Perpustakaan.Models
{
    public class Buku
    {
        public int Id { get; set; }
        public string Judul { get; set; }
        public string Deskripsi { get; set; }
        
    }
}