window.material_blazor_website = {
    themeSetter: {
        setTheme: function (sheetName) {
            document.getElementById("app-style").setAttribute("href", "_content/Material.Blazor.Website.Components/css/" + sheetName + ".min.css");
        }
    },

    baseHref: {
        getBaseURI: function () {
            return document.getElementsByTagName("base")[0].getAttribute("href");
        }
    }
}