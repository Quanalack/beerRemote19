#pragma checksum "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Grids\ProductExcelImport\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32f159f86c0e84b395513ae024a93ff5dc688116"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Grids_ProductExcelImport_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Grids/ProductExcelImport/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/BasicSamples/Grids/ProductExcelImport/Index.cshtml", typeof(AspNetCore.Modules_BasicSamples_Grids_ProductExcelImport_Index))]
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
#line 1 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#line 2 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#line 3 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using Serene1;

#line default
#line hidden
#line 4 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32f159f86c0e84b395513ae024a93ff5dc688116", @"/Modules/BasicSamples/Grids/ProductExcelImport/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3254ced552f0dad62c9e8654f29630ba694f49ac", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Grids_ProductExcelImport_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Grids\ProductExcelImport\Index.cshtml"
  
    ViewData["Title"] = "Product Excel Import";

#line default
#line hidden
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ContentHeader", async() => {
                BeginContext(82, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(93, 17, false);
#line 6 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Grids\ProductExcelImport\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(110, 22, true);
                WriteLiteral("<small></small></h1>\r\n");
                EndContext();
            }
            );
            BeginContext(135, 352, true);
            WriteLiteral(@"
<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>
        Importing data from Excel can be done using integrated EPPlus library.
    </p>
    <p>
        Click ""Import Excel"" and choose this file that you can download from GitHub:
        ");
            EndContext();
            BeginContext(489, 44, false);
#line 16 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Grids\ProductExcelImport\Index.cshtml"
    Write(Html.AppSourceFile("SampleProductList.xlsx"));

#line default
#line hidden
            EndContext();
            BeginContext(534, 506, true);
            WriteLiteral(@".
    </p>
    <p>
        This sample is very basic. It works based on product name. If a product doesn't exists,
        inserts new one, otherwise updates existing product. It should also fail for one
        invalid line in imported Excel file.
    </p>
    <p>
        In a production environment, you should have better error handling, and shouldn't 
        depend on predetermined column order like we do here.
    </p>

    <p style=""text-align: right;""><b>Source Files:</b> 
        ");
            EndContext();
            BeginContext(1041, 34, false);
#line 29 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Grids\ProductExcelImport\Index.cshtml"
   Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 11, true);
            WriteLiteral(",\r\n        ");
            EndContext();
            BeginContext(1087, 49, false);
#line 30 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Grids\ProductExcelImport\Index.cshtml"
   Write(Html.AppSourceFile("ProductExcelImportDialog.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 11, true);
            WriteLiteral(",\r\n        ");
            EndContext();
            BeginContext(1148, 51, false);
#line 31 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Grids\ProductExcelImport\Index.cshtml"
   Write(Html.AppSourceFile("ProductExcelImportEndpoint.cs"));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 11, true);
            WriteLiteral(",\r\n        ");
            EndContext();
            BeginContext(1211, 47, false);
#line 32 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Grids\ProductExcelImport\Index.cshtml"
   Write(Html.AppSourceFile("ProductExcelImportForm.cs"));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 11, true);
            WriteLiteral(",\r\n        ");
            EndContext();
            BeginContext(1270, 47, false);
#line 33 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Grids\ProductExcelImport\Index.cshtml"
   Write(Html.AppSourceFile("ProductExcelImportGrid.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(1317, 11, true);
            WriteLiteral(",\r\n        ");
            EndContext();
            BeginContext(1329, 44, false);
#line 34 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Grids\ProductExcelImport\Index.cshtml"
   Write(Html.AppSourceFile("SampleProductList.xlsx"));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 263, true);
            WriteLiteral(@"
    </p>
</div>

<div id=""GridDiv""></div>

<script type=""text/javascript"">
    jQuery(function () {
        new Serene1.BasicSamples.ProductExcelImportGrid($('#GridDiv'), {}).init();

        Q.initFullHeightGridPage($('#GridDiv'));
    });
</script>");
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