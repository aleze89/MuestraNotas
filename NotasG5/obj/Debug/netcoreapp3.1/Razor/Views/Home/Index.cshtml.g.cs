#pragma checksum "C:\Users\Gaby de enfermeria\Documents\Curso Comunidad IT\06 - Practica NET\NotasG5\MuestraNotas\NotasG5\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a23bb4c1be5be978d8c2f474c41d57f580319b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Gaby de enfermeria\Documents\Curso Comunidad IT\06 - Practica NET\NotasG5\MuestraNotas\NotasG5\Views\_ViewImports.cshtml"
using NotasG5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gaby de enfermeria\Documents\Curso Comunidad IT\06 - Practica NET\NotasG5\MuestraNotas\NotasG5\Views\_ViewImports.cshtml"
using NotasG5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a23bb4c1be5be978d8c2f474c41d57f580319b0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2330a073f09c55df0043c35274e162d7c58d9d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Nota>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Gaby de enfermeria\Documents\Curso Comunidad IT\06 - Practica NET\NotasG5\MuestraNotas\NotasG5\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Mis notas</h1>\r\n    <p>Tengo ");
#nullable restore
#line 8 "C:\Users\Gaby de enfermeria\Documents\Curso Comunidad IT\06 - Practica NET\NotasG5\MuestraNotas\NotasG5\Views\Home\Index.cshtml"
        Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" notas</p>\r\n    <div class=\"card-deck\">\r\n");
#nullable restore
#line 10 "C:\Users\Gaby de enfermeria\Documents\Curso Comunidad IT\06 - Practica NET\NotasG5\MuestraNotas\NotasG5\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\">\r\n                <h3 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\Gaby de enfermeria\Documents\Curso Comunidad IT\06 - Practica NET\NotasG5\MuestraNotas\NotasG5\Views\Home\Index.cshtml"
                                  Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\Gaby de enfermeria\Documents\Curso Comunidad IT\06 - Practica NET\NotasG5\MuestraNotas\NotasG5\Views\Home\Index.cshtml"
                                Write(item.Cuerpo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 16 "C:\Users\Gaby de enfermeria\Documents\Curso Comunidad IT\06 - Practica NET\NotasG5\MuestraNotas\NotasG5\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    \r\n    \r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Nota>> Html { get; private set; }
    }
}
#pragma warning restore 1591
