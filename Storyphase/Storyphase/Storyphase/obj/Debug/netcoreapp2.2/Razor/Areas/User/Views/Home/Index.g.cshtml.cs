#pragma checksum "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb2bc93646630bec354b31ce6a4bfe163c5b8fff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Home_Index), @"mvc.1.0.view", @"/Areas/User/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/User/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_User_Views_Home_Index))]
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
#line 1 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\_ViewImports.cshtml"
using Storyphase;

#line default
#line hidden
#line 2 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\_ViewImports.cshtml"
using Storyphase.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb2bc93646630bec354b31ce6a4bfe163c5b8fff", @"/Areas/User/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb5b66f2439cbe382c5c1180a275e9f50ce4c9f6", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Storyphase.Models.Stories>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success pull-right bg-white btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 33, true);
            WriteLiteral("<br /><br />\r\n<div class=\"row\">\r\n");
            EndContext();
#line 4 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\Home\Index.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
            BeginContext(113, 240, true);
            WriteLiteral("        <div class=\"col-4\">\r\n            <div class=\"card md-4\">\r\n                <div class=\"card-header\">\r\n                    <h4 class=\"my-0 font-weight-normal\">\r\n                        <label style=\"font-size:23px; color:blueviolet;\">");
            EndContext();
            BeginContext(354, 10, false);
#line 10 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\Home\Index.cshtml"
                                                                    Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(364, 111, true);
            WriteLiteral("</label>\r\n                    </h4>\r\n                </div>\r\n                <img class=\"card-img-top\" style=\"\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 475, "\"", 492, 1);
#line 13 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\Home\Index.cshtml"
WriteAttributeValue("", 481, item.Image, 481, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(493, 197, true);
            WriteLiteral(" alt=\"Card Image\" />\r\n                <div class=\"card-body\">\r\n                    <div class=\"d-flex justify-content-between align-items-center\">\r\n                        <div class=\"btn-group\">\r\n");
            EndContext();
#line 17 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\Home\Index.cshtml"
                             if (!item.SpecialTags.Name.Equals("--None--"))
                            {

#line default
#line hidden
            BeginContext(798, 82, true);
            WriteLiteral("                                <label style=\"font-size: 20px; color: #a51313\"><b>");
            EndContext();
            BeginContext(881, 21, false);
#line 19 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\Home\Index.cshtml"
                                                                             Write(item.SpecialTags.Name);

#line default
#line hidden
            EndContext();
            BeginContext(902, 14, true);
            WriteLiteral("</b></label>\r\n");
            EndContext();
#line 20 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(947, 56, true);
            WriteLiteral("                        </div>\r\n                        ");
            EndContext();
            BeginContext(1003, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb2bc93646630bec354b31ce6a4bfe163c5b8fff7456", async() => {
                BeginContext(1134, 12, true);
                WriteLiteral("View Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\Home\Index.cshtml"
                                                                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1150, 90, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 27 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1247, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Storyphase.Models.Stories>> Html { get; private set; }
    }
}
#pragma warning restore 1591
