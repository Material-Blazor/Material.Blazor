FROM node
WORKDIR /wip
COPY package.json .
RUN npm install
RUN curl "https://fonts.googleapis.com/css?family=Material+Icons|Material+Icons+Outlined|Material+Icons+Two+Tone|Material+Icons+Round|Material+Icons+Sharp" > material-components-icons.css
COPY . .
RUN npm run build-css && npm run build-min-css && npm run build-min-bundle-css && npm run build-js && npm run build-min-js && npm run build-min-bundle-js
WORKDIR /wip/wwwroot