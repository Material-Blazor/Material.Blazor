#!/bin/bash
i=0
while [ ! -f $1_$3.html ] || [ $(grep 'blazor-error-ui" style' $1_$3.html | wc -l) -gt 0 ] || [ $(grep 'splash-background-video' $1_$3.html | wc -l) -gt 0 ];
do
    echo "Attempt #$i for crawling $2$3"
    if [ $i -gt 0 ];
    then
        if [ ! -f $1_$3.html ];
        then
            echo "No file so far"
        elif [ $(grep 'blazor-error-ui" style' $1_$3.html | wc -l) -gt 0 ];
        then
            echo "File shows error"
        elif [ $(grep 'splash-background-video' $1_$3.html | wc -l) -gt 0 ];
        then
            echo "Still on video..."
            grep 'splash-background-video' $1_$3.html
        fi
    fi
    i=$((i+1))
    google-chrome --headless --disable-dev-shm-usage --disable-gpu --run-all-compositor-stages-before-draw --virtual-time-budget=200000 --dump-dom --no-sandbox $2$3 | grep -v "base href" | sed 's/integrity="\(.*\)"/integrity="..."/' | sed 's/[a-f0-9]\{8\}-[a-f0-9]\{4\}-[a-f0-9]\{4\}-[a-f0-9]\{4\}-[a-f0-9]\{12\}/guid/g' > $1_$3.html 2> /dev/null
done

