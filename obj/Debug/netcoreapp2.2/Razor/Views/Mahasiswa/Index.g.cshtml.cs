#pragma checksum "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Mahasiswa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ac44d62d5e2f10647d79c82a9148315db059517"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mahasiswa_Index), @"mvc.1.0.view", @"/Views/Mahasiswa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mahasiswa/Index.cshtml", typeof(AspNetCore.Views_Mahasiswa_Index))]
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
#line 1 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\_ViewImports.cshtml"
using ASPCoreGroupB;

#line default
#line hidden
#line 2 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\_ViewImports.cshtml"
using ASPCoreGroupB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ac44d62d5e2f10647d79c82a9148315db059517", @"/Views/Mahasiswa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5548ae16151ce2d56cb3b361b1424016d3007e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Mahasiswa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Mahasiswa\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 34, true);
            WriteLiteral("\r\n<h2> Daftar Mahasiswa</h2><br>\r\n");
            EndContext();
#line 6 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Mahasiswa\Index.cshtml"
 if(ViewData["pesan"]!=null){
    //@ViewData["Pesan"];
    

#line default
#line hidden
            BeginContext(129, 27, false);
#line 8 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Mahasiswa\Index.cshtml"
Write(Html.Raw(ViewData["pesan"]));

#line default
#line hidden
            EndContext();
#line 8 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Mahasiswa\Index.cshtml"
                                ;  
}

#line default
#line hidden
            BeginContext(164, 39, true);
            WriteLiteral("</div>\r\n<br>\r\n\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(203, 555, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ac44d62d5e2f10647d79c82a9148315db0595176529", async() => {
                BeginContext(249, 502, true);
                WriteLiteral(@"

        <div class=""form-group"">
        <label>Masukan Keyword</label>
        <input type=""Text"" name=""keyword"" placeholder=""Masukan keyword"" class=""form-control""/>
        </div>
        <div class=""radio"">
        <label><input type=""radio"" name=""cari"" value=""Nim"" >Nim</label>
        </div>
        <div class=""radio"">
        <label><input type=""radio"" name=""cari"" value=""Nama"">Nama</label>
        </div>
        <button type=""submit"" class=""btn btn-primary"">Search</button>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
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
            BeginContext(758, 24, true);
            WriteLiteral("\r\n</div>\r\n<br>\r\n\r\n<br>\r\n");
            EndContext();
            BeginContext(782, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ac44d62d5e2f10647d79c82a9148315db0595178819", async() => {
                BeginContext(836, 6, true);
                WriteLiteral("Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(846, 216, true);
            WriteLiteral(" <br>\r\n<div class=\"row\">\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>Nim</th>\r\n        <th>Nama</th>\r\n        <th>Email</th>\r\n        <th>Telp</th>\r\n        <th></th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 44 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Mahasiswa\Index.cshtml"
     foreach (var data in Model){

#line default
#line hidden
            BeginContext(1097, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1128, 8, false);
#line 46 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Mahasiswa\Index.cshtml"
           Write(data.Nim);

#line default
#line hidden
            EndContext();
            BeginContext(1136, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1160, 9, false);
#line 47 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Mahasiswa\Index.cshtml"
           Write(data.Nama);

#line default
#line hidden
            EndContext();
            BeginContext(1169, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1193, 10, false);
#line 48 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Mahasiswa\Index.cshtml"
           Write(data.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1203, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1227, 9, false);
#line 49 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Mahasiswa\Index.cshtml"
           Write(data.Telp);

#line default
#line hidden
            EndContext();
            BeginContext(1236, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1259, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ac44d62d5e2f10647d79c82a9148315db05951712357", async() => {
                BeginContext(1308, 7, true);
                WriteLiteral("details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Mahasiswa\Index.cshtml"
                                          WriteLiteral(data.Nim);

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
            BeginContext(1319, 24, true);
            WriteLiteral(" </td>\r\n            <td>");
            EndContext();
            BeginContext(1343, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ac44d62d5e2f10647d79c82a9148315db05951714745", async() => {
                BeginContext(1391, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Mahasiswa\Index.cshtml"
                                         WriteLiteral(data.Nim);

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
            BeginContext(1401, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 53 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Mahasiswa\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1430, 16, true);
            WriteLiteral("</table>\r\n</div>");
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
