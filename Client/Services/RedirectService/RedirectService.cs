using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Services.RedirectService;

public class RedirectService : IRedirectService
{
    private readonly NavigationManager _navigationManager;

    public RedirectService(NavigationManager navigationManager)
    {
        _navigationManager = navigationManager;
    }
    public string GetBaseUri() =>
        _navigationManager.BaseUri;

    public string GetUri() =>
        _navigationManager.Uri;

    public void NavigateTo(string url) =>
        _navigationManager.NavigateTo(url);

    public Uri ToAbsoluteUri(string relativeUri) =>
        _navigationManager.ToAbsoluteUri(relativeUri);

    public string ToBaseRelativePath(string url) =>
        _navigationManager.ToBaseRelativePath(url);
}
