#pragma checksum "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Dialogs\SerialAutoNumber\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5919da8283aab2f186b68ae1889f4965ab00ad5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Dialogs_SerialAutoNumber_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Dialogs/SerialAutoNumber/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/BasicSamples/Dialogs/SerialAutoNumber/Index.cshtml", typeof(AspNetCore.Modules_BasicSamples_Dialogs_SerialAutoNumber_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5919da8283aab2f186b68ae1889f4965ab00ad5", @"/Modules/BasicSamples/Dialogs/SerialAutoNumber/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3254ced552f0dad62c9e8654f29630ba694f49ac", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Dialogs_SerialAutoNumber_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Dialogs\SerialAutoNumber\Index.cshtml"
  
    ViewData["Title"] = "Serial Auto Numbering";

#line default
#line hidden
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ContentHeader", async() => {
                BeginContext(83, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(94, 17, false);
#line 6 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Dialogs\SerialAutoNumber\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(111, 22, true);
                WriteLiteral("<small></small></h1>\r\n");
                EndContext();
            }
            );
            BeginContext(136, 825, true);
            WriteLiteral(@"
<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>
        Here we demonstrate how to implement auto numbering that is commonly used with invoice numbers. 
        First time you add a new record, Customer ID will start with C0001, next one will be C0002, etc.
    </p>
    <p>
        You may also try typing other prefixes. Clear the customer ID and type X. Dialog will 
        automatically bring next number in that series like X0001.
    </p>
    <p>
        As currently, there are no numeric Customer IDs in database, so you'll need to add a few
        to see that numbers actually gets automatically increased.
    </p>

    <p style=""text-align: right;"">
        <b>Source Files:</b>
        ");
            EndContext();
            BeginContext(962, 34, false);
#line 26 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Dialogs\SerialAutoNumber\Index.cshtml"
   Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(996, 11, true);
            WriteLiteral(",\r\n        ");
            EndContext();
            BeginContext(1008, 45, false);
#line 27 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Dialogs\SerialAutoNumber\Index.cshtml"
   Write(Html.AppSourceFile("SerialAutoNumberGrid.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(1053, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1064, 47, false);
#line 28 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Dialogs\SerialAutoNumber\Index.cshtml"
   Write(Html.AppSourceFile("SerialAutoNumberDialog.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 261, true);
            WriteLiteral(@"
    </p>
</div>

<div id=""GridDiv""></div>

<script type=""text/javascript"">
    jQuery(function () {
        new Serene1.BasicSamples.SerialAutoNumberGrid($('#GridDiv'), {}).init();

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
