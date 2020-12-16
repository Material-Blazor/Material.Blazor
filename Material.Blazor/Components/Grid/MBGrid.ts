export function syncScroll(gridHeaderRef: HTMLElement, gridBodyRef: HTMLElement) {
    gridHeaderRef.scrollLeft = gridBodyRef.scrollLeft;
}

export function getScrollBarWidth(): number {
    const firstDiv: HTMLDivElement = document.createElement("div");
    firstDiv.style.visibility = "hidden";
    firstDiv.style.overflow = "scroll";
    document.body.appendChild(firstDiv);
    const secondDiv: HTMLDivElement = document.createElement("div");
    firstDiv.appendChild(secondDiv);
    const n: number = firstDiv.offsetWidth - secondDiv.offsetWidth;
    if (firstDiv.parentNode != null) {
        firstDiv.parentNode.removeChild(firstDiv);
    }
    return n;
}

export function getTextWidth(className: string, textToMeasure: string): string {
    // Create an element
    const ele: HTMLDivElement = document.createElement('div');

    // Set styles
    ele.style.position = 'absolute';
    ele.style.visibility = 'hidden';
    ele.style.whiteSpace = 'nowrap';
    ele.style.left = '-9999px';

    // Set the class
    ele.className = className;
    ele.innerText = textToMeasure;

    // Append to the body
    document.body.appendChild(ele);

    // Get the width
    const width: string = window.getComputedStyle(ele).width;

    // Remove the element
    document.body.removeChild(ele);

    return width;
}

export function setPaddingRight(elementRef: HTMLElement) {
    elementRef.style.paddingRight = getScrollBarWidth() + "px";
}

export function setTDWidths(elementRef: HTMLTableElement, columnWidthList: number[]) {

    // children node list has a length property, similarly to the arrays
    const lenWidths: number = columnWidthList.length;
    var fullWidth: number = 0;
    // loop through the width list
    for (let i: number = 0; i < lenWidths; i++) {
        console.log(columnWidthList[i]);
        fullWidth += columnWidthList[i];
    }

    //console.log(elementRef.nodeName);

    if (elementRef.nodeName != "TABLE") {
        alert(elementRef.nodeName + " is not a TABLE");
    }

    // get children of a node
    //const children: HTMLCollection = elementRef.children;
    //var hasBody: Boolean = false;
    //var hasColGroup: Boolean = false;
    //var hasHeader: Boolean = false;

    //// children node list has a length property, similarly to the arrays
    //const len: number = children.length;

    //// loop through the node list and log the names of nodes
    //// we are using the same syntax as for the arrays
    //for (let i: number = 0; i < len; i++) {
    //    console.log("   " + children[i].nodeName);
    //    if (children[i].nodeName == "TBODY") {
    //        hasBody = true;
    //    }
    //    if (children[i].nodeName == "TCOLGROUP") {
    //        hasColGroup = true;
    //    }
    //    if (children[i].nodeName == "THEAD") {
    //        hasHeader = true;
    //    }
    //}

    if (elementRef.rows.length > 0) {
        var rows: HTMLCollectionOf<HTMLTableRowElement> = elementRef.rows;
        var rowcount: number = rows.length;
        var r: number;
        var cells: HTMLCollectionOf<HTMLTableCellElement>;
        var cellcount: number;
        var c: number;
        var cell: HTMLTableCellElement;
        for (r = 0; r < rowcount; r++) {
            cells = rows[r].cells;
            cellcount = cells.length;
            for (c = 0; c < cellcount; c++) {
                cell = cells[c];
                // now do something.
                if (cell.outerHTML.includes("mbgrid-td-normal")) {
                    console.log("      mbgrid-td-normal -> R: " + r + " C: " + c);
                    cell.width = columnWidthList[c].toString() + "px";
                }
                if (cell.outerHTML.includes("mbgrid-td-wide")) {
                    console.log("      mbgrid-td-wide -> R: " + r + " C: " + c);
                    cell.width = fullWidth.toString() + "px";
                }
            }
        }
    }

    //var header: HTMLTableSectionElement | null = elementRef.tHead;
    //if (header != null) {
    //    var headerElem = elementRef.tHead?.children;
    //}

    // This interesting construct was found on codeproject
    // The row iterator works as expected "(0..n)" for n rows
    // But the column iterator returns "(0..m) length item namedItem" for m columns
    //
    //if (elementRef.rows.length > 0) {
    //    for (let i in elementRef.rows) {
    //        let row = elementRef.rows[i]
    //        //iterate through rows
    //        //rows would be accessed using the "row" variable assigned in the for loop
    //        for (let j in row.cells) {
    //            let col = row.cells[j]
    //            //iterate through columns
    //            //columns would be accessed using the "col" variable assigned in the for loop
    //            console.log("      Ri: " + i + " Cj: " + j);
    //        }
    //    }
    //}

}
