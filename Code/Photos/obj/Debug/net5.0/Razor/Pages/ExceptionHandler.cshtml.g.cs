#pragma checksum "C:\Users\manoj\gitrepo\CloudLearning\Code\Photos\Pages\ExceptionHandler.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35369a8821738a24f77ee6ba1d4761069dc29caa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_ExceptionHandler), @"mvc.1.0.razor-page", @"/Pages/ExceptionHandler.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35369a8821738a24f77ee6ba1d4761069dc29caa", @"/Pages/ExceptionHandler.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da39a3ee5e6b4b0d3255bfef95601890afd80709", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ExceptionHandler : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\manoj\gitrepo\CloudLearning\Code\Photos\Pages\ExceptionHandler.cshtml"
  
    ViewBag.PageTitle = "Error!!";

#line default
#line hidden
#nullable disable
            WriteLiteral("<em>We are unable to handle your request, try again later.</em>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_ExceptionHandler> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_ExceptionHandler> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_ExceptionHandler>)PageContext?.ViewData;
        public Pages_ExceptionHandler Model => ViewData.Model;
    }
}
#pragma warning restore 1591