#pragma checksum "C:\Users\carmesy\Desktop\Materias\3-C\Aplicaciones web\Aplicacion nueva\Aplicacion Web1\Views\Home\gestionDivision.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "725cb49967d50f47c0d5f21e27682d31f5550e6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_gestionDivision), @"mvc.1.0.view", @"/Views/Home/gestionDivision.cshtml")]
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
#line 1 "C:\Users\carmesy\Desktop\Materias\3-C\Aplicaciones web\Aplicacion nueva\Aplicacion Web1\Views\_ViewImports.cshtml"
using Aplicacion_Web1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\carmesy\Desktop\Materias\3-C\Aplicaciones web\Aplicacion nueva\Aplicacion Web1\Views\_ViewImports.cshtml"
using Aplicacion_Web1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"725cb49967d50f47c0d5f21e27682d31f5550e6d", @"/Views/Home/gestionDivision.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de7f5faf05b76c4089911435649d5b5c83445670", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_gestionDivision : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row col-md-12 NuevoProyecto1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<main id=""main"">







    <div class=""contenedoformytabla"">






        <div class=""contenedordelform1"">

            <div class=""field"" id=""searchform"">
                <input type=""text"" id=""searchterm"" placeholder=""Buscar division"" />
                <button type=""button"" id=""search"">IR</button>
            </div>


            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "725cb49967d50f47c0d5f21e27682d31f5550e6d4118", async() => {
                WriteLiteral(@"


                <div class=""col-md-12"">
                    <label for=""inputEmail4"" class=""form-label"">ID de la division</label>
                    <input type=""text"" class=""form-control"" id=""inputEmail4"">

                </div>
                <div class=""col-md-12"">
                    <label for=""inputEmail4"" class=""form-label"">Nombre de la division</label>
                    <input type=""text"" class=""form-control"" id=""inputEmail43"">

                </div>
                <div class=""col-md-12"">
                    <label for=""inputEmail4"" class=""form-label"">Jefe administrativo</label>
                    <input type=""text"" class=""form-control"" id=""inputEmail41"">
                </div>

                <div class=""col-md-12"">
                    <label for=""inputEmail4"" class=""form-label"">docentes</label>
                    <input type=""text"" class=""form-control"" id=""inputEmail44"">
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


            <div class=""colbtndivision"">
                <div class=""colbtn1"">
                    <button type=""submit"" class=""btn btn-primary"">AGREGAR</button>
                </div>
                <div class=""colbtn1"">
                    <button type=""submit"" class=""btn btn-primary"">CAMBIAR</button>
                </div>
                <div class=""colbtn1"">
                    <button type=""submit"" class=""btn btn-primary"">BORRAR</button>
                </div>
            </div>
        </div>










        <div class=""contenedordelatabladivision"">
            <table class=""table caption-top"">
                <caption><h1><center>LISTA DE DIVISIONES</center></h1></caption>
                <thead>
                    <tr>
                        <th scope=""col"">ID De la division</th>
                        <th scope=""col"">Nombre del la division</th>
                        <th scope=""col"">Jefe administrativo</th>
                        <th scope=""col""></th>
   ");
            WriteLiteral(@"                 </tr>

                </thead>
                <tbody>
                    <tr>
                        <th>101</th>
                        <th>DSM</th>
                        <td>CHUCK UC JOEL</td>
                        <td><button type=""button"" class=""btn1 btn-primary"">VER</button></td>

                    </tr>
                    <tr>
                        <th>101</th>
                        <th scope=""row"">ER</th>
                        <td>SEBASTIN MEDEZ ACOSTA</td>
                        <td>
                            <button type=""button"" class=""btn1 btn-primary"">VER</button>
                        </td>
                    </tr>
                    <tr>
                        <th>101</th>
                        <th scope=""row"">DSM</th>
                        <td>LAURA CASTILLA SALAZAR</td>
                        <td>
                            <button type=""button"" class=""btn1 btn-primary"">VER</button>
                        </td>
       ");
            WriteLiteral(@"             </tr>
                </tbody>
            </table>
        </div>

    </div>





    <section id=""cliens1"" class=""cliens section-bg"">
        <div class=""container"">

            <div class=""row"" data-aos=""zoom-in"">

                <div class=""col"">
                    <h1>NO OLVIDES VISITAR LOS PROYECTOS</h1>
                </div>
            </div>

        </div>

    </section>




</main>");
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
