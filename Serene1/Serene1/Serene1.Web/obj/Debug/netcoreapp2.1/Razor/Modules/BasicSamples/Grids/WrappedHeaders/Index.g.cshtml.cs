#pragma checksum "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Grids\WrappedHeaders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14efe41705b9b9c298da7428a731da4ac906a04a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Grids_WrappedHeaders_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Grids/WrappedHeaders/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/BasicSamples/Grids/WrappedHeaders/Index.cshtml", typeof(AspNetCore.Modules_BasicSamples_Grids_WrappedHeaders_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14efe41705b9b9c298da7428a731da4ac906a04a", @"/Modules/BasicSamples/Grids/WrappedHeaders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3254ced552f0dad62c9e8654f29630ba694f49ac", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Grids_WrappedHeaders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Grids\WrappedHeaders\Index.cshtml"
  
    ViewData["Title"] = "Wrapped Headers";

#line default
#line hidden
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ContentHeader", async() => {
                BeginContext(77, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(88, 17, false);
#line 6 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Grids\WrappedHeaders\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(105, 22, true);
                WriteLiteral("<small></small></h1>\r\n");
                EndContext();
            }
            );
            BeginContext(130, 377, true);
            WriteLiteral(@"
<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>
        Sometimes you might want to wrap column headers in grid. For this you just need to set a few CSS rules.
    </p>
    <p>
        site.basicsamples.less for class .s-WrappedHeadersGrid.
        See rules in ");
            EndContext();
            BeginContext(508, 70, false);
#line 16 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Grids\WrappedHeaders\Index.cshtml"
                Write(Html.AppSourceFile(@"..\..\..\..\Content\site\site.basicsamples.less"));

#line default
#line hidden
            EndContext();
            BeginContext(578, 88, true);
            WriteLiteral(" for how.\r\n    </p>\r\n\r\n    <p style=\"text-align: right;\"><b>Source Files:</b> \r\n        ");
            EndContext();
            BeginContext(667, 34, false);
#line 20 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Grids\WrappedHeaders\Index.cshtml"
   Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(701, 12, true);
            WriteLiteral(", \r\n        ");
            EndContext();
            BeginContext(714, 43, false);
#line 21 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Grids\WrappedHeaders\Index.cshtml"
   Write(Html.AppSourceFile("WrappedHeadersGrid.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(757, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(768, 70, false);
#line 22 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Grids\WrappedHeaders\Index.cshtml"
   Write(Html.AppSourceFile(@"..\..\..\..\Content\site\site.basicsamples.less"));

#line default
#line hidden
            EndContext();
            BeginContext(838, 259, true);
            WriteLiteral(@"
    </p>
</div>

<div id=""GridDiv""></div>

<script type=""text/javascript"">
    jQuery(function () {
        new Serene1.BasicSamples.WrappedHeadersGrid($('#GridDiv'), {}).init();

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