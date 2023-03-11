using System;
using System.Collections.Generic;
using System.Text;

namespace SunnySystem.Data.Models;

public partial class Component
{
    public int Componentid { get; set; }

    public string? Name { get; set; }

    public int? Cost { get; set; }

    public int? Max { get; set; }

    public virtual ICollection<Bin> Bins { get; } = new List<Bin>();

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"Component ID: {Componentid}, Name: {Name ?? "N/A"}, Cost: {Cost ?? 0}, Max: {Max ?? 0}\n");

        if (Bins.Count > 0)
        {
            sb.Append("Warehouses:\n");

            foreach (var bin in Bins)
            {
                sb.Append($"\tBin ID: {bin.Binid}, Row: {bin.Row}, Column: {bin.Column}, " +
                        $"Stash: {bin.Stash}, Piece: {bin.Piece}\n");
            }
        }
        else
        {
            sb.Append("No warehouses associated with this component.\n");
        }

        return sb.ToString();
    }   

}
