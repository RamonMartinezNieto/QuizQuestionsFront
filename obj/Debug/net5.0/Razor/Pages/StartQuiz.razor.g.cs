#pragma checksum "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2d568371881da1d31ed3d468176d51eab23030c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/StartQuiz/{category:int}/{numberOfQuestions:int}")]
    public partial class StartQuiz : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
 if(EndQuizReport){

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<QuizQuestionsFront.Pages.EndQuiz>(0);
            __builder.AddAttribute(1, "ListQuestions", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<QuizQuestionsFront.Models.QuestionModel>>(
#nullable restore
#line 5 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
                             ListQuestions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "AnswersList", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.Int32, System.Int32>>(
#nullable restore
#line 5 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
                                                          AnswersList

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 6 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"

} else {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<h3>StartQuiz</h3>");
#nullable restore
#line 9 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"

    if (!Error.IsError && ShouldRender())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid container bg-light border border-3 border-primary p-3 rounded-3 shadow rounded-3 w-75");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "text-center");
            __builder.OpenElement(8, "h3");
            __builder.AddAttribute(9, "class", "m-2");
#nullable restore
#line 15 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
__builder.AddContent(10, CurrentQuestion.Question);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n            ");
            __builder.OpenComponent<Blazorise.Form>(12);
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.RadioGroup<int>>(14);
                __builder2.AddAttribute(15, "Name", "answers");
                __builder2.AddAttribute(16, "CheckedValue", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 19 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
                                                                             _questionAnswer.ChoosedAnswerd

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "CheckedValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _questionAnswer.ChoosedAnswerd = __value, _questionAnswer.ChoosedAnswerd))));
                __builder2.AddAttribute(18, "CheckedValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int>>>(() => _questionAnswer.ChoosedAnswerd));
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 21 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
                     foreach (KeyValuePair<string, int> answerValue in ShuffleAnswers)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Blazorise.Radio<int>>(20);
                    __builder3.AddAttribute(21, "Checked", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
                                        false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 23 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
                                                                   answerValue.Value

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "Margin", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentSpacing>(
#nullable restore
#line 23 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
                                                                                              Blazorise.Margin.Is2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
                                                                                                                              EnableButton

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 23 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
__builder4.AddContent(26, answerValue.Key);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "<br>");
#nullable restore
#line 24 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n\r\n                ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "text-center");
#nullable restore
#line 28 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
                     if(IsLastQuestion){
                        if(IsButtonEnable){

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
                __builder2.AddAttribute(32, "class", "nav-link");
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(34, "button");
                    __builder3.AddAttribute(35, "class", "btn btn-danger btn-lg m-3");
                    __builder3.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
                                                                                    FinishQuiz

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "enabled");
                    __builder3.AddContent(38, "Finish!");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 33 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
                            } 
                            else
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
                __builder2.AddAttribute(40, "class", "nav-link");
                __builder2.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(42, "<button class=\"btn btn-danger btn-lg m-3\" disabled>Finish!</button>");
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 39 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
                            }
                        }
                    else if(IsButtonEnable)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(43);
                __builder2.AddAttribute(44, "class", "nav-link");
                __builder2.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(46, "button");
                    __builder3.AddAttribute(47, "class", "btn btn-primary btn-lg m-3");
                    __builder3.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
                                                                                 NextQuestion

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "enabled");
                    __builder3.AddContent(50, "Next");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 46 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
                    } else
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(51);
                __builder2.AddAttribute(52, "class", "nav-link");
                __builder2.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(54, "<button class=\"btn btn-primary btn-lg m-3\" disabled>Next</button>");
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 51 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(55, "\r\n\r\n        ");
            __builder.OpenElement(56, "div");
            __builder.AddContent(57, " Element questionId ");
#nullable restore
#line 55 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
__builder.AddContent(58, _questionAnswer.QuestionId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.OpenElement(60, "div");
            __builder.AddContent(61, " Element choosed ");
#nullable restore
#line 56 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
__builder.AddContent(62, _questionAnswer.ChoosedAnswerd);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "p");
#nullable restore
#line 61 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
__builder.AddContent(64, Error.Message);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\RMN\source\repos\QuizQuestionsFront\Pages\StartQuiz.razor"
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
