#pragma checksum "C:\Users\Emanuel\Desktop\TP_NT_1\TP_NT\Views\Home\UnirseTorneo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "381eaab25aa3c08d65e62135c3185f309e899331"
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
#line 1 "C:\Users\Emanuel\Desktop\TP_NT_1\TP_NT\Views\_ViewImports.cshtml"
using TP_NT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emanuel\Desktop\TP_NT_1\TP_NT\Views\_ViewImports.cshtml"
using TP_NT.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emanuel\Desktop\TP_NT_1\TP_NT\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"381eaab25aa3c08d65e62135c3185f309e899331", @"/Views/Home/UnirseTorneo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4614340178dd6d3a8e687c0a9c8a507dd7324d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UnirseTorneo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TP_NT.Models.ViewModel.Ranking>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Emanuel\Desktop\TP_NT_1\TP_NT\Views\Home\UnirseTorneo.cshtml"
  
    ViewData["Title"] = "Unirse a un torneo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "381eaab25aa3c08d65e62135c3185f309e8993313690", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-3"">
                    <input type=""text"" class=""form-control"" placeholder=""Nombre del torneo"">
                </div>
                <div class=""col-3"">
                    <input type=""text"" class=""form-control"" placeholder=""Nombre del dueño"">
                </div>
                <div class=""col-3"">
                    <input type=""text"" class=""form-control"" placeholder=""Apellido del dueño"">           
                </div>
                <div class=""col-3"">
                    <button type=""button"" class=""btn btn-primary"">Buscar torneo</button>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""row"">
        <table class=""table"">
                <thead>
                    <tr>
                    <th scope=""col""></th>
                    <th scope=""col"">Torneo</th>
                    <th scope=""col"">Dueño</th>
                    <th scope=""col""></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                    <th scope=""row""></th>
                    <td>Torneo</td>
                    <td>Amilcar</td>
                    <td><button type=""button"" class=""btn btn-outline-primary"">Postularse</button></td>
                    </tr>
                </tbody>
            </table>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TP_NT.Models.ViewModel.Ranking> Html { get; private set; }
    }
}
#pragma warning restore 1591
