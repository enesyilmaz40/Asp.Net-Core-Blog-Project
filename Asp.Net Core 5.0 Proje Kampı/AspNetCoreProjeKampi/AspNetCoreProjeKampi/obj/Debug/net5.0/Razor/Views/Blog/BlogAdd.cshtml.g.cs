#pragma checksum "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Blog\BlogAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d258632c43930e80a0aa69f341d56eda70f6b184"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogAdd), @"mvc.1.0.view", @"/Views/Blog/BlogAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d258632c43930e80a0aa69f341d56eda70f6b184", @"/Views/Blog/BlogAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eb2476c8f0a430caa9c19f0d86cf9a15f013083", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Blog\BlogAdd.cshtml"
  
    ViewData["Title"] = "BlogAdd";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yeni Blog Girişi</h1>\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Blog\BlogAdd.cshtml"
 using (Html.BeginForm("BlogAdd", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 18 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 24 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Küçük Görsel"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.BlogThumbnailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 29 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Blog\BlogAdd.cshtml"
Write(Html.DropDownListFor(x=>x.CategoryID,(List<SelectListItem>)ViewBag.cv,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 34 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Blog\BlogAdd.cshtml"
Write(Html.TextAreaFor(x => x.BlogContent, 20, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Kaydet</button>\r\n");
#nullable restore
#line 39 "C:\Users\enes_\OneDrive\Masaüstü\C#\Asp.Net Core 5.0 Proje Kampı\AspNetCoreProjeKampi\AspNetCoreProjeKampi\Views\Blog\BlogAdd.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
