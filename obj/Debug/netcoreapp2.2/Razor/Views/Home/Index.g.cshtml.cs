#pragma checksum "/Users/JoseAmesquita/Desktop/MvcApiCall/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a33e0437af24e3400ee5acbecb7384b0e9502507"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/JoseAmesquita/Desktop/MvcApiCall/Views/Home/Index.cshtml"
using MvcApiCall.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a33e0437af24e3400ee5acbecb7384b0e9502507", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 34, true);
            WriteLiteral("\r\n<h1>All Articles:</h1>\r\n\r\n<ol>\r\n");
            EndContext();
#line 6 "/Users/JoseAmesquita/Desktop/MvcApiCall/Views/Home/Index.cshtml"
 foreach (Article article in Model)
{

#line default
#line hidden
            BeginContext(101, 31, true);
            WriteLiteral("    <ul>\r\n        <li>Section: ");
            EndContext();
            BeginContext(133, 15, false);
#line 9 "/Users/JoseAmesquita/Desktop/MvcApiCall/Views/Home/Index.cshtml"
                Write(article.Section);

#line default
#line hidden
            EndContext();
            BeginContext(148, 26, true);
            WriteLiteral("</li>\r\n        <li>Title: ");
            EndContext();
            BeginContext(175, 13, false);
#line 10 "/Users/JoseAmesquita/Desktop/MvcApiCall/Views/Home/Index.cshtml"
              Write(article.Title);

#line default
#line hidden
            EndContext();
            BeginContext(188, 29, true);
            WriteLiteral("</li>\r\n        <li>Abstract: ");
            EndContext();
            BeginContext(218, 16, false);
#line 11 "/Users/JoseAmesquita/Desktop/MvcApiCall/Views/Home/Index.cshtml"
                 Write(article.Abstract);

#line default
#line hidden
            EndContext();
            BeginContext(234, 25, true);
            WriteLiteral(")</li>\r\n        <li>Url: ");
            EndContext();
            BeginContext(260, 11, false);
#line 12 "/Users/JoseAmesquita/Desktop/MvcApiCall/Views/Home/Index.cshtml"
            Write(article.Url);

#line default
#line hidden
            EndContext();
            BeginContext(271, 28, true);
            WriteLiteral(")</li>\r\n        <li>Byline: ");
            EndContext();
            BeginContext(300, 14, false);
#line 13 "/Users/JoseAmesquita/Desktop/MvcApiCall/Views/Home/Index.cshtml"
               Write(article.Byline);

#line default
#line hidden
            EndContext();
            BeginContext(314, 29, true);
            WriteLiteral(")</li>\r\n    </ul>\r\n    <br>\r\n");
            EndContext();
#line 16 "/Users/JoseAmesquita/Desktop/MvcApiCall/Views/Home/Index.cshtml"
}

#line default
#line hidden
            BeginContext(346, 7, true);
            WriteLiteral("</ol>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
