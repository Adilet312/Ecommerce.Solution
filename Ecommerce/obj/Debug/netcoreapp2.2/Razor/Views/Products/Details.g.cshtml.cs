#pragma checksum "/home/amt/Desktop/eCommerce.Solution/Ecommerce/Views/Products/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afd98b040143b85cfc5c6e1fcb2d2cd315ade4ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Details.cshtml", typeof(AspNetCore.Views_Products_Details))]
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
#line 1 "/home/amt/Desktop/eCommerce.Solution/Ecommerce/Views/_ViewImports.cshtml"
using Ecommerce;

#line default
#line hidden
#line 2 "/home/amt/Desktop/eCommerce.Solution/Ecommerce/Views/_ViewImports.cshtml"
using Ecommerce.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afd98b040143b85cfc5c6e1fcb2d2cd315ade4ff", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbcd7c65731fc074a835809e73fcf2cf9014c29", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ecommerce.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 3, true);
            WriteLiteral("  \n");
            EndContext();
#line 2 "/home/amt/Desktop/eCommerce.Solution/Ecommerce/Views/Products/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(63, 32, true);
            WriteLiteral("\n<h2>Flavor Details</h2>\n<hr />\n");
            EndContext();
#line 10 "/home/amt/Desktop/eCommerce.Solution/Ecommerce/Views/Products/Details.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(123, 6, true);
            WriteLiteral("  <h3>");
            EndContext();
            BeginContext(130, 45, false);
#line 12 "/home/amt/Desktop/eCommerce.Solution/Ecommerce/Views/Products/Details.cshtml"
 Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(175, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(178, 41, false);
#line 12 "/home/amt/Desktop/eCommerce.Solution/Ecommerce/Views/Products/Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(219, 13, true);
            WriteLiteral("</h3>\n   <h3>");
            EndContext();
            BeginContext(233, 41, false);
#line 13 "/home/amt/Desktop/eCommerce.Solution/Ecommerce/Views/Products/Details.cshtml"
  Write(Html.TextBoxFor(model => model.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(274, 75, true);
            WriteLiteral("</h3>\n  <input type=\"submit\" value=\"Add to cart\" class=\"btn btn-primary\"/>\n");
            EndContext();
#line 15 "/home/amt/Desktop/eCommerce.Solution/Ecommerce/Views/Products/Details.cshtml"

}

#line default
#line hidden
            BeginContext(352, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecommerce.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
