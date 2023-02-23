using System;
using System.Collections.Generic;

namespace SunnySystem.Data.Models;

public partial class Warehouse
{
    public int Binid { get; set; }

    public int? Row { get; set; }

    public int? Column { get; set; }

    public int? Stash { get; set; }

    public int? Componentid { get; set; }

    public int? Piece { get; set; }

    public virtual Componentsmain? Component { get; set; }
}
