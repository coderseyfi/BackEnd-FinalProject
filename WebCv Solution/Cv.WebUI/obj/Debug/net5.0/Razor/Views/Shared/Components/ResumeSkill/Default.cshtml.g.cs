#pragma checksum "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66acd3621a1754f0bee9ef462393fc5558e4cf86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ResumeSkill_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ResumeSkill/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66acd3621a1754f0bee9ef462393fc5558e4cf86", @"/Views/Shared/Components/ResumeSkill/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a236855dc37ee97ad21d0976099ac55c474beb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ResumeSkill_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ResumeSkill>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
     if(item.View == null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h6>");
#nullable restore
#line 7 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
   Write(item.ResumeCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
            WriteLiteral(@"    <div class=""panel-group accordion"" id=""accordion5"">
        <div class=""panel panel-default"">
            <div class=""row"">
                <div class=""col-sm-4"">
                    <!-- PANEL HEADING -->
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">
                            <a data-toggle=""collapse""
                           data-parent=""#accordion5""
                           href=""#collapseOne5"">
                                ");
#nullable restore
#line 19 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </a>
                        </h4>
                    </div>
                </div>

                <div class=""col-sm-8"">
                    <div class=""progress"">
                        <div class=""progress-bar""
                         role=""progressbar""
                         aria-valuenow=""80""
                         aria-valuemin=""0""
                         aria-valuemax=""100""");
            BeginWriteAttribute("style", "\r\n                         style=\"", 1090, "\"", 1143, 3);
            WriteAttributeValue("", 1124, "width:", 1124, 6, true);
#nullable restore
#line 32 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
WriteAttributeValue(" ", 1130, item.Level, 1131, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1142, "%", 1142, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <span class=\"sr-only\">");
#nullable restore
#line 33 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
                                             Write(item.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"% Complete</span>
                        </div>
                    </div>

                    <!-- Skillls Bars -->
                    <!-- Skillls Text -->
                    <div id=""collapseOne5""
                     class=""panel-collapse collapse in"">
                        <div class=""panel-body"">
                            <p>
                                ");
#nullable restore
#line 43 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
                           Write(item.Description.ToPlainText());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 52 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
    }
    else if(item.View != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"ethical\">\r\n        <h6>");
#nullable restore
#line 55 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
       Write(item.ResumeCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <a href=\"#.\">");
#nullable restore
#line 56 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </div>\r\n");
#nullable restore
#line 58 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
     
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