#pragma checksum "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ab5c9690c1239a72e24a9a1c0cf4473bd0e94bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ab5c9690c1239a72e24a9a1c0cf4473bd0e94bf", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9a9d701aef0f9b483f837ef592222cd1e5bb453", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DemoIndentityCore.Areas.Identity.Data.ITask>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Management Task</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ab5c9690c1239a72e24a9a1c0cf4473bd0e94bf4244", async() => {
                WriteLiteral("Create New Task");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TaskId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contentt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TimeStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TimeEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TaskStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TaskId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Contentt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TimeStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TimeEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TaskStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml"
           Write(Html.ActionLink("Add user", "AddUser", new {  id=item.TaskId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 59 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new {  id=item.TaskId  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 60 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {  id=item.TaskId  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\Admin\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DemoIndentityCore.Areas.Identity.Data.ITask>> Html { get; private set; }
    }
}
#pragma warning restore 1591
