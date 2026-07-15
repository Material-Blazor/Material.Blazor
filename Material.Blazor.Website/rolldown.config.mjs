import { defineConfig } from 'rolldown';

const input = './Scripts/material.blazor.website.ts';

export default defineConfig([
    {
        input,
        platform: 'browser',
        output: {
            dir: 'wwwroot',
            entryFileNames: 'js/material.blazor.website.js',
            format: 'iife',
            comments: { legal: true },
            minify: false
        }
    },
    {
        input,
        platform: 'browser',
        output: {
            dir: 'wwwroot',
            entryFileNames: 'js/material.blazor.website.min.js',
            format: 'iife',
            comments: { legal: true },
            minify: true
        }
    }
]);
