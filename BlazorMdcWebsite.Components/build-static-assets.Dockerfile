FROM node
WORKDIR /wip
COPY package.json .
RUN npm install
COPY . .
RUN npm run build-mt-default
RUN npm run build-min-mt-default
RUN npm run build-blue-square
RUN npm run build-min-blue-square
RUN npm run build-red-round
RUN npm run build-min-red-round
RUN npm run build-varied
RUN npm run build-min-varied
WORKDIR /wip/wwwroot/css
