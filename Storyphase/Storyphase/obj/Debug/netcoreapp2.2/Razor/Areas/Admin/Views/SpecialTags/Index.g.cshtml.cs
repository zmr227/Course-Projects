#pragma checksum "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Areas\Admin\Views\SpecialTags\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c8c955cda89d126252ce94051ae42dfe097e837"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SpecialTags_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SpecialTags/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/SpecialTags/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_SpecialTags_Index))]
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
#line 1 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Areas\Admin\Views\_ViewImports.cshtml"
using Storyphase;

#line default
#line hidden
#line 2 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Areas\Admin\Views\_ViewImports.cshtml"
using Storyphase.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c8c955cda89d126252ce94051ae42dfe097e837", @"/Areas/Admin/Views/SpecialTags/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb5b66f2439cbe382c5c1180a275e9f50ce4c9f6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SpecialTags_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Storyphase.Models.SpecialTags>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Areas\Admin\Views\SpecialTags\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(92, 173, true);
            WriteLiteral("\r\n\r\n<br /><br />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Special Tag List</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            EndContext();
            BeginContext(265, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c8c955cda89d126252ce94051ae42dfe097e8374486", async() => {
                BeginContext(309, 49, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; New Special Tag");
                EndContext();
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
            EndContext();
            BeginContext(362, 156, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<br />\r\n\r\n<div>\r\n    <table class=\"table table-striped border\">\r\n        <tr class=\"table-info\">\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(519, 32, false);
#line 24 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Areas\Admin\Views\SpecialTags\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(551, 84, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 30 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Areas\Admin\Views\SpecialTags\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(684, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(745, 31, false);
#line 34 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Areas\Admin\Views\SpecialTags\Index.cshtml"
               Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(776, 85, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"btn-group\">\r\n                    ");
            EndContext();
            BeginContext(862, 55, false);
#line 37 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Areas\Admin\Views\SpecialTags\Index.cshtml"
               Write(await Html.PartialAsync("_TableButtonPartial", item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(917, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 40 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Areas\Admin\Views\SpecialTags\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(972, 22, true);
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Storyphase.Models.SpecialTags>> Html { get; private set; }
    }
}
#pragma warning restore 1591
