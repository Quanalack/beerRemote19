#pragma checksum "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\AdminLTE\Examples\PacePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84c34d59e1f6c7c22146abf96e7c50ef407490d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_AdminLTE_Examples_PacePage), @"mvc.1.0.view", @"/Modules/AdminLTE/Examples/PacePage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/AdminLTE/Examples/PacePage.cshtml", typeof(AspNetCore.Modules_AdminLTE_Examples_PacePage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84c34d59e1f6c7c22146abf96e7c50ef407490d0", @"/Modules/AdminLTE/Examples/PacePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3254ced552f0dad62c9e8654f29630ba694f49ac", @"/Modules/_ViewImports.cshtml")]
    public class Modules_AdminLTE_Examples_PacePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/adminlte/demo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\AdminLTE\Examples\PacePage.cshtml"
  
    ViewData["Title"] = "Pace";

#line default
#line hidden
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Head", async() => {
                BeginContext(57, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(63, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2d52f524a5643ad9cc247bbe06c5de2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(113, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(118, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ContentHeader", async() => {
                BeginContext(144, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(155, 17, false);
#line 10 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\AdminLTE\Examples\PacePage.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(172, 38, true);
                WriteLiteral("<small> loading example</small></h1>\r\n");
                EndContext();
            }
            );
            BeginContext(213, 1660, true);
            WriteLiteral(@"
<!-- Default box -->
<div class=""box"">
    <div class=""box-header with-border"">
        <h3 class=""box-title"">Title</h3>
        <div class=""box-tools pull-right"">
            <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                <i class=""fa fa-minus""></i>
            </button>
            <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove"" data-toggle=""tooltip"" title=""Remove"">
                <i class=""fa fa-times""></i>
            </button>
        </div>
    </div>
    <div class=""box-body"">
        Pace loading works automatically on page. You can still implement it with ajax requests by adding this js:
        <br /><code>$(document).ajaxStart(function() { Pace.restart(); });</code>
        <br />
        <div class=""row"">
            <div class=""col-xs-12 text-center"">
                <button type=""button"" class=""btn btn-default btn-lrg ajax"" title=""Ajax Request"">
                    <i class=""");
            WriteLiteral(@"fa fa-spin fa-refresh""></i>&nbsp; Get External Content
                </button>
            </div>
        </div>
        <div class=""ajax-content"">
        </div>
    </div>
    <!-- /.box-body -->
    <div class=""box-footer"">
        Footer
    </div>
    <!-- /.box-footer-->
</div>
<!-- /.box -->

<script type=""text/javascript"">
	// To make Pace works on Ajax calls
	$(document).ajaxStart(function() { Pace.restart(); });
    $('.ajax').click(function(){
        $.ajax({url: '#', success: function(result){
            $('.ajax-content').html('<hr>Ajax Request Completed !');
        }});
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