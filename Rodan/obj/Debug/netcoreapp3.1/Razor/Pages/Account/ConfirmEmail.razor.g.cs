#pragma checksum "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\Pages\Account\ConfirmEmail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5443a4b558157718c472fd8bd33c1ed98b3510cf"
// <auto-generated/>
#pragma warning disable 1591
namespace Rodan.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Rodan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Rodan.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Rodan.Data.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Rodan.Business.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Rodan.Business.Classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/confirm-email/{UserId}/{Token}")]
    public partial class ConfirmEmail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\Pages\Account\ConfirmEmail.razor"
 
    [Parameter]
    public string UserId { get; set; }
    [Parameter]
    public string Token { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            if (UserId == null || Token == null)
            {
                notifications.Add("Odkaz je neplatný", EType.danger);
                navigation.NavigateTo("/");
            }

            var user = await userManager.FindByIdAsync(UserId);
            if (user == null)
            {
                notifications.Add($"Používateľa s ID sa nepodarilo načítať '{UserId}'", EType.danger);
                navigation.NavigateTo("/");
            }

            Token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(Token));
            var result = await userManager.ConfirmEmailAsync(user, Token);

            if (result.Succeeded)
                notifications.Add("Ďakujeme za potvrdenie vášho e-mailu", EType.primary);
            else
                notifications.Add("Chyba pri potvrdzovaní vášho e-mailu", EType.danger);

            navigation.NavigateTo("/");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationsService notifications { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> userManager { get; set; }
    }
}
#pragma warning restore 1591
