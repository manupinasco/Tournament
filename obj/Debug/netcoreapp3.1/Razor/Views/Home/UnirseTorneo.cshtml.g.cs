#pragma checksum "C:\ORT\SEGUNDO CUATRIMESTRE\PP I Programación en Nuevas\TP_FINAL_NT\TP_NT\Views\Home\UnirseTorneo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5bb1f289d18b806b31b866c1e9574b4d175485c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UnirseTorneo), @"mvc.1.0.view", @"/Views/Home/UnirseTorneo.cshtml")]
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
#line 1 "C:\ORT\SEGUNDO CUATRIMESTRE\PP I Programación en Nuevas\TP_FINAL_NT\TP_NT\Views\_ViewImports.cshtml"
using TP_NT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ORT\SEGUNDO CUATRIMESTRE\PP I Programación en Nuevas\TP_FINAL_NT\TP_NT\Views\_ViewImports.cshtml"
using TP_NT.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ORT\SEGUNDO CUATRIMESTRE\PP I Programación en Nuevas\TP_FINAL_NT\TP_NT\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5bb1f289d18b806b31b866c1e9574b4d175485c", @"/Views/Home/UnirseTorneo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4614340178dd6d3a8e687c0a9c8a507dd7324d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UnirseTorneo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TP_NT.Models.TorneoVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UnirseTorneo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\ORT\SEGUNDO CUATRIMESTRE\PP I Programación en Nuevas\TP_FINAL_NT\TP_NT\Views\Home\UnirseTorneo.cshtml"
  
    ViewData["Title"] = "Unirse a un torneo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card text-center"">
    <div class=""card-header"">
        <span class=""badge bg-warning text-dark"" style=""font-size:18px;"">TORNEOS DISPONIBLES</span>
    </div>
    <div class=""card-body"">

        <table class=""table table-striped table-bordered table-condensed table-sm mt-3"">
            <thead>
                <tr>
                    <th scope=""col"">Propietario</th>
                    <th scope=""col"">Torneo</th>
                    <th scope=""col"">Acciones</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 22 "C:\ORT\SEGUNDO CUATRIMESTRE\PP I Programación en Nuevas\TP_FINAL_NT\TP_NT\Views\Home\UnirseTorneo.cshtml"
                 foreach (var item in Model.Torneos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                      <td class=\"text-primary\">");
#nullable restore
#line 25 "C:\ORT\SEGUNDO CUATRIMESTRE\PP I Programación en Nuevas\TP_FINAL_NT\TP_NT\Views\Home\UnirseTorneo.cshtml"
                                          Write(item.Creador.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                      <td>");
#nullable restore
#line 26 "C:\ORT\SEGUNDO CUATRIMESTRE\PP I Programación en Nuevas\TP_FINAL_NT\TP_NT\Views\Home\UnirseTorneo.cshtml"
                     Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                      <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5bb1f289d18b806b31b866c1e9574b4d175485c6161", async() => {
                WriteLiteral("Inscribirse");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\ORT\SEGUNDO CUATRIMESTRE\PP I Programación en Nuevas\TP_FINAL_NT\TP_NT\Views\Home\UnirseTorneo.cshtml"
                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 29 "C:\ORT\SEGUNDO CUATRIMESTRE\PP I Programación en Nuevas\TP_FINAL_NT\TP_NT\Views\Home\UnirseTorneo.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n    <div class=\"card-footer text-muted\">\r\n            <i class=\"fas fa-basketball-ball\"></i>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TP_NT.Models.TorneoVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
