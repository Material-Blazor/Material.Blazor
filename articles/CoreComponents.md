## Core Components

Material Theme closely specifies the HTML markup for its [core components](https://material.io/develop/web). Blazor MDC implements many of these and aheres rigorously to 
the markup specification. We term these "Core Components. Blazor MDC also has non core [Plus Components](PlusComponents.html). Blazor MDC Core Components are:

| Component | Notes |
| :-------- | :---- |
| [`MTButton`](~/BlazorMdc/Components/Button/MTButton.razor.html) | A [Material Button](https://material.io/develop/web/components/buttons/). |
| [`MTCard`](~/BlazorMdc/Components/Card/MTCard.razor.html) | A [Material Card](https://material.io/develop/web/components/cards/). _Requires ripple effect._ |
| [`MTCheckbox`](~/BlazorMdc/Components/Checkbox/MTCheckbox.razor.html) | A [Material Checkbox](https://material.io/develop/web/components/input-controls/checkboxes/). Implements a two state on/off checkbox, but not yet an indeterminate variety. |
| [`MTCircularProgress`](~/BlazorMdc/Components/CircularProgress/MTCircularProgress.razor.html) | A [Material Circular Progress indicator](https://material.io/develop/web/components/progress-indicator/). |
| [`MTDataTable`](~/BlazorMdc/Components/DataTable/MTDataTable.razor.html) | A [Material Data Table](https://material.io/develop/web/components/data-tables/) without row selection |
| [`MTDialog`](~/BlazorMdc/Components/Dialog/MTDialog.razor.html) | A [Material Dialog](https://material.io/develop/web/components/dialogs/). Can set scrim and escape button actions. |
| [`MTDrawer`](~/BlazorMdc/Components/Drawer/MTDrawer.razor.html) | A [Material Drawer](https://material.io/develop/web/components/drawers/). _Awaits review_. |
| [`MTIconButton`](~/BlazorMdc/Components/IconButton/MTIconButton.razor.html) | A [Material Icon Button](https://material.io/develop/web/components/buttons/icon-buttons/). |
| [`MTIconButtonToggle`](~/BlazorMdc/Components/IconButtonToggle/MTIconButtonToggle.razor.html) | A toggle variant of the [Material Icon Button](https://material.io/develop/web/components/buttons/icon-buttons/). |
| [`MTLinearProgress`](~/BlazorMdc/Components/LinearProgress/MTLinearProgress.razor.html) | A [Material Linear Progress bar](https://material.io/develop/web/components/progress-indicator/). |
| [`MTList`](~/BlazorMdc/Components/List/MTList.razor.html) | A [Material List](https://material.io/develop/web/components/lists/). Implements Material Theme Web Components one and two line lists, plus a BlazorMdc interpretation of a three line list. |
| [`MTMenu`](~/BlazorMdc/Components/Menu/MTMenu.razor.html) | A [Material Menu](https://material.io/develop/web/components/menus/). Does not implement sub menus. May redesign parameterization. |
| [`MTNavLink`](~/BlazorMdc/Components/NavLink/MTNavLink.razor.html) | A [Material List Item](https://material.io/develop/web/components/menus/) wrapping a Blazor `NavLink`. _Awaits review_. |
| [`MTRadioButton`](~/BlazorMdc/Components/RadioButton/MTRadioButton.razor.html) | A [Material Radio Button](https://material.io/develop/web/components/input-controls/radio-buttons/). |
| [`MTSelect`](~/BlazorMdc/Components/Select/MTSelect.razor.html) | A [Material Select Menu](https://material.io/develop/web/components/input-controls/select-menus/). |
| [`MTSwitch`](~/BlazorMdc/Components/Switch/MTSwitch.razor.html) | A [Material Switch](https://material.io/develop/web/components/input-controls/switches/). |
| [`MTTabBar`](~/BlazorMdc/Components/TabBar/MTTabBar.razor.html) | A [Material Tab Bar](https://material.io/develop/web/components/tabs/tab-bar/). |
| [`MTTextArea`](~/BlazorMdc/Components/TextArea/MTTextArea.razor.html) | A [Material Text Field](https://material.io/develop/web/components/input-controls/text-field/) expressed as a text area. Implements the full width variety, but still needs to disable floating labels in this instance to follow MT guidelines - indeed full width fields with a floating label render poorly. |
| [`MTTextField`](~/BlazorMdc/Components/TextField/MTTextField.razor.html) | A [Material Text Field](https://material.io/develop/web/components/input-controls/text-field/). Does not implement the full width variety. |
| [`MTTopAppBar`](~/BlazorMdc/Components/TopAppBar/MTTopAppBar.razor.html) | A [Material Top App Bar](https://material.io/develop/web/components/top-app-bar/). |