---
uid: A.DevelopmentEnvironment
title: DevelopmentEnvironment
---
# Creating a Development Environment

We have developed Blazor MDC using Visual Studio 2019 on Windows, and have not tested any other development environment. However, the CI builds run on Ubuntu so for routine development a Linux environment should be quite acceptable.

### Forking the repos

- For the full development environmment you need to for two repositories. These are BlazorMdc & BlazorMdcWebsite. See the section below labeled 'GitHub Actions' for an explanantion of the second repository requirement.
- You can fork Blazor MDC from https://github.com/BlazorMdc/BlazorMdc and BlazorMdcWebsite from https://github.com/BlazorMdc/BlazorMdcWebSite. If you intend to submit pull requests please note that we use a`main` branch and accept feature branches created from `main`. PRs are only made to the BlazorMdc repository.
- The repo has Github Actions for `main`. In your forked repo, [`GithubActionsDevelop`](https://github.com/BlazorMdc/BlazorMdc/blob/develop/.github/workflows/GithubActionsMainWIP.yml) will attempt to publish the documentation to your GitHub pages and the website to the forked repo BlazorMdcWebsite GitHub pages:
  - If you want this to publish to `<repository owner>/github.io/BlazorMdc`, you will need to set up a Personal Access Token with write access to your repos - PATS are set up by clicking your icon at the top right on GitHub, then Settings and Developer Settings in the navigation menu to the left. <<SIMON - NEED IMAGES>>
  <img src="/images/gh-account-settings-1.png" alt="GitHub Account Settings"></img>
  <img src="/images/gh-account-settings-2.png" alt="GitHub Account Settings"></img>
  <img src="/images/gh-account-settings-3.png" alt="GitHub Account Settings"></img>
  - Next go to the Settings of your forked repo and add a secret called "GH_PAT" using the contents of the PAT that you created in the previous step.
<<SIMON - NEED IMAGE>>
  <img src="/images/gh-account-settings-4.png" alt="GitHub Account Settings"></img>
  - Now go to the main settings for your forked repo and scroll down until the "GitHub Pages" section. Select the "gh-pages branch" as the Source and click the Theme button - you *must* select a theme on the next page.
<<SIMON - NEED IMAGE>>
  <img src="/images/gh-account-settings-5.png" alt="GitHub Account Settings"></img>
  - The docs should now publish next time you push to your `develop` branch on GitHub.

### Configuring the development environment

- To build the Blazor project you need to be using the latest preview version of Visual Studio 2019. This can be found at [https://visualstudio.microsoft.com/vs/preview/](https://visualstudio.microsoft.com/vs/preview/). The Community Edition is sufficient. During the installation you must include the "ASP.NET and web development" Workload using Visual Studio Installer.:
<<SIMON - NEED IMAGE>>
    <img src="/images/vs-config.png" alt="Visual Studio Workloads"></img>
- Blazor MDC uses SASS for styling and uses Material Components Web SASS mixins. You will also need to install "Docker". Docker for Windows can be found at [https://docs.docker.com/docker-for-windows/install/](https://docs.docker.com/docker-for-windows/install/). Docker for Mac can be found at [https://docs.docker.com/docker-for-mac/install/](https://docs.docker.com/docker-for-mac/install/). Docker will be responsible for using npm to build and minify resources from within Docker virtual images.  Note that npm packages are  *voluminous* and running the build will download over 160MB of data in the Docker directory.
- There are some Visual Studio extensions that you need or may want:
  - We like Markdown Editor, which will help you improve this page.
<<SIMON - NEED IMAGE>>
   <img src="/images/vs-extensions.png" alt="Visual Studio Extensions"></img>

### CI and Release GitHub Action workflows

These workflows are responsible for publishing three artifacts:
* The BlazorMdc DocFx pages in the BlazorMdc repository gh-pages branch.
* The BlazorMdc NuGet package either as a GitHub package or a NuGet.org package.
* The BlazorMdc Website gh-pages as gh-pages in the BlazorMdcWebsite repository.

#### WIP Workflow

This workflow runs whenever a pull request is created, updated, or pushed.

##### Forked repository

Regardless of the trigger, all three artifacts are published. The DocFx pages reside locally in the forked repository, the NuGet package is identified as a CI build & published to NuGet packages in the forked repository, and the Website is published into the gh-pages branch of a BlazorMdc repository with the same owner as the forked BlazorMdc repository.

##### BlazorMdc\BlazorMdc repository

Regardless of the trigger, only the Nuget package identified as a CI build is published to the BlazorMdc repository . It is up to a developer to have checked the publishing results of the documentation and website in the forked repository prior to initiating a release workflow.

#### Release Workflow

##### Forked repository

Upon creation of a tag no actions are performed in the multiple jobs. At the current time we see no reason to create releases in the forked repositories.

##### BlazorMdc\BlazorMdc repository

All three artifacts are produced. The documentation is in the BlazorMdc\BlazorMdc\gh-pages branch.
The BlazorMdc NuGet package is published to NuGet.org. The Website is in the BlazorMdc\BlazorMdcWebsite\gh-pages branch.
