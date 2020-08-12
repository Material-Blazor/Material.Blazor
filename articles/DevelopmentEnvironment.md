---
uid: A.DevelopmentEnvironment
title: DevelopmentEnvironment
---
# Development Environment Setup

We have developed Blazor MDC using Visual Studio 2019 on Windows, and have not tested any other development environment.

## Forking the repo

- You can fork Blazor MDC from https://github.com/BlazorMdc/BlazorMdc. If you intend to submit pull requests please note that we use Git Flow with `develop` and `main` branches.
- The repo has Github Actions for `develop` and `main`. In your forked repo, [`GithubActionsDevelop`](https://github.com/BlazorMdc/BlazorMdc/blob/develop/.github/workflows/GithubActionsDevelop.yml) will attempt to publish the documentation to your GitHub pages:
  - If you want this to publish to `<your name>/github.io/BlazorMdc`, you will need to set up a Personal Access Token with write access to your repo - PATS are set up by clicking your icon at the top right on GitHub, then Settings and Developer Settings in the navigation menu to the left.
  <img src="/images/gh-account-settings-1.png" alt="GitHub Account Settings"></img>
  <img src="/images/gh-account-settings-2.png" alt="GitHub Account Settings"></img>
  <img src="/images/gh-account-settings-3.png" alt="GitHub Account Settings"></img>
  - Next go to the Settings of your forked repo and add a secret called "GP_PAT" using the contents of the PAT that you created in the previous step.
  <img src="/images/gh-account-settings-4.png" alt="GitHub Account Settings"></img>
  - Now go to the main settings for your forked repo and scroll down until the "GitHub Pages" section. Select the "gh-pages branch" as the Source and click the Theme button - you *must* select a theme on the next page.
  <img src="/images/gh-account-settings-5.png" alt="GitHub Account Settings"></img>
  - The docs should now publish next time you push to your `develop` branch on GitHub.

## Configuring Visual Studio

- To build the Blazor project you need to be using the latest version of Visual Studio 2019 and to include the "ASP.NET and web development" Workload using Visual Studio Installer.:
    <img src="/images/vs-config.png" alt="Visual Studio Workloads"></img>
- Blazor MDC uses SASS for styling and uses Material Components Web SASS mixins. You will also need to install "Node.js".  Note that npm packages are  *voluminous* and running the build will download over 80MB of data in the BlazorMdc\BlazorMdc\node_modules directory.
- There are some Visual Studio extensions that you need or may want:
  - We like Markdown Editor, which will help you improve this page.
   <img src="/images/vs-extensions.png" alt="Visual Studio Extensions"></img>