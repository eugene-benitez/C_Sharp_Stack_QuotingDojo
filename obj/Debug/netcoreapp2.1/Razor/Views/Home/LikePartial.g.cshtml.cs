#pragma checksum "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54c4939c8fe80730b63e3723e1f86e4bf2a6009f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LikePartial), @"mvc.1.0.view", @"/Views/Home/LikePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/LikePartial.cshtml", typeof(AspNetCore.Views_Home_LikePartial))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/_ViewImports.cshtml"
using C_Sharp;

#line default
#line hidden
#line 1 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
using C_Sharp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54c4939c8fe80730b63e3723e1f86e4bf2a6009f", @"/Views/Home/LikePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d5e279879302ac010ae0c0f8d26a1f9e08d51c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LikePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Likes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Like", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
 for (int i = 0; i < @ViewBag.AllQuotes.Count; i++)
{
    int liked = 0;

#line default
#line hidden
            BeginContext(108, 186, true);
            WriteLiteral("    <table class=\"table table-striped table-inverse table-responsive\">\n        <thead class=\"thead-inverse\">\n            <tbody>\n                <tr>\n                    <td scope=\"row\">");
            EndContext();
            BeginContext(295, 27, false);
#line 10 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
                               Write(ViewBag.AllQuotes[i].Author);

#line default
#line hidden
            EndContext();
            BeginContext(322, 31, true);
            WriteLiteral(":</td>\n                    <td>");
            EndContext();
            BeginContext(354, 25, false);
#line 11 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
                   Write(ViewBag.AllQuotes[i].Text);

#line default
#line hidden
            EndContext();
            BeginContext(379, 41, true);
            WriteLiteral("</td>\n                    <td>Posted By: ");
            EndContext();
            BeginContext(421, 38, false);
#line 12 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
                              Write(ViewBag.AllQuotes[i].Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(459, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(461, 37, false);
#line 12 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
                                                                      Write(ViewBag.AllQuotes[i].Creator.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(498, 32, true);
            WriteLiteral("</td>\n                    <td>\n\n");
            EndContext();
#line 15 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
                     if (@ViewBag.UserId == @ViewBag.AllQuotes[i].CreatorID)

                    {

#line default
#line hidden
            BeginContext(630, 50, true);
            WriteLiteral("                        <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 680, "\"", 723, 2);
            WriteAttributeValue("", 687, "delete/", 687, 7, true);
#line 18 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
WriteAttributeValue("", 694, ViewBag.AllQuotes[i].QuoteID, 694, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(724, 26, true);
            WriteLiteral(" role=\"button\">Delete</a>\n");
            EndContext();
#line 19 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(772, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 21 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
                     foreach (var user in @ViewBag.LikedQuotes[i].Likers)
                    {
                        

#line default
#line hidden
#line 23 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
                         if(user.User.UserID == @ViewBag.UserId) {
                            liked = 1;
                        }

#line default
#line hidden
#line 25 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
                         
                    }

#line default
#line hidden
            BeginContext(1023, 50, true);
            WriteLiteral("                    <br>\n                    <br>\n");
            EndContext();
#line 29 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
                     if (liked == 1)
                    {

#line default
#line hidden
            BeginContext(1132, 46, true);
            WriteLiteral("                    <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1178, "\"", 1221, 2);
            WriteAttributeValue("", 1185, "unlike/", 1185, 7, true);
#line 31 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
WriteAttributeValue("", 1192, ViewBag.AllQuotes[i].QuoteID, 1192, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1222, 26, true);
            WriteLiteral(" role=\"button\">Unlike</a>\n");
            EndContext();
            BeginContext(1249, 77, true);
            WriteLiteral("                    <br>\n                    <button class=\"btn btn-primary\">");
            EndContext();
            BeginContext(1327, 35, false);
#line 34 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
                                               Write(ViewBag.LikedQuotes[i].Likers.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1362, 10, true);
            WriteLiteral("</button>\n");
            EndContext();
#line 35 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"

                    }

                    else {

#line default
#line hidden
            BeginContext(1423, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1443, 266, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12fe242e1886480199717415ebf185f5", async() => {
                BeginContext(1503, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(1524, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "23329f241cf74024b4d309090f9ed7d6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 40 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.QuoteID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 40 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
                                                      WriteLiteral(ViewBag.AllQuotes[i].QuoteID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1601, 101, true);
                WriteLiteral("\n                    <button class=\"btn btn-primary\" type=\"submit\">Like</button>\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1709, 53, true);
            WriteLiteral("\n                    <button class=\"btn btn-primary\">");
            EndContext();
            BeginContext(1763, 35, false);
#line 43 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
                                               Write(ViewBag.LikedQuotes[i].Likers.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1798, 10, true);
            WriteLiteral("</button>\n");
            EndContext();
#line 44 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(1830, 82, true);
            WriteLiteral("                    </td>\n                </tr>\n            </tbody>\n    </table>\n");
            EndContext();
#line 49 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/C_Sharp/Views/Home/LikePartial.cshtml"

}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Likes> Html { get; private set; }
    }
}
#pragma warning restore 1591
