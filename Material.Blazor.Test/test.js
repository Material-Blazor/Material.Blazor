const puppeteer = require('puppeteer');
const trimImage = require('trim-image');
const looksSame = require('looks-same');
const fs = require('fs');
const glob = require('glob');
const path = require('path');

const baseUrl = 'https://localhost:5001';

async function testBatching() {
    const browser = await puppeteer.launch( {headless: false});
    const page = await browser.newPage();
    await page.goto(baseUrl);
    await page.waitForSelector('app > aside');
    for (let i = 0; i < 2; ++i) {
        
        await page.evaluate(async () => {
            const sites = document.querySelectorAll('app > aside > div > div > li');
            for (var site of sites) {
                site.click();
                await new Promise((r) => setTimeout(r, 400));
            }
            sites[0].click();
        });
    }
    //await browser.close();
}

(async () => { 
    await testBatching();
})(); 