#pragma checksum "C:\Users\Amit-pc\Downloads\Customer-Order-Website-master\Customer-Order-Website-master\BoatOrder\Views\Customer\OwnerloggedIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e696eaed4ff57f7d6c8e9805792411d44b10ea68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_OwnerloggedIn), @"mvc.1.0.view", @"/Views/Customer/OwnerloggedIn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e696eaed4ff57f7d6c8e9805792411d44b10ea68", @"/Views/Customer/OwnerloggedIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78ba1b2ebb4aba3707da36e36f813cdc0fcd2082", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_OwnerloggedIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataLayer.Customer>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Amit-pc\Downloads\Customer-Order-Website-master\Customer-Order-Website-master\BoatOrder\Views\Customer\OwnerloggedIn.cshtml"
  
    ViewData["Title"] = "OwnerloggedIn";
    Layout = "~/Views/Customer/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <h2>\r\n        Welcome ");
#nullable restore
#line 11 "C:\Users\Amit-pc\Downloads\Customer-Order-Website-master\Customer-Order-Website-master\BoatOrder\Views\Customer\OwnerloggedIn.cshtml"
           Write(Model.EmailID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h2>\r\n\r\n    <div class=\"container\">\r\n      \r\n        <div class=\"row\">\r\n            <div class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 18 "C:\Users\Amit-pc\Downloads\Customer-Order-Website-master\Customer-Order-Website-master\BoatOrder\Views\Customer\OwnerloggedIn.cshtml"
           Write(Html.ActionLink("View All Orders", "ViewAllOrders", "Owner", null, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n           \r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataLayer.Customer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
