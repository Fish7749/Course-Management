#pragma checksum "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "009f8ef2d2393ad3819a33160c051333bf7d5417c7088a4cbe669d0866308eab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_ListCourseAdmin), @"mvc.1.0.view", @"/Views/Courses/ListCourseAdmin.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\_ViewImports.cshtml"
using Courses_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\_ViewImports.cshtml"
using Courses_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"009f8ef2d2393ad3819a33160c051333bf7d5417c7088a4cbe669d0866308eab", @"/Views/Courses/ListCourseAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1204829c9cdc7244b680ef7e304fc0092fbb53936f6d83b4c4e3bb13602f3552", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Courses_ListCourseAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Courses_MVC.Models.Course>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NavBar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AlertMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Courses/listCourseAdmin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Courses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
  
    ViewData["Title"] = "Danh sách khóa học";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<main class=\"main\">\n    <div class=\"sidebar-admin\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "009f8ef2d2393ad3819a33160c051333bf7d5417c7088a4cbe669d0866308eab7023", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n    <section class=\"section-courseadmin\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "009f8ef2d2393ad3819a33160c051333bf7d5417c7088a4cbe669d0866308eab8226", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <h1 class=\"text-center mt-3\">");
#nullable restore
#line 14 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                                Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n        <p class=\"count--css\">Số lượng khóa học: ");
#nullable restore
#line 15 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                                                Write(ViewBag.count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <div class=\"search-create\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "009f8ef2d2393ad3819a33160c051333bf7d5417c7088a4cbe669d0866308eab10090", async() => {
                WriteLiteral(@"
                <div class=""form-inline "">
                    <label class=""control-label "" style=""margin-right: 5px;"">Tìm kiếm</label>
                    <input type=""text"" name=""searchString"" class=""form-control col-md-6"">
                    <input type=""submit"" class=""btn btn-info"" name=""submit"" value=""search"">
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            <div>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "009f8ef2d2393ad3819a33160c051333bf7d5417c7088a4cbe669d0866308eab12036", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i>Thêm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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

        <div class=""table-overflow"">
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>
                            STT
                        </th>
                        <th>
                            ");
#nullable restore
#line 37 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                       Write(Html.DisplayNameFor(model => model.courseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n");
            WriteLiteral("                        <th>\n                            ");
#nullable restore
#line 43 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                       Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 46 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                       Write(Html.DisplayNameFor(model => model.originalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n");
            WriteLiteral("                        <th>\n                            ");
#nullable restore
#line 52 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                       Write(Html.DisplayNameFor(model => model.totalTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 55 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                       Write(Html.DisplayNameFor(model => model.totalStudent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 58 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                       Write(Html.DisplayNameFor(model => model.Topic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 61 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                       Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>Chức năng</th>\n                    </tr>\n                </thead>\n                <tbody>\n");
#nullable restore
#line 67 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"row-listcourses-admin\">\n                            <td class=\"counterCell\">\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 73 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                           Write(Html.DisplayFor(modelItem => item.courseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n");
            WriteLiteral("                            <td>\n                                ");
#nullable restore
#line 79 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                           Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 82 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                           Write(Html.DisplayFor(modelItem => item.originalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n");
            WriteLiteral("                            <td>\n                                ");
#nullable restore
#line 88 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                           Write(Html.DisplayFor(modelItem => item.totalTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 91 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                           Write(Html.DisplayFor(modelItem => item.totalStudent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 94 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Topic.topicName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 97 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Discount.discription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "009f8ef2d2393ad3819a33160c051333bf7d5417c7088a4cbe669d0866308eab20104", async() => {
                WriteLiteral("<i class=\"far fa-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                                                          WriteLiteral(item.courseId);

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
            WriteLiteral(" |\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "009f8ef2d2393ad3819a33160c051333bf7d5417c7088a4cbe669d0866308eab22386", async() => {
                WriteLiteral("<i class=\"far fa-trash-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                                                               WriteLiteral(item.courseId);

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
            WriteLiteral("\n                            </td>\n                        </tr>\n");
#nullable restore
#line 104 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n\n    </section>\n</main>\n");
            WriteLiteral("<script>\n    const active_lienhe = document.querySelector(\'#active--khoahoc\')\n    active_lienhe.classList.add(\'active--css\')\n    /*document.querySelector(\'#active--khoahoc\').classList.remove(\'active--css\')*/\n</script>\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 118 "C:\Users\Admin\Desktop\Course-Management-main\Courses_MVC\Courses_MVC\Views\Courses\ListCourseAdmin.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Courses_MVC.Models.Course>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
