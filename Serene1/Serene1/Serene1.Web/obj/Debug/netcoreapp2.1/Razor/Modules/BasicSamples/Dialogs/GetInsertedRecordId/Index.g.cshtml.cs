#pragma checksum "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Dialogs\GetInsertedRecordId\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6af8112dc83e381263f4a451b08e78d25a2d72f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Dialogs_GetInsertedRecordId_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Dialogs/GetInsertedRecordId/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/BasicSamples/Dialogs/GetInsertedRecordId/Index.cshtml", typeof(AspNetCore.Modules_BasicSamples_Dialogs_GetInsertedRecordId_Index))]
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
#line 1 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#line 2 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#line 3 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using Serene1;

#line default
#line hidden
#line 4 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6af8112dc83e381263f4a451b08e78d25a2d72f6", @"/Modules/BasicSamples/Dialogs/GetInsertedRecordId/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3254ced552f0dad62c9e8654f29630ba694f49ac", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Dialogs_GetInsertedRecordId_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Dialogs\GetInsertedRecordId\Index.cshtml"
  
    ViewData["Title"] = "Get Inserted Record Id From Dialog";

#line default
#line hidden
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ContentHeader", async() => {
                BeginContext(96, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(107, 17, false);
#line 6 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Dialogs\GetInsertedRecordId\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(124, 22, true);
                WriteLiteral("<small></small></h1>\r\n");
                EndContext();
            }
            );
            BeginContext(149, 555, true);
            WriteLiteral(@"
<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>
        You might need to get ID of inserted record from a dialog, show some message, 
        or open another dialog for it. onSaveSuccess is a good place for this.
    </p>
    <p>
        Insert a new category and we'll show a message about inserted record. 
        This will do nothing for updates.
    </p>

    <p style=""text-align: right;"">
        <b>Source Files:</b>
        ");
            EndContext();
            BeginContext(705, 34, false);
#line 22 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Dialogs\GetInsertedRecordId\Index.cshtml"
   Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(739, 11, true);
            WriteLiteral(",\r\n        ");
            EndContext();
            BeginContext(751, 50, false);
#line 23 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Dialogs\GetInsertedRecordId\Index.cshtml"
   Write(Html.AppSourceFile("GetInsertedRecordIdDialog.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(801, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(812, 48, false);
#line 24 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\BasicSamples\Dialogs\GetInsertedRecordId\Index.cshtml"
   Write(Html.AppSourceFile("GetInsertedRecordIdGrid.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(860, 264, true);
            WriteLiteral(@"
    </p>
</div>

<div id=""GridDiv""></div>

<script type=""text/javascript"">
    jQuery(function () {
        new Serene1.BasicSamples.GetInsertedRecordIdGrid($('#GridDiv'), {}).init();

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
