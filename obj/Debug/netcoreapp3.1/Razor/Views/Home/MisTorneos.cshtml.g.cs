#pragma checksum "C:\ORT\SEGUNDO CUATRIMESTRE\PP I Programación en Nuevas\TP_FINAL_NT\TP_NT\Views\Home\MisTorneos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "924465261b9e3ba372f8b81f53f10c0034c2730b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"924465261b9e3ba372f8b81f53f10c0034c2730b", @"/Views/Home/MisTorneos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4614340178dd6d3a8e687c0a9c8a507dd7324d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MisTorneos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TP_NT.Models.ViewModel.Ranking>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\ORT\SEGUNDO CUATRIMESTRE\PP I Programación en Nuevas\TP_FINAL_NT\TP_NT\Views\Home\MisTorneos.cshtml"
  
    ViewData["Title"] = "Unirse a un torneo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card text-center"">
    <div class=""card-header"">
        <span class=""badge bg-primary text-white"" style=""font-size:18px; float:left;"">MIS TORNEOS</span>
        <button type=""button"" class=""btn btn-outline-success"" style=""margin-left:700px;"" data-toggle=""modal"" data-target=""#myModal"">CREAR TORNEO</button>
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
                 <tr>
                    <td class=""text-primary"">Usted</td>
                    <td>Liga top</td>
                    <td>
                        <button type=""button"" class=""btn btn-outline-primary"">Administrar <i class=""fas fa-user-edit""></i></button>
                        ");
            WriteLiteral(@"<button type=""button"" class=""btn btn-outline-danger"">Eliminar <i class=""fas fa-trash-alt""></i></button>
                    </td>
                </tr>                 
                <tr>
                    <td>Pepe</td>
                    <td>Liga Crazy</td>
                    <td><button type=""button"" class=""btn btn-outline-danger"">Eliminar <i class=""fas fa-trash-alt""></i></button></td>
                </tr>
              
            </tbody>
        </table>

    </div>
    <div class=""card-footer text-muted"">
            <i class=""fas fa-basketball-ball""></i>
    </div>
</div>

  <!-- Modal -->
  <div class=""modal fade"" id=""myModal"" role=""dialog"">
    <div class=""modal-dialog modal-md"">
      <div class=""modal-content"">
        <div class=""modal-header"" style=""background-color:#F7F7F7;"">
          <h4 class=""modal-title"">Arma tu torneo</h4>
        </div>
        <div class=""modal-body"">
          <div class=""input-group mb-3"">
            <input type=""text"" class=""form-co");
            WriteLiteral(@"ntrol"" placeholder=""Ingresa el nombre de tu torneo"">
            <div class=""input-group-append"">
                <button class=""btn btn-success"" type=""button"">Crear</button>
            </div>
            </div>
        </div>
        <div class=""modal-footer"">
          <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
        </div>
      </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TP_NT.Models.ViewModel.Ranking> Html { get; private set; }
    }
}
#pragma warning restore 1591
