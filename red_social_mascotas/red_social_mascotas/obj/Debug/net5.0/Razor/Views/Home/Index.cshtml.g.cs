#pragma checksum "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c660684714503b18c7b564a440b66a0b85d8bc2"
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
#line 1 "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\_ViewImports.cshtml"
using red_social_mascotas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\_ViewImports.cshtml"
using red_social_mascotas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c660684714503b18c7b564a440b66a0b85d8bc2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1f3b786937def7a6c1136ea3f96f5faf36271ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c660684714503b18c7b564a440b66a0b85d8bc24248", async() => {
                WriteLiteral("\r\n    <input type=\"text\" placeholder=\"Buscar por nombre\" name=\"busqueda\" autocomplete=\"off\"/>\r\n\r\n");
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
<div class=""container my-4"">
    <!--Carousel Wrapper-->
    <div id=""multi-item-example"" class=""carousel slide carousel-multi-item"" data-ride=""carousel"">

        <!--Controls-->
        <div class=""controls-top"">
            <a class=""btn-floating"" href=""#multi-item-example"" data-slide=""prev"">
                <i class=""fas fa-chevron-left""></i>
            </a>
            <a class=""btn-floating"" href=""#multi-item-example"" data-slide=""next"">
                <i
                    class=""fas fa-chevron-right"">
                </i>
            </a>
        </div>
        <!--/.Controls-->

        <!--Indicators-->
        <ol class=""carousel-indicators"">
            <li data-target=""#multi-item-example"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#multi-item-example"" data-slide-to=""1""></li>

        </ol>
        <!--/.Indicators-->

        <!--Slides-->
        <div class=""carousel-inner"" role=""listbox"">

            <!--First slide-->
            <div");
            WriteLiteral(" class=\"carousel-item active\">\r\n");
#nullable restore
#line 36 "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\Home\Index.cshtml"
                 foreach (var item in @ViewBag.publicaciones)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-3\" style=\"float:left\">\r\n                        <div class=\"card mb-2\">\r\n                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c660684714503b18c7b564a440b66a0b85d8bc27192", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1413, "~/images/", 1413, 9, true);
#nullable restore
#line 40 "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1422, ViewBag.mascota[item.IdMascota].Imagen, 1422, 39, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"card-body\">\r\n                                <h6 class=\"card-title\"><b>Nombre: </b>");
#nullable restore
#line 42 "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\Home\Index.cshtml"
                                                                 Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6 class=\"card-title\"><b>Raza: </b>");
#nullable restore
#line 43 "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\Home\Index.cshtml"
                                                               Write(ViewBag.raza[@item.IdRaza].Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6 class=\"card-title\"><b>Especie: </b>");
#nullable restore
#line 44 "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\Home\Index.cshtml"
                                                                  Write(ViewBag.especie[@item.IdEspecie].Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <p class=\"card-text\">\r\n                                    ");
#nullable restore
#line 46 "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\Home\Index.cshtml"
                               Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <h8 class=\"card-title\"><b>fecha publicacion: </b>");
#nullable restore
#line 48 "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\Home\Index.cshtml"
                                                                            Write(item.FechaPublicacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h8>\r\n                                <h6 class=\"card-title\"><b>Usuario dueño: </b>");
#nullable restore
#line 49 "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\Home\Index.cshtml"
                                                                        Write(ViewBag.usuario[@item.IdUsuario].Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 2297, "\"", 2340, 2);
            WriteAttributeValue("", 2304, "/Home/Test?IdMascota=", 2304, 21, true);
#nullable restore
#line 50 "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\Home\Index.cshtml"
WriteAttributeValue("", 2325, item.IdMascota, 2325, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">adoptar</a>\r\n                                <a class=\"btn-secundary\"");
            BeginWriteAttribute("href", " href=\"", 2411, "\"", 2458, 2);
            WriteAttributeValue("", 2418, "/Home/Comentarios?IdPublicacion=", 2418, 32, true);
#nullable restore
#line 51 "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\Home\Index.cshtml"
WriteAttributeValue("", 2450, item.Id, 2450, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">comentarios</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 55 "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <!--/.First slide-->\r\n\r\n        </div>\r\n        <!--/.Slides-->\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591