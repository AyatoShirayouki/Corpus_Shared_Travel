#pragma checksum "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "445ef8c79330d631c5f121e6cf51740443e93fe0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
using Shared_Traveling.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"445ef8c79330d631c5f121e6cf51740443e93fe0", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shared_Traveling.ViewModels.Home.GetPostsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/social-media.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/approved.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/rules.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/particlesjs/2.2.2/particles.min.js""></script>

<script src=""https://cdnjs.cloudflare.com/ajax/libs/particlesjs/2.2.2/particles.min.js""></script>
<script src=""http://code.jquery.com/jquery-1.11.1.min.js""></script>
<link href=""//datatables.net/download/build/nightly/jquery.dataTables.css"" rel=""stylesheet"" type=""text/css"" />
<script src=""//datatables.net/download/build/nightly/jquery.dataTables.js""></script>

<script type=""text/javascript"">
    $(document).ready(function () {
        $('#myTable').DataTable();
    });
</script>

");
#nullable restore
#line 23 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
 if (this.Context.Session.GetString("loggedUser") == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""jumbotron text-center"" style=""opacity: 0.9"">
        <div class=""container"">
            <h1 class=""jumbotron-heading"" style="" color: #111; font-family: 'Helvetica Neue', sans-serif; font-size: 100px; font-weight: bold; letter-spacing: -1px; line-height: 1; text-align: center;"">Welcome to Shared Traveling</h1>
        </div>
    </section>
");
            WriteLiteral(@"    <section>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <center>
                        <h2><b>We Offer</b></h2>
                    </center>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-4"">
                    <center>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "445ef8c79330d631c5f121e6cf51740443e93fe06827", async() => {
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
                        <h4>Posting</h4>
                        <p class=""text-center"">
                            Easy Offer <b>Posting</b><br />
                            Easy Offer <b>Editing</b><br />
                            Easy <b>Approval</b>
                        </p>
                    </center>
                </div>
                <div class=""col-md-4"">
                    <center>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "445ef8c79330d631c5f121e6cf51740443e93fe08385", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <h4>Approval</h4>
                        <p class=""text-center"">
                            <b>Create your Offer</b> and <b>Choose The People you Like</b><br />

                        </p>
                    </center>
                </div>
                <div class=""col-md-4"">
                    <center>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "445ef8c79330d631c5f121e6cf51740443e93fe09872", async() => {
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
            WriteLiteral(@"
                        <h4>Comunity Guidelines</h4>
                        <p class=""text-center"">
                            We have strict rules<br />
                            you have to follol <br />
                            Signing up.
                        </p>
                    </center>
                </div>
            </div>
        </div>
    </section>
");
#nullable restore
#line 76 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""jumbotron text-center"" style=""opacity: 0.9"">
        <div class=""container"">
            <h1 class=""jumbotron-heading"" style="" color: #111; font-family: 'Helvetica Neue', sans-serif; font-size: 100px; font-weight: bold; letter-spacing: -1px; line-height: 1; text-align: center;"">Travel Offers</h1>
        </div>
    </section>
");
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-3"">

        </div>
        <div class=""col-6"">
            <table id=""myTable"" class=""borderless-table"">
                <thead>
                    <tr>
                        <th scope=""col""></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 97 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
                     foreach (TravelPost item in Model.Items)
                    {
                        if (item.AvailableSeats > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <div class=\"card\">\r\n                                        <div class=\"card-header\">\r\n");
#nullable restore
#line 105 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
                                             foreach (User u in Model.Users)
                                            {
                                                if (u.Id == item.UserId)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span>");
#nullable restore
#line 109 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
                                                     Write(u.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 109 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
                                                                  Write(u.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 109 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
                                                                               Write(u.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n");
#nullable restore
#line 110 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
                                                }
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n                                        <div class=\"card-body\">\r\n                                            <h5 class=\"card-title\">\r\n                                                ");
#nullable restore
#line 115 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
                                           Write(item.CityOfDeparture);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 115 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
                                                                  Write(item.HourOfDeparture);

#line default
#line hidden
#nullable disable
            WriteLiteral(") - ");
#nullable restore
#line 115 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
                                                                                           Write(item.CityOfDestination);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 115 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
                                                                                                                    Write(item.HourOfDestination);

#line default
#line hidden
#nullable disable
            WriteLiteral(")<br />\r\n                                                Available Seats: ");
#nullable restore
#line 116 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
                                                            Write(item.AvailableSeats);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </h5>\r\n                                            <p class=\"card-text\">\r\n                                                <strong>Address of departure</strong>: ");
#nullable restore
#line 119 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
                                                                                  Write(item.AddressOfDeparture);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                                                <strong>Address of destination</strong>: ");
#nullable restore
#line 120 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
                                                                                    Write(item.AddressOfDestination);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                                                <strong>Price</strong>: ");
#nullable restore
#line 121 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
                                                                   Write(Math.Round(item.Price, 2, MidpointRounding.AwayFromZero));

#line default
#line hidden
#nullable disable
            WriteLiteral(" leva\r\n                                            </p>\r\n");
#nullable restore
#line 123 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
                                             using (Html.BeginForm("CreateRequest", "Requests", new { parentId = item.Id }, FormMethod.Post))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button class=\"btn btn-success\">Apply</button>\r\n");
#nullable restore
#line 126 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                    <br />\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 132 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n            \r\n        </div>\r\n\r\n        <div class=\"col-3\">\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 144 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shared_Traveling.ViewModels.Home.GetPostsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591