namespace MilitaryElite;
public class Mission : IMission
{
    public Mission(string codeName, MissionState state)
    {
        this.CodeName = codeName;
        this.State = state;
    }
    public string CodeName { get; }
    public MissionState State { get; }
    public override string ToString() => $"Code Name: {this.CodeName} State: {this.State}";
}