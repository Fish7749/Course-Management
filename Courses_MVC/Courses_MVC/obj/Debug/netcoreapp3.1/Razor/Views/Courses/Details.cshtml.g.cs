#pragma checksum "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c9c9c759eee2bd343bf86d0da444a05da90b9b4d4326b57140b5db7a53d1b6a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Details), @"mvc.1.0.view", @"/Views/Courses/Details.cshtml")]
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
#line 1 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\_ViewImports.cshtml"
using Courses_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\_ViewImports.cshtml"
using Courses_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c9c9c759eee2bd343bf86d0da444a05da90b9b4d4326b57140b5db7a53d1b6a4", @"/Views/Courses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1204829c9cdc7244b680ef7e304fc0092fbb53936f6d83b4c4e3bb13602f3552", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Courses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Courses_MVC.Models.Course>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NavBar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AlertMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListCourseAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
  
    ViewData["Title"] = "Chi tiết khóa học";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<main class=\"main\">\n    <div class=\"sidebar-admin\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c9c9c759eee2bd343bf86d0da444a05da90b9b4d4326b57140b5db7a53d1b6a45069", async() => {
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
            WriteLiteral("\n    </div>\n    <section class=\"section-add_course\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c9c9c759eee2bd343bf86d0da444a05da90b9b4d4326b57140b5db7a53d1b6a46271", async() => {
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
            WriteLiteral("\n        <h1 class=\"text-center mt-3\" style=\"padding-top:30px\">COURSE DETAILS</h1>\n        <div class=\"ml-5\">\n            <div");
            BeginWriteAttribute("class", " class=\"", 437, "\"", 445, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                <hr />\n\n                <dl class=\"row\" style=\"font-size:20px\">\n                    <dt class=\"col-sm-3\">\n                        ");
#nullable restore
#line 22 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.courseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-9\">\n                        ");
#nullable restore
#line 25 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                   Write(Html.DisplayFor(model => model.courseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-3\">\n                        ");
#nullable restore
#line 28 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.discription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-9\">\n                        ");
#nullable restore
#line 31 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                   Write(Html.DisplayFor(model => model.discription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-3\">\n                        ");
#nullable restore
#line 34 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-9\">\n                        ");
#nullable restore
#line 37 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                   Write(Html.DisplayFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-3\">\n                        ");
#nullable restore
#line 40 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.originalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-9\">\n                        ");
#nullable restore
#line 43 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                   Write(Html.DisplayFor(model => model.originalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
#nullable restore
#line 46 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.imgCourse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-9\">\n                        ");
#nullable restore
#line 49 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                   Write(Html.DisplayFor(model => model.imgCourse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-3\">\n                        ");
#nullable restore
#line 52 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.totalTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-9\">\n                        ");
#nullable restore
#line 55 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                   Write(Html.DisplayFor(model => model.totalTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-3\">\n                        ");
#nullable restore
#line 58 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.totalStudent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-9\">\n                        ");
#nullable restore
#line 61 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                   Write(Html.DisplayFor(model => model.totalStudent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-3\">\n                        ");
#nullable restore
#line 64 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Topic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-9\">\n                        ");
#nullable restore
#line 67 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Topic.topicName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-3\">\n                        ");
#nullable restore
#line 70 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-9\">\n                        ");
#nullable restore
#line 73 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Discount.discription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                </dl>\n            </div>\n            <div class=\"option-detail\">\n\n                <div class=\"back-admin\" style=\"width:100px\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9c9c759eee2bd343bf86d0da444a05da90b9b4d4326b57140b5db7a53d1b6a414900", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n                <div class=\"main-option\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9c9c759eee2bd343bf86d0da444a05da90b9b4d4326b57140b5db7a53d1b6a416165", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
                                                   WriteLiteral(Model.courseId);

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
            WriteLiteral(@"
                </div>

            </div>
        </div>
    </section>
</main>
<script>
    const active_lienhe = document.querySelector('#active--khoahoc')
    active_lienhe.classList.add('active--css')
    /*document.querySelector('#active--khoahoc').classList.remove('active--css')*/
</script>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 96 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Courses\Details.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Courses_MVC.Models.Course> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
