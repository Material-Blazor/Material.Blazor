var path = require("path");
const ForkTsCheckerWebpackPlugin = require('fork-ts-checker-webpack-plugin');

module.exports = {
    mode: 'production',

    entry: {
        'MaterialBlazor': [
            './scripts/MaterialBlazor.ts'
        ]
    },

    optimization: {
        minimize: false
    },

    output: {
        filename: "intermediate.js",
        path: path.resolve(__dirname, 'wwwroot'),
    },

    resolve: {
        extensions: [".ts", ".js"]
    },

    module: {
        rules: [
            {
                test: /\.(ts|js)x?$/,
                use: 'babel-loader',
                exclude: /node_modules/,
            }
        ],
    },

    plugins: [
        new ForkTsCheckerWebpackPlugin(),
    ]
};
