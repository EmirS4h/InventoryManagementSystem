using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Project : IEntity
    {
        // Project Id
        public int Id { get; set; }
        // Proje Adi
        public string? Name { get; set; }
        // Projedeki Toplam Todo Sayisi
        public int TotalTodosInProject { get; set; }
        // Tamamlanan Toplam Todo Sayisi
        public int TotalTodosCompleted { get; set; }
    }
}
