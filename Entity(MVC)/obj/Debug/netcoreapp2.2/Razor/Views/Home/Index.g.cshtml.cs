#pragma checksum "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Entity(MVC)\Entity(MVC)\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6304360bd1cb433562b8969dd7c145fd665a8506"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Entity(MVC)\Entity(MVC)\Views\_ViewImports.cshtml"
using Entity_MVC_;

#line default
#line hidden
#line 2 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Entity(MVC)\Entity(MVC)\Views\_ViewImports.cshtml"
using Entity_MVC_.Models;

#line default
#line hidden
#line 3 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Entity(MVC)\Entity(MVC)\Views\_ViewImports.cshtml"
using Entity_MVC_.Data;

#line default
#line hidden
#line 4 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Entity(MVC)\Entity(MVC)\Views\_ViewImports.cshtml"
using Entity_MVC_.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6304360bd1cb433562b8969dd7c145fd665a8506", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a832ba9101a69bba3231ea1f14502404d0fcab29", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(5, 13, false);
#line 1 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Entity(MVC)\Entity(MVC)\Views\Home\Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(18, 38, true);
            WriteLiteral("</h1>\r\n\r\n<div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 4 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Entity(MVC)\Entity(MVC)\Views\Home\Index.cshtml"
      

        foreach (Car car in Model.CarAvailable)
        {
            

#line default
#line hidden
            BeginContext(139, 40, false);
#line 8 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Entity(MVC)\Entity(MVC)\Views\Home\Index.cshtml"
       Write(await Html.PartialAsync("_CarCard", car));

#line default
#line hidden
            EndContext();
#line 8 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Entity(MVC)\Entity(MVC)\Views\Home\Index.cshtml"
                                                     
        }

    

#line default
#line hidden
            BeginContext(201, 8, true);
            WriteLiteral("</div>\r\n");
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