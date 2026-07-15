(function() {

//#region \0rolldown/runtime.js
	var __defProp = Object.defineProperty;
	var __exportAll = (all, no_symbols) => {
		let target = {};
		for (var name in all) {
			__defProp(target, name, {
				get: all[name],
				enumerable: true
			});
		}
		if (!no_symbols) {
			__defProp(target, Symbol.toStringTag, { value: "Module" });
		}
		return target;
	};

//#endregion

//#region Scripts/MBTheme.ts
	var MBTheme_exports = /* @__PURE__ */ __exportAll({
		setHtmlBlockTextDirection: () => setHtmlBlockTextDirection,
		setTheme: () => setTheme
	});
	function setTheme(sheetName, minify) {
		let extension = ".css";
		if (minify === true) extension = ".min.css";
		document.getElementById("app-style")?.setAttribute("href", "_content/Material.Blazor.Website/css/" + sheetName + extension);
	}
	function setHtmlBlockTextDirection(textDirection) {
		document.documentElement.setAttribute("dir", textDirection);
	}

//#endregion
//#region Scripts/material.blazor.website.ts
	window.MaterialBlazorWebsite = { MBTheme: MBTheme_exports };

//#endregion
})();