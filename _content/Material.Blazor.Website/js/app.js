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
    },

    initializeSplash: function () {
        let fileNames = [
            "coverr-a-girl-finishes-to-work-and-goes-away-7516",
            "coverr-a-girl-is-typing-on-the-laptop-and-drinking-coffee-9927",
            "coverr-close-up-of-two-hands-typing-on-a-keyboard-9692",
            "coverr-someone-is-checking-emails-there_s-an-old-globe-on-the-table-0186"
        ];

        let selectedName = fileNames[Math.floor(Math.random() * fileNames.length)];

        let elem = document.querySelector(".splash-background-video");
        elem.poster = "_content/Material.Blazor.Website/videos/" + selectedName + ".jpg";
        elem.innerHTML = "<source src='_content/Material.Blazor.Website/videos/" + selectedName + ".mp4' type='video/mp4'>"

        let linearProgress = document.querySelector('.splash-linear-progress');
        MaterialBlazor.MBLinearProgress.init(linearProgress, 0, 0);
    }
}
