var path = require("path");
const ForkTsCheckerWebpackPlugin = require('fork-ts-checker-webpack-plugin');

module.exports = {
    mode: 'production',

    entry: {
        'MaterialBlazorWebsite': [
            './scripts/material.blazor.website.ts'
        ]
    },

    optimization: {
        minimize: false
    },

    output: {
        clean: true,
        compareBeforeEmit: false,
        filename: "material.blazor.website.js",
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