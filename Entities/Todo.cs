using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Todo : IEntity
    {
        // Todo Id
        public int Id { get; set; }
        // Icerik
        public string? Text { get; set; }
        // Tamamlanma Durumu
        public bool Completed { get; set; }
        // Olusturulma Tarihi
        public DateTime CreatedDate { get; set; }
        // Guncellenme Tarihi
        public DateTime UpdatedDate { get; set; }
        // Tamamlanma Tarihi
        public DateTime CompletedDate { get; set; }
        // Onem Sirasi
        public string? Priority { get; set; }
    }
}
