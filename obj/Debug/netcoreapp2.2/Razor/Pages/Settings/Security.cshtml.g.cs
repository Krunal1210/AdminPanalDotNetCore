#pragma checksum "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "983ef06f223e0d81d3b896a787d609da0893f96f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DNC6.Pages.Settings.Pages_Settings_Security), @"mvc.1.0.razor-page", @"/Pages/Settings/Security.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Settings/Security.cshtml", typeof(DNC6.Pages.Settings.Pages_Settings_Security), null)]
namespace DNC6.Pages.Settings
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\MyProwork\Temp\DNC6\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\MyProwork\Temp\DNC6\Pages\_ViewImports.cshtml"
using DNC6;

#line default
#line hidden
#line 3 "D:\MyProwork\Temp\DNC6\Pages\_ViewImports.cshtml"
using DNC6.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"983ef06f223e0d81d3b896a787d609da0893f96f", @"/Pages/Settings/Security.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a089671beab0bd5d19b5784d16abee6c378c833", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Settings_Security : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LoginProvider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ProviderKey", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "RemoveLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "LinkLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./TwoFactorAuth/RecoveryCodes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Disable2FA", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
  
    ViewData["Title"] = "Security";

#line default
#line hidden
            BeginContext(93, 592, true);
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        My Profile
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""/""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li><a href=""#"">Settings</a></li>
        <li class=""active"">My Profile</li>
    </ol>
</section>


<!-- Main content -->
<section class=""content"">

    <div class=""row"">
        <div class=""col-lg-2"">

        </div>
        <!-- /.col -->

        <div class=""col-lg-8"">

            <h4>External Logins</h4>

            <ul class=""list-group"">
");
            EndContext();
#line 34 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                 foreach (var login in Model.CurrentLogins)
                {

#line default
#line hidden
            BeginContext(765, 199, true);
            WriteLiteral("                    <li class=\"list-group-item\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-xs-4 text-left nowrap\">\r\n                                <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 964, "\"", 1026, 4);
            WriteAttributeValue("", 972, "btn", 972, 3, true);
            WriteAttributeValue(" ", 975, "btn-social-icon", 976, 16, true);
            WriteAttributeValue(" ", 991, "btn-", 992, 5, true);
#line 39 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
WriteAttributeValue("", 996, login.LoginProvider.ToLower(), 996, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1027, 41, true);
            WriteLiteral(">\r\n                                    <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1068, "\"", 1112, 3);
            WriteAttributeValue("", 1076, "fa", 1076, 2, true);
            WriteAttributeValue(" ", 1078, "fa-", 1079, 4, true);
#line 40 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
WriteAttributeValue("", 1082, login.LoginProvider.ToLower(), 1082, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1113, 88, true);
            WriteLiteral("></i>\r\n                                </span>\r\n                                <strong>");
            EndContext();
            BeginContext(1202, 25, false);
#line 42 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                                   Write(login.ProviderDisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(1227, 161, true);
            WriteLiteral("</strong> <span class=\"label label-primary\">Connected</span>\r\n                            </div>\r\n                            <div class=\"col-xs-8 text-right\">\r\n");
            EndContext();
#line 45 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                                 if (Model.ShowRemoveButton)
                                {

#line default
#line hidden
            BeginContext(1485, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(1521, 729, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "983ef06f223e0d81d3b896a787d609da0893f96f10173", async() => {
                BeginContext(1572, 93, true);
                WriteLiteral("\r\n                                        <div>\r\n                                            ");
                EndContext();
                BeginContext(1665, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "983ef06f223e0d81d3b896a787d609da0893f96f10651", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 49 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.LoginProvider);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1740, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(1786, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "983ef06f223e0d81d3b896a787d609da0893f96f12702", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 50 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.ProviderKey);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1857, 90, true);
                WriteLiteral("\r\n                                            <button type=\"submit\" class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("title", " title=\"", 1947, "\"", 2011, 7);
                WriteAttributeValue("", 1955, "Remove", 1955, 6, true);
                WriteAttributeValue(" ", 1961, "this", 1962, 5, true);
#line 51 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
WriteAttributeValue(" ", 1966, login.LoginProvider, 1967, 20, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1987, "login", 1988, 6, true);
                WriteAttributeValue(" ", 1993, "from", 1994, 5, true);
                WriteAttributeValue(" ", 1998, "your", 1999, 5, true);
                WriteAttributeValue(" ", 2003, "account", 2004, 8, true);
                EndWriteAttribute();
                BeginContext(2012, 231, true);
                WriteLiteral(">\r\n                                                <i class=\"fa fa-remove\"></i> Disconnect\r\n                                            </button>\r\n                                        </div>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2250, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 56 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                                }

#line default
#line hidden
            BeginContext(2287, 95, true);
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </li>\r\n");
            EndContext();
#line 60 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                }

#line default
#line hidden
            BeginContext(2401, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 61 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                 foreach (var provider in Model.OtherLogins)
                {

#line default
#line hidden
            BeginContext(2482, 199, true);
            WriteLiteral("                    <li class=\"list-group-item\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-xs-4 text-left nowrap\">\r\n                                <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2681, "\"", 2744, 4);
            WriteAttributeValue("", 2689, "btn", 2689, 3, true);
            WriteAttributeValue(" ", 2692, "btn-social-icon", 2693, 16, true);
            WriteAttributeValue(" ", 2708, "btn-", 2709, 5, true);
#line 66 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
WriteAttributeValue("", 2713, provider.DisplayName.ToLower(), 2713, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2745, 41, true);
            WriteLiteral(">\r\n                                    <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2786, "\"", 2831, 3);
            WriteAttributeValue("", 2794, "fa", 2794, 2, true);
            WriteAttributeValue(" ", 2796, "fa-", 2797, 4, true);
#line 67 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
WriteAttributeValue("", 2800, provider.DisplayName.ToLower(), 2800, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2832, 88, true);
            WriteLiteral("></i>\r\n                                </span>\r\n                                <strong>");
            EndContext();
            BeginContext(2921, 20, false);
#line 69 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                                   Write(provider.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(2941, 142, true);
            WriteLiteral("</strong>\r\n                            </div>\r\n                            <div class=\"col-xs-8 text-right\">\r\n                                ");
            EndContext();
            BeginContext(3083, 360, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "983ef06f223e0d81d3b896a787d609da0893f96f20153", async() => {
                BeginContext(3156, 99, true);
                WriteLiteral("\r\n                                    <button type=\"submit\" class=\"btn btn-primary\" name=\"provider\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3255, "\"", 3277, 1);
#line 73 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
WriteAttributeValue("", 3263, provider.Name, 3263, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3278, 158, true);
                WriteLiteral(">\r\n                                        <i class=\"fa fa-plus\"></i> Connect\r\n                                    </button>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3443, 97, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </li>\r\n");
            EndContext();
#line 80 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                }

#line default
#line hidden
            BeginContext(3559, 69, true);
            WriteLiteral("            </ul>\r\n\r\n            <h4>Two-factor authentication</h4>\r\n");
            EndContext();
#line 84 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
             if (Model.Is2faEnabled)
            {
                

#line default
#line hidden
#line 86 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                 if (Model.RecoveryCodesLeft == 0)
                {

#line default
#line hidden
            BeginContext(3752, 165, true);
            WriteLiteral("                    <div class=\"alert alert-danger\">\r\n                        <strong>You have no recovery codes left.</strong>\r\n                        <p>You must ");
            EndContext();
            BeginContext(3917, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "983ef06f223e0d81d3b896a787d609da0893f96f23757", async() => {
                BeginContext(3961, 36, true);
                WriteLiteral("generate a new set of recovery codes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4001, 78, true);
            WriteLiteral(" before you can log in with a recovery code.</p>\r\n                    </div>\r\n");
            EndContext();
#line 92 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                }
                else if (Model.RecoveryCodesLeft == 1)
                {

#line default
#line hidden
            BeginContext(4173, 162, true);
            WriteLiteral("                    <div class=\"alert alert-danger\">\r\n                        <strong>You have 1 recovery code left.</strong>\r\n                        <p>You can ");
            EndContext();
            BeginContext(4335, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "983ef06f223e0d81d3b896a787d609da0893f96f25699", async() => {
                BeginContext(4379, 36, true);
                WriteLiteral("generate a new set of recovery codes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4419, 35, true);
            WriteLiteral(".</p>\r\n                    </div>\r\n");
            EndContext();
#line 99 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                }
                else if (Model.RecoveryCodesLeft <= 3)
                {

#line default
#line hidden
            BeginContext(4548, 96, true);
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <strong>You have ");
            EndContext();
            BeginContext(4645, 23, false);
#line 103 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                                    Write(Model.RecoveryCodesLeft);

#line default
#line hidden
            EndContext();
            BeginContext(4668, 70, true);
            WriteLiteral(" recovery codes left.</strong>\r\n                        <p>You should ");
            EndContext();
            BeginContext(4738, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "983ef06f223e0d81d3b896a787d609da0893f96f27940", async() => {
                BeginContext(4782, 36, true);
                WriteLiteral("generate a new set of recovery codes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4822, 35, true);
            WriteLiteral(".</p>\r\n                    </div>\r\n");
            EndContext();
#line 106 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                }

#line default
#line hidden
#line 106 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(4891, 126, true);
            WriteLiteral("\r\n            <ul class=\"list-group\">\r\n\r\n                <li class=\"list-group-item\">\r\n                    <div class=\"row\">\r\n");
            EndContext();
#line 113 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                         if (Model.Is2faEnabled)
                        {

#line default
#line hidden
            BeginContext(5094, 326, true);
            WriteLiteral(@"                            <div class=""col-xs-4 text-left nowrap"">
                                Status: <span class=""text-green""><strong>Enabled</strong> <i class=""fa fa-check""></i></span>
                            </div>
                            <div class=""col-xs-8 text-right"">
                                ");
            EndContext();
            BeginContext(5420, 477, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "983ef06f223e0d81d3b896a787d609da0893f96f30484", async() => {
                BeginContext(5489, 401, true);
                WriteLiteral(@"
                                    <a href=""./TwoFactorAuth"" class=""btn btn-primary"">
                                        <i class=""fa fa-edit""></i> Edit
                                    </a>

                                    <button class=""btn btn-danger"" type=""submit"" title=""Disable two-factor authentication""><i class=""fa fa-remove""></i></button>
                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5897, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 127 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(6019, 544, true);
            WriteLiteral(@"                            <div class=""col-xs-4 text-left nowrap"">
                                Status: <span class=""text-red""><strong>Off</strong> <i class=""fa fa-remove""></i></span>
                            </div>
                            <div class=""col-xs-8 text-right"">
                                <a href=""./TwoFactorAuth"" class=""btn btn-primary"">
                                    <i class=""fa fa-lock""></i> Set up two-factor authentication
                                </a>
                            </div>
");
            EndContext();
#line 138 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                        }

#line default
#line hidden
            BeginContext(6590, 51, true);
            WriteLiteral("                    </div>\r\n                </li>\r\n");
            EndContext();
#line 141 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                 if (Model.Is2faEnabled)
                {

#line default
#line hidden
            BeginContext(6702, 260, true);
            WriteLiteral(@"                    <li class=""list-group-item"">
                        Save your <a href=""./TwoFactorAuth/RecoveryCodes"">recovery codes</a> in a safe place. They will allow you to access your account if you ever lose your phone.
                    </li>
");
            EndContext();
#line 146 "D:\MyProwork\Temp\DNC6\Pages\Settings\Security.cshtml"
                }

#line default
#line hidden
            BeginContext(6981, 203, true);
            WriteLiteral("            </ul>\r\n\r\n        </div>\r\n        <!-- /.col -->\r\n\r\n        <div class=\"col-lg-2\">\r\n\r\n        </div>\r\n        <!-- /.col -->\r\n    </div>\r\n    <!-- /.row -->\r\n\r\n</section>\r\n<!-- /.content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DNC6.Pages.Settings.SecurityModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DNC6.Pages.Settings.SecurityModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DNC6.Pages.Settings.SecurityModel>)PageContext?.ViewData;
        public DNC6.Pages.Settings.SecurityModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591