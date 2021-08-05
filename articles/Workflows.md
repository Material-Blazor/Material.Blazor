---
uid: A.Workflows
title: Workflows
---
# GitHub workflows

The Material.Blazor project makes use of GitHub workflows to automate a range of tasks:

- Deploy releases to nuget
- Deploy the demo page (https://material-blazor.com) for every release
- Deploy a demo page (https://material-blazor.com) for the most recent state of the project (i.e. the state the `main` branch)
- Perform basic sanity checks for pull requests
- Perform side-by-side comparison checks for pull requests against the current state of Material.Blazor

# Difference between official demo pages

There are two demo pages for Material.Blazor: https://material-blazor.com and https://material-blazor.github.io/Material.Blazor.Current.
https://material-blazor.com reflects the state of the most recent release of Material.Blazor. Use this as a reference when designing your website.
https://material-blazor.github.io/Material.Blazor.Current reflects the state of the main branch of the Material.Blazor repo. Its main purpose is to facilitate the development of the library.

# Side-by-side comparisons

One of the key principles behind Material.Blazor is correctness. Components should create the exact markup specified by the material components web project. To detect regressions, we perform side-by-side comparisons of new versions against the current version.

We crawl all pages of the demo website for both forks and PRs and compare them against the most recent version of Material.Blazor.

For forks, the workflow run will create a new issue with the summary of the comparison.
For pull requests against the Material.Blazor repo, a comment will be added to the pull request.

![image](https://user-images.githubusercontent.com/10850250/111618192-bd20b100-87ec-11eb-82e4-d8b6c772f2b9.png)

# CI and Release GitHub Action workflows

These workflows are responsible for publishing three artifacts:
* A gh-pages branch  
* The Material.Blazor NuGet package 
* The Material.Blazor Side-by-side Comparison report 

The gh-pages branch is created in the repository of either Material.Blazor or Material.Blazor.Current;

The NuGet package is published as a GitHub package (CI) or a NuGet.org package (Release).

The Side by Side report is actually packaged as a GitHub artifact of the build.

### WIP Workflow

This workflow runs whenever a pull request is created, updated, or pushed.

#### Forked repository

Regardless of the trigger, the  three artifacts are published.

The output of the WebSite and DocFx builds are combined and reside locally in the forked repository gh-pages branch.

The NuGet package is identified as a CI build & published in the forked repository GH Packages. 

The final steps of the build involve a comparison of the local gh-pages to the Material.Blazor.Current repository gh-pages. The artifact that is produced is a zip file containing the difference report. The ertifact is indeed a GH Actions artifact named Report.

NOTE -- An issue exists when publishing the CI package to a forked repository in that the publish appears to work but the packages are not visible. For this reason (pending a service request response) the publish of the CI package is temporarily disabled.

#### Material-Blazor\Material.Blazor repository

Regardless of the trigger, the gh-pages branch is not published in the repository.

On a Push trigger the the Material.Blazor Nuget package identified as a CI build is built and then published to the Material.Blazor repository. Additionally, the gh-pages branch is created in the Material.Blazor.Current repository. 

It is up to a developer to have checked the publishing results of the gh-pages in the forked repository (or Material.Blazor.Current repository) prior to initiating a release workflow.

### Release Workflow

#### Forked repository

Upon creation of a tag no actions are performed in the multiple jobs. At the current time we see no reason to create releases in the forked repositories.

#### Material-Blazor\Material.Blazor repository

Upon creation of a tag the first two artifacts are produced.

The DocFx and WebSite build results are combined in the Material-Blazor\Material.Blazor\gh-pages branch.

The Material.Blazor NuGet package is published to NuGet.org.

The gh-pages branch is not required to be published to the Material.Blazor.Current repository by the release workflow as they will have been published by the CI build with the push request.

