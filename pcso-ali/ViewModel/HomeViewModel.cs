
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.AspNetCore.SignalR.Client;
using System.Collections.ObjectModel;

namespace pcso_ali.ViewModel;

public partial class HomeViewModel : BaseViewModel
{
    [ObservableProperty]
    public ObservableCollection<string> chatmessages;

    private HubConnection? hubConnection;
    private ObservableCollection<string> messages = new ObservableCollection<string>();
    private string? name;
    private string? message;

    public HomeViewModel()
    {
        OnInitializedAsync();
    }

    protected async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl("https://pcso-ali-backend.azurewebsites.net/chat")

            .Build();

        hubConnection.On<string, string>("Receive", (name, message) =>
        {
            var encodedMsg = $"{name} {message}";
            messages.Add(encodedMsg);
            Chatmessages = messages;
        });

        await hubConnection.StartAsync();
    }

    private async Task Send()
    {
        if (hubConnection is not null)
        {
            await hubConnection.SendAsync("Broadcast", name, message);
            message = null;
        }
    }
}
