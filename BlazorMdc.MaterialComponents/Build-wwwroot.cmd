@echo on
call npm install
call npm run clean-wwwroot
call npm run build-scss-bmdcb
call npm run minify-css-bmdcb
call npm run delete-css-bmdcb
call npm run build-scss-matf
call npm run minify-css-matf
call npm run delete-css-matf
call npm run build-scss-bmdc
call npm run minify-css-bmdc
call npm run copy-material-css
call npm run copy-material-js
call npm run build-ts
call npm run minify-js
call npm run copy-all
dir wwwroot /s
@echo call npm run clean-wwwroot
