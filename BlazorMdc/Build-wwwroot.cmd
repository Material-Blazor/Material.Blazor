@echo off
call npm install
call npm run clean-wip
call npm run clean-wwwroot
call npm run build-matfont
call npm run minify-matfont
call npm run build-bmdc
call npm run minify-bmdc
call npm run build-bundle
call npm run minify-bundle-css
call npm run build-bmdc-ts
call npm run minify-bmdc-js
call npm run minify-bundle-js
call npm run build-bmdcdemo
call npm run clean-wip
