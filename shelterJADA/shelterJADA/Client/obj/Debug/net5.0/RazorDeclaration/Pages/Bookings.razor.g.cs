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
#line 1 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using shelterJADA.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using shelterJADA.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\Bookings.razor"
using shelterJADA.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bookings")]
    public partial class Bookings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\Bookings.razor"
                                 

            Booking booking = new Booking();


    private List<Booking> BookingListe;

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\Bookings.razor"
                                  

    protected override async Task OnInitializedAsync()
    {
        BookingListe = await Http.GetFromJsonAsync<List<Booking>>("BookingsDB");

    }

   
    //Post-funktion til at slette  en booking
    protected async Task SletBooking(Booking booking)
    {
        await Http.PostAsJsonAsync<Booking>("BookingsDB/slet", booking);

        BookingListe = await Http.GetFromJsonAsync<List<Booking>>("BookingsDB");

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
