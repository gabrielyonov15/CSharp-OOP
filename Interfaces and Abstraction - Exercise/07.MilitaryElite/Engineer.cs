﻿namespace MilitaryElite;
using System.Collections.Generic;
using System.Text;
public class Engineer : SpecializedSoldier, IEngineer
{
    private readonly List<IRepair> _repairs;
    public Engineer(int id, string firstName, string lastName, decimal salary, SoldierCorps corps) : base(id, firstName, lastName, salary, corps)
    {
        this._repairs = new List<IRepair>();
        this.Repairs = this._repairs.AsReadOnly();
    }
    public IReadOnlyCollection<IRepair> Repairs { get; }
    public bool AddRepair(IRepair repair)
    {
        if (repair is null)
        {
            return false;
        }
        this._repairs.Add(repair);
        return true;
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.Append("Repairs:");
        foreach (var repair in this.Repairs)
        {
            sb.AppendLine();
            sb.Append("  ");
            sb.Append(repair);
        }
        return sb.ToString();
    }
}