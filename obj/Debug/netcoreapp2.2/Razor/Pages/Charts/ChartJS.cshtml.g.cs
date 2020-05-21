#pragma checksum "D:\MyProwork\Temp\DNC6\Pages\Charts\ChartJS.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da2dbd150ed0020eedb69e7bc32ebc518b53d0fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DNC6.Pages.Charts.Pages_Charts_ChartJS), @"mvc.1.0.razor-page", @"/Pages/Charts/ChartJS.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Charts/ChartJS.cshtml", typeof(DNC6.Pages.Charts.Pages_Charts_ChartJS), null)]
namespace DNC6.Pages.Charts
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da2dbd150ed0020eedb69e7bc32ebc518b53d0fb", @"/Pages/Charts/ChartJS.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a089671beab0bd5d19b5784d16abee6c378c833", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Charts_ChartJS : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/chart.js/Chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\MyProwork\Temp\DNC6\Pages\Charts\ChartJS.cshtml"
  
    ViewData["Title"] = "ChartJS";

#line default
#line hidden
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
                BeginContext(115, 28, true);
                WriteLiteral("\r\n    <!-- ChartJS -->\r\n    ");
                EndContext();
                BeginContext(143, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da2dbd150ed0020eedb69e7bc32ebc518b53d0fb4176", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(195, 8746, true);
                WriteLiteral(@"

    <!-- page script -->
    <script>
  $(function () {
    /* ChartJS
     * -------
     * Here we will create a few charts using ChartJS
     */

    //--------------
    //- AREA CHART -
    //--------------

    // Get context with jQuery - using jQuery's .get() method.
    var areaChartCanvas = $('#areaChart').get(0).getContext('2d')
    // This will get the first returned node in the jQuery collection.
    var areaChart       = new Chart(areaChartCanvas)

    var areaChartData = {
      labels  : ['January', 'February', 'March', 'April', 'May', 'June', 'July'],
      datasets: [
        {
          label               : 'Electronics',
          fillColor           : 'rgba(210, 214, 222, 1)',
          strokeColor         : 'rgba(210, 214, 222, 1)',
          pointColor          : 'rgba(210, 214, 222, 1)',
          pointStrokeColor    : '#c1c7d1',
          pointHighlightFill  : '#fff',
          pointHighlightStroke: 'rgba(220,220,220,1)',
          data                ");
                WriteLiteral(@": [65, 59, 80, 81, 56, 55, 40]
        },
        {
          label               : 'Digital Goods',
          fillColor           : 'rgba(60,141,188,0.9)',
          strokeColor         : 'rgba(60,141,188,0.8)',
          pointColor          : '#3b8bba',
          pointStrokeColor    : 'rgba(60,141,188,1)',
          pointHighlightFill  : '#fff',
          pointHighlightStroke: 'rgba(60,141,188,1)',
          data                : [28, 48, 40, 19, 86, 27, 90]
        }
      ]
    }

    var areaChartOptions = {
      //Boolean - If we should show the scale at all
      showScale               : true,
      //Boolean - Whether grid lines are shown across the chart
      scaleShowGridLines      : false,
      //String - Colour of the grid lines
      scaleGridLineColor      : 'rgba(0,0,0,.05)',
      //Number - Width of the grid lines
      scaleGridLineWidth      : 1,
      //Boolean - Whether to show horizontal lines (except X axis)
      scaleShowHorizontalLines: true,
      //Boo");
                WriteLiteral(@"lean - Whether to show vertical lines (except Y axis)
      scaleShowVerticalLines  : true,
      //Boolean - Whether the line is curved between points
      bezierCurve             : true,
      //Number - Tension of the bezier curve between points
      bezierCurveTension      : 0.3,
      //Boolean - Whether to show a dot for each point
      pointDot                : false,
      //Number - Radius of each point dot in pixels
      pointDotRadius          : 4,
      //Number - Pixel width of point dot stroke
      pointDotStrokeWidth     : 1,
      //Number - amount extra to add to the radius to cater for hit detection outside the drawn point
      pointHitDetectionRadius : 20,
      //Boolean - Whether to show a stroke for datasets
      datasetStroke           : true,
      //Number - Pixel width of dataset stroke
      datasetStrokeWidth      : 2,
      //Boolean - Whether to fill the dataset with a color
      datasetFill             : true,
      //String - A legend template
     ");
                WriteLiteral(@" legendTemplate          : '<ul class=""<%=name.toLowerCase()%>-legend""><% for (var i=0; i<datasets.length; i++){%><li><span style=""background-color:<%=datasets[i].lineColor%>""></span><%if(datasets[i].label){%><%=datasets[i].label%><%}%></li><%}%></ul>',
      //Boolean - whether to maintain the starting aspect ratio or not when responsive, if set to false, will take up entire container
      maintainAspectRatio     : true,
      //Boolean - whether to make the chart responsive to window resizing
      responsive              : true
    }

    //Create the line chart
    areaChart.Line(areaChartData, areaChartOptions)

    //-------------
    //- LINE CHART -
    //--------------
    var lineChartCanvas          = $('#lineChart').get(0).getContext('2d')
    var lineChart                = new Chart(lineChartCanvas)
    var lineChartOptions         = areaChartOptions
    lineChartOptions.datasetFill = false
    lineChart.Line(areaChartData, lineChartOptions)

    //-------------
    //- PIE C");
                WriteLiteral(@"HART -
    //-------------
    // Get context with jQuery - using jQuery's .get() method.
    var pieChartCanvas = $('#pieChart').get(0).getContext('2d')
    var pieChart       = new Chart(pieChartCanvas)
    var PieData        = [
      {
        value    : 700,
        color    : '#f56954',
        highlight: '#f56954',
        label    : 'Chrome'
      },
      {
        value    : 500,
        color    : '#00a65a',
        highlight: '#00a65a',
        label    : 'IE'
      },
      {
        value    : 400,
        color    : '#f39c12',
        highlight: '#f39c12',
        label    : 'FireFox'
      },
      {
        value    : 600,
        color    : '#00c0ef',
        highlight: '#00c0ef',
        label    : 'Safari'
      },
      {
        value    : 300,
        color    : '#3c8dbc',
        highlight: '#3c8dbc',
        label    : 'Opera'
      },
      {
        value    : 100,
        color    : '#d2d6de',
        highlight: '#d2d6de',
        label    : ");
                WriteLiteral(@"'Navigator'
      }
    ]
    var pieOptions     = {
      //Boolean - Whether we should show a stroke on each segment
      segmentShowStroke    : true,
      //String - The colour of each segment stroke
      segmentStrokeColor   : '#fff',
      //Number - The width of each segment stroke
      segmentStrokeWidth   : 2,
      //Number - The percentage of the chart that we cut out of the middle
      percentageInnerCutout: 50, // This is 0 for Pie charts
      //Number - Amount of animation steps
      animationSteps       : 100,
      //String - Animation easing effect
      animationEasing      : 'easeOutBounce',
      //Boolean - Whether we animate the rotation of the Doughnut
      animateRotate        : true,
      //Boolean - Whether we animate scaling the Doughnut from the centre
      animateScale         : false,
      //Boolean - whether to make the chart responsive to window resizing
      responsive           : true,
      // Boolean - whether to maintain the starting aspect");
                WriteLiteral(@" ratio or not when responsive, if set to false, will take up entire container
      maintainAspectRatio  : true,
      //String - A legend template
      legendTemplate       : '<ul class=""<%=name.toLowerCase()%>-legend""><% for (var i=0; i<segments.length; i++){%><li><span style=""background-color:<%=segments[i].fillColor%>""></span><%if(segments[i].label){%><%=segments[i].label%><%}%></li><%}%></ul>'
    }
    //Create pie or douhnut chart
    // You can switch between pie and douhnut using the method below.
    pieChart.Doughnut(PieData, pieOptions)

    //-------------
    //- BAR CHART -
    //-------------
    var barChartCanvas                   = $('#barChart').get(0).getContext('2d')
    var barChart                         = new Chart(barChartCanvas)
    var barChartData                     = areaChartData
    barChartData.datasets[1].fillColor   = '#00a65a'
    barChartData.datasets[1].strokeColor = '#00a65a'
    barChartData.datasets[1].pointColor  = '#00a65a'
    var barChartOption");
                WriteLiteral(@"s                  = {
      //Boolean - Whether the scale should start at zero, or an order of magnitude down from the lowest value
      scaleBeginAtZero        : true,
      //Boolean - Whether grid lines are shown across the chart
      scaleShowGridLines      : true,
      //String - Colour of the grid lines
      scaleGridLineColor      : 'rgba(0,0,0,.05)',
      //Number - Width of the grid lines
      scaleGridLineWidth      : 1,
      //Boolean - Whether to show horizontal lines (except X axis)
      scaleShowHorizontalLines: true,
      //Boolean - Whether to show vertical lines (except Y axis)
      scaleShowVerticalLines  : true,
      //Boolean - If there is a stroke on each bar
      barShowStroke           : true,
      //Number - Pixel width of the bar stroke
      barStrokeWidth          : 2,
      //Number - Spacing between each of the X value sets
      barValueSpacing         : 5,
      //Number - Spacing between data sets within X values
      barDatasetSpacing       :");
                WriteLiteral(@" 1,
      //String - A legend template
      legendTemplate          : '<ul class=""<%=name.toLowerCase()%>-legend""><% for (var i=0; i<datasets.length; i++){%><li><span style=""background-color:<%=datasets[i].fillColor%>""></span><%if(datasets[i].label){%><%=datasets[i].label%><%}%></li><%}%></ul>',
      //Boolean - whether to make the chart responsive
      responsive              : true,
      maintainAspectRatio     : true
    }

    barChartOptions.datasetFill = false
    barChart.Bar(barChartData, barChartOptions)
  })
    </script>
");
                EndContext();
            }
            );
            BeginContext(8944, 4238, true);
            WriteLiteral(@"

<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        ChartJS
        <small>Preview sample</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li><a href=""#"">Charts</a></li>
        <li class=""active"">ChartJS</li>
    </ol>
</section>

<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-md-6"">
            <!-- AREA CHART -->
            <div class=""box box-primary"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Area Chart</h3>

                    <div class=""box-tools pull-right"">
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                            <i class=""fa fa-minus""></i>
                        </button>
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i></bu");
            WriteLiteral(@"tton>
                    </div>
                </div>
                <div class=""box-body"">
                    <div class=""chart"">
                        <canvas id=""areaChart"" style=""height:250px""></canvas>
                    </div>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->
            <!-- DONUT CHART -->
            <div class=""box box-danger"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Donut Chart</h3>

                    <div class=""box-tools pull-right"">
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                            <i class=""fa fa-minus""></i>
                        </button>
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i></button>
                    </div>
                </div>
                <div class=""box-body"">
          ");
            WriteLiteral(@"          <canvas id=""pieChart"" style=""height:250px""></canvas>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->

        </div>
        <!-- /.col (LEFT) -->
        <div class=""col-md-6"">
            <!-- LINE CHART -->
            <div class=""box box-info"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Line Chart</h3>

                    <div class=""box-tools pull-right"">
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                            <i class=""fa fa-minus""></i>
                        </button>
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i></button>
                    </div>
                </div>
                <div class=""box-body"">
                    <div class=""chart"">
                        <canvas id=""lineChart"" style=""height:250px""></canva");
            WriteLiteral(@"s>
                    </div>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->
            <!-- BAR CHART -->
            <div class=""box box-success"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Bar Chart</h3>

                    <div class=""box-tools pull-right"">
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                            <i class=""fa fa-minus""></i>
                        </button>
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i></button>
                    </div>
                </div>
                <div class=""box-body"">
                    <div class=""chart"">
                        <canvas id=""barChart"" style=""height:230px""></canvas>
                    </div>
                </div>
                <!-- /.box-body -->
            </div>
");
            WriteLiteral("            <!-- /.box -->\r\n\r\n        </div>\r\n        <!-- /.col (RIGHT) -->\r\n    </div>\r\n    <!-- /.row -->\r\n\r\n</section>\r\n<!-- /.content -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChartJSModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ChartJSModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ChartJSModel>)PageContext?.ViewData;
        public ChartJSModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
