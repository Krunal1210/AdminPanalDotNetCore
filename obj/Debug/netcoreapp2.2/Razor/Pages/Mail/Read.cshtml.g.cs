#pragma checksum "D:\MyProwork\Temp\DNC6\Pages\Mail\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcdff326aa57dd8c1d5a29ea576e4e393daf0268"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DNC6.Pages.Mail.Pages_Mail_Read), @"mvc.1.0.razor-page", @"/Pages/Mail/Read.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Mail/Read.cshtml", typeof(DNC6.Pages.Mail.Pages_Mail_Read), null)]
namespace DNC6.Pages.Mail
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcdff326aa57dd8c1d5a29ea576e4e393daf0268", @"/Pages/Mail/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a089671beab0bd5d19b5784d16abee6c378c833", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Mail_Read : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/icheck/skins/flat/blue.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/icheck/icheck.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Mail/Compose"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block margin-bottom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Mail/Inbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/photo1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Attachment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/photo2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\MyProwork\Temp\DNC6\Pages\Mail\Read.cshtml"
  
    ViewData["Title"] = "Read";

#line default
#line hidden
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(84, 27, true);
                WriteLiteral("\r\n    <!-- iCheck -->\r\n    ");
                EndContext();
                BeginContext(111, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fcdff326aa57dd8c1d5a29ea576e4e393daf02686783", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(175, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(180, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(200, 27, true);
                WriteLiteral("\r\n    <!-- iCheck -->\r\n    ");
                EndContext();
                BeginContext(227, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcdff326aa57dd8c1d5a29ea576e4e393daf02688440", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(278, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(285, 398, true);
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        Read Mail
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li class=""active"">Mailbox</li>
    </ol>
</section>

<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-md-3"">
            ");
            EndContext();
            BeginContext(683, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcdff326aa57dd8c1d5a29ea576e4e393daf026810232", async() => {
                BeginContext(756, 7, true);
                WriteLiteral("Compose");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(767, 611, true);
            WriteLiteral(@"

            <div class=""box box-solid"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Folders</h3>

                    <div class=""box-tools"">
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                            <i class=""fa fa-minus""></i>
                        </button>
                    </div>
                </div>
                <div class=""box-body no-padding"">
                    <ul class=""nav nav-pills nav-stacked"">
                        <li>
                            ");
            EndContext();
            BeginContext(1378, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcdff326aa57dd8c1d5a29ea576e4e393daf026812238", async() => {
                BeginContext(1401, 185, true);
                WriteLiteral("\r\n                                <i class=\"fa fa-inbox\"></i> Inbox\r\n                                <span class=\"label label-primary pull-right\">12</span>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1590, 9304, true);
            WriteLiteral(@"
                        </li>
                        <li><a href=""#""><i class=""fa fa-envelope-o""></i> Sent</a></li>
                        <li><a href=""#""><i class=""fa fa-file-text-o""></i> Drafts</a></li>
                        <li>
                            <a href=""#""><i class=""fa fa-filter""></i> Junk <span class=""label label-warning pull-right"">65</span></a>
                        </li>
                        <li><a href=""#""><i class=""fa fa-trash-o""></i> Trash</a></li>
                    </ul>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /. box -->
            <div class=""box box-solid"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Labels</h3>

                    <div class=""box-tools"">
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                            <i class=""fa fa-minus""></i>
                        </button>
         ");
            WriteLiteral(@"           </div>
                </div>
                <div class=""box-body no-padding"">
                    <ul class=""nav nav-pills nav-stacked"">
                        <li><a href=""#""><i class=""fa fa-circle-o text-red""></i> Important</a></li>
                        <li><a href=""#""><i class=""fa fa-circle-o text-yellow""></i> Promotions</a></li>
                        <li><a href=""#""><i class=""fa fa-circle-o text-light-blue""></i> Social</a></li>
                    </ul>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->
        </div>
        <!-- /.col -->
        <div class=""col-md-9"">
            <div class=""box box-primary"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Read Mail</h3>

                    <div class=""box-tools pull-right"">
                        <a href=""#"" class=""btn btn-box-tool"" data-toggle=""tooltip"" title=""Previous""><i class=""fa fa-chevron-left""></i></a>
 ");
            WriteLiteral(@"                       <a href=""#"" class=""btn btn-box-tool"" data-toggle=""tooltip"" title=""Next""><i class=""fa fa-chevron-right""></i></a>
                    </div>
                </div>
                <!-- /.box-header -->
                <div class=""box-body no-padding"">
                    <div class=""mailbox-read-info"">
                        <h3>Message Subject Is Placed Here</h3>
                        <h5>
                            From: help@example.com
                            <span class=""mailbox-read-time pull-right"">15 Feb. 2016 11:03 PM</span>
                        </h5>
                    </div>
                    <!-- /.mailbox-read-info -->
                    <div class=""mailbox-controls with-border text-center"">
                        <div class=""btn-group"">
                            <button type=""button"" class=""btn btn-default btn-sm"" data-toggle=""tooltip"" data-container=""body"" title=""Delete"">
                                <i class=""fa fa-trash-o""></i>
      ");
            WriteLiteral(@"                      </button>
                            <button type=""button"" class=""btn btn-default btn-sm"" data-toggle=""tooltip"" data-container=""body"" title=""Reply"">
                                <i class=""fa fa-reply""></i>
                            </button>
                            <button type=""button"" class=""btn btn-default btn-sm"" data-toggle=""tooltip"" data-container=""body"" title=""Forward"">
                                <i class=""fa fa-share""></i>
                            </button>
                        </div>
                        <!-- /.btn-group -->
                        <button type=""button"" class=""btn btn-default btn-sm"" data-toggle=""tooltip"" title=""Print"">
                            <i class=""fa fa-print""></i>
                        </button>
                    </div>
                    <!-- /.mailbox-controls -->
                    <div class=""mailbox-read-message"">
                        <p>Hello John,</p>

                        <p>
              ");
            WriteLiteral(@"              Keffiyeh blog actually fashion axe vegan, irony biodiesel. Cold-pressed hoodie chillwave put a bird
                            on it aesthetic, bitters brunch meggings vegan iPhone. Dreamcatcher vegan scenester mlkshk. Ethical
                            master cleanse Bushwick, occupy Thundercats banjo cliche ennui farm-to-table mlkshk fanny pack
                            gluten-free. Marfa butcher vegan quinoa, bicycle rights disrupt tofu scenester chillwave 3 wolf moon
                            asymmetrical taxidermy pour-over. Quinoa tote bag fashion axe, Godard disrupt migas church-key tofu
                            blog locavore. Thundercats cronut polaroid Neutra tousled, meh food truck selfies narwhal American
                            Apparel.
                        </p>

                        <p>
                            Raw denim McSweeney's bicycle rights, iPhone trust fund quinoa Neutra VHS kale chips vegan PBR&amp;B
                            literally Th");
            WriteLiteral(@"undercats +1. Forage tilde four dollar toast, banjo health goth paleo butcher. Four dollar
                            toast Brooklyn pour-over American Apparel sustainable, lumbersexual listicle gluten-free health goth
                            umami hoodie. Synth Echo Park bicycle rights DIY farm-to-table, retro kogi sriracha dreamcatcher PBR&amp;B
                            flannel hashtag irony Wes Anderson. Lumbersexual Williamsburg Helvetica next level. Cold-pressed
                            slow-carb pop-up normcore Thundercats Portland, cardigan literally meditation lumbersexual crucifix.
                            Wayfarers raw denim paleo Bushwick, keytar Helvetica scenester keffiyeh 8-bit irony mumblecore
                            whatever viral Truffaut.
                        </p>

                        <p>
                            Post-ironic shabby chic VHS, Marfa keytar flannel lomo try-hard keffiyeh cray. Actually fap fanny
                            pack yr artisan ");
            WriteLiteral(@"trust fund. High Life dreamcatcher church-key gentrify. Tumblr stumptown four dollar
                            toast vinyl, cold-pressed try-hard blog authentic keffiyeh Helvetica lo-fi tilde Intelligentsia. Lomo
                            locavore salvia bespoke, twee fixie paleo cliche brunch Schlitz blog McSweeney's messenger bag swag
                            slow-carb. Odd Future photo booth pork belly, you probably haven't heard of them actually tofu ennui
                            keffiyeh lo-fi Truffaut health goth. Narwhal sustainable retro disrupt.
                        </p>

                        <p>
                            Skateboard artisan letterpress before they sold out High Life messenger bag. Bitters chambray
                            leggings listicle, drinking vinegar chillwave synth. Fanny pack hoodie American Apparel twee. American
                            Apparel PBR listicle, salvia aesthetic occupy sustainable Neutra kogi. Organic synth Tumblr viral
    ");
            WriteLiteral(@"                        plaid, shabby chic single-origin coffee Etsy 3 wolf moon slow-carb Schlitz roof party tousled squid
                            vinyl. Readymade next level literally trust fund. Distillery master cleanse migas, Vice sriracha
                            flannel chambray chia cronut.
                        </p>

                        <p>Thanks,<br>Jane</p>
                    </div>
                    <!-- /.mailbox-read-message -->
                </div>
                <!-- /.box-body -->
                <div class=""box-footer"">
                    <ul class=""mailbox-attachments clearfix"">
                        <li>
                            <span class=""mailbox-attachment-icon""><i class=""fa fa-file-pdf-o""></i></span>

                            <div class=""mailbox-attachment-info"">
                                <a href=""#"" class=""mailbox-attachment-name""><i class=""fa fa-paperclip""></i> Sep2014-report.pdf</a>
                                <span class=""mail");
            WriteLiteral(@"box-attachment-size"">
                                    1,245 KB
                                    <a href=""#"" class=""btn btn-default btn-xs pull-right""><i class=""fa fa-cloud-download""></i></a>
                                </span>
                            </div>
                        </li>
                        <li>
                            <span class=""mailbox-attachment-icon""><i class=""fa fa-file-word-o""></i></span>

                            <div class=""mailbox-attachment-info"">
                                <a href=""#"" class=""mailbox-attachment-name""><i class=""fa fa-paperclip""></i> App Description.docx</a>
                                <span class=""mailbox-attachment-size"">
                                    1,245 KB
                                    <a href=""#"" class=""btn btn-default btn-xs pull-right""><i class=""fa fa-cloud-download""></i></a>
                                </span>
                            </div>
                        </li>
                ");
            WriteLiteral("        <li>\r\n                            <span class=\"mailbox-attachment-icon has-img\">");
            EndContext();
            BeginContext(10894, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fcdff326aa57dd8c1d5a29ea576e4e393daf026823500", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10939, 660, true);
            WriteLiteral(@"</span>

                            <div class=""mailbox-attachment-info"">
                                <a href=""#"" class=""mailbox-attachment-name""><i class=""fa fa-camera""></i> photo1.png</a>
                                <span class=""mailbox-attachment-size"">
                                    2.67 MB
                                    <a href=""#"" class=""btn btn-default btn-xs pull-right""><i class=""fa fa-cloud-download""></i></a>
                                </span>
                            </div>
                        </li>
                        <li>
                            <span class=""mailbox-attachment-icon has-img"">");
            EndContext();
            BeginContext(11599, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fcdff326aa57dd8c1d5a29ea576e4e393daf026825434", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11644, 1428, true);
            WriteLiteral(@"</span>

                            <div class=""mailbox-attachment-info"">
                                <a href=""#"" class=""mailbox-attachment-name""><i class=""fa fa-camera""></i> photo2.png</a>
                                <span class=""mailbox-attachment-size"">
                                    1.9 MB
                                    <a href=""#"" class=""btn btn-default btn-xs pull-right""><i class=""fa fa-cloud-download""></i></a>
                                </span>
                            </div>
                        </li>
                    </ul>
                </div>
                <!-- /.box-footer -->
                <div class=""box-footer"">
                    <div class=""pull-right"">
                        <button type=""button"" class=""btn btn-default""><i class=""fa fa-reply""></i> Reply</button>
                        <button type=""button"" class=""btn btn-default""><i class=""fa fa-share""></i> Forward</button>
                    </div>
                    <button type=");
            WriteLiteral(@"""button"" class=""btn btn-default""><i class=""fa fa-trash-o""></i> Delete</button>
                    <button type=""button"" class=""btn btn-default""><i class=""fa fa-print""></i> Print</button>
                </div>
                <!-- /.box-footer -->
            </div>
            <!-- /. box -->
        </div>
        <!-- /.col -->
    </div>
    <!-- /.row -->
</section>
<!-- /.content -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReadModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ReadModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ReadModel>)PageContext?.ViewData;
        public ReadModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
