#pragma checksum "C:\clone github\NewPerpustakaanMulyoAbadi\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb0853dae61de68ba15742eea6c257a1b560da4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
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
#nullable restore
#line 1 "C:\clone github\NewPerpustakaanMulyoAbadi\Views\_ViewImports.cshtml"
using Perpustakaan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\clone github\NewPerpustakaanMulyoAbadi\Views\_ViewImports.cshtml"
using Perpustakaan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb0853dae61de68ba15742eea6c257a1b560da4b", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f3f057571a4f9a78f748cc7253a4d72ad3bb741", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Buku>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\clone github\NewPerpustakaanMulyoAbadi\Views\Home\List.cshtml"
  
    ViewData["Title"] = "Perpustakaan";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Buku Terbaik:</h1><br>
<style>
  .buku-list {
    width: 100%;
    position: relative;
    display: flex;
    flex-wrap: wrap;
  }
  .listbuku {
    margin: 0 auto;
  }
  .listbuku p {
    font-family: 'muara demo';
    font-weight: 800;
    font-size: 25px;
    text-align: center;
    color: black;
  }

</style>
<div class=""buku-list"">
    <div class=""listbuku"">
      <a href=""https://localhost:5001/Home/Invested""><img src=""https://images.bisnis-cdn.com//upload/img/Invested%20-%20Danielle%20Town.png"" width=""240""/></a>
      <p>Invested</p>
    </div>
    <div class=""listbuku"">
    <a href=""https://localhost:5001/Home/AthomicHabits""><img src=""https://aquariuslearning.co.id/wp-content/uploads/2020/01/raw-atomic-habits.png""width=""170""/></a>
      <p>Atomic Habit</p>
    </div>
    <div class=""listbuku"">
      <a href=""https://localhost:5001/Home/Naruto""><img src=""https://s4.bukalapak.com/img/496434901/w-1000/3099981-63_scaled.jpg""width=""145""/></a>
      <p>Naruto</p>
    </di");
            WriteLiteral(@"v>
    <div class=""listbuku"">
    <a href=""https://localhost:5001/Home/OnePiece""><img src=""https://inc.mizanstore.com/aassets/img/com_cart/produk/GRK-075.jpg""width=""140""/>
    <p>One Piece</p>
    </div>
    <div class=""listbuku"">
    <a href=""https://localhost:5001/Home/OnePunchMan""><img src=""https://financerewind.com/wp-content/uploads/2020/06/one-punch-man-a-hero-nobody-knows-cover-696x996-1.jpg""width=""140""/>
    <p>One Punch Man</p>
    </div>
  </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Buku>> Html { get; private set; }
    }
}
#pragma warning restore 1591
