﻿//export function init(elem): void {
//    if (!elem) {
//        return;
//    }

//    elem.addEventListener("ondragover", function () {
//        (function (ev) {
//            console.log("boo");
//            ev.preventDefault();
//            ev.dataTransfer.dropEffect = "move";
//        });
//    });
//}

//export function dragoverHandler(ev): void {
//    console.log("boo");
//    ev.preventDefault();
//    ev.dataTransfer.dropEffect = "move";
//}

//export function setProgress(elem, showProgress) {
//    if (!elem) {
//        return;
//    }
//    if (showProgress) {
//        elem._dataTable.showProgress();
//    }
//    else {
//        elem._dataTable.hideProgress();
//    }
//}