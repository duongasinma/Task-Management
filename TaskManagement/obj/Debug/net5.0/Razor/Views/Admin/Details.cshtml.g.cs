#pragma checksum "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dd8e14d1809aae03f19cf2a34f435df86478c57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Details), @"mvc.1.0.view", @"/Views/Admin/Details.cshtml")]
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
#line 1 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\_ViewImports.cshtml"
using DemoIndentityCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\_ViewImports.cshtml"
using DemoIndentityCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd8e14d1809aae03f19cf2a34f435df86478c57", @"/Views/Admin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9a9d701aef0f9b483f837ef592222cd1e5bb453", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DemoIndentityCore.Areas.Identity.Data.ITask>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details Of Task</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TaskId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.TaskId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Contentt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.Contentt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TimeStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.TimeStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TimeEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.TimeEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TaskStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.TaskStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 51 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Details.cshtml"
Write(Html.ActionLink("User on task", "ViewUserOnTask", new { id = Model.TaskId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>\r\n\r\n    ");
#nullable restore
#line 53 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.TaskId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dd8e14d1809aae03f19cf2a34f435df86478c579039", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DemoIndentityCore.Areas.Identity.Data.ITask> Html { get; private set; }
    }
}
#pragma warning restore 1591
