#pragma checksum "/home/krzys/projects/blogcsharp/Blog/Blog.Mvc/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb1e90f8367dfc552e0f27b5ba1f44c5d32f81b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/home/krzys/projects/blogcsharp/Blog/Blog.Mvc/Views/_ViewImports.cshtml"
using Blog.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/krzys/projects/blogcsharp/Blog/Blog.Mvc/Views/_ViewImports.cshtml"
using Blog.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb1e90f8367dfc552e0f27b5ba1f44c5d32f81b0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df941764ae9160f67fea2a9bcf878d362ff20832", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog.Entities.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/krzys/projects/blogcsharp/Blog/Blog.Mvc/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-6 text-center\">\r\n        <h2>Login</h2>\r\n");
#nullable restore
#line 9 "/home/krzys/projects/blogcsharp/Blog/Blog.Mvc/Views/Home/Index.cshtml"
         using (Html.BeginForm("User", "Login", FormMethod.Post, new { enctype = "multipart/form-data" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/krzys/projects/blogcsharp/Blog/Blog.Mvc/Views/Home/Index.cshtml"
       Write(Html.TextBoxFor(m => @Model.Email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/krzys/projects/blogcsharp/Blog/Blog.Mvc/Views/Home/Index.cshtml"
       Write(Html.TextBoxFor(m => @Model.Password));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/krzys/projects/blogcsharp/Blog/Blog.Mvc/Views/Home/Index.cshtml"
       Write(Html.ValidationMessageFor(m => @Model.Email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/krzys/projects/blogcsharp/Blog/Blog.Mvc/Views/Home/Index.cshtml"
       Write(Html.ValidationMessageFor(m => @Model.Password));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/krzys/projects/blogcsharp/Blog/Blog.Mvc/Views/Home/Index.cshtml"
                                                            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"col-md-6 text-center\">\r\n        <h2>Register</h2>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog.Entities.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
