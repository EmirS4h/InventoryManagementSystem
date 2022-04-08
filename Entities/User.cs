using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User : IEntity
    {
        // Kullanici Id
        public int Id { get; set; }
        // Kullanici Adi
        public string? Username { get; set; }
        // Sifre
        public string? Password { get; set; }
        // Kullanicinin Toplam Projesi
        public int TotalProjects { get; set; }
        // Tamamlanan Toplam Proje
        public int TotalProjectsCompleted { get; set; }
    }
}
