#pragma checksum "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Editors\LookupFilterByMultipleValues\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f483e8fa26415ae38c8520f793a0a0ab457aedc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Editors_LookupFilterByMultipleValues_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Editors/LookupFilterByMultipleValues/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/BasicSamples/Editors/LookupFilterByMultipleValues/Index.cshtml", typeof(AspNetCore.Modules_BasicSamples_Editors_LookupFilterByMultipleValues_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f483e8fa26415ae38c8520f793a0a0ab457aedc2", @"/Modules/BasicSamples/Editors/LookupFilterByMultipleValues/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3254ced552f0dad62c9e8654f29630ba694f49ac", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Editors_LookupFilterByMultipleValues_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Editors\LookupFilterByMultipleValues\Index.cshtml"
  
    ViewData["Title"] = "Lookup Filtering By Multiple Values (IN)";

#line default
#line hidden
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ContentHeader", async() => {
                BeginContext(102, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(113, 17, false);
#line 6 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Editors\LookupFilterByMultipleValues\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(130, 22, true);
                WriteLiteral("<small></small></h1>\r\n");
                EndContext();
            }
            );
            BeginContext(155, 789, true);
            WriteLiteral(@"
<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>
        This sample demonstrates how to filter a lookup client side by multiple values.
    </p>
    <p>
        You can normally use LookupField and LookupValue to filter a lookup editor by single value,
        but to use multiple values with IN(...) filtering you need to define a custom editor.
    </p>
    <p>
        Here we use a subclass of LookupEditor to show only Produce and Seafood in category
        editor of product dialog. Creating custom editors in Serenity is actually simple. 
        See ProduceSeafoodCategoyEditor.ts.
    </p>

    <p style=""text-align: right;""><b>Source Files:</b> 
        ");
            EndContext();
            BeginContext(945, 34, false);
#line 25 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Editors\LookupFilterByMultipleValues\Index.cshtml"
   Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(979, 12, true);
            WriteLiteral(", \r\n        ");
            EndContext();
            BeginContext(992, 51, false);
#line 26 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Editors\LookupFilterByMultipleValues\Index.cshtml"
   Write(Html.AppSourceFile("LookupFilterByMultipleForm.cs"));

#line default
#line hidden
            EndContext();
            BeginContext(1043, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1054, 53, false);
#line 27 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Editors\LookupFilterByMultipleValues\Index.cshtml"
   Write(Html.AppSourceFile("LookupFilterByMultipleDialog.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(1107, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1118, 51, false);
#line 28 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Editors\LookupFilterByMultipleValues\Index.cshtml"
   Write(Html.AppSourceFile("LookupFilterByMultipleGrid.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(1169, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1180, 53, false);
#line 29 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Editors\LookupFilterByMultipleValues\Index.cshtml"
   Write(Html.AppSourceFile("ProduceSeafoodCategoryEditor.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 267, true);
            WriteLiteral(@"
    </p>
</div>

<div id=""GridDiv""></div>

<script type=""text/javascript"">
    jQuery(function () {
        new Serene1.BasicSamples.LookupFilterByMultipleGrid($('#GridDiv'), {}).init();

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
