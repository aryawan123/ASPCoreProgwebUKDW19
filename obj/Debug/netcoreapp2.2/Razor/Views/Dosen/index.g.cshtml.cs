#pragma checksum "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\Materi\Materi_pertemuan10\ASPCoreVSCodeB-master\Views\Dosen\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50e5a7ff78fb234d014dd4309248ee81bb990273"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dosen_index), @"mvc.1.0.view", @"/Views/Dosen/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dosen/index.cshtml", typeof(AspNetCore.Views_Dosen_index))]
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
#line 1 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\Materi\Materi_pertemuan10\ASPCoreVSCodeB-master\Views\_ViewImports.cshtml"
using ASPCoreGroupB;

#line default
#line hidden
#line 2 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\Materi\Materi_pertemuan10\ASPCoreVSCodeB-master\Views\_ViewImports.cshtml"
using ASPCoreGroupB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50e5a7ff78fb234d014dd4309248ee81bb990273", @"/Views/Dosen/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b263f7249850b0df01fc6e8299dd3fc406b97f31", @"/Views/_ViewImports.cshtml")]
    public class Views_Dosen_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\Materi\Materi_pertemuan10\ASPCoreVSCodeB-master\Views\Dosen\index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 25, true);
            WriteLiteral("\r\n<h2>Daftar Dosen</h2>\r\n");
            EndContext();
            BeginContext(57, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50e5a7ff78fb234d014dd4309248ee81bb9902734793", async() => {
                BeginContext(111, 6, true);
                WriteLiteral("Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(121, 209, true);
            WriteLiteral(" <br>\r\n<table class=\"table table-striped\">\r\n        <tr>\r\n        <th>Nik</th>\r\n        <th>Nama</th>\r\n        <th>Alamat</th>\r\n        <th>Jurusan</th>\r\n        <th></th>\r\n        <th></th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 17 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\Materi\Materi_pertemuan10\ASPCoreVSCodeB-master\Views\Dosen\index.cshtml"
     foreach (var data in Model){

#line default
#line hidden
            BeginContext(365, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(396, 8, false);
#line 19 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\Materi\Materi_pertemuan10\ASPCoreVSCodeB-master\Views\Dosen\index.cshtml"
           Write(data.Nik);

#line default
#line hidden
            EndContext();
            BeginContext(404, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(428, 9, false);
#line 20 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\Materi\Materi_pertemuan10\ASPCoreVSCodeB-master\Views\Dosen\index.cshtml"
           Write(data.Nama);

#line default
#line hidden
            EndContext();
            BeginContext(437, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(461, 11, false);
#line 21 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\Materi\Materi_pertemuan10\ASPCoreVSCodeB-master\Views\Dosen\index.cshtml"
           Write(data.Alamat);

#line default
#line hidden
            EndContext();
            BeginContext(472, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(496, 12, false);
#line 22 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\Materi\Materi_pertemuan10\ASPCoreVSCodeB-master\Views\Dosen\index.cshtml"
           Write(data.Jurusan);

#line default
#line hidden
            EndContext();
            BeginContext(508, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(531, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50e5a7ff78fb234d014dd4309248ee81bb9902738370", async() => {
                BeginContext(580, 7, true);
                WriteLiteral("details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\Materi\Materi_pertemuan10\ASPCoreVSCodeB-master\Views\Dosen\index.cshtml"
                                          WriteLiteral(data.Nik);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(591, 24, true);
            WriteLiteral(" </td>\r\n            <td>");
            EndContext();
            BeginContext(615, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50e5a7ff78fb234d014dd4309248ee81bb99027310765", async() => {
                BeginContext(663, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\Materi\Materi_pertemuan10\ASPCoreVSCodeB-master\Views\Dosen\index.cshtml"
                                         WriteLiteral(data.Nik);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(673, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 26 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\Materi\Materi_pertemuan10\ASPCoreVSCodeB-master\Views\Dosen\index.cshtml"
    }

#line default
#line hidden
            BeginContext(702, 8, true);
            WriteLiteral("</table>");
            EndContext();
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
