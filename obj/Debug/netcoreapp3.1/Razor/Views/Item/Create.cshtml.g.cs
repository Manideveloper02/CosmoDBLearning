#pragma checksum "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15debf913130b08848681b128b0623efb7a67fd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Create), @"mvc.1.0.view", @"/Views/Item/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15debf913130b08848681b128b0623efb7a67fd9", @"/Views/Item/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba3874256156cd1ae0c440ea12051fa4e40a5fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<todo.Models.Item>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bundles/jqueryval"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
  
    ViewBag.Title = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Create a new To-Do Item</h2>\n\n\n");
#nullable restore
#line 11 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
 using (Html.BeginForm()) 
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\n    <hr />\n    ");
#nullable restore
#line 17 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 19 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
   Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 21 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
       Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 22 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    ");
#nullable restore
#line 25 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 27 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
   Write(Html.LabelFor(model => model.Test, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 29 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
       Write(Html.EditorFor(model => model.Test, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 30 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Test, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 34 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
   Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 36 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
       Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 37 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 42 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
   Write(Html.LabelFor(model => model.Completed, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            <div class=\"checkbox\">\n                ");
#nullable restore
#line 45 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
           Write(Html.EditorFor(model => model.Completed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 46 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Completed, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        <div class=\"col-md-offset-2 col-md-10\">\n            <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\n        </div>\n    </div>\n</div>\n");
#nullable restore
#line 57 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    ");
#nullable restore
#line 60 "D:\LearningCosmos\CosmoDBLearning\Views\Item\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15debf913130b08848681b128b0623efb7a67fd99117", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<todo.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
