using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace Material.Blazor.Website.Shared
{
    public partial class DemonstrationPage
    {
        [Inject] private NavigationManager NavigationManager { get; set; }

        [Parameter] public Tuple<int, string>[] AdditionalAPIReferences { get; set; } = null;
        [Parameter] public string ComponentDirectory { get; set; } = "";
        [Parameter] public string ComponentAndPageName { get; set; }
        [Parameter] public RenderFragment Controls { get; set; }
        [Parameter] public RenderFragment Description { get; set; }
        [Parameter] public string DetailedArticle { get; set; }
        [Parameter] public bool IsGeneric { get; set; } = false;
        [Parameter] public string MaterialDesignPage { get; set; } = "";
        [Parameter] public MBDensity MinDensity { get; set; } = MBDensity.Default;
        [Parameter] public RenderFragment PageContent { get; set; }
        [Parameter] public bool RequiresDisableSelection { get; set; } = false;
        [Parameter] public bool SuppressComponentDocumentation { get; set; } = false;
        [Parameter] public string Title { get; set; }



        private IEnumerable<MBSelectElement<MBDensity>> Densities { get; set; }

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
            ((ComponentAndPageName != null)
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
                componentDirectory = ComponentAndPageName;
            }

            var baseURI = NavigationManager.BaseUri;

            if ((!string.IsNullOrWhiteSpace(ComponentAndPageName)) && !SuppressComponentDocumentation)
            {
                Items.Add(new ReferenceItem
                {
                    Title = "Component Documentation",
                    Content = $"<a href=\"{baseURI}docs/Material.Blazor.MD3/Components/{componentDirectory}/MB{ComponentAndPageName}.html\" target=\"_blank\">MB{ComponentAndPageName} Component Article</a>"
                });

                var apiSuffix = (!IsGeneric) ? "" : "-1";
                var apiText = $"<a href=\"{baseURI}docs/api/Material.Blazor.MB{ComponentAndPageName}{apiSuffix}.html\" target=\"_blank\">MB{ComponentAndPageName} API docs</a>";

                Items.Add(new ReferenceItem
                {
                    Title = "API Documentation",
                    Content = apiText
                });
            }

            if (AdditionalAPIReferences != null)
            {
                var apiSuffix = (!IsGeneric) ? "" : "-1";
                foreach (var apiTuple in AdditionalAPIReferences)
                {
                    var api2Text = "";
                    var api2Spacer = "";
                    for (int i = 0; i < apiTuple.Item1; i++)
                    {
                        api2Spacer += "&nbsp;";
                    }

                    if (apiTuple.Item2.StartsWith("MB"))
                    {
                        api2Text = $"{api2Spacer}<a href=\"{baseURI}docs/api/Material.Blazor.{apiTuple.Item2}{apiSuffix}.html\" target=\"_blank\">{apiTuple.Item2} API docs</a>";
                    }
                    else
                    {
                        api2Text = $"{api2Spacer}<a href=\"{baseURI}docs/api/Material.Blazor.Internal.{apiTuple.Item2}{apiSuffix}.html\" target=\"_blank\">{apiTuple.Item2} API docs</a>";
                    }

                    Items.Add(new ReferenceItem
                    {
                        Title = "API Documentation",
                        Content = api2Text
                    });
                }
            }

            if (!string.IsNullOrWhiteSpace(DetailedArticle))
            {
                Items.Add(new ReferenceItem
                {
                    Title = "In Depth Documentation",
                    Content = $"<a href=\"{baseURI}docs/Material.Blazor.MD3/Articles/MB{DetailedArticle}.html\" target=\"_blank\">MB{DetailedArticle}</a>"
                });
            }

            if (!string.IsNullOrWhiteSpace(ComponentAndPageName))
            {
                Items.Add(new ReferenceItem
                {
                    Title = "Source for This Page",
                    Content = $"<a href=\"https://github.com/Material-Blazor/Material.Blazor/tree/main/Material.Blazor.Website.MD3/Pages/{ComponentAndPageName}.razor\" target=\"_blank\">GitHub source page link</a>"
                });
            }

            if (!string.IsNullOrWhiteSpace(MaterialDesignPage))
            {
                string[] pages;
                if (MaterialDesignPage.Contains(";"))
                {
                    pages = MaterialDesignPage.Split(';');
                }
                else
                {
                    pages = new string[1] { MaterialDesignPage };
                }

                foreach (var page in pages)
                {
                    Items.Add(new ReferenceItem
                    {
                        Title = "Material Design 3",
                        Content = $"<a href=\"https://material-web.dev/components/" + page + "/\" target=\"_blank\" >" + page + " page link</a>"
                    });
                }
            }

            Densities = new MBSelectElement<Material.Blazor.MBDensity>[]
            {
            new() {SelectedValue = MBDensity.Default, TrailingLabel = "Default", Disabled = false },
            new() {SelectedValue = MBDensity.Minus1, TrailingLabel = "Minus 1", Disabled = MinDensity > MBDensity.Minus1 },
            new() {SelectedValue = MBDensity.Minus2, TrailingLabel = "Minus 2", Disabled = MinDensity > MBDensity.Minus2 },
            new() {SelectedValue = MBDensity.Minus3, TrailingLabel = "Minus 3", Disabled = MinDensity > MBDensity.Minus3 },
            new() {SelectedValue = MBDensity.Minus4, TrailingLabel = "Minus 4", Disabled = MinDensity > MBDensity.Minus4 },
            new() {SelectedValue = MBDensity.Minus5, TrailingLabel = "Minus 5", Disabled = MinDensity > MBDensity.Minus5 },
            }.Where(d => d.Disabled != true);
        }


        private async Task AfterCascadingDefaultsChange()
        {
            await InvokeAsync(StateHasChanged);
        }
    }
}
