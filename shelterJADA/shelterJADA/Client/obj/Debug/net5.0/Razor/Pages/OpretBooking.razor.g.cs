#pragma checksum "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0f15eaf1154bb3c1545705dcc513c918d99828c"
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
#line 2 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
using shelterJADA.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class OpretBooking : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Opret en booking!</h1>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "shelterTabel col-md-7");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-striped table-sm");
            __builder.AddMarkupContent(7, "<thead><tr class=\"table-dark\"><th>Shelter</th>\r\n                    <th>Antal Pladser</th>\r\n                    <th>Beskrivelse</th></tr></thead>\r\n            ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 24 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                 if (KommuneSheltere != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                     foreach (var item in KommuneSheltere)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form-check");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "class", "form-check-input");
            __builder.AddAttribute(15, "type", "radio");
            __builder.AddAttribute(16, "id", "shelterKnap");
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                                                                                                         vælgShelter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "value", 
#nullable restore
#line 31 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                                                                                                                             item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "name", "radAnswer");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                                    ");
            __builder.OpenElement(21, "label");
            __builder.AddAttribute(22, "class", "form-check-label");
            __builder.AddAttribute(23, "for", "shelterknap");
#nullable restore
#line 33 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
__builder.AddContent(24, item.Properties.Navn);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "td");
#nullable restore
#line 37 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
__builder.AddContent(27, item.Properties.Antal_pl);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "td");
#nullable restore
#line 38 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
__builder.AddContent(30, item.Properties.Beskrivels);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "brugerInput col-md-5");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "form-floating mb-3");
            __builder.OpenElement(36, "select");
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                        vælgKommune

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "class", "form-select");
            __builder.AddAttribute(39, "id", "floatingSelect");
            __builder.OpenElement(40, "option");
            __builder.AddAttribute(41, "selected");
            __builder.AddContent(42, "Liste over kommuner");
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
     foreach (var item in AntalKommuner)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "option");
            __builder.AddAttribute(44, "value", 
#nullable restore
#line 52 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                       item

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 52 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
__builder.AddContent(45, item);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.AddMarkupContent(47, "<label for=\"floatingSelect\">Shelters i</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "div");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-floating mb-3");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "text");
            __builder.AddAttribute(54, "class", "form-control");
            __builder.AddAttribute(55, "id", "floatingFornavn");
            __builder.AddAttribute(56, "aria-label", "First name");
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                                                                                    fornavn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fornavn = __value, fornavn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.AddMarkupContent(60, "<label for=\"floatingFornavn\">Fornavn</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "form-floating mb-3");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "type", "text");
            __builder.AddAttribute(66, "class", "form-control");
            __builder.AddAttribute(67, "id", "floatingEfternavn");
            __builder.AddAttribute(68, "aria-label", "Last name");
            __builder.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                                                                                      efternavn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => efternavn = __value, efternavn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.AddMarkupContent(72, "<label for=\"floatingEfternavn\">Efternavn</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\r\n\r\n        ");
            __builder.OpenElement(74, "div");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "form-floating mb-3");
            __builder.OpenElement(77, "input");
            __builder.AddAttribute(78, "type", "email");
            __builder.AddAttribute(79, "class", "form-control");
            __builder.AddAttribute(80, "id", "floatingInput");
            __builder.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                                                                                 email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n              ");
            __builder.AddMarkupContent(84, "<label for=\"floatingInput\">Email</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n\r\n        ");
            __builder.OpenElement(86, "div");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "form-floating mb-3");
            __builder.OpenElement(89, "input");
            __builder.AddAttribute(90, "type", "tel");
            __builder.AddAttribute(91, "class", "form-control");
            __builder.AddAttribute(92, "id", "floatingTelefon");
            __builder.AddAttribute(93, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 78 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                                                                                 telefon

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => telefon = __value, telefon));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n              ");
            __builder.AddMarkupContent(96, "<label for=\"floatingTelefon\">Telefon</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n\r\n        ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "row g-2");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "col-md");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "form-floating mb-3");
            __builder.OpenElement(104, "input");
            __builder.AddAttribute(105, "type", "date");
            __builder.AddAttribute(106, "class", "form-control");
            __builder.AddAttribute(107, "id", "floatingStart");
            __builder.AddAttribute(108, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 86 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                                                                                    start_dato

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(109, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => start_dato = __value, start_dato, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                  ");
            __builder.AddMarkupContent(111, "<label for=\"floatingStart\">Start dato</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n            ");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "col-md");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "form-floating mb-3");
            __builder.OpenElement(117, "input");
            __builder.AddAttribute(118, "type", "date");
            __builder.AddAttribute(119, "class", "form-control");
            __builder.AddAttribute(120, "id", "floatingSlut");
            __builder.AddAttribute(121, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 92 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                                                                                   slut_dato

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(122, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => slut_dato = __value, slut_dato, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                  ");
            __builder.AddMarkupContent(124, "<label for=\"floatingSlut\">Slut dato</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n\r\n        ");
            __builder.OpenElement(126, "input");
            __builder.AddAttribute(127, "class", "btn btn-success");
            __builder.AddAttribute(128, "type", "submit");
            __builder.AddAttribute(129, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                                                               SendData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(130, "value", "Book Shelter");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\Anders\Desktop\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
       
    private string fornavn, efternavn, email, telefon, valgtKommune;

    private DateTime start_dato = DateTime.Now;
    private DateTime slut_dato = DateTime.Now.AddDays(1);

    public Shelter valgteShelter = new Shelter();
    public List<Shelter> ShelterListe;
    public List<string> AntalKommuner = new List<string>();
    public List<Shelter> KommuneSheltere;

    protected override async Task OnInitializedAsync()
    {
        AntalKommuner = await Http.GetFromJsonAsync<List<string>>("ShelterDB/distinctkommune");

    }

    //Finder sheltere baseret på valgte kommune
    public async Task vælgKommune(ChangeEventArgs e)
    {
        valgtKommune = e.Value.ToString();

        Console.WriteLine(valgtKommune);

        await GetKommuneSheltere(valgtKommune);
    } 

    //Get-funktion til at hente sheltere i controlleren
    protected async Task<List<Shelter>> GetKommuneSheltere(string kommunenavn)
    {
        return KommuneSheltere = await Http.GetFromJsonAsync<List<Shelter>>("ShelterDB/kommune?kommunenavn="+kommunenavn);

    }



    //Finder shelter ID og navn baseret på valgte shelter
    public async Task vælgShelter(ChangeEventArgs e)
    {
        var shelterId = e.Value.ToString();

        Console.WriteLine(shelterId);

        await GetShelterIdNavn(shelterId);
    } 

    //Get-funktion til at hente shelterID og navn i controlleren
    protected async Task<Shelter> GetShelterIdNavn(string shelterId)
    {
        return valgteShelter = await Http.GetFromJsonAsync<Shelter>("ShelterDB/idnavn?shelterId="+shelterId);

    }



    //Post-funktion til at oprette en booking
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

        nyUdlejet_Shelter.shelter_id = valgteShelter.Id.ToString();
        nyUdlejet_Shelter.shelter_navn = valgteShelter.Properties.Navn.ToString();

        nyBooking.bruger = nyBruger;
        nyBooking.udlejet_shelter = nyUdlejet_Shelter;

        fornavn = string.Empty;
        efternavn = string.Empty;
        email = string.Empty;
        telefon = string.Empty;
        slut_dato = DateTime.Now.AddDays(1);
        start_dato = DateTime.Now;


        await Http.PostAsJsonAsync<Booking>("BookingsDB/opret", nyBooking);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
