(()=>{var __webpack_modules__={18:(__unused_webpack___webpack_module__,__webpack_exports__,__webpack_require__)=>{"use strict";__webpack_require__.d(__webpack_exports__,{Z:()=>_toConsumableArray});function _arrayLikeToArray(arr,len){if(len==null||len>arr.length)len=arr.length;for(var i=0,arr2=new Array(len);i<len;i++){arr2[i]=arr[i]}return arr2}function _arrayWithoutHoles(arr){if(Array.isArray(arr))return _arrayLikeToArray(arr)}function _iterableToArray(iter){if(typeof Symbol!=="undefined"&&iter[Symbol.iterator]!=null||iter["@@iterator"]!=null)return Array.from(iter)}function _unsupportedIterableToArray(o,minLen){if(!o)return;if(typeof o==="string")return _arrayLikeToArray(o,minLen);var n=Object.prototype.toString.call(o).slice(8,-1);if(n==="Object"&&o.constructor)n=o.constructor.name;if(n==="Map"||n==="Set")return Array.from(o);if(n==="Arguments"||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(n))return _arrayLikeToArray(o,minLen)}function _nonIterableSpread(){throw new TypeError("Invalid attempt to spread non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.")}function _toConsumableArray(arr){return _arrayWithoutHoles(arr)||_iterableToArray(arr)||_unsupportedIterableToArray(arr)||_nonIterableSpread()}},757:(module,__unused_webpack_exports,__webpack_require__)=>{module.exports=__webpack_require__(666)},36:(__unused_webpack_module,__webpack_exports__,__webpack_require__)=>{"use strict";__webpack_require__.r(__webpack_exports__);__webpack_require__.d(__webpack_exports__,{apply:()=>apply});var _babel_runtime_helpers_toConsumableArray__WEBPACK_IMPORTED_MODULE_0__=__webpack_require__(18);var methodLookup={};function apply(calls){return calls.map((function(call){var identifier=call.identifier;var args=call.args;try{if(!(identifier in methodLookup)){methodLookup[identifier]=eval(identifier)}var f=methodLookup[identifier];if(args==null){f()}else{f.apply(void 0,(0,_babel_runtime_helpers_toConsumableArray__WEBPACK_IMPORTED_MODULE_0__.Z)(args))}return null}catch(e){return e.message}}))}},666:module=>{var runtime=function(exports){"use strict";var Op=Object.prototype;var hasOwn=Op.hasOwnProperty;var undefined;var $Symbol=typeof Symbol==="function"?Symbol:{};var iteratorSymbol=$Symbol.iterator||"@@iterator";var asyncIteratorSymbol=$Symbol.asyncIterator||"@@asyncIterator";var toStringTagSymbol=$Symbol.toStringTag||"@@toStringTag";function define(obj,key,value){Object.defineProperty(obj,key,{value:value,enumerable:true,configurable:true,writable:true});return obj[key]}try{define({},"")}catch(err){define=function(obj,key,value){return obj[key]=value}}function wrap(innerFn,outerFn,self,tryLocsList){var protoGenerator=outerFn&&outerFn.prototype instanceof Generator?outerFn:Generator;var generator=Object.create(protoGenerator.prototype);var context=new Context(tryLocsList||[]);generator._invoke=makeInvokeMethod(innerFn,self,context);return generator}exports.wrap=wrap;function tryCatch(fn,obj,arg){try{return{type:"normal",arg:fn.call(obj,arg)}}catch(err){return{type:"throw",arg:err}}}var GenStateSuspendedStart="suspendedStart";var GenStateSuspendedYield="suspendedYield";var GenStateExecuting="executing";var GenStateCompleted="completed";var ContinueSentinel={};function Generator(){}function GeneratorFunction(){}function GeneratorFunctionPrototype(){}var IteratorPrototype={};IteratorPrototype[iteratorSymbol]=function(){return this};var getProto=Object.getPrototypeOf;var NativeIteratorPrototype=getProto&&getProto(getProto(values([])));if(NativeIteratorPrototype&&NativeIteratorPrototype!==Op&&hasOwn.call(NativeIteratorPrototype,iteratorSymbol)){IteratorPrototype=NativeIteratorPrototype}var Gp=GeneratorFunctionPrototype.prototype=Generator.prototype=Object.create(IteratorPrototype);GeneratorFunction.prototype=Gp.constructor=GeneratorFunctionPrototype;GeneratorFunctionPrototype.constructor=GeneratorFunction;GeneratorFunction.displayName=define(GeneratorFunctionPrototype,toStringTagSymbol,"GeneratorFunction");function defineIteratorMethods(prototype){["next","throw","return"].forEach((function(method){define(prototype,method,(function(arg){return this._invoke(method,arg)}))}))}exports.isGeneratorFunction=function(genFun){var ctor=typeof genFun==="function"&&genFun.constructor;return ctor?ctor===GeneratorFunction||(ctor.displayName||ctor.name)==="GeneratorFunction":false};exports.mark=function(genFun){if(Object.setPrototypeOf){Object.setPrototypeOf(genFun,GeneratorFunctionPrototype)}else{genFun.__proto__=GeneratorFunctionPrototype;define(genFun,toStringTagSymbol,"GeneratorFunction")}genFun.prototype=Object.create(Gp);return genFun};exports.awrap=function(arg){return{__await:arg}};function AsyncIterator(generator,PromiseImpl){function invoke(method,arg,resolve,reject){var record=tryCatch(generator[method],generator,arg);if(record.type==="throw"){reject(record.arg)}else{var result=record.arg;var value=result.value;if(value&&typeof value==="object"&&hasOwn.call(value,"__await")){return PromiseImpl.resolve(value.__await).then((function(value){invoke("next",value,resolve,reject)}),(function(err){invoke("throw",err,resolve,reject)}))}return PromiseImpl.resolve(value).then((function(unwrapped){result.value=unwrapped;resolve(result)}),(function(error){return invoke("throw",error,resolve,reject)}))}}var previousPromise;function enqueue(method,arg){function callInvokeWithMethodAndArg(){return new PromiseImpl((function(resolve,reject){invoke(method,arg,resolve,reject)}))}return previousPromise=previousPromise?previousPromise.then(callInvokeWithMethodAndArg,callInvokeWithMethodAndArg):callInvokeWithMethodAndArg()}this._invoke=enqueue}defineIteratorMethods(AsyncIterator.prototype);AsyncIterator.prototype[asyncIteratorSymbol]=function(){return this};exports.AsyncIterator=AsyncIterator;exports.async=function(innerFn,outerFn,self,tryLocsList,PromiseImpl){if(PromiseImpl===void 0)PromiseImpl=Promise;var iter=new AsyncIterator(wrap(innerFn,outerFn,self,tryLocsList),PromiseImpl);return exports.isGeneratorFunction(outerFn)?iter:iter.next().then((function(result){return result.done?result.value:iter.next()}))};function makeInvokeMethod(innerFn,self,context){var state=GenStateSuspendedStart;return function invoke(method,arg){if(state===GenStateExecuting){throw new Error("Generator is already running")}if(state===GenStateCompleted){if(method==="throw"){throw arg}return doneResult()}context.method=method;context.arg=arg;while(true){var delegate=context.delegate;if(delegate){var delegateResult=maybeInvokeDelegate(delegate,context);if(delegateResult){if(delegateResult===ContinueSentinel)continue;return delegateResult}}if(context.method==="next"){context.sent=context._sent=context.arg}else if(context.method==="throw"){if(state===GenStateSuspendedStart){state=GenStateCompleted;throw context.arg}context.dispatchException(context.arg)}else if(context.method==="return"){context.abrupt("return",context.arg)}state=GenStateExecuting;var record=tryCatch(innerFn,self,context);if(record.type==="normal"){state=context.done?GenStateCompleted:GenStateSuspendedYield;if(record.arg===ContinueSentinel){continue}return{value:record.arg,done:context.done}}else if(record.type==="throw"){state=GenStateCompleted;context.method="throw";context.arg=record.arg}}}}function maybeInvokeDelegate(delegate,context){var method=delegate.iterator[context.method];if(method===undefined){context.delegate=null;if(context.method==="throw"){if(delegate.iterator["return"]){context.method="return";context.arg=undefined;maybeInvokeDelegate(delegate,context);if(context.method==="throw"){return ContinueSentinel}}context.method="throw";context.arg=new TypeError("The iterator does not provide a 'throw' method")}return ContinueSentinel}var record=tryCatch(method,delegate.iterator,context.arg);if(record.type==="throw"){context.method="throw";context.arg=record.arg;context.delegate=null;return ContinueSentinel}var info=record.arg;if(!info){context.method="throw";context.arg=new TypeError("iterator result is not an object");context.delegate=null;return ContinueSentinel}if(info.done){context[delegate.resultName]=info.value;context.next=delegate.nextLoc;if(context.method!=="return"){context.method="next";context.arg=undefined}}else{return info}context.delegate=null;return ContinueSentinel}defineIteratorMethods(Gp);define(Gp,toStringTagSymbol,"Generator");Gp[iteratorSymbol]=function(){return this};Gp.toString=function(){return"[object Generator]"};function pushTryEntry(locs){var entry={tryLoc:locs[0]};if(1 in locs){entry.catchLoc=locs[1]}if(2 in locs){entry.finallyLoc=locs[2];entry.afterLoc=locs[3]}this.tryEntries.push(entry)}function resetTryEntry(entry){var record=entry.completion||{};record.type="normal";delete record.arg;entry.completion=record}function Context(tryLocsList){this.tryEntries=[{tryLoc:"root"}];tryLocsList.forEach(pushTryEntry,this);this.reset(true)}exports.keys=function(object){var keys=[];for(var key in object){keys.push(key)}keys.reverse();return function next(){while(keys.length){var key=keys.pop();if(key in object){next.value=key;next.done=false;return next}}next.done=true;return next}};function values(iterable){if(iterable){var iteratorMethod=iterable[iteratorSymbol];if(iteratorMethod){return iteratorMethod.call(iterable)}if(typeof iterable.next==="function"){return iterable}if(!isNaN(iterable.length)){var i=-1,next=function next(){while(++i<iterable.length){if(hasOwn.call(iterable,i)){next.value=iterable[i];next.done=false;return next}}next.value=undefined;next.done=true;return next};return next.next=next}}return{next:doneResult}}exports.values=values;function doneResult(){return{value:undefined,done:true}}Context.prototype={constructor:Context,reset:function(skipTempReset){this.prev=0;this.next=0;this.sent=this._sent=undefined;this.done=false;this.delegate=null;this.method="next";this.arg=undefined;this.tryEntries.forEach(resetTryEntry);if(!skipTempReset){for(var name in this){if(name.charAt(0)==="t"&&hasOwn.call(this,name)&&!isNaN(+name.slice(1))){this[name]=undefined}}}},stop:function(){this.done=true;var rootEntry=this.tryEntries[0];var rootRecord=rootEntry.completion;if(rootRecord.type==="throw"){throw rootRecord.arg}return this.rval},dispatchException:function(exception){if(this.done){throw exception}var context=this;function handle(loc,caught){record.type="throw";record.arg=exception;context.next=loc;if(caught){context.method="next";context.arg=undefined}return!!caught}for(var i=this.tryEntries.length-1;i>=0;--i){var entry=this.tryEntries[i];var record=entry.completion;if(entry.tryLoc==="root"){return handle("end")}if(entry.tryLoc<=this.prev){var hasCatch=hasOwn.call(entry,"catchLoc");var hasFinally=hasOwn.call(entry,"finallyLoc");if(hasCatch&&hasFinally){if(this.prev<entry.catchLoc){return handle(entry.catchLoc,true)}else if(this.prev<entry.finallyLoc){return handle(entry.finallyLoc)}}else if(hasCatch){if(this.prev<entry.catchLoc){return handle(entry.catchLoc,true)}}else if(hasFinally){if(this.prev<entry.finallyLoc){return handle(entry.finallyLoc)}}else{throw new Error("try statement without catch or finally")}}}},abrupt:function(type,arg){for(var i=this.tryEntries.length-1;i>=0;--i){var entry=this.tryEntries[i];if(entry.tryLoc<=this.prev&&hasOwn.call(entry,"finallyLoc")&&this.prev<entry.finallyLoc){var finallyEntry=entry;break}}if(finallyEntry&&(type==="break"||type==="continue")&&finallyEntry.tryLoc<=arg&&arg<=finallyEntry.finallyLoc){finallyEntry=null}var record=finallyEntry?finallyEntry.completion:{};record.type=type;record.arg=arg;if(finallyEntry){this.method="next";this.next=finallyEntry.finallyLoc;return ContinueSentinel}return this.complete(record)},complete:function(record,afterLoc){if(record.type==="throw"){throw record.arg}if(record.type==="break"||record.type==="continue"){this.next=record.arg}else if(record.type==="return"){this.rval=this.arg=record.arg;this.method="return";this.next="end"}else if(record.type==="normal"&&afterLoc){this.next=afterLoc}return ContinueSentinel},finish:function(finallyLoc){for(var i=this.tryEntries.length-1;i>=0;--i){var entry=this.tryEntries[i];if(entry.finallyLoc===finallyLoc){this.complete(entry.completion,entry.afterLoc);resetTryEntry(entry);return ContinueSentinel}}},catch:function(tryLoc){for(var i=this.tryEntries.length-1;i>=0;--i){var entry=this.tryEntries[i];if(entry.tryLoc===tryLoc){var record=entry.completion;if(record.type==="throw"){var thrown=record.arg;resetTryEntry(entry)}return thrown}}throw new Error("illegal catch attempt")},delegateYield:function(iterable,resultName,nextLoc){this.delegate={iterator:values(iterable),resultName:resultName,nextLoc:nextLoc};if(this.method==="next"){this.arg=undefined}return ContinueSentinel}};return exports}(true?module.exports:0);try{regeneratorRuntime=runtime}catch(accidentalStrictMode){Function("r","regeneratorRuntime = r")(runtime)}}};var __webpack_module_cache__={};function __webpack_require__(moduleId){var cachedModule=__webpack_module_cache__[moduleId];if(cachedModule!==undefined){return cachedModule.exports}var module=__webpack_module_cache__[moduleId]={exports:{}};__webpack_modules__[moduleId](module,module.exports,__webpack_require__);return module.exports}(()=>{__webpack_require__.n=module=>{var getter=module&&module.__esModule?()=>module["default"]:()=>module;__webpack_require__.d(getter,{a:getter});return getter}})();(()=>{__webpack_require__.d=(exports,definition)=>{for(var key in definition){if(__webpack_require__.o(definition,key)&&!__webpack_require__.o(exports,key)){Object.defineProperty(exports,key,{enumerable:true,get:definition[key]})}}}})();(()=>{__webpack_require__.g=function(){if(typeof globalThis==="object")return globalThis;try{return this||new Function("return this")()}catch(e){if(typeof window==="object")return window}}()})();(()=>{__webpack_require__.o=(obj,prop)=>Object.prototype.hasOwnProperty.call(obj,prop)})();(()=>{__webpack_require__.r=exports=>{if(typeof Symbol!=="undefined"&&Symbol.toStringTag){Object.defineProperty(exports,Symbol.toStringTag,{value:"Module"})}Object.defineProperty(exports,"__esModule",{value:true})}})();var __webpack_exports__={};(()=>{"use strict";var MBAutocompleteTextField_namespaceObject={};__webpack_require__.r(MBAutocompleteTextField_namespaceObject);__webpack_require__.d(MBAutocompleteTextField_namespaceObject,{close:()=>MBAutocompleteTextField_close,init:()=>init,open:()=>MBAutocompleteTextField_open,setDisabled:()=>setDisabled,setValue:()=>setValue});var MBBladeSet_namespaceObject={};__webpack_require__.r(MBBladeSet_namespaceObject);__webpack_require__.d(MBBladeSet_namespaceObject,{closeBlade:()=>closeBlade,openBlade:()=>openBlade});var MBButton_namespaceObject={};__webpack_require__.r(MBButton_namespaceObject);__webpack_require__.d(MBButton_namespaceObject,{init:()=>MBButton_init});var MBCard_namespaceObject={};__webpack_require__.r(MBCard_namespaceObject);__webpack_require__.d(MBCard_namespaceObject,{init:()=>MBCard_init});var MBChipsSelectMulti_namespaceObject={};__webpack_require__.r(MBChipsSelectMulti_namespaceObject);__webpack_require__.d(MBChipsSelectMulti_namespaceObject,{init:()=>MBChipsSelectMulti_init,setDisabled:()=>MBChipsSelectMulti_setDisabled,setSelected:()=>setSelected});var MBCheckbox_namespaceObject={};__webpack_require__.r(MBCheckbox_namespaceObject);__webpack_require__.d(MBCheckbox_namespaceObject,{init:()=>MBCheckbox_init,setChecked:()=>setChecked,setDisabled:()=>MBCheckbox_setDisabled,setIndeterminate:()=>setIndeterminate});var MBCircularProgress_namespaceObject={};__webpack_require__.r(MBCircularProgress_namespaceObject);__webpack_require__.d(MBCircularProgress_namespaceObject,{init:()=>MBCircularProgress_init,setProgress:()=>setProgress});var MBDataTable_namespaceObject={};__webpack_require__.r(MBDataTable_namespaceObject);__webpack_require__.d(MBDataTable_namespaceObject,{init:()=>MBDataTable_init,setProgress:()=>MBDataTable_setProgress});var MBDatePicker_namespaceObject={};__webpack_require__.r(MBDatePicker_namespaceObject);__webpack_require__.d(MBDatePicker_namespaceObject,{init:()=>MBDatePicker_init,listItemClick:()=>listItemClick,scrollToYear:()=>scrollToYear,setDisabled:()=>MBDatePicker_setDisabled});var MBDialog_namespaceObject={};__webpack_require__.r(MBDialog_namespaceObject);__webpack_require__.d(MBDialog_namespaceObject,{hide:()=>hide,show:()=>show});var MBDrawer_namespaceObject={};__webpack_require__.r(MBDrawer_namespaceObject);__webpack_require__.d(MBDrawer_namespaceObject,{init:()=>MBDrawer_init,toggle:()=>toggle});var MBFloatingActionButton_namespaceObject={};__webpack_require__.r(MBFloatingActionButton_namespaceObject);__webpack_require__.d(MBFloatingActionButton_namespaceObject,{init:()=>MBFloatingActionButton_init,setExited:()=>setExited});var MBGrid_namespaceObject={};__webpack_require__.r(MBGrid_namespaceObject);__webpack_require__.d(MBGrid_namespaceObject,{getScrollBarWidth:()=>getScrollBarWidth,getTextWidths:()=>getTextWidths,syncScrollByID:()=>syncScrollByID,syncScrollByRef:()=>syncScrollByRef});var MBIconButton_namespaceObject={};__webpack_require__.r(MBIconButton_namespaceObject);__webpack_require__.d(MBIconButton_namespaceObject,{init:()=>MBIconButton_init});var MBIconButtonToggle_namespaceObject={};__webpack_require__.r(MBIconButtonToggle_namespaceObject);__webpack_require__.d(MBIconButtonToggle_namespaceObject,{click:()=>click,init:()=>MBIconButtonToggle_init,setOn:()=>setOn});var MBLinearProgress_namespaceObject={};__webpack_require__.r(MBLinearProgress_namespaceObject);__webpack_require__.d(MBLinearProgress_namespaceObject,{init:()=>MBLinearProgress_init,restartAnimation:()=>restartAnimation,setProgress:()=>MBLinearProgress_setProgress});var MBList_namespaceObject={};__webpack_require__.r(MBList_namespaceObject);__webpack_require__.d(MBList_namespaceObject,{init:()=>MBList_init});var MBMenu_namespaceObject={};__webpack_require__.r(MBMenu_namespaceObject);__webpack_require__.d(MBMenu_namespaceObject,{hide:()=>MBMenu_hide,init:()=>MBMenu_init,show:()=>MBMenu_show});var MBMenuSurface_namespaceObject={};__webpack_require__.r(MBMenuSurface_namespaceObject);__webpack_require__.d(MBMenuSurface_namespaceObject,{hide:()=>MBMenuSurface_hide,init:()=>MBMenuSurface_init,show:()=>MBMenuSurface_show});var MBRadioButton_namespaceObject={};__webpack_require__.r(MBRadioButton_namespaceObject);__webpack_require__.d(MBRadioButton_namespaceObject,{init:()=>MBRadioButton_init,setChecked:()=>MBRadioButton_setChecked,setDisabled:()=>MBRadioButton_setDisabled});var MBSegmentedButtonMulti_namespaceObject={};__webpack_require__.r(MBSegmentedButtonMulti_namespaceObject);__webpack_require__.d(MBSegmentedButtonMulti_namespaceObject,{init:()=>MBSegmentedButtonMulti_init,setDisabled:()=>MBSegmentedButtonMulti_setDisabled,setSelected:()=>MBSegmentedButtonMulti_setSelected});var MBSelect_namespaceObject={};__webpack_require__.r(MBSelect_namespaceObject);__webpack_require__.d(MBSelect_namespaceObject,{init:()=>MBSelect_init,setDisabled:()=>MBSelect_setDisabled,setIndex:()=>setIndex});var MBSlider_namespaceObject={};__webpack_require__.r(MBSlider_namespaceObject);__webpack_require__.d(MBSlider_namespaceObject,{init:()=>MBSlider_init,setDisabled:()=>MBSlider_setDisabled,setValue:()=>MBSlider_setValue});var MBSnackbar_namespaceObject={};__webpack_require__.r(MBSnackbar_namespaceObject);__webpack_require__.d(MBSnackbar_namespaceObject,{init:()=>MBSnackbar_init});var MBSwitch_namespaceObject={};__webpack_require__.r(MBSwitch_namespaceObject);__webpack_require__.d(MBSwitch_namespaceObject,{init:()=>MBSwitch_init,setChecked:()=>MBSwitch_setChecked,setDisabled:()=>MBSwitch_setDisabled});var MBTabBar_namespaceObject={};__webpack_require__.r(MBTabBar_namespaceObject);__webpack_require__.d(MBTabBar_namespaceObject,{activateTab:()=>activateTab,init:()=>MBTabBar_init});var MBTextField_namespaceObject={};__webpack_require__.r(MBTextField_namespaceObject);__webpack_require__.d(MBTextField_namespaceObject,{init:()=>MBTextField_init,setDisabled:()=>MBTextField_setDisabled,setHelperText:()=>setHelperText,setType:()=>setType,setValue:()=>MBTextField_setValue});var MBTooltip_namespaceObject={};__webpack_require__.r(MBTooltip_namespaceObject);__webpack_require__.d(MBTooltip_namespaceObject,{init:()=>MBTooltip_init,numbers:()=>tooltip_constants_numbers});var MBTopAppBar_namespaceObject={};__webpack_require__.r(MBTopAppBar_namespaceObject);__webpack_require__.d(MBTopAppBar_namespaceObject,{init:()=>MBTopAppBar_init});
/*! *****************************************************************************
Copyright (c) Microsoft Corporation.

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH
REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY
AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT,
INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM
LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR
OTHER TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR
PERFORMANCE OF THIS SOFTWARE.
***************************************************************************** */
var extendStatics=function(d,b){extendStatics=Object.setPrototypeOf||{__proto__:[]}instanceof Array&&function(d,b){d.__proto__=b}||function(d,b){for(var p in b)if(b.hasOwnProperty(p))d[p]=b[p]};return extendStatics(d,b)};function __extends(d,b){extendStatics(d,b);function __(){this.constructor=d}d.prototype=b===null?Object.create(b):(__.prototype=b.prototype,new __)}var __assign=function(){__assign=Object.assign||function __assign(t){for(var s,i=1,n=arguments.length;i<n;i++){s=arguments[i];for(var p in s)if(Object.prototype.hasOwnProperty.call(s,p))t[p]=s[p]}return t};return __assign.apply(this,arguments)};function __rest(s,e){var t={};for(var p in s)if(Object.prototype.hasOwnProperty.call(s,p)&&e.indexOf(p)<0)t[p]=s[p];if(s!=null&&typeof Object.getOwnPropertySymbols==="function")for(var i=0,p=Object.getOwnPropertySymbols(s);i<p.length;i++){if(e.indexOf(p[i])<0&&Object.prototype.propertyIsEnumerable.call(s,p[i]))t[p[i]]=s[p[i]]}return t}function __decorate(decorators,target,key,desc){var c=arguments.length,r=c<3?target:desc===null?desc=Object.getOwnPropertyDescriptor(target,key):desc,d;if(typeof Reflect==="object"&&typeof Reflect.decorate==="function")r=Reflect.decorate(decorators,target,key,desc);else for(var i=decorators.length-1;i>=0;i--)if(d=decorators[i])r=(c<3?d(r):c>3?d(target,key,r):d(target,key))||r;return c>3&&r&&Object.defineProperty(target,key,r),r}function __param(paramIndex,decorator){return function(target,key){decorator(target,key,paramIndex)}}function __metadata(metadataKey,metadataValue){if(typeof Reflect==="object"&&typeof Reflect.metadata==="function")return Reflect.metadata(metadataKey,metadataValue)}function __awaiter(thisArg,_arguments,P,generator){function adopt(value){return value instanceof P?value:new P((function(resolve){resolve(value)}))}return new(P||(P=Promise))((function(resolve,reject){function fulfilled(value){try{step(generator.next(value))}catch(e){reject(e)}}function rejected(value){try{step(generator["throw"](value))}catch(e){reject(e)}}function step(result){result.done?resolve(result.value):adopt(result.value).then(fulfilled,rejected)}step((generator=generator.apply(thisArg,_arguments||[])).next())}))}function __generator(thisArg,body){var _={label:0,sent:function(){if(t[0]&1)throw t[1];return t[1]},trys:[],ops:[]},f,y,t,g;return g={next:verb(0),throw:verb(1),return:verb(2)},typeof Symbol==="function"&&(g[Symbol.iterator]=function(){return this}),g;function verb(n){return function(v){return step([n,v])}}function step(op){if(f)throw new TypeError("Generator is already executing.");while(_)try{if(f=1,y&&(t=op[0]&2?y["return"]:op[0]?y["throw"]||((t=y["return"])&&t.call(y),0):y.next)&&!(t=t.call(y,op[1])).done)return t;if(y=0,t)op=[op[0]&2,t.value];switch(op[0]){case 0:case 1:t=op;break;case 4:_.label++;return{value:op[1],done:false};case 5:_.label++;y=op[1];op=[0];continue;case 7:op=_.ops.pop();_.trys.pop();continue;default:if(!(t=_.trys,t=t.length>0&&t[t.length-1])&&(op[0]===6||op[0]===2)){_=0;continue}if(op[0]===3&&(!t||op[1]>t[0]&&op[1]<t[3])){_.label=op[1];break}if(op[0]===6&&_.label<t[1]){_.label=t[1];t=op;break}if(t&&_.label<t[2]){_.label=t[2];_.ops.push(op);break}if(t[2])_.ops.pop();_.trys.pop();continue}op=body.call(thisArg,_)}catch(e){op=[6,e];y=0}finally{f=t=0}if(op[0]&5)throw op[1];return{value:op[0]?op[1]:void 0,done:true}}}function __createBinding(o,m,k,k2){if(k2===undefined)k2=k;o[k2]=m[k]}function __exportStar(m,exports){for(var p in m)if(p!=="default"&&!exports.hasOwnProperty(p))exports[p]=m[p]}function __values(o){var s=typeof Symbol==="function"&&Symbol.iterator,m=s&&o[s],i=0;if(m)return m.call(o);if(o&&typeof o.length==="number")return{next:function(){if(o&&i>=o.length)o=void 0;return{value:o&&o[i++],done:!o}}};throw new TypeError(s?"Object is not iterable.":"Symbol.iterator is not defined.")}function __read(o,n){var m=typeof Symbol==="function"&&o[Symbol.iterator];if(!m)return o;var i=m.call(o),r,ar=[],e;try{while((n===void 0||n-- >0)&&!(r=i.next()).done)ar.push(r.value)}catch(error){e={error:error}}finally{try{if(r&&!r.done&&(m=i["return"]))m.call(i)}finally{if(e)throw e.error}}return ar}function __spread(){for(var ar=[],i=0;i<arguments.length;i++)ar=ar.concat(__read(arguments[i]));return ar}function __spreadArrays(){for(var s=0,i=0,il=arguments.length;i<il;i++)s+=arguments[i].length;for(var r=Array(s),k=0,i=0;i<il;i++)for(var a=arguments[i],j=0,jl=a.length;j<jl;j++,k++)r[k]=a[j];return r}function __await(v){return this instanceof __await?(this.v=v,this):new __await(v)}function __asyncGenerator(thisArg,_arguments,generator){if(!Symbol.asyncIterator)throw new TypeError("Symbol.asyncIterator is not defined.");var g=generator.apply(thisArg,_arguments||[]),i,q=[];return i={},verb("next"),verb("throw"),verb("return"),i[Symbol.asyncIterator]=function(){return this},i;function verb(n){if(g[n])i[n]=function(v){return new Promise((function(a,b){q.push([n,v,a,b])>1||resume(n,v)}))}}function resume(n,v){try{step(g[n](v))}catch(e){settle(q[0][3],e)}}function step(r){r.value instanceof __await?Promise.resolve(r.value.v).then(fulfill,reject):settle(q[0][2],r)}function fulfill(value){resume("next",value)}function reject(value){resume("throw",value)}function settle(f,v){if(f(v),q.shift(),q.length)resume(q[0][0],q[0][1])}}function __asyncDelegator(o){var i,p;return i={},verb("next"),verb("throw",(function(e){throw e})),verb("return"),i[Symbol.iterator]=function(){return this},i;function verb(n,f){i[n]=o[n]?function(v){return(p=!p)?{value:__await(o[n](v)),done:n==="return"}:f?f(v):v}:f}}function __asyncValues(o){if(!Symbol.asyncIterator)throw new TypeError("Symbol.asyncIterator is not defined.");var m=o[Symbol.asyncIterator],i;return m?m.call(o):(o=typeof __values==="function"?__values(o):o[Symbol.iterator](),i={},verb("next"),verb("throw"),verb("return"),i[Symbol.asyncIterator]=function(){return this},i);function verb(n){i[n]=o[n]&&function(v){return new Promise((function(resolve,reject){v=o[n](v),settle(resolve,reject,v.done,v.value)}))}}function settle(resolve,reject,d,v){Promise.resolve(v).then((function(v){resolve({value:v,done:d})}),reject)}}function __makeTemplateObject(cooked,raw){if(Object.defineProperty){Object.defineProperty(cooked,"raw",{value:raw})}else{cooked.raw=raw}return cooked}function __importStar(mod){if(mod&&mod.__esModule)return mod;var result={};if(mod!=null)for(var k in mod)if(Object.hasOwnProperty.call(mod,k))result[k]=mod[k];result.default=mod;return result}function __importDefault(mod){return mod&&mod.__esModule?mod:{default:mod}}function __classPrivateFieldGet(receiver,privateMap){if(!privateMap.has(receiver)){throw new TypeError("attempted to get private field on non-instance")}return privateMap.get(receiver)}function __classPrivateFieldSet(receiver,privateMap,value){if(!privateMap.has(receiver)){throw new TypeError("attempted to set private field on non-instance")}privateMap.set(receiver,value);return value}
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
 */
var MDCFoundation=function(){function MDCFoundation(adapter){if(adapter===void 0){adapter={}}this.adapter=adapter}Object.defineProperty(MDCFoundation,"cssClasses",{get:function(){return{}},enumerable:true,configurable:true});Object.defineProperty(MDCFoundation,"strings",{get:function(){return{}},enumerable:true,configurable:true});Object.defineProperty(MDCFoundation,"numbers",{get:function(){return{}},enumerable:true,configurable:true});Object.defineProperty(MDCFoundation,"defaultAdapter",{get:function(){return{}},enumerable:true,configurable:true});MDCFoundation.prototype.init=function(){};MDCFoundation.prototype.destroy=function(){};return MDCFoundation}();const foundation=null&&MDCFoundation;
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
 */
var MDCComponent=function(){function MDCComponent(root,foundation){var args=[];for(var _i=2;_i<arguments.length;_i++){args[_i-2]=arguments[_i]}this.root=root;this.initialize.apply(this,__spread(args));this.foundation=foundation===undefined?this.getDefaultFoundation():foundation;this.foundation.init();this.initialSyncWithDOM()}MDCComponent.attachTo=function(root){return new MDCComponent(root,new MDCFoundation({}))};MDCComponent.prototype.initialize=function(){var _args=[];for(var _i=0;_i<arguments.length;_i++){_args[_i]=arguments[_i]}};MDCComponent.prototype.getDefaultFoundation=function(){throw new Error("Subclasses must override getDefaultFoundation to return a properly configured "+"foundation class")};MDCComponent.prototype.initialSyncWithDOM=function(){};MDCComponent.prototype.destroy=function(){this.foundation.destroy()};MDCComponent.prototype.listen=function(evtType,handler,options){this.root.addEventListener(evtType,handler,options)};MDCComponent.prototype.unlisten=function(evtType,handler,options){this.root.removeEventListener(evtType,handler,options)};MDCComponent.prototype.emit=function(evtType,evtData,shouldBubble){if(shouldBubble===void 0){shouldBubble=false}var evt;if(typeof CustomEvent==="function"){evt=new CustomEvent(evtType,{bubbles:shouldBubble,detail:evtData})}else{evt=document.createEvent("CustomEvent");evt.initCustomEvent(evtType,shouldBubble,false,evtData)}this.root.dispatchEvent(evt)};return MDCComponent}();const component=null&&MDCComponent;
/**
 * @license
 * Copyright 2019 Google Inc.
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
 */
function applyPassive(globalObj){if(globalObj===void 0){globalObj=window}return supportsPassiveOption(globalObj)?{passive:true}:false}function supportsPassiveOption(globalObj){if(globalObj===void 0){globalObj=window}var passiveSupported=false;try{var options={get passive(){passiveSupported=true;return false}};var handler=function(){};globalObj.document.addEventListener("test",handler,options);globalObj.document.removeEventListener("test",handler,options)}catch(err){passiveSupported=false}return passiveSupported}
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
function closest(element,selector){if(element.closest){return element.closest(selector)}var el=element;while(el){if(matches(el,selector)){return el}el=el.parentElement}return null}function matches(element,selector){var nativeMatches=element.matches||element.webkitMatchesSelector||element.msMatchesSelector;return nativeMatches.call(element,selector)}function estimateScrollWidth(element){var htmlEl=element;if(htmlEl.offsetParent!==null){return htmlEl.scrollWidth}var clone=htmlEl.cloneNode(true);clone.style.setProperty("position","absolute");clone.style.setProperty("transform","translate(-9999px, -9999px)");document.documentElement.appendChild(clone);var scrollWidth=clone.scrollWidth;document.documentElement.removeChild(clone);return scrollWidth}
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
 */
var cssClasses={LABEL_FLOAT_ABOVE:"mdc-floating-label--float-above",LABEL_REQUIRED:"mdc-floating-label--required",LABEL_SHAKE:"mdc-floating-label--shake",ROOT:"mdc-floating-label"};
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
 */
var MDCFloatingLabelFoundation=function(_super){__extends(MDCFloatingLabelFoundation,_super);function MDCFloatingLabelFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCFloatingLabelFoundation.defaultAdapter),adapter))||this;_this.shakeAnimationEndHandler_=function(){return _this.handleShakeAnimationEnd_()};return _this}Object.defineProperty(MDCFloatingLabelFoundation,"cssClasses",{get:function(){return cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCFloatingLabelFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},removeClass:function(){return undefined},getWidth:function(){return 0},registerInteractionHandler:function(){return undefined},deregisterInteractionHandler:function(){return undefined}}},enumerable:true,configurable:true});MDCFloatingLabelFoundation.prototype.init=function(){this.adapter.registerInteractionHandler("animationend",this.shakeAnimationEndHandler_)};MDCFloatingLabelFoundation.prototype.destroy=function(){this.adapter.deregisterInteractionHandler("animationend",this.shakeAnimationEndHandler_)};MDCFloatingLabelFoundation.prototype.getWidth=function(){return this.adapter.getWidth()};MDCFloatingLabelFoundation.prototype.shake=function(shouldShake){var LABEL_SHAKE=MDCFloatingLabelFoundation.cssClasses.LABEL_SHAKE;if(shouldShake){this.adapter.addClass(LABEL_SHAKE)}else{this.adapter.removeClass(LABEL_SHAKE)}};MDCFloatingLabelFoundation.prototype.float=function(shouldFloat){var _a=MDCFloatingLabelFoundation.cssClasses,LABEL_FLOAT_ABOVE=_a.LABEL_FLOAT_ABOVE,LABEL_SHAKE=_a.LABEL_SHAKE;if(shouldFloat){this.adapter.addClass(LABEL_FLOAT_ABOVE)}else{this.adapter.removeClass(LABEL_FLOAT_ABOVE);this.adapter.removeClass(LABEL_SHAKE)}};MDCFloatingLabelFoundation.prototype.setRequired=function(isRequired){var LABEL_REQUIRED=MDCFloatingLabelFoundation.cssClasses.LABEL_REQUIRED;if(isRequired){this.adapter.addClass(LABEL_REQUIRED)}else{this.adapter.removeClass(LABEL_REQUIRED)}};MDCFloatingLabelFoundation.prototype.handleShakeAnimationEnd_=function(){var LABEL_SHAKE=MDCFloatingLabelFoundation.cssClasses.LABEL_SHAKE;this.adapter.removeClass(LABEL_SHAKE)};return MDCFloatingLabelFoundation}(MDCFoundation);const floating_label_foundation=null&&MDCFloatingLabelFoundation;
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
 */
var MDCFloatingLabel=function(_super){__extends(MDCFloatingLabel,_super);function MDCFloatingLabel(){return _super!==null&&_super.apply(this,arguments)||this}MDCFloatingLabel.attachTo=function(root){return new MDCFloatingLabel(root)};MDCFloatingLabel.prototype.shake=function(shouldShake){this.foundation.shake(shouldShake)};MDCFloatingLabel.prototype.float=function(shouldFloat){this.foundation.float(shouldFloat)};MDCFloatingLabel.prototype.setRequired=function(isRequired){this.foundation.setRequired(isRequired)};MDCFloatingLabel.prototype.getWidth=function(){return this.foundation.getWidth()};MDCFloatingLabel.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClass:function(className){return _this.root.classList.add(className)},removeClass:function(className){return _this.root.classList.remove(className)},getWidth:function(){return estimateScrollWidth(_this.root)},registerInteractionHandler:function(evtType,handler){return _this.listen(evtType,handler)},deregisterInteractionHandler:function(evtType,handler){return _this.unlisten(evtType,handler)}};return new MDCFloatingLabelFoundation(adapter)};return MDCFloatingLabel}(MDCComponent);
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var constants_cssClasses={LINE_RIPPLE_ACTIVE:"mdc-line-ripple--active",LINE_RIPPLE_DEACTIVATING:"mdc-line-ripple--deactivating"};
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCLineRippleFoundation=function(_super){__extends(MDCLineRippleFoundation,_super);function MDCLineRippleFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCLineRippleFoundation.defaultAdapter),adapter))||this;_this.transitionEndHandler_=function(evt){return _this.handleTransitionEnd(evt)};return _this}Object.defineProperty(MDCLineRippleFoundation,"cssClasses",{get:function(){return constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCLineRippleFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},removeClass:function(){return undefined},hasClass:function(){return false},setStyle:function(){return undefined},registerEventHandler:function(){return undefined},deregisterEventHandler:function(){return undefined}}},enumerable:true,configurable:true});MDCLineRippleFoundation.prototype.init=function(){this.adapter.registerEventHandler("transitionend",this.transitionEndHandler_)};MDCLineRippleFoundation.prototype.destroy=function(){this.adapter.deregisterEventHandler("transitionend",this.transitionEndHandler_)};MDCLineRippleFoundation.prototype.activate=function(){this.adapter.removeClass(constants_cssClasses.LINE_RIPPLE_DEACTIVATING);this.adapter.addClass(constants_cssClasses.LINE_RIPPLE_ACTIVE)};MDCLineRippleFoundation.prototype.setRippleCenter=function(xCoordinate){this.adapter.setStyle("transform-origin",xCoordinate+"px center")};MDCLineRippleFoundation.prototype.deactivate=function(){this.adapter.addClass(constants_cssClasses.LINE_RIPPLE_DEACTIVATING)};MDCLineRippleFoundation.prototype.handleTransitionEnd=function(evt){var isDeactivating=this.adapter.hasClass(constants_cssClasses.LINE_RIPPLE_DEACTIVATING);if(evt.propertyName==="opacity"){if(isDeactivating){this.adapter.removeClass(constants_cssClasses.LINE_RIPPLE_ACTIVE);this.adapter.removeClass(constants_cssClasses.LINE_RIPPLE_DEACTIVATING)}}};return MDCLineRippleFoundation}(MDCFoundation);const line_ripple_foundation=null&&MDCLineRippleFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCLineRipple=function(_super){__extends(MDCLineRipple,_super);function MDCLineRipple(){return _super!==null&&_super.apply(this,arguments)||this}MDCLineRipple.attachTo=function(root){return new MDCLineRipple(root)};MDCLineRipple.prototype.activate=function(){this.foundation.activate()};MDCLineRipple.prototype.deactivate=function(){this.foundation.deactivate()};MDCLineRipple.prototype.setRippleCenter=function(xCoordinate){this.foundation.setRippleCenter(xCoordinate)};MDCLineRipple.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClass:function(className){return _this.root.classList.add(className)},removeClass:function(className){return _this.root.classList.remove(className)},hasClass:function(className){return _this.root.classList.contains(className)},setStyle:function(propertyName,value){return _this.root.style.setProperty(propertyName,value)},registerEventHandler:function(evtType,handler){return _this.listen(evtType,handler)},deregisterEventHandler:function(evtType,handler){return _this.unlisten(evtType,handler)}};return new MDCLineRippleFoundation(adapter)};return MDCLineRipple}(MDCComponent);
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var strings={NOTCH_ELEMENT_SELECTOR:".mdc-notched-outline__notch"};var numbers={NOTCH_ELEMENT_PADDING:8};var notched_outline_constants_cssClasses={NO_LABEL:"mdc-notched-outline--no-label",OUTLINE_NOTCHED:"mdc-notched-outline--notched",OUTLINE_UPGRADED:"mdc-notched-outline--upgraded"};
/**
 * @license
 * Copyright 2017 Google Inc.
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
 */
var MDCNotchedOutlineFoundation=function(_super){__extends(MDCNotchedOutlineFoundation,_super);function MDCNotchedOutlineFoundation(adapter){return _super.call(this,__assign(__assign({},MDCNotchedOutlineFoundation.defaultAdapter),adapter))||this}Object.defineProperty(MDCNotchedOutlineFoundation,"strings",{get:function(){return strings},enumerable:true,configurable:true});Object.defineProperty(MDCNotchedOutlineFoundation,"cssClasses",{get:function(){return notched_outline_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCNotchedOutlineFoundation,"numbers",{get:function(){return numbers},enumerable:true,configurable:true});Object.defineProperty(MDCNotchedOutlineFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},removeClass:function(){return undefined},setNotchWidthProperty:function(){return undefined},removeNotchWidthProperty:function(){return undefined}}},enumerable:true,configurable:true});MDCNotchedOutlineFoundation.prototype.notch=function(notchWidth){var OUTLINE_NOTCHED=MDCNotchedOutlineFoundation.cssClasses.OUTLINE_NOTCHED;if(notchWidth>0){notchWidth+=numbers.NOTCH_ELEMENT_PADDING}this.adapter.setNotchWidthProperty(notchWidth);this.adapter.addClass(OUTLINE_NOTCHED)};MDCNotchedOutlineFoundation.prototype.closeNotch=function(){var OUTLINE_NOTCHED=MDCNotchedOutlineFoundation.cssClasses.OUTLINE_NOTCHED;this.adapter.removeClass(OUTLINE_NOTCHED);this.adapter.removeNotchWidthProperty()};return MDCNotchedOutlineFoundation}(MDCFoundation);const notched_outline_foundation=null&&MDCNotchedOutlineFoundation;
/**
 * @license
 * Copyright 2017 Google Inc.
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
 */
var MDCNotchedOutline=function(_super){__extends(MDCNotchedOutline,_super);function MDCNotchedOutline(){return _super!==null&&_super.apply(this,arguments)||this}MDCNotchedOutline.attachTo=function(root){return new MDCNotchedOutline(root)};MDCNotchedOutline.prototype.initialSyncWithDOM=function(){this.notchElement_=this.root.querySelector(strings.NOTCH_ELEMENT_SELECTOR);var label=this.root.querySelector("."+MDCFloatingLabelFoundation.cssClasses.ROOT);if(label){label.style.transitionDuration="0s";this.root.classList.add(notched_outline_constants_cssClasses.OUTLINE_UPGRADED);requestAnimationFrame((function(){label.style.transitionDuration=""}))}else{this.root.classList.add(notched_outline_constants_cssClasses.NO_LABEL)}};MDCNotchedOutline.prototype.notch=function(notchWidth){this.foundation.notch(notchWidth)};MDCNotchedOutline.prototype.closeNotch=function(){this.foundation.closeNotch()};MDCNotchedOutline.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClass:function(className){return _this.root.classList.add(className)},removeClass:function(className){return _this.root.classList.remove(className)},setNotchWidthProperty:function(width){return _this.notchElement_.style.setProperty("width",width+"px")},removeNotchWidthProperty:function(){return _this.notchElement_.style.removeProperty("width")}};return new MDCNotchedOutlineFoundation(adapter)};return MDCNotchedOutline}(MDCComponent);
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
 */
var ripple_constants_cssClasses={BG_FOCUSED:"mdc-ripple-upgraded--background-focused",FG_ACTIVATION:"mdc-ripple-upgraded--foreground-activation",FG_DEACTIVATION:"mdc-ripple-upgraded--foreground-deactivation",ROOT:"mdc-ripple-upgraded",UNBOUNDED:"mdc-ripple-upgraded--unbounded"};var constants_strings={VAR_FG_SCALE:"--mdc-ripple-fg-scale",VAR_FG_SIZE:"--mdc-ripple-fg-size",VAR_FG_TRANSLATE_END:"--mdc-ripple-fg-translate-end",VAR_FG_TRANSLATE_START:"--mdc-ripple-fg-translate-start",VAR_LEFT:"--mdc-ripple-left",VAR_TOP:"--mdc-ripple-top"};var constants_numbers={DEACTIVATION_TIMEOUT_MS:225,FG_DEACTIVATION_MS:150,INITIAL_ORIGIN_SCALE:.6,PADDING:10,TAP_DELAY_MS:300};var supportsCssVariables_;function supportsCssVariables(windowObj,forceRefresh){if(forceRefresh===void 0){forceRefresh=false}var CSS=windowObj.CSS;var supportsCssVars=supportsCssVariables_;if(typeof supportsCssVariables_==="boolean"&&!forceRefresh){return supportsCssVariables_}var supportsFunctionPresent=CSS&&typeof CSS.supports==="function";if(!supportsFunctionPresent){return false}var explicitlySupportsCssVars=CSS.supports("--css-vars","yes");var weAreFeatureDetectingSafari10plus=CSS.supports("(--css-vars: yes)")&&CSS.supports("color","#00000000");supportsCssVars=explicitlySupportsCssVars||weAreFeatureDetectingSafari10plus;if(!forceRefresh){supportsCssVariables_=supportsCssVars}return supportsCssVars}function getNormalizedEventCoords(evt,pageOffset,clientRect){if(!evt){return{x:0,y:0}}var x=pageOffset.x,y=pageOffset.y;var documentX=x+clientRect.left;var documentY=y+clientRect.top;var normalizedX;var normalizedY;if(evt.type==="touchstart"){var touchEvent=evt;normalizedX=touchEvent.changedTouches[0].pageX-documentX;normalizedY=touchEvent.changedTouches[0].pageY-documentY}else{var mouseEvent=evt;normalizedX=mouseEvent.pageX-documentX;normalizedY=mouseEvent.pageY-documentY}return{x:normalizedX,y:normalizedY}}
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
 */
var ACTIVATION_EVENT_TYPES=["touchstart","pointerdown","mousedown","keydown"];var POINTER_DEACTIVATION_EVENT_TYPES=["touchend","pointerup","mouseup","contextmenu"];var activatedTargets=[];var MDCRippleFoundation=function(_super){__extends(MDCRippleFoundation,_super);function MDCRippleFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCRippleFoundation.defaultAdapter),adapter))||this;_this.activationAnimationHasEnded_=false;_this.activationTimer_=0;_this.fgDeactivationRemovalTimer_=0;_this.fgScale_="0";_this.frame_={width:0,height:0};_this.initialSize_=0;_this.layoutFrame_=0;_this.maxRadius_=0;_this.unboundedCoords_={left:0,top:0};_this.activationState_=_this.defaultActivationState_();_this.activationTimerCallback_=function(){_this.activationAnimationHasEnded_=true;_this.runDeactivationUXLogicIfReady_()};_this.activateHandler_=function(e){return _this.activate_(e)};_this.deactivateHandler_=function(){return _this.deactivate_()};_this.focusHandler_=function(){return _this.handleFocus()};_this.blurHandler_=function(){return _this.handleBlur()};_this.resizeHandler_=function(){return _this.layout()};return _this}Object.defineProperty(MDCRippleFoundation,"cssClasses",{get:function(){return ripple_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCRippleFoundation,"strings",{get:function(){return constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCRippleFoundation,"numbers",{get:function(){return constants_numbers},enumerable:true,configurable:true});Object.defineProperty(MDCRippleFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},browserSupportsCssVars:function(){return true},computeBoundingRect:function(){return{top:0,right:0,bottom:0,left:0,width:0,height:0}},containsEventTarget:function(){return true},deregisterDocumentInteractionHandler:function(){return undefined},deregisterInteractionHandler:function(){return undefined},deregisterResizeHandler:function(){return undefined},getWindowPageOffset:function(){return{x:0,y:0}},isSurfaceActive:function(){return true},isSurfaceDisabled:function(){return true},isUnbounded:function(){return true},registerDocumentInteractionHandler:function(){return undefined},registerInteractionHandler:function(){return undefined},registerResizeHandler:function(){return undefined},removeClass:function(){return undefined},updateCssVariable:function(){return undefined}}},enumerable:true,configurable:true});MDCRippleFoundation.prototype.init=function(){var _this=this;var supportsPressRipple=this.supportsPressRipple_();this.registerRootHandlers_(supportsPressRipple);if(supportsPressRipple){var _a=MDCRippleFoundation.cssClasses,ROOT_1=_a.ROOT,UNBOUNDED_1=_a.UNBOUNDED;requestAnimationFrame((function(){_this.adapter.addClass(ROOT_1);if(_this.adapter.isUnbounded()){_this.adapter.addClass(UNBOUNDED_1);_this.layoutInternal_()}}))}};MDCRippleFoundation.prototype.destroy=function(){var _this=this;if(this.supportsPressRipple_()){if(this.activationTimer_){clearTimeout(this.activationTimer_);this.activationTimer_=0;this.adapter.removeClass(MDCRippleFoundation.cssClasses.FG_ACTIVATION)}if(this.fgDeactivationRemovalTimer_){clearTimeout(this.fgDeactivationRemovalTimer_);this.fgDeactivationRemovalTimer_=0;this.adapter.removeClass(MDCRippleFoundation.cssClasses.FG_DEACTIVATION)}var _a=MDCRippleFoundation.cssClasses,ROOT_2=_a.ROOT,UNBOUNDED_2=_a.UNBOUNDED;requestAnimationFrame((function(){_this.adapter.removeClass(ROOT_2);_this.adapter.removeClass(UNBOUNDED_2);_this.removeCssVars_()}))}this.deregisterRootHandlers_();this.deregisterDeactivationHandlers_()};MDCRippleFoundation.prototype.activate=function(evt){this.activate_(evt)};MDCRippleFoundation.prototype.deactivate=function(){this.deactivate_()};MDCRippleFoundation.prototype.layout=function(){var _this=this;if(this.layoutFrame_){cancelAnimationFrame(this.layoutFrame_)}this.layoutFrame_=requestAnimationFrame((function(){_this.layoutInternal_();_this.layoutFrame_=0}))};MDCRippleFoundation.prototype.setUnbounded=function(unbounded){var UNBOUNDED=MDCRippleFoundation.cssClasses.UNBOUNDED;if(unbounded){this.adapter.addClass(UNBOUNDED)}else{this.adapter.removeClass(UNBOUNDED)}};MDCRippleFoundation.prototype.handleFocus=function(){var _this=this;requestAnimationFrame((function(){return _this.adapter.addClass(MDCRippleFoundation.cssClasses.BG_FOCUSED)}))};MDCRippleFoundation.prototype.handleBlur=function(){var _this=this;requestAnimationFrame((function(){return _this.adapter.removeClass(MDCRippleFoundation.cssClasses.BG_FOCUSED)}))};MDCRippleFoundation.prototype.supportsPressRipple_=function(){return this.adapter.browserSupportsCssVars()};MDCRippleFoundation.prototype.defaultActivationState_=function(){return{activationEvent:undefined,hasDeactivationUXRun:false,isActivated:false,isProgrammatic:false,wasActivatedByPointer:false,wasElementMadeActive:false}};MDCRippleFoundation.prototype.registerRootHandlers_=function(supportsPressRipple){var _this=this;if(supportsPressRipple){ACTIVATION_EVENT_TYPES.forEach((function(evtType){_this.adapter.registerInteractionHandler(evtType,_this.activateHandler_)}));if(this.adapter.isUnbounded()){this.adapter.registerResizeHandler(this.resizeHandler_)}}this.adapter.registerInteractionHandler("focus",this.focusHandler_);this.adapter.registerInteractionHandler("blur",this.blurHandler_)};MDCRippleFoundation.prototype.registerDeactivationHandlers_=function(evt){var _this=this;if(evt.type==="keydown"){this.adapter.registerInteractionHandler("keyup",this.deactivateHandler_)}else{POINTER_DEACTIVATION_EVENT_TYPES.forEach((function(evtType){_this.adapter.registerDocumentInteractionHandler(evtType,_this.deactivateHandler_)}))}};MDCRippleFoundation.prototype.deregisterRootHandlers_=function(){var _this=this;ACTIVATION_EVENT_TYPES.forEach((function(evtType){_this.adapter.deregisterInteractionHandler(evtType,_this.activateHandler_)}));this.adapter.deregisterInteractionHandler("focus",this.focusHandler_);this.adapter.deregisterInteractionHandler("blur",this.blurHandler_);if(this.adapter.isUnbounded()){this.adapter.deregisterResizeHandler(this.resizeHandler_)}};MDCRippleFoundation.prototype.deregisterDeactivationHandlers_=function(){var _this=this;this.adapter.deregisterInteractionHandler("keyup",this.deactivateHandler_);POINTER_DEACTIVATION_EVENT_TYPES.forEach((function(evtType){_this.adapter.deregisterDocumentInteractionHandler(evtType,_this.deactivateHandler_)}))};MDCRippleFoundation.prototype.removeCssVars_=function(){var _this=this;var rippleStrings=MDCRippleFoundation.strings;var keys=Object.keys(rippleStrings);keys.forEach((function(key){if(key.indexOf("VAR_")===0){_this.adapter.updateCssVariable(rippleStrings[key],null)}}))};MDCRippleFoundation.prototype.activate_=function(evt){var _this=this;if(this.adapter.isSurfaceDisabled()){return}var activationState=this.activationState_;if(activationState.isActivated){return}var previousActivationEvent=this.previousActivationEvent_;var isSameInteraction=previousActivationEvent&&evt!==undefined&&previousActivationEvent.type!==evt.type;if(isSameInteraction){return}activationState.isActivated=true;activationState.isProgrammatic=evt===undefined;activationState.activationEvent=evt;activationState.wasActivatedByPointer=activationState.isProgrammatic?false:evt!==undefined&&(evt.type==="mousedown"||evt.type==="touchstart"||evt.type==="pointerdown");var hasActivatedChild=evt!==undefined&&activatedTargets.length>0&&activatedTargets.some((function(target){return _this.adapter.containsEventTarget(target)}));if(hasActivatedChild){this.resetActivationState_();return}if(evt!==undefined){activatedTargets.push(evt.target);this.registerDeactivationHandlers_(evt)}activationState.wasElementMadeActive=this.checkElementMadeActive_(evt);if(activationState.wasElementMadeActive){this.animateActivation_()}requestAnimationFrame((function(){activatedTargets=[];if(!activationState.wasElementMadeActive&&evt!==undefined&&(evt.key===" "||evt.keyCode===32)){activationState.wasElementMadeActive=_this.checkElementMadeActive_(evt);if(activationState.wasElementMadeActive){_this.animateActivation_()}}if(!activationState.wasElementMadeActive){_this.activationState_=_this.defaultActivationState_()}}))};MDCRippleFoundation.prototype.checkElementMadeActive_=function(evt){return evt!==undefined&&evt.type==="keydown"?this.adapter.isSurfaceActive():true};MDCRippleFoundation.prototype.animateActivation_=function(){var _this=this;var _a=MDCRippleFoundation.strings,VAR_FG_TRANSLATE_START=_a.VAR_FG_TRANSLATE_START,VAR_FG_TRANSLATE_END=_a.VAR_FG_TRANSLATE_END;var _b=MDCRippleFoundation.cssClasses,FG_DEACTIVATION=_b.FG_DEACTIVATION,FG_ACTIVATION=_b.FG_ACTIVATION;var DEACTIVATION_TIMEOUT_MS=MDCRippleFoundation.numbers.DEACTIVATION_TIMEOUT_MS;this.layoutInternal_();var translateStart="";var translateEnd="";if(!this.adapter.isUnbounded()){var _c=this.getFgTranslationCoordinates_(),startPoint=_c.startPoint,endPoint=_c.endPoint;translateStart=startPoint.x+"px, "+startPoint.y+"px";translateEnd=endPoint.x+"px, "+endPoint.y+"px"}this.adapter.updateCssVariable(VAR_FG_TRANSLATE_START,translateStart);this.adapter.updateCssVariable(VAR_FG_TRANSLATE_END,translateEnd);clearTimeout(this.activationTimer_);clearTimeout(this.fgDeactivationRemovalTimer_);this.rmBoundedActivationClasses_();this.adapter.removeClass(FG_DEACTIVATION);this.adapter.computeBoundingRect();this.adapter.addClass(FG_ACTIVATION);this.activationTimer_=setTimeout((function(){return _this.activationTimerCallback_()}),DEACTIVATION_TIMEOUT_MS)};MDCRippleFoundation.prototype.getFgTranslationCoordinates_=function(){var _a=this.activationState_,activationEvent=_a.activationEvent,wasActivatedByPointer=_a.wasActivatedByPointer;var startPoint;if(wasActivatedByPointer){startPoint=getNormalizedEventCoords(activationEvent,this.adapter.getWindowPageOffset(),this.adapter.computeBoundingRect())}else{startPoint={x:this.frame_.width/2,y:this.frame_.height/2}}startPoint={x:startPoint.x-this.initialSize_/2,y:startPoint.y-this.initialSize_/2};var endPoint={x:this.frame_.width/2-this.initialSize_/2,y:this.frame_.height/2-this.initialSize_/2};return{startPoint:startPoint,endPoint:endPoint}};MDCRippleFoundation.prototype.runDeactivationUXLogicIfReady_=function(){var _this=this;var FG_DEACTIVATION=MDCRippleFoundation.cssClasses.FG_DEACTIVATION;var _a=this.activationState_,hasDeactivationUXRun=_a.hasDeactivationUXRun,isActivated=_a.isActivated;var activationHasEnded=hasDeactivationUXRun||!isActivated;if(activationHasEnded&&this.activationAnimationHasEnded_){this.rmBoundedActivationClasses_();this.adapter.addClass(FG_DEACTIVATION);this.fgDeactivationRemovalTimer_=setTimeout((function(){_this.adapter.removeClass(FG_DEACTIVATION)}),constants_numbers.FG_DEACTIVATION_MS)}};MDCRippleFoundation.prototype.rmBoundedActivationClasses_=function(){var FG_ACTIVATION=MDCRippleFoundation.cssClasses.FG_ACTIVATION;this.adapter.removeClass(FG_ACTIVATION);this.activationAnimationHasEnded_=false;this.adapter.computeBoundingRect()};MDCRippleFoundation.prototype.resetActivationState_=function(){var _this=this;this.previousActivationEvent_=this.activationState_.activationEvent;this.activationState_=this.defaultActivationState_();setTimeout((function(){return _this.previousActivationEvent_=undefined}),MDCRippleFoundation.numbers.TAP_DELAY_MS)};MDCRippleFoundation.prototype.deactivate_=function(){var _this=this;var activationState=this.activationState_;if(!activationState.isActivated){return}var state=__assign({},activationState);if(activationState.isProgrammatic){requestAnimationFrame((function(){return _this.animateDeactivation_(state)}));this.resetActivationState_()}else{this.deregisterDeactivationHandlers_();requestAnimationFrame((function(){_this.activationState_.hasDeactivationUXRun=true;_this.animateDeactivation_(state);_this.resetActivationState_()}))}};MDCRippleFoundation.prototype.animateDeactivation_=function(_a){var wasActivatedByPointer=_a.wasActivatedByPointer,wasElementMadeActive=_a.wasElementMadeActive;if(wasActivatedByPointer||wasElementMadeActive){this.runDeactivationUXLogicIfReady_()}};MDCRippleFoundation.prototype.layoutInternal_=function(){var _this=this;this.frame_=this.adapter.computeBoundingRect();var maxDim=Math.max(this.frame_.height,this.frame_.width);var getBoundedRadius=function(){var hypotenuse=Math.sqrt(Math.pow(_this.frame_.width,2)+Math.pow(_this.frame_.height,2));return hypotenuse+MDCRippleFoundation.numbers.PADDING};this.maxRadius_=this.adapter.isUnbounded()?maxDim:getBoundedRadius();var initialSize=Math.floor(maxDim*MDCRippleFoundation.numbers.INITIAL_ORIGIN_SCALE);if(this.adapter.isUnbounded()&&initialSize%2!==0){this.initialSize_=initialSize-1}else{this.initialSize_=initialSize}this.fgScale_=""+this.maxRadius_/this.initialSize_;this.updateLayoutCssVars_()};MDCRippleFoundation.prototype.updateLayoutCssVars_=function(){var _a=MDCRippleFoundation.strings,VAR_FG_SIZE=_a.VAR_FG_SIZE,VAR_LEFT=_a.VAR_LEFT,VAR_TOP=_a.VAR_TOP,VAR_FG_SCALE=_a.VAR_FG_SCALE;this.adapter.updateCssVariable(VAR_FG_SIZE,this.initialSize_+"px");this.adapter.updateCssVariable(VAR_FG_SCALE,this.fgScale_);if(this.adapter.isUnbounded()){this.unboundedCoords_={left:Math.round(this.frame_.width/2-this.initialSize_/2),top:Math.round(this.frame_.height/2-this.initialSize_/2)};this.adapter.updateCssVariable(VAR_LEFT,this.unboundedCoords_.left+"px");this.adapter.updateCssVariable(VAR_TOP,this.unboundedCoords_.top+"px")}};return MDCRippleFoundation}(MDCFoundation);const ripple_foundation=null&&MDCRippleFoundation;
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
 */
var MDCRipple=function(_super){__extends(MDCRipple,_super);function MDCRipple(){var _this=_super!==null&&_super.apply(this,arguments)||this;_this.disabled=false;return _this}MDCRipple.attachTo=function(root,opts){if(opts===void 0){opts={isUnbounded:undefined}}var ripple=new MDCRipple(root);if(opts.isUnbounded!==undefined){ripple.unbounded=opts.isUnbounded}return ripple};MDCRipple.createAdapter=function(instance){return{addClass:function(className){return instance.root.classList.add(className)},browserSupportsCssVars:function(){return supportsCssVariables(window)},computeBoundingRect:function(){return instance.root.getBoundingClientRect()},containsEventTarget:function(target){return instance.root.contains(target)},deregisterDocumentInteractionHandler:function(evtType,handler){return document.documentElement.removeEventListener(evtType,handler,applyPassive())},deregisterInteractionHandler:function(evtType,handler){return instance.root.removeEventListener(evtType,handler,applyPassive())},deregisterResizeHandler:function(handler){return window.removeEventListener("resize",handler)},getWindowPageOffset:function(){return{x:window.pageXOffset,y:window.pageYOffset}},isSurfaceActive:function(){return matches(instance.root,":active")},isSurfaceDisabled:function(){return Boolean(instance.disabled)},isUnbounded:function(){return Boolean(instance.unbounded)},registerDocumentInteractionHandler:function(evtType,handler){return document.documentElement.addEventListener(evtType,handler,applyPassive())},registerInteractionHandler:function(evtType,handler){return instance.root.addEventListener(evtType,handler,applyPassive())},registerResizeHandler:function(handler){return window.addEventListener("resize",handler)},removeClass:function(className){return instance.root.classList.remove(className)},updateCssVariable:function(varName,value){return instance.root.style.setProperty(varName,value)}}};Object.defineProperty(MDCRipple.prototype,"unbounded",{get:function(){return Boolean(this.unbounded_)},set:function(unbounded){this.unbounded_=Boolean(unbounded);this.setUnbounded_()},enumerable:true,configurable:true});MDCRipple.prototype.activate=function(){this.foundation.activate()};MDCRipple.prototype.deactivate=function(){this.foundation.deactivate()};MDCRipple.prototype.layout=function(){this.foundation.layout()};MDCRipple.prototype.getDefaultFoundation=function(){return new MDCRippleFoundation(MDCRipple.createAdapter(this))};MDCRipple.prototype.initialSyncWithDOM=function(){var root=this.root;this.unbounded="mdcRippleIsUnbounded"in root.dataset};MDCRipple.prototype.setUnbounded_=function(){this.foundation.setUnbounded(Boolean(this.unbounded_))};return MDCRipple}(MDCComponent);
/**
 * @license
 * Copyright 2019 Google Inc.
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
 */
var character_counter_constants_cssClasses={ROOT:"mdc-text-field-character-counter"};var character_counter_constants_strings={ROOT_SELECTOR:"."+character_counter_constants_cssClasses.ROOT};
/**
 * @license
 * Copyright 2019 Google Inc.
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
 */
var MDCTextFieldCharacterCounterFoundation=function(_super){__extends(MDCTextFieldCharacterCounterFoundation,_super);function MDCTextFieldCharacterCounterFoundation(adapter){return _super.call(this,__assign(__assign({},MDCTextFieldCharacterCounterFoundation.defaultAdapter),adapter))||this}Object.defineProperty(MDCTextFieldCharacterCounterFoundation,"cssClasses",{get:function(){return character_counter_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCTextFieldCharacterCounterFoundation,"strings",{get:function(){return character_counter_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCTextFieldCharacterCounterFoundation,"defaultAdapter",{get:function(){return{setContent:function(){return undefined}}},enumerable:true,configurable:true});MDCTextFieldCharacterCounterFoundation.prototype.setCounterValue=function(currentLength,maxLength){currentLength=Math.min(currentLength,maxLength);this.adapter.setContent(currentLength+" / "+maxLength)};return MDCTextFieldCharacterCounterFoundation}(MDCFoundation);const character_counter_foundation=null&&MDCTextFieldCharacterCounterFoundation;
/**
 * @license
 * Copyright 2019 Google Inc.
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
 */
var MDCTextFieldCharacterCounter=function(_super){__extends(MDCTextFieldCharacterCounter,_super);function MDCTextFieldCharacterCounter(){return _super!==null&&_super.apply(this,arguments)||this}MDCTextFieldCharacterCounter.attachTo=function(root){return new MDCTextFieldCharacterCounter(root)};Object.defineProperty(MDCTextFieldCharacterCounter.prototype,"foundationForTextField",{get:function(){return this.foundation},enumerable:true,configurable:true});MDCTextFieldCharacterCounter.prototype.getDefaultFoundation=function(){var _this=this;var adapter={setContent:function(content){_this.root.textContent=content}};return new MDCTextFieldCharacterCounterFoundation(adapter)};return MDCTextFieldCharacterCounter}(MDCComponent);
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
 */
var textfield_constants_strings={ARIA_CONTROLS:"aria-controls",ARIA_DESCRIBEDBY:"aria-describedby",INPUT_SELECTOR:".mdc-text-field__input",LABEL_SELECTOR:".mdc-floating-label",LEADING_ICON_SELECTOR:".mdc-text-field__icon--leading",LINE_RIPPLE_SELECTOR:".mdc-line-ripple",OUTLINE_SELECTOR:".mdc-notched-outline",PREFIX_SELECTOR:".mdc-text-field__affix--prefix",SUFFIX_SELECTOR:".mdc-text-field__affix--suffix",TRAILING_ICON_SELECTOR:".mdc-text-field__icon--trailing"};var textfield_constants_cssClasses={DISABLED:"mdc-text-field--disabled",FOCUSED:"mdc-text-field--focused",HELPER_LINE:"mdc-text-field-helper-line",INVALID:"mdc-text-field--invalid",LABEL_FLOATING:"mdc-text-field--label-floating",NO_LABEL:"mdc-text-field--no-label",OUTLINED:"mdc-text-field--outlined",ROOT:"mdc-text-field",TEXTAREA:"mdc-text-field--textarea",WITH_LEADING_ICON:"mdc-text-field--with-leading-icon",WITH_TRAILING_ICON:"mdc-text-field--with-trailing-icon"};var textfield_constants_numbers={LABEL_SCALE:.75};var VALIDATION_ATTR_WHITELIST=["pattern","min","max","required","step","minlength","maxlength"];var ALWAYS_FLOAT_TYPES=["color","date","datetime-local","month","range","time","week"];
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
 */
var POINTERDOWN_EVENTS=["mousedown","touchstart"];var INTERACTION_EVENTS=["click","keydown"];var MDCTextFieldFoundation=function(_super){__extends(MDCTextFieldFoundation,_super);function MDCTextFieldFoundation(adapter,foundationMap){if(foundationMap===void 0){foundationMap={}}var _this=_super.call(this,__assign(__assign({},MDCTextFieldFoundation.defaultAdapter),adapter))||this;_this.isFocused_=false;_this.receivedUserInput_=false;_this.isValid_=true;_this.useNativeValidation_=true;_this.validateOnValueChange_=true;_this.helperText_=foundationMap.helperText;_this.characterCounter_=foundationMap.characterCounter;_this.leadingIcon_=foundationMap.leadingIcon;_this.trailingIcon_=foundationMap.trailingIcon;_this.inputFocusHandler_=function(){return _this.activateFocus()};_this.inputBlurHandler_=function(){return _this.deactivateFocus()};_this.inputInputHandler_=function(){return _this.handleInput()};_this.setPointerXOffset_=function(evt){return _this.setTransformOrigin(evt)};_this.textFieldInteractionHandler_=function(){return _this.handleTextFieldInteraction()};_this.validationAttributeChangeHandler_=function(attributesList){return _this.handleValidationAttributeChange(attributesList)};return _this}Object.defineProperty(MDCTextFieldFoundation,"cssClasses",{get:function(){return textfield_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCTextFieldFoundation,"strings",{get:function(){return textfield_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCTextFieldFoundation,"numbers",{get:function(){return textfield_constants_numbers},enumerable:true,configurable:true});Object.defineProperty(MDCTextFieldFoundation.prototype,"shouldAlwaysFloat_",{get:function(){var type=this.getNativeInput_().type;return ALWAYS_FLOAT_TYPES.indexOf(type)>=0},enumerable:true,configurable:true});Object.defineProperty(MDCTextFieldFoundation.prototype,"shouldFloat",{get:function(){return this.shouldAlwaysFloat_||this.isFocused_||!!this.getValue()||this.isBadInput_()},enumerable:true,configurable:true});Object.defineProperty(MDCTextFieldFoundation.prototype,"shouldShake",{get:function(){return!this.isFocused_&&!this.isValid()&&!!this.getValue()},enumerable:true,configurable:true});Object.defineProperty(MDCTextFieldFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},removeClass:function(){return undefined},hasClass:function(){return true},setInputAttr:function(){return undefined},removeInputAttr:function(){return undefined},registerTextFieldInteractionHandler:function(){return undefined},deregisterTextFieldInteractionHandler:function(){return undefined},registerInputInteractionHandler:function(){return undefined},deregisterInputInteractionHandler:function(){return undefined},registerValidationAttributeChangeHandler:function(){return new MutationObserver((function(){return undefined}))},deregisterValidationAttributeChangeHandler:function(){return undefined},getNativeInput:function(){return null},isFocused:function(){return false},activateLineRipple:function(){return undefined},deactivateLineRipple:function(){return undefined},setLineRippleTransformOrigin:function(){return undefined},shakeLabel:function(){return undefined},floatLabel:function(){return undefined},setLabelRequired:function(){return undefined},hasLabel:function(){return false},getLabelWidth:function(){return 0},hasOutline:function(){return false},notchOutline:function(){return undefined},closeOutline:function(){return undefined}}},enumerable:true,configurable:true});MDCTextFieldFoundation.prototype.init=function(){var _this=this;if(this.adapter.hasLabel()&&this.getNativeInput_().required){this.adapter.setLabelRequired(true)}if(this.adapter.isFocused()){this.inputFocusHandler_()}else if(this.adapter.hasLabel()&&this.shouldFloat){this.notchOutline(true);this.adapter.floatLabel(true);this.styleFloating_(true)}this.adapter.registerInputInteractionHandler("focus",this.inputFocusHandler_);this.adapter.registerInputInteractionHandler("blur",this.inputBlurHandler_);this.adapter.registerInputInteractionHandler("input",this.inputInputHandler_);POINTERDOWN_EVENTS.forEach((function(evtType){_this.adapter.registerInputInteractionHandler(evtType,_this.setPointerXOffset_)}));INTERACTION_EVENTS.forEach((function(evtType){_this.adapter.registerTextFieldInteractionHandler(evtType,_this.textFieldInteractionHandler_)}));this.validationObserver_=this.adapter.registerValidationAttributeChangeHandler(this.validationAttributeChangeHandler_);this.setCharacterCounter_(this.getValue().length)};MDCTextFieldFoundation.prototype.destroy=function(){var _this=this;this.adapter.deregisterInputInteractionHandler("focus",this.inputFocusHandler_);this.adapter.deregisterInputInteractionHandler("blur",this.inputBlurHandler_);this.adapter.deregisterInputInteractionHandler("input",this.inputInputHandler_);POINTERDOWN_EVENTS.forEach((function(evtType){_this.adapter.deregisterInputInteractionHandler(evtType,_this.setPointerXOffset_)}));INTERACTION_EVENTS.forEach((function(evtType){_this.adapter.deregisterTextFieldInteractionHandler(evtType,_this.textFieldInteractionHandler_)}));this.adapter.deregisterValidationAttributeChangeHandler(this.validationObserver_)};MDCTextFieldFoundation.prototype.handleTextFieldInteraction=function(){var nativeInput=this.adapter.getNativeInput();if(nativeInput&&nativeInput.disabled){return}this.receivedUserInput_=true};MDCTextFieldFoundation.prototype.handleValidationAttributeChange=function(attributesList){var _this=this;attributesList.some((function(attributeName){if(VALIDATION_ATTR_WHITELIST.indexOf(attributeName)>-1){_this.styleValidity_(true);_this.adapter.setLabelRequired(_this.getNativeInput_().required);return true}return false}));if(attributesList.indexOf("maxlength")>-1){this.setCharacterCounter_(this.getValue().length)}};MDCTextFieldFoundation.prototype.notchOutline=function(openNotch){if(!this.adapter.hasOutline()||!this.adapter.hasLabel()){return}if(openNotch){var labelWidth=this.adapter.getLabelWidth()*textfield_constants_numbers.LABEL_SCALE;this.adapter.notchOutline(labelWidth)}else{this.adapter.closeOutline()}};MDCTextFieldFoundation.prototype.activateFocus=function(){this.isFocused_=true;this.styleFocused_(this.isFocused_);this.adapter.activateLineRipple();if(this.adapter.hasLabel()){this.notchOutline(this.shouldFloat);this.adapter.floatLabel(this.shouldFloat);this.styleFloating_(this.shouldFloat);this.adapter.shakeLabel(this.shouldShake)}if(this.helperText_&&(this.helperText_.isPersistent()||!this.helperText_.isValidation()||!this.isValid_)){this.helperText_.showToScreenReader()}};MDCTextFieldFoundation.prototype.setTransformOrigin=function(evt){if(this.isDisabled()||this.adapter.hasOutline()){return}var touches=evt.touches;var targetEvent=touches?touches[0]:evt;var targetClientRect=targetEvent.target.getBoundingClientRect();var normalizedX=targetEvent.clientX-targetClientRect.left;this.adapter.setLineRippleTransformOrigin(normalizedX)};MDCTextFieldFoundation.prototype.handleInput=function(){this.autoCompleteFocus();this.setCharacterCounter_(this.getValue().length)};MDCTextFieldFoundation.prototype.autoCompleteFocus=function(){if(!this.receivedUserInput_){this.activateFocus()}};MDCTextFieldFoundation.prototype.deactivateFocus=function(){this.isFocused_=false;this.adapter.deactivateLineRipple();var isValid=this.isValid();this.styleValidity_(isValid);this.styleFocused_(this.isFocused_);if(this.adapter.hasLabel()){this.notchOutline(this.shouldFloat);this.adapter.floatLabel(this.shouldFloat);this.styleFloating_(this.shouldFloat);this.adapter.shakeLabel(this.shouldShake)}if(!this.shouldFloat){this.receivedUserInput_=false}};MDCTextFieldFoundation.prototype.getValue=function(){return this.getNativeInput_().value};MDCTextFieldFoundation.prototype.setValue=function(value){if(this.getValue()!==value){this.getNativeInput_().value=value}this.setCharacterCounter_(value.length);if(this.validateOnValueChange_){var isValid=this.isValid();this.styleValidity_(isValid)}if(this.adapter.hasLabel()){this.notchOutline(this.shouldFloat);this.adapter.floatLabel(this.shouldFloat);this.styleFloating_(this.shouldFloat);if(this.validateOnValueChange_){this.adapter.shakeLabel(this.shouldShake)}}};MDCTextFieldFoundation.prototype.isValid=function(){return this.useNativeValidation_?this.isNativeInputValid_():this.isValid_};MDCTextFieldFoundation.prototype.setValid=function(isValid){this.isValid_=isValid;this.styleValidity_(isValid);var shouldShake=!isValid&&!this.isFocused_&&!!this.getValue();if(this.adapter.hasLabel()){this.adapter.shakeLabel(shouldShake)}};MDCTextFieldFoundation.prototype.setValidateOnValueChange=function(shouldValidate){this.validateOnValueChange_=shouldValidate};MDCTextFieldFoundation.prototype.getValidateOnValueChange=function(){return this.validateOnValueChange_};MDCTextFieldFoundation.prototype.setUseNativeValidation=function(useNativeValidation){this.useNativeValidation_=useNativeValidation};MDCTextFieldFoundation.prototype.isDisabled=function(){return this.getNativeInput_().disabled};MDCTextFieldFoundation.prototype.setDisabled=function(disabled){this.getNativeInput_().disabled=disabled;this.styleDisabled_(disabled)};MDCTextFieldFoundation.prototype.setHelperTextContent=function(content){if(this.helperText_){this.helperText_.setContent(content)}};MDCTextFieldFoundation.prototype.setLeadingIconAriaLabel=function(label){if(this.leadingIcon_){this.leadingIcon_.setAriaLabel(label)}};MDCTextFieldFoundation.prototype.setLeadingIconContent=function(content){if(this.leadingIcon_){this.leadingIcon_.setContent(content)}};MDCTextFieldFoundation.prototype.setTrailingIconAriaLabel=function(label){if(this.trailingIcon_){this.trailingIcon_.setAriaLabel(label)}};MDCTextFieldFoundation.prototype.setTrailingIconContent=function(content){if(this.trailingIcon_){this.trailingIcon_.setContent(content)}};MDCTextFieldFoundation.prototype.setCharacterCounter_=function(currentLength){if(!this.characterCounter_){return}var maxLength=this.getNativeInput_().maxLength;if(maxLength===-1){throw new Error("MDCTextFieldFoundation: Expected maxlength html property on text input or textarea.")}this.characterCounter_.setCounterValue(currentLength,maxLength)};MDCTextFieldFoundation.prototype.isBadInput_=function(){return this.getNativeInput_().validity.badInput||false};MDCTextFieldFoundation.prototype.isNativeInputValid_=function(){return this.getNativeInput_().validity.valid};MDCTextFieldFoundation.prototype.styleValidity_=function(isValid){var INVALID=MDCTextFieldFoundation.cssClasses.INVALID;if(isValid){this.adapter.removeClass(INVALID)}else{this.adapter.addClass(INVALID)}if(this.helperText_){this.helperText_.setValidity(isValid);var helperTextValidation=this.helperText_.isValidation();if(!helperTextValidation){return}var helperTextVisible=this.helperText_.isVisible();var helperTextId=this.helperText_.getId();if(helperTextVisible&&helperTextId){this.adapter.setInputAttr(textfield_constants_strings.ARIA_DESCRIBEDBY,helperTextId)}else{this.adapter.removeInputAttr(textfield_constants_strings.ARIA_DESCRIBEDBY)}}};MDCTextFieldFoundation.prototype.styleFocused_=function(isFocused){var FOCUSED=MDCTextFieldFoundation.cssClasses.FOCUSED;if(isFocused){this.adapter.addClass(FOCUSED)}else{this.adapter.removeClass(FOCUSED)}};MDCTextFieldFoundation.prototype.styleDisabled_=function(isDisabled){var _a=MDCTextFieldFoundation.cssClasses,DISABLED=_a.DISABLED,INVALID=_a.INVALID;if(isDisabled){this.adapter.addClass(DISABLED);this.adapter.removeClass(INVALID)}else{this.adapter.removeClass(DISABLED)}if(this.leadingIcon_){this.leadingIcon_.setDisabled(isDisabled)}if(this.trailingIcon_){this.trailingIcon_.setDisabled(isDisabled)}};MDCTextFieldFoundation.prototype.styleFloating_=function(isFloating){var LABEL_FLOATING=MDCTextFieldFoundation.cssClasses.LABEL_FLOATING;if(isFloating){this.adapter.addClass(LABEL_FLOATING)}else{this.adapter.removeClass(LABEL_FLOATING)}};MDCTextFieldFoundation.prototype.getNativeInput_=function(){var nativeInput=this.adapter?this.adapter.getNativeInput():null;return nativeInput||{disabled:false,maxLength:-1,required:false,type:"input",validity:{badInput:false,valid:true},value:""}};return MDCTextFieldFoundation}(MDCFoundation);const textfield_foundation=null&&MDCTextFieldFoundation;
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
 */
var helper_text_constants_cssClasses={HELPER_TEXT_PERSISTENT:"mdc-text-field-helper-text--persistent",HELPER_TEXT_VALIDATION_MSG:"mdc-text-field-helper-text--validation-msg",ROOT:"mdc-text-field-helper-text"};var helper_text_constants_strings={ARIA_HIDDEN:"aria-hidden",ROLE:"role",ROOT_SELECTOR:"."+helper_text_constants_cssClasses.ROOT};
/**
 * @license
 * Copyright 2017 Google Inc.
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
 */
var MDCTextFieldHelperTextFoundation=function(_super){__extends(MDCTextFieldHelperTextFoundation,_super);function MDCTextFieldHelperTextFoundation(adapter){return _super.call(this,__assign(__assign({},MDCTextFieldHelperTextFoundation.defaultAdapter),adapter))||this}Object.defineProperty(MDCTextFieldHelperTextFoundation,"cssClasses",{get:function(){return helper_text_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCTextFieldHelperTextFoundation,"strings",{get:function(){return helper_text_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCTextFieldHelperTextFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},removeClass:function(){return undefined},hasClass:function(){return false},getAttr:function(){return null},setAttr:function(){return undefined},removeAttr:function(){return undefined},setContent:function(){return undefined}}},enumerable:true,configurable:true});MDCTextFieldHelperTextFoundation.prototype.getId=function(){return this.adapter.getAttr("id")};MDCTextFieldHelperTextFoundation.prototype.isVisible=function(){return this.adapter.getAttr(helper_text_constants_strings.ARIA_HIDDEN)!=="true"};MDCTextFieldHelperTextFoundation.prototype.setContent=function(content){this.adapter.setContent(content)};MDCTextFieldHelperTextFoundation.prototype.isPersistent=function(){return this.adapter.hasClass(helper_text_constants_cssClasses.HELPER_TEXT_PERSISTENT)};MDCTextFieldHelperTextFoundation.prototype.setPersistent=function(isPersistent){if(isPersistent){this.adapter.addClass(helper_text_constants_cssClasses.HELPER_TEXT_PERSISTENT)}else{this.adapter.removeClass(helper_text_constants_cssClasses.HELPER_TEXT_PERSISTENT)}};MDCTextFieldHelperTextFoundation.prototype.isValidation=function(){return this.adapter.hasClass(helper_text_constants_cssClasses.HELPER_TEXT_VALIDATION_MSG)};MDCTextFieldHelperTextFoundation.prototype.setValidation=function(isValidation){if(isValidation){this.adapter.addClass(helper_text_constants_cssClasses.HELPER_TEXT_VALIDATION_MSG)}else{this.adapter.removeClass(helper_text_constants_cssClasses.HELPER_TEXT_VALIDATION_MSG)}};MDCTextFieldHelperTextFoundation.prototype.showToScreenReader=function(){this.adapter.removeAttr(helper_text_constants_strings.ARIA_HIDDEN)};MDCTextFieldHelperTextFoundation.prototype.setValidity=function(inputIsValid){var helperTextIsPersistent=this.adapter.hasClass(helper_text_constants_cssClasses.HELPER_TEXT_PERSISTENT);var helperTextIsValidationMsg=this.adapter.hasClass(helper_text_constants_cssClasses.HELPER_TEXT_VALIDATION_MSG);var validationMsgNeedsDisplay=helperTextIsValidationMsg&&!inputIsValid;if(validationMsgNeedsDisplay){this.showToScreenReader();this.adapter.setAttr(helper_text_constants_strings.ROLE,"alert")}else{this.adapter.removeAttr(helper_text_constants_strings.ROLE)}if(!helperTextIsPersistent&&!validationMsgNeedsDisplay){this.hide_()}};MDCTextFieldHelperTextFoundation.prototype.hide_=function(){this.adapter.setAttr(helper_text_constants_strings.ARIA_HIDDEN,"true")};return MDCTextFieldHelperTextFoundation}(MDCFoundation);const helper_text_foundation=null&&MDCTextFieldHelperTextFoundation;
/**
 * @license
 * Copyright 2017 Google Inc.
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
 */
var MDCTextFieldHelperText=function(_super){__extends(MDCTextFieldHelperText,_super);function MDCTextFieldHelperText(){return _super!==null&&_super.apply(this,arguments)||this}MDCTextFieldHelperText.attachTo=function(root){return new MDCTextFieldHelperText(root)};Object.defineProperty(MDCTextFieldHelperText.prototype,"foundationForTextField",{get:function(){return this.foundation},enumerable:true,configurable:true});MDCTextFieldHelperText.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClass:function(className){return _this.root.classList.add(className)},removeClass:function(className){return _this.root.classList.remove(className)},hasClass:function(className){return _this.root.classList.contains(className)},getAttr:function(attr){return _this.root.getAttribute(attr)},setAttr:function(attr,value){return _this.root.setAttribute(attr,value)},removeAttr:function(attr){return _this.root.removeAttribute(attr)},setContent:function(content){_this.root.textContent=content}};return new MDCTextFieldHelperTextFoundation(adapter)};return MDCTextFieldHelperText}(MDCComponent);
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
 */
var icon_constants_strings={ICON_EVENT:"MDCTextField:icon",ICON_ROLE:"button"};var icon_constants_cssClasses={ROOT:"mdc-text-field__icon"};
/**
 * @license
 * Copyright 2017 Google Inc.
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
 */
var foundation_INTERACTION_EVENTS=["click","keydown"];var MDCTextFieldIconFoundation=function(_super){__extends(MDCTextFieldIconFoundation,_super);function MDCTextFieldIconFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCTextFieldIconFoundation.defaultAdapter),adapter))||this;_this.savedTabIndex_=null;_this.interactionHandler_=function(evt){return _this.handleInteraction(evt)};return _this}Object.defineProperty(MDCTextFieldIconFoundation,"strings",{get:function(){return icon_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCTextFieldIconFoundation,"cssClasses",{get:function(){return icon_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCTextFieldIconFoundation,"defaultAdapter",{get:function(){return{getAttr:function(){return null},setAttr:function(){return undefined},removeAttr:function(){return undefined},setContent:function(){return undefined},registerInteractionHandler:function(){return undefined},deregisterInteractionHandler:function(){return undefined},notifyIconAction:function(){return undefined}}},enumerable:true,configurable:true});MDCTextFieldIconFoundation.prototype.init=function(){var _this=this;this.savedTabIndex_=this.adapter.getAttr("tabindex");foundation_INTERACTION_EVENTS.forEach((function(evtType){_this.adapter.registerInteractionHandler(evtType,_this.interactionHandler_)}))};MDCTextFieldIconFoundation.prototype.destroy=function(){var _this=this;foundation_INTERACTION_EVENTS.forEach((function(evtType){_this.adapter.deregisterInteractionHandler(evtType,_this.interactionHandler_)}))};MDCTextFieldIconFoundation.prototype.setDisabled=function(disabled){if(!this.savedTabIndex_){return}if(disabled){this.adapter.setAttr("tabindex","-1");this.adapter.removeAttr("role")}else{this.adapter.setAttr("tabindex",this.savedTabIndex_);this.adapter.setAttr("role",icon_constants_strings.ICON_ROLE)}};MDCTextFieldIconFoundation.prototype.setAriaLabel=function(label){this.adapter.setAttr("aria-label",label)};MDCTextFieldIconFoundation.prototype.setContent=function(content){this.adapter.setContent(content)};MDCTextFieldIconFoundation.prototype.handleInteraction=function(evt){var isEnterKey=evt.key==="Enter"||evt.keyCode===13;if(evt.type==="click"||isEnterKey){evt.preventDefault();this.adapter.notifyIconAction()}};return MDCTextFieldIconFoundation}(MDCFoundation);const icon_foundation=null&&MDCTextFieldIconFoundation;
/**
 * @license
 * Copyright 2017 Google Inc.
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
 */
var MDCTextFieldIcon=function(_super){__extends(MDCTextFieldIcon,_super);function MDCTextFieldIcon(){return _super!==null&&_super.apply(this,arguments)||this}MDCTextFieldIcon.attachTo=function(root){return new MDCTextFieldIcon(root)};Object.defineProperty(MDCTextFieldIcon.prototype,"foundationForTextField",{get:function(){return this.foundation},enumerable:true,configurable:true});MDCTextFieldIcon.prototype.getDefaultFoundation=function(){var _this=this;var adapter={getAttr:function(attr){return _this.root.getAttribute(attr)},setAttr:function(attr,value){return _this.root.setAttribute(attr,value)},removeAttr:function(attr){return _this.root.removeAttribute(attr)},setContent:function(content){_this.root.textContent=content},registerInteractionHandler:function(evtType,handler){return _this.listen(evtType,handler)},deregisterInteractionHandler:function(evtType,handler){return _this.unlisten(evtType,handler)},notifyIconAction:function(){return _this.emit(MDCTextFieldIconFoundation.strings.ICON_EVENT,{},true)}};return new MDCTextFieldIconFoundation(adapter)};return MDCTextFieldIcon}(MDCComponent);
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
 */
var MDCTextField=function(_super){__extends(MDCTextField,_super);function MDCTextField(){return _super!==null&&_super.apply(this,arguments)||this}MDCTextField.attachTo=function(root){return new MDCTextField(root)};MDCTextField.prototype.initialize=function(rippleFactory,lineRippleFactory,helperTextFactory,characterCounterFactory,iconFactory,labelFactory,outlineFactory){if(rippleFactory===void 0){rippleFactory=function(el,foundation){return new MDCRipple(el,foundation)}}if(lineRippleFactory===void 0){lineRippleFactory=function(el){return new MDCLineRipple(el)}}if(helperTextFactory===void 0){helperTextFactory=function(el){return new MDCTextFieldHelperText(el)}}if(characterCounterFactory===void 0){characterCounterFactory=function(el){return new MDCTextFieldCharacterCounter(el)}}if(iconFactory===void 0){iconFactory=function(el){return new MDCTextFieldIcon(el)}}if(labelFactory===void 0){labelFactory=function(el){return new MDCFloatingLabel(el)}}if(outlineFactory===void 0){outlineFactory=function(el){return new MDCNotchedOutline(el)}}this.input_=this.root.querySelector(textfield_constants_strings.INPUT_SELECTOR);var labelElement=this.root.querySelector(textfield_constants_strings.LABEL_SELECTOR);this.label_=labelElement?labelFactory(labelElement):null;var lineRippleElement=this.root.querySelector(textfield_constants_strings.LINE_RIPPLE_SELECTOR);this.lineRipple_=lineRippleElement?lineRippleFactory(lineRippleElement):null;var outlineElement=this.root.querySelector(textfield_constants_strings.OUTLINE_SELECTOR);this.outline_=outlineElement?outlineFactory(outlineElement):null;var helperTextStrings=MDCTextFieldHelperTextFoundation.strings;var nextElementSibling=this.root.nextElementSibling;var hasHelperLine=nextElementSibling&&nextElementSibling.classList.contains(textfield_constants_cssClasses.HELPER_LINE);var helperTextEl=hasHelperLine&&nextElementSibling&&nextElementSibling.querySelector(helperTextStrings.ROOT_SELECTOR);this.helperText_=helperTextEl?helperTextFactory(helperTextEl):null;var characterCounterStrings=MDCTextFieldCharacterCounterFoundation.strings;var characterCounterEl=this.root.querySelector(characterCounterStrings.ROOT_SELECTOR);if(!characterCounterEl&&hasHelperLine&&nextElementSibling){characterCounterEl=nextElementSibling.querySelector(characterCounterStrings.ROOT_SELECTOR)}this.characterCounter_=characterCounterEl?characterCounterFactory(characterCounterEl):null;var leadingIconEl=this.root.querySelector(textfield_constants_strings.LEADING_ICON_SELECTOR);this.leadingIcon_=leadingIconEl?iconFactory(leadingIconEl):null;var trailingIconEl=this.root.querySelector(textfield_constants_strings.TRAILING_ICON_SELECTOR);this.trailingIcon_=trailingIconEl?iconFactory(trailingIconEl):null;this.prefix_=this.root.querySelector(textfield_constants_strings.PREFIX_SELECTOR);this.suffix_=this.root.querySelector(textfield_constants_strings.SUFFIX_SELECTOR);this.ripple=this.createRipple_(rippleFactory)};MDCTextField.prototype.destroy=function(){if(this.ripple){this.ripple.destroy()}if(this.lineRipple_){this.lineRipple_.destroy()}if(this.helperText_){this.helperText_.destroy()}if(this.characterCounter_){this.characterCounter_.destroy()}if(this.leadingIcon_){this.leadingIcon_.destroy()}if(this.trailingIcon_){this.trailingIcon_.destroy()}if(this.label_){this.label_.destroy()}if(this.outline_){this.outline_.destroy()}_super.prototype.destroy.call(this)};MDCTextField.prototype.initialSyncWithDOM=function(){this.disabled=this.input_.disabled};Object.defineProperty(MDCTextField.prototype,"value",{get:function(){return this.foundation.getValue()},set:function(value){this.foundation.setValue(value)},enumerable:true,configurable:true});Object.defineProperty(MDCTextField.prototype,"disabled",{get:function(){return this.foundation.isDisabled()},set:function(disabled){this.foundation.setDisabled(disabled)},enumerable:true,configurable:true});Object.defineProperty(MDCTextField.prototype,"valid",{get:function(){return this.foundation.isValid()},set:function(valid){this.foundation.setValid(valid)},enumerable:true,configurable:true});Object.defineProperty(MDCTextField.prototype,"required",{get:function(){return this.input_.required},set:function(required){this.input_.required=required},enumerable:true,configurable:true});Object.defineProperty(MDCTextField.prototype,"pattern",{get:function(){return this.input_.pattern},set:function(pattern){this.input_.pattern=pattern},enumerable:true,configurable:true});Object.defineProperty(MDCTextField.prototype,"minLength",{get:function(){return this.input_.minLength},set:function(minLength){this.input_.minLength=minLength},enumerable:true,configurable:true});Object.defineProperty(MDCTextField.prototype,"maxLength",{get:function(){return this.input_.maxLength},set:function(maxLength){if(maxLength<0){this.input_.removeAttribute("maxLength")}else{this.input_.maxLength=maxLength}},enumerable:true,configurable:true});Object.defineProperty(MDCTextField.prototype,"min",{get:function(){return this.input_.min},set:function(min){this.input_.min=min},enumerable:true,configurable:true});Object.defineProperty(MDCTextField.prototype,"max",{get:function(){return this.input_.max},set:function(max){this.input_.max=max},enumerable:true,configurable:true});Object.defineProperty(MDCTextField.prototype,"step",{get:function(){return this.input_.step},set:function(step){this.input_.step=step},enumerable:true,configurable:true});Object.defineProperty(MDCTextField.prototype,"helperTextContent",{set:function(content){this.foundation.setHelperTextContent(content)},enumerable:true,configurable:true});Object.defineProperty(MDCTextField.prototype,"leadingIconAriaLabel",{set:function(label){this.foundation.setLeadingIconAriaLabel(label)},enumerable:true,configurable:true});Object.defineProperty(MDCTextField.prototype,"leadingIconContent",{set:function(content){this.foundation.setLeadingIconContent(content)},enumerable:true,configurable:true});Object.defineProperty(MDCTextField.prototype,"trailingIconAriaLabel",{set:function(label){this.foundation.setTrailingIconAriaLabel(label)},enumerable:true,configurable:true});Object.defineProperty(MDCTextField.prototype,"trailingIconContent",{set:function(content){this.foundation.setTrailingIconContent(content)},enumerable:true,configurable:true});Object.defineProperty(MDCTextField.prototype,"useNativeValidation",{set:function(useNativeValidation){this.foundation.setUseNativeValidation(useNativeValidation)},enumerable:true,configurable:true});Object.defineProperty(MDCTextField.prototype,"prefixText",{get:function(){return this.prefix_?this.prefix_.textContent:null},set:function(prefixText){if(this.prefix_){this.prefix_.textContent=prefixText}},enumerable:true,configurable:true});Object.defineProperty(MDCTextField.prototype,"suffixText",{get:function(){return this.suffix_?this.suffix_.textContent:null},set:function(suffixText){if(this.suffix_){this.suffix_.textContent=suffixText}},enumerable:true,configurable:true});MDCTextField.prototype.focus=function(){this.input_.focus()};MDCTextField.prototype.layout=function(){var openNotch=this.foundation.shouldFloat;this.foundation.notchOutline(openNotch)};MDCTextField.prototype.getDefaultFoundation=function(){var adapter=__assign(__assign(__assign(__assign(__assign({},this.getRootAdapterMethods_()),this.getInputAdapterMethods_()),this.getLabelAdapterMethods_()),this.getLineRippleAdapterMethods_()),this.getOutlineAdapterMethods_());return new MDCTextFieldFoundation(adapter,this.getFoundationMap_())};MDCTextField.prototype.getRootAdapterMethods_=function(){var _this=this;return{addClass:function(className){return _this.root.classList.add(className)},removeClass:function(className){return _this.root.classList.remove(className)},hasClass:function(className){return _this.root.classList.contains(className)},registerTextFieldInteractionHandler:function(evtType,handler){_this.listen(evtType,handler)},deregisterTextFieldInteractionHandler:function(evtType,handler){_this.unlisten(evtType,handler)},registerValidationAttributeChangeHandler:function(handler){var getAttributesList=function(mutationsList){return mutationsList.map((function(mutation){return mutation.attributeName})).filter((function(attributeName){return attributeName}))};var observer=new MutationObserver((function(mutationsList){return handler(getAttributesList(mutationsList))}));var config={attributes:true};observer.observe(_this.input_,config);return observer},deregisterValidationAttributeChangeHandler:function(observer){observer.disconnect()}}};MDCTextField.prototype.getInputAdapterMethods_=function(){var _this=this;return{getNativeInput:function(){return _this.input_},setInputAttr:function(attr,value){_this.input_.setAttribute(attr,value)},removeInputAttr:function(attr){_this.input_.removeAttribute(attr)},isFocused:function(){return document.activeElement===_this.input_},registerInputInteractionHandler:function(evtType,handler){_this.input_.addEventListener(evtType,handler,applyPassive())},deregisterInputInteractionHandler:function(evtType,handler){_this.input_.removeEventListener(evtType,handler,applyPassive())}}};MDCTextField.prototype.getLabelAdapterMethods_=function(){var _this=this;return{floatLabel:function(shouldFloat){return _this.label_&&_this.label_.float(shouldFloat)},getLabelWidth:function(){return _this.label_?_this.label_.getWidth():0},hasLabel:function(){return Boolean(_this.label_)},shakeLabel:function(shouldShake){return _this.label_&&_this.label_.shake(shouldShake)},setLabelRequired:function(isRequired){return _this.label_&&_this.label_.setRequired(isRequired)}}};MDCTextField.prototype.getLineRippleAdapterMethods_=function(){var _this=this;return{activateLineRipple:function(){if(_this.lineRipple_){_this.lineRipple_.activate()}},deactivateLineRipple:function(){if(_this.lineRipple_){_this.lineRipple_.deactivate()}},setLineRippleTransformOrigin:function(normalizedX){if(_this.lineRipple_){_this.lineRipple_.setRippleCenter(normalizedX)}}}};MDCTextField.prototype.getOutlineAdapterMethods_=function(){var _this=this;return{closeOutline:function(){return _this.outline_&&_this.outline_.closeNotch()},hasOutline:function(){return Boolean(_this.outline_)},notchOutline:function(labelWidth){return _this.outline_&&_this.outline_.notch(labelWidth)}}};MDCTextField.prototype.getFoundationMap_=function(){return{characterCounter:this.characterCounter_?this.characterCounter_.foundationForTextField:undefined,helperText:this.helperText_?this.helperText_.foundationForTextField:undefined,leadingIcon:this.leadingIcon_?this.leadingIcon_.foundationForTextField:undefined,trailingIcon:this.trailingIcon_?this.trailingIcon_.foundationForTextField:undefined}};MDCTextField.prototype.createRipple_=function(rippleFactory){var _this=this;var isTextArea=this.root.classList.contains(textfield_constants_cssClasses.TEXTAREA);var isOutlined=this.root.classList.contains(textfield_constants_cssClasses.OUTLINED);if(isTextArea||isOutlined){return null}var adapter=__assign(__assign({},MDCRipple.createAdapter(this)),{isSurfaceActive:function(){return matches(_this.input_,":active")},registerInteractionHandler:function(evtType,handler){return _this.input_.addEventListener(evtType,handler,applyPassive())},deregisterInteractionHandler:function(evtType,handler){return _this.input_.removeEventListener(evtType,handler,applyPassive())}});return rippleFactory(this.root,new MDCRippleFoundation(adapter))};return MDCTextField}(MDCComponent);
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var list_constants_cssClasses={LIST_ITEM_ACTIVATED_CLASS:"mdc-list-item--activated",LIST_ITEM_CLASS:"mdc-list-item",LIST_ITEM_DISABLED_CLASS:"mdc-list-item--disabled",LIST_ITEM_SELECTED_CLASS:"mdc-list-item--selected",LIST_ITEM_TEXT_CLASS:"mdc-list-item__text",LIST_ITEM_PRIMARY_TEXT_CLASS:"mdc-list-item__primary-text",ROOT:"mdc-list"};var list_constants_strings={ACTION_EVENT:"MDCList:action",ARIA_CHECKED:"aria-checked",ARIA_CHECKED_CHECKBOX_SELECTOR:'[role="checkbox"][aria-checked="true"]',ARIA_CHECKED_RADIO_SELECTOR:'[role="radio"][aria-checked="true"]',ARIA_CURRENT:"aria-current",ARIA_DISABLED:"aria-disabled",ARIA_ORIENTATION:"aria-orientation",ARIA_ORIENTATION_HORIZONTAL:"horizontal",ARIA_ROLE_CHECKBOX_SELECTOR:'[role="checkbox"]',ARIA_SELECTED:"aria-selected",CHECKBOX_RADIO_SELECTOR:'input[type="checkbox"], input[type="radio"]',CHECKBOX_SELECTOR:'input[type="checkbox"]',CHILD_ELEMENTS_TO_TOGGLE_TABINDEX:"\n    ."+list_constants_cssClasses.LIST_ITEM_CLASS+" button:not(:disabled),\n    ."+list_constants_cssClasses.LIST_ITEM_CLASS+" a\n  ",FOCUSABLE_CHILD_ELEMENTS:"\n    ."+list_constants_cssClasses.LIST_ITEM_CLASS+" button:not(:disabled),\n    ."+list_constants_cssClasses.LIST_ITEM_CLASS+" a,\n    ."+list_constants_cssClasses.LIST_ITEM_CLASS+' input[type="radio"]:not(:disabled),\n    .'+list_constants_cssClasses.LIST_ITEM_CLASS+' input[type="checkbox"]:not(:disabled)\n  ',RADIO_SELECTOR:'input[type="radio"]'};var list_constants_numbers={UNSET_INDEX:-1,TYPEAHEAD_BUFFER_CLEAR_TIMEOUT_MS:300};
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
 */
var KEY={UNKNOWN:"Unknown",BACKSPACE:"Backspace",ENTER:"Enter",SPACEBAR:"Spacebar",PAGE_UP:"PageUp",PAGE_DOWN:"PageDown",END:"End",HOME:"Home",ARROW_LEFT:"ArrowLeft",ARROW_UP:"ArrowUp",ARROW_RIGHT:"ArrowRight",ARROW_DOWN:"ArrowDown",DELETE:"Delete",ESCAPE:"Escape"};var normalizedKeys=new Set;normalizedKeys.add(KEY.BACKSPACE);normalizedKeys.add(KEY.ENTER);normalizedKeys.add(KEY.SPACEBAR);normalizedKeys.add(KEY.PAGE_UP);normalizedKeys.add(KEY.PAGE_DOWN);normalizedKeys.add(KEY.END);normalizedKeys.add(KEY.HOME);normalizedKeys.add(KEY.ARROW_LEFT);normalizedKeys.add(KEY.ARROW_UP);normalizedKeys.add(KEY.ARROW_RIGHT);normalizedKeys.add(KEY.ARROW_DOWN);normalizedKeys.add(KEY.DELETE);normalizedKeys.add(KEY.ESCAPE);var KEY_CODE={BACKSPACE:8,ENTER:13,SPACEBAR:32,PAGE_UP:33,PAGE_DOWN:34,END:35,HOME:36,ARROW_LEFT:37,ARROW_UP:38,ARROW_RIGHT:39,ARROW_DOWN:40,DELETE:46,ESCAPE:27};var mappedKeyCodes=new Map;mappedKeyCodes.set(KEY_CODE.BACKSPACE,KEY.BACKSPACE);mappedKeyCodes.set(KEY_CODE.ENTER,KEY.ENTER);mappedKeyCodes.set(KEY_CODE.SPACEBAR,KEY.SPACEBAR);mappedKeyCodes.set(KEY_CODE.PAGE_UP,KEY.PAGE_UP);mappedKeyCodes.set(KEY_CODE.PAGE_DOWN,KEY.PAGE_DOWN);mappedKeyCodes.set(KEY_CODE.END,KEY.END);mappedKeyCodes.set(KEY_CODE.HOME,KEY.HOME);mappedKeyCodes.set(KEY_CODE.ARROW_LEFT,KEY.ARROW_LEFT);mappedKeyCodes.set(KEY_CODE.ARROW_UP,KEY.ARROW_UP);mappedKeyCodes.set(KEY_CODE.ARROW_RIGHT,KEY.ARROW_RIGHT);mappedKeyCodes.set(KEY_CODE.ARROW_DOWN,KEY.ARROW_DOWN);mappedKeyCodes.set(KEY_CODE.DELETE,KEY.DELETE);mappedKeyCodes.set(KEY_CODE.ESCAPE,KEY.ESCAPE);var navigationKeys=new Set;navigationKeys.add(KEY.PAGE_UP);navigationKeys.add(KEY.PAGE_DOWN);navigationKeys.add(KEY.END);navigationKeys.add(KEY.HOME);navigationKeys.add(KEY.ARROW_LEFT);navigationKeys.add(KEY.ARROW_UP);navigationKeys.add(KEY.ARROW_RIGHT);navigationKeys.add(KEY.ARROW_DOWN);function normalizeKey(evt){var key=evt.key;if(normalizedKeys.has(key)){return key}var mappedKey=mappedKeyCodes.get(evt.keyCode);if(mappedKey){return mappedKey}return KEY.UNKNOWN}function isNavigationEvent(evt){return navigationKeys.has(normalizeKey(evt))}
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
 */
var ELEMENTS_KEY_ALLOWED_IN=["input","button","textarea","select"];var preventDefaultEvent=function(evt){var target=evt.target;if(!target){return}var tagName=(""+target.tagName).toLowerCase();if(ELEMENTS_KEY_ALLOWED_IN.indexOf(tagName)===-1){evt.preventDefault()}};
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
 */
function initState(){var state={bufferClearTimeout:0,currentFirstChar:"",sortedIndexCursor:0,typeaheadBuffer:""};return state}function initSortedIndex(listItemCount,getPrimaryTextByItemIndex){var sortedIndexByFirstChar=new Map;for(var i=0;i<listItemCount;i++){var primaryText=getPrimaryTextByItemIndex(i).trim();if(!primaryText){continue}var firstChar=primaryText[0].toLowerCase();if(!sortedIndexByFirstChar.has(firstChar)){sortedIndexByFirstChar.set(firstChar,[])}sortedIndexByFirstChar.get(firstChar).push({text:primaryText.toLowerCase(),index:i})}sortedIndexByFirstChar.forEach((function(values){values.sort((function(first,second){return first.index-second.index}))}));return sortedIndexByFirstChar}function matchItem(opts,state){var nextChar=opts.nextChar,focusItemAtIndex=opts.focusItemAtIndex,sortedIndexByFirstChar=opts.sortedIndexByFirstChar,focusedItemIndex=opts.focusedItemIndex,skipFocus=opts.skipFocus,isItemAtIndexDisabled=opts.isItemAtIndexDisabled;clearTimeout(state.bufferClearTimeout);state.bufferClearTimeout=setTimeout((function(){clearBuffer(state)}),list_constants_numbers.TYPEAHEAD_BUFFER_CLEAR_TIMEOUT_MS);state.typeaheadBuffer=state.typeaheadBuffer+nextChar;var index;if(state.typeaheadBuffer.length===1){index=matchFirstChar(sortedIndexByFirstChar,focusedItemIndex,isItemAtIndexDisabled,state)}else{index=matchAllChars(sortedIndexByFirstChar,isItemAtIndexDisabled,state)}if(index!==-1&&!skipFocus){focusItemAtIndex(index)}return index}function matchFirstChar(sortedIndexByFirstChar,focusedItemIndex,isItemAtIndexDisabled,state){var firstChar=state.typeaheadBuffer[0];var itemsMatchingFirstChar=sortedIndexByFirstChar.get(firstChar);if(!itemsMatchingFirstChar){return-1}if(firstChar===state.currentFirstChar&&itemsMatchingFirstChar[state.sortedIndexCursor].index===focusedItemIndex){state.sortedIndexCursor=(state.sortedIndexCursor+1)%itemsMatchingFirstChar.length;var newIndex=itemsMatchingFirstChar[state.sortedIndexCursor].index;if(!isItemAtIndexDisabled(newIndex)){return newIndex}}state.currentFirstChar=firstChar;var newCursorPosition=-1;var cursorPosition;for(cursorPosition=0;cursorPosition<itemsMatchingFirstChar.length;cursorPosition++){if(!isItemAtIndexDisabled(itemsMatchingFirstChar[cursorPosition].index)){newCursorPosition=cursorPosition;break}}for(;cursorPosition<itemsMatchingFirstChar.length;cursorPosition++){if(itemsMatchingFirstChar[cursorPosition].index>focusedItemIndex&&!isItemAtIndexDisabled(itemsMatchingFirstChar[cursorPosition].index)){newCursorPosition=cursorPosition;break}}if(newCursorPosition!==-1){state.sortedIndexCursor=newCursorPosition;return itemsMatchingFirstChar[state.sortedIndexCursor].index}return-1}function matchAllChars(sortedIndexByFirstChar,isItemAtIndexDisabled,state){var firstChar=state.typeaheadBuffer[0];var itemsMatchingFirstChar=sortedIndexByFirstChar.get(firstChar);if(!itemsMatchingFirstChar){return-1}var startingItem=itemsMatchingFirstChar[state.sortedIndexCursor];if(startingItem.text.lastIndexOf(state.typeaheadBuffer,0)===0&&!isItemAtIndexDisabled(startingItem.index)){return startingItem.index}var cursorPosition=(state.sortedIndexCursor+1)%itemsMatchingFirstChar.length;var nextCursorPosition=-1;while(cursorPosition!==state.sortedIndexCursor){var currentItem=itemsMatchingFirstChar[cursorPosition];var matches=currentItem.text.lastIndexOf(state.typeaheadBuffer,0)===0;var isEnabled=!isItemAtIndexDisabled(currentItem.index);if(matches&&isEnabled){nextCursorPosition=cursorPosition;break}cursorPosition=(cursorPosition+1)%itemsMatchingFirstChar.length}if(nextCursorPosition!==-1){state.sortedIndexCursor=nextCursorPosition;return itemsMatchingFirstChar[state.sortedIndexCursor].index}return-1}function isTypingInProgress(state){return state.typeaheadBuffer.length>0}function clearBuffer(state){state.typeaheadBuffer=""}function handleKeydown(opts,state){var event=opts.event,isTargetListItem=opts.isTargetListItem,focusedItemIndex=opts.focusedItemIndex,focusItemAtIndex=opts.focusItemAtIndex,sortedIndexByFirstChar=opts.sortedIndexByFirstChar,isItemAtIndexDisabled=opts.isItemAtIndexDisabled;var isArrowLeft=normalizeKey(event)==="ArrowLeft";var isArrowUp=normalizeKey(event)==="ArrowUp";var isArrowRight=normalizeKey(event)==="ArrowRight";var isArrowDown=normalizeKey(event)==="ArrowDown";var isHome=normalizeKey(event)==="Home";var isEnd=normalizeKey(event)==="End";var isEnter=normalizeKey(event)==="Enter";var isSpace=normalizeKey(event)==="Spacebar";if(isArrowLeft||isArrowUp||isArrowRight||isArrowDown||isHome||isEnd||isEnter){return-1}var isCharacterKey=!isSpace&&event.key.length===1;if(isCharacterKey){preventDefaultEvent(event);var matchItemOpts={focusItemAtIndex:focusItemAtIndex,focusedItemIndex:focusedItemIndex,nextChar:event.key.toLowerCase(),sortedIndexByFirstChar:sortedIndexByFirstChar,skipFocus:false,isItemAtIndexDisabled:isItemAtIndexDisabled};return matchItem(matchItemOpts,state)}if(!isSpace){return-1}if(isTargetListItem){preventDefaultEvent(event)}var typeaheadOnListItem=isTargetListItem&&isTypingInProgress(state);if(typeaheadOnListItem){var matchItemOpts={focusItemAtIndex:focusItemAtIndex,focusedItemIndex:focusedItemIndex,nextChar:" ",sortedIndexByFirstChar:sortedIndexByFirstChar,skipFocus:false,isItemAtIndexDisabled:isItemAtIndexDisabled};return matchItem(matchItemOpts,state)}return-1}
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
function isNumberArray(selectedIndex){return selectedIndex instanceof Array}var MDCListFoundation=function(_super){__extends(MDCListFoundation,_super);function MDCListFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCListFoundation.defaultAdapter),adapter))||this;_this.wrapFocus_=false;_this.isVertical_=true;_this.isSingleSelectionList_=false;_this.selectedIndex_=list_constants_numbers.UNSET_INDEX;_this.focusedItemIndex=list_constants_numbers.UNSET_INDEX;_this.useActivatedClass_=false;_this.useSelectedAttr_=false;_this.ariaCurrentAttrValue_=null;_this.isCheckboxList_=false;_this.isRadioList_=false;_this.hasTypeahead=false;_this.typeaheadState=initState();_this.sortedIndexByFirstChar=new Map;return _this}Object.defineProperty(MDCListFoundation,"strings",{get:function(){return list_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCListFoundation,"cssClasses",{get:function(){return list_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCListFoundation,"numbers",{get:function(){return list_constants_numbers},enumerable:true,configurable:true});Object.defineProperty(MDCListFoundation,"defaultAdapter",{get:function(){return{addClassForElementIndex:function(){return undefined},focusItemAtIndex:function(){return undefined},getAttributeForElementIndex:function(){return null},getFocusedElementIndex:function(){return 0},getListItemCount:function(){return 0},hasCheckboxAtIndex:function(){return false},hasRadioAtIndex:function(){return false},isCheckboxCheckedAtIndex:function(){return false},isFocusInsideList:function(){return false},isRootFocused:function(){return false},listItemAtIndexHasClass:function(){return false},notifyAction:function(){return undefined},removeClassForElementIndex:function(){return undefined},setAttributeForElementIndex:function(){return undefined},setCheckedCheckboxOrRadioAtIndex:function(){return undefined},setTabIndexForListItemChildren:function(){return undefined},getPrimaryTextAtIndex:function(){return""}}},enumerable:true,configurable:true});MDCListFoundation.prototype.layout=function(){if(this.adapter.getListItemCount()===0){return}if(this.adapter.hasCheckboxAtIndex(0)){this.isCheckboxList_=true}else if(this.adapter.hasRadioAtIndex(0)){this.isRadioList_=true}else{this.maybeInitializeSingleSelection()}if(this.hasTypeahead){this.sortedIndexByFirstChar=this.typeaheadInitSortedIndex()}};MDCListFoundation.prototype.setWrapFocus=function(value){this.wrapFocus_=value};MDCListFoundation.prototype.setVerticalOrientation=function(value){this.isVertical_=value};MDCListFoundation.prototype.setSingleSelection=function(value){this.isSingleSelectionList_=value;if(value){this.maybeInitializeSingleSelection()}};MDCListFoundation.prototype.maybeInitializeSingleSelection=function(){for(var i=0;i<this.adapter.getListItemCount();i++){var hasSelectedClass=this.adapter.listItemAtIndexHasClass(i,list_constants_cssClasses.LIST_ITEM_SELECTED_CLASS);var hasActivatedClass=this.adapter.listItemAtIndexHasClass(i,list_constants_cssClasses.LIST_ITEM_ACTIVATED_CLASS);if(!(hasSelectedClass||hasActivatedClass)){continue}if(hasActivatedClass){this.setUseActivatedClass(true)}this.isSingleSelectionList_=true;this.selectedIndex_=i;return}};MDCListFoundation.prototype.setHasTypeahead=function(hasTypeahead){this.hasTypeahead=hasTypeahead;if(hasTypeahead){this.sortedIndexByFirstChar=this.typeaheadInitSortedIndex()}};MDCListFoundation.prototype.isTypeaheadInProgress=function(){return this.hasTypeahead&&isTypingInProgress(this.typeaheadState)};MDCListFoundation.prototype.setUseActivatedClass=function(useActivated){this.useActivatedClass_=useActivated};MDCListFoundation.prototype.setUseSelectedAttribute=function(useSelected){this.useSelectedAttr_=useSelected};MDCListFoundation.prototype.getSelectedIndex=function(){return this.selectedIndex_};MDCListFoundation.prototype.setSelectedIndex=function(index){if(!this.isIndexValid_(index)){return}if(this.isCheckboxList_){this.setCheckboxAtIndex_(index)}else if(this.isRadioList_){this.setRadioAtIndex_(index)}else{this.setSingleSelectionAtIndex_(index)}};MDCListFoundation.prototype.handleFocusIn=function(_,listItemIndex){if(listItemIndex>=0){this.focusedItemIndex=listItemIndex;this.adapter.setAttributeForElementIndex(listItemIndex,"tabindex","0");this.adapter.setTabIndexForListItemChildren(listItemIndex,"0")}};MDCListFoundation.prototype.handleFocusOut=function(_,listItemIndex){var _this=this;if(listItemIndex>=0){this.adapter.setAttributeForElementIndex(listItemIndex,"tabindex","-1");this.adapter.setTabIndexForListItemChildren(listItemIndex,"-1")}setTimeout((function(){if(!_this.adapter.isFocusInsideList()){_this.setTabindexToFirstSelectedOrFocusedItem()}}),0)};MDCListFoundation.prototype.handleKeydown=function(event,isRootListItem,listItemIndex){var _this=this;var isArrowLeft=normalizeKey(event)==="ArrowLeft";var isArrowUp=normalizeKey(event)==="ArrowUp";var isArrowRight=normalizeKey(event)==="ArrowRight";var isArrowDown=normalizeKey(event)==="ArrowDown";var isHome=normalizeKey(event)==="Home";var isEnd=normalizeKey(event)==="End";var isEnter=normalizeKey(event)==="Enter";var isSpace=normalizeKey(event)==="Spacebar";var isLetterA=event.key==="A"||event.key==="a";if(this.adapter.isRootFocused()){if(isArrowUp||isEnd){event.preventDefault();this.focusLastElement()}else if(isArrowDown||isHome){event.preventDefault();this.focusFirstElement()}if(this.hasTypeahead){var handleKeydownOpts={event:event,focusItemAtIndex:function(index){_this.focusItemAtIndex(index)},focusedItemIndex:-1,isTargetListItem:isRootListItem,sortedIndexByFirstChar:this.sortedIndexByFirstChar,isItemAtIndexDisabled:function(index){return _this.adapter.listItemAtIndexHasClass(index,list_constants_cssClasses.LIST_ITEM_DISABLED_CLASS)}};handleKeydown(handleKeydownOpts,this.typeaheadState)}return}var currentIndex=this.adapter.getFocusedElementIndex();if(currentIndex===-1){currentIndex=listItemIndex;if(currentIndex<0){return}}if(this.isVertical_&&isArrowDown||!this.isVertical_&&isArrowRight){preventDefaultEvent(event);this.focusNextElement(currentIndex)}else if(this.isVertical_&&isArrowUp||!this.isVertical_&&isArrowLeft){preventDefaultEvent(event);this.focusPrevElement(currentIndex)}else if(isHome){preventDefaultEvent(event);this.focusFirstElement()}else if(isEnd){preventDefaultEvent(event);this.focusLastElement()}else if(isLetterA&&event.ctrlKey&&this.isCheckboxList_){event.preventDefault();this.toggleAll(this.selectedIndex_===list_constants_numbers.UNSET_INDEX?[]:this.selectedIndex_)}else if(isEnter||isSpace){if(isRootListItem){var target=event.target;if(target&&target.tagName==="A"&&isEnter){return}preventDefaultEvent(event);if(this.adapter.listItemAtIndexHasClass(currentIndex,list_constants_cssClasses.LIST_ITEM_DISABLED_CLASS)){return}if(!this.isTypeaheadInProgress()){if(this.isSelectableList_()){this.setSelectedIndexOnAction_(currentIndex)}this.adapter.notifyAction(currentIndex)}}}if(this.hasTypeahead){var handleKeydownOpts={event:event,focusItemAtIndex:function(index){_this.focusItemAtIndex(index)},focusedItemIndex:this.focusedItemIndex,isTargetListItem:isRootListItem,sortedIndexByFirstChar:this.sortedIndexByFirstChar,isItemAtIndexDisabled:function(index){return _this.adapter.listItemAtIndexHasClass(index,list_constants_cssClasses.LIST_ITEM_DISABLED_CLASS)}};handleKeydown(handleKeydownOpts,this.typeaheadState)}};MDCListFoundation.prototype.handleClick=function(index,toggleCheckbox){if(index===list_constants_numbers.UNSET_INDEX){return}if(this.adapter.listItemAtIndexHasClass(index,list_constants_cssClasses.LIST_ITEM_DISABLED_CLASS)){return}if(this.isSelectableList_()){this.setSelectedIndexOnAction_(index,toggleCheckbox)}this.adapter.notifyAction(index)};MDCListFoundation.prototype.focusNextElement=function(index){var count=this.adapter.getListItemCount();var nextIndex=index+1;if(nextIndex>=count){if(this.wrapFocus_){nextIndex=0}else{return index}}this.focusItemAtIndex(nextIndex);return nextIndex};MDCListFoundation.prototype.focusPrevElement=function(index){var prevIndex=index-1;if(prevIndex<0){if(this.wrapFocus_){prevIndex=this.adapter.getListItemCount()-1}else{return index}}this.focusItemAtIndex(prevIndex);return prevIndex};MDCListFoundation.prototype.focusFirstElement=function(){this.focusItemAtIndex(0);return 0};MDCListFoundation.prototype.focusLastElement=function(){var lastIndex=this.adapter.getListItemCount()-1;this.focusItemAtIndex(lastIndex);return lastIndex};MDCListFoundation.prototype.focusInitialElement=function(){var initialIndex=this.getFirstSelectedOrFocusedItemIndex();this.focusItemAtIndex(initialIndex);return initialIndex};MDCListFoundation.prototype.setEnabled=function(itemIndex,isEnabled){if(!this.isIndexValid_(itemIndex)){return}if(isEnabled){this.adapter.removeClassForElementIndex(itemIndex,list_constants_cssClasses.LIST_ITEM_DISABLED_CLASS);this.adapter.setAttributeForElementIndex(itemIndex,list_constants_strings.ARIA_DISABLED,"false")}else{this.adapter.addClassForElementIndex(itemIndex,list_constants_cssClasses.LIST_ITEM_DISABLED_CLASS);this.adapter.setAttributeForElementIndex(itemIndex,list_constants_strings.ARIA_DISABLED,"true")}};MDCListFoundation.prototype.setSingleSelectionAtIndex_=function(index){if(this.selectedIndex_===index){return}var selectedClassName=list_constants_cssClasses.LIST_ITEM_SELECTED_CLASS;if(this.useActivatedClass_){selectedClassName=list_constants_cssClasses.LIST_ITEM_ACTIVATED_CLASS}if(this.selectedIndex_!==list_constants_numbers.UNSET_INDEX){this.adapter.removeClassForElementIndex(this.selectedIndex_,selectedClassName)}this.setAriaForSingleSelectionAtIndex_(index);this.setTabindexAtIndex(index);if(index!==list_constants_numbers.UNSET_INDEX){this.adapter.addClassForElementIndex(index,selectedClassName)}this.selectedIndex_=index};MDCListFoundation.prototype.setAriaForSingleSelectionAtIndex_=function(index){if(this.selectedIndex_===list_constants_numbers.UNSET_INDEX){this.ariaCurrentAttrValue_=this.adapter.getAttributeForElementIndex(index,list_constants_strings.ARIA_CURRENT)}var isAriaCurrent=this.ariaCurrentAttrValue_!==null;var ariaAttribute=isAriaCurrent?list_constants_strings.ARIA_CURRENT:list_constants_strings.ARIA_SELECTED;if(this.selectedIndex_!==list_constants_numbers.UNSET_INDEX){this.adapter.setAttributeForElementIndex(this.selectedIndex_,ariaAttribute,"false")}if(index!==list_constants_numbers.UNSET_INDEX){var ariaAttributeValue=isAriaCurrent?this.ariaCurrentAttrValue_:"true";this.adapter.setAttributeForElementIndex(index,ariaAttribute,ariaAttributeValue)}};MDCListFoundation.prototype.getSelectionAttribute=function(){return this.useSelectedAttr_?list_constants_strings.ARIA_SELECTED:list_constants_strings.ARIA_CHECKED};MDCListFoundation.prototype.setRadioAtIndex_=function(index){var selectionAttribute=this.getSelectionAttribute();this.adapter.setCheckedCheckboxOrRadioAtIndex(index,true);if(this.selectedIndex_!==list_constants_numbers.UNSET_INDEX){this.adapter.setAttributeForElementIndex(this.selectedIndex_,selectionAttribute,"false")}this.adapter.setAttributeForElementIndex(index,selectionAttribute,"true");this.selectedIndex_=index};MDCListFoundation.prototype.setCheckboxAtIndex_=function(index){var selectionAttribute=this.getSelectionAttribute();for(var i=0;i<this.adapter.getListItemCount();i++){var isChecked=false;if(index.indexOf(i)>=0){isChecked=true}this.adapter.setCheckedCheckboxOrRadioAtIndex(i,isChecked);this.adapter.setAttributeForElementIndex(i,selectionAttribute,isChecked?"true":"false")}this.selectedIndex_=index};MDCListFoundation.prototype.setTabindexAtIndex=function(index){if(this.focusedItemIndex===list_constants_numbers.UNSET_INDEX&&index!==0){this.adapter.setAttributeForElementIndex(0,"tabindex","-1")}else if(this.focusedItemIndex>=0&&this.focusedItemIndex!==index){this.adapter.setAttributeForElementIndex(this.focusedItemIndex,"tabindex","-1")}if(!(this.selectedIndex_ instanceof Array)&&this.selectedIndex_!==index){this.adapter.setAttributeForElementIndex(this.selectedIndex_,"tabindex","-1")}if(index!==list_constants_numbers.UNSET_INDEX){this.adapter.setAttributeForElementIndex(index,"tabindex","0")}};MDCListFoundation.prototype.isSelectableList_=function(){return this.isSingleSelectionList_||this.isCheckboxList_||this.isRadioList_};MDCListFoundation.prototype.setTabindexToFirstSelectedOrFocusedItem=function(){var targetIndex=this.getFirstSelectedOrFocusedItemIndex();this.setTabindexAtIndex(targetIndex)};MDCListFoundation.prototype.getFirstSelectedOrFocusedItemIndex=function(){var targetIndex=this.focusedItemIndex>=0?this.focusedItemIndex:0;if(this.isSelectableList_()){if(typeof this.selectedIndex_==="number"&&this.selectedIndex_!==list_constants_numbers.UNSET_INDEX){targetIndex=this.selectedIndex_}else if(isNumberArray(this.selectedIndex_)&&this.selectedIndex_.length>0){targetIndex=this.selectedIndex_.reduce((function(currentIndex,minIndex){return Math.min(currentIndex,minIndex)}))}}return targetIndex};MDCListFoundation.prototype.isIndexValid_=function(index){var _this=this;if(index instanceof Array){if(!this.isCheckboxList_){throw new Error("MDCListFoundation: Array of index is only supported for checkbox based list")}if(index.length===0){return true}else{return index.some((function(i){return _this.isIndexInRange_(i)}))}}else if(typeof index==="number"){if(this.isCheckboxList_){throw new Error("MDCListFoundation: Expected array of index for checkbox based list but got number: "+index)}return this.isIndexInRange_(index)||this.isSingleSelectionList_&&index===list_constants_numbers.UNSET_INDEX}else{return false}};MDCListFoundation.prototype.isIndexInRange_=function(index){var listSize=this.adapter.getListItemCount();return index>=0&&index<listSize};MDCListFoundation.prototype.setSelectedIndexOnAction_=function(index,toggleCheckbox){if(toggleCheckbox===void 0){toggleCheckbox=true}if(this.isCheckboxList_){this.toggleCheckboxAtIndex_(index,toggleCheckbox)}else{this.setSelectedIndex(index)}};MDCListFoundation.prototype.toggleCheckboxAtIndex_=function(index,toggleCheckbox){var selectionAttribute=this.getSelectionAttribute();var isChecked=this.adapter.isCheckboxCheckedAtIndex(index);if(toggleCheckbox){isChecked=!isChecked;this.adapter.setCheckedCheckboxOrRadioAtIndex(index,isChecked)}this.adapter.setAttributeForElementIndex(index,selectionAttribute,isChecked?"true":"false");var selectedIndexes=this.selectedIndex_===list_constants_numbers.UNSET_INDEX?[]:this.selectedIndex_.slice();if(isChecked){selectedIndexes.push(index)}else{selectedIndexes=selectedIndexes.filter((function(i){return i!==index}))}this.selectedIndex_=selectedIndexes};MDCListFoundation.prototype.focusItemAtIndex=function(index){this.adapter.focusItemAtIndex(index);this.focusedItemIndex=index};MDCListFoundation.prototype.toggleAll=function(currentlySelectedIndexes){var count=this.adapter.getListItemCount();if(currentlySelectedIndexes.length===count){this.setCheckboxAtIndex_([])}else{var allIndexes=[];for(var i=0;i<count;i++){if(!this.adapter.listItemAtIndexHasClass(i,list_constants_cssClasses.LIST_ITEM_DISABLED_CLASS)||currentlySelectedIndexes.indexOf(i)>-1){allIndexes.push(i)}}this.setCheckboxAtIndex_(allIndexes)}};MDCListFoundation.prototype.typeaheadMatchItem=function(nextChar,startingIndex,skipFocus){var _this=this;if(skipFocus===void 0){skipFocus=false}var opts={focusItemAtIndex:function(index){_this.focusItemAtIndex(index)},focusedItemIndex:startingIndex?startingIndex:this.focusedItemIndex,nextChar:nextChar,sortedIndexByFirstChar:this.sortedIndexByFirstChar,skipFocus:skipFocus,isItemAtIndexDisabled:function(index){return _this.adapter.listItemAtIndexHasClass(index,list_constants_cssClasses.LIST_ITEM_DISABLED_CLASS)}};return matchItem(opts,this.typeaheadState)};MDCListFoundation.prototype.typeaheadInitSortedIndex=function(){return initSortedIndex(this.adapter.getListItemCount(),this.adapter.getPrimaryTextAtIndex)};MDCListFoundation.prototype.clearTypeaheadBuffer=function(){clearBuffer(this.typeaheadState)};return MDCListFoundation}(MDCFoundation);const list_foundation=null&&MDCListFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCList=function(_super){__extends(MDCList,_super);function MDCList(){return _super!==null&&_super.apply(this,arguments)||this}Object.defineProperty(MDCList.prototype,"vertical",{set:function(value){this.foundation.setVerticalOrientation(value)},enumerable:true,configurable:true});Object.defineProperty(MDCList.prototype,"listElements",{get:function(){return[].slice.call(this.root.querySelectorAll("."+list_constants_cssClasses.LIST_ITEM_CLASS))},enumerable:true,configurable:true});Object.defineProperty(MDCList.prototype,"wrapFocus",{set:function(value){this.foundation.setWrapFocus(value)},enumerable:true,configurable:true});Object.defineProperty(MDCList.prototype,"typeaheadInProgress",{get:function(){return this.foundation.isTypeaheadInProgress()},enumerable:true,configurable:true});Object.defineProperty(MDCList.prototype,"hasTypeahead",{set:function(hasTypeahead){this.foundation.setHasTypeahead(hasTypeahead)},enumerable:true,configurable:true});Object.defineProperty(MDCList.prototype,"singleSelection",{set:function(isSingleSelectionList){this.foundation.setSingleSelection(isSingleSelectionList)},enumerable:true,configurable:true});Object.defineProperty(MDCList.prototype,"selectedIndex",{get:function(){return this.foundation.getSelectedIndex()},set:function(index){this.foundation.setSelectedIndex(index)},enumerable:true,configurable:true});MDCList.attachTo=function(root){return new MDCList(root)};MDCList.prototype.initialSyncWithDOM=function(){this.handleClick_=this.handleClickEvent_.bind(this);this.handleKeydown_=this.handleKeydownEvent_.bind(this);this.focusInEventListener_=this.handleFocusInEvent_.bind(this);this.focusOutEventListener_=this.handleFocusOutEvent_.bind(this);this.listen("keydown",this.handleKeydown_);this.listen("click",this.handleClick_);this.listen("focusin",this.focusInEventListener_);this.listen("focusout",this.focusOutEventListener_);this.layout();this.initializeListType()};MDCList.prototype.destroy=function(){this.unlisten("keydown",this.handleKeydown_);this.unlisten("click",this.handleClick_);this.unlisten("focusin",this.focusInEventListener_);this.unlisten("focusout",this.focusOutEventListener_)};MDCList.prototype.layout=function(){var direction=this.root.getAttribute(list_constants_strings.ARIA_ORIENTATION);this.vertical=direction!==list_constants_strings.ARIA_ORIENTATION_HORIZONTAL;[].slice.call(this.root.querySelectorAll(".mdc-list-item:not([tabindex])")).forEach((function(el){el.setAttribute("tabindex","-1")}));[].slice.call(this.root.querySelectorAll(list_constants_strings.FOCUSABLE_CHILD_ELEMENTS)).forEach((function(el){return el.setAttribute("tabindex","-1")}));this.foundation.layout()};MDCList.prototype.getPrimaryText=function(item){var primaryText=item.querySelector("."+list_constants_cssClasses.LIST_ITEM_PRIMARY_TEXT_CLASS);if(primaryText){return primaryText.textContent||""}var singleLineText=item.querySelector("."+list_constants_cssClasses.LIST_ITEM_TEXT_CLASS);return singleLineText&&singleLineText.textContent||""};MDCList.prototype.initializeListType=function(){var _this=this;var checkboxListItems=this.root.querySelectorAll(list_constants_strings.ARIA_ROLE_CHECKBOX_SELECTOR);var radioSelectedListItem=this.root.querySelector(list_constants_strings.ARIA_CHECKED_RADIO_SELECTOR);if(checkboxListItems.length){var preselectedItems=this.root.querySelectorAll(list_constants_strings.ARIA_CHECKED_CHECKBOX_SELECTOR);this.selectedIndex=[].map.call(preselectedItems,(function(listItem){return _this.listElements.indexOf(listItem)}))}else if(radioSelectedListItem){this.selectedIndex=this.listElements.indexOf(radioSelectedListItem)}};MDCList.prototype.setEnabled=function(itemIndex,isEnabled){this.foundation.setEnabled(itemIndex,isEnabled)};MDCList.prototype.typeaheadMatchItem=function(nextChar,startingIndex){return this.foundation.typeaheadMatchItem(nextChar,startingIndex,true)};MDCList.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClassForElementIndex:function(index,className){var element=_this.listElements[index];if(element){element.classList.add(className)}},focusItemAtIndex:function(index){var element=_this.listElements[index];if(element){element.focus()}},getAttributeForElementIndex:function(index,attr){return _this.listElements[index].getAttribute(attr)},getFocusedElementIndex:function(){return _this.listElements.indexOf(document.activeElement)},getListItemCount:function(){return _this.listElements.length},getPrimaryTextAtIndex:function(index){return _this.getPrimaryText(_this.listElements[index])},hasCheckboxAtIndex:function(index){var listItem=_this.listElements[index];return!!listItem.querySelector(list_constants_strings.CHECKBOX_SELECTOR)},hasRadioAtIndex:function(index){var listItem=_this.listElements[index];return!!listItem.querySelector(list_constants_strings.RADIO_SELECTOR)},isCheckboxCheckedAtIndex:function(index){var listItem=_this.listElements[index];var toggleEl=listItem.querySelector(list_constants_strings.CHECKBOX_SELECTOR);return toggleEl.checked},isFocusInsideList:function(){return _this.root!==document.activeElement&&_this.root.contains(document.activeElement)},isRootFocused:function(){return document.activeElement===_this.root},listItemAtIndexHasClass:function(index,className){return _this.listElements[index].classList.contains(className)},notifyAction:function(index){_this.emit(list_constants_strings.ACTION_EVENT,{index:index},true)},removeClassForElementIndex:function(index,className){var element=_this.listElements[index];if(element){element.classList.remove(className)}},setAttributeForElementIndex:function(index,attr,value){var element=_this.listElements[index];if(element){element.setAttribute(attr,value)}},setCheckedCheckboxOrRadioAtIndex:function(index,isChecked){var listItem=_this.listElements[index];var toggleEl=listItem.querySelector(list_constants_strings.CHECKBOX_RADIO_SELECTOR);toggleEl.checked=isChecked;var event=document.createEvent("Event");event.initEvent("change",true,true);toggleEl.dispatchEvent(event)},setTabIndexForListItemChildren:function(listItemIndex,tabIndexValue){var element=_this.listElements[listItemIndex];var listItemChildren=[].slice.call(element.querySelectorAll(list_constants_strings.CHILD_ELEMENTS_TO_TOGGLE_TABINDEX));listItemChildren.forEach((function(el){return el.setAttribute("tabindex",tabIndexValue)}))}};return new MDCListFoundation(adapter)};MDCList.prototype.getListItemIndex_=function(evt){var eventTarget=evt.target;var nearestParent=closest(eventTarget,"."+list_constants_cssClasses.LIST_ITEM_CLASS+", ."+list_constants_cssClasses.ROOT);if(nearestParent&&matches(nearestParent,"."+list_constants_cssClasses.LIST_ITEM_CLASS)){return this.listElements.indexOf(nearestParent)}return-1};MDCList.prototype.handleFocusInEvent_=function(evt){var index=this.getListItemIndex_(evt);this.foundation.handleFocusIn(evt,index)};MDCList.prototype.handleFocusOutEvent_=function(evt){var index=this.getListItemIndex_(evt);this.foundation.handleFocusOut(evt,index)};MDCList.prototype.handleKeydownEvent_=function(evt){var index=this.getListItemIndex_(evt);var target=evt.target;this.foundation.handleKeydown(evt,target.classList.contains(list_constants_cssClasses.LIST_ITEM_CLASS),index)};MDCList.prototype.handleClickEvent_=function(evt){var index=this.getListItemIndex_(evt);var target=evt.target;var toggleCheckbox=!matches(target,list_constants_strings.CHECKBOX_RADIO_SELECTOR);this.foundation.handleClick(index,toggleCheckbox)};return MDCList}(MDCComponent);
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var menu_surface_constants_cssClasses={ANCHOR:"mdc-menu-surface--anchor",ANIMATING_CLOSED:"mdc-menu-surface--animating-closed",ANIMATING_OPEN:"mdc-menu-surface--animating-open",FIXED:"mdc-menu-surface--fixed",IS_OPEN_BELOW:"mdc-menu-surface--is-open-below",OPEN:"mdc-menu-surface--open",ROOT:"mdc-menu-surface"};var menu_surface_constants_strings={CLOSED_EVENT:"MDCMenuSurface:closed",OPENED_EVENT:"MDCMenuSurface:opened",FOCUSABLE_ELEMENTS:["button:not(:disabled)",'[href]:not([aria-disabled="true"])',"input:not(:disabled)","select:not(:disabled)","textarea:not(:disabled)",'[tabindex]:not([tabindex="-1"]):not([aria-disabled="true"])'].join(", ")};var menu_surface_constants_numbers={TRANSITION_OPEN_DURATION:120,TRANSITION_CLOSE_DURATION:75,MARGIN_TO_EDGE:32,ANCHOR_TO_MENU_SURFACE_WIDTH_RATIO:.67};var CornerBit;(function(CornerBit){CornerBit[CornerBit["BOTTOM"]=1]="BOTTOM";CornerBit[CornerBit["CENTER"]=2]="CENTER";CornerBit[CornerBit["RIGHT"]=4]="RIGHT";CornerBit[CornerBit["FLIP_RTL"]=8]="FLIP_RTL"})(CornerBit||(CornerBit={}));var Corner;(function(Corner){Corner[Corner["TOP_LEFT"]=0]="TOP_LEFT";Corner[Corner["TOP_RIGHT"]=4]="TOP_RIGHT";Corner[Corner["BOTTOM_LEFT"]=1]="BOTTOM_LEFT";Corner[Corner["BOTTOM_RIGHT"]=5]="BOTTOM_RIGHT";Corner[Corner["TOP_START"]=8]="TOP_START";Corner[Corner["TOP_END"]=12]="TOP_END";Corner[Corner["BOTTOM_START"]=9]="BOTTOM_START";Corner[Corner["BOTTOM_END"]=13]="BOTTOM_END"})(Corner||(Corner={}));
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCMenuSurfaceFoundation=function(_super){__extends(MDCMenuSurfaceFoundation,_super);function MDCMenuSurfaceFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCMenuSurfaceFoundation.defaultAdapter),adapter))||this;_this.isSurfaceOpen=false;_this.isQuickOpen=false;_this.isHoistedElement=false;_this.isFixedPosition=false;_this.openAnimationEndTimerId=0;_this.closeAnimationEndTimerId=0;_this.animationRequestId=0;_this.anchorCorner=Corner.TOP_START;_this.originCorner=Corner.TOP_START;_this.anchorMargin={top:0,right:0,bottom:0,left:0};_this.position={x:0,y:0};return _this}Object.defineProperty(MDCMenuSurfaceFoundation,"cssClasses",{get:function(){return menu_surface_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCMenuSurfaceFoundation,"strings",{get:function(){return menu_surface_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCMenuSurfaceFoundation,"numbers",{get:function(){return menu_surface_constants_numbers},enumerable:true,configurable:true});Object.defineProperty(MDCMenuSurfaceFoundation,"Corner",{get:function(){return Corner},enumerable:true,configurable:true});Object.defineProperty(MDCMenuSurfaceFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},removeClass:function(){return undefined},hasClass:function(){return false},hasAnchor:function(){return false},isElementInContainer:function(){return false},isFocused:function(){return false},isRtl:function(){return false},getInnerDimensions:function(){return{height:0,width:0}},getAnchorDimensions:function(){return null},getWindowDimensions:function(){return{height:0,width:0}},getBodyDimensions:function(){return{height:0,width:0}},getWindowScroll:function(){return{x:0,y:0}},setPosition:function(){return undefined},setMaxHeight:function(){return undefined},setTransformOrigin:function(){return undefined},saveFocus:function(){return undefined},restoreFocus:function(){return undefined},notifyClose:function(){return undefined},notifyOpen:function(){return undefined}}},enumerable:true,configurable:true});MDCMenuSurfaceFoundation.prototype.init=function(){var _a=MDCMenuSurfaceFoundation.cssClasses,ROOT=_a.ROOT,OPEN=_a.OPEN;if(!this.adapter.hasClass(ROOT)){throw new Error(ROOT+" class required in root element.")}if(this.adapter.hasClass(OPEN)){this.isSurfaceOpen=true}};MDCMenuSurfaceFoundation.prototype.destroy=function(){clearTimeout(this.openAnimationEndTimerId);clearTimeout(this.closeAnimationEndTimerId);cancelAnimationFrame(this.animationRequestId)};MDCMenuSurfaceFoundation.prototype.setAnchorCorner=function(corner){this.anchorCorner=corner};MDCMenuSurfaceFoundation.prototype.flipCornerHorizontally=function(){this.originCorner=this.originCorner^CornerBit.RIGHT};MDCMenuSurfaceFoundation.prototype.setAnchorMargin=function(margin){this.anchorMargin.top=margin.top||0;this.anchorMargin.right=margin.right||0;this.anchorMargin.bottom=margin.bottom||0;this.anchorMargin.left=margin.left||0};MDCMenuSurfaceFoundation.prototype.setIsHoisted=function(isHoisted){this.isHoistedElement=isHoisted};MDCMenuSurfaceFoundation.prototype.setFixedPosition=function(isFixedPosition){this.isFixedPosition=isFixedPosition};MDCMenuSurfaceFoundation.prototype.setAbsolutePosition=function(x,y){this.position.x=this.isFinite(x)?x:0;this.position.y=this.isFinite(y)?y:0};MDCMenuSurfaceFoundation.prototype.setQuickOpen=function(quickOpen){this.isQuickOpen=quickOpen};MDCMenuSurfaceFoundation.prototype.isOpen=function(){return this.isSurfaceOpen};MDCMenuSurfaceFoundation.prototype.open=function(){var _this=this;if(this.isSurfaceOpen){return}this.adapter.saveFocus();if(this.isQuickOpen){this.isSurfaceOpen=true;this.adapter.addClass(MDCMenuSurfaceFoundation.cssClasses.OPEN);this.dimensions=this.adapter.getInnerDimensions();this.autoposition();this.adapter.notifyOpen()}else{this.adapter.addClass(MDCMenuSurfaceFoundation.cssClasses.ANIMATING_OPEN);this.animationRequestId=requestAnimationFrame((function(){_this.adapter.addClass(MDCMenuSurfaceFoundation.cssClasses.OPEN);_this.dimensions=_this.adapter.getInnerDimensions();_this.autoposition();_this.openAnimationEndTimerId=setTimeout((function(){_this.openAnimationEndTimerId=0;_this.adapter.removeClass(MDCMenuSurfaceFoundation.cssClasses.ANIMATING_OPEN);_this.adapter.notifyOpen()}),menu_surface_constants_numbers.TRANSITION_OPEN_DURATION)}));this.isSurfaceOpen=true}};MDCMenuSurfaceFoundation.prototype.close=function(skipRestoreFocus){var _this=this;if(skipRestoreFocus===void 0){skipRestoreFocus=false}if(!this.isSurfaceOpen){return}if(this.isQuickOpen){this.isSurfaceOpen=false;if(!skipRestoreFocus){this.maybeRestoreFocus()}this.adapter.removeClass(MDCMenuSurfaceFoundation.cssClasses.OPEN);this.adapter.removeClass(MDCMenuSurfaceFoundation.cssClasses.IS_OPEN_BELOW);this.adapter.notifyClose()}else{this.adapter.addClass(MDCMenuSurfaceFoundation.cssClasses.ANIMATING_CLOSED);requestAnimationFrame((function(){_this.adapter.removeClass(MDCMenuSurfaceFoundation.cssClasses.OPEN);_this.adapter.removeClass(MDCMenuSurfaceFoundation.cssClasses.IS_OPEN_BELOW);_this.closeAnimationEndTimerId=setTimeout((function(){_this.closeAnimationEndTimerId=0;_this.adapter.removeClass(MDCMenuSurfaceFoundation.cssClasses.ANIMATING_CLOSED);_this.adapter.notifyClose()}),menu_surface_constants_numbers.TRANSITION_CLOSE_DURATION)}));this.isSurfaceOpen=false;if(!skipRestoreFocus){this.maybeRestoreFocus()}}};MDCMenuSurfaceFoundation.prototype.handleBodyClick=function(evt){var el=evt.target;if(this.adapter.isElementInContainer(el)){return}this.close()};MDCMenuSurfaceFoundation.prototype.handleKeydown=function(evt){var keyCode=evt.keyCode,key=evt.key;var isEscape=key==="Escape"||keyCode===27;if(isEscape){this.close()}};MDCMenuSurfaceFoundation.prototype.autoposition=function(){var _a;this.measurements=this.getAutoLayoutmeasurements();var corner=this.getoriginCorner();var maxMenuSurfaceHeight=this.getMenuSurfaceMaxHeight(corner);var verticalAlignment=this.hasBit(corner,CornerBit.BOTTOM)?"bottom":"top";var horizontalAlignment=this.hasBit(corner,CornerBit.RIGHT)?"right":"left";var horizontalOffset=this.getHorizontalOriginOffset(corner);var verticalOffset=this.getVerticalOriginOffset(corner);var _b=this.measurements,anchorSize=_b.anchorSize,surfaceSize=_b.surfaceSize;var position=(_a={},_a[horizontalAlignment]=horizontalOffset,_a[verticalAlignment]=verticalOffset,_a);if(anchorSize.width/surfaceSize.width>menu_surface_constants_numbers.ANCHOR_TO_MENU_SURFACE_WIDTH_RATIO){horizontalAlignment="center"}if(this.isHoistedElement||this.isFixedPosition){this.adjustPositionForHoistedElement(position)}this.adapter.setTransformOrigin(horizontalAlignment+" "+verticalAlignment);this.adapter.setPosition(position);this.adapter.setMaxHeight(maxMenuSurfaceHeight?maxMenuSurfaceHeight+"px":"");if(!this.hasBit(corner,CornerBit.BOTTOM)){this.adapter.addClass(MDCMenuSurfaceFoundation.cssClasses.IS_OPEN_BELOW)}};MDCMenuSurfaceFoundation.prototype.getAutoLayoutmeasurements=function(){var anchorRect=this.adapter.getAnchorDimensions();var bodySize=this.adapter.getBodyDimensions();var viewportSize=this.adapter.getWindowDimensions();var windowScroll=this.adapter.getWindowScroll();if(!anchorRect){anchorRect={top:this.position.y,right:this.position.x,bottom:this.position.y,left:this.position.x,width:0,height:0}}return{anchorSize:anchorRect,bodySize:bodySize,surfaceSize:this.dimensions,viewportDistance:{top:anchorRect.top,right:viewportSize.width-anchorRect.right,bottom:viewportSize.height-anchorRect.bottom,left:anchorRect.left},viewportSize:viewportSize,windowScroll:windowScroll}};MDCMenuSurfaceFoundation.prototype.getoriginCorner=function(){var corner=this.originCorner;var _a=this.measurements,viewportDistance=_a.viewportDistance,anchorSize=_a.anchorSize,surfaceSize=_a.surfaceSize;var MARGIN_TO_EDGE=MDCMenuSurfaceFoundation.numbers.MARGIN_TO_EDGE;var isAnchoredToBottom=this.hasBit(this.anchorCorner,CornerBit.BOTTOM);var availableTop;var availableBottom;if(isAnchoredToBottom){availableTop=viewportDistance.top-MARGIN_TO_EDGE+anchorSize.height+this.anchorMargin.bottom;availableBottom=viewportDistance.bottom-MARGIN_TO_EDGE-this.anchorMargin.bottom}else{availableTop=viewportDistance.top-MARGIN_TO_EDGE+this.anchorMargin.top;availableBottom=viewportDistance.bottom-MARGIN_TO_EDGE+anchorSize.height-this.anchorMargin.top}var isAvailableBottom=availableBottom-surfaceSize.height>0;if(!isAvailableBottom&&availableTop>=availableBottom){corner=this.setBit(corner,CornerBit.BOTTOM)}var isRtl=this.adapter.isRtl();var isFlipRtl=this.hasBit(this.anchorCorner,CornerBit.FLIP_RTL);var hasRightBit=this.hasBit(this.anchorCorner,CornerBit.RIGHT)||this.hasBit(corner,CornerBit.RIGHT);var isAnchoredToRight=false;if(isRtl&&isFlipRtl){isAnchoredToRight=!hasRightBit}else{isAnchoredToRight=hasRightBit}var availableLeft;var availableRight;if(isAnchoredToRight){availableLeft=viewportDistance.left+anchorSize.width+this.anchorMargin.right;availableRight=viewportDistance.right-this.anchorMargin.right}else{availableLeft=viewportDistance.left+this.anchorMargin.left;availableRight=viewportDistance.right+anchorSize.width-this.anchorMargin.left}var isAvailableLeft=availableLeft-surfaceSize.width>0;var isAvailableRight=availableRight-surfaceSize.width>0;var isOriginCornerAlignedToEnd=this.hasBit(corner,CornerBit.FLIP_RTL)&&this.hasBit(corner,CornerBit.RIGHT);if(isAvailableRight&&isOriginCornerAlignedToEnd&&isRtl||!isAvailableLeft&&isOriginCornerAlignedToEnd){corner=this.unsetBit(corner,CornerBit.RIGHT)}else if(isAvailableLeft&&isAnchoredToRight&&isRtl||isAvailableLeft&&!isAnchoredToRight&&hasRightBit||!isAvailableRight&&availableLeft>=availableRight){corner=this.setBit(corner,CornerBit.RIGHT)}return corner};MDCMenuSurfaceFoundation.prototype.getMenuSurfaceMaxHeight=function(corner){var viewportDistance=this.measurements.viewportDistance;var maxHeight=0;var isBottomAligned=this.hasBit(corner,CornerBit.BOTTOM);var isBottomAnchored=this.hasBit(this.anchorCorner,CornerBit.BOTTOM);var MARGIN_TO_EDGE=MDCMenuSurfaceFoundation.numbers.MARGIN_TO_EDGE;if(isBottomAligned){maxHeight=viewportDistance.top+this.anchorMargin.top-MARGIN_TO_EDGE;if(!isBottomAnchored){maxHeight+=this.measurements.anchorSize.height}}else{maxHeight=viewportDistance.bottom-this.anchorMargin.bottom+this.measurements.anchorSize.height-MARGIN_TO_EDGE;if(isBottomAnchored){maxHeight-=this.measurements.anchorSize.height}}return maxHeight};MDCMenuSurfaceFoundation.prototype.getHorizontalOriginOffset=function(corner){var anchorSize=this.measurements.anchorSize;var isRightAligned=this.hasBit(corner,CornerBit.RIGHT);var avoidHorizontalOverlap=this.hasBit(this.anchorCorner,CornerBit.RIGHT);if(isRightAligned){var rightOffset=avoidHorizontalOverlap?anchorSize.width-this.anchorMargin.left:this.anchorMargin.right;if(this.isHoistedElement||this.isFixedPosition){return rightOffset-(this.measurements.viewportSize.width-this.measurements.bodySize.width)}return rightOffset}return avoidHorizontalOverlap?anchorSize.width-this.anchorMargin.right:this.anchorMargin.left};MDCMenuSurfaceFoundation.prototype.getVerticalOriginOffset=function(corner){var anchorSize=this.measurements.anchorSize;var isBottomAligned=this.hasBit(corner,CornerBit.BOTTOM);var avoidVerticalOverlap=this.hasBit(this.anchorCorner,CornerBit.BOTTOM);var y=0;if(isBottomAligned){y=avoidVerticalOverlap?anchorSize.height-this.anchorMargin.top:-this.anchorMargin.bottom}else{y=avoidVerticalOverlap?anchorSize.height+this.anchorMargin.bottom:this.anchorMargin.top}return y};MDCMenuSurfaceFoundation.prototype.adjustPositionForHoistedElement=function(position){var e_1,_a;var _b=this.measurements,windowScroll=_b.windowScroll,viewportDistance=_b.viewportDistance;var props=Object.keys(position);try{for(var props_1=__values(props),props_1_1=props_1.next();!props_1_1.done;props_1_1=props_1.next()){var prop=props_1_1.value;var value=position[prop]||0;value+=viewportDistance[prop];if(!this.isFixedPosition){if(prop==="top"){value+=windowScroll.y}else if(prop==="bottom"){value-=windowScroll.y}else if(prop==="left"){value+=windowScroll.x}else{value-=windowScroll.x}}position[prop]=value}}catch(e_1_1){e_1={error:e_1_1}}finally{try{if(props_1_1&&!props_1_1.done&&(_a=props_1.return))_a.call(props_1)}finally{if(e_1)throw e_1.error}}};MDCMenuSurfaceFoundation.prototype.maybeRestoreFocus=function(){var isRootFocused=this.adapter.isFocused();var childHasFocus=document.activeElement&&this.adapter.isElementInContainer(document.activeElement);if(isRootFocused||childHasFocus){this.adapter.restoreFocus()}};MDCMenuSurfaceFoundation.prototype.hasBit=function(corner,bit){return Boolean(corner&bit)};MDCMenuSurfaceFoundation.prototype.setBit=function(corner,bit){return corner|bit};MDCMenuSurfaceFoundation.prototype.unsetBit=function(corner,bit){return corner^bit};MDCMenuSurfaceFoundation.prototype.isFinite=function(num){return typeof num==="number"&&isFinite(num)};return MDCMenuSurfaceFoundation}(MDCFoundation);const menu_surface_foundation=null&&MDCMenuSurfaceFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var cachedCssTransformPropertyName_;function getTransformPropertyName(globalObj,forceRefresh){if(forceRefresh===void 0){forceRefresh=false}if(cachedCssTransformPropertyName_===undefined||forceRefresh){var el=globalObj.document.createElement("div");cachedCssTransformPropertyName_="transform"in el.style?"transform":"webkitTransform"}return cachedCssTransformPropertyName_}
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCMenuSurface=function(_super){__extends(MDCMenuSurface,_super);function MDCMenuSurface(){return _super!==null&&_super.apply(this,arguments)||this}MDCMenuSurface.attachTo=function(root){return new MDCMenuSurface(root)};MDCMenuSurface.prototype.initialSyncWithDOM=function(){var _this=this;var parentEl=this.root.parentElement;this.anchorElement=parentEl&&parentEl.classList.contains(menu_surface_constants_cssClasses.ANCHOR)?parentEl:null;if(this.root.classList.contains(menu_surface_constants_cssClasses.FIXED)){this.setFixedPosition(true)}this.handleKeydown=function(event){_this.foundation.handleKeydown(event)};this.handleBodyClick=function(event){_this.foundation.handleBodyClick(event)};this.registerBodyClickListener=function(){document.body.addEventListener("click",_this.handleBodyClick,{capture:true})};this.deregisterBodyClickListener=function(){document.body.removeEventListener("click",_this.handleBodyClick,{capture:true})};this.listen("keydown",this.handleKeydown);this.listen(menu_surface_constants_strings.OPENED_EVENT,this.registerBodyClickListener);this.listen(menu_surface_constants_strings.CLOSED_EVENT,this.deregisterBodyClickListener)};MDCMenuSurface.prototype.destroy=function(){this.unlisten("keydown",this.handleKeydown);this.unlisten(menu_surface_constants_strings.OPENED_EVENT,this.registerBodyClickListener);this.unlisten(menu_surface_constants_strings.CLOSED_EVENT,this.deregisterBodyClickListener);_super.prototype.destroy.call(this)};MDCMenuSurface.prototype.isOpen=function(){return this.foundation.isOpen()};MDCMenuSurface.prototype.open=function(){this.foundation.open()};MDCMenuSurface.prototype.close=function(skipRestoreFocus){if(skipRestoreFocus===void 0){skipRestoreFocus=false}this.foundation.close(skipRestoreFocus)};Object.defineProperty(MDCMenuSurface.prototype,"quickOpen",{set:function(quickOpen){this.foundation.setQuickOpen(quickOpen)},enumerable:true,configurable:true});MDCMenuSurface.prototype.setIsHoisted=function(isHoisted){this.foundation.setIsHoisted(isHoisted)};MDCMenuSurface.prototype.setMenuSurfaceAnchorElement=function(element){this.anchorElement=element};MDCMenuSurface.prototype.setFixedPosition=function(isFixed){if(isFixed){this.root.classList.add(menu_surface_constants_cssClasses.FIXED)}else{this.root.classList.remove(menu_surface_constants_cssClasses.FIXED)}this.foundation.setFixedPosition(isFixed)};MDCMenuSurface.prototype.setAbsolutePosition=function(x,y){this.foundation.setAbsolutePosition(x,y);this.setIsHoisted(true)};MDCMenuSurface.prototype.setAnchorCorner=function(corner){this.foundation.setAnchorCorner(corner)};MDCMenuSurface.prototype.setAnchorMargin=function(margin){this.foundation.setAnchorMargin(margin)};MDCMenuSurface.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClass:function(className){return _this.root.classList.add(className)},removeClass:function(className){return _this.root.classList.remove(className)},hasClass:function(className){return _this.root.classList.contains(className)},hasAnchor:function(){return!!_this.anchorElement},notifyClose:function(){return _this.emit(MDCMenuSurfaceFoundation.strings.CLOSED_EVENT,{})},notifyOpen:function(){return _this.emit(MDCMenuSurfaceFoundation.strings.OPENED_EVENT,{})},isElementInContainer:function(el){return _this.root.contains(el)},isRtl:function(){return getComputedStyle(_this.root).getPropertyValue("direction")==="rtl"},setTransformOrigin:function(origin){var propertyName=getTransformPropertyName(window)+"-origin";_this.root.style.setProperty(propertyName,origin)},isFocused:function(){return document.activeElement===_this.root},saveFocus:function(){_this.previousFocus=document.activeElement},restoreFocus:function(){if(_this.root.contains(document.activeElement)){if(_this.previousFocus&&_this.previousFocus.focus){_this.previousFocus.focus()}}},getInnerDimensions:function(){return{width:_this.root.offsetWidth,height:_this.root.offsetHeight}},getAnchorDimensions:function(){return _this.anchorElement?_this.anchorElement.getBoundingClientRect():null},getWindowDimensions:function(){return{width:window.innerWidth,height:window.innerHeight}},getBodyDimensions:function(){return{width:document.body.clientWidth,height:document.body.clientHeight}},getWindowScroll:function(){return{x:window.pageXOffset,y:window.pageYOffset}},setPosition:function(position){var rootHTML=_this.root;rootHTML.style.left="left"in position?position.left+"px":"";rootHTML.style.right="right"in position?position.right+"px":"";rootHTML.style.top="top"in position?position.top+"px":"";rootHTML.style.bottom="bottom"in position?position.bottom+"px":""},setMaxHeight:function(height){_this.root.style.maxHeight=height}};return new MDCMenuSurfaceFoundation(adapter)};return MDCMenuSurface}(MDCComponent);
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var menu_constants_cssClasses={MENU_SELECTED_LIST_ITEM:"mdc-menu-item--selected",MENU_SELECTION_GROUP:"mdc-menu__selection-group",ROOT:"mdc-menu"};var menu_constants_strings={ARIA_CHECKED_ATTR:"aria-checked",ARIA_DISABLED_ATTR:"aria-disabled",CHECKBOX_SELECTOR:'input[type="checkbox"]',LIST_SELECTOR:".mdc-list",SELECTED_EVENT:"MDCMenu:selected"};var menu_constants_numbers={FOCUS_ROOT_INDEX:-1};var DefaultFocusState;(function(DefaultFocusState){DefaultFocusState[DefaultFocusState["NONE"]=0]="NONE";DefaultFocusState[DefaultFocusState["LIST_ROOT"]=1]="LIST_ROOT";DefaultFocusState[DefaultFocusState["FIRST_ITEM"]=2]="FIRST_ITEM";DefaultFocusState[DefaultFocusState["LAST_ITEM"]=3]="LAST_ITEM"})(DefaultFocusState||(DefaultFocusState={}));
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCMenuFoundation=function(_super){__extends(MDCMenuFoundation,_super);function MDCMenuFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCMenuFoundation.defaultAdapter),adapter))||this;_this.closeAnimationEndTimerId_=0;_this.defaultFocusState_=DefaultFocusState.LIST_ROOT;return _this}Object.defineProperty(MDCMenuFoundation,"cssClasses",{get:function(){return menu_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCMenuFoundation,"strings",{get:function(){return menu_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCMenuFoundation,"numbers",{get:function(){return menu_constants_numbers},enumerable:true,configurable:true});Object.defineProperty(MDCMenuFoundation,"defaultAdapter",{get:function(){return{addClassToElementAtIndex:function(){return undefined},removeClassFromElementAtIndex:function(){return undefined},addAttributeToElementAtIndex:function(){return undefined},removeAttributeFromElementAtIndex:function(){return undefined},elementContainsClass:function(){return false},closeSurface:function(){return undefined},getElementIndex:function(){return-1},notifySelected:function(){return undefined},getMenuItemCount:function(){return 0},focusItemAtIndex:function(){return undefined},focusListRoot:function(){return undefined},getSelectedSiblingOfItemAtIndex:function(){return-1},isSelectableItemAtIndex:function(){return false}}},enumerable:true,configurable:true});MDCMenuFoundation.prototype.destroy=function(){if(this.closeAnimationEndTimerId_){clearTimeout(this.closeAnimationEndTimerId_)}this.adapter.closeSurface()};MDCMenuFoundation.prototype.handleKeydown=function(evt){var key=evt.key,keyCode=evt.keyCode;var isTab=key==="Tab"||keyCode===9;if(isTab){this.adapter.closeSurface(true)}};MDCMenuFoundation.prototype.handleItemAction=function(listItem){var _this=this;var index=this.adapter.getElementIndex(listItem);if(index<0){return}this.adapter.notifySelected({index:index});this.adapter.closeSurface();this.closeAnimationEndTimerId_=setTimeout((function(){var recomputedIndex=_this.adapter.getElementIndex(listItem);if(recomputedIndex>=0&&_this.adapter.isSelectableItemAtIndex(recomputedIndex)){_this.setSelectedIndex(recomputedIndex)}}),MDCMenuSurfaceFoundation.numbers.TRANSITION_CLOSE_DURATION)};MDCMenuFoundation.prototype.handleMenuSurfaceOpened=function(){switch(this.defaultFocusState_){case DefaultFocusState.FIRST_ITEM:this.adapter.focusItemAtIndex(0);break;case DefaultFocusState.LAST_ITEM:this.adapter.focusItemAtIndex(this.adapter.getMenuItemCount()-1);break;case DefaultFocusState.NONE:break;default:this.adapter.focusListRoot();break}};MDCMenuFoundation.prototype.setDefaultFocusState=function(focusState){this.defaultFocusState_=focusState};MDCMenuFoundation.prototype.setSelectedIndex=function(index){this.validatedIndex_(index);if(!this.adapter.isSelectableItemAtIndex(index)){throw new Error("MDCMenuFoundation: No selection group at specified index.")}var prevSelectedIndex=this.adapter.getSelectedSiblingOfItemAtIndex(index);if(prevSelectedIndex>=0){this.adapter.removeAttributeFromElementAtIndex(prevSelectedIndex,menu_constants_strings.ARIA_CHECKED_ATTR);this.adapter.removeClassFromElementAtIndex(prevSelectedIndex,menu_constants_cssClasses.MENU_SELECTED_LIST_ITEM)}this.adapter.addClassToElementAtIndex(index,menu_constants_cssClasses.MENU_SELECTED_LIST_ITEM);this.adapter.addAttributeToElementAtIndex(index,menu_constants_strings.ARIA_CHECKED_ATTR,"true")};MDCMenuFoundation.prototype.setEnabled=function(index,isEnabled){this.validatedIndex_(index);if(isEnabled){this.adapter.removeClassFromElementAtIndex(index,list_constants_cssClasses.LIST_ITEM_DISABLED_CLASS);this.adapter.addAttributeToElementAtIndex(index,menu_constants_strings.ARIA_DISABLED_ATTR,"false")}else{this.adapter.addClassToElementAtIndex(index,list_constants_cssClasses.LIST_ITEM_DISABLED_CLASS);this.adapter.addAttributeToElementAtIndex(index,menu_constants_strings.ARIA_DISABLED_ATTR,"true")}};MDCMenuFoundation.prototype.validatedIndex_=function(index){var menuSize=this.adapter.getMenuItemCount();var isIndexInRange=index>=0&&index<menuSize;if(!isIndexInRange){throw new Error("MDCMenuFoundation: No list item at specified index.")}};return MDCMenuFoundation}(MDCFoundation);const menu_foundation=null&&MDCMenuFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCMenu=function(_super){__extends(MDCMenu,_super);function MDCMenu(){return _super!==null&&_super.apply(this,arguments)||this}MDCMenu.attachTo=function(root){return new MDCMenu(root)};MDCMenu.prototype.initialize=function(menuSurfaceFactory,listFactory){if(menuSurfaceFactory===void 0){menuSurfaceFactory=function(el){return new MDCMenuSurface(el)}}if(listFactory===void 0){listFactory=function(el){return new MDCList(el)}}this.menuSurfaceFactory_=menuSurfaceFactory;this.listFactory_=listFactory};MDCMenu.prototype.initialSyncWithDOM=function(){var _this=this;this.menuSurface_=this.menuSurfaceFactory_(this.root);var list=this.root.querySelector(menu_constants_strings.LIST_SELECTOR);if(list){this.list_=this.listFactory_(list);this.list_.wrapFocus=true}else{this.list_=null}this.handleKeydown_=function(evt){return _this.foundation.handleKeydown(evt)};this.handleItemAction_=function(evt){return _this.foundation.handleItemAction(_this.items[evt.detail.index])};this.handleMenuSurfaceOpened_=function(){return _this.foundation.handleMenuSurfaceOpened()};this.menuSurface_.listen(MDCMenuSurfaceFoundation.strings.OPENED_EVENT,this.handleMenuSurfaceOpened_);this.listen("keydown",this.handleKeydown_);this.listen(MDCListFoundation.strings.ACTION_EVENT,this.handleItemAction_)};MDCMenu.prototype.destroy=function(){if(this.list_){this.list_.destroy()}this.menuSurface_.destroy();this.menuSurface_.unlisten(MDCMenuSurfaceFoundation.strings.OPENED_EVENT,this.handleMenuSurfaceOpened_);this.unlisten("keydown",this.handleKeydown_);this.unlisten(MDCListFoundation.strings.ACTION_EVENT,this.handleItemAction_);_super.prototype.destroy.call(this)};Object.defineProperty(MDCMenu.prototype,"open",{get:function(){return this.menuSurface_.isOpen()},set:function(value){if(value){this.menuSurface_.open()}else{this.menuSurface_.close()}},enumerable:true,configurable:true});Object.defineProperty(MDCMenu.prototype,"wrapFocus",{get:function(){return this.list_?this.list_.wrapFocus:false},set:function(value){if(this.list_){this.list_.wrapFocus=value}},enumerable:true,configurable:true});Object.defineProperty(MDCMenu.prototype,"hasTypeahead",{set:function(value){if(this.list_){this.list_.hasTypeahead=value}},enumerable:true,configurable:true});Object.defineProperty(MDCMenu.prototype,"typeaheadInProgress",{get:function(){return this.list_?this.list_.typeaheadInProgress:false},enumerable:true,configurable:true});MDCMenu.prototype.typeaheadMatchItem=function(nextChar,startingIndex){if(this.list_){return this.list_.typeaheadMatchItem(nextChar,startingIndex)}return-1};MDCMenu.prototype.layout=function(){if(this.list_){this.list_.layout()}};Object.defineProperty(MDCMenu.prototype,"items",{get:function(){return this.list_?this.list_.listElements:[]},enumerable:true,configurable:true});Object.defineProperty(MDCMenu.prototype,"singleSelection",{set:function(singleSelection){if(this.list_){this.list_.singleSelection=singleSelection}},enumerable:true,configurable:true});Object.defineProperty(MDCMenu.prototype,"selectedIndex",{get:function(){return this.list_?this.list_.selectedIndex:list_constants_numbers.UNSET_INDEX},set:function(index){if(this.list_){this.list_.selectedIndex=index}},enumerable:true,configurable:true});Object.defineProperty(MDCMenu.prototype,"quickOpen",{set:function(quickOpen){this.menuSurface_.quickOpen=quickOpen},enumerable:true,configurable:true});MDCMenu.prototype.setDefaultFocusState=function(focusState){this.foundation.setDefaultFocusState(focusState)};MDCMenu.prototype.setAnchorCorner=function(corner){this.menuSurface_.setAnchorCorner(corner)};MDCMenu.prototype.setAnchorMargin=function(margin){this.menuSurface_.setAnchorMargin(margin)};MDCMenu.prototype.setSelectedIndex=function(index){this.foundation.setSelectedIndex(index)};MDCMenu.prototype.setEnabled=function(index,isEnabled){this.foundation.setEnabled(index,isEnabled)};MDCMenu.prototype.getOptionByIndex=function(index){var items=this.items;if(index<items.length){return this.items[index]}else{return null}};MDCMenu.prototype.getPrimaryTextAtIndex=function(index){var item=this.getOptionByIndex(index);if(item&&this.list_){return this.list_.getPrimaryText(item)||""}return""};MDCMenu.prototype.setFixedPosition=function(isFixed){this.menuSurface_.setFixedPosition(isFixed)};MDCMenu.prototype.setIsHoisted=function(isHoisted){this.menuSurface_.setIsHoisted(isHoisted)};MDCMenu.prototype.setAbsolutePosition=function(x,y){this.menuSurface_.setAbsolutePosition(x,y)};MDCMenu.prototype.setAnchorElement=function(element){this.menuSurface_.anchorElement=element};MDCMenu.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClassToElementAtIndex:function(index,className){var list=_this.items;list[index].classList.add(className)},removeClassFromElementAtIndex:function(index,className){var list=_this.items;list[index].classList.remove(className)},addAttributeToElementAtIndex:function(index,attr,value){var list=_this.items;list[index].setAttribute(attr,value)},removeAttributeFromElementAtIndex:function(index,attr){var list=_this.items;list[index].removeAttribute(attr)},elementContainsClass:function(element,className){return element.classList.contains(className)},closeSurface:function(skipRestoreFocus){return _this.menuSurface_.close(skipRestoreFocus)},getElementIndex:function(element){return _this.items.indexOf(element)},notifySelected:function(evtData){return _this.emit(menu_constants_strings.SELECTED_EVENT,{index:evtData.index,item:_this.items[evtData.index]})},getMenuItemCount:function(){return _this.items.length},focusItemAtIndex:function(index){return _this.items[index].focus()},focusListRoot:function(){return _this.root.querySelector(menu_constants_strings.LIST_SELECTOR).focus()},isSelectableItemAtIndex:function(index){return!!closest(_this.items[index],"."+menu_constants_cssClasses.MENU_SELECTION_GROUP)},getSelectedSiblingOfItemAtIndex:function(index){var selectionGroupEl=closest(_this.items[index],"."+menu_constants_cssClasses.MENU_SELECTION_GROUP);var selectedItemEl=selectionGroupEl.querySelector("."+menu_constants_cssClasses.MENU_SELECTED_LIST_ITEM);return selectedItemEl?_this.items.indexOf(selectedItemEl):-1}};return new MDCMenuFoundation(adapter)};return MDCMenu}(MDCComponent);function init(textElem,menuElem,dotNetObject){if(!textElem||!menuElem){return}textElem._textField=MDCTextField.attachTo(textElem);menuElem._menu=MDCMenu.attachTo(menuElem);menuElem._menu.foundation.handleItemAction=function(listItem){menuElem._menu.open=false;dotNetObject.invokeMethodAsync("NotifySelected",listItem.innerText)};menuElem._menu.foundation.adapter.handleMenuSurfaceOpened=function(){menuElem._menu.foundation.setDefaultFocusState(0)};var closedCallback=function closedCallback(){dotNetObject.invokeMethodAsync("NotifyClosed")};menuElem._menu.listen("MDCMenuSurface:closed",closedCallback)}function MBAutocompleteTextField_open(menuElem){menuElem._menu.open=true;menuElem._menu.foundation.setDefaultFocusState(0)}function MBAutocompleteTextField_close(menuElem){menuElem._menu.open=false}function setValue(textElem,value){textElem._textField.value=value}function setDisabled(textElem,disabled){textElem._textField.disabled=disabled}function asyncGeneratorStep(gen,resolve,reject,_next,_throw,key,arg){try{var info=gen[key](arg);var value=info.value}catch(error){reject(error);return}if(info.done){resolve(value)}else{Promise.resolve(value).then(_next,_throw)}}function _asyncToGenerator(fn){return function(){var self=this,args=arguments;return new Promise((function(resolve,reject){var gen=fn.apply(self,args);function _next(value){asyncGeneratorStep(gen,resolve,reject,_next,_throw,"next",value)}function _throw(err){asyncGeneratorStep(gen,resolve,reject,_next,_throw,"throw",err)}_next(undefined)}))}}var regenerator=__webpack_require__(757);var regenerator_default=__webpack_require__.n(regenerator);var fps=60;var waitDelay=1e3/fps;function sleep(ms){return new Promise((function(resolve){return setTimeout(resolve,ms)}))}function openBlade(_x,_x2,_x3){return _openBlade.apply(this,arguments)}function _openBlade(){_openBlade=_asyncToGenerator(regenerator_default().mark((function _callee(bladeElem,bladeContentElem,transitionMs){var transition,bladeContentWidth,intervals,i;return regenerator_default().wrap((function _callee$(_context){while(1){switch(_context.prev=_context.next){case 0:if(!(!bladeElem||!bladeContentElem)){_context.next=2;break}return _context.abrupt("return");case 2:transition="width "+transitionMs+"ms";bladeContentWidth=bladeContentElem.getBoundingClientRect().width;bladeElem.style.transition=transition;bladeElem.style.width=bladeContentWidth+"px";bladeElem.scrollIntoView();intervals=Math.ceil(transitionMs/waitDelay)+1;i=0;case 9:if(!(i<intervals)){_context.next=16;break}_context.next=12;return sleep(waitDelay);case 12:bladeElem.scrollIntoView();case 13:i++;_context.next=9;break;case 16:case"end":return _context.stop()}}}),_callee)})));return _openBlade.apply(this,arguments)}function closeBlade(bladeElem){if(!bladeElem){return}bladeElem.style.width="0px"}function MBButton_init(elem){if(!elem){return}elem._ripple=MDCRipple.attachTo(elem)}function MBCard_init(elem){if(!elem){return}elem._ripple=MDCRipple.attachTo(elem)}
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
 */
var AnnouncerPriority;(function(AnnouncerPriority){AnnouncerPriority["POLITE"]="polite";AnnouncerPriority["ASSERTIVE"]="assertive"})(AnnouncerPriority||(AnnouncerPriority={}));var DATA_MDC_DOM_ANNOUNCE="data-mdc-dom-announce";function announce(message,priority){Announcer.getInstance().say(message,priority)}var Announcer=function(){function Announcer(){this.liveRegions=new Map}Announcer.getInstance=function(){if(!Announcer.instance){Announcer.instance=new Announcer}return Announcer.instance};Announcer.prototype.say=function(message,priority){if(priority===void 0){priority=AnnouncerPriority.POLITE}var liveRegion=this.getLiveRegion(priority);liveRegion.textContent="";setTimeout((function(){liveRegion.textContent=message;document.addEventListener("click",clearLiveRegion)}),1);function clearLiveRegion(){liveRegion.textContent="";document.removeEventListener("click",clearLiveRegion)}};Announcer.prototype.getLiveRegion=function(priority){var existingLiveRegion=this.liveRegions.get(priority);if(existingLiveRegion&&document.body.contains(existingLiveRegion)){return existingLiveRegion}var liveRegion=this.createLiveRegion(priority);this.liveRegions.set(priority,liveRegion);return liveRegion};Announcer.prototype.createLiveRegion=function(priority){var el=document.createElement("div");el.style.position="absolute";el.style.top="-9999px";el.style.left="-9999px";el.style.height="1px";el.style.overflow="hidden";el.setAttribute("aria-atomic","true");el.setAttribute("aria-live",priority);el.setAttribute(DATA_MDC_DOM_ANNOUNCE,"true");document.body.appendChild(el);return el};return Announcer}();
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
 */
var InteractionTrigger;(function(InteractionTrigger){InteractionTrigger[InteractionTrigger["UNSPECIFIED"]=0]="UNSPECIFIED";InteractionTrigger[InteractionTrigger["CLICK"]=1]="CLICK";InteractionTrigger[InteractionTrigger["BACKSPACE_KEY"]=2]="BACKSPACE_KEY";InteractionTrigger[InteractionTrigger["DELETE_KEY"]=3]="DELETE_KEY";InteractionTrigger[InteractionTrigger["SPACEBAR_KEY"]=4]="SPACEBAR_KEY";InteractionTrigger[InteractionTrigger["ENTER_KEY"]=5]="ENTER_KEY"})(InteractionTrigger||(InteractionTrigger={}));var trailingaction_constants_strings={ARIA_HIDDEN:"aria-hidden",INTERACTION_EVENT:"MDCChipTrailingAction:interaction",NAVIGATION_EVENT:"MDCChipTrailingAction:navigation",TAB_INDEX:"tabindex"};
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
 */
var MDCChipTrailingActionFoundation=function(_super){__extends(MDCChipTrailingActionFoundation,_super);function MDCChipTrailingActionFoundation(adapter){return _super.call(this,__assign(__assign({},MDCChipTrailingActionFoundation.defaultAdapter),adapter))||this}Object.defineProperty(MDCChipTrailingActionFoundation,"strings",{get:function(){return trailingaction_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCChipTrailingActionFoundation,"defaultAdapter",{get:function(){return{focus:function(){return undefined},getAttribute:function(){return null},setAttribute:function(){return undefined},notifyInteraction:function(){return undefined},notifyNavigation:function(){return undefined}}},enumerable:true,configurable:true});MDCChipTrailingActionFoundation.prototype.handleClick=function(evt){evt.stopPropagation();this.adapter.notifyInteraction(InteractionTrigger.CLICK)};MDCChipTrailingActionFoundation.prototype.handleKeydown=function(evt){evt.stopPropagation();var key=normalizeKey(evt);if(this.shouldNotifyInteractionFromKey_(key)){var trigger=this.getTriggerFromKey_(key);this.adapter.notifyInteraction(trigger);return}if(isNavigationEvent(evt)){this.adapter.notifyNavigation(key);return}};MDCChipTrailingActionFoundation.prototype.removeFocus=function(){this.adapter.setAttribute(trailingaction_constants_strings.TAB_INDEX,"-1")};MDCChipTrailingActionFoundation.prototype.focus=function(){this.adapter.setAttribute(trailingaction_constants_strings.TAB_INDEX,"0");this.adapter.focus()};MDCChipTrailingActionFoundation.prototype.isNavigable=function(){return this.adapter.getAttribute(trailingaction_constants_strings.ARIA_HIDDEN)!=="true"};MDCChipTrailingActionFoundation.prototype.shouldNotifyInteractionFromKey_=function(key){var isFromActionKey=key===KEY.ENTER||key===KEY.SPACEBAR;var isFromDeleteKey=key===KEY.BACKSPACE||key===KEY.DELETE;return isFromActionKey||isFromDeleteKey};MDCChipTrailingActionFoundation.prototype.getTriggerFromKey_=function(key){if(key===KEY.SPACEBAR){return InteractionTrigger.SPACEBAR_KEY}if(key===KEY.ENTER){return InteractionTrigger.ENTER_KEY}if(key===KEY.DELETE){return InteractionTrigger.DELETE_KEY}if(key===KEY.BACKSPACE){return InteractionTrigger.BACKSPACE_KEY}return InteractionTrigger.UNSPECIFIED};return MDCChipTrailingActionFoundation}(MDCFoundation);const trailingaction_foundation=null&&MDCChipTrailingActionFoundation;
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
 */
var MDCChipTrailingAction=function(_super){__extends(MDCChipTrailingAction,_super);function MDCChipTrailingAction(){return _super!==null&&_super.apply(this,arguments)||this}Object.defineProperty(MDCChipTrailingAction.prototype,"ripple",{get:function(){return this.ripple_},enumerable:true,configurable:true});MDCChipTrailingAction.attachTo=function(root){return new MDCChipTrailingAction(root)};MDCChipTrailingAction.prototype.initialize=function(rippleFactory){if(rippleFactory===void 0){rippleFactory=function(el,foundation){return new MDCRipple(el,foundation)}}var rippleAdapter=MDCRipple.createAdapter(this);this.ripple_=rippleFactory(this.root,new MDCRippleFoundation(rippleAdapter))};MDCChipTrailingAction.prototype.initialSyncWithDOM=function(){var _this=this;this.handleClick_=function(evt){_this.foundation.handleClick(evt)};this.handleKeydown_=function(evt){_this.foundation.handleKeydown(evt)};this.listen("click",this.handleClick_);this.listen("keydown",this.handleKeydown_)};MDCChipTrailingAction.prototype.destroy=function(){this.ripple_.destroy();this.unlisten("click",this.handleClick_);this.unlisten("keydown",this.handleKeydown_);_super.prototype.destroy.call(this)};MDCChipTrailingAction.prototype.getDefaultFoundation=function(){var _this=this;var adapter={focus:function(){_this.root.focus()},getAttribute:function(attr){return _this.root.getAttribute(attr)},notifyInteraction:function(trigger){return _this.emit(trailingaction_constants_strings.INTERACTION_EVENT,{trigger:trigger},true)},notifyNavigation:function(key){_this.emit(trailingaction_constants_strings.NAVIGATION_EVENT,{key:key},true)},setAttribute:function(attr,value){_this.root.setAttribute(attr,value)}};return new MDCChipTrailingActionFoundation(adapter)};MDCChipTrailingAction.prototype.isNavigable=function(){return this.foundation.isNavigable()};MDCChipTrailingAction.prototype.focus=function(){this.foundation.focus()};MDCChipTrailingAction.prototype.removeFocus=function(){this.foundation.removeFocus()};return MDCChipTrailingAction}(MDCComponent);
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
 */
var Direction;(function(Direction){Direction["LEFT"]="left";Direction["RIGHT"]="right"})(Direction||(Direction={}));var EventSource;(function(EventSource){EventSource["PRIMARY"]="primary";EventSource["TRAILING"]="trailing";EventSource["NONE"]="none"})(EventSource||(EventSource={}));var chip_constants_strings={ADDED_ANNOUNCEMENT_ATTRIBUTE:"data-mdc-chip-added-announcement",ARIA_CHECKED:"aria-checked",ARROW_DOWN_KEY:"ArrowDown",ARROW_LEFT_KEY:"ArrowLeft",ARROW_RIGHT_KEY:"ArrowRight",ARROW_UP_KEY:"ArrowUp",BACKSPACE_KEY:"Backspace",CHECKMARK_SELECTOR:".mdc-chip__checkmark",DELETE_KEY:"Delete",END_KEY:"End",ENTER_KEY:"Enter",ENTRY_ANIMATION_NAME:"mdc-chip-entry",HOME_KEY:"Home",IE_ARROW_DOWN_KEY:"Down",IE_ARROW_LEFT_KEY:"Left",IE_ARROW_RIGHT_KEY:"Right",IE_ARROW_UP_KEY:"Up",IE_DELETE_KEY:"Del",INTERACTION_EVENT:"MDCChip:interaction",LEADING_ICON_SELECTOR:".mdc-chip__icon--leading",NAVIGATION_EVENT:"MDCChip:navigation",PRIMARY_ACTION_SELECTOR:".mdc-chip__primary-action",REMOVED_ANNOUNCEMENT_ATTRIBUTE:"data-mdc-chip-removed-announcement",REMOVAL_EVENT:"MDCChip:removal",SELECTION_EVENT:"MDCChip:selection",SPACEBAR_KEY:" ",TAB_INDEX:"tabindex",TRAILING_ACTION_SELECTOR:".mdc-chip-trailing-action",TRAILING_ICON_INTERACTION_EVENT:"MDCChip:trailingIconInteraction",TRAILING_ICON_SELECTOR:".mdc-chip__icon--trailing"};var chip_constants_cssClasses={CHECKMARK:"mdc-chip__checkmark",CHIP_EXIT:"mdc-chip--exit",DELETABLE:"mdc-chip--deletable",EDITABLE:"mdc-chip--editable",EDITING:"mdc-chip--editing",HIDDEN_LEADING_ICON:"mdc-chip__icon--leading-hidden",LEADING_ICON:"mdc-chip__icon--leading",PRIMARY_ACTION:"mdc-chip__primary-action",PRIMARY_ACTION_FOCUSED:"mdc-chip--primary-action-focused",SELECTED:"mdc-chip--selected",TEXT:"mdc-chip__text",TRAILING_ACTION:"mdc-chip__trailing-action",TRAILING_ICON:"mdc-chip__icon--trailing"};var constants_navigationKeys=new Set;constants_navigationKeys.add(chip_constants_strings.ARROW_LEFT_KEY);constants_navigationKeys.add(chip_constants_strings.ARROW_RIGHT_KEY);constants_navigationKeys.add(chip_constants_strings.ARROW_DOWN_KEY);constants_navigationKeys.add(chip_constants_strings.ARROW_UP_KEY);constants_navigationKeys.add(chip_constants_strings.END_KEY);constants_navigationKeys.add(chip_constants_strings.HOME_KEY);constants_navigationKeys.add(chip_constants_strings.IE_ARROW_LEFT_KEY);constants_navigationKeys.add(chip_constants_strings.IE_ARROW_RIGHT_KEY);constants_navigationKeys.add(chip_constants_strings.IE_ARROW_DOWN_KEY);constants_navigationKeys.add(chip_constants_strings.IE_ARROW_UP_KEY);var jumpChipKeys=new Set;jumpChipKeys.add(chip_constants_strings.ARROW_UP_KEY);jumpChipKeys.add(chip_constants_strings.ARROW_DOWN_KEY);jumpChipKeys.add(chip_constants_strings.HOME_KEY);jumpChipKeys.add(chip_constants_strings.END_KEY);jumpChipKeys.add(chip_constants_strings.IE_ARROW_UP_KEY);jumpChipKeys.add(chip_constants_strings.IE_ARROW_DOWN_KEY);
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
 */
var emptyClientRect={bottom:0,height:0,left:0,right:0,top:0,width:0};var FocusBehavior;(function(FocusBehavior){FocusBehavior[FocusBehavior["SHOULD_FOCUS"]=0]="SHOULD_FOCUS";FocusBehavior[FocusBehavior["SHOULD_NOT_FOCUS"]=1]="SHOULD_NOT_FOCUS"})(FocusBehavior||(FocusBehavior={}));var MDCChipFoundation=function(_super){__extends(MDCChipFoundation,_super);function MDCChipFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCChipFoundation.defaultAdapter),adapter))||this;_this.shouldRemoveOnTrailingIconClick_=true;_this.shouldFocusPrimaryActionOnClick_=true;return _this}Object.defineProperty(MDCChipFoundation,"strings",{get:function(){return chip_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCChipFoundation,"cssClasses",{get:function(){return chip_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCChipFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},addClassToLeadingIcon:function(){return undefined},eventTargetHasClass:function(){return false},focusPrimaryAction:function(){return undefined},focusTrailingAction:function(){return undefined},getAttribute:function(){return null},getCheckmarkBoundingClientRect:function(){return emptyClientRect},getComputedStyleValue:function(){return""},getRootBoundingClientRect:function(){return emptyClientRect},hasClass:function(){return false},hasLeadingIcon:function(){return false},isRTL:function(){return false},isTrailingActionNavigable:function(){return false},notifyEditFinish:function(){return undefined},notifyEditStart:function(){return undefined},notifyInteraction:function(){return undefined},notifyNavigation:function(){return undefined},notifyRemoval:function(){return undefined},notifySelection:function(){return undefined},notifyTrailingIconInteraction:function(){return undefined},removeClass:function(){return undefined},removeClassFromLeadingIcon:function(){return undefined},removeTrailingActionFocus:function(){return undefined},setPrimaryActionAttr:function(){return undefined},setStyleProperty:function(){return undefined}}},enumerable:true,configurable:true});MDCChipFoundation.prototype.isSelected=function(){return this.adapter.hasClass(chip_constants_cssClasses.SELECTED)};MDCChipFoundation.prototype.isEditable=function(){return this.adapter.hasClass(chip_constants_cssClasses.EDITABLE)};MDCChipFoundation.prototype.isEditing=function(){return this.adapter.hasClass(chip_constants_cssClasses.EDITING)};MDCChipFoundation.prototype.setSelected=function(selected){this.setSelected_(selected);this.notifySelection_(selected)};MDCChipFoundation.prototype.setSelectedFromChipSet=function(selected,shouldNotifyClients){this.setSelected_(selected);if(shouldNotifyClients){this.notifyIgnoredSelection_(selected)}};MDCChipFoundation.prototype.getShouldRemoveOnTrailingIconClick=function(){return this.shouldRemoveOnTrailingIconClick_};MDCChipFoundation.prototype.setShouldRemoveOnTrailingIconClick=function(shouldRemove){this.shouldRemoveOnTrailingIconClick_=shouldRemove};MDCChipFoundation.prototype.setShouldFocusPrimaryActionOnClick=function(shouldFocus){this.shouldFocusPrimaryActionOnClick_=shouldFocus};MDCChipFoundation.prototype.getDimensions=function(){var _this=this;var getRootRect=function(){return _this.adapter.getRootBoundingClientRect()};var getCheckmarkRect=function(){return _this.adapter.getCheckmarkBoundingClientRect()};if(!this.adapter.hasLeadingIcon()){var checkmarkRect=getCheckmarkRect();if(checkmarkRect){var rootRect=getRootRect();return{bottom:rootRect.bottom,height:rootRect.height,left:rootRect.left,right:rootRect.right,top:rootRect.top,width:rootRect.width+checkmarkRect.height}}}return getRootRect()};MDCChipFoundation.prototype.beginExit=function(){this.adapter.addClass(chip_constants_cssClasses.CHIP_EXIT)};MDCChipFoundation.prototype.handleClick=function(){this.adapter.notifyInteraction();this.setPrimaryActionFocusable_(this.getFocusBehavior_())};MDCChipFoundation.prototype.handleDoubleClick=function(){if(this.isEditable()){this.startEditing()}};MDCChipFoundation.prototype.handleTransitionEnd=function(evt){var _this=this;var shouldHandle=this.adapter.eventTargetHasClass(evt.target,chip_constants_cssClasses.CHIP_EXIT);var widthIsAnimating=evt.propertyName==="width";var opacityIsAnimating=evt.propertyName==="opacity";if(shouldHandle&&opacityIsAnimating){var chipWidth_1=this.adapter.getComputedStyleValue("width");requestAnimationFrame((function(){_this.adapter.setStyleProperty("width",chipWidth_1);_this.adapter.setStyleProperty("padding","0");_this.adapter.setStyleProperty("margin","0");requestAnimationFrame((function(){_this.adapter.setStyleProperty("width","0")}))}));return}if(shouldHandle&&widthIsAnimating){this.removeFocus();var removedAnnouncement=this.adapter.getAttribute(chip_constants_strings.REMOVED_ANNOUNCEMENT_ATTRIBUTE);this.adapter.notifyRemoval(removedAnnouncement)}if(!opacityIsAnimating){return}var shouldHideLeadingIcon=this.adapter.eventTargetHasClass(evt.target,chip_constants_cssClasses.LEADING_ICON)&&this.adapter.hasClass(chip_constants_cssClasses.SELECTED);var shouldShowLeadingIcon=this.adapter.eventTargetHasClass(evt.target,chip_constants_cssClasses.CHECKMARK)&&!this.adapter.hasClass(chip_constants_cssClasses.SELECTED);if(shouldHideLeadingIcon){this.adapter.addClassToLeadingIcon(chip_constants_cssClasses.HIDDEN_LEADING_ICON);return}if(shouldShowLeadingIcon){this.adapter.removeClassFromLeadingIcon(chip_constants_cssClasses.HIDDEN_LEADING_ICON);return}};MDCChipFoundation.prototype.handleFocusIn=function(evt){if(!this.eventFromPrimaryAction_(evt)){return}this.adapter.addClass(chip_constants_cssClasses.PRIMARY_ACTION_FOCUSED)};MDCChipFoundation.prototype.handleFocusOut=function(evt){if(!this.eventFromPrimaryAction_(evt)){return}if(this.isEditing()){this.finishEditing()}this.adapter.removeClass(chip_constants_cssClasses.PRIMARY_ACTION_FOCUSED)};MDCChipFoundation.prototype.handleTrailingActionInteraction=function(){this.adapter.notifyTrailingIconInteraction();this.removeChip_()};MDCChipFoundation.prototype.handleKeydown=function(evt){if(this.isEditing()){if(this.shouldFinishEditing(evt)){evt.preventDefault();this.finishEditing()}return}if(this.isEditable()){if(this.shouldStartEditing(evt)){evt.preventDefault();this.startEditing()}}if(this.shouldNotifyInteraction_(evt)){this.adapter.notifyInteraction();this.setPrimaryActionFocusable_(this.getFocusBehavior_());return}if(this.isDeleteAction_(evt)){evt.preventDefault();this.removeChip_();return}if(!constants_navigationKeys.has(evt.key)){return}evt.preventDefault();this.focusNextAction_(evt.key,EventSource.PRIMARY)};MDCChipFoundation.prototype.handleTrailingActionNavigation=function(evt){return this.focusNextAction_(evt.detail.key,EventSource.TRAILING)};MDCChipFoundation.prototype.removeFocus=function(){this.adapter.setPrimaryActionAttr(chip_constants_strings.TAB_INDEX,"-1");this.adapter.removeTrailingActionFocus()};MDCChipFoundation.prototype.focusPrimaryAction=function(){this.setPrimaryActionFocusable_(FocusBehavior.SHOULD_FOCUS)};MDCChipFoundation.prototype.focusTrailingAction=function(){var trailingActionIsNavigable=this.adapter.isTrailingActionNavigable();if(trailingActionIsNavigable){this.adapter.setPrimaryActionAttr(chip_constants_strings.TAB_INDEX,"-1");this.adapter.focusTrailingAction();return}this.focusPrimaryAction()};MDCChipFoundation.prototype.setPrimaryActionFocusable_=function(focusBehavior){this.adapter.setPrimaryActionAttr(chip_constants_strings.TAB_INDEX,"0");if(focusBehavior===FocusBehavior.SHOULD_FOCUS){this.adapter.focusPrimaryAction()}this.adapter.removeTrailingActionFocus()};MDCChipFoundation.prototype.getFocusBehavior_=function(){if(this.shouldFocusPrimaryActionOnClick_){return FocusBehavior.SHOULD_FOCUS}return FocusBehavior.SHOULD_NOT_FOCUS};MDCChipFoundation.prototype.focusNextAction_=function(key,source){var isTrailingActionNavigable=this.adapter.isTrailingActionNavigable();var dir=this.getDirection_(key);if(jumpChipKeys.has(key)||!isTrailingActionNavigable){return this.adapter.notifyNavigation(key,source)}if(source===EventSource.PRIMARY&&dir===Direction.RIGHT){return this.focusTrailingAction()}if(source===EventSource.TRAILING&&dir===Direction.LEFT){return this.focusPrimaryAction()}this.adapter.notifyNavigation(key,EventSource.NONE)};MDCChipFoundation.prototype.getDirection_=function(key){var isRTL=this.adapter.isRTL();var isLeftKey=key===chip_constants_strings.ARROW_LEFT_KEY||key===chip_constants_strings.IE_ARROW_LEFT_KEY;var isRightKey=key===chip_constants_strings.ARROW_RIGHT_KEY||key===chip_constants_strings.IE_ARROW_RIGHT_KEY;if(!isRTL&&isLeftKey||isRTL&&isRightKey){return Direction.LEFT}return Direction.RIGHT};MDCChipFoundation.prototype.removeChip_=function(){if(this.shouldRemoveOnTrailingIconClick_){this.beginExit()}};MDCChipFoundation.prototype.shouldStartEditing=function(evt){return this.eventFromPrimaryAction_(evt)&&evt.key===chip_constants_strings.ENTER_KEY};MDCChipFoundation.prototype.shouldFinishEditing=function(evt){return evt.key===chip_constants_strings.ENTER_KEY};MDCChipFoundation.prototype.shouldNotifyInteraction_=function(evt){return evt.key===chip_constants_strings.ENTER_KEY||evt.key===chip_constants_strings.SPACEBAR_KEY};MDCChipFoundation.prototype.isDeleteAction_=function(evt){var isDeletable=this.adapter.hasClass(chip_constants_cssClasses.DELETABLE);return isDeletable&&(evt.key===chip_constants_strings.BACKSPACE_KEY||evt.key===chip_constants_strings.DELETE_KEY||evt.key===chip_constants_strings.IE_DELETE_KEY)};MDCChipFoundation.prototype.setSelected_=function(selected){if(selected){this.adapter.addClass(chip_constants_cssClasses.SELECTED);this.adapter.setPrimaryActionAttr(chip_constants_strings.ARIA_CHECKED,"true")}else{this.adapter.removeClass(chip_constants_cssClasses.SELECTED);this.adapter.setPrimaryActionAttr(chip_constants_strings.ARIA_CHECKED,"false")}};MDCChipFoundation.prototype.notifySelection_=function(selected){this.adapter.notifySelection(selected,false)};MDCChipFoundation.prototype.notifyIgnoredSelection_=function(selected){this.adapter.notifySelection(selected,true)};MDCChipFoundation.prototype.eventFromPrimaryAction_=function(evt){return this.adapter.eventTargetHasClass(evt.target,chip_constants_cssClasses.PRIMARY_ACTION)};MDCChipFoundation.prototype.startEditing=function(){this.adapter.addClass(chip_constants_cssClasses.EDITING);this.adapter.notifyEditStart()};MDCChipFoundation.prototype.finishEditing=function(){this.adapter.removeClass(chip_constants_cssClasses.EDITING);this.adapter.notifyEditFinish()};return MDCChipFoundation}(MDCFoundation);const chip_foundation=null&&MDCChipFoundation;
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
 */
var MDCChip=function(_super){__extends(MDCChip,_super);function MDCChip(){return _super!==null&&_super.apply(this,arguments)||this}Object.defineProperty(MDCChip.prototype,"selected",{get:function(){return this.foundation.isSelected()},set:function(selected){this.foundation.setSelected(selected)},enumerable:true,configurable:true});Object.defineProperty(MDCChip.prototype,"shouldRemoveOnTrailingIconClick",{get:function(){return this.foundation.getShouldRemoveOnTrailingIconClick()},set:function(shouldRemove){this.foundation.setShouldRemoveOnTrailingIconClick(shouldRemove)},enumerable:true,configurable:true});Object.defineProperty(MDCChip.prototype,"setShouldFocusPrimaryActionOnClick",{set:function(shouldFocus){this.foundation.setShouldFocusPrimaryActionOnClick(shouldFocus)},enumerable:true,configurable:true});Object.defineProperty(MDCChip.prototype,"ripple",{get:function(){return this.ripple_},enumerable:true,configurable:true});Object.defineProperty(MDCChip.prototype,"id",{get:function(){return this.root.id},enumerable:true,configurable:true});MDCChip.attachTo=function(root){return new MDCChip(root)};MDCChip.prototype.initialize=function(rippleFactory,trailingActionFactory){var _this=this;if(rippleFactory===void 0){rippleFactory=function(el,foundation){return new MDCRipple(el,foundation)}}if(trailingActionFactory===void 0){trailingActionFactory=function(el){return new MDCChipTrailingAction(el)}}this.leadingIcon_=this.root.querySelector(chip_constants_strings.LEADING_ICON_SELECTOR);this.checkmark_=this.root.querySelector(chip_constants_strings.CHECKMARK_SELECTOR);this.primaryAction_=this.root.querySelector(chip_constants_strings.PRIMARY_ACTION_SELECTOR);var trailingActionEl=this.root.querySelector(chip_constants_strings.TRAILING_ACTION_SELECTOR);if(trailingActionEl){this.trailingAction_=trailingActionFactory(trailingActionEl)}var rippleAdapter=__assign(__assign({},MDCRipple.createAdapter(this)),{computeBoundingRect:function(){return _this.foundation.getDimensions()}});this.ripple_=rippleFactory(this.root,new MDCRippleFoundation(rippleAdapter))};MDCChip.prototype.initialSyncWithDOM=function(){var _this=this;this.handleTrailingActionInteraction_=function(){_this.foundation.handleTrailingActionInteraction()};this.handleTrailingActionNavigation_=function(evt){_this.foundation.handleTrailingActionNavigation(evt)};this.handleClick_=function(){_this.foundation.handleClick()};this.handleKeydown_=function(evt){_this.foundation.handleKeydown(evt)};this.handleTransitionEnd_=function(evt){_this.foundation.handleTransitionEnd(evt)};this.handleFocusIn_=function(evt){_this.foundation.handleFocusIn(evt)};this.handleFocusOut_=function(evt){_this.foundation.handleFocusOut(evt)};this.listen("transitionend",this.handleTransitionEnd_);this.listen("click",this.handleClick_);this.listen("keydown",this.handleKeydown_);this.listen("focusin",this.handleFocusIn_);this.listen("focusout",this.handleFocusOut_);if(this.trailingAction_){this.listen(trailingaction_constants_strings.INTERACTION_EVENT,this.handleTrailingActionInteraction_);this.listen(trailingaction_constants_strings.NAVIGATION_EVENT,this.handleTrailingActionNavigation_)}};MDCChip.prototype.destroy=function(){this.ripple_.destroy();this.unlisten("transitionend",this.handleTransitionEnd_);this.unlisten("keydown",this.handleKeydown_);this.unlisten("click",this.handleClick_);this.unlisten("focusin",this.handleFocusIn_);this.unlisten("focusout",this.handleFocusOut_);if(this.trailingAction_){this.unlisten(trailingaction_constants_strings.INTERACTION_EVENT,this.handleTrailingActionInteraction_);this.unlisten(trailingaction_constants_strings.NAVIGATION_EVENT,this.handleTrailingActionNavigation_)}_super.prototype.destroy.call(this)};MDCChip.prototype.beginExit=function(){this.foundation.beginExit()};MDCChip.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClass:function(className){return _this.root.classList.add(className)},addClassToLeadingIcon:function(className){if(_this.leadingIcon_){_this.leadingIcon_.classList.add(className)}},eventTargetHasClass:function(target,className){return target?target.classList.contains(className):false},focusPrimaryAction:function(){if(_this.primaryAction_){_this.primaryAction_.focus()}},focusTrailingAction:function(){if(_this.trailingAction_){_this.trailingAction_.focus()}},getAttribute:function(attr){return _this.root.getAttribute(attr)},getCheckmarkBoundingClientRect:function(){return _this.checkmark_?_this.checkmark_.getBoundingClientRect():null},getComputedStyleValue:function(propertyName){return window.getComputedStyle(_this.root).getPropertyValue(propertyName)},getRootBoundingClientRect:function(){return _this.root.getBoundingClientRect()},hasClass:function(className){return _this.root.classList.contains(className)},hasLeadingIcon:function(){return!!_this.leadingIcon_},isRTL:function(){return window.getComputedStyle(_this.root).getPropertyValue("direction")==="rtl"},isTrailingActionNavigable:function(){if(_this.trailingAction_){return _this.trailingAction_.isNavigable()}return false},notifyInteraction:function(){return _this.emit(chip_constants_strings.INTERACTION_EVENT,{chipId:_this.id},true)},notifyNavigation:function(key,source){return _this.emit(chip_constants_strings.NAVIGATION_EVENT,{chipId:_this.id,key:key,source:source},true)},notifyRemoval:function(removedAnnouncement){_this.emit(chip_constants_strings.REMOVAL_EVENT,{chipId:_this.id,removedAnnouncement:removedAnnouncement},true)},notifySelection:function(selected,shouldIgnore){return _this.emit(chip_constants_strings.SELECTION_EVENT,{chipId:_this.id,selected:selected,shouldIgnore:shouldIgnore},true)},notifyTrailingIconInteraction:function(){return _this.emit(chip_constants_strings.TRAILING_ICON_INTERACTION_EVENT,{chipId:_this.id},true)},notifyEditStart:function(){},notifyEditFinish:function(){},removeClass:function(className){return _this.root.classList.remove(className)},removeClassFromLeadingIcon:function(className){if(_this.leadingIcon_){_this.leadingIcon_.classList.remove(className)}},removeTrailingActionFocus:function(){if(_this.trailingAction_){_this.trailingAction_.removeFocus()}},setPrimaryActionAttr:function(attr,value){if(_this.primaryAction_){_this.primaryAction_.setAttribute(attr,value)}},setStyleProperty:function(propertyName,value){return _this.root.style.setProperty(propertyName,value)}};return new MDCChipFoundation(adapter)};MDCChip.prototype.setSelectedFromChipSet=function(selected,shouldNotifyClients){this.foundation.setSelectedFromChipSet(selected,shouldNotifyClients)};MDCChip.prototype.focusPrimaryAction=function(){this.foundation.focusPrimaryAction()};MDCChip.prototype.focusTrailingAction=function(){this.foundation.focusTrailingAction()};MDCChip.prototype.removeFocus=function(){this.foundation.removeFocus()};MDCChip.prototype.remove=function(){var parent=this.root.parentNode;if(parent!==null){parent.removeChild(this.root)}};return MDCChip}(MDCComponent);
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
 */
var chip_set_constants_strings={CHIP_SELECTOR:".mdc-chip"};var chip_set_constants_cssClasses={CHOICE:"mdc-chip-set--choice",FILTER:"mdc-chip-set--filter"};
/**
 * @license
 * Copyright 2017 Google Inc.
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
 */
var MDCChipSetFoundation=function(_super){__extends(MDCChipSetFoundation,_super);function MDCChipSetFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCChipSetFoundation.defaultAdapter),adapter))||this;_this.selectedChipIds_=[];return _this}Object.defineProperty(MDCChipSetFoundation,"strings",{get:function(){return chip_set_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCChipSetFoundation,"cssClasses",{get:function(){return chip_set_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCChipSetFoundation,"defaultAdapter",{get:function(){return{announceMessage:function(){return undefined},focusChipPrimaryActionAtIndex:function(){return undefined},focusChipTrailingActionAtIndex:function(){return undefined},getChipListCount:function(){return-1},getIndexOfChipById:function(){return-1},hasClass:function(){return false},isRTL:function(){return false},removeChipAtIndex:function(){return undefined},removeFocusFromChipAtIndex:function(){return undefined},selectChipAtIndex:function(){return undefined}}},enumerable:true,configurable:true});MDCChipSetFoundation.prototype.getSelectedChipIds=function(){return this.selectedChipIds_.slice()};MDCChipSetFoundation.prototype.select=function(chipId){this.select_(chipId,false)};MDCChipSetFoundation.prototype.handleChipInteraction=function(_a){var chipId=_a.chipId;var index=this.adapter.getIndexOfChipById(chipId);this.removeFocusFromChipsExcept_(index);if(this.adapter.hasClass(chip_set_constants_cssClasses.CHOICE)||this.adapter.hasClass(chip_set_constants_cssClasses.FILTER)){this.toggleSelect_(chipId)}};MDCChipSetFoundation.prototype.handleChipSelection=function(_a){var chipId=_a.chipId,selected=_a.selected,shouldIgnore=_a.shouldIgnore;if(shouldIgnore){return}var chipIsSelected=this.selectedChipIds_.indexOf(chipId)>=0;if(selected&&!chipIsSelected){this.select(chipId)}else if(!selected&&chipIsSelected){this.deselect_(chipId)}};MDCChipSetFoundation.prototype.handleChipRemoval=function(_a){var chipId=_a.chipId,removedAnnouncement=_a.removedAnnouncement;if(removedAnnouncement){this.adapter.announceMessage(removedAnnouncement)}var index=this.adapter.getIndexOfChipById(chipId);this.deselectAndNotifyClients_(chipId);this.adapter.removeChipAtIndex(index);var maxIndex=this.adapter.getChipListCount()-1;if(maxIndex<0){return}var nextIndex=Math.min(index,maxIndex);this.removeFocusFromChipsExcept_(nextIndex);this.adapter.focusChipTrailingActionAtIndex(nextIndex)};MDCChipSetFoundation.prototype.handleChipNavigation=function(_a){var chipId=_a.chipId,key=_a.key,source=_a.source;var maxIndex=this.adapter.getChipListCount()-1;var index=this.adapter.getIndexOfChipById(chipId);if(index===-1||!constants_navigationKeys.has(key)){return}var isRTL=this.adapter.isRTL();var isLeftKey=key===chip_constants_strings.ARROW_LEFT_KEY||key===chip_constants_strings.IE_ARROW_LEFT_KEY;var isRightKey=key===chip_constants_strings.ARROW_RIGHT_KEY||key===chip_constants_strings.IE_ARROW_RIGHT_KEY;var isDownKey=key===chip_constants_strings.ARROW_DOWN_KEY||key===chip_constants_strings.IE_ARROW_DOWN_KEY;var shouldIncrement=!isRTL&&isRightKey||isRTL&&isLeftKey||isDownKey;var isHome=key===chip_constants_strings.HOME_KEY;var isEnd=key===chip_constants_strings.END_KEY;if(shouldIncrement){index++}else if(isHome){index=0}else if(isEnd){index=maxIndex}else{index--}if(index<0||index>maxIndex){return}this.removeFocusFromChipsExcept_(index);this.focusChipAction_(index,key,source)};MDCChipSetFoundation.prototype.focusChipAction_=function(index,key,source){var shouldJumpChips=jumpChipKeys.has(key);if(shouldJumpChips&&source===EventSource.PRIMARY){return this.adapter.focusChipPrimaryActionAtIndex(index)}if(shouldJumpChips&&source===EventSource.TRAILING){return this.adapter.focusChipTrailingActionAtIndex(index)}var dir=this.getDirection_(key);if(dir===Direction.LEFT){return this.adapter.focusChipTrailingActionAtIndex(index)}if(dir===Direction.RIGHT){return this.adapter.focusChipPrimaryActionAtIndex(index)}};MDCChipSetFoundation.prototype.getDirection_=function(key){var isRTL=this.adapter.isRTL();var isLeftKey=key===chip_constants_strings.ARROW_LEFT_KEY||key===chip_constants_strings.IE_ARROW_LEFT_KEY;var isRightKey=key===chip_constants_strings.ARROW_RIGHT_KEY||key===chip_constants_strings.IE_ARROW_RIGHT_KEY;if(!isRTL&&isLeftKey||isRTL&&isRightKey){return Direction.LEFT}return Direction.RIGHT};MDCChipSetFoundation.prototype.deselect_=function(chipId,shouldNotifyClients){if(shouldNotifyClients===void 0){shouldNotifyClients=false}var index=this.selectedChipIds_.indexOf(chipId);if(index>=0){this.selectedChipIds_.splice(index,1);var chipIndex=this.adapter.getIndexOfChipById(chipId);this.adapter.selectChipAtIndex(chipIndex,false,shouldNotifyClients)}};MDCChipSetFoundation.prototype.deselectAndNotifyClients_=function(chipId){this.deselect_(chipId,true)};MDCChipSetFoundation.prototype.toggleSelect_=function(chipId){if(this.selectedChipIds_.indexOf(chipId)>=0){this.deselectAndNotifyClients_(chipId)}else{this.selectAndNotifyClients_(chipId)}};MDCChipSetFoundation.prototype.removeFocusFromChipsExcept_=function(index){var chipCount=this.adapter.getChipListCount();for(var i=0;i<chipCount;i++){if(i!==index){this.adapter.removeFocusFromChipAtIndex(i)}}};MDCChipSetFoundation.prototype.selectAndNotifyClients_=function(chipId){this.select_(chipId,true)};MDCChipSetFoundation.prototype.select_=function(chipId,shouldNotifyClients){if(this.selectedChipIds_.indexOf(chipId)>=0){return}if(this.adapter.hasClass(chip_set_constants_cssClasses.CHOICE)&&this.selectedChipIds_.length>0){var previouslySelectedChip=this.selectedChipIds_[0];var previouslySelectedIndex=this.adapter.getIndexOfChipById(previouslySelectedChip);this.selectedChipIds_=[];this.adapter.selectChipAtIndex(previouslySelectedIndex,false,shouldNotifyClients)}this.selectedChipIds_.push(chipId);var index=this.adapter.getIndexOfChipById(chipId);this.adapter.selectChipAtIndex(index,true,shouldNotifyClients)};return MDCChipSetFoundation}(MDCFoundation);const chip_set_foundation=null&&MDCChipSetFoundation;
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
 */
var _a=MDCChipFoundation.strings,INTERACTION_EVENT=_a.INTERACTION_EVENT,SELECTION_EVENT=_a.SELECTION_EVENT,REMOVAL_EVENT=_a.REMOVAL_EVENT,NAVIGATION_EVENT=_a.NAVIGATION_EVENT;var CHIP_SELECTOR=MDCChipSetFoundation.strings.CHIP_SELECTOR;var idCounter=0;var MDCChipSet=function(_super){__extends(MDCChipSet,_super);function MDCChipSet(){return _super!==null&&_super.apply(this,arguments)||this}MDCChipSet.attachTo=function(root){return new MDCChipSet(root)};Object.defineProperty(MDCChipSet.prototype,"chips",{get:function(){return this.chips_.slice()},enumerable:true,configurable:true});Object.defineProperty(MDCChipSet.prototype,"selectedChipIds",{get:function(){return this.foundation.getSelectedChipIds()},enumerable:true,configurable:true});MDCChipSet.prototype.initialize=function(chipFactory){if(chipFactory===void 0){chipFactory=function(el){return new MDCChip(el)}}this.chipFactory_=chipFactory;this.chips_=this.instantiateChips_(this.chipFactory_)};MDCChipSet.prototype.initialSyncWithDOM=function(){var _this=this;this.chips_.forEach((function(chip){if(chip.id&&chip.selected){_this.foundation.select(chip.id)}}));this.handleChipInteraction_=function(evt){return _this.foundation.handleChipInteraction(evt.detail)};this.handleChipSelection_=function(evt){return _this.foundation.handleChipSelection(evt.detail)};this.handleChipRemoval_=function(evt){return _this.foundation.handleChipRemoval(evt.detail)};this.handleChipNavigation_=function(evt){return _this.foundation.handleChipNavigation(evt.detail)};this.listen(INTERACTION_EVENT,this.handleChipInteraction_);this.listen(SELECTION_EVENT,this.handleChipSelection_);this.listen(REMOVAL_EVENT,this.handleChipRemoval_);this.listen(NAVIGATION_EVENT,this.handleChipNavigation_)};MDCChipSet.prototype.destroy=function(){this.chips_.forEach((function(chip){chip.destroy()}));this.unlisten(INTERACTION_EVENT,this.handleChipInteraction_);this.unlisten(SELECTION_EVENT,this.handleChipSelection_);this.unlisten(REMOVAL_EVENT,this.handleChipRemoval_);this.unlisten(NAVIGATION_EVENT,this.handleChipNavigation_);_super.prototype.destroy.call(this)};MDCChipSet.prototype.addChip=function(chipEl){chipEl.id=chipEl.id||"mdc-chip-"+ ++idCounter;this.chips_.push(this.chipFactory_(chipEl))};MDCChipSet.prototype.getDefaultFoundation=function(){var _this=this;var adapter={announceMessage:function(message){announce(message)},focusChipPrimaryActionAtIndex:function(index){_this.chips_[index].focusPrimaryAction()},focusChipTrailingActionAtIndex:function(index){_this.chips_[index].focusTrailingAction()},getChipListCount:function(){return _this.chips_.length},getIndexOfChipById:function(chipId){return _this.findChipIndex_(chipId)},hasClass:function(className){return _this.root.classList.contains(className)},isRTL:function(){return window.getComputedStyle(_this.root).getPropertyValue("direction")==="rtl"},removeChipAtIndex:function(index){if(index>=0&&index<_this.chips_.length){_this.chips_[index].destroy();_this.chips_[index].remove();_this.chips_.splice(index,1)}},removeFocusFromChipAtIndex:function(index){_this.chips_[index].removeFocus()},selectChipAtIndex:function(index,selected,shouldNotifyClients){if(index>=0&&index<_this.chips_.length){_this.chips_[index].setSelectedFromChipSet(selected,shouldNotifyClients)}}};return new MDCChipSetFoundation(adapter)};MDCChipSet.prototype.instantiateChips_=function(chipFactory){var chipElements=[].slice.call(this.root.querySelectorAll(CHIP_SELECTOR));return chipElements.map((function(el){el.id=el.id||"mdc-chip-"+ ++idCounter;return chipFactory(el)}))};MDCChipSet.prototype.findChipIndex_=function(chipId){for(var i=0;i<this.chips_.length;i++){if(this.chips_[i].id===chipId){return i}}return-1};return MDCChipSet}(MDCComponent);function MBChipsSelectMulti_init(elem,isSingleSelect,dotNetObject){if(!elem){return}elem._chipSet=MDCChipSet.attachTo(elem);elem._isSingleSelect=isSingleSelect;var clickedCallback=function clickedCallback(){if(elem._isSingleSelect){var selectedChips=elem._chipSet.chips.filter((function(x){return x.foundation.isSelected()}));if(selectedChips.length==0){dotNetObject.invokeMethodAsync("NotifySingleSelected",-1)}else{dotNetObject.invokeMethodAsync("NotifySingleSelected",elem._chipSet.chips.findIndex((function(x){return x.id===selectedChips[0].id})))}}else{dotNetObject.invokeMethodAsync("NotifyMultiSelected",elem._chipSet.chips.map((function(x){return x.foundation.isSelected()})))}};elem._chipSet.listen("MDCChip:selection",clickedCallback)}function MBChipsSelectMulti_setDisabled(elem,value){if(!elem){return}elem._chipSet.disabled=value}function setSelected(elem,selectedFlags){if(!elem){return}for(var i=0;i<selectedFlags.length;i++){elem._chipSet.foundation.adapter.selectChipAtIndex(i,selectedFlags[i],false)}}
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
 */
var cssPropertyNameMap={animation:{prefixed:"-webkit-animation",standard:"animation"},transform:{prefixed:"-webkit-transform",standard:"transform"},transition:{prefixed:"-webkit-transition",standard:"transition"}};var jsEventTypeMap={animationend:{cssProperty:"animation",prefixed:"webkitAnimationEnd",standard:"animationend"},animationiteration:{cssProperty:"animation",prefixed:"webkitAnimationIteration",standard:"animationiteration"},animationstart:{cssProperty:"animation",prefixed:"webkitAnimationStart",standard:"animationstart"},transitionend:{cssProperty:"transition",prefixed:"webkitTransitionEnd",standard:"transitionend"}};function isWindow(windowObj){return Boolean(windowObj.document)&&typeof windowObj.document.createElement==="function"}function getCorrectPropertyName(windowObj,cssProperty){if(isWindow(windowObj)&&cssProperty in cssPropertyNameMap){var el=windowObj.document.createElement("div");var _a=cssPropertyNameMap[cssProperty],standard=_a.standard,prefixed=_a.prefixed;var isStandard=standard in el.style;return isStandard?standard:prefixed}return cssProperty}function getCorrectEventName(windowObj,eventType){if(isWindow(windowObj)&&eventType in jsEventTypeMap){var el=windowObj.document.createElement("div");var _a=jsEventTypeMap[eventType],standard=_a.standard,prefixed=_a.prefixed,cssProperty=_a.cssProperty;var isStandard=cssProperty in el.style;return isStandard?standard:prefixed}return eventType}
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
 */
var checkbox_constants_cssClasses={ANIM_CHECKED_INDETERMINATE:"mdc-checkbox--anim-checked-indeterminate",ANIM_CHECKED_UNCHECKED:"mdc-checkbox--anim-checked-unchecked",ANIM_INDETERMINATE_CHECKED:"mdc-checkbox--anim-indeterminate-checked",ANIM_INDETERMINATE_UNCHECKED:"mdc-checkbox--anim-indeterminate-unchecked",ANIM_UNCHECKED_CHECKED:"mdc-checkbox--anim-unchecked-checked",ANIM_UNCHECKED_INDETERMINATE:"mdc-checkbox--anim-unchecked-indeterminate",BACKGROUND:"mdc-checkbox__background",CHECKED:"mdc-checkbox--checked",CHECKMARK:"mdc-checkbox__checkmark",CHECKMARK_PATH:"mdc-checkbox__checkmark-path",DISABLED:"mdc-checkbox--disabled",INDETERMINATE:"mdc-checkbox--indeterminate",MIXEDMARK:"mdc-checkbox__mixedmark",NATIVE_CONTROL:"mdc-checkbox__native-control",ROOT:"mdc-checkbox",SELECTED:"mdc-checkbox--selected",UPGRADED:"mdc-checkbox--upgraded"};var checkbox_constants_strings={ARIA_CHECKED_ATTR:"aria-checked",ARIA_CHECKED_INDETERMINATE_VALUE:"mixed",DATA_INDETERMINATE_ATTR:"data-indeterminate",NATIVE_CONTROL_SELECTOR:".mdc-checkbox__native-control",TRANSITION_STATE_CHECKED:"checked",TRANSITION_STATE_INDETERMINATE:"indeterminate",TRANSITION_STATE_INIT:"init",TRANSITION_STATE_UNCHECKED:"unchecked"};var checkbox_constants_numbers={ANIM_END_LATCH_MS:250};
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
 */
var MDCCheckboxFoundation=function(_super){__extends(MDCCheckboxFoundation,_super);function MDCCheckboxFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCCheckboxFoundation.defaultAdapter),adapter))||this;_this.currentCheckState_=checkbox_constants_strings.TRANSITION_STATE_INIT;_this.currentAnimationClass_="";_this.animEndLatchTimer_=0;_this.enableAnimationEndHandler_=false;return _this}Object.defineProperty(MDCCheckboxFoundation,"cssClasses",{get:function(){return checkbox_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCCheckboxFoundation,"strings",{get:function(){return checkbox_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCCheckboxFoundation,"numbers",{get:function(){return checkbox_constants_numbers},enumerable:true,configurable:true});Object.defineProperty(MDCCheckboxFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},forceLayout:function(){return undefined},hasNativeControl:function(){return false},isAttachedToDOM:function(){return false},isChecked:function(){return false},isIndeterminate:function(){return false},removeClass:function(){return undefined},removeNativeControlAttr:function(){return undefined},setNativeControlAttr:function(){return undefined},setNativeControlDisabled:function(){return undefined}}},enumerable:true,configurable:true});MDCCheckboxFoundation.prototype.init=function(){this.currentCheckState_=this.determineCheckState_();this.updateAriaChecked_();this.adapter.addClass(checkbox_constants_cssClasses.UPGRADED)};MDCCheckboxFoundation.prototype.destroy=function(){clearTimeout(this.animEndLatchTimer_)};MDCCheckboxFoundation.prototype.setDisabled=function(disabled){this.adapter.setNativeControlDisabled(disabled);if(disabled){this.adapter.addClass(checkbox_constants_cssClasses.DISABLED)}else{this.adapter.removeClass(checkbox_constants_cssClasses.DISABLED)}};MDCCheckboxFoundation.prototype.handleAnimationEnd=function(){var _this=this;if(!this.enableAnimationEndHandler_){return}clearTimeout(this.animEndLatchTimer_);this.animEndLatchTimer_=setTimeout((function(){_this.adapter.removeClass(_this.currentAnimationClass_);_this.enableAnimationEndHandler_=false}),checkbox_constants_numbers.ANIM_END_LATCH_MS)};MDCCheckboxFoundation.prototype.handleChange=function(){this.transitionCheckState_()};MDCCheckboxFoundation.prototype.transitionCheckState_=function(){if(!this.adapter.hasNativeControl()){return}var oldState=this.currentCheckState_;var newState=this.determineCheckState_();if(oldState===newState){return}this.updateAriaChecked_();var TRANSITION_STATE_UNCHECKED=checkbox_constants_strings.TRANSITION_STATE_UNCHECKED;var SELECTED=checkbox_constants_cssClasses.SELECTED;if(newState===TRANSITION_STATE_UNCHECKED){this.adapter.removeClass(SELECTED)}else{this.adapter.addClass(SELECTED)}if(this.currentAnimationClass_.length>0){clearTimeout(this.animEndLatchTimer_);this.adapter.forceLayout();this.adapter.removeClass(this.currentAnimationClass_)}this.currentAnimationClass_=this.getTransitionAnimationClass_(oldState,newState);this.currentCheckState_=newState;if(this.adapter.isAttachedToDOM()&&this.currentAnimationClass_.length>0){this.adapter.addClass(this.currentAnimationClass_);this.enableAnimationEndHandler_=true}};MDCCheckboxFoundation.prototype.determineCheckState_=function(){var TRANSITION_STATE_INDETERMINATE=checkbox_constants_strings.TRANSITION_STATE_INDETERMINATE,TRANSITION_STATE_CHECKED=checkbox_constants_strings.TRANSITION_STATE_CHECKED,TRANSITION_STATE_UNCHECKED=checkbox_constants_strings.TRANSITION_STATE_UNCHECKED;if(this.adapter.isIndeterminate()){return TRANSITION_STATE_INDETERMINATE}return this.adapter.isChecked()?TRANSITION_STATE_CHECKED:TRANSITION_STATE_UNCHECKED};MDCCheckboxFoundation.prototype.getTransitionAnimationClass_=function(oldState,newState){var TRANSITION_STATE_INIT=checkbox_constants_strings.TRANSITION_STATE_INIT,TRANSITION_STATE_CHECKED=checkbox_constants_strings.TRANSITION_STATE_CHECKED,TRANSITION_STATE_UNCHECKED=checkbox_constants_strings.TRANSITION_STATE_UNCHECKED;var _a=MDCCheckboxFoundation.cssClasses,ANIM_UNCHECKED_CHECKED=_a.ANIM_UNCHECKED_CHECKED,ANIM_UNCHECKED_INDETERMINATE=_a.ANIM_UNCHECKED_INDETERMINATE,ANIM_CHECKED_UNCHECKED=_a.ANIM_CHECKED_UNCHECKED,ANIM_CHECKED_INDETERMINATE=_a.ANIM_CHECKED_INDETERMINATE,ANIM_INDETERMINATE_CHECKED=_a.ANIM_INDETERMINATE_CHECKED,ANIM_INDETERMINATE_UNCHECKED=_a.ANIM_INDETERMINATE_UNCHECKED;switch(oldState){case TRANSITION_STATE_INIT:if(newState===TRANSITION_STATE_UNCHECKED){return""}return newState===TRANSITION_STATE_CHECKED?ANIM_INDETERMINATE_CHECKED:ANIM_INDETERMINATE_UNCHECKED;case TRANSITION_STATE_UNCHECKED:return newState===TRANSITION_STATE_CHECKED?ANIM_UNCHECKED_CHECKED:ANIM_UNCHECKED_INDETERMINATE;case TRANSITION_STATE_CHECKED:return newState===TRANSITION_STATE_UNCHECKED?ANIM_CHECKED_UNCHECKED:ANIM_CHECKED_INDETERMINATE;default:return newState===TRANSITION_STATE_CHECKED?ANIM_INDETERMINATE_CHECKED:ANIM_INDETERMINATE_UNCHECKED}};MDCCheckboxFoundation.prototype.updateAriaChecked_=function(){if(this.adapter.isIndeterminate()){this.adapter.setNativeControlAttr(checkbox_constants_strings.ARIA_CHECKED_ATTR,checkbox_constants_strings.ARIA_CHECKED_INDETERMINATE_VALUE)}else{this.adapter.removeNativeControlAttr(checkbox_constants_strings.ARIA_CHECKED_ATTR)}};return MDCCheckboxFoundation}(MDCFoundation);const checkbox_foundation=null&&MDCCheckboxFoundation;
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
 */
var CB_PROTO_PROPS=["checked","indeterminate"];var MDCCheckbox=function(_super){__extends(MDCCheckbox,_super);function MDCCheckbox(){var _this=_super!==null&&_super.apply(this,arguments)||this;_this.ripple_=_this.createRipple_();return _this}MDCCheckbox.attachTo=function(root){return new MDCCheckbox(root)};Object.defineProperty(MDCCheckbox.prototype,"ripple",{get:function(){return this.ripple_},enumerable:true,configurable:true});Object.defineProperty(MDCCheckbox.prototype,"checked",{get:function(){return this.nativeControl_.checked},set:function(checked){this.nativeControl_.checked=checked},enumerable:true,configurable:true});Object.defineProperty(MDCCheckbox.prototype,"indeterminate",{get:function(){return this.nativeControl_.indeterminate},set:function(indeterminate){this.nativeControl_.indeterminate=indeterminate},enumerable:true,configurable:true});Object.defineProperty(MDCCheckbox.prototype,"disabled",{get:function(){return this.nativeControl_.disabled},set:function(disabled){this.foundation.setDisabled(disabled)},enumerable:true,configurable:true});Object.defineProperty(MDCCheckbox.prototype,"value",{get:function(){return this.nativeControl_.value},set:function(value){this.nativeControl_.value=value},enumerable:true,configurable:true});MDCCheckbox.prototype.initialize=function(){var DATA_INDETERMINATE_ATTR=checkbox_constants_strings.DATA_INDETERMINATE_ATTR;this.nativeControl_.indeterminate=this.nativeControl_.getAttribute(DATA_INDETERMINATE_ATTR)==="true";this.nativeControl_.removeAttribute(DATA_INDETERMINATE_ATTR)};MDCCheckbox.prototype.initialSyncWithDOM=function(){var _this=this;this.handleChange_=function(){return _this.foundation.handleChange()};this.handleAnimationEnd_=function(){return _this.foundation.handleAnimationEnd()};this.nativeControl_.addEventListener("change",this.handleChange_);this.listen(getCorrectEventName(window,"animationend"),this.handleAnimationEnd_);this.installPropertyChangeHooks_()};MDCCheckbox.prototype.destroy=function(){this.ripple_.destroy();this.nativeControl_.removeEventListener("change",this.handleChange_);this.unlisten(getCorrectEventName(window,"animationend"),this.handleAnimationEnd_);this.uninstallPropertyChangeHooks_();_super.prototype.destroy.call(this)};MDCCheckbox.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClass:function(className){return _this.root.classList.add(className)},forceLayout:function(){return _this.root.offsetWidth},hasNativeControl:function(){return!!_this.nativeControl_},isAttachedToDOM:function(){return Boolean(_this.root.parentNode)},isChecked:function(){return _this.checked},isIndeterminate:function(){return _this.indeterminate},removeClass:function(className){_this.root.classList.remove(className)},removeNativeControlAttr:function(attr){_this.nativeControl_.removeAttribute(attr)},setNativeControlAttr:function(attr,value){_this.nativeControl_.setAttribute(attr,value)},setNativeControlDisabled:function(disabled){_this.nativeControl_.disabled=disabled}};return new MDCCheckboxFoundation(adapter)};MDCCheckbox.prototype.createRipple_=function(){var _this=this;var adapter=__assign(__assign({},MDCRipple.createAdapter(this)),{deregisterInteractionHandler:function(evtType,handler){return _this.nativeControl_.removeEventListener(evtType,handler,applyPassive())},isSurfaceActive:function(){return matches(_this.nativeControl_,":active")},isUnbounded:function(){return true},registerInteractionHandler:function(evtType,handler){return _this.nativeControl_.addEventListener(evtType,handler,applyPassive())}});return new MDCRipple(this.root,new MDCRippleFoundation(adapter))};MDCCheckbox.prototype.installPropertyChangeHooks_=function(){var _this=this;var nativeCb=this.nativeControl_;var cbProto=Object.getPrototypeOf(nativeCb);CB_PROTO_PROPS.forEach((function(controlState){var desc=Object.getOwnPropertyDescriptor(cbProto,controlState);if(!validDescriptor(desc)){return}var nativeGetter=desc.get;var nativeCbDesc={configurable:desc.configurable,enumerable:desc.enumerable,get:nativeGetter,set:function(state){desc.set.call(nativeCb,state);_this.foundation.handleChange()}};Object.defineProperty(nativeCb,controlState,nativeCbDesc)}))};MDCCheckbox.prototype.uninstallPropertyChangeHooks_=function(){var nativeCb=this.nativeControl_;var cbProto=Object.getPrototypeOf(nativeCb);CB_PROTO_PROPS.forEach((function(controlState){var desc=Object.getOwnPropertyDescriptor(cbProto,controlState);if(!validDescriptor(desc)){return}Object.defineProperty(nativeCb,controlState,desc)}))};Object.defineProperty(MDCCheckbox.prototype,"nativeControl_",{get:function(){var NATIVE_CONTROL_SELECTOR=checkbox_constants_strings.NATIVE_CONTROL_SELECTOR;var el=this.root.querySelector(NATIVE_CONTROL_SELECTOR);if(!el){throw new Error("Checkbox component requires a "+NATIVE_CONTROL_SELECTOR+" element")}return el},enumerable:true,configurable:true});return MDCCheckbox}(MDCComponent);function validDescriptor(inputPropDesc){return!!inputPropDesc&&typeof inputPropDesc.set==="function"}
/**
 * @license
 * Copyright 2017 Google Inc.
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
 */
var form_field_constants_cssClasses={ROOT:"mdc-form-field"};var form_field_constants_strings={LABEL_SELECTOR:".mdc-form-field > label"};
/**
 * @license
 * Copyright 2017 Google Inc.
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
 */
var MDCFormFieldFoundation=function(_super){__extends(MDCFormFieldFoundation,_super);function MDCFormFieldFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCFormFieldFoundation.defaultAdapter),adapter))||this;_this.click=function(){_this.handleClick()};return _this}Object.defineProperty(MDCFormFieldFoundation,"cssClasses",{get:function(){return form_field_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCFormFieldFoundation,"strings",{get:function(){return form_field_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCFormFieldFoundation,"defaultAdapter",{get:function(){return{activateInputRipple:function(){return undefined},deactivateInputRipple:function(){return undefined},deregisterInteractionHandler:function(){return undefined},registerInteractionHandler:function(){return undefined}}},enumerable:true,configurable:true});MDCFormFieldFoundation.prototype.init=function(){this.adapter.registerInteractionHandler("click",this.click)};MDCFormFieldFoundation.prototype.destroy=function(){this.adapter.deregisterInteractionHandler("click",this.click)};MDCFormFieldFoundation.prototype.handleClick=function(){var _this=this;this.adapter.activateInputRipple();requestAnimationFrame((function(){_this.adapter.deactivateInputRipple()}))};return MDCFormFieldFoundation}(MDCFoundation);const form_field_foundation=null&&MDCFormFieldFoundation;
/**
 * @license
 * Copyright 2017 Google Inc.
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
 */
var MDCFormField=function(_super){__extends(MDCFormField,_super);function MDCFormField(){return _super!==null&&_super.apply(this,arguments)||this}MDCFormField.attachTo=function(root){return new MDCFormField(root)};MDCFormField.prototype.labelEl=function(){var LABEL_SELECTOR=MDCFormFieldFoundation.strings.LABEL_SELECTOR;return this.root.querySelector(LABEL_SELECTOR)};MDCFormField.prototype.getDefaultFoundation=function(){var _this=this;var adapter={activateInputRipple:function(){if(_this.input&&_this.input.ripple){_this.input.ripple.activate()}},deactivateInputRipple:function(){if(_this.input&&_this.input.ripple){_this.input.ripple.deactivate()}},deregisterInteractionHandler:function(evtType,handler){var labelEl=_this.labelEl();if(labelEl){labelEl.removeEventListener(evtType,handler)}},registerInteractionHandler:function(evtType,handler){var labelEl=_this.labelEl();if(labelEl){labelEl.addEventListener(evtType,handler)}}};return new MDCFormFieldFoundation(adapter)};return MDCFormField}(MDCComponent);function MBCheckbox_init(elem,formFieldElem,checked,indeterminate){if(!elem||!formFieldElem){return}elem._checkbox=MDCCheckbox.attachTo(elem);elem._checkbox.checked=checked;elem._checkbox.indeterminate=indeterminate;elem._formField=MDCFormField.attachTo(formFieldElem);elem._formField.input=elem._checkbox}function setChecked(elem,checked){if(!elem){return}elem._checkbox.checked=checked}function setIndeterminate(elem,indeterminate){if(!elem){return}if((elem===null||elem===void 0?void 0:elem._checkbox)==null){return}elem._checkbox.indeterminate=indeterminate}function MBCheckbox_setDisabled(elem,disabled){if(!elem){return}elem._checkbox.disabled=disabled}
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
 */
var circular_progress_constants_cssClasses={INDETERMINATE_CLASS:"mdc-circular-progress--indeterminate",CLOSED_CLASS:"mdc-circular-progress--closed"};var circular_progress_constants_strings={DETERMINATE_CIRCLE_SELECTOR:".mdc-circular-progress__determinate-circle",ARIA_VALUENOW:"aria-valuenow",RADIUS:"r",STROKE_DASHOFFSET:"stroke-dashoffset"};
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
 */
var MDCCircularProgressFoundation=function(_super){__extends(MDCCircularProgressFoundation,_super);function MDCCircularProgressFoundation(adapter){return _super.call(this,__assign(__assign({},MDCCircularProgressFoundation.defaultAdapter),adapter))||this}Object.defineProperty(MDCCircularProgressFoundation,"cssClasses",{get:function(){return circular_progress_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCCircularProgressFoundation,"strings",{get:function(){return circular_progress_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCCircularProgressFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},getDeterminateCircleAttribute:function(){return null},hasClass:function(){return false},removeClass:function(){return undefined},removeAttribute:function(){return undefined},setAttribute:function(){return undefined},setDeterminateCircleAttribute:function(){return undefined}}},enumerable:true,configurable:true});MDCCircularProgressFoundation.prototype.init=function(){this.isClosed_=this.adapter.hasClass(circular_progress_constants_cssClasses.CLOSED_CLASS);this.isDeterminate_=!this.adapter.hasClass(circular_progress_constants_cssClasses.INDETERMINATE_CLASS);this.progress_=0;if(this.isDeterminate_){this.adapter.setAttribute(circular_progress_constants_strings.ARIA_VALUENOW,this.progress_.toString())}this.radius_=Number(this.adapter.getDeterminateCircleAttribute(circular_progress_constants_strings.RADIUS))};MDCCircularProgressFoundation.prototype.isDeterminate=function(){return this.isDeterminate_};MDCCircularProgressFoundation.prototype.getProgress=function(){return this.progress_};MDCCircularProgressFoundation.prototype.isClosed=function(){return this.isClosed_};MDCCircularProgressFoundation.prototype.setDeterminate=function(isDeterminate){this.isDeterminate_=isDeterminate;if(this.isDeterminate_){this.adapter.removeClass(circular_progress_constants_cssClasses.INDETERMINATE_CLASS);this.setProgress(this.progress_)}else{this.adapter.addClass(circular_progress_constants_cssClasses.INDETERMINATE_CLASS);this.adapter.removeAttribute(circular_progress_constants_strings.ARIA_VALUENOW)}};MDCCircularProgressFoundation.prototype.setProgress=function(value){this.progress_=value;if(this.isDeterminate_){var unfilledArcLength=(1-this.progress_)*(2*Math.PI*this.radius_);this.adapter.setDeterminateCircleAttribute(circular_progress_constants_strings.STROKE_DASHOFFSET,""+unfilledArcLength);this.adapter.setAttribute(circular_progress_constants_strings.ARIA_VALUENOW,this.progress_.toString())}};MDCCircularProgressFoundation.prototype.open=function(){this.isClosed_=false;this.adapter.removeClass(circular_progress_constants_cssClasses.CLOSED_CLASS)};MDCCircularProgressFoundation.prototype.close=function(){this.isClosed_=true;this.adapter.addClass(circular_progress_constants_cssClasses.CLOSED_CLASS)};return MDCCircularProgressFoundation}(MDCFoundation);const circular_progress_foundation=null&&MDCCircularProgressFoundation;
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
 */
var MDCCircularProgress=function(_super){__extends(MDCCircularProgress,_super);function MDCCircularProgress(){return _super!==null&&_super.apply(this,arguments)||this}MDCCircularProgress.prototype.initialize=function(){this.determinateCircle_=this.root.querySelector(MDCCircularProgressFoundation.strings.DETERMINATE_CIRCLE_SELECTOR)};MDCCircularProgress.attachTo=function(root){return new MDCCircularProgress(root)};Object.defineProperty(MDCCircularProgress.prototype,"determinate",{set:function(value){this.foundation.setDeterminate(value)},enumerable:true,configurable:true});Object.defineProperty(MDCCircularProgress.prototype,"progress",{set:function(value){this.foundation.setProgress(value)},enumerable:true,configurable:true});Object.defineProperty(MDCCircularProgress.prototype,"isClosed",{get:function(){return this.foundation.isClosed()},enumerable:true,configurable:true});MDCCircularProgress.prototype.open=function(){this.foundation.open()};MDCCircularProgress.prototype.close=function(){this.foundation.close()};MDCCircularProgress.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClass:function(className){return _this.root.classList.add(className)},getDeterminateCircleAttribute:function(attributeName){return _this.determinateCircle_.getAttribute(attributeName)},hasClass:function(className){return _this.root.classList.contains(className)},removeClass:function(className){return _this.root.classList.remove(className)},removeAttribute:function(attributeName){return _this.root.removeAttribute(attributeName)},setAttribute:function(attributeName,value){return _this.root.setAttribute(attributeName,value)},setDeterminateCircleAttribute:function(attributeName,value){return _this.determinateCircle_.setAttribute(attributeName,value)}};return new MDCCircularProgressFoundation(adapter)};return MDCCircularProgress}(MDCComponent);function MBCircularProgress_init(elem,progress){if(!elem){return}elem._circularProgress=MDCCircularProgress.attachTo(elem);setProgress(elem,progress)}function setProgress(elem,progress){if(!elem){return}elem._circularProgress.progress=progress}
/**
 * @license
 * Copyright 2017 Google Inc.
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
 */
var linear_progress_constants_cssClasses={CLOSED_CLASS:"mdc-linear-progress--closed",CLOSED_ANIMATION_OFF_CLASS:"mdc-linear-progress--closed-animation-off",INDETERMINATE_CLASS:"mdc-linear-progress--indeterminate",REVERSED_CLASS:"mdc-linear-progress--reversed",ANIMATION_READY_CLASS:"mdc-linear-progress--animation-ready"};var linear_progress_constants_strings={ARIA_VALUEMAX:"aria-valuemax",ARIA_VALUEMIN:"aria-valuemin",ARIA_VALUENOW:"aria-valuenow",BUFFER_BAR_SELECTOR:".mdc-linear-progress__buffer-bar",FLEX_BASIS:"flex-basis",PRIMARY_BAR_SELECTOR:".mdc-linear-progress__primary-bar"};var animationDimensionPercentages={PRIMARY_HALF:.8367142,PRIMARY_FULL:2.00611057,SECONDARY_QUARTER:.37651913,SECONDARY_HALF:.84386165,SECONDARY_FULL:1.60277782};
/**
 * @license
 * Copyright 2017 Google Inc.
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
 */
var MDCLinearProgressFoundation=function(_super){__extends(MDCLinearProgressFoundation,_super);function MDCLinearProgressFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCLinearProgressFoundation.defaultAdapter),adapter))||this;_this.observer=null;return _this}Object.defineProperty(MDCLinearProgressFoundation,"cssClasses",{get:function(){return linear_progress_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCLinearProgressFoundation,"strings",{get:function(){return linear_progress_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCLinearProgressFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},attachResizeObserver:function(){return null},forceLayout:function(){return undefined},getWidth:function(){return 0},hasClass:function(){return false},setBufferBarStyle:function(){return null},setPrimaryBarStyle:function(){return null},setStyle:function(){return undefined},removeAttribute:function(){return undefined},removeClass:function(){return undefined},setAttribute:function(){return undefined}}},enumerable:true,configurable:true});MDCLinearProgressFoundation.prototype.init=function(){var _this=this;this.isDeterminate=!this.adapter.hasClass(linear_progress_constants_cssClasses.INDETERMINATE_CLASS);this.adapter.addClass(linear_progress_constants_cssClasses.ANIMATION_READY_CLASS);this.isReversed=this.adapter.hasClass(linear_progress_constants_cssClasses.REVERSED_CLASS);this.progress=0;this.buffer=1;this.observer=this.adapter.attachResizeObserver((function(entries){var e_1,_a;if(_this.isDeterminate){return}try{for(var entries_1=__values(entries),entries_1_1=entries_1.next();!entries_1_1.done;entries_1_1=entries_1.next()){var entry=entries_1_1.value;if(entry.contentRect){_this.calculateAndSetDimensions(entry.contentRect.width)}}}catch(e_1_1){e_1={error:e_1_1}}finally{try{if(entries_1_1&&!entries_1_1.done&&(_a=entries_1.return))_a.call(entries_1)}finally{if(e_1)throw e_1.error}}}));if(!this.isDeterminate&&this.observer){this.calculateAndSetDimensions(this.adapter.getWidth())}};MDCLinearProgressFoundation.prototype.setDeterminate=function(isDeterminate){this.isDeterminate=isDeterminate;if(this.isDeterminate){this.adapter.removeClass(linear_progress_constants_cssClasses.INDETERMINATE_CLASS);this.adapter.setAttribute(linear_progress_constants_strings.ARIA_VALUENOW,this.progress.toString());this.adapter.setAttribute(linear_progress_constants_strings.ARIA_VALUEMAX,"1");this.adapter.setAttribute(linear_progress_constants_strings.ARIA_VALUEMIN,"0");this.setPrimaryBarProgress(this.progress);this.setBufferBarProgress(this.buffer);return}if(this.isReversed){this.adapter.removeClass(linear_progress_constants_cssClasses.REVERSED_CLASS);this.adapter.forceLayout();this.adapter.addClass(linear_progress_constants_cssClasses.REVERSED_CLASS)}if(this.observer){this.calculateAndSetDimensions(this.adapter.getWidth())}this.adapter.addClass(linear_progress_constants_cssClasses.INDETERMINATE_CLASS);this.adapter.removeAttribute(linear_progress_constants_strings.ARIA_VALUENOW);this.adapter.removeAttribute(linear_progress_constants_strings.ARIA_VALUEMAX);this.adapter.removeAttribute(linear_progress_constants_strings.ARIA_VALUEMIN);this.setPrimaryBarProgress(1);this.setBufferBarProgress(1)};MDCLinearProgressFoundation.prototype.getDeterminate=function(){return this.isDeterminate};MDCLinearProgressFoundation.prototype.setProgress=function(value){this.progress=value;if(this.isDeterminate){this.setPrimaryBarProgress(value);this.adapter.setAttribute(linear_progress_constants_strings.ARIA_VALUENOW,value.toString())}};MDCLinearProgressFoundation.prototype.getProgress=function(){return this.progress};MDCLinearProgressFoundation.prototype.setBuffer=function(value){this.buffer=value;if(this.isDeterminate){this.setBufferBarProgress(value)}};MDCLinearProgressFoundation.prototype.setReverse=function(isReversed){this.isReversed=isReversed;if(!this.isDeterminate){this.restartAnimation()}if(this.isReversed){this.adapter.addClass(linear_progress_constants_cssClasses.REVERSED_CLASS);return}this.adapter.removeClass(linear_progress_constants_cssClasses.REVERSED_CLASS)};MDCLinearProgressFoundation.prototype.open=function(){this.adapter.removeClass(linear_progress_constants_cssClasses.CLOSED_CLASS);this.adapter.removeClass(linear_progress_constants_cssClasses.CLOSED_ANIMATION_OFF_CLASS)};MDCLinearProgressFoundation.prototype.close=function(){this.adapter.addClass(linear_progress_constants_cssClasses.CLOSED_CLASS)};MDCLinearProgressFoundation.prototype.handleTransitionEnd=function(){if(this.adapter.hasClass(linear_progress_constants_cssClasses.CLOSED_CLASS)){this.adapter.addClass(linear_progress_constants_cssClasses.CLOSED_ANIMATION_OFF_CLASS)}};MDCLinearProgressFoundation.prototype.destroy=function(){_super.prototype.destroy.call(this);if(this.observer){this.observer.disconnect()}};MDCLinearProgressFoundation.prototype.setPrimaryBarProgress=function(progressValue){var value="scaleX("+progressValue+")";var transformProp=typeof window!=="undefined"?getCorrectPropertyName(window,"transform"):"transform";this.adapter.setPrimaryBarStyle(transformProp,value)};MDCLinearProgressFoundation.prototype.setBufferBarProgress=function(progressValue){var value=progressValue*100+"%";this.adapter.setBufferBarStyle(linear_progress_constants_strings.FLEX_BASIS,value)};MDCLinearProgressFoundation.prototype.restartAnimation=function(){this.adapter.removeClass(linear_progress_constants_cssClasses.ANIMATION_READY_CLASS);this.adapter.forceLayout();this.adapter.addClass(linear_progress_constants_cssClasses.ANIMATION_READY_CLASS)};MDCLinearProgressFoundation.prototype.calculateAndSetDimensions=function(width){var primaryHalf=width*animationDimensionPercentages.PRIMARY_HALF;var primaryFull=width*animationDimensionPercentages.PRIMARY_FULL;var secondaryQuarter=width*animationDimensionPercentages.SECONDARY_QUARTER;var secondaryHalf=width*animationDimensionPercentages.SECONDARY_HALF;var secondaryFull=width*animationDimensionPercentages.SECONDARY_FULL;this.adapter.setStyle("--mdc-linear-progress-primary-half",primaryHalf+"px");this.adapter.setStyle("--mdc-linear-progress-primary-half-neg",-primaryHalf+"px");this.adapter.setStyle("--mdc-linear-progress-primary-full",primaryFull+"px");this.adapter.setStyle("--mdc-linear-progress-primary-full-neg",-primaryFull+"px");this.adapter.setStyle("--mdc-linear-progress-secondary-quarter",secondaryQuarter+"px");this.adapter.setStyle("--mdc-linear-progress-secondary-quarter-neg",-secondaryQuarter+"px");this.adapter.setStyle("--mdc-linear-progress-secondary-half",secondaryHalf+"px");this.adapter.setStyle("--mdc-linear-progress-secondary-half-neg",-secondaryHalf+"px");this.adapter.setStyle("--mdc-linear-progress-secondary-full",secondaryFull+"px");this.adapter.setStyle("--mdc-linear-progress-secondary-full-neg",-secondaryFull+"px");this.restartAnimation()};return MDCLinearProgressFoundation}(MDCFoundation);const linear_progress_foundation=null&&MDCLinearProgressFoundation;
/**
 * @license
 * Copyright 2017 Google Inc.
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
 */
var MDCLinearProgress=function(_super){__extends(MDCLinearProgress,_super);function MDCLinearProgress(){return _super!==null&&_super.apply(this,arguments)||this}MDCLinearProgress.attachTo=function(root){return new MDCLinearProgress(root)};Object.defineProperty(MDCLinearProgress.prototype,"determinate",{set:function(value){this.foundation.setDeterminate(value)},enumerable:true,configurable:true});Object.defineProperty(MDCLinearProgress.prototype,"progress",{set:function(value){this.foundation.setProgress(value)},enumerable:true,configurable:true});Object.defineProperty(MDCLinearProgress.prototype,"buffer",{set:function(value){this.foundation.setBuffer(value)},enumerable:true,configurable:true});Object.defineProperty(MDCLinearProgress.prototype,"reverse",{set:function(value){this.foundation.setReverse(value)},enumerable:true,configurable:true});MDCLinearProgress.prototype.open=function(){this.foundation.open()};MDCLinearProgress.prototype.close=function(){this.foundation.close()};MDCLinearProgress.prototype.initialSyncWithDOM=function(){var _this=this;this.root.addEventListener("transitionend",(function(){_this.foundation.handleTransitionEnd()}))};MDCLinearProgress.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClass:function(className){_this.root.classList.add(className)},forceLayout:function(){_this.root.getBoundingClientRect()},setBufferBarStyle:function(styleProperty,value){var bufferBar=_this.root.querySelector(MDCLinearProgressFoundation.strings.BUFFER_BAR_SELECTOR);if(bufferBar){bufferBar.style.setProperty(styleProperty,value)}},setPrimaryBarStyle:function(styleProperty,value){var primaryBar=_this.root.querySelector(MDCLinearProgressFoundation.strings.PRIMARY_BAR_SELECTOR);if(primaryBar){primaryBar.style.setProperty(styleProperty,value)}},hasClass:function(className){return _this.root.classList.contains(className)},removeAttribute:function(attributeName){_this.root.removeAttribute(attributeName)},removeClass:function(className){_this.root.classList.remove(className)},setAttribute:function(attributeName,value){_this.root.setAttribute(attributeName,value)},setStyle:function(name,value){_this.root.style.setProperty(name,value)},attachResizeObserver:function(callback){if(window.ResizeObserver){var ro=new ResizeObserver(callback);ro.observe(_this.root);return ro}return null},getWidth:function(){return _this.root.offsetWidth}};return new MDCLinearProgressFoundation(adapter)};return MDCLinearProgress}(MDCComponent);
/**
 * @license
 * Copyright 2019 Google Inc.
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
 */
var data_table_constants_cssClasses={CELL:"mdc-data-table__cell",CELL_NUMERIC:"mdc-data-table__cell--numeric",CONTENT:"mdc-data-table__content",HEADER_CELL:"mdc-data-table__header-cell",HEADER_CELL_LABEL:"mdc-data-table__header-cell-label",HEADER_CELL_SORTED:"mdc-data-table__header-cell--sorted",HEADER_CELL_SORTED_DESCENDING:"mdc-data-table__header-cell--sorted-descending",HEADER_CELL_WITH_SORT:"mdc-data-table__header-cell--with-sort",HEADER_CELL_WRAPPER:"mdc-data-table__header-cell-wrapper",HEADER_ROW:"mdc-data-table__header-row",HEADER_ROW_CHECKBOX:"mdc-data-table__header-row-checkbox",IN_PROGRESS:"mdc-data-table--in-progress",LINEAR_PROGRESS:"mdc-data-table__linear-progress",PAGINATION_ROWS_PER_PAGE_LABEL:"mdc-data-table__pagination-rows-per-page-label",PAGINATION_ROWS_PER_PAGE_SELECT:"mdc-data-table__pagination-rows-per-page-select",PROGRESS_INDICATOR:"mdc-data-table__progress-indicator",ROOT:"mdc-data-table",ROW:"mdc-data-table__row",ROW_CHECKBOX:"mdc-data-table__row-checkbox",ROW_SELECTED:"mdc-data-table__row--selected",SORT_ICON_BUTTON:"mdc-data-table__sort-icon-button",SORT_STATUS_LABEL:"mdc-data-table__sort-status-label",TABLE_CONTAINER:"mdc-data-table__table-container"};var attributes={ARIA_SELECTED:"aria-selected",ARIA_SORT:"aria-sort"};var dataAttributes={COLUMN_ID:"data-column-id",ROW_ID:"data-row-id"};var selectors={CONTENT:"."+data_table_constants_cssClasses.CONTENT,HEADER_CELL:"."+data_table_constants_cssClasses.HEADER_CELL,HEADER_CELL_WITH_SORT:"."+data_table_constants_cssClasses.HEADER_CELL_WITH_SORT,HEADER_ROW:"."+data_table_constants_cssClasses.HEADER_ROW,HEADER_ROW_CHECKBOX:"."+data_table_constants_cssClasses.HEADER_ROW_CHECKBOX,PROGRESS_INDICATOR:"."+data_table_constants_cssClasses.PROGRESS_INDICATOR,ROW:"."+data_table_constants_cssClasses.ROW,ROW_CHECKBOX:"."+data_table_constants_cssClasses.ROW_CHECKBOX,ROW_SELECTED:"."+data_table_constants_cssClasses.ROW_SELECTED,SORT_ICON_BUTTON:"."+data_table_constants_cssClasses.SORT_ICON_BUTTON,SORT_STATUS_LABEL:"."+data_table_constants_cssClasses.SORT_STATUS_LABEL};var messages={SORTED_IN_DESCENDING:"Sorted in descending order",SORTED_IN_ASCENDING:"Sorted in ascending order"};var data_table_constants_strings={ARIA_SELECTED:attributes.ARIA_SELECTED,ARIA_SORT:attributes.ARIA_SORT,DATA_ROW_ID_ATTR:dataAttributes.ROW_ID,HEADER_ROW_CHECKBOX_SELECTOR:selectors.HEADER_ROW_CHECKBOX,ROW_CHECKBOX_SELECTOR:selectors.ROW_CHECKBOX,ROW_SELECTED_SELECTOR:selectors.ROW_SELECTED,ROW_SELECTOR:selectors.ROW};var SortValue;(function(SortValue){SortValue["ASCENDING"]="ascending";SortValue["DESCENDING"]="descending";SortValue["NONE"]="none";SortValue["OTHER"]="other"})(SortValue||(SortValue={}));var events={ROW_SELECTION_CHANGED:"MDCDataTable:rowSelectionChanged",SELECTED_ALL:"MDCDataTable:selectedAll",UNSELECTED_ALL:"MDCDataTable:unselectedAll",SORTED:"MDCDataTable:sorted"};
/**
 * @license
 * Copyright 2019 Google Inc.
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
 */
var MDCDataTableFoundation=function(_super){__extends(MDCDataTableFoundation,_super);function MDCDataTableFoundation(adapter){return _super.call(this,__assign(__assign({},MDCDataTableFoundation.defaultAdapter),adapter))||this}Object.defineProperty(MDCDataTableFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},addClassAtRowIndex:function(){return undefined},getAttributeByHeaderCellIndex:function(){return""},getHeaderCellCount:function(){return 0},getHeaderCellElements:function(){return[]},getRowCount:function(){return 0},getRowElements:function(){return[]},getRowIdAtIndex:function(){return""},getRowIndexByChildElement:function(){return 0},getSelectedRowCount:function(){return 0},getTableContainerHeight:function(){return 0},getTableHeaderHeight:function(){return 0},isCheckboxAtRowIndexChecked:function(){return false},isHeaderRowCheckboxChecked:function(){return false},isRowsSelectable:function(){return false},notifyRowSelectionChanged:function(){return undefined},notifySelectedAll:function(){return undefined},notifySortAction:function(){return undefined},notifyUnselectedAll:function(){return undefined},registerHeaderRowCheckbox:function(){return undefined},registerRowCheckboxes:function(){return undefined},removeClass:function(){return undefined},removeClassAtRowIndex:function(){return undefined},removeClassNameByHeaderCellIndex:function(){return undefined},setAttributeAtRowIndex:function(){return undefined},setAttributeByHeaderCellIndex:function(){return undefined},setClassNameByHeaderCellIndex:function(){return undefined},setHeaderRowCheckboxChecked:function(){return undefined},setHeaderRowCheckboxIndeterminate:function(){return undefined},setProgressIndicatorStyles:function(){return undefined},setRowCheckboxCheckedAtIndex:function(){return undefined},setSortStatusLabelByHeaderCellIndex:function(){return undefined}}},enumerable:true,configurable:true});MDCDataTableFoundation.prototype.layout=function(){if(this.adapter.isRowsSelectable()){this.adapter.registerHeaderRowCheckbox();this.adapter.registerRowCheckboxes();this.setHeaderRowCheckboxState()}};MDCDataTableFoundation.prototype.layoutAsync=function(){return __awaiter(this,void 0,void 0,(function(){return __generator(this,(function(_a){switch(_a.label){case 0:if(!this.adapter.isRowsSelectable())return[3,3];return[4,this.adapter.registerHeaderRowCheckbox()];case 1:_a.sent();return[4,this.adapter.registerRowCheckboxes()];case 2:_a.sent();this.setHeaderRowCheckboxState();_a.label=3;case 3:return[2]}}))}))};MDCDataTableFoundation.prototype.getRows=function(){return this.adapter.getRowElements()};MDCDataTableFoundation.prototype.getHeaderCells=function(){return this.adapter.getHeaderCellElements()};MDCDataTableFoundation.prototype.setSelectedRowIds=function(rowIds){for(var rowIndex=0;rowIndex<this.adapter.getRowCount();rowIndex++){var rowId=this.adapter.getRowIdAtIndex(rowIndex);var isSelected=false;if(rowId&&rowIds.indexOf(rowId)>=0){isSelected=true}this.adapter.setRowCheckboxCheckedAtIndex(rowIndex,isSelected);this.selectRowAtIndex(rowIndex,isSelected)}this.setHeaderRowCheckboxState()};MDCDataTableFoundation.prototype.getRowIds=function(){var rowIds=[];for(var rowIndex=0;rowIndex<this.adapter.getRowCount();rowIndex++){rowIds.push(this.adapter.getRowIdAtIndex(rowIndex))}return rowIds};MDCDataTableFoundation.prototype.getSelectedRowIds=function(){var selectedRowIds=[];for(var rowIndex=0;rowIndex<this.adapter.getRowCount();rowIndex++){if(this.adapter.isCheckboxAtRowIndexChecked(rowIndex)){selectedRowIds.push(this.adapter.getRowIdAtIndex(rowIndex))}}return selectedRowIds};MDCDataTableFoundation.prototype.handleHeaderRowCheckboxChange=function(){var isHeaderChecked=this.adapter.isHeaderRowCheckboxChecked();for(var rowIndex=0;rowIndex<this.adapter.getRowCount();rowIndex++){this.adapter.setRowCheckboxCheckedAtIndex(rowIndex,isHeaderChecked);this.selectRowAtIndex(rowIndex,isHeaderChecked)}if(isHeaderChecked){this.adapter.notifySelectedAll()}else{this.adapter.notifyUnselectedAll()}};MDCDataTableFoundation.prototype.handleRowCheckboxChange=function(event){var rowIndex=this.adapter.getRowIndexByChildElement(event.target);if(rowIndex===-1){return}var selected=this.adapter.isCheckboxAtRowIndexChecked(rowIndex);this.selectRowAtIndex(rowIndex,selected);this.setHeaderRowCheckboxState();var rowId=this.adapter.getRowIdAtIndex(rowIndex);this.adapter.notifyRowSelectionChanged({rowId:rowId,rowIndex:rowIndex,selected:selected})};MDCDataTableFoundation.prototype.handleSortAction=function(eventData){var columnId=eventData.columnId,columnIndex=eventData.columnIndex,headerCell=eventData.headerCell;for(var index=0;index<this.adapter.getHeaderCellCount();index++){if(index===columnIndex){continue}this.adapter.removeClassNameByHeaderCellIndex(index,data_table_constants_cssClasses.HEADER_CELL_SORTED);this.adapter.removeClassNameByHeaderCellIndex(index,data_table_constants_cssClasses.HEADER_CELL_SORTED_DESCENDING);this.adapter.setAttributeByHeaderCellIndex(index,data_table_constants_strings.ARIA_SORT,SortValue.NONE);this.adapter.setSortStatusLabelByHeaderCellIndex(index,SortValue.NONE)}this.adapter.setClassNameByHeaderCellIndex(columnIndex,data_table_constants_cssClasses.HEADER_CELL_SORTED);var currentSortValue=this.adapter.getAttributeByHeaderCellIndex(columnIndex,data_table_constants_strings.ARIA_SORT);var sortValue=SortValue.NONE;if(currentSortValue===SortValue.ASCENDING){this.adapter.setClassNameByHeaderCellIndex(columnIndex,data_table_constants_cssClasses.HEADER_CELL_SORTED_DESCENDING);this.adapter.setAttributeByHeaderCellIndex(columnIndex,data_table_constants_strings.ARIA_SORT,SortValue.DESCENDING);sortValue=SortValue.DESCENDING}else if(currentSortValue===SortValue.DESCENDING){this.adapter.removeClassNameByHeaderCellIndex(columnIndex,data_table_constants_cssClasses.HEADER_CELL_SORTED_DESCENDING);this.adapter.setAttributeByHeaderCellIndex(columnIndex,data_table_constants_strings.ARIA_SORT,SortValue.ASCENDING);sortValue=SortValue.ASCENDING}else{this.adapter.setAttributeByHeaderCellIndex(columnIndex,data_table_constants_strings.ARIA_SORT,SortValue.ASCENDING);sortValue=SortValue.ASCENDING}this.adapter.setSortStatusLabelByHeaderCellIndex(columnIndex,sortValue);this.adapter.notifySortAction({columnId:columnId,columnIndex:columnIndex,headerCell:headerCell,sortValue:sortValue})};MDCDataTableFoundation.prototype.showProgress=function(){var tableHeaderHeight=this.adapter.getTableHeaderHeight();var height=this.adapter.getTableContainerHeight()-tableHeaderHeight;var top=tableHeaderHeight;this.adapter.setProgressIndicatorStyles({height:height+"px",top:top+"px"});this.adapter.addClass(data_table_constants_cssClasses.IN_PROGRESS)};MDCDataTableFoundation.prototype.hideProgress=function(){this.adapter.removeClass(data_table_constants_cssClasses.IN_PROGRESS)};MDCDataTableFoundation.prototype.setHeaderRowCheckboxState=function(){if(this.adapter.getSelectedRowCount()===0){this.adapter.setHeaderRowCheckboxChecked(false);this.adapter.setHeaderRowCheckboxIndeterminate(false)}else if(this.adapter.getSelectedRowCount()===this.adapter.getRowCount()){this.adapter.setHeaderRowCheckboxChecked(true);this.adapter.setHeaderRowCheckboxIndeterminate(false)}else{this.adapter.setHeaderRowCheckboxIndeterminate(true);this.adapter.setHeaderRowCheckboxChecked(false)}};MDCDataTableFoundation.prototype.selectRowAtIndex=function(rowIndex,selected){if(selected){this.adapter.addClassAtRowIndex(rowIndex,data_table_constants_cssClasses.ROW_SELECTED);this.adapter.setAttributeAtRowIndex(rowIndex,data_table_constants_strings.ARIA_SELECTED,"true")}else{this.adapter.removeClassAtRowIndex(rowIndex,data_table_constants_cssClasses.ROW_SELECTED);this.adapter.setAttributeAtRowIndex(rowIndex,data_table_constants_strings.ARIA_SELECTED,"false")}};return MDCDataTableFoundation}(MDCFoundation);
/**
 * @license
 * Copyright 2019 Google Inc.
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
 */
var MDCDataTable=function(_super){__extends(MDCDataTable,_super);function MDCDataTable(){return _super!==null&&_super.apply(this,arguments)||this}MDCDataTable.attachTo=function(root){return new MDCDataTable(root)};MDCDataTable.prototype.initialize=function(checkboxFactory){if(checkboxFactory===void 0){checkboxFactory=function(el){return new MDCCheckbox(el)}}this.checkboxFactory=checkboxFactory};MDCDataTable.prototype.initialSyncWithDOM=function(){var _this=this;this.headerRow=this.root.querySelector("."+data_table_constants_cssClasses.HEADER_ROW);this.handleHeaderRowCheckboxChange=function(){_this.foundation.handleHeaderRowCheckboxChange()};this.headerRow.addEventListener("change",this.handleHeaderRowCheckboxChange);this.headerRowClickListener=function(event){_this.handleHeaderRowClick(event)};this.headerRow.addEventListener("click",this.headerRowClickListener);this.content=this.root.querySelector("."+data_table_constants_cssClasses.CONTENT);this.handleRowCheckboxChange=function(event){_this.foundation.handleRowCheckboxChange(event)};this.content.addEventListener("change",this.handleRowCheckboxChange);this.layout()};MDCDataTable.prototype.layout=function(){this.foundation.layout()};MDCDataTable.prototype.getHeaderCells=function(){return[].slice.call(this.root.querySelectorAll(selectors.HEADER_CELL))};MDCDataTable.prototype.getRows=function(){return this.foundation.getRows()};MDCDataTable.prototype.getSelectedRowIds=function(){return this.foundation.getSelectedRowIds()};MDCDataTable.prototype.setSelectedRowIds=function(rowIds){this.foundation.setSelectedRowIds(rowIds)};MDCDataTable.prototype.showProgress=function(){this.getLinearProgress().open();this.foundation.showProgress()};MDCDataTable.prototype.hideProgress=function(){this.foundation.hideProgress();this.getLinearProgress().close()};MDCDataTable.prototype.destroy=function(){var e_1,_a;if(this.handleHeaderRowCheckboxChange){this.headerRow.removeEventListener("change",this.handleHeaderRowCheckboxChange)}if(this.headerRowClickListener){this.headerRow.removeEventListener("click",this.headerRowClickListener)}if(this.handleRowCheckboxChange){this.content.removeEventListener("change",this.handleRowCheckboxChange)}if(this.headerRowCheckbox){this.headerRowCheckbox.destroy()}if(this.rowCheckboxList){try{for(var _b=__values(this.rowCheckboxList),_c=_b.next();!_c.done;_c=_b.next()){var checkbox=_c.value;checkbox.destroy()}}catch(e_1_1){e_1={error:e_1_1}}finally{try{if(_c&&!_c.done&&(_a=_b.return))_a.call(_b)}finally{if(e_1)throw e_1.error}}}};MDCDataTable.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClass:function(className){_this.root.classList.add(className)},removeClass:function(className){_this.root.classList.remove(className)},getHeaderCellElements:function(){return _this.getHeaderCells()},getHeaderCellCount:function(){return _this.getHeaderCells().length},getAttributeByHeaderCellIndex:function(index,attribute){return _this.getHeaderCells()[index].getAttribute(attribute)},setAttributeByHeaderCellIndex:function(index,attribute,value){_this.getHeaderCells()[index].setAttribute(attribute,value)},setClassNameByHeaderCellIndex:function(index,className){_this.getHeaderCells()[index].classList.add(className)},removeClassNameByHeaderCellIndex:function(index,className){_this.getHeaderCells()[index].classList.remove(className)},notifySortAction:function(data){_this.emit(events.SORTED,data,true)},getTableContainerHeight:function(){var tableContainer=_this.root.querySelector("."+data_table_constants_cssClasses.TABLE_CONTAINER);if(!tableContainer){throw new Error("MDCDataTable: Table container element not found.")}return tableContainer.getBoundingClientRect().height},getTableHeaderHeight:function(){var tableHeader=_this.root.querySelector(selectors.HEADER_ROW);if(!tableHeader){throw new Error("MDCDataTable: Table header element not found.")}return tableHeader.getBoundingClientRect().height},setProgressIndicatorStyles:function(styles){var progressIndicator=_this.root.querySelector(selectors.PROGRESS_INDICATOR);if(!progressIndicator){throw new Error("MDCDataTable: Progress indicator element not found.")}progressIndicator.style.setProperty("height",styles.height);progressIndicator.style.setProperty("top",styles.top)},addClassAtRowIndex:function(rowIndex,className){_this.getRows()[rowIndex].classList.add(className)},getRowCount:function(){return _this.getRows().length},getRowElements:function(){return[].slice.call(_this.root.querySelectorAll(selectors.ROW))},getRowIdAtIndex:function(rowIndex){return _this.getRows()[rowIndex].getAttribute(dataAttributes.ROW_ID)},getRowIndexByChildElement:function(el){return _this.getRows().indexOf(closest(el,selectors.ROW))},getSelectedRowCount:function(){return _this.root.querySelectorAll(selectors.ROW_SELECTED).length},isCheckboxAtRowIndexChecked:function(rowIndex){return _this.rowCheckboxList[rowIndex].checked},isHeaderRowCheckboxChecked:function(){return _this.headerRowCheckbox.checked},isRowsSelectable:function(){return!!_this.root.querySelector(selectors.ROW_CHECKBOX)||!!_this.root.querySelector(selectors.HEADER_ROW_CHECKBOX)},notifyRowSelectionChanged:function(data){_this.emit(events.ROW_SELECTION_CHANGED,{row:_this.getRowByIndex(data.rowIndex),rowId:_this.getRowIdByIndex(data.rowIndex),rowIndex:data.rowIndex,selected:data.selected},true)},notifySelectedAll:function(){_this.emit(events.SELECTED_ALL,{},true)},notifyUnselectedAll:function(){_this.emit(events.UNSELECTED_ALL,{},true)},registerHeaderRowCheckbox:function(){if(_this.headerRowCheckbox){_this.headerRowCheckbox.destroy()}var checkboxEl=_this.root.querySelector(selectors.HEADER_ROW_CHECKBOX);_this.headerRowCheckbox=_this.checkboxFactory(checkboxEl)},registerRowCheckboxes:function(){if(_this.rowCheckboxList){_this.rowCheckboxList.forEach((function(checkbox){checkbox.destroy()}))}_this.rowCheckboxList=[];_this.getRows().forEach((function(rowEl){var checkbox=_this.checkboxFactory(rowEl.querySelector(selectors.ROW_CHECKBOX));_this.rowCheckboxList.push(checkbox)}))},removeClassAtRowIndex:function(rowIndex,className){_this.getRows()[rowIndex].classList.remove(className)},setAttributeAtRowIndex:function(rowIndex,attr,value){_this.getRows()[rowIndex].setAttribute(attr,value)},setHeaderRowCheckboxChecked:function(checked){_this.headerRowCheckbox.checked=checked},setHeaderRowCheckboxIndeterminate:function(indeterminate){_this.headerRowCheckbox.indeterminate=indeterminate},setRowCheckboxCheckedAtIndex:function(rowIndex,checked){_this.rowCheckboxList[rowIndex].checked=checked},setSortStatusLabelByHeaderCellIndex:function(columnIndex,sortValue){var headerCell=_this.getHeaderCells()[columnIndex];var sortStatusLabel=headerCell.querySelector(selectors.SORT_STATUS_LABEL);if(!sortStatusLabel)return;sortStatusLabel.textContent=_this.getSortStatusMessageBySortValue(sortValue)}};return new MDCDataTableFoundation(adapter)};MDCDataTable.prototype.getRowByIndex=function(index){return this.getRows()[index]};MDCDataTable.prototype.getRowIdByIndex=function(index){return this.getRowByIndex(index).getAttribute(dataAttributes.ROW_ID)};MDCDataTable.prototype.handleHeaderRowClick=function(event){var headerCell=closest(event.target,selectors.HEADER_CELL_WITH_SORT);if(!headerCell){return}var columnId=headerCell.getAttribute(dataAttributes.COLUMN_ID);var columnIndex=this.getHeaderCells().indexOf(headerCell);if(columnIndex===-1){return}this.foundation.handleSortAction({columnId:columnId,columnIndex:columnIndex,headerCell:headerCell})};MDCDataTable.prototype.getSortStatusMessageBySortValue=function(sortValue){switch(sortValue){case SortValue.ASCENDING:return messages.SORTED_IN_ASCENDING;case SortValue.DESCENDING:return messages.SORTED_IN_DESCENDING;default:return""}};MDCDataTable.prototype.getLinearProgressElement=function(){var el=this.root.querySelector("."+data_table_constants_cssClasses.LINEAR_PROGRESS);if(!el){throw new Error("MDCDataTable: linear progress element is not found.")}return el};MDCDataTable.prototype.getLinearProgress=function(){if(!this.linearProgress){var el=this.getLinearProgressElement();this.linearProgress=new MDCLinearProgress(el)}return this.linearProgress};return MDCDataTable}(MDCComponent);function MBDataTable_init(elem,hasProgress,showProgress){if(!elem){return}elem._dataTable=MDCDataTable.attachTo(elem);if(hasProgress){MBDataTable_setProgress(elem,showProgress)}}function MBDataTable_setProgress(elem,showProgress){if(!elem){return}if(showProgress){elem._dataTable.showProgress()}else{elem._dataTable.hideProgress()}}
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
 */
var select_constants_cssClasses={ACTIVATED:"mdc-select--activated",DISABLED:"mdc-select--disabled",FOCUSED:"mdc-select--focused",INVALID:"mdc-select--invalid",MENU_INVALID:"mdc-select__menu--invalid",OUTLINED:"mdc-select--outlined",REQUIRED:"mdc-select--required",ROOT:"mdc-select",WITH_LEADING_ICON:"mdc-select--with-leading-icon"};var select_constants_strings={ARIA_CONTROLS:"aria-controls",ARIA_DESCRIBEDBY:"aria-describedby",ARIA_SELECTED_ATTR:"aria-selected",CHANGE_EVENT:"MDCSelect:change",HIDDEN_INPUT_SELECTOR:'input[type="hidden"]',LABEL_SELECTOR:".mdc-floating-label",LEADING_ICON_SELECTOR:".mdc-select__icon",LINE_RIPPLE_SELECTOR:".mdc-line-ripple",MENU_SELECTOR:".mdc-select__menu",OUTLINE_SELECTOR:".mdc-notched-outline",SELECTED_TEXT_SELECTOR:".mdc-select__selected-text",SELECT_ANCHOR_SELECTOR:".mdc-select__anchor",VALUE_ATTR:"data-value"};var select_constants_numbers={LABEL_SCALE:.75,UNSET_INDEX:-1,CLICK_DEBOUNCE_TIMEOUT_MS:330};
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
 */
var MDCSelectFoundation=function(_super){__extends(MDCSelectFoundation,_super);function MDCSelectFoundation(adapter,foundationMap){if(foundationMap===void 0){foundationMap={}}var _this=_super.call(this,__assign(__assign({},MDCSelectFoundation.defaultAdapter),adapter))||this;_this.disabled=false;_this.isMenuOpen=false;_this.useDefaultValidation=true;_this.customValidity=true;_this.lastSelectedIndex=select_constants_numbers.UNSET_INDEX;_this.clickDebounceTimeout=0;_this.recentlyClicked=false;_this.leadingIcon=foundationMap.leadingIcon;_this.helperText=foundationMap.helperText;return _this}Object.defineProperty(MDCSelectFoundation,"cssClasses",{get:function(){return select_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCSelectFoundation,"numbers",{get:function(){return select_constants_numbers},enumerable:true,configurable:true});Object.defineProperty(MDCSelectFoundation,"strings",{get:function(){return select_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCSelectFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},removeClass:function(){return undefined},hasClass:function(){return false},activateBottomLine:function(){return undefined},deactivateBottomLine:function(){return undefined},getSelectedIndex:function(){return-1},setSelectedIndex:function(){return undefined},hasLabel:function(){return false},floatLabel:function(){return undefined},getLabelWidth:function(){return 0},setLabelRequired:function(){return undefined},hasOutline:function(){return false},notchOutline:function(){return undefined},closeOutline:function(){return undefined},setRippleCenter:function(){return undefined},notifyChange:function(){return undefined},setSelectedText:function(){return undefined},isSelectAnchorFocused:function(){return false},getSelectAnchorAttr:function(){return""},setSelectAnchorAttr:function(){return undefined},removeSelectAnchorAttr:function(){return undefined},addMenuClass:function(){return undefined},removeMenuClass:function(){return undefined},openMenu:function(){return undefined},closeMenu:function(){return undefined},getAnchorElement:function(){return null},setMenuAnchorElement:function(){return undefined},setMenuAnchorCorner:function(){return undefined},setMenuWrapFocus:function(){return undefined},focusMenuItemAtIndex:function(){return undefined},getMenuItemCount:function(){return 0},getMenuItemValues:function(){return[]},getMenuItemTextAtIndex:function(){return""},isTypeaheadInProgress:function(){return false},typeaheadMatchItem:function(){return-1}}},enumerable:true,configurable:true});MDCSelectFoundation.prototype.getSelectedIndex=function(){return this.adapter.getSelectedIndex()};MDCSelectFoundation.prototype.setSelectedIndex=function(index,closeMenu,skipNotify){if(closeMenu===void 0){closeMenu=false}if(skipNotify===void 0){skipNotify=false}if(index>=this.adapter.getMenuItemCount()){return}if(index===select_constants_numbers.UNSET_INDEX){this.adapter.setSelectedText("")}else{this.adapter.setSelectedText(this.adapter.getMenuItemTextAtIndex(index).trim())}this.adapter.setSelectedIndex(index);if(closeMenu){this.adapter.closeMenu()}if(!skipNotify&&this.lastSelectedIndex!==index){this.handleChange()}this.lastSelectedIndex=index};MDCSelectFoundation.prototype.setValue=function(value,skipNotify){if(skipNotify===void 0){skipNotify=false}var index=this.adapter.getMenuItemValues().indexOf(value);this.setSelectedIndex(index,false,skipNotify)};MDCSelectFoundation.prototype.getValue=function(){var index=this.adapter.getSelectedIndex();var menuItemValues=this.adapter.getMenuItemValues();return index!==select_constants_numbers.UNSET_INDEX?menuItemValues[index]:""};MDCSelectFoundation.prototype.getDisabled=function(){return this.disabled};MDCSelectFoundation.prototype.setDisabled=function(isDisabled){this.disabled=isDisabled;if(this.disabled){this.adapter.addClass(select_constants_cssClasses.DISABLED);this.adapter.closeMenu()}else{this.adapter.removeClass(select_constants_cssClasses.DISABLED)}if(this.leadingIcon){this.leadingIcon.setDisabled(this.disabled)}if(this.disabled){this.adapter.removeSelectAnchorAttr("tabindex")}else{this.adapter.setSelectAnchorAttr("tabindex","0")}this.adapter.setSelectAnchorAttr("aria-disabled",this.disabled.toString())};MDCSelectFoundation.prototype.openMenu=function(){this.adapter.addClass(select_constants_cssClasses.ACTIVATED);this.adapter.openMenu();this.isMenuOpen=true;this.adapter.setSelectAnchorAttr("aria-expanded","true")};MDCSelectFoundation.prototype.setHelperTextContent=function(content){if(this.helperText){this.helperText.setContent(content)}};MDCSelectFoundation.prototype.layout=function(){if(this.adapter.hasLabel()){var optionHasValue=this.getValue().length>0;var isFocused=this.adapter.hasClass(select_constants_cssClasses.FOCUSED);var shouldFloatAndNotch=optionHasValue||isFocused;var isRequired=this.adapter.hasClass(select_constants_cssClasses.REQUIRED);this.notchOutline(shouldFloatAndNotch);this.adapter.floatLabel(shouldFloatAndNotch);this.adapter.setLabelRequired(isRequired)}};MDCSelectFoundation.prototype.layoutOptions=function(){var menuItemValues=this.adapter.getMenuItemValues();var selectedIndex=menuItemValues.indexOf(this.getValue());this.setSelectedIndex(selectedIndex,false,true)};MDCSelectFoundation.prototype.handleMenuOpened=function(){if(this.adapter.getMenuItemValues().length===0){return}var selectedIndex=this.getSelectedIndex();var focusItemIndex=selectedIndex>=0?selectedIndex:0;this.adapter.focusMenuItemAtIndex(focusItemIndex)};MDCSelectFoundation.prototype.handleMenuClosed=function(){this.adapter.removeClass(select_constants_cssClasses.ACTIVATED);this.isMenuOpen=false;this.adapter.setSelectAnchorAttr("aria-expanded","false");if(!this.adapter.isSelectAnchorFocused()){this.blur()}};MDCSelectFoundation.prototype.handleChange=function(){this.layout();this.adapter.notifyChange(this.getValue());var isRequired=this.adapter.hasClass(select_constants_cssClasses.REQUIRED);if(isRequired&&this.useDefaultValidation){this.setValid(this.isValid())}};MDCSelectFoundation.prototype.handleMenuItemAction=function(index){this.setSelectedIndex(index,true)};MDCSelectFoundation.prototype.handleFocus=function(){this.adapter.addClass(select_constants_cssClasses.FOCUSED);this.layout();this.adapter.activateBottomLine()};MDCSelectFoundation.prototype.handleBlur=function(){if(this.isMenuOpen){return}this.blur()};MDCSelectFoundation.prototype.handleClick=function(normalizedX){if(this.disabled||this.recentlyClicked){return}this.setClickDebounceTimeout();if(this.isMenuOpen){this.adapter.closeMenu();return}this.adapter.setRippleCenter(normalizedX);this.openMenu()};MDCSelectFoundation.prototype.handleKeydown=function(event){if(this.isMenuOpen||!this.adapter.hasClass(select_constants_cssClasses.FOCUSED)){return}var isEnter=normalizeKey(event)===KEY.ENTER;var isSpace=normalizeKey(event)===KEY.SPACEBAR;var arrowUp=normalizeKey(event)===KEY.ARROW_UP;var arrowDown=normalizeKey(event)===KEY.ARROW_DOWN;if(!isSpace&&event.key&&event.key.length===1||isSpace&&this.adapter.isTypeaheadInProgress()){var key=isSpace?" ":event.key;var typeaheadNextIndex=this.adapter.typeaheadMatchItem(key,this.getSelectedIndex());if(typeaheadNextIndex>=0){this.setSelectedIndex(typeaheadNextIndex)}event.preventDefault();return}if(!isEnter&&!isSpace&&!arrowUp&&!arrowDown){return}if(arrowUp&&this.getSelectedIndex()>0){this.setSelectedIndex(this.getSelectedIndex()-1)}else if(arrowDown&&this.getSelectedIndex()<this.adapter.getMenuItemCount()-1){this.setSelectedIndex(this.getSelectedIndex()+1)}this.openMenu();event.preventDefault()};MDCSelectFoundation.prototype.notchOutline=function(openNotch){if(!this.adapter.hasOutline()){return}var isFocused=this.adapter.hasClass(select_constants_cssClasses.FOCUSED);if(openNotch){var labelScale=select_constants_numbers.LABEL_SCALE;var labelWidth=this.adapter.getLabelWidth()*labelScale;this.adapter.notchOutline(labelWidth)}else if(!isFocused){this.adapter.closeOutline()}};MDCSelectFoundation.prototype.setLeadingIconAriaLabel=function(label){if(this.leadingIcon){this.leadingIcon.setAriaLabel(label)}};MDCSelectFoundation.prototype.setLeadingIconContent=function(content){if(this.leadingIcon){this.leadingIcon.setContent(content)}};MDCSelectFoundation.prototype.setUseDefaultValidation=function(useDefaultValidation){this.useDefaultValidation=useDefaultValidation};MDCSelectFoundation.prototype.setValid=function(isValid){if(!this.useDefaultValidation){this.customValidity=isValid}this.adapter.setSelectAnchorAttr("aria-invalid",(!isValid).toString());if(isValid){this.adapter.removeClass(select_constants_cssClasses.INVALID);this.adapter.removeMenuClass(select_constants_cssClasses.MENU_INVALID)}else{this.adapter.addClass(select_constants_cssClasses.INVALID);this.adapter.addMenuClass(select_constants_cssClasses.MENU_INVALID)}this.syncHelperTextValidity(isValid)};MDCSelectFoundation.prototype.isValid=function(){if(this.useDefaultValidation&&this.adapter.hasClass(select_constants_cssClasses.REQUIRED)&&!this.adapter.hasClass(select_constants_cssClasses.DISABLED)){return this.getSelectedIndex()!==select_constants_numbers.UNSET_INDEX&&(this.getSelectedIndex()!==0||Boolean(this.getValue()))}return this.customValidity};MDCSelectFoundation.prototype.setRequired=function(isRequired){if(isRequired){this.adapter.addClass(select_constants_cssClasses.REQUIRED)}else{this.adapter.removeClass(select_constants_cssClasses.REQUIRED)}this.adapter.setSelectAnchorAttr("aria-required",isRequired.toString());this.adapter.setLabelRequired(isRequired)};MDCSelectFoundation.prototype.getRequired=function(){return this.adapter.getSelectAnchorAttr("aria-required")==="true"};MDCSelectFoundation.prototype.init=function(){var anchorEl=this.adapter.getAnchorElement();if(anchorEl){this.adapter.setMenuAnchorElement(anchorEl);this.adapter.setMenuAnchorCorner(Corner.BOTTOM_START)}this.adapter.setMenuWrapFocus(false);this.setDisabled(this.adapter.hasClass(select_constants_cssClasses.DISABLED));this.syncHelperTextValidity(!this.adapter.hasClass(select_constants_cssClasses.INVALID));this.layout();this.layoutOptions()};MDCSelectFoundation.prototype.blur=function(){this.adapter.removeClass(select_constants_cssClasses.FOCUSED);this.layout();this.adapter.deactivateBottomLine();var isRequired=this.adapter.hasClass(select_constants_cssClasses.REQUIRED);if(isRequired&&this.useDefaultValidation){this.setValid(this.isValid())}};MDCSelectFoundation.prototype.syncHelperTextValidity=function(isValid){if(!this.helperText){return}this.helperText.setValidity(isValid);var helperTextVisible=this.helperText.isVisible();var helperTextId=this.helperText.getId();if(helperTextVisible&&helperTextId){this.adapter.setSelectAnchorAttr(select_constants_strings.ARIA_DESCRIBEDBY,helperTextId)}else{this.adapter.removeSelectAnchorAttr(select_constants_strings.ARIA_DESCRIBEDBY)}};MDCSelectFoundation.prototype.setClickDebounceTimeout=function(){var _this=this;clearTimeout(this.clickDebounceTimeout);this.clickDebounceTimeout=setTimeout((function(){_this.recentlyClicked=false}),select_constants_numbers.CLICK_DEBOUNCE_TIMEOUT_MS);this.recentlyClicked=true};return MDCSelectFoundation}(MDCFoundation);const select_foundation=null&&MDCSelectFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var select_helper_text_constants_strings={ARIA_HIDDEN:"aria-hidden",ROLE:"role"};var select_helper_text_constants_cssClasses={HELPER_TEXT_VALIDATION_MSG:"mdc-select-helper-text--validation-msg",HELPER_TEXT_VALIDATION_MSG_PERSISTENT:"mdc-select-helper-text--validation-msg-persistent"};
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCSelectHelperTextFoundation=function(_super){__extends(MDCSelectHelperTextFoundation,_super);function MDCSelectHelperTextFoundation(adapter){return _super.call(this,__assign(__assign({},MDCSelectHelperTextFoundation.defaultAdapter),adapter))||this}Object.defineProperty(MDCSelectHelperTextFoundation,"cssClasses",{get:function(){return select_helper_text_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCSelectHelperTextFoundation,"strings",{get:function(){return select_helper_text_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCSelectHelperTextFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},removeClass:function(){return undefined},hasClass:function(){return false},setAttr:function(){return undefined},getAttr:function(){return null},removeAttr:function(){return undefined},setContent:function(){return undefined}}},enumerable:true,configurable:true});MDCSelectHelperTextFoundation.prototype.getId=function(){return this.adapter.getAttr("id")};MDCSelectHelperTextFoundation.prototype.isVisible=function(){return this.adapter.getAttr(select_helper_text_constants_strings.ARIA_HIDDEN)!=="true"};MDCSelectHelperTextFoundation.prototype.setContent=function(content){this.adapter.setContent(content)};MDCSelectHelperTextFoundation.prototype.setValidation=function(isValidation){if(isValidation){this.adapter.addClass(select_helper_text_constants_cssClasses.HELPER_TEXT_VALIDATION_MSG)}else{this.adapter.removeClass(select_helper_text_constants_cssClasses.HELPER_TEXT_VALIDATION_MSG)}};MDCSelectHelperTextFoundation.prototype.setValidationMsgPersistent=function(isPersistent){if(isPersistent){this.adapter.addClass(select_helper_text_constants_cssClasses.HELPER_TEXT_VALIDATION_MSG_PERSISTENT)}else{this.adapter.removeClass(select_helper_text_constants_cssClasses.HELPER_TEXT_VALIDATION_MSG_PERSISTENT)}};MDCSelectHelperTextFoundation.prototype.setValidity=function(selectIsValid){var isValidationMsg=this.adapter.hasClass(select_helper_text_constants_cssClasses.HELPER_TEXT_VALIDATION_MSG);if(!isValidationMsg){return}var isPersistentValidationMsg=this.adapter.hasClass(select_helper_text_constants_cssClasses.HELPER_TEXT_VALIDATION_MSG_PERSISTENT);var msgShouldDisplay=!selectIsValid||isPersistentValidationMsg;if(msgShouldDisplay){this.showToScreenReader();if(!selectIsValid){this.adapter.setAttr(select_helper_text_constants_strings.ROLE,"alert")}else{this.adapter.removeAttr(select_helper_text_constants_strings.ROLE)}return}this.adapter.removeAttr(select_helper_text_constants_strings.ROLE);this.hide()};MDCSelectHelperTextFoundation.prototype.showToScreenReader=function(){this.adapter.removeAttr(select_helper_text_constants_strings.ARIA_HIDDEN)};MDCSelectHelperTextFoundation.prototype.hide=function(){this.adapter.setAttr(select_helper_text_constants_strings.ARIA_HIDDEN,"true")};return MDCSelectHelperTextFoundation}(MDCFoundation);const select_helper_text_foundation=null&&MDCSelectHelperTextFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCSelectHelperText=function(_super){__extends(MDCSelectHelperText,_super);function MDCSelectHelperText(){return _super!==null&&_super.apply(this,arguments)||this}MDCSelectHelperText.attachTo=function(root){return new MDCSelectHelperText(root)};Object.defineProperty(MDCSelectHelperText.prototype,"foundationForSelect",{get:function(){return this.foundation},enumerable:true,configurable:true});MDCSelectHelperText.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClass:function(className){return _this.root.classList.add(className)},removeClass:function(className){return _this.root.classList.remove(className)},hasClass:function(className){return _this.root.classList.contains(className)},getAttr:function(attr){return _this.root.getAttribute(attr)},setAttr:function(attr,value){return _this.root.setAttribute(attr,value)},removeAttr:function(attr){return _this.root.removeAttribute(attr)},setContent:function(content){_this.root.textContent=content}};return new MDCSelectHelperTextFoundation(adapter)};return MDCSelectHelperText}(MDCComponent);
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var select_icon_constants_strings={ICON_EVENT:"MDCSelect:icon",ICON_ROLE:"button"};
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var icon_foundation_INTERACTION_EVENTS=["click","keydown"];var MDCSelectIconFoundation=function(_super){__extends(MDCSelectIconFoundation,_super);function MDCSelectIconFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCSelectIconFoundation.defaultAdapter),adapter))||this;_this.savedTabIndex_=null;_this.interactionHandler_=function(evt){return _this.handleInteraction(evt)};return _this}Object.defineProperty(MDCSelectIconFoundation,"strings",{get:function(){return select_icon_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCSelectIconFoundation,"defaultAdapter",{get:function(){return{getAttr:function(){return null},setAttr:function(){return undefined},removeAttr:function(){return undefined},setContent:function(){return undefined},registerInteractionHandler:function(){return undefined},deregisterInteractionHandler:function(){return undefined},notifyIconAction:function(){return undefined}}},enumerable:true,configurable:true});MDCSelectIconFoundation.prototype.init=function(){var _this=this;this.savedTabIndex_=this.adapter.getAttr("tabindex");icon_foundation_INTERACTION_EVENTS.forEach((function(evtType){_this.adapter.registerInteractionHandler(evtType,_this.interactionHandler_)}))};MDCSelectIconFoundation.prototype.destroy=function(){var _this=this;icon_foundation_INTERACTION_EVENTS.forEach((function(evtType){_this.adapter.deregisterInteractionHandler(evtType,_this.interactionHandler_)}))};MDCSelectIconFoundation.prototype.setDisabled=function(disabled){if(!this.savedTabIndex_){return}if(disabled){this.adapter.setAttr("tabindex","-1");this.adapter.removeAttr("role")}else{this.adapter.setAttr("tabindex",this.savedTabIndex_);this.adapter.setAttr("role",select_icon_constants_strings.ICON_ROLE)}};MDCSelectIconFoundation.prototype.setAriaLabel=function(label){this.adapter.setAttr("aria-label",label)};MDCSelectIconFoundation.prototype.setContent=function(content){this.adapter.setContent(content)};MDCSelectIconFoundation.prototype.handleInteraction=function(evt){var isEnterKey=evt.key==="Enter"||evt.keyCode===13;if(evt.type==="click"||isEnterKey){this.adapter.notifyIconAction()}};return MDCSelectIconFoundation}(MDCFoundation);const select_icon_foundation=null&&MDCSelectIconFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCSelectIcon=function(_super){__extends(MDCSelectIcon,_super);function MDCSelectIcon(){return _super!==null&&_super.apply(this,arguments)||this}MDCSelectIcon.attachTo=function(root){return new MDCSelectIcon(root)};Object.defineProperty(MDCSelectIcon.prototype,"foundationForSelect",{get:function(){return this.foundation},enumerable:true,configurable:true});MDCSelectIcon.prototype.getDefaultFoundation=function(){var _this=this;var adapter={getAttr:function(attr){return _this.root.getAttribute(attr)},setAttr:function(attr,value){return _this.root.setAttribute(attr,value)},removeAttr:function(attr){return _this.root.removeAttribute(attr)},setContent:function(content){_this.root.textContent=content},registerInteractionHandler:function(evtType,handler){return _this.listen(evtType,handler)},deregisterInteractionHandler:function(evtType,handler){return _this.unlisten(evtType,handler)},notifyIconAction:function(){return _this.emit(MDCSelectIconFoundation.strings.ICON_EVENT,{},true)}};return new MDCSelectIconFoundation(adapter)};return MDCSelectIcon}(MDCComponent);
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
 */
var MDCSelect=function(_super){__extends(MDCSelect,_super);function MDCSelect(){return _super!==null&&_super.apply(this,arguments)||this}MDCSelect.attachTo=function(root){return new MDCSelect(root)};MDCSelect.prototype.initialize=function(labelFactory,lineRippleFactory,outlineFactory,menuFactory,iconFactory,helperTextFactory){if(labelFactory===void 0){labelFactory=function(el){return new MDCFloatingLabel(el)}}if(lineRippleFactory===void 0){lineRippleFactory=function(el){return new MDCLineRipple(el)}}if(outlineFactory===void 0){outlineFactory=function(el){return new MDCNotchedOutline(el)}}if(menuFactory===void 0){menuFactory=function(el){return new MDCMenu(el)}}if(iconFactory===void 0){iconFactory=function(el){return new MDCSelectIcon(el)}}if(helperTextFactory===void 0){helperTextFactory=function(el){return new MDCSelectHelperText(el)}}this.selectAnchor=this.root.querySelector(select_constants_strings.SELECT_ANCHOR_SELECTOR);this.selectedText=this.root.querySelector(select_constants_strings.SELECTED_TEXT_SELECTOR);this.hiddenInput=this.root.querySelector(select_constants_strings.HIDDEN_INPUT_SELECTOR);if(!this.selectedText){throw new Error("MDCSelect: Missing required element: The following selector must be present: "+("'"+select_constants_strings.SELECTED_TEXT_SELECTOR+"'"))}if(this.selectAnchor.hasAttribute(select_constants_strings.ARIA_CONTROLS)){var helperTextElement=document.getElementById(this.selectAnchor.getAttribute(select_constants_strings.ARIA_CONTROLS));if(helperTextElement){this.helperText=helperTextFactory(helperTextElement)}}this.menuSetup(menuFactory);var labelElement=this.root.querySelector(select_constants_strings.LABEL_SELECTOR);this.label=labelElement?labelFactory(labelElement):null;var lineRippleElement=this.root.querySelector(select_constants_strings.LINE_RIPPLE_SELECTOR);this.lineRipple=lineRippleElement?lineRippleFactory(lineRippleElement):null;var outlineElement=this.root.querySelector(select_constants_strings.OUTLINE_SELECTOR);this.outline=outlineElement?outlineFactory(outlineElement):null;var leadingIcon=this.root.querySelector(select_constants_strings.LEADING_ICON_SELECTOR);if(leadingIcon){this.leadingIcon=iconFactory(leadingIcon)}if(!this.root.classList.contains(select_constants_cssClasses.OUTLINED)){this.ripple=this.createRipple()}};MDCSelect.prototype.initialSyncWithDOM=function(){var _this=this;this.handleFocus=function(){_this.foundation.handleFocus()};this.handleBlur=function(){_this.foundation.handleBlur()};this.handleClick=function(evt){_this.selectAnchor.focus();_this.foundation.handleClick(_this.getNormalizedXCoordinate(evt))};this.handleKeydown=function(evt){_this.foundation.handleKeydown(evt)};this.handleMenuItemAction=function(evt){_this.foundation.handleMenuItemAction(evt.detail.index)};this.handleMenuOpened=function(){_this.foundation.handleMenuOpened()};this.handleMenuClosed=function(){_this.foundation.handleMenuClosed()};this.selectAnchor.addEventListener("focus",this.handleFocus);this.selectAnchor.addEventListener("blur",this.handleBlur);this.selectAnchor.addEventListener("click",this.handleClick);this.selectAnchor.addEventListener("keydown",this.handleKeydown);this.menu.listen(menu_surface_constants_strings.CLOSED_EVENT,this.handleMenuClosed);this.menu.listen(menu_surface_constants_strings.OPENED_EVENT,this.handleMenuOpened);this.menu.listen(menu_constants_strings.SELECTED_EVENT,this.handleMenuItemAction);if(this.hiddenInput){if(this.hiddenInput.value){this.foundation.setValue(this.hiddenInput.value,true);this.foundation.layout();return}this.hiddenInput.value=this.value}};MDCSelect.prototype.destroy=function(){this.selectAnchor.removeEventListener("focus",this.handleFocus);this.selectAnchor.removeEventListener("blur",this.handleBlur);this.selectAnchor.removeEventListener("keydown",this.handleKeydown);this.selectAnchor.removeEventListener("click",this.handleClick);this.menu.unlisten(menu_surface_constants_strings.CLOSED_EVENT,this.handleMenuClosed);this.menu.unlisten(menu_surface_constants_strings.OPENED_EVENT,this.handleMenuOpened);this.menu.unlisten(menu_constants_strings.SELECTED_EVENT,this.handleMenuItemAction);this.menu.destroy();if(this.ripple){this.ripple.destroy()}if(this.outline){this.outline.destroy()}if(this.leadingIcon){this.leadingIcon.destroy()}if(this.helperText){this.helperText.destroy()}_super.prototype.destroy.call(this)};Object.defineProperty(MDCSelect.prototype,"value",{get:function(){return this.foundation.getValue()},set:function(value){this.foundation.setValue(value)},enumerable:true,configurable:true});Object.defineProperty(MDCSelect.prototype,"selectedIndex",{get:function(){return this.foundation.getSelectedIndex()},set:function(selectedIndex){this.foundation.setSelectedIndex(selectedIndex,true)},enumerable:true,configurable:true});Object.defineProperty(MDCSelect.prototype,"disabled",{get:function(){return this.foundation.getDisabled()},set:function(disabled){this.foundation.setDisabled(disabled);if(this.hiddenInput){this.hiddenInput.disabled=disabled}},enumerable:true,configurable:true});Object.defineProperty(MDCSelect.prototype,"leadingIconAriaLabel",{set:function(label){this.foundation.setLeadingIconAriaLabel(label)},enumerable:true,configurable:true});Object.defineProperty(MDCSelect.prototype,"leadingIconContent",{set:function(content){this.foundation.setLeadingIconContent(content)},enumerable:true,configurable:true});Object.defineProperty(MDCSelect.prototype,"helperTextContent",{set:function(content){this.foundation.setHelperTextContent(content)},enumerable:true,configurable:true});Object.defineProperty(MDCSelect.prototype,"useDefaultValidation",{set:function(useDefaultValidation){this.foundation.setUseDefaultValidation(useDefaultValidation)},enumerable:true,configurable:true});Object.defineProperty(MDCSelect.prototype,"valid",{get:function(){return this.foundation.isValid()},set:function(isValid){this.foundation.setValid(isValid)},enumerable:true,configurable:true});Object.defineProperty(MDCSelect.prototype,"required",{get:function(){return this.foundation.getRequired()},set:function(isRequired){this.foundation.setRequired(isRequired)},enumerable:true,configurable:true});MDCSelect.prototype.layout=function(){this.foundation.layout()};MDCSelect.prototype.layoutOptions=function(){this.foundation.layoutOptions();this.menu.layout();this.menuItemValues=this.menu.items.map((function(el){return el.getAttribute(select_constants_strings.VALUE_ATTR)||""}));if(this.hiddenInput){this.hiddenInput.value=this.value}};MDCSelect.prototype.getDefaultFoundation=function(){var adapter=__assign(__assign(__assign(__assign({},this.getSelectAdapterMethods()),this.getCommonAdapterMethods()),this.getOutlineAdapterMethods()),this.getLabelAdapterMethods());return new MDCSelectFoundation(adapter,this.getFoundationMap())};MDCSelect.prototype.menuSetup=function(menuFactory){this.menuElement=this.root.querySelector(select_constants_strings.MENU_SELECTOR);this.menu=menuFactory(this.menuElement);this.menu.hasTypeahead=true;this.menu.singleSelection=true;this.menuItemValues=this.menu.items.map((function(el){return el.getAttribute(select_constants_strings.VALUE_ATTR)||""}))};MDCSelect.prototype.createRipple=function(){var _this=this;var adapter=__assign(__assign({},MDCRipple.createAdapter({root:this.selectAnchor})),{registerInteractionHandler:function(evtType,handler){_this.selectAnchor.addEventListener(evtType,handler)},deregisterInteractionHandler:function(evtType,handler){_this.selectAnchor.removeEventListener(evtType,handler)}});return new MDCRipple(this.selectAnchor,new MDCRippleFoundation(adapter))};MDCSelect.prototype.getSelectAdapterMethods=function(){var _this=this;return{getMenuItemAttr:function(menuItem,attr){return menuItem.getAttribute(attr)},setSelectedText:function(text){_this.selectedText.textContent=text},isSelectAnchorFocused:function(){return document.activeElement===_this.selectAnchor},getSelectAnchorAttr:function(attr){return _this.selectAnchor.getAttribute(attr)},setSelectAnchorAttr:function(attr,value){_this.selectAnchor.setAttribute(attr,value)},removeSelectAnchorAttr:function(attr){_this.selectAnchor.removeAttribute(attr)},addMenuClass:function(className){_this.menuElement.classList.add(className)},removeMenuClass:function(className){_this.menuElement.classList.remove(className)},openMenu:function(){_this.menu.open=true},closeMenu:function(){_this.menu.open=false},getAnchorElement:function(){return _this.root.querySelector(select_constants_strings.SELECT_ANCHOR_SELECTOR)},setMenuAnchorElement:function(anchorEl){_this.menu.setAnchorElement(anchorEl)},setMenuAnchorCorner:function(anchorCorner){_this.menu.setAnchorCorner(anchorCorner)},setMenuWrapFocus:function(wrapFocus){_this.menu.wrapFocus=wrapFocus},getSelectedIndex:function(){var index=_this.menu.selectedIndex;return index instanceof Array?index[0]:index},setSelectedIndex:function(index){_this.menu.selectedIndex=index},focusMenuItemAtIndex:function(index){_this.menu.items[index].focus()},getMenuItemCount:function(){return _this.menu.items.length},getMenuItemValues:function(){return _this.menuItemValues},getMenuItemTextAtIndex:function(index){return _this.menu.getPrimaryTextAtIndex(index)},isTypeaheadInProgress:function(){return _this.menu.typeaheadInProgress},typeaheadMatchItem:function(nextChar,startingIndex){return _this.menu.typeaheadMatchItem(nextChar,startingIndex)}}};MDCSelect.prototype.getCommonAdapterMethods=function(){var _this=this;return{addClass:function(className){_this.root.classList.add(className)},removeClass:function(className){_this.root.classList.remove(className)},hasClass:function(className){return _this.root.classList.contains(className)},setRippleCenter:function(normalizedX){_this.lineRipple&&_this.lineRipple.setRippleCenter(normalizedX)},activateBottomLine:function(){_this.lineRipple&&_this.lineRipple.activate()},deactivateBottomLine:function(){_this.lineRipple&&_this.lineRipple.deactivate()},notifyChange:function(value){var index=_this.selectedIndex;_this.emit(select_constants_strings.CHANGE_EVENT,{value:value,index:index},true);if(_this.hiddenInput){_this.hiddenInput.value=value}}}};MDCSelect.prototype.getOutlineAdapterMethods=function(){var _this=this;return{hasOutline:function(){return Boolean(_this.outline)},notchOutline:function(labelWidth){_this.outline&&_this.outline.notch(labelWidth)},closeOutline:function(){_this.outline&&_this.outline.closeNotch()}}};MDCSelect.prototype.getLabelAdapterMethods=function(){var _this=this;return{hasLabel:function(){return!!_this.label},floatLabel:function(shouldFloat){_this.label&&_this.label.float(shouldFloat)},getLabelWidth:function(){return _this.label?_this.label.getWidth():0},setLabelRequired:function(isRequired){_this.label&&_this.label.setRequired(isRequired)}}};MDCSelect.prototype.getNormalizedXCoordinate=function(evt){var targetClientRect=evt.target.getBoundingClientRect();var xCoordinate=this.isTouchEvent(evt)?evt.touches[0].clientX:evt.clientX;return xCoordinate-targetClientRect.left};MDCSelect.prototype.isTouchEvent=function(evt){return Boolean(evt.touches)};MDCSelect.prototype.getFoundationMap=function(){return{helperText:this.helperText?this.helperText.foundationForSelect:undefined,leadingIcon:this.leadingIcon?this.leadingIcon.foundationForSelect:undefined}};return MDCSelect}(MDCComponent);function MBDatePicker_init(elem,menuSurfaceElem,dotNetObject){if(!elem||!menuSurfaceElem){return}elem._select=MDCSelect.attachTo(elem);elem._menuSurface=MDCMenuSurface.attachTo(menuSurfaceElem);var openCallback=function openCallback(){elem._menuSurface.unlisten("MDCMenuSurface:opened",openCallback);dotNetObject.invokeMethodAsync("NotifyOpened")};elem._menuSurface.listen("MDCMenuSurface:opened",openCallback)}function MBDatePicker_setDisabled(elem,value){if(!elem){return}elem._select.disabled=value}function listItemClick(elem,elemText){if(!elem){return}elem.innerText=elemText;elem.click()}function tryScrollToYear(id,attempt){setTimeout((function(){var element=document.getElementById(id);if(element){element.scrollIntoView({behavior:"auto",block:"nearest",inline:"nearest"})}else{if(attempt<10){tryScrollToYear(id,attempt+1)}}}),16)}function scrollToYear(id){tryScrollToYear(id,0)}
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
 */
var FOCUS_SENTINEL_CLASS="mdc-dom-focus-sentinel";var FocusTrap=function(){function FocusTrap(root,options){if(options===void 0){options={}}this.root=root;this.options=options;this.elFocusedBeforeTrapFocus=null}FocusTrap.prototype.trapFocus=function(){var focusableEls=this.getFocusableElements(this.root);if(focusableEls.length===0){throw new Error("FocusTrap: Element must have at least one focusable child.")}this.elFocusedBeforeTrapFocus=document.activeElement instanceof HTMLElement?document.activeElement:null;this.wrapTabFocus(this.root,focusableEls);if(!this.options.skipInitialFocus){this.focusInitialElement(focusableEls,this.options.initialFocusEl)}};FocusTrap.prototype.releaseFocus=function(){[].slice.call(this.root.querySelectorAll("."+FOCUS_SENTINEL_CLASS)).forEach((function(sentinelEl){sentinelEl.parentElement.removeChild(sentinelEl)}));if(this.elFocusedBeforeTrapFocus){this.elFocusedBeforeTrapFocus.focus()}};FocusTrap.prototype.wrapTabFocus=function(el,focusableEls){var sentinelStart=this.createSentinel();var sentinelEnd=this.createSentinel();sentinelStart.addEventListener("focus",(function(){if(focusableEls.length>0){focusableEls[focusableEls.length-1].focus()}}));sentinelEnd.addEventListener("focus",(function(){if(focusableEls.length>0){focusableEls[0].focus()}}));el.insertBefore(sentinelStart,el.children[0]);el.appendChild(sentinelEnd)};FocusTrap.prototype.focusInitialElement=function(focusableEls,initialFocusEl){var focusIndex=0;if(initialFocusEl){focusIndex=Math.max(focusableEls.indexOf(initialFocusEl),0)}focusableEls[focusIndex].focus()};FocusTrap.prototype.getFocusableElements=function(root){var focusableEls=[].slice.call(root.querySelectorAll("[autofocus], [tabindex], a, input, textarea, select, button"));return focusableEls.filter((function(el){var isDisabledOrHidden=el.getAttribute("aria-disabled")==="true"||el.getAttribute("disabled")!=null||el.getAttribute("hidden")!=null||el.getAttribute("aria-hidden")==="true";var isTabbableAndVisible=el.tabIndex>=0&&el.getBoundingClientRect().width>0&&!el.classList.contains(FOCUS_SENTINEL_CLASS)&&!isDisabledOrHidden;var isProgrammaticallyHidden=false;if(isTabbableAndVisible){var style=getComputedStyle(el);isProgrammaticallyHidden=style.display==="none"||style.visibility==="hidden"}return isTabbableAndVisible&&!isProgrammaticallyHidden}))};FocusTrap.prototype.createSentinel=function(){var sentinel=document.createElement("div");sentinel.setAttribute("tabindex","0");sentinel.setAttribute("aria-hidden","true");sentinel.classList.add(FOCUS_SENTINEL_CLASS);return sentinel};return FocusTrap}();
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
 */
var dialog_constants_cssClasses={CLOSING:"mdc-dialog--closing",OPEN:"mdc-dialog--open",OPENING:"mdc-dialog--opening",SCROLLABLE:"mdc-dialog--scrollable",SCROLL_LOCK:"mdc-dialog-scroll-lock",STACKED:"mdc-dialog--stacked"};var dialog_constants_strings={ACTION_ATTRIBUTE:"data-mdc-dialog-action",BUTTON_DEFAULT_ATTRIBUTE:"data-mdc-dialog-button-default",BUTTON_SELECTOR:".mdc-dialog__button",CLOSED_EVENT:"MDCDialog:closed",CLOSE_ACTION:"close",CLOSING_EVENT:"MDCDialog:closing",CONTAINER_SELECTOR:".mdc-dialog__container",CONTENT_SELECTOR:".mdc-dialog__content",DESTROY_ACTION:"destroy",INITIAL_FOCUS_ATTRIBUTE:"data-mdc-dialog-initial-focus",OPENED_EVENT:"MDCDialog:opened",OPENING_EVENT:"MDCDialog:opening",SCRIM_SELECTOR:".mdc-dialog__scrim",SUPPRESS_DEFAULT_PRESS_SELECTOR:["textarea",".mdc-menu .mdc-list-item"].join(", "),SURFACE_SELECTOR:".mdc-dialog__surface"};var dialog_constants_numbers={DIALOG_ANIMATION_CLOSE_TIME_MS:75,DIALOG_ANIMATION_OPEN_TIME_MS:150};
/**
 * @license
 * Copyright 2017 Google Inc.
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
 */
var MDCDialogFoundation=function(_super){__extends(MDCDialogFoundation,_super);function MDCDialogFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCDialogFoundation.defaultAdapter),adapter))||this;_this.isOpen_=false;_this.animationFrame_=0;_this.animationTimer_=0;_this.layoutFrame_=0;_this.escapeKeyAction_=dialog_constants_strings.CLOSE_ACTION;_this.scrimClickAction_=dialog_constants_strings.CLOSE_ACTION;_this.autoStackButtons_=true;_this.areButtonsStacked_=false;_this.suppressDefaultPressSelector=dialog_constants_strings.SUPPRESS_DEFAULT_PRESS_SELECTOR;return _this}Object.defineProperty(MDCDialogFoundation,"cssClasses",{get:function(){return dialog_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCDialogFoundation,"strings",{get:function(){return dialog_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCDialogFoundation,"numbers",{get:function(){return dialog_constants_numbers},enumerable:true,configurable:true});Object.defineProperty(MDCDialogFoundation,"defaultAdapter",{get:function(){return{addBodyClass:function(){return undefined},addClass:function(){return undefined},areButtonsStacked:function(){return false},clickDefaultButton:function(){return undefined},eventTargetMatches:function(){return false},getActionFromEvent:function(){return""},getInitialFocusEl:function(){return null},hasClass:function(){return false},isContentScrollable:function(){return false},notifyClosed:function(){return undefined},notifyClosing:function(){return undefined},notifyOpened:function(){return undefined},notifyOpening:function(){return undefined},releaseFocus:function(){return undefined},removeBodyClass:function(){return undefined},removeClass:function(){return undefined},reverseButtons:function(){return undefined},trapFocus:function(){return undefined}}},enumerable:true,configurable:true});MDCDialogFoundation.prototype.init=function(){if(this.adapter.hasClass(dialog_constants_cssClasses.STACKED)){this.setAutoStackButtons(false)}};MDCDialogFoundation.prototype.destroy=function(){if(this.isOpen_){this.close(dialog_constants_strings.DESTROY_ACTION)}if(this.animationTimer_){clearTimeout(this.animationTimer_);this.handleAnimationTimerEnd_()}if(this.layoutFrame_){cancelAnimationFrame(this.layoutFrame_);this.layoutFrame_=0}};MDCDialogFoundation.prototype.open=function(){var _this=this;this.isOpen_=true;this.adapter.notifyOpening();this.adapter.addClass(dialog_constants_cssClasses.OPENING);this.runNextAnimationFrame_((function(){_this.adapter.addClass(dialog_constants_cssClasses.OPEN);_this.adapter.addBodyClass(dialog_constants_cssClasses.SCROLL_LOCK);_this.layout();_this.animationTimer_=setTimeout((function(){_this.handleAnimationTimerEnd_();_this.adapter.trapFocus(_this.adapter.getInitialFocusEl());_this.adapter.notifyOpened()}),dialog_constants_numbers.DIALOG_ANIMATION_OPEN_TIME_MS)}))};MDCDialogFoundation.prototype.close=function(action){var _this=this;if(action===void 0){action=""}if(!this.isOpen_){return}this.isOpen_=false;this.adapter.notifyClosing(action);this.adapter.addClass(dialog_constants_cssClasses.CLOSING);this.adapter.removeClass(dialog_constants_cssClasses.OPEN);this.adapter.removeBodyClass(dialog_constants_cssClasses.SCROLL_LOCK);cancelAnimationFrame(this.animationFrame_);this.animationFrame_=0;clearTimeout(this.animationTimer_);this.animationTimer_=setTimeout((function(){_this.adapter.releaseFocus();_this.handleAnimationTimerEnd_();_this.adapter.notifyClosed(action)}),dialog_constants_numbers.DIALOG_ANIMATION_CLOSE_TIME_MS)};MDCDialogFoundation.prototype.isOpen=function(){return this.isOpen_};MDCDialogFoundation.prototype.getEscapeKeyAction=function(){return this.escapeKeyAction_};MDCDialogFoundation.prototype.setEscapeKeyAction=function(action){this.escapeKeyAction_=action};MDCDialogFoundation.prototype.getScrimClickAction=function(){return this.scrimClickAction_};MDCDialogFoundation.prototype.setScrimClickAction=function(action){this.scrimClickAction_=action};MDCDialogFoundation.prototype.getAutoStackButtons=function(){return this.autoStackButtons_};MDCDialogFoundation.prototype.setAutoStackButtons=function(autoStack){this.autoStackButtons_=autoStack};MDCDialogFoundation.prototype.getSuppressDefaultPressSelector=function(){return this.suppressDefaultPressSelector};MDCDialogFoundation.prototype.setSuppressDefaultPressSelector=function(selector){this.suppressDefaultPressSelector=selector};MDCDialogFoundation.prototype.layout=function(){var _this=this;if(this.layoutFrame_){cancelAnimationFrame(this.layoutFrame_)}this.layoutFrame_=requestAnimationFrame((function(){_this.layoutInternal_();_this.layoutFrame_=0}))};MDCDialogFoundation.prototype.handleClick=function(evt){var isScrim=this.adapter.eventTargetMatches(evt.target,dialog_constants_strings.SCRIM_SELECTOR);if(isScrim&&this.scrimClickAction_!==""){this.close(this.scrimClickAction_)}else{var action=this.adapter.getActionFromEvent(evt);if(action){this.close(action)}}};MDCDialogFoundation.prototype.handleKeydown=function(evt){var isEnter=evt.key==="Enter"||evt.keyCode===13;if(!isEnter){return}var action=this.adapter.getActionFromEvent(evt);if(action){return}var target=evt.composedPath?evt.composedPath()[0]:evt.target;var isDefault=!this.adapter.eventTargetMatches(target,this.suppressDefaultPressSelector);if(isEnter&&isDefault){this.adapter.clickDefaultButton()}};MDCDialogFoundation.prototype.handleDocumentKeydown=function(evt){var isEscape=evt.key==="Escape"||evt.keyCode===27;if(isEscape&&this.escapeKeyAction_!==""){this.close(this.escapeKeyAction_)}};MDCDialogFoundation.prototype.layoutInternal_=function(){if(this.autoStackButtons_){this.detectStackedButtons_()}this.detectScrollableContent_()};MDCDialogFoundation.prototype.handleAnimationTimerEnd_=function(){this.animationTimer_=0;this.adapter.removeClass(dialog_constants_cssClasses.OPENING);this.adapter.removeClass(dialog_constants_cssClasses.CLOSING)};MDCDialogFoundation.prototype.runNextAnimationFrame_=function(callback){var _this=this;cancelAnimationFrame(this.animationFrame_);this.animationFrame_=requestAnimationFrame((function(){_this.animationFrame_=0;clearTimeout(_this.animationTimer_);_this.animationTimer_=setTimeout(callback,0)}))};MDCDialogFoundation.prototype.detectStackedButtons_=function(){this.adapter.removeClass(dialog_constants_cssClasses.STACKED);var areButtonsStacked=this.adapter.areButtonsStacked();if(areButtonsStacked){this.adapter.addClass(dialog_constants_cssClasses.STACKED)}if(areButtonsStacked!==this.areButtonsStacked_){this.adapter.reverseButtons();this.areButtonsStacked_=areButtonsStacked}};MDCDialogFoundation.prototype.detectScrollableContent_=function(){this.adapter.removeClass(dialog_constants_cssClasses.SCROLLABLE);if(this.adapter.isContentScrollable()){this.adapter.addClass(dialog_constants_cssClasses.SCROLLABLE)}};return MDCDialogFoundation}(MDCFoundation);const dialog_foundation=null&&MDCDialogFoundation;
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
 */
function createFocusTrapInstance(surfaceEl,focusTrapFactory,initialFocusEl){return focusTrapFactory(surfaceEl,{initialFocusEl:initialFocusEl})}function isScrollable(el){return el?el.scrollHeight>el.offsetHeight:false}function areTopsMisaligned(els){var tops=new Set;[].forEach.call(els,(function(el){return tops.add(el.offsetTop)}));return tops.size>1}
/**
 * @license
 * Copyright 2017 Google Inc.
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
 */
var component_strings=MDCDialogFoundation.strings;var MDCDialog=function(_super){__extends(MDCDialog,_super);function MDCDialog(){return _super!==null&&_super.apply(this,arguments)||this}Object.defineProperty(MDCDialog.prototype,"isOpen",{get:function(){return this.foundation.isOpen()},enumerable:true,configurable:true});Object.defineProperty(MDCDialog.prototype,"escapeKeyAction",{get:function(){return this.foundation.getEscapeKeyAction()},set:function(action){this.foundation.setEscapeKeyAction(action)},enumerable:true,configurable:true});Object.defineProperty(MDCDialog.prototype,"scrimClickAction",{get:function(){return this.foundation.getScrimClickAction()},set:function(action){this.foundation.setScrimClickAction(action)},enumerable:true,configurable:true});Object.defineProperty(MDCDialog.prototype,"autoStackButtons",{get:function(){return this.foundation.getAutoStackButtons()},set:function(autoStack){this.foundation.setAutoStackButtons(autoStack)},enumerable:true,configurable:true});MDCDialog.attachTo=function(root){return new MDCDialog(root)};MDCDialog.prototype.initialize=function(focusTrapFactory){var e_1,_a;if(focusTrapFactory===void 0){focusTrapFactory=function(el,focusOptions){return new FocusTrap(el,focusOptions)}}var container=this.root.querySelector(component_strings.CONTAINER_SELECTOR);if(!container){throw new Error("Dialog component requires a "+component_strings.CONTAINER_SELECTOR+" container element")}this.container_=container;this.content_=this.root.querySelector(component_strings.CONTENT_SELECTOR);this.buttons_=[].slice.call(this.root.querySelectorAll(component_strings.BUTTON_SELECTOR));this.defaultButton_=this.root.querySelector("["+component_strings.BUTTON_DEFAULT_ATTRIBUTE+"]");this.focusTrapFactory_=focusTrapFactory;this.buttonRipples_=[];try{for(var _b=__values(this.buttons_),_c=_b.next();!_c.done;_c=_b.next()){var buttonEl=_c.value;this.buttonRipples_.push(new MDCRipple(buttonEl))}}catch(e_1_1){e_1={error:e_1_1}}finally{try{if(_c&&!_c.done&&(_a=_b.return))_a.call(_b)}finally{if(e_1)throw e_1.error}}};MDCDialog.prototype.initialSyncWithDOM=function(){var _this=this;this.focusTrap_=createFocusTrapInstance(this.container_,this.focusTrapFactory_,this.getInitialFocusEl_()||undefined);this.handleClick_=this.foundation.handleClick.bind(this.foundation);this.handleKeydown_=this.foundation.handleKeydown.bind(this.foundation);this.handleDocumentKeydown_=this.foundation.handleDocumentKeydown.bind(this.foundation);this.handleLayout_=this.layout.bind(this);var LAYOUT_EVENTS=["resize","orientationchange"];this.handleOpening_=function(){LAYOUT_EVENTS.forEach((function(evtType){return window.addEventListener(evtType,_this.handleLayout_)}));document.addEventListener("keydown",_this.handleDocumentKeydown_)};this.handleClosing_=function(){LAYOUT_EVENTS.forEach((function(evtType){return window.removeEventListener(evtType,_this.handleLayout_)}));document.removeEventListener("keydown",_this.handleDocumentKeydown_)};this.listen("click",this.handleClick_);this.listen("keydown",this.handleKeydown_);this.listen(component_strings.OPENING_EVENT,this.handleOpening_);this.listen(component_strings.CLOSING_EVENT,this.handleClosing_)};MDCDialog.prototype.destroy=function(){this.unlisten("click",this.handleClick_);this.unlisten("keydown",this.handleKeydown_);this.unlisten(component_strings.OPENING_EVENT,this.handleOpening_);this.unlisten(component_strings.CLOSING_EVENT,this.handleClosing_);this.handleClosing_();this.buttonRipples_.forEach((function(ripple){return ripple.destroy()}));_super.prototype.destroy.call(this)};MDCDialog.prototype.layout=function(){this.foundation.layout()};MDCDialog.prototype.open=function(){this.foundation.open()};MDCDialog.prototype.close=function(action){if(action===void 0){action=""}this.foundation.close(action)};MDCDialog.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addBodyClass:function(className){return document.body.classList.add(className)},addClass:function(className){return _this.root.classList.add(className)},areButtonsStacked:function(){return areTopsMisaligned(_this.buttons_)},clickDefaultButton:function(){return _this.defaultButton_&&_this.defaultButton_.click()},eventTargetMatches:function(target,selector){return target?matches(target,selector):false},getActionFromEvent:function(evt){if(!evt.target){return""}var element=closest(evt.target,"["+component_strings.ACTION_ATTRIBUTE+"]");return element&&element.getAttribute(component_strings.ACTION_ATTRIBUTE)},getInitialFocusEl:function(){return _this.getInitialFocusEl_()},hasClass:function(className){return _this.root.classList.contains(className)},isContentScrollable:function(){return isScrollable(_this.content_)},notifyClosed:function(action){return _this.emit(component_strings.CLOSED_EVENT,action?{action:action}:{})},notifyClosing:function(action){return _this.emit(component_strings.CLOSING_EVENT,action?{action:action}:{})},notifyOpened:function(){return _this.emit(component_strings.OPENED_EVENT,{})},notifyOpening:function(){return _this.emit(component_strings.OPENING_EVENT,{})},releaseFocus:function(){return _this.focusTrap_.releaseFocus()},removeBodyClass:function(className){return document.body.classList.remove(className)},removeClass:function(className){return _this.root.classList.remove(className)},reverseButtons:function(){_this.buttons_.reverse();_this.buttons_.forEach((function(button){button.parentElement.appendChild(button)}))},trapFocus:function(){return _this.focusTrap_.trapFocus()}};return new MDCDialogFoundation(adapter)};MDCDialog.prototype.getInitialFocusEl_=function(){return this.root.querySelector("["+component_strings.INITIAL_FOCUS_ATTRIBUTE+"]")};return MDCDialog}(MDCComponent);function show(elem,dotNetObject,escapeKeyAction,scrimClickAction){if(!elem){return}elem._dialog=elem._dialog||MDCDialog.attachTo(elem);elem._dotNetObject=dotNetObject;var dialog=elem._dialog;var openedCallback=function openedCallback(){dialog.unlisten("MDCDialog:opened",openedCallback);dotNetObject.invokeMethodAsync("NotifyOpened")};dialog.listen("MDCDialog:opened",openedCallback);dialog.escapeKeyAction=escapeKeyAction;dialog.scrimClickAction=scrimClickAction;var closingCallback=function closingCallback(event){dialog.unlisten("MDCDialog:closing",closingCallback);dotNetObject.invokeMethodAsync("NotifyClosed",event.detail.action)};dialog.listen("MDCDialog:closing",closingCallback);dialog.open()}function hide(elem,dialogAction){if(!elem){return}if(elem&&elem._dialog){elem._dialog.close(dialogAction||"dismissed");elem._dialog.destroy()}}
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
 */
var drawer_constants_cssClasses={ANIMATE:"mdc-drawer--animate",CLOSING:"mdc-drawer--closing",DISMISSIBLE:"mdc-drawer--dismissible",MODAL:"mdc-drawer--modal",OPEN:"mdc-drawer--open",OPENING:"mdc-drawer--opening",ROOT:"mdc-drawer"};var drawer_constants_strings={APP_CONTENT_SELECTOR:".mdc-drawer-app-content",CLOSE_EVENT:"MDCDrawer:closed",OPEN_EVENT:"MDCDrawer:opened",SCRIM_SELECTOR:".mdc-drawer-scrim"};
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCDismissibleDrawerFoundation=function(_super){__extends(MDCDismissibleDrawerFoundation,_super);function MDCDismissibleDrawerFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCDismissibleDrawerFoundation.defaultAdapter),adapter))||this;_this.animationFrame_=0;_this.animationTimer_=0;return _this}Object.defineProperty(MDCDismissibleDrawerFoundation,"strings",{get:function(){return drawer_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCDismissibleDrawerFoundation,"cssClasses",{get:function(){return drawer_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCDismissibleDrawerFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},removeClass:function(){return undefined},hasClass:function(){return false},elementHasClass:function(){return false},notifyClose:function(){return undefined},notifyOpen:function(){return undefined},saveFocus:function(){return undefined},restoreFocus:function(){return undefined},focusActiveNavigationItem:function(){return undefined},trapFocus:function(){return undefined},releaseFocus:function(){return undefined}}},enumerable:true,configurable:true});MDCDismissibleDrawerFoundation.prototype.destroy=function(){if(this.animationFrame_){cancelAnimationFrame(this.animationFrame_)}if(this.animationTimer_){clearTimeout(this.animationTimer_)}};MDCDismissibleDrawerFoundation.prototype.open=function(){var _this=this;if(this.isOpen()||this.isOpening()||this.isClosing()){return}this.adapter.addClass(drawer_constants_cssClasses.OPEN);this.adapter.addClass(drawer_constants_cssClasses.ANIMATE);this.runNextAnimationFrame_((function(){_this.adapter.addClass(drawer_constants_cssClasses.OPENING)}));this.adapter.saveFocus()};MDCDismissibleDrawerFoundation.prototype.close=function(){if(!this.isOpen()||this.isOpening()||this.isClosing()){return}this.adapter.addClass(drawer_constants_cssClasses.CLOSING)};MDCDismissibleDrawerFoundation.prototype.isOpen=function(){return this.adapter.hasClass(drawer_constants_cssClasses.OPEN)};MDCDismissibleDrawerFoundation.prototype.isOpening=function(){return this.adapter.hasClass(drawer_constants_cssClasses.OPENING)||this.adapter.hasClass(drawer_constants_cssClasses.ANIMATE)};MDCDismissibleDrawerFoundation.prototype.isClosing=function(){return this.adapter.hasClass(drawer_constants_cssClasses.CLOSING)};MDCDismissibleDrawerFoundation.prototype.handleKeydown=function(evt){var keyCode=evt.keyCode,key=evt.key;var isEscape=key==="Escape"||keyCode===27;if(isEscape){this.close()}};MDCDismissibleDrawerFoundation.prototype.handleTransitionEnd=function(evt){var OPENING=drawer_constants_cssClasses.OPENING,CLOSING=drawer_constants_cssClasses.CLOSING,OPEN=drawer_constants_cssClasses.OPEN,ANIMATE=drawer_constants_cssClasses.ANIMATE,ROOT=drawer_constants_cssClasses.ROOT;var isRootElement=this.isElement_(evt.target)&&this.adapter.elementHasClass(evt.target,ROOT);if(!isRootElement){return}if(this.isClosing()){this.adapter.removeClass(OPEN);this.closed_();this.adapter.restoreFocus();this.adapter.notifyClose()}else{this.adapter.focusActiveNavigationItem();this.opened_();this.adapter.notifyOpen()}this.adapter.removeClass(ANIMATE);this.adapter.removeClass(OPENING);this.adapter.removeClass(CLOSING)};MDCDismissibleDrawerFoundation.prototype.opened_=function(){};MDCDismissibleDrawerFoundation.prototype.closed_=function(){};MDCDismissibleDrawerFoundation.prototype.runNextAnimationFrame_=function(callback){var _this=this;cancelAnimationFrame(this.animationFrame_);this.animationFrame_=requestAnimationFrame((function(){_this.animationFrame_=0;clearTimeout(_this.animationTimer_);_this.animationTimer_=setTimeout(callback,0)}))};MDCDismissibleDrawerFoundation.prototype.isElement_=function(element){return Boolean(element.classList)};return MDCDismissibleDrawerFoundation}(MDCFoundation);const dismissible_foundation=null&&MDCDismissibleDrawerFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCModalDrawerFoundation=function(_super){__extends(MDCModalDrawerFoundation,_super);function MDCModalDrawerFoundation(){return _super!==null&&_super.apply(this,arguments)||this}MDCModalDrawerFoundation.prototype.handleScrimClick=function(){this.close()};MDCModalDrawerFoundation.prototype.opened_=function(){this.adapter.trapFocus()};MDCModalDrawerFoundation.prototype.closed_=function(){this.adapter.releaseFocus()};return MDCModalDrawerFoundation}(MDCDismissibleDrawerFoundation);const modal_foundation=null&&MDCModalDrawerFoundation;
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
 */
function util_createFocusTrapInstance(surfaceEl,focusTrapFactory){return focusTrapFactory(surfaceEl,{skipInitialFocus:true})}
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
 */
var component_cssClasses=MDCDismissibleDrawerFoundation.cssClasses,drawer_component_strings=MDCDismissibleDrawerFoundation.strings;var MDCDrawer=function(_super){__extends(MDCDrawer,_super);function MDCDrawer(){return _super!==null&&_super.apply(this,arguments)||this}MDCDrawer.attachTo=function(root){return new MDCDrawer(root)};Object.defineProperty(MDCDrawer.prototype,"open",{get:function(){return this.foundation.isOpen()},set:function(isOpen){if(isOpen){this.foundation.open()}else{this.foundation.close()}},enumerable:true,configurable:true});Object.defineProperty(MDCDrawer.prototype,"list",{get:function(){return this.list_},enumerable:true,configurable:true});MDCDrawer.prototype.initialize=function(focusTrapFactory,listFactory){if(focusTrapFactory===void 0){focusTrapFactory=function(el){return new FocusTrap(el)}}if(listFactory===void 0){listFactory=function(el){return new MDCList(el)}}var listEl=this.root.querySelector("."+MDCListFoundation.cssClasses.ROOT);if(listEl){this.list_=listFactory(listEl);this.list_.wrapFocus=true}this.focusTrapFactory_=focusTrapFactory};MDCDrawer.prototype.initialSyncWithDOM=function(){var _this=this;var MODAL=component_cssClasses.MODAL;var SCRIM_SELECTOR=drawer_component_strings.SCRIM_SELECTOR;this.scrim_=this.root.parentNode.querySelector(SCRIM_SELECTOR);if(this.scrim_&&this.root.classList.contains(MODAL)){this.handleScrimClick_=function(){return _this.foundation.handleScrimClick()};this.scrim_.addEventListener("click",this.handleScrimClick_);this.focusTrap_=util_createFocusTrapInstance(this.root,this.focusTrapFactory_)}this.handleKeydown_=function(evt){return _this.foundation.handleKeydown(evt)};this.handleTransitionEnd_=function(evt){return _this.foundation.handleTransitionEnd(evt)};this.listen("keydown",this.handleKeydown_);this.listen("transitionend",this.handleTransitionEnd_)};MDCDrawer.prototype.destroy=function(){this.unlisten("keydown",this.handleKeydown_);this.unlisten("transitionend",this.handleTransitionEnd_);if(this.list_){this.list_.destroy()}var MODAL=component_cssClasses.MODAL;if(this.scrim_&&this.handleScrimClick_&&this.root.classList.contains(MODAL)){this.scrim_.removeEventListener("click",this.handleScrimClick_);this.open=false}};MDCDrawer.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClass:function(className){return _this.root.classList.add(className)},removeClass:function(className){return _this.root.classList.remove(className)},hasClass:function(className){return _this.root.classList.contains(className)},elementHasClass:function(element,className){return element.classList.contains(className)},saveFocus:function(){return _this.previousFocus_=document.activeElement},restoreFocus:function(){var previousFocus=_this.previousFocus_;if(previousFocus&&previousFocus.focus&&_this.root.contains(document.activeElement)){previousFocus.focus()}},focusActiveNavigationItem:function(){var activeNavItemEl=_this.root.querySelector("."+MDCListFoundation.cssClasses.LIST_ITEM_ACTIVATED_CLASS);if(activeNavItemEl){activeNavItemEl.focus()}},notifyClose:function(){return _this.emit(drawer_component_strings.CLOSE_EVENT,{},true)},notifyOpen:function(){return _this.emit(drawer_component_strings.OPEN_EVENT,{},true)},trapFocus:function(){return _this.focusTrap_.trapFocus()},releaseFocus:function(){return _this.focusTrap_.releaseFocus()}};var DISMISSIBLE=component_cssClasses.DISMISSIBLE,MODAL=component_cssClasses.MODAL;if(this.root.classList.contains(DISMISSIBLE)){return new MDCDismissibleDrawerFoundation(adapter)}else if(this.root.classList.contains(MODAL)){return new MDCModalDrawerFoundation(adapter)}else{throw new Error("MDCDrawer: Failed to instantiate component. Supported variants are "+DISMISSIBLE+" and "+MODAL+".")}};return MDCDrawer}(MDCComponent);function MBDrawer_init(elem,isOpen){if(!elem){return}elem._drawer=MDCDrawer.attachTo(elem);toggle(elem,isOpen)}function toggle(elem,isOpen){if(!elem){return}elem._drawer.open=isOpen}function MBFloatingActionButton_init(elem,exited){elem._fab=MDCRipple.attachTo(elem);elem._exited=false;setExited(elem,exited)}function setExited(elem,exited){if(elem){if(exited!=elem._exited){elem.classList.add("mdc-fab--exited")}else{elem.classList.remove("mdc-fab--exited")}}}function syncScrollByID(gridHeaderID,gridBodyID){var headerDiv=document.getElementById(gridHeaderID);var bodyDiv=document.getElementById(gridBodyID);if(headerDiv!=null&&bodyDiv!=null){headerDiv.scrollLeft=bodyDiv.scrollLeft}}function syncScrollByRef(gridHeaderRef,gridBodyRef){gridHeaderRef.scrollLeft=gridBodyRef.scrollLeft}function getScrollBarWidth(className){var firstDiv=document.createElement("div");firstDiv.style.position="absolute";firstDiv.style.visibility="hidden";firstDiv.style.whiteSpace="nowrap";firstDiv.style.left="-9999px";firstDiv.className=className;document.body.appendChild(firstDiv);var secondDiv=document.createElement("div");firstDiv.appendChild(secondDiv);var width=firstDiv.offsetWidth-secondDiv.offsetWidth;document.body.removeChild(firstDiv);return width}function getTextWidths(className,currentWidths,textToMeasure){var ele=document.createElement("div");ele.style.position="absolute";ele.style.visibility="hidden";ele.style.whiteSpace="nowrap";ele.style.left="-9999px";ele.className=className;document.body.appendChild(ele);for(var i=0;i<textToMeasure.length;i++){ele.innerText=textToMeasure[i];var width=window.getComputedStyle(ele).width;var unadornedWidth=width.slice(0,width.indexOf("px"));var numericWidth=parseFloat(unadornedWidth);var indexMod=i%currentWidths.length;if(numericWidth>currentWidths[indexMod]){currentWidths[indexMod]=numericWidth}}document.body.removeChild(ele);return currentWidths}function MBIconButton_init(elem){if(!elem){return}elem._ripple=MDCRipple.attachTo(elem);elem._ripple.unbounded=true}
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var icon_button_constants_cssClasses={ICON_BUTTON_ON:"mdc-icon-button--on",ROOT:"mdc-icon-button"};var icon_button_constants_strings={ARIA_LABEL:"aria-label",ARIA_PRESSED:"aria-pressed",DATA_ARIA_LABEL_OFF:"data-aria-label-off",DATA_ARIA_LABEL_ON:"data-aria-label-on",CHANGE_EVENT:"MDCIconButtonToggle:change"};
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCIconButtonToggleFoundation=function(_super){__extends(MDCIconButtonToggleFoundation,_super);function MDCIconButtonToggleFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCIconButtonToggleFoundation.defaultAdapter),adapter))||this;_this.hasToggledAriaLabel=false;return _this}Object.defineProperty(MDCIconButtonToggleFoundation,"cssClasses",{get:function(){return icon_button_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCIconButtonToggleFoundation,"strings",{get:function(){return icon_button_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCIconButtonToggleFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},hasClass:function(){return false},notifyChange:function(){return undefined},removeClass:function(){return undefined},getAttr:function(){return null},setAttr:function(){return undefined}}},enumerable:true,configurable:true});MDCIconButtonToggleFoundation.prototype.init=function(){var ariaLabelOn=this.adapter.getAttr(icon_button_constants_strings.DATA_ARIA_LABEL_ON);var ariaLabelOff=this.adapter.getAttr(icon_button_constants_strings.DATA_ARIA_LABEL_OFF);if(ariaLabelOn&&ariaLabelOff){if(this.adapter.getAttr(icon_button_constants_strings.ARIA_PRESSED)!==null){throw new Error("MDCIconButtonToggleFoundation: Button should not set "+"`aria-pressed` if it has a toggled aria label.")}this.hasToggledAriaLabel=true}else{this.adapter.setAttr(icon_button_constants_strings.ARIA_PRESSED,String(this.isOn()))}};MDCIconButtonToggleFoundation.prototype.handleClick=function(){this.toggle();this.adapter.notifyChange({isOn:this.isOn()})};MDCIconButtonToggleFoundation.prototype.isOn=function(){return this.adapter.hasClass(icon_button_constants_cssClasses.ICON_BUTTON_ON)};MDCIconButtonToggleFoundation.prototype.toggle=function(isOn){if(isOn===void 0){isOn=!this.isOn()}if(isOn){this.adapter.addClass(icon_button_constants_cssClasses.ICON_BUTTON_ON)}else{this.adapter.removeClass(icon_button_constants_cssClasses.ICON_BUTTON_ON)}if(this.hasToggledAriaLabel){var ariaLabel=isOn?this.adapter.getAttr(icon_button_constants_strings.DATA_ARIA_LABEL_ON):this.adapter.getAttr(icon_button_constants_strings.DATA_ARIA_LABEL_OFF);this.adapter.setAttr(icon_button_constants_strings.ARIA_LABEL,ariaLabel||"")}else{this.adapter.setAttr(icon_button_constants_strings.ARIA_PRESSED,""+isOn)}};return MDCIconButtonToggleFoundation}(MDCFoundation);const icon_button_foundation=null&&MDCIconButtonToggleFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var icon_button_component_strings=MDCIconButtonToggleFoundation.strings;var MDCIconButtonToggle=function(_super){__extends(MDCIconButtonToggle,_super);function MDCIconButtonToggle(){var _this=_super!==null&&_super.apply(this,arguments)||this;_this.rippleComponent=_this.createRipple();return _this}MDCIconButtonToggle.attachTo=function(root){return new MDCIconButtonToggle(root)};MDCIconButtonToggle.prototype.initialSyncWithDOM=function(){var _this=this;this.handleClick=function(){_this.foundation.handleClick()};this.listen("click",this.handleClick)};MDCIconButtonToggle.prototype.destroy=function(){this.unlisten("click",this.handleClick);this.ripple.destroy();_super.prototype.destroy.call(this)};MDCIconButtonToggle.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClass:function(className){return _this.root.classList.add(className)},hasClass:function(className){return _this.root.classList.contains(className)},notifyChange:function(evtData){_this.emit(icon_button_component_strings.CHANGE_EVENT,evtData)},removeClass:function(className){return _this.root.classList.remove(className)},getAttr:function(attrName){return _this.root.getAttribute(attrName)},setAttr:function(attrName,attrValue){return _this.root.setAttribute(attrName,attrValue)}};return new MDCIconButtonToggleFoundation(adapter)};Object.defineProperty(MDCIconButtonToggle.prototype,"ripple",{get:function(){return this.rippleComponent},enumerable:true,configurable:true});Object.defineProperty(MDCIconButtonToggle.prototype,"on",{get:function(){return this.foundation.isOn()},set:function(isOn){this.foundation.toggle(isOn)},enumerable:true,configurable:true});MDCIconButtonToggle.prototype.createRipple=function(){var ripple=new MDCRipple(this.root);ripple.unbounded=true;return ripple};return MDCIconButtonToggle}(MDCComponent);function MBIconButtonToggle_init(elem){if(!elem){return}elem._iconButtonToggle=MDCIconButtonToggle.attachTo(elem)}function setOn(elem,isOn){if(!elem){return}elem._iconButtonToggle.on=isOn}function click(elem){if(!elem){return}elem._iconButtonToggle.root.click()}function MBLinearProgress_init(elem,progress,buffer){if(!elem){return}elem._linearProgress=MDCLinearProgress.attachTo(elem);MBLinearProgress_setProgress(elem,progress,buffer)}function MBLinearProgress_setProgress(elem,progress,buffer){if(!elem){return}elem._linearProgress.progress=progress;elem._linearProgress.buffer=buffer}function restartAnimation(elem){if(!elem){return}elem._linearProgress.foundation.restartAnimation()}function MBList_init(elem,keyboardInteractions,ripple){if(!elem){return}if(keyboardInteractions==true){elem._list=MDCList.attachTo(elem);if(ripple==true){elem._list.listElements.map((function(elem){return MDCRipple.attachTo(elem)}))}}}function MBMenu_init(elem,dotNetObject){if(!elem){return}elem._menu=MDCMenu.attachTo(elem);var closedCallback=function closedCallback(){dotNetObject.invokeMethodAsync("NotifyClosed")};elem._menu.listen("MDCMenuSurface:closed",closedCallback)}function MBMenu_show(elem){if(!elem){return}if(elem._menu){elem._menu.open=true}}function MBMenu_hide(elem){if(!elem){return}if(elem._menu){elem._menu.open=false}}function MBMenuSurface_init(elem,dotNetObject){if(!elem){return}elem._menu=MDCMenuSurface.attachTo(elem);var closedCallback=function closedCallback(){dotNetObject.invokeMethodAsync("NotifyClosed")};elem._menu.listen("MDCMenuSurface:closed",closedCallback)}function MBMenuSurface_show(elem){if(!elem){return}if(elem._menu){elem._menu.open()}}function MBMenuSurface_hide(elem){if(!elem){return}if(elem._menu){elem._menu.close()}}
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
 */
var radio_constants_strings={NATIVE_CONTROL_SELECTOR:".mdc-radio__native-control"};var radio_constants_cssClasses={DISABLED:"mdc-radio--disabled",ROOT:"mdc-radio"};
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
 */
var MDCRadioFoundation=function(_super){__extends(MDCRadioFoundation,_super);function MDCRadioFoundation(adapter){return _super.call(this,__assign(__assign({},MDCRadioFoundation.defaultAdapter),adapter))||this}Object.defineProperty(MDCRadioFoundation,"cssClasses",{get:function(){return radio_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCRadioFoundation,"strings",{get:function(){return radio_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCRadioFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},removeClass:function(){return undefined},setNativeControlDisabled:function(){return undefined}}},enumerable:true,configurable:true});MDCRadioFoundation.prototype.setDisabled=function(disabled){var DISABLED=MDCRadioFoundation.cssClasses.DISABLED;this.adapter.setNativeControlDisabled(disabled);if(disabled){this.adapter.addClass(DISABLED)}else{this.adapter.removeClass(DISABLED)}};return MDCRadioFoundation}(MDCFoundation);const radio_foundation=null&&MDCRadioFoundation;
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
 */
var MDCRadio=function(_super){__extends(MDCRadio,_super);function MDCRadio(){var _this=_super!==null&&_super.apply(this,arguments)||this;_this.ripple_=_this.createRipple_();return _this}MDCRadio.attachTo=function(root){return new MDCRadio(root)};Object.defineProperty(MDCRadio.prototype,"checked",{get:function(){return this.nativeControl_.checked},set:function(checked){this.nativeControl_.checked=checked},enumerable:true,configurable:true});Object.defineProperty(MDCRadio.prototype,"disabled",{get:function(){return this.nativeControl_.disabled},set:function(disabled){this.foundation.setDisabled(disabled)},enumerable:true,configurable:true});Object.defineProperty(MDCRadio.prototype,"value",{get:function(){return this.nativeControl_.value},set:function(value){this.nativeControl_.value=value},enumerable:true,configurable:true});Object.defineProperty(MDCRadio.prototype,"ripple",{get:function(){return this.ripple_},enumerable:true,configurable:true});MDCRadio.prototype.destroy=function(){this.ripple_.destroy();_super.prototype.destroy.call(this)};MDCRadio.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClass:function(className){return _this.root.classList.add(className)},removeClass:function(className){return _this.root.classList.remove(className)},setNativeControlDisabled:function(disabled){return _this.nativeControl_.disabled=disabled}};return new MDCRadioFoundation(adapter)};MDCRadio.prototype.createRipple_=function(){var _this=this;var adapter=__assign(__assign({},MDCRipple.createAdapter(this)),{registerInteractionHandler:function(evtType,handler){return _this.nativeControl_.addEventListener(evtType,handler,applyPassive())},deregisterInteractionHandler:function(evtType,handler){return _this.nativeControl_.removeEventListener(evtType,handler,applyPassive())},isSurfaceActive:function(){return false},isUnbounded:function(){return true}});return new MDCRipple(this.root,new MDCRippleFoundation(adapter))};Object.defineProperty(MDCRadio.prototype,"nativeControl_",{get:function(){var NATIVE_CONTROL_SELECTOR=MDCRadioFoundation.strings.NATIVE_CONTROL_SELECTOR;var el=this.root.querySelector(NATIVE_CONTROL_SELECTOR);if(!el){throw new Error("Radio component requires a "+NATIVE_CONTROL_SELECTOR+" element")}return el},enumerable:true,configurable:true});return MDCRadio}(MDCComponent);function MBRadioButton_init(elem,formFieldElem,isChecked){if(!elem){return}elem._radio=MDCRadio.attachTo(elem);elem._radio.checked=isChecked;elem._formField=MDCFormField.attachTo(formFieldElem);elem._formField.input=elem._radio}function MBRadioButton_setDisabled(elem,value){if(!elem){return}elem._radio.disabled=value}function MBRadioButton_setChecked(elem,isChecked){if(!elem){return}elem._radio.checked=isChecked}
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
 */
var constants_selectors={SEGMENT:".mdc-segmented-button__segment"};var constants_events={SELECTED:"selected",CHANGE:"change"};var segmented_button_constants_cssClasses={SINGLE_SELECT:"mdc-segmented-button--single-select"};
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
 */
var MDCSegmentedButtonFoundation=function(_super){__extends(MDCSegmentedButtonFoundation,_super);function MDCSegmentedButtonFoundation(adapter){return _super.call(this,__assign(__assign({},MDCSegmentedButtonFoundation.defaultAdapter),adapter))||this}Object.defineProperty(MDCSegmentedButtonFoundation,"defaultAdapter",{get:function(){return{hasClass:function(){return false},getSegments:function(){return[]},selectSegment:function(){return undefined},unselectSegment:function(){return undefined},notifySelectedChange:function(){return undefined}}},enumerable:true,configurable:true});MDCSegmentedButtonFoundation.prototype.selectSegment=function(indexOrSegmentId){this.adapter.selectSegment(indexOrSegmentId)};MDCSegmentedButtonFoundation.prototype.unselectSegment=function(indexOrSegmentId){this.adapter.unselectSegment(indexOrSegmentId)};MDCSegmentedButtonFoundation.prototype.getSelectedSegments=function(){return this.adapter.getSegments().filter((function(segmentDetail){return segmentDetail.selected}))};MDCSegmentedButtonFoundation.prototype.isSegmentSelected=function(indexOrSegmentId){return this.adapter.getSegments().some((function(segmentDetail){return(segmentDetail.index===indexOrSegmentId||segmentDetail.segmentId===indexOrSegmentId)&&segmentDetail.selected}))};MDCSegmentedButtonFoundation.prototype.isSingleSelect=function(){return this.adapter.hasClass(segmented_button_constants_cssClasses.SINGLE_SELECT)};MDCSegmentedButtonFoundation.prototype.handleSelected=function(detail){if(this.isSingleSelect()){this.unselectPrevSelected(detail.index)}this.adapter.notifySelectedChange(detail)};MDCSegmentedButtonFoundation.prototype.unselectPrevSelected=function(index){var e_1,_a;try{for(var _b=__values(this.getSelectedSegments()),_c=_b.next();!_c.done;_c=_b.next()){var selectedSegment=_c.value;if(selectedSegment.index!==index){this.unselectSegment(selectedSegment.index)}}}catch(e_1_1){e_1={error:e_1_1}}finally{try{if(_c&&!_c.done&&(_a=_b.return))_a.call(_b)}finally{if(e_1)throw e_1.error}}};return MDCSegmentedButtonFoundation}(MDCFoundation);
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
 */
var booleans={TRUE:"true",FALSE:"false"};var constants_attributes={ARIA_CHECKED:"aria-checked",ARIA_PRESSED:"aria-pressed",DATA_SEGMENT_ID:"data-segment-id"};var segment_constants_events={CLICK:"click",SELECTED:"selected"};var segment_constants_cssClasses={SELECTED:"mdc-segmented-button__segment--selected"};
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
 */
var foundation_emptyClientRect={bottom:0,height:0,left:0,right:0,top:0,width:0};var MDCSegmentedButtonSegmentFoundation=function(_super){__extends(MDCSegmentedButtonSegmentFoundation,_super);function MDCSegmentedButtonSegmentFoundation(adapter){return _super.call(this,__assign(__assign({},MDCSegmentedButtonSegmentFoundation.defaultAdapter),adapter))||this}Object.defineProperty(MDCSegmentedButtonSegmentFoundation,"defaultAdapter",{get:function(){return{isSingleSelect:function(){return false},getAttr:function(){return""},setAttr:function(){return undefined},addClass:function(){return undefined},removeClass:function(){return undefined},hasClass:function(){return false},notifySelectedChange:function(){return undefined},getRootBoundingClientRect:function(){return foundation_emptyClientRect}}},enumerable:true,configurable:true});MDCSegmentedButtonSegmentFoundation.prototype.isSelected=function(){return this.adapter.hasClass(segment_constants_cssClasses.SELECTED)};MDCSegmentedButtonSegmentFoundation.prototype.setSelected=function(){this.adapter.addClass(segment_constants_cssClasses.SELECTED);this.setAriaAttr(booleans.TRUE)};MDCSegmentedButtonSegmentFoundation.prototype.setUnselected=function(){this.adapter.removeClass(segment_constants_cssClasses.SELECTED);this.setAriaAttr(booleans.FALSE)};MDCSegmentedButtonSegmentFoundation.prototype.getSegmentId=function(){var _a;return(_a=this.adapter.getAttr(constants_attributes.DATA_SEGMENT_ID))!==null&&_a!==void 0?_a:undefined};MDCSegmentedButtonSegmentFoundation.prototype.handleClick=function(){if(this.adapter.isSingleSelect()){this.setSelected()}else{this.toggleSelection()}this.adapter.notifySelectedChange(this.isSelected())};MDCSegmentedButtonSegmentFoundation.prototype.getDimensions=function(){return this.adapter.getRootBoundingClientRect()};MDCSegmentedButtonSegmentFoundation.prototype.toggleSelection=function(){if(this.isSelected()){this.setUnselected()}else{this.setSelected()}};MDCSegmentedButtonSegmentFoundation.prototype.setAriaAttr=function(value){if(this.adapter.isSingleSelect()){this.adapter.setAttr(constants_attributes.ARIA_CHECKED,value)}else{this.adapter.setAttr(constants_attributes.ARIA_PRESSED,value)}};return MDCSegmentedButtonSegmentFoundation}(MDCFoundation);
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
 */
var MDCSegmentedButtonSegment=function(_super){__extends(MDCSegmentedButtonSegment,_super);function MDCSegmentedButtonSegment(){return _super!==null&&_super.apply(this,arguments)||this}Object.defineProperty(MDCSegmentedButtonSegment.prototype,"ripple",{get:function(){return this.rippleComponent},enumerable:true,configurable:true});MDCSegmentedButtonSegment.attachTo=function(root){return new MDCSegmentedButtonSegment(root)};MDCSegmentedButtonSegment.prototype.initialize=function(rippleFactory){var _this=this;if(rippleFactory===void 0){rippleFactory=function(el,foundation){return new MDCRipple(el,foundation)}}var rippleAdapter=__assign(__assign({},MDCRipple.createAdapter(this)),{computeBoundingRect:function(){return _this.foundation.getDimensions()}});this.rippleComponent=rippleFactory(this.root,new MDCRippleFoundation(rippleAdapter))};MDCSegmentedButtonSegment.prototype.initialSyncWithDOM=function(){var _this=this;this.handleClick=function(){_this.foundation.handleClick()};this.listen(segment_constants_events.CLICK,this.handleClick)};MDCSegmentedButtonSegment.prototype.destroy=function(){this.ripple.destroy();this.unlisten(segment_constants_events.CLICK,this.handleClick);_super.prototype.destroy.call(this)};MDCSegmentedButtonSegment.prototype.getDefaultFoundation=function(){var _this=this;var adapter={isSingleSelect:function(){return _this.isSingleSelect},getAttr:function(attrName){return _this.root.getAttribute(attrName)},setAttr:function(attrName,value){_this.root.setAttribute(attrName,value)},addClass:function(className){_this.root.classList.add(className)},removeClass:function(className){_this.root.classList.remove(className)},hasClass:function(className){return _this.root.classList.contains(className)},notifySelectedChange:function(selected){_this.emit(segment_constants_events.SELECTED,{index:_this.index,selected:selected,segmentId:_this.getSegmentId()},true)},getRootBoundingClientRect:function(){return _this.root.getBoundingClientRect()}};return new MDCSegmentedButtonSegmentFoundation(adapter)};MDCSegmentedButtonSegment.prototype.setIndex=function(index){this.index=index};MDCSegmentedButtonSegment.prototype.setIsSingleSelect=function(isSingleSelect){this.isSingleSelect=isSingleSelect};MDCSegmentedButtonSegment.prototype.isSelected=function(){return this.foundation.isSelected()};MDCSegmentedButtonSegment.prototype.setSelected=function(){this.foundation.setSelected()};MDCSegmentedButtonSegment.prototype.setUnselected=function(){this.foundation.setUnselected()};MDCSegmentedButtonSegment.prototype.getSegmentId=function(){return this.foundation.getSegmentId()};return MDCSegmentedButtonSegment}(MDCComponent);
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
 */
var MDCSegmentedButton=function(_super){__extends(MDCSegmentedButton,_super);function MDCSegmentedButton(){return _super!==null&&_super.apply(this,arguments)||this}MDCSegmentedButton.attachTo=function(root){return new MDCSegmentedButton(root)};Object.defineProperty(MDCSegmentedButton.prototype,"segments",{get:function(){return this.segments_.slice()},enumerable:true,configurable:true});MDCSegmentedButton.prototype.initialize=function(segmentFactory){if(segmentFactory===void 0){segmentFactory=function(el){return new MDCSegmentedButtonSegment(el)}}this.segmentFactory=segmentFactory;this.segments_=this.instantiateSegments(this.segmentFactory)};MDCSegmentedButton.prototype.instantiateSegments=function(segmentFactory){var segmentElements=[].slice.call(this.root.querySelectorAll(constants_selectors.SEGMENT));return segmentElements.map((function(el){return segmentFactory(el)}))};MDCSegmentedButton.prototype.initialSyncWithDOM=function(){var _this=this;this.handleSelected=function(event){_this.foundation.handleSelected(event.detail)};this.listen(constants_events.SELECTED,this.handleSelected);var isSingleSelect=this.foundation.isSingleSelect();this.segments_.forEach((function(segment,index){segment.setIndex(index);segment.setIsSingleSelect(isSingleSelect)}));var selectedSegments=this.segments_.filter((function(segment){return segment.isSelected()}));if(isSingleSelect&&selectedSegments.length==0&&this.segments_.length>0){throw new Error("No segment selected in singleSelect mdc-segmented-button")}else if(isSingleSelect&&selectedSegments.length>1){throw new Error("Multiple segments selected in singleSelect mdc-segmented-button")}};MDCSegmentedButton.prototype.destroy=function(){this.segments_.forEach((function(segment){segment.destroy()}));this.unlisten(constants_events.SELECTED,this.handleSelected);_super.prototype.destroy.call(this)};MDCSegmentedButton.prototype.getDefaultFoundation=function(){var _this=this;var adapter={hasClass:function(className){return _this.root.classList.contains(className)},getSegments:function(){return _this.mappedSegments()},selectSegment:function(indexOrSegmentId){var segmentDetail=_this.mappedSegments().find((function(_segmentDetail){return _segmentDetail.index===indexOrSegmentId||_segmentDetail.segmentId===indexOrSegmentId}));if(segmentDetail){_this.segments_[segmentDetail.index].setSelected()}},unselectSegment:function(indexOrSegmentId){var segmentDetail=_this.mappedSegments().find((function(_segmentDetail){return _segmentDetail.index===indexOrSegmentId||_segmentDetail.segmentId===indexOrSegmentId}));if(segmentDetail){_this.segments_[segmentDetail.index].setUnselected()}},notifySelectedChange:function(detail){_this.emit(constants_events.CHANGE,detail,true)}};return new MDCSegmentedButtonFoundation(adapter)};MDCSegmentedButton.prototype.getSelectedSegments=function(){return this.foundation.getSelectedSegments()};MDCSegmentedButton.prototype.selectSegment=function(indexOrSegmentId){this.foundation.selectSegment(indexOrSegmentId)};MDCSegmentedButton.prototype.unselectSegment=function(indexOrSegmentId){this.foundation.unselectSegment(indexOrSegmentId)};MDCSegmentedButton.prototype.isSegmentSelected=function(indexOrSegmentId){return this.foundation.isSegmentSelected(indexOrSegmentId)};MDCSegmentedButton.prototype.mappedSegments=function(){return this.segments_.map((function(segment,index){return{index:index,selected:segment.isSelected(),segmentId:segment.getSegmentId()}}))};return MDCSegmentedButton}(MDCComponent);function MBSegmentedButtonMulti_init(elem,isSingleSelect,dotNetObject){if(!elem){return}elem._segmentedButton=MDCSegmentedButton.attachTo(elem);elem._isSingleSelect=isSingleSelect;elem._segmentedButton.foundation.adapter.notifySelectedChange=function(detail){if(elem._isSingleSelect){dotNetObject.invokeMethodAsync("NotifySingleSelected",detail.index)}else{dotNetObject.invokeMethodAsync("NotifyMultiSelected",elem._segmentedButton.segments.map((function(x){return x.isSelected()})))}}}function MBSegmentedButtonMulti_setDisabled(elem,value){if(!elem){return}elem._segmentedButton.disabled=value}function MBSegmentedButtonMulti_setSelected(elem,selectedFlags){if(!elem){return}for(var i=0;i<selectedFlags.length;i++){if(selectedFlags[i]==true){elem._segmentedButton.segments[i].setSelected()}else{elem._segmentedButton.segments[i].setUnselected()}}}function MBSelect_init(elem,dotNetObject){if(!elem){return}elem._select=MDCSelect.attachTo(elem);elem._select.listen("MDCSelect:change",(function(){dotNetObject.invokeMethodAsync("NotifySelected",elem._select.selectedIndex)}))}function MBSelect_setDisabled(elem,value){if(!elem){return}elem._select.disabled=value}function setIndex(elem,index){if(!elem){return}elem._select.selectedIndex=index}
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
 */
var slider_constants_cssClasses={DISABLED:"mdc-slider--disabled",DISCRETE:"mdc-slider--discrete",INPUT:"mdc-slider__input",RANGE:"mdc-slider--range",THUMB:"mdc-slider__thumb",THUMB_KNOB:"mdc-slider__thumb-knob",THUMB_TOP:"mdc-slider__thumb--top",THUMB_WITH_INDICATOR:"mdc-slider__thumb--with-indicator",TICK_MARKS:"mdc-slider--tick-marks",TICK_MARKS_CONTAINER:"mdc-slider__tick-marks",TICK_MARK_ACTIVE:"mdc-slider__tick-mark--active",TICK_MARK_INACTIVE:"mdc-slider__tick-mark--inactive",TRACK:"mdc-slider__track",TRACK_ACTIVE:"mdc-slider__track--active_fill",VALUE_INDICATOR_TEXT:"mdc-slider__value-indicator-text"};var slider_constants_numbers={STEP_SIZE:1,THUMB_UPDATE_MIN_PX:5};var slider_constants_attributes={ARIA_DISABLED:"aria-disabled",ARIA_VALUEMAX:"aria-valuemax",ARIA_VALUEMIN:"aria-valuemin",ARIA_VALUENOW:"aria-valuenow",ARIA_VALUETEXT:"aria-valuetext",INPUT_DISABLED:"disabled",INPUT_MIN:"min",INPUT_MAX:"max",INPUT_VALUE:"value",INPUT_STEP:"step"};var slider_constants_events={CHANGE:"MDCSlider:change",INPUT:"MDCSlider:input"};
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
 */
var TickMark;(function(TickMark){TickMark[TickMark["ACTIVE"]=0]="ACTIVE";TickMark[TickMark["INACTIVE"]=1]="INACTIVE"})(TickMark||(TickMark={}));var Thumb;(function(Thumb){Thumb[Thumb["START"]=1]="START";Thumb[Thumb["END"]=2]="END"})(Thumb||(Thumb={}));
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
 */
var HAS_WINDOW=typeof window!=="undefined";var MDCSliderFoundation=function(_super){__extends(MDCSliderFoundation,_super);function MDCSliderFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCSliderFoundation.defaultAdapter),adapter))||this;_this.initialStylesRemoved=false;_this.isDisabled=false;_this.isDiscrete=false;_this.step=slider_constants_numbers.STEP_SIZE;_this.hasTickMarks=false;_this.isRange=false;_this.thumb=null;_this.downEventClientX=null;_this.startThumbKnobWidth=0;_this.endThumbKnobWidth=0;return _this}Object.defineProperty(MDCSliderFoundation,"defaultAdapter",{get:function(){return{hasClass:function(){return false},addClass:function(){return undefined},removeClass:function(){return undefined},addThumbClass:function(){return undefined},removeThumbClass:function(){return undefined},getAttribute:function(){return null},getInputValue:function(){return""},setInputValue:function(){return undefined},getInputAttribute:function(){return null},setInputAttribute:function(){return null},removeInputAttribute:function(){return null},focusInput:function(){return undefined},isInputFocused:function(){return false},getThumbKnobWidth:function(){return 0},getThumbBoundingClientRect:function(){return{top:0,right:0,bottom:0,left:0,width:0,height:0}},getBoundingClientRect:function(){return{top:0,right:0,bottom:0,left:0,width:0,height:0}},isRTL:function(){return false},setThumbStyleProperty:function(){return undefined},removeThumbStyleProperty:function(){return undefined},setTrackActiveStyleProperty:function(){return undefined},removeTrackActiveStyleProperty:function(){return undefined},setValueIndicatorText:function(){return undefined},getValueToAriaValueTextFn:function(){return null},updateTickMarks:function(){return undefined},setPointerCapture:function(){return undefined},emitChangeEvent:function(){return undefined},emitInputEvent:function(){return undefined},emitDragStartEvent:function(){return undefined},emitDragEndEvent:function(){return undefined},registerEventHandler:function(){return undefined},deregisterEventHandler:function(){return undefined},registerThumbEventHandler:function(){return undefined},deregisterThumbEventHandler:function(){return undefined},registerInputEventHandler:function(){return undefined},deregisterInputEventHandler:function(){return undefined},registerBodyEventHandler:function(){return undefined},deregisterBodyEventHandler:function(){return undefined},registerWindowEventHandler:function(){return undefined},deregisterWindowEventHandler:function(){return undefined}}},enumerable:true,configurable:true});MDCSliderFoundation.prototype.init=function(){var _this=this;this.isDisabled=this.adapter.hasClass(slider_constants_cssClasses.DISABLED);this.isDiscrete=this.adapter.hasClass(slider_constants_cssClasses.DISCRETE);this.hasTickMarks=this.adapter.hasClass(slider_constants_cssClasses.TICK_MARKS);this.isRange=this.adapter.hasClass(slider_constants_cssClasses.RANGE);var min=this.convertAttributeValueToNumber(this.adapter.getInputAttribute(slider_constants_attributes.INPUT_MIN,this.isRange?Thumb.START:Thumb.END),slider_constants_attributes.INPUT_MIN);var max=this.convertAttributeValueToNumber(this.adapter.getInputAttribute(slider_constants_attributes.INPUT_MAX,Thumb.END),slider_constants_attributes.INPUT_MAX);var value=this.convertAttributeValueToNumber(this.adapter.getInputAttribute(slider_constants_attributes.INPUT_VALUE,Thumb.END),slider_constants_attributes.INPUT_VALUE);var valueStart=this.isRange?this.convertAttributeValueToNumber(this.adapter.getInputAttribute(slider_constants_attributes.INPUT_VALUE,Thumb.START),slider_constants_attributes.INPUT_VALUE):min;this.validateProperties({min:min,max:max,value:value,valueStart:valueStart});this.min=min;this.max=max;this.value=value;this.valueStart=valueStart;this.valueBeforeDownEvent=value;this.valueStartBeforeDownEvent=valueStart;var stepAttr=this.adapter.getInputAttribute(slider_constants_attributes.INPUT_STEP,Thumb.END);if(stepAttr){this.step=this.convertAttributeValueToNumber(stepAttr,slider_constants_attributes.INPUT_STEP)}if(this.step<=0){throw new Error("MDCSliderFoundation: step must be a positive number. "+("Current step: "+this.step))}this.mousedownOrTouchstartListener=this.handleMousedownOrTouchstart.bind(this);this.moveListener=this.handleMove.bind(this);this.pointerdownListener=this.handlePointerdown.bind(this);this.pointerupListener=this.handlePointerup.bind(this);this.thumbMouseenterListener=this.handleThumbMouseenter.bind(this);this.thumbMouseleaveListener=this.handleThumbMouseleave.bind(this);this.inputStartChangeListener=function(){_this.handleInputChange(Thumb.START)};this.inputEndChangeListener=function(){_this.handleInputChange(Thumb.END)};this.inputStartFocusListener=function(){_this.handleInputFocus(Thumb.START)};this.inputEndFocusListener=function(){_this.handleInputFocus(Thumb.END)};this.inputStartBlurListener=function(){_this.handleInputBlur(Thumb.START)};this.inputEndBlurListener=function(){_this.handleInputBlur(Thumb.END)};this.resizeListener=this.handleResize.bind(this);this.registerEventHandlers()};MDCSliderFoundation.prototype.destroy=function(){this.deregisterEventHandlers()};MDCSliderFoundation.prototype.getMin=function(){return this.min};MDCSliderFoundation.prototype.getMax=function(){return this.max};MDCSliderFoundation.prototype.getValue=function(){return this.value};MDCSliderFoundation.prototype.setValue=function(value){if(this.isRange&&value<this.valueStart){throw new Error("end thumb value ("+value+") must be >= start thumb "+("value ("+this.valueStart+")"))}this.updateValue(value,Thumb.END)};MDCSliderFoundation.prototype.getValueStart=function(){if(!this.isRange){throw new Error("`valueStart` is only applicable for range sliders.")}return this.valueStart};MDCSliderFoundation.prototype.setValueStart=function(valueStart){if(!this.isRange){throw new Error("`valueStart` is only applicable for range sliders.")}if(this.isRange&&valueStart>this.value){throw new Error("start thumb value ("+valueStart+") must be <= end thumb "+("value ("+this.value+")"))}this.updateValue(valueStart,Thumb.START)};MDCSliderFoundation.prototype.getStep=function(){return this.step};MDCSliderFoundation.prototype.getDisabled=function(){return this.isDisabled};MDCSliderFoundation.prototype.setDisabled=function(disabled){this.isDisabled=disabled;if(disabled){this.adapter.addClass(slider_constants_cssClasses.DISABLED);if(this.isRange){this.adapter.setInputAttribute(slider_constants_attributes.INPUT_DISABLED,"",Thumb.START)}this.adapter.setInputAttribute(slider_constants_attributes.INPUT_DISABLED,"",Thumb.END)}else{this.adapter.removeClass(slider_constants_cssClasses.DISABLED);if(this.isRange){this.adapter.removeInputAttribute(slider_constants_attributes.INPUT_DISABLED,Thumb.START)}this.adapter.removeInputAttribute(slider_constants_attributes.INPUT_DISABLED,Thumb.END)}};MDCSliderFoundation.prototype.getIsRange=function(){return this.isRange};MDCSliderFoundation.prototype.layout=function(_a){var skipUpdateUI=(_a===void 0?{}:_a).skipUpdateUI;this.rect=this.adapter.getBoundingClientRect();if(this.isRange){this.startThumbKnobWidth=this.adapter.getThumbKnobWidth(Thumb.START);this.endThumbKnobWidth=this.adapter.getThumbKnobWidth(Thumb.END)}if(!skipUpdateUI){this.updateUI()}};MDCSliderFoundation.prototype.handleResize=function(){this.layout()};MDCSliderFoundation.prototype.handleDown=function(event){if(this.isDisabled)return;this.valueStartBeforeDownEvent=this.valueStart;this.valueBeforeDownEvent=this.value;var clientX=event.clientX!=null?event.clientX:event.targetTouches[0].clientX;this.downEventClientX=clientX;var value=this.mapClientXOnSliderScale(clientX);this.thumb=this.getThumbFromDownEvent(clientX,value);if(this.thumb===null)return;this.handleDragStart(event,value,this.thumb);var newValueInCurrentRange=this.isRange&&value>=this.valueStart&&value<=this.value;if(newValueInCurrentRange)return;this.updateValue(value,this.thumb,{emitInputEvent:true})};MDCSliderFoundation.prototype.handleMove=function(event){if(this.isDisabled)return;event.preventDefault();var clientX=event.clientX!=null?event.clientX:event.targetTouches[0].clientX;var dragAlreadyStarted=this.thumb!=null;this.thumb=this.getThumbFromMoveEvent(clientX);if(this.thumb===null)return;var value=this.mapClientXOnSliderScale(clientX);if(!dragAlreadyStarted){this.handleDragStart(event,value,this.thumb);this.adapter.emitDragStartEvent(value,this.thumb)}this.updateValue(value,this.thumb,{emitInputEvent:true})};MDCSliderFoundation.prototype.handleUp=function(){if(this.isDisabled||this.thumb===null)return;var oldValue=this.thumb===Thumb.START?this.valueStartBeforeDownEvent:this.valueBeforeDownEvent;var newValue=this.thumb===Thumb.START?this.valueStart:this.value;if(oldValue!==newValue){this.adapter.emitChangeEvent(newValue,this.thumb)}this.adapter.emitDragEndEvent(newValue,this.thumb);this.thumb=null};MDCSliderFoundation.prototype.handleThumbMouseenter=function(){if(!this.isDiscrete||!this.isRange)return;this.adapter.addThumbClass(slider_constants_cssClasses.THUMB_WITH_INDICATOR,Thumb.START);this.adapter.addThumbClass(slider_constants_cssClasses.THUMB_WITH_INDICATOR,Thumb.END)};MDCSliderFoundation.prototype.handleThumbMouseleave=function(){if(!this.isDiscrete||!this.isRange)return;if(this.adapter.isInputFocused(Thumb.START)||this.adapter.isInputFocused(Thumb.END)){return}this.adapter.removeThumbClass(slider_constants_cssClasses.THUMB_WITH_INDICATOR,Thumb.START);this.adapter.removeThumbClass(slider_constants_cssClasses.THUMB_WITH_INDICATOR,Thumb.END)};MDCSliderFoundation.prototype.handleMousedownOrTouchstart=function(event){var _this=this;var moveEventType=event.type==="mousedown"?"mousemove":"touchmove";this.adapter.registerBodyEventHandler(moveEventType,this.moveListener);var upHandler=function(){_this.handleUp();_this.adapter.deregisterBodyEventHandler(moveEventType,_this.moveListener);_this.adapter.deregisterEventHandler("mouseup",upHandler);_this.adapter.deregisterEventHandler("touchend",upHandler)};this.adapter.registerBodyEventHandler("mouseup",upHandler);this.adapter.registerBodyEventHandler("touchend",upHandler);this.handleDown(event)};MDCSliderFoundation.prototype.handlePointerdown=function(event){this.adapter.setPointerCapture(event.pointerId);this.adapter.registerEventHandler("pointermove",this.moveListener);this.handleDown(event)};MDCSliderFoundation.prototype.handleInputChange=function(thumb){var value=Number(this.adapter.getInputValue(thumb));if(thumb===Thumb.START){this.setValueStart(value)}else{this.setValue(value)}};MDCSliderFoundation.prototype.handleInputFocus=function(thumb){if(!this.isDiscrete)return;this.adapter.addThumbClass(slider_constants_cssClasses.THUMB_WITH_INDICATOR,thumb);if(this.isRange){var otherThumb=thumb===Thumb.START?Thumb.END:Thumb.START;this.adapter.addThumbClass(slider_constants_cssClasses.THUMB_WITH_INDICATOR,otherThumb)}};MDCSliderFoundation.prototype.handleInputBlur=function(thumb){if(!this.isDiscrete)return;this.adapter.removeThumbClass(slider_constants_cssClasses.THUMB_WITH_INDICATOR,thumb);if(this.isRange){var otherThumb=thumb===Thumb.START?Thumb.END:Thumb.START;this.adapter.removeThumbClass(slider_constants_cssClasses.THUMB_WITH_INDICATOR,otherThumb)}};MDCSliderFoundation.prototype.handleDragStart=function(event,value,thumb){this.adapter.focusInput(thumb);event.preventDefault();this.adapter.emitDragStartEvent(value,thumb)};MDCSliderFoundation.prototype.getThumbFromDownEvent=function(clientX,value){if(!this.isRange)return Thumb.END;var thumbStartRect=this.adapter.getThumbBoundingClientRect(Thumb.START);var thumbEndRect=this.adapter.getThumbBoundingClientRect(Thumb.END);var inThumbStartBounds=clientX>=thumbStartRect.left&&clientX<=thumbStartRect.right;var inThumbEndBounds=clientX>=thumbEndRect.left&&clientX<=thumbEndRect.right;if(inThumbStartBounds&&inThumbEndBounds){return null}if(inThumbStartBounds){return Thumb.START}if(inThumbEndBounds){return Thumb.END}if(value<this.valueStart){return Thumb.START}if(value>this.value){return Thumb.END}return null};MDCSliderFoundation.prototype.getThumbFromMoveEvent=function(clientX){if(this.thumb!==null)return this.thumb;if(this.downEventClientX===null){throw new Error("`downEventClientX` is null after move event.")}var moveDistanceUnderThreshold=Math.abs(this.downEventClientX-clientX)<slider_constants_numbers.THUMB_UPDATE_MIN_PX;if(moveDistanceUnderThreshold)return this.thumb;var draggedThumbToLeft=clientX<this.downEventClientX;if(draggedThumbToLeft){return this.adapter.isRTL()?Thumb.END:Thumb.START}else{return this.adapter.isRTL()?Thumb.START:Thumb.END}};MDCSliderFoundation.prototype.updateUI=function(thumb){this.updateThumbAndInputAttributes(thumb);this.updateThumbAndTrackUI(thumb);this.updateValueIndicatorUI(thumb);this.updateTickMarksUI()};MDCSliderFoundation.prototype.updateThumbAndInputAttributes=function(thumb){if(!thumb)return;var value=this.isRange&&thumb===Thumb.START?this.valueStart:this.value;var valueStr=String(value);this.adapter.setInputAttribute(slider_constants_attributes.INPUT_VALUE,valueStr,thumb);if(this.isRange&&thumb===Thumb.START){this.adapter.setInputAttribute(slider_constants_attributes.INPUT_MIN,valueStr,Thumb.END)}else if(this.isRange&&thumb===Thumb.END){this.adapter.setInputAttribute(slider_constants_attributes.INPUT_MAX,valueStr,Thumb.START)}if(this.adapter.getInputValue(thumb)!==valueStr){this.adapter.setInputValue(valueStr,thumb)}var valueToAriaValueTextFn=this.adapter.getValueToAriaValueTextFn();if(valueToAriaValueTextFn){this.adapter.setInputAttribute(slider_constants_attributes.ARIA_VALUETEXT,valueToAriaValueTextFn(value),thumb)}};MDCSliderFoundation.prototype.updateValueIndicatorUI=function(thumb){if(!this.isDiscrete)return;var value=this.isRange&&thumb===Thumb.START?this.valueStart:this.value;this.adapter.setValueIndicatorText(value,thumb===Thumb.START?Thumb.START:Thumb.END);if(!thumb&&this.isRange){this.adapter.setValueIndicatorText(this.valueStart,Thumb.START)}};MDCSliderFoundation.prototype.updateTickMarksUI=function(){if(!this.isDiscrete||!this.hasTickMarks)return;var numTickMarksInactiveStart=(this.valueStart-this.min)/this.step;var numTickMarksActive=(this.value-this.valueStart)/this.step+1;var numTickMarksInactiveEnd=(this.max-this.value)/this.step;var tickMarksInactiveStart=Array.from({length:numTickMarksInactiveStart}).fill(TickMark.INACTIVE);var tickMarksActive=Array.from({length:numTickMarksActive}).fill(TickMark.ACTIVE);var tickMarksInactiveEnd=Array.from({length:numTickMarksInactiveEnd}).fill(TickMark.INACTIVE);this.adapter.updateTickMarks(tickMarksInactiveStart.concat(tickMarksActive).concat(tickMarksInactiveEnd))};MDCSliderFoundation.prototype.mapClientXOnSliderScale=function(clientX){var xPos=clientX-this.rect.left;var pctComplete=xPos/this.rect.width;if(this.adapter.isRTL()){pctComplete=1-pctComplete}var value=this.min+pctComplete*(this.max-this.min);if(value===this.max||value===this.min){return value}return this.quantize(value)};MDCSliderFoundation.prototype.updateValue=function(value,thumb,_a){var _b=_a===void 0?{}:_a,emitInputEvent=_b.emitInputEvent,emitChangeEvent=_b.emitChangeEvent;value=this.clampValue(value,thumb);if(this.isRange&&thumb===Thumb.START){if(this.valueStart===value)return;this.valueStart=value}else{if(this.value===value)return;this.value=value}this.updateUI(thumb);if(emitInputEvent){this.adapter.emitInputEvent(thumb===Thumb.START?this.valueStart:this.value,thumb)}if(emitChangeEvent){this.adapter.emitChangeEvent(thumb===Thumb.START?this.valueStart:this.value,thumb)}};MDCSliderFoundation.prototype.quantize=function(value){var numSteps=Math.round(value/this.step);return numSteps*this.step};MDCSliderFoundation.prototype.clampValue=function(value,thumb){value=Math.min(Math.max(value,this.min),this.max);var thumbStartMovedPastThumbEnd=this.isRange&&thumb===Thumb.START&&value>this.value;if(thumbStartMovedPastThumbEnd){return this.value}var thumbEndMovedPastThumbStart=this.isRange&&thumb===Thumb.END&&value<this.valueStart;if(thumbEndMovedPastThumbStart){return this.valueStart}return value};MDCSliderFoundation.prototype.updateThumbAndTrackUI=function(thumb){var _this=this;var _a=this,max=_a.max,min=_a.min;var pctComplete=(this.value-this.valueStart)/(max-min);var rangePx=pctComplete*this.rect.width;var isRtl=this.adapter.isRTL();var transformProp=HAS_WINDOW?getCorrectPropertyName(window,"transform"):"transform";if(this.isRange){var thumbLeftPos_1=this.adapter.isRTL()?(max-this.value)/(max-min)*this.rect.width:(this.valueStart-min)/(max-min)*this.rect.width;var thumbRightPos_1=thumbLeftPos_1+rangePx;requestAnimationFrame((function(){var trackAnimatesFromRight=!isRtl&&thumb===Thumb.START||isRtl&&thumb!==Thumb.START;if(trackAnimatesFromRight){_this.adapter.setTrackActiveStyleProperty("transform-origin","right");_this.adapter.setTrackActiveStyleProperty("left","unset");_this.adapter.setTrackActiveStyleProperty("right",_this.rect.width-thumbRightPos_1+"px")}else{_this.adapter.setTrackActiveStyleProperty("transform-origin","left");_this.adapter.setTrackActiveStyleProperty("right","unset");_this.adapter.setTrackActiveStyleProperty("left",thumbLeftPos_1+"px")}_this.adapter.setTrackActiveStyleProperty(transformProp,"scaleX("+pctComplete+")");var thumbStartPos=isRtl?thumbRightPos_1:thumbLeftPos_1;var thumbEndPos=_this.adapter.isRTL()?thumbLeftPos_1:thumbRightPos_1;if(thumb===Thumb.START||!thumb||!_this.initialStylesRemoved){_this.adapter.setThumbStyleProperty(transformProp,"translateX("+thumbStartPos+"px)",Thumb.START)}if(thumb===Thumb.END||!thumb||!_this.initialStylesRemoved){_this.adapter.setThumbStyleProperty(transformProp,"translateX("+thumbEndPos+"px)",Thumb.END)}_this.removeInitialStyles(isRtl);_this.updateOverlappingThumbsUI(thumbStartPos,thumbEndPos,thumb)}))}else{requestAnimationFrame((function(){var thumbStartPos=isRtl?_this.rect.width-rangePx:rangePx;_this.adapter.setThumbStyleProperty(transformProp,"translateX("+thumbStartPos+"px)",Thumb.END);_this.adapter.setTrackActiveStyleProperty(transformProp,"scaleX("+pctComplete+")");_this.removeInitialStyles(isRtl)}))}};MDCSliderFoundation.prototype.removeInitialStyles=function(isRtl){if(this.initialStylesRemoved)return;var position=isRtl?"right":"left";this.adapter.removeThumbStyleProperty(position,Thumb.END);if(this.isRange){this.adapter.removeThumbStyleProperty(position,Thumb.START)}this.initialStylesRemoved=true;this.resetTrackAndThumbAnimation()};MDCSliderFoundation.prototype.resetTrackAndThumbAnimation=function(){var _this=this;if(!this.isDiscrete)return;var transitionProp=HAS_WINDOW?getCorrectPropertyName(window,"transition"):"transition";var transitionDefault="all 0s ease 0s";this.adapter.setThumbStyleProperty(transitionProp,transitionDefault,Thumb.END);if(this.isRange){this.adapter.setThumbStyleProperty(transitionProp,transitionDefault,Thumb.START)}this.adapter.setTrackActiveStyleProperty(transitionProp,transitionDefault);requestAnimationFrame((function(){_this.adapter.removeThumbStyleProperty(transitionProp,Thumb.END);_this.adapter.removeTrackActiveStyleProperty(transitionProp);if(_this.isRange){_this.adapter.removeThumbStyleProperty(transitionProp,Thumb.START)}}))};MDCSliderFoundation.prototype.updateOverlappingThumbsUI=function(thumbStartPos,thumbEndPos,thumb){var thumbsOverlap=false;if(this.adapter.isRTL()){var startThumbLeftEdge=thumbStartPos-this.startThumbKnobWidth/2;var endThumbRightEdge=thumbEndPos+this.endThumbKnobWidth/2;thumbsOverlap=endThumbRightEdge>=startThumbLeftEdge}else{var startThumbRightEdge=thumbStartPos+this.startThumbKnobWidth/2;var endThumbLeftEdge=thumbEndPos-this.endThumbKnobWidth/2;thumbsOverlap=startThumbRightEdge>=endThumbLeftEdge}if(thumbsOverlap){this.adapter.addThumbClass(slider_constants_cssClasses.THUMB_TOP,thumb||Thumb.END);this.adapter.removeThumbClass(slider_constants_cssClasses.THUMB_TOP,thumb===Thumb.START?Thumb.END:Thumb.START)}else{this.adapter.removeThumbClass(slider_constants_cssClasses.THUMB_TOP,Thumb.START);this.adapter.removeThumbClass(slider_constants_cssClasses.THUMB_TOP,Thumb.END)}};MDCSliderFoundation.prototype.convertAttributeValueToNumber=function(attributeValue,attributeName){if(attributeValue===null){throw new Error("MDCSliderFoundation: `"+attributeName+"` must be non-null.")}var value=Number(attributeValue);if(isNaN(value)){throw new Error("MDCSliderFoundation: `"+attributeName+"` value is "+("`"+attributeValue+"`, but must be a number."))}return value};MDCSliderFoundation.prototype.validateProperties=function(_a){var min=_a.min,max=_a.max,value=_a.value,valueStart=_a.valueStart;if(min>=max){throw new Error("MDCSliderFoundation: min must be strictly less than max. "+("Current: [min: "+min+", max: "+max+"]"))}if(this.isRange){if(value<min||value>max||valueStart<min||valueStart>max){throw new Error("MDCSliderFoundation: values must be in [min, max] range. "+("Current values: [start value: "+valueStart+", end value: "+value+"]"))}if(valueStart>value){throw new Error("MDCSliderFoundation: start value must be <= end value. "+("Current values: [start value: "+valueStart+", end value: "+value+"]"))}}else{if(value<min||value>max){throw new Error("MDCSliderFoundation: value must be in [min, max] range. "+("Current value: "+value))}}};MDCSliderFoundation.prototype.registerEventHandlers=function(){this.adapter.registerWindowEventHandler("resize",this.resizeListener);if(MDCSliderFoundation.SUPPORTS_POINTER_EVENTS){this.adapter.registerEventHandler("pointerdown",this.pointerdownListener);this.adapter.registerEventHandler("pointerup",this.pointerupListener)}else{this.adapter.registerEventHandler("mousedown",this.mousedownOrTouchstartListener);this.adapter.registerEventHandler("touchstart",this.mousedownOrTouchstartListener)}if(this.isRange){this.adapter.registerThumbEventHandler(Thumb.START,"mouseenter",this.thumbMouseenterListener);this.adapter.registerThumbEventHandler(Thumb.START,"mouseleave",this.thumbMouseleaveListener);this.adapter.registerInputEventHandler(Thumb.START,"change",this.inputStartChangeListener);this.adapter.registerInputEventHandler(Thumb.START,"focus",this.inputStartFocusListener);this.adapter.registerInputEventHandler(Thumb.START,"blur",this.inputStartBlurListener)}this.adapter.registerThumbEventHandler(Thumb.END,"mouseenter",this.thumbMouseenterListener);this.adapter.registerThumbEventHandler(Thumb.END,"mouseleave",this.thumbMouseleaveListener);this.adapter.registerInputEventHandler(Thumb.END,"change",this.inputEndChangeListener);this.adapter.registerInputEventHandler(Thumb.END,"focus",this.inputEndFocusListener);this.adapter.registerInputEventHandler(Thumb.END,"blur",this.inputEndBlurListener)};MDCSliderFoundation.prototype.deregisterEventHandlers=function(){this.adapter.deregisterWindowEventHandler("resize",this.resizeListener);if(MDCSliderFoundation.SUPPORTS_POINTER_EVENTS){this.adapter.deregisterEventHandler("pointerdown",this.pointerdownListener);this.adapter.deregisterEventHandler("pointerup",this.pointerupListener)}else{this.adapter.deregisterEventHandler("mousedown",this.mousedownOrTouchstartListener);this.adapter.deregisterEventHandler("touchstart",this.mousedownOrTouchstartListener)}if(this.isRange){this.adapter.deregisterThumbEventHandler(Thumb.START,"mouseenter",this.thumbMouseenterListener);this.adapter.deregisterThumbEventHandler(Thumb.START,"mouseleave",this.thumbMouseleaveListener);this.adapter.deregisterInputEventHandler(Thumb.START,"change",this.inputStartChangeListener);this.adapter.deregisterInputEventHandler(Thumb.START,"focus",this.inputStartFocusListener);this.adapter.deregisterInputEventHandler(Thumb.START,"blur",this.inputStartBlurListener)}this.adapter.deregisterThumbEventHandler(Thumb.END,"mouseenter",this.thumbMouseenterListener);this.adapter.deregisterThumbEventHandler(Thumb.END,"mouseleave",this.thumbMouseleaveListener);this.adapter.deregisterInputEventHandler(Thumb.END,"change",this.inputEndChangeListener);this.adapter.deregisterInputEventHandler(Thumb.END,"focus",this.inputEndFocusListener);this.adapter.deregisterInputEventHandler(Thumb.END,"blur",this.inputEndBlurListener)};MDCSliderFoundation.prototype.handlePointerup=function(){this.handleUp();this.adapter.deregisterEventHandler("pointermove",this.moveListener)};MDCSliderFoundation.SUPPORTS_POINTER_EVENTS=HAS_WINDOW&&Boolean(window.PointerEvent);return MDCSliderFoundation}(MDCFoundation);
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
 */
var MDCSlider=function(_super){__extends(MDCSlider,_super);function MDCSlider(){var _this=_super!==null&&_super.apply(this,arguments)||this;_this.skipInitialUIUpdate=false;_this.valueToAriaValueTextFn=null;return _this}MDCSlider.attachTo=function(root,options){if(options===void 0){options={}}return new MDCSlider(root,undefined,options)};MDCSlider.prototype.getDefaultFoundation=function(){var _this=this;var adapter={hasClass:function(className){return _this.root.classList.contains(className)},addClass:function(className){_this.root.classList.add(className)},removeClass:function(className){_this.root.classList.remove(className)},addThumbClass:function(className,thumb){_this.getThumbEl(thumb).classList.add(className)},removeThumbClass:function(className,thumb){_this.getThumbEl(thumb).classList.remove(className)},getAttribute:function(attribute){return _this.root.getAttribute(attribute)},getInputValue:function(thumb){return _this.getInput(thumb).value},setInputValue:function(value,thumb){_this.getInput(thumb).value=value},getInputAttribute:function(attribute,thumb){return _this.getInput(thumb).getAttribute(attribute)},setInputAttribute:function(attribute,value,thumb){_this.getInput(thumb).setAttribute(attribute,value)},removeInputAttribute:function(attribute,thumb){_this.getInput(thumb).removeAttribute(attribute)},focusInput:function(thumb){_this.getInput(thumb).focus()},isInputFocused:function(thumb){return _this.getInput(thumb)===document.activeElement},getThumbKnobWidth:function(thumb){return _this.getThumbEl(thumb).querySelector("."+slider_constants_cssClasses.THUMB_KNOB).getBoundingClientRect().width},getThumbBoundingClientRect:function(thumb){return _this.getThumbEl(thumb).getBoundingClientRect()},getBoundingClientRect:function(){return _this.root.getBoundingClientRect()},isRTL:function(){return getComputedStyle(_this.root).direction==="rtl"},setThumbStyleProperty:function(propertyName,value,thumb){_this.getThumbEl(thumb).style.setProperty(propertyName,value)},removeThumbStyleProperty:function(propertyName,thumb){_this.getThumbEl(thumb).style.removeProperty(propertyName)},setTrackActiveStyleProperty:function(propertyName,value){_this.trackActive.style.setProperty(propertyName,value)},removeTrackActiveStyleProperty:function(propertyName){_this.trackActive.style.removeProperty(propertyName)},setValueIndicatorText:function(value,thumb){var valueIndicatorEl=_this.getThumbEl(thumb).querySelector("."+slider_constants_cssClasses.VALUE_INDICATOR_TEXT);valueIndicatorEl.textContent=String(value)},getValueToAriaValueTextFn:function(){return _this.valueToAriaValueTextFn},updateTickMarks:function(tickMarks){var tickMarksContainer=_this.root.querySelector("."+slider_constants_cssClasses.TICK_MARKS_CONTAINER);if(!tickMarksContainer){tickMarksContainer=document.createElement("div");tickMarksContainer.classList.add(slider_constants_cssClasses.TICK_MARKS_CONTAINER);var track=_this.root.querySelector("."+slider_constants_cssClasses.TRACK);track.appendChild(tickMarksContainer)}if(tickMarks.length!==tickMarksContainer.children.length){tickMarksContainer.innerHTML="";_this.addTickMarks(tickMarksContainer,tickMarks)}else{_this.updateTickMarks(tickMarksContainer,tickMarks)}},setPointerCapture:function(pointerId){_this.root.setPointerCapture(pointerId)},emitChangeEvent:function(value,thumb){_this.emit(slider_constants_events.CHANGE,{value:value,thumb:thumb})},emitInputEvent:function(value,thumb){_this.emit(slider_constants_events.INPUT,{value:value,thumb:thumb})},emitDragStartEvent:function(_,thumb){_this.getRipple(thumb).activate()},emitDragEndEvent:function(_,thumb){_this.getRipple(thumb).deactivate()},registerEventHandler:function(evtType,handler){_this.listen(evtType,handler)},deregisterEventHandler:function(evtType,handler){_this.unlisten(evtType,handler)},registerThumbEventHandler:function(thumb,evtType,handler){_this.getThumbEl(thumb).addEventListener(evtType,handler)},deregisterThumbEventHandler:function(thumb,evtType,handler){_this.getThumbEl(thumb).removeEventListener(evtType,handler)},registerInputEventHandler:function(thumb,evtType,handler){_this.getInput(thumb).addEventListener(evtType,handler)},deregisterInputEventHandler:function(thumb,evtType,handler){_this.getInput(thumb).removeEventListener(evtType,handler)},registerBodyEventHandler:function(evtType,handler){document.body.addEventListener(evtType,handler)},deregisterBodyEventHandler:function(evtType,handler){document.body.removeEventListener(evtType,handler)},registerWindowEventHandler:function(evtType,handler){window.addEventListener(evtType,handler)},deregisterWindowEventHandler:function(evtType,handler){window.removeEventListener(evtType,handler)}};return new MDCSliderFoundation(adapter)};MDCSlider.prototype.initialize=function(_a){var skipInitialUIUpdate=(_a===void 0?{}:_a).skipInitialUIUpdate;this.inputs=[].slice.call(this.root.querySelectorAll("."+slider_constants_cssClasses.INPUT));this.thumbs=[].slice.call(this.root.querySelectorAll("."+slider_constants_cssClasses.THUMB));this.trackActive=this.root.querySelector("."+slider_constants_cssClasses.TRACK_ACTIVE);this.ripples=this.createRipples();if(skipInitialUIUpdate){this.skipInitialUIUpdate=true}};MDCSlider.prototype.initialSyncWithDOM=function(){this.foundation.layout({skipUpdateUI:this.skipInitialUIUpdate})};MDCSlider.prototype.layout=function(){this.foundation.layout()};MDCSlider.prototype.getValueStart=function(){return this.foundation.getValueStart()};MDCSlider.prototype.setValueStart=function(valueStart){this.foundation.setValueStart(valueStart)};MDCSlider.prototype.getValue=function(){return this.foundation.getValue()};MDCSlider.prototype.setValue=function(value){this.foundation.setValue(value)};MDCSlider.prototype.getDisabled=function(){return this.foundation.getDisabled()};MDCSlider.prototype.setDisabled=function(disabled){this.foundation.setDisabled(disabled)};MDCSlider.prototype.setValueToAriaValueTextFn=function(mapFn){this.valueToAriaValueTextFn=mapFn};MDCSlider.prototype.getThumbEl=function(thumb){return thumb===Thumb.END?this.thumbs[this.thumbs.length-1]:this.thumbs[0]};MDCSlider.prototype.getInput=function(thumb){return thumb===Thumb.END?this.inputs[this.inputs.length-1]:this.inputs[0]};MDCSlider.prototype.getRipple=function(thumb){return thumb===Thumb.END?this.ripples[this.ripples.length-1]:this.ripples[0]};MDCSlider.prototype.addTickMarks=function(tickMarkContainer,tickMarks){var fragment=document.createDocumentFragment();for(var i=0;i<tickMarks.length;i++){var div=document.createElement("div");var tickMarkClass=tickMarks[i]===TickMark.ACTIVE?slider_constants_cssClasses.TICK_MARK_ACTIVE:slider_constants_cssClasses.TICK_MARK_INACTIVE;div.classList.add(tickMarkClass);fragment.appendChild(div)}tickMarkContainer.appendChild(fragment)};MDCSlider.prototype.updateTickMarks=function(tickMarkContainer,tickMarks){var tickMarkEls=Array.from(tickMarkContainer.children);for(var i=0;i<tickMarkEls.length;i++){if(tickMarks[i]===TickMark.ACTIVE){tickMarkEls[i].classList.add(slider_constants_cssClasses.TICK_MARK_ACTIVE);tickMarkEls[i].classList.remove(slider_constants_cssClasses.TICK_MARK_INACTIVE)}else{tickMarkEls[i].classList.add(slider_constants_cssClasses.TICK_MARK_INACTIVE);tickMarkEls[i].classList.remove(slider_constants_cssClasses.TICK_MARK_ACTIVE)}}};MDCSlider.prototype.createRipples=function(){var ripples=[];var rippleSurfaces=[].slice.call(this.root.querySelectorAll("."+slider_constants_cssClasses.THUMB));var _loop_1=function(i){var rippleSurface=rippleSurfaces[i];var input=this_1.inputs[i];var adapter=__assign(__assign({},MDCRipple.createAdapter(this_1)),{addClass:function(className){rippleSurface.classList.add(className)},computeBoundingRect:function(){return rippleSurface.getBoundingClientRect()},deregisterInteractionHandler:function(evtType,handler){input.removeEventListener(evtType,handler)},isSurfaceActive:function(){return matches(input,":active")},isUnbounded:function(){return true},registerInteractionHandler:function(evtType,handler){input.addEventListener(evtType,handler)},removeClass:function(className){rippleSurface.classList.remove(className)},updateCssVariable:function(varName,value){rippleSurface.style.setProperty(varName,value)}});var ripple=new MDCRipple(rippleSurface,new MDCRippleFoundation(adapter));ripple.unbounded=true;ripples.push(ripple)};var this_1=this;for(var i=0;i<rippleSurfaces.length;i++){_loop_1(i)}return ripples};return MDCSlider}(MDCComponent);function _typeof(obj){"@babel/helpers - typeof";if(typeof Symbol==="function"&&typeof Symbol.iterator==="symbol"){_typeof=function _typeof(obj){return typeof obj}}else{_typeof=function _typeof(obj){return obj&&typeof Symbol==="function"&&obj.constructor===Symbol&&obj!==Symbol.prototype?"symbol":typeof obj}}return _typeof(obj)}
/**
 * @license
 * 
 * This file is based on https://github.com/lodash/lodash and thus licensed as follows.
 * The code & license is based on https://github.com/lodash/lodash/tree/2da024c3b4f9947a48517639de7560457cd4ec6c
 * 
 * The MIT License
 *
 * Copyright JS Foundation and other contributors <https://js.foundation/>
 * 
 * Based on Underscore.js, copyright Jeremy Ashkenas,
 * DocumentCloud and Investigative Reporters & Editors <http://underscorejs.org/>
 * 
 * This software consists of voluntary contributions made by many
 * individuals. For exact contribution history, see the revision history
 * available at https://github.com/lodash/lodash
 * 
 * The following license applies to all parts of this software except as
 * documented below:
 * 
 * ====
 * 
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the
 * "Software"), to deal in the Software without restriction, including
 * without limitation the rights to use, copy, modify, merge, publish,
 * distribute, sublicense, and/or sell copies of the Software, and to
 * permit persons to whom the Software is furnished to do so, subject to
 * the following conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
 * LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
 * OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
 * WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 * ====
 * 
 * Copyright and related rights for sample code are waived via CC0. Sample
 * code is defined as all source code displayed within the prose of the
 * documentation.
 * 
 * CC0: http://creativecommons.org/publicdomain/zero/1.0/
 * 
 * ====
 * 
 * Files located in the node_modules and vendor directories are externally
 * maintained libraries used by this software which have their own
 * licenses; we recommend you read them, as their terms may differ from the
 * terms above.
 * 
 */
function isObject(value){var type=_typeof(value);return value!=null&&(type==="object"||type==="function")}var freeGlobal=(typeof __webpack_require__.g==="undefined"?"undefined":_typeof(__webpack_require__.g))==="object"&&__webpack_require__.g!==null&&__webpack_require__.g.Object===Object&&__webpack_require__.g;var freeGlobalThis=(typeof globalThis==="undefined"?"undefined":_typeof(globalThis))==="object"&&globalThis!==null&&globalThis.Object==Object&&globalThis;var freeSelf=(typeof self==="undefined"?"undefined":_typeof(self))==="object"&&self!==null&&self.Object===Object&&self;var root=freeGlobalThis||freeGlobal||freeSelf||Function("return this")();function debounce(func,wait,options){var lastArgs,lastThis,maxWait,result,timerId,lastCallTime;var lastInvokeTime=0;var leading=false;var maxing=false;var trailing=true;var useRAF=!wait&&wait!==0&&typeof root.requestAnimationFrame==="function";if(typeof func!=="function"){throw new TypeError("Expected a function")}wait=+wait||0;if(isObject(options)){leading=!!options.leading;maxing="maxWait"in options;maxWait=maxing?Math.max(+options.maxWait||0,wait):maxWait;trailing="trailing"in options?!!options.trailing:trailing}function invokeFunc(time){var args=lastArgs;var thisArg=lastThis;lastArgs=lastThis=undefined;lastInvokeTime=time;result=func.apply(thisArg,args);return result}function startTimer(pendingFunc,wait){if(useRAF){root.cancelAnimationFrame(timerId);return root.requestAnimationFrame(pendingFunc)}return setTimeout(pendingFunc,wait)}function cancelTimer(id){if(useRAF){return root.cancelAnimationFrame(id)}clearTimeout(id)}function leadingEdge(time){lastInvokeTime=time;timerId=startTimer(timerExpired,wait);return leading?invokeFunc(time):result}function remainingWait(time){var timeSinceLastCall=time-lastCallTime;var timeSinceLastInvoke=time-lastInvokeTime;var timeWaiting=wait-timeSinceLastCall;return maxing?Math.min(timeWaiting,maxWait-timeSinceLastInvoke):timeWaiting}function shouldInvoke(time){var timeSinceLastCall=time-lastCallTime;var timeSinceLastInvoke=time-lastInvokeTime;return lastCallTime===undefined||timeSinceLastCall>=wait||timeSinceLastCall<0||maxing&&timeSinceLastInvoke>=maxWait}function timerExpired(){var time=Date.now();if(shouldInvoke(time)){return trailingEdge(time)}timerId=startTimer(timerExpired,remainingWait(time))}function trailingEdge(time){timerId=undefined;if(trailing&&lastArgs){return invokeFunc(time)}lastArgs=lastThis=undefined;return result}function cancel(){if(timerId!==undefined){cancelTimer(timerId)}lastInvokeTime=0;lastArgs=lastCallTime=lastThis=timerId=undefined}function flush(){return timerId===undefined?result:trailingEdge(Date.now())}function pending(){return timerId!==undefined}function debounced(){var time=Date.now();var isInvoking=shouldInvoke(time);for(var _len=arguments.length,args=new Array(_len),_key=0;_key<_len;_key++){args[_key]=arguments[_key]}lastArgs=args;lastThis=this;lastCallTime=time;if(isInvoking){if(timerId===undefined){return leadingEdge(lastCallTime)}if(maxing){timerId=startTimer(timerExpired,wait);return invokeFunc(lastCallTime)}}if(timerId===undefined){timerId=startTimer(timerExpired,wait)}return result}debounced.cancel=cancel;debounced.flush=flush;debounced.pending=pending;return debounced}function throttle(func,wait,options){var leading=true;var trailing=true;if(typeof func!=="function"){throw new TypeError("Expected a function")}if(isObject(options)){leading="leading"in options?!!options.leading:leading;trailing="trailing"in options?!!options.trailing:trailing}return debounce(func,wait,{leading:leading,trailing:trailing,maxWait:wait})}function MBSlider_init(elem,dotNetObject,eventType,delay){if(!elem){return}elem._slider=MDCSlider.attachTo(elem);elem._eventType=eventType;if(eventType==0){var thumbUpCallback=function thumbUpCallback(){dotNetObject.invokeMethodAsync("NotifyChanged",elem._slider.getValue())};elem._slider.listen("MDCSlider:change",thumbUpCallback)}else if(eventType==1){var debounceNotify=debounce((function(){dotNetObject.invokeMethodAsync("NotifyChanged",elem._slider.getValue())}),delay,{});elem._slider.listen("MDCSlider:input",debounceNotify)}else{var throttleNotify=throttle((function(){dotNetObject.invokeMethodAsync("NotifyChanged",elem._slider.getValue())}),delay,{});elem._slider.listen("MDCSlider:input",throttleNotify)}}function MBSlider_setValue(elem,value){if(!elem){return}elem._slider.setValue(value)}function MBSlider_setDisabled(elem,value){if(!elem){return}elem._slider.setDisabled(value)}
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var snackbar_constants_cssClasses={CLOSING:"mdc-snackbar--closing",OPEN:"mdc-snackbar--open",OPENING:"mdc-snackbar--opening"};var snackbar_constants_strings={ACTION_SELECTOR:".mdc-snackbar__action",ARIA_LIVE_LABEL_TEXT_ATTR:"data-mdc-snackbar-label-text",CLOSED_EVENT:"MDCSnackbar:closed",CLOSING_EVENT:"MDCSnackbar:closing",DISMISS_SELECTOR:".mdc-snackbar__dismiss",LABEL_SELECTOR:".mdc-snackbar__label",OPENED_EVENT:"MDCSnackbar:opened",OPENING_EVENT:"MDCSnackbar:opening",REASON_ACTION:"action",REASON_DISMISS:"dismiss",SURFACE_SELECTOR:".mdc-snackbar__surface"};var snackbar_constants_numbers={DEFAULT_AUTO_DISMISS_TIMEOUT_MS:5e3,INDETERMINATE:-1,MAX_AUTO_DISMISS_TIMEOUT_MS:1e4,MIN_AUTO_DISMISS_TIMEOUT_MS:4e3,SNACKBAR_ANIMATION_CLOSE_TIME_MS:75,SNACKBAR_ANIMATION_OPEN_TIME_MS:150,ARIA_LIVE_DELAY_MS:1e3};
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var OPENING=snackbar_constants_cssClasses.OPENING,OPEN=snackbar_constants_cssClasses.OPEN,CLOSING=snackbar_constants_cssClasses.CLOSING;var REASON_ACTION=snackbar_constants_strings.REASON_ACTION,REASON_DISMISS=snackbar_constants_strings.REASON_DISMISS;var MDCSnackbarFoundation=function(_super){__extends(MDCSnackbarFoundation,_super);function MDCSnackbarFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCSnackbarFoundation.defaultAdapter),adapter))||this;_this.isOpen_=false;_this.animationFrame_=0;_this.animationTimer_=0;_this.autoDismissTimer_=0;_this.autoDismissTimeoutMs_=snackbar_constants_numbers.DEFAULT_AUTO_DISMISS_TIMEOUT_MS;_this.closeOnEscape_=true;return _this}Object.defineProperty(MDCSnackbarFoundation,"cssClasses",{get:function(){return snackbar_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCSnackbarFoundation,"strings",{get:function(){return snackbar_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCSnackbarFoundation,"numbers",{get:function(){return snackbar_constants_numbers},enumerable:true,configurable:true});Object.defineProperty(MDCSnackbarFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},announce:function(){return undefined},notifyClosed:function(){return undefined},notifyClosing:function(){return undefined},notifyOpened:function(){return undefined},notifyOpening:function(){return undefined},removeClass:function(){return undefined}}},enumerable:true,configurable:true});MDCSnackbarFoundation.prototype.destroy=function(){this.clearAutoDismissTimer_();cancelAnimationFrame(this.animationFrame_);this.animationFrame_=0;clearTimeout(this.animationTimer_);this.animationTimer_=0;this.adapter.removeClass(OPENING);this.adapter.removeClass(OPEN);this.adapter.removeClass(CLOSING)};MDCSnackbarFoundation.prototype.open=function(){var _this=this;this.clearAutoDismissTimer_();this.isOpen_=true;this.adapter.notifyOpening();this.adapter.removeClass(CLOSING);this.adapter.addClass(OPENING);this.adapter.announce();this.runNextAnimationFrame_((function(){_this.adapter.addClass(OPEN);_this.animationTimer_=setTimeout((function(){var timeoutMs=_this.getTimeoutMs();_this.handleAnimationTimerEnd_();_this.adapter.notifyOpened();if(timeoutMs!==snackbar_constants_numbers.INDETERMINATE){_this.autoDismissTimer_=setTimeout((function(){_this.close(REASON_DISMISS)}),timeoutMs)}}),snackbar_constants_numbers.SNACKBAR_ANIMATION_OPEN_TIME_MS)}))};MDCSnackbarFoundation.prototype.close=function(reason){var _this=this;if(reason===void 0){reason=""}if(!this.isOpen_){return}cancelAnimationFrame(this.animationFrame_);this.animationFrame_=0;this.clearAutoDismissTimer_();this.isOpen_=false;this.adapter.notifyClosing(reason);this.adapter.addClass(snackbar_constants_cssClasses.CLOSING);this.adapter.removeClass(snackbar_constants_cssClasses.OPEN);this.adapter.removeClass(snackbar_constants_cssClasses.OPENING);clearTimeout(this.animationTimer_);this.animationTimer_=setTimeout((function(){_this.handleAnimationTimerEnd_();_this.adapter.notifyClosed(reason)}),snackbar_constants_numbers.SNACKBAR_ANIMATION_CLOSE_TIME_MS)};MDCSnackbarFoundation.prototype.isOpen=function(){return this.isOpen_};MDCSnackbarFoundation.prototype.getTimeoutMs=function(){return this.autoDismissTimeoutMs_};MDCSnackbarFoundation.prototype.setTimeoutMs=function(timeoutMs){var minValue=snackbar_constants_numbers.MIN_AUTO_DISMISS_TIMEOUT_MS;var maxValue=snackbar_constants_numbers.MAX_AUTO_DISMISS_TIMEOUT_MS;var indeterminateValue=snackbar_constants_numbers.INDETERMINATE;if(timeoutMs===snackbar_constants_numbers.INDETERMINATE||timeoutMs<=maxValue&&timeoutMs>=minValue){this.autoDismissTimeoutMs_=timeoutMs}else{throw new Error("\n        timeoutMs must be an integer in the range "+minValue+"–"+maxValue+"\n        (or "+indeterminateValue+" to disable), but got '"+timeoutMs+"'")}};MDCSnackbarFoundation.prototype.getCloseOnEscape=function(){return this.closeOnEscape_};MDCSnackbarFoundation.prototype.setCloseOnEscape=function(closeOnEscape){this.closeOnEscape_=closeOnEscape};MDCSnackbarFoundation.prototype.handleKeyDown=function(evt){var isEscapeKey=evt.key==="Escape"||evt.keyCode===27;if(isEscapeKey&&this.getCloseOnEscape()){this.close(REASON_DISMISS)}};MDCSnackbarFoundation.prototype.handleActionButtonClick=function(_evt){this.close(REASON_ACTION)};MDCSnackbarFoundation.prototype.handleActionIconClick=function(_evt){this.close(REASON_DISMISS)};MDCSnackbarFoundation.prototype.clearAutoDismissTimer_=function(){clearTimeout(this.autoDismissTimer_);this.autoDismissTimer_=0};MDCSnackbarFoundation.prototype.handleAnimationTimerEnd_=function(){this.animationTimer_=0;this.adapter.removeClass(snackbar_constants_cssClasses.OPENING);this.adapter.removeClass(snackbar_constants_cssClasses.CLOSING)};MDCSnackbarFoundation.prototype.runNextAnimationFrame_=function(callback){var _this=this;cancelAnimationFrame(this.animationFrame_);this.animationFrame_=requestAnimationFrame((function(){_this.animationFrame_=0;clearTimeout(_this.animationTimer_);_this.animationTimer_=setTimeout(callback,0)}))};return MDCSnackbarFoundation}(MDCFoundation);const snackbar_foundation=null&&MDCSnackbarFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var ARIA_LIVE_DELAY_MS=snackbar_constants_numbers.ARIA_LIVE_DELAY_MS;var ARIA_LIVE_LABEL_TEXT_ATTR=snackbar_constants_strings.ARIA_LIVE_LABEL_TEXT_ATTR;function util_announce(ariaEl,labelEl){if(labelEl===void 0){labelEl=ariaEl}var priority=ariaEl.getAttribute("aria-live");var labelText=labelEl.textContent.trim();if(!labelText||!priority){return}ariaEl.setAttribute("aria-live","off");labelEl.textContent="";labelEl.innerHTML='<span style="display: inline-block; width: 0; height: 1px;">&nbsp;</span>';labelEl.setAttribute(ARIA_LIVE_LABEL_TEXT_ATTR,labelText);setTimeout((function(){ariaEl.setAttribute("aria-live",priority);labelEl.removeAttribute(ARIA_LIVE_LABEL_TEXT_ATTR);labelEl.textContent=labelText}),ARIA_LIVE_DELAY_MS)}
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var SURFACE_SELECTOR=snackbar_constants_strings.SURFACE_SELECTOR,LABEL_SELECTOR=snackbar_constants_strings.LABEL_SELECTOR,ACTION_SELECTOR=snackbar_constants_strings.ACTION_SELECTOR,DISMISS_SELECTOR=snackbar_constants_strings.DISMISS_SELECTOR,OPENING_EVENT=snackbar_constants_strings.OPENING_EVENT,OPENED_EVENT=snackbar_constants_strings.OPENED_EVENT,CLOSING_EVENT=snackbar_constants_strings.CLOSING_EVENT,CLOSED_EVENT=snackbar_constants_strings.CLOSED_EVENT;var MDCSnackbar=function(_super){__extends(MDCSnackbar,_super);function MDCSnackbar(){return _super!==null&&_super.apply(this,arguments)||this}MDCSnackbar.attachTo=function(root){return new MDCSnackbar(root)};MDCSnackbar.prototype.initialize=function(announcerFactory){if(announcerFactory===void 0){announcerFactory=function(){return util_announce}}this.announce_=announcerFactory()};MDCSnackbar.prototype.initialSyncWithDOM=function(){var _this=this;this.surfaceEl_=this.root.querySelector(SURFACE_SELECTOR);this.labelEl_=this.root.querySelector(LABEL_SELECTOR);this.actionEl_=this.root.querySelector(ACTION_SELECTOR);this.handleKeyDown_=function(evt){return _this.foundation.handleKeyDown(evt)};this.handleSurfaceClick_=function(evt){var target=evt.target;if(_this.isActionButton_(target)){_this.foundation.handleActionButtonClick(evt)}else if(_this.isActionIcon_(target)){_this.foundation.handleActionIconClick(evt)}};this.registerKeyDownHandler_(this.handleKeyDown_);this.registerSurfaceClickHandler_(this.handleSurfaceClick_)};MDCSnackbar.prototype.destroy=function(){_super.prototype.destroy.call(this);this.deregisterKeyDownHandler_(this.handleKeyDown_);this.deregisterSurfaceClickHandler_(this.handleSurfaceClick_)};MDCSnackbar.prototype.open=function(){this.foundation.open()};MDCSnackbar.prototype.close=function(reason){if(reason===void 0){reason=""}this.foundation.close(reason)};MDCSnackbar.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClass:function(className){return _this.root.classList.add(className)},announce:function(){return _this.announce_(_this.labelEl_)},notifyClosed:function(reason){return _this.emit(CLOSED_EVENT,reason?{reason:reason}:{})},notifyClosing:function(reason){return _this.emit(CLOSING_EVENT,reason?{reason:reason}:{})},notifyOpened:function(){return _this.emit(OPENED_EVENT,{})},notifyOpening:function(){return _this.emit(OPENING_EVENT,{})},removeClass:function(className){return _this.root.classList.remove(className)}};return new MDCSnackbarFoundation(adapter)};Object.defineProperty(MDCSnackbar.prototype,"timeoutMs",{get:function(){return this.foundation.getTimeoutMs()},set:function(timeoutMs){this.foundation.setTimeoutMs(timeoutMs)},enumerable:true,configurable:true});Object.defineProperty(MDCSnackbar.prototype,"closeOnEscape",{get:function(){return this.foundation.getCloseOnEscape()},set:function(closeOnEscape){this.foundation.setCloseOnEscape(closeOnEscape)},enumerable:true,configurable:true});Object.defineProperty(MDCSnackbar.prototype,"isOpen",{get:function(){return this.foundation.isOpen()},enumerable:true,configurable:true});Object.defineProperty(MDCSnackbar.prototype,"labelText",{get:function(){return this.labelEl_.textContent},set:function(labelText){this.labelEl_.textContent=labelText},enumerable:true,configurable:true});Object.defineProperty(MDCSnackbar.prototype,"actionButtonText",{get:function(){return this.actionEl_.textContent},set:function(actionButtonText){this.actionEl_.textContent=actionButtonText},enumerable:true,configurable:true});MDCSnackbar.prototype.registerKeyDownHandler_=function(handler){this.listen("keydown",handler)};MDCSnackbar.prototype.deregisterKeyDownHandler_=function(handler){this.unlisten("keydown",handler)};MDCSnackbar.prototype.registerSurfaceClickHandler_=function(handler){this.surfaceEl_.addEventListener("click",handler)};MDCSnackbar.prototype.deregisterSurfaceClickHandler_=function(handler){this.surfaceEl_.removeEventListener("click",handler)};MDCSnackbar.prototype.isActionButton_=function(target){return Boolean(closest(target,ACTION_SELECTOR))};MDCSnackbar.prototype.isActionIcon_=function(target){return Boolean(closest(target,DISMISS_SELECTOR))};return MDCSnackbar}(MDCComponent);function MBSnackbar_init(elem,dotnetReference,timeoutMs){if(!elem){return}elem._snackbar=new MDCSnackbar(elem);elem._snackbar.listen("MDCSnackbar:closed",(function(r){dotnetReference.invokeMethodAsync("Closed",r)}));elem._snackbar.timeoutMs=timeoutMs;elem._snackbar.open()}
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var switch_constants_cssClasses={CHECKED:"mdc-switch--checked",DISABLED:"mdc-switch--disabled"};var switch_constants_strings={ARIA_CHECKED_ATTR:"aria-checked",NATIVE_CONTROL_SELECTOR:".mdc-switch__native-control",RIPPLE_SURFACE_SELECTOR:".mdc-switch__thumb-underlay"};
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCSwitchFoundation=function(_super){__extends(MDCSwitchFoundation,_super);function MDCSwitchFoundation(adapter){return _super.call(this,__assign(__assign({},MDCSwitchFoundation.defaultAdapter),adapter))||this}Object.defineProperty(MDCSwitchFoundation,"strings",{get:function(){return switch_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCSwitchFoundation,"cssClasses",{get:function(){return switch_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCSwitchFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},removeClass:function(){return undefined},setNativeControlChecked:function(){return undefined},setNativeControlDisabled:function(){return undefined},setNativeControlAttr:function(){return undefined}}},enumerable:true,configurable:true});MDCSwitchFoundation.prototype.setChecked=function(checked){this.adapter.setNativeControlChecked(checked);this.updateAriaChecked_(checked);this.updateCheckedStyling_(checked)};MDCSwitchFoundation.prototype.setDisabled=function(disabled){this.adapter.setNativeControlDisabled(disabled);if(disabled){this.adapter.addClass(switch_constants_cssClasses.DISABLED)}else{this.adapter.removeClass(switch_constants_cssClasses.DISABLED)}};MDCSwitchFoundation.prototype.handleChange=function(evt){var nativeControl=evt.target;this.updateAriaChecked_(nativeControl.checked);this.updateCheckedStyling_(nativeControl.checked)};MDCSwitchFoundation.prototype.updateCheckedStyling_=function(checked){if(checked){this.adapter.addClass(switch_constants_cssClasses.CHECKED)}else{this.adapter.removeClass(switch_constants_cssClasses.CHECKED)}};MDCSwitchFoundation.prototype.updateAriaChecked_=function(checked){this.adapter.setNativeControlAttr(switch_constants_strings.ARIA_CHECKED_ATTR,""+!!checked)};return MDCSwitchFoundation}(MDCFoundation);const switch_foundation=null&&MDCSwitchFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCSwitch=function(_super){__extends(MDCSwitch,_super);function MDCSwitch(){var _this=_super!==null&&_super.apply(this,arguments)||this;_this.ripple_=_this.createRipple_();return _this}MDCSwitch.attachTo=function(root){return new MDCSwitch(root)};MDCSwitch.prototype.destroy=function(){_super.prototype.destroy.call(this);this.ripple_.destroy();this.nativeControl_.removeEventListener("change",this.changeHandler_)};MDCSwitch.prototype.initialSyncWithDOM=function(){var _this=this;this.changeHandler_=function(){var _a;var args=[];for(var _i=0;_i<arguments.length;_i++){args[_i]=arguments[_i]}return(_a=_this.foundation).handleChange.apply(_a,__spread(args))};this.nativeControl_.addEventListener("change",this.changeHandler_);this.checked=this.checked};MDCSwitch.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClass:function(className){return _this.root.classList.add(className)},removeClass:function(className){return _this.root.classList.remove(className)},setNativeControlChecked:function(checked){return _this.nativeControl_.checked=checked},setNativeControlDisabled:function(disabled){return _this.nativeControl_.disabled=disabled},setNativeControlAttr:function(attr,value){return _this.nativeControl_.setAttribute(attr,value)}};return new MDCSwitchFoundation(adapter)};Object.defineProperty(MDCSwitch.prototype,"ripple",{get:function(){return this.ripple_},enumerable:true,configurable:true});Object.defineProperty(MDCSwitch.prototype,"checked",{get:function(){return this.nativeControl_.checked},set:function(checked){this.foundation.setChecked(checked)},enumerable:true,configurable:true});Object.defineProperty(MDCSwitch.prototype,"disabled",{get:function(){return this.nativeControl_.disabled},set:function(disabled){this.foundation.setDisabled(disabled)},enumerable:true,configurable:true});MDCSwitch.prototype.createRipple_=function(){var _this=this;var RIPPLE_SURFACE_SELECTOR=MDCSwitchFoundation.strings.RIPPLE_SURFACE_SELECTOR;var rippleSurface=this.root.querySelector(RIPPLE_SURFACE_SELECTOR);var adapter=__assign(__assign({},MDCRipple.createAdapter(this)),{addClass:function(className){return rippleSurface.classList.add(className)},computeBoundingRect:function(){return rippleSurface.getBoundingClientRect()},deregisterInteractionHandler:function(evtType,handler){_this.nativeControl_.removeEventListener(evtType,handler,applyPassive())},isSurfaceActive:function(){return matches(_this.nativeControl_,":active")},isUnbounded:function(){return true},registerInteractionHandler:function(evtType,handler){_this.nativeControl_.addEventListener(evtType,handler,applyPassive())},removeClass:function(className){rippleSurface.classList.remove(className)},updateCssVariable:function(varName,value){rippleSurface.style.setProperty(varName,value)}});return new MDCRipple(this.root,new MDCRippleFoundation(adapter))};Object.defineProperty(MDCSwitch.prototype,"nativeControl_",{get:function(){var NATIVE_CONTROL_SELECTOR=MDCSwitchFoundation.strings.NATIVE_CONTROL_SELECTOR;return this.root.querySelector(NATIVE_CONTROL_SELECTOR)},enumerable:true,configurable:true});return MDCSwitch}(MDCComponent);function MBSwitch_init(elem,checked){if(!elem){return}elem._switch=MDCSwitch.attachTo(elem);elem._switch.checked=checked}function MBSwitch_setChecked(elem,checked){if(!elem){return}elem._switch.checked=checked}function MBSwitch_setDisabled(elem,disabled){if(!elem){return}elem._switch.disabled=disabled}
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var tab_scroller_constants_cssClasses={ANIMATING:"mdc-tab-scroller--animating",SCROLL_AREA_SCROLL:"mdc-tab-scroller__scroll-area--scroll",SCROLL_TEST:"mdc-tab-scroller__test"};var tab_scroller_constants_strings={AREA_SELECTOR:".mdc-tab-scroller__scroll-area",CONTENT_SELECTOR:".mdc-tab-scroller__scroll-content"};
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCTabScrollerRTL=function(){function MDCTabScrollerRTL(adapter){this.adapter=adapter}return MDCTabScrollerRTL}();const rtl_scroller=null&&MDCTabScrollerRTL;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCTabScrollerRTLDefault=function(_super){__extends(MDCTabScrollerRTLDefault,_super);function MDCTabScrollerRTLDefault(){return _super!==null&&_super.apply(this,arguments)||this}MDCTabScrollerRTLDefault.prototype.getScrollPositionRTL=function(){var currentScrollLeft=this.adapter.getScrollAreaScrollLeft();var right=this.calculateScrollEdges_().right;return Math.round(right-currentScrollLeft)};MDCTabScrollerRTLDefault.prototype.scrollToRTL=function(scrollX){var edges=this.calculateScrollEdges_();var currentScrollLeft=this.adapter.getScrollAreaScrollLeft();var clampedScrollLeft=this.clampScrollValue_(edges.right-scrollX);return{finalScrollPosition:clampedScrollLeft,scrollDelta:clampedScrollLeft-currentScrollLeft}};MDCTabScrollerRTLDefault.prototype.incrementScrollRTL=function(scrollX){var currentScrollLeft=this.adapter.getScrollAreaScrollLeft();var clampedScrollLeft=this.clampScrollValue_(currentScrollLeft-scrollX);return{finalScrollPosition:clampedScrollLeft,scrollDelta:clampedScrollLeft-currentScrollLeft}};MDCTabScrollerRTLDefault.prototype.getAnimatingScrollPosition=function(scrollX){return scrollX};MDCTabScrollerRTLDefault.prototype.calculateScrollEdges_=function(){var contentWidth=this.adapter.getScrollContentOffsetWidth();var rootWidth=this.adapter.getScrollAreaOffsetWidth();return{left:0,right:contentWidth-rootWidth}};MDCTabScrollerRTLDefault.prototype.clampScrollValue_=function(scrollX){var edges=this.calculateScrollEdges_();return Math.min(Math.max(edges.left,scrollX),edges.right)};return MDCTabScrollerRTLDefault}(MDCTabScrollerRTL);const rtl_default_scroller=null&&MDCTabScrollerRTLDefault;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCTabScrollerRTLNegative=function(_super){__extends(MDCTabScrollerRTLNegative,_super);function MDCTabScrollerRTLNegative(){return _super!==null&&_super.apply(this,arguments)||this}MDCTabScrollerRTLNegative.prototype.getScrollPositionRTL=function(translateX){var currentScrollLeft=this.adapter.getScrollAreaScrollLeft();return Math.round(translateX-currentScrollLeft)};MDCTabScrollerRTLNegative.prototype.scrollToRTL=function(scrollX){var currentScrollLeft=this.adapter.getScrollAreaScrollLeft();var clampedScrollLeft=this.clampScrollValue_(-scrollX);return{finalScrollPosition:clampedScrollLeft,scrollDelta:clampedScrollLeft-currentScrollLeft}};MDCTabScrollerRTLNegative.prototype.incrementScrollRTL=function(scrollX){var currentScrollLeft=this.adapter.getScrollAreaScrollLeft();var clampedScrollLeft=this.clampScrollValue_(currentScrollLeft-scrollX);return{finalScrollPosition:clampedScrollLeft,scrollDelta:clampedScrollLeft-currentScrollLeft}};MDCTabScrollerRTLNegative.prototype.getAnimatingScrollPosition=function(scrollX,translateX){return scrollX-translateX};MDCTabScrollerRTLNegative.prototype.calculateScrollEdges_=function(){var contentWidth=this.adapter.getScrollContentOffsetWidth();var rootWidth=this.adapter.getScrollAreaOffsetWidth();return{left:rootWidth-contentWidth,right:0}};MDCTabScrollerRTLNegative.prototype.clampScrollValue_=function(scrollX){var edges=this.calculateScrollEdges_();return Math.max(Math.min(edges.right,scrollX),edges.left)};return MDCTabScrollerRTLNegative}(MDCTabScrollerRTL);const rtl_negative_scroller=null&&MDCTabScrollerRTLNegative;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCTabScrollerRTLReverse=function(_super){__extends(MDCTabScrollerRTLReverse,_super);function MDCTabScrollerRTLReverse(){return _super!==null&&_super.apply(this,arguments)||this}MDCTabScrollerRTLReverse.prototype.getScrollPositionRTL=function(translateX){var currentScrollLeft=this.adapter.getScrollAreaScrollLeft();return Math.round(currentScrollLeft-translateX)};MDCTabScrollerRTLReverse.prototype.scrollToRTL=function(scrollX){var currentScrollLeft=this.adapter.getScrollAreaScrollLeft();var clampedScrollLeft=this.clampScrollValue_(scrollX);return{finalScrollPosition:clampedScrollLeft,scrollDelta:currentScrollLeft-clampedScrollLeft}};MDCTabScrollerRTLReverse.prototype.incrementScrollRTL=function(scrollX){var currentScrollLeft=this.adapter.getScrollAreaScrollLeft();var clampedScrollLeft=this.clampScrollValue_(currentScrollLeft+scrollX);return{finalScrollPosition:clampedScrollLeft,scrollDelta:currentScrollLeft-clampedScrollLeft}};MDCTabScrollerRTLReverse.prototype.getAnimatingScrollPosition=function(scrollX,translateX){return scrollX+translateX};MDCTabScrollerRTLReverse.prototype.calculateScrollEdges_=function(){var contentWidth=this.adapter.getScrollContentOffsetWidth();var rootWidth=this.adapter.getScrollAreaOffsetWidth();return{left:contentWidth-rootWidth,right:0}};MDCTabScrollerRTLReverse.prototype.clampScrollValue_=function(scrollX){var edges=this.calculateScrollEdges_();return Math.min(Math.max(edges.right,scrollX),edges.left)};return MDCTabScrollerRTLReverse}(MDCTabScrollerRTL);const rtl_reverse_scroller=null&&MDCTabScrollerRTLReverse;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCTabScrollerFoundation=function(_super){__extends(MDCTabScrollerFoundation,_super);function MDCTabScrollerFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCTabScrollerFoundation.defaultAdapter),adapter))||this;_this.isAnimating_=false;return _this}Object.defineProperty(MDCTabScrollerFoundation,"cssClasses",{get:function(){return tab_scroller_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCTabScrollerFoundation,"strings",{get:function(){return tab_scroller_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCTabScrollerFoundation,"defaultAdapter",{get:function(){return{eventTargetMatchesSelector:function(){return false},addClass:function(){return undefined},removeClass:function(){return undefined},addScrollAreaClass:function(){return undefined},setScrollAreaStyleProperty:function(){return undefined},setScrollContentStyleProperty:function(){return undefined},getScrollContentStyleValue:function(){return""},setScrollAreaScrollLeft:function(){return undefined},getScrollAreaScrollLeft:function(){return 0},getScrollContentOffsetWidth:function(){return 0},getScrollAreaOffsetWidth:function(){return 0},computeScrollAreaClientRect:function(){return{top:0,right:0,bottom:0,left:0,width:0,height:0}},computeScrollContentClientRect:function(){return{top:0,right:0,bottom:0,left:0,width:0,height:0}},computeHorizontalScrollbarHeight:function(){return 0}}},enumerable:true,configurable:true});MDCTabScrollerFoundation.prototype.init=function(){var horizontalScrollbarHeight=this.adapter.computeHorizontalScrollbarHeight();this.adapter.setScrollAreaStyleProperty("margin-bottom",-horizontalScrollbarHeight+"px");this.adapter.addScrollAreaClass(MDCTabScrollerFoundation.cssClasses.SCROLL_AREA_SCROLL)};MDCTabScrollerFoundation.prototype.getScrollPosition=function(){if(this.isRTL_()){return this.computeCurrentScrollPositionRTL_()}var currentTranslateX=this.calculateCurrentTranslateX_();var scrollLeft=this.adapter.getScrollAreaScrollLeft();return scrollLeft-currentTranslateX};MDCTabScrollerFoundation.prototype.handleInteraction=function(){if(!this.isAnimating_){return}this.stopScrollAnimation_()};MDCTabScrollerFoundation.prototype.handleTransitionEnd=function(evt){var evtTarget=evt.target;if(!this.isAnimating_||!this.adapter.eventTargetMatchesSelector(evtTarget,MDCTabScrollerFoundation.strings.CONTENT_SELECTOR)){return}this.isAnimating_=false;this.adapter.removeClass(MDCTabScrollerFoundation.cssClasses.ANIMATING)};MDCTabScrollerFoundation.prototype.incrementScroll=function(scrollXIncrement){if(scrollXIncrement===0){return}this.animate_(this.getIncrementScrollOperation_(scrollXIncrement))};MDCTabScrollerFoundation.prototype.incrementScrollImmediate=function(scrollXIncrement){if(scrollXIncrement===0){return}var operation=this.getIncrementScrollOperation_(scrollXIncrement);if(operation.scrollDelta===0){return}this.stopScrollAnimation_();this.adapter.setScrollAreaScrollLeft(operation.finalScrollPosition)};MDCTabScrollerFoundation.prototype.scrollTo=function(scrollX){if(this.isRTL_()){return this.scrollToRTL_(scrollX)}this.scrollTo_(scrollX)};MDCTabScrollerFoundation.prototype.getRTLScroller=function(){if(!this.rtlScrollerInstance_){this.rtlScrollerInstance_=this.rtlScrollerFactory_()}return this.rtlScrollerInstance_};MDCTabScrollerFoundation.prototype.calculateCurrentTranslateX_=function(){var transformValue=this.adapter.getScrollContentStyleValue("transform");if(transformValue==="none"){return 0}var match=/\((.+?)\)/.exec(transformValue);if(!match){return 0}var matrixParams=match[1];var _a=__read(matrixParams.split(","),6),a=_a[0],b=_a[1],c=_a[2],d=_a[3],tx=_a[4],ty=_a[5];return parseFloat(tx)};MDCTabScrollerFoundation.prototype.clampScrollValue_=function(scrollX){var edges=this.calculateScrollEdges_();return Math.min(Math.max(edges.left,scrollX),edges.right)};MDCTabScrollerFoundation.prototype.computeCurrentScrollPositionRTL_=function(){var translateX=this.calculateCurrentTranslateX_();return this.getRTLScroller().getScrollPositionRTL(translateX)};MDCTabScrollerFoundation.prototype.calculateScrollEdges_=function(){var contentWidth=this.adapter.getScrollContentOffsetWidth();var rootWidth=this.adapter.getScrollAreaOffsetWidth();return{left:0,right:contentWidth-rootWidth}};MDCTabScrollerFoundation.prototype.scrollTo_=function(scrollX){var currentScrollX=this.getScrollPosition();var safeScrollX=this.clampScrollValue_(scrollX);var scrollDelta=safeScrollX-currentScrollX;this.animate_({finalScrollPosition:safeScrollX,scrollDelta:scrollDelta})};MDCTabScrollerFoundation.prototype.scrollToRTL_=function(scrollX){var animation=this.getRTLScroller().scrollToRTL(scrollX);this.animate_(animation)};MDCTabScrollerFoundation.prototype.getIncrementScrollOperation_=function(scrollX){if(this.isRTL_()){return this.getRTLScroller().incrementScrollRTL(scrollX)}var currentScrollX=this.getScrollPosition();var targetScrollX=scrollX+currentScrollX;var safeScrollX=this.clampScrollValue_(targetScrollX);var scrollDelta=safeScrollX-currentScrollX;return{finalScrollPosition:safeScrollX,scrollDelta:scrollDelta}};MDCTabScrollerFoundation.prototype.animate_=function(animation){var _this=this;if(animation.scrollDelta===0){return}this.stopScrollAnimation_();this.adapter.setScrollAreaScrollLeft(animation.finalScrollPosition);this.adapter.setScrollContentStyleProperty("transform","translateX("+animation.scrollDelta+"px)");this.adapter.computeScrollAreaClientRect();requestAnimationFrame((function(){_this.adapter.addClass(MDCTabScrollerFoundation.cssClasses.ANIMATING);_this.adapter.setScrollContentStyleProperty("transform","none")}));this.isAnimating_=true};MDCTabScrollerFoundation.prototype.stopScrollAnimation_=function(){this.isAnimating_=false;var currentScrollPosition=this.getAnimatingScrollPosition_();this.adapter.removeClass(MDCTabScrollerFoundation.cssClasses.ANIMATING);this.adapter.setScrollContentStyleProperty("transform","translateX(0px)");this.adapter.setScrollAreaScrollLeft(currentScrollPosition)};MDCTabScrollerFoundation.prototype.getAnimatingScrollPosition_=function(){var currentTranslateX=this.calculateCurrentTranslateX_();var scrollLeft=this.adapter.getScrollAreaScrollLeft();if(this.isRTL_()){return this.getRTLScroller().getAnimatingScrollPosition(scrollLeft,currentTranslateX)}return scrollLeft-currentTranslateX};MDCTabScrollerFoundation.prototype.rtlScrollerFactory_=function(){var initialScrollLeft=this.adapter.getScrollAreaScrollLeft();this.adapter.setScrollAreaScrollLeft(initialScrollLeft-1);var newScrollLeft=this.adapter.getScrollAreaScrollLeft();if(newScrollLeft<0){this.adapter.setScrollAreaScrollLeft(initialScrollLeft);return new MDCTabScrollerRTLNegative(this.adapter)}var rootClientRect=this.adapter.computeScrollAreaClientRect();var contentClientRect=this.adapter.computeScrollContentClientRect();var rightEdgeDelta=Math.round(contentClientRect.right-rootClientRect.right);this.adapter.setScrollAreaScrollLeft(initialScrollLeft);if(rightEdgeDelta===newScrollLeft){return new MDCTabScrollerRTLReverse(this.adapter)}return new MDCTabScrollerRTLDefault(this.adapter)};MDCTabScrollerFoundation.prototype.isRTL_=function(){return this.adapter.getScrollContentStyleValue("direction")==="rtl"};return MDCTabScrollerFoundation}(MDCFoundation);const tab_scroller_foundation=null&&MDCTabScrollerFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var horizontalScrollbarHeight_;function computeHorizontalScrollbarHeight(documentObj,shouldCacheResult){if(shouldCacheResult===void 0){shouldCacheResult=true}if(shouldCacheResult&&typeof horizontalScrollbarHeight_!=="undefined"){return horizontalScrollbarHeight_}var el=documentObj.createElement("div");el.classList.add(tab_scroller_constants_cssClasses.SCROLL_TEST);documentObj.body.appendChild(el);var horizontalScrollbarHeight=el.offsetHeight-el.clientHeight;documentObj.body.removeChild(el);if(shouldCacheResult){horizontalScrollbarHeight_=horizontalScrollbarHeight}return horizontalScrollbarHeight}
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCTabScroller=function(_super){__extends(MDCTabScroller,_super);function MDCTabScroller(){return _super!==null&&_super.apply(this,arguments)||this}MDCTabScroller.attachTo=function(root){return new MDCTabScroller(root)};MDCTabScroller.prototype.initialize=function(){this.area_=this.root.querySelector(MDCTabScrollerFoundation.strings.AREA_SELECTOR);this.content_=this.root.querySelector(MDCTabScrollerFoundation.strings.CONTENT_SELECTOR)};MDCTabScroller.prototype.initialSyncWithDOM=function(){var _this=this;this.handleInteraction_=function(){return _this.foundation.handleInteraction()};this.handleTransitionEnd_=function(evt){return _this.foundation.handleTransitionEnd(evt)};this.area_.addEventListener("wheel",this.handleInteraction_,applyPassive());this.area_.addEventListener("touchstart",this.handleInteraction_,applyPassive());this.area_.addEventListener("pointerdown",this.handleInteraction_,applyPassive());this.area_.addEventListener("mousedown",this.handleInteraction_,applyPassive());this.area_.addEventListener("keydown",this.handleInteraction_,applyPassive());this.content_.addEventListener("transitionend",this.handleTransitionEnd_)};MDCTabScroller.prototype.destroy=function(){_super.prototype.destroy.call(this);this.area_.removeEventListener("wheel",this.handleInteraction_,applyPassive());this.area_.removeEventListener("touchstart",this.handleInteraction_,applyPassive());this.area_.removeEventListener("pointerdown",this.handleInteraction_,applyPassive());this.area_.removeEventListener("mousedown",this.handleInteraction_,applyPassive());this.area_.removeEventListener("keydown",this.handleInteraction_,applyPassive());this.content_.removeEventListener("transitionend",this.handleTransitionEnd_)};MDCTabScroller.prototype.getDefaultFoundation=function(){var _this=this;var adapter={eventTargetMatchesSelector:function(evtTarget,selector){return matches(evtTarget,selector)},addClass:function(className){return _this.root.classList.add(className)},removeClass:function(className){return _this.root.classList.remove(className)},addScrollAreaClass:function(className){return _this.area_.classList.add(className)},setScrollAreaStyleProperty:function(prop,value){return _this.area_.style.setProperty(prop,value)},setScrollContentStyleProperty:function(prop,value){return _this.content_.style.setProperty(prop,value)},getScrollContentStyleValue:function(propName){return window.getComputedStyle(_this.content_).getPropertyValue(propName)},setScrollAreaScrollLeft:function(scrollX){return _this.area_.scrollLeft=scrollX},getScrollAreaScrollLeft:function(){return _this.area_.scrollLeft},getScrollContentOffsetWidth:function(){return _this.content_.offsetWidth},getScrollAreaOffsetWidth:function(){return _this.area_.offsetWidth},computeScrollAreaClientRect:function(){return _this.area_.getBoundingClientRect()},computeScrollContentClientRect:function(){return _this.content_.getBoundingClientRect()},computeHorizontalScrollbarHeight:function(){return computeHorizontalScrollbarHeight(document)}};return new MDCTabScrollerFoundation(adapter)};MDCTabScroller.prototype.getScrollPosition=function(){return this.foundation.getScrollPosition()};MDCTabScroller.prototype.getScrollContentWidth=function(){return this.content_.offsetWidth};MDCTabScroller.prototype.incrementScroll=function(scrollXIncrement){this.foundation.incrementScroll(scrollXIncrement)};MDCTabScroller.prototype.scrollTo=function(scrollX){this.foundation.scrollTo(scrollX)};return MDCTabScroller}(MDCComponent);
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var tab_indicator_constants_cssClasses={ACTIVE:"mdc-tab-indicator--active",FADE:"mdc-tab-indicator--fade",NO_TRANSITION:"mdc-tab-indicator--no-transition"};var tab_indicator_constants_strings={CONTENT_SELECTOR:".mdc-tab-indicator__content"};
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCTabIndicatorFoundation=function(_super){__extends(MDCTabIndicatorFoundation,_super);function MDCTabIndicatorFoundation(adapter){return _super.call(this,__assign(__assign({},MDCTabIndicatorFoundation.defaultAdapter),adapter))||this}Object.defineProperty(MDCTabIndicatorFoundation,"cssClasses",{get:function(){return tab_indicator_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCTabIndicatorFoundation,"strings",{get:function(){return tab_indicator_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCTabIndicatorFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},removeClass:function(){return undefined},computeContentClientRect:function(){return{top:0,right:0,bottom:0,left:0,width:0,height:0}},setContentStyleProperty:function(){return undefined}}},enumerable:true,configurable:true});MDCTabIndicatorFoundation.prototype.computeContentClientRect=function(){return this.adapter.computeContentClientRect()};return MDCTabIndicatorFoundation}(MDCFoundation);const tab_indicator_foundation=null&&MDCTabIndicatorFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCFadingTabIndicatorFoundation=function(_super){__extends(MDCFadingTabIndicatorFoundation,_super);function MDCFadingTabIndicatorFoundation(){return _super!==null&&_super.apply(this,arguments)||this}MDCFadingTabIndicatorFoundation.prototype.activate=function(){this.adapter.addClass(MDCTabIndicatorFoundation.cssClasses.ACTIVE)};MDCFadingTabIndicatorFoundation.prototype.deactivate=function(){this.adapter.removeClass(MDCTabIndicatorFoundation.cssClasses.ACTIVE)};return MDCFadingTabIndicatorFoundation}(MDCTabIndicatorFoundation);const fading_foundation=null&&MDCFadingTabIndicatorFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCSlidingTabIndicatorFoundation=function(_super){__extends(MDCSlidingTabIndicatorFoundation,_super);function MDCSlidingTabIndicatorFoundation(){return _super!==null&&_super.apply(this,arguments)||this}MDCSlidingTabIndicatorFoundation.prototype.activate=function(previousIndicatorClientRect){if(!previousIndicatorClientRect){this.adapter.addClass(MDCTabIndicatorFoundation.cssClasses.ACTIVE);return}var currentClientRect=this.computeContentClientRect();var widthDelta=previousIndicatorClientRect.width/currentClientRect.width;var xPosition=previousIndicatorClientRect.left-currentClientRect.left;this.adapter.addClass(MDCTabIndicatorFoundation.cssClasses.NO_TRANSITION);this.adapter.setContentStyleProperty("transform","translateX("+xPosition+"px) scaleX("+widthDelta+")");this.computeContentClientRect();this.adapter.removeClass(MDCTabIndicatorFoundation.cssClasses.NO_TRANSITION);this.adapter.addClass(MDCTabIndicatorFoundation.cssClasses.ACTIVE);this.adapter.setContentStyleProperty("transform","")};MDCSlidingTabIndicatorFoundation.prototype.deactivate=function(){this.adapter.removeClass(MDCTabIndicatorFoundation.cssClasses.ACTIVE)};return MDCSlidingTabIndicatorFoundation}(MDCTabIndicatorFoundation);const sliding_foundation=null&&MDCSlidingTabIndicatorFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCTabIndicator=function(_super){__extends(MDCTabIndicator,_super);function MDCTabIndicator(){return _super!==null&&_super.apply(this,arguments)||this}MDCTabIndicator.attachTo=function(root){return new MDCTabIndicator(root)};MDCTabIndicator.prototype.initialize=function(){this.content_=this.root.querySelector(MDCTabIndicatorFoundation.strings.CONTENT_SELECTOR)};MDCTabIndicator.prototype.computeContentClientRect=function(){return this.foundation.computeContentClientRect()};MDCTabIndicator.prototype.getDefaultFoundation=function(){var _this=this;var adapter={addClass:function(className){return _this.root.classList.add(className)},removeClass:function(className){return _this.root.classList.remove(className)},computeContentClientRect:function(){return _this.content_.getBoundingClientRect()},setContentStyleProperty:function(prop,value){return _this.content_.style.setProperty(prop,value)}};if(this.root.classList.contains(MDCTabIndicatorFoundation.cssClasses.FADE)){return new MDCFadingTabIndicatorFoundation(adapter)}return new MDCSlidingTabIndicatorFoundation(adapter)};MDCTabIndicator.prototype.activate=function(previousIndicatorClientRect){this.foundation.activate(previousIndicatorClientRect)};MDCTabIndicator.prototype.deactivate=function(){this.foundation.deactivate()};return MDCTabIndicator}(MDCComponent);
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var tab_constants_cssClasses={ACTIVE:"mdc-tab--active"};var tab_constants_strings={ARIA_SELECTED:"aria-selected",CONTENT_SELECTOR:".mdc-tab__content",INTERACTED_EVENT:"MDCTab:interacted",RIPPLE_SELECTOR:".mdc-tab__ripple",TABINDEX:"tabIndex",TAB_INDICATOR_SELECTOR:".mdc-tab-indicator"};
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCTabFoundation=function(_super){__extends(MDCTabFoundation,_super);function MDCTabFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCTabFoundation.defaultAdapter),adapter))||this;_this.focusOnActivate_=true;return _this}Object.defineProperty(MDCTabFoundation,"cssClasses",{get:function(){return tab_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCTabFoundation,"strings",{get:function(){return tab_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCTabFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},removeClass:function(){return undefined},hasClass:function(){return false},setAttr:function(){return undefined},activateIndicator:function(){return undefined},deactivateIndicator:function(){return undefined},notifyInteracted:function(){return undefined},getOffsetLeft:function(){return 0},getOffsetWidth:function(){return 0},getContentOffsetLeft:function(){return 0},getContentOffsetWidth:function(){return 0},focus:function(){return undefined}}},enumerable:true,configurable:true});MDCTabFoundation.prototype.handleClick=function(){this.adapter.notifyInteracted()};MDCTabFoundation.prototype.isActive=function(){return this.adapter.hasClass(tab_constants_cssClasses.ACTIVE)};MDCTabFoundation.prototype.setFocusOnActivate=function(focusOnActivate){this.focusOnActivate_=focusOnActivate};MDCTabFoundation.prototype.activate=function(previousIndicatorClientRect){this.adapter.addClass(tab_constants_cssClasses.ACTIVE);this.adapter.setAttr(tab_constants_strings.ARIA_SELECTED,"true");this.adapter.setAttr(tab_constants_strings.TABINDEX,"0");this.adapter.activateIndicator(previousIndicatorClientRect);if(this.focusOnActivate_){this.adapter.focus()}};MDCTabFoundation.prototype.deactivate=function(){if(!this.isActive()){return}this.adapter.removeClass(tab_constants_cssClasses.ACTIVE);this.adapter.setAttr(tab_constants_strings.ARIA_SELECTED,"false");this.adapter.setAttr(tab_constants_strings.TABINDEX,"-1");this.adapter.deactivateIndicator()};MDCTabFoundation.prototype.computeDimensions=function(){var rootWidth=this.adapter.getOffsetWidth();var rootLeft=this.adapter.getOffsetLeft();var contentWidth=this.adapter.getContentOffsetWidth();var contentLeft=this.adapter.getContentOffsetLeft();return{contentLeft:rootLeft+contentLeft,contentRight:rootLeft+contentLeft+contentWidth,rootLeft:rootLeft,rootRight:rootLeft+rootWidth}};return MDCTabFoundation}(MDCFoundation);const tab_foundation=null&&MDCTabFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCTab=function(_super){__extends(MDCTab,_super);function MDCTab(){return _super!==null&&_super.apply(this,arguments)||this}MDCTab.attachTo=function(root){return new MDCTab(root)};MDCTab.prototype.initialize=function(rippleFactory,tabIndicatorFactory){if(rippleFactory===void 0){rippleFactory=function(el,foundation){return new MDCRipple(el,foundation)}}if(tabIndicatorFactory===void 0){tabIndicatorFactory=function(el){return new MDCTabIndicator(el)}}this.id=this.root.id;var rippleSurface=this.root.querySelector(MDCTabFoundation.strings.RIPPLE_SELECTOR);var rippleAdapter=__assign(__assign({},MDCRipple.createAdapter(this)),{addClass:function(className){return rippleSurface.classList.add(className)},removeClass:function(className){return rippleSurface.classList.remove(className)},updateCssVariable:function(varName,value){return rippleSurface.style.setProperty(varName,value)}});var rippleFoundation=new MDCRippleFoundation(rippleAdapter);this.ripple_=rippleFactory(this.root,rippleFoundation);var tabIndicatorElement=this.root.querySelector(MDCTabFoundation.strings.TAB_INDICATOR_SELECTOR);this.tabIndicator_=tabIndicatorFactory(tabIndicatorElement);this.content_=this.root.querySelector(MDCTabFoundation.strings.CONTENT_SELECTOR)};MDCTab.prototype.initialSyncWithDOM=function(){var _this=this;this.handleClick_=function(){return _this.foundation.handleClick()};this.listen("click",this.handleClick_)};MDCTab.prototype.destroy=function(){this.unlisten("click",this.handleClick_);this.ripple_.destroy();_super.prototype.destroy.call(this)};MDCTab.prototype.getDefaultFoundation=function(){var _this=this;var adapter={setAttr:function(attr,value){return _this.root.setAttribute(attr,value)},addClass:function(className){return _this.root.classList.add(className)},removeClass:function(className){return _this.root.classList.remove(className)},hasClass:function(className){return _this.root.classList.contains(className)},activateIndicator:function(previousIndicatorClientRect){return _this.tabIndicator_.activate(previousIndicatorClientRect)},deactivateIndicator:function(){return _this.tabIndicator_.deactivate()},notifyInteracted:function(){return _this.emit(MDCTabFoundation.strings.INTERACTED_EVENT,{tabId:_this.id},true)},getOffsetLeft:function(){return _this.root.offsetLeft},getOffsetWidth:function(){return _this.root.offsetWidth},getContentOffsetLeft:function(){return _this.content_.offsetLeft},getContentOffsetWidth:function(){return _this.content_.offsetWidth},focus:function(){return _this.root.focus()}};return new MDCTabFoundation(adapter)};Object.defineProperty(MDCTab.prototype,"active",{get:function(){return this.foundation.isActive()},enumerable:true,configurable:true});Object.defineProperty(MDCTab.prototype,"focusOnActivate",{set:function(focusOnActivate){this.foundation.setFocusOnActivate(focusOnActivate)},enumerable:true,configurable:true});MDCTab.prototype.activate=function(computeIndicatorClientRect){this.foundation.activate(computeIndicatorClientRect)};MDCTab.prototype.deactivate=function(){this.foundation.deactivate()};MDCTab.prototype.computeIndicatorClientRect=function(){return this.tabIndicator_.computeContentClientRect()};MDCTab.prototype.computeDimensions=function(){return this.foundation.computeDimensions()};MDCTab.prototype.focus=function(){this.root.focus()};return MDCTab}(MDCComponent);
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var tab_bar_constants_strings={ARROW_LEFT_KEY:"ArrowLeft",ARROW_RIGHT_KEY:"ArrowRight",END_KEY:"End",ENTER_KEY:"Enter",HOME_KEY:"Home",SPACE_KEY:"Space",TAB_ACTIVATED_EVENT:"MDCTabBar:activated",TAB_SCROLLER_SELECTOR:".mdc-tab-scroller",TAB_SELECTOR:".mdc-tab"};var tab_bar_constants_numbers={ARROW_LEFT_KEYCODE:37,ARROW_RIGHT_KEYCODE:39,END_KEYCODE:35,ENTER_KEYCODE:13,EXTRA_SCROLL_AMOUNT:20,HOME_KEYCODE:36,SPACE_KEYCODE:32};
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var ACCEPTABLE_KEYS=new Set;ACCEPTABLE_KEYS.add(tab_bar_constants_strings.ARROW_LEFT_KEY);ACCEPTABLE_KEYS.add(tab_bar_constants_strings.ARROW_RIGHT_KEY);ACCEPTABLE_KEYS.add(tab_bar_constants_strings.END_KEY);ACCEPTABLE_KEYS.add(tab_bar_constants_strings.HOME_KEY);ACCEPTABLE_KEYS.add(tab_bar_constants_strings.ENTER_KEY);ACCEPTABLE_KEYS.add(tab_bar_constants_strings.SPACE_KEY);var KEYCODE_MAP=new Map;KEYCODE_MAP.set(tab_bar_constants_numbers.ARROW_LEFT_KEYCODE,tab_bar_constants_strings.ARROW_LEFT_KEY);KEYCODE_MAP.set(tab_bar_constants_numbers.ARROW_RIGHT_KEYCODE,tab_bar_constants_strings.ARROW_RIGHT_KEY);KEYCODE_MAP.set(tab_bar_constants_numbers.END_KEYCODE,tab_bar_constants_strings.END_KEY);KEYCODE_MAP.set(tab_bar_constants_numbers.HOME_KEYCODE,tab_bar_constants_strings.HOME_KEY);KEYCODE_MAP.set(tab_bar_constants_numbers.ENTER_KEYCODE,tab_bar_constants_strings.ENTER_KEY);KEYCODE_MAP.set(tab_bar_constants_numbers.SPACE_KEYCODE,tab_bar_constants_strings.SPACE_KEY);var MDCTabBarFoundation=function(_super){__extends(MDCTabBarFoundation,_super);function MDCTabBarFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCTabBarFoundation.defaultAdapter),adapter))||this;_this.useAutomaticActivation_=false;return _this}Object.defineProperty(MDCTabBarFoundation,"strings",{get:function(){return tab_bar_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCTabBarFoundation,"numbers",{get:function(){return tab_bar_constants_numbers},enumerable:true,configurable:true});Object.defineProperty(MDCTabBarFoundation,"defaultAdapter",{get:function(){return{scrollTo:function(){return undefined},incrementScroll:function(){return undefined},getScrollPosition:function(){return 0},getScrollContentWidth:function(){return 0},getOffsetWidth:function(){return 0},isRTL:function(){return false},setActiveTab:function(){return undefined},activateTabAtIndex:function(){return undefined},deactivateTabAtIndex:function(){return undefined},focusTabAtIndex:function(){return undefined},getTabIndicatorClientRectAtIndex:function(){return{top:0,right:0,bottom:0,left:0,width:0,height:0}},getTabDimensionsAtIndex:function(){return{rootLeft:0,rootRight:0,contentLeft:0,contentRight:0}},getPreviousActiveTabIndex:function(){return-1},getFocusedTabIndex:function(){return-1},getIndexOfTabById:function(){return-1},getTabListLength:function(){return 0},notifyTabActivated:function(){return undefined}}},enumerable:true,configurable:true});MDCTabBarFoundation.prototype.setUseAutomaticActivation=function(useAutomaticActivation){this.useAutomaticActivation_=useAutomaticActivation};MDCTabBarFoundation.prototype.activateTab=function(index){var previousActiveIndex=this.adapter.getPreviousActiveTabIndex();if(!this.indexIsInRange_(index)||index===previousActiveIndex){return}var previousClientRect;if(previousActiveIndex!==-1){this.adapter.deactivateTabAtIndex(previousActiveIndex);previousClientRect=this.adapter.getTabIndicatorClientRectAtIndex(previousActiveIndex)}this.adapter.activateTabAtIndex(index,previousClientRect);this.scrollIntoView(index);this.adapter.notifyTabActivated(index)};MDCTabBarFoundation.prototype.handleKeyDown=function(evt){var key=this.getKeyFromEvent_(evt);if(key===undefined){return}if(!this.isActivationKey_(key)){evt.preventDefault()}if(this.useAutomaticActivation_){if(this.isActivationKey_(key)){return}var index=this.determineTargetFromKey_(this.adapter.getPreviousActiveTabIndex(),key);this.adapter.setActiveTab(index);this.scrollIntoView(index)}else{var focusedTabIndex=this.adapter.getFocusedTabIndex();if(this.isActivationKey_(key)){this.adapter.setActiveTab(focusedTabIndex)}else{var index=this.determineTargetFromKey_(focusedTabIndex,key);this.adapter.focusTabAtIndex(index);this.scrollIntoView(index)}}};MDCTabBarFoundation.prototype.handleTabInteraction=function(evt){this.adapter.setActiveTab(this.adapter.getIndexOfTabById(evt.detail.tabId))};MDCTabBarFoundation.prototype.scrollIntoView=function(index){if(!this.indexIsInRange_(index)){return}if(index===0){return this.adapter.scrollTo(0)}if(index===this.adapter.getTabListLength()-1){return this.adapter.scrollTo(this.adapter.getScrollContentWidth())}if(this.isRTL_()){return this.scrollIntoViewRTL_(index)}this.scrollIntoView_(index)};MDCTabBarFoundation.prototype.determineTargetFromKey_=function(origin,key){var isRTL=this.isRTL_();var maxIndex=this.adapter.getTabListLength()-1;var shouldGoToEnd=key===tab_bar_constants_strings.END_KEY;var shouldDecrement=key===tab_bar_constants_strings.ARROW_LEFT_KEY&&!isRTL||key===tab_bar_constants_strings.ARROW_RIGHT_KEY&&isRTL;var shouldIncrement=key===tab_bar_constants_strings.ARROW_RIGHT_KEY&&!isRTL||key===tab_bar_constants_strings.ARROW_LEFT_KEY&&isRTL;var index=origin;if(shouldGoToEnd){index=maxIndex}else if(shouldDecrement){index-=1}else if(shouldIncrement){index+=1}else{index=0}if(index<0){index=maxIndex}else if(index>maxIndex){index=0}return index};MDCTabBarFoundation.prototype.calculateScrollIncrement_=function(index,nextIndex,scrollPosition,barWidth){var nextTabDimensions=this.adapter.getTabDimensionsAtIndex(nextIndex);var relativeContentLeft=nextTabDimensions.contentLeft-scrollPosition-barWidth;var relativeContentRight=nextTabDimensions.contentRight-scrollPosition;var leftIncrement=relativeContentRight-tab_bar_constants_numbers.EXTRA_SCROLL_AMOUNT;var rightIncrement=relativeContentLeft+tab_bar_constants_numbers.EXTRA_SCROLL_AMOUNT;if(nextIndex<index){return Math.min(leftIncrement,0)}return Math.max(rightIncrement,0)};MDCTabBarFoundation.prototype.calculateScrollIncrementRTL_=function(index,nextIndex,scrollPosition,barWidth,scrollContentWidth){var nextTabDimensions=this.adapter.getTabDimensionsAtIndex(nextIndex);var relativeContentLeft=scrollContentWidth-nextTabDimensions.contentLeft-scrollPosition;var relativeContentRight=scrollContentWidth-nextTabDimensions.contentRight-scrollPosition-barWidth;var leftIncrement=relativeContentRight+tab_bar_constants_numbers.EXTRA_SCROLL_AMOUNT;var rightIncrement=relativeContentLeft-tab_bar_constants_numbers.EXTRA_SCROLL_AMOUNT;if(nextIndex>index){return Math.max(leftIncrement,0)}return Math.min(rightIncrement,0)};MDCTabBarFoundation.prototype.findAdjacentTabIndexClosestToEdge_=function(index,tabDimensions,scrollPosition,barWidth){var relativeRootLeft=tabDimensions.rootLeft-scrollPosition;var relativeRootRight=tabDimensions.rootRight-scrollPosition-barWidth;var relativeRootDelta=relativeRootLeft+relativeRootRight;var leftEdgeIsCloser=relativeRootLeft<0||relativeRootDelta<0;var rightEdgeIsCloser=relativeRootRight>0||relativeRootDelta>0;if(leftEdgeIsCloser){return index-1}if(rightEdgeIsCloser){return index+1}return-1};MDCTabBarFoundation.prototype.findAdjacentTabIndexClosestToEdgeRTL_=function(index,tabDimensions,scrollPosition,barWidth,scrollContentWidth){var rootLeft=scrollContentWidth-tabDimensions.rootLeft-barWidth-scrollPosition;var rootRight=scrollContentWidth-tabDimensions.rootRight-scrollPosition;var rootDelta=rootLeft+rootRight;var leftEdgeIsCloser=rootLeft>0||rootDelta>0;var rightEdgeIsCloser=rootRight<0||rootDelta<0;if(leftEdgeIsCloser){return index+1}if(rightEdgeIsCloser){return index-1}return-1};MDCTabBarFoundation.prototype.getKeyFromEvent_=function(evt){if(ACCEPTABLE_KEYS.has(evt.key)){return evt.key}return KEYCODE_MAP.get(evt.keyCode)};MDCTabBarFoundation.prototype.isActivationKey_=function(key){return key===tab_bar_constants_strings.SPACE_KEY||key===tab_bar_constants_strings.ENTER_KEY};MDCTabBarFoundation.prototype.indexIsInRange_=function(index){return index>=0&&index<this.adapter.getTabListLength()};MDCTabBarFoundation.prototype.isRTL_=function(){return this.adapter.isRTL()};MDCTabBarFoundation.prototype.scrollIntoView_=function(index){var scrollPosition=this.adapter.getScrollPosition();var barWidth=this.adapter.getOffsetWidth();var tabDimensions=this.adapter.getTabDimensionsAtIndex(index);var nextIndex=this.findAdjacentTabIndexClosestToEdge_(index,tabDimensions,scrollPosition,barWidth);if(!this.indexIsInRange_(nextIndex)){return}var scrollIncrement=this.calculateScrollIncrement_(index,nextIndex,scrollPosition,barWidth);this.adapter.incrementScroll(scrollIncrement)};MDCTabBarFoundation.prototype.scrollIntoViewRTL_=function(index){var scrollPosition=this.adapter.getScrollPosition();var barWidth=this.adapter.getOffsetWidth();var tabDimensions=this.adapter.getTabDimensionsAtIndex(index);var scrollWidth=this.adapter.getScrollContentWidth();var nextIndex=this.findAdjacentTabIndexClosestToEdgeRTL_(index,tabDimensions,scrollPosition,barWidth,scrollWidth);if(!this.indexIsInRange_(nextIndex)){return}var scrollIncrement=this.calculateScrollIncrementRTL_(index,nextIndex,scrollPosition,barWidth,scrollWidth);this.adapter.incrementScroll(scrollIncrement)};return MDCTabBarFoundation}(MDCFoundation);const tab_bar_foundation=null&&MDCTabBarFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var tab_bar_component_strings=MDCTabBarFoundation.strings;var tabIdCounter=0;var MDCTabBar=function(_super){__extends(MDCTabBar,_super);function MDCTabBar(){return _super!==null&&_super.apply(this,arguments)||this}MDCTabBar.attachTo=function(root){return new MDCTabBar(root)};Object.defineProperty(MDCTabBar.prototype,"focusOnActivate",{set:function(focusOnActivate){this.tabList_.forEach((function(tab){return tab.focusOnActivate=focusOnActivate}))},enumerable:true,configurable:true});Object.defineProperty(MDCTabBar.prototype,"useAutomaticActivation",{set:function(useAutomaticActivation){this.foundation.setUseAutomaticActivation(useAutomaticActivation)},enumerable:true,configurable:true});MDCTabBar.prototype.initialize=function(tabFactory,tabScrollerFactory){if(tabFactory===void 0){tabFactory=function(el){return new MDCTab(el)}}if(tabScrollerFactory===void 0){tabScrollerFactory=function(el){return new MDCTabScroller(el)}}this.tabList_=this.instantiateTabs_(tabFactory);this.tabScroller_=this.instantiateTabScroller_(tabScrollerFactory)};MDCTabBar.prototype.initialSyncWithDOM=function(){var _this=this;this.handleTabInteraction_=function(evt){return _this.foundation.handleTabInteraction(evt)};this.handleKeyDown_=function(evt){return _this.foundation.handleKeyDown(evt)};this.listen(MDCTabFoundation.strings.INTERACTED_EVENT,this.handleTabInteraction_);this.listen("keydown",this.handleKeyDown_);for(var i=0;i<this.tabList_.length;i++){if(this.tabList_[i].active){this.scrollIntoView(i);break}}};MDCTabBar.prototype.destroy=function(){_super.prototype.destroy.call(this);this.unlisten(MDCTabFoundation.strings.INTERACTED_EVENT,this.handleTabInteraction_);this.unlisten("keydown",this.handleKeyDown_);this.tabList_.forEach((function(tab){return tab.destroy()}));if(this.tabScroller_){this.tabScroller_.destroy()}};MDCTabBar.prototype.getDefaultFoundation=function(){var _this=this;var adapter={scrollTo:function(scrollX){return _this.tabScroller_.scrollTo(scrollX)},incrementScroll:function(scrollXIncrement){return _this.tabScroller_.incrementScroll(scrollXIncrement)},getScrollPosition:function(){return _this.tabScroller_.getScrollPosition()},getScrollContentWidth:function(){return _this.tabScroller_.getScrollContentWidth()},getOffsetWidth:function(){return _this.root.offsetWidth},isRTL:function(){return window.getComputedStyle(_this.root).getPropertyValue("direction")==="rtl"},setActiveTab:function(index){return _this.foundation.activateTab(index)},activateTabAtIndex:function(index,clientRect){return _this.tabList_[index].activate(clientRect)},deactivateTabAtIndex:function(index){return _this.tabList_[index].deactivate()},focusTabAtIndex:function(index){return _this.tabList_[index].focus()},getTabIndicatorClientRectAtIndex:function(index){return _this.tabList_[index].computeIndicatorClientRect()},getTabDimensionsAtIndex:function(index){return _this.tabList_[index].computeDimensions()},getPreviousActiveTabIndex:function(){for(var i=0;i<_this.tabList_.length;i++){if(_this.tabList_[i].active){return i}}return-1},getFocusedTabIndex:function(){var tabElements=_this.getTabElements_();var activeElement=document.activeElement;return tabElements.indexOf(activeElement)},getIndexOfTabById:function(id){for(var i=0;i<_this.tabList_.length;i++){if(_this.tabList_[i].id===id){return i}}return-1},getTabListLength:function(){return _this.tabList_.length},notifyTabActivated:function(index){return _this.emit(tab_bar_component_strings.TAB_ACTIVATED_EVENT,{index:index},true)}};return new MDCTabBarFoundation(adapter)};MDCTabBar.prototype.activateTab=function(index){this.foundation.activateTab(index)};MDCTabBar.prototype.scrollIntoView=function(index){this.foundation.scrollIntoView(index)};MDCTabBar.prototype.getTabElements_=function(){return[].slice.call(this.root.querySelectorAll(tab_bar_component_strings.TAB_SELECTOR))};MDCTabBar.prototype.instantiateTabs_=function(tabFactory){return this.getTabElements_().map((function(el){el.id=el.id||"mdc-tab-"+ ++tabIdCounter;return tabFactory(el)}))};MDCTabBar.prototype.instantiateTabScroller_=function(tabScrollerFactory){var tabScrollerElement=this.root.querySelector(tab_bar_component_strings.TAB_SCROLLER_SELECTOR);if(tabScrollerElement){return tabScrollerFactory(tabScrollerElement)}return null};return MDCTabBar}(MDCComponent);function MBTabBar_init(elem,dotNetObject){if(!elem){return}elem._tabBar=MDCTabBar.attachTo(elem);elem._callback=function(){var index=elem._tabBar.foundation.adapter.getFocusedTabIndex();dotNetObject.invokeMethodAsync("NotifyActivated",index)};elem._tabBar.listen("MDCTabBar:activated",elem._callback)}function activateTab(elem,index){if(!elem){return}elem._tabBar.unlisten("MDCTabBar:activated",elem._callback);elem._tabBar.activateTab(index);elem._tabBar.listen("MDCTabBar:activated",elem._callback)}function MBTextField_init(elem,helperTextElem,helperText,helperTextPersistent,performsValidation){if(!elem){return}elem._textField=MDCTextField.attachTo(elem);setHelperText(elem,helperTextElem,helperText,helperTextPersistent,performsValidation,false,"")}function MBTextField_setValue(elem,value){if(!elem){return}elem._textField.value=value}function MBTextField_setDisabled(elem,value){if(!elem){return}elem._textField.disabled=value}function setHelperText(elem,helperTextElem,helperText,helperTextPersistent,performsValidation,shakeLabel,validationMessage){if(!elem||!helperTextElem){return}if(helperText!==""||performsValidation===true){if(!elem._helperText){elem._helperText=MDCTextFieldHelperText.attachTo(helperTextElem)}if(validationMessage!==""){elem._helperText.root.innerHTML=sanitizeHTMLWithBreaks(validationMessage);elem._helperText.foundation.setPersistent(true);elem._helperText.foundation.setValidation(true);elem._helperText.foundation.setValidity(false);elem._textField.foundation.setValid(false);if(shakeLabel){elem._textField.foundation.adapter.shakeLabel(true)}}else if(helperText!==""){elem._helperText.foundation.setContent(helperText);elem._helperText.foundation.setPersistent(helperTextPersistent);elem._helperText.foundation.setValidation(false);elem._helperText.foundation.setValidity(true);elem._textField.foundation.setValid(true)}else{elem._helperText.foundation.setContent("");elem._helperText.foundation.setPersistent(false);elem._helperText.foundation.setValidation(false);elem._helperText.foundation.setValidity(true);elem._textField.foundation.setValid(true)}}}function setType(elem,value,inputElem,type,formNoValidate){if(!elem||!inputElem){return}inputElem.setAttribute("type",type);inputElem.setAttribute("formnovalidate",formNoValidate);elem._textField.value=value;if(formNoValidate){inputElem.focus();inputElem.select()}}
/*!
 * Sanitize and encode all HTML in a user-submitted string
 * (c) 2018 Chris Ferdinandi, MIT License, https://gomakethings.com
 * @param  {String} str  The user-submitted string
 * @return {String} str  The sanitized string
 */function sanitizeHTMLWithBreaks(str){var tempDiv=document.createElement("div");tempDiv.textContent=str;var sanitized=tempDiv.innerHTML;tempDiv.remove();return sanitized.replace(new RegExp(escapeRegExp("&lt;br /&gt;"),"g"),"<br />")}function escapeRegExp(str){return str.replace(/([.*+?^=!:${}()|\[\]\/\\])/g,"\\$1")}
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
 */
var CssClasses;(function(CssClasses){CssClasses["RICH"]="mdc-tooltip--rich";CssClasses["SHOWN"]="mdc-tooltip--shown";CssClasses["SHOWING"]="mdc-tooltip--showing";CssClasses["SHOWING_TRANSITION"]="mdc-tooltip--showing-transition";CssClasses["HIDE"]="mdc-tooltip--hide";CssClasses["HIDE_TRANSITION"]="mdc-tooltip--hide-transition";CssClasses["MULTILINE_TOOLTIP"]="mdc-tooltip--multiline"})(CssClasses||(CssClasses={}));var tooltip_constants_numbers={BOUNDED_ANCHOR_GAP:4,UNBOUNDED_ANCHOR_GAP:8,MIN_VIEWPORT_TOOLTIP_THRESHOLD:8,HIDE_DELAY_MS:600,SHOW_DELAY_MS:500,MIN_HEIGHT:24,MAX_WIDTH:200};var tooltip_constants_attributes={ARIA_EXPANDED:"aria-expanded",ARIA_HASPOPUP:"aria-haspopup",PERSISTENT:"data-mdc-tooltip-persistent"};var tooltip_constants_events={HIDDEN:"MDCTooltip:hidden"};var XPosition;(function(XPosition){XPosition[XPosition["DETECTED"]=0]="DETECTED";XPosition[XPosition["START"]=1]="START";XPosition[XPosition["CENTER"]=2]="CENTER";XPosition[XPosition["END"]=3]="END"})(XPosition||(XPosition={}));var YPosition;(function(YPosition){YPosition[YPosition["DETECTED"]=0]="DETECTED";YPosition[YPosition["ABOVE"]=1]="ABOVE";YPosition[YPosition["BELOW"]=2]="BELOW"})(YPosition||(YPosition={}));var AnchorBoundaryType;(function(AnchorBoundaryType){AnchorBoundaryType[AnchorBoundaryType["BOUNDED"]=0]="BOUNDED";AnchorBoundaryType[AnchorBoundaryType["UNBOUNDED"]=1]="UNBOUNDED"})(AnchorBoundaryType||(AnchorBoundaryType={}));
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
 */
var AnimationFrame=function(){function AnimationFrame(){this.rafIDs=new Map}AnimationFrame.prototype.request=function(key,callback){var _this=this;this.cancel(key);var frameID=requestAnimationFrame((function(frame){_this.rafIDs.delete(key);callback(frame)}));this.rafIDs.set(key,frameID)};AnimationFrame.prototype.cancel=function(key){var rafID=this.rafIDs.get(key);if(rafID){cancelAnimationFrame(rafID);this.rafIDs.delete(key)}};AnimationFrame.prototype.cancelAll=function(){var _this=this;this.rafIDs.forEach((function(_,key){_this.cancel(key)}))};AnimationFrame.prototype.getQueue=function(){var queue=[];this.rafIDs.forEach((function(_,key){queue.push(key)}));return queue};return AnimationFrame}();
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
 */
var RICH=CssClasses.RICH,SHOWN=CssClasses.SHOWN,SHOWING=CssClasses.SHOWING,SHOWING_TRANSITION=CssClasses.SHOWING_TRANSITION,HIDE=CssClasses.HIDE,HIDE_TRANSITION=CssClasses.HIDE_TRANSITION,MULTILINE_TOOLTIP=CssClasses.MULTILINE_TOOLTIP;var AnimationKeys;(function(AnimationKeys){AnimationKeys["POLL_ANCHOR"]="poll_anchor"})(AnimationKeys||(AnimationKeys={}));var MDCTooltipFoundation=function(_super){__extends(MDCTooltipFoundation,_super);function MDCTooltipFoundation(adapter){var _this=_super.call(this,__assign(__assign({},MDCTooltipFoundation.defaultAdapter),adapter))||this;_this.isShown=false;_this.anchorGap=tooltip_constants_numbers.BOUNDED_ANCHOR_GAP;_this.xTooltipPos=XPosition.DETECTED;_this.yTooltipPos=YPosition.DETECTED;_this.minViewportTooltipThreshold=tooltip_constants_numbers.MIN_VIEWPORT_TOOLTIP_THRESHOLD;_this.hideDelayMs=tooltip_constants_numbers.HIDE_DELAY_MS;_this.showDelayMs=tooltip_constants_numbers.SHOW_DELAY_MS;_this.anchorRect=null;_this.frameId=null;_this.hideTimeout=null;_this.showTimeout=null;_this.animFrame=new AnimationFrame;_this.documentClickHandler=function(evt){_this.handleDocumentClick(evt)};_this.documentKeydownHandler=function(evt){_this.handleKeydown(evt)};_this.richTooltipMouseEnterHandler=function(){_this.handleRichTooltipMouseEnter()};_this.richTooltipMouseLeaveHandler=function(){_this.handleRichTooltipMouseLeave()};_this.richTooltipFocusOutHandler=function(evt){_this.handleRichTooltipFocusOut(evt)};_this.windowScrollHandler=function(){_this.handleWindowChangeEvent()};_this.windowResizeHandler=function(){_this.handleWindowChangeEvent()};return _this}Object.defineProperty(MDCTooltipFoundation,"defaultAdapter",{get:function(){return{getAttribute:function(){return null},setAttribute:function(){return undefined},addClass:function(){return undefined},hasClass:function(){return false},removeClass:function(){return undefined},setStyleProperty:function(){return undefined},getViewportWidth:function(){return 0},getViewportHeight:function(){return 0},getTooltipSize:function(){return{width:0,height:0}},getAnchorBoundingRect:function(){return{top:0,right:0,bottom:0,left:0,width:0,height:0}},getAnchorAttribute:function(){return null},setAnchorAttribute:function(){return null},isRTL:function(){return false},anchorContainsElement:function(){return false},tooltipContainsElement:function(){return false},focusAnchorElement:function(){return undefined},registerEventHandler:function(){return undefined},deregisterEventHandler:function(){return undefined},registerDocumentEventHandler:function(){return undefined},deregisterDocumentEventHandler:function(){return undefined},registerWindowEventHandler:function(){return undefined},deregisterWindowEventHandler:function(){return undefined},notifyHidden:function(){return undefined}}},enumerable:true,configurable:true});MDCTooltipFoundation.prototype.init=function(){this.isRich=this.adapter.hasClass(RICH);this.isPersistent=this.adapter.getAttribute(tooltip_constants_attributes.PERSISTENT)==="true";this.isInteractive=!!this.adapter.getAnchorAttribute(tooltip_constants_attributes.ARIA_EXPANDED)&&this.adapter.getAnchorAttribute(tooltip_constants_attributes.ARIA_HASPOPUP)==="true"};MDCTooltipFoundation.prototype.getIsRich=function(){return this.isRich};MDCTooltipFoundation.prototype.getIsPersistent=function(){return this.isPersistent};MDCTooltipFoundation.prototype.handleAnchorMouseEnter=function(){var _this=this;if(this.isShown){this.show()}else{this.showTimeout=setTimeout((function(){_this.show()}),this.showDelayMs)}};MDCTooltipFoundation.prototype.handleAnchorFocus=function(evt){var _this=this;var relatedTarget=evt.relatedTarget;var tooltipContainsRelatedTarget=relatedTarget instanceof HTMLElement&&this.adapter.tooltipContainsElement(relatedTarget);if(tooltipContainsRelatedTarget){return}this.showTimeout=setTimeout((function(){_this.show()}),this.showDelayMs)};MDCTooltipFoundation.prototype.handleAnchorMouseLeave=function(){var _this=this;this.clearShowTimeout();this.hideTimeout=setTimeout((function(){_this.hide()}),this.hideDelayMs)};MDCTooltipFoundation.prototype.handleAnchorBlur=function(evt){if(this.isRich){var tooltipContainsRelatedTargetElement=evt.relatedTarget instanceof HTMLElement&&this.adapter.tooltipContainsElement(evt.relatedTarget);if(tooltipContainsRelatedTargetElement){return}}this.hide()};MDCTooltipFoundation.prototype.handleAnchorClick=function(){if(this.isShown){this.hide()}else{this.show()}};MDCTooltipFoundation.prototype.handleDocumentClick=function(evt){var anchorOrTooltipContainsTargetElement=evt.target instanceof HTMLElement&&(this.adapter.anchorContainsElement(evt.target)||this.adapter.tooltipContainsElement(evt.target));if(this.isRich&&this.isPersistent&&anchorOrTooltipContainsTargetElement){return}this.hide()};MDCTooltipFoundation.prototype.handleKeydown=function(evt){var key=normalizeKey(evt);if(key===KEY.ESCAPE){var tooltipContainsActiveElement=document.activeElement instanceof HTMLElement&&this.adapter.tooltipContainsElement(document.activeElement);if(tooltipContainsActiveElement){this.adapter.focusAnchorElement()}this.hide()}};MDCTooltipFoundation.prototype.handleRichTooltipMouseEnter=function(){this.show()};MDCTooltipFoundation.prototype.handleRichTooltipMouseLeave=function(){var _this=this;this.clearShowTimeout();this.hideTimeout=setTimeout((function(){_this.hide()}),this.hideDelayMs)};MDCTooltipFoundation.prototype.handleRichTooltipFocusOut=function(evt){var anchorOrTooltipContainsRelatedTargetElement=evt.relatedTarget instanceof HTMLElement&&(this.adapter.anchorContainsElement(evt.relatedTarget)||this.adapter.tooltipContainsElement(evt.relatedTarget));if(anchorOrTooltipContainsRelatedTargetElement){return}this.hide()};MDCTooltipFoundation.prototype.handleWindowChangeEvent=function(){var _this=this;this.animFrame.request(AnimationKeys.POLL_ANCHOR,(function(){_this.repositionTooltipOnAnchorMove()}))};MDCTooltipFoundation.prototype.show=function(){var _this=this;this.clearHideTimeout();this.clearShowTimeout();if(this.isShown){return}this.isShown=true;var showTooltipOptions=this.parseShowTooltipOptions();if(!showTooltipOptions.hideFromScreenreader){this.adapter.setAttribute("aria-hidden","false")}if(this.isRich){if(this.isInteractive){this.adapter.setAnchorAttribute("aria-expanded","true")}this.adapter.registerEventHandler("focusout",this.richTooltipFocusOutHandler);if(!this.isPersistent){this.adapter.registerEventHandler("mouseenter",this.richTooltipMouseEnterHandler);this.adapter.registerEventHandler("mouseleave",this.richTooltipMouseLeaveHandler)}}this.adapter.removeClass(HIDE);this.adapter.addClass(SHOWING);if(this.isTooltipMultiline()&&!this.isRich){this.adapter.addClass(MULTILINE_TOOLTIP)}this.anchorRect=this.adapter.getAnchorBoundingRect();this.positionTooltip();this.adapter.registerDocumentEventHandler("click",this.documentClickHandler);this.adapter.registerDocumentEventHandler("keydown",this.documentKeydownHandler);this.adapter.registerWindowEventHandler("scroll",this.windowScrollHandler);this.adapter.registerWindowEventHandler("resize",this.windowResizeHandler);this.frameId=requestAnimationFrame((function(){_this.clearAllAnimationClasses();_this.adapter.addClass(SHOWN);_this.adapter.addClass(SHOWING_TRANSITION)}))};MDCTooltipFoundation.prototype.hide=function(){this.clearHideTimeout();this.clearShowTimeout();if(!this.isShown){return}if(this.frameId){cancelAnimationFrame(this.frameId)}this.isShown=false;this.adapter.setAttribute("aria-hidden","true");this.adapter.deregisterEventHandler("focusout",this.richTooltipFocusOutHandler);if(this.isRich){if(this.isInteractive){this.adapter.setAnchorAttribute("aria-expanded","false")}if(!this.isPersistent){this.adapter.deregisterEventHandler("mouseenter",this.richTooltipMouseEnterHandler);this.adapter.deregisterEventHandler("mouseleave",this.richTooltipMouseLeaveHandler)}}this.clearAllAnimationClasses();this.adapter.addClass(HIDE);this.adapter.addClass(HIDE_TRANSITION);this.adapter.removeClass(SHOWN);this.adapter.deregisterDocumentEventHandler("click",this.documentClickHandler);this.adapter.deregisterDocumentEventHandler("keydown",this.documentKeydownHandler);this.adapter.deregisterWindowEventHandler("scroll",this.windowScrollHandler);this.adapter.deregisterWindowEventHandler("resize",this.windowResizeHandler)};MDCTooltipFoundation.prototype.handleTransitionEnd=function(){var isHidingTooltip=this.adapter.hasClass(HIDE);this.adapter.removeClass(SHOWING);this.adapter.removeClass(SHOWING_TRANSITION);this.adapter.removeClass(HIDE);this.adapter.removeClass(HIDE_TRANSITION);if(isHidingTooltip){this.adapter.notifyHidden()}};MDCTooltipFoundation.prototype.clearAllAnimationClasses=function(){this.adapter.removeClass(SHOWING_TRANSITION);this.adapter.removeClass(HIDE_TRANSITION)};MDCTooltipFoundation.prototype.setTooltipPosition=function(position){var xPos=position.xPos,yPos=position.yPos;if(xPos){this.xTooltipPos=xPos}if(yPos){this.yTooltipPos=yPos}};MDCTooltipFoundation.prototype.setAnchorBoundaryType=function(type){if(type===AnchorBoundaryType.UNBOUNDED){this.anchorGap=tooltip_constants_numbers.UNBOUNDED_ANCHOR_GAP}else{this.anchorGap=tooltip_constants_numbers.BOUNDED_ANCHOR_GAP}};MDCTooltipFoundation.prototype.parseShowTooltipOptions=function(){var hideFromScreenreader=Boolean(this.adapter.getAnchorAttribute("data-tooltip-id"));return{hideFromScreenreader:hideFromScreenreader}};MDCTooltipFoundation.prototype.isTooltipMultiline=function(){var tooltipSize=this.adapter.getTooltipSize();return tooltipSize.height>tooltip_constants_numbers.MIN_HEIGHT&&tooltipSize.width>=tooltip_constants_numbers.MAX_WIDTH};MDCTooltipFoundation.prototype.positionTooltip=function(){var _a=this.calculateTooltipDistance(this.anchorRect),top=_a.top,left=_a.left;this.adapter.setStyleProperty("top",top+"px");this.adapter.setStyleProperty("left",left+"px")};MDCTooltipFoundation.prototype.calculateTooltipDistance=function(anchorRect){if(!anchorRect){return{top:0,left:0}}var tooltipSize=this.adapter.getTooltipSize();var top=this.calculateYTooltipDistance(anchorRect,tooltipSize.height);var left=this.calculateXTooltipDistance(anchorRect,tooltipSize.width);return{top:top,left:left}};MDCTooltipFoundation.prototype.calculateXTooltipDistance=function(anchorRect,tooltipWidth){var isLTR=!this.adapter.isRTL();var startPos,endPos,centerPos;if(this.isRich){startPos=isLTR?anchorRect.left-tooltipWidth:anchorRect.right;endPos=isLTR?anchorRect.right:anchorRect.left-tooltipWidth}else{startPos=isLTR?anchorRect.left:anchorRect.right-tooltipWidth;endPos=isLTR?anchorRect.right-tooltipWidth:anchorRect.left;centerPos=anchorRect.left+(anchorRect.width-tooltipWidth)/2}var positionOptions=this.isRich?this.determineValidPositionOptions(startPos,endPos):this.determineValidPositionOptions(centerPos,startPos,endPos);if(this.xTooltipPos===XPosition.START&&positionOptions.has(startPos)){return startPos}if(this.xTooltipPos===XPosition.END&&positionOptions.has(endPos)){return endPos}if(this.xTooltipPos===XPosition.CENTER&&positionOptions.has(centerPos)){return centerPos}var possiblePositions=this.isRich?[endPos,startPos]:[centerPos,startPos,endPos];var validPosition=possiblePositions.find((function(pos){return positionOptions.has(pos)}));if(validPosition){return validPosition}if(anchorRect.left<0){return this.minViewportTooltipThreshold}else{var viewportWidth=this.adapter.getViewportWidth();return viewportWidth-(tooltipWidth+this.minViewportTooltipThreshold)}};MDCTooltipFoundation.prototype.determineValidPositionOptions=function(){var e_1,_a;var positions=[];for(var _i=0;_i<arguments.length;_i++){positions[_i]=arguments[_i]}var posWithinThreshold=new Set;var posWithinViewport=new Set;try{for(var positions_1=__values(positions),positions_1_1=positions_1.next();!positions_1_1.done;positions_1_1=positions_1.next()){var position=positions_1_1.value;if(this.positionHonorsViewportThreshold(position)){posWithinThreshold.add(position)}else if(this.positionDoesntCollideWithViewport(position)){posWithinViewport.add(position)}}}catch(e_1_1){e_1={error:e_1_1}}finally{try{if(positions_1_1&&!positions_1_1.done&&(_a=positions_1.return))_a.call(positions_1)}finally{if(e_1)throw e_1.error}}return posWithinThreshold.size?posWithinThreshold:posWithinViewport};MDCTooltipFoundation.prototype.positionHonorsViewportThreshold=function(leftPos){var viewportWidth=this.adapter.getViewportWidth();var tooltipWidth=this.adapter.getTooltipSize().width;return leftPos+tooltipWidth<=viewportWidth-this.minViewportTooltipThreshold&&leftPos>=this.minViewportTooltipThreshold};MDCTooltipFoundation.prototype.positionDoesntCollideWithViewport=function(leftPos){var viewportWidth=this.adapter.getViewportWidth();var tooltipWidth=this.adapter.getTooltipSize().width;return leftPos+tooltipWidth<=viewportWidth&&leftPos>=0};MDCTooltipFoundation.prototype.calculateYTooltipDistance=function(anchorRect,tooltipHeight){var belowYPos=anchorRect.bottom+this.anchorGap;var aboveYPos=anchorRect.top-(this.anchorGap+tooltipHeight);var yPositionOptions=this.determineValidYPositionOptions(aboveYPos,belowYPos);if(this.yTooltipPos===YPosition.ABOVE&&yPositionOptions.has(aboveYPos)){return aboveYPos}else if(this.yTooltipPos===YPosition.BELOW&&yPositionOptions.has(belowYPos)){return belowYPos}if(yPositionOptions.has(belowYPos)){return belowYPos}if(yPositionOptions.has(aboveYPos)){return aboveYPos}return belowYPos};MDCTooltipFoundation.prototype.determineValidYPositionOptions=function(aboveAnchorPos,belowAnchorPos){var posWithinThreshold=new Set;var posWithinViewport=new Set;if(this.yPositionHonorsViewportThreshold(aboveAnchorPos)){posWithinThreshold.add(aboveAnchorPos)}else if(this.yPositionDoesntCollideWithViewport(aboveAnchorPos)){posWithinViewport.add(aboveAnchorPos)}if(this.yPositionHonorsViewportThreshold(belowAnchorPos)){posWithinThreshold.add(belowAnchorPos)}else if(this.yPositionDoesntCollideWithViewport(belowAnchorPos)){posWithinViewport.add(belowAnchorPos)}return posWithinThreshold.size?posWithinThreshold:posWithinViewport};MDCTooltipFoundation.prototype.yPositionHonorsViewportThreshold=function(yPos){var viewportHeight=this.adapter.getViewportHeight();var tooltipHeight=this.adapter.getTooltipSize().height;return yPos+tooltipHeight+this.minViewportTooltipThreshold<=viewportHeight&&yPos>=this.minViewportTooltipThreshold};MDCTooltipFoundation.prototype.yPositionDoesntCollideWithViewport=function(yPos){var viewportHeight=this.adapter.getViewportHeight();var tooltipHeight=this.adapter.getTooltipSize().height;return yPos+tooltipHeight<=viewportHeight&&yPos>=0};MDCTooltipFoundation.prototype.repositionTooltipOnAnchorMove=function(){var newAnchorRect=this.adapter.getAnchorBoundingRect();if(!newAnchorRect||!this.anchorRect)return;if(newAnchorRect.top!==this.anchorRect.top||newAnchorRect.left!==this.anchorRect.left||newAnchorRect.height!==this.anchorRect.height||newAnchorRect.width!==this.anchorRect.width){this.anchorRect=newAnchorRect;this.positionTooltip()}};MDCTooltipFoundation.prototype.clearShowTimeout=function(){if(this.showTimeout){clearTimeout(this.showTimeout);this.showTimeout=null}};MDCTooltipFoundation.prototype.clearHideTimeout=function(){if(this.hideTimeout){clearTimeout(this.hideTimeout);this.hideTimeout=null}};MDCTooltipFoundation.prototype.destroy=function(){if(this.frameId){cancelAnimationFrame(this.frameId);this.frameId=null}this.clearHideTimeout();this.clearShowTimeout();this.adapter.removeClass(SHOWN);this.adapter.removeClass(SHOWING_TRANSITION);this.adapter.removeClass(SHOWING);this.adapter.removeClass(HIDE);this.adapter.removeClass(HIDE_TRANSITION);if(this.isRich){this.adapter.deregisterEventHandler("focusout",this.richTooltipFocusOutHandler);if(!this.isPersistent){this.adapter.deregisterEventHandler("mouseenter",this.richTooltipMouseEnterHandler);this.adapter.deregisterEventHandler("mouseleave",this.richTooltipMouseLeaveHandler)}}this.adapter.deregisterDocumentEventHandler("click",this.documentClickHandler);this.adapter.deregisterDocumentEventHandler("keydown",this.documentKeydownHandler);this.adapter.deregisterWindowEventHandler("scroll",this.windowScrollHandler);this.adapter.deregisterWindowEventHandler("resize",this.windowResizeHandler);this.animFrame.cancelAll()};return MDCTooltipFoundation}(MDCFoundation);const tooltip_foundation=null&&MDCTooltipFoundation;
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
 */
var MDCTooltip=function(_super){__extends(MDCTooltip,_super);function MDCTooltip(){return _super!==null&&_super.apply(this,arguments)||this}MDCTooltip.attachTo=function(root){return new MDCTooltip(root)};MDCTooltip.prototype.initialize=function(){var tooltipId=this.root.getAttribute("id");if(!tooltipId){throw new Error("MDCTooltip: Tooltip component must have an id.")}var anchorElem=document.querySelector('[aria-describedby="'+tooltipId+'"]')||document.querySelector('[data-tooltip-id="'+tooltipId+'"]');if(!anchorElem){throw new Error("MDCTooltip: Tooltip component requires an anchor element annotated with [aria-describedby] or [data-tooltip-id] anchor element.")}this.anchorElem=anchorElem};MDCTooltip.prototype.initialSyncWithDOM=function(){var _this=this;this.isTooltipRich=this.foundation.getIsRich();this.isTooltipPersistent=this.foundation.getIsPersistent();this.handleMouseEnter=function(){_this.foundation.handleAnchorMouseEnter()};this.handleFocus=function(evt){_this.foundation.handleAnchorFocus(evt)};this.handleMouseLeave=function(){_this.foundation.handleAnchorMouseLeave()};this.handleBlur=function(evt){_this.foundation.handleAnchorBlur(evt)};this.handleTransitionEnd=function(){_this.foundation.handleTransitionEnd()};this.handleClick=function(){_this.foundation.handleAnchorClick()};this.anchorElem.addEventListener("blur",this.handleBlur);if(this.isTooltipRich&&this.isTooltipPersistent){this.anchorElem.addEventListener("click",this.handleClick)}else{this.anchorElem.addEventListener("mouseenter",this.handleMouseEnter);this.anchorElem.addEventListener("focus",this.handleFocus);this.anchorElem.addEventListener("mouseleave",this.handleMouseLeave)}this.listen("transitionend",this.handleTransitionEnd)};MDCTooltip.prototype.destroy=function(){if(this.anchorElem){this.anchorElem.removeEventListener("blur",this.handleBlur);if(this.isTooltipRich&&this.isTooltipPersistent){this.anchorElem.removeEventListener("click",this.handleClick)}else{this.anchorElem.removeEventListener("mouseenter",this.handleMouseEnter);this.anchorElem.removeEventListener("focus",this.handleFocus);this.anchorElem.removeEventListener("mouseleave",this.handleMouseLeave)}}this.unlisten("transitionend",this.handleTransitionEnd);_super.prototype.destroy.call(this)};MDCTooltip.prototype.setTooltipPosition=function(position){this.foundation.setTooltipPosition(position)};MDCTooltip.prototype.setAnchorBoundaryType=function(type){this.foundation.setAnchorBoundaryType(type)};MDCTooltip.prototype.getDefaultFoundation=function(){var _this=this;var adapter={getAttribute:function(attr){return _this.root.getAttribute(attr)},setAttribute:function(attr,value){_this.root.setAttribute(attr,value)},addClass:function(className){_this.root.classList.add(className)},hasClass:function(className){return _this.root.classList.contains(className)},removeClass:function(className){_this.root.classList.remove(className)},setStyleProperty:function(propertyName,value){_this.root.style.setProperty(propertyName,value)},getViewportWidth:function(){return window.innerWidth},getViewportHeight:function(){return window.innerHeight},getTooltipSize:function(){return{width:_this.root.offsetWidth,height:_this.root.offsetHeight}},getAnchorBoundingRect:function(){return _this.anchorElem?_this.anchorElem.getBoundingClientRect():null},getAnchorAttribute:function(attr){return _this.anchorElem?_this.anchorElem.getAttribute(attr):null},setAnchorAttribute:function(attr,value){var _a;(_a=_this.anchorElem)===null||_a===void 0?void 0:_a.setAttribute(attr,value)},isRTL:function(){return getComputedStyle(_this.root).direction==="rtl"},anchorContainsElement:function(element){var _a;return!!((_a=_this.anchorElem)===null||_a===void 0?void 0:_a.contains(element))},tooltipContainsElement:function(element){return _this.root.contains(element)},focusAnchorElement:function(){var _a;(_a=_this.anchorElem)===null||_a===void 0?void 0:_a.focus()},registerEventHandler:function(evt,handler){if(_this.root instanceof HTMLElement){_this.root.addEventListener(evt,handler)}},deregisterEventHandler:function(evt,handler){if(_this.root instanceof HTMLElement){_this.root.removeEventListener(evt,handler)}},registerDocumentEventHandler:function(evt,handler){document.body.addEventListener(evt,handler)},deregisterDocumentEventHandler:function(evt,handler){document.body.removeEventListener(evt,handler)},registerWindowEventHandler:function(evt,handler){window.addEventListener(evt,handler)},deregisterWindowEventHandler:function(evt,handler){window.removeEventListener(evt,handler)},notifyHidden:function(){_this.emit(tooltip_constants_events.HIDDEN,{})}};return new MDCTooltipFoundation(adapter)};return MDCTooltip}(MDCComponent);function _createForOfIteratorHelper(o,allowArrayLike){var it=typeof Symbol!=="undefined"&&o[Symbol.iterator]||o["@@iterator"];if(!it){if(Array.isArray(o)||(it=_unsupportedIterableToArray(o))||allowArrayLike&&o&&typeof o.length==="number"){if(it)o=it;var i=0;var F=function F(){};return{s:F,n:function n(){if(i>=o.length)return{done:true};return{done:false,value:o[i++]}},e:function e(_e){throw _e},f:F}}throw new TypeError("Invalid attempt to iterate non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.")}var normalCompletion=true,didErr=false,err;return{s:function s(){it=it.call(o)},n:function n(){var step=it.next();normalCompletion=step.done;return step},e:function e(_e2){didErr=true;err=_e2},f:function f(){try{if(!normalCompletion&&it["return"]!=null)it["return"]()}finally{if(didErr)throw err}}}}function _unsupportedIterableToArray(o,minLen){if(!o)return;if(typeof o==="string")return _arrayLikeToArray(o,minLen);var n=Object.prototype.toString.call(o).slice(8,-1);if(n==="Object"&&o.constructor)n=o.constructor.name;if(n==="Map"||n==="Set")return Array.from(o);if(n==="Arguments"||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(n))return _arrayLikeToArray(o,minLen)}function _arrayLikeToArray(arr,len){if(len==null||len>arr.length)len=arr.length;for(var i=0,arr2=new Array(len);i<len;i++){arr2[i]=arr[i]}return arr2}function MBTooltip_init(arrayOfReferences){var _iterator=_createForOfIteratorHelper(arrayOfReferences),_step;try{for(_iterator.s();!(_step=_iterator.n()).done;){var elem=_step.value;try{if(elem){MDCTooltip.attachTo(elem)}}catch(e){}}}catch(err){_iterator.e(err)}finally{_iterator.f()}}
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var top_app_bar_constants_cssClasses={FIXED_CLASS:"mdc-top-app-bar--fixed",FIXED_SCROLLED_CLASS:"mdc-top-app-bar--fixed-scrolled",SHORT_CLASS:"mdc-top-app-bar--short",SHORT_COLLAPSED_CLASS:"mdc-top-app-bar--short-collapsed",SHORT_HAS_ACTION_ITEM_CLASS:"mdc-top-app-bar--short-has-action-item"};var top_app_bar_constants_numbers={DEBOUNCE_THROTTLE_RESIZE_TIME_MS:100,MAX_TOP_APP_BAR_HEIGHT:128};var top_app_bar_constants_strings={ACTION_ITEM_SELECTOR:".mdc-top-app-bar__action-item",NAVIGATION_EVENT:"MDCTopAppBar:nav",NAVIGATION_ICON_SELECTOR:".mdc-top-app-bar__navigation-icon",ROOT_SELECTOR:".mdc-top-app-bar",TITLE_SELECTOR:".mdc-top-app-bar__title"};
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCTopAppBarBaseFoundation=function(_super){__extends(MDCTopAppBarBaseFoundation,_super);function MDCTopAppBarBaseFoundation(adapter){return _super.call(this,__assign(__assign({},MDCTopAppBarBaseFoundation.defaultAdapter),adapter))||this}Object.defineProperty(MDCTopAppBarBaseFoundation,"strings",{get:function(){return top_app_bar_constants_strings},enumerable:true,configurable:true});Object.defineProperty(MDCTopAppBarBaseFoundation,"cssClasses",{get:function(){return top_app_bar_constants_cssClasses},enumerable:true,configurable:true});Object.defineProperty(MDCTopAppBarBaseFoundation,"numbers",{get:function(){return top_app_bar_constants_numbers},enumerable:true,configurable:true});Object.defineProperty(MDCTopAppBarBaseFoundation,"defaultAdapter",{get:function(){return{addClass:function(){return undefined},removeClass:function(){return undefined},hasClass:function(){return false},setStyle:function(){return undefined},getTopAppBarHeight:function(){return 0},notifyNavigationIconClicked:function(){return undefined},getViewportScrollY:function(){return 0},getTotalActionItems:function(){return 0}}},enumerable:true,configurable:true});MDCTopAppBarBaseFoundation.prototype.handleTargetScroll=function(){};MDCTopAppBarBaseFoundation.prototype.handleWindowResize=function(){};MDCTopAppBarBaseFoundation.prototype.handleNavigationClick=function(){this.adapter.notifyNavigationIconClicked()};return MDCTopAppBarBaseFoundation}(MDCFoundation);const top_app_bar_foundation=null&&MDCTopAppBarBaseFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var INITIAL_VALUE=0;var MDCTopAppBarFoundation=function(_super){__extends(MDCTopAppBarFoundation,_super);function MDCTopAppBarFoundation(adapter){var _this=_super.call(this,adapter)||this;_this.wasDocked_=true;_this.isDockedShowing_=true;_this.currentAppBarOffsetTop_=0;_this.isCurrentlyBeingResized_=false;_this.resizeThrottleId_=INITIAL_VALUE;_this.resizeDebounceId_=INITIAL_VALUE;_this.lastScrollPosition_=_this.adapter.getViewportScrollY();_this.topAppBarHeight_=_this.adapter.getTopAppBarHeight();return _this}MDCTopAppBarFoundation.prototype.destroy=function(){_super.prototype.destroy.call(this);this.adapter.setStyle("top","")};MDCTopAppBarFoundation.prototype.handleTargetScroll=function(){var currentScrollPosition=Math.max(this.adapter.getViewportScrollY(),0);var diff=currentScrollPosition-this.lastScrollPosition_;this.lastScrollPosition_=currentScrollPosition;if(!this.isCurrentlyBeingResized_){this.currentAppBarOffsetTop_-=diff;if(this.currentAppBarOffsetTop_>0){this.currentAppBarOffsetTop_=0}else if(Math.abs(this.currentAppBarOffsetTop_)>this.topAppBarHeight_){this.currentAppBarOffsetTop_=-this.topAppBarHeight_}this.moveTopAppBar_()}};MDCTopAppBarFoundation.prototype.handleWindowResize=function(){var _this=this;if(!this.resizeThrottleId_){this.resizeThrottleId_=setTimeout((function(){_this.resizeThrottleId_=INITIAL_VALUE;_this.throttledResizeHandler_()}),top_app_bar_constants_numbers.DEBOUNCE_THROTTLE_RESIZE_TIME_MS)}this.isCurrentlyBeingResized_=true;if(this.resizeDebounceId_){clearTimeout(this.resizeDebounceId_)}this.resizeDebounceId_=setTimeout((function(){_this.handleTargetScroll();_this.isCurrentlyBeingResized_=false;_this.resizeDebounceId_=INITIAL_VALUE}),top_app_bar_constants_numbers.DEBOUNCE_THROTTLE_RESIZE_TIME_MS)};MDCTopAppBarFoundation.prototype.checkForUpdate_=function(){var offscreenBoundaryTop=-this.topAppBarHeight_;var hasAnyPixelsOffscreen=this.currentAppBarOffsetTop_<0;var hasAnyPixelsOnscreen=this.currentAppBarOffsetTop_>offscreenBoundaryTop;var partiallyShowing=hasAnyPixelsOffscreen&&hasAnyPixelsOnscreen;if(partiallyShowing){this.wasDocked_=false}else{if(!this.wasDocked_){this.wasDocked_=true;return true}else if(this.isDockedShowing_!==hasAnyPixelsOnscreen){this.isDockedShowing_=hasAnyPixelsOnscreen;return true}}return partiallyShowing};MDCTopAppBarFoundation.prototype.moveTopAppBar_=function(){if(this.checkForUpdate_()){var offset=this.currentAppBarOffsetTop_;if(Math.abs(offset)>=this.topAppBarHeight_){offset=-top_app_bar_constants_numbers.MAX_TOP_APP_BAR_HEIGHT}this.adapter.setStyle("top",offset+"px")}};MDCTopAppBarFoundation.prototype.throttledResizeHandler_=function(){var currentHeight=this.adapter.getTopAppBarHeight();if(this.topAppBarHeight_!==currentHeight){this.wasDocked_=false;this.currentAppBarOffsetTop_-=this.topAppBarHeight_-currentHeight;this.topAppBarHeight_=currentHeight}this.handleTargetScroll()};return MDCTopAppBarFoundation}(MDCTopAppBarBaseFoundation);const standard_foundation=null&&MDCTopAppBarFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCFixedTopAppBarFoundation=function(_super){__extends(MDCFixedTopAppBarFoundation,_super);function MDCFixedTopAppBarFoundation(){var _this=_super!==null&&_super.apply(this,arguments)||this;_this.wasScrolled_=false;return _this}MDCFixedTopAppBarFoundation.prototype.handleTargetScroll=function(){var currentScroll=this.adapter.getViewportScrollY();if(currentScroll<=0){if(this.wasScrolled_){this.adapter.removeClass(top_app_bar_constants_cssClasses.FIXED_SCROLLED_CLASS);this.wasScrolled_=false}}else{if(!this.wasScrolled_){this.adapter.addClass(top_app_bar_constants_cssClasses.FIXED_SCROLLED_CLASS);this.wasScrolled_=true}}};return MDCFixedTopAppBarFoundation}(MDCTopAppBarFoundation);const fixed_foundation=null&&MDCFixedTopAppBarFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCShortTopAppBarFoundation=function(_super){__extends(MDCShortTopAppBarFoundation,_super);function MDCShortTopAppBarFoundation(adapter){var _this=_super.call(this,adapter)||this;_this.isCollapsed_=false;_this.isAlwaysCollapsed_=false;return _this}Object.defineProperty(MDCShortTopAppBarFoundation.prototype,"isCollapsed",{get:function(){return this.isCollapsed_},enumerable:true,configurable:true});MDCShortTopAppBarFoundation.prototype.init=function(){_super.prototype.init.call(this);if(this.adapter.getTotalActionItems()>0){this.adapter.addClass(top_app_bar_constants_cssClasses.SHORT_HAS_ACTION_ITEM_CLASS)}this.setAlwaysCollapsed(this.adapter.hasClass(top_app_bar_constants_cssClasses.SHORT_COLLAPSED_CLASS))};MDCShortTopAppBarFoundation.prototype.setAlwaysCollapsed=function(value){this.isAlwaysCollapsed_=!!value;if(this.isAlwaysCollapsed_){this.collapse_()}else{this.maybeCollapseBar_()}};MDCShortTopAppBarFoundation.prototype.getAlwaysCollapsed=function(){return this.isAlwaysCollapsed_};MDCShortTopAppBarFoundation.prototype.handleTargetScroll=function(){this.maybeCollapseBar_()};MDCShortTopAppBarFoundation.prototype.maybeCollapseBar_=function(){if(this.isAlwaysCollapsed_){return}var currentScroll=this.adapter.getViewportScrollY();if(currentScroll<=0){if(this.isCollapsed_){this.uncollapse_()}}else{if(!this.isCollapsed_){this.collapse_()}}};MDCShortTopAppBarFoundation.prototype.uncollapse_=function(){this.adapter.removeClass(top_app_bar_constants_cssClasses.SHORT_COLLAPSED_CLASS);this.isCollapsed_=false};MDCShortTopAppBarFoundation.prototype.collapse_=function(){this.adapter.addClass(top_app_bar_constants_cssClasses.SHORT_COLLAPSED_CLASS);this.isCollapsed_=true};return MDCShortTopAppBarFoundation}(MDCTopAppBarBaseFoundation);const short_foundation=null&&MDCShortTopAppBarFoundation;
/**
 * @license
 * Copyright 2018 Google Inc.
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
 */
var MDCTopAppBar=function(_super){__extends(MDCTopAppBar,_super);function MDCTopAppBar(){return _super!==null&&_super.apply(this,arguments)||this}MDCTopAppBar.attachTo=function(root){return new MDCTopAppBar(root)};MDCTopAppBar.prototype.initialize=function(rippleFactory){if(rippleFactory===void 0){rippleFactory=function(el){return MDCRipple.attachTo(el)}}this.navIcon_=this.root.querySelector(top_app_bar_constants_strings.NAVIGATION_ICON_SELECTOR);var icons=[].slice.call(this.root.querySelectorAll(top_app_bar_constants_strings.ACTION_ITEM_SELECTOR));if(this.navIcon_){icons.push(this.navIcon_)}this.iconRipples_=icons.map((function(icon){var ripple=rippleFactory(icon);ripple.unbounded=true;return ripple}));this.scrollTarget_=window};MDCTopAppBar.prototype.initialSyncWithDOM=function(){this.handleNavigationClick_=this.foundation.handleNavigationClick.bind(this.foundation);this.handleWindowResize_=this.foundation.handleWindowResize.bind(this.foundation);this.handleTargetScroll_=this.foundation.handleTargetScroll.bind(this.foundation);this.scrollTarget_.addEventListener("scroll",this.handleTargetScroll_);if(this.navIcon_){this.navIcon_.addEventListener("click",this.handleNavigationClick_)}var isFixed=this.root.classList.contains(top_app_bar_constants_cssClasses.FIXED_CLASS);var isShort=this.root.classList.contains(top_app_bar_constants_cssClasses.SHORT_CLASS);if(!isShort&&!isFixed){window.addEventListener("resize",this.handleWindowResize_)}};MDCTopAppBar.prototype.destroy=function(){this.iconRipples_.forEach((function(iconRipple){return iconRipple.destroy()}));this.scrollTarget_.removeEventListener("scroll",this.handleTargetScroll_);if(this.navIcon_){this.navIcon_.removeEventListener("click",this.handleNavigationClick_)}var isFixed=this.root.classList.contains(top_app_bar_constants_cssClasses.FIXED_CLASS);var isShort=this.root.classList.contains(top_app_bar_constants_cssClasses.SHORT_CLASS);if(!isShort&&!isFixed){window.removeEventListener("resize",this.handleWindowResize_)}_super.prototype.destroy.call(this)};MDCTopAppBar.prototype.setScrollTarget=function(target){this.scrollTarget_.removeEventListener("scroll",this.handleTargetScroll_);this.scrollTarget_=target;this.handleTargetScroll_=this.foundation.handleTargetScroll.bind(this.foundation);this.scrollTarget_.addEventListener("scroll",this.handleTargetScroll_)};MDCTopAppBar.prototype.getDefaultFoundation=function(){var _this=this;var adapter={hasClass:function(className){return _this.root.classList.contains(className)},addClass:function(className){return _this.root.classList.add(className)},removeClass:function(className){return _this.root.classList.remove(className)},setStyle:function(property,value){return _this.root.style.setProperty(property,value)},getTopAppBarHeight:function(){return _this.root.clientHeight},notifyNavigationIconClicked:function(){return _this.emit(top_app_bar_constants_strings.NAVIGATION_EVENT,{})},getViewportScrollY:function(){var win=_this.scrollTarget_;var el=_this.scrollTarget_;return win.pageYOffset!==undefined?win.pageYOffset:el.scrollTop},getTotalActionItems:function(){return _this.root.querySelectorAll(top_app_bar_constants_strings.ACTION_ITEM_SELECTOR).length}};var foundation;if(this.root.classList.contains(top_app_bar_constants_cssClasses.SHORT_CLASS)){foundation=new MDCShortTopAppBarFoundation(adapter)}else if(this.root.classList.contains(top_app_bar_constants_cssClasses.FIXED_CLASS)){foundation=new MDCFixedTopAppBarFoundation(adapter)}else{foundation=new MDCTopAppBarFoundation(adapter)}return foundation};return MDCTopAppBar}(MDCComponent);function MBTopAppBar_init(elem,scrollTarget){if(!elem){return}elem._topAppBar=MDCTopAppBar.attachTo(elem);if(scrollTarget){elem._topAppBar.setScrollTarget(document.querySelector(scrollTarget))}}var batching=__webpack_require__(36);window.MaterialBlazor={Batching:batching,MBAutoCompleteTextField:MBAutocompleteTextField_namespaceObject,MBBladeSet:MBBladeSet_namespaceObject,MBButton:MBButton_namespaceObject,MBCard:MBCard_namespaceObject,MBChipsSelectMulti:MBChipsSelectMulti_namespaceObject,MBCheckbox:MBCheckbox_namespaceObject,MBCircularProgress:MBCircularProgress_namespaceObject,MBDataTable:MBDataTable_namespaceObject,MBDatePicker:MBDatePicker_namespaceObject,MBDialog:MBDialog_namespaceObject,MBDrawer:MBDrawer_namespaceObject,MBFloatingActionButton:MBFloatingActionButton_namespaceObject,MBGrid:MBGrid_namespaceObject,MBIconButton:MBIconButton_namespaceObject,MBIconButtonToggle:MBIconButtonToggle_namespaceObject,MBLinearProgress:MBLinearProgress_namespaceObject,MBList:MBList_namespaceObject,MBMenu:MBMenu_namespaceObject,MBMenuSurface:MBMenuSurface_namespaceObject,MBRadioButton:MBRadioButton_namespaceObject,MBSegmentedButtonMulti:MBSegmentedButtonMulti_namespaceObject,MBSelect:MBSelect_namespaceObject,MBSlider:MBSlider_namespaceObject,MBSnackbar:MBSnackbar_namespaceObject,MBSwitch:MBSwitch_namespaceObject,MBTabBar:MBTabBar_namespaceObject,MBTextField:MBTextField_namespaceObject,MBTooltip:MBTooltip_namespaceObject,MBTopAppBar:MBTopAppBar_namespaceObject}})()})();