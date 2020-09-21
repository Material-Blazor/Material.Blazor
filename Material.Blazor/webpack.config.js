var path = require("path");

module.exports = {
    entry: {
        'matBlazor': [
            './scripts/MaterialBlazor.ts'
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
        extensions: [".ts"]
    },


    module: {
        rules: [
            {
                test: /\.tsx?$/,
                use: 'ts-loader',
                exclude: /node_modules/,
            }
        ]
    }
};
