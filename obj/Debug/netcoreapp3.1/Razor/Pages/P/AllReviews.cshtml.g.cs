#pragma checksum "D:\Howl\Howl\Pages\P\AllReviews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d75b9be7911b9432f438482e3182cdb80b327611"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Howl.Pages.P.Pages_P_AllReviews), @"mvc.1.0.razor-page", @"/Pages/P/AllReviews.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d75b9be7911b9432f438482e3182cdb80b327611", @"/Pages/P/AllReviews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d276b2a0dad9b158fb9e55c80ded8d1f0080a7bc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_P_AllReviews : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"d-inline\">\r\n    <h3 class=\"text-info\">Newest reviews</h3>\r\n");
#nullable restore
#line 7 "D:\Howl\Howl\Pages\P\AllReviews.cshtml"
     if (Model.Reviews.Count != 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Howl\Howl\Pages\P\AllReviews.cshtml"
         foreach (var rv in Model.Reviews)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"text-light bg-dark card mb-5\">\r\n            <div class=\"card-header\">\r\n                <h5 class=\"text-white card-title d-inline\">");
#nullable restore
#line 13 "D:\Howl\Howl\Pages\P\AllReviews.cshtml"
                                                      Write(rv.Album.AlbumTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <div class=\"d-inline float-right\">\r\n");
            WriteLiteral("                    <div>\r\n");
#nullable restore
#line 17 "D:\Howl\Howl\Pages\P\AllReviews.cshtml"
                         for (int i = 0; i < rv.StarRating; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa fa-star\" aria-hidden=\"true\"></i>\r\n");
#nullable restore
#line 20 "D:\Howl\Howl\Pages\P\AllReviews.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <img class=\"float-right\" height=\"150\" width=\"150\"");
            BeginWriteAttribute("src", " src=\"", 994, "\"", 1018, 1);
#nullable restore
#line 26 "D:\Howl\Howl\Pages\P\AllReviews.cshtml"
WriteAttributeValue("", 1000, rv.Album.CoverUrl, 1000, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <p class=\"text-white\"><strong>");
#nullable restore
#line 27 "D:\Howl\Howl\Pages\P\AllReviews.cshtml"
                                         Write(rv.ReviewTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                <p class=\"card-text text-light\">");
#nullable restore
#line 28 "D:\Howl\Howl\Pages\P\AllReviews.cshtml"
                                           Write(rv.ReviewText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div>\r\n                <div class=\"d-inline\">\r\n                    <p class=\"card-text text-white d-inline col mr-1\"><em>");
#nullable restore
#line 32 "D:\Howl\Howl\Pages\P\AllReviews.cshtml"
                                                                     Write(rv.User.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em></p>\r\n                    <p class=\" card-text text-info d-inline float-right mr-2\">");
#nullable restore
#line 33 "D:\Howl\Howl\Pages\P\AllReviews.cshtml"
                                                                         Write(rv.PublishDateTime.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 37 "D:\Howl\Howl\Pages\P\AllReviews.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Howl\Howl\Pages\P\AllReviews.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Howl.Pages.P.AllReviewsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Howl.Pages.P.AllReviewsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Howl.Pages.P.AllReviewsModel>)PageContext?.ViewData;
        public Howl.Pages.P.AllReviewsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
