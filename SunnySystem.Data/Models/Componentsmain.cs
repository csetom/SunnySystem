using System;
using System.Collections.Generic;
using System.Text;

namespace SunnySystem.Data.Models;

public partial class Componentsmain
{
    public int Componentid { get; set; }

    public string? Name { get; set; }

    public int? Cost { get; set; }

    public int? Max { get; set; }

    public virtual ICollection<Warehouse> Warehouses { get; } = new List<Warehouse>();

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"Component ID: {Componentid}, Name: {Name ?? "N/A"}, Cost: {Cost ?? 0}, Max: {Max ?? 0}\n");

        if (Warehouses.Count > 0)
        {
            sb.Append("Warehouses:\n");

            foreach (var warehouse in Warehouses)
            {
                sb.Append($"\tBin ID: {warehouse.Binid}, Row: {warehouse.Row}, Column: {warehouse.Column}, " +
                        $"Stash: {warehouse.Stash}, Piece: {warehouse.Piece}\n");
            }
        }
        else
        {
            sb.Append("No warehouses associated with this component.\n");
        }

        return sb.ToString();
    }   

}
