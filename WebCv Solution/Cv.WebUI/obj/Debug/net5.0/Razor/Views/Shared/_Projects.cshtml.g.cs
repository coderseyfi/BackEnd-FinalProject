#pragma checksum "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\_Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0abbcd4379e911e87a07abfe5cba3daf3018417"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Projects), @"mvc.1.0.view", @"/Views/Shared/_Projects.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0abbcd4379e911e87a07abfe5cba3daf3018417", @"/Views/Shared/_Projects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a236855dc37ee97ad21d0976099ac55c474beb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Projects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PortfolioViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"Container\" class=\"item-space row col-3\" style=\"height: 0px; perspective: 3000px; perspective-origin: 50% 50%; transition: height 600ms ease 0s;\">\r\n\r\n");
#nullable restore
#line 5 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\_Projects.cshtml"
     foreach (var item in Model.Projects)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <article");
            BeginWriteAttribute("class", " class=\"", 253, "\"", 305, 4);
            WriteAttributeValue("", 261, "portfolio-item", 261, 14, true);
            WriteAttributeValue(" ", 275, "mix", 276, 4, true);
            WriteAttributeValue(" ", 279, "c-", 280, 3, true);
#nullable restore
#line 7 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\_Projects.cshtml"
WriteAttributeValue("", 282, item.ProjectCategoryId, 282, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-inter-pos-x=""0"" data-inter-pos-y=""0"" data-final-pos-x=""0"" data-final-pos-y=""0"" style=""transition: all 600ms ease 0ms, opacity 600ms linear; display: inline-block; transform: translate(0px, 0px);"" data-bound=""true"">
            <div class=""portfolio-image"">
                <a href=""#.""> <img class=""img-responsive"" alt=""Open Imagination""");
            BeginWriteAttribute("src", " src=\"", 651, "\"", 688, 2);
            WriteAttributeValue("", 657, "/uploads/images/", 657, 16, true);
#nullable restore
#line 9 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\_Projects.cshtml"
WriteAttributeValue("", 673, item.ImagePath, 673, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> </a>\r\n                <div class=\"portfolio-overlay style-4\">\r\n                    <div class=\"detail-info\">\r\n                        <div class=\"position-center-center\">\r\n                            <h3 class=\"no-margin\">");
#nullable restore
#line 13 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\_Projects.cshtml"
                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <span><a href=\"#.\">");
#nullable restore
#line 14 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\_Projects.cshtml"
                                          Write(item.ProjectCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span><a");
            BeginWriteAttribute("href", " href=\"", 1016, "\"", 1033, 1);
#nullable restore
#line 14 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\_Projects.cshtml"
WriteAttributeValue("", 1023, item.Link, 1023, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" .\" class=\"go\"><i class=\"fa fa-link\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </article>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0abbcd4379e911e87a07abfe5cba3daf30184177424", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 20 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\_Projects.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.ProjectCategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 21 "D:\Academy p513\Asp.Net Final Project\WebCv Solution\Cv.WebUI\Views\Shared\_Projects.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PortfolioViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
