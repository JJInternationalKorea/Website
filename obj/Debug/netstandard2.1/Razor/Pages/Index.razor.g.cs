#pragma checksum "C:\Users\Wooseok\source\Website\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0ba0404f5e7166748368a1a0f847058d1a1ecd9"
// <auto-generated/>
#pragma warning disable 1591
namespace Website.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Wooseok\source\Website\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wooseok\source\Website\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Wooseok\source\Website\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Wooseok\source\Website\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Wooseok\source\Website\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Wooseok\source\Website\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Wooseok\source\Website\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Wooseok\source\Website\_Imports.razor"
using Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Wooseok\source\Website\_Imports.razor"
using Website.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"section padding_layout_1\">\r\n  <div class=\"container\">\r\n    <div class=\"row\">\r\n      <div class=\"col-md-12\">\r\n        <div class=\"full\">\r\n          <div class=\"main_heading text_align_center\">\r\n            <h1>Welcome to JJ International Korea</h1>\r\n          </div>\r\n          <p class=\"large text_align_center\">\r\n            We export garment fabrics to large brands in the United States, and we are exporting only 100% domestic fabrics.<br>\r\n            We also handle women\'s WOVEN / KNIT / LACE and various types of post-processing, PRINT, etc.\r\n          </p>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"full text_align_center margin_bottom_30\">\r\n      <h2>Major Buyers</h2>\r\n    </div>\r\n    <div class=\"row\">\r\n      <div class=\"col-lg-3 col-md-6 col-sm-6 col-xs-12\">\r\n        <div class=\"full text_align_center margin_bottom_30\">\r\n          <div class=\"center\">\r\n            <a href=\"https://www.calvinklein.us/en\">\r\n              <img src=\"./images/CK.jpg\" alt=\"calvinklein\" width=\"250\" height=\"150\" style=\"padding-left: 10px; padding-right: 10px;\">\r\n            </a>\r\n          </div>\r\n        </div>\r\n      </div>\r\n      <div class=\"col-lg-3 col-md-6 col-sm-6 col-xs-12\">\r\n        <div class=\"full text_align_center margin_bottom_30\">\r\n          <div class=\"center\">\r\n            <a href=\"https://www.gap.com/\">\r\n              <img src=\"./images/GAP.png\" alt=\"gap\" width=\"250\" height=\"150\" style=\"padding-left: 10px; padding-right: 10px;\">\r\n            </a>\r\n          </div>\r\n        </div>\r\n      </div>\r\n      <div class=\"col-lg-3 col-md-6 col-sm-6 col-xs-12\">\r\n        <div class=\"full text_align_center margin_bottom_30\">\r\n          <div class=\"center\">\r\n            <a href=\"https://www.macys.com/?cm_sp=navigation-_-top_nav-_-macys_icon&lid=glbtopnav_macys_icon-intl\">\r\n              <img src=\"./images/Macys.jpg\" alt=\"macys\" width=\"250\" height=\"150\" style=\"padding-left: 10px; padding-right: 10px;\">\r\n            </a>\r\n          </div>\r\n        </div>\r\n      </div>\r\n      <div class=\"col-lg-3 col-md-6 col-sm-6 col-xs-12\">\r\n        <div class=\"full text_align_center margin_bottom_30 margin_0\">\r\n          <div class=\"center\">\r\n            <a href=\"https://bananarepublic.gap.com/\">\r\n              <img src=\"./images/BR.png\" alt=\"bananarepublic\" width=\"250\" height=\"150\" style=\"padding-left: 10px; padding-right: 10px;\">\r\n            </a>\r\n          </div>\r\n        </div>\r\n      </div>\r\n      <div class=\"col-lg-3 col-md-6 col-sm-6 col-xs-12\">\r\n        <div class=\"full text_align_center margin_bottom_30\">\r\n          <div class=\"center\">\r\n            <a href=\"https://www.michaelkors.global/en_NZ/\">\r\n              <img src=\"./images/MK.png\" alt=\"michaelkors\" width=\"250\" height=\"150\" style=\"padding-left: 10px; padding-right: 10px;\">\r\n            </a>\r\n          </div>\r\n        </div>\r\n      </div>\r\n      <div class=\"col-lg-3 col-md-6 col-sm-6 col-xs-12\">\r\n        <div class=\"full text_align_center margin_bottom_30\">\r\n          <div class=\"center\">\r\n            <a href=\"https://www.lillypulitzer.com/\">\r\n              <img src=\"./images/LP.png\" alt=\"lillypulitzer\" width=\"250\" height=\"150\" style=\"padding-left: 10px; padding-right: 10px;\">\r\n            </a>\r\n          </div>\r\n        </div>\r\n      </div>\r\n      <div class=\"col-lg-3 col-md-6 col-sm-6 col-xs-12\">\r\n        <div class=\"full text_align_center margin_bottom_30\">\r\n          <div class=\"center\">\r\n            <a href=\"https://www.anntaylor.com/\">\r\n              <img src=\"./images/AT.jpg\" alt=\"anntaylor\" width=\"250\" height=\"150\" style=\"padding-left: 10px; padding-right: 10px;\">\r\n            </a>\r\n          </div>\r\n        </div>\r\n      </div>\r\n      <div class=\"col-lg-3 col-md-6 col-sm-6 col-xs-12\">\r\n        <div class=\"full text_align_center margin_bottom_30\">\r\n          <div class=\"center\">\r\n            <a href=\"https://www.donnakaran.com/category/dkny.do\">\r\n              <img src=\"./images/DKNY.jpg\" alt=\"donnakaran\" width=\"250\" height=\"150\" style=\"padding-left: 10px; padding-right: 10px;\">\r\n            </a>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"section padding_layout_1\">\r\n  <div class=\"container\">\r\n    <div class=\"row\">\r\n      <div class=\"col-md-12\">\r\n        <div class=\"full\">\r\n          <div class=\"main_heading text_align_center\">\r\n            <h2>Our Products</h2>\r\n            <p class=\"large\">We package the products with best services to make you a happy customer.</p>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"row\">\r\n      <div class=\"col-lg-3 col-md-6 col-sm-6 col-xs-12 margin_bottom_30_all\">\r\n        <div class=\"product_list\">\r\n          <div class=\"product_img\"> <img class=\"img-responsive\" src=\"images/cloth/Product.png\" alt> </div>\r\n          <div class=\"product_detail_btm\">\r\n            <div class=\"center\">\r\n              <h4><a href=\"protectivecloth\">Protective Cloth</a></h4>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n      <div class=\"col-lg-3 col-md-6 col-sm-6 col-xs-12 margin_bottom_30_all\">\r\n        <div class=\"product_list\">\r\n          <div class=\"product_img\"> <img class=\"img-responsive\" src=\"images/mask/mask-information.jpg\" alt> </div>\r\n          <div class=\"product_detail_btm\">\r\n            <div class=\"center\">\r\n              <h4><a href=\"dentalmask\">Dental Mask</a></h4>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n      <div class=\"col-lg-3 col-md-6 col-sm-6 col-xs-12 margin_bottom_30_all\">\r\n        <div class=\"product_list\">\r\n          <div class=\"product_img\"> <img class=\"img-responsive\" src=\"images/mask/design-1.jpg\" alt> </div>\r\n          <div class=\"product_detail_btm\">\r\n            <div class=\"center\">\r\n              <h4><a href=\"fashionmask\">Fashion Mask</a></h4>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n\r\n");
            __builder.AddMarkupContent(2, @"<section id=""google-map"">
  <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3154.690049477154!2d127.0700838151588!3d37.750415121333994!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x357cc6fb2d39e261%3A0x75c945243f2711d7!2s626%20Janggok-ro%2C%20Singok-dong%2C%20Euijeongbu%2C%20Gyeonggi-do%2C%20South%20Korea!5e0!3m2!1sen!2snz!4v1594003871737!5m2!1sen!2snz"" width=""100%"" height=""350"" frameborder=""0"" style=""border:0"" allowfullscreen></iframe>
</section>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
