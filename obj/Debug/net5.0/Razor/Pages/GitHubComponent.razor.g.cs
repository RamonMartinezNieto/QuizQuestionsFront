#pragma checksum "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2125510a57d25bf6064ddf4cf285b6008ea2d730"
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
#line 1 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\_Imports.razor"
using QuizQuestionsFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\_Imports.razor"
using QuizQuestionsFront.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\_Imports.razor"
using Blazorise.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\_Imports.razor"
using QuizQuestionsFront.Models;

#line default
#line hidden
#nullable disable
    public partial class GitHubComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.Div>(0);
            __builder.AddAttribute(1, "Border", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentBorder>(
#nullable restore
#line 1 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor"
             Border.Is1.Dark.OnAll.Rounded

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Flex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentFlex>(
#nullable restore
#line 1 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor"
                                                  Flex.AlignContent.Center

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentSpacing>(
#nullable restore
#line 1 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor"
                                                                                    Margin.Is5.FromLeft.Is5.FromRight.Is2.FromTop.Is2.FromBottom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.Div>(5);
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.Image>(7);
                    __builder3.AddAttribute(8, "Source", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor"
                        GitHubAvartLink

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "Border", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentBorder>(
#nullable restore
#line 3 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor"
                                                 Border.RoundedPill.Is1.Dark

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentSpacing>(
#nullable restore
#line 3 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor"
                                                                                      Margin.Is3

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "style", "width: 150px; height: 150px;");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<Blazorise.Div>(13);
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.ListGroup>(15);
                    __builder3.AddAttribute(16, "Flush", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor"
                          true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.ListGroupItem>(18);
                        __builder4.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(20, "<svg version=\"1.1\" id=\"Capa_1\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" x=\"0px\" y=\"0px\" width=\"24px\" height=\"24px\" viewBox=\"0 0 438.549 438.549\" style=\"enable-background:new 0 0 438.549 438.549;\" xml:space=\"preserve\"><path d=\"M409.132,114.573c-19.608-33.596-46.205-60.194-79.798-79.8C295.736,15.166,259.057,5.365,219.271,5.365\r\n\t\t                c-39.781,0-76.472,9.804-110.063,29.408c-33.596,19.605-60.192,46.204-79.8,79.8C9.803,148.168,0,184.854,0,224.63\r\n\t\t                c0,47.78,13.94,90.745,41.827,128.906c27.884,38.164,63.906,64.572,108.063,79.227c5.14,0.954,8.945,0.283,11.419-1.996\r\n\t\t                c2.475-2.282,3.711-5.14,3.711-8.562c0-0.571-0.049-5.708-0.144-15.417c-0.098-9.709-0.144-18.179-0.144-25.406l-6.567,1.136\r\n\t\t                c-4.187,0.767-9.469,1.092-15.846,1c-6.374-0.089-12.991-0.757-19.842-1.999c-6.854-1.231-13.229-4.086-19.13-8.559\r\n\t\t                c-5.898-4.473-10.085-10.328-12.56-17.556l-2.855-6.57c-1.903-4.374-4.899-9.233-8.992-14.559\r\n\t\t                c-4.093-5.331-8.232-8.945-12.419-10.848l-1.999-1.431c-1.332-0.951-2.568-2.098-3.711-3.429c-1.142-1.331-1.997-2.663-2.568-3.997\r\n\t\t                c-0.572-1.335-0.098-2.43,1.427-3.289c1.525-0.859,4.281-1.276,8.28-1.276l5.708,0.853c3.807,0.763,8.516,3.042,14.133,6.851\r\n\t\t                c5.614,3.806,10.229,8.754,13.846,14.842c4.38,7.806,9.657,13.754,15.846,17.847c6.184,4.093,12.419,6.136,18.699,6.136\r\n\t\t                c6.28,0,11.704-0.476,16.274-1.423c4.565-0.952,8.848-2.383,12.847-4.285c1.713-12.758,6.377-22.559,13.988-29.41\r\n\t\t                c-10.848-1.14-20.601-2.857-29.264-5.14c-8.658-2.286-17.605-5.996-26.835-11.14c-9.235-5.137-16.896-11.516-22.985-19.126\r\n\t\t                c-6.09-7.614-11.088-17.61-14.987-29.979c-3.901-12.374-5.852-26.648-5.852-42.826c0-23.035,7.52-42.637,22.557-58.817\r\n\t\t                c-7.044-17.318-6.379-36.732,1.997-58.24c5.52-1.715,13.706-0.428,24.554,3.853c10.85,4.283,18.794,7.952,23.84,10.994\r\n\t\t                c5.046,3.041,9.089,5.618,12.135,7.708c17.705-4.947,35.976-7.421,54.818-7.421s37.117,2.474,54.823,7.421l10.849-6.849\r\n\t\t                c7.419-4.57,16.18-8.758,26.262-12.565c10.088-3.805,17.802-4.853,23.134-3.138c8.562,21.509,9.325,40.922,2.279,58.24\r\n\t\t                c15.036,16.18,22.559,35.787,22.559,58.817c0,16.178-1.958,30.497-5.853,42.966c-3.9,12.471-8.941,22.457-15.125,29.979\r\n\t\t                c-6.191,7.521-13.901,13.85-23.131,18.986c-9.232,5.14-18.182,8.85-26.84,11.136c-8.662,2.286-18.415,4.004-29.263,5.146\r\n\t\t                c9.894,8.562,14.842,22.077,14.842,40.539v60.237c0,3.422,1.19,6.279,3.572,8.562c2.379,2.279,6.136,2.95,11.276,1.995\r\n\t\t                c44.163-14.653,80.185-41.062,108.068-79.226c27.88-38.161,41.825-81.126,41.825-128.906\r\n\t\t                C438.536,184.851,428.728,148.168,409.132,114.573z\"></path></svg>\r\n                ");
                            __builder5.OpenElement(21, "span");
                            __builder5.AddAttribute(22, "class", "p-label");
                            __builder5.OpenElement(23, "a");
                            __builder5.AddAttribute(24, "href", 
#nullable restore
#line 30 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor"
                                                 GetGitHubUrl()

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddContent(25, 
#nullable restore
#line 30 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor"
                                                                   GitHub

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(26, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.ListGroupItem>(27);
                        __builder4.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(29, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24""><path d=""M19 0h-14c-2.761 0-5 2.239-5 5v14c0 2.761 2.239 5 5 5h14c2.762 0 5-2.239 5-5v-14c0-2.761-2.238-5-5-5zm-11 19h-3v-11h3v11zm-1.5-12.268c-.966 0-1.75-.79-1.75-1.764s.784-1.764 1.75-1.764 1.75.79 1.75 1.764-.783 1.764-1.75 1.764zm13.5 12.268h-3v-5.604c0-3.368-4-3.113-4 0v5.604h-3v-11h3v1.765c1.396-2.586 7-2.777 7 2.476v6.759z""></path></svg>
                ");
                            __builder5.OpenElement(30, "a");
                            __builder5.AddAttribute(31, "rel", "nofollow me");
                            __builder5.AddAttribute(32, "class", "Link--primary ");
                            __builder5.AddAttribute(33, "href", 
#nullable restore
#line 34 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor"
                                                                   GetLinkedinUrl()

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddContent(34, 
#nullable restore
#line 34 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor"
                                                                                      Linkedin

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(35, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.ListGroupItem>(36);
                        __builder4.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(38, @"<svg class=""octicon octicon-mail"" viewBox=""0 0 16 16"" version=""1.1"" width=""24"" height=""24"" aria-hidden=""true""><path fill-rule=""evenodd"" d=""M1.75 2A1.75 1.75 0 000 3.75v.736a.75.75 0 000 .027v7.737C0 13.216.784 14 1.75 14h12.5A1.75 1.75 0 0016 12.25v-8.5A1.75 1.75 0 0014.25 2H1.75zM14.5 4.07v-.32a.25.25 0 00-.25-.25H1.75a.25.25 0 00-.25.25v.32L8 7.88l6.5-3.81zm-13 1.74v6.441c0 .138.112.25.25.25h12.5a.25.25 0 00.25-.25V5.809L8.38 9.397a.75.75 0 01-.76 0L1.5 5.809z""></path></svg>
                ");
                            __builder5.OpenElement(39, "a");
                            __builder5.AddAttribute(40, "class", "u-email Link--primary ");
                            __builder5.AddAttribute(41, "href", "mailto:" + (
#nullable restore
#line 38 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor"
                                                                Email

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddContent(42, 
#nullable restore
#line 38 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor"
                                                                        Email

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(43, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.ListGroupItem>(44);
                        __builder4.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(46, @"<svg aria-hidden=""true"" height=""24"" viewBox=""0 0 16 16"" version=""1.1"" width=""24"" data-view-component=""true"" class=""octicon octicon-link""><path fill-rule=""evenodd"" d=""M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z""></path></svg>
                ");
                            __builder5.OpenElement(47, "a");
                            __builder5.AddAttribute(48, "rel", "nofollow me");
                            __builder5.AddAttribute(49, "class", "Link--primary ");
                            __builder5.AddAttribute(50, "href", 
#nullable restore
#line 44 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor"
                                                                   PersonalWeb

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddContent(51, 
#nullable restore
#line 44 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor"
                                                                                 PersonalWeb

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(52, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.ListGroupItem>(53);
                        __builder4.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(55, @"<svg height=""24px"" width=""24px"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 273.5 222.3"" role=""img"" aria-labelledby=""lhe6bep8x9whjdmp3inadjt9r8qbm2a"" class=""octicon""><title id=""lhe6bep8x9whjdmp3inadjt9r8qbm2a"">Twitter</title><path d=""M273.5 26.3a109.77 109.77 0 0 1-32.2 8.8 56.07 56.07 0 0 0 24.7-31 113.39 113.39 0 0 1-35.7 13.6 56.1 56.1 0 0 0-97 38.4 54 54 0 0 0 1.5 12.8A159.68 159.68 0 0 1 19.1 10.3a56.12 56.12 0 0 0 17.4 74.9 56.06 56.06 0 0 1-25.4-7v.7a56.11 56.11 0 0 0 45 55 55.65 55.65 0 0 1-14.8 2 62.39 62.39 0 0 1-10.6-1 56.24 56.24 0 0 0 52.4 39 112.87 112.87 0 0 1-69.7 24 119 119 0 0 1-13.4-.8 158.83 158.83 0 0 0 86 25.2c103.2 0 159.6-85.5 159.6-159.6 0-2.4-.1-4.9-.2-7.3a114.25 114.25 0 0 0 28.1-29.1"" fill=""currentColor""></path></svg>
                ");
                            __builder5.OpenElement(56, "a");
                            __builder5.AddAttribute(57, "rel", "nofollow me");
                            __builder5.AddAttribute(58, "class", "Link--primary ");
                            __builder5.AddAttribute(59, "href", 
#nullable restore
#line 48 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor"
                                                                   GetTwitterUrl()

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddContent(60, 
#nullable restore
#line 48 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor"
                                                                                     Twitter

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "F:\MyHome\SimpleQuestionsProject\Front-end\QuizQuestionsFront\Pages\GitHubComponent.razor"
      

    [Parameter]
    public string Twitter { get; set; }

    [Parameter]
    public string PersonalWeb { get; set; }

    [Parameter]
    public string Email { get; set; }

    [Parameter]
    public string GitHub { get; set; }

    [Parameter]
    public string GitHubAvartLink { get; set; }

    [Parameter]
    public string Linkedin { get; set; }

    public string GetTwitterUrl() => @$"https://twitter.com/{this.Twitter}";

    public string GetGitHubUrl() => @$"https://github.com/{this.GitHub}";

    public string GetLinkedinUrl() => @$"https://www.linkedin.com/in/{this.Linkedin}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591