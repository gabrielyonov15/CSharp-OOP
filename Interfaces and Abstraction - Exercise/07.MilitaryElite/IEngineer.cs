namespace MilitaryElite;
using System.Collections.Generic;
public interface IEngineer : ISpecializedSoldier
{
    IReadOnlyCollection<IRepair> Repairs { get; }
}