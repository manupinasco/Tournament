#pragma checksum "C:\Users\Emanuel\Desktop\TP_NT_1\TP_NT\Views\Home\Ranking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e5107ee7aeea7f2ab3a146f3522d3178245de07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Ranking), @"mvc.1.0.view", @"/Views/Home/Ranking.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e5107ee7aeea7f2ab3a146f3522d3178245de07", @"/Views/Home/Ranking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4614340178dd6d3a8e687c0a9c8a507dd7324d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Ranking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TP_NT.Models.ViewModel.Ranking>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
#nullable restore
#line 3 "C:\Users\Emanuel\Desktop\TP_NT_1\TP_NT\Views\Home\Ranking.cshtml"
  
    ViewData["Title"] = "Ranking";

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
<div class=""row my-4"">
   <div class=""col"">
    <div class=""card"">
 
      <!--
    <div class=""card-body"">
        <a href=""#"" class=""badge badge-success"">RANKING ANOTADORES</a>
        <table class=""table table-striped table-bordered table-condensed table-sm mt-1"">
          <thead>
            <tr>
              <th scope=""col"">Jugador</th>
              <th scope=""col"">Posicion</th>
            </tr>
          </thead>
          <tbody>
              <tr>
                <td>nombre
                </td>
                <td><span class=""badge badge-warning"">cantidad</span></td>
              </tr>
                            <tr>
                <td>nombre
                </td>
                <td><span class=""badge badge-warning"">cantidad</span></td>
              </tr>
                            <tr>
                <td>nombre
                </td>
                <td><span class=""badge badge-warning"">cantidad</span></td>
              </tr>
        </table>
        </d");
            WriteLiteral(@"iv>
        </div>
        </div>
           <div class=""col"">
    <div class=""card"">
 
    <div class=""card-body"">
        <a href=""#"" class=""badge badge-success"">RANKING ASISTIDORES</a>
        <table class=""table table-striped table-bordered table-condensed table-sm mt-1"">
          <thead>
            <tr>
              <th scope=""col"">Jugador</th>
              <th scope=""col"">Cantidad</th>
            </tr>
          </thead>
          <tbody>
              <tr>
                <td>nombre
                </td>
                <td><span class=""badge badge-warning"">cantidad</span></td>
              </tr>
                            <tr>
                <td>nombre
                </td>
                <td><span class=""badge badge-warning"">cantidad</span></td>
              </tr>
                            <tr>
                <td>nombre
                </td>
                <td><span class=""badge badge-warning"">cantidad</span></td>
              </tr>
        </table>
    ");
            WriteLiteral(@"    </div>
        </div>
        </div>
           <div class=""col"">
    <div class=""card"">
 
    <div class=""card-body"">
        <a href=""#"" class=""badge badge-success"">RANKING BLOQUEADORES</a>
        <table class=""table table-striped table-bordered table-condensed table-sm mt-1"">
          <thead>
            <tr>
              <th scope=""col"">Jugador</th>
              <th scope=""col"">Cantidad</th>
            </tr>
          </thead>
          <tbody>
              <tr>
                <td>nombre
                </td>
                <td><span class=""badge badge-warning"">cantidad</span></td>
              </tr>
                            <tr>
                <td>nombre
                </td>
                <td><span class=""badge badge-warning"">cantidad</span></td>
              </tr>
                            <tr>
                <td>nombre
                </td>
                <td><span class=""badge badge-warning"">cantidad</span></td>
              </tr>
        </tabl");
            WriteLiteral(@"e>
        </div>
        </div>
        </div>
           <div class=""col"">
    <div class=""card"">
 
    <div class=""card-body"">
        <a href=""#"" class=""badge badge-success"">RANKING REBOTES</a>
        <table class=""table table-striped table-bordered table-condensed table-sm mt-1"">
          <thead>
            <tr>
              <th scope=""col"">Jugador</th>
              <th scope=""col"">Cantidad</th>
            </tr>
          </thead>
          <tbody>
              <tr>
                <td>nombre
                </td>
                <td><span class=""badge badge-warning"">cantidad</span></td>
              </tr>
                            <tr>
                <td>nombre
                </td>
                <td><span class=""badge badge-warning"">cantidad</span></td>
              </tr>
                            <tr>
                <td>nombre
                </td>
                <td><span class=""badge badge-warning"">cantidad</span></td>
              </tr>
        </t");
            WriteLiteral(@"able>
        </div>
        </div>
        </div>
         </div>
-->
<div class=""row"">
  <div class=""col-sm-12"">
    <div class=""card"">
        <div class=""card-header"">
    <center>
    <span class=""badge badge-success"" style=""font-size:18px;"">RANKING EQUIPOS DE USUARIOS</span>
    </center>
  </div>
      <div class=""card-body"">
 
    <table class=""table table-striped table-bordered table-condensed table-sm mt-3"">
      <thead>
        <tr>
          <th scope=""col"">Puesto</th>
          <th scope=""col"">Usuario</th>
          <th scope=""col"">Puntaje</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 158 "C:\Users\Emanuel\Desktop\TP_NT_1\TP_NT\Views\Home\Ranking.cshtml"
          int pos = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n");
#nullable restore
#line 160 "C:\Users\Emanuel\Desktop\TP_NT_1\TP_NT\Views\Home\Ranking.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n            <td><span class=\"badge badge-warning\">");
#nullable restore
#line 163 "C:\Users\Emanuel\Desktop\TP_NT_1\TP_NT\Views\Home\Ranking.cshtml"
                                             Write(pos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td><span class=\"badge badge-primary\">");
#nullable restore
#line 164 "C:\Users\Emanuel\Desktop\TP_NT_1\TP_NT\Views\Home\Ranking.cshtml"
                                             Write(item.NombreUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td><span class=\"badge badge-danger\">");
#nullable restore
#line 165 "C:\Users\Emanuel\Desktop\TP_NT_1\TP_NT\Views\Home\Ranking.cshtml"
                                            Write(item.Puntaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n          </tr>\r\n");
#nullable restore
#line 167 "C:\Users\Emanuel\Desktop\TP_NT_1\TP_NT\Views\Home\Ranking.cshtml"
          {pos++;}
        }                  

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tbody>\r\n    </table>\r\n\r\n </div>\r\n</div>\r\n</div>  \r\n \r\n \r\n \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TP_NT.Models.ViewModel.Ranking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
