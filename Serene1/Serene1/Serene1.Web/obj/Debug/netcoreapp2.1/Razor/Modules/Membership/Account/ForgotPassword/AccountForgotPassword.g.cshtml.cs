#pragma checksum "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3207f42efc8a85054f48cb1e48dcbb21d2bba6a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_ForgotPassword_AccountForgotPassword), @"mvc.1.0.view", @"/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.cshtml", typeof(AspNetCore.Modules_Membership_Account_ForgotPassword_AccountForgotPassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3207f42efc8a85054f48cb1e48dcbb21d2bba6a6", @"/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3254ced552f0dad62c9e8654f29630ba694f49ac", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_ForgotPassword_AccountForgotPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml"
  
    ViewData["Title"] = Texts.Forms.Membership.ForgotPassword.FormTitle;
    ViewData["PageId"] = "ForgotPassword";
    Layout = MVC.Views.Shared._LayoutNoNavigation;

#line default
#line hidden
            BeginContext(177, 120, true);
            WriteLiteral("\r\n<script id=\"Template_Membership_ForgotPasswordPanel\" type=\"text/template\">\r\n    <div>\r\n        <h3 class=\"page-title\">");
            EndContext();
            BeginContext(298, 47, false);
#line 9 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml"
                          Write(Texts.Forms.Membership.ForgotPassword.FormTitle);

#line default
#line hidden
            EndContext();
            BeginContext(345, 36, true);
            WriteLiteral("</h3>\r\n        <p class=\"form-info\">");
            EndContext();
            BeginContext(382, 46, false);
#line 10 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml"
                        Write(Texts.Forms.Membership.ForgotPassword.FormInfo);

#line default
#line hidden
            EndContext();
            BeginContext(428, 435, true);
            WriteLiteral(@"</p>
        <form id=""~_Form"" action="""">
            <div class=""s-Form"">
                <div class=""fieldset ui-widget ui-widget-content ui-corner-all"">
                    <div id=""~_PropertyGrid""></div>
                    <div class=""clear""></div>
                </div>
                <div class=""buttons"">
                    <button id=""~_SubmitButton"" type=""submit"" class=""btn btn-primary"">
                        ");
            EndContext();
            BeginContext(864, 50, false);
#line 19 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml"
                   Write(Texts.Forms.Membership.ForgotPassword.SubmitButton);

#line default
#line hidden
            EndContext();
            BeginContext(914, 351, true);
            WriteLiteral(@"
                    </button>
                </div>
            </div>
        </form>
    </div>
</script>

<div class=""page-content"">
    <div id=""ForgotPasswordPanel"">
    </div>
</div>

<script type=""text/javascript"">
$(function() {
    new Serene1.Membership.ForgotPasswordPanel($('#ForgotPasswordPanel')).init();
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
