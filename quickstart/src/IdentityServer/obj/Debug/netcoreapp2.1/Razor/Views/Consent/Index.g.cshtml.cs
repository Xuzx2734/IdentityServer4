#pragma checksum "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0089ab629719f3a07e1dd3559c7051bdd85ac65c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent_Index), @"mvc.1.0.view", @"/Views/Consent/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consent/Index.cshtml", typeof(AspNetCore.Views_Consent_Index))]
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
#line 1 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\_ViewImports.cshtml"
using IdentityServer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0089ab629719f3a07e1dd3559c7051bdd85ac65c", @"/Views/Consent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68eec6d3abdefe101d53f77bde96d516819f255c", @"/Views/_ViewImports.cshtml")]
    public class Views_Consent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConsentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationSummary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ScopeListItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-scopecheck"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 94, true);
            WriteLiteral("\n<div class=\"page-consent\">\n    <div class=\"row page-header\">\n        <div class=\"col-sm-10\">\n");
            EndContext();
#line 6 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
             if (Model.ClientLogoUrl != null)
            {

#line default
#line hidden
            BeginContext(178, 45, true);
            WriteLiteral("                <div class=\"client-logo\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 223, "\"", 249, 1);
#line 8 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
WriteAttributeValue("", 229, Model.ClientLogoUrl, 229, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(250, 8, true);
            WriteLiteral("></div>\n");
            EndContext();
#line 9 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(272, 33, true);
            WriteLiteral("            <h1>\n                ");
            EndContext();
            BeginContext(306, 16, false);
#line 11 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
           Write(Model.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(322, 172, true);
            WriteLiteral("\n                <small>is requesting your permission</small>\n            </h1>\n        </div>\n    </div>\n\n    <div class=\"row\">\n        <div class=\"col-sm-8\">\n            ");
            EndContext();
            BeginContext(494, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5654843597ac4ae3809d993612d99dfc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(531, 26, true);
            WriteLiteral("\n            \n            ");
            EndContext();
            BeginContext(557, 2590, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "615a70ae15664bc69c0bfe646450ebd5", async() => {
                BeginContext(603, 17, true);
                WriteLiteral("\n                ");
                EndContext();
                BeginContext(620, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6df8a8c5bd934441bd0316d1638fc50b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 22 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ReturnUrl);

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
                BeginContext(663, 96, true);
                WriteLiteral("\n\n                <div>Uncheck the permissions you do not wish to grant.</div>\n                \n");
                EndContext();
#line 26 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
                 if (Model.IdentityScopes.Any())
                {

#line default
#line hidden
                BeginContext(826, 325, true);
                WriteLiteral(@"                    <div class=""panel panel-default consent-buttons"">
                        <div class=""panel-heading"">
                            <span class=""glyphicon glyphicon-user""></span>
                            Personal Information
                        </div>
                        <ul class=""list-group"">
");
                EndContext();
#line 34 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
                             foreach (var scope in Model.IdentityScopes)
                            {

#line default
#line hidden
                BeginContext(1254, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1286, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0e898fa068042668a6719f8b9856365", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 36 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = scope;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1334, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 37 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(1365, 57, true);
                WriteLiteral("                        </ul>\n                    </div>\n");
                EndContext();
#line 40 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(1440, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 42 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
                 if (Model.ResourceScopes.Any())
                {

#line default
#line hidden
                BeginContext(1508, 308, true);
                WriteLiteral(@"                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">
                            <span class=""glyphicon glyphicon-tasks""></span>
                            Application Access
                        </div>
                        <ul class=""list-group"">
");
                EndContext();
#line 50 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
                             foreach (var scope in Model.ResourceScopes)
                            {

#line default
#line hidden
                BeginContext(1919, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1951, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b317765fd8bc49e2a8e05a8c10891c57", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 52 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = scope;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1998, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 53 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(2029, 57, true);
                WriteLiteral("                        </ul>\n                    </div>\n");
                EndContext();
#line 56 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(2104, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 58 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
                 if (Model.AllowRememberConsent)
                {

#line default
#line hidden
                BeginContext(2172, 111, true);
                WriteLiteral("                    <div class=\"consent-remember\">\n                        <label>\n                            ");
                EndContext();
                BeginContext(2283, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c451e23d9c9448da0b528f5434936fd", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 62 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberConsent);

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
                BeginContext(2345, 127, true);
                WriteLiteral("\n                            <strong>Remember My Decision</strong>\n                        </label>\n                    </div>\n");
                EndContext();
#line 66 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(2490, 246, true);
                WriteLiteral("\n                <div class=\"consent-buttons\">\n                    <button name=\"button\" value=\"yes\" class=\"btn btn-primary\" autofocus>Yes, Allow</button>\n                    <button name=\"button\" value=\"no\" class=\"btn\">No, Do Not Allow</button>\n");
                EndContext();
#line 71 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
                     if (Model.ClientUrl != null)
                    {

#line default
#line hidden
                BeginContext(2808, 77, true);
                WriteLiteral("                        <a class=\"pull-right btn btn-default\" target=\"_blank\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2885, "\"", 2908, 1);
#line 73 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
WriteAttributeValue("", 2892, Model.ClientUrl, 2892, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2909, 118, true);
                WriteLiteral(">\n                            <span class=\"glyphicon glyphicon-info-sign\"></span>\n                            <strong>");
                EndContext();
                BeginContext(3028, 16, false);
#line 75 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
                               Write(Model.ClientName);

#line default
#line hidden
                EndContext();
                BeginContext(3044, 39, true);
                WriteLiteral("</strong>\n                        </a>\n");
                EndContext();
#line 77 "H:\workspace\Dotnet_Core\IdentityServer4\Example\quickstart\src\IdentityServer\Views\Consent\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(3105, 35, true);
                WriteLiteral("                </div>\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3147, 33, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConsentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
