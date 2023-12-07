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
/************************************************************************/
var __webpack_exports__ = {};
/* unused harmony exports eventArgsCreatorMenuClose, afterStarted */
/*
** MW3 menu-close event arguments
**
** This must match the C# definition found in MBMenuEvents.cs
*/
function eventArgsCreatorMenuClose(event) {
  return {
    customProperty1: 'any value for property 1',
    customProperty2: event.srcElement.value
  };
}

/*
** Register all custom events
*/
function afterStarted(blazor) {
  blazor.registerCustomEventType('menuclose', {
    browserEventName: "menu-close",
    createEventArgs: eventArgsCreatorMenuClose
  });
}
/******/ })()
;