#pragma checksum "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "983abd66047e3d5ba0529b419c950bd9991d1745"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TopsyTurvyCakes.Pages.Pages__Layout), @"mvc.1.0.view", @"/Pages/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/_Layout.cshtml", typeof(TopsyTurvyCakes.Pages.Pages__Layout))]
namespace TopsyTurvyCakes.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_ViewImports.cshtml"
using TopsyTurvyCakes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"983abd66047e3d5ba0529b419c950bd9991d1745", @"/Pages/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2a9475420124357a8d7f22b775addacc3971e35", @"/Pages/_ViewImports.cshtml")]
    public class Pages__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6049272c011247898fa42db8bbe7cad0", async() => {
                BeginContext(31, 50, true);
                WriteLiteral("\r\n    <title>Topsy Turvy Cake Design</title>\r\n    ");
                EndContext();
                BeginContext(81, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4d4a11e3aa0b4d688da9ad853d74d76d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(124, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(130, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "20031e8738614b4db09f7dfcc508efa1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(178, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(187, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(189, 1973, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44f47e2ac0c049028cd5d4903494df2b", async() => {
                BeginContext(195, 674, true);
                WriteLiteral(@"
    <header class=""container site-header"">
        <div class=""row"">
            <h1 class=""main-logo""><a href=""/"">Topsy Turvy Cake Design</a></h1>
        </div>
        <div class=""row"">
            <nav class=""navbar"">
                <ul class=""nav nav-pills"">
                    <li><a href=""/About"">About</a></li>
                    <li><a href=""/Blog"">Blog</a></li>
                    <li><a class=""active"" href=""/"">Recipes</a></li>
                    <li><a href=""/Portfolio"">Portfolio</a></li>
                    <li><a href=""/Contact"">Contact</a></li>
                </ul>
                <ul class=""nav nav-pills"">
                    <li>
");
                EndContext();
#line 24 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                         if (!User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
                BeginContext(958, 64, true);
                WriteLiteral("                            <a href=\"/Account/Login\">Login</a>\r\n");
                EndContext();
#line 27 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(1106, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1134, 315, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e53ea86f70a44cd7a5a865dfcc9b173f", async() => {
                    BeginContext(1154, 288, true);
                    WriteLiteral(@"
                                <div class=""input-group"">
                                    <span>User Name</span>
                                    <button type=""submit"" class=""btn btn-primary"">Logout</button>
                                </div>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
                BeginContext(1449, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 36 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                        }

#line default
#line hidden
                BeginContext(1478, 115, true);
                WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </nav>\r\n        </div>\r\n        <div class=\"row\">\r\n");
                EndContext();
#line 43 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
             if (IsSectionDefined("Title"))
            {

#line default
#line hidden
                BeginContext(1653, 34, true);
                WriteLiteral("                <h2 class=\"title\">");
                EndContext();
                BeginContext(1688, 39, false);
#line 45 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                             Write(RenderSection("Title", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(1727, 7, true);
                WriteLiteral("</h2>\r\n");
                EndContext();
#line 46 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(1782, 34, true);
                WriteLiteral("                <h2 class=\"title\">");
                EndContext();
                BeginContext(1817, 17, false);
#line 49 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                             Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(1834, 7, true);
                WriteLiteral("</h2>\r\n");
                EndContext();
#line 50 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
            }

#line default
#line hidden
                BeginContext(1856, 81, true);
                WriteLiteral("        </div>\r\n    </header>\r\n    <div class=\"container body-content\">\r\n        ");
                EndContext();
                BeginContext(1938, 12, false);
#line 54 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1950, 131, true);
                WriteLiteral("\r\n        <hr />\r\n        <footer>\r\n            <div class=\"text-center\">\r\n                <span class=\"text-muted\">Last Rendered: ");
                EndContext();
                BeginContext(2082, 12, false);
#line 58 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                                                   Write(DateTime.Now);

#line default
#line hidden
                EndContext();
                BeginContext(2094, 61, true);
                WriteLiteral(" </span>\r\n            </div>\r\n        </footer>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2162, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IRecipesService RecipesService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591