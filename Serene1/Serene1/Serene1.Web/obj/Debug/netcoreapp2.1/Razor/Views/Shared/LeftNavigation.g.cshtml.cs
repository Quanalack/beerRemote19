#pragma checksum "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\Shared\LeftNavigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba2cb4b026acdb32265d57d0b004ebf42b4df24c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_LeftNavigation), @"mvc.1.0.view", @"/Views/Shared/LeftNavigation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/LeftNavigation.cshtml", typeof(AspNetCore.Views_Shared_LeftNavigation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba2cb4b026acdb32265d57d0b004ebf42b4df24c", @"/Views/Shared/LeftNavigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efd227ca16d5db0ad543ae12477fdce80449a669", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_LeftNavigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Serene1.Navigation.NavigationModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1796, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\Shared\LeftNavigation.cshtml"
  var path = new int[10]; 

#line default
#line hidden
#line 47 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\Shared\LeftNavigation.cshtml"
 foreach (var item in Model.Items)
{
    

#line default
#line hidden
            BeginContext(1871, 25, false);
#line 49 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\Shared\LeftNavigation.cshtml"
Write(renderItem(item, 0, path));

#line default
#line hidden
            EndContext();
#line 49 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\Shared\LeftNavigation.cshtml"
                              ;
}

#line default
#line hidden
            BeginContext(1902, 534, true);
            WriteLiteral(@"
<script type=""text/javascript"">
    function openWindow(url, width, height) {
        height = height || (screen.availHeight - 60);
        width = width || (screen.availWidth - 10);
        var x = (screen.availWidth - width) / 2 - 5; if (x < 0) x = 0;
        var y = (screen.availHeight - height) / 2 - 25; if (y < 0) y = 0;
        var winPopup = window.open(url, """", ""status=0, toolbar=0, width="" + width + "", height="" + height + 
            "", scrollbars=1, resizable=yes, left="" + x + "", top="" + y);
    }
</script>");
            EndContext();
        }
        #pragma warning restore 1998
#line 3 "D:\Programmering\beerRemote19\Serene1\Serene1\Serene1.Web\Views\Shared\LeftNavigation.cshtml"
            
    public HtmlString renderItem(Serenity.Navigation.NavigationItem item, int depth, int[] path) {

        var isactive = true;
        for (var i = 0; i <= depth; i++)
        {
            if (path[i] != Model.ActivePath[i])
            {
                isactive = false;
                break;
            }
        }

        var klass = (isactive ? "active" : "") + (item.Children.IsEmptyOrNull() ? "" : " treeview");
        if (!string.IsNullOrEmpty(item.ItemClass))
        {
            klass = (klass + " " + item.ItemClass).Trim();
        }
        var icon = (item.IconClass ?? (item.Children.Count > 0 ? "icon-layers" : (depth == 0 ? "icon-link" : "fa-circle-o")));
        var title = (LocalText.TryGet("Navigation." + item.FullPath) ?? item.Title);
        var sectionUrl = (item.Url ?? "javascript:;");
        var target = item.Target; if (target != null) { target += " target=" + target; }

        var sb = new System.Text.StringBuilder();
        sb.Append("<li class='" + klass + "'><a href='" + HtmlEncoder.Encode(sectionUrl) + "' " + target + ">" +
        "<i class='nav-icon fa " + icon + "'></i><span>" + HtmlEncoder.Encode(title) + "</span>" + (!item.Children.IsEmptyOrNull() ? "<i class='fa fa-angle-left pull-right'></i>" : "") + "</a>");

        if (item.Children.Count > 0) {
            sb.Append("<ul class='treeview-menu'>");
            path[depth + 1] = 0;
            foreach (var child in item.Children)
            {
                sb.Append(renderItem(child, depth + 1, path).ToString());

            }
            sb.Append("</ul>");
        }
        sb.Append("</li>");
        path[depth]++;
        return new HtmlString(sb.ToString());
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Serene1.Navigation.NavigationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
