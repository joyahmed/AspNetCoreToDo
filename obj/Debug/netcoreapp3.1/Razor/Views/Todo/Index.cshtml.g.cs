#pragma checksum "D:\Projects\ASP.NET Projects\Examples 2020\AspNetCoreToDo\AspNetCoreToDo\Views\Todo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c65a2354e2bffd2c2760d5ba04afee1fd469d3de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Index), @"mvc.1.0.view", @"/Views/Todo/Index.cshtml")]
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
#line 1 "D:\Projects\ASP.NET Projects\Examples 2020\AspNetCoreToDo\AspNetCoreToDo\Views\_ViewImports.cshtml"
using AspNetCoreToDo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\ASP.NET Projects\Examples 2020\AspNetCoreToDo\AspNetCoreToDo\Views\_ViewImports.cshtml"
using AspNetCoreToDo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\ASP.NET Projects\Examples 2020\AspNetCoreToDo\AspNetCoreToDo\Views\_ViewImports.cshtml"
using AspNetCoreToDo.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\ASP.NET Projects\Examples 2020\AspNetCoreToDo\AspNetCoreToDo\Views\Todo\Index.cshtml"
using Humanizer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c65a2354e2bffd2c2760d5ba04afee1fd469d3de", @"/Views/Todo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e63b848704ac68d98e66489c2f8f3edb81feaa78", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetCoreToDo.ViewModels.TodoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkDone", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Projects\ASP.NET Projects\Examples 2020\AspNetCoreToDo\AspNetCoreToDo\Views\Todo\Index.cshtml"
  
    ViewData["Title"] = "Manage your todo list";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"panel panel-default todo-panel\">\r\n    <div class=\"panel-heading\">");
#nullable restore
#line 8 "D:\Projects\ASP.NET Projects\Examples 2020\AspNetCoreToDo\AspNetCoreToDo\Views\Todo\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <table class=\"table table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <td>&#x2714;</td>\r\n                <td>Item</td>\r\n                <td>Due</td>\r\n            </tr>\r\n        </thead>\r\n");
#nullable restore
#line 17 "D:\Projects\ASP.NET Projects\Examples 2020\AspNetCoreToDo\AspNetCoreToDo\Views\Todo\Index.cshtml"
         foreach (var item in Model.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c65a2354e2bffd2c2760d5ba04afee1fd469d3de5483", async() => {
                WriteLiteral("\r\n                        <input type=\"checkbox\" class=\"done-checkbox\">\r\n                        <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 719, "\"", 735, 1);
#nullable restore
#line 23 "D:\Projects\ASP.NET Projects\Examples 2020\AspNetCoreToDo\AspNetCoreToDo\Views\Todo\Index.cshtml"
WriteAttributeValue("", 727, item.Id, 727, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 26 "D:\Projects\ASP.NET Projects\Examples 2020\AspNetCoreToDo\AspNetCoreToDo\Views\Todo\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "D:\Projects\ASP.NET Projects\Examples 2020\AspNetCoreToDo\AspNetCoreToDo\Views\Todo\Index.cshtml"
               Write(item.DueAt.Humanize());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "D:\Projects\ASP.NET Projects\Examples 2020\AspNetCoreToDo\AspNetCoreToDo\Views\Todo\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    <div class=\"panel-footer add-item-form\">\r\n        ");
#nullable restore
#line 32 "D:\Projects\ASP.NET Projects\Examples 2020\AspNetCoreToDo\AspNetCoreToDo\Views\Todo\Index.cshtml"
   Write(await Html.PartialAsync("AddItemPartial", new TodoItem()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCoreToDo.ViewModels.TodoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
