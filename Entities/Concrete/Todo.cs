using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Todo : IEntity
    {
        // Todo Id - Bos olamaz
        public int Id { get; set; }

        // Hangi Projeye Ait - Bos olamaz
        public int ProjectId { get; set; }

        // Icerik - Bos olamaz
        public string? TodoText { get; set; }

        // Tamamlanma Durumu - Bos olamaz - Default = 0 (0 = false, 1 = true)
        public int Completed { get; set; }

        // Olusturulma Tarihi - Bos olamaz - Default = Olusturulma Tarihi
        public string? CreatedDate { get; set; }

        // Guncellenme Tarihi - Bos olabilir
        public string? UpdatedDate { get; set; }

        // Tamamlanma Tarihi - Bos olabilir
        public string? CompletedDate { get; set; }

        // Onem Sirasi - Bos Olamaz
        public string? Priority { get; set; }
    }
}
