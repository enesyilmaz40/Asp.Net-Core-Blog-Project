#pragma checksum "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Shared\Components\CategoryListDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47e651eb2b1f57e4b06f981b0b667a9401809cdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryListDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryListDashboard/Default.cshtml")]
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
#line 1 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\_ViewImports.cshtml"
using AspNetCoreProjeKampi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\_ViewImports.cshtml"
using AspNetCoreProjeKampi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47e651eb2b1f57e4b06f981b0b667a9401809cdf", @"/Views/Shared/Components/CategoryListDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eb2476c8f0a430caa9c19f0d86cf9a15f013083", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CategoryListDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Project Status</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> Kategori Adı </th>
                                <th> Durum </th>
                                <th> İşlemler </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 20 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                             foreach (var item in Model)
                            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td> ");
#nullable restore
#line 25 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 26 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 27 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                Write(item.CategoryStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar bg-gradient-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </td>
                            </tr>
");
#nullable restore
#line 34 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
