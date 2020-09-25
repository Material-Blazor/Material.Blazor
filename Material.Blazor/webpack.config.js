var path = require("path");

module.exports = {
    mode: 'production',

    entry: {
        'MaterialBlazor': [
            './Scripts/MaterialBlazor.ts'
        ]
    },

    optimization: {
        minimize: false
    },

    output: {
        filename: "MaterialBlazor.js",
        path: path.resolve(__dirname, 'wwwroot'),
    },

    resolve: {
        extensions: [".ts", ".js"]
    },

    module: {
        rules: [
            {
                test: /\.tsx?$/,
                use: 'ts-loader',
                exclude: /node_modules/,
            },
            {
                test: /\.js$/,
                loader: "babel-loader",
            }
        ],
    },
};
