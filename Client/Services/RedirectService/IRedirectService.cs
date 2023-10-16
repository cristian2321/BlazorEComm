namespace BlazorEComm.Client.Services.RedirectService;

public interface IRedirectService
{
    string GetBaseUri();

    string GetUri();

    void NavigateTo(string url);

    Uri ToAbsoluteUri(string relativeUri);

    string ToBaseRelativePath(string url);
}