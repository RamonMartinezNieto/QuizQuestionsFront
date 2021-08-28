#pragma checksum "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\QuestionsQuiz.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b818a326e709435088eda97674a7bbb503a5123e"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Quiz")]
    public partial class QuestionsQuiz : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>QuestionsQuiz One</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "justify-content-center align-items-center container-fluid text-center container bg-light border border-3 border-primary p-3 rounded-3 shadow rounded-3 w-75");
            __builder.AddMarkupContent(3, "<h2 class=\"m-2\">Choose your training</h2>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "m-3");
            __builder.AddMarkupContent(6, "<label class=\"m-2 col-form-label\" for=\"categorySelect\">Category:</label><br>\r\n        \r\n        ");
            __builder.OpenElement(7, "select");
            __builder.AddAttribute(8, "name", "category");
            __builder.AddAttribute(9, "id", "category");
            __builder.AddAttribute(10, "class", "form-control-lg border border-1 border-secondary rounded-3 w-50");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\QuestionsQuiz.razor"
                       SelectedCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedCategory = __value, SelectedCategory));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "value", "0");
            __builder.AddAttribute(15, "selected");
            __builder.AddAttribute(16, "disabled");
            __builder.AddContent(17, "Select the category");
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\QuestionsQuiz.razor"
             foreach (CategoryModel a in LoadCategories())
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "option");
            __builder.AddAttribute(19, "value", 
#nullable restore
#line 17 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\QuestionsQuiz.razor"
                                a.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "data-tokens", 
#nullable restore
#line 17 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\QuestionsQuiz.razor"
                                                    a.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, 
#nullable restore
#line 17 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\QuestionsQuiz.razor"
                                                             a.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\QuestionsQuiz.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group m-3");
            __builder.AddMarkupContent(25, "<label class=\"m-2\" for=\"questionsRequest\">Number of questions:</label><br>\r\n        \r\n        ");
            __builder.OpenElement(26, "select");
            __builder.AddAttribute(27, "name", "category");
            __builder.AddAttribute(28, "id", "category");
            __builder.AddAttribute(29, "class", "form-control-lg border border-1 border-secondary rounded-3 w-50");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\QuestionsQuiz.razor"
                       SelectedNumberOfQuestions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedNumberOfQuestions = __value, SelectedNumberOfQuestions));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value", "0");
            __builder.AddAttribute(34, "selected");
            __builder.AddAttribute(35, "disabled");
            __builder.AddContent(36, "Select number of questions");
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\QuestionsQuiz.razor"
             foreach (int time in TimesQuiz)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "option");
            __builder.AddAttribute(38, "value", 
#nullable restore
#line 30 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\QuestionsQuiz.razor"
                                time

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(39, 
#nullable restore
#line 30 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\QuestionsQuiz.razor"
                                       time

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\QuestionsQuiz.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\QuestionsQuiz.razor"
     if (SelectedCategory == 0 || SelectedNumberOfQuestions == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(40);
            __builder.AddAttribute(41, "class", "nav-link");
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "<button class=\"btn btn-secondary btn-lg w-25\">Start!</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 40 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\QuestionsQuiz.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(44);
            __builder.AddAttribute(45, "class", "nav-link");
            __builder.AddAttribute(46, "href", 
#nullable restore
#line 43 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\QuestionsQuiz.razor"
                                         GetRoute()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(48, "<button class=\"btn btn-primary btn-lg w-25\">Start!</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 46 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\QuestionsQuiz.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591