using Markdig;

namespace Material.Blazor.Website.MD3.Pages;

public partial class Roadmap
{
    private string markDownAsHTML { get; set; }

    public Roadmap()
    {
        var rawMarkDown = @"
# Version 2024-02-10

# About Material 3

Material 3, announced in early 2021 replaces Material 2 which is currently used by Material.Blazor. Material 3's web implementation can be tracked in the [material-web](https://github.com/material-components/material-web) project. This project uses web components as opposed to the HTML markup/JS instantiation approach of Material 2's [material-components-web](https://github.com/material-components/material-components-web).

Material.Blazor will require most of the Material Web 3 components. The [roadmap](https://github.com/material-components/material-web/blob/main/docs/roadmap.md) for Material Web shows the progress and current schedule.

# Material.Blazor migration progress tracking

The following section tracks our progress in migrating to Material 3.


We likely aim to build all Material Web components. Material Blazor will follow the component convention of MW3. Note that Material Web 3 components do not map 1:1 to Material Design 3 components. As examples of the disparity: 
- MD3 specifies a singular button component and MW3 breaks these into button, icon button, floating action button, and segmented button
-  MW3 has additional components that were deemed useful for a web implementation of MD3 such as elevation, focus ring, icon, and select. These components are differentiated by a (+) indicator.

Required for M.B key:

- 🟢 These are strictly required for Material.Blazor
- 🟡 These will make existing Plus components obsolete and are strongly desirable for follow-on Material.Blazor releases if not available immediately
- 🔴 Not presently required for Material.Blazor however our ambition is to include all Material Web 3 components

M.B/MW3 status key:

- ✅ Complete
- 🟡 In progress
- 💤 Not started

### Material Web 3

**Feature (MB/MW3)** | **Required for M.B** | **MW3 schedule** | **MW3 status** | **MB status** | **Notes** |
:--- | :---: | :---: | :---: | :---: | :--- |
Color theming | 🟢 | V1.0 | ✅ | ✅ |
Catalog | 🔴 | Future | 💤 | 💤 |
Density  | 🟢 | Future | 💤 | 💤 |
Motion theming | 🔴 | Future | 💤 | 💤 |
Shape theming | 🔴 | Future | 💤 | 💤 |
Spacing tokens | 🔴 | Future | 💤 | 💤 |
SSR | 🔴 | Future  | 💤 | 💤 |
Typescript theming  | 🔴 | Future | 💤 | 💤 |
Typography theming | 🟢 | V1.0 | ✅ | ✅ |
**Component (MB/MW3)** | | | | |
App bar | 🟢 | Future |💤 | 💤 |
.....Bottom app bar    | 🔴 | Future | 💤 | 💤 |
.....Top app bar       | 🟢 | Future | 💤 | 💤 |
Autocomplete (+) | 🟢 | Future | 💤 | 💤 |
Badge  | 🟡 | Future | 💤 | 💤 |
Banner (+) | 🔴 | Future | 💤 | 💤 |
Button | 🟢 | V1.0 | ✅ | 🟡  | Density |
Card | 🟢 | Q1 2024 | 🟡 |  💤 |
Carousel | 🟢 | Future | 💤 |  💤 |
Checkbox  | 🟢 | V1.0 | ✅ | 🟡  | Density |
Chips  | 🟢 | V1.0 | ✅ |  🟡  | Density & Interaction|
Data table (+) | 🟢 | Future | 💤 | 💤 |
Date picker | 🟡 | Future | 💤 |  💤 |
Dialog | 🟢 | V1.0 | ✅ |  🟡 | Demo of datepicker (not implemented) |
Divider | 🟢 | V1.0 | ✅ |  n/a |
Elevation (+) | 🟢 | V1.0 | ✅ | n/a |
Floating action button (+) | 🟢 | V1.0 | ✅ | ✅ |
Focus ring (+) | 🟢 | V1.0 | ✅ | n/a |
Icon (+) | 🟢 |  V1.0 | ✅ | ✅ |
Icon button (+) | 🟢 | V1.0 | ✅ | 🟡  | Density |
List | 🟢 |  V1.0 | ✅ |  ✅ |
Menu | 🟢 |  V1.0 | ✅ |  🟡  | Density & Interaction, sub-menu (Do we support?) |
Navigation | 🟢 | Future | 💤 |  💤 |
.....Navigation bar    | 🔴 | Future | 💤 |  💤 |
.....Navigation drawer | 🟢 | Q1 2024 | 💤 |  💤 |
.....Navigation rail   | 🔴 | Future | 💤 |  💤 |
Progress indicators | 🟢 |  V1.0 | ✅ | ✅ |
Radio button  | 🟢 |  V1.0 | ✅ | 🟡 | Density |
Ripple (+) | 🟢 | V1.0 | ✅ | n/a |
Search | 🔴 | Future | 💤 | 💤 |
Segmented button (+) | 🟢 | Q1 2024 | 💤 |  💤 |
Select (+) | 🟢 | V1.0 | ✅ | 🟡 | Density |
Sheet      | 🔴 | Future | 💤 | 💤 |
.....Bottom sheet | 🔴 | Future | 💤 | 💤 |
.....Side sheet | 🔴 | Future | 💤 | 💤 |
Slider  | 🟢 | Future | ✅ | 🟡 | Density & Interaction, two thumb (Do we support?) |
Snackbar | 🟢 | Future | 💤 | 💤 |
Switch  | 🟢 | V1.0 | ✅ | 🟡 | Density |
Tabs | 🟢 | V1.0 | ✅ |✅ |
Text field | 🟢 | V1.0 | ✅ | 🟡 | Density, error, errortext, supporting text, type (including area), does not play well with forms |
Time picker | 🟡 | Future | 💤 | 💤 |
Tooltip  | 🟢 | Future | 💤 | 💤 |
**Component (MB+)**  |  |  |  |  |
Anchor | 🟢 | n/a | n/a | 🟡 |  Potentially needs MWC3 tooltip and snackbar anchors depending upon implementation |
AutocompletePagedField | 🟢 | n/a | n/a | 💤 | 
AutocompleteSelectField | 🟢 | n/a | n/a | 💤 |
AutocompleteTextField | 🟢 | n/a | n/a | 💤 | 
BladeSet | 🟢 | n/a | n/a | 💤 |
ChipsSelectMulti | 🟢 | n/a | n/a | 💤 |
ChipsSelectSingle | 🟢 | n/a | n/a | 💤 |
ConfirmationDialog | 🟢 | n/a | n/a | 💤 |
DateTimeField | 🟢 | n/a | n/a | 🟡 | Density and supporting text persistence |
DebouncedTextField | 🟢 | n/a | n/a | 💤 |
DecimalField | 🟢 | n/a | n/a | 🟡 | Density and supporting text persistence |
DoubleField | 🟢 | n/a | n/a | 🟡 | Density and supporting text persistence |
DragAndDropList | 🟢 | n/a | n/a | 💤 |
Drawer | 🟢 | n/a | n/a | 💤 |
FileUpload | 🟢 | n/a | n/a | 💤 | 
Grid | 🟢 | n/a | n/a | 🟢 |
IconButtonToggle | 🟢 | n/a | n/a | 💤 |
IntField | 🟢 | n/a | n/a | 🟡 | Density and supporting text persistence |
PagedDataList | 🟢 | n/a | n/a | 💤 |
Paginator | 🟢 | n/a | n/a | 💤 |
RadioButtonGroup | 🟢 | n/a | n/a | 🟡 | Density |
Scheduler | 🟢 | n/a | n/a | 💤 |
SegmentedButtonMulti | 🟢 | n/a | n/a | 💤 |
Shield | 🟢 | n/a | n/a | 💤 |
Slider | 🟢 | n/a | n/a | 💤 |
Toast | 🟢 | n/a | n/a | 🟢 |
        ";

        // Configure the pipeline with all advanced extensions active
        var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
        markDownAsHTML = Markdown.ToHtml(rawMarkDown, pipeline);
    }

}
