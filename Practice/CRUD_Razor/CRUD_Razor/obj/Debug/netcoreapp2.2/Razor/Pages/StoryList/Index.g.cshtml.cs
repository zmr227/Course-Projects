#pragma checksum "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85eb9e3403eefb272cda80d45075f15de3887966"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CRUD_Razor.Pages.StoryList.Pages_StoryList_Index), @"mvc.1.0.razor-page", @"/Pages/StoryList/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/StoryList/Index.cshtml", typeof(CRUD_Razor.Pages.StoryList.Pages_StoryList_Index), null)]
namespace CRUD_Razor.Pages.StoryList
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\_ViewImports.cshtml"
using CRUD_Razor;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85eb9e3403eefb272cda80d45075f15de3887966", @"/Pages/StoryList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ed5dfc9dd8361557366312798e9ae57df0a42e9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_StoryList_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateStory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "EditStory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(94, 33, true);
            WriteLiteral("\r\n<h2>Story List</h2>\r\n<br />\r\n\r\n");
            EndContext();
#line 10 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
 if(Model.Message != null)
{

#line default
#line hidden
            BeginContext(158, 233, true);
            WriteLiteral("    <div class=\"alert alert-info alert-dismissible\" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n        ");
            EndContext();
            BeginContext(392, 13, false);
#line 16 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
   Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(405, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 18 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
}

#line default
#line hidden
            BeginContext(422, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(424, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85eb9e3403eefb272cda80d45075f15de38879667287", async() => {
                BeginContext(474, 16, true);
                WriteLiteral("Create New Story");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
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
            BeginContext(494, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(496, 1732, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85eb9e3403eefb272cda80d45075f15de38879668750", async() => {
                BeginContext(516, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 22 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
     if (Model.Stories.Count() > 0)
    {

#line default
#line hidden
                BeginContext(562, 113, true);
                WriteLiteral("        <br /><br />\r\n        <table class=\"table\">\r\n            <tr>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(676, 58, false);
#line 28 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Stories.FirstOrDefault().Title));

#line default
#line hidden
                EndContext();
                BeginContext(734, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(802, 59, false);
#line 31 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Stories.FirstOrDefault().Author));

#line default
#line hidden
                EndContext();
                BeginContext(861, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(929, 64, false);
#line 34 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Stories.FirstOrDefault().Description));

#line default
#line hidden
                EndContext();
                BeginContext(993, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1061, 63, false);
#line 37 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Stories.FirstOrDefault().CreateTime));

#line default
#line hidden
                EndContext();
                BeginContext(1124, 98, true);
                WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n                <th></th>\r\n            </tr>\r\n");
                EndContext();
#line 42 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
             foreach (var item in Model.Stories)
            {

#line default
#line hidden
                BeginContext(1287, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1360, 32, false);
#line 46 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Title));

#line default
#line hidden
                EndContext();
                BeginContext(1392, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1472, 33, false);
#line 49 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Author));

#line default
#line hidden
                EndContext();
                BeginContext(1505, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1585, 38, false);
#line 52 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Description));

#line default
#line hidden
                EndContext();
                BeginContext(1623, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1703, 37, false);
#line 55 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
                   Write(Html.DisplayFor(m => item.CreateTime));

#line default
#line hidden
                EndContext();
                BeginContext(1740, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1819, 103, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85eb9e3403eefb272cda80d45075f15de388796614024", async() => {
                    BeginContext(1907, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 58 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
                                                            WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1922, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1948, 87, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85eb9e3403eefb272cda80d45075f15de388796616681", async() => {
                    BeginContext(2027, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 59 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2035, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 62 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(2102, 20, true);
                WriteLiteral("\r\n        </table>\r\n");
                EndContext();
#line 65 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(2146, 68, true);
                WriteLiteral("        <br /><br />\r\n        <div>No Story in the Database!</div>\r\n");
                EndContext();
#line 70 "C:\Users\可爱的我\Documents\小可爱的IP作业\Internet-Programming\Project\CRUD_Razor\CRUD_Razor\Pages\StoryList\Index.cshtml"
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2228, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CRUD_Razor.Pages.StoryList.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CRUD_Razor.Pages.StoryList.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CRUD_Razor.Pages.StoryList.IndexModel>)PageContext?.ViewData;
        public CRUD_Razor.Pages.StoryList.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
