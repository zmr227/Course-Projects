#pragma checksum "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\Home\BlockShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e557880a0074537c744fc23cd176637ae2c2cfd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Home_BlockShow), @"mvc.1.0.view", @"/Areas/User/Views/Home/BlockShow.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/User/Views/Home/BlockShow.cshtml", typeof(AspNetCore.Areas_User_Views_Home_BlockShow))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e557880a0074537c744fc23cd176637ae2c2cfd0", @"/Areas/User/Views/Home/BlockShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb5b66f2439cbe382c5c1180a275e9f50ce4c9f6", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Home_BlockShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Storyphase.Models.StoryBlocks>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 168, true);
            WriteLiteral("\r\n<br />\r\n\r\n<!--Carousel controls -->\r\n<div id=\"carouseControls\" class=\"carousel slide\" data-ride=\"carousel\" data-interval=\"5000\">\r\n\r\n    <div class=\"carousel-inner\">\r\n");
            EndContext();
#line 9 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\Home\BlockShow.cshtml"
          
            var first = true;
        

#line default
#line hidden
            BeginContext(266, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 12 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\Home\BlockShow.cshtml"
         foreach (var item in @Model)
        {

#line default
#line hidden
            BeginContext(316, 16, true);
            WriteLiteral("            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 332, "\"", 394, 2);
            WriteAttributeValue("", 340, "carousel-item", 340, 13, true);
#line 14 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\Home\BlockShow.cshtml"
WriteAttributeValue(" ", 353, first?Html.Raw("active"):Html.Raw(""), 354, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(395, 67, true);
            WriteLiteral(">\r\n\r\n                <div class=\"card-title\">\r\n                    ");
            EndContext();
            BeginContext(462, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e557880a0074537c744fc23cd176637ae2c2cfd05250", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 17 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\Home\BlockShow.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("diabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(521, 68, true);
            WriteLiteral("\r\n                </div>\r\n                <img class=\"d-block w-100\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 589, "\"", 606, 1);
#line 19 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\Home\BlockShow.cshtml"
WriteAttributeValue("", 595, item.Image, 595, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 607, "\"", 623, 1);
#line 19 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\Home\BlockShow.cshtml"
WriteAttributeValue("", 613, item.Name, 613, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(624, 68, true);
            WriteLiteral(">\r\n\r\n                <div class=\"tab-content\">\r\n                    ");
            EndContext();
            BeginContext(692, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e557880a0074537c744fc23cd176637ae2c2cfd08125", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 22 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\Home\BlockShow.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Content);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("diabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(754, 46, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 25 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Storyphase\Storyphase\Storyphase\Areas\User\Views\Home\BlockShow.cshtml"
            first = false;
        }

#line default
#line hidden
            BeginContext(839, 651, true);
            WriteLiteral(@"    </div>
    <a class=""carousel-control left"" href=""#myCarousel"" data-slide=""prev"">&lsaquo;</a>
    <a class=""carousel-control right"" href=""#myCarousel"" data-slide=""next"">&rsaquo;</a>

    <a class=""carousel-control left"" href=""#carouselControls"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselControls"" role=""button""
       data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>

</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1508, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Storyphase.Models.StoryBlocks>> Html { get; private set; }
    }
}
#pragma warning restore 1591
