/******/ (() => { // webpackBootstrap
/******/ 	"use strict";
/******/ 	// The require scope
/******/ 	var __webpack_require__ = {};
/******/ 	
/************************************************************************/
/******/ 	/* webpack/runtime/define property getters */
/******/ 	(() => {
/******/ 		// define getter functions for harmony exports
/******/ 		__webpack_require__.d = (exports, definition) => {
/******/ 			for(var key in definition) {
/******/ 				if(__webpack_require__.o(definition, key) && !__webpack_require__.o(exports, key)) {
/******/ 					Object.defineProperty(exports, key, { enumerable: true, get: definition[key] });
/******/ 				}
/******/ 			}
/******/ 		};
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/hasOwnProperty shorthand */
/******/ 	(() => {
/******/ 		__webpack_require__.o = (obj, prop) => (Object.prototype.hasOwnProperty.call(obj, prop))
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/make namespace object */
/******/ 	(() => {
/******/ 		// define __esModule on exports
/******/ 		__webpack_require__.r = (exports) => {
/******/ 			if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 				Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 			}
/******/ 			Object.defineProperty(exports, '__esModule', { value: true });
/******/ 		};
/******/ 	})();
/******/ 	
/************************************************************************/
var __webpack_exports__ = {};

// NAMESPACE OBJECT: ./Scripts/MBTheme.ts
var MBTheme_namespaceObject = {};
__webpack_require__.r(MBTheme_namespaceObject);
__webpack_require__.d(MBTheme_namespaceObject, {
  setTheme: () => (setTheme)
});

;// CONCATENATED MODULE: ./Scripts/MBTheme.ts
function setTheme(sheetName, minify) {
  var _document$getElementB;
  var extension = ".css";
  if (minify === true) {
    extension = ".min.css";
  }
  (_document$getElementB = document.getElementById("app-style")) === null || _document$getElementB === void 0 || _document$getElementB.setAttribute("href", "_content/Material.Blazor.Website/css/" + sheetName + extension);
}
;// CONCATENATED MODULE: ./scripts/material.blazor.website.ts

window.MaterialBlazorWebsite = {
  MBTheme: MBTheme_namespaceObject
};
/******/ })()
;