#pragma checksum "C:\Users\vivek\source\repos\Bio-Data\Bio-Data\Views\FamilyDetailsView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a59c2a24250c35d0b330af03929b564edde3842"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FamilyDetailsView), @"mvc.1.0.view", @"/Views/FamilyDetailsView.cshtml")]
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
#line 1 "C:\Users\vivek\source\repos\Bio-Data\Bio-Data\Views\_ViewImports.cshtml"
using Bio_Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vivek\source\repos\Bio-Data\Bio-Data\Views\_ViewImports.cshtml"
using Bio_Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a59c2a24250c35d0b330af03929b564edde3842", @"/Views/FamilyDetailsView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a266632859f3479417f184c0ceefb9464cd6aee4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_FamilyDetailsView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio_Data.Models.Familydetails>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vivek\source\repos\Bio-Data\Bio-Data\Views\FamilyDetailsView.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Family Details</h1>\r\n<div>\r\n    <p>Father Name: ");
#nullable restore
#line 9 "C:\Users\vivek\source\repos\Bio-Data\Bio-Data\Views\FamilyDetailsView.cshtml"
               Write(Model.FatherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Father Occupation: ");
#nullable restore
#line 10 "C:\Users\vivek\source\repos\Bio-Data\Bio-Data\Views\FamilyDetailsView.cshtml"
                     Write(Model.FatherOccupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Mother Name: ");
#nullable restore
#line 11 "C:\Users\vivek\source\repos\Bio-Data\Bio-Data\Views\FamilyDetailsView.cshtml"
               Write(Model.MotherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Mother Occupation: ");
#nullable restore
#line 12 "C:\Users\vivek\source\repos\Bio-Data\Bio-Data\Views\FamilyDetailsView.cshtml"
                     Write(Model.MotherOccupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Elder Brother Name: ");
#nullable restore
#line 13 "C:\Users\vivek\source\repos\Bio-Data\Bio-Data\Views\FamilyDetailsView.cshtml"
                      Write(Model.ElderBrotherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Elder Brother Occupation: ");
#nullable restore
#line 14 "C:\Users\vivek\source\repos\Bio-Data\Bio-Data\Views\FamilyDetailsView.cshtml"
                            Write(Model.ElderBrotherOccupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Younger Brother Name: ");
#nullable restore
#line 15 "C:\Users\vivek\source\repos\Bio-Data\Bio-Data\Views\FamilyDetailsView.cshtml"
                        Write(Model.YoungerBrotherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Younger Brother Occupation: ");
#nullable restore
#line 16 "C:\Users\vivek\source\repos\Bio-Data\Bio-Data\Views\FamilyDetailsView.cshtml"
                              Write(Model.YoungerBrotherOccupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Elder Sister Name: ");
#nullable restore
#line 17 "C:\Users\vivek\source\repos\Bio-Data\Bio-Data\Views\FamilyDetailsView.cshtml"
                     Write(Model.ElderSisterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Elder Sister Occupation: ");
#nullable restore
#line 18 "C:\Users\vivek\source\repos\Bio-Data\Bio-Data\Views\FamilyDetailsView.cshtml"
                           Write(Model.ElderSisterOccupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Younger Sister Name: ");
#nullable restore
#line 19 "C:\Users\vivek\source\repos\Bio-Data\Bio-Data\Views\FamilyDetailsView.cshtml"
                       Write(Model.YoungerSisterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Younger Sister Occupation: ");
#nullable restore
#line 20 "C:\Users\vivek\source\repos\Bio-Data\Bio-Data\Views\FamilyDetailsView.cshtml"
                             Write(Model.YoungerSisterOccupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio_Data.Models.Familydetails> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591