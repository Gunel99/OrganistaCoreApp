#pragma checksum "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Shared\Components\CounterComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0e8788efcca51456694b1ea8a27484733609d13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrganista_Views_Shared_Components_CounterComponent_Default), @"mvc.1.0.view", @"/Areas/AdminOrganista/Views/Shared/Components/CounterComponent/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminOrganista/Views/Shared/Components/CounterComponent/Default.cshtml", typeof(AspNetCore.Areas_AdminOrganista_Views_Shared_Components_CounterComponent_Default))]
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
#line 1 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\_ViewImports.cshtml"
using OrganistaProject.Models;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\_ViewImports.cshtml"
using OrganistaProject.Entity;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\_ViewImports.cshtml"
using OrganistaProject.Areas.AdminOrganista.Models;

#line default
#line hidden
#line 4 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0e8788efcca51456694b1ea8a27484733609d13", @"/Areas/AdminOrganista/Views/Shared/Components/CounterComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d085bf9f8c80a65e4f9cd1e0386c01fcb12d48", @"/Areas/AdminOrganista/Views/_ViewImports.cshtml")]
    public class Areas_AdminOrganista_Views_Shared_Components_CounterComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CounterModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Slider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/apple-2-32.ico"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fa fa-5x red"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/carrot-32.ico"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fa fa-5x yellow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Author", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Image", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FollowImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Company", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 1117, true);
            WriteLiteral(@"<style>
    .board .panel {
        display: flex;
        justify-content: space-between;
        padding: 20px 15px;
        border: none;
        background: #fff;
    }


    .number h3 {
        font-size: 32px;
        color: #676767;
    }

    .number small {
        font-size: 14px;
        color: #AAB5BC;
        font-weight: 600;
        text-transform: uppercase;
        margin: 8px 5px;
        display: inline-block;
    }

    .board .panel .icon .fa {
        font-size: 30px;
        color: #FFFFFF;
        background: #30A5FF;
        padding: 19px;
    }

    .blue {
        background: #30A5FF !important;
    }

    .green {
        background: #1ABC9C !important;
    }

    .yellow {
        background: #FABE28 !important;
    }

    .red {
        background: #f36a5a !important;
    }
</style>


<div class=""row mt-5"">
    <div class=""col-md-3 col-sm-12 col-xs-12"">
        <div class=""board"">
            <div class=""panel panel-primary"">
");
            WriteLiteral("                <div class=\"number\">\r\n                    <h3>\r\n                    </h3><h3>");
            EndContext();
            BeginContext(1139, 21, false);
#line 57 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Shared\Components\CounterComponent\Default.cshtml"
                        Write(Model.Sliders.Count());

#line default
#line hidden
            EndContext();
            BeginContext(1160, 91, true);
            WriteLiteral("</h3>\r\n                    <small>Sliders</small>\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(1251, 299, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6979973b95e340b8a3b9c83cf54fb673", async() => {
                BeginContext(1297, 249, true);
                WriteLiteral("\r\n                    <div class=\"icon\" style=\"margin-top:10px;\">\r\n                        <i class=\"mdi mdi-presentation-play fa-5x green\" style=\"color: white; padding: 11px 15px; font-size: 40px;\"></i>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1550, 269, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""col-md-3 col-sm-12 col-xs-12"">
        <div class=""board"">
            <div class=""panel panel-primary"">
                <div class=""number"">
                    <h3>
                    </h3><h3>");
            EndContext();
            BeginContext(1820, 20, false);
#line 74 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Shared\Components\CounterComponent\Default.cshtml"
                        Write(Model.Orders.Count());

#line default
#line hidden
            EndContext();
            BeginContext(1840, 92, true);
            WriteLiteral("</h3>\r\n                    <small>Orders</small>\r\n\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(1932, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41d2faac80ff462b9ba00782df72babe", async() => {
                BeginContext(1977, 158, true);
                WriteLiteral("\r\n                    <div class=\"icon\">\r\n                        <i class=\"fa fa-shopping-cart fa-5x blue\"></i>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2139, 269, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""col-md-3 col-sm-12 col-xs-12"">
        <div class=""board"">
            <div class=""panel panel-primary"">
                <div class=""number"">
                    <h3>
                    </h3><h3>");
            EndContext();
            BeginContext(2409, 22, false);
#line 92 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Shared\Components\CounterComponent\Default.cshtml"
                        Write(Model.Products.Count());

#line default
#line hidden
            EndContext();
            BeginContext(2431, 92, true);
            WriteLiteral("</h3>\r\n                    <small>Products</small>\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(2523, 218, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b8f187aa4354f55bdd9ef0e126eda43", async() => {
                BeginContext(2570, 66, true);
                WriteLiteral("\r\n                    <div class=\"icon\">\r\n                        ");
                EndContext();
                BeginContext(2636, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a65eb2241bb943288428df00ea297943", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2691, 46, true);
                WriteLiteral("\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2741, 269, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""col-md-3 col-sm-12 col-xs-12"">
        <div class=""board"">
            <div class=""panel panel-primary"">
                <div class=""number"">
                    <h3>
                    </h3><h3>");
            EndContext();
            BeginContext(3011, 24, false);
#line 109 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Shared\Components\CounterComponent\Default.cshtml"
                        Write(Model.Categories.Count());

#line default
#line hidden
            EndContext();
            BeginContext(3035, 96, true);
            WriteLiteral("</h3>\r\n                    <small>Categories</small>\r\n\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(3131, 221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094f7c5dd0bf403c8a9795ea18681741", async() => {
                BeginContext(3179, 66, true);
                WriteLiteral("\r\n                    <div class=\"icon\">\r\n                        ");
                EndContext();
                BeginContext(3245, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "868fbe6873da4d36b5e0881f8cc06e41", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3302, 46, true);
                WriteLiteral("\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3352, 274, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""col-md-3 col-sm-12 col-xs-12"">
        <div class=""board mt-3"">
            <div class=""panel panel-primary"">
                <div class=""number"">
                    <h3>
                    </h3><h3>");
            EndContext();
            BeginContext(3627, 19, false);
#line 127 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Shared\Components\CounterComponent\Default.cshtml"
                        Write(Model.Blogs.Count());

#line default
#line hidden
            EndContext();
            BeginContext(3646, 91, true);
            WriteLiteral("</h3>\r\n                    <small>Blogs</small>\r\n\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(3737, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9e72dde34fa4eba93cf517a97f275a7", async() => {
                BeginContext(3781, 153, true);
                WriteLiteral("\r\n                    <div class=\"icon\">\r\n                        <i class=\"fa fa-file-alt fa-5x blue\"></i>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3938, 274, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""col-md-3 col-sm-12 col-xs-12"">
        <div class=""board mt-3"">
            <div class=""panel panel-primary"">
                <div class=""number"">
                    <h3>
                    </h3><h3>");
            EndContext();
            BeginContext(4213, 21, false);
#line 145 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Shared\Components\CounterComponent\Default.cshtml"
                        Write(Model.Authors.Count());

#line default
#line hidden
            EndContext();
            BeginContext(4234, 93, true);
            WriteLiteral("</h3>\r\n                    <small>Authors</small>\r\n\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(4327, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca58cc9fdcb94a7a88f856bcd5e28ab4", async() => {
                BeginContext(4373, 154, true);
                WriteLiteral("\r\n                    <div class=\"icon\">\r\n                        <i class=\"fa fa-user-tie fa-5x green\"></i>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4531, 274, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""col-md-3 col-sm-12 col-xs-12"">
        <div class=""board mt-3"">
            <div class=""panel panel-primary"">
                <div class=""number"">
                    <h3>
                    </h3><h3>");
            EndContext();
            BeginContext(4806, 19, false);
#line 163 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Shared\Components\CounterComponent\Default.cshtml"
                        Write(Model.Users.Count());

#line default
#line hidden
            EndContext();
            BeginContext(4825, 91, true);
            WriteLiteral("</h3>\r\n                    <small>Users</small>\r\n\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(4916, 199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99c000088c924c84ab40070d3e8ec884", async() => {
                BeginContext(4960, 151, true);
                WriteLiteral("\r\n                    <div class=\"icon\">\r\n                        <i class=\"fa fa-user fa-5x yellow\"></i>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5115, 274, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""col-md-3 col-sm-12 col-xs-12"">
        <div class=""board mt-3"">
            <div class=""panel panel-primary"">
                <div class=""number"">
                    <h3>
                    </h3><h3>");
            EndContext();
            BeginContext(5390, 20, false);
#line 181 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Shared\Components\CounterComponent\Default.cshtml"
                        Write(Model.Images.Count());

#line default
#line hidden
            EndContext();
            BeginContext(5410, 102, true);
            WriteLiteral("</h3>\r\n                    <small>Blog Desc Images</small>\r\n\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(5512, 199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e18d76a884f4740905aa2e83066a53e", async() => {
                BeginContext(5557, 150, true);
                WriteLiteral("\r\n                    <div class=\"icon\">\r\n                        <i class=\"fa fa-images fa-5x red\"></i>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5711, 274, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""col-md-3 col-sm-12 col-xs-12"">
        <div class=""board mt-3"">
            <div class=""panel panel-primary"">
                <div class=""number"">
                    <h3>
                    </h3><h3>");
            EndContext();
            BeginContext(5986, 26, false);
#line 199 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Shared\Components\CounterComponent\Default.cshtml"
                        Write(Model.FollowImages.Count());

#line default
#line hidden
            EndContext();
            BeginContext(6012, 99, true);
            WriteLiteral("</h3>\r\n                    <small>Follow Images</small>\r\n\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(6111, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1de1b5c86464dd1b7e0300149f6b594", async() => {
                BeginContext(6162, 156, true);
                WriteLiteral("\r\n                    <div class=\"icon\">\r\n                        <i class=\"fa fa-camera-retro fa-5x red\"></i>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6322, 274, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""col-md-3 col-sm-12 col-xs-12"">
        <div class=""board mt-3"">
            <div class=""panel panel-primary"">
                <div class=""number"">
                    <h3>
                    </h3><h3>");
            EndContext();
            BeginContext(6597, 23, false);
#line 217 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Shared\Components\CounterComponent\Default.cshtml"
                        Write(Model.Companies.Count());

#line default
#line hidden
            EndContext();
            BeginContext(6620, 95, true);
            WriteLiteral("</h3>\r\n                    <small>Companies</small>\r\n\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(6715, 263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "110f9cfec60a4cac8ceb99e792f977e9", async() => {
                BeginContext(6762, 212, true);
                WriteLiteral("\r\n                    <div class=\"icon\">\r\n                        <i class=\"far fa-building fa-5x yellow\" style=\"font-size: 30px; color: #FFFFFF; padding: 19px;\"></i>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6978, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CounterModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
