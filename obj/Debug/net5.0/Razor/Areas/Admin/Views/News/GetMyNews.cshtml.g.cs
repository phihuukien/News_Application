#pragma checksum "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3643435e6d3ab577271b777a590f7593664ca72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_News_GetMyNews), @"mvc.1.0.view", @"/Areas/Admin/Views/News/GetMyNews.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3643435e6d3ab577271b777a590f7593664ca72", @"/Areas/Admin/Views/News/GetMyNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"284a1f2bf1346af405739fab82caafc7cf133f05", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_News_GetMyNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BTLASPMONGO.Models.DataModels.News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetMyNews", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
  
    ViewData["Title"] = "GetMyNews";
    Layout = "~/Areas/Admin/Views/Shared/LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content-header\">\r\n    <div class=\"container-fluid\">\r\n        <div style=\"text-align: center; \">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3643435e6d3ab577271b777a590f7593664ca725164", async() => {
                WriteLiteral("  <h1 class=\"m-0\" style=\" color: #0cb674; \"> Danh sách các tin của bạn </h1>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div><!-- /.container-fluid -->
</div>

<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">
                            Tổng ");
#nullable restore
#line 23 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                            Write(ViewBag.TotalNews);

#line default
#line hidden
#nullable disable
            WriteLiteral(" tin\r\n                        </h3>\r\n                        <div class=\"card-tools\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3643435e6d3ab577271b777a590f7593664ca727134", async() => {
                WriteLiteral("\r\n                                <div class=\"input-group\">\r\n                                    <input type=\"search\" name=\"search_String\" id=\"key_search\" class=\"form-control form-control-lg\" placeholder=\"Search...\"");
                BeginWriteAttribute("value", " value=\"", 1139, "\"", 1169, 1);
#nullable restore
#line 28 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
WriteAttributeValue("", 1147, ViewBag.search_String, 1147, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" onkeyup=""checkKey()"">
                                    <div class=""input-group-append"">
                                        <button type=""submit"" id=""btn_search"" class=""btn btn-lg btn-default"" onclick=""checkKey()"">
                                            <i class=""fa fa-search""></i>
                                        </button>
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>

                    <!-- /.card-header -->
                    <div class=""card-body"">
                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th>
                                        Tiêu đề
                                    </th>
                                    <th>
                                        Ngày đăng
                                    </th>
                                    <th>
                                        Lượt xem
                                    </th>
                                    <th style=""width: 150px"">Trạng thái</th>
                                    <th style=""width: 130px"">Hành động</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 58 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 61 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                       Write(item.news_title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                        <td>");
#nullable restore
#line 63 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                       Write(String.Format("{0: HH:mm,MM/dd/yyyy}", item.published_time));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                                        <th>");
#nullable restore
#line 66 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                       Write(item.total_views);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                                        <td style=\"display:flex;\">\r\n");
#nullable restore
#line 69 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                             if (item.status == 1)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge badge-warning mr-4\" style=\"line-height:unset;\">Approving</span>\r\n");
#nullable restore
#line 72 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                                
                                            }
                                            else if (item.status == 2)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge badge-primary mr-4\" style=\"line-height:unset;\">Writting</span>\r\n");
#nullable restore
#line 77 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                            }
                                            else if (item.status == 3)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge badge-success mr-4\" style=\"line-height:unset;\">Published</span>\r\n");
#nullable restore
#line 81 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                                
                                            }
                                            else if (item.status == 4)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge badge-danger mr-4\" style=\"line-height:unset;\">lock</span>\r\n");
#nullable restore
#line 86 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                               
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge badge-dark mr-4\" style=\"line-height:unset;\">No Status</span>\r\n");
#nullable restore
#line 91 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                        </td>\r\n                                        <td style=\"text-align:center;\">\r\n\r\n\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3643435e6d3ab577271b777a590f7593664ca7215256", async() => {
                WriteLiteral(" <span class=\"badge bg-success\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"View!\"><i class=\"fas fa-eye\"></i></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                                                     WriteLiteral(item._id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 101 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                    <div class=\"card-footer clearfix\" style=\"text-align:center;\">\r\n\r\n\r\n");
#nullable restore
#line 108 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                         if ((ViewBag.total_Page == 0) || (ViewBag.total_Page == 0 && ViewBag.search_String == ""))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span style=\"color:red;\">no documents</span>\r\n");
#nullable restore
#line 111 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <ul class=\"pagination pagination-sm m-0 float-right\">\r\n");
#nullable restore
#line 113 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                             if (ViewBag.total_Page == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\"><a class=\"page-link\" hre=\"#\">1</a></li>\r\n");
#nullable restore
#line 116 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                            }
                            else if (ViewBag.total_Page > 1)
                            {

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                 if (ViewBag.page != 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3643435e6d3ab577271b777a590f7593664ca7219901", async() => {
                WriteLiteral("&laquo;");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                                                                         WriteLiteral(ViewBag.page-1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                                                                                                                      WriteLiteral(ViewBag.search_String);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["search_String"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-search_String", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["search_String"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 123 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                 for (int i = 1; i <= ViewBag.total_Page; i++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3643435e6d3ab577271b777a590f7593664ca7223635", async() => {
#nullable restore
#line 126 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                                                                                                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 126 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                                                                        WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 126 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                                                                                                       WriteLiteral(ViewBag.search_String);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["search_String"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-search_String", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["search_String"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6575, "page-link", 6575, 9, true);
#nullable restore
#line 126 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
AddHtmlAttributeValue("  ", 6584, ViewBag.page == i?"checked_page" :"" , 6586, 40, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 127 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                 if (ViewBag.page != ViewBag.total_Page)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3643435e6d3ab577271b777a590f7593664ca7228171", async() => {
                WriteLiteral("&raquo;");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 131 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                                                                                           WriteLiteral(ViewBag.page+1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 131 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                                                                                                                                        WriteLiteral(ViewBag.search_String);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["search_String"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-search_String", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["search_String"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 132 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"ml-2 mt-1\">  <span>Page: ");
#nullable restore
#line 133 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                                               Write(ViewBag.page);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 133 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"
                                                                                Write(ViewBag.total_Page);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n");
#nullable restore
#line 134 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\GetMyNews.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                    <!-- /.card-body -->
                </div>
            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->
    </div>
    <!-- /.container-fluid -->
</section>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function checkKey() {
            var key = document.getElementById(""key_search"").value;
            if (key == """") {
                document.querySelector(""#btn_search"").disabled = true;
                $('#btn_search').keyup(function (event) {
                    if (event.keyCode == 13) {
                        return false
                    }
                });
            } else {
                document.querySelector(""#btn_search"").disabled = false;
            }

        }
        function change_status(id) {
            if ($('#' + id).is("":checked"")) {
                var formData = new FormData();
                formData.append(""_id"", id);
                formData.append(""status"", 3);
                $.ajax({
                    url: '/admin/news/change-status',
                    type: 'POST',
                    data: formData,
                    processData: false,
                    contentType: false,
                    success: functi");
                WriteLiteral(@"on (data) {

                        setTimeout(function () {
                            reloadwindow();
                        }, 2000);
                        $.Toast(""update"", ""You Published News"", ""success"", {
                            has_icon: true,
                            has_close_btn: true,
                            stack: true,
                            fullscreen: false,
                            timeout: 2000,
                            sticky: false,
                            has_progress: true,
                            rtl: false,
                        });

                    },
                    error: function (msg) {
                        console.log(msg);
                    }
                });
            } else {
                var formData = new FormData();
                formData.append(""_id"", id);
                formData.append(""status"", 4);
                $.ajax({
                    url: '/admin/news/change-status',
        ");
                WriteLiteral(@"            type: 'POST',
                    data: formData,
                    processData: false,
                    contentType: false,
                    success: function (data) {

                        setTimeout(function () {
                            reloadwindow();
                        }, 2000);
                        $.Toast(""update"", ""You Locked News"", ""success"", {
                            has_icon: true,
                            has_close_btn: true,
                            stack: true,
                            fullscreen: false,
                            timeout: 2000,
                            sticky: false,
                            has_progress: true,
                            rtl: false,
                        });
                    },
                    error: function (msg) {
                        console.log(msg);
                    }
                });
            }
        }
        function reloadwindow() {
            lo");
                WriteLiteral("cation.reload();\r\n        }\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BTLASPMONGO.Models.DataModels.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
