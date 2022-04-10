using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Project : IEntity
    {
        // Project Id - Bos olamaz - AutoInc
        public int Id { get; set; }

        // Hangi kullaniciya ait - Bos olamaz
        public int UserId { get; set; }

        // Proje Adi - Bos olamaz
        public string? ProjectName { get; set; }

        // Proje olusturulma Tarihi
        public string? CreatedDate { get; set; }

        // Projedeki Toplam Todo Sayisi - Bos olamaz - Default = 0
        public int TotalTodosInProject { get; set; }

        // Tamamlanan Toplam Todo Sayisi - Bos olamaz - Default = 0
        public int TotalTodosCompleted { get; set; }
    }
}
