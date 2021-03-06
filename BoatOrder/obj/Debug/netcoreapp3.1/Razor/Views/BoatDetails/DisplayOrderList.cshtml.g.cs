#pragma checksum "C:\Users\Amit-pc\Downloads\Customer-Order-Website-master\Customer-Order-Website-master\BoatOrder\Views\BoatDetails\DisplayOrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15a2ab65c56692e61c333990257bfe85d48dbab9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BoatDetails_DisplayOrderList), @"mvc.1.0.view", @"/Views/BoatDetails/DisplayOrderList.cshtml")]
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
#line 1 "C:\Users\Amit-pc\Downloads\Customer-Order-Website-master\Customer-Order-Website-master\BoatOrder\Views\_ViewImports.cshtml"
using BoatOrder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Amit-pc\Downloads\Customer-Order-Website-master\Customer-Order-Website-master\BoatOrder\Views\_ViewImports.cshtml"
using BoatOrder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15a2ab65c56692e61c333990257bfe85d48dbab9", @"/Views/BoatDetails/DisplayOrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78ba1b2ebb4aba3707da36e36f813cdc0fcd2082", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BoatDetails_DisplayOrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataLayer.BoatDetails>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Amit-pc\Downloads\Customer-Order-Website-master\Customer-Order-Website-master\BoatOrder\Views\BoatDetails\DisplayOrderList.cshtml"
  
    ViewData["Title"] = "DisplayOrderList";
    Layout = "~/Views/Users/Shared/_Layout.cshtml";
   

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n\r\n    <p> <b> Your Orders List: </b>  </p>\r\n    <table class=\"table table-striped table-dark p-lg-5\">\r\n        <thead class=\"p-5\">\r\n\r\n            \r\n            <tr>\r\n");
            WriteLiteral("                <th> ");
#nullable restore
#line 19 "C:\Users\Amit-pc\Downloads\Customer-Order-Website-master\Customer-Order-Website-master\BoatOrder\Views\BoatDetails\DisplayOrderList.cshtml"
                Write(Html.DisplayName("Items"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th> ");
#nullable restore
#line 20 "C:\Users\Amit-pc\Downloads\Customer-Order-Website-master\Customer-Order-Website-master\BoatOrder\Views\BoatDetails\DisplayOrderList.cshtml"
                Write(Html.DisplayName("Order Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th> ");
#nullable restore
#line 21 "C:\Users\Amit-pc\Downloads\Customer-Order-Website-master\Customer-Order-Website-master\BoatOrder\Views\BoatDetails\DisplayOrderList.cshtml"
                Write(Html.DisplayName("Shipment Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th> ");
#nullable restore
#line 22 "C:\Users\Amit-pc\Downloads\Customer-Order-Website-master\Customer-Order-Website-master\BoatOrder\Views\BoatDetails\DisplayOrderList.cshtml"
                Write(Html.DisplayName("Delete Order"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n            </tr>\r\n        </thead>\r\n\r\n\r\n");
#nullable restore
#line 28 "C:\Users\Amit-pc\Downloads\Customer-Order-Website-master\Customer-Order-Website-master\BoatOrder\Views\BoatDetails\DisplayOrderList.cshtml"
         foreach (var order in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tbody>\r\n                <tr>\r\n\r\n");
            WriteLiteral("                    <td>");
#nullable restore
#line 34 "C:\Users\Amit-pc\Downloads\Customer-Order-Website-master\Customer-Order-Website-master\BoatOrder\Views\BoatDetails\DisplayOrderList.cshtml"
                   Write(Html.DisplayFor(m => order.Boa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 35 "C:\Users\Amit-pc\Downloads\Customer-Order-Website-master\Customer-Order-Website-master\BoatOrder\Views\BoatDetails\DisplayOrderList.cshtml"
                    Write(Html.DisplayFor(m => order.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 36 "C:\Users\Amit-pc\Downloads\Customer-Order-Website-master\Customer-Order-Website-master\BoatOrder\Views\BoatDetails\DisplayOrderList.cshtml"
                    Write(Html.DisplayFor(m => order.ShipmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>  ");
#nullable restore
#line 37 "C:\Users\Amit-pc\Downloads\Customer-Order-Website-master\Customer-Order-Website-master\BoatOrder\Views\BoatDetails\DisplayOrderList.cshtml"
                     Write(Html.ActionLink("Delete", "DeleteOrder", "Order", new { orderID = order.ID }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                  \r\n                </tr>\r\n            </tbody>\r\n");
#nullable restore
#line 41 "C:\Users\Amit-pc\Downloads\Customer-Order-Website-master\Customer-Order-Website-master\BoatOrder\Views\BoatDetails\DisplayOrderList.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n   \r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataLayer.BoatDetails> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
