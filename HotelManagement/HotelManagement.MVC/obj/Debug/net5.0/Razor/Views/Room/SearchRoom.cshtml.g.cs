#pragma checksum "/Users/rufengma/Documents/Job/Antra/Final_RM/HotelManagement/HotelManagement.MVC/Views/Room/SearchRoom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15d7c97d71ecc9f6496ccbf3c11da92e90aaaeaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_SearchRoom), @"mvc.1.0.view", @"/Views/Room/SearchRoom.cshtml")]
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
#line 1 "/Users/rufengma/Documents/Job/Antra/Final_RM/HotelManagement/HotelManagement.MVC/Views/_ViewImports.cshtml"
using HotelManagement.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/rufengma/Documents/Job/Antra/Final_RM/HotelManagement/HotelManagement.MVC/Views/_ViewImports.cshtml"
using HotelManagement.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15d7c97d71ecc9f6496ccbf3c11da92e90aaaeaf", @"/Views/Room/SearchRoom.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbb92b12bee4616d3ed648b43f2c0bf5a7c9d202", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_SearchRoom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelManagement.Core.Entities.Room>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/rufengma/Documents/Job/Antra/Final_RM/HotelManagement/HotelManagement.MVC/Views/Room/SearchRoom.cshtml"
  
    ViewData["Title"] = "Room By Id";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h5>Room with Id = ");
#nullable restore
#line 7 "/Users/rufengma/Documents/Job/Antra/Final_RM/HotelManagement/HotelManagement.MVC/Views/Room/SearchRoom.cshtml"
              Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n\n<table class=\"table\">\n    <tbody>\n\n        <tr>\n            <td>ID</td>\n            <td>Room Type Code</td>\n            <td>Room Status</td>\n        </tr>\n\n        <tr>\n            <td>");
#nullable restore
#line 19 "/Users/rufengma/Documents/Job/Antra/Final_RM/HotelManagement/HotelManagement.MVC/Views/Room/SearchRoom.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 20 "/Users/rufengma/Documents/Job/Antra/Final_RM/HotelManagement/HotelManagement.MVC/Views/Room/SearchRoom.cshtml"
           Write(Model.RTCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 21 "/Users/rufengma/Documents/Job/Antra/Final_RM/HotelManagement/HotelManagement.MVC/Views/Room/SearchRoom.cshtml"
           Write(Model.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelManagement.Core.Entities.Room> Html { get; private set; }
    }
}
#pragma warning restore 1591
