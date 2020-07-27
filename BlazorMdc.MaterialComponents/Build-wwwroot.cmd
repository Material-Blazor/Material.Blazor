@echo on
call npm install
call npm run clean-wwwroot
call npm run build-scss-matf
call npm run minify-css-matf
call npm run delete-css-matf
call npm run build-scss-bmdc
call npm run minify-css-bmdc
call npm run copy-material-css
call npm run copy-material-js
@echo call npm run build-ts
@echo call npm run minify-js
@echo call npm run copy-all
dir wwwroot /s
@echo call npm run clean-wwwroot
