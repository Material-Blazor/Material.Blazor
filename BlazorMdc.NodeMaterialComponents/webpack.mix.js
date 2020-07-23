const mix = require('laravel-mix');

/*
 |--------------------------------------------------------------------------
 | Mix Asset Management
 |--------------------------------------------------------------------------
 |
 | Mix provides a clean, fluent API for defining some Webpack build steps
 | for your Laravel application. By default, we are compiling the Sass
 | file for the application as well as bundling up all the JS files.
 |
 */

mix
    //.ts("ts/index.ts", "Material-Components-Web/dist")
    .sass('main.scss', 'Material-Components-Web/dist')
    .webpackConfig({
        module: {
            rules: [
                {
                    test: /\.s[ac]ss$/i,
                    use: [
                        {
                            loader: 'extract-loader'
                        },
                        {
                            loader: 'css-loader',
                        },
                        {
                            loader: 'sass-loader',
                            options: {
                                // Prefer Dart Sass
                                implementation: require('dart-sass'),

                                // See https://github.com/webpack-contrib/sass-loader/issues/804
                                webpackImporter: false,

                                sassOptions: {
                                    includePaths: ['node_modules'],
                                },
                            },
                        },
                    ]
                }
            ]
        },
    });