#pragma checksum "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b1b2502b9020de84a03004efca388955133b8bd"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\_Imports.razor"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\_Imports.razor"
using WebApplication2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.OpenElement(2, "label");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
                          LoginAs

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "Войти как");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
                      userInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInput = __value, userInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form-group");
            __builder.OpenElement(13, "label");
            __builder.AddMarkupContent(14, "\r\n        Получатель:\r\n        ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "size", "50");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
                      receiverUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => receiverUser = __value, receiverUser));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.OpenElement(22, "label");
            __builder.AddMarkupContent(23, "\r\n        Тема:\r\n        ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "size", "50");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
                      themeInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => themeInput = __value, themeInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "form-group");
            __builder.OpenElement(31, "label");
            __builder.AddMarkupContent(32, "\r\n        Сообщение:\r\n        ");
            __builder.OpenElement(33, "textarea");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
                         messageInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
                  Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "disabled", 
#nullable restore
#line 32 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
                                    !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, "Отправить");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n<hr>");
#nullable restore
#line 35 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
 if (currentUser != string.Empty)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "p");
            __builder.AddMarkupContent(43, "Вы вошли как ");
            __builder.AddContent(44, 
#nullable restore
#line 37 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
                     currentUser

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "<hr>\r\n\r\n");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "d-flex");
            __builder.OpenElement(48, "ul");
            __builder.AddAttribute(49, "id", "dialogsList");
#nullable restore
#line 43 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
         foreach (var d in dialogs)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "li");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
                                    e => ShowDialogWith(d)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "Открыть диалог с пользователем ");
            __builder.AddContent(54, 
#nullable restore
#line 46 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
                                                                                             d

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.OpenElement(56, "ul");
            __builder.AddAttribute(57, "id", "messagesList");
#nullable restore
#line 51 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
         foreach (var msg in currentMessages)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
             if (msg.hidden)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "li");
            __builder.AddAttribute(59, "style", "cursor: pointer");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
                                                        e => ShowMessage(msg.message)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(61, "\r\n                    От: ");
            __builder.AddContent(62, 
#nullable restore
#line 56 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
                         msg.message.SenderName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(63, "\r\n                    <br>\r\n                    Тема: ");
            __builder.AddContent(64, 
#nullable restore
#line 58 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
                           msg.message.Theme

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(65, "\r\n                    <hr>");
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "li");
            __builder.AddMarkupContent(67, "\r\n                    От: ");
            __builder.AddContent(68, 
#nullable restore
#line 65 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
                         msg.message.SenderName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(69, "\r\n                    <br>\r\n                    Дата отправки: ");
            __builder.AddContent(70, 
#nullable restore
#line 67 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
                                    msg.message.Date

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(71, "\r\n                    <br>\r\n                    Тема: ");
            __builder.AddContent(72, 
#nullable restore
#line 69 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
                           msg.message.Theme

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(73, "\r\n                    <br>\r\n                    <br>\r\n                    ");
            __builder.AddContent(74, 
#nullable restore
#line 72 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
                     msg.message.Text

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(75, "\r\n                    <hr>");
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\xiaom\Desktop\Max\Itransition\WebApplication2\Pages\Index.razor"
       
    private HubConnection hubConnection;
    private List<Models.Message> messages = new List<Models.Message>();
    private List<(Models.Message message, bool hidden)> currentMessages = new List<(Models.Message, bool)>();
    private List<string> dialogs = new List<string>();

    private string userInput = string.Empty;
    private string receiverUser = string.Empty;
    private string themeInput = string.Empty;
    private string messageInput = string.Empty;

    private string currentUser = string.Empty;
    private string currentDialog = string.Empty;

    void LoginAs()
    {
        if (userInput == string.Empty)
            return;

        currentUser = userInput;
        currentMessages.Clear();
        GetAllDialogs();

        StateHasChanged();
    }

    void ShowDialogWith(string user)
    {
        if (currentDialog != user)
        {
            currentDialog = user;
            ShowMessagesFromCurrentDialog();
        }
        else
        {
            currentDialog = string.Empty;
            currentMessages.Clear();
        }

        StateHasChanged();
    }

    void ShowMessagesFromCurrentDialog()
    {
        if (currentDialog == string.Empty)
            return;

        currentMessages.Clear();
        foreach (var m in messages)
        {
            if ((m.SenderName == currentDialog && m.ReceiverName == currentUser) ||
                (m.ReceiverName == currentDialog && m.SenderName == currentUser))
            {
                currentMessages.Add((m, true));
            }
        }
    }

    void ShowMessage(Models.Message msg)
    {
        int index = currentMessages.FindIndex(m => m.message == msg);
        currentMessages[index] = (msg, !currentMessages[index].hidden);
        StateHasChanged();
    }

    void GetAllDialogs()
    {
        dialogs.Clear();
        foreach (var m in messages)
        {
            if (m.ReceiverName == m.SenderName)
                continue;

            if (m.ReceiverName == currentUser && !dialogs.Contains(m.SenderName))
                dialogs.Add(m.SenderName);
            else if (m.SenderName == currentUser && !dialogs.Contains(m.ReceiverName))
                dialogs.Add(m.ReceiverName);
        }
    }

    protected override async Task OnInitializedAsync()
    {
        {
            var contextOptions = new DbContextOptionsBuilder<Models.MessageDbContext>()
                .UseSqlServer(Startup.connection)
                .Options;

            using var context = new Models.MessageDbContext(contextOptions);
            try
            {
                foreach (var m in context.Messages)
                    messages.Add(m);
            }
            catch
            {
                base.StateHasChanged();
            }
        }

        hubConnection = new HubConnectionBuilder()
        .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
        .Build();

        hubConnection.On<string, string, string, string, DateTime>("ReceiveMessage",
        async (fromUser, toUser, theme, text, date) =>
        {
            Models.Message msg = new Models.Message
            {
                Text = $"{text}",
                Theme = $"{theme}",
                ReceiverName = $"{toUser}",
                SenderName = $"{fromUser}",
                Date = date
            };
            messages.Add(msg);

            var contextOptions = new DbContextOptionsBuilder<Models.MessageDbContext>()
                .UseSqlServer(Startup.connection)
                .Options;

            using var context = new Models.MessageDbContext(contextOptions);
            try
            {
                context.Messages.Add(msg);
                await context.SaveChangesAsync();
            }
            catch
            {
                base.StateHasChanged();
            }

            StateHasChanged();
        });

        await hubConnection.StartAsync();
    }

    async Task Send()
    {
        if (currentUser != string.Empty && receiverUser != string.Empty)
        {
            await hubConnection.SendAsync("SendMessage", currentUser, receiverUser, themeInput, messageInput, DateTime.Now);
            await Task.Delay(100);
            GetAllDialogs();
            ShowMessagesFromCurrentDialog();
            StateHasChanged();
        }
    }

    public bool IsConnected => hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
