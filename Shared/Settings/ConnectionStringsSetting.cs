namespace BlazorEComm.Shared.Settings;

public class ConnectionStringsSetting
{
    public const string Key = "ConnectionStrings";

    public string DefaultConnection { get; set; } = string.Empty;

    public static string DefaultConnectionKey => nameof(DefaultConnection);
}