#pragma checksum "D:\Howl\Howl\Pages\P\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e8e563b02f87ce7fc145d7bf0b5aa9d49d63aa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Howl.Pages.P.Pages_P_Admin), @"mvc.1.0.razor-page", @"/Pages/P/Admin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e8e563b02f87ce7fc145d7bf0b5aa9d49d63aa3", @"/Pages/P/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d276b2a0dad9b158fb9e55c80ded8d1f0080a7bc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_P_Admin : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Admin Page</h1>

<button class=""btn btn-primary"" onclick=""$('#Album').toggle()"">See Albums</button>
<button class=""btn btn-primary"" onclick=""$('#Review').toggle()"">See Reviews</button>
<button class=""btn btn-primary"" onclick=""$('#User').toggle()"">See Users</button>

<div style=""display:none;"" id=""Album"">
    <h2>See all albums</h2>
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>Album ID</th>
                <th>Album Title</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "D:\Howl\Howl\Pages\P\Admin.cshtml"
             if (Model.Albums.Count() != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Howl\Howl\Pages\P\Admin.cshtml"
                 foreach (var a in Model.Albums)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 26 "D:\Howl\Howl\Pages\P\Admin.cshtml"
                       Write(a.AlbumID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "D:\Howl\Howl\Pages\P\Admin.cshtml"
                       Write(a.AlbumTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 29 "D:\Howl\Howl\Pages\P\Admin.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Howl\Howl\Pages\P\Admin.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>
<div style=""display:none;"" id=""Review"">
    <h2>See all reviews</h2>
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>Review ID</th>
                <th>Review Title</th>
                <th>Review User</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 45 "D:\Howl\Howl\Pages\P\Admin.cshtml"
             if (Model.Reviews.Count() != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\Howl\Howl\Pages\P\Admin.cshtml"
                 foreach (var r in Model.Reviews)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 50 "D:\Howl\Howl\Pages\P\Admin.cshtml"
                       Write(r.ReviewID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 51 "D:\Howl\Howl\Pages\P\Admin.cshtml"
                       Write(r.ReviewTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 52 "D:\Howl\Howl\Pages\P\Admin.cshtml"
                       Write(r.User.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 54 "D:\Howl\Howl\Pages\P\Admin.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\Howl\Howl\Pages\P\Admin.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>
<div style=""display:none;"" id=""User"">
    <h2>See all users</h2>
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>Username</th>
                <th>Password</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 69 "D:\Howl\Howl\Pages\P\Admin.cshtml"
             if (Model.Users.Count() != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "D:\Howl\Howl\Pages\P\Admin.cshtml"
                 foreach (var u in Model.Users)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 74 "D:\Howl\Howl\Pages\P\Admin.cshtml"
                       Write(u.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 75 "D:\Howl\Howl\Pages\P\Admin.cshtml"
                       Write(u.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 77 "D:\Howl\Howl\Pages\P\Admin.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\Howl\Howl\Pages\P\Admin.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Howl.Pages.P.AdminModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Howl.Pages.P.AdminModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Howl.Pages.P.AdminModel>)PageContext?.ViewData;
        public Howl.Pages.P.AdminModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
