#pragma checksum "C:\Users\James\Desktop\Bootcamp\MovieStateManagement\MovieStateManagement\Views\Movie\MovieForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed4862247f0bcdca76675836d090d9423191ad10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_MovieForm), @"mvc.1.0.view", @"/Views/Movie/MovieForm.cshtml")]
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
#nullable restore
#line 1 "C:\Users\James\Desktop\Bootcamp\MovieStateManagement\MovieStateManagement\Views\_ViewImports.cshtml"
using MovieStateManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\James\Desktop\Bootcamp\MovieStateManagement\MovieStateManagement\Views\_ViewImports.cshtml"
using MovieStateManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed4862247f0bcdca76675836d090d9423191ad10", @"/Views/Movie/MovieForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6367209062a91dd7e9159f1b6dceae6cfa9d1b7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_MovieForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table-primary\">\r\n    <tr>\r\n        <th>Title</th>\r\n        <th>Runtime</th>\r\n        <th>Add to Cart</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\James\Desktop\Bootcamp\MovieStateManagement\MovieStateManagement\Views\Movie\MovieForm.cshtml"
     foreach(var movie in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\James\Desktop\Bootcamp\MovieStateManagement\MovieStateManagement\Views\Movie\MovieForm.cshtml"
           Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\James\Desktop\Bootcamp\MovieStateManagement\MovieStateManagement\Views\Movie\MovieForm.cshtml"
           Write(movie.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 319, "\"", 356, 2);
            WriteAttributeValue("", 326, "/Movie/SelectMovie?name=", 326, 24, true);
#nullable restore
#line 16 "C:\Users\James\Desktop\Bootcamp\MovieStateManagement\MovieStateManagement\Views\Movie\MovieForm.cshtml"
WriteAttributeValue("", 350, movie, 350, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 19 "C:\Users\James\Desktop\Bootcamp\MovieStateManagement\MovieStateManagement\Views\Movie\MovieForm.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Movie/ListCart\">Cart</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591