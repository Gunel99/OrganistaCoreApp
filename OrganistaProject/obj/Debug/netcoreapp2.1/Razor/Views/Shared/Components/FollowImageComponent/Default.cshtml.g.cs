#pragma checksum "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\Shared\Components\FollowImageComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a415853bbcda5194b8cd350f90b56d4021df2e93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FollowImageComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FollowImageComponent/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/FollowImageComponent/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_FollowImageComponent_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a415853bbcda5194b8cd350f90b56d4021df2e93", @"/Views/Shared/Components/FollowImageComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"607d1484598de7f379d5bfc1b102f5e9bf8cb542", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FollowImageComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FollowImage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(33, 824, true);
            WriteLiteral(@"
    <!-- FOLLOW US PART START -->
    <section id=""follow_us"">
        <div class=""row w-100 m-0"">
            <div class=""col-lg-4 col-md-12 col-sm-12 col-xs-12 p-0"">
                <div class=""follow h-100 d-flex align-items-center justify-content-center"">
                    <div class=""title"">
                        <div>
                            <h3>Follow Us On Instagram</h3>
                        </div>
                        <div>
                            <a href=""https://www.instagram.com/organic.foodstore/"">FOLLOW US</a>
                        </div>

                    </div>
                </div>
            </div>
            <div class=""col-lg-8 col-md-12 col-sm-12 col-xs-12 p-0"">
                <div class=""images"">
                    <div class=""row w-100 m-0"">
");
            EndContext();
#line 22 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\Shared\Components\FollowImageComponent\Default.cshtml"
                         foreach(var item in Model)
                        {

#line default
#line hidden
            BeginContext(937, 221, true);
            WriteLiteral("                            <div class=\"col-lg-4 col-md-4 p-0\">\r\n                                <div class=\"images_part\">\r\n                                    <div class=\"image\">\r\n                                        ");
            EndContext();
            BeginContext(1158, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aab123b294394c4c99e88df96b32d4cb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1168, "~/img/", 1168, 6, true);
#line 27 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\Shared\Components\FollowImageComponent\Default.cshtml"
AddHtmlAttributeValue("", 1174, item.Image, 1174, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1194, 122, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 31 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\Shared\Components\FollowImageComponent\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(1343, 156, true);
            WriteLiteral("                    </div>\r\n                 \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!-- FOLLOW US PART END -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FollowImage>> Html { get; private set; }
    }
}
#pragma warning restore 1591