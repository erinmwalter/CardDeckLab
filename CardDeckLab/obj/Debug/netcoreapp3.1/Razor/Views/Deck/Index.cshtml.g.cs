#pragma checksum "C:\Users\ewalter\source\repos\CardDeckLab\CardDeckLab\Views\Deck\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af7876626d0c6d373450d0ce3b76d9e24739ff2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Deck_Index), @"mvc.1.0.view", @"/Views/Deck/Index.cshtml")]
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
#line 1 "C:\Users\ewalter\source\repos\CardDeckLab\CardDeckLab\Views\_ViewImports.cshtml"
using CardDeckLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ewalter\source\repos\CardDeckLab\CardDeckLab\Views\_ViewImports.cshtml"
using CardDeckLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af7876626d0c6d373450d0ce3b76d9e24739ff2c", @"/Views/Deck/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2592e516bd47cd1eeb5093436be456a15bf8964f", @"/Views/_ViewImports.cshtml")]
    public class Views_Deck_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PileResult>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>Cards Remaining: ");
#nullable restore
#line 3 "C:\Users\ewalter\source\repos\CardDeckLab\CardDeckLab\Views\Deck\Index.cshtml"
               Write(Model.remaining);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Your Hand:</p>\r\n");
#nullable restore
#line 5 "C:\Users\ewalter\source\repos\CardDeckLab\CardDeckLab\Views\Deck\Index.cshtml"
 using (Html.BeginForm("Index", "Deck", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <tr>\r\n            <th>Card Name</th>\r\n            <th>Card Image</th>\r\n            <th>Discard</th>\r\n        </tr>\r\n");
#nullable restore
#line 13 "C:\Users\ewalter\source\repos\CardDeckLab\CardDeckLab\Views\Deck\Index.cshtml"
         foreach (Card c in Model.piles.player1.cards)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\ewalter\source\repos\CardDeckLab\CardDeckLab\Views\Deck\Index.cshtml"
               Write(c.value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 16 "C:\Users\ewalter\source\repos\CardDeckLab\CardDeckLab\Views\Deck\Index.cshtml"
                           Write(c.suit);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td><img");
            BeginWriteAttribute("src", " src=\"", 437, "\"", 451, 1);
#nullable restore
#line 17 "C:\Users\ewalter\source\repos\CardDeckLab\CardDeckLab\Views\Deck\Index.cshtml"
WriteAttributeValue("", 443, c.image, 443, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"checkbox\" name=\"discards[]\"");
            BeginWriteAttribute("value", " value=\"", 522, "\"", 537, 1);
#nullable restore
#line 18 "C:\Users\ewalter\source\repos\CardDeckLab\CardDeckLab\Views\Deck\Index.cshtml"
WriteAttributeValue("", 530, c.code, 530, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 538, "\"", 550, 1);
#nullable restore
#line 18 "C:\Users\ewalter\source\repos\CardDeckLab\CardDeckLab\Views\Deck\Index.cshtml"
WriteAttributeValue("", 543, c.code, 543, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n            </tr>\r\n");
#nullable restore
#line 20 "C:\Users\ewalter\source\repos\CardDeckLab\CardDeckLab\Views\Deck\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    <br />\r\n    <input type=\"hidden\" name=\"deckID\"");
            BeginWriteAttribute("value", " value=\"", 655, "\"", 677, 1);
#nullable restore
#line 23 "C:\Users\ewalter\source\repos\CardDeckLab\CardDeckLab\Views\Deck\Index.cshtml"
WriteAttributeValue("", 663, Model.deck_id, 663, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"submit\" value=\"Draw Again\" />\r\n");
#nullable restore
#line 25 "C:\Users\ewalter\source\repos\CardDeckLab\CardDeckLab\Views\Deck\Index.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PileResult> Html { get; private set; }
    }
}
#pragma warning restore 1591
