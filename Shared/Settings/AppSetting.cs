namespace BlazorEComm.Shared.Settings;

public class AppSetting
{
    public const string Key = "AppSettings";

    public string AllowedShippingCountry { get; set; } = string.Empty;

    public int DecimalMultiplier { get; set; } 
    
    public string OrderCancelUrl { get; set; } = string.Empty;

    public string OrderSuccesUrl { get; set; } = string.Empty;

    public string PaymentCurrency { get; set; } = string.Empty;

    public string PaymentMethod { get; set; } = string.Empty;

    public string PaymentMode { get; set; } = string.Empty;

    public string StripeKey { get; set; } = string.Empty;

    public string Token { get; set; } = string.Empty;

    public static string TokenKey => $"{Key}:{nameof(Token)}";
}
