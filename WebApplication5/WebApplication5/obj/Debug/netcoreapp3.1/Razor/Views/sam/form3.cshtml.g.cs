#pragma checksum "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\form3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3521ab007a770ec3e30a0a3e30e54bdbfc81ad0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_sam_form3), @"mvc.1.0.view", @"/Views/sam/form3.cshtml")]
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
#nullable restore
#line 1 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3521ab007a770ec3e30a0a3e30e54bdbfc81ad0d", @"/Views/sam/form3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac7a6a20369a094c1643b76f0e92e19ec3cef6a", @"/Views/_ViewImports.cshtml")]
    public class Views_sam_form3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication5.Views.sam.logindetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\form3.cshtml"
 using (Html.BeginForm("form3", "sam", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label>  enter username:</label>\r\n");
#nullable restore
#line 6 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\form3.cshtml"
Write(Html.TextBoxFor(x => x.username));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <label>  enter Password:</label>\r\n");
#nullable restore
#line 11 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\form3.cshtml"
Write(Html.PasswordFor(x => x.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <label> Emailid:</label>\r\n");
#nullable restore
#line 16 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\form3.cshtml"
Write(Html.TextBoxFor(x => x.mailid));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"login\" />\r\n");
#nullable restore
#line 21 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\form3.cshtml"
Write(Html.ValidationSummary(false));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\form3.cshtml"
                                  

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication5.Views.sam.logindetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
