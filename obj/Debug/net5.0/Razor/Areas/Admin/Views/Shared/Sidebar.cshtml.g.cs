#pragma checksum "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Shared\Sidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c943c13b88d50664f0ad5703e330084bf8126417"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Sidebar), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Sidebar.cshtml")]
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
#nullable restore
#line 1 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Shared\Sidebar.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c943c13b88d50664f0ad5703e330084bf8126417", @"/Areas/Admin/Views/Shared/Sidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"284a1f2bf1346af405739fab82caafc7cf133f05", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Sidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetMyNews", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "News", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"  <!-- Main Sidebar Container -->
<aside class=""main-sidebar sidebar-dark-primary elevation-4"">
    <!-- Brand Logo -->
    <a href=""index3.html"" class=""brand-link"">
        <img src=""/Admin/dist/img/AdminLTELogo.png"" alt=""AdminLTE Logo"" class=""brand-image img-circle elevation-3"" style=""opacity: .8"">
        <span class=""brand-text font-weight-light"">MAGNEWS</span>
    </a>

    <!-- Sidebar -->
    <div class=""sidebar"">
        <!-- Sidebar user panel (optional) -->
        <div class=""user-panel mt-3 pb-3 mb-3 d-flex"">
            <div class=""image"">
                <img");
            BeginWriteAttribute("src", " src=\"", 702, "\"", 752, 2);
            WriteAttributeValue("", 708, "/", 708, 1, true);
#nullable restore
#line 16 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Shared\Sidebar.cshtml"
WriteAttributeValue("", 709, User.Claims.Skip(3).FirstOrDefault().Value, 709, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-circle elevation-2\" alt=\"User Image\">\r\n            </div>\r\n            <div class=\"info\">\r\n                <a href=\"#\" class=\"d-block\">");
#nullable restore
#line 19 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\Shared\Sidebar.cshtml"
                                       Write(User.Claims.Skip(1).FirstOrDefault().Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
            </div>
        </div>

        <!-- SidebarSearch Form -->
        <div class=""form-inline"">
        </div>

        <!-- Sidebar Menu -->
        <nav class=""mt-2"">
            <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">

                <li class=""nav-item menu-open"">
                    <a href=""#"" class=""nav-link active"">
                        <i class=""nav-icon fas fa-tachometer-alt""></i>
                        <p>
                            Quản lý website
                            <i class=""right fas fa-angle-left""></i>
                        </p>
                    </a>
                    <ul class=""nav nav-treeview"">
                        <li class=""nav-item"">
                            <a href=""/admin"" class=""nav-link active"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Tổng quan</p>
                            </a>
    ");
            WriteLiteral(@"                    </li>
                        <li class=""nav-item"">
                            <a href=""/admin/category"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Danh muc tin tức</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""/admin/news"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Tin tức</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c943c13b88d50664f0ad5703e330084bf81264177653", async() => {
                WriteLiteral("\r\n                                <i class=\"far fa-circle nav-icon\"></i>\r\n                                <p>Tin tức của tôi</p>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n                    </ul>\r\n                </li>\r\n\r\n\r\n            </ul>\r\n        </nav>\r\n        <!-- /.sidebar-menu -->\r\n    </div>\r\n    <!-- /.sidebar -->\r\n</aside>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
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
