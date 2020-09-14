FROM node
WORKDIR /wip
COPY package.json .
RUN npm install
COPY . .
RUN npm run build-mt-default && npm run build-min-mt-default && npm run build-blue-square && npm run build-min-blue-square && npm run build-red-round && npm run build-min-red-round && npm run build-varied && npm run build-min-varied
WORKDIR /wip/wwwroot/css
