// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1_DNP1Y.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/biancamilitaru/RiderProjects/Assignment1-DNP1Y/Assignment1-DNP1Y/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/biancamilitaru/RiderProjects/Assignment1-DNP1Y/Assignment1-DNP1Y/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/biancamilitaru/RiderProjects/Assignment1-DNP1Y/Assignment1-DNP1Y/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/biancamilitaru/RiderProjects/Assignment1-DNP1Y/Assignment1-DNP1Y/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/biancamilitaru/RiderProjects/Assignment1-DNP1Y/Assignment1-DNP1Y/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/biancamilitaru/RiderProjects/Assignment1-DNP1Y/Assignment1-DNP1Y/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/biancamilitaru/RiderProjects/Assignment1-DNP1Y/Assignment1-DNP1Y/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/biancamilitaru/RiderProjects/Assignment1-DNP1Y/Assignment1-DNP1Y/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/biancamilitaru/RiderProjects/Assignment1-DNP1Y/Assignment1-DNP1Y/_Imports.razor"
using Assignment1_DNP1Y;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/biancamilitaru/RiderProjects/Assignment1-DNP1Y/Assignment1-DNP1Y/_Imports.razor"
using Assignment1_DNP1Y.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/biancamilitaru/RiderProjects/Assignment1-DNP1Y/Assignment1-DNP1Y/Pages/FetchData.razor"
using Assignment1_DNP1Y.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "/Users/biancamilitaru/RiderProjects/Assignment1-DNP1Y/Assignment1-DNP1Y/Pages/FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
