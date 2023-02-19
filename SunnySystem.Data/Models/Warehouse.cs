using System.ComponentModel.DataAnnotations;

namespace SunnySystem.Data.Models
{
    public class Warehouse
    {
        [Key]
        public int BinId { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public int Stash { get; set; }

        public int ComponentId { get; set; }

        public int Piece { get; set; }
    }
}
