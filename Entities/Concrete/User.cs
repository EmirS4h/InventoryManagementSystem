using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        // Kullanici Id - Bos olamaz
        public int Id { get; set; }

        // Kullanici Adi - Bos olamaz
        public string? Username { get; set; }

        // Sifre - Bos olamaz
        public string? Password { get; set; }

        // Kullanicinin Toplam Projesi - Bos olamaz - Default = 0
        public int TotalProjects { get; set; }

        // Tamamlanan Toplam Proje - Bos olamaz - Default = 0
        public int TotalProjectsCompleted { get; set; }
    }
}
