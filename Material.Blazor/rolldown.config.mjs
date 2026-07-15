import { defineConfig } from 'rolldown';

const input = './Scripts/material.blazor.ts';

export default defineConfig([
    {
        input,
        platform: 'browser',
        output: {
            dir: 'wwwroot',
            entryFileNames: 'material.blazor.js',
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
            entryFileNames: 'material.blazor.min.js',
            format: 'iife',
            comments: { legal: true },
            minify: true
        }
    }
]);
