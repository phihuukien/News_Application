#pragma checksum "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34e4a6298b0e6ebb296e79ffb73f2c5e505c630b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\_ViewImports.cshtml"
using BTLASPMONGO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\_ViewImports.cshtml"
using BTLASPMONGO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34e4a6298b0e6ebb296e79ffb73f2c5e505c630b", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"284a1f2bf1346af405739fab82caafc7cf133f05", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Areas/Admin/Views/Shared/LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"" style=""justify-content:center;"">
            <div class=""col-sm-6"">
                <h1 class=""m-0"" style=""text-align:center;"">Tổng Quan</h1>
            </div><!-- /.col -->

        </div><!-- /.row -->
    </div><!-- /.container-fluid -->
</div>
<!-- /.content-header -->
<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <!-- Small boxes (Stat box) -->
        <div class=""row"">
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-info"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 27 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
                       Write(ViewBag.NewsTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                        <p>Tổng toàn bộ tin</p>
                    </div>
                    <div class=""icon"">
                        <i class=""fa fa-newspaper-o"" aria-hidden=""true""></i>
                    </div>
                    <a href=""/admin/news"" class=""small-box-footer"">Thêm thông tin <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-success"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 42 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
                       Write(ViewBag.NewsTotalApproving);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                        <p>Tin đang chờ duyệt</p>\r\n                    </div>\r\n                    <div class=\"icon\">\r\n                        <i class=\"fa fa-ellipsis-h\" aria-hidden=\"true\"></i>\r\n                    </div>\r\n");
#nullable restore
#line 49 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
                     if (@ViewBag.NewsTotalApproving > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"/Admin/news/status/1\" class=\"small-box-footer\">Thêm thông tin <i class=\"fas fa-arrow-circle-right\"></i></a>\r\n");
#nullable restore
#line 52 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"small-box-footer\">Thêm thông tin <i class=\"fas fa-arrow-circle-right\"></i></a>\r\n");
#nullable restore
#line 56 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-3 col-6\">\r\n                <!-- small box -->\r\n                <div class=\"small-box bg-danger\">\r\n                    <div class=\"inner\">\r\n                        <h3>");
#nullable restore
#line 65 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
                       Write(ViewBag.NewsTotalLocked);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                        <p>Tin đã khóa</p>\r\n                    </div>\r\n                    <div class=\"icon\">\r\n                        <i class=\"fa fa-lock\" aria-hidden=\"true\"></i>\r\n                    </div>\r\n");
#nullable restore
#line 72 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
                     if (@ViewBag.NewsTotalLocked > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"/Admin/news/status/4 \" class=\"small-box-footer\">Thêm thông tin <i class=\"fas fa-arrow-circle-right\"></i></a>\r\n");
#nullable restore
#line 75 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"small-box-footer\">Thêm thông tin <i class=\"fas fa-arrow-circle-right\"></i></a>\r\n");
#nullable restore
#line 79 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-warning"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 87 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
                       Write(ViewBag.NewsTotalWriting);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                        <p>Tin đang viết</p>\r\n                    </div>\r\n                    <div class=\"icon\">\r\n                        <i class=\"fa fa-pen-square\" aria-hidden=\"true\"></i>\r\n                    </div>\r\n");
#nullable restore
#line 94 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
                     if (@ViewBag.NewsTotalWriting > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"/Admin/news/status/2\" class=\"small-box-footer\">Thêm thông tin <i class=\"fas fa-arrow-circle-right\"></i></a>\r\n");
#nullable restore
#line 97 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a  class=\"small-box-footer\">Thêm thông tin <i class=\"fas fa-arrow-circle-right\"></i></a>\r\n");
#nullable restore
#line 101 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"col-lg-3 col-6\">\r\n                <!-- small box -->\r\n                <div class=\"small-box bg-gradient-maroon\">\r\n                    <div class=\"inner\">\r\n                        <h3>");
#nullable restore
#line 108 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
                       Write(ViewBag.NewsTotalPublished);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                        <p>Tin đã đăng</p>\r\n                    </div>\r\n                    <div class=\"icon\">\r\n                        <i class=\"fa fa-check-square-o\" aria-hidden=\"true\"></i>\r\n                    </div>\r\n");
#nullable restore
#line 115 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
                     if (@ViewBag.NewsTotalPublished > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"/Admin/news/status/3 \" class=\"small-box-footer\">Thêm thông tin <i class=\"fas fa-arrow-circle-right\"></i></a>\r\n");
#nullable restore
#line 118 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a  class=\"small-box-footer\">Thêm thông tin <i class=\"fas fa-arrow-circle-right\"></i></a>\r\n");
#nullable restore
#line 122 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
            <!-- ./col -->
            <!-- ./col -->
        </div>
        <!-- /.row -->

        <div class=""row"">
            <div class=""col-12 col-sm-6 col-md-3"">
                <div class=""info-box"">
                    <span class=""info-box-icon bg-info elevation-1"">  <i class=""fa fa-newspaper-o"" aria-hidden=""true""></i></span>

                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Tin đã đăng hôm nay</span>
                        <span class=""info-box-number"">
                            ");
#nullable restore
#line 138 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Home\Index.cshtml"
                       Write(ViewBag.NewsTotalToday);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
            </div>
     
        </div>

    </div><!-- /.container-fluid -->
</section>
<!-- /.content -->
");
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
