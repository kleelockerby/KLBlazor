#pragma checksum "C:\Source\Blazor\KLBlazor\KLBlazor.Components\Components\ComboBox\XFListBoxItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcbae02a129df43d8f4921014d38d57a9c059e27"
// <auto-generated/>
#pragma warning disable 1591
namespace KLBlazor.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Source\Blazor\KLBlazor\KLBlazor.Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class XFListBoxItem<TItem> : XFComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Source\Blazor\KLBlazor\KLBlazor.Components\Components\ComboBox\XFListBoxItem.razor"
 if (ItemTemplate == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "li");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 7 "C:\Source\Blazor\KLBlazor\KLBlazor.Components\Components\ComboBox\XFListBoxItem.razor"
                ClassNames

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Source\Blazor\KLBlazor\KLBlazor.Components\Components\ComboBox\XFListBoxItem.razor"
                                       OnClickHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "style", 
#nullable restore
#line 7 "C:\Source\Blazor\KLBlazor\KLBlazor.Components\Components\ComboBox\XFListBoxItem.razor"
                                                               StyleNames

#line default
#line hidden
#nullable disable
            );
            __builder.AddMultipleAttributes(4, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 7 "C:\Source\Blazor\KLBlazor\KLBlazor.Components\Components\ComboBox\XFListBoxItem.razor"
                                                                                         Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, 
#nullable restore
#line 7 "C:\Source\Blazor\KLBlazor\KLBlazor.Components\Components\ComboBox\XFListBoxItem.razor"
                                                                                                      Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Source\Blazor\KLBlazor\KLBlazor.Components\Components\ComboBox\XFListBoxItem.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "class", 
#nullable restore
#line 11 "C:\Source\Blazor\KLBlazor\KLBlazor.Components\Components\ComboBox\XFListBoxItem.razor"
                ClassNames

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Source\Blazor\KLBlazor\KLBlazor.Components\Components\ComboBox\XFListBoxItem.razor"
                                       OnClickHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "style", 
#nullable restore
#line 11 "C:\Source\Blazor\KLBlazor\KLBlazor.Components\Components\ComboBox\XFListBoxItem.razor"
                                                               StyleNames

#line default
#line hidden
#nullable disable
            );
            __builder.AddMultipleAttributes(10, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 11 "C:\Source\Blazor\KLBlazor\KLBlazor.Components\Components\ComboBox\XFListBoxItem.razor"
                                                                                         Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, 
#nullable restore
#line 11 "C:\Source\Blazor\KLBlazor\KLBlazor.Components\Components\ComboBox\XFListBoxItem.razor"
                                                                                                      ItemTemplate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Source\Blazor\KLBlazor\KLBlazor.Components\Components\ComboBox\XFListBoxItem.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
