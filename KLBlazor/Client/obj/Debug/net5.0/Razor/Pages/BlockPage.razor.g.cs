#pragma checksum "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\BlockPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f82af76706bffda7b109c6eed06ec527c36ec47f"
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
#nullable restore
#line 2 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\BlockPage.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/blockpage")]
    public partial class BlockPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .validation-message {\r\n        color: #ff0000;\r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>BlockPage</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\BlockPage.razor"
                  person

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\BlockPage.razor"
                                         OnSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "<label for=\"Name\">Name</label>\r\n            ");
                __builder2.OpenComponent<KLBlazor.Components.XFTextBox>(11);
                __builder2.AddAttribute(12, "id", "Name");
                __builder2.AddAttribute(13, "ValueInputChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 17 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\BlockPage.razor"
                                                                                OnInputChanged

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(14, "Style", "width: 300px;");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\BlockPage.razor"
                                               person.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.Name = __value, person.Name))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => person.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __Blazor.KLBlazor.Client.Pages.BlockPage.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 18 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\BlockPage.razor"
                                       () => person.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n\r\n        ");
                __builder2.AddMarkupContent(22, "<div style=\"margin-top: 20px;\"><button type=\"submit\">Submit</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n\r\n");
            __builder.OpenComponent<KLBlazor.Components.XFBlock>(24);
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n    Test MS to see if they know what the fuck they are doing\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n\r\n\r\n");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "style", "margin-top: 40px;");
            __builder.AddMarkupContent(30, "<span>Results: </span>");
            __builder.AddContent(31, 
#nullable restore
#line 33 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\BlockPage.razor"
                           results

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "style", "margin-top: 40px;");
            __builder.AddContent(35, 
#nullable restore
#line 37 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\BlockPage.razor"
     resultChars

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Source\Blazor\KLBlazor\KLBlazor\Client\Pages\BlockPage.razor"
      
    public class Person
    {
        [Required]
        [StringLength(20, ErrorMessage = "Name is Required.")]
        public string Name { get; set; } = null;
    }

    Person person = new Person();

    protected string results;
    protected string resultChars;

    protected string selectedText;
    protected string selectedChars;

    protected void OnTextChanged(string newValue)
    {
        person.Name = newValue;
        selectedText = newValue;
        results = selectedText;
        StateHasChanged();
    }

    protected override void OnInitialized()
    {
        results = person.Name;
    }

    protected void OnInputChanged(string newChar)
    {
        selectedChars = newChar;
        resultChars = selectedChars;
    }

    protected void OnSubmit()
    {
        ///bool isValid = editContext.Validate();
        results = person.Name;
        //results = isValid.ToString();
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.KLBlazor.Client.Pages.BlockPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
