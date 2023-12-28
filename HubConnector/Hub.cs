using Microsoft.AspNetCore.Components;

namespace HubConnector;
public class Hub
{

    const string PBaseSystem = "blazor.jsmotta.com";    

    public void GoApp(string appBase, NavigationManager navigationManager)
    {
        if (appBase != "0" &&
            appBase != "1" &&
            appBase != "2")
        {
            throw new Exception("Id not exists!");
        }        

        var options = new NavigationOptions()
        {
            ForceLoad = false,
            HistoryEntryState = navigationManager.Uri,
            ReplaceHistoryEntry = true
        };        

        string appUrl;
        if (appBase.Equals("0"))
        {
            appUrl = $"https://{PBaseSystem}";
            navigationManager.NavigateTo(appUrl, options);
            return;
        }

        appUrl = $"https://app{appBase}.{PBaseSystem}";

        navigationManager.NavigateTo($"{appUrl}/?token={EncryptedToken()}", options);
    }

    public string Url(int appBase)
    {
        return appBase.ToString().Equals("0") ? $"https://{PBaseSystem}" : $"https://app{appBase}.{PBaseSystem}";
    }

    public string EncryptedToken()
    {
        // Create Fake Token
        return "afkLkasjOwelKAo41Asdiqwkl231sdJL23u";
    }
}
