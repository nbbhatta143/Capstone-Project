#pragma checksum "D:\C# Programming\Capstone Stuff\GroupBCapstoneProject\GroupBCapstoneProject\Views\Home\StudentHome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d31a2003b25d72524692473c28cec1832bfda22e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StudentHome), @"mvc.1.0.view", @"/Views/Home/StudentHome.cshtml")]
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
#line 1 "D:\C# Programming\Capstone Stuff\GroupBCapstoneProject\GroupBCapstoneProject\Views\_ViewImports.cshtml"
using GroupBCapstoneProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C# Programming\Capstone Stuff\GroupBCapstoneProject\GroupBCapstoneProject\Views\_ViewImports.cshtml"
using GroupBCapstoneProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d31a2003b25d72524692473c28cec1832bfda22e", @"/Views/Home/StudentHome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50fe17463a6e178e695157ba9184f8ef4f726319", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StudentHome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <ul>\r\n        <li><a");
            BeginWriteAttribute("href", " href=\"", 151, "\"", 214, 1);
#nullable restore
#line 6 "D:\C# Programming\Capstone Stuff\GroupBCapstoneProject\GroupBCapstoneProject\Views\Home\StudentHome.cshtml"
WriteAttributeValue("", 158, Url.Content("~/Views/Brochures/Accounting Program.pdf"), 158, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Accounting Track</a></li>\r\n        <li><a");
            BeginWriteAttribute("href", " href=\"", 257, "\"", 318, 1);
#nullable restore
#line 7 "D:\C# Programming\Capstone Stuff\GroupBCapstoneProject\GroupBCapstoneProject\Views\Home\StudentHome.cshtml"
WriteAttributeValue("", 264, Url.Content("~/Views/Brochures/Business Program.pdf"), 264, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Business Track</a></li>\r\n        <li><a");
            BeginWriteAttribute("href", " href=\"", 359, "\"", 419, 1);
#nullable restore
#line 8 "D:\C# Programming\Capstone Stuff\GroupBCapstoneProject\GroupBCapstoneProject\Views\Home\StudentHome.cshtml"
WriteAttributeValue("", 366, Url.Content("~/Views/Brochures/ComputerScience.pdf"), 366, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Computer Science Track</a></li>\r\n        <li><a");
            BeginWriteAttribute("href", " href=\"", 468, "\"", 537, 1);
#nullable restore
#line 9 "D:\C# Programming\Capstone Stuff\GroupBCapstoneProject\GroupBCapstoneProject\Views\Home\StudentHome.cshtml"
WriteAttributeValue("", 475, Url.Content("~/Views/Brochures/Criminal Justice Program.pdf"), 475, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Criminal Justice Track</a></li>\r\n        <li><a");
            BeginWriteAttribute("href", " href=\"", 586, "\"", 647, 1);
#nullable restore
#line 10 "D:\C# Programming\Capstone Stuff\GroupBCapstoneProject\GroupBCapstoneProject\Views\Home\StudentHome.cshtml"
WriteAttributeValue("", 593, Url.Content("~/Views/Brochures/Culinary Program.pdf"), 593, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Culinary Track</a></li>\r\n        <li><a");
            BeginWriteAttribute("href", " href=\"", 688, "\"", 750, 1);
#nullable restore
#line 11 "D:\C# Programming\Capstone Stuff\GroupBCapstoneProject\GroupBCapstoneProject\Views\Home\StudentHome.cshtml"
WriteAttributeValue("", 695, Url.Content("~/Views/Brochures/Marketing Program.pdf"), 695, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Marketing Track</a></li>\r\n        <li><a");
            BeginWriteAttribute("href", " href=\"", 792, "\"", 852, 1);
#nullable restore
#line 12 "D:\C# Programming\Capstone Stuff\GroupBCapstoneProject\GroupBCapstoneProject\Views\Home\StudentHome.cshtml"
WriteAttributeValue("", 799, Url.Content("~/Views/Brochures/Spanish Program.pdf"), 799, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Spanish Track</a></li>\r\n    </ul>\r\n");
            WriteLiteral("    <p>Enrolled Classes</p>\r\n    <p>Query the database (specifically the enrollments table), make a list</p>\r\n");
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
