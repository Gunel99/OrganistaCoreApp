#pragma checksum "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa71d8e30a997d7292fa7bae8ce507e4e5118774"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrganista_Views_Role_Update), @"mvc.1.0.view", @"/Areas/AdminOrganista/Views/Role/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminOrganista/Views/Role/Update.cshtml", typeof(AspNetCore.Areas_AdminOrganista_Views_Role_Update))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa71d8e30a997d7292fa7bae8ce507e4e5118774", @"/Areas/AdminOrganista/Views/Role/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d085bf9f8c80a65e4f9cd1e0386c01fcb12d48", @"/Areas/AdminOrganista/Views/_ViewImports.cshtml")]
    public class Areas_AdminOrganista_Views_Role_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-icon-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
  
    ViewData["Title"] = "Update";

#line default
#line hidden
            BeginContext(62, 130, true);
            WriteLiteral("\r\n    <div style=\"background: #1979a9; padding: 15px; color: #fff;\">\r\n        <h2 class=\"m-0\">Update Role</h2>\r\n    </div>\r\n\r\n    ");
            EndContext();
            BeginContext(192, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2695e0d30c14945b2481c98c94c63d3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 10 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(258, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(264, 2214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a65bd5206314d92b0189ef631e30cc2", async() => {
                BeginContext(304, 44, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"RoleId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 348, "\"", 370, 1);
#line 12 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
WriteAttributeValue("", 356, Model.Role.Id, 356, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(371, 49, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"RoleName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 420, "\"", 444, 1);
#line 13 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
WriteAttributeValue("", 428, Model.Role.Name, 428, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(445, 98, true);
                WriteLiteral(" />\r\n\r\n        <h6 style=\"padding: 10px; background: #5dbcd2; color: white;\">\r\n            Add to ");
                EndContext();
                BeginContext(544, 15, false);
#line 16 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
              Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(559, 19, true);
                WriteLiteral("\r\n        </h6>\r\n\r\n");
                EndContext();
#line 19 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
         if (Model.NonMembers.Count() == 0)
        {

#line default
#line hidden
                BeginContext(634, 68, true);
                WriteLiteral("            <p style=\"padding: 15px 0px;\">All user are members</p>\r\n");
                EndContext();
#line 22 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
        }
        else
        {

#line default
#line hidden
                BeginContext(738, 60, true);
                WriteLiteral("            <table class=\"table\">\r\n                <tbody>\r\n");
                EndContext();
#line 27 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
                     foreach (var user in Model.NonMembers)
                    {

#line default
#line hidden
                BeginContext(882, 62, true);
                WriteLiteral("                        <tr>\r\n                            <td>");
                EndContext();
                BeginContext(945, 13, false);
#line 30 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
                           Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(958, 146, true);
                WriteLiteral("</td>\r\n                            <td>\r\n                                <input style=\"width: 20px; height: 20px;\" type=\"checkbox\" name=\"IdsToAdd\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1104, "\"", 1120, 1);
#line 32 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
WriteAttributeValue("", 1112, user.Id, 1112, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1121, 71, true);
                WriteLiteral(" />\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 35 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
                    }

#line default
#line hidden
                BeginContext(1215, 48, true);
                WriteLiteral("                </tbody>\r\n            </table>\r\n");
                EndContext();
#line 38 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
        }

#line default
#line hidden
                BeginContext(1274, 96, true);
                WriteLiteral("\r\n        <h6 style=\"padding: 10px; background: #5dbcd2; color: white;\">\r\n            Delete to ");
                EndContext();
                BeginContext(1371, 15, false);
#line 41 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
                 Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1386, 19, true);
                WriteLiteral("\r\n        </h6>\r\n\r\n");
                EndContext();
#line 44 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
         if (Model.Members.Count() == 0)
        {

#line default
#line hidden
                BeginContext(1458, 68, true);
                WriteLiteral("            <p style=\"padding: 15px 0px;\">No users are members</p>\r\n");
                EndContext();
#line 47 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
        }
        else
        {

#line default
#line hidden
                BeginContext(1562, 60, true);
                WriteLiteral("            <table class=\"table\">\r\n                <tbody>\r\n");
                EndContext();
#line 52 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
                     foreach (var user in Model.Members)
                    {

#line default
#line hidden
                BeginContext(1703, 62, true);
                WriteLiteral("                        <tr>\r\n                            <td>");
                EndContext();
                BeginContext(1766, 13, false);
#line 55 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
                           Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(1779, 149, true);
                WriteLiteral("</td>\r\n                            <td>\r\n                                <input style=\"width: 20px; height: 20px;\" type=\"checkbox\" name=\"IdsToDelete\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1928, "\"", 1944, 1);
#line 57 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
WriteAttributeValue("", 1936, user.Id, 1936, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1945, 71, true);
                WriteLiteral(" />\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 60 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
                    }

#line default
#line hidden
                BeginContext(2039, 48, true);
                WriteLiteral("                </tbody>\r\n            </table>\r\n");
                EndContext();
#line 63 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Areas\AdminOrganista\Views\Role\Update.cshtml"
        }

#line default
#line hidden
                BeginContext(2098, 184, true);
                WriteLiteral("\r\n        <button type=\"submit\" class=\"btn btn-primary btn-icon-text\">\r\n            <i class=\"mdi mdi-file-check btn-icon-prepend\"></i>\r\n            Submit\r\n        </button>\r\n        ");
                EndContext();
                BeginContext(2282, 181, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b544c6215e64e76aa6d9c1a0cb19501", async() => {
                    BeginContext(2363, 91, true);
                    WriteLiteral("\r\n            <i class=\"mdi mdi-reload btn-icon-prepend\"></i>\r\n            Cancel\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2463, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2478, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
