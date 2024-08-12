namespace MyFirstAPI.Entities;

public sealed class Laptop : Device
{
    public override string GetBrand()
    {
        return "Apple";
    }

    public override string Hello()
    {
        return "wellison";
    }

    public string GetModel()
    {
        var isConnected = IsConnected();
        if (isConnected)
            return "MacBook";

        return "Unknown";
    }
}
