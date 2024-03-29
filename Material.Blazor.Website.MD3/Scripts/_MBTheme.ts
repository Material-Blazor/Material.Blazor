﻿export function setTheme(sheetName, minify) {
    let extension = ".css";

    if (minify === true) {
        extension = ".min.css";
    }

    document.getElementById("app-style")?.setAttribute("href", "_content/Material.Blazor.Website.MD3/css/" + sheetName + extension);
}
