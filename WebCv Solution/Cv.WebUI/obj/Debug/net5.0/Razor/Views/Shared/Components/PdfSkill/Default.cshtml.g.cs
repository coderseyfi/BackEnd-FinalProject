#pragma checksum "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e496c479ce98257fd89892c3475f2380df65c37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PdfSkill_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PdfSkill/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e496c479ce98257fd89892c3475f2380df65c37", @"/Views/Shared/Components/PdfSkill/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a236855dc37ee97ad21d0976099ac55c474beb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PdfSkill_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ResumeSkill>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
     if(item.View == null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"media-left\">\r\n        <span class=\"sun\">");
#nullable restore
#line 8 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
                     Write(item.ResumeCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n    <div class=\"panel-group accordion\" id=\"accordion5\">\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-4\">\r\n                    ");
#nullable restore
#line 14 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-8\">\r\n                    ");
#nullable restore
#line 17 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
               Write(item.Description.ToPlainText());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 22 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
    }
    else if(item.View != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"ethical\">\r\n        <h6>");
#nullable restore
#line 25 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
       Write(item.ResumeCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <a href=\"#.\">");
#nullable restore
#line 26 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </div>\r\n");
#nullable restore
#line 28 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ResumeSkill>> Html { get; private set; }
    }
}
#pragma warning restore 1591
