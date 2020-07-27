@echo on
call npm install
call npm run clean-wwwroot
call npm run build-scss-matfont
call npm run minify-css-matfont
call npm run delete-css-matfont
call npm run build-scss-bundle
call npm run minify-css-bundle
call npm run delete-css-bundle
call npm run build-scss-bmdc
call npm run minify-css-bmdc
call npm run copy-material-css
call npm run copy-material-js
@echo call npm run build-ts
@echo call npm run minify-js
@echo call npm run copy-all
dir wwwroot /s
@echo call npm run clean-wwwroot
