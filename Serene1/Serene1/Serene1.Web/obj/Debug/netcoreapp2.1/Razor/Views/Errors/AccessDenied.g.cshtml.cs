#pragma checksum "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\Errors\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e093686023c390cfb5918d23fc990009546ce81f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Errors_AccessDenied), @"mvc.1.0.view", @"/Views/Errors/AccessDenied.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Errors/AccessDenied.cshtml", typeof(AspNetCore.Views_Errors_AccessDenied))]
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
#line 1 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#line 2 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#line 3 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\_ViewImports.cshtml"
using Serene1;

#line default
#line hidden
#line 4 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e093686023c390cfb5918d23fc990009546ce81f", @"/Views/Errors/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efd227ca16d5db0ad543ae12477fdce80449a669", @"/Views/_ViewImports.cshtml")]
    public class Views_Errors_AccessDenied : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\Errors\AccessDenied.cshtml"
  
    ViewData["Title"] = Texts.Site.AccessDenied.PageTitle;
    ViewData["PageId"] = "AccessDenied";
    Layout = Serenity.Authorization.IsLoggedIn ?
        "~/Views/Shared/_Layout.cshtml" :
        "~/Views/Shared/_LayoutNoNavigation.cshtml";

#line default
#line hidden
            BeginContext(273, 296, true);
            WriteLiteral(@"
<div class=""page-content"">
    <div class=""message"">
        <table>
            <tr>
                <td style=""width: 200px;"">
                    <i class=""fa fa-times-circle text-red"" style=""font-size: 180px;""></i>
                </td>
                <td>
                    <h1>");
            EndContext();
            BeginContext(570, 33, false);
#line 19 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\Errors\AccessDenied.cshtml"
                   Write(Texts.Site.AccessDenied.PageTitle);

#line default
#line hidden
            EndContext();
            BeginContext(603, 31, true);
            WriteLiteral("</h1>\r\n                    <h3>");
            EndContext();
            BeginContext(636, 113, false);
#line 20 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\Errors\AccessDenied.cshtml"
                    Write(Serenity.Authorization.IsLoggedIn ? Texts.Site.AccessDenied.LackPermissions : Texts.Site.AccessDenied.NotLoggedIn);

#line default
#line hidden
            EndContext();
            BeginContext(750, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 21 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\Errors\AccessDenied.cshtml"
                     if (Model != null)
                    {

#line default
#line hidden
            BeginContext(821, 43, true);
            WriteLiteral("                        <a class=\"redirect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 864, "\"", 902, 2);
            WriteAttributeValue("", 871, "/Account/Login?returnURL=", 871, 25, true);
#line 23 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\Errors\AccessDenied.cshtml"
WriteAttributeValue("", 896, Model, 896, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(903, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(906, 146, false);
#line 23 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\Errors\AccessDenied.cshtml"
                                                                               Write(Serenity.Authorization.IsLoggedIn ? 
                            Texts.Site.AccessDenied.ClickToChangeUser : Texts.Site.AccessDenied.ClickToLogin);

#line default
#line hidden
            EndContext();
            BeginContext(1053, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 25 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\Errors\AccessDenied.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1131, 66, true);
            WriteLiteral("                        <a class=\"redirect\" href=\"/Account/Login\">");
            EndContext();
            BeginContext(1198, 36, false);
#line 28 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\Errors\AccessDenied.cshtml"
                                                             Write(Texts.Site.AccessDenied.ClickToLogin);

#line default
#line hidden
            EndContext();
            BeginContext(1234, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 29 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\Errors\AccessDenied.cshtml"
                    }

#line default
#line hidden
            BeginContext(1263, 69, true);
            WriteLiteral("                    <div class=\"date-time\">\r\n                        ");
            EndContext();
            BeginContext(1334, 83, false);
#line 31 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\Errors\AccessDenied.cshtml"
                    Write(!Serenity.Authorization.IsLoggedIn ? "" : (Serenity.Authorization.Username + " - "));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 44, false);
#line 31 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\Errors\AccessDenied.cshtml"
                                                                                                         Write(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(1463, 165, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"clear\"></div>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        \r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591