
# GitHub workflows

The Material.Blazor project makes use of GitHub workflows to automate a range of tasks:

- Deploy releases to nuget
- Deploy the demo page (https://material-blazor.com) for every release
- Perform basic sanity checks for pull requests
- Perform side-by-side comparison checks for pull requests against the current state of Material.Blazor

# Side-by-side comparisons

One of the key principles behind Material.Blazor is correctness. Components should create the exact markup specified by the material components web project. To detect regressions, we perform side-by-side comparisons of new versions against the current version.
