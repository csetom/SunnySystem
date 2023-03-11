using System;
using System.Collections.Generic;

namespace SunnySystem.Data.Models;

public partial class Bin
{
    public int BinId { get; set; }

    public int? Row { get; set; }

    public int? Column { get; set; }

    public int? Stash { get; set; }

    public int? Componentid { get; set; }

    public int? Piece { get; set; }

    public virtual Component? Component { get; set; }
}
