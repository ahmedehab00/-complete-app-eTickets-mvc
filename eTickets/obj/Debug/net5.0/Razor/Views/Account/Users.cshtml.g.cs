#pragma checksum "E:\Project E-Commerce\Project eTickets\eTickets\eTickets\Views\Account\Users.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "20cf35a1de3097af3d348e2f1a8d3533f3f8f92e1a215c4b0bd1800b77706fdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Users), @"mvc.1.0.view", @"/Views/Account/Users.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Project E-Commerce\Project eTickets\eTickets\eTickets\Views\_ViewImports.cshtml"
using eTickets

#nullable disable
    ;
#nullable restore
#line 2 "E:\Project E-Commerce\Project eTickets\eTickets\eTickets\Views\_ViewImports.cshtml"
using eTickets.Models

#nullable disable
    ;
#nullable restore
#line 3 "E:\Project E-Commerce\Project eTickets\eTickets\eTickets\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"20cf35a1de3097af3d348e2f1a8d3533f3f8f92e1a215c4b0bd1800b77706fdc", @"/Views/Account/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a5dee59e67e5ca943218e3cb9eab0bb2214ad84e6aaf66ed9a75b5370da36a44", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\Project E-Commerce\Project eTickets\eTickets\eTickets\Views\Account\Users.cshtml"
  
    ViewData["Title"] = "List of all users";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-6 offset-3\">\n        <p>\n            <h4>List of all users</h4>\n        </p>\n\n        <table class=\"table\">\n            <thead>\n                <tr class=\"text-center\">\n                    <th>");
            Write(
#nullable restore
#line 16 "E:\Project E-Commerce\Project eTickets\eTickets\eTickets\Views\Account\Users.cshtml"
                         Html.DisplayNameFor(model => model.FullName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\n                    <th>");
            Write(
#nullable restore
#line 17 "E:\Project E-Commerce\Project eTickets\eTickets\eTickets\Views\Account\Users.cshtml"
                         Html.DisplayNameFor(model => model.UserName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\n                    <th>");
            Write(
#nullable restore
#line 18 "E:\Project E-Commerce\Project eTickets\eTickets\eTickets\Views\Account\Users.cshtml"
                         Html.DisplayNameFor(model => model.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 22 "E:\Project E-Commerce\Project eTickets\eTickets\eTickets\Views\Account\Users.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <tr>\n                    <td class=\"align-middle\">\n                        ");
            Write(
#nullable restore
#line 26 "E:\Project E-Commerce\Project eTickets\eTickets\eTickets\Views\Account\Users.cshtml"
                         Html.DisplayFor(modelItem => item.FullName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                    </td>\n                    <td class=\"align-middle\">\n                        ");
            Write(
#nullable restore
#line 29 "E:\Project E-Commerce\Project eTickets\eTickets\eTickets\Views\Account\Users.cshtml"
                         Html.DisplayFor(modelItem => item.UserName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                    </td>\n                    <td class=\"align-middle\">\n                        ");
            Write(
#nullable restore
#line 32 "E:\Project E-Commerce\Project eTickets\eTickets\eTickets\Views\Account\Users.cshtml"
                         Html.DisplayFor(modelItem => item.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 35 "E:\Project E-Commerce\Project eTickets\eTickets\eTickets\Views\Account\Users.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </tbody>\n\n        </table>\n\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
