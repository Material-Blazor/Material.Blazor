@echo on
call npm install
call npm run clean-wip
call npm run clean-wwwroot
call npm run build-matfont
call npm run minify-matfont
call npm run build-bmdc
call npm run minify-bmdc
call npm run build-bundle
call npm run minify-bundle-css
call npm run minify-bundle-js
call npm run copy-all
dir wip /s
dir wwwroot /s
@echo call npm run clean-wip
@echo call npm run clean-wwwroot
