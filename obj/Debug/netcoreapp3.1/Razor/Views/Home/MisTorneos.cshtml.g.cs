#pragma checksum "C:\Users\Emanuel\Desktop\TP_NT_1\TP_NT\Views\Home\MisTorneos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9c369e26dea1654cd627a8c3b3e7d95d62d0e20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MisTorneos), @"mvc.1.0.view", @"/Views/Home/MisTorneos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9c369e26dea1654cd627a8c3b3e7d95d62d0e20", @"/Views/Home/MisTorneos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4614340178dd6d3a8e687c0a9c8a507dd7324d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MisTorneos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TP_NT.Models.Torneo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Emanuel\Desktop\TP_NT_1\TP_NT\Views\Home\MisTorneos.cshtml"
  
    ViewData["Title"] = "Mis torneos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-8"">
            <table class=""table"">
                <thead>
                    <tr>
                    <th scope=""col""></th>
                    <th scope=""col"">Torneo</th>
                    <th scope=""col""></th>
                    <th scope=""col"">Ver</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                    <th scope=""row""></th>
                    <td>Torneo de mi amigo</td>
                    <td></td>
                    <td><button type=""button"" class=""btn btn-outline-primary"">Ver torneo</button></td>
                    </tr>
                    <tr>
                    <th scope=""row""></th>
                    <td>Torneo mio</td>
                    <td><button type=""button"" class=""btn btn-outline-primary"">Administrar</button></td>
                    <td><button type=""button"" class=""btn btn-outline-primary"">Ver torneo</button></td>
 ");
            WriteLiteral(@"                   </tr>
                </tbody>
            </table>
        </div>
        <div class=""col-4"">
            <button type=""button"" class=""btn btn-primary btn-lg"">Crear</button>
            <button type=""button"" class=""btn btn-primary btn-lg"">Inscribirse</button>
        </div>
    </div>
</div>

    
     

    

   
    
    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TP_NT.Models.Torneo> Html { get; private set; }
    }
}
#pragma warning restore 1591
