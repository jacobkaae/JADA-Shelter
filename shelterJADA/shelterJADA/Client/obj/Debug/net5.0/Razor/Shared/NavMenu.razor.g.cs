#pragma checksum "C:\Users\lynge\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4caf4af769994b17221caf95c7f854967c18971d"
// <auto-generated/>
#pragma warning disable 1591
namespace shelterJADA.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lynge\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lynge\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lynge\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lynge\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lynge\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lynge\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lynge\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lynge\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lynge\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using shelterJADA.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lynge\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using shelterJADA.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-460nw7u3i7");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-460nw7u3i7>shelterJADA</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\lynge\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-460nw7u3i7");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-460nw7u3i7></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\lynge\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\lynge\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-460nw7u3i7");
            __builder.OpenElement(14, "nav");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-460nw7u3i7");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-460nw7u3i7");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "<span class=\"oi oi-book\" aria-hidden=\"true\" b-460nw7u3i7></span> Book Shelter\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "nav-item px-3");
            __builder.AddAttribute(28, "b-460nw7u3i7");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "class", "nav-link");
            __builder.AddAttribute(31, "href", "bookings");
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(33, "<span class=\"oi oi-terminal\" aria-hidden=\"true\" b-460nw7u3i7></span> Bookings\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "nav-item px-3");
            __builder.AddAttribute(37, "b-460nw7u3i7");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(38);
            __builder.AddAttribute(39, "class", "nav-link");
            __builder.AddAttribute(40, "href", "shelterdata");
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(42, "<span class=\"oi oi-cloud\" aria-hidden=\"true\" b-460nw7u3i7></span> Shelter Database\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\lynge\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
