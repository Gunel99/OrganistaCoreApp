#pragma checksum "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\Shared\Components\CommentInBlogDetailsPageComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eefe1fe1e635abc01e61e3fdff9b32d21dffb99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CommentInBlogDetailsPageComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CommentInBlogDetailsPageComponent/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CommentInBlogDetailsPageComponent/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CommentInBlogDetailsPageComponent_Default))]
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
#line 1 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\_ViewImports.cshtml"
using OrganistaProject.Entity;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\_ViewImports.cshtml"
using OrganistaProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eefe1fe1e635abc01e61e3fdff9b32d21dffb99", @"/Views/Shared/Components/CommentInBlogDetailsPageComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"607d1484598de7f379d5bfc1b102f5e9bf8cb542", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CommentInBlogDetailsPageComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CommentFromPage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/organic-food-distributors-3864x1932.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 230%; border-radius:0;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Organista"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 15, true);
            WriteLiteral("\r\n<style>\r\n    ");
            EndContext();
            BeginContext(53, 244, true);
            WriteLiteral("@media only screen and (max-width: 1200px){\r\n        .comment .image{\r\n            display:none!important;\r\n        }\r\n    }\r\n</style>\r\n\r\n<section id=\"comments\" style=\"margin:55px 0px;\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 14 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\Shared\Components\CommentInBlogDetailsPageComponent\Default.cshtml"
             foreach (var commentt in Model)
            {
                

#line default
#line hidden
#line 16 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\Shared\Components\CommentInBlogDetailsPageComponent\Default.cshtml"
                 if (commentt.IsRead == true)
                {

#line default
#line hidden
            BeginContext(424, 618, true);
            WriteLiteral(@"                    <div class=""comment d-flex py-5 w-100"">
                        <div class=""image"" style=""text-align: center; padding: 20px 0px; border: 1px solid #f0f2f3; border-radius: 50%;
                                height: 90px; width: 100px; background: #f0f2f3; margin-right: 25px;"">
                            <i class=""far fa-user"" style=""font-size:40px;""></i>
                        </div>
                        <div class=""content w-100 d-block"" style=""margin-top: 10px;"">
                            <div class=""title d-flex justify-content-between"">
                                <h5>");
            EndContext();
            BeginContext(1043, 17, false);
#line 25 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\Shared\Components\CommentInBlogDetailsPageComponent\Default.cshtml"
                               Write(commentt.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(1060, 61, true);
            WriteLiteral("</h5>\r\n\r\n                                <p>Posted on: <span>");
            EndContext();
            BeginContext(1122, 36, false);
#line 27 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\Shared\Components\CommentInBlogDetailsPageComponent\Default.cshtml"
                                               Write(DateTime.Now.ToString("dd MMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1158, 80, true);
            WriteLiteral("</span></p>\r\n                            </div>\r\n                            <p>");
            EndContext();
            BeginContext(1239, 16, false);
#line 29 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\Shared\Components\CommentInBlogDetailsPageComponent\Default.cshtml"
                          Write(commentt.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(1255, 66, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 32 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\Shared\Components\CommentInBlogDetailsPageComponent\Default.cshtml"
                     if (commentt.IsResponsed == true)
                    {

#line default
#line hidden
            BeginContext(1400, 362, true);
            WriteLiteral(@"                        <div class=""comment d-flex w-100"" style=""margin-left: 80px;"">
                            <div class=""image"" style=""text-align: center; border: 1px solid #f0f2f3; border-radius: 50%;
                                height: 90px; width: 100px; background: #f0f2f3; margin-right: 25px; overflow:hidden;"">
                                ");
            EndContext();
            BeginContext(1762, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8fa3e538bcc149e7806de8fb9ba74f91", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1873, 309, true);
            WriteLiteral(@"
                            </div>
                            <div class=""content w-100 d-block"" style=""margin-top: 10px;"">
                                <div class=""title"">
                                    <h5>Organista</h5>
                                    <p><span style=""font-weight:bold;"">");
            EndContext();
            BeginContext(2183, 17, false);
#line 42 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\Shared\Components\CommentInBlogDetailsPageComponent\Default.cshtml"
                                                                  Write(commentt.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(2200, 141, true);
            WriteLiteral(" </span>email gonderildi...</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 46 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\Shared\Components\CommentInBlogDetailsPageComponent\Default.cshtml"
                    }

#line default
#line hidden
#line 46 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\Shared\Components\CommentInBlogDetailsPageComponent\Default.cshtml"
                     
                }

#line default
#line hidden
#line 47 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\Shared\Components\CommentInBlogDetailsPageComponent\Default.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(2398, 40, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CommentFromPage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
