#pragma checksum "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\TravelPost\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e2a2dd0f58575c373ad1c03ba79864c926f75d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TravelPost_Create), @"mvc.1.0.view", @"/Views/TravelPost/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e2a2dd0f58575c373ad1c03ba79864c926f75d6", @"/Views/TravelPost/Create.cshtml")]
    public class Views_TravelPost_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shared_Traveling.ViewModels.TravelPosts.CreateVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("45"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/back.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\TravelPost\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/particlesjs/2.2.2/particles.min.js""></script>
<link rel=""stylesheet"" href=""http://code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css"">

<script src=""http://code.jquery.com/jquery-1.10.2.js""></script>

<script src=""http://code.jquery.com/ui/1.11.4/jquery-ui.js""></script>

<script>
    $(function () {
        $(""#datepicker2"").datepicker();
    });
</script>
<div class=""row"">
    <div class=""col-3""></div>
    <div class=""col-6"">
        <form action=""/TravelPost/Create"" method=""post"">
            <div class=""card"">
                <div class=""card-header"">
                    Post
                </div>
                <div class=""card-body"">
                    <h5 class=""card-title"">
                        <label>City Of Departure</label>
                        ");
#nullable restore
#line 30 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\TravelPost\Create.cshtml"
                   Write(Html.TextBoxFor(p => p.CityOfDeparture, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 31 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\TravelPost\Create.cshtml"
                   Write(Html.ValidationMessageFor(p => p.CityOfDeparture, null, new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <label for=\"HourOfDeparture\"> Date and Hour Of Departure</label>\r\n                        <input type=\"datetime-local\" id=\"HourOfDeparture\" name=\"HourOfDeparture\" class=\"form-control\">\r\n                        ");
#nullable restore
#line 34 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\TravelPost\Create.cshtml"
                   Write(Html.ValidationMessageFor(p => p.HourOfDeparture, null, new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <label>City Of Destination</label>\r\n                        ");
#nullable restore
#line 36 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\TravelPost\Create.cshtml"
                   Write(Html.TextBoxFor(p => p.CityOfDestination, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 37 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\TravelPost\Create.cshtml"
                   Write(Html.ValidationMessageFor(p => p.CityOfDestination, null, new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <label for=\"HourOfDestination\">Date and Hour of Arrival</label>\r\n                        <input type=\"datetime-local\" id=\"HourOfDestination\" name=\"HourOfDestination\" class=\"form-control\">\r\n                        ");
#nullable restore
#line 40 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\TravelPost\Create.cshtml"
                   Write(Html.ValidationMessageFor(p => p.HourOfDestination, null, new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                        <label for=\"AvailableSeats\">Available Seats</label>\r\n                        <input type=\"number\" id=\"AvailableSeats\" name=\"AvailableSeats\"><br />\r\n                        ");
#nullable restore
#line 43 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\TravelPost\Create.cshtml"
                   Write(Html.ValidationMessageFor(p => p.AvailableSeats, null, new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                        <label for=\"AddressOfDeparture\">Address of Departure</label>\r\n                        ");
#nullable restore
#line 45 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\TravelPost\Create.cshtml"
                   Write(Html.TextBoxFor(p => p.AddressOfDeparture, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 46 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\TravelPost\Create.cshtml"
                   Write(Html.ValidationMessageFor(p => p.AddressOfDeparture, null, new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <label>Address of Destination</label>\r\n                        ");
#nullable restore
#line 48 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\TravelPost\Create.cshtml"
                   Write(Html.TextBoxFor(p => p.AddressOfDestination, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 49 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\TravelPost\Create.cshtml"
                   Write(Html.ValidationMessageFor(p => p.AddressOfDestination, null, new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                        <label for=\"Price\">Price Per Passenger</label>\r\n                        <input type=\"number\" id=\"Price\" name=\"Price\" step=\"any\">\r\n                        ");
#nullable restore
#line 52 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\TravelPost\Create.cshtml"
                   Write(Html.ValidationMessageFor(p => p.Price, null, new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h5>
                    
                    <input class=""btn btn-primary "" type=""submit"" name=""Create"" value=""Create Post"" />
                </div>
            </div>
        </form>
        <br />
        <a href=""/TravelPost/Index"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5e2a2dd0f58575c373ad1c03ba79864c926f75d69790", async() => {
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
            WriteLiteral(@"
        </a>
        <br /><br />
    </div>
    <div class=""col-3""></div>
</div>
<script>
    window.
        onload
        = function () {
            Particles.
                init
                ({
                    selector:
                        '.background'
                });
        };
    var particles = Particles.init({
        selector: '.background',
        color: ['#DA0463', '#404B69', '#DBEDF3'],
        connectParticles: true
    });
</script>
<canvas class=""background""></canvas>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shared_Traveling.ViewModels.TravelPosts.CreateVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
