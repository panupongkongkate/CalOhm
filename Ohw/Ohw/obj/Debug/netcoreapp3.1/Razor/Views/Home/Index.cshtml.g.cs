#pragma checksum "H:\Ohw\CalOhm\Ohw\Ohw\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f20a8ca30f54cda79ed9e9f072875e1d06d93d09"
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
#line 1 "H:\Ohw\CalOhm\Ohw\Ohw\Views\_ViewImports.cshtml"
using Ohw;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Ohw\CalOhm\Ohw\Ohw\Views\_ViewImports.cshtml"
using Ohw.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20a8ca30f54cda79ed9e9f072875e1d06d93d09", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff610c89e44908dc4c2aff8b7b0b1d3c888830ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""section-index-a"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-4"">
                <div id=""form-group-id"" class=""form-group"">

                    <small id=""helpId"">ความต้านทาน</small>
                    <label");
            BeginWriteAttribute("for", " for=\"", 276, "\"", 282, 0);
            EndWriteAttribute();
            WriteLiteral("></label>\r\n                    <input id=\"ohm\" type=\"text\" class=\"form-control\" placeholder=\"Resistance\"><br>\r\n\r\n                    <small id=\"helpId\">กระแสไฟ</small>\r\n                    <label");
            BeginWriteAttribute("for", " for=\"", 478, "\"", 484, 0);
            EndWriteAttribute();
            WriteLiteral("></label>\r\n                    <input id=\"amp\" type=\"text\" class=\"form-control\" placeholder=\"Ampere\"><br>\r\n                    <small id=\"helpId\">แรงดันไฟฟ้า</small>\r\n                    <label");
            BeginWriteAttribute("for", " for=\"", 678, "\"", 684, 0);
            EndWriteAttribute();
            WriteLiteral(@"></label>
                    <input id=""volt"" type=""text"" class=""form-control"" placeholder=""Voltage""><br>
                    <div class=""allbuttons"">
                        <button id=""summitbutton"" type=""submit"" class=""btn btn-primary"">
                            คำนวน
                        </button>
                        <button id=""Resetbutton"" type=""reset"" class=""btn
                                btn-primary"">
                            ล้างค่า
                        </button>
                    </div>
                </div>
            </div>
            <div class=""col-sm-8"">
                <div class=""imgbackground"">
                </div>
            </div>
        </div>
    </div>
</section>

<!-- Modal -->
<div class=""modal fade"" id=""modelId"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modelTitleId"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5");
            WriteLiteral(@" class=""modal-title"">แจ้งเตือน</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                กรุณากรอกข้อความให้ครบ
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591