#pragma checksum "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Dokter\Tampil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfa2ef8ef1cbd0bb382aba058119de048c94306d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dokter_Tampil), @"mvc.1.0.view", @"/Views/Dokter/Tampil.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dokter/Tampil.cshtml", typeof(AspNetCore.Views_Dokter_Tampil))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfa2ef8ef1cbd0bb382aba058119de048c94306d", @"/Views/Dokter/Tampil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5548ae16151ce2d56cb3b361b1424016d3007e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Dokter_Tampil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Dokter\Tampil.cshtml"
  
    Layout = "_Layout";


#line default
#line hidden
            BeginContext(31, 99, true);
            WriteLiteral("    <!-- string nama= \"ary\";\r\n    int bil1 =13;\r\n    int bil2 =20;\r\n    int hasil =bil1+bil2; -->\r\n");
            EndContext();
            BeginContext(133, 40, true);
            WriteLiteral("\r\n<h2>Registrasi Berhasil</h2>\r\n<p>Nama ");
            EndContext();
            BeginContext(174, 15, false);
#line 11 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Dokter\Tampil.cshtml"
   Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(189, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(191, 14, false);
#line 11 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Dokter\Tampil.cshtml"
                    Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(205, 17, true);
            WriteLiteral(" </p>\r\n<p>Alamat ");
            EndContext();
            BeginContext(223, 13, false);
#line 12 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Dokter\Tampil.cshtml"
     Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(236, 16, true);
            WriteLiteral("  </p>\r\n<p>Telp ");
            EndContext();
            BeginContext(253, 10, false);
#line 13 "E:\Ary Doc Duta Wacana\Semester4\8_ProgWeb_Erick\TAS\TAS_ARY\ASPCoreProgwebUKDW19\Views\Dokter\Tampil.cshtml"
   Write(Model.Telp);

#line default
#line hidden
            EndContext();
            BeginContext(263, 9, true);
            WriteLiteral(" </p>\r\n\r\n");
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
