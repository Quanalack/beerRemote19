#pragma checksum "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\Membership\Account\ResetPassword\AccountResetPasswordEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a3083abddce30ecfe6509058a5aa94554852d39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_ResetPassword_AccountResetPasswordEmail), @"mvc.1.0.view", @"/Modules/Membership/Account/ResetPassword/AccountResetPasswordEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/Membership/Account/ResetPassword/AccountResetPasswordEmail.cshtml", typeof(AspNetCore.Modules_Membership_Account_ResetPassword_AccountResetPasswordEmail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3083abddce30ecfe6509058a5aa94554852d39", @"/Modules/Membership/Account/ResetPassword/AccountResetPasswordEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3254ced552f0dad62c9e8654f29630ba694f49ac", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_ResetPassword_AccountResetPasswordEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Serene1.Membership.ResetPasswordEmailModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(61, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cf5cfba154b43da85e32e1c52ad4a75", async() => {
                BeginContext(67, 50, true);
                WriteLiteral("\r\n    <title>Reset your Serene1 password</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(124, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(126, 362, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bd726edef214735b34fcf3182c22a11", async() => {
                BeginContext(132, 9, true);
                WriteLiteral("\r\n    <p>");
                EndContext();
                BeginContext(142, 17, false);
#line 8 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\Membership\Account\ResetPassword\AccountResetPasswordEmail.cshtml"
  Write(Model.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(159, 148, true);
                WriteLiteral(",</p>\r\n\r\n    <p>We received a request to change your password on Serene1.</p>\r\n\r\n    <p>Click the link below to set a new password:</p>\r\n\r\n    <p><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 307, "\"", 330, 1);
#line 14 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\Membership\Account\ResetPassword\AccountResetPasswordEmail.cshtml"
WriteAttributeValue("", 314, Model.ResetLink, 314, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(331, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(333, 15, false);
#line 14 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\Membership\Account\ResetPassword\AccountResetPasswordEmail.cshtml"
                             Write(Model.ResetLink);

#line default
#line hidden
                EndContext();
                BeginContext(348, 133, true);
                WriteLiteral("</a></p>\r\n\r\n    <p>If you don\'t want to change your password, you can ignore this email.</p>\r\n\r\n    Thanks,\r\n    The \"Serene1\" Team\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(488, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Serene1.Membership.ResetPasswordEmailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
