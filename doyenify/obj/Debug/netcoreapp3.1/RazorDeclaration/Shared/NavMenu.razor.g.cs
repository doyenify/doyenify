#pragma checksum "/Users/admin/Documents/GitHub/doyenify/doyenify/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c78fc0bddde07e2b4784cc8a7f0d486772a0f8a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace doyenify.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/admin/Documents/GitHub/doyenify/doyenify/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/Users/admin/Documents/GitHub/doyenify/doyenify/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "/Users/admin/Documents/GitHub/doyenify/doyenify/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "/Users/admin/Documents/GitHub/doyenify/doyenify/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "/Users/admin/Documents/GitHub/doyenify/doyenify/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "/Users/admin/Documents/GitHub/doyenify/doyenify/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "/Users/admin/Documents/GitHub/doyenify/doyenify/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "/Users/admin/Documents/GitHub/doyenify/doyenify/_Imports.razor"
using doyenify;

#line default
#line hidden
#line 9 "/Users/admin/Documents/GitHub/doyenify/doyenify/_Imports.razor"
using doyenify.Shared;

#line default
#line hidden
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 28 "/Users/admin/Documents/GitHub/doyenify/doyenify/Shared/NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
