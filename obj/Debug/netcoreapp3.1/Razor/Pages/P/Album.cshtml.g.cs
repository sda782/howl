#pragma checksum "D:\Howl\Howl\Pages\P\Album.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "369246e934ed1ca545b438097abcb149aae36a83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Howl.Pages.P.Pages_P_Album), @"mvc.1.0.razor-page", @"/Pages/P/Album.cshtml")]
namespace Howl.Pages.P
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Howl\Howl\Pages\_ViewImports.cshtml"
using Howl;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"369246e934ed1ca545b438097abcb149aae36a83", @"/Pages/P/Album.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d276b2a0dad9b158fb9e55c80ded8d1f0080a7bc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_P_Album : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "WriteReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("<div class=\"bg-dark float-left\">\r\n    <img height=\"300\" width=\"300\"");
            BeginWriteAttribute("src", " src=\"", 113, "\"", 140, 1);
#nullable restore
#line 6 "D:\Howl\Howl\Pages\P\Album.cshtml"
WriteAttributeValue("", 119, Model.Album.CoverUrl, 119, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <p class=\"card-text float-left text-light d-inline\">Rating:</p>\r\n            <p class=\"card-text float-right text-info d-inline\">");
#nullable restore
#line 10 "D:\Howl\Howl\Pages\P\Album.cshtml"
                                                           Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <p class=\"card-text float-left text-light d-inline\">Title:</p>\r\n            <p class=\"card-text float-right text-info d-inline\">");
#nullable restore
#line 14 "D:\Howl\Howl\Pages\P\Album.cshtml"
                                                           Write(Model.Album.AlbumTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <p class=\"card-text float-left text-light d-inline\">Artist:</p>\r\n            <p class=\"card-text float-right text-info d-inline\">");
#nullable restore
#line 18 "D:\Howl\Howl\Pages\P\Album.cshtml"
                                                           Write(Model.Album.Artist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <p class=\"card-text float-left text-light d-inline\">Released:</p>\r\n            <p class=\"card-text float-right text-info d-inline\">");
#nullable restore
#line 22 "D:\Howl\Howl\Pages\P\Album.cshtml"
                                                           Write(Model.Album.Year.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <p class=\"card-text float-left text-light d-inline\">Genre:</p>\r\n            <p class=\"card-text float-right text-info d-inline\">");
#nullable restore
#line 26 "D:\Howl\Howl\Pages\P\Album.cshtml"
                                                           Write(Model.Album.MusicGenre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"float-right w-50\">\r\n    <h3 class=\"text-light\">Reviews</h3>\r\n");
#nullable restore
#line 32 "D:\Howl\Howl\Pages\P\Album.cshtml"
     if (HttpContext.Request.Cookies.ContainsKey("UserName"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "369246e934ed1ca545b438097abcb149aae36a836424", async() => {
                WriteLiteral("Write review");
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
#nullable restore
#line 34 "D:\Howl\Howl\Pages\P\Album.cshtml"
                                    WriteLiteral(Model.Album.AlbumID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n        <br />\r\n");
#nullable restore
#line 36 "D:\Howl\Howl\Pages\P\Album.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 38 "D:\Howl\Howl\Pages\P\Album.cshtml"
     if (Model.Reviews.Count() != 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\Howl\Howl\Pages\P\Album.cshtml"
         foreach (var rv in Model.Reviews)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"bg-dark w-100 card mb-5\">\r\n                <div class=\"card-header\">\r\n");
            WriteLiteral("                    <p class=\"card-text d-inline\"><strong>");
#nullable restore
#line 45 "D:\Howl\Howl\Pages\P\Album.cshtml"
                                                     Write(rv.ReviewTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                    <div class=\"d-inline\">\r\n");
#nullable restore
#line 47 "D:\Howl\Howl\Pages\P\Album.cshtml"
                         for (int i = 0; i < rv.StarRating; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa fa-star\" aria-hidden=\"true\"></i>\r\n");
#nullable restore
#line 50 "D:\Howl\Howl\Pages\P\Album.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <p class=\"card-text text-light\">");
#nullable restore
#line 54 "D:\Howl\Howl\Pages\P\Album.cshtml"
                                               Write(rv.ReviewText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div>\r\n                    <div class=\"d-inline\">\r\n                        <p class=\"card-text text-white d-inline col mr-1\"><em>");
#nullable restore
#line 58 "D:\Howl\Howl\Pages\P\Album.cshtml"
                                                                         Write(rv.User.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em></p>\r\n                        <p class=\" card-text text-info d-inline float-right mr-2\">");
#nullable restore
#line 59 "D:\Howl\Howl\Pages\P\Album.cshtml"
                                                                             Write(rv.PublishDateTime.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 63 "D:\Howl\Howl\Pages\P\Album.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "D:\Howl\Howl\Pages\P\Album.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Howl.Pages.P.AlbumModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Howl.Pages.P.AlbumModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Howl.Pages.P.AlbumModel>)PageContext?.ViewData;
        public Howl.Pages.P.AlbumModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591