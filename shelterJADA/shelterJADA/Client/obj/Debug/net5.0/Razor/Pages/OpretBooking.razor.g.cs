#pragma checksum "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85af7af1f48b31cedba871a258c806c07e67d742"
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
#line 1 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using shelterJADA.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\_Imports.razor"
using shelterJADA.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
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
            __builder.OpenElement(7, "thead");
#nullable restore
#line 17 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                 if (KommuneSheltere != null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<tr class=\"table-dark\"><th>Shelter</th>\r\n                    <th>Antal Pladser</th>\r\n                    <th>Beskrivelse</th></tr>");
#nullable restore
#line 24 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 27 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                 if (KommuneSheltere != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                     foreach (var item in KommuneSheltere)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-check");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "class", "form-check-input");
            __builder.AddAttribute(17, "type", "radio");
            __builder.AddAttribute(18, "id", "shelterKnap");
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                                                                                                         vælgShelter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "value", 
#nullable restore
#line 34 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                                                                                                                             item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "name", "radAnswer");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                                    ");
            __builder.OpenElement(23, "label");
            __builder.AddAttribute(24, "class", "form-check-label");
            __builder.AddAttribute(25, "for", "shelterknap");
#nullable restore
#line 36 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
__builder.AddContent(26, item.Properties.Navn);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "td");
#nullable restore
#line 40 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
__builder.AddContent(29, item.Properties.Antal_pl);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "td");
#nullable restore
#line 41 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
__builder.AddContent(32, item.Properties.Beskrivels);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "brugerInput col-md-5");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "form-floating mb-3");
            __builder.OpenElement(38, "select");
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                        vælgKommune

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "class", "form-select");
            __builder.AddAttribute(41, "id", "floatingSelect");
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "selected");
            __builder.AddContent(44, "Liste over kommuner");
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
     foreach (var item in AntalKommuner)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "option");
            __builder.AddAttribute(46, "value", 
#nullable restore
#line 55 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                       item

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 55 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
__builder.AddContent(47, item);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.AddMarkupContent(49, "<label for=\"floatingSelect\">Shelters i</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "div");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "form-floating mb-3");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "type", "text");
            __builder.AddAttribute(56, "class", "form-control");
            __builder.AddAttribute(57, "id", "floatingFornavn");
            __builder.AddAttribute(58, "aria-label", "First name");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                                                                                    fornavn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fornavn = __value, fornavn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.AddMarkupContent(62, "<label for=\"floatingFornavn\">Fornavn</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "form-floating mb-3");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "type", "text");
            __builder.AddAttribute(68, "class", "form-control");
            __builder.AddAttribute(69, "id", "floatingEfternavn");
            __builder.AddAttribute(70, "aria-label", "Last name");
            __builder.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 66 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                                                                                      efternavn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => efternavn = __value, efternavn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.AddMarkupContent(74, "<label for=\"floatingEfternavn\">Efternavn</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n\r\n\r\n        ");
            __builder.OpenElement(76, "div");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "form-floating mb-3");
            __builder.OpenElement(79, "input");
            __builder.AddAttribute(80, "type", "email");
            __builder.AddAttribute(81, "class", "form-control");
            __builder.AddAttribute(82, "id", "floatingInput");
            __builder.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 74 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                                                                                 email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n              ");
            __builder.AddMarkupContent(86, "<label for=\"floatingInput\">Email</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\r\n        ");
            __builder.OpenElement(88, "div");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "form-floating mb-3");
            __builder.OpenElement(91, "input");
            __builder.AddAttribute(92, "type", "tel");
            __builder.AddAttribute(93, "class", "form-control");
            __builder.AddAttribute(94, "id", "floatingTelefon");
            __builder.AddAttribute(95, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 81 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                                                                                 telefon

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => telefon = __value, telefon));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n              ");
            __builder.AddMarkupContent(98, "<label for=\"floatingTelefon\">Telefon</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n\r\n        ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "row g-2");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "col-md");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "form-floating mb-3");
            __builder.OpenElement(106, "input");
            __builder.AddAttribute(107, "type", "date");
            __builder.AddAttribute(108, "class", "form-control");
            __builder.AddAttribute(109, "id", "floatingStart");
            __builder.AddAttribute(110, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                                                                                    start_dato

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(111, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => start_dato = __value, start_dato, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                  ");
            __builder.AddMarkupContent(113, "<label for=\"floatingStart\">Start dato</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n            ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "col-md");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "form-floating mb-3");
            __builder.OpenElement(119, "input");
            __builder.AddAttribute(120, "type", "date");
            __builder.AddAttribute(121, "class", "form-control");
            __builder.AddAttribute(122, "id", "floatingSlut");
            __builder.AddAttribute(123, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 95 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                                                                                   slut_dato

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(124, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => slut_dato = __value, slut_dato, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                  ");
            __builder.AddMarkupContent(126, "<label for=\"floatingSlut\">Slut dato</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n\r\n        ");
            __builder.OpenElement(128, "input");
            __builder.AddAttribute(129, "class", "btn btn-success");
            __builder.AddAttribute(130, "type", "submit");
            __builder.AddAttribute(131, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
                                                               SendData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(132, "value", "Book Shelter");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "C:\Users\Jacob\Source\Repos\JADA-Shelter\shelterJADA\shelterJADA\Client\Pages\OpretBooking.razor"
       
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



        await Http.PostAsJsonAsync<Booking>("BookingsDB/opret", nyBooking);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
