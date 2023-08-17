using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor.Website.Shared
{
    public partial class DemonstrationPage
    {
        [Inject] private NavigationManager NavigationManager { get; set; }
        [Parameter] public string ComponentDirectory { get; set; } = "";
        [Parameter] public string ComponentName { get; set; }
        [Parameter] public RenderFragment Controls { get; set; }
        [Parameter] public RenderFragment Description { get; set; }
        [Parameter] public string DetailedArticle { get; set; }
        [Parameter] public bool IsGeneric { get; set; } = false;
        [Parameter] public string MaterialDesignPage { get; set; } = "";
        [Parameter] public MBDensity MinDensity { get; set; } = MBDensity.Default;
        [Parameter] public RenderFragment PageContent { get; set; }
        [Parameter] public bool RequiresDisableSelection { get; set; } = false;
        [Parameter] public string Title { get; set; }



        private IEnumerable<Material.Blazor.MD2.MBSelectElement<MBDensity>> Densities { get; set; }

        private MBCascadingDefaults CascadingDefaults { get; set; } = new MBCascadingDefaults()
        {
            ThemeDensity = Material.Blazor.MBDensity.Default,
            Disabled = false,
        };


        private class ReferenceItem
        {
            public string Title { get; set; }
            public string Content { get; set; }

            public MarkupString ContentMarkup => new MarkupString(Content);
        }


        private List<ReferenceItem> Items { get; set; }

        private bool NeedsTable =>
            ((ComponentName != null)
            || (DetailedArticle != null)
            || (MaterialDesignPage != null));


        protected override void OnInitialized()
        {
            Items = new List<ReferenceItem>();

            if (!NeedsTable)
            {
                return;
            }

            var componentDirectory = "";
            if (ComponentDirectory.Length > 0)
            {
                componentDirectory = ComponentDirectory;
            }
            else
            {
                componentDirectory = ComponentName;
            }

            var baseURI = NavigationManager.BaseUri;

            if (!string.IsNullOrWhiteSpace(ComponentName))
            {
                Items.Add(new ReferenceItem
                {
                    Title = "Component Documentation",
                    Content = $"<a href=\"{baseURI}docs/Material.Blazor.MD3/Components/{componentDirectory}/MB{ComponentName}.html\" target=\"_blank\">MB{ComponentName} Component Article</a>"
                });

                var apiSuffix = (!IsGeneric) ? "" : "-1";
                var apiText = $"<a href=\"{baseURI}docs/api/Material.Blazor.MB{ComponentName}{apiSuffix}.html\" target=\"_blank\">MB{ComponentName} API docs</a>";

                Items.Add(new ReferenceItem
                {
                    Title = "API Documentation",
                    Content = apiText
                });

                Items.Add(new ReferenceItem
                {
                    Title = "Source for This Page",
                    Content = $"<a href=\"https://github.com/Material-Blazor/Material.Blazor/tree/main/Material.Blazor.Website.MD3/Pages/{ComponentName}.razor\" target=\"_blank\">GitHub source page link</a>"
                });
            }

            if (!string.IsNullOrWhiteSpace(DetailedArticle))
            {
                Items.Add(new ReferenceItem
                {
                    Title = "In Depth Documentation",
                    Content = $"<a href=\"{baseURI}docs/Material.Blazor.MD3/Articles/MB{DetailedArticle}.html\" target=\"_blank\">MB{DetailedArticle}</a>"
                });
            }

            if (!string.IsNullOrWhiteSpace(MaterialDesignPage))
            {
                Items.Add(new ReferenceItem
                {
                    Title = "Material Design 3",
                    Content = $"<a href=\"https://material-web.dev/components/" + MaterialDesignPage + "/\" target=\"_blank\" >MD3 page link</a>"
                });
            }

            Densities = new Material.Blazor.MD2.MBSelectElement<Material.Blazor.MBDensity>[]
            {
            new() {SelectedValue = Material.Blazor.MBDensity.Default, Label = "Default", Disabled = false },
            new() {SelectedValue = Material.Blazor.MBDensity.Minus1, Label = "Minus 1", Disabled = MinDensity > Material.Blazor.MBDensity.Minus1 },
            new() {SelectedValue = Material.Blazor.MBDensity.Minus2, Label = "Minus 2", Disabled = MinDensity > Material.Blazor.MBDensity.Minus2 },
            new() {SelectedValue = Material.Blazor.MBDensity.Minus3, Label = "Minus 3", Disabled = MinDensity > Material.Blazor.MBDensity.Minus3 },
            new() {SelectedValue = Material.Blazor.MBDensity.Minus4, Label = "Minus 4", Disabled = MinDensity > Material.Blazor.MBDensity.Minus4 },
            new() {SelectedValue = Material.Blazor.MBDensity.Minus5, Label = "Minus 5", Disabled = MinDensity > Material.Blazor.MBDensity.Minus5 },
            }.Where(d => d.Disabled != true);
        }


        private async Task AfterCascadingDefaultsChange()
        {
            await InvokeAsync(StateHasChanged);
        }
    }
}
