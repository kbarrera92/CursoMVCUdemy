#pragma checksum "C:\Users\Kevin\Source\Repos\PrimeraAppMVC\PrimeraAppMVC\Views\TipoUsuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25dc1cca4979cafc900d69dc5585497d0cd6e801"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TipoUsuario_Index), @"mvc.1.0.view", @"/Views/TipoUsuario/Index.cshtml")]
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
#line 1 "C:\Users\Kevin\Source\Repos\PrimeraAppMVC\PrimeraAppMVC\Views\_ViewImports.cshtml"
using PrimeraAppMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kevin\Source\Repos\PrimeraAppMVC\PrimeraAppMVC\Views\_ViewImports.cshtml"
using PrimeraAppMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25dc1cca4979cafc900d69dc5585497d0cd6e801", @"/Views/TipoUsuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb281decc1dbeb951ad9bc7b707eff0d7e4134fe", @"/Views/_ViewImports.cshtml")]
    public class Views_TipoUsuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PrimeraAppMVC.Clases.TipoUsuarioCLS>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TipoUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Kevin\Source\Repos\PrimeraAppMVC\PrimeraAppMVC\Views\TipoUsuario\Index.cshtml"
  
    ViewData["Title"] = "Index";
    string nombreusuario = ViewBag.Nombre;
    string descripcion = ViewBag.Descripcion;
    int idtipousuario = ViewBag.IdTipoUsuario;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Listado de tipos de usuarios</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25dc1cca4979cafc900d69dc5585497d0cd6e8014333", async() => {
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Filtrar\" class=\"btn btn-primary\"/>\r\n    <table class=\"table\">\r\n        <thead class=\"thead-dark\">\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 18 "C:\Users\Kevin\Source\Repos\PrimeraAppMVC\PrimeraAppMVC\Views\TipoUsuario\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.idusuario));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "C:\Users\Kevin\Source\Repos\PrimeraAppMVC\PrimeraAppMVC\Views\TipoUsuario\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.nombreusuario));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\Kevin\Source\Repos\PrimeraAppMVC\PrimeraAppMVC\Views\TipoUsuario\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.descripcion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n");
#nullable restore
#line 30 "C:\Users\Kevin\Source\Repos\PrimeraAppMVC\PrimeraAppMVC\Views\TipoUsuario\Index.cshtml"
                     if (idtipousuario == 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"number\" name=\"idusuario\" class=\"form form-control\" />\r\n");
#nullable restore
#line 33 "C:\Users\Kevin\Source\Repos\PrimeraAppMVC\PrimeraAppMVC\Views\TipoUsuario\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 1170, "\"", 1192, 1);
#nullable restore
#line 36 "C:\Users\Kevin\Source\Repos\PrimeraAppMVC\PrimeraAppMVC\Views\TipoUsuario\Index.cshtml"
WriteAttributeValue("", 1178, idtipousuario, 1178, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"idusuario\" class=\"form form-control\" />\r\n");
#nullable restore
#line 37 "C:\Users\Kevin\Source\Repos\PrimeraAppMVC\PrimeraAppMVC\Views\TipoUsuario\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1349, "\"", 1371, 1);
#nullable restore
#line 41 "C:\Users\Kevin\Source\Repos\PrimeraAppMVC\PrimeraAppMVC\Views\TipoUsuario\Index.cshtml"
WriteAttributeValue("", 1357, nombreusuario, 1357, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"nombreusuario\" class=\"form form-control\" />\r\n                </th>\r\n                <th>\r\n                    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1507, "\"", 1527, 1);
#nullable restore
#line 44 "C:\Users\Kevin\Source\Repos\PrimeraAppMVC\PrimeraAppMVC\Views\TipoUsuario\Index.cshtml"
WriteAttributeValue("", 1515, descripcion, 1515, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"descripcion\" class=\"form form-control\" />\r\n                </th>\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\Kevin\Source\Repos\PrimeraAppMVC\PrimeraAppMVC\Views\TipoUsuario\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 54 "C:\Users\Kevin\Source\Repos\PrimeraAppMVC\PrimeraAppMVC\Views\TipoUsuario\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.idusuario));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 57 "C:\Users\Kevin\Source\Repos\PrimeraAppMVC\PrimeraAppMVC\Views\TipoUsuario\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.nombreusuario));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 60 "C:\Users\Kevin\Source\Repos\PrimeraAppMVC\PrimeraAppMVC\Views\TipoUsuario\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.descripcion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 64 "C:\Users\Kevin\Source\Repos\PrimeraAppMVC\PrimeraAppMVC\Views\TipoUsuario\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PrimeraAppMVC.Clases.TipoUsuarioCLS>> Html { get; private set; }
    }
}
#pragma warning restore 1591