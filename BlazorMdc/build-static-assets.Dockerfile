FROM node
WORKDIR /wip
COPY package.json .
RUN npm install
RUN curl "https://fonts.googleapis.com/css?family=Material+Icons|Material+Icons+Outlined|Material+Icons+Two+Tone|Material+Icons+Round|Material+Icons+Sharp" > material-components-icons.css
COPY . .
RUN npm run build-css
RUN npm run build-min-css
RUN npm run build-min-bundle-css
RUN npm run build-js
RUN npm run build-min-js
RUN npm run build-min-bundle-js
WORKDIR /wip/wwwroot