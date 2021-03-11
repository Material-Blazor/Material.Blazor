if ($args.Count -gt 0) {
    if ($args.Contains("--fork")) {
        $fork_args_index=$args.IndexOf("--fork")
        $args[$fork_args_index] = ""
        $fork=$args[$fork_args_index + 1]
        $args[$fork_args_index + 1] = ""
        echo "Using fork $fork"
    } else {
        $fork="https://stefanloerwald.github.io/Material.Blazor/"
        echo "Using default fork $fork"
    }
    
    if ($args.Contains("--pages")) {
        $pages_args_index=$args.IndexOf("--pages")
        $args[$pages_args_index] = ""
        echo $args | Set-Content -Encoding Ascii pages
        echo "Crawling pages $args"
    } else {
        echo "Crawling all pages"
    }
} else {
    $fork="https://stefanloerwald.github.io/Material.Blazor/"
    echo "Using default fork $fork"
    
    # All routable Blazor pages of the Material.Blazor project are *.razor files in the folder ..\Material.Blazor.Website\Pages\
    # The first line contains the route attribute @page "/pagename", we ignore the rest of those files
    # We need pagename, therefore we ignore the first 8 characters (@page "/), and the last character, so Substring(8, length - 9).
    $pages=$(Get-ChildItem ..\Material.Blazor.Website\Pages\ -Filter *.razor | ForEach-Object { Get-Content ..\Material.Blazor.Website\Pages\$_ -First 1 } | ForEach-Object { $_.SubString(8, $_.Length - 9) })
    echo $pages | Set-Content -Encoding Ascii pages
    echo "Crawling all pages"
}



docker build -t mb_comparison --build-arg fork=$fork .
docker create --name mb_comparison mb_comparison
docker cp mb_comparison:/out/report report.md
docker rm mb_comparison
Start-Process 'report.md'