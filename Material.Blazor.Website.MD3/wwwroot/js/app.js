// We load this file on the MD3 website even though there is no support yet for themes

window.material_blazor_website = {
    themeSetter: {
        setTheme: function (sheetName, minify) {
            let extension = ".css";

            if (minify === true) {
                extension = ".min.css";
            }

            document.getElementById("app-style").setAttribute("href", "_content/Material.Blazor.Website/css/" + sheetName + extension);
        }
    },

    baseHref: {
        getBaseURI: function () {
            return document.getElementsByTagName("base")[0].getAttribute("href");
        }
    }
}
