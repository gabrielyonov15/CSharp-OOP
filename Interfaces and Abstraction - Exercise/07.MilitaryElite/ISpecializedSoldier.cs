namespace MilitaryElite;
public interface ISpecializedSoldier : IPrivateSoldier
{
    SoldierCorps Corps { get; }
}