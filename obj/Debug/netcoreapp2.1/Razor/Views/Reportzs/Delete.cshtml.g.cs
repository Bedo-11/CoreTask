#pragma checksum "/Users/bedo/Desktop/core/CoreTask/Views/Reportzs/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11e779d32e96436e3958eea29cb467b794800d33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reportzs_Delete), @"mvc.1.0.view", @"/Views/Reportzs/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reportzs/Delete.cshtml", typeof(AspNetCore.Views_Reportzs_Delete))]
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
#line 1 "/Users/bedo/Desktop/core/CoreTask/Views/_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#line 2 "/Users/bedo/Desktop/core/CoreTask/Views/_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11e779d32e96436e3958eea29cb467b794800d33", @"/Views/Reportzs/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"913d19762f9ae78021f2c0262519d885f2085739", @"/Views/_ViewImports.cshtml")]
    public class Views_Reportzs_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication3.Models.Reportz>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/bedo/Desktop/core/CoreTask/Views/Reportzs/Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(78, 613, true);
            WriteLiteral(@"
<div class=""container form-b bShadow bShadow-62 animate__animated animate__fadeInDown"">
    <div class=""row d-flex justify-content-center mb-5"">

        <div style=""display:flex ; justify-content:center"" class=""row mb-5"">
            <h2 class=""mt-5"">هل انت متأكد من حذف هذا البلاغ؟</h2>
        </div>

        
    </div>
    <div class=""row d-flex justify-content-center"">
        <div class=""container"">
            <div class=""row"">
                <table class=""table table-striped table-bordered mb-5"">
                    <thead>
                        <tr>
                            <th scope=""col"">");
            EndContext();
            BeginContext(692, 43, false);
#line 22 "/Users/bedo/Desktop/core/CoreTask/Views/Reportzs/Delete.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Statuez));

#line default
#line hidden
            EndContext();
            BeginContext(735, 50, true);
            WriteLiteral("</th>\n                            <th scope=\"col\">");
            EndContext();
            BeginContext(786, 40, false);
#line 23 "/Users/bedo/Desktop/core/CoreTask/Views/Reportzs/Delete.cshtml"
                                       Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
            EndContext();
            BeginContext(826, 50, true);
            WriteLiteral("</th>\n                            <th scope=\"col\">");
            EndContext();
            BeginContext(877, 42, false);
#line 24 "/Users/bedo/Desktop/core/CoreTask/Views/Reportzs/Delete.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Topicz));

#line default
#line hidden
            EndContext();
            BeginContext(919, 50, true);
            WriteLiteral("</th>\n                            <th scope=\"col\">");
            EndContext();
            BeginContext(970, 41, false);
#line 25 "/Users/bedo/Desktop/core/CoreTask/Views/Reportzs/Delete.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Textz));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 154, true);
            WriteLiteral("</th>\n                        </tr>\n                    </thead>\n                    <tbody>\n                        <tr>\n                            <th>");
            EndContext();
            BeginContext(1166, 44, false);
#line 30 "/Users/bedo/Desktop/core/CoreTask/Views/Reportzs/Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Statuez.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 38, true);
            WriteLiteral("</th>\n                            <td>");
            EndContext();
            BeginContext(1249, 38, false);
#line 31 "/Users/bedo/Desktop/core/CoreTask/Views/Reportzs/Delete.cshtml"
                           Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(1287, 39, true);
            WriteLiteral(" </td>\n                            <td>");
            EndContext();
            BeginContext(1327, 38, false);
#line 32 "/Users/bedo/Desktop/core/CoreTask/Views/Reportzs/Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Topicz));

#line default
#line hidden
            EndContext();
            BeginContext(1365, 71, true);
            WriteLiteral("</td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(1437, 37, false);
#line 34 "/Users/bedo/Desktop/core/CoreTask/Views/Reportzs/Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Textz));

#line default
#line hidden
            EndContext();
            BeginContext(1474, 346, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
            
            <div style=""display: flex; justify-content: center"" class=""row mt-4 mb-5"">
                <div class=""col-md-4"">
                    <div class=""form-group"">
                        ");
            EndContext();
            BeginContext(1820, 239, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06d6ce8d27c84f7b97476d136a83c82b", async() => {
                BeginContext(1846, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
                BeginContext(1875, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "70a8c6bea68d4a4fae65f26fb3c68d53", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 45 "/Users/bedo/Desktop/core/CoreTask/Views/Reportzs/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1911, 141, true);
                WriteLiteral("\n                            <input style=\"width: 100%\" type=\"submit\" value=\"تأكيد الحذف\" class=\"btn btn-danger\" /> \n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2059, 159, true);
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"col-md-4\">\n                    <div class=\"form-group\">\n                        ");
            EndContext();
            BeginContext(2218, 168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03d2bb1ebd7b4397895ffeaa6578a14e", async() => {
                BeginContext(2285, 97, true);
                WriteLiteral("\n                            رجوع      <i class=\"fas fa-arrow-left\"></i>\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2386, 108, true);
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </div>\n\n    </div>\n</div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication3.Models.Reportz> Html { get; private set; }
    }
}
#pragma warning restore 1591
