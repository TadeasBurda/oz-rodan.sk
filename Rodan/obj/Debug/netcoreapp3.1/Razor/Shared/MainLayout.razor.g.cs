#pragma checksum "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6799d8efba3a0e5595c0cf6bdd02036eed2c140c"
// <auto-generated/>
#pragma warning disable 1591
namespace Rodan.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-light navbar-expand-lg sticky-top bg-white shadow");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<a class=\"navbar-brand text-center\" href=\"/\">\r\n            <img class=\"border rounded-circle d-inline-block align-top\" width=\"30\" height=\"30\" alt=\"OZ Rodan - logo\" src=\"/favicon.ico\">\r\n            <strong>OZ Rodan</strong>\r\n        </a>\r\n\r\n        ");
            __builder.AddMarkupContent(7, "<button data-toggle=\"collapse\" data-target=\"#navcol-1\" class=\"navbar-toggler\">\r\n            <span class=\"sr-only\">Toggle navigation</span>\r\n            <span class=\"navbar-toggler-icon\"></span>\r\n        </button>\r\n\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "collapse navbar-collapse");
            __builder.AddAttribute(10, "id", "navcol-1");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "ul");
            __builder.AddAttribute(13, "class", "nav navbar-nav mr-auto pl-3 pl-lg-0");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "li");
            __builder.AddAttribute(16, "role", "presentation");
            __builder.AddAttribute(17, "class", "nav-item");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(19);
            __builder.AddAttribute(20, "class", "nav-link");
            __builder.AddAttribute(21, "href", "/");
            __builder.AddAttribute(22, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 18 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\Shared\MainLayout.razor"
                                                              NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(24, "Domov");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "role", "presentation");
            __builder.AddAttribute(29, "class", "nav-item");
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "activities");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(35, "Aktivity");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "li");
            __builder.AddAttribute(39, "role", "presentation");
            __builder.AddAttribute(40, "class", "nav-item");
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(42);
            __builder.AddAttribute(43, "class", "nav-link");
            __builder.AddAttribute(44, "href", "articles");
            __builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(46, "Články");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "li");
            __builder.AddAttribute(50, "role", "presentation");
            __builder.AddAttribute(51, "class", "nav-item");
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(53);
            __builder.AddAttribute(54, "class", "nav-link");
            __builder.AddAttribute(55, "href", "projects");
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(57, "Projekty");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "li");
            __builder.AddAttribute(61, "role", "presentation");
            __builder.AddAttribute(62, "class", "nav-item");
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(64);
            __builder.AddAttribute(65, "class", "nav-link");
            __builder.AddAttribute(66, "href", "contacts");
            __builder.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(68, "Kontaky");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.OpenElement(71, "li");
            __builder.AddAttribute(72, "role", "presentation");
            __builder.AddAttribute(73, "class", "nav-item");
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(75);
            __builder.AddAttribute(76, "class", "nav-link");
            __builder.AddAttribute(77, "href", "help");
            __builder.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(79, "Pomoc");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n\r\n            ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "text-right");
            __builder.AddMarkupContent(85, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(86);
            __builder.AddAttribute(87, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(88, "\r\n                        ");
                __builder2.OpenElement(89, "a");
                __builder2.AddAttribute(90, "href", "Identity/Account/Manage");
                __builder2.AddContent(91, 
#nullable restore
#line 40 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\Shared\MainLayout.razor"
                                                           context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                    ");
            }
            ));
            __builder.AddAttribute(93, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(94, "\r\n                        ");
                __builder2.AddMarkupContent(95, "<a href=\"Identity/Account/Register\">Registrovať</a>\r\n                        &emsp;\r\n                        ");
                __builder2.AddMarkupContent(96, "<a href=\"Identity/Account/Login\">Prihlásiť sa</a>\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(97, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n\r\n");
            __builder.OpenElement(102, "main");
            __builder.AddAttribute(103, "class", "bg-light");
            __builder.AddMarkupContent(104, "\r\n    ");
            __builder.OpenComponent<Rodan.Shared.ToastNotifications>(105);
            __builder.CloseComponent();
            __builder.AddMarkupContent(106, "\r\n\r\n    ");
            __builder.AddContent(107, 
#nullable restore
#line 57 "C:\Users\tadea\Source\Repos\TadeasBurda\oz-rodan.sk\Rodan\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(108, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n\r\n");
            __builder.AddMarkupContent(110, @"<footer class=""footer-style"">
    <div class=""social"">
        <a href=""https://www.facebook.com/rodanoz"" target=""_blank"">
            <i class=""fab fa-facebook-f""></i>
        </a>
    </div>
    <ul class=""list-inline"">
        <li class=""list-inline-item"">
            <a href=""/"">Domov</a>
        </li>
        <li class=""list-inline-item"">
            <a href=""contacts"">Kontakty</a>
        </li>
        <li class=""list-inline-item"">
            <a href=""Identity/Account/Login"">Prihlásiť sa</a>
        </li>
    </ul>
    <p class=""copyright"">
        oz-rodan.sk 2020 &copy; <a href=""https://tadeasburda.sk"">Tadeáš Burda</a>
    </p>
</footer>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
