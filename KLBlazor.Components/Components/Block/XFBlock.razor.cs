using Microsoft.AspNetCore.Components;
using System;
using System.Collections;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace KLBlazor.Components
{
    public partial class XFBlock : XFComponentBase
    {
        [Parameter] public RenderFragment ChildContent { get; set; }

        protected ClassBuilder ComponentClassBuilder { get; private set; }
        protected string ComponentClassNames => ComponentClassBuilder.Class;

        protected override void BuildClasses(ClassBuilder builder)
        {
            builder.Append("xf-card");
            base.BuildClasses(builder);
        }
    }
}