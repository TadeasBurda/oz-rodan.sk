#pragma checksum "C:\Users\tadea\source\Repos\TadeasBurda\oz-rodan.sk\Rodan\Shared\Subscribe.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d5ad994f0dd7129329bada07697d1710bcdb31c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Rodan.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tadea\source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tadea\source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tadea\source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tadea\source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tadea\source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tadea\source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tadea\source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tadea\source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Rodan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tadea\source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Rodan.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tadea\source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Rodan.Data.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\tadea\source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Rodan.Business.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\tadea\source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Rodan.Business.Classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\tadea\source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\tadea\source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\tadea\source\Repos\TadeasBurda\oz-rodan.sk\Rodan\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    public partial class Subscribe : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\tadea\source\Repos\TadeasBurda\oz-rodan.sk\Rodan\Shared\Subscribe.razor"
       
    private EmailViewModel model = new EmailViewModel();
    private bool isValid = false;

    private void ValidSubmint()
    {
        int id = subsService.SaveSubscribeEmail(model.EmailAdrress);

        Console.WriteLine($"Subscriber id: {id}");

        subsService.SendConfimedEmail(id);

        model = new EmailViewModel();
        isValid = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISubscribeService subsService { get; set; }
    }
}
#pragma warning restore 1591
