#pragma checksum "E:\Documents\GitHub\DIIC-API\BeaconApi\TodoApi\Pages\Beacons\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b3e209cbac530669b0a83bcda831aa2a0c982f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Beacons_Create), @"mvc.1.0.razor-page", @"/Pages/Beacons/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Beacons/Create.cshtml", typeof(AspNetCore.Pages_Beacons_Create), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b3e209cbac530669b0a83bcda831aa2a0c982f6", @"/Pages/Beacons/Create.cshtml")]
    public class Pages_Beacons_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\Documents\GitHub\DIIC-API\BeaconApi\TodoApi\Pages\Beacons\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(95, 1355, true);
            WriteLiteral(@"
<h2>Create</h2>

<h4>BeaconItem</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""BeaconItem.Id"" class=""control-label""></label>
                <input asp-for=""BeaconItem.Id"" class=""form-control"" />
                <span asp-validation-for=""BeaconItem.Id"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""BeaconItem.Name"" class=""control-label""></label>
                <input asp-for=""BeaconItem.Name"" class=""form-control"" />
                <span asp-validation-for=""BeaconItem.Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""BeaconItem.ExtraInfo"" class=""control-label""></label>
                <input asp-for=""BeaconItem.ExtraInfo"" class=""form-control"" />
                <s");
            WriteLiteral(@"pan asp-validation-for=""BeaconItem.ExtraInfo"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-page=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1468, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 43 "E:\Documents\GitHub\DIIC-API\BeaconApi\TodoApi\Pages\Beacons\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BeaconApi.Pages.Beacons.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BeaconApi.Pages.Beacons.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BeaconApi.Pages.Beacons.CreateModel>)PageContext?.ViewData;
        public BeaconApi.Pages.Beacons.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
