FROM node
WORKDIR /wip
COPY package.json .
RUN npm install
RUN curl "https://fonts.googleapis.com/css?family=Material+Icons|Material+Icons+Outlined|Material+Icons+Two+Tone|Material+Icons+Round|Material+Icons+Sharp" > material-components-icons.css
COPY . .
RUN npm run build-bmdc-css
RUN npm run minify-bmdc-css
RUN npm run build-bundle-css
RUN npm run minify-bundle-css
RUN npm run build-bmdc-js
RUN npm run minify-bmdc-js
RUN npm run minify-bundle-js
WORKDIR /wip/wwwroot
