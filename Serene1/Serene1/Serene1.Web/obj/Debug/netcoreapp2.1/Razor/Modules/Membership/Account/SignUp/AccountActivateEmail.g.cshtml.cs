#pragma checksum "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\Membership\Account\SignUp\AccountActivateEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72d3844c97767c20c95580810384e8718840a0a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_SignUp_AccountActivateEmail), @"mvc.1.0.view", @"/Modules/Membership/Account/SignUp/AccountActivateEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/Membership/Account/SignUp/AccountActivateEmail.cshtml", typeof(AspNetCore.Modules_Membership_Account_SignUp_AccountActivateEmail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d3844c97767c20c95580810384e8718840a0a7", @"/Modules/Membership/Account/SignUp/AccountActivateEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3254ced552f0dad62c9e8654f29630ba694f49ac", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_SignUp_AccountActivateEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Serene1.Membership.ActivateEmailModel>
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
            BeginContext(46, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(56, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c41358bcf2cf4ec3b695c8004b7e7b1c", async() => {
                BeginContext(62, 52, true);
                WriteLiteral("\r\n    <title>Activate your Serene1 account</title>\r\n");
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
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(123, 390, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6fe23c3fc2243988b6fbf05dffe0343", async() => {
                BeginContext(129, 9, true);
                WriteLiteral("\r\n    <p>");
                EndContext();
                BeginContext(139, 17, false);
#line 8 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\Membership\Account\SignUp\AccountActivateEmail.cshtml"
  Write(Model.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(156, 176, true);
                WriteLiteral(",</p>\r\n\r\n    <p>We received a request to create a new account on Serene1 with your e-mail address.</p>\r\n\r\n    <p>Click the link below to activate your account:</p>\r\n\r\n    <p><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 332, "\"", 358, 1);
#line 14 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\Membership\Account\SignUp\AccountActivateEmail.cshtml"
WriteAttributeValue("", 339, Model.ActivateLink, 339, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(359, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(361, 18, false);
#line 14 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\Membership\Account\SignUp\AccountActivateEmail.cshtml"
                                Write(Model.ActivateLink);

#line default
#line hidden
                EndContext();
                BeginContext(379, 127, true);
                WriteLiteral("</a></p>\r\n\r\n    <p>If it wasn\'t you who requested this, you can ignore this email.</p>\r\n\r\n    Thanks,\r\n    The \"Serene1\" Team\r\n");
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
            BeginContext(513, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Serene1.Membership.ActivateEmailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
