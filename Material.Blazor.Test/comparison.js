const puppeteer = require('puppeteer');
const trimImage = require('trim-image');
const looksSame = require('looks-same');
const fs = require('fs');
const glob = require('glob');
const path = require('path');

const baseline = 'https://material-blazor.com';
const fork = process.argv[process.argv.length - 1].startsWith('http') 
                ? process.argv[process.argv.length - 1]
                : 'https://stefanloerwald.github.io/Material.Blazor';


// We need this method, as trim-image returns too early (file not yet written), but it's crucial to wait for it to be written, before we do anything else. Taken from https://stackoverflow.com/a/47764403/985296
function checkExistsWithTimeout(filePath, timeout) {
    return new Promise(function (resolve, reject) {

        var timer = setTimeout(function () {
            watcher.close();
            reject(new Error('File did not exists and was not created during the timeout.'));
        }, timeout);

        fs.access(filePath, fs.constants.R_OK, function (err) {
            if (!err) {
                clearTimeout(timer);
                watcher.close();
                resolve();
            }
        });

        var dir = path.dirname(filePath);
        var basename = path.basename(filePath);
        var watcher = fs.watch(dir, function (eventType, filename) {
            if (eventType === 'rename' && filename === basename) {
                clearTimeout(timer);
                watcher.close();
                resolve();
            }
        });
    });
}

async function capture(page, site, prefix) {
    console.log(`Navigating to ${site}`);
    await page.goto(site);
    await page.setViewport({ width: 1000, height: 20000 });
    await page.waitForSelector('app > aside');
    console.log(`Page ${site} loaded`);
    const siteCount = await page.evaluate(() => {
        document.body.style.backgroundColor = 'transparent';
        console.log(document.location);
        return Promise.resolve(document.querySelectorAll('app > aside > div > div > li').length);
    });
    for (let i = 0; i < 3; ++i) {
        await page.evaluate((i) => {
            const site = document.querySelectorAll('app > aside > div > div > li')[i];
            site.click();
        }, i);
        await new Promise(r => setTimeout(r, 400));
        let path = await page.evaluate(() => {
            return Promise.resolve(document.location.pathname.substr(1));
        });
        if (path.startsWith('Material.Blazor/')) {
            path = path.split('/').splice(1).join('/');
        }
        path = path.replace(/\//g,'_');
        const html = await page.content();
        await fs.writeFile(`${prefix}_${path}.html`, html, (error) => {
            if (error) {
                console.log(error);
            }
        });
        await page.screenshot({ path: `${prefix}_raw_${path}.png`, fullPage: true, omitBackground: true });
        trimImage(`${prefix}_raw_${path}.png`, `${prefix}_${path}.png`, { top: false, right: false, left: false, bottom: true } );
        await checkExistsWithTimeout(`${prefix}_${path}.png`, 100000);
        await fs.unlink(`${prefix}_raw_${path}.png`, (error) => {
            if (error) {
                console.log(error);
            }
        });
        console.log(`Processed site '${site}/${path}'`);
    }
}

async function captureAll() {
    const browser = await puppeteer.launch();
    const mbPage = await browser.newPage();
    const forkPage = await browser.newPage();
    const mbPromise = capture(mbPage, baseline, 'mb');
    const forkPromise = capture(forkPage, fork, 'fork');
    await Promise.all([mbPromise, forkPromise]);
    await browser.close(); 
}

async function compare(f) {
    await looksSame(`mb_${f}`, `fork_${f}`, {ignoreAntialiasing: true}, async function(error, {equal}) {
        if (!equal) {
            console.log(`Found difference for ${f}. Creating diff file...`);
            await looksSame.createDiff({
                reference: `mb_${f}`,
                current: `fork_${f}`,
                diff: `diff_${f}`,
                highlightColor: '#ff00ff', // color to highlight the differences
                strict: false, // strict comparsion
                ignoreAntialiasing: true, // ignore antialising by default
            }, function(error) {});
            await fs.unlink(`mb_${f}`, (error) => {
                if (error) {
                    console.log(error);
                }
            });
            await fs.unlink(`fork_${f}`, (error) => {
                if (error) {
                    console.log(error);
                }
            });
        } else {
            console.log(`Found no difference for ${f}`);
            await fs.unlink(`mb_${f}`, (error) => {
                if (error) {
                    console.log(error);
                }
            });
            await fs.unlink(`fork_${f}`, (error) => {
                if (error) {
                    console.log(error);
                }
            });
        }
    });
}

async function compareAll() {
    const raw_mb_files = glob.sync('mb_*.png');
    const raw_fork_files = glob.sync('fork_*.png');
    const mb_files = new Set();
    const fork_files = new Set();
    for (const f of raw_mb_files) {
        mb_files.add(f.replace('mb_',''));
    }
    for (const f of raw_fork_files) {
        fork_files.add(f.replace('fork_',''));
    }
    for (const f of mb_files) {
        if (!fork_files.has(f)) {
            console.log(`Found ${f}, which does exist on MB, but not on the fork`);
        }
    }
    for (const f of fork_files) {
        if (!mb_files.has(f)) {
            console.log(`Found ${f}, which does exist on the fork, but not on MB`);
        }
    }
    for (const f of mb_files) {
        if (fork_files.has(f)) {
            await compare(f);
        }
    }
}

(async () => { 
    await captureAll();
    await compareAll();
})();