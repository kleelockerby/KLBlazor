// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KLBlazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\_Imports.razor"
using KLBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\_Imports.razor"
using KLBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\_Imports.razor"
using KLBlazor.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/comboboxpage")]
    public partial class ComboBoxPage : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\ComboBoxPage.razor"
       
    private string resultProperty = "";
    private string results = "";
    private string selectedCountryName1 = "";

    private Country[] countries;
    private Country selectedCountry1 { get; set; }

    protected override async Task OnInitializedAsync()
    {
        this.countries = await Http.GetFromJsonAsync<Country[]>("sample-data/countries.json");
        this.selectedCountry1 = countries[3];
    }

    protected void XFComboBox1_Changed(object newValue)
    {
        selectedCountry1 = (Country)newValue;
        selectedCountryName1 = selectedCountry1.CountryName;
        resultProperty = "Selected Country:";
        results = selectedCountryName1;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
