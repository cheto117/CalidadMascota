#pragma checksum "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\Home\PonerEnAdopccion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e45cb182f5d64bf1fc0ee693c2f78b9ab4cb9c44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PonerEnAdopccion), @"mvc.1.0.view", @"/Views/Home/PonerEnAdopccion.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45cb182f5d64bf1fc0ee693c2f78b9ab4cb9c44", @"/Views/Home/PonerEnAdopccion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1f3b786937def7a6c1136ea3f96f5faf36271ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PonerEnAdopccion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-signin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/guardarPublicacion"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\Home\PonerEnAdopccion.cshtml"
   Layout = "_Layout1"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
 
  
  body {
  	background: #eee !important;	
  }
  
  .wrapper {	
  	margin-top: 80px;
    margin-bottom: 80px;
  }
  
  .form-signin {
    max-width: 380px;
    padding: 15px 35px 45px;
    margin: 0 auto;
    background-color: #fff;
    border: 1px solid rgba(0,0,0,0.1); } 
  
    .form-signin-heading,
  	.checkbox {
  	  margin-bottom: 30px;
  	}
  
  	.checkbox {
  	  font-weight: normal;
  	}
  
  	.form-control {
  	  position: relative;
  	  font-size: 16px;
  	  height: auto;
  	  padding: 10px;
  		");
            WriteLiteral(@"@include box-sizing(border-box);}
  
  		&:focus {
  		  z-index: 2;
  		}
  	}
  
  	input[type=""text""] {
  	  margin-bottom: -1px;
  	  border-bottom-left-radius: 0;
  	  border-bottom-right-radius: 0;
  	}
  
  	input[type=""password""] {
  	  margin-bottom: 20px;
  	  border-top-left-radius: 0;
  	  border-top-right-radius: 0;
  	}
  }

</style>
<div class=""wrapper"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e45cb182f5d64bf1fc0ee693c2f78b9ab4cb9c445404", async() => {
                WriteLiteral("\r\n        <h2 class=\"form-signin-heading\">Ingrese la descripcion de la publicacion </h2>\r\n        <hr>\r\n        <h3>mascota</h3>\r\n        <h4><b>Nombre: </b> ");
#nullable restore
#line 61 "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\Home\PonerEnAdopccion.cshtml"
                       Write(ViewBag.mimascota.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n        <h4><b>Raza: </b> ");
#nullable restore
#line 62 "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\Home\PonerEnAdopccion.cshtml"
                     Write(ViewBag.raza[@ViewBag.mimascota.IdRaza].Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n        <h4><b>Especie: </b> ");
#nullable restore
#line 63 "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\Home\PonerEnAdopccion.cshtml"
                        Write(ViewBag.especie[@ViewBag.mimascota.IdEspecie].Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n        <input type=\"hidden\"  name=\"IdMascota\"");
                BeginWriteAttribute("value", " value=\"", 1447, "\"", 1476, 1);
#nullable restore
#line 64 "D:\2021-2\ArquiSoftware\Proy Final -Examen Final\red_social_mascotas\red_social_mascotas\red_social_mascotas\Views\Home\PonerEnAdopccion.cshtml"
WriteAttributeValue("", 1455, ViewBag.mimascota.Id, 1455, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n      \r\n        <input type=\"text\" class=\"form-control\" name=\"descripcion\" placeholder=\"descripcion de la publicacion\"");
                BeginWriteAttribute("required", " required=\"", 1599, "\"", 1610, 0);
                EndWriteAttribute();
                BeginWriteAttribute("autofocus", " autofocus=\"", 1611, "\"", 1623, 0);
                EndWriteAttribute();
                WriteLiteral("/>\r\n        <hr>\r\n\r\n        <button class=\"btn btn-lg btn-primary btn-block\" type=\"submit\">publicar</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
