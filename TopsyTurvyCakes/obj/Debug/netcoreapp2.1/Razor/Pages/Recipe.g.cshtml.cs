#pragma checksum "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2459ab1d92e0988f30981dc8a5e6b2973a2caca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TopsyTurvyCakes.Pages.Pages_Recipe), @"mvc.1.0.razor-page", @"/Pages/Recipe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Recipe.cshtml", typeof(TopsyTurvyCakes.Pages.Pages_Recipe), @"{id}")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2459ab1d92e0988f30981dc8a5e6b2973a2caca", @"/Pages/Recipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2a9475420124357a8d7f22b775addacc3971e35", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Recipe : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Admin/AddEditRecipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("add-recipe btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
  
    var id = long.Parse((string)RouteData.Values["id"]);
    var recipesService = new RecipesService();
    var recipe = await recipesService.FindAsync(id);
    ViewData["Title"] = recipe.Name;

#line default
#line hidden
            DefineSection("Title", async() => {
                BeginContext(238, 24, true);
                WriteLiteral("\r\n    <h2 class=\"title\">");
                EndContext();
                BeginContext(263, 11, false);
#line 10 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
                 Write(recipe.Name);

#line default
#line hidden
                EndContext();
                BeginContext(274, 11, true);
                WriteLiteral("</h2>\r\n    ");
                EndContext();
                BeginContext(285, 110, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bfbb85def174a8c97438108a519d698", async() => {
                    BeginContext(380, 11, true);
                    WriteLiteral("Edit Recipe");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 11 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
                                        WriteLiteral(recipe.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(395, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(400, 196, true);
            WriteLiteral("<div class=\"container\">\r\n\r\n    <div class=\"row recipe\">\r\n\r\n        <div class=\"col-md-8\">\r\n\r\n            <div class=\"col-md-12\">\r\n\r\n                <span class=\"description\">\r\n                    ");
            EndContext();
            BeginContext(597, 18, false);
#line 22 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
               Write(recipe.Description);

#line default
#line hidden
            EndContext();
            BeginContext(615, 183, true);
            WriteLiteral("\r\n                </span>\r\n\r\n                <hr />\r\n            </div>\r\n\r\n            <div class=\"ingredients col-md-4\">\r\n                <h4>Ingredients</h4>\r\n                <ul>\r\n");
            EndContext();
#line 31 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
                     foreach (var ingredient in recipe.IngredientsList)
                    {

#line default
#line hidden
            BeginContext(894, 28, true);
            WriteLiteral("                        <li>");
            EndContext();
            BeginContext(923, 10, false);
#line 33 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
                       Write(ingredient);

#line default
#line hidden
            EndContext();
            BeginContext(933, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 34 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
                    }

#line default
#line hidden
            BeginContext(963, 45, true);
            WriteLiteral("\r\n                </ul>\r\n            </div>\r\n");
            EndContext();
#line 38 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
             foreach (var step in recipe.DirectionsList)
            {

#line default
#line hidden
            BeginContext(1081, 146, true);
            WriteLiteral("                <div class=\"directions col-md-8\">\r\n                    <h4>Directions</h4>\r\n                    <ol>\r\n                        <li>");
            EndContext();
            BeginContext(1228, 4, false);
#line 43 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
                       Write(step);

#line default
#line hidden
            EndContext();
            BeginContext(1232, 58, true);
            WriteLiteral("</li>\r\n                    </ol>\r\n                </div>\r\n");
            EndContext();
#line 46 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"

            }

#line default
#line hidden
            BeginContext(1307, 105, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-md-4 text-right\">\r\n            <img class=\"img img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1412, "\"", 1445, 1);
#line 52 "C:\Users\gprot\Desktop\CS4790\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
WriteAttributeValue("", 1418, recipe.GetInlineImageSrc(), 1418, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1446, 43, true);
            WriteLiteral(" />\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Recipe> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Recipe> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Recipe>)PageContext?.ViewData;
        public Pages_Recipe Model => ViewData.Model;
    }
}
#pragma warning restore 1591
