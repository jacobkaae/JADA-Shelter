#pragma checksum "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/ShelterData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe02d4c6fb2eb2963d8296d97754c5c429267632"
// <auto-generated/>
#pragma warning disable 1591
namespace shelterJADA.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/_Imports.razor"
using shelterJADA.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/_Imports.razor"
using shelterJADA.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/ShelterData.razor"
using shelterJADA.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/shelterdata")]
    public partial class ShelterData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>ShelterData</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>");
#nullable restore
#line 9 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/ShelterData.razor"
 if (ShelterListe == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/ShelterData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, @"<thead><tr><th>ID</th>
                <th>Kommunekode</th>
                <th>Kommunenavn</th>
                <th>Shelternavn</th>
                <th>Antal pladser</th>
                <th>K-beskrivelse</th>
                <th>L-beskrivelse</th></tr></thead>
        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 28 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/ShelterData.razor"
             foreach (var shelter in ShelterListe)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "<td>f</td>\n                ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 32 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/ShelterData.razor"
                     shelter.Properties.kommunekode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 33 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/ShelterData.razor"
                     shelter.Properties.cvr_navn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 34 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/ShelterData.razor"
                     shelter.Properties.navn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 35 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/ShelterData.razor"
                     shelter.Properties.antal_pl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 36 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/ShelterData.razor"
                     shelter.Properties.beskrivels

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 37 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/ShelterData.razor"
                     shelter.Properties.lang_beskr

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/ShelterData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/ShelterData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/ShelterData.razor"
       

    private List<Shelter> ShelterListe;

    protected override async Task OnInitializedAsync()
    {
        ShelterListe = await Http.GetFromJsonAsync<List<Shelter>>("Shelter");

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
