#pragma checksum "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bf085229018656a144ab028e8dee2232a34b737"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_About_Default), @"mvc.1.0.view", @"/Views/Shared/Components/About/Default.cshtml")]
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
#line 3 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using Cv.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using Cv.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using Cv.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using Cv.Domain.AppCode.Infracture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using Cv.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using Cv.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bf085229018656a144ab028e8dee2232a34b737", @"/Views/Shared/Components/About/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a236855dc37ee97ad21d0976099ac55c474beb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_About_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<About>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<ul class=\"personal-info\">\r\n");
#nullable restore
#line 5 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml"
     foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <p> <span> Name</span>");
#nullable restore
#line 8 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml"
                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n            <li>\r\n                <p> <span> Age</span>");
#nullable restore
#line 11 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml"
                                Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n            <li>\r\n                <p>\r\n");
#nullable restore
#line 15 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml"
                     if (@item.Location == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span></span>\r\n");
#nullable restore
#line 18 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span> Location</span>\r\n");
#nullable restore
#line 22 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 24 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml"
               Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n\r\n            </li>\r\n            <li>\r\n                <p> <span> Experience</span>");
#nullable restore
#line 29 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml"
                                       Write(item.Experince);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            </li>\r\n            <li>\r\n                <p> <span> Degree</span> ");
#nullable restore
#line 32 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml"
                                    Write(item.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n            <li>\r\n                <p> <span> Career Level</span>");
#nullable restore
#line 35 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml"
                                         Write(item.CareerLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n            <li>\r\n                <p> <span> Phone</span>");
#nullable restore
#line 38 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml"
                                  Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n            <li>\r\n                <p> <span> FAX</span>");
#nullable restore
#line 41 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml"
                                Write(item.Fax);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            </li>\r\n            <li>\r\n                <p> <span> E-mail</span> <a href=\"#.\"></a> ");
#nullable restore
#line 44 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml"
                                                      Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n            <li>\r\n                <p>\r\n");
#nullable restore
#line 48 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml"
                     if (@item.Website == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span></span>\r\n");
#nullable restore
#line 51 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span> Website</span>\r\n");
#nullable restore
#line 55 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <a href=\"#.\"></a>");
#nullable restore
#line 57 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml"
                                Write(item.Website);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </li>\r\n");
#nullable restore
#line 60 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\About\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<About>> Html { get; private set; }
    }
}
#pragma warning restore 1591
