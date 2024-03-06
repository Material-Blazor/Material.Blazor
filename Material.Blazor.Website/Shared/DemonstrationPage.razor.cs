using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor.Website.Shared
{
    public partial class DemonstrationPage
    {
        [Inject] private NavigationManager NavigationManager { get; set; }
        [Inject] private IJSRuntime JSRuntime { get; set; }


        [CascadingParameter(Name = "MaterialDocRef")] private string MaterialDocRef { get; set; }

        [Parameter] public string ComponentAndPageName { get; set; }

        [Parameter] public RenderFragment Controls { get; set; }

        [Parameter] public RenderFragment Description { get; set; }

        [Parameter] public string DetailedArticle { get; set; }

        [Parameter] public bool IsGeneric { get; set; } = false;

        [Parameter] public string MaterialIOPage { get; set; }

        [Parameter] public MBDensity MinDensity { get; set; } = MBDensity.Default;

        [Parameter] public RenderFragment PageContent { get; set; }

        [Parameter] public bool RequiresDisableSelection { get; set; } = false;

        [Parameter] public bool SuppressComponentDocumentation { get; set; } = false;

        [Parameter] public string Title { get; set; }


        private MBCascadingDefaults CascadingDefaults { get; set; }


        private class ReferenceItem
        {
            public string Title { get; set; }
            public string Content { get; set; }

            public MarkupString ContentMarkup => new MarkupString(Content);
        }


        private List<ReferenceItem> Items { get; set; }

        private IEnumerable<MBSelectElement<MBDensity>> Densities { get; set; }

        private bool NeedsTable =>
            ((ComponentAndPageName != null) ||
             (DetailedArticle != null) ||
             (MaterialIOPage != null));


        private bool IsRTL { get; set; } = false;
        private CultureInfo CultureInfo => IsRTL ? new("ar-SA") : new("en-US");


        protected override void OnInitialized()
        {
            Items = new List<ReferenceItem>();

            if (!NeedsTable)
            {
                return;
            }

            var baseURI = NavigationManager.BaseUri;

            if ((ComponentAndPageName != null) && SuppressComponentDocumentation)
            {
                Items.Add(new ReferenceItem
                {
                    Title = "Component Documentation",
                    Content = $"<a href=\"{baseURI}docs/Material.Blazor/Components/{ComponentAndPageName}/MB{ComponentAndPageName}.html\" target=\"_blank\">MB{ComponentAndPageName} Component Article</a>"
                });

                var apiSuffix = (!IsGeneric) ? "" : "-1";
                var apiText = $"<a href=\"{baseURI}docs/api/Material.Blazor.MB{ComponentAndPageName}{apiSuffix}.html\" target=\"_blank\">MB{ComponentAndPageName} API docs</a>";

                Items.Add(new ReferenceItem
                {
                    Title = "API Documentation",
                    Content = apiText
                });
            }

            Items.Add(new ReferenceItem
            {
                Title = "Source for This Page",
                Content = $"<a href=\"https://github.com/Material-Blazor/Material.Blazor/tree/main/Material.Blazor.Website/Pages/{ComponentAndPageName}.razor\" target=\"_blank\">GitHub source page link</a>"
            });

            if (DetailedArticle != null)
            {
                Items.Add(new ReferenceItem
                {
                    Title = "In Depth Documentation",
                    Content = $"<a href=\"{baseURI}docs/Articles/{DetailedArticle}.html\" target=\"_blank\">{DetailedArticle}</a>"
                });
            }

            if (ComponentAndPageName != null)
            {
                Items.Add(new ReferenceItem
                {
                    Title = "Source for This Page",
                    Content = $"<a href=\"https://github.com/Material-Blazor/Material.Blazor/tree/main/Material.Blazor.Website/Pages/{ComponentAndPageName}.razor\" target=\"_blank\">GitHub source page link</a>"
                });
            }

            if (MaterialIOPage != null)
            {
                var materialPage = $"<a href=\"{MaterialDocRef + MaterialIOPage}\" target=\"_blank\">{MaterialIOPage.Split("#")[0]}</a>";

                Items.Add(new ReferenceItem
                {
                    Title = "Material Theme Page",
                    Content = materialPage
                });
            }

            Densities =
            [
                new() {SelectedValue = MBDensity.Default, Label = "Default", Disabled = false },
                new() {SelectedValue = MBDensity.Minus1, Label = "Minus 1", Disabled = MinDensity > MBDensity.Minus1 },
                new() {SelectedValue = MBDensity.Minus2, Label = "Minus 2", Disabled = MinDensity > MBDensity.Minus2 },
                new() {SelectedValue = MBDensity.Minus3, Label = "Minus 3", Disabled = MinDensity > MBDensity.Minus3 },
                new() {SelectedValue = MBDensity.Minus4, Label = "Minus 4", Disabled = MinDensity > MBDensity.Minus4 },
                new() {SelectedValue = MBDensity.Minus5, Label = "Minus 5", Disabled = MinDensity > MBDensity.Minus5 },
            ];

            Densities = Densities.Where(d => d.Disabled != true);

            CascadingDefaults = new MBCascadingDefaults()
            {
                ThemeDensity = MBDensity.Default,
                Disabled = false,
                CultureInfo = CultureInfo
            };
        }


        private ValueTask OnRTLToggle()
        {
            return JSRuntime.InvokeVoidAsync("MaterialBlazorWebsite.MBTheme.setHtmlBlockTextDirection", IsRTL ? "rtl" : "ltr");
        }
    }
}
