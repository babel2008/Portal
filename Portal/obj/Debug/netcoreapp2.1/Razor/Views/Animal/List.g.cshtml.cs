#pragma checksum "E:\programowanie\Core\Portal\Portal\Portal\Views\Animal\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe09f0a4aebc129d59718b7bcf8ca017a4bf9068"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animal_List), @"mvc.1.0.view", @"/Views/Animal/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Animal/List.cshtml", typeof(AspNetCore.Views_Animal_List))]
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
#line 1 "E:\programowanie\Core\Portal\Portal\Portal\Views\_ViewImports.cshtml"
using Portal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe09f0a4aebc129d59718b7bcf8ca017a4bf9068", @"/Views/Animal/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf33d8c7e530ffc8103159abc8a4acfe14fa3a20", @"/Views/_ViewImports.cshtml")]
    public class Views_Animal_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Animal>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\programowanie\Core\Portal\Portal\Portal\Views\Animal\List.cshtml"
 foreach (var p in Model)
{

#line default
#line hidden
            BeginContext(60, 23, true);
            WriteLiteral("    <div>\r\n        <h3>");
            EndContext();
            BeginContext(84, 6, false);
#line 6 "E:\programowanie\Core\Portal\Portal\Portal\Views\Animal\List.cshtml"
       Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(90, 15, true);
            WriteLiteral("</h3>\r\n        ");
            EndContext();
            BeginContext(106, 13, false);
#line 7 "E:\programowanie\Core\Portal\Portal\Portal\Views\Animal\List.cshtml"
   Write(p.Description);

#line default
#line hidden
            EndContext();
            BeginContext(119, 24, true);
            WriteLiteral("\r\n        \r\n    </div>\r\n");
            EndContext();
#line 10 "E:\programowanie\Core\Portal\Portal\Portal\Views\Animal\List.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Animal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
