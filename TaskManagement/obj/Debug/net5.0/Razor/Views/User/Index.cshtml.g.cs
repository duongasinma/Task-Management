#pragma checksum "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4eca18079a33d60967c889a2944bc9e1a284440c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eca18079a33d60967c889a2944bc9e1a284440c", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9a9d701aef0f9b483f837ef592222cd1e5bb453", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DemoIndentityCore.Areas.Identity.Data.ITask>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\User\Index.cshtml"
  
    ViewData["Title"] = "My Task";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List My Task</h1>\r\n\r\n<p>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TaskId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contentt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TimeStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TimeEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\User\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TaskId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Contentt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TimeStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TimeEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>               \r\n                ");
#nullable restore
#line 53 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\User\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.TaskId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\DUONGAS\Documents\VS_Projects\PRN07_ProjectTaskManagement\TaskMaganement\DemoIndentityCore\Views\User\Index.cshtml"
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
