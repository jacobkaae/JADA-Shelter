#pragma checksum "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/OpretBooking.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "513acad86a2f25cb0fb0b56344fff753e01e4c15"
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
#line 2 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/OpretBooking.razor"
using shelterJADA.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/opretbooking")]
    public partial class OpretBooking : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Opret en booking!</h1>\n\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "placeholder", "Fornavn");
            __builder.AddAttribute(3, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/OpretBooking.razor"
                                    fornavn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fornavn = __value, fornavn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "placeholder", "Efternavn");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/OpretBooking.razor"
                                      efternavn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => efternavn = __value, efternavn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "placeholder", "Email");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/OpretBooking.razor"
                                  email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "placeholder", "Telefon");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/OpretBooking.razor"
                                    telefon

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => telefon = __value, telefon));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n\n");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "date");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/OpretBooking.razor"
                          start_dato

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => start_dato = __value, start_dato, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "date");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/OpretBooking.razor"
                          slut_dato

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => slut_dato = __value, slut_dato, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
#nullable restore
#line 15 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/OpretBooking.razor"
 if (AntalKommuner != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "select");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "selected");
            __builder.AddMarkupContent(33, "Vælg Kommune");
            __builder.CloseElement();
#nullable restore
#line 19 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/OpretBooking.razor"
     foreach (var item in AntalKommuner)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "option");
            __builder.AddContent(35, 
#nullable restore
#line 21 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/OpretBooking.razor"
                 item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 22 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/OpretBooking.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 24 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/OpretBooking.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "button");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/OpretBooking.razor"
                               SendData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "value", "Tilføj Indkøb");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/OpretBooking.razor"
       
    private string fornavn, efternavn, email, telefon;
    private DateTime start_dato = DateTime.Now;
    private DateTime slut_dato = DateTime.Now.AddDays(1);

    public List<Shelter> ShelterListe;
    public List<string> AntalKommuner = new List<string>();


    protected override async Task OnInitializedAsync()
    {
        AntalKommuner = await Http.GetFromJsonAsync<List<string>>("ShelterDB/kommune");

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "/Users/jacobkaae/Desktop/JADA-Shelter/shelterJADA/shelterJADA/Client/Pages/OpretBooking.razor"
                                                                                                

    }

    protected async Task SendData()
    {
        Booking nyBooking = new Booking();
        Bruger nyBruger = new Bruger();
        Udlejet_Shelter nyUdlejet_Shelter = new Udlejet_Shelter();

        nyBruger.fornavn = fornavn;
        nyBruger.efternavn = efternavn;
        nyBruger.email = email;
        nyBruger.telefon = telefon;

        nyBooking.slut_dato = slut_dato.AddDays(1);
        nyBooking.start_dato = start_dato.AddDays(1);

        nyUdlejet_Shelter.shelter_id = "hehfewhfewf";
        nyUdlejet_Shelter.shelter_navn = "Abis Hytte med mælk";

        nyBooking.bruger = nyBruger;
        nyBooking.udlejet_shelter = nyUdlejet_Shelter;



        await Http.PostAsJsonAsync<Booking>("BookingsDB", nyBooking);
    }








#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
