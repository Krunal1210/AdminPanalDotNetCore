#pragma checksum "D:\MyProwork\Temp\DNC6\Pages\Tables\Simple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d8ec1fdf2508627377402a217fe0b270e18aa54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DNC6.Pages.Tables.Pages_Tables_Simple), @"mvc.1.0.razor-page", @"/Pages/Tables/Simple.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Tables/Simple.cshtml", typeof(DNC6.Pages.Tables.Pages_Tables_Simple), null)]
namespace DNC6.Pages.Tables
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d8ec1fdf2508627377402a217fe0b270e18aa54", @"/Pages/Tables/Simple.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a089671beab0bd5d19b5784d16abee6c378c833", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Tables_Simple : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\MyProwork\Temp\DNC6\Pages\Tables\Simple.cshtml"
  
    ViewData["Title"] = "Simple";

#line default
#line hidden
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(88, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(95, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(115, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(122, 15995, true);
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        Simple Tables
        <small>preview of simple tables</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li><a href=""#"">Tables</a></li>
        <li class=""active"">Simple</li>
    </ol>
</section>

<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""box"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Bordered Table</h3>
                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
                    <table class=""table table-bordered"">
                        <tr>
                            <th style=""width: 10px"">#</th>
                            <th>Task</th>
                            <th>Progress</th>
                            <th style=""width: 40px"">Labe");
            WriteLiteral(@"l</th>
                        </tr>
                        <tr>
                            <td>1.</td>
                            <td>Update software</td>
                            <td>
                                <div class=""progress progress-xs"">
                                    <div class=""progress-bar progress-bar-danger"" style=""width: 55%""></div>
                                </div>
                            </td>
                            <td><span class=""badge bg-red"">55%</span></td>
                        </tr>
                        <tr>
                            <td>2.</td>
                            <td>Clean database</td>
                            <td>
                                <div class=""progress progress-xs"">
                                    <div class=""progress-bar progress-bar-yellow"" style=""width: 70%""></div>
                                </div>
                            </td>
                            <td><span class=""badge bg-yel");
            WriteLiteral(@"low"">70%</span></td>
                        </tr>
                        <tr>
                            <td>3.</td>
                            <td>Cron job running</td>
                            <td>
                                <div class=""progress progress-xs progress-striped active"">
                                    <div class=""progress-bar progress-bar-primary"" style=""width: 30%""></div>
                                </div>
                            </td>
                            <td><span class=""badge bg-light-blue"">30%</span></td>
                        </tr>
                        <tr>
                            <td>4.</td>
                            <td>Fix and squish bugs</td>
                            <td>
                                <div class=""progress progress-xs progress-striped active"">
                                    <div class=""progress-bar progress-bar-success"" style=""width: 90%""></div>
                                </div>
               ");
            WriteLiteral(@"             </td>
                            <td><span class=""badge bg-green"">90%</span></td>
                        </tr>
                    </table>
                </div>
                <!-- /.box-body -->
                <div class=""box-footer clearfix"">
                    <ul class=""pagination pagination-sm no-margin pull-right"">
                        <li><a href=""#"">&laquo;</a></li>
                        <li><a href=""#"">1</a></li>
                        <li><a href=""#"">2</a></li>
                        <li><a href=""#"">3</a></li>
                        <li><a href=""#"">&raquo;</a></li>
                    </ul>
                </div>
            </div>
            <!-- /.box -->

            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Condensed Full Width Table</h3>
                </div>
                <!-- /.box-header -->
                <div class=""box-body no-padding"">
                    <table class=""tabl");
            WriteLiteral(@"e table-condensed"">
                        <tr>
                            <th style=""width: 10px"">#</th>
                            <th>Task</th>
                            <th>Progress</th>
                            <th style=""width: 40px"">Label</th>
                        </tr>
                        <tr>
                            <td>1.</td>
                            <td>Update software</td>
                            <td>
                                <div class=""progress progress-xs"">
                                    <div class=""progress-bar progress-bar-danger"" style=""width: 55%""></div>
                                </div>
                            </td>
                            <td><span class=""badge bg-red"">55%</span></td>
                        </tr>
                        <tr>
                            <td>2.</td>
                            <td>Clean database</td>
                            <td>
                                <div class=""progress");
            WriteLiteral(@" progress-xs"">
                                    <div class=""progress-bar progress-bar-yellow"" style=""width: 70%""></div>
                                </div>
                            </td>
                            <td><span class=""badge bg-yellow"">70%</span></td>
                        </tr>
                        <tr>
                            <td>3.</td>
                            <td>Cron job running</td>
                            <td>
                                <div class=""progress progress-xs progress-striped active"">
                                    <div class=""progress-bar progress-bar-primary"" style=""width: 30%""></div>
                                </div>
                            </td>
                            <td><span class=""badge bg-light-blue"">30%</span></td>
                        </tr>
                        <tr>
                            <td>4.</td>
                            <td>Fix and squish bugs</td>
                            <td>
");
            WriteLiteral(@"                                <div class=""progress progress-xs progress-striped active"">
                                    <div class=""progress-bar progress-bar-success"" style=""width: 90%""></div>
                                </div>
                            </td>
                            <td><span class=""badge bg-green"">90%</span></td>
                        </tr>
                    </table>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->
        </div>
        <!-- /.col -->
        <div class=""col-md-6"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Simple Full Width Table</h3>

                    <div class=""box-tools"">
                        <ul class=""pagination pagination-sm no-margin pull-right"">
                            <li><a href=""#"">&laquo;</a></li>
                            <li><a href=""#"">1</a></li>
                            <li><");
            WriteLiteral(@"a href=""#"">2</a></li>
                            <li><a href=""#"">3</a></li>
                            <li><a href=""#"">&raquo;</a></li>
                        </ul>
                    </div>
                </div>
                <!-- /.box-header -->
                <div class=""box-body no-padding"">
                    <table class=""table"">
                        <tr>
                            <th style=""width: 10px"">#</th>
                            <th>Task</th>
                            <th>Progress</th>
                            <th style=""width: 40px"">Label</th>
                        </tr>
                        <tr>
                            <td>1.</td>
                            <td>Update software</td>
                            <td>
                                <div class=""progress progress-xs"">
                                    <div class=""progress-bar progress-bar-danger"" style=""width: 55%""></div>
                                </div>
                ");
            WriteLiteral(@"            </td>
                            <td><span class=""badge bg-red"">55%</span></td>
                        </tr>
                        <tr>
                            <td>2.</td>
                            <td>Clean database</td>
                            <td>
                                <div class=""progress progress-xs"">
                                    <div class=""progress-bar progress-bar-yellow"" style=""width: 70%""></div>
                                </div>
                            </td>
                            <td><span class=""badge bg-yellow"">70%</span></td>
                        </tr>
                        <tr>
                            <td>3.</td>
                            <td>Cron job running</td>
                            <td>
                                <div class=""progress progress-xs progress-striped active"">
                                    <div class=""progress-bar progress-bar-primary"" style=""width: 30%""></div>
                ");
            WriteLiteral(@"                </div>
                            </td>
                            <td><span class=""badge bg-light-blue"">30%</span></td>
                        </tr>
                        <tr>
                            <td>4.</td>
                            <td>Fix and squish bugs</td>
                            <td>
                                <div class=""progress progress-xs progress-striped active"">
                                    <div class=""progress-bar progress-bar-success"" style=""width: 90%""></div>
                                </div>
                            </td>
                            <td><span class=""badge bg-green"">90%</span></td>
                        </tr>
                    </table>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->

            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Striped Full Width Table</h3>
               ");
            WriteLiteral(@" </div>
                <!-- /.box-header -->
                <div class=""box-body no-padding"">
                    <table class=""table table-striped"">
                        <tr>
                            <th style=""width: 10px"">#</th>
                            <th>Task</th>
                            <th>Progress</th>
                            <th style=""width: 40px"">Label</th>
                        </tr>
                        <tr>
                            <td>1.</td>
                            <td>Update software</td>
                            <td>
                                <div class=""progress progress-xs"">
                                    <div class=""progress-bar progress-bar-danger"" style=""width: 55%""></div>
                                </div>
                            </td>
                            <td><span class=""badge bg-red"">55%</span></td>
                        </tr>
                        <tr>
                            <td>2.</td>
    ");
            WriteLiteral(@"                        <td>Clean database</td>
                            <td>
                                <div class=""progress progress-xs"">
                                    <div class=""progress-bar progress-bar-yellow"" style=""width: 70%""></div>
                                </div>
                            </td>
                            <td><span class=""badge bg-yellow"">70%</span></td>
                        </tr>
                        <tr>
                            <td>3.</td>
                            <td>Cron job running</td>
                            <td>
                                <div class=""progress progress-xs progress-striped active"">
                                    <div class=""progress-bar progress-bar-primary"" style=""width: 30%""></div>
                                </div>
                            </td>
                            <td><span class=""badge bg-light-blue"">30%</span></td>
                        </tr>
                        <tr>");
            WriteLiteral(@"
                            <td>4.</td>
                            <td>Fix and squish bugs</td>
                            <td>
                                <div class=""progress progress-xs progress-striped active"">
                                    <div class=""progress-bar progress-bar-success"" style=""width: 90%""></div>
                                </div>
                            </td>
                            <td><span class=""badge bg-green"">90%</span></td>
                        </tr>
                    </table>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->
        </div>
        <!-- /.col -->
    </div>
    <!-- /.row -->
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Responsive Hover Table</h3>

                    <div class=""box-tools"">
                        <div class=""input-gro");
            WriteLiteral(@"up input-group-sm"" style=""width: 150px;"">
                            <input type=""text"" name=""table_search"" class=""form-control pull-right"" placeholder=""Search"">

                            <div class=""input-group-btn"">
                                <button type=""submit"" class=""btn btn-default""><i class=""fa fa-search""></i></button>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /.box-header -->
                <div class=""box-body table-responsive no-padding"">
                    <table class=""table table-hover"">
                        <tr>
                            <th>ID</th>
                            <th>User</th>
                            <th>Date</th>
                            <th>Status</th>
                            <th>Reason</th>
                        </tr>
                        <tr>
                            <td>183</td>
                            <td>John Doe</td>
  ");
            WriteLiteral(@"                          <td>11-7-2014</td>
                            <td><span class=""label label-success"">Approved</span></td>
                            <td>Bacon ipsum dolor sit amet salami venison chicken flank fatback doner.</td>
                        </tr>
                        <tr>
                            <td>219</td>
                            <td>Alexander Pierce</td>
                            <td>11-7-2014</td>
                            <td><span class=""label label-warning"">Pending</span></td>
                            <td>Bacon ipsum dolor sit amet salami venison chicken flank fatback doner.</td>
                        </tr>
                        <tr>
                            <td>657</td>
                            <td>Bob Doe</td>
                            <td>11-7-2014</td>
                            <td><span class=""label label-primary"">Approved</span></td>
                            <td>Bacon ipsum dolor sit amet salami venison chicken flank fatbac");
            WriteLiteral(@"k doner.</td>
                        </tr>
                        <tr>
                            <td>175</td>
                            <td>Mike Doe</td>
                            <td>11-7-2014</td>
                            <td><span class=""label label-danger"">Denied</span></td>
                            <td>Bacon ipsum dolor sit amet salami venison chicken flank fatback doner.</td>
                        </tr>
                    </table>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->
        </div>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimpleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SimpleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SimpleModel>)PageContext?.ViewData;
        public SimpleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
