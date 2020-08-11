window.BlazorMdcWebsite = {
    themeSetter: {
        setTheme: function (sheetName) {
            document.getElementById("app-style").setAttribute("href", "_content/BlazorMdcWebsite.Components/css/" + sheetName + ".min.css");
        }
    }
}