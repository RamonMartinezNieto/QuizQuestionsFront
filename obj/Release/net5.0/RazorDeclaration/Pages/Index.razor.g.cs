// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace QuizQuestionsFront.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\RMN\source\repos\QuizQuestionsFront\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RMN\source\repos\QuizQuestionsFront\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\RMN\source\repos\QuizQuestionsFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\RMN\source\repos\QuizQuestionsFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\RMN\source\repos\QuizQuestionsFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\RMN\source\repos\QuizQuestionsFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\RMN\source\repos\QuizQuestionsFront\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\RMN\source\repos\QuizQuestionsFront\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\RMN\source\repos\QuizQuestionsFront\_Imports.razor"
using QuizQuestionsFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\RMN\source\repos\QuizQuestionsFront\_Imports.razor"
using QuizQuestionsFront.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\RMN\source\repos\QuizQuestionsFront\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\RMN\source\repos\QuizQuestionsFront\_Imports.razor"
using QuizQuestionsFront.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\Index.razor"
       
  string currentInputValue;

  public async Task Save()
  {
    await JSRuntime.InvokeVoidAsync("localStorage.setItem", "item", currentInputValue);
  }

  public async Task Read()
  {
    currentInputValue = await JSRuntime.InvokeAsync<string>("localStorage.getItem", "item");
  }

  public async Task Delete()
  {
    await JSRuntime.InvokeAsync<string>("localStorage.removeItem", "item");
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
