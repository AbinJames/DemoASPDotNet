#pragma checksum "D:\DemoASPDotNet\WebApplication1\Views\Home\EditStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "140666d4d5098e493068e103c232192a8a16f06a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditStudent), @"mvc.1.0.view", @"/Views/Home/EditStudent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/EditStudent.cshtml", typeof(AspNetCore.Views_Home_EditStudent))]
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
#line 1 "D:\DemoASPDotNet\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "D:\DemoASPDotNet\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"140666d4d5098e493068e103c232192a8a16f06a", @"/Views/Home/EditStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EditStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("my-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddNewStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(41, 37, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    ");
            EndContext();
            BeginContext(78, 1923, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dca5ccdd06444676a5e633f612cec1ad", async() => {
                BeginContext(166, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(177, 100, false);
#line 6 "D:\DemoASPDotNet\WebApplication1\Views\Home\EditStudent.cshtml"
   Write(Html.TextBoxFor(model => model.studentId,new { @class = "form-control", @placeholder = ViewBag.id} ));

#line default
#line hidden
                EndContext();
                BeginContext(277, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(309, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(318, 64, false);
#line 8 "D:\DemoASPDotNet\WebApplication1\Views\Home\EditStudent.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(382, 194, true);
                WriteLiteral("\r\n        <div class=\"form-group row\">\r\n            <label for=\"full_name\" class=\"col-md-12 col-form-label text-md-right\">Full Name</label>\r\n            <div class=\"col-md-12\">\r\n                ");
                EndContext();
                BeginContext(577, 136, false);
#line 12 "D:\DemoASPDotNet\WebApplication1\Views\Home\EditStudent.cshtml"
           Write(Html.EditorFor(model => model.studentName, new { htmlAttributes = new { @class = "form-control", @placeholder = ViewBag.studentName } }));

#line default
#line hidden
                EndContext();
                BeginContext(713, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(771, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(788, 81, false);
#line 14 "D:\DemoASPDotNet\WebApplication1\Views\Home\EditStudent.cshtml"
           Write(Html.ValidationMessageFor(m => m.studentName, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(869, 40, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n");
                EndContext();
                BeginContext(935, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(944, 64, false);
#line 19 "D:\DemoASPDotNet\WebApplication1\Views\Home\EditStudent.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1008, 170, true);
                WriteLiteral("\r\n        <div class=\"form-group row\">\r\n            <label for=\"batch\" class=\"col-md-12 col-form-label text-md-right\">Batch</label>\r\n            <div class=\"col-md-12\">\r\n");
                EndContext();
#line 24 "D:\DemoASPDotNet\WebApplication1\Views\Home\EditStudent.cshtml"
                  
                    List<WebApplication1.Models.Batch> list = ViewBag.Batches;
                    var items = new SelectList(list, "batchId", "batchName", selectedValue: ViewBag.batch);
                

#line default
#line hidden
                BeginContext(1451, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1501, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1520, 109, false);
#line 29 "D:\DemoASPDotNet\WebApplication1\Views\Home\EditStudent.cshtml"
           Write(Html.DropDownListFor(x => x.batchId, @items, "Nil", new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1629, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(1687, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1704, 77, false);
#line 31 "D:\DemoASPDotNet\WebApplication1\Views\Home\EditStudent.cshtml"
           Write(Html.ValidationMessageFor(x => x.batchId, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1781, 213, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-6 offset-md-4\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">\r\n                Register\r\n            </button>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2001, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
