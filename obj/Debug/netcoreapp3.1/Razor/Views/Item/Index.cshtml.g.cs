#pragma checksum "D:\LearningCosmos\CosmoDBLearning\Views\Item\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14ddb67ac0c3017f180ba42df1e259ea79733ee4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Index), @"mvc.1.0.view", @"/Views/Item/Index.cshtml")]
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
#line 1 "D:\LearningCosmos\CosmoDBLearning\Views\_ViewImports.cshtml"
using todo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LearningCosmos\CosmoDBLearning\Views\_ViewImports.cshtml"
using todo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14ddb67ac0c3017f180ba42df1e259ea79733ee4", @"/Views/Item/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba3874256156cd1ae0c440ea12051fa4e40a5fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<todo.Models.Item>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Index.cshtml"
  
    ViewBag.Title = "List of To-Do Items";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>List of To-Do Items</h2>\n\n<table class=\"table\">\n    <tr>\n        <th>\n            ");
#nullable restore
#line 13 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 16 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 19 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Completed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th></th>\n    </tr>\n\n");
#nullable restore
#line 24 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>\n            ");
#nullable restore
#line 27 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 30 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 33 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Completed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 36 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Index.cshtml"
       Write(Html.ActionLink("Edit", "Edit", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n            ");
#nullable restore
#line 37 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Index.cshtml"
       Write(Html.ActionLink("Details", "Details", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n            ");
#nullable restore
#line 38 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Index.cshtml"
       Write(Html.ActionLink("Delete", "Delete", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n    </tr>\n");
#nullable restore
#line 41 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>\n\n<p>\n    ");
#nullable restore
#line 46 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<todo.Models.Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591
