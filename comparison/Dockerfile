FROM justinribeiro/chrome-headless

USER root
RUN apt update && apt install wdiff -y
USER chrome

WORKDIR /out

COPY crawl_all.sh .
COPY crawl.sh .

WORKDIR /src
COPY pages .
RUN tr -d '\015' <pages >tmp && mv tmp pages

WORKDIR /out

ARG baseline=https://material-blazor.com/
ARG fork=https://stefanloerwald.github.io/Material.Blazor/

RUN /bin/bash ./crawl_all.sh "$baseline" "$fork"
RUN cat ./differences* > report
