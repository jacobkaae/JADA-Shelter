// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace shelterJADA.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jacob\Desktop\Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jacob\Desktop\Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jacob\Desktop\Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jacob\Desktop\Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jacob\Desktop\Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jacob\Desktop\Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jacob\Desktop\Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jacob\Desktop\Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jacob\Desktop\Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using shelterJADA.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jacob\Desktop\Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using shelterJADA.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jacob\Desktop\Shelter\shelterJADA\shelterJADA\Client\Pages\ShelterData.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Jacob\Desktop\Shelter\shelterJADA\shelterJADA\Client\Pages\ShelterData.razor"
                                 

    private List<Shelter> ShelterListe;


    

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Jacob\Desktop\Shelter\shelterJADA\shelterJADA\Client\Pages\ShelterData.razor"
                                  

    protected override async Task OnInitializedAsync()
    {
        ShelterListe = await Http.GetFromJsonAsync<List<Shelter>>("ShelterDB/all");

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
