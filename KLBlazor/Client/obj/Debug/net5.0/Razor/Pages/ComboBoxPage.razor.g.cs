#pragma checksum "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\ComboBoxPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0677ba21c941ff436cff54410ce5fc4047240f63"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/comboboxpage")]
    public partial class ComboBoxPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>

    .xf-combo-wrapper a.xf-button {
        width: 30px;
        background: #d75d1a;
        background: -webkit-gradient(linear, left top, left bottom, from(#fe7f26), to(#d75d1a));
        background: linear-gradient(to bottom, #fe7f26 0%, #d75d1a 100%);
        border: 1px solid #1a78bd;
        border-left: none;
        border-radius: 0 4px 4px 0;
        color: white;
        cursor: pointer;
        font-size: 1rem;
        padding: 0 10px;
        text-align: center;
        text-shadow: 0 1px 0 rgba(0, 0, 0, 0.3);
    }

        .xf-combo-wrapper a.xf-button::before {
            font-family: fontawesome;
            content: '\f0d7';
            color: #FFF;
            text-shadow: 0 1px 0 rgba(0, 0, 0, 0.3);
        }
</style>");
#nullable restore
#line 30 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\ComboBoxPage.razor"
 if (countries == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 33 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\ComboBoxPage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "margin-top: 25px;");
            __builder.AddMarkupContent(4, "<div><h3 style=\"color: #000;\">XFComboBox Class</h3></div>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "style", "margin-top: 20px;");
            __builder.AddMarkupContent(7, "<div><h4 style=\"color: #333; border-bottom: 1px solid #ccc;\">Event Results</h4></div>\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "style", "padding: 10px 0; background-color: #F0F0F0; font-size: .85rem;");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "style", "padding: 10px 30px;");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "style", "display: inline-block; width: 20%; color: #0073e0;");
            __builder.AddContent(14, 
#nullable restore
#line 42 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\ComboBoxPage.razor"
                                                                                     resultProperty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "style", "display: inline-block;");
            __builder.AddContent(18, 
#nullable restore
#line 43 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\ComboBoxPage.razor"
                                                         results

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "margin-top: 40px;");
            __builder.AddMarkupContent(21, "<div style=\"font-size: .80rem; padding: 5px; color: rgb(150, 150, 150);\">Bind Initial Value and Allow Clear</div>\r\n        ");
            __Blazor.KLBlazor.Client.Pages.ComboBoxPage.TypeInference.CreateXFComboBox_0(__builder, 22, 23, 
#nullable restore
#line 51 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\ComboBoxPage.razor"
                                 countries

#line default
#line hidden
#nullable disable
            , 24, 
#nullable restore
#line 52 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\ComboBoxPage.razor"
                                 (item)=>item.CountryName

#line default
#line hidden
#nullable disable
            , 25, 
#nullable restore
#line 53 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\ComboBoxPage.razor"
                                  (item)=>item.CountryCode

#line default
#line hidden
#nullable disable
            , 26, 
#nullable restore
#line 54 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\ComboBoxPage.razor"
                                   selectedCountry1

#line default
#line hidden
#nullable disable
            , 27, 
#nullable restore
#line 55 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\ComboBoxPage.razor"
                                          XFComboBox1_Changed

#line default
#line hidden
#nullable disable
            , 28, 
#nullable restore
#line 56 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\ComboBoxPage.razor"
                                    5

#line default
#line hidden
#nullable disable
            , 29, 
#nullable restore
#line 57 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\ComboBoxPage.razor"
                                    true

#line default
#line hidden
#nullable disable
            , 30, 
#nullable restore
#line 58 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\ComboBoxPage.razor"
                                true

#line default
#line hidden
#nullable disable
            , 31, "Select A Country");
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\ComboBoxPage.razor"
}

#line default
#line hidden
#nullable disable
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
namespace __Blazor.KLBlazor.Client.Pages.ComboBoxPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateXFComboBox_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.Func<TItem, global::System.String> __arg1, int __seq2, global::System.Func<TItem, global::System.Object> __arg2, int __seq3, TItem __arg3, int __seq4, global::System.Action<TItem> __arg4, int __seq5, global::System.Int32 __arg5, int __seq6, global::System.Boolean __arg6, int __seq7, global::System.Boolean __arg7, int __seq8, global::System.String __arg8)
        {
        __builder.OpenComponent<global::KLBlazor.Components.XFComboBox<TItem>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "TextField", __arg1);
        __builder.AddAttribute(__seq2, "ValueField", __arg2);
        __builder.AddAttribute(__seq3, "SelectedItem", __arg3);
        __builder.AddAttribute(__seq4, "SelectedItemChanged", __arg4);
        __builder.AddAttribute(__seq5, "NoDisplayItems", __arg5);
        __builder.AddAttribute(__seq6, "AllowFiltering", __arg6);
        __builder.AddAttribute(__seq7, "AllowClear", __arg7);
        __builder.AddAttribute(__seq8, "PlaceHolder", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591