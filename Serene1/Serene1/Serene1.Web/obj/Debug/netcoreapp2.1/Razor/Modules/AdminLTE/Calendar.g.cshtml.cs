#pragma checksum "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\AdminLTE\Calendar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4f6e339fa1686d25a58757bf3d52f921d6daab7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_AdminLTE_Calendar), @"mvc.1.0.view", @"/Modules/AdminLTE/Calendar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/AdminLTE/Calendar.cshtml", typeof(AspNetCore.Modules_AdminLTE_Calendar))]
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
#line 1 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#line 2 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#line 3 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using Serene1;

#line default
#line hidden
#line 4 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4f6e339fa1686d25a58757bf3d52f921d6daab7", @"/Modules/AdminLTE/Calendar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3254ced552f0dad62c9e8654f29630ba694f49ac", @"/Modules/_ViewImports.cshtml")]
    public class Modules_AdminLTE_Calendar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/fullcalendar/fullcalendar.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/fullcalendar/fullcalendar.print.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("print"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/fullcalendar/fullcalendar.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/adminlte/demo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\AdminLTE\Calendar.cshtml"
  
    ViewData["Title"] = "Calendar";

#line default
#line hidden
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Head", async() => {
                BeginContext(61, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(67, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f48ba39fa049488aa8859c98ffffc01b", async() => {
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
                BeginContext(141, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(147, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ab1c4007a52344c9bc81d44514c5b8f4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(237, 105, true);
                WriteLiteral("\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.10.2/moment.min.js\"></script>\r\n    ");
                EndContext();
                BeginContext(342, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d2c22145d2844688f47ac64f80c7dcc", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(408, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(414, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78c19d1a872448be888e9759f965f450", async() => {
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
                BeginContext(464, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(469, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ContentHeader", async() => {
                BeginContext(495, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(506, 17, false);
#line 14 "C:\Users\frede\OneDrive\Programmering\4. Semester Project\beerRemote19\Serene1\Serene1\Serene1.Web\Modules\AdminLTE\Calendar.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(523, 36, true);
                WriteLiteral("<small> full calendar</small></h1>\r\n");
                EndContext();
            }
            );
            BeginContext(562, 9685, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-3"">
        <div class=""box box-solid"">
            <div class=""box-header with-border"">
                <h4 class=""box-title"">Draggable Events</h4>
            </div>
            <div class=""box-body"">
                <!-- the events -->
                <div id=""external-events"">
                    <div class=""external-event bg-green"">Lunch</div>
                    <div class=""external-event bg-yellow"">Go home</div>
                    <div class=""external-event bg-aqua"">Do homework</div>
                    <div class=""external-event bg-light-blue"">Work on UI design</div>
                    <div class=""external-event bg-red"">Sleep tight</div>
                    <div class=""checkbox"">
                        <label for=""drop-remove"">
                            <input type=""checkbox"" id=""drop-remove"">
                            remove after drop
                        </label>
                    </div>
                </div>
            <");
            WriteLiteral(@"/div><!-- /.box-body -->
        </div><!-- /. box -->
        <div class=""box box-solid"">
            <div class=""box-header with-border"">
                <h3 class=""box-title"">Create Event</h3>
            </div>
            <div class=""box-body"">
                <div class=""btn-group"" style=""width: 100%; margin-bottom: 10px;"">
                    <!--<button type=""button"" id=""color-chooser-btn"" class=""btn btn-info btn-block dropdown-toggle"" data-toggle=""dropdown"">Color <span class=""caret""></span></button>-->
                    <ul class=""fc-color-picker"" id=""color-chooser"">
                        <li><a class=""text-aqua"" href=""#""><i class=""fa fa-square""></i></a></li>
                        <li><a class=""text-blue"" href=""#""><i class=""fa fa-square""></i></a></li>
                        <li><a class=""text-light-blue"" href=""#""><i class=""fa fa-square""></i></a></li>
                        <li><a class=""text-teal"" href=""#""><i class=""fa fa-square""></i></a></li>
                        <li><a clas");
            WriteLiteral(@"s=""text-yellow"" href=""#""><i class=""fa fa-square""></i></a></li>
                        <li><a class=""text-orange"" href=""#""><i class=""fa fa-square""></i></a></li>
                        <li><a class=""text-green"" href=""#""><i class=""fa fa-square""></i></a></li>
                        <li><a class=""text-lime"" href=""#""><i class=""fa fa-square""></i></a></li>
                        <li><a class=""text-red"" href=""#""><i class=""fa fa-square""></i></a></li>
                        <li><a class=""text-purple"" href=""#""><i class=""fa fa-square""></i></a></li>
                        <li><a class=""text-fuchsia"" href=""#""><i class=""fa fa-square""></i></a></li>
                        <li><a class=""text-muted"" href=""#""><i class=""fa fa-square""></i></a></li>
                        <li><a class=""text-navy"" href=""#""><i class=""fa fa-square""></i></a></li>
                    </ul>
                </div><!-- /btn-group -->
                <div class=""input-group"">
                    <input id=""new-event"" type=""text"" class=""fo");
            WriteLiteral(@"rm-control"" placeholder=""Event Title"">
                    <div class=""input-group-btn"">
                        <button id=""add-new-event"" type=""button"" class=""btn btn-primary btn-flat"">Add</button>
                    </div><!-- /btn-group -->
                </div><!-- /input-group -->
            </div>
        </div>
    </div><!-- /.col -->
    <div class=""col-md-9"">
        <div class=""box box-primary"">
            <div class=""box-body no-padding"">
                <!-- THE CALENDAR -->
                <div id=""calendar""></div>
            </div><!-- /.box-body -->
        </div><!-- /. box -->
    </div><!-- /.col -->
</div><!-- /.row -->

<script>
      $(function () {

        /* initialize the external events
         -----------------------------------------------------------------*/
        function ini_events(ele) {
          ele.each(function () {

            // create an Event Object (http://arshaw.com/fullcalendar/docs/event_data/Event_Object/)
            // it doe");
            WriteLiteral(@"sn't need to have a start or end
            var eventObject = {
              title: $.trim($(this).text()) // use the element's text as the event title
            };

            // store the Event Object in the DOM element so we can get to it later
            $(this).data('eventObject', eventObject);

            // make the event draggable using jQuery UI
            $(this).draggable({
              zIndex: 1070,
              revert: true, // will cause the event to go back to its
              revertDuration: 0  //  original position after the drag
            });

          });
        }
        ini_events($('#external-events div.external-event'));

        /* initialize the calendar
         -----------------------------------------------------------------*/
        //Date for the calendar events (dummy data)
        var date = new Date();
        var d = date.getDate(),
                m = date.getMonth(),
                y = date.getFullYear();
        $('#calendar').ful");
            WriteLiteral(@"lCalendar({
          header: {
            left: 'prev,next today',
            center: 'title',
            right: 'month,agendaWeek,agendaDay'
          },
          buttonText: {
            today: 'today',
            month: 'month',
            week: 'week',
            day: 'day'
          },
          //Random default events
          events: [
            {
              title: 'All Day Event',
              start: new Date(y, m, 1),
              backgroundColor: ""#f56954"", //red
              borderColor: ""#f56954"" //red
            },
            {
              title: 'Long Event',
              start: new Date(y, m, d - 5),
              end: new Date(y, m, d - 2),
              backgroundColor: ""#f39c12"", //yellow
              borderColor: ""#f39c12"" //yellow
            },
            {
              title: 'Meeting',
              start: new Date(y, m, d, 10, 30),
              allDay: false,
              backgroundColor: ""#0073b7"", //Blue
              border");
            WriteLiteral(@"Color: ""#0073b7"" //Blue
            },
            {
              title: 'Lunch',
              start: new Date(y, m, d, 12, 0),
              end: new Date(y, m, d, 14, 0),
              allDay: false,
              backgroundColor: ""#00c0ef"", //Info (aqua)
              borderColor: ""#00c0ef"" //Info (aqua)
            },
            {
              title: 'Birthday Party',
              start: new Date(y, m, d + 1, 19, 0),
              end: new Date(y, m, d + 1, 22, 30),
              allDay: false,
              backgroundColor: ""#00a65a"", //Success (green)
              borderColor: ""#00a65a"" //Success (green)
            },
            {
              title: 'Click for Google',
              start: new Date(y, m, 28),
              end: new Date(y, m, 29),
              url: 'http://google.com/',
              backgroundColor: ""#3c8dbc"", //Primary (light-blue)
              borderColor: ""#3c8dbc"" //Primary (light-blue)
            }
          ],
          editable: true,
   ");
            WriteLiteral(@"       droppable: true, // this allows things to be dropped onto the calendar !!!
          drop: function (date, allDay) { // this function is called when something is dropped

            // retrieve the dropped element's stored Event Object
            var originalEventObject = $(this).data('eventObject');

            // we need to copy it, so that multiple events don't have a reference to the same object
            var copiedEventObject = $.extend({}, originalEventObject);

            // assign it the date that was reported
            copiedEventObject.start = date;
            copiedEventObject.allDay = allDay;
            copiedEventObject.backgroundColor = $(this).css(""background-color"");
            copiedEventObject.borderColor = $(this).css(""border-color"");

            // render the event on the calendar
            // the last `true` argument determines if the event ""sticks"" (http://arshaw.com/fullcalendar/docs/event_rendering/renderEvent/)
            $('#calendar').fullCalen");
            WriteLiteral(@"dar('renderEvent', copiedEventObject, true);

            // is the ""remove after drop"" checkbox checked?
            if ($('#drop-remove').is(':checked')) {
              // if so, remove the element from the ""Draggable Events"" list
              $(this).remove();
            }

          }
        });

        /* ADDING EVENTS */
        var currColor = ""#3c8dbc""; //Red by default
        //Color chooser button
        var colorChooser = $(""#color-chooser-btn"");
        $(""#color-chooser > li > a"").click(function (e) {
          e.preventDefault();
          //Save color
          currColor = $(this).css(""color"");
          //Add color effect to button
          $('#add-new-event').css({""background-color"": currColor, ""border-color"": currColor});
        });
        $(""#add-new-event"").click(function (e) {
          e.preventDefault();
          //Get value and make sure it is not null
          var val = $(""#new-event"").val();
          if (val.length == 0) {
            return;
");
            WriteLiteral(@"          }

          //Create events
          var event = $(""<div />"");
          event.css({""background-color"": currColor, ""border-color"": currColor, ""color"": ""#fff""}).addClass(""external-event"");
          event.html(val);
          $('#external-events').prepend(event);

          //Add draggable funtionality
          ini_events(event);

          //Remove event from text input
          $(""#new-event"").val("""");
        });
      });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
