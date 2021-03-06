#pragma checksum "D:\DemoASPDotNet\WebApplication1\Views\Home\AllStudents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "611727c7d8fc250bfc19246557d12928f43531a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllStudents), @"mvc.1.0.view", @"/Views/Home/AllStudents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AllStudents.cshtml", typeof(AspNetCore.Views_Home_AllStudents))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"611727c7d8fc250bfc19246557d12928f43531a9", @"/Views/Home/AllStudents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllStudents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\DemoASPDotNet\WebApplication1\Views\Home\AllStudents.cshtml"
  
    ViewData["Title"] = "AllEmployees";

#line default
#line hidden
            BeginContext(50, 38, true);
            WriteLiteral("\r\n<h4>All Students (Inner Join)</h4>\r\n");
            EndContext();
#line 8 "D:\DemoASPDotNet\WebApplication1\Views\Home\AllStudents.cshtml"
 foreach (var student in ViewData["Students"] as IList<WebApplication1.Models.StudentViewModel>)
{

#line default
#line hidden
            BeginContext(233, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(241, 12, false);
#line 10 "D:\DemoASPDotNet\WebApplication1\Views\Home\AllStudents.cshtml"
  Write(student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(253, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(256, 17, false);
#line 10 "D:\DemoASPDotNet\WebApplication1\Views\Home\AllStudents.cshtml"
                 Write(student.BatchName);

#line default
#line hidden
            EndContext();
            BeginContext(273, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 11 "D:\DemoASPDotNet\WebApplication1\Views\Home\AllStudents.cshtml"
}

#line default
#line hidden
            BeginContext(282, 43, true);
            WriteLiteral("\r\n<h4>All Students (Left Outer Join)</h4>\r\n");
            EndContext();
#line 15 "D:\DemoASPDotNet\WebApplication1\Views\Home\AllStudents.cshtml"
 foreach (var student in ViewData["LeftOuteredStudents"] as IList<WebApplication1.Models.StudentViewModel>)
{

#line default
#line hidden
            BeginContext(486, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(494, 12, false);
#line 17 "D:\DemoASPDotNet\WebApplication1\Views\Home\AllStudents.cshtml"
  Write(student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(506, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(509, 17, false);
#line 17 "D:\DemoASPDotNet\WebApplication1\Views\Home\AllStudents.cshtml"
                 Write(student.BatchName);

#line default
#line hidden
            EndContext();
            BeginContext(526, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 18 "D:\DemoASPDotNet\WebApplication1\Views\Home\AllStudents.cshtml"
    //link to edit student by passing student id
    

#line default
#line hidden
            BeginContext(587, 77, false);
#line 19 "D:\DemoASPDotNet\WebApplication1\Views\Home\AllStudents.cshtml"
Write(Html.ActionLink("Edit", "EditStudent", "Home", new { id = student.Id }, null));

#line default
#line hidden
            EndContext();
#line 19 "D:\DemoASPDotNet\WebApplication1\Views\Home\AllStudents.cshtml"
                                                                                  ;
}

#line default
#line hidden
            BeginContext(670, 35, true);
            WriteLiteral("<h4>All Batches (Group Join)</h4>\r\n");
            EndContext();
#line 23 "D:\DemoASPDotNet\WebApplication1\Views\Home\AllStudents.cshtml"
 foreach (var item in ViewData["GroupStudent"] as IList<WebApplication1.Models.BatchViewModel>)
{

#line default
#line hidden
            BeginContext(863, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(871, 10, false);
#line 25 "D:\DemoASPDotNet\WebApplication1\Views\Home\AllStudents.cshtml"
  Write(item.batch);

#line default
#line hidden
            EndContext();
            BeginContext(881, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 26 "D:\DemoASPDotNet\WebApplication1\Views\Home\AllStudents.cshtml"
     foreach(var student in item.student)
    {

#line default
#line hidden
            BeginContext(937, 29, true);
            WriteLiteral("        <p>student.name</p>\r\n");
            EndContext();
#line 29 "D:\DemoASPDotNet\WebApplication1\Views\Home\AllStudents.cshtml"
    }

#line default
#line hidden
#line 29 "D:\DemoASPDotNet\WebApplication1\Views\Home\AllStudents.cshtml"
     
}

#line default
#line hidden
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
