window.BlazorMdc={autoComplete:{init:function(textElem,menuElem,dotNetObject){textElem._textField=mdc.textField.MDCTextField.attachTo(textElem);menuElem._menu=mdc.menu.MDCMenu.attachTo(menuElem);return new Promise(()=>{menuElem._menu.foundation.handleItemAction=listItem=>{menuElem._menu.open=false;dotNetObject.invokeMethodAsync("NotifySelectedAsync",listItem.innerText)};menuElem._menu.foundation.adapter.handleMenuSurfaceOpened=()=>{menuElem._menu.foundation.setDefaultFocusState(0)};closedCallback=()=>{dotNetObject.invokeMethodAsync("NotifyClosedAsync")};menuElem._menu.listen("MDCMenuSurface:closed",closedCallback)})},open:function(menuElem){menuElem._menu.open=true;menuElem._menu.foundation.setDefaultFocusState(0)},close:function(menuElem){menuElem._menu.open=false},setValue:function(textElem,value){textElem._textField.value=value},setDisabled:function(textElem,disabled){textElem._textField.disabled=disabled}},button:{init:function(elem){mdc.ripple.MDCRipple.attachTo(elem)}},cardPrimaryAction:{init:function(elem){mdc.ripple.MDCRipple.attachTo(elem)}},checkBox:{init:function(elem,formFieldElem,checked,indeterminate){elem._checkbox=mdc.checkbox.MDCCheckbox.attachTo(elem);elem._checkbox.checked=checked;elem._checkbox.indeterminate=indeterminate;elem._formField=mdc.formField.MDCFormField.attachTo(formFieldElem);elem._formField.input=elem._checkbox},setChecked:function(elem,checked){elem._checkbox.checked=checked},setIndeterminate:function(elem,indeterminate){elem._checkbox.indeterminate=indeterminate},setDisabled:function(elem,disabled){elem._checkbox.disabled=disabled}},circularProgress:{init:function(elem,progress){elem._circularProgress=mdc.circularProgress.MDCCircularProgress.attachTo(elem);this.setProgress(elem,progress)},setProgress:function(elem,progress){elem._circularProgress.progress=progress}},datePicker:{init:function(elem){elem._select=mdc.select.MDCSelect.attachTo(elem)},listItemClick:function(elem,elemText){elem.innerText=elemText;elem.click()},scrollToYear:function(id){var element=document.getElementById(id);element.scrollIntoView({behavior:"smooth",block:"center",inline:"start"})}},dataTable:{init:function(elem){}},dialog:{show:function(elem,dotNetObject,escapeKeyAction,scrimClickAction){elem._dialog=elem._dialog||mdc.dialog.MDCDialog.attachTo(elem);elem._dotNetObject=dotNetObject;return new Promise(resolve=>{const dialog=elem._dialog;const openedCallback=event=>{dialog.unlisten("MDCDialog:opened",openedCallback);dotNetObject.invokeMethodAsync("NotifyOpenedAsync")};const closingCallback=event=>{dialog.unlisten("MDCDialog:closing",closingCallback);resolve(event.detail.action)};dialog.listen("MDCDialog:opened",openedCallback);dialog.listen("MDCDialog:closing",closingCallback);dialog.escapeKeyAction=escapeKeyAction;dialog.scrimClickAction=scrimClickAction;dialog.open()})},hide:function(elem,dialogAction){if(elem._dialog){elem._dialog.close(dialogAction||"dismissed")}}},drawer:{toggle:function(elem,isOpen){const drawer=mdc.drawer.MDCDrawer.attachTo(elem);drawer.open=isOpen}},iconButton:{init:function(elem){const iconButtonRipple=mdc.ripple.MDCRipple.attachTo(elem);iconButtonRipple.unbounded=true}},iconButtonToggle:{init:function(elem){elem._iconButtonToggle=mdc.iconButton.MDCIconButtonToggle.attachTo(elem)},setOn:function(elem,isOn){elem._iconButtonToggle.on=isOn},click:function(elem){elem._iconButtonToggle.root.click()}},linearProgress:{init:function(elem,progress,buffer){elem._linearProgress=mdc.linearProgress.MDCLinearProgress.attachTo(elem);this.setProgress(elem,progress,buffer)},setProgress:function(elem,progress,buffer){elem._linearProgress.progress=progress;elem._linearProgress.buffer=buffer}},list:{init:function(elem,keyboardInteractions,ripple){if(keyboardInteractions==true){const list=mdc.list.MDCList.attachTo(elem);if(ripple==true){list.listElements.map(elem=>mdc.ripple.MDCRipple.attachTo(elem))}}}},menu:{init:function(elem,dotNetObject){elem._menu=mdc.menu.MDCMenu.attachTo(elem);return new Promise(()=>{elem._menu.foundation.handleItemAction=()=>{elem._menu.open=false;dotNetObject.invokeMethodAsync("NotifyClosedAsync")}})},show:function(elem){if(elem._menu){elem._menu.open=true}},hide:function(elem){if(elem._menu){elem._menu.open=false}}},radioButton:{init:function(elem,formFieldElem,isChecked){elem._radio=mdc.radio.MDCRadio.attachTo(elem);elem._radio.checked=isChecked;let formField=mdc.formField.MDCFormField.attachTo(formFieldElem);formField.input=elem._radio},setChecked:function(elem,isChecked){elem._radio.checked=isChecked}},select:{init:function(selectElem,dotNetObject){selectElem._select=mdc.select.MDCSelect.attachTo(selectElem);return new Promise(()=>{selectElem._select.foundation.handleMenuItemAction=index=>{selectElem._select.foundation.setSelectedIndex(index);dotNetObject.invokeMethodAsync("NotifySelectedAsync",index)}})},setDisabled:function(elem,value){elem._select.disabled=value},setIndex:function(elem,index){elem._select.selectedIndex=index}},switch:{init:function(elem,checked){elem._switch=mdc.switchControl.MDCSwitch.attachTo(elem);elem._switch.checked=checked},setChecked:function(elem,checked){elem._switch.checked=checked},setDisabled:function(elem,disabled){elem._switch.disabled=disabled}},tabBar:{init:function(elem,dotNetObject){elem._tabBar=mdc.tabBar.MDCTabBar.attachTo(elem);return new Promise(()=>{elem._callback=()=>{let index=elem._tabBar.foundation.adapter.getFocusedTabIndex();dotNetObject.invokeMethodAsync("NotifyActivatedAsync",index)};elem._tabBar.listen("MDCTabBar:activated",elem._callback)})},activateTab:function(elem,index){elem._tabBar.unlisten("MDCTabBar:activated",elem._callback);elem._tabBar.activateTab(index);elem._tabBar.listen("MDCTabBar:activated",elem._callback)}},textField:{init:function(elem){elem._textField=mdc.textField.MDCTextField.attachTo(elem)},select:function(inputElem){inputElem.focus();inputElem.select()},setValue:function(elem,value){elem._textField.value=value},setDisabled:function(elem,value){elem._textField.disabled=value}},tooltip:{init:function(elems){for(let i=0;i<elems.length;i++){mdc.tooltip.MDCTooltip.attachTo(elems[i])}}},topAppBar:{init:function(elem,scrollTarget){const topAppBar=mdc.topAppBar.MDCTopAppBar.attachTo(elem);if(scrollTarget){topAppBar.setScrollTarget(document.querySelector(scrollTarget))}}}};
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://github.com/material-components/material-components-web/blob/master/LICENSE
 */
(function webpackUniversalModuleDefinition(root,factory){if(typeof exports==="object"&&typeof module==="object")module.exports=factory();else if(typeof define==="function"&&define.amd)define([],factory);else if(typeof exports==="object")exports["tooltip"]=factory();else root["mdc"]=root["mdc"]||{},root["mdc"]["tooltip"]=factory()})(this,(function(){return function(modules){var installedModules={};function __webpack_require__(moduleId){if(installedModules[moduleId]){return installedModules[moduleId].exports}var module=installedModules[moduleId]={i:moduleId,l:false,exports:{}};modules[moduleId].call(module.exports,module,module.exports,__webpack_require__);module.l=true;return module.exports}__webpack_require__.m=modules;__webpack_require__.c=installedModules;__webpack_require__.d=function(exports,name,getter){if(!__webpack_require__.o(exports,name)){Object.defineProperty(exports,name,{enumerable:true,get:getter})}};__webpack_require__.r=function(exports){if(typeof Symbol!=="undefined"&&Symbol.toStringTag){Object.defineProperty(exports,Symbol.toStringTag,{value:"Module"})}Object.defineProperty(exports,"__esModule",{value:true})};__webpack_require__.t=function(value,mode){if(mode&1)value=__webpack_require__(value);if(mode&8)return value;if(mode&4&&typeof value==="object"&&value&&value.__esModule)return value;var ns=Object.create(null);__webpack_require__.r(ns);Object.defineProperty(ns,"default",{enumerable:true,value:value});if(mode&2&&typeof value!="string")for(var key in value)__webpack_require__.d(ns,key,function(key){return value[key]}.bind(null,key));return ns};__webpack_require__.n=function(module){var getter=module&&module.__esModule?function getDefault(){return module["default"]}:function getModuleExports(){return module};__webpack_require__.d(getter,"a",getter);return getter};__webpack_require__.o=function(object,property){return Object.prototype.hasOwnProperty.call(object,property)};__webpack_require__.p="";return __webpack_require__(__webpack_require__.s="./packages/mdc-tooltip/index.ts")}({"./packages/mdc-base/component.ts":
/*!****************************************!*\
  !*** ./packages/mdc-base/component.ts ***!
  \****************************************/
/*! no static exports found */function(module,exports,__webpack_require__){"use strict";
/**
 * @license
 * Copyright 2016 Google Inc.
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */var __read=this&&this.__read||function(o,n){var m=typeof Symbol==="function"&&o[Symbol.iterator];if(!m)return o;var i=m.call(o),r,ar=[],e;try{while((n===void 0||n-- >0)&&!(r=i.next()).done){ar.push(r.value)}}catch(error){e={error:error}}finally{try{if(r&&!r.done&&(m=i["return"]))m.call(i)}finally{if(e)throw e.error}}return ar};var __spread=this&&this.__spread||function(){for(var ar=[],i=0;i<arguments.length;i++){ar=ar.concat(__read(arguments[i]))}return ar};Object.defineProperty(exports,"__esModule",{value:true});var foundation_1=__webpack_require__(/*! ./foundation */"./packages/mdc-base/foundation.ts");var MDCComponent=function(){function MDCComponent(root,foundation){var args=[];for(var _i=2;_i<arguments.length;_i++){args[_i-2]=arguments[_i]}this.root=root;this.initialize.apply(this,__spread(args));this.foundation=foundation===undefined?this.getDefaultFoundation():foundation;this.foundation.init();this.initialSyncWithDOM()}MDCComponent.attachTo=function(root){return new MDCComponent(root,new foundation_1.MDCFoundation({}))};MDCComponent.prototype.initialize=function(){var _args=[];for(var _i=0;_i<arguments.length;_i++){_args[_i]=arguments[_i]}};MDCComponent.prototype.getDefaultFoundation=function(){throw new Error("Subclasses must override getDefaultFoundation to return a properly configured "+"foundation class")};MDCComponent.prototype.initialSyncWithDOM=function(){};MDCComponent.prototype.destroy=function(){this.foundation.destroy()};MDCComponent.prototype.listen=function(evtType,handler,options){this.root.addEventListener(evtType,handler,options)};MDCComponent.prototype.unlisten=function(evtType,handler,options){this.root.removeEventListener(evtType,handler,options)};MDCComponent.prototype.emit=function(evtType,evtData,shouldBubble){if(shouldBubble===void 0){shouldBubble=false}var evt;if(typeof CustomEvent==="function"){evt=new CustomEvent(evtType,{bubbles:shouldBubble,detail:evtData})}else{evt=document.createEvent("CustomEvent");evt.initCustomEvent(evtType,shouldBubble,false,evtData)}this.root.dispatchEvent(evt)};return MDCComponent}();exports.MDCComponent=MDCComponent;exports.default=MDCComponent},"./packages/mdc-base/foundation.ts":
/*!*****************************************!*\
  !*** ./packages/mdc-base/foundation.ts ***!
  \*****************************************/
/*! no static exports found */function(module,exports,__webpack_require__){"use strict";
/**
 * @license
 * Copyright 2016 Google Inc.
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */Object.defineProperty(exports,"__esModule",{value:true});var MDCFoundation=function(){function MDCFoundation(adapter){if(adapter===void 0){adapter={}}this.adapter=adapter}Object.defineProperty(MDCFoundation,"cssClasses",{get:function get(){return{}},enumerable:true,configurable:true});Object.defineProperty(MDCFoundation,"strings",{get:function get(){return{}},enumerable:true,configurable:true});Object.defineProperty(MDCFoundation,"numbers",{get:function get(){return{}},enumerable:true,configurable:true});Object.defineProperty(MDCFoundation,"defaultAdapter",{get:function get(){return{}},enumerable:true,configurable:true});MDCFoundation.prototype.init=function(){};MDCFoundation.prototype.destroy=function(){};return MDCFoundation}();exports.MDCFoundation=MDCFoundation;exports.default=MDCFoundation},"./packages/mdc-dom/keyboard.ts":
/*!**************************************!*\
  !*** ./packages/mdc-dom/keyboard.ts ***!
  \**************************************/
/*! no static exports found */function(module,exports,__webpack_require__){"use strict";
/**
 * @license
 * Copyright 2020 Google Inc.
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */Object.defineProperty(exports,"__esModule",{value:true});exports.KEY={UNKNOWN:"Unknown",BACKSPACE:"Backspace",ENTER:"Enter",SPACEBAR:"Spacebar",PAGE_UP:"PageUp",PAGE_DOWN:"PageDown",END:"End",HOME:"Home",ARROW_LEFT:"ArrowLeft",ARROW_UP:"ArrowUp",ARROW_RIGHT:"ArrowRight",ARROW_DOWN:"ArrowDown",DELETE:"Delete",ESCAPE:"Escape"};var normalizedKeys=new Set;normalizedKeys.add(exports.KEY.BACKSPACE);normalizedKeys.add(exports.KEY.ENTER);normalizedKeys.add(exports.KEY.SPACEBAR);normalizedKeys.add(exports.KEY.PAGE_UP);normalizedKeys.add(exports.KEY.PAGE_DOWN);normalizedKeys.add(exports.KEY.END);normalizedKeys.add(exports.KEY.HOME);normalizedKeys.add(exports.KEY.ARROW_LEFT);normalizedKeys.add(exports.KEY.ARROW_UP);normalizedKeys.add(exports.KEY.ARROW_RIGHT);normalizedKeys.add(exports.KEY.ARROW_DOWN);normalizedKeys.add(exports.KEY.DELETE);normalizedKeys.add(exports.KEY.ESCAPE);var KEY_CODE={BACKSPACE:8,ENTER:13,SPACEBAR:32,PAGE_UP:33,PAGE_DOWN:34,END:35,HOME:36,ARROW_LEFT:37,ARROW_UP:38,ARROW_RIGHT:39,ARROW_DOWN:40,DELETE:46,ESCAPE:27};var mappedKeyCodes=new Map;mappedKeyCodes.set(KEY_CODE.BACKSPACE,exports.KEY.BACKSPACE);mappedKeyCodes.set(KEY_CODE.ENTER,exports.KEY.ENTER);mappedKeyCodes.set(KEY_CODE.SPACEBAR,exports.KEY.SPACEBAR);mappedKeyCodes.set(KEY_CODE.PAGE_UP,exports.KEY.PAGE_UP);mappedKeyCodes.set(KEY_CODE.PAGE_DOWN,exports.KEY.PAGE_DOWN);mappedKeyCodes.set(KEY_CODE.END,exports.KEY.END);mappedKeyCodes.set(KEY_CODE.HOME,exports.KEY.HOME);mappedKeyCodes.set(KEY_CODE.ARROW_LEFT,exports.KEY.ARROW_LEFT);mappedKeyCodes.set(KEY_CODE.ARROW_UP,exports.KEY.ARROW_UP);mappedKeyCodes.set(KEY_CODE.ARROW_RIGHT,exports.KEY.ARROW_RIGHT);mappedKeyCodes.set(KEY_CODE.ARROW_DOWN,exports.KEY.ARROW_DOWN);mappedKeyCodes.set(KEY_CODE.DELETE,exports.KEY.DELETE);mappedKeyCodes.set(KEY_CODE.ESCAPE,exports.KEY.ESCAPE);var navigationKeys=new Set;navigationKeys.add(exports.KEY.PAGE_UP);navigationKeys.add(exports.KEY.PAGE_DOWN);navigationKeys.add(exports.KEY.END);navigationKeys.add(exports.KEY.HOME);navigationKeys.add(exports.KEY.ARROW_LEFT);navigationKeys.add(exports.KEY.ARROW_UP);navigationKeys.add(exports.KEY.ARROW_RIGHT);navigationKeys.add(exports.KEY.ARROW_DOWN);function normalizeKey(evt){var key=evt.key;if(normalizedKeys.has(key)){return key}var mappedKey=mappedKeyCodes.get(evt.keyCode);if(mappedKey){return mappedKey}return exports.KEY.UNKNOWN}exports.normalizeKey=normalizeKey;function isNavigationEvent(evt){return navigationKeys.has(normalizeKey(evt))}exports.isNavigationEvent=isNavigationEvent},"./packages/mdc-tooltip/component.ts":
/*!*******************************************!*\
  !*** ./packages/mdc-tooltip/component.ts ***!
  \*******************************************/
/*! no static exports found */function(module,exports,__webpack_require__){"use strict";
/**
 * @license
 * Copyright 2020 Google Inc.
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */var __extends=this&&this.__extends||function(){var _extendStatics=function extendStatics(d,b){_extendStatics=Object.setPrototypeOf||{__proto__:[]}instanceof Array&&function(d,b){d.__proto__=b}||function(d,b){for(var p in b){if(b.hasOwnProperty(p))d[p]=b[p]}};return _extendStatics(d,b)};return function(d,b){_extendStatics(d,b);function __(){this.constructor=d}d.prototype=b===null?Object.create(b):(__.prototype=b.prototype,new __)}}();Object.defineProperty(exports,"__esModule",{value:true});var component_1=__webpack_require__(/*! @material/base/component */"./packages/mdc-base/component.ts");var foundation_1=__webpack_require__(/*! ./foundation */"./packages/mdc-tooltip/foundation.ts");var MDCTooltip=function(_super){__extends(MDCTooltip,_super);function MDCTooltip(){return _super!==null&&_super.apply(this,arguments)||this}MDCTooltip.attachTo=function(root){return new MDCTooltip(root)};MDCTooltip.prototype.initialSyncWithDOM=function(){var _this=this;var tooltipId=this.root.getAttribute("id");if(!tooltipId){throw new Error("MDCTooltip: Tooltip component must have an id.")}this.anchorElem=document.querySelector('[aria-describedby="'+tooltipId+'"]');if(!this.anchorElem){throw new Error("MDCTooltip: Tooltip component requries an [aria-describedby] anchor element.")}this.handleMouseEnter=function(){_this.foundation.handleAnchorMouseEnter()};this.handleFocus=function(){_this.foundation.handleAnchorFocus()};this.handleMouseLeave=function(){_this.foundation.handleAnchorMouseLeave()};this.handleBlur=function(){_this.foundation.handleAnchorBlur()};this.handleTransitionEnd=function(){_this.foundation.handleTransitionEnd()};this.anchorElem.addEventListener("mouseenter",this.handleMouseEnter);this.anchorElem.addEventListener("focus",this.handleFocus);this.anchorElem.addEventListener("mouseleave",this.handleMouseLeave);this.anchorElem.addEventListener("blur",this.handleBlur);this.listen("transitionend",this.handleTransitionEnd)};MDCTooltip.prototype.destroy=function(){if(this.anchorElem){this.anchorElem.removeEventListener("mouseenter",this.handleMouseEnter);this.anchorElem.removeEventListener("focus",this.handleFocus);this.anchorElem.removeEventListener("mouseleave",this.handleMouseLeave);this.anchorElem.removeEventListener("blur",this.handleBlur)}this.unlisten("transitionend",this.handleTransitionEnd);_super.prototype.destroy.call(this)};MDCTooltip.prototype.setTooltipPosition=function(pos){this.foundation.setTooltipPosition(pos)};MDCTooltip.prototype.setAnchorBoundaryType=function(type){this.foundation.setAnchorBoundaryType(type)};MDCTooltip.prototype.getDefaultFoundation=function(){var _this=this;var adapter={getAttribute:function getAttribute(attr){return _this.root.getAttribute(attr)},setAttribute:function setAttribute(attr,value){_this.root.setAttribute(attr,value)},addClass:function addClass(className){_this.root.classList.add(className)},removeClass:function removeClass(className){_this.root.classList.remove(className)},setStyleProperty:function setStyleProperty(propertyName,value){_this.root.style.setProperty(propertyName,value)},getViewportWidth:function getViewportWidth(){return window.innerWidth},getViewportHeight:function getViewportHeight(){return window.innerHeight},getTooltipSize:function getTooltipSize(){return{width:_this.root.offsetWidth,height:_this.root.offsetHeight}},getAnchorBoundingRect:function getAnchorBoundingRect(){return _this.anchorElem?_this.anchorElem.getBoundingClientRect():null},isRTL:function isRTL(){return getComputedStyle(_this.root).direction==="rtl"},registerDocumentEventHandler:function registerDocumentEventHandler(evt,handler){document.body.addEventListener(evt,handler)},deregisterDocumentEventHandler:function deregisterDocumentEventHandler(evt,handler){document.body.removeEventListener(evt,handler)}};return new foundation_1.MDCTooltipFoundation(adapter)};return MDCTooltip}(component_1.MDCComponent);exports.MDCTooltip=MDCTooltip},"./packages/mdc-tooltip/constants.ts":
/*!*******************************************!*\
  !*** ./packages/mdc-tooltip/constants.ts ***!
  \*******************************************/
/*! no static exports found */function(module,exports,__webpack_require__){"use strict";
/**
 * @license
 * Copyright 2020 Google Inc.
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */Object.defineProperty(exports,"__esModule",{value:true});var cssClasses={SHOWN:"mdc-tooltip--shown",SHOWING:"mdc-tooltip--showing",HIDE:"mdc-tooltip--hide"};exports.cssClasses=cssClasses;var numbers={BOUNDED_ANCHOR_GAP:4,UNBOUNDED_ANCHOR_GAP:8,MIN_VIEWPORT_TOOLTIP_THRESHOLD:32,HIDE_DELAY_MS:600};exports.numbers=numbers;var Position;(function(Position){Position[Position["DETECTED"]=0]="DETECTED";Position[Position["START"]=1]="START";Position[Position["CENTER"]=2]="CENTER";Position[Position["END"]=3]="END"})(Position||(Position={}));exports.Position=Position;var AnchorBoundaryType;(function(AnchorBoundaryType){AnchorBoundaryType[AnchorBoundaryType["BOUNDED"]=0]="BOUNDED";AnchorBoundaryType[AnchorBoundaryType["UNBOUNDED"]=1]="UNBOUNDED"})(AnchorBoundaryType||(AnchorBoundaryType={}));exports.AnchorBoundaryType=AnchorBoundaryType},"./packages/mdc-tooltip/foundation.ts":
/*!********************************************!*\
  !*** ./packages/mdc-tooltip/foundation.ts ***!
  \********************************************/
/*! no static exports found */function(module,exports,__webpack_require__){"use strict";
/**
 * @license
 * Copyright 2020 Google Inc.
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */var __extends=this&&this.__extends||function(){var _extendStatics=function extendStatics(d,b){_extendStatics=Object.setPrototypeOf||{__proto__:[]}instanceof Array&&function(d,b){d.__proto__=b}||function(d,b){for(var p in b){if(b.hasOwnProperty(p))d[p]=b[p]}};return _extendStatics(d,b)};return function(d,b){_extendStatics(d,b);function __(){this.constructor=d}d.prototype=b===null?Object.create(b):(__.prototype=b.prototype,new __)}}();var __assign=this&&this.__assign||function(){__assign=Object.assign||function(t){for(var s,i=1,n=arguments.length;i<n;i++){s=arguments[i];for(var p in s){if(Object.prototype.hasOwnProperty.call(s,p))t[p]=s[p]}}return t};return __assign.apply(this,arguments)};Object.defineProperty(exports,"__esModule",{value:true});var foundation_1=__webpack_require__(/*! @material/base/foundation */"./packages/mdc-base/foundation.ts");var keyboard_1=__webpack_require__(/*! @material/dom/keyboard */"./packages/mdc-dom/keyboard.ts");var constants_1=__webpack_require__(/*! ./constants */"./packages/mdc-tooltip/constants.ts");var SHOWN=constants_1.cssClasses.SHOWN,SHOWING=constants_1.cssClasses.SHOWING,HIDE=constants_1.cssClasses.HIDE;var MDCTooltipFoundation=function(_super){__extends(MDCTooltipFoundation,_super);function MDCTooltipFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCTooltipFoundation.defaultAdapter),adapter))||this;_this.isShown=false;_this.anchorGap=constants_1.numbers.BOUNDED_ANCHOR_GAP;_this.tooltipPos=constants_1.Position.DETECTED;_this.minViewportTooltipThreshold=constants_1.numbers.MIN_VIEWPORT_TOOLTIP_THRESHOLD;_this.hideDelayMs=constants_1.numbers.HIDE_DELAY_MS;_this.frameId=null;_this.hideTimeout=null;_this.documentClickHandler=function(){_this.handleClick()};_this.documentKeydownHandler=function(evt){_this.handleKeydown(evt)};return _this}Object.defineProperty(MDCTooltipFoundation,"defaultAdapter",{get:function get(){return{getAttribute:function getAttribute(){return null},setAttribute:function setAttribute(){return undefined},addClass:function addClass(){return undefined},removeClass:function removeClass(){return undefined},setStyleProperty:function setStyleProperty(){return undefined},getViewportWidth:function getViewportWidth(){return 0},getViewportHeight:function getViewportHeight(){return 0},getTooltipSize:function getTooltipSize(){return{width:0,height:0}},getAnchorBoundingRect:function getAnchorBoundingRect(){return{top:0,right:0,bottom:0,left:0,width:0,height:0}},isRTL:function isRTL(){return false},registerDocumentEventHandler:function registerDocumentEventHandler(){return undefined},deregisterDocumentEventHandler:function deregisterDocumentEventHandler(){return undefined}}},enumerable:true,configurable:true});MDCTooltipFoundation.prototype.handleAnchorMouseEnter=function(){this.show()};MDCTooltipFoundation.prototype.handleAnchorFocus=function(){this.show()};MDCTooltipFoundation.prototype.handleAnchorMouseLeave=function(){var _this=this;this.hideTimeout=setTimeout((function(){_this.hide()}),this.hideDelayMs)};MDCTooltipFoundation.prototype.handleAnchorBlur=function(){this.hide()};MDCTooltipFoundation.prototype.handleClick=function(){this.hide()};MDCTooltipFoundation.prototype.handleKeydown=function(evt){var key=keyboard_1.normalizeKey(evt);if(key===keyboard_1.KEY.ESCAPE){this.hide()}};MDCTooltipFoundation.prototype.show=function(){var _this=this;this.clearHideTimeout();if(this.isShown){return}this.isShown=true;this.adapter.setAttribute("aria-hidden","false");this.adapter.removeClass(HIDE);this.adapter.addClass(SHOWING);var _a=this.calculateTooltipDistance(),top=_a.top,left=_a.left;this.adapter.setStyleProperty("top",top+"px");this.adapter.setStyleProperty("left",left+"px");this.adapter.registerDocumentEventHandler("click",this.documentClickHandler);this.adapter.registerDocumentEventHandler("keydown",this.documentKeydownHandler);this.frameId=requestAnimationFrame((function(){_this.adapter.addClass(SHOWN)}))};MDCTooltipFoundation.prototype.hide=function(){this.clearHideTimeout();if(!this.isShown){return}if(this.frameId){cancelAnimationFrame(this.frameId)}this.isShown=false;this.adapter.setAttribute("aria-hidden","true");this.adapter.addClass(HIDE);this.adapter.removeClass(SHOWN);this.adapter.deregisterDocumentEventHandler("click",this.documentClickHandler);this.adapter.deregisterDocumentEventHandler("keydown",this.documentKeydownHandler)};MDCTooltipFoundation.prototype.handleTransitionEnd=function(){this.adapter.removeClass(SHOWING);this.adapter.removeClass(HIDE)};MDCTooltipFoundation.prototype.setTooltipPosition=function(pos){this.tooltipPos=pos};MDCTooltipFoundation.prototype.setAnchorBoundaryType=function(type){if(type===constants_1.AnchorBoundaryType.UNBOUNDED){this.anchorGap=constants_1.numbers.UNBOUNDED_ANCHOR_GAP}else{this.anchorGap=constants_1.numbers.BOUNDED_ANCHOR_GAP}};MDCTooltipFoundation.prototype.calculateTooltipDistance=function(){var anchorRect=this.adapter.getAnchorBoundingRect();var tooltipSize=this.adapter.getTooltipSize();if(!anchorRect){return{top:0,left:0}}var yPos=anchorRect.bottom+this.anchorGap;var startPos=anchorRect.left;var endPos=anchorRect.right-tooltipSize.width;var centerPos=anchorRect.left+(anchorRect.width-tooltipSize.width)/2;if(this.adapter.isRTL()){startPos=anchorRect.right-tooltipSize.width;endPos=anchorRect.left}var positionOptions=this.determineValidPositionOptions(centerPos,startPos,endPos);if(this.tooltipPos===constants_1.Position.START&&positionOptions.has(startPos)){return{top:yPos,left:startPos}}if(this.tooltipPos===constants_1.Position.END&&positionOptions.has(endPos)){return{top:yPos,left:endPos}}if(this.tooltipPos===constants_1.Position.CENTER&&positionOptions.has(centerPos)){return{top:yPos,left:centerPos}}if(positionOptions.has(centerPos)){return{top:yPos,left:centerPos}}if(positionOptions.has(startPos)){return{top:yPos,left:startPos}}if(positionOptions.has(endPos)){return{top:yPos,left:endPos}}return{top:yPos,left:centerPos}};MDCTooltipFoundation.prototype.determineValidPositionOptions=function(centerPos,startPos,endPos){var posWithinThreshold=new Set;var posWithinViewport=new Set;if(this.positionHonorsViewportThreshold(centerPos)){posWithinThreshold.add(centerPos)}else if(this.positionDoesntCollideWithViewport(centerPos)){posWithinViewport.add(centerPos)}if(this.positionHonorsViewportThreshold(startPos)){posWithinThreshold.add(startPos)}else if(this.positionDoesntCollideWithViewport(startPos)){posWithinViewport.add(startPos)}if(this.positionHonorsViewportThreshold(endPos)){posWithinThreshold.add(endPos)}else if(this.positionDoesntCollideWithViewport(endPos)){posWithinViewport.add(endPos)}return posWithinThreshold.size?posWithinThreshold:posWithinViewport};MDCTooltipFoundation.prototype.positionHonorsViewportThreshold=function(leftPos){var viewportWidth=this.adapter.getViewportWidth();var tooltipWidth=this.adapter.getTooltipSize().width;return leftPos+tooltipWidth<=viewportWidth-this.minViewportTooltipThreshold&&leftPos>=this.minViewportTooltipThreshold};MDCTooltipFoundation.prototype.positionDoesntCollideWithViewport=function(leftPos){var viewportWidth=this.adapter.getViewportWidth();var tooltipWidth=this.adapter.getTooltipSize().width;return leftPos+tooltipWidth<=viewportWidth&&leftPos>=0};MDCTooltipFoundation.prototype.clearHideTimeout=function(){if(this.hideTimeout){clearTimeout(this.hideTimeout);this.hideTimeout=null}};MDCTooltipFoundation.prototype.destroy=function(){if(this.frameId){cancelAnimationFrame(this.frameId);this.frameId=null}this.clearHideTimeout();this.adapter.removeClass(SHOWN);this.adapter.removeClass(SHOWING);this.adapter.removeClass(HIDE);this.adapter.deregisterDocumentEventHandler("click",this.documentClickHandler);this.adapter.deregisterDocumentEventHandler("keydown",this.documentKeydownHandler)};return MDCTooltipFoundation}(foundation_1.MDCFoundation);exports.MDCTooltipFoundation=MDCTooltipFoundation;exports.default=MDCTooltipFoundation},"./packages/mdc-tooltip/index.ts":
/*!***************************************!*\
  !*** ./packages/mdc-tooltip/index.ts ***!
  \***************************************/
/*! no static exports found */function(module,exports,__webpack_require__){"use strict";
/**
 * @license
 * Copyright 2020 Google Inc.
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */function __export(m){for(var p in m){if(!exports.hasOwnProperty(p))exports[p]=m[p]}}Object.defineProperty(exports,"__esModule",{value:true});__export(__webpack_require__(/*! ./component */"./packages/mdc-tooltip/component.ts"));__export(__webpack_require__(/*! ./foundation */"./packages/mdc-tooltip/foundation.ts"));__export(__webpack_require__(/*! ./constants */"./packages/mdc-tooltip/constants.ts"))}})}));