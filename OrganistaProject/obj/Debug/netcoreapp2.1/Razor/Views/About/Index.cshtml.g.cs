#pragma checksum "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33affa7b7c642e58daed5c9e70b3e7947aebea91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/About/Index.cshtml", typeof(AspNetCore.Views_About_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33affa7b7c642e58daed5c9e70b3e7947aebea91", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"607d1484598de7f379d5bfc1b102f5e9bf8cb542", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(60, 782, true);
            WriteLiteral(@"
    <!-- MAIN PART START -->

    <main>
        <!-- ABOUT US SECTION START -->
        <section id=""about_us"">
            <div class=""container"">
                <div class=""row w-100 pl-3 m-0"">
                    <div class=""content w-100 d-flex justify-content-between"">
                        <h1>About Us</h1>
                        <p><span>Home</span> > About Us</p>
                    </div>
                </div>
            </div>
        </section>
        <!-- ABOUT US SECTION END -->

        <!-- SERVING PART START -->
        <section id=""serving"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""image"">
                            ");
            EndContext();
            BeginContext(842, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a5e4e4f05e634f5aad7637cec2ea83b1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 852, "~/img/", 852, 6, true);
#line 28 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 858, Model.AboutUsFirstDesc.Image, 858, 29, false);

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
            BeginContext(896, 185, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-6\">\r\n                        <div class=\"serving\">\r\n                            <h2>");
            EndContext();
            BeginContext(1082, 27, false);
#line 33 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\About\Index.cshtml"
                           Write(Model.AboutUsFirstDesc.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1109, 72, true);
            WriteLiteral("</h2>\r\n                            <p>\r\n                                ");
            EndContext();
            BeginContext(1182, 34, false);
#line 35 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\About\Index.cshtml"
                           Write(Model.AboutUsFirstDesc.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1216, 64, true);
            WriteLiteral("\r\n                            </p>\r\n                            ");
            EndContext();
            BeginContext(1280, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00390ac603a94f5d9538c2214bdce9db", async() => {
                BeginContext(1327, 79, true);
                WriteLiteral("\r\n                                Browse Our Shop\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1410, 777, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- SERVING PART END -->
        <!-- BUY TODAY PART START -->
        <section id=""buy_today"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""buy_today w-100 description"">
                        <h3>Buy Today and Get 20% Off</h3>
                        <p>
                            Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Cras ultricies ligula sed
                            magna dictum porta. Praesent sapien massa, convallis a pellentesque nec, egestas non
                            nisi.
                        </p>
                        ");
            EndContext();
            BeginContext(2187, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a069f95985a74552823d258f73f6eb35", async() => {
                BeginContext(2234, 8, true);
                WriteLiteral("Shop Now");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2246, 413, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </section>
        <!-- BUY TODAY PART END -->
        <!-- SERVING AND PICTURE PART START -->
        <section id=""serving_and_picture"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""image"">
                            ");
            EndContext();
            BeginContext(2659, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ae205d3867bd4f088ac887ca128fe1a5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2669, "~/img/", 2669, 6, true);
#line 69 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 2675, Model.AboutUsSecondDesc.Image, 2675, 30, false);

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
            BeginContext(2714, 185, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-6\">\r\n                        <div class=\"content\">\r\n                            <h2>");
            EndContext();
            BeginContext(2900, 28, false);
#line 74 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\About\Index.cshtml"
                           Write(Model.AboutUsSecondDesc.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2928, 72, true);
            WriteLiteral("</h2>\r\n                            <p>\r\n                                ");
            EndContext();
            BeginContext(3001, 35, false);
#line 76 "C:\Users\User\Desktop\OrganistaProject\OrganistaProject\Views\About\Index.cshtml"
                           Write(Model.AboutUsSecondDesc.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3036, 1313, true);
            WriteLiteral(@"
                            </p>
                            <div class=""advantages"">
                                <ul class=""p-0"">
                                    <li class=""mb-3"">
                                        <i class=""fas fa-plus-circle mr-3""></i>Lorem Ipsum has been the
                                        industry's standard dummy text ever
                                    </li>
                                    <li class=""mb-3"">
                                        <i class=""fas fa-plus-circle mr-3""></i>Lorem Ipsum has been the
                                        industry's
                                    </li>
                                    <li class=""mb-3"">
                                        <i class=""fas fa-plus-circle mr-3""></i>Lorem Ipsum has been the
                                        industry's standard dummy text ever
                                    </li>
                                    <li class=""mb-3"">
              ");
            WriteLiteral(@"                          <i class=""fas fa-plus-circle mr-3""></i>Lorem Ipsum has been the
                                        industry's
                                    </li>
                                </ul>
                            </div>
                            ");
            EndContext();
            BeginContext(4349, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3d364e1eb884af7b0ac67e6449726e0", async() => {
                BeginContext(4396, 79, true);
                WriteLiteral("\r\n                                Browse Our Shop\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4479, 6003, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- SERVING AND PICTURE PART END -->
        <!-- WE ARE PEOPLE PART START -->
        <section id=""we_are_people"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""title w-100"">
                        <h4 class=""mb-3"">What Are People Saying</h4>
                    </div>
                </div>
                <div class=""testimonials"">
                    <div class=""row"">
                        <div class=""col-lg-4 col-md-6 col-sm-12 col-xs-12"">
                            <div class=""testimonial mr-3"">
                                <div class=""comment mb-4"">
                                    <h5>Perfect service</h5>
                                    <img class=""icon"" src=""img/quote.png"" alt="""">
                                    <div class=""stars mb-2"">
                                        <i");
            WriteLiteral(@" class=""fas fa-star colory""></i>
                                        <i class=""fas fa-star colory""></i>
                                        <i class=""fas fa-star""></i>
                                        <i class=""fas fa-star""></i>
                                        <i class=""fas fa-star""></i>
                                    </div>
                                    <p class=""m-0"">
                                        Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum
                                        has been the industry
                                    </p>
                                </div>
                                <div class=""bio mt-5 ml-3"" style=""display: flex;"">
                                    <div class=""image"">
                                        <img src=""img/bio1.jpg"" alt="""">
                                    </div>
                                    <div class=""titlee"">
                     ");
            WriteLiteral(@"                   <h6>John Mishlen</h6>
                                        <p>Executive CEO at company</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-6 col-sm-12 col-xs-12"">
                            <div class=""testimonial mr-3"">
                                <div class=""comment mb-4"">
                                    <h5>Competitive prices</h5>
                                    <img class=""icon"" src=""img/quote.png"" alt="""">
                                    <div class=""stars mb-2"">
                                        <i class=""fas fa-star colory""></i>
                                        <i class=""fas fa-star colory""></i>
                                        <i class=""fas fa-star colory""></i>
                                        <i class=""fas fa-star""></i>
                                        <i class=""fas");
            WriteLiteral(@" fa-star""></i>
                                    </div>
                                    <p class=""m-0"">
                                        Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum
                                        has been the industry
                                    </p>
                                </div>
                                <div class=""bio mt-5 ml-3"" style=""display: flex;"">
                                    <div class=""image"">
                                        <img src=""img/bio2.jpg"" alt="""">
                                    </div>
                                    <div class=""titlee"">
                                        <h6>Moe Sondi</h6>
                                        <p>Executive CEO at company</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""c");
            WriteLiteral(@"ol-lg-4 col-md-12 col-sm-12 col-xs-12"">
                            <div class=""testimonial mr-3"">
                                <div class=""comment mb-4"">
                                    <h5>Great agents</h5>
                                    <img class=""icon"" src=""img/quote.png"" alt="""">
                                    <div class=""stars mb-2"">
                                        <i class=""fas fa-star colory""></i>
                                        <i class=""fas fa-star colory""></i>
                                        <i class=""fas fa-star colory""></i>
                                        <i class=""fas fa-star colory""></i>
                                        <i class=""fas fa-star""></i>
                                    </div>
                                    <p class=""m-0"">
                                        Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum
                                        has been the industry");
            WriteLiteral(@"
                                    </p>
                                </div>
                                <div class=""bio mt-5 ml-3"" style=""display: flex;"">
                                    <div class=""image third_image"">
                                        <img src=""img/bio1.jpg"" alt="""">
                                    </div>
                                    <div class=""titlee"">
                                        <h6>Mandy Floss</h6>
                                        <p>Executive CEO at company</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- WE ARE PEOPLE PART END -->


    </main>

    <!-- MAIN PART END -->


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
