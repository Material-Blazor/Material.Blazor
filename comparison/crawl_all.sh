#!/bin/bash
baseline=$1
fork=$2

while read page; do
    echo "comparing ${baseline}$page with ${fork}$page" && sleep 2
    /bin/bash ./crawl.sh baseline $baseline $page
    /bin/bash ./crawl.sh fork $fork $page
    echo "### Differences on page '/$page'" > differences_$page
    echo "\`\`\`diff" >> differences_$page
    diff -d -w baseline_$page.html fork_$page.html >> differences_$page || true
    echo "\`\`\`" >> differences_$page
    echo -e "\n\n\n\n" >> differences_$page
done < /src/pages
