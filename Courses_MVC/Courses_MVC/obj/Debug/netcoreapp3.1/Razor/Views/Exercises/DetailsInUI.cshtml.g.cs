#pragma checksum "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ab6d505e99776178df9cb03f56251b8132d8807f17c01dc69ad7a193025e74e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exercises_DetailsInUI), @"mvc.1.0.view", @"/Views/Exercises/DetailsInUI.cshtml")]
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
#line 1 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
using Courses_MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ab6d505e99776178df9cb03f56251b8132d8807f17c01dc69ad7a193025e74e5", @"/Views/Exercises/DetailsInUI.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1204829c9cdc7244b680ef7e304fc0092fbb53936f6d83b4c4e3bb13602f3552", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Exercises_DetailsInUI : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exercise>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/LessonDetail.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AlertMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/ExerciseInUsers/SubmitExercise"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
  
    var listId = ViewBag.listIdExercise;
    var idcurrent = Model.exerciseId;
    var length = listId.Length;
    var idMin = listId[0].exerciseId;
    var idMax = listId[length - 1].exerciseId;
    var idPre = idcurrent - 1;
    var idNext = idcurrent + 1;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ab6d505e99776178df9cb03f56251b8132d8807f17c01dc69ad7a193025e74e56899", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<div class=\"container col-9 container-custom mb-5\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ab6d505e99776178df9cb03f56251b8132d8807f17c01dc69ad7a193025e74e58094", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    <div class=\"lesson-title mt-4 p-4 pb-2 text-center \">");
#nullable restore
#line 20 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
                                                    Write(Model.exerciseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    <div class=\"lesson-info pb-2 pt-3 p-4\">\n        <div class=\"lesson-info-teacher\"><i class=\"fas fa-chalkboard-teacher\"></i><b>Tác giả:</b> ");
#nullable restore
#line 22 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
                                                                                             Write(Model.AppUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"lesson-info-deadline\"><i class=\"fas fa-hourglass-start\">Deadline:</i> ");
#nullable restore
#line 23 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
                                                                                     Write(Model.deadline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    </div>\n    <div class=\"lesson-content mb-3 pl-4 pr-4\">\n        <b>Nội dung:</b>\n        <p>\n            ");
#nullable restore
#line 28 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
       Write(Model.content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </div>\n    <div class=\"exercise-input mb-1 pl-4 pr-4\">\n        <b>Input:</b>\n        <div>");
#nullable restore
#line 33 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
        Write(Model.input);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    </div>\n    <div class=\"exercise-output mb-1 pl-4 pr-4\">\n        <b>Output:</b>\n        ");
#nullable restore
#line 37 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
   Write(Model.output);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"do-exercise mb-3 pl-4 pr-4\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab6d505e99776178df9cb03f56251b8132d8807f17c01dc69ad7a193025e74e511685", async() => {
                WriteLiteral("\n            <input type=\"hidden\" name=\"exerciseId\"");
                BeginWriteAttribute("value", " value=\"", 1514, "\"", 1539, 1);
#nullable restore
#line 41 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
WriteAttributeValue("", 1522, Model.exerciseId, 1522, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n            <input type=\"hidden\" name=\"lessonId\"");
                BeginWriteAttribute("value", " value=\"", 1592, "\"", 1615, 1);
#nullable restore
#line 42 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
WriteAttributeValue("", 1600, Model.lessonId, 1600, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

            <label for=""place-do-exercise""><b>Làm bài tập:</b></label>
            <textarea name=""content""
                      id=""place-do-exercise""
                      cols=""30"" rows=""10"" placeholder=""Nhập bài làm của bạn""
                      class=""form-control""
                      required>

            </textarea>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab6d505e99776178df9cb03f56251b8132d8807f17c01dc69ad7a193025e74e513259", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 52 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.content);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            <button class=\"btn btn-primary\" type=\"submit\">Nộp bài</button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n    </div>\n    \n\n    <div class=\"move-lesson p-4 pt-0\">\n\n");
#nullable restore
#line 61 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
         if (idPre == idMin - 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"next-lesson\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 2274, "\"", 2320, 2);
            WriteAttributeValue("", 2281, "/lesson/LessonDetail?Id=", 2281, 24, true);
#nullable restore
#line 64 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
WriteAttributeValue("", 2305, Model.lessonId, 2305, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"pre-lesson-btn\">Quay lại bài học</a>\n            </div>\n            <div class=\"pre-lesson\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 2440, "\"", 2480, 2);
            WriteAttributeValue("", 2447, "/Exercises/DetailsInUI?Id=", 2447, 26, true);
#nullable restore
#line 67 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
WriteAttributeValue("", 2473, idNext, 2473, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"pre-lesson-btn\">Kế tiếp</a>\n            </div>\n");
#nullable restore
#line 69 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
        }
        else if (idNext == idMax + 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"next-lesson\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 2650, "\"", 2689, 2);
            WriteAttributeValue("", 2657, "/Exercises/DetailsInUI?Id=", 2657, 26, true);
#nullable restore
#line 73 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
WriteAttributeValue("", 2683, idPre, 2683, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"pre-lesson-btn\">Quay lại</a>\n            </div>\n            <div class=\"next-lesson\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 2802, "\"", 2848, 2);
            WriteAttributeValue("", 2809, "/lesson/LessonDetail?Id=", 2809, 24, true);
#nullable restore
#line 76 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
WriteAttributeValue("", 2833, Model.lessonId, 2833, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"pre-lesson-btn\">Quay lại bài học</a>\n            </div>\n");
#nullable restore
#line 78 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"next-lesson\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 3002, "\"", 3041, 2);
            WriteAttributeValue("", 3009, "/Exercises/DetailsInUI?Id=", 3009, 26, true);
#nullable restore
#line 82 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
WriteAttributeValue("", 3035, idPre, 3035, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"pre-lesson-btn\">Quay lại</a>\n            </div>\n            <div class=\"pre-lesson\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 3153, "\"", 3193, 2);
            WriteAttributeValue("", 3160, "/Exercises/DetailsInUI?Id=", 3160, 26, true);
#nullable restore
#line 85 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
WriteAttributeValue("", 3186, idNext, 3186, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"pre-lesson-btn\">Kế tiếp</a>\n            </div>\n");
#nullable restore
#line 87 "C:\Users\Admin\source\Fish7749\Courses-Management\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> SignInManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exercise> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
