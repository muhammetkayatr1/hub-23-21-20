#pragma checksum "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\Admin\VideoListAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24b741245cd117d1e513d27aa6f785f72b0abbee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_VideoListAdmin), @"mvc.1.0.view", @"/Views/Admin/VideoListAdmin.cshtml")]
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
#line 1 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\_ViewImports.cshtml"
using HalicHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\_ViewImports.cshtml"
using Halic.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24b741245cd117d1e513d27aa6f785f72b0abbee", @"/Views/Admin/VideoListAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d447f06f600cad35a08585f36a3d6ae0aa3e3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_VideoListAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VideoListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-3 btn-create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float: right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VideoCreateAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/VideoDeleteAdmin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n");
#nullable restore
#line 3 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\Admin\VideoListAdmin.cshtml"
   Layout = "_LayoutAdmin"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--[if lt IE 8]>
        <p class=""browserupgrade"">You are using an <strong>outdated</strong> browser. Please <a href=""http://browsehappy.com/"">upgrade your browser</a> to improve your experience.</p>
    <![endif]-->
<!-- preloader area start -->
<div id=""preloader"">
    <div class=""loader""></div>
</div>
<!-- preloader area end -->
<!-- page container area start -->
<div class=""page-container"">
    <!-- sidebar menu area start -->
    ");
#nullable restore
#line 16 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\Admin\VideoListAdmin.cshtml"
Write(await Html.PartialAsync("_AdminMenu"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <!-- sidebar menu area end -->
    <!-- main content area start -->
    <div class=""main-content"">
        <!-- header area start -->
        <div class=""header-area"">
            <div class=""row align-items-center"">
                <!-- nav and search button -->
                <div class=""col-md-6 col-sm-8 clearfix menu-mobil"">
                    <div class=""nav-btn pull-left"">
                        <span></span>
                        <span></span>
                        <span></span>
                    </div>
                </div>
                <!-- profile info & task notification -->
                <div class=""col-md-6 col-sm-4 clearfix menu-mobil"">
                    <ul class=""notification-area pull-right"">
                        <li id=""full-view""><i class=""ti-fullscreen""></i></li>
                        <li id=""full-view-exit""><i class=""ti-zoom-out""></i></li>
                        <li class=""dropdown"">
                            <i class=""ti-settings dropdown-toggle"" data-toggle");
            WriteLiteral(@"=""dropdown""></i>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Profil</a>
                                <a class=""dropdown-item"" href=""#"">Roller</a>
                                <a class=""dropdown-item"" href=""#"">Çıkış Yap</a>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <!-- header area end -->
        <!-- page title area start -->
        <div class=""page-title-area"" style=""margin-top: 20px;background-color: #F3F8FB"">
            <div class=""row align-items-center"">
                <div class=""col-sm-6"">
                    <div class=""breadcrumbs-area clearfix"">
                        <h4 class=""page-title pull-left"">Dashboard</h4>
                        <ul class=""breadcrumbs pull-left"">
                            <li><a href=""anasayfa.html"">Anasayfa</a></li>
                            <li><span>Videolar</span></");
            WriteLiteral(@"li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <!-- page title area end -->
        <div class=""main-content-inner"">
            <div class=""row"">
                <!-- data table start -->
                <div class=""col-12 mt-5"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <h4 class=""header-title"" style=""display: inline-block; margin-right: 20px"">Videolar</h4>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24b741245cd117d1e513d27aa6f785f72b0abbee10603", async() => {
                WriteLiteral("Video Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""data-tables"">
                                <table id=""dataTable"" class=""text-center"">
                                    <thead class=""bg-light text-capitalize"">
                                        <tr>
                                            <th>Id</th>
                                            <th>Başlık</th>
                                            <th>Url</th>
                                            <th>Tarih</th>
                                            <th>Güncelle</th>
                                            <th>Sil</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 85 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\Admin\VideoListAdmin.cshtml"
                                         if (Model.Videos.Count > 0)//ürün varsa gel foreachı çalıştır
                                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\Admin\VideoListAdmin.cshtml"
                             foreach (var item in Model.Videos)//her ürüne göre oluşacak
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td>");
#nullable restore
#line 90 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\Admin\VideoListAdmin.cshtml"
                                           Write(item.VideoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 91 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\Admin\VideoListAdmin.cshtml"
                                           Write(item.Tittle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 92 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\Admin\VideoListAdmin.cshtml"
                                           Write(item.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 93 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\Admin\VideoListAdmin.cshtml"
                                           Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4678, "\"", 4720, 2);
            WriteAttributeValue("", 4685, "/admin/VideoEditAdmin/", 4685, 22, true);
#nullable restore
#line 95 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\Admin\VideoListAdmin.cshtml"
WriteAttributeValue("", 4707, item.VideoId, 4707, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary btn-sm mr-2"">Güncelle</a>
                                                
                                            </td>
                                            <td>
                                               
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24b741245cd117d1e513d27aa6f785f72b0abbee15846", async() => {
                WriteLiteral("\n                                                    <input type=\"hidden\" name=\"VideoId\"");
                BeginWriteAttribute("value", " value=\"", 5156, "\"", 5177, 1);
#nullable restore
#line 101 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\Admin\VideoListAdmin.cshtml"
WriteAttributeValue("", 5164, item.VideoId, 5164, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                                    <button type=\"submit\" class=\"btn btn-danger btn-sm\">Sil</button>\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                            </td>\n                                        </tr>");
#nullable restore
#line 105 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\Admin\VideoListAdmin.cshtml"
                                             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\Admin\VideoListAdmin.cshtml"
                                               }
                        else 

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\Admin\VideoListAdmin.cshtml"
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-warning\" role=\"alert\">\n                <h3>Video Yok</h3>\n            </div>");
#nullable restore
#line 109 "C:\Users\muhammetkaya\Desktop\hubguncel-main - Copy\HalicHub\Views\Admin\VideoListAdmin.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- main content area end -->
    <!-- footer area start-->
    <footer>
        <div class=""footer-area"">
            <p>© Copyright 2020. Tüm hakları saklıdır. | <a href=""http://www.halic.edu.tr/tr"" target=""_blank""> Haliç Üniversitesi</a>.</p>
        </div>
    </footer>
    <!-- footer area end-->
</div>
<!-- page container area end -->
<!-- offset area start -->

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VideoListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
