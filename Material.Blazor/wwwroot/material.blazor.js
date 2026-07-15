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

//#region node_modules/.pnpm/tslib@2.8.1/node_modules/tslib/tslib.es6.mjs
/******************************************************************************
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
	var extendStatics = function(d, b) {
		extendStatics = Object.setPrototypeOf || { __proto__: [] } instanceof Array && function(d, b) {
			d.__proto__ = b;
		} || function(d, b) {
			for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p];
		};
		return extendStatics(d, b);
	};
	function __extends(d, b) {
		if (typeof b !== "function" && b !== null) throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
		extendStatics(d, b);
		function __() {
			this.constructor = d;
		}
		d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
	}
	var __assign = function() {
		__assign = Object.assign || function __assign(t) {
			for (var s, i = 1, n = arguments.length; i < n; i++) {
				s = arguments[i];
				for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p)) t[p] = s[p];
			}
			return t;
		};
		return __assign.apply(this, arguments);
	};
	function __awaiter(thisArg, _arguments, P, generator) {
		function adopt(value) {
			return value instanceof P ? value : new P(function(resolve) {
				resolve(value);
			});
		}
		return new (P || (P = Promise))(function(resolve, reject) {
			function fulfilled(value) {
				try {
					step(generator.next(value));
				} catch (e) {
					reject(e);
				}
			}
			function rejected(value) {
				try {
					step(generator["throw"](value));
				} catch (e) {
					reject(e);
				}
			}
			function step(result) {
				result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected);
			}
			step((generator = generator.apply(thisArg, _arguments || [])).next());
		});
	}
	function __generator(thisArg, body) {
		var _ = {
			label: 0,
			sent: function() {
				if (t[0] & 1) throw t[1];
				return t[1];
			},
			trys: [],
			ops: []
		}, f, y, t, g = Object.create((typeof Iterator === "function" ? Iterator : Object).prototype);
		return g.next = verb(0), g["throw"] = verb(1), g["return"] = verb(2), typeof Symbol === "function" && (g[Symbol.iterator] = function() {
			return this;
		}), g;
		function verb(n) {
			return function(v) {
				return step([n, v]);
			};
		}
		function step(op) {
			if (f) throw new TypeError("Generator is already executing.");
			while (g && (g = 0, op[0] && (_ = 0)), _) try {
				if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
				if (y = 0, t) op = [op[0] & 2, t.value];
				switch (op[0]) {
					case 0:
					case 1:
						t = op;
						break;
					case 4:
						_.label++;
						return {
							value: op[1],
							done: false
						};
					case 5:
						_.label++;
						y = op[1];
						op = [0];
						continue;
					case 7:
						op = _.ops.pop();
						_.trys.pop();
						continue;
					default:
						if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) {
							_ = 0;
							continue;
						}
						if (op[0] === 3 && (!t || op[1] > t[0] && op[1] < t[3])) {
							_.label = op[1];
							break;
						}
						if (op[0] === 6 && _.label < t[1]) {
							_.label = t[1];
							t = op;
							break;
						}
						if (t && _.label < t[2]) {
							_.label = t[2];
							_.ops.push(op);
							break;
						}
						if (t[2]) _.ops.pop();
						_.trys.pop();
						continue;
				}
				op = body.call(thisArg, _);
			} catch (e) {
				op = [6, e];
				y = 0;
			} finally {
				f = t = 0;
			}
			if (op[0] & 5) throw op[1];
			return {
				value: op[0] ? op[1] : void 0,
				done: true
			};
		}
	}
	function __values(o) {
		var s = typeof Symbol === "function" && Symbol.iterator, m = s && o[s], i = 0;
		if (m) return m.call(o);
		if (o && typeof o.length === "number") return { next: function() {
			if (o && i >= o.length) o = void 0;
			return {
				value: o && o[i++],
				done: !o
			};
		} };
		throw new TypeError(s ? "Object is not iterable." : "Symbol.iterator is not defined.");
	}
	function __read(o, n) {
		var m = typeof Symbol === "function" && o[Symbol.iterator];
		if (!m) return o;
		var i = m.call(o), r, ar = [], e;
		try {
			while ((n === void 0 || n-- > 0) && !(r = i.next()).done) ar.push(r.value);
		} catch (error) {
			e = { error };
		} finally {
			try {
				if (r && !r.done && (m = i["return"])) m.call(i);
			} finally {
				if (e) throw e.error;
			}
		}
		return ar;
	}
	function __spreadArray(to, from, pack) {
		if (pack || arguments.length === 2) {
			for (var i = 0, l = from.length, ar; i < l; i++) if (ar || !(i in from)) {
				if (!ar) ar = Array.prototype.slice.call(from, 0, i);
				ar[i] = from[i];
			}
		}
		return to.concat(ar || Array.prototype.slice.call(from));
	}

//#endregion
//#region node_modules/.pnpm/@material+base@14.0.0/node_modules/@material/base/foundation.js
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
	var MDCFoundation = function() {
		function MDCFoundation(adapter) {
			if (adapter === void 0) adapter = {};
			this.adapter = adapter;
		}
		Object.defineProperty(MDCFoundation, "cssClasses", {
			get: function() {
				return {};
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCFoundation, "strings", {
			get: function() {
				return {};
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCFoundation, "numbers", {
			get: function() {
				return {};
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCFoundation, "defaultAdapter", {
			get: function() {
				return {};
			},
			enumerable: false,
			configurable: true
		});
		MDCFoundation.prototype.init = function() {};
		MDCFoundation.prototype.destroy = function() {};
		return MDCFoundation;
	}();

//#endregion
//#region node_modules/.pnpm/@material+base@14.0.0/node_modules/@material/base/component.js
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
	var MDCComponent = function() {
		function MDCComponent(root, foundation) {
			var args = [];
			for (var _i = 2; _i < arguments.length; _i++) args[_i - 2] = arguments[_i];
			this.root = root;
			this.initialize.apply(this, __spreadArray([], __read(args)));
			this.foundation = foundation === void 0 ? this.getDefaultFoundation() : foundation;
			this.foundation.init();
			this.initialSyncWithDOM();
		}
		MDCComponent.attachTo = function(root) {
			return new MDCComponent(root, new MDCFoundation({}));
		};
		/* istanbul ignore next: method param only exists for typing purposes; it does not need to be unit tested */
		MDCComponent.prototype.initialize = function() {
			var _args = [];
			for (var _i = 0; _i < arguments.length; _i++) _args[_i] = arguments[_i];
		};
		MDCComponent.prototype.getDefaultFoundation = function() {
			throw new Error("Subclasses must override getDefaultFoundation to return a properly configured foundation class");
		};
		MDCComponent.prototype.initialSyncWithDOM = function() {};
		MDCComponent.prototype.destroy = function() {
			this.foundation.destroy();
		};
		MDCComponent.prototype.listen = function(evtType, handler, options) {
			this.root.addEventListener(evtType, handler, options);
		};
		MDCComponent.prototype.unlisten = function(evtType, handler, options) {
			this.root.removeEventListener(evtType, handler, options);
		};
		/**
		* Fires a cross-browser-compatible custom event from the component root of the given type, with the given data.
		*/
		MDCComponent.prototype.emit = function(evtType, evtData, shouldBubble) {
			if (shouldBubble === void 0) shouldBubble = false;
			var evt;
			if (typeof CustomEvent === "function") evt = new CustomEvent(evtType, {
				bubbles: shouldBubble,
				detail: evtData
			});
			else {
				evt = document.createEvent("CustomEvent");
				evt.initCustomEvent(evtType, shouldBubble, false, evtData);
			}
			this.root.dispatchEvent(evt);
		};
		return MDCComponent;
	}();

//#endregion
//#region node_modules/.pnpm/@material+dom@14.0.0/node_modules/@material/dom/events.js
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
	/**
	* Determine whether the current browser supports passive event listeners, and
	* if so, use them.
	*/
	function applyPassive(globalObj) {
		if (globalObj === void 0) globalObj = window;
		return supportsPassiveOption(globalObj) ? { passive: true } : false;
	}
	function supportsPassiveOption(globalObj) {
		if (globalObj === void 0) globalObj = window;
		var passiveSupported = false;
		try {
			var options = { get passive() {
				passiveSupported = true;
				return false;
			} };
			var handler = function() {};
			globalObj.document.addEventListener("test", handler, options);
			globalObj.document.removeEventListener("test", handler, options);
		} catch (err) {
			passiveSupported = false;
		}
		return passiveSupported;
	}

//#endregion
//#region node_modules/.pnpm/@material+dom@14.0.0/node_modules/@material/dom/ponyfill.js
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
	/**
	* @fileoverview A "ponyfill" is a polyfill that doesn't modify the global prototype chain.
	* This makes ponyfills safer than traditional polyfills, especially for libraries like MDC.
	*/
	function closest(element, selector) {
		if (element.closest) return element.closest(selector);
		var el = element;
		while (el) {
			if (matches(el, selector)) return el;
			el = el.parentElement;
		}
		return null;
	}
	function matches(element, selector) {
		return (element.matches || element.webkitMatchesSelector || element.msMatchesSelector).call(element, selector);
	}
	/**
	* Used to compute the estimated scroll width of elements. When an element is
	* hidden due to display: none; being applied to a parent element, the width is
	* returned as 0. However, the element will have a true width once no longer
	* inside a display: none context. This method computes an estimated width when
	* the element is hidden or returns the true width when the element is visble.
	* @param {Element} element the element whose width to estimate
	*/
	function estimateScrollWidth(element) {
		var htmlEl = element;
		if (htmlEl.offsetParent !== null) return htmlEl.scrollWidth;
		var clone = htmlEl.cloneNode(true);
		clone.style.setProperty("position", "absolute");
		clone.style.setProperty("transform", "translate(-9999px, -9999px)");
		document.documentElement.appendChild(clone);
		var scrollWidth = clone.scrollWidth;
		document.documentElement.removeChild(clone);
		return scrollWidth;
	}

//#endregion
//#region node_modules/.pnpm/@material+floating-label@14.0.0/node_modules/@material/floating-label/constants.js
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
	var cssClasses$30 = {
		LABEL_FLOAT_ABOVE: "mdc-floating-label--float-above",
		LABEL_REQUIRED: "mdc-floating-label--required",
		LABEL_SHAKE: "mdc-floating-label--shake",
		ROOT: "mdc-floating-label"
	};

//#endregion
//#region node_modules/.pnpm/@material+floating-label@14.0.0/node_modules/@material/floating-label/foundation.js
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
	var MDCFloatingLabelFoundation = function(_super) {
		__extends(MDCFloatingLabelFoundation, _super);
		function MDCFloatingLabelFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCFloatingLabelFoundation.defaultAdapter), adapter)) || this;
			_this.shakeAnimationEndHandler = function() {
				_this.handleShakeAnimationEnd();
			};
			return _this;
		}
		Object.defineProperty(MDCFloatingLabelFoundation, "cssClasses", {
			get: function() {
				return cssClasses$30;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCFloatingLabelFoundation, "defaultAdapter", {
			/**
			* See {@link MDCFloatingLabelAdapter} for typing information on parameters and return types.
			*/
			get: function() {
				return {
					addClass: function() {},
					removeClass: function() {},
					getWidth: function() {
						return 0;
					},
					registerInteractionHandler: function() {},
					deregisterInteractionHandler: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCFloatingLabelFoundation.prototype.init = function() {
			this.adapter.registerInteractionHandler("animationend", this.shakeAnimationEndHandler);
		};
		MDCFloatingLabelFoundation.prototype.destroy = function() {
			this.adapter.deregisterInteractionHandler("animationend", this.shakeAnimationEndHandler);
		};
		/**
		* Returns the width of the label element.
		*/
		MDCFloatingLabelFoundation.prototype.getWidth = function() {
			return this.adapter.getWidth();
		};
		/**
		* Styles the label to produce a shake animation to indicate an error.
		* @param shouldShake If true, adds the shake CSS class; otherwise, removes shake class.
		*/
		MDCFloatingLabelFoundation.prototype.shake = function(shouldShake) {
			var LABEL_SHAKE = MDCFloatingLabelFoundation.cssClasses.LABEL_SHAKE;
			if (shouldShake) this.adapter.addClass(LABEL_SHAKE);
			else this.adapter.removeClass(LABEL_SHAKE);
		};
		/**
		* Styles the label to float or dock.
		* @param shouldFloat If true, adds the float CSS class; otherwise, removes float and shake classes to dock the label.
		*/
		MDCFloatingLabelFoundation.prototype.float = function(shouldFloat) {
			var _a = MDCFloatingLabelFoundation.cssClasses, LABEL_FLOAT_ABOVE = _a.LABEL_FLOAT_ABOVE, LABEL_SHAKE = _a.LABEL_SHAKE;
			if (shouldFloat) this.adapter.addClass(LABEL_FLOAT_ABOVE);
			else {
				this.adapter.removeClass(LABEL_FLOAT_ABOVE);
				this.adapter.removeClass(LABEL_SHAKE);
			}
		};
		/**
		* Styles the label as required.
		* @param isRequired If true, adds an asterisk to the label, indicating that it is required.
		*/
		MDCFloatingLabelFoundation.prototype.setRequired = function(isRequired) {
			var LABEL_REQUIRED = MDCFloatingLabelFoundation.cssClasses.LABEL_REQUIRED;
			if (isRequired) this.adapter.addClass(LABEL_REQUIRED);
			else this.adapter.removeClass(LABEL_REQUIRED);
		};
		MDCFloatingLabelFoundation.prototype.handleShakeAnimationEnd = function() {
			var LABEL_SHAKE = MDCFloatingLabelFoundation.cssClasses.LABEL_SHAKE;
			this.adapter.removeClass(LABEL_SHAKE);
		};
		return MDCFloatingLabelFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+floating-label@14.0.0/node_modules/@material/floating-label/component.js
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
	var MDCFloatingLabel = function(_super) {
		__extends(MDCFloatingLabel, _super);
		function MDCFloatingLabel() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCFloatingLabel.attachTo = function(root) {
			return new MDCFloatingLabel(root);
		};
		/**
		* Styles the label to produce the label shake for errors.
		* @param shouldShake If true, shakes the label by adding a CSS class; otherwise, stops shaking by removing the class.
		*/
		MDCFloatingLabel.prototype.shake = function(shouldShake) {
			this.foundation.shake(shouldShake);
		};
		/**
		* Styles the label to float/dock.
		* @param shouldFloat If true, floats the label by adding a CSS class; otherwise, docks it by removing the class.
		*/
		MDCFloatingLabel.prototype.float = function(shouldFloat) {
			this.foundation.float(shouldFloat);
		};
		/**
		* Styles the label as required.
		* @param isRequired If true, adds an asterisk to the label, indicating that it is required.
		*/
		MDCFloatingLabel.prototype.setRequired = function(isRequired) {
			this.foundation.setRequired(isRequired);
		};
		MDCFloatingLabel.prototype.getWidth = function() {
			return this.foundation.getWidth();
		};
		MDCFloatingLabel.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCFloatingLabelFoundation({
				addClass: function(className) {
					return _this.root.classList.add(className);
				},
				removeClass: function(className) {
					return _this.root.classList.remove(className);
				},
				getWidth: function() {
					return estimateScrollWidth(_this.root);
				},
				registerInteractionHandler: function(evtType, handler) {
					return _this.listen(evtType, handler);
				},
				deregisterInteractionHandler: function(evtType, handler) {
					return _this.unlisten(evtType, handler);
				}
			});
		};
		return MDCFloatingLabel;
	}(MDCComponent);

//#endregion
//#region node_modules/.pnpm/@material+line-ripple@14.0.0/node_modules/@material/line-ripple/constants.js
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
	var cssClasses$29 = {
		LINE_RIPPLE_ACTIVE: "mdc-line-ripple--active",
		LINE_RIPPLE_DEACTIVATING: "mdc-line-ripple--deactivating"
	};

//#endregion
//#region node_modules/.pnpm/@material+line-ripple@14.0.0/node_modules/@material/line-ripple/foundation.js
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
	var MDCLineRippleFoundation = function(_super) {
		__extends(MDCLineRippleFoundation, _super);
		function MDCLineRippleFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCLineRippleFoundation.defaultAdapter), adapter)) || this;
			_this.transitionEndHandler = function(evt) {
				_this.handleTransitionEnd(evt);
			};
			return _this;
		}
		Object.defineProperty(MDCLineRippleFoundation, "cssClasses", {
			get: function() {
				return cssClasses$29;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCLineRippleFoundation, "defaultAdapter", {
			/**
			* See {@link MDCLineRippleAdapter} for typing information on parameters and return types.
			*/
			get: function() {
				return {
					addClass: function() {},
					removeClass: function() {},
					hasClass: function() {
						return false;
					},
					setStyle: function() {},
					registerEventHandler: function() {},
					deregisterEventHandler: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCLineRippleFoundation.prototype.init = function() {
			this.adapter.registerEventHandler("transitionend", this.transitionEndHandler);
		};
		MDCLineRippleFoundation.prototype.destroy = function() {
			this.adapter.deregisterEventHandler("transitionend", this.transitionEndHandler);
		};
		MDCLineRippleFoundation.prototype.activate = function() {
			this.adapter.removeClass(cssClasses$29.LINE_RIPPLE_DEACTIVATING);
			this.adapter.addClass(cssClasses$29.LINE_RIPPLE_ACTIVE);
		};
		MDCLineRippleFoundation.prototype.setRippleCenter = function(xCoordinate) {
			this.adapter.setStyle("transform-origin", xCoordinate + "px center");
		};
		MDCLineRippleFoundation.prototype.deactivate = function() {
			this.adapter.addClass(cssClasses$29.LINE_RIPPLE_DEACTIVATING);
		};
		MDCLineRippleFoundation.prototype.handleTransitionEnd = function(evt) {
			var isDeactivating = this.adapter.hasClass(cssClasses$29.LINE_RIPPLE_DEACTIVATING);
			if (evt.propertyName === "opacity") {
				if (isDeactivating) {
					this.adapter.removeClass(cssClasses$29.LINE_RIPPLE_ACTIVE);
					this.adapter.removeClass(cssClasses$29.LINE_RIPPLE_DEACTIVATING);
				}
			}
		};
		return MDCLineRippleFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+line-ripple@14.0.0/node_modules/@material/line-ripple/component.js
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
	var MDCLineRipple = function(_super) {
		__extends(MDCLineRipple, _super);
		function MDCLineRipple() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCLineRipple.attachTo = function(root) {
			return new MDCLineRipple(root);
		};
		/**
		* Activates the line ripple
		*/
		MDCLineRipple.prototype.activate = function() {
			this.foundation.activate();
		};
		/**
		* Deactivates the line ripple
		*/
		MDCLineRipple.prototype.deactivate = function() {
			this.foundation.deactivate();
		};
		/**
		* Sets the transform origin given a user's click location.
		* The `rippleCenter` is the x-coordinate of the middle of the ripple.
		*/
		MDCLineRipple.prototype.setRippleCenter = function(xCoordinate) {
			this.foundation.setRippleCenter(xCoordinate);
		};
		MDCLineRipple.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCLineRippleFoundation({
				addClass: function(className) {
					return _this.root.classList.add(className);
				},
				removeClass: function(className) {
					return _this.root.classList.remove(className);
				},
				hasClass: function(className) {
					return _this.root.classList.contains(className);
				},
				setStyle: function(propertyName, value) {
					return _this.root.style.setProperty(propertyName, value);
				},
				registerEventHandler: function(evtType, handler) {
					return _this.listen(evtType, handler);
				},
				deregisterEventHandler: function(evtType, handler) {
					return _this.unlisten(evtType, handler);
				}
			});
		};
		return MDCLineRipple;
	}(MDCComponent);

//#endregion
//#region node_modules/.pnpm/@material+notched-outline@14.0.0/node_modules/@material/notched-outline/constants.js
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
	var strings$32 = { NOTCH_ELEMENT_SELECTOR: ".mdc-notched-outline__notch" };
	var numbers$13 = { NOTCH_ELEMENT_PADDING: 8 };
	var cssClasses$28 = {
		NO_LABEL: "mdc-notched-outline--no-label",
		OUTLINE_NOTCHED: "mdc-notched-outline--notched",
		OUTLINE_UPGRADED: "mdc-notched-outline--upgraded"
	};

//#endregion
//#region node_modules/.pnpm/@material+notched-outline@14.0.0/node_modules/@material/notched-outline/foundation.js
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
	var MDCNotchedOutlineFoundation = function(_super) {
		__extends(MDCNotchedOutlineFoundation, _super);
		function MDCNotchedOutlineFoundation(adapter) {
			return _super.call(this, __assign(__assign({}, MDCNotchedOutlineFoundation.defaultAdapter), adapter)) || this;
		}
		Object.defineProperty(MDCNotchedOutlineFoundation, "strings", {
			get: function() {
				return strings$32;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCNotchedOutlineFoundation, "cssClasses", {
			get: function() {
				return cssClasses$28;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCNotchedOutlineFoundation, "numbers", {
			get: function() {
				return numbers$13;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCNotchedOutlineFoundation, "defaultAdapter", {
			/**
			* See {@link MDCNotchedOutlineAdapter} for typing information on parameters and return types.
			*/
			get: function() {
				return {
					addClass: function() {},
					removeClass: function() {},
					setNotchWidthProperty: function() {},
					removeNotchWidthProperty: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		/**
		* Adds the outline notched selector and updates the notch width calculated based off of notchWidth.
		*/
		MDCNotchedOutlineFoundation.prototype.notch = function(notchWidth) {
			var OUTLINE_NOTCHED = MDCNotchedOutlineFoundation.cssClasses.OUTLINE_NOTCHED;
			if (notchWidth > 0) notchWidth += numbers$13.NOTCH_ELEMENT_PADDING;
			this.adapter.setNotchWidthProperty(notchWidth);
			this.adapter.addClass(OUTLINE_NOTCHED);
		};
		/**
		* Removes notched outline selector to close the notch in the outline.
		*/
		MDCNotchedOutlineFoundation.prototype.closeNotch = function() {
			var OUTLINE_NOTCHED = MDCNotchedOutlineFoundation.cssClasses.OUTLINE_NOTCHED;
			this.adapter.removeClass(OUTLINE_NOTCHED);
			this.adapter.removeNotchWidthProperty();
		};
		return MDCNotchedOutlineFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+notched-outline@14.0.0/node_modules/@material/notched-outline/component.js
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
	var MDCNotchedOutline = function(_super) {
		__extends(MDCNotchedOutline, _super);
		function MDCNotchedOutline() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCNotchedOutline.attachTo = function(root) {
			return new MDCNotchedOutline(root);
		};
		MDCNotchedOutline.prototype.initialSyncWithDOM = function() {
			this.notchElement = this.root.querySelector(strings$32.NOTCH_ELEMENT_SELECTOR);
			var label = this.root.querySelector("." + MDCFloatingLabelFoundation.cssClasses.ROOT);
			if (label) {
				label.style.transitionDuration = "0s";
				this.root.classList.add(cssClasses$28.OUTLINE_UPGRADED);
				requestAnimationFrame(function() {
					label.style.transitionDuration = "";
				});
			} else this.root.classList.add(cssClasses$28.NO_LABEL);
		};
		/**
		* Updates classes and styles to open the notch to the specified width.
		* @param notchWidth The notch width in the outline.
		*/
		MDCNotchedOutline.prototype.notch = function(notchWidth) {
			this.foundation.notch(notchWidth);
		};
		/**
		* Updates classes and styles to close the notch.
		*/
		MDCNotchedOutline.prototype.closeNotch = function() {
			this.foundation.closeNotch();
		};
		MDCNotchedOutline.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCNotchedOutlineFoundation({
				addClass: function(className) {
					return _this.root.classList.add(className);
				},
				removeClass: function(className) {
					return _this.root.classList.remove(className);
				},
				setNotchWidthProperty: function(width) {
					_this.notchElement.style.setProperty("width", width + "px");
				},
				removeNotchWidthProperty: function() {
					_this.notchElement.style.removeProperty("width");
				}
			});
		};
		return MDCNotchedOutline;
	}(MDCComponent);

//#endregion
//#region node_modules/.pnpm/@material+ripple@14.0.0/node_modules/@material/ripple/constants.js
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
	var cssClasses$27 = {
		BG_FOCUSED: "mdc-ripple-upgraded--background-focused",
		FG_ACTIVATION: "mdc-ripple-upgraded--foreground-activation",
		FG_DEACTIVATION: "mdc-ripple-upgraded--foreground-deactivation",
		ROOT: "mdc-ripple-upgraded",
		UNBOUNDED: "mdc-ripple-upgraded--unbounded"
	};
	var strings$31 = {
		VAR_FG_SCALE: "--mdc-ripple-fg-scale",
		VAR_FG_SIZE: "--mdc-ripple-fg-size",
		VAR_FG_TRANSLATE_END: "--mdc-ripple-fg-translate-end",
		VAR_FG_TRANSLATE_START: "--mdc-ripple-fg-translate-start",
		VAR_LEFT: "--mdc-ripple-left",
		VAR_TOP: "--mdc-ripple-top"
	};
	var numbers$12 = {
		DEACTIVATION_TIMEOUT_MS: 225,
		FG_DEACTIVATION_MS: 150,
		INITIAL_ORIGIN_SCALE: .6,
		PADDING: 10,
		TAP_DELAY_MS: 300
	};

//#endregion
//#region node_modules/.pnpm/@material+ripple@14.0.0/node_modules/@material/ripple/util.js
/**
	* Stores result from supportsCssVariables to avoid redundant processing to
	* detect CSS custom variable support.
	*/
	var supportsCssVariables_;
	function supportsCssVariables(windowObj, forceRefresh) {
		if (forceRefresh === void 0) forceRefresh = false;
		var CSS = windowObj.CSS;
		var supportsCssVars = supportsCssVariables_;
		if (typeof supportsCssVariables_ === "boolean" && !forceRefresh) return supportsCssVariables_;
		if (!(CSS && typeof CSS.supports === "function")) return false;
		var explicitlySupportsCssVars = CSS.supports("--css-vars", "yes");
		var weAreFeatureDetectingSafari10plus = CSS.supports("(--css-vars: yes)") && CSS.supports("color", "#00000000");
		supportsCssVars = explicitlySupportsCssVars || weAreFeatureDetectingSafari10plus;
		if (!forceRefresh) supportsCssVariables_ = supportsCssVars;
		return supportsCssVars;
	}
	function getNormalizedEventCoords(evt, pageOffset, clientRect) {
		if (!evt) return {
			x: 0,
			y: 0
		};
		var x = pageOffset.x, y = pageOffset.y;
		var documentX = x + clientRect.left;
		var documentY = y + clientRect.top;
		var normalizedX;
		var normalizedY;
		if (evt.type === "touchstart") {
			var touchEvent = evt;
			normalizedX = touchEvent.changedTouches[0].pageX - documentX;
			normalizedY = touchEvent.changedTouches[0].pageY - documentY;
		} else {
			var mouseEvent = evt;
			normalizedX = mouseEvent.pageX - documentX;
			normalizedY = mouseEvent.pageY - documentY;
		}
		return {
			x: normalizedX,
			y: normalizedY
		};
	}

//#endregion
//#region node_modules/.pnpm/@material+ripple@14.0.0/node_modules/@material/ripple/foundation.js
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
	var ACTIVATION_EVENT_TYPES = [
		"touchstart",
		"pointerdown",
		"mousedown",
		"keydown"
	];
	var POINTER_DEACTIVATION_EVENT_TYPES = [
		"touchend",
		"pointerup",
		"mouseup",
		"contextmenu"
	];
	var activatedTargets = [];
	var MDCRippleFoundation = function(_super) {
		__extends(MDCRippleFoundation, _super);
		function MDCRippleFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCRippleFoundation.defaultAdapter), adapter)) || this;
			_this.activationAnimationHasEnded = false;
			_this.activationTimer = 0;
			_this.fgDeactivationRemovalTimer = 0;
			_this.fgScale = "0";
			_this.frame = {
				width: 0,
				height: 0
			};
			_this.initialSize = 0;
			_this.layoutFrame = 0;
			_this.maxRadius = 0;
			_this.unboundedCoords = {
				left: 0,
				top: 0
			};
			_this.activationState = _this.defaultActivationState();
			_this.activationTimerCallback = function() {
				_this.activationAnimationHasEnded = true;
				_this.runDeactivationUXLogicIfReady();
			};
			_this.activateHandler = function(e) {
				_this.activateImpl(e);
			};
			_this.deactivateHandler = function() {
				_this.deactivateImpl();
			};
			_this.focusHandler = function() {
				_this.handleFocus();
			};
			_this.blurHandler = function() {
				_this.handleBlur();
			};
			_this.resizeHandler = function() {
				_this.layout();
			};
			return _this;
		}
		Object.defineProperty(MDCRippleFoundation, "cssClasses", {
			get: function() {
				return cssClasses$27;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCRippleFoundation, "strings", {
			get: function() {
				return strings$31;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCRippleFoundation, "numbers", {
			get: function() {
				return numbers$12;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCRippleFoundation, "defaultAdapter", {
			get: function() {
				return {
					addClass: function() {},
					browserSupportsCssVars: function() {
						return true;
					},
					computeBoundingRect: function() {
						return {
							top: 0,
							right: 0,
							bottom: 0,
							left: 0,
							width: 0,
							height: 0
						};
					},
					containsEventTarget: function() {
						return true;
					},
					deregisterDocumentInteractionHandler: function() {},
					deregisterInteractionHandler: function() {},
					deregisterResizeHandler: function() {},
					getWindowPageOffset: function() {
						return {
							x: 0,
							y: 0
						};
					},
					isSurfaceActive: function() {
						return true;
					},
					isSurfaceDisabled: function() {
						return true;
					},
					isUnbounded: function() {
						return true;
					},
					registerDocumentInteractionHandler: function() {},
					registerInteractionHandler: function() {},
					registerResizeHandler: function() {},
					removeClass: function() {},
					updateCssVariable: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCRippleFoundation.prototype.init = function() {
			var _this = this;
			var supportsPressRipple = this.supportsPressRipple();
			this.registerRootHandlers(supportsPressRipple);
			if (supportsPressRipple) {
				var _a = MDCRippleFoundation.cssClasses, ROOT_1 = _a.ROOT, UNBOUNDED_1 = _a.UNBOUNDED;
				requestAnimationFrame(function() {
					_this.adapter.addClass(ROOT_1);
					if (_this.adapter.isUnbounded()) {
						_this.adapter.addClass(UNBOUNDED_1);
						_this.layoutInternal();
					}
				});
			}
		};
		MDCRippleFoundation.prototype.destroy = function() {
			var _this = this;
			if (this.supportsPressRipple()) {
				if (this.activationTimer) {
					clearTimeout(this.activationTimer);
					this.activationTimer = 0;
					this.adapter.removeClass(MDCRippleFoundation.cssClasses.FG_ACTIVATION);
				}
				if (this.fgDeactivationRemovalTimer) {
					clearTimeout(this.fgDeactivationRemovalTimer);
					this.fgDeactivationRemovalTimer = 0;
					this.adapter.removeClass(MDCRippleFoundation.cssClasses.FG_DEACTIVATION);
				}
				var _a = MDCRippleFoundation.cssClasses, ROOT_2 = _a.ROOT, UNBOUNDED_2 = _a.UNBOUNDED;
				requestAnimationFrame(function() {
					_this.adapter.removeClass(ROOT_2);
					_this.adapter.removeClass(UNBOUNDED_2);
					_this.removeCssVars();
				});
			}
			this.deregisterRootHandlers();
			this.deregisterDeactivationHandlers();
		};
		/**
		* @param evt Optional event containing position information.
		*/
		MDCRippleFoundation.prototype.activate = function(evt) {
			this.activateImpl(evt);
		};
		MDCRippleFoundation.prototype.deactivate = function() {
			this.deactivateImpl();
		};
		MDCRippleFoundation.prototype.layout = function() {
			var _this = this;
			if (this.layoutFrame) cancelAnimationFrame(this.layoutFrame);
			this.layoutFrame = requestAnimationFrame(function() {
				_this.layoutInternal();
				_this.layoutFrame = 0;
			});
		};
		MDCRippleFoundation.prototype.setUnbounded = function(unbounded) {
			var UNBOUNDED = MDCRippleFoundation.cssClasses.UNBOUNDED;
			if (unbounded) this.adapter.addClass(UNBOUNDED);
			else this.adapter.removeClass(UNBOUNDED);
		};
		MDCRippleFoundation.prototype.handleFocus = function() {
			var _this = this;
			requestAnimationFrame(function() {
				return _this.adapter.addClass(MDCRippleFoundation.cssClasses.BG_FOCUSED);
			});
		};
		MDCRippleFoundation.prototype.handleBlur = function() {
			var _this = this;
			requestAnimationFrame(function() {
				return _this.adapter.removeClass(MDCRippleFoundation.cssClasses.BG_FOCUSED);
			});
		};
		/**
		* We compute this property so that we are not querying information about the client
		* until the point in time where the foundation requests it. This prevents scenarios where
		* client-side feature-detection may happen too early, such as when components are rendered on the server
		* and then initialized at mount time on the client.
		*/
		MDCRippleFoundation.prototype.supportsPressRipple = function() {
			return this.adapter.browserSupportsCssVars();
		};
		MDCRippleFoundation.prototype.defaultActivationState = function() {
			return {
				activationEvent: void 0,
				hasDeactivationUXRun: false,
				isActivated: false,
				isProgrammatic: false,
				wasActivatedByPointer: false,
				wasElementMadeActive: false
			};
		};
		/**
		* supportsPressRipple Passed from init to save a redundant function call
		*/
		MDCRippleFoundation.prototype.registerRootHandlers = function(supportsPressRipple) {
			var e_1, _a;
			if (supportsPressRipple) {
				try {
					for (var ACTIVATION_EVENT_TYPES_1 = __values(ACTIVATION_EVENT_TYPES), ACTIVATION_EVENT_TYPES_1_1 = ACTIVATION_EVENT_TYPES_1.next(); !ACTIVATION_EVENT_TYPES_1_1.done; ACTIVATION_EVENT_TYPES_1_1 = ACTIVATION_EVENT_TYPES_1.next()) {
						var evtType = ACTIVATION_EVENT_TYPES_1_1.value;
						this.adapter.registerInteractionHandler(evtType, this.activateHandler);
					}
				} catch (e_1_1) {
					e_1 = { error: e_1_1 };
				} finally {
					try {
						if (ACTIVATION_EVENT_TYPES_1_1 && !ACTIVATION_EVENT_TYPES_1_1.done && (_a = ACTIVATION_EVENT_TYPES_1.return)) _a.call(ACTIVATION_EVENT_TYPES_1);
					} finally {
						if (e_1) throw e_1.error;
					}
				}
				if (this.adapter.isUnbounded()) this.adapter.registerResizeHandler(this.resizeHandler);
			}
			this.adapter.registerInteractionHandler("focus", this.focusHandler);
			this.adapter.registerInteractionHandler("blur", this.blurHandler);
		};
		MDCRippleFoundation.prototype.registerDeactivationHandlers = function(evt) {
			var e_2, _a;
			if (evt.type === "keydown") this.adapter.registerInteractionHandler("keyup", this.deactivateHandler);
			else try {
				for (var POINTER_DEACTIVATION_EVENT_TYPES_1 = __values(POINTER_DEACTIVATION_EVENT_TYPES), POINTER_DEACTIVATION_EVENT_TYPES_1_1 = POINTER_DEACTIVATION_EVENT_TYPES_1.next(); !POINTER_DEACTIVATION_EVENT_TYPES_1_1.done; POINTER_DEACTIVATION_EVENT_TYPES_1_1 = POINTER_DEACTIVATION_EVENT_TYPES_1.next()) {
					var evtType = POINTER_DEACTIVATION_EVENT_TYPES_1_1.value;
					this.adapter.registerDocumentInteractionHandler(evtType, this.deactivateHandler);
				}
			} catch (e_2_1) {
				e_2 = { error: e_2_1 };
			} finally {
				try {
					if (POINTER_DEACTIVATION_EVENT_TYPES_1_1 && !POINTER_DEACTIVATION_EVENT_TYPES_1_1.done && (_a = POINTER_DEACTIVATION_EVENT_TYPES_1.return)) _a.call(POINTER_DEACTIVATION_EVENT_TYPES_1);
				} finally {
					if (e_2) throw e_2.error;
				}
			}
		};
		MDCRippleFoundation.prototype.deregisterRootHandlers = function() {
			var e_3, _a;
			try {
				for (var ACTIVATION_EVENT_TYPES_2 = __values(ACTIVATION_EVENT_TYPES), ACTIVATION_EVENT_TYPES_2_1 = ACTIVATION_EVENT_TYPES_2.next(); !ACTIVATION_EVENT_TYPES_2_1.done; ACTIVATION_EVENT_TYPES_2_1 = ACTIVATION_EVENT_TYPES_2.next()) {
					var evtType = ACTIVATION_EVENT_TYPES_2_1.value;
					this.adapter.deregisterInteractionHandler(evtType, this.activateHandler);
				}
			} catch (e_3_1) {
				e_3 = { error: e_3_1 };
			} finally {
				try {
					if (ACTIVATION_EVENT_TYPES_2_1 && !ACTIVATION_EVENT_TYPES_2_1.done && (_a = ACTIVATION_EVENT_TYPES_2.return)) _a.call(ACTIVATION_EVENT_TYPES_2);
				} finally {
					if (e_3) throw e_3.error;
				}
			}
			this.adapter.deregisterInteractionHandler("focus", this.focusHandler);
			this.adapter.deregisterInteractionHandler("blur", this.blurHandler);
			if (this.adapter.isUnbounded()) this.adapter.deregisterResizeHandler(this.resizeHandler);
		};
		MDCRippleFoundation.prototype.deregisterDeactivationHandlers = function() {
			var e_4, _a;
			this.adapter.deregisterInteractionHandler("keyup", this.deactivateHandler);
			try {
				for (var POINTER_DEACTIVATION_EVENT_TYPES_2 = __values(POINTER_DEACTIVATION_EVENT_TYPES), POINTER_DEACTIVATION_EVENT_TYPES_2_1 = POINTER_DEACTIVATION_EVENT_TYPES_2.next(); !POINTER_DEACTIVATION_EVENT_TYPES_2_1.done; POINTER_DEACTIVATION_EVENT_TYPES_2_1 = POINTER_DEACTIVATION_EVENT_TYPES_2.next()) {
					var evtType = POINTER_DEACTIVATION_EVENT_TYPES_2_1.value;
					this.adapter.deregisterDocumentInteractionHandler(evtType, this.deactivateHandler);
				}
			} catch (e_4_1) {
				e_4 = { error: e_4_1 };
			} finally {
				try {
					if (POINTER_DEACTIVATION_EVENT_TYPES_2_1 && !POINTER_DEACTIVATION_EVENT_TYPES_2_1.done && (_a = POINTER_DEACTIVATION_EVENT_TYPES_2.return)) _a.call(POINTER_DEACTIVATION_EVENT_TYPES_2);
				} finally {
					if (e_4) throw e_4.error;
				}
			}
		};
		MDCRippleFoundation.prototype.removeCssVars = function() {
			var _this = this;
			var rippleStrings = MDCRippleFoundation.strings;
			Object.keys(rippleStrings).forEach(function(key) {
				if (key.indexOf("VAR_") === 0) _this.adapter.updateCssVariable(rippleStrings[key], null);
			});
		};
		MDCRippleFoundation.prototype.activateImpl = function(evt) {
			var _this = this;
			if (this.adapter.isSurfaceDisabled()) return;
			var activationState = this.activationState;
			if (activationState.isActivated) return;
			var previousActivationEvent = this.previousActivationEvent;
			if (previousActivationEvent && evt !== void 0 && previousActivationEvent.type !== evt.type) return;
			activationState.isActivated = true;
			activationState.isProgrammatic = evt === void 0;
			activationState.activationEvent = evt;
			activationState.wasActivatedByPointer = activationState.isProgrammatic ? false : evt !== void 0 && (evt.type === "mousedown" || evt.type === "touchstart" || evt.type === "pointerdown");
			if (evt !== void 0 && activatedTargets.length > 0 && activatedTargets.some(function(target) {
				return _this.adapter.containsEventTarget(target);
			})) {
				this.resetActivationState();
				return;
			}
			if (evt !== void 0) {
				activatedTargets.push(evt.target);
				this.registerDeactivationHandlers(evt);
			}
			activationState.wasElementMadeActive = this.checkElementMadeActive(evt);
			if (activationState.wasElementMadeActive) this.animateActivation();
			requestAnimationFrame(function() {
				activatedTargets = [];
				if (!activationState.wasElementMadeActive && evt !== void 0 && (evt.key === " " || evt.keyCode === 32)) {
					activationState.wasElementMadeActive = _this.checkElementMadeActive(evt);
					if (activationState.wasElementMadeActive) _this.animateActivation();
				}
				if (!activationState.wasElementMadeActive) _this.activationState = _this.defaultActivationState();
			});
		};
		MDCRippleFoundation.prototype.checkElementMadeActive = function(evt) {
			return evt !== void 0 && evt.type === "keydown" ? this.adapter.isSurfaceActive() : true;
		};
		MDCRippleFoundation.prototype.animateActivation = function() {
			var _this = this;
			var _a = MDCRippleFoundation.strings, VAR_FG_TRANSLATE_START = _a.VAR_FG_TRANSLATE_START, VAR_FG_TRANSLATE_END = _a.VAR_FG_TRANSLATE_END;
			var _b = MDCRippleFoundation.cssClasses, FG_DEACTIVATION = _b.FG_DEACTIVATION, FG_ACTIVATION = _b.FG_ACTIVATION;
			var DEACTIVATION_TIMEOUT_MS = MDCRippleFoundation.numbers.DEACTIVATION_TIMEOUT_MS;
			this.layoutInternal();
			var translateStart = "";
			var translateEnd = "";
			if (!this.adapter.isUnbounded()) {
				var _c = this.getFgTranslationCoordinates(), startPoint = _c.startPoint, endPoint = _c.endPoint;
				translateStart = startPoint.x + "px, " + startPoint.y + "px";
				translateEnd = endPoint.x + "px, " + endPoint.y + "px";
			}
			this.adapter.updateCssVariable(VAR_FG_TRANSLATE_START, translateStart);
			this.adapter.updateCssVariable(VAR_FG_TRANSLATE_END, translateEnd);
			clearTimeout(this.activationTimer);
			clearTimeout(this.fgDeactivationRemovalTimer);
			this.rmBoundedActivationClasses();
			this.adapter.removeClass(FG_DEACTIVATION);
			this.adapter.computeBoundingRect();
			this.adapter.addClass(FG_ACTIVATION);
			this.activationTimer = setTimeout(function() {
				_this.activationTimerCallback();
			}, DEACTIVATION_TIMEOUT_MS);
		};
		MDCRippleFoundation.prototype.getFgTranslationCoordinates = function() {
			var _a = this.activationState, activationEvent = _a.activationEvent, wasActivatedByPointer = _a.wasActivatedByPointer;
			var startPoint;
			if (wasActivatedByPointer) startPoint = getNormalizedEventCoords(activationEvent, this.adapter.getWindowPageOffset(), this.adapter.computeBoundingRect());
			else startPoint = {
				x: this.frame.width / 2,
				y: this.frame.height / 2
			};
			startPoint = {
				x: startPoint.x - this.initialSize / 2,
				y: startPoint.y - this.initialSize / 2
			};
			var endPoint = {
				x: this.frame.width / 2 - this.initialSize / 2,
				y: this.frame.height / 2 - this.initialSize / 2
			};
			return {
				startPoint,
				endPoint
			};
		};
		MDCRippleFoundation.prototype.runDeactivationUXLogicIfReady = function() {
			var _this = this;
			var FG_DEACTIVATION = MDCRippleFoundation.cssClasses.FG_DEACTIVATION;
			var _a = this.activationState, hasDeactivationUXRun = _a.hasDeactivationUXRun, isActivated = _a.isActivated;
			if ((hasDeactivationUXRun || !isActivated) && this.activationAnimationHasEnded) {
				this.rmBoundedActivationClasses();
				this.adapter.addClass(FG_DEACTIVATION);
				this.fgDeactivationRemovalTimer = setTimeout(function() {
					_this.adapter.removeClass(FG_DEACTIVATION);
				}, numbers$12.FG_DEACTIVATION_MS);
			}
		};
		MDCRippleFoundation.prototype.rmBoundedActivationClasses = function() {
			var FG_ACTIVATION = MDCRippleFoundation.cssClasses.FG_ACTIVATION;
			this.adapter.removeClass(FG_ACTIVATION);
			this.activationAnimationHasEnded = false;
			this.adapter.computeBoundingRect();
		};
		MDCRippleFoundation.prototype.resetActivationState = function() {
			var _this = this;
			this.previousActivationEvent = this.activationState.activationEvent;
			this.activationState = this.defaultActivationState();
			setTimeout(function() {
				_this.previousActivationEvent = void 0;
			}, MDCRippleFoundation.numbers.TAP_DELAY_MS);
		};
		MDCRippleFoundation.prototype.deactivateImpl = function() {
			var _this = this;
			var activationState = this.activationState;
			if (!activationState.isActivated) return;
			var state = __assign({}, activationState);
			if (activationState.isProgrammatic) {
				requestAnimationFrame(function() {
					_this.animateDeactivation(state);
				});
				this.resetActivationState();
			} else {
				this.deregisterDeactivationHandlers();
				requestAnimationFrame(function() {
					_this.activationState.hasDeactivationUXRun = true;
					_this.animateDeactivation(state);
					_this.resetActivationState();
				});
			}
		};
		MDCRippleFoundation.prototype.animateDeactivation = function(_a) {
			var wasActivatedByPointer = _a.wasActivatedByPointer, wasElementMadeActive = _a.wasElementMadeActive;
			if (wasActivatedByPointer || wasElementMadeActive) this.runDeactivationUXLogicIfReady();
		};
		MDCRippleFoundation.prototype.layoutInternal = function() {
			var _this = this;
			this.frame = this.adapter.computeBoundingRect();
			var maxDim = Math.max(this.frame.height, this.frame.width);
			var getBoundedRadius = function() {
				return Math.sqrt(Math.pow(_this.frame.width, 2) + Math.pow(_this.frame.height, 2)) + MDCRippleFoundation.numbers.PADDING;
			};
			this.maxRadius = this.adapter.isUnbounded() ? maxDim : getBoundedRadius();
			var initialSize = Math.floor(maxDim * MDCRippleFoundation.numbers.INITIAL_ORIGIN_SCALE);
			if (this.adapter.isUnbounded() && initialSize % 2 !== 0) this.initialSize = initialSize - 1;
			else this.initialSize = initialSize;
			this.fgScale = "" + this.maxRadius / this.initialSize;
			this.updateLayoutCssVars();
		};
		MDCRippleFoundation.prototype.updateLayoutCssVars = function() {
			var _a = MDCRippleFoundation.strings, VAR_FG_SIZE = _a.VAR_FG_SIZE, VAR_LEFT = _a.VAR_LEFT, VAR_TOP = _a.VAR_TOP, VAR_FG_SCALE = _a.VAR_FG_SCALE;
			this.adapter.updateCssVariable(VAR_FG_SIZE, this.initialSize + "px");
			this.adapter.updateCssVariable(VAR_FG_SCALE, this.fgScale);
			if (this.adapter.isUnbounded()) {
				this.unboundedCoords = {
					left: Math.round(this.frame.width / 2 - this.initialSize / 2),
					top: Math.round(this.frame.height / 2 - this.initialSize / 2)
				};
				this.adapter.updateCssVariable(VAR_LEFT, this.unboundedCoords.left + "px");
				this.adapter.updateCssVariable(VAR_TOP, this.unboundedCoords.top + "px");
			}
		};
		return MDCRippleFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+ripple@14.0.0/node_modules/@material/ripple/component.js
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
	var MDCRipple = function(_super) {
		__extends(MDCRipple, _super);
		function MDCRipple() {
			var _this = _super !== null && _super.apply(this, arguments) || this;
			_this.disabled = false;
			return _this;
		}
		MDCRipple.attachTo = function(root, opts) {
			if (opts === void 0) opts = { isUnbounded: void 0 };
			var ripple = new MDCRipple(root);
			if (opts.isUnbounded !== void 0) ripple.unbounded = opts.isUnbounded;
			return ripple;
		};
		MDCRipple.createAdapter = function(instance) {
			return {
				addClass: function(className) {
					return instance.root.classList.add(className);
				},
				browserSupportsCssVars: function() {
					return supportsCssVariables(window);
				},
				computeBoundingRect: function() {
					return instance.root.getBoundingClientRect();
				},
				containsEventTarget: function(target) {
					return instance.root.contains(target);
				},
				deregisterDocumentInteractionHandler: function(evtType, handler) {
					return document.documentElement.removeEventListener(evtType, handler, applyPassive());
				},
				deregisterInteractionHandler: function(evtType, handler) {
					return instance.root.removeEventListener(evtType, handler, applyPassive());
				},
				deregisterResizeHandler: function(handler) {
					return window.removeEventListener("resize", handler);
				},
				getWindowPageOffset: function() {
					return {
						x: window.pageXOffset,
						y: window.pageYOffset
					};
				},
				isSurfaceActive: function() {
					return matches(instance.root, ":active");
				},
				isSurfaceDisabled: function() {
					return Boolean(instance.disabled);
				},
				isUnbounded: function() {
					return Boolean(instance.unbounded);
				},
				registerDocumentInteractionHandler: function(evtType, handler) {
					return document.documentElement.addEventListener(evtType, handler, applyPassive());
				},
				registerInteractionHandler: function(evtType, handler) {
					return instance.root.addEventListener(evtType, handler, applyPassive());
				},
				registerResizeHandler: function(handler) {
					return window.addEventListener("resize", handler);
				},
				removeClass: function(className) {
					return instance.root.classList.remove(className);
				},
				updateCssVariable: function(varName, value) {
					return instance.root.style.setProperty(varName, value);
				}
			};
		};
		Object.defineProperty(MDCRipple.prototype, "unbounded", {
			get: function() {
				return Boolean(this.isUnbounded);
			},
			set: function(unbounded) {
				this.isUnbounded = Boolean(unbounded);
				this.setUnbounded();
			},
			enumerable: false,
			configurable: true
		});
		MDCRipple.prototype.activate = function() {
			this.foundation.activate();
		};
		MDCRipple.prototype.deactivate = function() {
			this.foundation.deactivate();
		};
		MDCRipple.prototype.layout = function() {
			this.foundation.layout();
		};
		MDCRipple.prototype.getDefaultFoundation = function() {
			return new MDCRippleFoundation(MDCRipple.createAdapter(this));
		};
		MDCRipple.prototype.initialSyncWithDOM = function() {
			var root = this.root;
			this.isUnbounded = "mdcRippleIsUnbounded" in root.dataset;
		};
		/**
		* Closure Compiler throws an access control error when directly accessing a
		* protected or private property inside a getter/setter, like unbounded above.
		* By accessing the protected property inside a method, we solve that problem.
		* That's why this function exists.
		*/
		MDCRipple.prototype.setUnbounded = function() {
			this.foundation.setUnbounded(Boolean(this.isUnbounded));
		};
		return MDCRipple;
	}(MDCComponent);

//#endregion
//#region node_modules/.pnpm/@material+textfield@14.0.0/node_modules/@material/textfield/character-counter/constants.js
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
	var cssClasses$26 = { ROOT: "mdc-text-field-character-counter" };
	var strings$30 = { ROOT_SELECTOR: "." + cssClasses$26.ROOT };

//#endregion
//#region node_modules/.pnpm/@material+textfield@14.0.0/node_modules/@material/textfield/character-counter/foundation.js
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
	var MDCTextFieldCharacterCounterFoundation = function(_super) {
		__extends(MDCTextFieldCharacterCounterFoundation, _super);
		function MDCTextFieldCharacterCounterFoundation(adapter) {
			return _super.call(this, __assign(__assign({}, MDCTextFieldCharacterCounterFoundation.defaultAdapter), adapter)) || this;
		}
		Object.defineProperty(MDCTextFieldCharacterCounterFoundation, "cssClasses", {
			get: function() {
				return cssClasses$26;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextFieldCharacterCounterFoundation, "strings", {
			get: function() {
				return strings$30;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextFieldCharacterCounterFoundation, "defaultAdapter", {
			/**
			* See {@link MDCTextFieldCharacterCounterAdapter} for typing information on parameters and return types.
			*/
			get: function() {
				return { setContent: function() {} };
			},
			enumerable: false,
			configurable: true
		});
		MDCTextFieldCharacterCounterFoundation.prototype.setCounterValue = function(currentLength, maxLength) {
			currentLength = Math.min(currentLength, maxLength);
			this.adapter.setContent(currentLength + " / " + maxLength);
		};
		return MDCTextFieldCharacterCounterFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+textfield@14.0.0/node_modules/@material/textfield/character-counter/component.js
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
	var MDCTextFieldCharacterCounter = function(_super) {
		__extends(MDCTextFieldCharacterCounter, _super);
		function MDCTextFieldCharacterCounter() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCTextFieldCharacterCounter.attachTo = function(root) {
			return new MDCTextFieldCharacterCounter(root);
		};
		Object.defineProperty(MDCTextFieldCharacterCounter.prototype, "foundationForTextField", {
			get: function() {
				return this.foundation;
			},
			enumerable: false,
			configurable: true
		});
		MDCTextFieldCharacterCounter.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCTextFieldCharacterCounterFoundation({ setContent: function(content) {
				_this.root.textContent = content;
			} });
		};
		return MDCTextFieldCharacterCounter;
	}(MDCComponent);

//#endregion
//#region node_modules/.pnpm/@material+textfield@14.0.0/node_modules/@material/textfield/constants.js
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
	var strings$29 = {
		ARIA_CONTROLS: "aria-controls",
		ARIA_DESCRIBEDBY: "aria-describedby",
		INPUT_SELECTOR: ".mdc-text-field__input",
		LABEL_SELECTOR: ".mdc-floating-label",
		LEADING_ICON_SELECTOR: ".mdc-text-field__icon--leading",
		LINE_RIPPLE_SELECTOR: ".mdc-line-ripple",
		OUTLINE_SELECTOR: ".mdc-notched-outline",
		PREFIX_SELECTOR: ".mdc-text-field__affix--prefix",
		SUFFIX_SELECTOR: ".mdc-text-field__affix--suffix",
		TRAILING_ICON_SELECTOR: ".mdc-text-field__icon--trailing"
	};
	var cssClasses$25 = {
		DISABLED: "mdc-text-field--disabled",
		FOCUSED: "mdc-text-field--focused",
		HELPER_LINE: "mdc-text-field-helper-line",
		INVALID: "mdc-text-field--invalid",
		LABEL_FLOATING: "mdc-text-field--label-floating",
		NO_LABEL: "mdc-text-field--no-label",
		OUTLINED: "mdc-text-field--outlined",
		ROOT: "mdc-text-field",
		TEXTAREA: "mdc-text-field--textarea",
		WITH_LEADING_ICON: "mdc-text-field--with-leading-icon",
		WITH_TRAILING_ICON: "mdc-text-field--with-trailing-icon",
		WITH_INTERNAL_COUNTER: "mdc-text-field--with-internal-counter"
	};
	var numbers$11 = { LABEL_SCALE: .75 };
	/**
	* Whitelist based off of
	* https://developer.mozilla.org/en-US/docs/Web/Guide/HTML/HTML5/Constraint_validation
	* under the "Validation-related attributes" section.
	*/
	var VALIDATION_ATTR_WHITELIST = [
		"pattern",
		"min",
		"max",
		"required",
		"step",
		"minlength",
		"maxlength"
	];
	/**
	* Label should always float for these types as they show some UI even if value
	* is empty.
	*/
	var ALWAYS_FLOAT_TYPES = [
		"color",
		"date",
		"datetime-local",
		"month",
		"range",
		"time",
		"week"
	];

//#endregion
//#region node_modules/.pnpm/@material+textfield@14.0.0/node_modules/@material/textfield/foundation.js
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
	var POINTERDOWN_EVENTS = ["mousedown", "touchstart"];
	var INTERACTION_EVENTS$2 = ["click", "keydown"];
	var MDCTextFieldFoundation = function(_super) {
		__extends(MDCTextFieldFoundation, _super);
		/**
		* @param adapter
		* @param foundationMap Map from subcomponent names to their subfoundations.
		*/
		function MDCTextFieldFoundation(adapter, foundationMap) {
			if (foundationMap === void 0) foundationMap = {};
			var _this = _super.call(this, __assign(__assign({}, MDCTextFieldFoundation.defaultAdapter), adapter)) || this;
			_this.isFocused = false;
			_this.receivedUserInput = false;
			_this.valid = true;
			_this.useNativeValidation = true;
			_this.validateOnValueChange = true;
			_this.helperText = foundationMap.helperText;
			_this.characterCounter = foundationMap.characterCounter;
			_this.leadingIcon = foundationMap.leadingIcon;
			_this.trailingIcon = foundationMap.trailingIcon;
			_this.inputFocusHandler = function() {
				_this.activateFocus();
			};
			_this.inputBlurHandler = function() {
				_this.deactivateFocus();
			};
			_this.inputInputHandler = function() {
				_this.handleInput();
			};
			_this.setPointerXOffset = function(evt) {
				_this.setTransformOrigin(evt);
			};
			_this.textFieldInteractionHandler = function() {
				_this.handleTextFieldInteraction();
			};
			_this.validationAttributeChangeHandler = function(attributesList) {
				_this.handleValidationAttributeChange(attributesList);
			};
			return _this;
		}
		Object.defineProperty(MDCTextFieldFoundation, "cssClasses", {
			get: function() {
				return cssClasses$25;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextFieldFoundation, "strings", {
			get: function() {
				return strings$29;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextFieldFoundation, "numbers", {
			get: function() {
				return numbers$11;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextFieldFoundation.prototype, "shouldAlwaysFloat", {
			get: function() {
				var type = this.getNativeInput().type;
				return ALWAYS_FLOAT_TYPES.indexOf(type) >= 0;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextFieldFoundation.prototype, "shouldFloat", {
			get: function() {
				return this.shouldAlwaysFloat || this.isFocused || !!this.getValue() || this.isBadInput();
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextFieldFoundation.prototype, "shouldShake", {
			get: function() {
				return !this.isFocused && !this.isValid() && !!this.getValue();
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextFieldFoundation, "defaultAdapter", {
			/**
			* See {@link MDCTextFieldAdapter} for typing information on parameters and
			* return types.
			*/
			get: function() {
				return {
					addClass: function() {},
					removeClass: function() {},
					hasClass: function() {
						return true;
					},
					setInputAttr: function() {},
					removeInputAttr: function() {},
					registerTextFieldInteractionHandler: function() {},
					deregisterTextFieldInteractionHandler: function() {},
					registerInputInteractionHandler: function() {},
					deregisterInputInteractionHandler: function() {},
					registerValidationAttributeChangeHandler: function() {
						return new MutationObserver(function() {});
					},
					deregisterValidationAttributeChangeHandler: function() {},
					getNativeInput: function() {
						return null;
					},
					isFocused: function() {
						return false;
					},
					activateLineRipple: function() {},
					deactivateLineRipple: function() {},
					setLineRippleTransformOrigin: function() {},
					shakeLabel: function() {},
					floatLabel: function() {},
					setLabelRequired: function() {},
					hasLabel: function() {
						return false;
					},
					getLabelWidth: function() {
						return 0;
					},
					hasOutline: function() {
						return false;
					},
					notchOutline: function() {},
					closeOutline: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCTextFieldFoundation.prototype.init = function() {
			var e_1, _a, e_2, _b;
			if (this.adapter.hasLabel() && this.getNativeInput().required) this.adapter.setLabelRequired(true);
			if (this.adapter.isFocused()) this.inputFocusHandler();
			else if (this.adapter.hasLabel() && this.shouldFloat) {
				this.notchOutline(true);
				this.adapter.floatLabel(true);
				this.styleFloating(true);
			}
			this.adapter.registerInputInteractionHandler("focus", this.inputFocusHandler);
			this.adapter.registerInputInteractionHandler("blur", this.inputBlurHandler);
			this.adapter.registerInputInteractionHandler("input", this.inputInputHandler);
			try {
				for (var POINTERDOWN_EVENTS_1 = __values(POINTERDOWN_EVENTS), POINTERDOWN_EVENTS_1_1 = POINTERDOWN_EVENTS_1.next(); !POINTERDOWN_EVENTS_1_1.done; POINTERDOWN_EVENTS_1_1 = POINTERDOWN_EVENTS_1.next()) {
					var evtType = POINTERDOWN_EVENTS_1_1.value;
					this.adapter.registerInputInteractionHandler(evtType, this.setPointerXOffset);
				}
			} catch (e_1_1) {
				e_1 = { error: e_1_1 };
			} finally {
				try {
					if (POINTERDOWN_EVENTS_1_1 && !POINTERDOWN_EVENTS_1_1.done && (_a = POINTERDOWN_EVENTS_1.return)) _a.call(POINTERDOWN_EVENTS_1);
				} finally {
					if (e_1) throw e_1.error;
				}
			}
			try {
				for (var INTERACTION_EVENTS_1 = __values(INTERACTION_EVENTS$2), INTERACTION_EVENTS_1_1 = INTERACTION_EVENTS_1.next(); !INTERACTION_EVENTS_1_1.done; INTERACTION_EVENTS_1_1 = INTERACTION_EVENTS_1.next()) {
					var evtType = INTERACTION_EVENTS_1_1.value;
					this.adapter.registerTextFieldInteractionHandler(evtType, this.textFieldInteractionHandler);
				}
			} catch (e_2_1) {
				e_2 = { error: e_2_1 };
			} finally {
				try {
					if (INTERACTION_EVENTS_1_1 && !INTERACTION_EVENTS_1_1.done && (_b = INTERACTION_EVENTS_1.return)) _b.call(INTERACTION_EVENTS_1);
				} finally {
					if (e_2) throw e_2.error;
				}
			}
			this.validationObserver = this.adapter.registerValidationAttributeChangeHandler(this.validationAttributeChangeHandler);
			this.setcharacterCounter(this.getValue().length);
		};
		MDCTextFieldFoundation.prototype.destroy = function() {
			var e_3, _a, e_4, _b;
			this.adapter.deregisterInputInteractionHandler("focus", this.inputFocusHandler);
			this.adapter.deregisterInputInteractionHandler("blur", this.inputBlurHandler);
			this.adapter.deregisterInputInteractionHandler("input", this.inputInputHandler);
			try {
				for (var POINTERDOWN_EVENTS_2 = __values(POINTERDOWN_EVENTS), POINTERDOWN_EVENTS_2_1 = POINTERDOWN_EVENTS_2.next(); !POINTERDOWN_EVENTS_2_1.done; POINTERDOWN_EVENTS_2_1 = POINTERDOWN_EVENTS_2.next()) {
					var evtType = POINTERDOWN_EVENTS_2_1.value;
					this.adapter.deregisterInputInteractionHandler(evtType, this.setPointerXOffset);
				}
			} catch (e_3_1) {
				e_3 = { error: e_3_1 };
			} finally {
				try {
					if (POINTERDOWN_EVENTS_2_1 && !POINTERDOWN_EVENTS_2_1.done && (_a = POINTERDOWN_EVENTS_2.return)) _a.call(POINTERDOWN_EVENTS_2);
				} finally {
					if (e_3) throw e_3.error;
				}
			}
			try {
				for (var INTERACTION_EVENTS_2 = __values(INTERACTION_EVENTS$2), INTERACTION_EVENTS_2_1 = INTERACTION_EVENTS_2.next(); !INTERACTION_EVENTS_2_1.done; INTERACTION_EVENTS_2_1 = INTERACTION_EVENTS_2.next()) {
					var evtType = INTERACTION_EVENTS_2_1.value;
					this.adapter.deregisterTextFieldInteractionHandler(evtType, this.textFieldInteractionHandler);
				}
			} catch (e_4_1) {
				e_4 = { error: e_4_1 };
			} finally {
				try {
					if (INTERACTION_EVENTS_2_1 && !INTERACTION_EVENTS_2_1.done && (_b = INTERACTION_EVENTS_2.return)) _b.call(INTERACTION_EVENTS_2);
				} finally {
					if (e_4) throw e_4.error;
				}
			}
			this.adapter.deregisterValidationAttributeChangeHandler(this.validationObserver);
		};
		/**
		* Handles user interactions with the Text Field.
		*/
		MDCTextFieldFoundation.prototype.handleTextFieldInteraction = function() {
			var nativeInput = this.adapter.getNativeInput();
			if (nativeInput && nativeInput.disabled) return;
			this.receivedUserInput = true;
		};
		/**
		* Handles validation attribute changes
		*/
		MDCTextFieldFoundation.prototype.handleValidationAttributeChange = function(attributesList) {
			var _this = this;
			attributesList.some(function(attributeName) {
				if (VALIDATION_ATTR_WHITELIST.indexOf(attributeName) > -1) {
					_this.styleValidity(true);
					_this.adapter.setLabelRequired(_this.getNativeInput().required);
					return true;
				}
				return false;
			});
			if (attributesList.indexOf("maxlength") > -1) this.setcharacterCounter(this.getValue().length);
		};
		/**
		* Opens/closes the notched outline.
		*/
		MDCTextFieldFoundation.prototype.notchOutline = function(openNotch) {
			if (!this.adapter.hasOutline() || !this.adapter.hasLabel()) return;
			if (openNotch) {
				var labelWidth = this.adapter.getLabelWidth() * numbers$11.LABEL_SCALE;
				this.adapter.notchOutline(labelWidth);
			} else this.adapter.closeOutline();
		};
		/**
		* Activates the text field focus state.
		*/
		MDCTextFieldFoundation.prototype.activateFocus = function() {
			this.isFocused = true;
			this.styleFocused(this.isFocused);
			this.adapter.activateLineRipple();
			if (this.adapter.hasLabel()) {
				this.notchOutline(this.shouldFloat);
				this.adapter.floatLabel(this.shouldFloat);
				this.styleFloating(this.shouldFloat);
				this.adapter.shakeLabel(this.shouldShake);
			}
			if (this.helperText && (this.helperText.isPersistent() || !this.helperText.isValidation() || !this.valid)) this.helperText.showToScreenReader();
		};
		/**
		* Sets the line ripple's transform origin, so that the line ripple activate
		* animation will animate out from the user's click location.
		*/
		MDCTextFieldFoundation.prototype.setTransformOrigin = function(evt) {
			if (this.isDisabled() || this.adapter.hasOutline()) return;
			var touches = evt.touches;
			var targetEvent = touches ? touches[0] : evt;
			var targetClientRect = targetEvent.target.getBoundingClientRect();
			var normalizedX = targetEvent.clientX - targetClientRect.left;
			this.adapter.setLineRippleTransformOrigin(normalizedX);
		};
		/**
		* Handles input change of text input and text area.
		*/
		MDCTextFieldFoundation.prototype.handleInput = function() {
			this.autoCompleteFocus();
			this.setcharacterCounter(this.getValue().length);
		};
		/**
		* Activates the Text Field's focus state in cases when the input value
		* changes without user input (e.g. programmatically).
		*/
		MDCTextFieldFoundation.prototype.autoCompleteFocus = function() {
			if (!this.receivedUserInput) this.activateFocus();
		};
		/**
		* Deactivates the Text Field's focus state.
		*/
		MDCTextFieldFoundation.prototype.deactivateFocus = function() {
			this.isFocused = false;
			this.adapter.deactivateLineRipple();
			var isValid = this.isValid();
			this.styleValidity(isValid);
			this.styleFocused(this.isFocused);
			if (this.adapter.hasLabel()) {
				this.notchOutline(this.shouldFloat);
				this.adapter.floatLabel(this.shouldFloat);
				this.styleFloating(this.shouldFloat);
				this.adapter.shakeLabel(this.shouldShake);
			}
			if (!this.shouldFloat) this.receivedUserInput = false;
		};
		MDCTextFieldFoundation.prototype.getValue = function() {
			return this.getNativeInput().value;
		};
		/**
		* @param value The value to set on the input Element.
		*/
		MDCTextFieldFoundation.prototype.setValue = function(value) {
			if (this.getValue() !== value) this.getNativeInput().value = value;
			this.setcharacterCounter(value.length);
			if (this.validateOnValueChange) {
				var isValid = this.isValid();
				this.styleValidity(isValid);
			}
			if (this.adapter.hasLabel()) {
				this.notchOutline(this.shouldFloat);
				this.adapter.floatLabel(this.shouldFloat);
				this.styleFloating(this.shouldFloat);
				if (this.validateOnValueChange) this.adapter.shakeLabel(this.shouldShake);
			}
		};
		/**
		* @return The custom validity state, if set; otherwise, the result of a
		*     native validity check.
		*/
		MDCTextFieldFoundation.prototype.isValid = function() {
			return this.useNativeValidation ? this.isNativeInputValid() : this.valid;
		};
		/**
		* @param isValid Sets the custom validity state of the Text Field.
		*/
		MDCTextFieldFoundation.prototype.setValid = function(isValid) {
			this.valid = isValid;
			this.styleValidity(isValid);
			var shouldShake = !isValid && !this.isFocused && !!this.getValue();
			if (this.adapter.hasLabel()) this.adapter.shakeLabel(shouldShake);
		};
		/**
		* @param shouldValidate Whether or not validity should be updated on
		*     value change.
		*/
		MDCTextFieldFoundation.prototype.setValidateOnValueChange = function(shouldValidate) {
			this.validateOnValueChange = shouldValidate;
		};
		/**
		* @return Whether or not validity should be updated on value change. `true`
		*     by default.
		*/
		MDCTextFieldFoundation.prototype.getValidateOnValueChange = function() {
			return this.validateOnValueChange;
		};
		/**
		* Enables or disables the use of native validation. Use this for custom
		* validation.
		* @param useNativeValidation Set this to false to ignore native input
		*     validation.
		*/
		MDCTextFieldFoundation.prototype.setUseNativeValidation = function(useNativeValidation) {
			this.useNativeValidation = useNativeValidation;
		};
		MDCTextFieldFoundation.prototype.isDisabled = function() {
			return this.getNativeInput().disabled;
		};
		/**
		* @param disabled Sets the text-field disabled or enabled.
		*/
		MDCTextFieldFoundation.prototype.setDisabled = function(disabled) {
			this.getNativeInput().disabled = disabled;
			this.styleDisabled(disabled);
		};
		/**
		* @param content Sets the content of the helper text.
		*/
		MDCTextFieldFoundation.prototype.setHelperTextContent = function(content) {
			if (this.helperText) this.helperText.setContent(content);
		};
		/**
		* Sets the aria label of the leading icon.
		*/
		MDCTextFieldFoundation.prototype.setLeadingIconAriaLabel = function(label) {
			if (this.leadingIcon) this.leadingIcon.setAriaLabel(label);
		};
		/**
		* Sets the text content of the leading icon.
		*/
		MDCTextFieldFoundation.prototype.setLeadingIconContent = function(content) {
			if (this.leadingIcon) this.leadingIcon.setContent(content);
		};
		/**
		* Sets the aria label of the trailing icon.
		*/
		MDCTextFieldFoundation.prototype.setTrailingIconAriaLabel = function(label) {
			if (this.trailingIcon) this.trailingIcon.setAriaLabel(label);
		};
		/**
		* Sets the text content of the trailing icon.
		*/
		MDCTextFieldFoundation.prototype.setTrailingIconContent = function(content) {
			if (this.trailingIcon) this.trailingIcon.setContent(content);
		};
		/**
		* Sets character counter values that shows characters used and the total
		* character limit.
		*/
		MDCTextFieldFoundation.prototype.setcharacterCounter = function(currentLength) {
			if (!this.characterCounter) return;
			var maxLength = this.getNativeInput().maxLength;
			if (maxLength === -1) throw new Error("MDCTextFieldFoundation: Expected maxlength html property on text input or textarea.");
			this.characterCounter.setCounterValue(currentLength, maxLength);
		};
		/**
		* @return True if the Text Field input fails in converting the user-supplied
		*     value.
		*/
		MDCTextFieldFoundation.prototype.isBadInput = function() {
			return this.getNativeInput().validity.badInput || false;
		};
		/**
		* @return The result of native validity checking (ValidityState.valid).
		*/
		MDCTextFieldFoundation.prototype.isNativeInputValid = function() {
			return this.getNativeInput().validity.valid;
		};
		/**
		* Styles the component based on the validity state.
		*/
		MDCTextFieldFoundation.prototype.styleValidity = function(isValid) {
			var INVALID = MDCTextFieldFoundation.cssClasses.INVALID;
			if (isValid) this.adapter.removeClass(INVALID);
			else this.adapter.addClass(INVALID);
			if (this.helperText) {
				this.helperText.setValidity(isValid);
				if (!this.helperText.isValidation()) return;
				var helperTextVisible = this.helperText.isVisible();
				var helperTextId = this.helperText.getId();
				if (helperTextVisible && helperTextId) this.adapter.setInputAttr(strings$29.ARIA_DESCRIBEDBY, helperTextId);
				else this.adapter.removeInputAttr(strings$29.ARIA_DESCRIBEDBY);
			}
		};
		/**
		* Styles the component based on the focused state.
		*/
		MDCTextFieldFoundation.prototype.styleFocused = function(isFocused) {
			var FOCUSED = MDCTextFieldFoundation.cssClasses.FOCUSED;
			if (isFocused) this.adapter.addClass(FOCUSED);
			else this.adapter.removeClass(FOCUSED);
		};
		/**
		* Styles the component based on the disabled state.
		*/
		MDCTextFieldFoundation.prototype.styleDisabled = function(isDisabled) {
			var _a = MDCTextFieldFoundation.cssClasses, DISABLED = _a.DISABLED, INVALID = _a.INVALID;
			if (isDisabled) {
				this.adapter.addClass(DISABLED);
				this.adapter.removeClass(INVALID);
			} else this.adapter.removeClass(DISABLED);
			if (this.leadingIcon) this.leadingIcon.setDisabled(isDisabled);
			if (this.trailingIcon) this.trailingIcon.setDisabled(isDisabled);
		};
		/**
		* Styles the component based on the label floating state.
		*/
		MDCTextFieldFoundation.prototype.styleFloating = function(isFloating) {
			var LABEL_FLOATING = MDCTextFieldFoundation.cssClasses.LABEL_FLOATING;
			if (isFloating) this.adapter.addClass(LABEL_FLOATING);
			else this.adapter.removeClass(LABEL_FLOATING);
		};
		/**
		* @return The native text input element from the host environment, or an
		*     object with the same shape for unit tests.
		*/
		MDCTextFieldFoundation.prototype.getNativeInput = function() {
			return (this.adapter ? this.adapter.getNativeInput() : null) || {
				disabled: false,
				maxLength: -1,
				required: false,
				type: "input",
				validity: {
					badInput: false,
					valid: true
				},
				value: ""
			};
		};
		return MDCTextFieldFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+textfield@14.0.0/node_modules/@material/textfield/helper-text/constants.js
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
	var cssClasses$24 = {
		HELPER_TEXT_PERSISTENT: "mdc-text-field-helper-text--persistent",
		HELPER_TEXT_VALIDATION_MSG: "mdc-text-field-helper-text--validation-msg",
		ROOT: "mdc-text-field-helper-text"
	};
	var strings$28 = {
		ARIA_HIDDEN: "aria-hidden",
		ROLE: "role",
		ROOT_SELECTOR: "." + cssClasses$24.ROOT
	};

//#endregion
//#region node_modules/.pnpm/@material+textfield@14.0.0/node_modules/@material/textfield/helper-text/foundation.js
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
	var MDCTextFieldHelperTextFoundation = function(_super) {
		__extends(MDCTextFieldHelperTextFoundation, _super);
		function MDCTextFieldHelperTextFoundation(adapter) {
			return _super.call(this, __assign(__assign({}, MDCTextFieldHelperTextFoundation.defaultAdapter), adapter)) || this;
		}
		Object.defineProperty(MDCTextFieldHelperTextFoundation, "cssClasses", {
			get: function() {
				return cssClasses$24;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextFieldHelperTextFoundation, "strings", {
			get: function() {
				return strings$28;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextFieldHelperTextFoundation, "defaultAdapter", {
			/**
			* See {@link MDCTextFieldHelperTextAdapter} for typing information on parameters and return types.
			*/
			get: function() {
				return {
					addClass: function() {},
					removeClass: function() {},
					hasClass: function() {
						return false;
					},
					getAttr: function() {
						return null;
					},
					setAttr: function() {},
					removeAttr: function() {},
					setContent: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCTextFieldHelperTextFoundation.prototype.getId = function() {
			return this.adapter.getAttr("id");
		};
		MDCTextFieldHelperTextFoundation.prototype.isVisible = function() {
			return this.adapter.getAttr(strings$28.ARIA_HIDDEN) !== "true";
		};
		/**
		* Sets the content of the helper text field.
		*/
		MDCTextFieldHelperTextFoundation.prototype.setContent = function(content) {
			this.adapter.setContent(content);
		};
		MDCTextFieldHelperTextFoundation.prototype.isPersistent = function() {
			return this.adapter.hasClass(cssClasses$24.HELPER_TEXT_PERSISTENT);
		};
		/**
		* @param isPersistent Sets the persistency of the helper text.
		*/
		MDCTextFieldHelperTextFoundation.prototype.setPersistent = function(isPersistent) {
			if (isPersistent) this.adapter.addClass(cssClasses$24.HELPER_TEXT_PERSISTENT);
			else this.adapter.removeClass(cssClasses$24.HELPER_TEXT_PERSISTENT);
		};
		/**
		* @return whether the helper text acts as an error validation message.
		*/
		MDCTextFieldHelperTextFoundation.prototype.isValidation = function() {
			return this.adapter.hasClass(cssClasses$24.HELPER_TEXT_VALIDATION_MSG);
		};
		/**
		* @param isValidation True to make the helper text act as an error validation message.
		*/
		MDCTextFieldHelperTextFoundation.prototype.setValidation = function(isValidation) {
			if (isValidation) this.adapter.addClass(cssClasses$24.HELPER_TEXT_VALIDATION_MSG);
			else this.adapter.removeClass(cssClasses$24.HELPER_TEXT_VALIDATION_MSG);
		};
		/**
		* Makes the helper text visible to the screen reader.
		*/
		MDCTextFieldHelperTextFoundation.prototype.showToScreenReader = function() {
			this.adapter.removeAttr(strings$28.ARIA_HIDDEN);
		};
		/**
		* Sets the validity of the helper text based on the input validity.
		*/
		MDCTextFieldHelperTextFoundation.prototype.setValidity = function(inputIsValid) {
			var helperTextIsPersistent = this.adapter.hasClass(cssClasses$24.HELPER_TEXT_PERSISTENT);
			var validationMsgNeedsDisplay = this.adapter.hasClass(cssClasses$24.HELPER_TEXT_VALIDATION_MSG) && !inputIsValid;
			if (validationMsgNeedsDisplay) {
				this.showToScreenReader();
				if (this.adapter.getAttr(strings$28.ROLE) === "alert") this.refreshAlertRole();
				else this.adapter.setAttr(strings$28.ROLE, "alert");
			} else this.adapter.removeAttr(strings$28.ROLE);
			if (!helperTextIsPersistent && !validationMsgNeedsDisplay) this.hide();
		};
		/**
		* Hides the help text from screen readers.
		*/
		MDCTextFieldHelperTextFoundation.prototype.hide = function() {
			this.adapter.setAttr(strings$28.ARIA_HIDDEN, "true");
		};
		MDCTextFieldHelperTextFoundation.prototype.refreshAlertRole = function() {
			var _this = this;
			this.adapter.removeAttr(strings$28.ROLE);
			requestAnimationFrame(function() {
				_this.adapter.setAttr(strings$28.ROLE, "alert");
			});
		};
		return MDCTextFieldHelperTextFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+textfield@14.0.0/node_modules/@material/textfield/helper-text/component.js
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
	var MDCTextFieldHelperText = function(_super) {
		__extends(MDCTextFieldHelperText, _super);
		function MDCTextFieldHelperText() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCTextFieldHelperText.attachTo = function(root) {
			return new MDCTextFieldHelperText(root);
		};
		Object.defineProperty(MDCTextFieldHelperText.prototype, "foundationForTextField", {
			get: function() {
				return this.foundation;
			},
			enumerable: false,
			configurable: true
		});
		MDCTextFieldHelperText.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCTextFieldHelperTextFoundation({
				addClass: function(className) {
					return _this.root.classList.add(className);
				},
				removeClass: function(className) {
					return _this.root.classList.remove(className);
				},
				hasClass: function(className) {
					return _this.root.classList.contains(className);
				},
				getAttr: function(attr) {
					return _this.root.getAttribute(attr);
				},
				setAttr: function(attr, value) {
					return _this.root.setAttribute(attr, value);
				},
				removeAttr: function(attr) {
					return _this.root.removeAttribute(attr);
				},
				setContent: function(content) {
					_this.root.textContent = content;
				}
			});
		};
		return MDCTextFieldHelperText;
	}(MDCComponent);

//#endregion
//#region node_modules/.pnpm/@material+textfield@14.0.0/node_modules/@material/textfield/icon/constants.js
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
	var strings$27 = {
		ICON_EVENT: "MDCTextField:icon",
		ICON_ROLE: "button"
	};
	var cssClasses$23 = { ROOT: "mdc-text-field__icon" };

//#endregion
//#region node_modules/.pnpm/@material+textfield@14.0.0/node_modules/@material/textfield/icon/foundation.js
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
	var INTERACTION_EVENTS$1 = ["click", "keydown"];
	var MDCTextFieldIconFoundation = function(_super) {
		__extends(MDCTextFieldIconFoundation, _super);
		function MDCTextFieldIconFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCTextFieldIconFoundation.defaultAdapter), adapter)) || this;
			_this.savedTabIndex = null;
			_this.interactionHandler = function(evt) {
				_this.handleInteraction(evt);
			};
			return _this;
		}
		Object.defineProperty(MDCTextFieldIconFoundation, "strings", {
			get: function() {
				return strings$27;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextFieldIconFoundation, "cssClasses", {
			get: function() {
				return cssClasses$23;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextFieldIconFoundation, "defaultAdapter", {
			/**
			* See {@link MDCTextFieldIconAdapter} for typing information on parameters and return types.
			*/
			get: function() {
				return {
					getAttr: function() {
						return null;
					},
					setAttr: function() {},
					removeAttr: function() {},
					setContent: function() {},
					registerInteractionHandler: function() {},
					deregisterInteractionHandler: function() {},
					notifyIconAction: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCTextFieldIconFoundation.prototype.init = function() {
			var e_1, _a;
			this.savedTabIndex = this.adapter.getAttr("tabindex");
			try {
				for (var INTERACTION_EVENTS_1 = __values(INTERACTION_EVENTS$1), INTERACTION_EVENTS_1_1 = INTERACTION_EVENTS_1.next(); !INTERACTION_EVENTS_1_1.done; INTERACTION_EVENTS_1_1 = INTERACTION_EVENTS_1.next()) {
					var evtType = INTERACTION_EVENTS_1_1.value;
					this.adapter.registerInteractionHandler(evtType, this.interactionHandler);
				}
			} catch (e_1_1) {
				e_1 = { error: e_1_1 };
			} finally {
				try {
					if (INTERACTION_EVENTS_1_1 && !INTERACTION_EVENTS_1_1.done && (_a = INTERACTION_EVENTS_1.return)) _a.call(INTERACTION_EVENTS_1);
				} finally {
					if (e_1) throw e_1.error;
				}
			}
		};
		MDCTextFieldIconFoundation.prototype.destroy = function() {
			var e_2, _a;
			try {
				for (var INTERACTION_EVENTS_2 = __values(INTERACTION_EVENTS$1), INTERACTION_EVENTS_2_1 = INTERACTION_EVENTS_2.next(); !INTERACTION_EVENTS_2_1.done; INTERACTION_EVENTS_2_1 = INTERACTION_EVENTS_2.next()) {
					var evtType = INTERACTION_EVENTS_2_1.value;
					this.adapter.deregisterInteractionHandler(evtType, this.interactionHandler);
				}
			} catch (e_2_1) {
				e_2 = { error: e_2_1 };
			} finally {
				try {
					if (INTERACTION_EVENTS_2_1 && !INTERACTION_EVENTS_2_1.done && (_a = INTERACTION_EVENTS_2.return)) _a.call(INTERACTION_EVENTS_2);
				} finally {
					if (e_2) throw e_2.error;
				}
			}
		};
		MDCTextFieldIconFoundation.prototype.setDisabled = function(disabled) {
			if (!this.savedTabIndex) return;
			if (disabled) {
				this.adapter.setAttr("tabindex", "-1");
				this.adapter.removeAttr("role");
			} else {
				this.adapter.setAttr("tabindex", this.savedTabIndex);
				this.adapter.setAttr("role", strings$27.ICON_ROLE);
			}
		};
		MDCTextFieldIconFoundation.prototype.setAriaLabel = function(label) {
			this.adapter.setAttr("aria-label", label);
		};
		MDCTextFieldIconFoundation.prototype.setContent = function(content) {
			this.adapter.setContent(content);
		};
		MDCTextFieldIconFoundation.prototype.handleInteraction = function(evt) {
			var isEnterKey = evt.key === "Enter" || evt.keyCode === 13;
			if (evt.type === "click" || isEnterKey) {
				evt.preventDefault();
				this.adapter.notifyIconAction();
			}
		};
		return MDCTextFieldIconFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+textfield@14.0.0/node_modules/@material/textfield/icon/component.js
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
	var MDCTextFieldIcon = function(_super) {
		__extends(MDCTextFieldIcon, _super);
		function MDCTextFieldIcon() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCTextFieldIcon.attachTo = function(root) {
			return new MDCTextFieldIcon(root);
		};
		Object.defineProperty(MDCTextFieldIcon.prototype, "foundationForTextField", {
			get: function() {
				return this.foundation;
			},
			enumerable: false,
			configurable: true
		});
		MDCTextFieldIcon.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCTextFieldIconFoundation({
				getAttr: function(attr) {
					return _this.root.getAttribute(attr);
				},
				setAttr: function(attr, value) {
					return _this.root.setAttribute(attr, value);
				},
				removeAttr: function(attr) {
					return _this.root.removeAttribute(attr);
				},
				setContent: function(content) {
					_this.root.textContent = content;
				},
				registerInteractionHandler: function(evtType, handler) {
					return _this.listen(evtType, handler);
				},
				deregisterInteractionHandler: function(evtType, handler) {
					return _this.unlisten(evtType, handler);
				},
				notifyIconAction: function() {
					return _this.emit(MDCTextFieldIconFoundation.strings.ICON_EVENT, {}, true);
				}
			});
		};
		return MDCTextFieldIcon;
	}(MDCComponent);

//#endregion
//#region node_modules/.pnpm/@material+textfield@14.0.0/node_modules/@material/textfield/component.js
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
	var MDCTextField = function(_super) {
		__extends(MDCTextField, _super);
		function MDCTextField() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCTextField.attachTo = function(root) {
			return new MDCTextField(root);
		};
		MDCTextField.prototype.initialize = function(rippleFactory, lineRippleFactory, helperTextFactory, characterCounterFactory, iconFactory, labelFactory, outlineFactory) {
			if (rippleFactory === void 0) rippleFactory = function(el, foundation) {
				return new MDCRipple(el, foundation);
			};
			if (lineRippleFactory === void 0) lineRippleFactory = function(el) {
				return new MDCLineRipple(el);
			};
			if (helperTextFactory === void 0) helperTextFactory = function(el) {
				return new MDCTextFieldHelperText(el);
			};
			if (characterCounterFactory === void 0) characterCounterFactory = function(el) {
				return new MDCTextFieldCharacterCounter(el);
			};
			if (iconFactory === void 0) iconFactory = function(el) {
				return new MDCTextFieldIcon(el);
			};
			if (labelFactory === void 0) labelFactory = function(el) {
				return new MDCFloatingLabel(el);
			};
			if (outlineFactory === void 0) outlineFactory = function(el) {
				return new MDCNotchedOutline(el);
			};
			this.input = this.root.querySelector(strings$29.INPUT_SELECTOR);
			var labelElement = this.root.querySelector(strings$29.LABEL_SELECTOR);
			this.label = labelElement ? labelFactory(labelElement) : null;
			var lineRippleElement = this.root.querySelector(strings$29.LINE_RIPPLE_SELECTOR);
			this.lineRipple = lineRippleElement ? lineRippleFactory(lineRippleElement) : null;
			var outlineElement = this.root.querySelector(strings$29.OUTLINE_SELECTOR);
			this.outline = outlineElement ? outlineFactory(outlineElement) : null;
			var helperTextStrings = MDCTextFieldHelperTextFoundation.strings;
			var nextElementSibling = this.root.nextElementSibling;
			var hasHelperLine = nextElementSibling && nextElementSibling.classList.contains(cssClasses$25.HELPER_LINE);
			var helperTextEl = hasHelperLine && nextElementSibling && nextElementSibling.querySelector(helperTextStrings.ROOT_SELECTOR);
			this.helperText = helperTextEl ? helperTextFactory(helperTextEl) : null;
			var characterCounterStrings = MDCTextFieldCharacterCounterFoundation.strings;
			var characterCounterEl = this.root.querySelector(characterCounterStrings.ROOT_SELECTOR);
			if (!characterCounterEl && hasHelperLine && nextElementSibling) characterCounterEl = nextElementSibling.querySelector(characterCounterStrings.ROOT_SELECTOR);
			this.characterCounter = characterCounterEl ? characterCounterFactory(characterCounterEl) : null;
			var leadingIconEl = this.root.querySelector(strings$29.LEADING_ICON_SELECTOR);
			this.leadingIcon = leadingIconEl ? iconFactory(leadingIconEl) : null;
			var trailingIconEl = this.root.querySelector(strings$29.TRAILING_ICON_SELECTOR);
			this.trailingIcon = trailingIconEl ? iconFactory(trailingIconEl) : null;
			this.prefix = this.root.querySelector(strings$29.PREFIX_SELECTOR);
			this.suffix = this.root.querySelector(strings$29.SUFFIX_SELECTOR);
			this.ripple = this.createRipple(rippleFactory);
		};
		MDCTextField.prototype.destroy = function() {
			if (this.ripple) this.ripple.destroy();
			if (this.lineRipple) this.lineRipple.destroy();
			if (this.helperText) this.helperText.destroy();
			if (this.characterCounter) this.characterCounter.destroy();
			if (this.leadingIcon) this.leadingIcon.destroy();
			if (this.trailingIcon) this.trailingIcon.destroy();
			if (this.label) this.label.destroy();
			if (this.outline) this.outline.destroy();
			_super.prototype.destroy.call(this);
		};
		/**
		* Initializes the Text Field's internal state based on the environment's
		* state.
		*/
		MDCTextField.prototype.initialSyncWithDOM = function() {
			this.disabled = this.input.disabled;
		};
		Object.defineProperty(MDCTextField.prototype, "value", {
			get: function() {
				return this.foundation.getValue();
			},
			/**
			* @param value The value to set on the input.
			*/
			set: function(value) {
				this.foundation.setValue(value);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextField.prototype, "disabled", {
			get: function() {
				return this.foundation.isDisabled();
			},
			/**
			* @param disabled Sets the Text Field disabled or enabled.
			*/
			set: function(disabled) {
				this.foundation.setDisabled(disabled);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextField.prototype, "valid", {
			get: function() {
				return this.foundation.isValid();
			},
			/**
			* @param valid Sets the Text Field valid or invalid.
			*/
			set: function(valid) {
				this.foundation.setValid(valid);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextField.prototype, "required", {
			get: function() {
				return this.input.required;
			},
			/**
			* @param required Sets the Text Field to required.
			*/
			set: function(required) {
				this.input.required = required;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextField.prototype, "pattern", {
			get: function() {
				return this.input.pattern;
			},
			/**
			* @param pattern Sets the input element's validation pattern.
			*/
			set: function(pattern) {
				this.input.pattern = pattern;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextField.prototype, "minLength", {
			get: function() {
				return this.input.minLength;
			},
			/**
			* @param minLength Sets the input element's minLength.
			*/
			set: function(minLength) {
				this.input.minLength = minLength;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextField.prototype, "maxLength", {
			get: function() {
				return this.input.maxLength;
			},
			/**
			* @param maxLength Sets the input element's maxLength.
			*/
			set: function(maxLength) {
				if (maxLength < 0) this.input.removeAttribute("maxLength");
				else this.input.maxLength = maxLength;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextField.prototype, "min", {
			get: function() {
				return this.input.min;
			},
			/**
			* @param min Sets the input element's min.
			*/
			set: function(min) {
				this.input.min = min;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextField.prototype, "max", {
			get: function() {
				return this.input.max;
			},
			/**
			* @param max Sets the input element's max.
			*/
			set: function(max) {
				this.input.max = max;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextField.prototype, "step", {
			get: function() {
				return this.input.step;
			},
			/**
			* @param step Sets the input element's step.
			*/
			set: function(step) {
				this.input.step = step;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextField.prototype, "helperTextContent", {
			/**
			* Sets the helper text element content.
			*/
			set: function(content) {
				this.foundation.setHelperTextContent(content);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextField.prototype, "leadingIconAriaLabel", {
			/**
			* Sets the aria label of the leading icon.
			*/
			set: function(label) {
				this.foundation.setLeadingIconAriaLabel(label);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextField.prototype, "leadingIconContent", {
			/**
			* Sets the text content of the leading icon.
			*/
			set: function(content) {
				this.foundation.setLeadingIconContent(content);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextField.prototype, "trailingIconAriaLabel", {
			/**
			* Sets the aria label of the trailing icon.
			*/
			set: function(label) {
				this.foundation.setTrailingIconAriaLabel(label);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextField.prototype, "trailingIconContent", {
			/**
			* Sets the text content of the trailing icon.
			*/
			set: function(content) {
				this.foundation.setTrailingIconContent(content);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextField.prototype, "useNativeValidation", {
			/**
			* Enables or disables the use of native validation. Use this for custom validation.
			* @param useNativeValidation Set this to false to ignore native input validation.
			*/
			set: function(useNativeValidation) {
				this.foundation.setUseNativeValidation(useNativeValidation);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextField.prototype, "prefixText", {
			/**
			* Gets the text content of the prefix, or null if it does not exist.
			*/
			get: function() {
				return this.prefix ? this.prefix.textContent : null;
			},
			/**
			* Sets the text content of the prefix, if it exists.
			*/
			set: function(prefixText) {
				if (this.prefix) this.prefix.textContent = prefixText;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTextField.prototype, "suffixText", {
			/**
			* Gets the text content of the suffix, or null if it does not exist.
			*/
			get: function() {
				return this.suffix ? this.suffix.textContent : null;
			},
			/**
			* Sets the text content of the suffix, if it exists.
			*/
			set: function(suffixText) {
				if (this.suffix) this.suffix.textContent = suffixText;
			},
			enumerable: false,
			configurable: true
		});
		/**
		* Focuses the input element.
		*/
		MDCTextField.prototype.focus = function() {
			this.input.focus();
		};
		/**
		* Recomputes the outline SVG path for the outline element.
		*/
		MDCTextField.prototype.layout = function() {
			var openNotch = this.foundation.shouldFloat;
			this.foundation.notchOutline(openNotch);
		};
		MDCTextField.prototype.getDefaultFoundation = function() {
			return new MDCTextFieldFoundation(__assign(__assign(__assign(__assign(__assign({}, this.getRootAdapterMethods()), this.getInputAdapterMethods()), this.getLabelAdapterMethods()), this.getLineRippleAdapterMethods()), this.getOutlineAdapterMethods()), this.getFoundationMap());
		};
		MDCTextField.prototype.getRootAdapterMethods = function() {
			var _this = this;
			return {
				addClass: function(className) {
					return _this.root.classList.add(className);
				},
				removeClass: function(className) {
					return _this.root.classList.remove(className);
				},
				hasClass: function(className) {
					return _this.root.classList.contains(className);
				},
				registerTextFieldInteractionHandler: function(evtType, handler) {
					_this.listen(evtType, handler);
				},
				deregisterTextFieldInteractionHandler: function(evtType, handler) {
					_this.unlisten(evtType, handler);
				},
				registerValidationAttributeChangeHandler: function(handler) {
					var getAttributesList = function(mutationsList) {
						return mutationsList.map(function(mutation) {
							return mutation.attributeName;
						}).filter(function(attributeName) {
							return attributeName;
						});
					};
					var observer = new MutationObserver(function(mutationsList) {
						return handler(getAttributesList(mutationsList));
					});
					observer.observe(_this.input, { attributes: true });
					return observer;
				},
				deregisterValidationAttributeChangeHandler: function(observer) {
					observer.disconnect();
				}
			};
		};
		MDCTextField.prototype.getInputAdapterMethods = function() {
			var _this = this;
			return {
				getNativeInput: function() {
					return _this.input;
				},
				setInputAttr: function(attr, value) {
					_this.input.setAttribute(attr, value);
				},
				removeInputAttr: function(attr) {
					_this.input.removeAttribute(attr);
				},
				isFocused: function() {
					return document.activeElement === _this.input;
				},
				registerInputInteractionHandler: function(evtType, handler) {
					_this.input.addEventListener(evtType, handler, applyPassive());
				},
				deregisterInputInteractionHandler: function(evtType, handler) {
					_this.input.removeEventListener(evtType, handler, applyPassive());
				}
			};
		};
		MDCTextField.prototype.getLabelAdapterMethods = function() {
			var _this = this;
			return {
				floatLabel: function(shouldFloat) {
					_this.label && _this.label.float(shouldFloat);
				},
				getLabelWidth: function() {
					return _this.label ? _this.label.getWidth() : 0;
				},
				hasLabel: function() {
					return Boolean(_this.label);
				},
				shakeLabel: function(shouldShake) {
					_this.label && _this.label.shake(shouldShake);
				},
				setLabelRequired: function(isRequired) {
					_this.label && _this.label.setRequired(isRequired);
				}
			};
		};
		MDCTextField.prototype.getLineRippleAdapterMethods = function() {
			var _this = this;
			return {
				activateLineRipple: function() {
					if (_this.lineRipple) _this.lineRipple.activate();
				},
				deactivateLineRipple: function() {
					if (_this.lineRipple) _this.lineRipple.deactivate();
				},
				setLineRippleTransformOrigin: function(normalizedX) {
					if (_this.lineRipple) _this.lineRipple.setRippleCenter(normalizedX);
				}
			};
		};
		MDCTextField.prototype.getOutlineAdapterMethods = function() {
			var _this = this;
			return {
				closeOutline: function() {
					_this.outline && _this.outline.closeNotch();
				},
				hasOutline: function() {
					return Boolean(_this.outline);
				},
				notchOutline: function(labelWidth) {
					_this.outline && _this.outline.notch(labelWidth);
				}
			};
		};
		/**
		* @return A map of all subcomponents to subfoundations.
		*/
		MDCTextField.prototype.getFoundationMap = function() {
			return {
				characterCounter: this.characterCounter ? this.characterCounter.foundationForTextField : void 0,
				helperText: this.helperText ? this.helperText.foundationForTextField : void 0,
				leadingIcon: this.leadingIcon ? this.leadingIcon.foundationForTextField : void 0,
				trailingIcon: this.trailingIcon ? this.trailingIcon.foundationForTextField : void 0
			};
		};
		MDCTextField.prototype.createRipple = function(rippleFactory) {
			var _this = this;
			var isTextArea = this.root.classList.contains(cssClasses$25.TEXTAREA);
			var isOutlined = this.root.classList.contains(cssClasses$25.OUTLINED);
			if (isTextArea || isOutlined) return null;
			var adapter = __assign(__assign({}, MDCRipple.createAdapter(this)), {
				isSurfaceActive: function() {
					return matches(_this.input, ":active");
				},
				registerInteractionHandler: function(evtType, handler) {
					_this.input.addEventListener(evtType, handler, applyPassive());
				},
				deregisterInteractionHandler: function(evtType, handler) {
					_this.input.removeEventListener(evtType, handler, applyPassive());
				}
			});
			return rippleFactory(this.root, new MDCRippleFoundation(adapter));
		};
		return MDCTextField;
	}(MDCComponent);

//#endregion
//#region node_modules/.pnpm/@material+menu-surface@14.0.0/node_modules/@material/menu-surface/constants.js
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
	var cssClasses$22 = {
		ANCHOR: "mdc-menu-surface--anchor",
		ANIMATING_CLOSED: "mdc-menu-surface--animating-closed",
		ANIMATING_OPEN: "mdc-menu-surface--animating-open",
		FIXED: "mdc-menu-surface--fixed",
		IS_OPEN_BELOW: "mdc-menu-surface--is-open-below",
		OPEN: "mdc-menu-surface--open",
		ROOT: "mdc-menu-surface"
	};
	var strings$26 = {
		CLOSED_EVENT: "MDCMenuSurface:closed",
		CLOSING_EVENT: "MDCMenuSurface:closing",
		OPENED_EVENT: "MDCMenuSurface:opened",
		OPENING_EVENT: "MDCMenuSurface:opening",
		FOCUSABLE_ELEMENTS: [
			"button:not(:disabled)",
			"[href]:not([aria-disabled=\"true\"])",
			"input:not(:disabled)",
			"select:not(:disabled)",
			"textarea:not(:disabled)",
			"[tabindex]:not([tabindex=\"-1\"]):not([aria-disabled=\"true\"])"
		].join(", ")
	};
	var numbers$10 = {
		/** Total duration of menu-surface open animation. */
		TRANSITION_OPEN_DURATION: 120,
		/** Total duration of menu-surface close animation. */
		TRANSITION_CLOSE_DURATION: 75,
		/**
		* Margin left to the edge of the viewport when menu-surface is at maximum
		* possible height. Also used as a viewport margin.
		*/
		MARGIN_TO_EDGE: 32,
		/**
		* Ratio of anchor width to menu-surface width for switching from corner
		* positioning to center positioning.
		*/
		ANCHOR_TO_MENU_SURFACE_WIDTH_RATIO: .67,
		/**
		* Amount of time to wait before restoring focus when closing the menu
		* surface. This is important because if a touch event triggered the menu
		* close, and the subsequent mouse event occurs after focus is restored, then
		* the restored focus would be lost.
		*/
		TOUCH_EVENT_WAIT_MS: 30
	};
	/**
	* Enum for bits in the {@see Corner) bitmap.
	*/
	var CornerBit;
	(function(CornerBit) {
		CornerBit[CornerBit["BOTTOM"] = 1] = "BOTTOM";
		CornerBit[CornerBit["CENTER"] = 2] = "CENTER";
		CornerBit[CornerBit["RIGHT"] = 4] = "RIGHT";
		CornerBit[CornerBit["FLIP_RTL"] = 8] = "FLIP_RTL";
	})(CornerBit || (CornerBit = {}));
	/**
	* Enum for representing an element corner for positioning the menu-surface.
	*
	* The START constants map to LEFT if element directionality is left
	* to right and RIGHT if the directionality is right to left.
	* Likewise END maps to RIGHT or LEFT depending on the directionality.
	*/
	var Corner;
	(function(Corner) {
		Corner[Corner["TOP_LEFT"] = 0] = "TOP_LEFT";
		Corner[Corner["TOP_RIGHT"] = 4] = "TOP_RIGHT";
		Corner[Corner["BOTTOM_LEFT"] = 1] = "BOTTOM_LEFT";
		Corner[Corner["BOTTOM_RIGHT"] = 5] = "BOTTOM_RIGHT";
		Corner[Corner["TOP_START"] = 8] = "TOP_START";
		Corner[Corner["TOP_END"] = 12] = "TOP_END";
		Corner[Corner["BOTTOM_START"] = 9] = "BOTTOM_START";
		Corner[Corner["BOTTOM_END"] = 13] = "BOTTOM_END";
	})(Corner || (Corner = {}));

//#endregion
//#region node_modules/.pnpm/@material+list@14.0.0/node_modules/@material/list/constants.js
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
	var _a;
	var _b;
	var cssClasses$21 = {
		LIST_ITEM_ACTIVATED_CLASS: "mdc-list-item--activated",
		LIST_ITEM_CLASS: "mdc-list-item",
		LIST_ITEM_DISABLED_CLASS: "mdc-list-item--disabled",
		LIST_ITEM_SELECTED_CLASS: "mdc-list-item--selected",
		LIST_ITEM_TEXT_CLASS: "mdc-list-item__text",
		LIST_ITEM_PRIMARY_TEXT_CLASS: "mdc-list-item__primary-text",
		ROOT: "mdc-list"
	};
	var evolutionClassNameMap = (_a = {}, _a["" + cssClasses$21.LIST_ITEM_ACTIVATED_CLASS] = "mdc-list-item--activated", _a["" + cssClasses$21.LIST_ITEM_CLASS] = "mdc-list-item", _a["" + cssClasses$21.LIST_ITEM_DISABLED_CLASS] = "mdc-list-item--disabled", _a["" + cssClasses$21.LIST_ITEM_SELECTED_CLASS] = "mdc-list-item--selected", _a["" + cssClasses$21.LIST_ITEM_PRIMARY_TEXT_CLASS] = "mdc-list-item__primary-text", _a["" + cssClasses$21.ROOT] = "mdc-list", _a);
	var deprecatedClassNameMap = (_b = {}, _b["" + cssClasses$21.LIST_ITEM_ACTIVATED_CLASS] = "mdc-deprecated-list-item--activated", _b["" + cssClasses$21.LIST_ITEM_CLASS] = "mdc-deprecated-list-item", _b["" + cssClasses$21.LIST_ITEM_DISABLED_CLASS] = "mdc-deprecated-list-item--disabled", _b["" + cssClasses$21.LIST_ITEM_SELECTED_CLASS] = "mdc-deprecated-list-item--selected", _b["" + cssClasses$21.LIST_ITEM_TEXT_CLASS] = "mdc-deprecated-list-item__text", _b["" + cssClasses$21.LIST_ITEM_PRIMARY_TEXT_CLASS] = "mdc-deprecated-list-item__primary-text", _b["" + cssClasses$21.ROOT] = "mdc-deprecated-list", _b);
	var strings$25 = {
		ACTION_EVENT: "MDCList:action",
		SELECTION_CHANGE_EVENT: "MDCList:selectionChange",
		ARIA_CHECKED: "aria-checked",
		ARIA_CHECKED_CHECKBOX_SELECTOR: "[role=\"checkbox\"][aria-checked=\"true\"]",
		ARIA_CHECKED_RADIO_SELECTOR: "[role=\"radio\"][aria-checked=\"true\"]",
		ARIA_CURRENT: "aria-current",
		ARIA_DISABLED: "aria-disabled",
		ARIA_ORIENTATION: "aria-orientation",
		ARIA_ORIENTATION_HORIZONTAL: "horizontal",
		ARIA_ROLE_CHECKBOX_SELECTOR: "[role=\"checkbox\"]",
		ARIA_SELECTED: "aria-selected",
		ARIA_INTERACTIVE_ROLES_SELECTOR: "[role=\"listbox\"], [role=\"menu\"]",
		ARIA_MULTI_SELECTABLE_SELECTOR: "[aria-multiselectable=\"true\"]",
		CHECKBOX_RADIO_SELECTOR: "input[type=\"checkbox\"], input[type=\"radio\"]",
		CHECKBOX_SELECTOR: "input[type=\"checkbox\"]",
		CHILD_ELEMENTS_TO_TOGGLE_TABINDEX: "\n    ." + cssClasses$21.LIST_ITEM_CLASS + " button:not(:disabled),\n    ." + cssClasses$21.LIST_ITEM_CLASS + " a,\n    ." + deprecatedClassNameMap[cssClasses$21.LIST_ITEM_CLASS] + " button:not(:disabled),\n    ." + deprecatedClassNameMap[cssClasses$21.LIST_ITEM_CLASS] + " a\n  ",
		DEPRECATED_SELECTOR: ".mdc-deprecated-list",
		FOCUSABLE_CHILD_ELEMENTS: "\n    ." + cssClasses$21.LIST_ITEM_CLASS + " button:not(:disabled),\n    ." + cssClasses$21.LIST_ITEM_CLASS + " a,\n    ." + cssClasses$21.LIST_ITEM_CLASS + " input[type=\"radio\"]:not(:disabled),\n    ." + cssClasses$21.LIST_ITEM_CLASS + " input[type=\"checkbox\"]:not(:disabled),\n    ." + deprecatedClassNameMap[cssClasses$21.LIST_ITEM_CLASS] + " button:not(:disabled),\n    ." + deprecatedClassNameMap[cssClasses$21.LIST_ITEM_CLASS] + " a,\n    ." + deprecatedClassNameMap[cssClasses$21.LIST_ITEM_CLASS] + " input[type=\"radio\"]:not(:disabled),\n    ." + deprecatedClassNameMap[cssClasses$21.LIST_ITEM_CLASS] + " input[type=\"checkbox\"]:not(:disabled)\n  ",
		RADIO_SELECTOR: "input[type=\"radio\"]",
		SELECTED_ITEM_SELECTOR: "[aria-selected=\"true\"], [aria-current=\"true\"]"
	};
	var numbers$9 = {
		UNSET_INDEX: -1,
		TYPEAHEAD_BUFFER_CLEAR_TIMEOUT_MS: 300
	};
	var evolutionAttribute = "evolution";

//#endregion
//#region node_modules/.pnpm/@material+dom@14.0.0/node_modules/@material/dom/keyboard.js
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
	/**
	* KEY provides normalized string values for keys.
	*/
	var KEY = {
		UNKNOWN: "Unknown",
		BACKSPACE: "Backspace",
		ENTER: "Enter",
		SPACEBAR: "Spacebar",
		PAGE_UP: "PageUp",
		PAGE_DOWN: "PageDown",
		END: "End",
		HOME: "Home",
		ARROW_LEFT: "ArrowLeft",
		ARROW_UP: "ArrowUp",
		ARROW_RIGHT: "ArrowRight",
		ARROW_DOWN: "ArrowDown",
		DELETE: "Delete",
		ESCAPE: "Escape",
		TAB: "Tab"
	};
	var normalizedKeys = /* @__PURE__ */ new Set();
	normalizedKeys.add(KEY.BACKSPACE);
	normalizedKeys.add(KEY.ENTER);
	normalizedKeys.add(KEY.SPACEBAR);
	normalizedKeys.add(KEY.PAGE_UP);
	normalizedKeys.add(KEY.PAGE_DOWN);
	normalizedKeys.add(KEY.END);
	normalizedKeys.add(KEY.HOME);
	normalizedKeys.add(KEY.ARROW_LEFT);
	normalizedKeys.add(KEY.ARROW_UP);
	normalizedKeys.add(KEY.ARROW_RIGHT);
	normalizedKeys.add(KEY.ARROW_DOWN);
	normalizedKeys.add(KEY.DELETE);
	normalizedKeys.add(KEY.ESCAPE);
	normalizedKeys.add(KEY.TAB);
	var KEY_CODE = {
		BACKSPACE: 8,
		ENTER: 13,
		SPACEBAR: 32,
		PAGE_UP: 33,
		PAGE_DOWN: 34,
		END: 35,
		HOME: 36,
		ARROW_LEFT: 37,
		ARROW_UP: 38,
		ARROW_RIGHT: 39,
		ARROW_DOWN: 40,
		DELETE: 46,
		ESCAPE: 27,
		TAB: 9
	};
	var mappedKeyCodes = /* @__PURE__ */ new Map();
	mappedKeyCodes.set(KEY_CODE.BACKSPACE, KEY.BACKSPACE);
	mappedKeyCodes.set(KEY_CODE.ENTER, KEY.ENTER);
	mappedKeyCodes.set(KEY_CODE.SPACEBAR, KEY.SPACEBAR);
	mappedKeyCodes.set(KEY_CODE.PAGE_UP, KEY.PAGE_UP);
	mappedKeyCodes.set(KEY_CODE.PAGE_DOWN, KEY.PAGE_DOWN);
	mappedKeyCodes.set(KEY_CODE.END, KEY.END);
	mappedKeyCodes.set(KEY_CODE.HOME, KEY.HOME);
	mappedKeyCodes.set(KEY_CODE.ARROW_LEFT, KEY.ARROW_LEFT);
	mappedKeyCodes.set(KEY_CODE.ARROW_UP, KEY.ARROW_UP);
	mappedKeyCodes.set(KEY_CODE.ARROW_RIGHT, KEY.ARROW_RIGHT);
	mappedKeyCodes.set(KEY_CODE.ARROW_DOWN, KEY.ARROW_DOWN);
	mappedKeyCodes.set(KEY_CODE.DELETE, KEY.DELETE);
	mappedKeyCodes.set(KEY_CODE.ESCAPE, KEY.ESCAPE);
	mappedKeyCodes.set(KEY_CODE.TAB, KEY.TAB);
	var navigationKeys = /* @__PURE__ */ new Set();
	navigationKeys.add(KEY.PAGE_UP);
	navigationKeys.add(KEY.PAGE_DOWN);
	navigationKeys.add(KEY.END);
	navigationKeys.add(KEY.HOME);
	navigationKeys.add(KEY.ARROW_LEFT);
	navigationKeys.add(KEY.ARROW_UP);
	navigationKeys.add(KEY.ARROW_RIGHT);
	navigationKeys.add(KEY.ARROW_DOWN);
	/**
	* normalizeKey returns the normalized string for a navigational action.
	*/
	function normalizeKey(evt) {
		var key = evt.key;
		if (normalizedKeys.has(key)) return key;
		var mappedKey = mappedKeyCodes.get(evt.keyCode);
		if (mappedKey) return mappedKey;
		return KEY.UNKNOWN;
	}

//#endregion
//#region node_modules/.pnpm/@material+list@14.0.0/node_modules/@material/list/events.js
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
	var ELEMENTS_KEY_ALLOWED_IN = [
		"input",
		"button",
		"textarea",
		"select"
	];
	/**
	* Ensures that preventDefault is only called if the containing element
	* doesn't consume the event, and it will cause an unintended scroll.
	*
	* @param evt keyboard event to be prevented.
	*/
	var preventDefaultEvent = function(evt) {
		var target = evt.target;
		if (!target) return;
		var tagName = ("" + target.tagName).toLowerCase();
		if (ELEMENTS_KEY_ALLOWED_IN.indexOf(tagName) === -1) evt.preventDefault();
	};

//#endregion
//#region node_modules/.pnpm/@material+list@14.0.0/node_modules/@material/list/typeahead.js
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
	/**
	* Initializes a state object for typeahead. Use the same reference for calls to
	* typeahead functions.
	*
	* @return The current state of the typeahead process. Each state reference
	*     represents a typeahead instance as the reference is typically mutated
	*     in-place.
	*/
	function initState() {
		return {
			bufferClearTimeout: 0,
			currentFirstChar: "",
			sortedIndexCursor: 0,
			typeaheadBuffer: ""
		};
	}
	/**
	* Initializes typeahead state by indexing the current list items by primary
	* text into the sortedIndexByFirstChar data structure.
	*
	* @param listItemCount numer of items in the list
	* @param getPrimaryTextByItemIndex function that returns the primary text at a
	*     given index
	*
	* @return Map that maps the first character of the primary text to the full
	*     list text and it's index
	*/
	function initSortedIndex(listItemCount, getPrimaryTextByItemIndex) {
		var sortedIndexByFirstChar = /* @__PURE__ */ new Map();
		for (var i = 0; i < listItemCount; i++) {
			var primaryText = getPrimaryTextByItemIndex(i).trim();
			if (!primaryText) continue;
			var firstChar = primaryText[0].toLowerCase();
			if (!sortedIndexByFirstChar.has(firstChar)) sortedIndexByFirstChar.set(firstChar, []);
			sortedIndexByFirstChar.get(firstChar).push({
				text: primaryText.toLowerCase(),
				index: i
			});
		}
		sortedIndexByFirstChar.forEach(function(values) {
			values.sort(function(first, second) {
				return first.index - second.index;
			});
		});
		return sortedIndexByFirstChar;
	}
	/**
	* Given the next desired character from the user, it attempts to find the next
	* list option matching the buffer. Wraps around if at the end of options.
	*
	* @param opts Options and accessors
	*   - nextChar - the next character to match against items
	*   - sortedIndexByFirstChar - output of `initSortedIndex(...)`
	*   - focusedItemIndex - the index of the currently focused item
	*   - focusItemAtIndex - function that focuses a list item at given index
	*   - skipFocus - whether or not to focus the matched item
	*   - isItemAtIndexDisabled - function that determines whether an item at a
	*        given index is disabled
	* @param state The typeahead state instance. See `initState`.
	*
	* @return The index of the matched item, or -1 if no match.
	*/
	function matchItem(opts, state) {
		var nextChar = opts.nextChar, focusItemAtIndex = opts.focusItemAtIndex, sortedIndexByFirstChar = opts.sortedIndexByFirstChar, focusedItemIndex = opts.focusedItemIndex, skipFocus = opts.skipFocus, isItemAtIndexDisabled = opts.isItemAtIndexDisabled;
		clearTimeout(state.bufferClearTimeout);
		state.bufferClearTimeout = setTimeout(function() {
			clearBuffer(state);
		}, numbers$9.TYPEAHEAD_BUFFER_CLEAR_TIMEOUT_MS);
		state.typeaheadBuffer = state.typeaheadBuffer + nextChar;
		var index;
		if (state.typeaheadBuffer.length === 1) index = matchFirstChar(sortedIndexByFirstChar, focusedItemIndex, isItemAtIndexDisabled, state);
		else index = matchAllChars(sortedIndexByFirstChar, isItemAtIndexDisabled, state);
		if (index !== -1 && !skipFocus) focusItemAtIndex(index);
		return index;
	}
	/**
	* Matches the user's single input character in the buffer to the
	* next option that begins with such character. Wraps around if at
	* end of options. Returns -1 if no match is found.
	*/
	function matchFirstChar(sortedIndexByFirstChar, focusedItemIndex, isItemAtIndexDisabled, state) {
		var firstChar = state.typeaheadBuffer[0];
		var itemsMatchingFirstChar = sortedIndexByFirstChar.get(firstChar);
		if (!itemsMatchingFirstChar) return -1;
		if (firstChar === state.currentFirstChar && itemsMatchingFirstChar[state.sortedIndexCursor].index === focusedItemIndex) {
			state.sortedIndexCursor = (state.sortedIndexCursor + 1) % itemsMatchingFirstChar.length;
			var newIndex = itemsMatchingFirstChar[state.sortedIndexCursor].index;
			if (!isItemAtIndexDisabled(newIndex)) return newIndex;
		}
		state.currentFirstChar = firstChar;
		var newCursorPosition = -1;
		var cursorPosition;
		for (cursorPosition = 0; cursorPosition < itemsMatchingFirstChar.length; cursorPosition++) if (!isItemAtIndexDisabled(itemsMatchingFirstChar[cursorPosition].index)) {
			newCursorPosition = cursorPosition;
			break;
		}
		for (; cursorPosition < itemsMatchingFirstChar.length; cursorPosition++) if (itemsMatchingFirstChar[cursorPosition].index > focusedItemIndex && !isItemAtIndexDisabled(itemsMatchingFirstChar[cursorPosition].index)) {
			newCursorPosition = cursorPosition;
			break;
		}
		if (newCursorPosition !== -1) {
			state.sortedIndexCursor = newCursorPosition;
			return itemsMatchingFirstChar[state.sortedIndexCursor].index;
		}
		return -1;
	}
	/**
	* Attempts to find the next item that matches all of the typeahead buffer.
	* Wraps around if at end of options. Returns -1 if no match is found.
	*/
	function matchAllChars(sortedIndexByFirstChar, isItemAtIndexDisabled, state) {
		var firstChar = state.typeaheadBuffer[0];
		var itemsMatchingFirstChar = sortedIndexByFirstChar.get(firstChar);
		if (!itemsMatchingFirstChar) return -1;
		var startingItem = itemsMatchingFirstChar[state.sortedIndexCursor];
		if (startingItem.text.lastIndexOf(state.typeaheadBuffer, 0) === 0 && !isItemAtIndexDisabled(startingItem.index)) return startingItem.index;
		var cursorPosition = (state.sortedIndexCursor + 1) % itemsMatchingFirstChar.length;
		var nextCursorPosition = -1;
		while (cursorPosition !== state.sortedIndexCursor) {
			var currentItem = itemsMatchingFirstChar[cursorPosition];
			var matches = currentItem.text.lastIndexOf(state.typeaheadBuffer, 0) === 0;
			var isEnabled = !isItemAtIndexDisabled(currentItem.index);
			if (matches && isEnabled) {
				nextCursorPosition = cursorPosition;
				break;
			}
			cursorPosition = (cursorPosition + 1) % itemsMatchingFirstChar.length;
		}
		if (nextCursorPosition !== -1) {
			state.sortedIndexCursor = nextCursorPosition;
			return itemsMatchingFirstChar[state.sortedIndexCursor].index;
		}
		return -1;
	}
	/**
	* Whether or not the given typeahead instaance state is currently typing.
	*
	* @param state The typeahead state instance. See `initState`.
	*/
	function isTypingInProgress(state) {
		return state.typeaheadBuffer.length > 0;
	}
	/**
	* Clears the typeahaed buffer so that it resets item matching to the first
	* character.
	*
	* @param state The typeahead state instance. See `initState`.
	*/
	function clearBuffer(state) {
		state.typeaheadBuffer = "";
	}
	/**
	* Given a keydown event, it calculates whether or not to automatically focus a
	* list item depending on what was typed mimicing the typeahead functionality of
	* a standard <select> element that is open.
	*
	* @param opts Options and accessors
	*   - event - the KeyboardEvent to handle and parse
	*   - sortedIndexByFirstChar - output of `initSortedIndex(...)`
	*   - focusedItemIndex - the index of the currently focused item
	*   - focusItemAtIndex - function that focuses a list item at given index
	*   - isItemAtFocusedIndexDisabled - whether or not the currently focused item
	*      is disabled
	*   - isTargetListItem - whether or not the event target is a list item
	* @param state The typeahead state instance. See `initState`.
	*
	* @returns index of the item matched by the keydown. -1 if not matched.
	*/
	function handleKeydown(opts, state) {
		var event = opts.event, isTargetListItem = opts.isTargetListItem, focusedItemIndex = opts.focusedItemIndex, focusItemAtIndex = opts.focusItemAtIndex, sortedIndexByFirstChar = opts.sortedIndexByFirstChar, isItemAtIndexDisabled = opts.isItemAtIndexDisabled;
		var isArrowLeft = normalizeKey(event) === "ArrowLeft";
		var isArrowUp = normalizeKey(event) === "ArrowUp";
		var isArrowRight = normalizeKey(event) === "ArrowRight";
		var isArrowDown = normalizeKey(event) === "ArrowDown";
		var isHome = normalizeKey(event) === "Home";
		var isEnd = normalizeKey(event) === "End";
		var isEnter = normalizeKey(event) === "Enter";
		var isSpace = normalizeKey(event) === "Spacebar";
		if (event.altKey || event.ctrlKey || event.metaKey || isArrowLeft || isArrowUp || isArrowRight || isArrowDown || isHome || isEnd || isEnter) return -1;
		if (!isSpace && event.key.length === 1) {
			preventDefaultEvent(event);
			var matchItemOpts = {
				focusItemAtIndex,
				focusedItemIndex,
				nextChar: event.key.toLowerCase(),
				sortedIndexByFirstChar,
				skipFocus: false,
				isItemAtIndexDisabled
			};
			return matchItem(matchItemOpts, state);
		}
		if (!isSpace) return -1;
		if (isTargetListItem) preventDefaultEvent(event);
		if (isTargetListItem && isTypingInProgress(state)) {
			var matchItemOpts = {
				focusItemAtIndex,
				focusedItemIndex,
				nextChar: " ",
				sortedIndexByFirstChar,
				skipFocus: false,
				isItemAtIndexDisabled
			};
			return matchItem(matchItemOpts, state);
		}
		return -1;
	}

//#endregion
//#region node_modules/.pnpm/@material+list@14.0.0/node_modules/@material/list/foundation.js
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
	function isNumberArray(selectedIndex) {
		return selectedIndex instanceof Array;
	}
	/** List of modifier keys to consider while handling keyboard events. */
	var handledModifierKeys = [
		"Alt",
		"Control",
		"Meta",
		"Shift"
	];
	/** Checks if the event has the given modifier keys. */
	function createModifierChecker(event) {
		var eventModifiers = new Set(event ? handledModifierKeys.filter(function(m) {
			return event.getModifierState(m);
		}) : []);
		return function(modifiers) {
			return modifiers.every(function(m) {
				return eventModifiers.has(m);
			}) && modifiers.length === eventModifiers.size;
		};
	}
	var MDCListFoundation = function(_super) {
		__extends(MDCListFoundation, _super);
		function MDCListFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCListFoundation.defaultAdapter), adapter)) || this;
			_this.wrapFocus = false;
			_this.isVertical = true;
			_this.isSingleSelectionList = false;
			_this.areDisabledItemsFocusable = true;
			_this.selectedIndex = numbers$9.UNSET_INDEX;
			_this.focusedItemIndex = numbers$9.UNSET_INDEX;
			_this.useActivatedClass = false;
			_this.useSelectedAttr = false;
			_this.ariaCurrentAttrValue = null;
			_this.isCheckboxList = false;
			_this.isRadioList = false;
			_this.lastSelectedIndex = null;
			_this.hasTypeahead = false;
			_this.typeaheadState = initState();
			_this.sortedIndexByFirstChar = /* @__PURE__ */ new Map();
			return _this;
		}
		Object.defineProperty(MDCListFoundation, "strings", {
			get: function() {
				return strings$25;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCListFoundation, "cssClasses", {
			get: function() {
				return cssClasses$21;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCListFoundation, "numbers", {
			get: function() {
				return numbers$9;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCListFoundation, "defaultAdapter", {
			get: function() {
				return {
					addClassForElementIndex: function() {},
					focusItemAtIndex: function() {},
					getAttributeForElementIndex: function() {
						return null;
					},
					getFocusedElementIndex: function() {
						return 0;
					},
					getListItemCount: function() {
						return 0;
					},
					hasCheckboxAtIndex: function() {
						return false;
					},
					hasRadioAtIndex: function() {
						return false;
					},
					isCheckboxCheckedAtIndex: function() {
						return false;
					},
					isFocusInsideList: function() {
						return false;
					},
					isRootFocused: function() {
						return false;
					},
					listItemAtIndexHasClass: function() {
						return false;
					},
					notifyAction: function() {},
					notifySelectionChange: function() {},
					removeClassForElementIndex: function() {},
					setAttributeForElementIndex: function() {},
					setCheckedCheckboxOrRadioAtIndex: function() {},
					setTabIndexForListItemChildren: function() {},
					getPrimaryTextAtIndex: function() {
						return "";
					}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCListFoundation.prototype.layout = function() {
			if (this.adapter.getListItemCount() === 0) return;
			if (this.adapter.hasCheckboxAtIndex(0)) this.isCheckboxList = true;
			else if (this.adapter.hasRadioAtIndex(0)) this.isRadioList = true;
			else this.maybeInitializeSingleSelection();
			if (this.hasTypeahead) this.sortedIndexByFirstChar = this.typeaheadInitSortedIndex();
		};
		/** Returns the index of the item that was last focused. */
		MDCListFoundation.prototype.getFocusedItemIndex = function() {
			return this.focusedItemIndex;
		};
		/** Toggles focus wrapping with keyboard navigation. */
		MDCListFoundation.prototype.setWrapFocus = function(value) {
			this.wrapFocus = value;
		};
		/**
		* Toggles orientation direction for keyboard navigation (true for vertical,
		* false for horizontal).
		*/
		MDCListFoundation.prototype.setVerticalOrientation = function(value) {
			this.isVertical = value;
		};
		/** Toggles single-selection behavior. */
		MDCListFoundation.prototype.setSingleSelection = function(value) {
			this.isSingleSelectionList = value;
			if (value) {
				this.maybeInitializeSingleSelection();
				this.selectedIndex = this.getSelectedIndexFromDOM();
			}
		};
		MDCListFoundation.prototype.setDisabledItemsFocusable = function(value) {
			this.areDisabledItemsFocusable = value;
		};
		/**
		* Automatically determines whether the list is single selection list. If so,
		* initializes the internal state to match the selected item.
		*/
		MDCListFoundation.prototype.maybeInitializeSingleSelection = function() {
			var selectedItemIndex = this.getSelectedIndexFromDOM();
			if (selectedItemIndex === numbers$9.UNSET_INDEX) return;
			if (this.adapter.listItemAtIndexHasClass(selectedItemIndex, cssClasses$21.LIST_ITEM_ACTIVATED_CLASS)) this.setUseActivatedClass(true);
			this.isSingleSelectionList = true;
			this.selectedIndex = selectedItemIndex;
		};
		/** @return Index of the first selected item based on the DOM state. */
		MDCListFoundation.prototype.getSelectedIndexFromDOM = function() {
			var selectedIndex = numbers$9.UNSET_INDEX;
			var listItemsCount = this.adapter.getListItemCount();
			for (var i = 0; i < listItemsCount; i++) {
				var hasSelectedClass = this.adapter.listItemAtIndexHasClass(i, cssClasses$21.LIST_ITEM_SELECTED_CLASS);
				var hasActivatedClass = this.adapter.listItemAtIndexHasClass(i, cssClasses$21.LIST_ITEM_ACTIVATED_CLASS);
				if (!(hasSelectedClass || hasActivatedClass)) continue;
				selectedIndex = i;
				break;
			}
			return selectedIndex;
		};
		/**
		* Sets whether typeahead is enabled on the list.
		* @param hasTypeahead Whether typeahead is enabled.
		*/
		MDCListFoundation.prototype.setHasTypeahead = function(hasTypeahead) {
			this.hasTypeahead = hasTypeahead;
			if (hasTypeahead) this.sortedIndexByFirstChar = this.typeaheadInitSortedIndex();
		};
		/**
		* @return Whether typeahead is currently matching a user-specified prefix.
		*/
		MDCListFoundation.prototype.isTypeaheadInProgress = function() {
			return this.hasTypeahead && isTypingInProgress(this.typeaheadState);
		};
		/** Toggle use of the "activated" CSS class. */
		MDCListFoundation.prototype.setUseActivatedClass = function(useActivated) {
			this.useActivatedClass = useActivated;
		};
		/**
		* Toggles use of the selected attribute (true for aria-selected, false for
		* aria-checked).
		*/
		MDCListFoundation.prototype.setUseSelectedAttribute = function(useSelected) {
			this.useSelectedAttr = useSelected;
		};
		MDCListFoundation.prototype.getSelectedIndex = function() {
			return this.selectedIndex;
		};
		MDCListFoundation.prototype.setSelectedIndex = function(index, options) {
			if (options === void 0) options = {};
			if (!this.isIndexValid(index)) return;
			if (this.isCheckboxList) this.setCheckboxAtIndex(index, options);
			else if (this.isRadioList) this.setRadioAtIndex(index, options);
			else this.setSingleSelectionAtIndex(index, options);
		};
		/**
		* Focus in handler for the list items.
		*/
		MDCListFoundation.prototype.handleFocusIn = function(listItemIndex) {
			if (listItemIndex >= 0) {
				this.focusedItemIndex = listItemIndex;
				this.adapter.setAttributeForElementIndex(listItemIndex, "tabindex", "0");
				this.adapter.setTabIndexForListItemChildren(listItemIndex, "0");
			}
		};
		/**
		* Focus out handler for the list items.
		*/
		MDCListFoundation.prototype.handleFocusOut = function(listItemIndex) {
			var _this = this;
			if (listItemIndex >= 0) {
				this.adapter.setAttributeForElementIndex(listItemIndex, "tabindex", "-1");
				this.adapter.setTabIndexForListItemChildren(listItemIndex, "-1");
			}
			/**
			* Between Focusout & Focusin some browsers do not have focus on any
			* element. Setting a delay to wait till the focus is moved to next element.
			*/
			setTimeout(function() {
				if (!_this.adapter.isFocusInsideList()) _this.setTabindexToFirstSelectedOrFocusedItem();
			}, 0);
		};
		MDCListFoundation.prototype.isIndexDisabled = function(index) {
			return this.adapter.listItemAtIndexHasClass(index, cssClasses$21.LIST_ITEM_DISABLED_CLASS);
		};
		/**
		* Key handler for the list.
		*/
		MDCListFoundation.prototype.handleKeydown = function(event, isRootListItem, listItemIndex) {
			var _this = this;
			var _a;
			var isArrowLeft = normalizeKey(event) === "ArrowLeft";
			var isArrowUp = normalizeKey(event) === "ArrowUp";
			var isArrowRight = normalizeKey(event) === "ArrowRight";
			var isArrowDown = normalizeKey(event) === "ArrowDown";
			var isHome = normalizeKey(event) === "Home";
			var isEnd = normalizeKey(event) === "End";
			var isEnter = normalizeKey(event) === "Enter";
			var isSpace = normalizeKey(event) === "Spacebar";
			var isForward = this.isVertical && isArrowDown || !this.isVertical && isArrowRight;
			var isBack = this.isVertical && isArrowUp || !this.isVertical && isArrowLeft;
			var isLetterA = event.key === "A" || event.key === "a";
			var eventHasModifiers = createModifierChecker(event);
			if (this.adapter.isRootFocused()) {
				if ((isBack || isEnd) && eventHasModifiers([])) {
					event.preventDefault();
					this.focusLastElement();
				} else if ((isForward || isHome) && eventHasModifiers([])) {
					event.preventDefault();
					this.focusFirstElement();
				} else if (isBack && eventHasModifiers(["Shift"]) && this.isCheckboxList) {
					event.preventDefault();
					var focusedIndex = this.focusLastElement();
					if (focusedIndex !== -1) this.setSelectedIndexOnAction(focusedIndex, false);
				} else if (isForward && eventHasModifiers(["Shift"]) && this.isCheckboxList) {
					event.preventDefault();
					var focusedIndex = this.focusFirstElement();
					if (focusedIndex !== -1) this.setSelectedIndexOnAction(focusedIndex, false);
				}
				if (this.hasTypeahead) {
					var handleKeydownOpts = {
						event,
						focusItemAtIndex: function(index) {
							_this.focusItemAtIndex(index);
						},
						focusedItemIndex: -1,
						isTargetListItem: isRootListItem,
						sortedIndexByFirstChar: this.sortedIndexByFirstChar,
						isItemAtIndexDisabled: function(index) {
							return _this.isIndexDisabled(index);
						}
					};
					handleKeydown(handleKeydownOpts, this.typeaheadState);
				}
				return;
			}
			var currentIndex = this.adapter.getFocusedElementIndex();
			if (currentIndex === -1) {
				currentIndex = listItemIndex;
				if (currentIndex < 0) return;
			}
			if (isForward && eventHasModifiers([])) {
				preventDefaultEvent(event);
				this.focusNextElement(currentIndex);
			} else if (isBack && eventHasModifiers([])) {
				preventDefaultEvent(event);
				this.focusPrevElement(currentIndex);
			} else if (isForward && eventHasModifiers(["Shift"]) && this.isCheckboxList) {
				preventDefaultEvent(event);
				var focusedIndex = this.focusNextElement(currentIndex);
				if (focusedIndex !== -1) this.setSelectedIndexOnAction(focusedIndex, false);
			} else if (isBack && eventHasModifiers(["Shift"]) && this.isCheckboxList) {
				preventDefaultEvent(event);
				var focusedIndex = this.focusPrevElement(currentIndex);
				if (focusedIndex !== -1) this.setSelectedIndexOnAction(focusedIndex, false);
			} else if (isHome && eventHasModifiers([])) {
				preventDefaultEvent(event);
				this.focusFirstElement();
			} else if (isEnd && eventHasModifiers([])) {
				preventDefaultEvent(event);
				this.focusLastElement();
			} else if (isHome && eventHasModifiers(["Control", "Shift"]) && this.isCheckboxList) {
				preventDefaultEvent(event);
				if (this.isIndexDisabled(currentIndex)) return;
				this.focusFirstElement();
				this.toggleCheckboxRange(0, currentIndex, currentIndex);
			} else if (isEnd && eventHasModifiers(["Control", "Shift"]) && this.isCheckboxList) {
				preventDefaultEvent(event);
				if (this.isIndexDisabled(currentIndex)) return;
				this.focusLastElement();
				this.toggleCheckboxRange(currentIndex, this.adapter.getListItemCount() - 1, currentIndex);
			} else if (isLetterA && eventHasModifiers(["Control"]) && this.isCheckboxList) {
				event.preventDefault();
				this.checkboxListToggleAll(this.selectedIndex === numbers$9.UNSET_INDEX ? [] : this.selectedIndex, true);
			} else if ((isEnter || isSpace) && eventHasModifiers([])) {
				if (isRootListItem) {
					var target = event.target;
					if (target && target.tagName === "A" && isEnter) return;
					preventDefaultEvent(event);
					if (this.isIndexDisabled(currentIndex)) return;
					if (!this.isTypeaheadInProgress()) {
						if (this.isSelectableList()) this.setSelectedIndexOnAction(currentIndex, false);
						this.adapter.notifyAction(currentIndex);
					}
				}
			} else if ((isEnter || isSpace) && eventHasModifiers(["Shift"]) && this.isCheckboxList) {
				var target = event.target;
				if (target && target.tagName === "A" && isEnter) return;
				preventDefaultEvent(event);
				if (this.isIndexDisabled(currentIndex)) return;
				if (!this.isTypeaheadInProgress()) {
					this.toggleCheckboxRange((_a = this.lastSelectedIndex) !== null && _a !== void 0 ? _a : currentIndex, currentIndex, currentIndex);
					this.adapter.notifyAction(currentIndex);
				}
			}
			if (this.hasTypeahead) {
				var handleKeydownOpts = {
					event,
					focusItemAtIndex: function(index) {
						_this.focusItemAtIndex(index);
					},
					focusedItemIndex: this.focusedItemIndex,
					isTargetListItem: isRootListItem,
					sortedIndexByFirstChar: this.sortedIndexByFirstChar,
					isItemAtIndexDisabled: function(index) {
						return _this.isIndexDisabled(index);
					}
				};
				handleKeydown(handleKeydownOpts, this.typeaheadState);
			}
		};
		/**
		* Click handler for the list.
		*
		* @param index Index for the item that has been clicked.
		* @param isCheckboxAlreadyUpdatedInAdapter Whether the checkbox for
		*   the list item has already been updated in the adapter. This attribute
		*   should be set to `true` when e.g. the click event directly landed on
		*   the underlying native checkbox element which would cause the checked
		*   state to be already toggled within `adapter.isCheckboxCheckedAtIndex`.
		*/
		MDCListFoundation.prototype.handleClick = function(index, isCheckboxAlreadyUpdatedInAdapter, event) {
			var _a;
			var eventHasModifiers = createModifierChecker(event);
			if (index === numbers$9.UNSET_INDEX) return;
			if (this.isIndexDisabled(index)) return;
			if (eventHasModifiers([])) {
				if (this.isSelectableList()) this.setSelectedIndexOnAction(index, isCheckboxAlreadyUpdatedInAdapter);
				this.adapter.notifyAction(index);
			} else if (this.isCheckboxList && eventHasModifiers(["Shift"])) {
				this.toggleCheckboxRange((_a = this.lastSelectedIndex) !== null && _a !== void 0 ? _a : index, index, index);
				this.adapter.notifyAction(index);
			}
		};
		/**
		* Focuses the next element on the list.
		*/
		MDCListFoundation.prototype.focusNextElement = function(index) {
			var count = this.adapter.getListItemCount();
			var nextIndex = index;
			var firstChecked = null;
			do {
				nextIndex++;
				if (nextIndex >= count) if (this.wrapFocus) nextIndex = 0;
				else return index;
				if (nextIndex === firstChecked) return -1;
				firstChecked = firstChecked !== null && firstChecked !== void 0 ? firstChecked : nextIndex;
			} while (!this.areDisabledItemsFocusable && this.isIndexDisabled(nextIndex));
			this.focusItemAtIndex(nextIndex);
			return nextIndex;
		};
		/**
		* Focuses the previous element on the list.
		*/
		MDCListFoundation.prototype.focusPrevElement = function(index) {
			var count = this.adapter.getListItemCount();
			var prevIndex = index;
			var firstChecked = null;
			do {
				prevIndex--;
				if (prevIndex < 0) if (this.wrapFocus) prevIndex = count - 1;
				else return index;
				if (prevIndex === firstChecked) return -1;
				firstChecked = firstChecked !== null && firstChecked !== void 0 ? firstChecked : prevIndex;
			} while (!this.areDisabledItemsFocusable && this.isIndexDisabled(prevIndex));
			this.focusItemAtIndex(prevIndex);
			return prevIndex;
		};
		MDCListFoundation.prototype.focusFirstElement = function() {
			return this.focusNextElement(-1);
		};
		MDCListFoundation.prototype.focusLastElement = function() {
			return this.focusPrevElement(this.adapter.getListItemCount());
		};
		MDCListFoundation.prototype.focusInitialElement = function() {
			var initialIndex = this.getFirstSelectedOrFocusedItemIndex();
			this.focusItemAtIndex(initialIndex);
			return initialIndex;
		};
		/**
		* @param itemIndex Index of the list item
		* @param isEnabled Sets the list item to enabled or disabled.
		*/
		MDCListFoundation.prototype.setEnabled = function(itemIndex, isEnabled) {
			if (!this.isIndexValid(itemIndex, false)) return;
			if (isEnabled) {
				this.adapter.removeClassForElementIndex(itemIndex, cssClasses$21.LIST_ITEM_DISABLED_CLASS);
				this.adapter.setAttributeForElementIndex(itemIndex, strings$25.ARIA_DISABLED, "false");
			} else {
				this.adapter.addClassForElementIndex(itemIndex, cssClasses$21.LIST_ITEM_DISABLED_CLASS);
				this.adapter.setAttributeForElementIndex(itemIndex, strings$25.ARIA_DISABLED, "true");
			}
		};
		MDCListFoundation.prototype.setSingleSelectionAtIndex = function(index, options) {
			if (options === void 0) options = {};
			if (this.selectedIndex === index && !options.forceUpdate) return;
			var selectedClassName = cssClasses$21.LIST_ITEM_SELECTED_CLASS;
			if (this.useActivatedClass) selectedClassName = cssClasses$21.LIST_ITEM_ACTIVATED_CLASS;
			if (this.selectedIndex !== numbers$9.UNSET_INDEX) this.adapter.removeClassForElementIndex(this.selectedIndex, selectedClassName);
			this.setAriaForSingleSelectionAtIndex(index);
			this.setTabindexAtIndex(index);
			if (index !== numbers$9.UNSET_INDEX) this.adapter.addClassForElementIndex(index, selectedClassName);
			this.selectedIndex = index;
			if (options.isUserInteraction && !options.forceUpdate) this.adapter.notifySelectionChange([index]);
		};
		/**
		* Sets aria attribute for single selection at given index.
		*/
		MDCListFoundation.prototype.setAriaForSingleSelectionAtIndex = function(index) {
			if (this.selectedIndex === numbers$9.UNSET_INDEX) this.ariaCurrentAttrValue = this.adapter.getAttributeForElementIndex(index, strings$25.ARIA_CURRENT);
			var isAriaCurrent = this.ariaCurrentAttrValue !== null;
			var ariaAttribute = isAriaCurrent ? strings$25.ARIA_CURRENT : strings$25.ARIA_SELECTED;
			if (this.selectedIndex !== numbers$9.UNSET_INDEX) this.adapter.setAttributeForElementIndex(this.selectedIndex, ariaAttribute, "false");
			if (index !== numbers$9.UNSET_INDEX) {
				var ariaAttributeValue = isAriaCurrent ? this.ariaCurrentAttrValue : "true";
				this.adapter.setAttributeForElementIndex(index, ariaAttribute, ariaAttributeValue);
			}
		};
		/**
		* Returns the attribute to use for indicating selection status.
		*/
		MDCListFoundation.prototype.getSelectionAttribute = function() {
			return this.useSelectedAttr ? strings$25.ARIA_SELECTED : strings$25.ARIA_CHECKED;
		};
		/**
		* Toggles radio at give index. Radio doesn't change the checked state if it
		* is already checked.
		*/
		MDCListFoundation.prototype.setRadioAtIndex = function(index, options) {
			if (options === void 0) options = {};
			var selectionAttribute = this.getSelectionAttribute();
			this.adapter.setCheckedCheckboxOrRadioAtIndex(index, true);
			if (this.selectedIndex === index && !options.forceUpdate) return;
			if (this.selectedIndex !== numbers$9.UNSET_INDEX) this.adapter.setAttributeForElementIndex(this.selectedIndex, selectionAttribute, "false");
			this.adapter.setAttributeForElementIndex(index, selectionAttribute, "true");
			this.selectedIndex = index;
			if (options.isUserInteraction && !options.forceUpdate) this.adapter.notifySelectionChange([index]);
		};
		MDCListFoundation.prototype.setCheckboxAtIndex = function(index, options) {
			if (options === void 0) options = {};
			var currentIndex = this.selectedIndex;
			var currentlySelected = options.isUserInteraction ? new Set(currentIndex === numbers$9.UNSET_INDEX ? [] : currentIndex) : null;
			var selectionAttribute = this.getSelectionAttribute();
			var changedIndices = [];
			for (var i = 0; i < this.adapter.getListItemCount(); i++) {
				var previousIsChecked = currentlySelected === null || currentlySelected === void 0 ? void 0 : currentlySelected.has(i);
				var newIsChecked = index.indexOf(i) >= 0;
				if (newIsChecked !== previousIsChecked) changedIndices.push(i);
				this.adapter.setCheckedCheckboxOrRadioAtIndex(i, newIsChecked);
				this.adapter.setAttributeForElementIndex(i, selectionAttribute, newIsChecked ? "true" : "false");
			}
			this.selectedIndex = index;
			if (options.isUserInteraction && changedIndices.length) this.adapter.notifySelectionChange(changedIndices);
		};
		/**
		* Toggles the state of all checkboxes in the given range (inclusive) based on
		* the state of the checkbox at the `toggleIndex`. To determine whether to set
		* the given range to checked or unchecked, read the value of the checkbox at
		* the `toggleIndex` and negate it. Then apply that new checked state to all
		* checkboxes in the range.
		* @param fromIndex The start of the range of checkboxes to toggle
		* @param toIndex The end of the range of checkboxes to toggle
		* @param toggleIndex The index that will be used to determine the new state
		*     of the given checkbox range.
		*/
		MDCListFoundation.prototype.toggleCheckboxRange = function(fromIndex, toIndex, toggleIndex) {
			this.lastSelectedIndex = toggleIndex;
			var currentlySelected = new Set(this.selectedIndex === numbers$9.UNSET_INDEX ? [] : this.selectedIndex);
			var newIsChecked = !(currentlySelected === null || currentlySelected === void 0 ? void 0 : currentlySelected.has(toggleIndex));
			var _a = __read([fromIndex, toIndex].sort(), 2), startIndex = _a[0], endIndex = _a[1];
			var selectionAttribute = this.getSelectionAttribute();
			var changedIndices = [];
			for (var i = startIndex; i <= endIndex; i++) {
				if (this.isIndexDisabled(i)) continue;
				if (newIsChecked !== currentlySelected.has(i)) {
					changedIndices.push(i);
					this.adapter.setCheckedCheckboxOrRadioAtIndex(i, newIsChecked);
					this.adapter.setAttributeForElementIndex(i, selectionAttribute, "" + newIsChecked);
					if (newIsChecked) currentlySelected.add(i);
					else currentlySelected.delete(i);
				}
			}
			if (changedIndices.length) {
				this.selectedIndex = __spreadArray([], __read(currentlySelected));
				this.adapter.notifySelectionChange(changedIndices);
			}
		};
		MDCListFoundation.prototype.setTabindexAtIndex = function(index) {
			if (this.focusedItemIndex === numbers$9.UNSET_INDEX && index !== 0) this.adapter.setAttributeForElementIndex(0, "tabindex", "-1");
			else if (this.focusedItemIndex >= 0 && this.focusedItemIndex !== index) this.adapter.setAttributeForElementIndex(this.focusedItemIndex, "tabindex", "-1");
			if (!(this.selectedIndex instanceof Array) && this.selectedIndex !== index) this.adapter.setAttributeForElementIndex(this.selectedIndex, "tabindex", "-1");
			if (index !== numbers$9.UNSET_INDEX) this.adapter.setAttributeForElementIndex(index, "tabindex", "0");
		};
		/**
		* @return Return true if it is single selectin list, checkbox list or radio
		*     list.
		*/
		MDCListFoundation.prototype.isSelectableList = function() {
			return this.isSingleSelectionList || this.isCheckboxList || this.isRadioList;
		};
		MDCListFoundation.prototype.setTabindexToFirstSelectedOrFocusedItem = function() {
			var targetIndex = this.getFirstSelectedOrFocusedItemIndex();
			this.setTabindexAtIndex(targetIndex);
		};
		MDCListFoundation.prototype.getFirstSelectedOrFocusedItemIndex = function() {
			if (!this.isSelectableList()) return Math.max(this.focusedItemIndex, 0);
			if (typeof this.selectedIndex === "number" && this.selectedIndex !== numbers$9.UNSET_INDEX) return this.selectedIndex;
			if (isNumberArray(this.selectedIndex) && this.selectedIndex.length > 0) return this.selectedIndex.reduce(function(minIndex, currentIndex) {
				return Math.min(minIndex, currentIndex);
			});
			return 0;
		};
		MDCListFoundation.prototype.isIndexValid = function(index, validateListType) {
			var _this = this;
			if (validateListType === void 0) validateListType = true;
			if (index instanceof Array) {
				if (!this.isCheckboxList && validateListType) throw new Error("MDCListFoundation: Array of index is only supported for checkbox based list");
				if (index.length === 0) return true;
				else return index.some(function(i) {
					return _this.isIndexInRange(i);
				});
			} else if (typeof index === "number") {
				if (this.isCheckboxList && validateListType) throw new Error("MDCListFoundation: Expected array of index for checkbox based list but got number: " + index);
				return this.isIndexInRange(index) || this.isSingleSelectionList && index === numbers$9.UNSET_INDEX;
			} else return false;
		};
		MDCListFoundation.prototype.isIndexInRange = function(index) {
			var listSize = this.adapter.getListItemCount();
			return index >= 0 && index < listSize;
		};
		/**
		* Sets selected index on user action, toggles checkboxes in checkbox lists
		* by default, unless `isCheckboxAlreadyUpdatedInAdapter` is set to `true`.
		*
		* In cases where `isCheckboxAlreadyUpdatedInAdapter` is set to `true`, the
		* UI is just updated to reflect the value returned by the adapter.
		*
		* When calling this, make sure user interaction does not toggle disabled
		* list items.
		*/
		MDCListFoundation.prototype.setSelectedIndexOnAction = function(index, isCheckboxAlreadyUpdatedInAdapter) {
			this.lastSelectedIndex = index;
			if (this.isCheckboxList) {
				this.toggleCheckboxAtIndex(index, isCheckboxAlreadyUpdatedInAdapter);
				this.adapter.notifySelectionChange([index]);
			} else this.setSelectedIndex(index, { isUserInteraction: true });
		};
		MDCListFoundation.prototype.toggleCheckboxAtIndex = function(index, isCheckboxAlreadyUpdatedInAdapter) {
			var selectionAttribute = this.getSelectionAttribute();
			var adapterIsChecked = this.adapter.isCheckboxCheckedAtIndex(index);
			var newCheckedValue;
			if (isCheckboxAlreadyUpdatedInAdapter) newCheckedValue = adapterIsChecked;
			else {
				newCheckedValue = !adapterIsChecked;
				this.adapter.setCheckedCheckboxOrRadioAtIndex(index, newCheckedValue);
			}
			this.adapter.setAttributeForElementIndex(index, selectionAttribute, newCheckedValue ? "true" : "false");
			var selectedIndexes = this.selectedIndex === numbers$9.UNSET_INDEX ? [] : this.selectedIndex.slice();
			if (newCheckedValue) selectedIndexes.push(index);
			else selectedIndexes = selectedIndexes.filter(function(i) {
				return i !== index;
			});
			this.selectedIndex = selectedIndexes;
		};
		MDCListFoundation.prototype.focusItemAtIndex = function(index) {
			this.adapter.focusItemAtIndex(index);
			this.focusedItemIndex = index;
		};
		MDCListFoundation.prototype.checkboxListToggleAll = function(currentlySelectedIndexes, isUserInteraction) {
			var count = this.adapter.getListItemCount();
			if (currentlySelectedIndexes.length === count) this.setCheckboxAtIndex([], { isUserInteraction });
			else {
				var allIndexes = [];
				for (var i = 0; i < count; i++) if (!this.isIndexDisabled(i) || currentlySelectedIndexes.indexOf(i) > -1) allIndexes.push(i);
				this.setCheckboxAtIndex(allIndexes, { isUserInteraction });
			}
		};
		/**
		* Given the next desired character from the user, adds it to the typeahead
		* buffer. Then, attempts to find the next option matching the buffer. Wraps
		* around if at the end of options.
		*
		* @param nextChar The next character to add to the prefix buffer.
		* @param startingIndex The index from which to start matching. Only relevant
		*     when starting a new match sequence. To start a new match sequence,
		*     clear the buffer using `clearTypeaheadBuffer`, or wait for the buffer
		*     to clear after a set interval defined in list foundation. Defaults to
		*     the currently focused index.
		* @return The index of the matched item, or -1 if no match.
		*/
		MDCListFoundation.prototype.typeaheadMatchItem = function(nextChar, startingIndex, skipFocus) {
			var _this = this;
			if (skipFocus === void 0) skipFocus = false;
			var opts = {
				focusItemAtIndex: function(index) {
					_this.focusItemAtIndex(index);
				},
				focusedItemIndex: startingIndex ? startingIndex : this.focusedItemIndex,
				nextChar,
				sortedIndexByFirstChar: this.sortedIndexByFirstChar,
				skipFocus,
				isItemAtIndexDisabled: function(index) {
					return _this.isIndexDisabled(index);
				}
			};
			return matchItem(opts, this.typeaheadState);
		};
		/**
		* Initializes the MDCListTextAndIndex data structure by indexing the current
		* list items by primary text.
		*
		* @return The primary texts of all the list items sorted by first character.
		*/
		MDCListFoundation.prototype.typeaheadInitSortedIndex = function() {
			return initSortedIndex(this.adapter.getListItemCount(), this.adapter.getPrimaryTextAtIndex);
		};
		/**
		* Clears the typeahead buffer.
		*/
		MDCListFoundation.prototype.clearTypeaheadBuffer = function() {
			clearBuffer(this.typeaheadState);
		};
		return MDCListFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+list@14.0.0/node_modules/@material/list/component.js
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
	var MDCList = function(_super) {
		__extends(MDCList, _super);
		function MDCList() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		Object.defineProperty(MDCList.prototype, "vertical", {
			set: function(value) {
				this.foundation.setVerticalOrientation(value);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCList.prototype, "listElements", {
			get: function() {
				return Array.from(this.root.querySelectorAll("." + this.classNameMap[cssClasses$21.LIST_ITEM_CLASS]));
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCList.prototype, "wrapFocus", {
			set: function(value) {
				this.foundation.setWrapFocus(value);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCList.prototype, "typeaheadInProgress", {
			/**
			* @return Whether typeahead is currently matching a user-specified prefix.
			*/
			get: function() {
				return this.foundation.isTypeaheadInProgress();
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCList.prototype, "hasTypeahead", {
			/**
			* Sets whether typeahead functionality is enabled on the list.
			* @param hasTypeahead Whether typeahead is enabled.
			*/
			set: function(hasTypeahead) {
				this.foundation.setHasTypeahead(hasTypeahead);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCList.prototype, "singleSelection", {
			set: function(isSingleSelectionList) {
				this.foundation.setSingleSelection(isSingleSelectionList);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCList.prototype, "disabledItemsFocusable", {
			set: function(areDisabledItemsFocusable) {
				this.foundation.setDisabledItemsFocusable(areDisabledItemsFocusable);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCList.prototype, "selectedIndex", {
			get: function() {
				return this.foundation.getSelectedIndex();
			},
			set: function(index) {
				this.foundation.setSelectedIndex(index);
			},
			enumerable: false,
			configurable: true
		});
		MDCList.attachTo = function(root) {
			return new MDCList(root);
		};
		MDCList.prototype.initialSyncWithDOM = function() {
			this.isEvolutionEnabled = evolutionAttribute in this.root.dataset;
			if (this.isEvolutionEnabled) this.classNameMap = evolutionClassNameMap;
			else if (matches(this.root, strings$25.DEPRECATED_SELECTOR)) this.classNameMap = deprecatedClassNameMap;
			else this.classNameMap = Object.values(cssClasses$21).reduce(function(obj, className) {
				obj[className] = className;
				return obj;
			}, {});
			this.handleClick = this.handleClickEvent.bind(this);
			this.handleKeydown = this.handleKeydownEvent.bind(this);
			this.focusInEventListener = this.handleFocusInEvent.bind(this);
			this.focusOutEventListener = this.handleFocusOutEvent.bind(this);
			this.listen("keydown", this.handleKeydown);
			this.listen("click", this.handleClick);
			this.listen("focusin", this.focusInEventListener);
			this.listen("focusout", this.focusOutEventListener);
			this.layout();
			this.initializeListType();
			this.ensureFocusable();
		};
		MDCList.prototype.destroy = function() {
			this.unlisten("keydown", this.handleKeydown);
			this.unlisten("click", this.handleClick);
			this.unlisten("focusin", this.focusInEventListener);
			this.unlisten("focusout", this.focusOutEventListener);
		};
		MDCList.prototype.layout = function() {
			var direction = this.root.getAttribute(strings$25.ARIA_ORIENTATION);
			this.vertical = direction !== strings$25.ARIA_ORIENTATION_HORIZONTAL;
			var itemSelector = "." + this.classNameMap[cssClasses$21.LIST_ITEM_CLASS] + ":not([tabindex])";
			var childSelector = strings$25.FOCUSABLE_CHILD_ELEMENTS;
			var itemEls = this.root.querySelectorAll(itemSelector);
			if (itemEls.length) Array.prototype.forEach.call(itemEls, function(el) {
				el.setAttribute("tabindex", "-1");
			});
			var focusableChildEls = this.root.querySelectorAll(childSelector);
			if (focusableChildEls.length) Array.prototype.forEach.call(focusableChildEls, function(el) {
				el.setAttribute("tabindex", "-1");
			});
			if (this.isEvolutionEnabled) this.foundation.setUseSelectedAttribute(true);
			this.foundation.layout();
		};
		/**
		* Extracts the primary text from a list item.
		* @param item The list item element.
		* @return The primary text in the element.
		*/
		MDCList.prototype.getPrimaryText = function(item) {
			var _a;
			var primaryText = item.querySelector("." + this.classNameMap[cssClasses$21.LIST_ITEM_PRIMARY_TEXT_CLASS]);
			if (this.isEvolutionEnabled || primaryText) return (_a = primaryText === null || primaryText === void 0 ? void 0 : primaryText.textContent) !== null && _a !== void 0 ? _a : "";
			var singleLineText = item.querySelector("." + this.classNameMap[cssClasses$21.LIST_ITEM_TEXT_CLASS]);
			return singleLineText && singleLineText.textContent || "";
		};
		/**
		* Initialize selectedIndex value based on pre-selected list items.
		*/
		MDCList.prototype.initializeListType = function() {
			var _this = this;
			this.isInteractive = matches(this.root, strings$25.ARIA_INTERACTIVE_ROLES_SELECTOR);
			if (this.isEvolutionEnabled && this.isInteractive) {
				var selection = Array.from(this.root.querySelectorAll(strings$25.SELECTED_ITEM_SELECTOR), function(listItem) {
					return _this.listElements.indexOf(listItem);
				});
				if (matches(this.root, strings$25.ARIA_MULTI_SELECTABLE_SELECTOR)) this.selectedIndex = selection;
				else if (selection.length > 0) this.selectedIndex = selection[0];
				return;
			}
			var checkboxListItems = this.root.querySelectorAll(strings$25.ARIA_ROLE_CHECKBOX_SELECTOR);
			var radioSelectedListItem = this.root.querySelector(strings$25.ARIA_CHECKED_RADIO_SELECTOR);
			if (checkboxListItems.length) {
				var preselectedItems = this.root.querySelectorAll(strings$25.ARIA_CHECKED_CHECKBOX_SELECTOR);
				this.selectedIndex = Array.from(preselectedItems, function(listItem) {
					return _this.listElements.indexOf(listItem);
				});
			} else if (radioSelectedListItem) this.selectedIndex = this.listElements.indexOf(radioSelectedListItem);
		};
		/**
		* Updates the list item at itemIndex to the desired isEnabled state.
		* @param itemIndex Index of the list item
		* @param isEnabled Sets the list item to enabled or disabled.
		*/
		MDCList.prototype.setEnabled = function(itemIndex, isEnabled) {
			this.foundation.setEnabled(itemIndex, isEnabled);
		};
		/**
		* Given the next desired character from the user, adds it to the typeahead
		* buffer. Then, attempts to find the next option matching the buffer. Wraps
		* around if at the end of options.
		*
		* @param nextChar The next character to add to the prefix buffer.
		* @param startingIndex The index from which to start matching. Defaults to
		*     the currently focused index.
		* @return The index of the matched item.
		*/
		MDCList.prototype.typeaheadMatchItem = function(nextChar, startingIndex) {
			return this.foundation.typeaheadMatchItem(
				nextChar,
				startingIndex,
				/** skipFocus */
				true
			);
		};
		MDCList.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCListFoundation({
				addClassForElementIndex: function(index, className) {
					var element = _this.listElements[index];
					if (element) element.classList.add(_this.classNameMap[className]);
				},
				focusItemAtIndex: function(index) {
					var element = _this.listElements[index];
					if (element) element.focus();
				},
				getAttributeForElementIndex: function(index, attr) {
					return _this.listElements[index].getAttribute(attr);
				},
				getFocusedElementIndex: function() {
					return _this.listElements.indexOf(document.activeElement);
				},
				getListItemCount: function() {
					return _this.listElements.length;
				},
				getPrimaryTextAtIndex: function(index) {
					return _this.getPrimaryText(_this.listElements[index]);
				},
				hasCheckboxAtIndex: function(index) {
					return !!_this.listElements[index].querySelector(strings$25.CHECKBOX_SELECTOR);
				},
				hasRadioAtIndex: function(index) {
					return !!_this.listElements[index].querySelector(strings$25.RADIO_SELECTOR);
				},
				isCheckboxCheckedAtIndex: function(index) {
					return _this.listElements[index].querySelector(strings$25.CHECKBOX_SELECTOR).checked;
				},
				isFocusInsideList: function() {
					return _this.root !== document.activeElement && _this.root.contains(document.activeElement);
				},
				isRootFocused: function() {
					return document.activeElement === _this.root;
				},
				listItemAtIndexHasClass: function(index, className) {
					return _this.listElements[index].classList.contains(_this.classNameMap[className]);
				},
				notifyAction: function(index) {
					_this.emit(
						strings$25.ACTION_EVENT,
						{ index },
						/** shouldBubble */
						true
					);
				},
				notifySelectionChange: function(changedIndices) {
					_this.emit(
						strings$25.SELECTION_CHANGE_EVENT,
						{ changedIndices },
						/** shouldBubble */
						true
					);
				},
				removeClassForElementIndex: function(index, className) {
					var element = _this.listElements[index];
					if (element) element.classList.remove(_this.classNameMap[className]);
				},
				setAttributeForElementIndex: function(index, attr, value) {
					var element = _this.listElements[index];
					if (element) element.setAttribute(attr, value);
				},
				setCheckedCheckboxOrRadioAtIndex: function(index, isChecked) {
					var toggleEl = _this.listElements[index].querySelector(strings$25.CHECKBOX_RADIO_SELECTOR);
					toggleEl.checked = isChecked;
					var event = document.createEvent("Event");
					event.initEvent("change", true, true);
					toggleEl.dispatchEvent(event);
				},
				setTabIndexForListItemChildren: function(listItemIndex, tabIndexValue) {
					var element = _this.listElements[listItemIndex];
					var selector = strings$25.CHILD_ELEMENTS_TO_TOGGLE_TABINDEX;
					Array.prototype.forEach.call(element.querySelectorAll(selector), function(el) {
						el.setAttribute("tabindex", tabIndexValue);
					});
				}
			});
		};
		/**
		* Ensures that at least one item is focusable if the list is interactive and
		* doesn't specify a suitable tabindex.
		*/
		MDCList.prototype.ensureFocusable = function() {
			if (this.isEvolutionEnabled && this.isInteractive) {
				if (!this.root.querySelector("." + this.classNameMap[cssClasses$21.LIST_ITEM_CLASS] + "[tabindex=\"0\"]")) {
					var index = this.initialFocusIndex();
					if (index !== -1) this.listElements[index].tabIndex = 0;
				}
			}
		};
		MDCList.prototype.initialFocusIndex = function() {
			if (this.selectedIndex instanceof Array && this.selectedIndex.length > 0) return this.selectedIndex[0];
			if (typeof this.selectedIndex === "number" && this.selectedIndex !== numbers$9.UNSET_INDEX) return this.selectedIndex;
			var el = this.root.querySelector("." + this.classNameMap[cssClasses$21.LIST_ITEM_CLASS] + ":not(." + this.classNameMap[cssClasses$21.LIST_ITEM_DISABLED_CLASS] + ")");
			if (el === null) return -1;
			return this.getListItemIndex(el);
		};
		/**
		* Used to figure out which list item this event is targetting. Or returns -1
		* if there is no list item
		*/
		MDCList.prototype.getListItemIndex = function(el) {
			var nearestParent = closest(el, "." + this.classNameMap[cssClasses$21.LIST_ITEM_CLASS] + ", ." + this.classNameMap[cssClasses$21.ROOT]);
			if (nearestParent && matches(nearestParent, "." + this.classNameMap[cssClasses$21.LIST_ITEM_CLASS])) return this.listElements.indexOf(nearestParent);
			return -1;
		};
		/**
		* Used to figure out which element was clicked before sending the event to
		* the foundation.
		*/
		MDCList.prototype.handleFocusInEvent = function(evt) {
			var index = this.getListItemIndex(evt.target);
			this.foundation.handleFocusIn(index);
		};
		/**
		* Used to figure out which element was clicked before sending the event to
		* the foundation.
		*/
		MDCList.prototype.handleFocusOutEvent = function(evt) {
			var index = this.getListItemIndex(evt.target);
			this.foundation.handleFocusOut(index);
		};
		/**
		* Used to figure out which element was focused when keydown event occurred
		* before sending the event to the foundation.
		*/
		MDCList.prototype.handleKeydownEvent = function(evt) {
			var index = this.getListItemIndex(evt.target);
			var target = evt.target;
			this.foundation.handleKeydown(evt, target.classList.contains(this.classNameMap[cssClasses$21.LIST_ITEM_CLASS]), index);
		};
		/**
		* Used to figure out which element was clicked before sending the event to
		* the foundation.
		*/
		MDCList.prototype.handleClickEvent = function(evt) {
			var index = this.getListItemIndex(evt.target);
			var target = evt.target;
			var toggleCheckbox = !matches(target, strings$25.CHECKBOX_RADIO_SELECTOR);
			this.foundation.handleClick(index, toggleCheckbox, evt);
		};
		return MDCList;
	}(MDCComponent);

//#endregion
//#region node_modules/.pnpm/@material+menu-surface@14.0.0/node_modules/@material/menu-surface/foundation.js
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
	var MDCMenuSurfaceFoundation = function(_super) {
		__extends(MDCMenuSurfaceFoundation, _super);
		function MDCMenuSurfaceFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCMenuSurfaceFoundation.defaultAdapter), adapter)) || this;
			_this.isSurfaceOpen = false;
			_this.isQuickOpen = false;
			_this.isHoistedElement = false;
			_this.isFixedPosition = false;
			_this.isHorizontallyCenteredOnViewport = false;
			_this.maxHeight = 0;
			_this.openBottomBias = 0;
			_this.openAnimationEndTimerId = 0;
			_this.closeAnimationEndTimerId = 0;
			_this.animationRequestId = 0;
			_this.anchorCorner = Corner.TOP_START;
			/**
			* Corner of the menu surface to which menu surface is attached to anchor.
			*
			*  Anchor corner --->+----------+
			*                    |  ANCHOR  |
			*                    +----------+
			*  Origin corner --->+--------------+
			*                    |              |
			*                    |              |
			*                    | MENU SURFACE |
			*                    |              |
			*                    |              |
			*                    +--------------+
			*/
			_this.originCorner = Corner.TOP_START;
			_this.anchorMargin = {
				top: 0,
				right: 0,
				bottom: 0,
				left: 0
			};
			_this.position = {
				x: 0,
				y: 0
			};
			return _this;
		}
		Object.defineProperty(MDCMenuSurfaceFoundation, "cssClasses", {
			get: function() {
				return cssClasses$22;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCMenuSurfaceFoundation, "strings", {
			get: function() {
				return strings$26;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCMenuSurfaceFoundation, "numbers", {
			get: function() {
				return numbers$10;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCMenuSurfaceFoundation, "Corner", {
			get: function() {
				return Corner;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCMenuSurfaceFoundation, "defaultAdapter", {
			/**
			* @see {@link MDCMenuSurfaceAdapter} for typing information on parameters and return types.
			*/
			get: function() {
				return {
					addClass: function() {},
					removeClass: function() {},
					hasClass: function() {
						return false;
					},
					hasAnchor: function() {
						return false;
					},
					isElementInContainer: function() {
						return false;
					},
					isFocused: function() {
						return false;
					},
					isRtl: function() {
						return false;
					},
					getInnerDimensions: function() {
						return {
							height: 0,
							width: 0
						};
					},
					getAnchorDimensions: function() {
						return null;
					},
					getWindowDimensions: function() {
						return {
							height: 0,
							width: 0
						};
					},
					getBodyDimensions: function() {
						return {
							height: 0,
							width: 0
						};
					},
					getWindowScroll: function() {
						return {
							x: 0,
							y: 0
						};
					},
					setPosition: function() {},
					setMaxHeight: function() {},
					setTransformOrigin: function() {},
					saveFocus: function() {},
					restoreFocus: function() {},
					notifyClose: function() {},
					notifyClosing: function() {},
					notifyOpen: function() {},
					notifyOpening: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCMenuSurfaceFoundation.prototype.init = function() {
			var _a = MDCMenuSurfaceFoundation.cssClasses, ROOT = _a.ROOT, OPEN = _a.OPEN;
			if (!this.adapter.hasClass(ROOT)) throw new Error(ROOT + " class required in root element.");
			if (this.adapter.hasClass(OPEN)) this.isSurfaceOpen = true;
		};
		MDCMenuSurfaceFoundation.prototype.destroy = function() {
			clearTimeout(this.openAnimationEndTimerId);
			clearTimeout(this.closeAnimationEndTimerId);
			cancelAnimationFrame(this.animationRequestId);
		};
		/**
		* @param corner Default anchor corner alignment of top-left menu surface
		*     corner.
		*/
		MDCMenuSurfaceFoundation.prototype.setAnchorCorner = function(corner) {
			this.anchorCorner = corner;
		};
		/**
		* Flip menu corner horizontally.
		*/
		MDCMenuSurfaceFoundation.prototype.flipCornerHorizontally = function() {
			this.originCorner = this.originCorner ^ CornerBit.RIGHT;
		};
		/**
		* @param margin Set of margin values from anchor.
		*/
		MDCMenuSurfaceFoundation.prototype.setAnchorMargin = function(margin) {
			this.anchorMargin.top = margin.top || 0;
			this.anchorMargin.right = margin.right || 0;
			this.anchorMargin.bottom = margin.bottom || 0;
			this.anchorMargin.left = margin.left || 0;
		};
		/** Used to indicate if the menu-surface is hoisted to the body. */
		MDCMenuSurfaceFoundation.prototype.setIsHoisted = function(isHoisted) {
			this.isHoistedElement = isHoisted;
		};
		/**
		* Used to set the menu-surface calculations based on a fixed position menu.
		*/
		MDCMenuSurfaceFoundation.prototype.setFixedPosition = function(isFixedPosition) {
			this.isFixedPosition = isFixedPosition;
		};
		/**
		* @return Returns true if menu is in fixed (`position: fixed`) position.
		*/
		MDCMenuSurfaceFoundation.prototype.isFixed = function() {
			return this.isFixedPosition;
		};
		/** Sets the menu-surface position on the page. */
		MDCMenuSurfaceFoundation.prototype.setAbsolutePosition = function(x, y) {
			this.position.x = this.isFinite(x) ? x : 0;
			this.position.y = this.isFinite(y) ? y : 0;
		};
		/** Sets whether menu-surface should be horizontally centered to viewport. */
		MDCMenuSurfaceFoundation.prototype.setIsHorizontallyCenteredOnViewport = function(isCentered) {
			this.isHorizontallyCenteredOnViewport = isCentered;
		};
		MDCMenuSurfaceFoundation.prototype.setQuickOpen = function(quickOpen) {
			this.isQuickOpen = quickOpen;
		};
		/**
		* Sets maximum menu-surface height on open.
		* @param maxHeight The desired max-height. Set to 0 (default) to
		*     automatically calculate max height based on available viewport space.
		*/
		MDCMenuSurfaceFoundation.prototype.setMaxHeight = function(maxHeight) {
			this.maxHeight = maxHeight;
		};
		/**
		* Set to a positive integer to influence the menu to preferentially open
		* below the anchor instead of above.
		* @param bias A value of `x` simulates an extra `x` pixels of available space
		*     below the menu during positioning calculations.
		*/
		MDCMenuSurfaceFoundation.prototype.setOpenBottomBias = function(bias) {
			this.openBottomBias = bias;
		};
		MDCMenuSurfaceFoundation.prototype.isOpen = function() {
			return this.isSurfaceOpen;
		};
		/**
		* Open the menu surface.
		*/
		MDCMenuSurfaceFoundation.prototype.open = function() {
			var _this = this;
			if (this.isSurfaceOpen) return;
			this.adapter.notifyOpening();
			this.adapter.saveFocus();
			if (this.isQuickOpen) {
				this.isSurfaceOpen = true;
				this.adapter.addClass(MDCMenuSurfaceFoundation.cssClasses.OPEN);
				this.dimensions = this.adapter.getInnerDimensions();
				this.autoposition();
				this.adapter.notifyOpen();
			} else {
				this.adapter.addClass(MDCMenuSurfaceFoundation.cssClasses.ANIMATING_OPEN);
				this.animationRequestId = requestAnimationFrame(function() {
					_this.dimensions = _this.adapter.getInnerDimensions();
					_this.autoposition();
					_this.adapter.addClass(MDCMenuSurfaceFoundation.cssClasses.OPEN);
					_this.openAnimationEndTimerId = setTimeout(function() {
						_this.openAnimationEndTimerId = 0;
						_this.adapter.removeClass(MDCMenuSurfaceFoundation.cssClasses.ANIMATING_OPEN);
						_this.adapter.notifyOpen();
					}, numbers$10.TRANSITION_OPEN_DURATION);
				});
				this.isSurfaceOpen = true;
			}
		};
		/**
		* Closes the menu surface.
		*/
		MDCMenuSurfaceFoundation.prototype.close = function(skipRestoreFocus) {
			var _this = this;
			if (skipRestoreFocus === void 0) skipRestoreFocus = false;
			if (!this.isSurfaceOpen) return;
			this.adapter.notifyClosing();
			if (this.isQuickOpen) {
				this.isSurfaceOpen = false;
				if (!skipRestoreFocus) this.maybeRestoreFocus();
				this.adapter.removeClass(MDCMenuSurfaceFoundation.cssClasses.OPEN);
				this.adapter.removeClass(MDCMenuSurfaceFoundation.cssClasses.IS_OPEN_BELOW);
				this.adapter.notifyClose();
				return;
			}
			this.adapter.addClass(MDCMenuSurfaceFoundation.cssClasses.ANIMATING_CLOSED);
			requestAnimationFrame(function() {
				_this.adapter.removeClass(MDCMenuSurfaceFoundation.cssClasses.OPEN);
				_this.adapter.removeClass(MDCMenuSurfaceFoundation.cssClasses.IS_OPEN_BELOW);
				_this.closeAnimationEndTimerId = setTimeout(function() {
					_this.closeAnimationEndTimerId = 0;
					_this.adapter.removeClass(MDCMenuSurfaceFoundation.cssClasses.ANIMATING_CLOSED);
					_this.adapter.notifyClose();
				}, numbers$10.TRANSITION_CLOSE_DURATION);
			});
			this.isSurfaceOpen = false;
			if (!skipRestoreFocus) this.maybeRestoreFocus();
		};
		/** Handle clicks and close if not within menu-surface element. */
		MDCMenuSurfaceFoundation.prototype.handleBodyClick = function(evt) {
			var el = evt.target;
			if (this.adapter.isElementInContainer(el)) return;
			this.close();
		};
		/** Handle keys that close the surface. */
		MDCMenuSurfaceFoundation.prototype.handleKeydown = function(evt) {
			var keyCode = evt.keyCode;
			if (evt.key === "Escape" || keyCode === 27) this.close();
		};
		MDCMenuSurfaceFoundation.prototype.autoposition = function() {
			var _a;
			this.measurements = this.getAutoLayoutmeasurements();
			var corner = this.getoriginCorner();
			var maxMenuSurfaceHeight = this.getMenuSurfaceMaxHeight(corner);
			var verticalAlignment = this.hasBit(corner, CornerBit.BOTTOM) ? "bottom" : "top";
			var horizontalAlignment = this.hasBit(corner, CornerBit.RIGHT) ? "right" : "left";
			var horizontalOffset = this.getHorizontalOriginOffset(corner);
			var verticalOffset = this.getVerticalOriginOffset(corner);
			var _b = this.measurements, anchorSize = _b.anchorSize, surfaceSize = _b.surfaceSize;
			var position = (_a = {}, _a[horizontalAlignment] = horizontalOffset, _a[verticalAlignment] = verticalOffset, _a);
			if (anchorSize.width / surfaceSize.width > numbers$10.ANCHOR_TO_MENU_SURFACE_WIDTH_RATIO) horizontalAlignment = "center";
			if (this.isHoistedElement || this.isFixedPosition) this.adjustPositionForHoistedElement(position);
			this.adapter.setTransformOrigin(horizontalAlignment + " " + verticalAlignment);
			this.adapter.setPosition(position);
			this.adapter.setMaxHeight(maxMenuSurfaceHeight ? maxMenuSurfaceHeight + "px" : "");
			if (!this.hasBit(corner, CornerBit.BOTTOM)) this.adapter.addClass(MDCMenuSurfaceFoundation.cssClasses.IS_OPEN_BELOW);
		};
		/**
		* @return Measurements used to position menu surface popup.
		*/
		MDCMenuSurfaceFoundation.prototype.getAutoLayoutmeasurements = function() {
			var anchorRect = this.adapter.getAnchorDimensions();
			var bodySize = this.adapter.getBodyDimensions();
			var viewportSize = this.adapter.getWindowDimensions();
			var windowScroll = this.adapter.getWindowScroll();
			if (!anchorRect) anchorRect = {
				top: this.position.y,
				right: this.position.x,
				bottom: this.position.y,
				left: this.position.x,
				width: 0,
				height: 0
			};
			return {
				anchorSize: anchorRect,
				bodySize,
				surfaceSize: this.dimensions,
				viewportDistance: {
					top: anchorRect.top,
					right: viewportSize.width - anchorRect.right,
					bottom: viewportSize.height - anchorRect.bottom,
					left: anchorRect.left
				},
				viewportSize,
				windowScroll
			};
		};
		/**
		* Computes the corner of the anchor from which to animate and position the
		* menu surface.
		*
		* Only LEFT or RIGHT bit is used to position the menu surface ignoring RTL
		* context. E.g., menu surface will be positioned from right side on TOP_END.
		*/
		MDCMenuSurfaceFoundation.prototype.getoriginCorner = function() {
			var corner = this.originCorner;
			var _a = this.measurements, viewportDistance = _a.viewportDistance, anchorSize = _a.anchorSize, surfaceSize = _a.surfaceSize;
			var MARGIN_TO_EDGE = MDCMenuSurfaceFoundation.numbers.MARGIN_TO_EDGE;
			var isAnchoredToBottom = this.hasBit(this.anchorCorner, CornerBit.BOTTOM);
			var availableTop;
			var availableBottom;
			if (isAnchoredToBottom) {
				availableTop = viewportDistance.top - MARGIN_TO_EDGE + this.anchorMargin.bottom;
				availableBottom = viewportDistance.bottom - MARGIN_TO_EDGE - this.anchorMargin.bottom;
			} else {
				availableTop = viewportDistance.top - MARGIN_TO_EDGE + this.anchorMargin.top;
				availableBottom = viewportDistance.bottom - MARGIN_TO_EDGE + anchorSize.height - this.anchorMargin.top;
			}
			if (!(availableBottom - surfaceSize.height > 0) && availableTop > availableBottom + this.openBottomBias) corner = this.setBit(corner, CornerBit.BOTTOM);
			var isRtl = this.adapter.isRtl();
			var isFlipRtl = this.hasBit(this.anchorCorner, CornerBit.FLIP_RTL);
			var hasRightBit = this.hasBit(this.anchorCorner, CornerBit.RIGHT) || this.hasBit(corner, CornerBit.RIGHT);
			var isAnchoredToRight = false;
			if (isRtl && isFlipRtl) isAnchoredToRight = !hasRightBit;
			else isAnchoredToRight = hasRightBit;
			var availableLeft;
			var availableRight;
			if (isAnchoredToRight) {
				availableLeft = viewportDistance.left + anchorSize.width + this.anchorMargin.right;
				availableRight = viewportDistance.right - this.anchorMargin.right;
			} else {
				availableLeft = viewportDistance.left + this.anchorMargin.left;
				availableRight = viewportDistance.right + anchorSize.width - this.anchorMargin.left;
			}
			var isAvailableLeft = availableLeft - surfaceSize.width > 0;
			var isAvailableRight = availableRight - surfaceSize.width > 0;
			var isOriginCornerAlignedToEnd = this.hasBit(corner, CornerBit.FLIP_RTL) && this.hasBit(corner, CornerBit.RIGHT);
			if (isAvailableRight && isOriginCornerAlignedToEnd && isRtl || !isAvailableLeft && isOriginCornerAlignedToEnd) corner = this.unsetBit(corner, CornerBit.RIGHT);
			else if (isAvailableLeft && isAnchoredToRight && isRtl || isAvailableLeft && !isAnchoredToRight && hasRightBit || !isAvailableRight && availableLeft >= availableRight) corner = this.setBit(corner, CornerBit.RIGHT);
			return corner;
		};
		/**
		* @param corner Origin corner of the menu surface.
		* @return Maximum height of the menu surface, based on available space. 0
		*     indicates should not be set.
		*/
		MDCMenuSurfaceFoundation.prototype.getMenuSurfaceMaxHeight = function(corner) {
			if (this.maxHeight > 0) return this.maxHeight;
			var viewportDistance = this.measurements.viewportDistance;
			var maxHeight = 0;
			var isBottomAligned = this.hasBit(corner, CornerBit.BOTTOM);
			var isBottomAnchored = this.hasBit(this.anchorCorner, CornerBit.BOTTOM);
			var MARGIN_TO_EDGE = MDCMenuSurfaceFoundation.numbers.MARGIN_TO_EDGE;
			if (isBottomAligned) {
				maxHeight = viewportDistance.top + this.anchorMargin.top - MARGIN_TO_EDGE;
				if (!isBottomAnchored) maxHeight += this.measurements.anchorSize.height;
			} else {
				maxHeight = viewportDistance.bottom - this.anchorMargin.bottom + this.measurements.anchorSize.height - MARGIN_TO_EDGE;
				if (isBottomAnchored) maxHeight -= this.measurements.anchorSize.height;
			}
			return maxHeight;
		};
		/**
		* @param corner Origin corner of the menu surface.
		* @return Horizontal offset of menu surface origin corner from corresponding
		*     anchor corner.
		*/
		MDCMenuSurfaceFoundation.prototype.getHorizontalOriginOffset = function(corner) {
			var anchorSize = this.measurements.anchorSize;
			var isRightAligned = this.hasBit(corner, CornerBit.RIGHT);
			var avoidHorizontalOverlap = this.hasBit(this.anchorCorner, CornerBit.RIGHT);
			if (isRightAligned) {
				var rightOffset = avoidHorizontalOverlap ? anchorSize.width - this.anchorMargin.left : this.anchorMargin.right;
				if (this.isHoistedElement || this.isFixedPosition) return rightOffset - (this.measurements.viewportSize.width - this.measurements.bodySize.width);
				return rightOffset;
			}
			return avoidHorizontalOverlap ? anchorSize.width - this.anchorMargin.right : this.anchorMargin.left;
		};
		/**
		* @param corner Origin corner of the menu surface.
		* @return Vertical offset of menu surface origin corner from corresponding
		*     anchor corner.
		*/
		MDCMenuSurfaceFoundation.prototype.getVerticalOriginOffset = function(corner) {
			var anchorSize = this.measurements.anchorSize;
			var isBottomAligned = this.hasBit(corner, CornerBit.BOTTOM);
			var avoidVerticalOverlap = this.hasBit(this.anchorCorner, CornerBit.BOTTOM);
			var y = 0;
			if (isBottomAligned) y = avoidVerticalOverlap ? anchorSize.height - this.anchorMargin.top : -this.anchorMargin.bottom;
			else y = avoidVerticalOverlap ? anchorSize.height + this.anchorMargin.bottom : this.anchorMargin.top;
			return y;
		};
		/**
		* Calculates the offsets for positioning the menu-surface when the
		* menu-surface has been hoisted to the body.
		*/
		MDCMenuSurfaceFoundation.prototype.adjustPositionForHoistedElement = function(position) {
			var e_1, _a;
			var _b = this.measurements, windowScroll = _b.windowScroll, viewportDistance = _b.viewportDistance, surfaceSize = _b.surfaceSize, viewportSize = _b.viewportSize;
			var props = Object.keys(position);
			try {
				for (var props_1 = __values(props), props_1_1 = props_1.next(); !props_1_1.done; props_1_1 = props_1.next()) {
					var prop = props_1_1.value;
					var value = position[prop] || 0;
					if (this.isHorizontallyCenteredOnViewport && (prop === "left" || prop === "right")) {
						position[prop] = (viewportSize.width - surfaceSize.width) / 2;
						continue;
					}
					value += viewportDistance[prop];
					if (!this.isFixedPosition) if (prop === "top") value += windowScroll.y;
					else if (prop === "bottom") value -= windowScroll.y;
					else if (prop === "left") value += windowScroll.x;
					else value -= windowScroll.x;
					position[prop] = value;
				}
			} catch (e_1_1) {
				e_1 = { error: e_1_1 };
			} finally {
				try {
					if (props_1_1 && !props_1_1.done && (_a = props_1.return)) _a.call(props_1);
				} finally {
					if (e_1) throw e_1.error;
				}
			}
		};
		/**
		* The last focused element when the menu surface was opened should regain
		* focus, if the user is focused on or within the menu surface when it is
		* closed.
		*/
		MDCMenuSurfaceFoundation.prototype.maybeRestoreFocus = function() {
			var _this = this;
			var isRootFocused = this.adapter.isFocused();
			var ownerDocument = this.adapter.getOwnerDocument ? this.adapter.getOwnerDocument() : document;
			var childHasFocus = ownerDocument.activeElement && this.adapter.isElementInContainer(ownerDocument.activeElement);
			if (isRootFocused || childHasFocus) setTimeout(function() {
				_this.adapter.restoreFocus();
			}, numbers$10.TOUCH_EVENT_WAIT_MS);
		};
		MDCMenuSurfaceFoundation.prototype.hasBit = function(corner, bit) {
			return Boolean(corner & bit);
		};
		MDCMenuSurfaceFoundation.prototype.setBit = function(corner, bit) {
			return corner | bit;
		};
		MDCMenuSurfaceFoundation.prototype.unsetBit = function(corner, bit) {
			return corner ^ bit;
		};
		/**
		* isFinite that doesn't force conversion to number type.
		* Equivalent to Number.isFinite in ES2015, which is not supported in IE.
		*/
		MDCMenuSurfaceFoundation.prototype.isFinite = function(num) {
			return typeof num === "number" && isFinite(num);
		};
		return MDCMenuSurfaceFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+animation@14.0.0/node_modules/@material/animation/util.js
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
	var cssPropertyNameMap = {
		animation: {
			prefixed: "-webkit-animation",
			standard: "animation"
		},
		transform: {
			prefixed: "-webkit-transform",
			standard: "transform"
		},
		transition: {
			prefixed: "-webkit-transition",
			standard: "transition"
		}
	};
	var jsEventTypeMap = {
		animationend: {
			cssProperty: "animation",
			prefixed: "webkitAnimationEnd",
			standard: "animationend"
		},
		animationiteration: {
			cssProperty: "animation",
			prefixed: "webkitAnimationIteration",
			standard: "animationiteration"
		},
		animationstart: {
			cssProperty: "animation",
			prefixed: "webkitAnimationStart",
			standard: "animationstart"
		},
		transitionend: {
			cssProperty: "transition",
			prefixed: "webkitTransitionEnd",
			standard: "transitionend"
		}
	};
	function isWindow(windowObj) {
		return Boolean(windowObj.document) && typeof windowObj.document.createElement === "function";
	}
	function getCorrectPropertyName(windowObj, cssProperty) {
		if (isWindow(windowObj) && cssProperty in cssPropertyNameMap) {
			var el = windowObj.document.createElement("div");
			var _a = cssPropertyNameMap[cssProperty], standard = _a.standard, prefixed = _a.prefixed;
			return standard in el.style ? standard : prefixed;
		}
		return cssProperty;
	}
	function getCorrectEventName(windowObj, eventType) {
		if (isWindow(windowObj) && eventType in jsEventTypeMap) {
			var el = windowObj.document.createElement("div");
			var _a = jsEventTypeMap[eventType], standard = _a.standard, prefixed = _a.prefixed;
			return _a.cssProperty in el.style ? standard : prefixed;
		}
		return eventType;
	}

//#endregion
//#region node_modules/.pnpm/@material+menu-surface@14.0.0/node_modules/@material/menu-surface/component.js
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
	var MDCMenuSurface = function(_super) {
		__extends(MDCMenuSurface, _super);
		function MDCMenuSurface() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCMenuSurface.attachTo = function(root) {
			return new MDCMenuSurface(root);
		};
		MDCMenuSurface.prototype.initialSyncWithDOM = function() {
			var _this = this;
			var parentEl = this.root.parentElement;
			this.anchorElement = parentEl && parentEl.classList.contains(cssClasses$22.ANCHOR) ? parentEl : null;
			if (this.root.classList.contains(cssClasses$22.FIXED)) this.setFixedPosition(true);
			this.handleKeydown = function(event) {
				_this.foundation.handleKeydown(event);
			};
			this.handleBodyClick = function(event) {
				_this.foundation.handleBodyClick(event);
			};
			this.registerBodyClickListener = function() {
				document.body.addEventListener("click", _this.handleBodyClick, { capture: true });
			};
			this.deregisterBodyClickListener = function() {
				document.body.removeEventListener("click", _this.handleBodyClick, { capture: true });
			};
			this.listen("keydown", this.handleKeydown);
			this.listen(strings$26.OPENED_EVENT, this.registerBodyClickListener);
			this.listen(strings$26.CLOSED_EVENT, this.deregisterBodyClickListener);
		};
		MDCMenuSurface.prototype.destroy = function() {
			this.unlisten("keydown", this.handleKeydown);
			this.unlisten(strings$26.OPENED_EVENT, this.registerBodyClickListener);
			this.unlisten(strings$26.CLOSED_EVENT, this.deregisterBodyClickListener);
			_super.prototype.destroy.call(this);
		};
		MDCMenuSurface.prototype.isOpen = function() {
			return this.foundation.isOpen();
		};
		MDCMenuSurface.prototype.open = function() {
			this.foundation.open();
		};
		MDCMenuSurface.prototype.close = function(skipRestoreFocus) {
			if (skipRestoreFocus === void 0) skipRestoreFocus = false;
			this.foundation.close(skipRestoreFocus);
		};
		Object.defineProperty(MDCMenuSurface.prototype, "quickOpen", {
			set: function(quickOpen) {
				this.foundation.setQuickOpen(quickOpen);
			},
			enumerable: false,
			configurable: true
		});
		/** Sets the foundation to use page offsets for an positioning when the menu is hoisted to the body. */
		MDCMenuSurface.prototype.setIsHoisted = function(isHoisted) {
			this.foundation.setIsHoisted(isHoisted);
		};
		/** Sets the element that the menu-surface is anchored to. */
		MDCMenuSurface.prototype.setMenuSurfaceAnchorElement = function(element) {
			this.anchorElement = element;
		};
		/** Sets the menu-surface to position: fixed. */
		MDCMenuSurface.prototype.setFixedPosition = function(isFixed) {
			if (isFixed) this.root.classList.add(cssClasses$22.FIXED);
			else this.root.classList.remove(cssClasses$22.FIXED);
			this.foundation.setFixedPosition(isFixed);
		};
		/** Sets the absolute x/y position to position based on. Requires the menu to be hoisted. */
		MDCMenuSurface.prototype.setAbsolutePosition = function(x, y) {
			this.foundation.setAbsolutePosition(x, y);
			this.setIsHoisted(true);
		};
		/**
		* @param corner Default anchor corner alignment of top-left surface corner.
		*/
		MDCMenuSurface.prototype.setAnchorCorner = function(corner) {
			this.foundation.setAnchorCorner(corner);
		};
		MDCMenuSurface.prototype.setAnchorMargin = function(margin) {
			this.foundation.setAnchorMargin(margin);
		};
		MDCMenuSurface.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCMenuSurfaceFoundation({
				addClass: function(className) {
					return _this.root.classList.add(className);
				},
				removeClass: function(className) {
					return _this.root.classList.remove(className);
				},
				hasClass: function(className) {
					return _this.root.classList.contains(className);
				},
				hasAnchor: function() {
					return !!_this.anchorElement;
				},
				notifyClose: function() {
					return _this.emit(MDCMenuSurfaceFoundation.strings.CLOSED_EVENT, {});
				},
				notifyClosing: function() {
					_this.emit(MDCMenuSurfaceFoundation.strings.CLOSING_EVENT, {});
				},
				notifyOpen: function() {
					return _this.emit(MDCMenuSurfaceFoundation.strings.OPENED_EVENT, {});
				},
				notifyOpening: function() {
					return _this.emit(MDCMenuSurfaceFoundation.strings.OPENING_EVENT, {});
				},
				isElementInContainer: function(el) {
					return _this.root.contains(el);
				},
				isRtl: function() {
					return getComputedStyle(_this.root).getPropertyValue("direction") === "rtl";
				},
				setTransformOrigin: function(origin) {
					var propertyName = getCorrectPropertyName(window, "transform") + "-origin";
					_this.root.style.setProperty(propertyName, origin);
				},
				isFocused: function() {
					return document.activeElement === _this.root;
				},
				saveFocus: function() {
					_this.previousFocus = document.activeElement;
				},
				restoreFocus: function() {
					if (_this.root.contains(document.activeElement)) {
						if (_this.previousFocus && _this.previousFocus.focus) _this.previousFocus.focus();
					}
				},
				getInnerDimensions: function() {
					return {
						width: _this.root.offsetWidth,
						height: _this.root.offsetHeight
					};
				},
				getAnchorDimensions: function() {
					return _this.anchorElement ? _this.anchorElement.getBoundingClientRect() : null;
				},
				getWindowDimensions: function() {
					return {
						width: window.innerWidth,
						height: window.innerHeight
					};
				},
				getBodyDimensions: function() {
					return {
						width: document.body.clientWidth,
						height: document.body.clientHeight
					};
				},
				getWindowScroll: function() {
					return {
						x: window.pageXOffset,
						y: window.pageYOffset
					};
				},
				setPosition: function(position) {
					var rootHTML = _this.root;
					rootHTML.style.left = "left" in position ? position.left + "px" : "";
					rootHTML.style.right = "right" in position ? position.right + "px" : "";
					rootHTML.style.top = "top" in position ? position.top + "px" : "";
					rootHTML.style.bottom = "bottom" in position ? position.bottom + "px" : "";
				},
				setMaxHeight: function(height) {
					_this.root.style.maxHeight = height;
				}
			});
		};
		return MDCMenuSurface;
	}(MDCComponent);

//#endregion
//#region node_modules/.pnpm/@material+menu@14.0.0/node_modules/@material/menu/constants.js
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
	var cssClasses$20 = {
		MENU_SELECTED_LIST_ITEM: "mdc-menu-item--selected",
		MENU_SELECTION_GROUP: "mdc-menu__selection-group",
		ROOT: "mdc-menu"
	};
	var strings$24 = {
		ARIA_CHECKED_ATTR: "aria-checked",
		ARIA_DISABLED_ATTR: "aria-disabled",
		CHECKBOX_SELECTOR: "input[type=\"checkbox\"]",
		LIST_SELECTOR: ".mdc-list,.mdc-deprecated-list",
		SELECTED_EVENT: "MDCMenu:selected",
		SKIP_RESTORE_FOCUS: "data-menu-item-skip-restore-focus"
	};
	var numbers$8 = { FOCUS_ROOT_INDEX: -1 };
	var DefaultFocusState;
	(function(DefaultFocusState) {
		DefaultFocusState[DefaultFocusState["NONE"] = 0] = "NONE";
		DefaultFocusState[DefaultFocusState["LIST_ROOT"] = 1] = "LIST_ROOT";
		DefaultFocusState[DefaultFocusState["FIRST_ITEM"] = 2] = "FIRST_ITEM";
		DefaultFocusState[DefaultFocusState["LAST_ITEM"] = 3] = "LAST_ITEM";
	})(DefaultFocusState || (DefaultFocusState = {}));

//#endregion
//#region node_modules/.pnpm/@material+menu@14.0.0/node_modules/@material/menu/foundation.js
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
	var MDCMenuFoundation = function(_super) {
		__extends(MDCMenuFoundation, _super);
		function MDCMenuFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCMenuFoundation.defaultAdapter), adapter)) || this;
			_this.closeAnimationEndTimerId = 0;
			_this.defaultFocusState = DefaultFocusState.LIST_ROOT;
			_this.selectedIndex = -1;
			return _this;
		}
		Object.defineProperty(MDCMenuFoundation, "cssClasses", {
			get: function() {
				return cssClasses$20;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCMenuFoundation, "strings", {
			get: function() {
				return strings$24;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCMenuFoundation, "numbers", {
			get: function() {
				return numbers$8;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCMenuFoundation, "defaultAdapter", {
			/**
			* @see {@link MDCMenuAdapter} for typing information on parameters and return types.
			*/
			get: function() {
				return {
					addClassToElementAtIndex: function() {},
					removeClassFromElementAtIndex: function() {},
					addAttributeToElementAtIndex: function() {},
					removeAttributeFromElementAtIndex: function() {},
					getAttributeFromElementAtIndex: function() {
						return null;
					},
					elementContainsClass: function() {
						return false;
					},
					closeSurface: function() {},
					getElementIndex: function() {
						return -1;
					},
					notifySelected: function() {},
					getMenuItemCount: function() {
						return 0;
					},
					focusItemAtIndex: function() {},
					focusListRoot: function() {},
					getSelectedSiblingOfItemAtIndex: function() {
						return -1;
					},
					isSelectableItemAtIndex: function() {
						return false;
					}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCMenuFoundation.prototype.destroy = function() {
			if (this.closeAnimationEndTimerId) clearTimeout(this.closeAnimationEndTimerId);
			this.adapter.closeSurface();
		};
		MDCMenuFoundation.prototype.handleKeydown = function(evt) {
			var key = evt.key, keyCode = evt.keyCode;
			if (key === "Tab" || keyCode === 9) this.adapter.closeSurface(
				/** skipRestoreFocus */
				true
			);
		};
		MDCMenuFoundation.prototype.handleItemAction = function(listItem) {
			var _this = this;
			var index = this.adapter.getElementIndex(listItem);
			if (index < 0) return;
			this.adapter.notifySelected({ index });
			var skipRestoreFocus = this.adapter.getAttributeFromElementAtIndex(index, strings$24.SKIP_RESTORE_FOCUS) === "true";
			this.adapter.closeSurface(skipRestoreFocus);
			this.closeAnimationEndTimerId = setTimeout(function() {
				var recomputedIndex = _this.adapter.getElementIndex(listItem);
				if (recomputedIndex >= 0 && _this.adapter.isSelectableItemAtIndex(recomputedIndex)) _this.setSelectedIndex(recomputedIndex);
			}, MDCMenuSurfaceFoundation.numbers.TRANSITION_CLOSE_DURATION);
		};
		MDCMenuFoundation.prototype.handleMenuSurfaceOpened = function() {
			switch (this.defaultFocusState) {
				case DefaultFocusState.FIRST_ITEM:
					this.adapter.focusItemAtIndex(0);
					break;
				case DefaultFocusState.LAST_ITEM:
					this.adapter.focusItemAtIndex(this.adapter.getMenuItemCount() - 1);
					break;
				case DefaultFocusState.NONE: break;
				default:
					this.adapter.focusListRoot();
					break;
			}
		};
		/**
		* Sets default focus state where the menu should focus every time when menu
		* is opened. Focuses the list root (`DefaultFocusState.LIST_ROOT`) element by
		* default.
		*/
		MDCMenuFoundation.prototype.setDefaultFocusState = function(focusState) {
			this.defaultFocusState = focusState;
		};
		/** @return Index of the currently selected list item within the menu. */
		MDCMenuFoundation.prototype.getSelectedIndex = function() {
			return this.selectedIndex;
		};
		/**
		* Selects the list item at `index` within the menu.
		* @param index Index of list item within the menu.
		*/
		MDCMenuFoundation.prototype.setSelectedIndex = function(index) {
			this.validatedIndex(index);
			if (!this.adapter.isSelectableItemAtIndex(index)) throw new Error("MDCMenuFoundation: No selection group at specified index.");
			var prevSelectedIndex = this.adapter.getSelectedSiblingOfItemAtIndex(index);
			if (prevSelectedIndex >= 0) {
				this.adapter.removeAttributeFromElementAtIndex(prevSelectedIndex, strings$24.ARIA_CHECKED_ATTR);
				this.adapter.removeClassFromElementAtIndex(prevSelectedIndex, cssClasses$20.MENU_SELECTED_LIST_ITEM);
			}
			this.adapter.addClassToElementAtIndex(index, cssClasses$20.MENU_SELECTED_LIST_ITEM);
			this.adapter.addAttributeToElementAtIndex(index, strings$24.ARIA_CHECKED_ATTR, "true");
			this.selectedIndex = index;
		};
		/**
		* Sets the enabled state to isEnabled for the menu item at the given index.
		* @param index Index of the menu item
		* @param isEnabled The desired enabled state of the menu item.
		*/
		MDCMenuFoundation.prototype.setEnabled = function(index, isEnabled) {
			this.validatedIndex(index);
			if (isEnabled) {
				this.adapter.removeClassFromElementAtIndex(index, cssClasses$21.LIST_ITEM_DISABLED_CLASS);
				this.adapter.addAttributeToElementAtIndex(index, strings$24.ARIA_DISABLED_ATTR, "false");
			} else {
				this.adapter.addClassToElementAtIndex(index, cssClasses$21.LIST_ITEM_DISABLED_CLASS);
				this.adapter.addAttributeToElementAtIndex(index, strings$24.ARIA_DISABLED_ATTR, "true");
			}
		};
		MDCMenuFoundation.prototype.validatedIndex = function(index) {
			var menuSize = this.adapter.getMenuItemCount();
			if (!(index >= 0 && index < menuSize)) throw new Error("MDCMenuFoundation: No list item at specified index.");
		};
		return MDCMenuFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+menu@14.0.0/node_modules/@material/menu/component.js
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
	var MDCMenu = function(_super) {
		__extends(MDCMenu, _super);
		function MDCMenu() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCMenu.attachTo = function(root) {
			return new MDCMenu(root);
		};
		MDCMenu.prototype.initialize = function(menuSurfaceFactory, listFactory) {
			if (menuSurfaceFactory === void 0) menuSurfaceFactory = function(el) {
				return new MDCMenuSurface(el);
			};
			if (listFactory === void 0) listFactory = function(el) {
				return new MDCList(el);
			};
			this.menuSurfaceFactory = menuSurfaceFactory;
			this.listFactory = listFactory;
		};
		MDCMenu.prototype.initialSyncWithDOM = function() {
			var _this = this;
			this.menuSurface = this.menuSurfaceFactory(this.root);
			var list = this.root.querySelector(strings$24.LIST_SELECTOR);
			if (list) {
				this.list = this.listFactory(list);
				this.list.wrapFocus = true;
			} else this.list = null;
			this.handleKeydown = function(evt) {
				_this.foundation.handleKeydown(evt);
			};
			this.handleItemAction = function(evt) {
				_this.foundation.handleItemAction(_this.items[evt.detail.index]);
			};
			this.handleMenuSurfaceOpened = function() {
				_this.foundation.handleMenuSurfaceOpened();
			};
			this.menuSurface.listen(MDCMenuSurfaceFoundation.strings.OPENED_EVENT, this.handleMenuSurfaceOpened);
			this.listen("keydown", this.handleKeydown);
			this.listen(MDCListFoundation.strings.ACTION_EVENT, this.handleItemAction);
		};
		MDCMenu.prototype.destroy = function() {
			if (this.list) this.list.destroy();
			this.menuSurface.destroy();
			this.menuSurface.unlisten(MDCMenuSurfaceFoundation.strings.OPENED_EVENT, this.handleMenuSurfaceOpened);
			this.unlisten("keydown", this.handleKeydown);
			this.unlisten(MDCListFoundation.strings.ACTION_EVENT, this.handleItemAction);
			_super.prototype.destroy.call(this);
		};
		Object.defineProperty(MDCMenu.prototype, "open", {
			get: function() {
				return this.menuSurface.isOpen();
			},
			set: function(value) {
				if (value) this.menuSurface.open();
				else this.menuSurface.close();
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCMenu.prototype, "wrapFocus", {
			get: function() {
				return this.list ? this.list.wrapFocus : false;
			},
			set: function(value) {
				if (this.list) this.list.wrapFocus = value;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCMenu.prototype, "hasTypeahead", {
			/**
			* Sets whether the menu has typeahead functionality.
			* @param value Whether typeahead is enabled.
			*/
			set: function(value) {
				if (this.list) this.list.hasTypeahead = value;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCMenu.prototype, "typeaheadInProgress", {
			/**
			* @return Whether typeahead logic is currently matching some user prefix.
			*/
			get: function() {
				return this.list ? this.list.typeaheadInProgress : false;
			},
			enumerable: false,
			configurable: true
		});
		/**
		* Given the next desired character from the user, adds it to the typeahead
		* buffer. Then, attempts to find the next option matching the buffer. Wraps
		* around if at the end of options.
		*
		* @param nextChar The next character to add to the prefix buffer.
		* @param startingIndex The index from which to start matching. Only relevant
		*     when starting a new match sequence. To start a new match sequence,
		*     clear the buffer using `clearTypeaheadBuffer`, or wait for the buffer
		*     to clear after a set interval defined in list foundation. Defaults to
		*     the currently focused index.
		* @return The index of the matched item, or -1 if no match.
		*/
		MDCMenu.prototype.typeaheadMatchItem = function(nextChar, startingIndex) {
			if (this.list) return this.list.typeaheadMatchItem(nextChar, startingIndex);
			return -1;
		};
		/**
		* Layout the underlying list element in the case of any dynamic updates
		* to its structure.
		*/
		MDCMenu.prototype.layout = function() {
			if (this.list) this.list.layout();
		};
		Object.defineProperty(MDCMenu.prototype, "items", {
			/**
			* Return the items within the menu. Note that this only contains the set of elements within
			* the items container that are proper list items, and not supplemental / presentational DOM
			* elements.
			*/
			get: function() {
				return this.list ? this.list.listElements : [];
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCMenu.prototype, "singleSelection", {
			/**
			* Turns on/off the underlying list's single selection mode. Used mainly
			* by select menu.
			*
			* @param singleSelection Whether to enable single selection mode.
			*/
			set: function(singleSelection) {
				if (this.list) this.list.singleSelection = singleSelection;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCMenu.prototype, "selectedIndex", {
			/**
			* Retrieves the selected index. Only applicable to select menus.
			* @return The selected index, which is a number for single selection and
			*     radio lists, and an array of numbers for checkbox lists.
			*/
			get: function() {
				return this.list ? this.list.selectedIndex : numbers$9.UNSET_INDEX;
			},
			/**
			* Sets the selected index of the list. Only applicable to select menus.
			* @param index The selected index, which is a number for single selection and
			*     radio lists, and an array of numbers for checkbox lists.
			*/
			set: function(index) {
				if (this.list) this.list.selectedIndex = index;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCMenu.prototype, "quickOpen", {
			set: function(quickOpen) {
				this.menuSurface.quickOpen = quickOpen;
			},
			enumerable: false,
			configurable: true
		});
		/**
		* Sets default focus state where the menu should focus every time when menu
		* is opened. Focuses the list root (`DefaultFocusState.LIST_ROOT`) element by
		* default.
		* @param focusState Default focus state.
		*/
		MDCMenu.prototype.setDefaultFocusState = function(focusState) {
			this.foundation.setDefaultFocusState(focusState);
		};
		/**
		* @param corner Default anchor corner alignment of top-left menu corner.
		*/
		MDCMenu.prototype.setAnchorCorner = function(corner) {
			this.menuSurface.setAnchorCorner(corner);
		};
		MDCMenu.prototype.setAnchorMargin = function(margin) {
			this.menuSurface.setAnchorMargin(margin);
		};
		/**
		* Sets the list item as the selected row at the specified index.
		* @param index Index of list item within menu.
		*/
		MDCMenu.prototype.setSelectedIndex = function(index) {
			this.foundation.setSelectedIndex(index);
		};
		/**
		* Sets the enabled state to isEnabled for the menu item at the given index.
		* @param index Index of the menu item
		* @param isEnabled The desired enabled state of the menu item.
		*/
		MDCMenu.prototype.setEnabled = function(index, isEnabled) {
			this.foundation.setEnabled(index, isEnabled);
		};
		/**
		* @return The item within the menu at the index specified.
		*/
		MDCMenu.prototype.getOptionByIndex = function(index) {
			if (index < this.items.length) return this.items[index];
			else return null;
		};
		/**
		* @param index A menu item's index.
		* @return The primary text within the menu at the index specified.
		*/
		MDCMenu.prototype.getPrimaryTextAtIndex = function(index) {
			var item = this.getOptionByIndex(index);
			if (item && this.list) return this.list.getPrimaryText(item) || "";
			return "";
		};
		MDCMenu.prototype.setFixedPosition = function(isFixed) {
			this.menuSurface.setFixedPosition(isFixed);
		};
		MDCMenu.prototype.setIsHoisted = function(isHoisted) {
			this.menuSurface.setIsHoisted(isHoisted);
		};
		MDCMenu.prototype.setAbsolutePosition = function(x, y) {
			this.menuSurface.setAbsolutePosition(x, y);
		};
		/**
		* Sets the element that the menu-surface is anchored to.
		*/
		MDCMenu.prototype.setAnchorElement = function(element) {
			this.menuSurface.anchorElement = element;
		};
		MDCMenu.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCMenuFoundation({
				addClassToElementAtIndex: function(index, className) {
					_this.items[index].classList.add(className);
				},
				removeClassFromElementAtIndex: function(index, className) {
					_this.items[index].classList.remove(className);
				},
				addAttributeToElementAtIndex: function(index, attr, value) {
					_this.items[index].setAttribute(attr, value);
				},
				removeAttributeFromElementAtIndex: function(index, attr) {
					_this.items[index].removeAttribute(attr);
				},
				getAttributeFromElementAtIndex: function(index, attr) {
					return _this.items[index].getAttribute(attr);
				},
				elementContainsClass: function(element, className) {
					return element.classList.contains(className);
				},
				closeSurface: function(skipRestoreFocus) {
					_this.menuSurface.close(skipRestoreFocus);
				},
				getElementIndex: function(element) {
					return _this.items.indexOf(element);
				},
				notifySelected: function(evtData) {
					_this.emit(strings$24.SELECTED_EVENT, {
						index: evtData.index,
						item: _this.items[evtData.index]
					});
				},
				getMenuItemCount: function() {
					return _this.items.length;
				},
				focusItemAtIndex: function(index) {
					_this.items[index].focus();
				},
				focusListRoot: function() {
					_this.root.querySelector(strings$24.LIST_SELECTOR).focus();
				},
				isSelectableItemAtIndex: function(index) {
					return !!closest(_this.items[index], "." + cssClasses$20.MENU_SELECTION_GROUP);
				},
				getSelectedSiblingOfItemAtIndex: function(index) {
					var selectedItemEl = closest(_this.items[index], "." + cssClasses$20.MENU_SELECTION_GROUP).querySelector("." + cssClasses$20.MENU_SELECTED_LIST_ITEM);
					return selectedItemEl ? _this.items.indexOf(selectedItemEl) : -1;
				}
			});
		};
		return MDCMenu;
	}(MDCComponent);

//#endregion
//#region Components/AutocompletePagedField/MBAutocompletePagedField.ts
	var MBAutocompletePagedField_exports = /* @__PURE__ */ __exportAll({
		close: () => close$1,
		init: () => init$25,
		open: () => open$1,
		setDisabled: () => setDisabled$9,
		setValue: () => setValue$3
	});
	function init$25(textElem, menuElem, dotNetObject) {
		if (!textElem || !menuElem) return;
		textElem._textField = MDCTextField.attachTo(textElem);
		menuElem._menu = MDCMenu.attachTo(menuElem);
		menuElem._menu.menuSurface.foundation.adapter.handleMenuSurfaceOpened = () => {
			menuElem._menu.foundation.setDefaultFocusState(0);
		};
		const closedCallback = () => {
			dotNetObject.invokeMethodAsync("NotifyClosed");
		};
		menuElem._menu.listen("MDCMenuSurface:closed", closedCallback);
	}
	function open$1(menuElem) {
		menuElem._menu.open = true;
		menuElem._menu.foundation.setDefaultFocusState(0);
	}
	function close$1(menuElem) {
		menuElem._menu.open = false;
	}
	function setValue$3(textElem, value) {
		textElem._textField.value = value;
	}
	function setDisabled$9(textElem, disabled) {
		textElem._textField.disabled = disabled;
	}

//#endregion
//#region Components/AutocompleteTextField/MBAutocompleteTextField.ts
	var MBAutocompleteTextField_exports = /* @__PURE__ */ __exportAll({
		close: () => close,
		init: () => init$24,
		open: () => open,
		setDisabled: () => setDisabled$8,
		setValue: () => setValue$2
	});
	function init$24(textElem, menuElem, dotNetObject) {
		if (!textElem || !menuElem) return;
		textElem._textField = MDCTextField.attachTo(textElem);
		menuElem._menu = MDCMenu.attachTo(menuElem);
		menuElem._menu.foundation.handleItemAction = (listItem) => {
			menuElem._menu.open = false;
			dotNetObject.invokeMethodAsync("NotifySelected", listItem.getAttribute("data-value"));
		};
		menuElem._menu.foundation.adapter.handleMenuSurfaceOpened = () => {
			menuElem._menu.foundation.setDefaultFocusState(0);
		};
		const closedCallback = () => {
			dotNetObject.invokeMethodAsync("NotifyClosed");
		};
		menuElem._menu.listen("MDCMenuSurface:closed", closedCallback);
	}
	function open(menuElem) {
		menuElem._menu.open = true;
		menuElem._menu.foundation.setDefaultFocusState(0);
	}
	function close(menuElem) {
		menuElem._menu.open = false;
	}
	function setValue$2(textElem, value) {
		textElem._textField.value = value;
	}
	function setDisabled$8(textElem, disabled) {
		textElem._textField.disabled = disabled;
	}

//#endregion
//#region Components/BladeSet/MBBladeSet.ts
	var MBBladeSet_exports = /* @__PURE__ */ __exportAll({
		closeBlade: () => closeBlade,
		openBlade: () => openBlade
	});
	const waitDelay = 1e3 / 60;
	function sleep(ms) {
		return new Promise((resolve) => setTimeout(resolve, ms));
	}
	async function openBlade(bladeElem, bladeContentElem, transitionMs) {
		if (!bladeElem || !bladeContentElem) return;
		let transition = "width " + transitionMs + "ms";
		let bladeContentWidth = bladeContentElem.getBoundingClientRect().width;
		bladeElem.style.transition = transition;
		bladeElem.style.width = bladeContentWidth + "px";
		bladeElem.scrollIntoView();
		let intervals = Math.ceil(transitionMs / waitDelay) + 1;
		for (let i = 0; i < intervals; i++) {
			await sleep(waitDelay);
			bladeElem.scrollIntoView();
		}
	}
	function closeBlade(bladeElem) {
		if (!bladeElem) return;
		bladeElem.style.width = "0px";
	}

//#endregion
//#region Components/Button/MBButton.ts
	var MBButton_exports = /* @__PURE__ */ __exportAll({ init: () => init$23 });
	function init$23(elem) {
		if (!elem) return;
		elem._ripple = MDCRipple.attachTo(elem);
	}

//#endregion
//#region Components/Card/MBCard.ts
	var MBCard_exports = /* @__PURE__ */ __exportAll({ init: () => init$22 });
	function init$22(elem) {
		if (!elem) return;
		elem._ripple = MDCRipple.attachTo(elem);
	}

//#endregion
//#region node_modules/.pnpm/@material+checkbox@14.0.0/node_modules/@material/checkbox/constants.js
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
	var cssClasses$19 = {
		ANIM_CHECKED_INDETERMINATE: "mdc-checkbox--anim-checked-indeterminate",
		ANIM_CHECKED_UNCHECKED: "mdc-checkbox--anim-checked-unchecked",
		ANIM_INDETERMINATE_CHECKED: "mdc-checkbox--anim-indeterminate-checked",
		ANIM_INDETERMINATE_UNCHECKED: "mdc-checkbox--anim-indeterminate-unchecked",
		ANIM_UNCHECKED_CHECKED: "mdc-checkbox--anim-unchecked-checked",
		ANIM_UNCHECKED_INDETERMINATE: "mdc-checkbox--anim-unchecked-indeterminate",
		BACKGROUND: "mdc-checkbox__background",
		CHECKED: "mdc-checkbox--checked",
		CHECKMARK: "mdc-checkbox__checkmark",
		CHECKMARK_PATH: "mdc-checkbox__checkmark-path",
		DISABLED: "mdc-checkbox--disabled",
		INDETERMINATE: "mdc-checkbox--indeterminate",
		MIXEDMARK: "mdc-checkbox__mixedmark",
		NATIVE_CONTROL: "mdc-checkbox__native-control",
		ROOT: "mdc-checkbox",
		SELECTED: "mdc-checkbox--selected",
		UPGRADED: "mdc-checkbox--upgraded"
	};
	var strings$23 = {
		ARIA_CHECKED_ATTR: "aria-checked",
		ARIA_CHECKED_INDETERMINATE_VALUE: "mixed",
		DATA_INDETERMINATE_ATTR: "data-indeterminate",
		NATIVE_CONTROL_SELECTOR: ".mdc-checkbox__native-control",
		TRANSITION_STATE_CHECKED: "checked",
		TRANSITION_STATE_INDETERMINATE: "indeterminate",
		TRANSITION_STATE_INIT: "init",
		TRANSITION_STATE_UNCHECKED: "unchecked"
	};
	var numbers$7 = { ANIM_END_LATCH_MS: 250 };

//#endregion
//#region node_modules/.pnpm/@material+checkbox@14.0.0/node_modules/@material/checkbox/foundation.js
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
	var MDCCheckboxFoundation = function(_super) {
		__extends(MDCCheckboxFoundation, _super);
		function MDCCheckboxFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCCheckboxFoundation.defaultAdapter), adapter)) || this;
			_this.currentCheckState = strings$23.TRANSITION_STATE_INIT;
			_this.currentAnimationClass = "";
			_this.animEndLatchTimer = 0;
			_this.enableAnimationEndHandler = false;
			return _this;
		}
		Object.defineProperty(MDCCheckboxFoundation, "cssClasses", {
			get: function() {
				return cssClasses$19;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCCheckboxFoundation, "strings", {
			get: function() {
				return strings$23;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCCheckboxFoundation, "numbers", {
			get: function() {
				return numbers$7;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCCheckboxFoundation, "defaultAdapter", {
			get: function() {
				return {
					addClass: function() {},
					forceLayout: function() {},
					hasNativeControl: function() {
						return false;
					},
					isAttachedToDOM: function() {
						return false;
					},
					isChecked: function() {
						return false;
					},
					isIndeterminate: function() {
						return false;
					},
					removeClass: function() {},
					removeNativeControlAttr: function() {},
					setNativeControlAttr: function() {},
					setNativeControlDisabled: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCCheckboxFoundation.prototype.init = function() {
			this.currentCheckState = this.determineCheckState();
			this.updateAriaChecked();
			this.adapter.addClass(cssClasses$19.UPGRADED);
		};
		MDCCheckboxFoundation.prototype.destroy = function() {
			clearTimeout(this.animEndLatchTimer);
		};
		MDCCheckboxFoundation.prototype.setDisabled = function(disabled) {
			this.adapter.setNativeControlDisabled(disabled);
			if (disabled) this.adapter.addClass(cssClasses$19.DISABLED);
			else this.adapter.removeClass(cssClasses$19.DISABLED);
		};
		/**
		* Handles the animationend event for the checkbox
		*/
		MDCCheckboxFoundation.prototype.handleAnimationEnd = function() {
			var _this = this;
			if (!this.enableAnimationEndHandler) return;
			clearTimeout(this.animEndLatchTimer);
			this.animEndLatchTimer = setTimeout(function() {
				_this.adapter.removeClass(_this.currentAnimationClass);
				_this.enableAnimationEndHandler = false;
			}, numbers$7.ANIM_END_LATCH_MS);
		};
		/**
		* Handles the change event for the checkbox
		*/
		MDCCheckboxFoundation.prototype.handleChange = function() {
			this.transitionCheckState();
		};
		MDCCheckboxFoundation.prototype.transitionCheckState = function() {
			if (!this.adapter.hasNativeControl()) return;
			var oldState = this.currentCheckState;
			var newState = this.determineCheckState();
			if (oldState === newState) return;
			this.updateAriaChecked();
			var TRANSITION_STATE_UNCHECKED = strings$23.TRANSITION_STATE_UNCHECKED;
			var SELECTED = cssClasses$19.SELECTED;
			if (newState === TRANSITION_STATE_UNCHECKED) this.adapter.removeClass(SELECTED);
			else this.adapter.addClass(SELECTED);
			if (this.currentAnimationClass.length > 0) {
				clearTimeout(this.animEndLatchTimer);
				this.adapter.forceLayout();
				this.adapter.removeClass(this.currentAnimationClass);
			}
			this.currentAnimationClass = this.getTransitionAnimationClass(oldState, newState);
			this.currentCheckState = newState;
			if (this.adapter.isAttachedToDOM() && this.currentAnimationClass.length > 0) {
				this.adapter.addClass(this.currentAnimationClass);
				this.enableAnimationEndHandler = true;
			}
		};
		MDCCheckboxFoundation.prototype.determineCheckState = function() {
			var TRANSITION_STATE_INDETERMINATE = strings$23.TRANSITION_STATE_INDETERMINATE, TRANSITION_STATE_CHECKED = strings$23.TRANSITION_STATE_CHECKED, TRANSITION_STATE_UNCHECKED = strings$23.TRANSITION_STATE_UNCHECKED;
			if (this.adapter.isIndeterminate()) return TRANSITION_STATE_INDETERMINATE;
			return this.adapter.isChecked() ? TRANSITION_STATE_CHECKED : TRANSITION_STATE_UNCHECKED;
		};
		MDCCheckboxFoundation.prototype.getTransitionAnimationClass = function(oldState, newState) {
			var TRANSITION_STATE_INIT = strings$23.TRANSITION_STATE_INIT, TRANSITION_STATE_CHECKED = strings$23.TRANSITION_STATE_CHECKED, TRANSITION_STATE_UNCHECKED = strings$23.TRANSITION_STATE_UNCHECKED;
			var _a = MDCCheckboxFoundation.cssClasses, ANIM_UNCHECKED_CHECKED = _a.ANIM_UNCHECKED_CHECKED, ANIM_UNCHECKED_INDETERMINATE = _a.ANIM_UNCHECKED_INDETERMINATE, ANIM_CHECKED_UNCHECKED = _a.ANIM_CHECKED_UNCHECKED, ANIM_CHECKED_INDETERMINATE = _a.ANIM_CHECKED_INDETERMINATE, ANIM_INDETERMINATE_CHECKED = _a.ANIM_INDETERMINATE_CHECKED, ANIM_INDETERMINATE_UNCHECKED = _a.ANIM_INDETERMINATE_UNCHECKED;
			switch (oldState) {
				case TRANSITION_STATE_INIT:
					if (newState === TRANSITION_STATE_UNCHECKED) return "";
					return newState === TRANSITION_STATE_CHECKED ? ANIM_INDETERMINATE_CHECKED : ANIM_INDETERMINATE_UNCHECKED;
				case TRANSITION_STATE_UNCHECKED: return newState === TRANSITION_STATE_CHECKED ? ANIM_UNCHECKED_CHECKED : ANIM_UNCHECKED_INDETERMINATE;
				case TRANSITION_STATE_CHECKED: return newState === TRANSITION_STATE_UNCHECKED ? ANIM_CHECKED_UNCHECKED : ANIM_CHECKED_INDETERMINATE;
				default: return newState === TRANSITION_STATE_CHECKED ? ANIM_INDETERMINATE_CHECKED : ANIM_INDETERMINATE_UNCHECKED;
			}
		};
		MDCCheckboxFoundation.prototype.updateAriaChecked = function() {
			if (this.adapter.isIndeterminate()) this.adapter.setNativeControlAttr(strings$23.ARIA_CHECKED_ATTR, strings$23.ARIA_CHECKED_INDETERMINATE_VALUE);
			else this.adapter.removeNativeControlAttr(strings$23.ARIA_CHECKED_ATTR);
		};
		return MDCCheckboxFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+checkbox@14.0.0/node_modules/@material/checkbox/component.js
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
	var CB_PROTO_PROPS = ["checked", "indeterminate"];
	var MDCCheckbox = function(_super) {
		__extends(MDCCheckbox, _super);
		function MDCCheckbox() {
			var _this = _super !== null && _super.apply(this, arguments) || this;
			_this.rippleSurface = _this.createRipple();
			return _this;
		}
		MDCCheckbox.attachTo = function(root) {
			return new MDCCheckbox(root);
		};
		Object.defineProperty(MDCCheckbox.prototype, "ripple", {
			get: function() {
				return this.rippleSurface;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCCheckbox.prototype, "checked", {
			get: function() {
				return this.getNativeControl().checked;
			},
			set: function(checked) {
				this.getNativeControl().checked = checked;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCCheckbox.prototype, "indeterminate", {
			get: function() {
				return this.getNativeControl().indeterminate;
			},
			set: function(indeterminate) {
				this.getNativeControl().indeterminate = indeterminate;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCCheckbox.prototype, "disabled", {
			get: function() {
				return this.getNativeControl().disabled;
			},
			set: function(disabled) {
				this.foundation.setDisabled(disabled);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCCheckbox.prototype, "value", {
			get: function() {
				return this.getNativeControl().value;
			},
			set: function(value) {
				this.getNativeControl().value = value;
			},
			enumerable: false,
			configurable: true
		});
		MDCCheckbox.prototype.initialize = function() {
			var DATA_INDETERMINATE_ATTR = strings$23.DATA_INDETERMINATE_ATTR;
			this.getNativeControl().indeterminate = this.getNativeControl().getAttribute(DATA_INDETERMINATE_ATTR) === "true";
			this.getNativeControl().removeAttribute(DATA_INDETERMINATE_ATTR);
		};
		MDCCheckbox.prototype.initialSyncWithDOM = function() {
			var _this = this;
			this.handleChange = function() {
				_this.foundation.handleChange();
			};
			this.handleAnimationEnd = function() {
				_this.foundation.handleAnimationEnd();
			};
			this.getNativeControl().addEventListener("change", this.handleChange);
			this.listen(getCorrectEventName(window, "animationend"), this.handleAnimationEnd);
			this.installPropertyChangeHooks();
		};
		MDCCheckbox.prototype.destroy = function() {
			this.rippleSurface.destroy();
			this.getNativeControl().removeEventListener("change", this.handleChange);
			this.unlisten(getCorrectEventName(window, "animationend"), this.handleAnimationEnd);
			this.uninstallPropertyChangeHooks();
			_super.prototype.destroy.call(this);
		};
		MDCCheckbox.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCCheckboxFoundation({
				addClass: function(className) {
					return _this.root.classList.add(className);
				},
				forceLayout: function() {
					return _this.root.offsetWidth;
				},
				hasNativeControl: function() {
					return !!_this.getNativeControl();
				},
				isAttachedToDOM: function() {
					return Boolean(_this.root.parentNode);
				},
				isChecked: function() {
					return _this.checked;
				},
				isIndeterminate: function() {
					return _this.indeterminate;
				},
				removeClass: function(className) {
					_this.root.classList.remove(className);
				},
				removeNativeControlAttr: function(attr) {
					_this.getNativeControl().removeAttribute(attr);
				},
				setNativeControlAttr: function(attr, value) {
					_this.getNativeControl().setAttribute(attr, value);
				},
				setNativeControlDisabled: function(disabled) {
					_this.getNativeControl().disabled = disabled;
				}
			});
		};
		MDCCheckbox.prototype.createRipple = function() {
			var _this = this;
			var adapter = __assign(__assign({}, MDCRipple.createAdapter(this)), {
				deregisterInteractionHandler: function(evtType, handler) {
					_this.getNativeControl().removeEventListener(evtType, handler, applyPassive());
				},
				isSurfaceActive: function() {
					return matches(_this.getNativeControl(), ":active");
				},
				isUnbounded: function() {
					return true;
				},
				registerInteractionHandler: function(evtType, handler) {
					_this.getNativeControl().addEventListener(evtType, handler, applyPassive());
				}
			});
			return new MDCRipple(this.root, new MDCRippleFoundation(adapter));
		};
		MDCCheckbox.prototype.installPropertyChangeHooks = function() {
			var e_1, _a;
			var _this = this;
			var nativeCb = this.getNativeControl();
			var cbProto = Object.getPrototypeOf(nativeCb);
			var _loop_1 = function(controlState) {
				var desc = Object.getOwnPropertyDescriptor(cbProto, controlState);
				if (!validDescriptor(desc)) return { value: void 0 };
				var nativeGetter = desc.get;
				var nativeCbDesc = {
					configurable: desc.configurable,
					enumerable: desc.enumerable,
					get: nativeGetter,
					set: function(state) {
						desc.set.call(nativeCb, state);
						_this.foundation.handleChange();
					}
				};
				Object.defineProperty(nativeCb, controlState, nativeCbDesc);
			};
			try {
				for (var CB_PROTO_PROPS_1 = __values(CB_PROTO_PROPS), CB_PROTO_PROPS_1_1 = CB_PROTO_PROPS_1.next(); !CB_PROTO_PROPS_1_1.done; CB_PROTO_PROPS_1_1 = CB_PROTO_PROPS_1.next()) {
					var controlState = CB_PROTO_PROPS_1_1.value;
					var state_1 = _loop_1(controlState);
					if (typeof state_1 === "object") return state_1.value;
				}
			} catch (e_1_1) {
				e_1 = { error: e_1_1 };
			} finally {
				try {
					if (CB_PROTO_PROPS_1_1 && !CB_PROTO_PROPS_1_1.done && (_a = CB_PROTO_PROPS_1.return)) _a.call(CB_PROTO_PROPS_1);
				} finally {
					if (e_1) throw e_1.error;
				}
			}
		};
		MDCCheckbox.prototype.uninstallPropertyChangeHooks = function() {
			var e_2, _a;
			var nativeCb = this.getNativeControl();
			var cbProto = Object.getPrototypeOf(nativeCb);
			try {
				for (var CB_PROTO_PROPS_2 = __values(CB_PROTO_PROPS), CB_PROTO_PROPS_2_1 = CB_PROTO_PROPS_2.next(); !CB_PROTO_PROPS_2_1.done; CB_PROTO_PROPS_2_1 = CB_PROTO_PROPS_2.next()) {
					var controlState = CB_PROTO_PROPS_2_1.value;
					var desc = Object.getOwnPropertyDescriptor(cbProto, controlState);
					if (!validDescriptor(desc)) return;
					Object.defineProperty(nativeCb, controlState, desc);
				}
			} catch (e_2_1) {
				e_2 = { error: e_2_1 };
			} finally {
				try {
					if (CB_PROTO_PROPS_2_1 && !CB_PROTO_PROPS_2_1.done && (_a = CB_PROTO_PROPS_2.return)) _a.call(CB_PROTO_PROPS_2);
				} finally {
					if (e_2) throw e_2.error;
				}
			}
		};
		MDCCheckbox.prototype.getNativeControl = function() {
			var NATIVE_CONTROL_SELECTOR = strings$23.NATIVE_CONTROL_SELECTOR;
			var el = this.root.querySelector(NATIVE_CONTROL_SELECTOR);
			if (!el) throw new Error("Checkbox component requires a " + NATIVE_CONTROL_SELECTOR + " element");
			return el;
		};
		return MDCCheckbox;
	}(MDCComponent);
	function validDescriptor(inputPropDesc) {
		return !!inputPropDesc && typeof inputPropDesc.set === "function";
	}

//#endregion
//#region node_modules/.pnpm/@material+form-field@14.0.0/node_modules/@material/form-field/constants.js
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
	var cssClasses$18 = { ROOT: "mdc-form-field" };
	var strings$22 = { LABEL_SELECTOR: ".mdc-form-field > label" };

//#endregion
//#region node_modules/.pnpm/@material+form-field@14.0.0/node_modules/@material/form-field/foundation.js
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
	var MDCFormFieldFoundation = function(_super) {
		__extends(MDCFormFieldFoundation, _super);
		function MDCFormFieldFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCFormFieldFoundation.defaultAdapter), adapter)) || this;
			_this.click = function() {
				_this.handleClick();
			};
			return _this;
		}
		Object.defineProperty(MDCFormFieldFoundation, "cssClasses", {
			get: function() {
				return cssClasses$18;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCFormFieldFoundation, "strings", {
			get: function() {
				return strings$22;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCFormFieldFoundation, "defaultAdapter", {
			get: function() {
				return {
					activateInputRipple: function() {},
					deactivateInputRipple: function() {},
					deregisterInteractionHandler: function() {},
					registerInteractionHandler: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCFormFieldFoundation.prototype.init = function() {
			this.adapter.registerInteractionHandler("click", this.click);
		};
		MDCFormFieldFoundation.prototype.destroy = function() {
			this.adapter.deregisterInteractionHandler("click", this.click);
		};
		MDCFormFieldFoundation.prototype.handleClick = function() {
			var _this = this;
			this.adapter.activateInputRipple();
			requestAnimationFrame(function() {
				_this.adapter.deactivateInputRipple();
			});
		};
		return MDCFormFieldFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+form-field@14.0.0/node_modules/@material/form-field/component.js
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
	var MDCFormField = function(_super) {
		__extends(MDCFormField, _super);
		function MDCFormField() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCFormField.attachTo = function(root) {
			return new MDCFormField(root);
		};
		MDCFormField.prototype.labelEl = function() {
			var LABEL_SELECTOR = MDCFormFieldFoundation.strings.LABEL_SELECTOR;
			return this.root.querySelector(LABEL_SELECTOR);
		};
		MDCFormField.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCFormFieldFoundation({
				activateInputRipple: function() {
					if (_this.input && _this.input.ripple) _this.input.ripple.activate();
				},
				deactivateInputRipple: function() {
					if (_this.input && _this.input.ripple) _this.input.ripple.deactivate();
				},
				deregisterInteractionHandler: function(evtType, handler) {
					var labelEl = _this.labelEl();
					if (labelEl) labelEl.removeEventListener(evtType, handler);
				},
				registerInteractionHandler: function(evtType, handler) {
					var labelEl = _this.labelEl();
					if (labelEl) labelEl.addEventListener(evtType, handler);
				}
			});
		};
		return MDCFormField;
	}(MDCComponent);

//#endregion
//#region Components/Checkbox/MBCheckbox.ts
	var MBCheckbox_exports = /* @__PURE__ */ __exportAll({
		init: () => init$21,
		setChecked: () => setChecked$1,
		setDisabled: () => setDisabled$7,
		setIndeterminate: () => setIndeterminate
	});
	function init$21(elem, formFieldElem, checked, indeterminate) {
		if (!elem || !formFieldElem) return;
		elem._checkbox = MDCCheckbox.attachTo(elem);
		elem._checkbox.checked = checked;
		elem._checkbox.indeterminate = indeterminate;
		elem._formField = MDCFormField.attachTo(formFieldElem);
		elem._formField.input = elem._checkbox;
	}
	function setChecked$1(elem, checked) {
		if (!elem) return;
		elem._checkbox.checked = checked;
	}
	function setIndeterminate(elem, indeterminate) {
		if (!elem) return;
		if (elem?._checkbox == null) return;
		elem._checkbox.indeterminate = indeterminate;
	}
	function setDisabled$7(elem, disabled) {
		if (!elem) return;
		elem._checkbox.disabled = disabled;
	}

//#endregion
//#region node_modules/.pnpm/@material+circular-progress@14.0.0/node_modules/@material/circular-progress/constants.js
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
	/**
	* CSS class names used in component.
	*/
	var cssClasses$17 = {
		INDETERMINATE_CLASS: "mdc-circular-progress--indeterminate",
		CLOSED_CLASS: "mdc-circular-progress--closed"
	};
	/**
	* Attributes and selectors used in component.
	*/
	var strings$21 = {
		ARIA_HIDDEN: "aria-hidden",
		ARIA_VALUENOW: "aria-valuenow",
		DETERMINATE_CIRCLE_SELECTOR: ".mdc-circular-progress__determinate-circle",
		RADIUS: "r",
		STROKE_DASHOFFSET: "stroke-dashoffset"
	};

//#endregion
//#region node_modules/.pnpm/@material+circular-progress@14.0.0/node_modules/@material/circular-progress/foundation.js
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
	var MDCCircularProgressFoundation = function(_super) {
		__extends(MDCCircularProgressFoundation, _super);
		function MDCCircularProgressFoundation(adapter) {
			return _super.call(this, __assign(__assign({}, MDCCircularProgressFoundation.defaultAdapter), adapter)) || this;
		}
		Object.defineProperty(MDCCircularProgressFoundation, "cssClasses", {
			get: function() {
				return cssClasses$17;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCCircularProgressFoundation, "strings", {
			get: function() {
				return strings$21;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCCircularProgressFoundation, "defaultAdapter", {
			get: function() {
				return {
					addClass: function() {},
					getDeterminateCircleAttribute: function() {
						return null;
					},
					hasClass: function() {
						return false;
					},
					removeClass: function() {},
					removeAttribute: function() {},
					setAttribute: function() {},
					setDeterminateCircleAttribute: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCCircularProgressFoundation.prototype.init = function() {
			this.closed = this.adapter.hasClass(cssClasses$17.CLOSED_CLASS);
			this.determinate = !this.adapter.hasClass(cssClasses$17.INDETERMINATE_CLASS);
			this.progress = 0;
			if (this.determinate) this.adapter.setAttribute(strings$21.ARIA_VALUENOW, this.progress.toString());
			this.radius = Number(this.adapter.getDeterminateCircleAttribute(strings$21.RADIUS));
		};
		/**
		* Sets whether the progress indicator is in determinate mode.
		* @param determinate Whether the indicator should be determinate.
		*/
		MDCCircularProgressFoundation.prototype.setDeterminate = function(determinate) {
			this.determinate = determinate;
			if (this.determinate) {
				this.adapter.removeClass(cssClasses$17.INDETERMINATE_CLASS);
				this.setProgress(this.progress);
			} else {
				this.adapter.addClass(cssClasses$17.INDETERMINATE_CLASS);
				this.adapter.removeAttribute(strings$21.ARIA_VALUENOW);
			}
		};
		MDCCircularProgressFoundation.prototype.isDeterminate = function() {
			return this.determinate;
		};
		/**
		* Sets the current progress value. In indeterminate mode, this has no
		* visual effect but will be reflected if the indicator is switched to
		* determinate mode.
		* @param value The current progress value, which must be between 0 and 1.
		*/
		MDCCircularProgressFoundation.prototype.setProgress = function(value) {
			this.progress = value;
			if (this.determinate) {
				var unfilledArcLength = (1 - this.progress) * (2 * Math.PI * this.radius);
				this.adapter.setDeterminateCircleAttribute(strings$21.STROKE_DASHOFFSET, "" + unfilledArcLength);
				this.adapter.setAttribute(strings$21.ARIA_VALUENOW, this.progress.toString());
			}
		};
		MDCCircularProgressFoundation.prototype.getProgress = function() {
			return this.progress;
		};
		/**
		* Shows the progress indicator.
		*/
		MDCCircularProgressFoundation.prototype.open = function() {
			this.closed = false;
			this.adapter.removeClass(cssClasses$17.CLOSED_CLASS);
			this.adapter.removeAttribute(strings$21.ARIA_HIDDEN);
		};
		/**
		* Hides the progress indicator
		*/
		MDCCircularProgressFoundation.prototype.close = function() {
			this.closed = true;
			this.adapter.addClass(cssClasses$17.CLOSED_CLASS);
			this.adapter.setAttribute(strings$21.ARIA_HIDDEN, "true");
		};
		/**
		* @return Returns whether the progress indicator is hidden.
		*/
		MDCCircularProgressFoundation.prototype.isClosed = function() {
			return this.closed;
		};
		return MDCCircularProgressFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+circular-progress@14.0.0/node_modules/@material/circular-progress/component.js
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
	var MDCCircularProgress = function(_super) {
		__extends(MDCCircularProgress, _super);
		function MDCCircularProgress() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCCircularProgress.prototype.initialize = function() {
			this.determinateCircle = this.root.querySelector(MDCCircularProgressFoundation.strings.DETERMINATE_CIRCLE_SELECTOR);
		};
		MDCCircularProgress.attachTo = function(root) {
			return new MDCCircularProgress(root);
		};
		Object.defineProperty(MDCCircularProgress.prototype, "determinate", {
			/**
			* Sets whether the progress indicator is in determinate mode.
			* @param isDeterminate Whether the indicator should be determinate.
			*/
			set: function(value) {
				this.foundation.setDeterminate(value);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCCircularProgress.prototype, "progress", {
			/**
			* Sets the current progress value. In indeterminate mode, this has no
			* visual effect but will be reflected if the indicator is switched to
			* determinate mode.
			* @param value The current progress value, which must be between 0 and 1.
			*/
			set: function(value) {
				this.foundation.setProgress(value);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCCircularProgress.prototype, "isClosed", {
			/**
			* Whether the progress indicator is hidden.
			*/
			get: function() {
				return this.foundation.isClosed();
			},
			enumerable: false,
			configurable: true
		});
		/**
		* Shows the progress indicator.
		*/
		MDCCircularProgress.prototype.open = function() {
			this.foundation.open();
		};
		/**
		* Hides the progress indicator.
		*/
		MDCCircularProgress.prototype.close = function() {
			this.foundation.close();
		};
		MDCCircularProgress.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCCircularProgressFoundation({
				addClass: function(className) {
					_this.root.classList.add(className);
				},
				getDeterminateCircleAttribute: function(attributeName) {
					return _this.determinateCircle.getAttribute(attributeName);
				},
				hasClass: function(className) {
					return _this.root.classList.contains(className);
				},
				removeClass: function(className) {
					_this.root.classList.remove(className);
				},
				removeAttribute: function(attributeName) {
					_this.root.removeAttribute(attributeName);
				},
				setAttribute: function(attributeName, value) {
					_this.root.setAttribute(attributeName, value);
				},
				setDeterminateCircleAttribute: function(attributeName, value) {
					_this.determinateCircle.setAttribute(attributeName, value);
				}
			});
		};
		return MDCCircularProgress;
	}(MDCComponent);

//#endregion
//#region Components/CircularProgress/MBCircularProgress.ts
	var MBCircularProgress_exports = /* @__PURE__ */ __exportAll({
		init: () => init$20,
		setProgress: () => setProgress$2
	});
	function init$20(elem, progress) {
		if (!elem) return;
		elem._circularProgress = MDCCircularProgress.attachTo(elem);
		setProgress$2(elem, progress);
	}
	function setProgress$2(elem, progress) {
		if (!elem) return;
		elem._circularProgress.progress = progress;
	}

//#endregion
//#region node_modules/.pnpm/@material+linear-progress@14.0.0/node_modules/@material/linear-progress/constants.js
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
	var cssClasses$16 = {
		CLOSED_CLASS: "mdc-linear-progress--closed",
		CLOSED_ANIMATION_OFF_CLASS: "mdc-linear-progress--closed-animation-off",
		INDETERMINATE_CLASS: "mdc-linear-progress--indeterminate",
		REVERSED_CLASS: "mdc-linear-progress--reversed",
		ANIMATION_READY_CLASS: "mdc-linear-progress--animation-ready"
	};
	var strings$20 = {
		ARIA_HIDDEN: "aria-hidden",
		ARIA_VALUEMAX: "aria-valuemax",
		ARIA_VALUEMIN: "aria-valuemin",
		ARIA_VALUENOW: "aria-valuenow",
		BUFFER_BAR_SELECTOR: ".mdc-linear-progress__buffer-bar",
		FLEX_BASIS: "flex-basis",
		PRIMARY_BAR_SELECTOR: ".mdc-linear-progress__primary-bar"
	};
	var animationDimensionPercentages = {
		PRIMARY_HALF: .8367142,
		PRIMARY_FULL: 2.00611057,
		SECONDARY_QUARTER: .37651913,
		SECONDARY_HALF: .84386165,
		SECONDARY_FULL: 1.60277782
	};

//#endregion
//#region node_modules/.pnpm/@material+linear-progress@14.0.0/node_modules/@material/linear-progress/foundation.js
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
	var MDCLinearProgressFoundation = function(_super) {
		__extends(MDCLinearProgressFoundation, _super);
		function MDCLinearProgressFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCLinearProgressFoundation.defaultAdapter), adapter)) || this;
			_this.observer = null;
			return _this;
		}
		Object.defineProperty(MDCLinearProgressFoundation, "cssClasses", {
			get: function() {
				return cssClasses$16;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCLinearProgressFoundation, "strings", {
			get: function() {
				return strings$20;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCLinearProgressFoundation, "defaultAdapter", {
			get: function() {
				return {
					addClass: function() {},
					attachResizeObserver: function() {
						return null;
					},
					forceLayout: function() {},
					getWidth: function() {
						return 0;
					},
					hasClass: function() {
						return false;
					},
					setBufferBarStyle: function() {
						return null;
					},
					setPrimaryBarStyle: function() {
						return null;
					},
					setStyle: function() {},
					removeAttribute: function() {},
					removeClass: function() {},
					setAttribute: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCLinearProgressFoundation.prototype.init = function() {
			var _this = this;
			this.determinate = !this.adapter.hasClass(cssClasses$16.INDETERMINATE_CLASS);
			this.adapter.addClass(cssClasses$16.ANIMATION_READY_CLASS);
			this.progress = 0;
			this.buffer = 1;
			this.observer = this.adapter.attachResizeObserver(function(entries) {
				var e_1, _a;
				if (_this.determinate) return;
				try {
					for (var entries_1 = __values(entries), entries_1_1 = entries_1.next(); !entries_1_1.done; entries_1_1 = entries_1.next()) {
						var entry = entries_1_1.value;
						if (entry.contentRect) _this.calculateAndSetDimensions(entry.contentRect.width);
					}
				} catch (e_1_1) {
					e_1 = { error: e_1_1 };
				} finally {
					try {
						if (entries_1_1 && !entries_1_1.done && (_a = entries_1.return)) _a.call(entries_1);
					} finally {
						if (e_1) throw e_1.error;
					}
				}
			});
			if (!this.determinate && this.observer) this.calculateAndSetDimensions(this.adapter.getWidth());
		};
		MDCLinearProgressFoundation.prototype.setDeterminate = function(isDeterminate) {
			this.determinate = isDeterminate;
			if (this.determinate) {
				this.adapter.removeClass(cssClasses$16.INDETERMINATE_CLASS);
				this.adapter.setAttribute(strings$20.ARIA_VALUENOW, this.progress.toString());
				this.adapter.setAttribute(strings$20.ARIA_VALUEMAX, "1");
				this.adapter.setAttribute(strings$20.ARIA_VALUEMIN, "0");
				this.setPrimaryBarProgress(this.progress);
				this.setBufferBarProgress(this.buffer);
				return;
			}
			if (this.observer) this.calculateAndSetDimensions(this.adapter.getWidth());
			this.adapter.addClass(cssClasses$16.INDETERMINATE_CLASS);
			this.adapter.removeAttribute(strings$20.ARIA_VALUENOW);
			this.adapter.removeAttribute(strings$20.ARIA_VALUEMAX);
			this.adapter.removeAttribute(strings$20.ARIA_VALUEMIN);
			this.setPrimaryBarProgress(1);
			this.setBufferBarProgress(1);
		};
		MDCLinearProgressFoundation.prototype.isDeterminate = function() {
			return this.determinate;
		};
		MDCLinearProgressFoundation.prototype.setProgress = function(value) {
			this.progress = value;
			if (this.determinate) {
				this.setPrimaryBarProgress(value);
				this.adapter.setAttribute(strings$20.ARIA_VALUENOW, value.toString());
			}
		};
		MDCLinearProgressFoundation.prototype.getProgress = function() {
			return this.progress;
		};
		MDCLinearProgressFoundation.prototype.setBuffer = function(value) {
			this.buffer = value;
			if (this.determinate) this.setBufferBarProgress(value);
		};
		MDCLinearProgressFoundation.prototype.getBuffer = function() {
			return this.buffer;
		};
		MDCLinearProgressFoundation.prototype.open = function() {
			this.adapter.removeClass(cssClasses$16.CLOSED_CLASS);
			this.adapter.removeClass(cssClasses$16.CLOSED_ANIMATION_OFF_CLASS);
			this.adapter.removeAttribute(strings$20.ARIA_HIDDEN);
		};
		MDCLinearProgressFoundation.prototype.close = function() {
			this.adapter.addClass(cssClasses$16.CLOSED_CLASS);
			this.adapter.setAttribute(strings$20.ARIA_HIDDEN, "true");
		};
		MDCLinearProgressFoundation.prototype.isClosed = function() {
			return this.adapter.hasClass(cssClasses$16.CLOSED_CLASS);
		};
		/**
		* Handles the transitionend event emitted after `close()` is called and the
		* opacity fades out. This is so that animations are removed only after the
		* progress indicator is completely hidden.
		*/
		MDCLinearProgressFoundation.prototype.handleTransitionEnd = function() {
			if (this.adapter.hasClass(cssClasses$16.CLOSED_CLASS)) this.adapter.addClass(cssClasses$16.CLOSED_ANIMATION_OFF_CLASS);
		};
		MDCLinearProgressFoundation.prototype.destroy = function() {
			_super.prototype.destroy.call(this);
			if (this.observer) this.observer.disconnect();
		};
		MDCLinearProgressFoundation.prototype.restartAnimation = function() {
			this.adapter.removeClass(cssClasses$16.ANIMATION_READY_CLASS);
			this.adapter.forceLayout();
			this.adapter.addClass(cssClasses$16.ANIMATION_READY_CLASS);
		};
		MDCLinearProgressFoundation.prototype.setPrimaryBarProgress = function(progressValue) {
			var value = "scaleX(" + progressValue + ")";
			var transformProp = typeof window !== "undefined" ? getCorrectPropertyName(window, "transform") : "transform";
			this.adapter.setPrimaryBarStyle(transformProp, value);
		};
		MDCLinearProgressFoundation.prototype.setBufferBarProgress = function(progressValue) {
			var value = progressValue * 100 + "%";
			this.adapter.setBufferBarStyle(strings$20.FLEX_BASIS, value);
		};
		MDCLinearProgressFoundation.prototype.calculateAndSetDimensions = function(width) {
			var primaryHalf = width * animationDimensionPercentages.PRIMARY_HALF;
			var primaryFull = width * animationDimensionPercentages.PRIMARY_FULL;
			var secondaryQuarter = width * animationDimensionPercentages.SECONDARY_QUARTER;
			var secondaryHalf = width * animationDimensionPercentages.SECONDARY_HALF;
			var secondaryFull = width * animationDimensionPercentages.SECONDARY_FULL;
			this.adapter.setStyle("--mdc-linear-progress-primary-half", primaryHalf + "px");
			this.adapter.setStyle("--mdc-linear-progress-primary-half-neg", -primaryHalf + "px");
			this.adapter.setStyle("--mdc-linear-progress-primary-full", primaryFull + "px");
			this.adapter.setStyle("--mdc-linear-progress-primary-full-neg", -primaryFull + "px");
			this.adapter.setStyle("--mdc-linear-progress-secondary-quarter", secondaryQuarter + "px");
			this.adapter.setStyle("--mdc-linear-progress-secondary-quarter-neg", -secondaryQuarter + "px");
			this.adapter.setStyle("--mdc-linear-progress-secondary-half", secondaryHalf + "px");
			this.adapter.setStyle("--mdc-linear-progress-secondary-half-neg", -secondaryHalf + "px");
			this.adapter.setStyle("--mdc-linear-progress-secondary-full", secondaryFull + "px");
			this.adapter.setStyle("--mdc-linear-progress-secondary-full-neg", -secondaryFull + "px");
			this.restartAnimation();
		};
		return MDCLinearProgressFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+linear-progress@14.0.0/node_modules/@material/linear-progress/component.js
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
	var MDCLinearProgress = function(_super) {
		__extends(MDCLinearProgress, _super);
		function MDCLinearProgress() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCLinearProgress.attachTo = function(root) {
			return new MDCLinearProgress(root);
		};
		Object.defineProperty(MDCLinearProgress.prototype, "determinate", {
			set: function(value) {
				this.foundation.setDeterminate(value);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCLinearProgress.prototype, "progress", {
			set: function(value) {
				this.foundation.setProgress(value);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCLinearProgress.prototype, "buffer", {
			set: function(value) {
				this.foundation.setBuffer(value);
			},
			enumerable: false,
			configurable: true
		});
		MDCLinearProgress.prototype.open = function() {
			this.foundation.open();
		};
		MDCLinearProgress.prototype.close = function() {
			this.foundation.close();
		};
		MDCLinearProgress.prototype.initialSyncWithDOM = function() {
			var _this = this;
			this.root.addEventListener("transitionend", function() {
				_this.foundation.handleTransitionEnd();
			});
		};
		MDCLinearProgress.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCLinearProgressFoundation({
				addClass: function(className) {
					_this.root.classList.add(className);
				},
				forceLayout: function() {
					_this.root.getBoundingClientRect();
				},
				setBufferBarStyle: function(styleProperty, value) {
					var bufferBar = _this.root.querySelector(MDCLinearProgressFoundation.strings.BUFFER_BAR_SELECTOR);
					if (bufferBar) bufferBar.style.setProperty(styleProperty, value);
				},
				setPrimaryBarStyle: function(styleProperty, value) {
					var primaryBar = _this.root.querySelector(MDCLinearProgressFoundation.strings.PRIMARY_BAR_SELECTOR);
					if (primaryBar) primaryBar.style.setProperty(styleProperty, value);
				},
				hasClass: function(className) {
					return _this.root.classList.contains(className);
				},
				removeAttribute: function(attributeName) {
					_this.root.removeAttribute(attributeName);
				},
				removeClass: function(className) {
					_this.root.classList.remove(className);
				},
				setAttribute: function(attributeName, value) {
					_this.root.setAttribute(attributeName, value);
				},
				setStyle: function(name, value) {
					_this.root.style.setProperty(name, value);
				},
				attachResizeObserver: function(callback) {
					var RO = window.ResizeObserver;
					if (RO) {
						var ro = new RO(callback);
						ro.observe(_this.root);
						return ro;
					}
					return null;
				},
				getWidth: function() {
					return _this.root.offsetWidth;
				}
			});
		};
		return MDCLinearProgress;
	}(MDCComponent);

//#endregion
//#region node_modules/.pnpm/@material+data-table@14.0.0/node_modules/@material/data-table/constants.js
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
	/**
	* CSS class names used in component.
	*/
	var cssClasses$15 = {
		CELL: "mdc-data-table__cell",
		CELL_NUMERIC: "mdc-data-table__cell--numeric",
		CONTENT: "mdc-data-table__content",
		HEADER_CELL: "mdc-data-table__header-cell",
		HEADER_CELL_LABEL: "mdc-data-table__header-cell-label",
		HEADER_CELL_SORTED: "mdc-data-table__header-cell--sorted",
		HEADER_CELL_SORTED_DESCENDING: "mdc-data-table__header-cell--sorted-descending",
		HEADER_CELL_WITH_SORT: "mdc-data-table__header-cell--with-sort",
		HEADER_CELL_WRAPPER: "mdc-data-table__header-cell-wrapper",
		HEADER_ROW: "mdc-data-table__header-row",
		HEADER_ROW_CHECKBOX: "mdc-data-table__header-row-checkbox",
		IN_PROGRESS: "mdc-data-table--in-progress",
		LINEAR_PROGRESS: "mdc-data-table__linear-progress",
		PAGINATION_ROWS_PER_PAGE_LABEL: "mdc-data-table__pagination-rows-per-page-label",
		PAGINATION_ROWS_PER_PAGE_SELECT: "mdc-data-table__pagination-rows-per-page-select",
		PROGRESS_INDICATOR: "mdc-data-table__progress-indicator",
		ROOT: "mdc-data-table",
		ROW: "mdc-data-table__row",
		ROW_CHECKBOX: "mdc-data-table__row-checkbox",
		ROW_SELECTED: "mdc-data-table__row--selected",
		SORT_ICON_BUTTON: "mdc-data-table__sort-icon-button",
		SORT_STATUS_LABEL: "mdc-data-table__sort-status-label",
		TABLE_CONTAINER: "mdc-data-table__table-container"
	};
	/**
	* DOM attributes used in component.
	*/
	var attributes$3 = {
		ARIA_SELECTED: "aria-selected",
		ARIA_SORT: "aria-sort"
	};
	/**
	* List of data attributes used in component.
	*/
	var dataAttributes = {
		COLUMN_ID: "data-column-id",
		ROW_ID: "data-row-id"
	};
	/**
	* CSS selectors used in component.
	*/
	var selectors$1 = {
		CONTENT: "." + cssClasses$15.CONTENT,
		HEADER_CELL: "." + cssClasses$15.HEADER_CELL,
		HEADER_CELL_WITH_SORT: "." + cssClasses$15.HEADER_CELL_WITH_SORT,
		HEADER_ROW: "." + cssClasses$15.HEADER_ROW,
		HEADER_ROW_CHECKBOX: "." + cssClasses$15.HEADER_ROW_CHECKBOX,
		PROGRESS_INDICATOR: "." + cssClasses$15.PROGRESS_INDICATOR,
		ROW: "." + cssClasses$15.ROW,
		ROW_CHECKBOX: "." + cssClasses$15.ROW_CHECKBOX,
		ROW_SELECTED: "." + cssClasses$15.ROW_SELECTED,
		SORT_ICON_BUTTON: "." + cssClasses$15.SORT_ICON_BUTTON,
		SORT_STATUS_LABEL: "." + cssClasses$15.SORT_STATUS_LABEL
	};
	/**
	* Messages used in component.
	*/
	var messages = {
		SORTED_IN_DESCENDING: "Sorted in descending order",
		SORTED_IN_ASCENDING: "Sorted in ascending order"
	};
	/**
	* Attributes and selectors used in component.
	* @deprecated Use `attributes`, `dataAttributes` and `selectors` instead.
	*/
	var strings$19 = {
		ARIA_SELECTED: attributes$3.ARIA_SELECTED,
		ARIA_SORT: attributes$3.ARIA_SORT,
		DATA_ROW_ID_ATTR: dataAttributes.ROW_ID,
		HEADER_ROW_CHECKBOX_SELECTOR: selectors$1.HEADER_ROW_CHECKBOX,
		ROW_CHECKBOX_SELECTOR: selectors$1.ROW_CHECKBOX,
		ROW_SELECTED_SELECTOR: selectors$1.ROW_SELECTED,
		ROW_SELECTOR: selectors$1.ROW
	};
	/**
	* Sort values defined by ARIA.
	* See https://www.w3.org/WAI/PF/aria/states_and_properties#aria-sort
	*/
	var SortValue;
	(function(SortValue) {
		SortValue["ASCENDING"] = "ascending";
		SortValue["DESCENDING"] = "descending";
		SortValue["NONE"] = "none";
		SortValue["OTHER"] = "other";
	})(SortValue || (SortValue = {}));
	/**
	* Event names used in component.
	*/
	var events$4 = {
		ROW_CLICK: "MDCDataTable:rowClick",
		ROW_SELECTION_CHANGED: "MDCDataTable:rowSelectionChanged",
		SELECTED_ALL: "MDCDataTable:selectedAll",
		SORTED: "MDCDataTable:sorted",
		UNSELECTED_ALL: "MDCDataTable:unselectedAll"
	};

//#endregion
//#region node_modules/.pnpm/@material+data-table@14.0.0/node_modules/@material/data-table/foundation.js
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
	/**
	* The Foundation of data table component containing pure business logic, any
	* logic requiring DOM manipulation are delegated to adapter methods.
	*/
	var MDCDataTableFoundation = function(_super) {
		__extends(MDCDataTableFoundation, _super);
		function MDCDataTableFoundation(adapter) {
			return _super.call(this, __assign(__assign({}, MDCDataTableFoundation.defaultAdapter), adapter)) || this;
		}
		Object.defineProperty(MDCDataTableFoundation, "defaultAdapter", {
			get: function() {
				return {
					addClass: function() {},
					addClassAtRowIndex: function() {},
					getAttributeByHeaderCellIndex: function() {
						return "";
					},
					getHeaderCellCount: function() {
						return 0;
					},
					getHeaderCellElements: function() {
						return [];
					},
					getRowCount: function() {
						return 0;
					},
					getRowElements: function() {
						return [];
					},
					getRowIdAtIndex: function() {
						return "";
					},
					getRowIndexByChildElement: function() {
						return 0;
					},
					getSelectedRowCount: function() {
						return 0;
					},
					getTableContainerHeight: function() {
						return 0;
					},
					getTableHeaderHeight: function() {
						return 0;
					},
					isCheckboxAtRowIndexChecked: function() {
						return false;
					},
					isHeaderRowCheckboxChecked: function() {
						return false;
					},
					isRowsSelectable: function() {
						return false;
					},
					notifyRowSelectionChanged: function() {},
					notifySelectedAll: function() {},
					notifySortAction: function() {},
					notifyUnselectedAll: function() {},
					notifyRowClick: function() {},
					registerHeaderRowCheckbox: function() {},
					registerRowCheckboxes: function() {},
					removeClass: function() {},
					removeClassAtRowIndex: function() {},
					removeClassNameByHeaderCellIndex: function() {},
					setAttributeAtRowIndex: function() {},
					setAttributeByHeaderCellIndex: function() {},
					setClassNameByHeaderCellIndex: function() {},
					setHeaderRowCheckboxChecked: function() {},
					setHeaderRowCheckboxIndeterminate: function() {},
					setProgressIndicatorStyles: function() {},
					setRowCheckboxCheckedAtIndex: function() {},
					setSortStatusLabelByHeaderCellIndex: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		/**
		* Re-initializes header row checkbox and row checkboxes when selectable rows
		* are added or removed from table. Use this if registering checkbox is
		* synchronous.
		*/
		MDCDataTableFoundation.prototype.layout = function() {
			if (this.adapter.isRowsSelectable()) {
				this.adapter.registerHeaderRowCheckbox();
				this.adapter.registerRowCheckboxes();
				this.setHeaderRowCheckboxState();
			}
		};
		/**
		* Re-initializes header row checkbox and row checkboxes when selectable rows
		* are added or removed from table. Use this if registering checkbox is
		* asynchronous.
		*/
		MDCDataTableFoundation.prototype.layoutAsync = function() {
			return __awaiter(this, void 0, void 0, function() {
				return __generator(this, function(_a) {
					switch (_a.label) {
						case 0:
							if (!this.adapter.isRowsSelectable()) return [3, 3];
							return [4, this.adapter.registerHeaderRowCheckbox()];
						case 1:
							_a.sent();
							return [4, this.adapter.registerRowCheckboxes()];
						case 2:
							_a.sent();
							this.setHeaderRowCheckboxState();
							_a.label = 3;
						case 3: return [2];
					}
				});
			});
		};
		/**
		* @return Returns array of row elements.
		*/
		MDCDataTableFoundation.prototype.getRows = function() {
			return this.adapter.getRowElements();
		};
		/**
		* @return Array of header cell elements.
		*/
		MDCDataTableFoundation.prototype.getHeaderCells = function() {
			return this.adapter.getHeaderCellElements();
		};
		/**
		* Sets selected row ids. Overwrites previously selected rows.
		* @param rowIds Array of row ids that needs to be selected.
		*/
		MDCDataTableFoundation.prototype.setSelectedRowIds = function(rowIds) {
			for (var rowIndex = 0; rowIndex < this.adapter.getRowCount(); rowIndex++) {
				var rowId = this.adapter.getRowIdAtIndex(rowIndex);
				var isSelected = false;
				if (rowId && rowIds.indexOf(rowId) >= 0) isSelected = true;
				this.adapter.setRowCheckboxCheckedAtIndex(rowIndex, isSelected);
				this.selectRowAtIndex(rowIndex, isSelected);
			}
			this.setHeaderRowCheckboxState();
		};
		/**
		* @return Returns array of all row ids.
		*/
		MDCDataTableFoundation.prototype.getRowIds = function() {
			var rowIds = [];
			for (var rowIndex = 0; rowIndex < this.adapter.getRowCount(); rowIndex++) rowIds.push(this.adapter.getRowIdAtIndex(rowIndex));
			return rowIds;
		};
		/**
		* @return Returns array of selected row ids.
		*/
		MDCDataTableFoundation.prototype.getSelectedRowIds = function() {
			var selectedRowIds = [];
			for (var rowIndex = 0; rowIndex < this.adapter.getRowCount(); rowIndex++) if (this.adapter.isCheckboxAtRowIndexChecked(rowIndex)) selectedRowIds.push(this.adapter.getRowIdAtIndex(rowIndex));
			return selectedRowIds;
		};
		/**
		* Handles header row checkbox change event.
		*/
		MDCDataTableFoundation.prototype.handleHeaderRowCheckboxChange = function() {
			var isHeaderChecked = this.adapter.isHeaderRowCheckboxChecked();
			for (var rowIndex = 0; rowIndex < this.adapter.getRowCount(); rowIndex++) {
				this.adapter.setRowCheckboxCheckedAtIndex(rowIndex, isHeaderChecked);
				this.selectRowAtIndex(rowIndex, isHeaderChecked);
			}
			if (isHeaderChecked) this.adapter.notifySelectedAll();
			else this.adapter.notifyUnselectedAll();
		};
		/**
		* Handles change event originated from row checkboxes.
		*/
		MDCDataTableFoundation.prototype.handleRowCheckboxChange = function(event) {
			var rowIndex = this.adapter.getRowIndexByChildElement(event.target);
			if (rowIndex === -1) return;
			var selected = this.adapter.isCheckboxAtRowIndexChecked(rowIndex);
			this.selectRowAtIndex(rowIndex, selected);
			this.setHeaderRowCheckboxState();
			var rowId = this.adapter.getRowIdAtIndex(rowIndex);
			this.adapter.notifyRowSelectionChanged({
				rowId,
				rowIndex,
				selected
			});
		};
		/**
		* Handles sort action on sortable header cell.
		*/
		MDCDataTableFoundation.prototype.handleSortAction = function(eventData) {
			var columnId = eventData.columnId, columnIndex = eventData.columnIndex, headerCell = eventData.headerCell;
			for (var index = 0; index < this.adapter.getHeaderCellCount(); index++) {
				if (index === columnIndex) continue;
				this.adapter.removeClassNameByHeaderCellIndex(index, cssClasses$15.HEADER_CELL_SORTED);
				this.adapter.removeClassNameByHeaderCellIndex(index, cssClasses$15.HEADER_CELL_SORTED_DESCENDING);
				this.adapter.setAttributeByHeaderCellIndex(index, strings$19.ARIA_SORT, SortValue.NONE);
				this.adapter.setSortStatusLabelByHeaderCellIndex(index, SortValue.NONE);
			}
			this.adapter.setClassNameByHeaderCellIndex(columnIndex, cssClasses$15.HEADER_CELL_SORTED);
			var currentSortValue = this.adapter.getAttributeByHeaderCellIndex(columnIndex, strings$19.ARIA_SORT);
			var sortValue = SortValue.NONE;
			if (currentSortValue === SortValue.ASCENDING) {
				this.adapter.setClassNameByHeaderCellIndex(columnIndex, cssClasses$15.HEADER_CELL_SORTED_DESCENDING);
				this.adapter.setAttributeByHeaderCellIndex(columnIndex, strings$19.ARIA_SORT, SortValue.DESCENDING);
				sortValue = SortValue.DESCENDING;
			} else if (currentSortValue === SortValue.DESCENDING) {
				this.adapter.removeClassNameByHeaderCellIndex(columnIndex, cssClasses$15.HEADER_CELL_SORTED_DESCENDING);
				this.adapter.setAttributeByHeaderCellIndex(columnIndex, strings$19.ARIA_SORT, SortValue.ASCENDING);
				sortValue = SortValue.ASCENDING;
			} else {
				this.adapter.setAttributeByHeaderCellIndex(columnIndex, strings$19.ARIA_SORT, SortValue.ASCENDING);
				sortValue = SortValue.ASCENDING;
			}
			this.adapter.setSortStatusLabelByHeaderCellIndex(columnIndex, sortValue);
			this.adapter.notifySortAction({
				columnId,
				columnIndex,
				headerCell,
				sortValue
			});
		};
		/**
		* Handles data table row click event.
		*/
		MDCDataTableFoundation.prototype.handleRowClick = function(_a) {
			var rowId = _a.rowId, row = _a.row;
			this.adapter.notifyRowClick({
				rowId,
				row
			});
		};
		/**
		* Shows progress indicator blocking only the table body content when in
		* loading state.
		*/
		MDCDataTableFoundation.prototype.showProgress = function() {
			var tableHeaderHeight = this.adapter.getTableHeaderHeight();
			var height = this.adapter.getTableContainerHeight() - tableHeaderHeight;
			var top = tableHeaderHeight;
			this.adapter.setProgressIndicatorStyles({
				height: height + "px",
				top: top + "px"
			});
			this.adapter.addClass(cssClasses$15.IN_PROGRESS);
		};
		/**
		* Hides progress indicator when data table is finished loading.
		*/
		MDCDataTableFoundation.prototype.hideProgress = function() {
			this.adapter.removeClass(cssClasses$15.IN_PROGRESS);
		};
		/**
		* Updates header row checkbox state based on number of rows selected.
		*/
		MDCDataTableFoundation.prototype.setHeaderRowCheckboxState = function() {
			if (this.adapter.getSelectedRowCount() === 0) {
				this.adapter.setHeaderRowCheckboxChecked(false);
				this.adapter.setHeaderRowCheckboxIndeterminate(false);
			} else if (this.adapter.getSelectedRowCount() === this.adapter.getRowCount()) {
				this.adapter.setHeaderRowCheckboxChecked(true);
				this.adapter.setHeaderRowCheckboxIndeterminate(false);
			} else {
				this.adapter.setHeaderRowCheckboxIndeterminate(true);
				this.adapter.setHeaderRowCheckboxChecked(false);
			}
		};
		/**
		* Sets the attributes of row element based on selection state.
		*/
		MDCDataTableFoundation.prototype.selectRowAtIndex = function(rowIndex, selected) {
			if (selected) {
				this.adapter.addClassAtRowIndex(rowIndex, cssClasses$15.ROW_SELECTED);
				this.adapter.setAttributeAtRowIndex(rowIndex, strings$19.ARIA_SELECTED, "true");
			} else {
				this.adapter.removeClassAtRowIndex(rowIndex, cssClasses$15.ROW_SELECTED);
				this.adapter.setAttributeAtRowIndex(rowIndex, strings$19.ARIA_SELECTED, "false");
			}
		};
		return MDCDataTableFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+data-table@14.0.0/node_modules/@material/data-table/component.js
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
	/**
	* Implementation of `MDCDataTableFoundation`
	*/
	var MDCDataTable = function(_super) {
		__extends(MDCDataTable, _super);
		function MDCDataTable() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCDataTable.attachTo = function(root) {
			return new MDCDataTable(root);
		};
		MDCDataTable.prototype.initialize = function(checkboxFactory) {
			if (checkboxFactory === void 0) checkboxFactory = function(el) {
				return new MDCCheckbox(el);
			};
			this.checkboxFactory = checkboxFactory;
		};
		MDCDataTable.prototype.initialSyncWithDOM = function() {
			var _this = this;
			this.headerRow = this.root.querySelector("." + cssClasses$15.HEADER_ROW);
			this.handleHeaderRowCheckboxChange = function() {
				_this.foundation.handleHeaderRowCheckboxChange();
			};
			this.headerRow.addEventListener("change", this.handleHeaderRowCheckboxChange);
			this.headerRowClickListener = function(event) {
				_this.handleHeaderRowClick(event);
			};
			this.headerRow.addEventListener("click", this.headerRowClickListener);
			this.content = this.root.querySelector("." + cssClasses$15.CONTENT);
			this.handleContentClick = function(event) {
				var dataRowEl = closest(event.target, selectors$1.ROW);
				if (!dataRowEl) return;
				_this.foundation.handleRowClick({
					rowId: _this.getRowIdByRowElement(dataRowEl),
					row: dataRowEl
				});
			};
			this.content.addEventListener("click", this.handleContentClick);
			this.handleRowCheckboxChange = function(event) {
				_this.foundation.handleRowCheckboxChange(event);
			};
			this.content.addEventListener("change", this.handleRowCheckboxChange);
			this.layout();
		};
		/**
		* Re-initializes header row checkbox and row checkboxes when selectable rows
		* are added or removed from table.
		*/
		MDCDataTable.prototype.layout = function() {
			this.foundation.layout();
		};
		/**
		* @return Returns array of header row cell elements.
		*/
		MDCDataTable.prototype.getHeaderCells = function() {
			return [].slice.call(this.root.querySelectorAll(selectors$1.HEADER_CELL));
		};
		/**
		* @return Returns array of row elements.
		*/
		MDCDataTable.prototype.getRows = function() {
			return this.foundation.getRows();
		};
		/**
		* @return Returns array of selected row ids.
		*/
		MDCDataTable.prototype.getSelectedRowIds = function() {
			return this.foundation.getSelectedRowIds();
		};
		/**
		* Sets selected row ids. Overwrites previously selected rows.
		* @param rowIds Array of row ids that needs to be selected.
		*/
		MDCDataTable.prototype.setSelectedRowIds = function(rowIds) {
			this.foundation.setSelectedRowIds(rowIds);
		};
		/**
		* Shows progress indicator when data table is in loading state.
		*/
		MDCDataTable.prototype.showProgress = function() {
			this.getLinearProgress().open();
			this.foundation.showProgress();
		};
		/**
		* Hides progress indicator after data table is finished loading.
		*/
		MDCDataTable.prototype.hideProgress = function() {
			this.foundation.hideProgress();
			this.getLinearProgress().close();
		};
		MDCDataTable.prototype.destroy = function() {
			var e_1, _a;
			if (this.handleHeaderRowCheckboxChange) this.headerRow.removeEventListener("change", this.handleHeaderRowCheckboxChange);
			if (this.headerRowClickListener) this.headerRow.removeEventListener("click", this.headerRowClickListener);
			if (this.handleRowCheckboxChange) this.content.removeEventListener("change", this.handleRowCheckboxChange);
			if (this.headerRowCheckbox) this.headerRowCheckbox.destroy();
			if (this.rowCheckboxList) try {
				for (var _b = __values(this.rowCheckboxList), _c = _b.next(); !_c.done; _c = _b.next()) _c.value.destroy();
			} catch (e_1_1) {
				e_1 = { error: e_1_1 };
			} finally {
				try {
					if (_c && !_c.done && (_a = _b.return)) _a.call(_b);
				} finally {
					if (e_1) throw e_1.error;
				}
			}
			if (this.handleContentClick) this.content.removeEventListener("click", this.handleContentClick);
		};
		MDCDataTable.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCDataTableFoundation({
				addClass: function(className) {
					_this.root.classList.add(className);
				},
				removeClass: function(className) {
					_this.root.classList.remove(className);
				},
				getHeaderCellElements: function() {
					return _this.getHeaderCells();
				},
				getHeaderCellCount: function() {
					return _this.getHeaderCells().length;
				},
				getAttributeByHeaderCellIndex: function(index, attribute) {
					return _this.getHeaderCells()[index].getAttribute(attribute);
				},
				setAttributeByHeaderCellIndex: function(index, attribute, value) {
					_this.getHeaderCells()[index].setAttribute(attribute, value);
				},
				setClassNameByHeaderCellIndex: function(index, className) {
					_this.getHeaderCells()[index].classList.add(className);
				},
				removeClassNameByHeaderCellIndex: function(index, className) {
					_this.getHeaderCells()[index].classList.remove(className);
				},
				notifySortAction: function(data) {
					_this.emit(
						events$4.SORTED,
						data,
						/** shouldBubble */
						true
					);
				},
				getTableContainerHeight: function() {
					var tableContainer = _this.root.querySelector("." + cssClasses$15.TABLE_CONTAINER);
					if (!tableContainer) throw new Error("MDCDataTable: Table container element not found.");
					return tableContainer.getBoundingClientRect().height;
				},
				getTableHeaderHeight: function() {
					var tableHeader = _this.root.querySelector(selectors$1.HEADER_ROW);
					if (!tableHeader) throw new Error("MDCDataTable: Table header element not found.");
					return tableHeader.getBoundingClientRect().height;
				},
				setProgressIndicatorStyles: function(styles) {
					var progressIndicator = _this.root.querySelector(selectors$1.PROGRESS_INDICATOR);
					if (!progressIndicator) throw new Error("MDCDataTable: Progress indicator element not found.");
					progressIndicator.style.setProperty("height", styles.height);
					progressIndicator.style.setProperty("top", styles.top);
				},
				addClassAtRowIndex: function(rowIndex, className) {
					_this.getRows()[rowIndex].classList.add(className);
				},
				getRowCount: function() {
					return _this.getRows().length;
				},
				getRowElements: function() {
					return [].slice.call(_this.root.querySelectorAll(selectors$1.ROW));
				},
				getRowIdAtIndex: function(rowIndex) {
					return _this.getRows()[rowIndex].getAttribute(dataAttributes.ROW_ID);
				},
				getRowIndexByChildElement: function(el) {
					return _this.getRows().indexOf(closest(el, selectors$1.ROW));
				},
				getSelectedRowCount: function() {
					return _this.root.querySelectorAll(selectors$1.ROW_SELECTED).length;
				},
				isCheckboxAtRowIndexChecked: function(rowIndex) {
					return _this.rowCheckboxList[rowIndex].checked;
				},
				isHeaderRowCheckboxChecked: function() {
					return _this.headerRowCheckbox.checked;
				},
				isRowsSelectable: function() {
					return !!_this.root.querySelector(selectors$1.ROW_CHECKBOX) || !!_this.root.querySelector(selectors$1.HEADER_ROW_CHECKBOX);
				},
				notifyRowSelectionChanged: function(data) {
					_this.emit(
						events$4.ROW_SELECTION_CHANGED,
						{
							row: _this.getRowByIndex(data.rowIndex),
							rowId: _this.getRowIdByIndex(data.rowIndex),
							rowIndex: data.rowIndex,
							selected: data.selected
						},
						/** shouldBubble */
						true
					);
				},
				notifySelectedAll: function() {
					_this.emit(
						events$4.SELECTED_ALL,
						{},
						/** shouldBubble */
						true
					);
				},
				notifyUnselectedAll: function() {
					_this.emit(
						events$4.UNSELECTED_ALL,
						{},
						/** shouldBubble */
						true
					);
				},
				notifyRowClick: function(data) {
					_this.emit(
						events$4.ROW_CLICK,
						data,
						/** shouldBubble */
						true
					);
				},
				registerHeaderRowCheckbox: function() {
					if (_this.headerRowCheckbox) _this.headerRowCheckbox.destroy();
					var checkboxEl = _this.root.querySelector(selectors$1.HEADER_ROW_CHECKBOX);
					_this.headerRowCheckbox = _this.checkboxFactory(checkboxEl);
				},
				registerRowCheckboxes: function() {
					if (_this.rowCheckboxList) _this.rowCheckboxList.forEach(function(checkbox) {
						checkbox.destroy();
					});
					_this.rowCheckboxList = [];
					_this.getRows().forEach(function(rowEl) {
						var checkbox = _this.checkboxFactory(rowEl.querySelector(selectors$1.ROW_CHECKBOX));
						_this.rowCheckboxList.push(checkbox);
					});
				},
				removeClassAtRowIndex: function(rowIndex, className) {
					_this.getRows()[rowIndex].classList.remove(className);
				},
				setAttributeAtRowIndex: function(rowIndex, attr, value) {
					_this.getRows()[rowIndex].setAttribute(attr, value);
				},
				setHeaderRowCheckboxChecked: function(checked) {
					_this.headerRowCheckbox.checked = checked;
				},
				setHeaderRowCheckboxIndeterminate: function(indeterminate) {
					_this.headerRowCheckbox.indeterminate = indeterminate;
				},
				setRowCheckboxCheckedAtIndex: function(rowIndex, checked) {
					_this.rowCheckboxList[rowIndex].checked = checked;
				},
				setSortStatusLabelByHeaderCellIndex: function(columnIndex, sortValue) {
					var sortStatusLabel = _this.getHeaderCells()[columnIndex].querySelector(selectors$1.SORT_STATUS_LABEL);
					if (!sortStatusLabel) return;
					sortStatusLabel.textContent = _this.getSortStatusMessageBySortValue(sortValue);
				}
			});
		};
		MDCDataTable.prototype.getRowByIndex = function(index) {
			return this.getRows()[index];
		};
		MDCDataTable.prototype.getRowIdByIndex = function(index) {
			return this.getRowByIndex(index).getAttribute(dataAttributes.ROW_ID);
		};
		MDCDataTable.prototype.handleHeaderRowClick = function(event) {
			var headerCell = closest(event.target, selectors$1.HEADER_CELL_WITH_SORT);
			if (!headerCell) return;
			var columnId = headerCell.getAttribute(dataAttributes.COLUMN_ID);
			var columnIndex = this.getHeaderCells().indexOf(headerCell);
			if (columnIndex === -1) return;
			this.foundation.handleSortAction({
				columnId,
				columnIndex,
				headerCell
			});
		};
		MDCDataTable.prototype.getSortStatusMessageBySortValue = function(sortValue) {
			switch (sortValue) {
				case SortValue.ASCENDING: return messages.SORTED_IN_ASCENDING;
				case SortValue.DESCENDING: return messages.SORTED_IN_DESCENDING;
				default: return "";
			}
		};
		MDCDataTable.prototype.getLinearProgressElement = function() {
			var el = this.root.querySelector("." + cssClasses$15.LINEAR_PROGRESS);
			if (!el) throw new Error("MDCDataTable: linear progress element is not found.");
			return el;
		};
		MDCDataTable.prototype.getLinearProgress = function() {
			if (!this.linearProgress) {
				var el = this.getLinearProgressElement();
				this.linearProgress = new MDCLinearProgress(el);
			}
			return this.linearProgress;
		};
		MDCDataTable.prototype.getRowIdByRowElement = function(rowElement) {
			return rowElement.getAttribute(dataAttributes.ROW_ID);
		};
		return MDCDataTable;
	}(MDCComponent);

//#endregion
//#region Components/DataTable/MBDataTable.ts
	var MBDataTable_exports = /* @__PURE__ */ __exportAll({
		init: () => init$19,
		setProgress: () => setProgress$1
	});
	function init$19(elem, hasProgress, showProgress) {
		if (!elem) return;
		elem._dataTable = MDCDataTable.attachTo(elem);
		if (hasProgress) setProgress$1(elem, showProgress);
	}
	function setProgress$1(elem, showProgress) {
		if (!elem) return;
		if (showProgress) elem._dataTable.showProgress();
		else elem._dataTable.hideProgress();
	}

//#endregion
//#region node_modules/.pnpm/@material+select@14.0.0/node_modules/@material/select/constants.js
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
	var cssClasses$14 = {
		ACTIVATED: "mdc-select--activated",
		DISABLED: "mdc-select--disabled",
		FOCUSED: "mdc-select--focused",
		INVALID: "mdc-select--invalid",
		MENU_INVALID: "mdc-select__menu--invalid",
		OUTLINED: "mdc-select--outlined",
		REQUIRED: "mdc-select--required",
		ROOT: "mdc-select",
		WITH_LEADING_ICON: "mdc-select--with-leading-icon"
	};
	var strings$18 = {
		ARIA_CONTROLS: "aria-controls",
		ARIA_DESCRIBEDBY: "aria-describedby",
		ARIA_SELECTED_ATTR: "aria-selected",
		CHANGE_EVENT: "MDCSelect:change",
		HIDDEN_INPUT_SELECTOR: "input[type=\"hidden\"]",
		LABEL_SELECTOR: ".mdc-floating-label",
		LEADING_ICON_SELECTOR: ".mdc-select__icon",
		LINE_RIPPLE_SELECTOR: ".mdc-line-ripple",
		MENU_SELECTOR: ".mdc-select__menu",
		OUTLINE_SELECTOR: ".mdc-notched-outline",
		SELECTED_TEXT_SELECTOR: ".mdc-select__selected-text",
		SELECT_ANCHOR_SELECTOR: ".mdc-select__anchor",
		VALUE_ATTR: "data-value"
	};
	var numbers$6 = {
		LABEL_SCALE: .75,
		UNSET_INDEX: -1,
		CLICK_DEBOUNCE_TIMEOUT_MS: 330
	};

//#endregion
//#region node_modules/.pnpm/@material+select@14.0.0/node_modules/@material/select/foundation.js
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
	var MDCSelectFoundation = function(_super) {
		__extends(MDCSelectFoundation, _super);
		/* istanbul ignore next: optional argument is not a branch statement */
		/**
		* @param adapter
		* @param foundationMap Map from subcomponent names to their subfoundations.
		*/
		function MDCSelectFoundation(adapter, foundationMap) {
			if (foundationMap === void 0) foundationMap = {};
			var _this = _super.call(this, __assign(__assign({}, MDCSelectFoundation.defaultAdapter), adapter)) || this;
			_this.disabled = false;
			_this.isMenuOpen = false;
			_this.useDefaultValidation = true;
			_this.customValidity = true;
			_this.lastSelectedIndex = numbers$6.UNSET_INDEX;
			_this.clickDebounceTimeout = 0;
			_this.recentlyClicked = false;
			_this.leadingIcon = foundationMap.leadingIcon;
			_this.helperText = foundationMap.helperText;
			return _this;
		}
		Object.defineProperty(MDCSelectFoundation, "cssClasses", {
			get: function() {
				return cssClasses$14;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSelectFoundation, "numbers", {
			get: function() {
				return numbers$6;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSelectFoundation, "strings", {
			get: function() {
				return strings$18;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSelectFoundation, "defaultAdapter", {
			/**
			* See {@link MDCSelectAdapter} for typing information on parameters and return types.
			*/
			get: function() {
				return {
					addClass: function() {},
					removeClass: function() {},
					hasClass: function() {
						return false;
					},
					activateBottomLine: function() {},
					deactivateBottomLine: function() {},
					getSelectedIndex: function() {
						return -1;
					},
					setSelectedIndex: function() {},
					hasLabel: function() {
						return false;
					},
					floatLabel: function() {},
					getLabelWidth: function() {
						return 0;
					},
					setLabelRequired: function() {},
					hasOutline: function() {
						return false;
					},
					notchOutline: function() {},
					closeOutline: function() {},
					setRippleCenter: function() {},
					notifyChange: function() {},
					setSelectedText: function() {},
					isSelectAnchorFocused: function() {
						return false;
					},
					getSelectAnchorAttr: function() {
						return "";
					},
					setSelectAnchorAttr: function() {},
					removeSelectAnchorAttr: function() {},
					addMenuClass: function() {},
					removeMenuClass: function() {},
					openMenu: function() {},
					closeMenu: function() {},
					getAnchorElement: function() {
						return null;
					},
					setMenuAnchorElement: function() {},
					setMenuAnchorCorner: function() {},
					setMenuWrapFocus: function() {},
					focusMenuItemAtIndex: function() {},
					getMenuItemCount: function() {
						return 0;
					},
					getMenuItemValues: function() {
						return [];
					},
					getMenuItemTextAtIndex: function() {
						return "";
					},
					isTypeaheadInProgress: function() {
						return false;
					},
					typeaheadMatchItem: function() {
						return -1;
					}
				};
			},
			enumerable: false,
			configurable: true
		});
		/** Returns the index of the currently selected menu item, or -1 if none. */
		MDCSelectFoundation.prototype.getSelectedIndex = function() {
			return this.adapter.getSelectedIndex();
		};
		MDCSelectFoundation.prototype.setSelectedIndex = function(index, closeMenu, skipNotify) {
			if (closeMenu === void 0) closeMenu = false;
			if (skipNotify === void 0) skipNotify = false;
			if (index >= this.adapter.getMenuItemCount()) return;
			if (index === numbers$6.UNSET_INDEX) this.adapter.setSelectedText("");
			else this.adapter.setSelectedText(this.adapter.getMenuItemTextAtIndex(index).trim());
			this.adapter.setSelectedIndex(index);
			if (closeMenu) this.adapter.closeMenu();
			if (!skipNotify && this.lastSelectedIndex !== index) this.handleChange();
			this.lastSelectedIndex = index;
		};
		MDCSelectFoundation.prototype.setValue = function(value, skipNotify) {
			if (skipNotify === void 0) skipNotify = false;
			var index = this.adapter.getMenuItemValues().indexOf(value);
			this.setSelectedIndex(
				index,
				/** closeMenu */
				false,
				skipNotify
			);
		};
		MDCSelectFoundation.prototype.getValue = function() {
			var index = this.adapter.getSelectedIndex();
			var menuItemValues = this.adapter.getMenuItemValues();
			return index !== numbers$6.UNSET_INDEX ? menuItemValues[index] : "";
		};
		MDCSelectFoundation.prototype.getDisabled = function() {
			return this.disabled;
		};
		MDCSelectFoundation.prototype.setDisabled = function(isDisabled) {
			this.disabled = isDisabled;
			if (this.disabled) {
				this.adapter.addClass(cssClasses$14.DISABLED);
				this.adapter.closeMenu();
			} else this.adapter.removeClass(cssClasses$14.DISABLED);
			if (this.leadingIcon) this.leadingIcon.setDisabled(this.disabled);
			if (this.disabled) this.adapter.removeSelectAnchorAttr("tabindex");
			else this.adapter.setSelectAnchorAttr("tabindex", "0");
			this.adapter.setSelectAnchorAttr("aria-disabled", this.disabled.toString());
		};
		/** Opens the menu. */
		MDCSelectFoundation.prototype.openMenu = function() {
			this.adapter.addClass(cssClasses$14.ACTIVATED);
			this.adapter.openMenu();
			this.isMenuOpen = true;
			this.adapter.setSelectAnchorAttr("aria-expanded", "true");
		};
		/**
		* @param content Sets the content of the helper text.
		*/
		MDCSelectFoundation.prototype.setHelperTextContent = function(content) {
			if (this.helperText) this.helperText.setContent(content);
		};
		/**
		* Re-calculates if the notched outline should be notched and if the label
		* should float.
		*/
		MDCSelectFoundation.prototype.layout = function() {
			if (this.adapter.hasLabel()) {
				var optionHasValue = this.getValue().length > 0;
				var isFocused = this.adapter.hasClass(cssClasses$14.FOCUSED);
				var shouldFloatAndNotch = optionHasValue || isFocused;
				var isRequired = this.adapter.hasClass(cssClasses$14.REQUIRED);
				this.notchOutline(shouldFloatAndNotch);
				this.adapter.floatLabel(shouldFloatAndNotch);
				this.adapter.setLabelRequired(isRequired);
			}
		};
		/**
		* Synchronizes the list of options with the state of the foundation. Call
		* this whenever menu options are dynamically updated.
		*/
		MDCSelectFoundation.prototype.layoutOptions = function() {
			var selectedIndex = this.adapter.getMenuItemValues().indexOf(this.getValue());
			this.setSelectedIndex(
				selectedIndex,
				/** closeMenu */
				false,
				/** skipNotify */
				true
			);
		};
		MDCSelectFoundation.prototype.handleMenuOpened = function() {
			if (this.adapter.getMenuItemValues().length === 0) return;
			var selectedIndex = this.getSelectedIndex();
			var focusItemIndex = selectedIndex >= 0 ? selectedIndex : 0;
			this.adapter.focusMenuItemAtIndex(focusItemIndex);
		};
		MDCSelectFoundation.prototype.handleMenuClosing = function() {
			this.adapter.setSelectAnchorAttr("aria-expanded", "false");
		};
		MDCSelectFoundation.prototype.handleMenuClosed = function() {
			this.adapter.removeClass(cssClasses$14.ACTIVATED);
			this.isMenuOpen = false;
			if (!this.adapter.isSelectAnchorFocused()) this.blur();
		};
		/**
		* Handles value changes, via change event or programmatic updates.
		*/
		MDCSelectFoundation.prototype.handleChange = function() {
			this.layout();
			this.adapter.notifyChange(this.getValue());
			if (this.adapter.hasClass(cssClasses$14.REQUIRED) && this.useDefaultValidation) this.setValid(this.isValid());
		};
		MDCSelectFoundation.prototype.handleMenuItemAction = function(index) {
			this.setSelectedIndex(
				index,
				/** closeMenu */
				true
			);
		};
		/**
		* Handles focus events from select element.
		*/
		MDCSelectFoundation.prototype.handleFocus = function() {
			this.adapter.addClass(cssClasses$14.FOCUSED);
			this.layout();
			this.adapter.activateBottomLine();
		};
		/**
		* Handles blur events from select element.
		*/
		MDCSelectFoundation.prototype.handleBlur = function() {
			if (this.isMenuOpen) return;
			this.blur();
		};
		MDCSelectFoundation.prototype.handleClick = function(normalizedX) {
			if (this.disabled || this.recentlyClicked) return;
			this.setClickDebounceTimeout();
			if (this.isMenuOpen) {
				this.adapter.closeMenu();
				return;
			}
			this.adapter.setRippleCenter(normalizedX);
			this.openMenu();
		};
		/**
		* Handles keydown events on select element. Depending on the type of
		* character typed, does typeahead matching or opens menu.
		*/
		MDCSelectFoundation.prototype.handleKeydown = function(event) {
			if (this.isMenuOpen || !this.adapter.hasClass(cssClasses$14.FOCUSED)) return;
			var isEnter = normalizeKey(event) === KEY.ENTER;
			var isSpace = normalizeKey(event) === KEY.SPACEBAR;
			var arrowUp = normalizeKey(event) === KEY.ARROW_UP;
			var arrowDown = normalizeKey(event) === KEY.ARROW_DOWN;
			if (!(event.ctrlKey || event.metaKey) && (!isSpace && event.key && event.key.length === 1 || isSpace && this.adapter.isTypeaheadInProgress())) {
				var key = isSpace ? " " : event.key;
				var typeaheadNextIndex = this.adapter.typeaheadMatchItem(key, this.getSelectedIndex());
				if (typeaheadNextIndex >= 0) this.setSelectedIndex(typeaheadNextIndex);
				event.preventDefault();
				return;
			}
			if (!isEnter && !isSpace && !arrowUp && !arrowDown) return;
			this.openMenu();
			event.preventDefault();
		};
		/**
		* Opens/closes the notched outline.
		*/
		MDCSelectFoundation.prototype.notchOutline = function(openNotch) {
			if (!this.adapter.hasOutline()) return;
			var isFocused = this.adapter.hasClass(cssClasses$14.FOCUSED);
			if (openNotch) {
				var labelScale = numbers$6.LABEL_SCALE;
				var labelWidth = this.adapter.getLabelWidth() * labelScale;
				this.adapter.notchOutline(labelWidth);
			} else if (!isFocused) this.adapter.closeOutline();
		};
		/**
		* Sets the aria label of the leading icon.
		*/
		MDCSelectFoundation.prototype.setLeadingIconAriaLabel = function(label) {
			if (this.leadingIcon) this.leadingIcon.setAriaLabel(label);
		};
		/**
		* Sets the text content of the leading icon.
		*/
		MDCSelectFoundation.prototype.setLeadingIconContent = function(content) {
			if (this.leadingIcon) this.leadingIcon.setContent(content);
		};
		MDCSelectFoundation.prototype.getUseDefaultValidation = function() {
			return this.useDefaultValidation;
		};
		MDCSelectFoundation.prototype.setUseDefaultValidation = function(useDefaultValidation) {
			this.useDefaultValidation = useDefaultValidation;
		};
		MDCSelectFoundation.prototype.setValid = function(isValid) {
			if (!this.useDefaultValidation) this.customValidity = isValid;
			this.adapter.setSelectAnchorAttr("aria-invalid", (!isValid).toString());
			if (isValid) {
				this.adapter.removeClass(cssClasses$14.INVALID);
				this.adapter.removeMenuClass(cssClasses$14.MENU_INVALID);
			} else {
				this.adapter.addClass(cssClasses$14.INVALID);
				this.adapter.addMenuClass(cssClasses$14.MENU_INVALID);
			}
			this.syncHelperTextValidity(isValid);
		};
		MDCSelectFoundation.prototype.isValid = function() {
			if (this.useDefaultValidation && this.adapter.hasClass(cssClasses$14.REQUIRED) && !this.adapter.hasClass(cssClasses$14.DISABLED)) return this.getSelectedIndex() !== numbers$6.UNSET_INDEX && (this.getSelectedIndex() !== 0 || Boolean(this.getValue()));
			return this.customValidity;
		};
		MDCSelectFoundation.prototype.setRequired = function(isRequired) {
			if (isRequired) this.adapter.addClass(cssClasses$14.REQUIRED);
			else this.adapter.removeClass(cssClasses$14.REQUIRED);
			this.adapter.setSelectAnchorAttr("aria-required", isRequired.toString());
			this.adapter.setLabelRequired(isRequired);
		};
		MDCSelectFoundation.prototype.getRequired = function() {
			return this.adapter.getSelectAnchorAttr("aria-required") === "true";
		};
		MDCSelectFoundation.prototype.init = function() {
			var anchorEl = this.adapter.getAnchorElement();
			if (anchorEl) {
				this.adapter.setMenuAnchorElement(anchorEl);
				this.adapter.setMenuAnchorCorner(Corner.BOTTOM_START);
			}
			this.adapter.setMenuWrapFocus(false);
			this.setDisabled(this.adapter.hasClass(cssClasses$14.DISABLED));
			this.syncHelperTextValidity(!this.adapter.hasClass(cssClasses$14.INVALID));
			this.layout();
			this.layoutOptions();
		};
		/**
		* Unfocuses the select component.
		*/
		MDCSelectFoundation.prototype.blur = function() {
			this.adapter.removeClass(cssClasses$14.FOCUSED);
			this.layout();
			this.adapter.deactivateBottomLine();
			if (this.adapter.hasClass(cssClasses$14.REQUIRED) && this.useDefaultValidation) this.setValid(this.isValid());
		};
		MDCSelectFoundation.prototype.syncHelperTextValidity = function(isValid) {
			if (!this.helperText) return;
			this.helperText.setValidity(isValid);
			var helperTextVisible = this.helperText.isVisible();
			var helperTextId = this.helperText.getId();
			if (helperTextVisible && helperTextId) this.adapter.setSelectAnchorAttr(strings$18.ARIA_DESCRIBEDBY, helperTextId);
			else this.adapter.removeSelectAnchorAttr(strings$18.ARIA_DESCRIBEDBY);
		};
		MDCSelectFoundation.prototype.setClickDebounceTimeout = function() {
			var _this = this;
			clearTimeout(this.clickDebounceTimeout);
			this.clickDebounceTimeout = setTimeout(function() {
				_this.recentlyClicked = false;
			}, numbers$6.CLICK_DEBOUNCE_TIMEOUT_MS);
			this.recentlyClicked = true;
		};
		return MDCSelectFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+select@14.0.0/node_modules/@material/select/helper-text/constants.js
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
	var strings$17 = {
		ARIA_HIDDEN: "aria-hidden",
		ROLE: "role"
	};
	var cssClasses$13 = {
		HELPER_TEXT_VALIDATION_MSG: "mdc-select-helper-text--validation-msg",
		HELPER_TEXT_VALIDATION_MSG_PERSISTENT: "mdc-select-helper-text--validation-msg-persistent"
	};

//#endregion
//#region node_modules/.pnpm/@material+select@14.0.0/node_modules/@material/select/helper-text/foundation.js
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
	var MDCSelectHelperTextFoundation = function(_super) {
		__extends(MDCSelectHelperTextFoundation, _super);
		function MDCSelectHelperTextFoundation(adapter) {
			return _super.call(this, __assign(__assign({}, MDCSelectHelperTextFoundation.defaultAdapter), adapter)) || this;
		}
		Object.defineProperty(MDCSelectHelperTextFoundation, "cssClasses", {
			get: function() {
				return cssClasses$13;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSelectHelperTextFoundation, "strings", {
			get: function() {
				return strings$17;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSelectHelperTextFoundation, "defaultAdapter", {
			/**
			* See {@link MDCSelectHelperTextAdapter} for typing information on parameters and return types.
			*/
			get: function() {
				return {
					addClass: function() {},
					removeClass: function() {},
					hasClass: function() {
						return false;
					},
					setAttr: function() {},
					getAttr: function() {
						return null;
					},
					removeAttr: function() {},
					setContent: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		/**
		* @return The ID of the helper text, or null if none is set.
		*/
		MDCSelectHelperTextFoundation.prototype.getId = function() {
			return this.adapter.getAttr("id");
		};
		/**
		* @return Whether the helper text is currently visible.
		*/
		MDCSelectHelperTextFoundation.prototype.isVisible = function() {
			return this.adapter.getAttr(strings$17.ARIA_HIDDEN) !== "true";
		};
		/**
		* Sets the content of the helper text field.
		*/
		MDCSelectHelperTextFoundation.prototype.setContent = function(content) {
			this.adapter.setContent(content);
		};
		/**
		* Sets the helper text to act as a validation message.
		* By default, validation messages are hidden when the select is valid and
		* visible when the select is invalid.
		*
		* @param isValidation True to make the helper text act as an error validation
		*     message.
		*/
		MDCSelectHelperTextFoundation.prototype.setValidation = function(isValidation) {
			if (isValidation) this.adapter.addClass(cssClasses$13.HELPER_TEXT_VALIDATION_MSG);
			else this.adapter.removeClass(cssClasses$13.HELPER_TEXT_VALIDATION_MSG);
		};
		/**
		* Sets the persistency of the validation helper text.
		* This keeps the validation message visible even if the select is valid,
		* though it will be displayed in the normal (grey) color.
		*/
		MDCSelectHelperTextFoundation.prototype.setValidationMsgPersistent = function(isPersistent) {
			if (isPersistent) this.adapter.addClass(cssClasses$13.HELPER_TEXT_VALIDATION_MSG_PERSISTENT);
			else this.adapter.removeClass(cssClasses$13.HELPER_TEXT_VALIDATION_MSG_PERSISTENT);
		};
		/**
		* @return Whether the helper text acts as a validation message.
		* By default, validation messages are hidden when the select is valid and
		* visible when the select is invalid.
		*/
		MDCSelectHelperTextFoundation.prototype.getIsValidation = function() {
			return this.adapter.hasClass(cssClasses$13.HELPER_TEXT_VALIDATION_MSG);
		};
		/**
		* @return Whether the validation helper text persists even if the input is
		* valid. If it is, it will be displayed in the normal (grey) color.
		*/
		MDCSelectHelperTextFoundation.prototype.getIsValidationMsgPersistent = function() {
			return this.adapter.hasClass(cssClasses$13.HELPER_TEXT_VALIDATION_MSG_PERSISTENT);
		};
		/**
		* When acting as a validation message, shows/hides the helper text and
		* triggers alerts as necessary based on the select's validity.
		*/
		MDCSelectHelperTextFoundation.prototype.setValidity = function(selectIsValid) {
			if (!this.adapter.hasClass(cssClasses$13.HELPER_TEXT_VALIDATION_MSG)) return;
			var isPersistentValidationMsg = this.adapter.hasClass(cssClasses$13.HELPER_TEXT_VALIDATION_MSG_PERSISTENT);
			if (!selectIsValid || isPersistentValidationMsg) {
				this.showToScreenReader();
				if (!selectIsValid) this.adapter.setAttr(strings$17.ROLE, "alert");
				else this.adapter.removeAttr(strings$17.ROLE);
				return;
			}
			this.adapter.removeAttr(strings$17.ROLE);
			this.hide();
		};
		/**
		* Makes the helper text visible to screen readers.
		*/
		MDCSelectHelperTextFoundation.prototype.showToScreenReader = function() {
			this.adapter.removeAttr(strings$17.ARIA_HIDDEN);
		};
		/**
		* Hides the help text from screen readers.
		*/
		MDCSelectHelperTextFoundation.prototype.hide = function() {
			this.adapter.setAttr(strings$17.ARIA_HIDDEN, "true");
		};
		return MDCSelectHelperTextFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+select@14.0.0/node_modules/@material/select/helper-text/component.js
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
	var MDCSelectHelperText = function(_super) {
		__extends(MDCSelectHelperText, _super);
		function MDCSelectHelperText() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCSelectHelperText.attachTo = function(root) {
			return new MDCSelectHelperText(root);
		};
		Object.defineProperty(MDCSelectHelperText.prototype, "foundationForSelect", {
			get: function() {
				return this.foundation;
			},
			enumerable: false,
			configurable: true
		});
		MDCSelectHelperText.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCSelectHelperTextFoundation({
				addClass: function(className) {
					return _this.root.classList.add(className);
				},
				removeClass: function(className) {
					return _this.root.classList.remove(className);
				},
				hasClass: function(className) {
					return _this.root.classList.contains(className);
				},
				getAttr: function(attr) {
					return _this.root.getAttribute(attr);
				},
				setAttr: function(attr, value) {
					return _this.root.setAttribute(attr, value);
				},
				removeAttr: function(attr) {
					return _this.root.removeAttribute(attr);
				},
				setContent: function(content) {
					_this.root.textContent = content;
				}
			});
		};
		return MDCSelectHelperText;
	}(MDCComponent);

//#endregion
//#region node_modules/.pnpm/@material+select@14.0.0/node_modules/@material/select/icon/constants.js
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
	var strings$16 = {
		ICON_EVENT: "MDCSelect:icon",
		ICON_ROLE: "button"
	};

//#endregion
//#region node_modules/.pnpm/@material+select@14.0.0/node_modules/@material/select/icon/foundation.js
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
	var INTERACTION_EVENTS = ["click", "keydown"];
	var MDCSelectIconFoundation = function(_super) {
		__extends(MDCSelectIconFoundation, _super);
		function MDCSelectIconFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCSelectIconFoundation.defaultAdapter), adapter)) || this;
			_this.savedTabIndex = null;
			_this.interactionHandler = function(evt) {
				_this.handleInteraction(evt);
			};
			return _this;
		}
		Object.defineProperty(MDCSelectIconFoundation, "strings", {
			get: function() {
				return strings$16;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSelectIconFoundation, "defaultAdapter", {
			/**
			* See {@link MDCSelectIconAdapter} for typing information on parameters and return types.
			*/
			get: function() {
				return {
					getAttr: function() {
						return null;
					},
					setAttr: function() {},
					removeAttr: function() {},
					setContent: function() {},
					registerInteractionHandler: function() {},
					deregisterInteractionHandler: function() {},
					notifyIconAction: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCSelectIconFoundation.prototype.init = function() {
			var e_1, _a;
			this.savedTabIndex = this.adapter.getAttr("tabindex");
			try {
				for (var INTERACTION_EVENTS_1 = __values(INTERACTION_EVENTS), INTERACTION_EVENTS_1_1 = INTERACTION_EVENTS_1.next(); !INTERACTION_EVENTS_1_1.done; INTERACTION_EVENTS_1_1 = INTERACTION_EVENTS_1.next()) {
					var evtType = INTERACTION_EVENTS_1_1.value;
					this.adapter.registerInteractionHandler(evtType, this.interactionHandler);
				}
			} catch (e_1_1) {
				e_1 = { error: e_1_1 };
			} finally {
				try {
					if (INTERACTION_EVENTS_1_1 && !INTERACTION_EVENTS_1_1.done && (_a = INTERACTION_EVENTS_1.return)) _a.call(INTERACTION_EVENTS_1);
				} finally {
					if (e_1) throw e_1.error;
				}
			}
		};
		MDCSelectIconFoundation.prototype.destroy = function() {
			var e_2, _a;
			try {
				for (var INTERACTION_EVENTS_2 = __values(INTERACTION_EVENTS), INTERACTION_EVENTS_2_1 = INTERACTION_EVENTS_2.next(); !INTERACTION_EVENTS_2_1.done; INTERACTION_EVENTS_2_1 = INTERACTION_EVENTS_2.next()) {
					var evtType = INTERACTION_EVENTS_2_1.value;
					this.adapter.deregisterInteractionHandler(evtType, this.interactionHandler);
				}
			} catch (e_2_1) {
				e_2 = { error: e_2_1 };
			} finally {
				try {
					if (INTERACTION_EVENTS_2_1 && !INTERACTION_EVENTS_2_1.done && (_a = INTERACTION_EVENTS_2.return)) _a.call(INTERACTION_EVENTS_2);
				} finally {
					if (e_2) throw e_2.error;
				}
			}
		};
		MDCSelectIconFoundation.prototype.setDisabled = function(disabled) {
			if (!this.savedTabIndex) return;
			if (disabled) {
				this.adapter.setAttr("tabindex", "-1");
				this.adapter.removeAttr("role");
			} else {
				this.adapter.setAttr("tabindex", this.savedTabIndex);
				this.adapter.setAttr("role", strings$16.ICON_ROLE);
			}
		};
		MDCSelectIconFoundation.prototype.setAriaLabel = function(label) {
			this.adapter.setAttr("aria-label", label);
		};
		MDCSelectIconFoundation.prototype.setContent = function(content) {
			this.adapter.setContent(content);
		};
		MDCSelectIconFoundation.prototype.handleInteraction = function(evt) {
			var isEnterKey = evt.key === "Enter" || evt.keyCode === 13;
			if (evt.type === "click" || isEnterKey) this.adapter.notifyIconAction();
		};
		return MDCSelectIconFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+select@14.0.0/node_modules/@material/select/icon/component.js
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
	var MDCSelectIcon = function(_super) {
		__extends(MDCSelectIcon, _super);
		function MDCSelectIcon() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCSelectIcon.attachTo = function(root) {
			return new MDCSelectIcon(root);
		};
		Object.defineProperty(MDCSelectIcon.prototype, "foundationForSelect", {
			get: function() {
				return this.foundation;
			},
			enumerable: false,
			configurable: true
		});
		MDCSelectIcon.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCSelectIconFoundation({
				getAttr: function(attr) {
					return _this.root.getAttribute(attr);
				},
				setAttr: function(attr, value) {
					return _this.root.setAttribute(attr, value);
				},
				removeAttr: function(attr) {
					return _this.root.removeAttribute(attr);
				},
				setContent: function(content) {
					_this.root.textContent = content;
				},
				registerInteractionHandler: function(evtType, handler) {
					return _this.listen(evtType, handler);
				},
				deregisterInteractionHandler: function(evtType, handler) {
					return _this.unlisten(evtType, handler);
				},
				notifyIconAction: function() {
					return _this.emit(MDCSelectIconFoundation.strings.ICON_EVENT, {}, true);
				}
			});
		};
		return MDCSelectIcon;
	}(MDCComponent);

//#endregion
//#region node_modules/.pnpm/@material+select@14.0.0/node_modules/@material/select/component.js
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
	var MDCSelect = function(_super) {
		__extends(MDCSelect, _super);
		function MDCSelect() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCSelect.attachTo = function(root) {
			return new MDCSelect(root);
		};
		MDCSelect.prototype.initialize = function(labelFactory, lineRippleFactory, outlineFactory, menuFactory, iconFactory, helperTextFactory) {
			if (labelFactory === void 0) labelFactory = function(el) {
				return new MDCFloatingLabel(el);
			};
			if (lineRippleFactory === void 0) lineRippleFactory = function(el) {
				return new MDCLineRipple(el);
			};
			if (outlineFactory === void 0) outlineFactory = function(el) {
				return new MDCNotchedOutline(el);
			};
			if (menuFactory === void 0) menuFactory = function(el) {
				return new MDCMenu(el);
			};
			if (iconFactory === void 0) iconFactory = function(el) {
				return new MDCSelectIcon(el);
			};
			if (helperTextFactory === void 0) helperTextFactory = function(el) {
				return new MDCSelectHelperText(el);
			};
			this.selectAnchor = this.root.querySelector(strings$18.SELECT_ANCHOR_SELECTOR);
			this.selectedText = this.root.querySelector(strings$18.SELECTED_TEXT_SELECTOR);
			this.hiddenInput = this.root.querySelector(strings$18.HIDDEN_INPUT_SELECTOR);
			if (!this.selectedText) throw new Error("MDCSelect: Missing required element: The following selector must be present: " + ("'" + strings$18.SELECTED_TEXT_SELECTOR + "'"));
			if (this.selectAnchor.hasAttribute(strings$18.ARIA_CONTROLS)) {
				var helperTextElement = document.getElementById(this.selectAnchor.getAttribute(strings$18.ARIA_CONTROLS));
				if (helperTextElement) this.helperText = helperTextFactory(helperTextElement);
			}
			this.menuSetup(menuFactory);
			var labelElement = this.root.querySelector(strings$18.LABEL_SELECTOR);
			this.label = labelElement ? labelFactory(labelElement) : null;
			var lineRippleElement = this.root.querySelector(strings$18.LINE_RIPPLE_SELECTOR);
			this.lineRipple = lineRippleElement ? lineRippleFactory(lineRippleElement) : null;
			var outlineElement = this.root.querySelector(strings$18.OUTLINE_SELECTOR);
			this.outline = outlineElement ? outlineFactory(outlineElement) : null;
			var leadingIcon = this.root.querySelector(strings$18.LEADING_ICON_SELECTOR);
			if (leadingIcon) this.leadingIcon = iconFactory(leadingIcon);
			if (!this.root.classList.contains(cssClasses$14.OUTLINED)) this.ripple = this.createRipple();
		};
		/**
		* Initializes the select's event listeners and internal state based
		* on the environment's state.
		*/
		MDCSelect.prototype.initialSyncWithDOM = function() {
			var _this = this;
			this.handleFocus = function() {
				_this.foundation.handleFocus();
			};
			this.handleBlur = function() {
				_this.foundation.handleBlur();
			};
			this.handleClick = function(evt) {
				_this.selectAnchor.focus();
				_this.foundation.handleClick(_this.getNormalizedXCoordinate(evt));
			};
			this.handleKeydown = function(evt) {
				_this.foundation.handleKeydown(evt);
			};
			this.handleMenuItemAction = function(evt) {
				_this.foundation.handleMenuItemAction(evt.detail.index);
			};
			this.handleMenuOpened = function() {
				_this.foundation.handleMenuOpened();
			};
			this.handleMenuClosed = function() {
				_this.foundation.handleMenuClosed();
			};
			this.handleMenuClosing = function() {
				_this.foundation.handleMenuClosing();
			};
			this.selectAnchor.addEventListener("focus", this.handleFocus);
			this.selectAnchor.addEventListener("blur", this.handleBlur);
			this.selectAnchor.addEventListener("click", this.handleClick);
			this.selectAnchor.addEventListener("keydown", this.handleKeydown);
			this.menu.listen(strings$26.CLOSED_EVENT, this.handleMenuClosed);
			this.menu.listen(strings$26.CLOSING_EVENT, this.handleMenuClosing);
			this.menu.listen(strings$26.OPENED_EVENT, this.handleMenuOpened);
			this.menu.listen(strings$24.SELECTED_EVENT, this.handleMenuItemAction);
			if (this.hiddenInput) {
				if (this.hiddenInput.value) {
					this.foundation.setValue(
						this.hiddenInput.value,
						/** skipNotify */
						true
					);
					this.foundation.layout();
					return;
				}
				this.hiddenInput.value = this.value;
			}
		};
		MDCSelect.prototype.destroy = function() {
			this.selectAnchor.removeEventListener("focus", this.handleFocus);
			this.selectAnchor.removeEventListener("blur", this.handleBlur);
			this.selectAnchor.removeEventListener("keydown", this.handleKeydown);
			this.selectAnchor.removeEventListener("click", this.handleClick);
			this.menu.unlisten(strings$26.CLOSED_EVENT, this.handleMenuClosed);
			this.menu.unlisten(strings$26.OPENED_EVENT, this.handleMenuOpened);
			this.menu.unlisten(strings$24.SELECTED_EVENT, this.handleMenuItemAction);
			this.menu.destroy();
			if (this.ripple) this.ripple.destroy();
			if (this.outline) this.outline.destroy();
			if (this.leadingIcon) this.leadingIcon.destroy();
			if (this.helperText) this.helperText.destroy();
			_super.prototype.destroy.call(this);
		};
		Object.defineProperty(MDCSelect.prototype, "value", {
			get: function() {
				return this.foundation.getValue();
			},
			set: function(value) {
				this.foundation.setValue(value);
			},
			enumerable: false,
			configurable: true
		});
		MDCSelect.prototype.setValue = function(value, skipNotify) {
			if (skipNotify === void 0) skipNotify = false;
			this.foundation.setValue(value, skipNotify);
		};
		Object.defineProperty(MDCSelect.prototype, "selectedIndex", {
			get: function() {
				return this.foundation.getSelectedIndex();
			},
			set: function(selectedIndex) {
				this.foundation.setSelectedIndex(selectedIndex, true);
			},
			enumerable: false,
			configurable: true
		});
		MDCSelect.prototype.setSelectedIndex = function(selectedIndex, skipNotify) {
			if (skipNotify === void 0) skipNotify = false;
			this.foundation.setSelectedIndex(selectedIndex, true, skipNotify);
		};
		Object.defineProperty(MDCSelect.prototype, "disabled", {
			get: function() {
				return this.foundation.getDisabled();
			},
			set: function(disabled) {
				this.foundation.setDisabled(disabled);
				if (this.hiddenInput) this.hiddenInput.disabled = disabled;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSelect.prototype, "leadingIconAriaLabel", {
			set: function(label) {
				this.foundation.setLeadingIconAriaLabel(label);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSelect.prototype, "leadingIconContent", {
			/**
			* Sets the text content of the leading icon.
			*/
			set: function(content) {
				this.foundation.setLeadingIconContent(content);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSelect.prototype, "helperTextContent", {
			/**
			* Sets the text content of the helper text.
			*/
			set: function(content) {
				this.foundation.setHelperTextContent(content);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSelect.prototype, "useDefaultValidation", {
			/**
			* Enables or disables the default validation scheme where a required select
			* must be non-empty. Set to false for custom validation.
			* @param useDefaultValidation Set this to false to ignore default
			*     validation scheme.
			*/
			set: function(useDefaultValidation) {
				this.foundation.setUseDefaultValidation(useDefaultValidation);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSelect.prototype, "valid", {
			/**
			* Checks if the select is in a valid state.
			*/
			get: function() {
				return this.foundation.isValid();
			},
			/**
			* Sets the current invalid state of the select.
			*/
			set: function(isValid) {
				this.foundation.setValid(isValid);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSelect.prototype, "required", {
			/**
			* Returns whether the select is required.
			*/
			get: function() {
				return this.foundation.getRequired();
			},
			/**
			* Sets the control to the required state.
			*/
			set: function(isRequired) {
				this.foundation.setRequired(isRequired);
			},
			enumerable: false,
			configurable: true
		});
		/**
		* Re-calculates if the notched outline should be notched and if the label
		* should float.
		*/
		MDCSelect.prototype.layout = function() {
			this.foundation.layout();
		};
		/**
		* Synchronizes the list of options with the state of the foundation. Call
		* this whenever menu options are dynamically updated.
		*/
		MDCSelect.prototype.layoutOptions = function() {
			this.foundation.layoutOptions();
			this.menu.layout();
			this.menuItemValues = this.menu.items.map(function(el) {
				return el.getAttribute(strings$18.VALUE_ATTR) || "";
			});
			if (this.hiddenInput) this.hiddenInput.value = this.value;
		};
		MDCSelect.prototype.getDefaultFoundation = function() {
			return new MDCSelectFoundation(__assign(__assign(__assign(__assign({}, this.getSelectAdapterMethods()), this.getCommonAdapterMethods()), this.getOutlineAdapterMethods()), this.getLabelAdapterMethods()), this.getFoundationMap());
		};
		/**
		* Handles setup for the menu.
		*/
		MDCSelect.prototype.menuSetup = function(menuFactory) {
			this.menuElement = this.root.querySelector(strings$18.MENU_SELECTOR);
			this.menu = menuFactory(this.menuElement);
			this.menu.hasTypeahead = true;
			this.menu.singleSelection = true;
			this.menuItemValues = this.menu.items.map(function(el) {
				return el.getAttribute(strings$18.VALUE_ATTR) || "";
			});
		};
		MDCSelect.prototype.createRipple = function() {
			var _this = this;
			var adapter = __assign(__assign({}, MDCRipple.createAdapter({ root: this.selectAnchor })), {
				registerInteractionHandler: function(evtType, handler) {
					_this.selectAnchor.addEventListener(evtType, handler);
				},
				deregisterInteractionHandler: function(evtType, handler) {
					_this.selectAnchor.removeEventListener(evtType, handler);
				}
			});
			return new MDCRipple(this.selectAnchor, new MDCRippleFoundation(adapter));
		};
		MDCSelect.prototype.getSelectAdapterMethods = function() {
			var _this = this;
			return {
				getMenuItemAttr: function(menuItem, attr) {
					return menuItem.getAttribute(attr);
				},
				setSelectedText: function(text) {
					_this.selectedText.textContent = text;
				},
				isSelectAnchorFocused: function() {
					return document.activeElement === _this.selectAnchor;
				},
				getSelectAnchorAttr: function(attr) {
					return _this.selectAnchor.getAttribute(attr);
				},
				setSelectAnchorAttr: function(attr, value) {
					_this.selectAnchor.setAttribute(attr, value);
				},
				removeSelectAnchorAttr: function(attr) {
					_this.selectAnchor.removeAttribute(attr);
				},
				addMenuClass: function(className) {
					_this.menuElement.classList.add(className);
				},
				removeMenuClass: function(className) {
					_this.menuElement.classList.remove(className);
				},
				openMenu: function() {
					_this.menu.open = true;
				},
				closeMenu: function() {
					_this.menu.open = false;
				},
				getAnchorElement: function() {
					return _this.root.querySelector(strings$18.SELECT_ANCHOR_SELECTOR);
				},
				setMenuAnchorElement: function(anchorEl) {
					_this.menu.setAnchorElement(anchorEl);
				},
				setMenuAnchorCorner: function(anchorCorner) {
					_this.menu.setAnchorCorner(anchorCorner);
				},
				setMenuWrapFocus: function(wrapFocus) {
					_this.menu.wrapFocus = wrapFocus;
				},
				getSelectedIndex: function() {
					var index = _this.menu.selectedIndex;
					return index instanceof Array ? index[0] : index;
				},
				setSelectedIndex: function(index) {
					_this.menu.selectedIndex = index;
				},
				focusMenuItemAtIndex: function(index) {
					_this.menu.items[index].focus();
				},
				getMenuItemCount: function() {
					return _this.menu.items.length;
				},
				getMenuItemValues: function() {
					return _this.menuItemValues;
				},
				getMenuItemTextAtIndex: function(index) {
					return _this.menu.getPrimaryTextAtIndex(index);
				},
				isTypeaheadInProgress: function() {
					return _this.menu.typeaheadInProgress;
				},
				typeaheadMatchItem: function(nextChar, startingIndex) {
					return _this.menu.typeaheadMatchItem(nextChar, startingIndex);
				}
			};
		};
		MDCSelect.prototype.getCommonAdapterMethods = function() {
			var _this = this;
			return {
				addClass: function(className) {
					_this.root.classList.add(className);
				},
				removeClass: function(className) {
					_this.root.classList.remove(className);
				},
				hasClass: function(className) {
					return _this.root.classList.contains(className);
				},
				setRippleCenter: function(normalizedX) {
					_this.lineRipple && _this.lineRipple.setRippleCenter(normalizedX);
				},
				activateBottomLine: function() {
					_this.lineRipple && _this.lineRipple.activate();
				},
				deactivateBottomLine: function() {
					_this.lineRipple && _this.lineRipple.deactivate();
				},
				notifyChange: function(value) {
					if (_this.hiddenInput) _this.hiddenInput.value = value;
					var index = _this.selectedIndex;
					_this.emit(strings$18.CHANGE_EVENT, {
						value,
						index
					}, true);
				}
			};
		};
		MDCSelect.prototype.getOutlineAdapterMethods = function() {
			var _this = this;
			return {
				hasOutline: function() {
					return Boolean(_this.outline);
				},
				notchOutline: function(labelWidth) {
					_this.outline && _this.outline.notch(labelWidth);
				},
				closeOutline: function() {
					_this.outline && _this.outline.closeNotch();
				}
			};
		};
		MDCSelect.prototype.getLabelAdapterMethods = function() {
			var _this = this;
			return {
				hasLabel: function() {
					return !!_this.label;
				},
				floatLabel: function(shouldFloat) {
					_this.label && _this.label.float(shouldFloat);
				},
				getLabelWidth: function() {
					return _this.label ? _this.label.getWidth() : 0;
				},
				setLabelRequired: function(isRequired) {
					_this.label && _this.label.setRequired(isRequired);
				}
			};
		};
		/**
		* Calculates where the line ripple should start based on the x coordinate within the component.
		*/
		MDCSelect.prototype.getNormalizedXCoordinate = function(evt) {
			var targetClientRect = evt.target.getBoundingClientRect();
			return (this.isTouchEvent(evt) ? evt.touches[0].clientX : evt.clientX) - targetClientRect.left;
		};
		MDCSelect.prototype.isTouchEvent = function(evt) {
			return Boolean(evt.touches);
		};
		/**
		* Returns a map of all subcomponents to subfoundations.
		*/
		MDCSelect.prototype.getFoundationMap = function() {
			return {
				helperText: this.helperText ? this.helperText.foundationForSelect : void 0,
				leadingIcon: this.leadingIcon ? this.leadingIcon.foundationForSelect : void 0
			};
		};
		return MDCSelect;
	}(MDCComponent);

//#endregion
//#region Components/DatePicker/MBDatePicker.ts
	var MBDatePicker_exports = /* @__PURE__ */ __exportAll({
		init: () => init$18,
		listItemClick: () => listItemClick,
		scrollToYear: () => scrollToYear,
		setDisabled: () => setDisabled$6
	});
	function init$18(elem, menuSurfaceElem, dotNetObject) {
		if (!elem || !menuSurfaceElem) return;
		elem._select = MDCSelect.attachTo(elem);
		elem._menuSurface = MDCMenuSurface.attachTo(menuSurfaceElem);
		const openCallback = () => {
			elem._menuSurface.unlisten("MDCMenuSurface:opened", openCallback);
			dotNetObject.invokeMethodAsync("NotifyOpened");
		};
		elem._menuSurface.listen("MDCMenuSurface:opened", openCallback);
	}
	function setDisabled$6(elem, value) {
		if (!elem) return;
		elem._select.disabled = value;
	}
	function listItemClick(elem, elemText) {
		if (!elem) return;
		elem.innerText = elemText;
		elem.click();
	}
	function tryScrollToYear(id, attempt) {
		setTimeout(() => {
			var element = document.getElementById(id);
			if (element) element.scrollIntoView({
				behavior: "auto",
				block: "nearest",
				inline: "nearest"
			});
			else if (attempt < 10) tryScrollToYear(id, attempt + 1);
		}, 16);
	}
	function scrollToYear(id) {
		tryScrollToYear(id, 0);
	}

//#endregion
//#region node_modules/.pnpm/@material+dialog@14.0.0/node_modules/@material/dialog/util.js
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
	function createFocusTrapInstance$1(surfaceEl, focusTrapFactory, initialFocusEl) {
		return focusTrapFactory(surfaceEl, { initialFocusEl });
	}
	function isScrollable(el) {
		return el ? el.scrollHeight > el.offsetHeight : false;
	}
	/**
	* For scrollable content, returns true if the content has not been scrolled
	* (that is, the scroll content is as the "top"). This is used in full-screen
	* dialogs, where the scroll divider is expected only to appear once the
	* content has been scrolled "underneath" the header bar.
	*/
	function isScrollAtTop(el) {
		return el ? el.scrollTop === 0 : false;
	}
	/**
	* For scrollable content, returns true if the content has been scrolled all the
	* way to the bottom. This is used in full-screen dialogs, where the footer
	* scroll divider is expected only to appear when the content is "cut-off" by
	* the footer bar.
	*/
	function isScrollAtBottom(el) {
		return el ? Math.ceil(el.scrollHeight - el.scrollTop) === el.clientHeight : false;
	}
	function areTopsMisaligned(els) {
		var tops = /* @__PURE__ */ new Set();
		[].forEach.call(els, function(el) {
			return tops.add(el.offsetTop);
		});
		return tops.size > 1;
	}

//#endregion
//#region node_modules/.pnpm/@material+dom@14.0.0/node_modules/@material/dom/focus-trap.js
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
	var FOCUS_SENTINEL_CLASS = "mdc-dom-focus-sentinel";
	/**
	* Utility to trap focus in a given root element, e.g. for modal components such
	* as dialogs. The root should have at least one focusable child element,
	* for setting initial focus when trapping focus.
	* Also tracks the previously focused element, and restores focus to that
	* element when releasing focus.
	*/
	var FocusTrap = function() {
		function FocusTrap(root, options) {
			if (options === void 0) options = {};
			this.root = root;
			this.options = options;
			this.elFocusedBeforeTrapFocus = null;
		}
		/**
		* Traps focus in `root`. Also focuses on either `initialFocusEl` if set;
		* otherwises sets initial focus to the first focusable child element.
		*/
		FocusTrap.prototype.trapFocus = function() {
			var focusableEls = this.getFocusableElements(this.root);
			if (focusableEls.length === 0) throw new Error("FocusTrap: Element must have at least one focusable child.");
			this.elFocusedBeforeTrapFocus = document.activeElement instanceof HTMLElement ? document.activeElement : null;
			this.wrapTabFocus(this.root);
			if (!this.options.skipInitialFocus) this.focusInitialElement(focusableEls, this.options.initialFocusEl);
		};
		/**
		* Releases focus from `root`. Also restores focus to the previously focused
		* element.
		*/
		FocusTrap.prototype.releaseFocus = function() {
			[].slice.call(this.root.querySelectorAll(".mdc-dom-focus-sentinel")).forEach(function(sentinelEl) {
				sentinelEl.parentElement.removeChild(sentinelEl);
			});
			if (!this.options.skipRestoreFocus && this.elFocusedBeforeTrapFocus) this.elFocusedBeforeTrapFocus.focus();
		};
		/**
		* Wraps tab focus within `el` by adding two hidden sentinel divs which are
		* used to mark the beginning and the end of the tabbable region. When
		* focused, these sentinel elements redirect focus to the first/last
		* children elements of the tabbable region, ensuring that focus is trapped
		* within that region.
		*/
		FocusTrap.prototype.wrapTabFocus = function(el) {
			var _this = this;
			var sentinelStart = this.createSentinel();
			var sentinelEnd = this.createSentinel();
			sentinelStart.addEventListener("focus", function() {
				var focusableEls = _this.getFocusableElements(el);
				if (focusableEls.length > 0) focusableEls[focusableEls.length - 1].focus();
			});
			sentinelEnd.addEventListener("focus", function() {
				var focusableEls = _this.getFocusableElements(el);
				if (focusableEls.length > 0) focusableEls[0].focus();
			});
			el.insertBefore(sentinelStart, el.children[0]);
			el.appendChild(sentinelEnd);
		};
		/**
		* Focuses on `initialFocusEl` if defined and a child of the root element.
		* Otherwise, focuses on the first focusable child element of the root.
		*/
		FocusTrap.prototype.focusInitialElement = function(focusableEls, initialFocusEl) {
			var focusIndex = 0;
			if (initialFocusEl) focusIndex = Math.max(focusableEls.indexOf(initialFocusEl), 0);
			focusableEls[focusIndex].focus();
		};
		FocusTrap.prototype.getFocusableElements = function(root) {
			return [].slice.call(root.querySelectorAll("[autofocus], [tabindex], a, input, textarea, select, button")).filter(function(el) {
				var isDisabledOrHidden = el.getAttribute("aria-disabled") === "true" || el.getAttribute("disabled") != null || el.getAttribute("hidden") != null || el.getAttribute("aria-hidden") === "true";
				var isTabbableAndVisible = el.tabIndex >= 0 && el.getBoundingClientRect().width > 0 && !el.classList.contains(FOCUS_SENTINEL_CLASS) && !isDisabledOrHidden;
				var isProgrammaticallyHidden = false;
				if (isTabbableAndVisible) {
					var style = getComputedStyle(el);
					isProgrammaticallyHidden = style.display === "none" || style.visibility === "hidden";
				}
				return isTabbableAndVisible && !isProgrammaticallyHidden;
			});
		};
		FocusTrap.prototype.createSentinel = function() {
			var sentinel = document.createElement("div");
			sentinel.setAttribute("tabindex", "0");
			sentinel.setAttribute("aria-hidden", "true");
			sentinel.classList.add(FOCUS_SENTINEL_CLASS);
			return sentinel;
		};
		return FocusTrap;
	}();

//#endregion
//#region node_modules/.pnpm/@material+animation@14.0.0/node_modules/@material/animation/animationframe.js
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
	/**
	* AnimationFrame provides a user-friendly abstraction around requesting
	* and canceling animation frames.
	*/
	var AnimationFrame = function() {
		function AnimationFrame() {
			this.rafIDs = /* @__PURE__ */ new Map();
		}
		/**
		* Requests an animation frame. Cancels any existing frame with the same key.
		* @param {string} key The key for this callback.
		* @param {FrameRequestCallback} callback The callback to be executed.
		*/
		AnimationFrame.prototype.request = function(key, callback) {
			var _this = this;
			this.cancel(key);
			var frameID = requestAnimationFrame(function(frame) {
				_this.rafIDs.delete(key);
				callback(frame);
			});
			this.rafIDs.set(key, frameID);
		};
		/**
		* Cancels a queued callback with the given key.
		* @param {string} key The key for this callback.
		*/
		AnimationFrame.prototype.cancel = function(key) {
			var rafID = this.rafIDs.get(key);
			if (rafID) {
				cancelAnimationFrame(rafID);
				this.rafIDs.delete(key);
			}
		};
		/**
		* Cancels all queued callback.
		*/
		AnimationFrame.prototype.cancelAll = function() {
			var _this = this;
			this.rafIDs.forEach(function(_, key) {
				_this.cancel(key);
			});
		};
		/**
		* Returns the queue of unexecuted callback keys.
		*/
		AnimationFrame.prototype.getQueue = function() {
			var queue = [];
			this.rafIDs.forEach(function(_, key) {
				queue.push(key);
			});
			return queue;
		};
		return AnimationFrame;
	}();

//#endregion
//#region node_modules/.pnpm/@material+dialog@14.0.0/node_modules/@material/dialog/constants.js
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
	var cssClasses$12 = {
		CLOSING: "mdc-dialog--closing",
		OPEN: "mdc-dialog--open",
		OPENING: "mdc-dialog--opening",
		SCROLLABLE: "mdc-dialog--scrollable",
		SCROLL_LOCK: "mdc-dialog-scroll-lock",
		STACKED: "mdc-dialog--stacked",
		FULLSCREEN: "mdc-dialog--fullscreen",
		SCROLL_DIVIDER_HEADER: "mdc-dialog-scroll-divider-header",
		SCROLL_DIVIDER_FOOTER: "mdc-dialog-scroll-divider-footer",
		SURFACE_SCRIM_SHOWN: "mdc-dialog__surface-scrim--shown",
		SURFACE_SCRIM_SHOWING: "mdc-dialog__surface-scrim--showing",
		SURFACE_SCRIM_HIDING: "mdc-dialog__surface-scrim--hiding",
		SCRIM_HIDDEN: "mdc-dialog__scrim--hidden"
	};
	var strings$15 = {
		ACTION_ATTRIBUTE: "data-mdc-dialog-action",
		BUTTON_DEFAULT_ATTRIBUTE: "data-mdc-dialog-button-default",
		BUTTON_SELECTOR: ".mdc-dialog__button",
		CLOSED_EVENT: "MDCDialog:closed",
		CLOSE_ACTION: "close",
		CLOSING_EVENT: "MDCDialog:closing",
		CONTAINER_SELECTOR: ".mdc-dialog__container",
		CONTENT_SELECTOR: ".mdc-dialog__content",
		DESTROY_ACTION: "destroy",
		INITIAL_FOCUS_ATTRIBUTE: "data-mdc-dialog-initial-focus",
		OPENED_EVENT: "MDCDialog:opened",
		OPENING_EVENT: "MDCDialog:opening",
		SCRIM_SELECTOR: ".mdc-dialog__scrim",
		SUPPRESS_DEFAULT_PRESS_SELECTOR: [
			"textarea",
			".mdc-menu .mdc-list-item",
			".mdc-menu .mdc-deprecated-list-item"
		].join(", "),
		SURFACE_SELECTOR: ".mdc-dialog__surface"
	};
	var numbers$5 = {
		DIALOG_ANIMATION_CLOSE_TIME_MS: 75,
		DIALOG_ANIMATION_OPEN_TIME_MS: 150
	};

//#endregion
//#region node_modules/.pnpm/@material+dialog@14.0.0/node_modules/@material/dialog/foundation.js
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
	var AnimationKeys$2;
	(function(AnimationKeys) {
		AnimationKeys["POLL_SCROLL_POS"] = "poll_scroll_position";
		AnimationKeys["POLL_LAYOUT_CHANGE"] = "poll_layout_change";
	})(AnimationKeys$2 || (AnimationKeys$2 = {}));
	var MDCDialogFoundation = function(_super) {
		__extends(MDCDialogFoundation, _super);
		function MDCDialogFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCDialogFoundation.defaultAdapter), adapter)) || this;
			_this.dialogOpen = false;
			_this.isFullscreen = false;
			_this.animationFrame = 0;
			_this.animationTimer = 0;
			_this.escapeKeyAction = strings$15.CLOSE_ACTION;
			_this.scrimClickAction = strings$15.CLOSE_ACTION;
			_this.autoStackButtons = true;
			_this.areButtonsStacked = false;
			_this.suppressDefaultPressSelector = strings$15.SUPPRESS_DEFAULT_PRESS_SELECTOR;
			_this.animFrame = new AnimationFrame();
			_this.contentScrollHandler = function() {
				_this.handleScrollEvent();
			};
			_this.windowResizeHandler = function() {
				_this.layout();
			};
			_this.windowOrientationChangeHandler = function() {
				_this.layout();
			};
			return _this;
		}
		Object.defineProperty(MDCDialogFoundation, "cssClasses", {
			get: function() {
				return cssClasses$12;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCDialogFoundation, "strings", {
			get: function() {
				return strings$15;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCDialogFoundation, "numbers", {
			get: function() {
				return numbers$5;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCDialogFoundation, "defaultAdapter", {
			get: function() {
				return {
					addBodyClass: function() {},
					addClass: function() {},
					areButtonsStacked: function() {
						return false;
					},
					clickDefaultButton: function() {},
					eventTargetMatches: function() {
						return false;
					},
					getActionFromEvent: function() {
						return "";
					},
					getInitialFocusEl: function() {
						return null;
					},
					hasClass: function() {
						return false;
					},
					isContentScrollable: function() {
						return false;
					},
					notifyClosed: function() {},
					notifyClosing: function() {},
					notifyOpened: function() {},
					notifyOpening: function() {},
					releaseFocus: function() {},
					removeBodyClass: function() {},
					removeClass: function() {},
					reverseButtons: function() {},
					trapFocus: function() {},
					registerContentEventHandler: function() {},
					deregisterContentEventHandler: function() {},
					isScrollableContentAtTop: function() {
						return false;
					},
					isScrollableContentAtBottom: function() {
						return false;
					},
					registerWindowEventHandler: function() {},
					deregisterWindowEventHandler: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCDialogFoundation.prototype.init = function() {
			if (this.adapter.hasClass(cssClasses$12.STACKED)) this.setAutoStackButtons(false);
			this.isFullscreen = this.adapter.hasClass(cssClasses$12.FULLSCREEN);
		};
		MDCDialogFoundation.prototype.destroy = function() {
			if (this.animationTimer) {
				clearTimeout(this.animationTimer);
				this.handleAnimationTimerEnd();
			}
			if (this.isFullscreen) this.adapter.deregisterContentEventHandler("scroll", this.contentScrollHandler);
			this.animFrame.cancelAll();
			this.adapter.deregisterWindowEventHandler("resize", this.windowResizeHandler);
			this.adapter.deregisterWindowEventHandler("orientationchange", this.windowOrientationChangeHandler);
		};
		MDCDialogFoundation.prototype.open = function(dialogOptions) {
			var _this = this;
			this.dialogOpen = true;
			this.adapter.notifyOpening();
			this.adapter.addClass(cssClasses$12.OPENING);
			if (this.isFullscreen) this.adapter.registerContentEventHandler("scroll", this.contentScrollHandler);
			if (dialogOptions && dialogOptions.isAboveFullscreenDialog) this.adapter.addClass(cssClasses$12.SCRIM_HIDDEN);
			this.adapter.registerWindowEventHandler("resize", this.windowResizeHandler);
			this.adapter.registerWindowEventHandler("orientationchange", this.windowOrientationChangeHandler);
			this.runNextAnimationFrame(function() {
				_this.adapter.addClass(cssClasses$12.OPEN);
				_this.adapter.addBodyClass(cssClasses$12.SCROLL_LOCK);
				_this.layout();
				_this.animationTimer = setTimeout(function() {
					_this.handleAnimationTimerEnd();
					_this.adapter.trapFocus(_this.adapter.getInitialFocusEl());
					_this.adapter.notifyOpened();
				}, numbers$5.DIALOG_ANIMATION_OPEN_TIME_MS);
			});
		};
		MDCDialogFoundation.prototype.close = function(action) {
			var _this = this;
			if (action === void 0) action = "";
			if (!this.dialogOpen) return;
			this.dialogOpen = false;
			this.adapter.notifyClosing(action);
			this.adapter.addClass(cssClasses$12.CLOSING);
			this.adapter.removeClass(cssClasses$12.OPEN);
			this.adapter.removeBodyClass(cssClasses$12.SCROLL_LOCK);
			if (this.isFullscreen) this.adapter.deregisterContentEventHandler("scroll", this.contentScrollHandler);
			this.adapter.deregisterWindowEventHandler("resize", this.windowResizeHandler);
			this.adapter.deregisterWindowEventHandler("orientationchange", this.windowOrientationChangeHandler);
			cancelAnimationFrame(this.animationFrame);
			this.animationFrame = 0;
			clearTimeout(this.animationTimer);
			this.animationTimer = setTimeout(function() {
				_this.adapter.releaseFocus();
				_this.handleAnimationTimerEnd();
				_this.adapter.notifyClosed(action);
			}, numbers$5.DIALOG_ANIMATION_CLOSE_TIME_MS);
		};
		/**
		* Used only in instances of showing a secondary dialog over a full-screen
		* dialog. Shows the "surface scrim" displayed over the full-screen dialog.
		*/
		MDCDialogFoundation.prototype.showSurfaceScrim = function() {
			var _this = this;
			this.adapter.addClass(cssClasses$12.SURFACE_SCRIM_SHOWING);
			this.runNextAnimationFrame(function() {
				_this.adapter.addClass(cssClasses$12.SURFACE_SCRIM_SHOWN);
			});
		};
		/**
		* Used only in instances of showing a secondary dialog over a full-screen
		* dialog. Hides the "surface scrim" displayed over the full-screen dialog.
		*/
		MDCDialogFoundation.prototype.hideSurfaceScrim = function() {
			this.adapter.removeClass(cssClasses$12.SURFACE_SCRIM_SHOWN);
			this.adapter.addClass(cssClasses$12.SURFACE_SCRIM_HIDING);
		};
		/**
		* Handles `transitionend` event triggered when surface scrim animation is
		* finished.
		*/
		MDCDialogFoundation.prototype.handleSurfaceScrimTransitionEnd = function() {
			this.adapter.removeClass(cssClasses$12.SURFACE_SCRIM_HIDING);
			this.adapter.removeClass(cssClasses$12.SURFACE_SCRIM_SHOWING);
		};
		MDCDialogFoundation.prototype.isOpen = function() {
			return this.dialogOpen;
		};
		MDCDialogFoundation.prototype.getEscapeKeyAction = function() {
			return this.escapeKeyAction;
		};
		MDCDialogFoundation.prototype.setEscapeKeyAction = function(action) {
			this.escapeKeyAction = action;
		};
		MDCDialogFoundation.prototype.getScrimClickAction = function() {
			return this.scrimClickAction;
		};
		MDCDialogFoundation.prototype.setScrimClickAction = function(action) {
			this.scrimClickAction = action;
		};
		MDCDialogFoundation.prototype.getAutoStackButtons = function() {
			return this.autoStackButtons;
		};
		MDCDialogFoundation.prototype.setAutoStackButtons = function(autoStack) {
			this.autoStackButtons = autoStack;
		};
		MDCDialogFoundation.prototype.getSuppressDefaultPressSelector = function() {
			return this.suppressDefaultPressSelector;
		};
		MDCDialogFoundation.prototype.setSuppressDefaultPressSelector = function(selector) {
			this.suppressDefaultPressSelector = selector;
		};
		MDCDialogFoundation.prototype.layout = function() {
			var _this = this;
			this.animFrame.request(AnimationKeys$2.POLL_LAYOUT_CHANGE, function() {
				_this.layoutInternal();
			});
		};
		/** Handles click on the dialog root element. */
		MDCDialogFoundation.prototype.handleClick = function(evt) {
			if (this.adapter.eventTargetMatches(evt.target, strings$15.SCRIM_SELECTOR) && this.scrimClickAction !== "") this.close(this.scrimClickAction);
			else {
				var action = this.adapter.getActionFromEvent(evt);
				if (action) this.close(action);
			}
		};
		/** Handles keydown on the dialog root element. */
		MDCDialogFoundation.prototype.handleKeydown = function(evt) {
			var isEnter = evt.key === "Enter" || evt.keyCode === 13;
			if (!isEnter) return;
			if (this.adapter.getActionFromEvent(evt)) return;
			var target = evt.composedPath ? evt.composedPath()[0] : evt.target;
			var isDefault = this.suppressDefaultPressSelector ? !this.adapter.eventTargetMatches(target, this.suppressDefaultPressSelector) : true;
			if (isEnter && isDefault) this.adapter.clickDefaultButton();
		};
		/** Handles keydown on the document. */
		MDCDialogFoundation.prototype.handleDocumentKeydown = function(evt) {
			if ((evt.key === "Escape" || evt.keyCode === 27) && this.escapeKeyAction !== "") this.close(this.escapeKeyAction);
		};
		/**
		* Handles scroll event on the dialog's content element -- showing a scroll
		* divider on the header or footer based on the scroll position. This handler
		* should only be registered on full-screen dialogs with scrollable content.
		*/
		MDCDialogFoundation.prototype.handleScrollEvent = function() {
			var _this = this;
			this.animFrame.request(AnimationKeys$2.POLL_SCROLL_POS, function() {
				_this.toggleScrollDividerHeader();
				_this.toggleScrollDividerFooter();
			});
		};
		MDCDialogFoundation.prototype.layoutInternal = function() {
			if (this.autoStackButtons) this.detectStackedButtons();
			this.toggleScrollableClasses();
		};
		MDCDialogFoundation.prototype.handleAnimationTimerEnd = function() {
			this.animationTimer = 0;
			this.adapter.removeClass(cssClasses$12.OPENING);
			this.adapter.removeClass(cssClasses$12.CLOSING);
		};
		/**
		* Runs the given logic on the next animation frame, using setTimeout to
		* factor in Firefox reflow behavior.
		*/
		MDCDialogFoundation.prototype.runNextAnimationFrame = function(callback) {
			var _this = this;
			cancelAnimationFrame(this.animationFrame);
			this.animationFrame = requestAnimationFrame(function() {
				_this.animationFrame = 0;
				clearTimeout(_this.animationTimer);
				_this.animationTimer = setTimeout(callback, 0);
			});
		};
		MDCDialogFoundation.prototype.detectStackedButtons = function() {
			this.adapter.removeClass(cssClasses$12.STACKED);
			var areButtonsStacked = this.adapter.areButtonsStacked();
			if (areButtonsStacked) this.adapter.addClass(cssClasses$12.STACKED);
			if (areButtonsStacked !== this.areButtonsStacked) {
				this.adapter.reverseButtons();
				this.areButtonsStacked = areButtonsStacked;
			}
		};
		MDCDialogFoundation.prototype.toggleScrollableClasses = function() {
			this.adapter.removeClass(cssClasses$12.SCROLLABLE);
			if (this.adapter.isContentScrollable()) {
				this.adapter.addClass(cssClasses$12.SCROLLABLE);
				if (this.isFullscreen) {
					this.toggleScrollDividerHeader();
					this.toggleScrollDividerFooter();
				}
			}
		};
		MDCDialogFoundation.prototype.toggleScrollDividerHeader = function() {
			if (!this.adapter.isScrollableContentAtTop()) this.adapter.addClass(cssClasses$12.SCROLL_DIVIDER_HEADER);
			else if (this.adapter.hasClass(cssClasses$12.SCROLL_DIVIDER_HEADER)) this.adapter.removeClass(cssClasses$12.SCROLL_DIVIDER_HEADER);
		};
		MDCDialogFoundation.prototype.toggleScrollDividerFooter = function() {
			if (!this.adapter.isScrollableContentAtBottom()) this.adapter.addClass(cssClasses$12.SCROLL_DIVIDER_FOOTER);
			else if (this.adapter.hasClass(cssClasses$12.SCROLL_DIVIDER_FOOTER)) this.adapter.removeClass(cssClasses$12.SCROLL_DIVIDER_FOOTER);
		};
		return MDCDialogFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+dialog@14.0.0/node_modules/@material/dialog/component.js
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
	var strings$14 = MDCDialogFoundation.strings;
	var MDCDialog = function(_super) {
		__extends(MDCDialog, _super);
		function MDCDialog() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		Object.defineProperty(MDCDialog.prototype, "isOpen", {
			get: function() {
				return this.foundation.isOpen();
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCDialog.prototype, "escapeKeyAction", {
			get: function() {
				return this.foundation.getEscapeKeyAction();
			},
			set: function(action) {
				this.foundation.setEscapeKeyAction(action);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCDialog.prototype, "scrimClickAction", {
			get: function() {
				return this.foundation.getScrimClickAction();
			},
			set: function(action) {
				this.foundation.setScrimClickAction(action);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCDialog.prototype, "autoStackButtons", {
			get: function() {
				return this.foundation.getAutoStackButtons();
			},
			set: function(autoStack) {
				this.foundation.setAutoStackButtons(autoStack);
			},
			enumerable: false,
			configurable: true
		});
		MDCDialog.attachTo = function(root) {
			return new MDCDialog(root);
		};
		MDCDialog.prototype.initialize = function(focusTrapFactory) {
			var e_1, _a;
			if (focusTrapFactory === void 0) focusTrapFactory = function(el, focusOptions) {
				return new FocusTrap(el, focusOptions);
			};
			var container = this.root.querySelector(strings$14.CONTAINER_SELECTOR);
			if (!container) throw new Error("Dialog component requires a " + strings$14.CONTAINER_SELECTOR + " container element");
			this.container = container;
			this.content = this.root.querySelector(strings$14.CONTENT_SELECTOR);
			this.buttons = [].slice.call(this.root.querySelectorAll(strings$14.BUTTON_SELECTOR));
			this.defaultButton = this.root.querySelector("[" + strings$14.BUTTON_DEFAULT_ATTRIBUTE + "]");
			this.focusTrapFactory = focusTrapFactory;
			this.buttonRipples = [];
			try {
				for (var _b = __values(this.buttons), _c = _b.next(); !_c.done; _c = _b.next()) {
					var buttonEl = _c.value;
					this.buttonRipples.push(new MDCRipple(buttonEl));
				}
			} catch (e_1_1) {
				e_1 = { error: e_1_1 };
			} finally {
				try {
					if (_c && !_c.done && (_a = _b.return)) _a.call(_b);
				} finally {
					if (e_1) throw e_1.error;
				}
			}
		};
		MDCDialog.prototype.initialSyncWithDOM = function() {
			var _this = this;
			this.focusTrap = createFocusTrapInstance$1(this.container, this.focusTrapFactory, this.getInitialFocusEl() || void 0);
			this.handleClick = this.foundation.handleClick.bind(this.foundation);
			this.handleKeydown = this.foundation.handleKeydown.bind(this.foundation);
			this.handleDocumentKeydown = this.foundation.handleDocumentKeydown.bind(this.foundation);
			this.handleOpening = function() {
				document.addEventListener("keydown", _this.handleDocumentKeydown);
			};
			this.handleClosing = function() {
				document.removeEventListener("keydown", _this.handleDocumentKeydown);
			};
			this.listen("click", this.handleClick);
			this.listen("keydown", this.handleKeydown);
			this.listen(strings$14.OPENING_EVENT, this.handleOpening);
			this.listen(strings$14.CLOSING_EVENT, this.handleClosing);
		};
		MDCDialog.prototype.destroy = function() {
			this.unlisten("click", this.handleClick);
			this.unlisten("keydown", this.handleKeydown);
			this.unlisten(strings$14.OPENING_EVENT, this.handleOpening);
			this.unlisten(strings$14.CLOSING_EVENT, this.handleClosing);
			this.handleClosing();
			this.buttonRipples.forEach(function(ripple) {
				ripple.destroy();
			});
			_super.prototype.destroy.call(this);
		};
		MDCDialog.prototype.layout = function() {
			this.foundation.layout();
		};
		MDCDialog.prototype.open = function() {
			this.foundation.open();
		};
		MDCDialog.prototype.close = function(action) {
			if (action === void 0) action = "";
			this.foundation.close(action);
		};
		MDCDialog.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCDialogFoundation({
				addBodyClass: function(className) {
					return document.body.classList.add(className);
				},
				addClass: function(className) {
					return _this.root.classList.add(className);
				},
				areButtonsStacked: function() {
					return areTopsMisaligned(_this.buttons);
				},
				clickDefaultButton: function() {
					if (_this.defaultButton && !_this.defaultButton.disabled) _this.defaultButton.click();
				},
				eventTargetMatches: function(target, selector) {
					return target ? matches(target, selector) : false;
				},
				getActionFromEvent: function(evt) {
					if (!evt.target) return "";
					var element = closest(evt.target, "[" + strings$14.ACTION_ATTRIBUTE + "]");
					return element && element.getAttribute(strings$14.ACTION_ATTRIBUTE);
				},
				getInitialFocusEl: function() {
					return _this.getInitialFocusEl();
				},
				hasClass: function(className) {
					return _this.root.classList.contains(className);
				},
				isContentScrollable: function() {
					return isScrollable(_this.content);
				},
				notifyClosed: function(action) {
					return _this.emit(strings$14.CLOSED_EVENT, action ? { action } : {});
				},
				notifyClosing: function(action) {
					return _this.emit(strings$14.CLOSING_EVENT, action ? { action } : {});
				},
				notifyOpened: function() {
					return _this.emit(strings$14.OPENED_EVENT, {});
				},
				notifyOpening: function() {
					return _this.emit(strings$14.OPENING_EVENT, {});
				},
				releaseFocus: function() {
					_this.focusTrap.releaseFocus();
				},
				removeBodyClass: function(className) {
					return document.body.classList.remove(className);
				},
				removeClass: function(className) {
					return _this.root.classList.remove(className);
				},
				reverseButtons: function() {
					_this.buttons.reverse();
					_this.buttons.forEach(function(button) {
						button.parentElement.appendChild(button);
					});
				},
				trapFocus: function() {
					_this.focusTrap.trapFocus();
				},
				registerContentEventHandler: function(evt, handler) {
					if (_this.content instanceof HTMLElement) _this.content.addEventListener(evt, handler);
				},
				deregisterContentEventHandler: function(evt, handler) {
					if (_this.content instanceof HTMLElement) _this.content.removeEventListener(evt, handler);
				},
				isScrollableContentAtTop: function() {
					return isScrollAtTop(_this.content);
				},
				isScrollableContentAtBottom: function() {
					return isScrollAtBottom(_this.content);
				},
				registerWindowEventHandler: function(evt, handler) {
					window.addEventListener(evt, handler);
				},
				deregisterWindowEventHandler: function(evt, handler) {
					window.removeEventListener(evt, handler);
				}
			});
		};
		MDCDialog.prototype.getInitialFocusEl = function() {
			return this.root.querySelector("[" + strings$14.INITIAL_FOCUS_ATTRIBUTE + "]");
		};
		return MDCDialog;
	}(MDCComponent);

//#endregion
//#region Components/Dialog/MBDialog.ts
	var MBDialog_exports = /* @__PURE__ */ __exportAll({
		hide: () => hide$3,
		show: () => show$3
	});
	function show$3(elem, dotNetObject, escapeKeyAction, scrimClickAction) {
		if (!elem) return;
		elem._dialog = elem._dialog || MDCDialog.attachTo(elem);
		elem._dotNetObject = dotNetObject;
		const openedCallback = () => {
			elem._dialog.unlisten("MDCDialog:opened", openedCallback);
			dotNetObject.invokeMethodAsync("NotifyOpened");
		};
		elem._dialog.listen("MDCDialog:opened", openedCallback);
		elem._dialog.escapeKeyAction = escapeKeyAction;
		elem._dialog.scrimClickAction = scrimClickAction;
		const closingCallback = (event) => {
			elem._dialog.unlisten("MDCDialog:closing", closingCallback);
			dotNetObject.invokeMethodAsync("NotifyClosed", event.detail.action);
		};
		elem._dialog.listen("MDCDialog:closing", closingCallback);
		elem._dialog.open();
	}
	function hide$3(elem, dialogAction) {
		if (!elem) return;
		if (elem && elem._dialog) {
			elem._dialog.close(dialogAction || "dismissed");
			elem._dialog.destroy();
		}
	}

//#endregion
//#region node_modules/.pnpm/@material+drawer@14.0.0/node_modules/@material/drawer/util.js
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
	function createFocusTrapInstance(surfaceEl, focusTrapFactory) {
		return focusTrapFactory(surfaceEl, { skipInitialFocus: true });
	}

//#endregion
//#region node_modules/.pnpm/@material+drawer@14.0.0/node_modules/@material/drawer/constants.js
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
	var cssClasses$11 = {
		ANIMATE: "mdc-drawer--animate",
		CLOSING: "mdc-drawer--closing",
		DISMISSIBLE: "mdc-drawer--dismissible",
		MODAL: "mdc-drawer--modal",
		OPEN: "mdc-drawer--open",
		OPENING: "mdc-drawer--opening",
		ROOT: "mdc-drawer"
	};
	var strings$13 = {
		APP_CONTENT_SELECTOR: ".mdc-drawer-app-content",
		CLOSE_EVENT: "MDCDrawer:closed",
		OPEN_EVENT: "MDCDrawer:opened",
		SCRIM_SELECTOR: ".mdc-drawer-scrim",
		LIST_SELECTOR: ".mdc-list,.mdc-deprecated-list",
		LIST_ITEM_ACTIVATED_SELECTOR: ".mdc-list-item--activated,.mdc-deprecated-list-item--activated"
	};

//#endregion
//#region node_modules/.pnpm/@material+drawer@14.0.0/node_modules/@material/drawer/dismissible/foundation.js
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
	var MDCDismissibleDrawerFoundation = function(_super) {
		__extends(MDCDismissibleDrawerFoundation, _super);
		function MDCDismissibleDrawerFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCDismissibleDrawerFoundation.defaultAdapter), adapter)) || this;
			_this.animationFrame = 0;
			_this.animationTimer = 0;
			return _this;
		}
		Object.defineProperty(MDCDismissibleDrawerFoundation, "strings", {
			get: function() {
				return strings$13;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCDismissibleDrawerFoundation, "cssClasses", {
			get: function() {
				return cssClasses$11;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCDismissibleDrawerFoundation, "defaultAdapter", {
			get: function() {
				return {
					addClass: function() {},
					removeClass: function() {},
					hasClass: function() {
						return false;
					},
					elementHasClass: function() {
						return false;
					},
					notifyClose: function() {},
					notifyOpen: function() {},
					saveFocus: function() {},
					restoreFocus: function() {},
					focusActiveNavigationItem: function() {},
					trapFocus: function() {},
					releaseFocus: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCDismissibleDrawerFoundation.prototype.destroy = function() {
			if (this.animationFrame) cancelAnimationFrame(this.animationFrame);
			if (this.animationTimer) clearTimeout(this.animationTimer);
		};
		/**
		* Opens the drawer from the closed state.
		*/
		MDCDismissibleDrawerFoundation.prototype.open = function() {
			var _this = this;
			if (this.isOpen() || this.isOpening() || this.isClosing()) return;
			this.adapter.addClass(cssClasses$11.OPEN);
			this.adapter.addClass(cssClasses$11.ANIMATE);
			this.runNextAnimationFrame(function() {
				_this.adapter.addClass(cssClasses$11.OPENING);
			});
			this.adapter.saveFocus();
		};
		/**
		* Closes the drawer from the open state.
		*/
		MDCDismissibleDrawerFoundation.prototype.close = function() {
			if (!this.isOpen() || this.isOpening() || this.isClosing()) return;
			this.adapter.addClass(cssClasses$11.CLOSING);
		};
		/**
		* Returns true if the drawer is in the open position.
		* @return true if drawer is in open state.
		*/
		MDCDismissibleDrawerFoundation.prototype.isOpen = function() {
			return this.adapter.hasClass(cssClasses$11.OPEN);
		};
		/**
		* Returns true if the drawer is animating open.
		* @return true if drawer is animating open.
		*/
		MDCDismissibleDrawerFoundation.prototype.isOpening = function() {
			return this.adapter.hasClass(cssClasses$11.OPENING) || this.adapter.hasClass(cssClasses$11.ANIMATE);
		};
		/**
		* Returns true if the drawer is animating closed.
		* @return true if drawer is animating closed.
		*/
		MDCDismissibleDrawerFoundation.prototype.isClosing = function() {
			return this.adapter.hasClass(cssClasses$11.CLOSING);
		};
		/**
		* Keydown handler to close drawer when key is escape.
		*/
		MDCDismissibleDrawerFoundation.prototype.handleKeydown = function(evt) {
			var keyCode = evt.keyCode;
			if (evt.key === "Escape" || keyCode === 27) this.close();
		};
		/**
		* Handles the `transitionend` event when the drawer finishes opening/closing.
		*/
		MDCDismissibleDrawerFoundation.prototype.handleTransitionEnd = function(evt) {
			var OPENING = cssClasses$11.OPENING, CLOSING = cssClasses$11.CLOSING, OPEN = cssClasses$11.OPEN, ANIMATE = cssClasses$11.ANIMATE, ROOT = cssClasses$11.ROOT;
			if (!(this.isElement(evt.target) && this.adapter.elementHasClass(evt.target, ROOT))) return;
			if (this.isClosing()) {
				this.adapter.removeClass(OPEN);
				this.closed();
				this.adapter.restoreFocus();
				this.adapter.notifyClose();
			} else {
				this.adapter.focusActiveNavigationItem();
				this.opened();
				this.adapter.notifyOpen();
			}
			this.adapter.removeClass(ANIMATE);
			this.adapter.removeClass(OPENING);
			this.adapter.removeClass(CLOSING);
		};
		/**
		* Extension point for when drawer finishes open animation.
		*/
		MDCDismissibleDrawerFoundation.prototype.opened = function() {};
		/**
		* Extension point for when drawer finishes close animation.
		*/
		MDCDismissibleDrawerFoundation.prototype.closed = function() {};
		/**
		* Runs the given logic on the next animation frame, using setTimeout to factor in Firefox reflow behavior.
		*/
		MDCDismissibleDrawerFoundation.prototype.runNextAnimationFrame = function(callback) {
			var _this = this;
			cancelAnimationFrame(this.animationFrame);
			this.animationFrame = requestAnimationFrame(function() {
				_this.animationFrame = 0;
				clearTimeout(_this.animationTimer);
				_this.animationTimer = setTimeout(callback, 0);
			});
		};
		MDCDismissibleDrawerFoundation.prototype.isElement = function(element) {
			return Boolean(element.classList);
		};
		return MDCDismissibleDrawerFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+drawer@14.0.0/node_modules/@material/drawer/modal/foundation.js
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
	/* istanbul ignore next: subclass is not a branch statement */
	var MDCModalDrawerFoundation = function(_super) {
		__extends(MDCModalDrawerFoundation, _super);
		function MDCModalDrawerFoundation() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		/**
		* Handles click event on scrim.
		*/
		MDCModalDrawerFoundation.prototype.handleScrimClick = function() {
			this.close();
		};
		/**
		* Called when drawer finishes open animation.
		*/
		MDCModalDrawerFoundation.prototype.opened = function() {
			this.adapter.trapFocus();
		};
		/**
		* Called when drawer finishes close animation.
		*/
		MDCModalDrawerFoundation.prototype.closed = function() {
			this.adapter.releaseFocus();
		};
		return MDCModalDrawerFoundation;
	}(MDCDismissibleDrawerFoundation);

//#endregion
//#region node_modules/.pnpm/@material+drawer@14.0.0/node_modules/@material/drawer/component.js
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
	var cssClasses$10 = MDCDismissibleDrawerFoundation.cssClasses;
	var strings$12 = MDCDismissibleDrawerFoundation.strings;
	/**
	* @events `MDCDrawer:closed {}` Emits when the navigation drawer has closed.
	* @events `MDCDrawer:opened {}` Emits when the navigation drawer has opened.
	*/
	var MDCDrawer = function(_super) {
		__extends(MDCDrawer, _super);
		function MDCDrawer() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCDrawer.attachTo = function(root) {
			return new MDCDrawer(root);
		};
		Object.defineProperty(MDCDrawer.prototype, "open", {
			/**
			* @return boolean Proxies to the foundation's `open`/`close` methods.
			* Also returns true if drawer is in the open position.
			*/
			get: function() {
				return this.foundation.isOpen();
			},
			/**
			* Toggles the drawer open and closed.
			*/
			set: function(isOpen) {
				if (isOpen) this.foundation.open();
				else this.foundation.close();
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCDrawer.prototype, "list", {
			get: function() {
				return this.innerList;
			},
			enumerable: false,
			configurable: true
		});
		MDCDrawer.prototype.initialize = function(focusTrapFactory, listFactory) {
			if (focusTrapFactory === void 0) focusTrapFactory = function(el) {
				return new FocusTrap(el);
			};
			if (listFactory === void 0) listFactory = function(el) {
				return new MDCList(el);
			};
			var listEl = this.root.querySelector(strings$12.LIST_SELECTOR);
			if (listEl) {
				this.innerList = listFactory(listEl);
				this.innerList.wrapFocus = true;
			}
			this.focusTrapFactory = focusTrapFactory;
		};
		MDCDrawer.prototype.initialSyncWithDOM = function() {
			var _this = this;
			var MODAL = cssClasses$10.MODAL;
			var SCRIM_SELECTOR = strings$12.SCRIM_SELECTOR;
			this.scrim = this.root.parentNode.querySelector(SCRIM_SELECTOR);
			if (this.scrim && this.root.classList.contains(MODAL)) {
				this.handleScrimClick = function() {
					return _this.foundation.handleScrimClick();
				};
				this.scrim.addEventListener("click", this.handleScrimClick);
				this.focusTrap = createFocusTrapInstance(this.root, this.focusTrapFactory);
			}
			this.handleKeydown = function(evt) {
				_this.foundation.handleKeydown(evt);
			};
			this.handleTransitionEnd = function(evt) {
				_this.foundation.handleTransitionEnd(evt);
			};
			this.listen("keydown", this.handleKeydown);
			this.listen("transitionend", this.handleTransitionEnd);
		};
		MDCDrawer.prototype.destroy = function() {
			this.unlisten("keydown", this.handleKeydown);
			this.unlisten("transitionend", this.handleTransitionEnd);
			if (this.innerList) this.innerList.destroy();
			var MODAL = cssClasses$10.MODAL;
			if (this.scrim && this.handleScrimClick && this.root.classList.contains(MODAL)) {
				this.scrim.removeEventListener("click", this.handleScrimClick);
				this.open = false;
			}
		};
		MDCDrawer.prototype.getDefaultFoundation = function() {
			var _this = this;
			var adapter = {
				addClass: function(className) {
					_this.root.classList.add(className);
				},
				removeClass: function(className) {
					_this.root.classList.remove(className);
				},
				hasClass: function(className) {
					return _this.root.classList.contains(className);
				},
				elementHasClass: function(element, className) {
					return element.classList.contains(className);
				},
				saveFocus: function() {
					_this.previousFocus = document.activeElement;
				},
				restoreFocus: function() {
					var previousFocus = _this.previousFocus;
					if (previousFocus && previousFocus.focus && _this.root.contains(document.activeElement)) previousFocus.focus();
				},
				focusActiveNavigationItem: function() {
					var activeNavItemEl = _this.root.querySelector(strings$12.LIST_ITEM_ACTIVATED_SELECTOR);
					if (activeNavItemEl) activeNavItemEl.focus();
				},
				notifyClose: function() {
					_this.emit(strings$12.CLOSE_EVENT, {}, true);
				},
				notifyOpen: function() {
					_this.emit(strings$12.OPEN_EVENT, {}, true);
				},
				trapFocus: function() {
					_this.focusTrap.trapFocus();
				},
				releaseFocus: function() {
					_this.focusTrap.releaseFocus();
				}
			};
			var DISMISSIBLE = cssClasses$10.DISMISSIBLE, MODAL = cssClasses$10.MODAL;
			if (this.root.classList.contains(DISMISSIBLE)) return new MDCDismissibleDrawerFoundation(adapter);
			else if (this.root.classList.contains(MODAL)) return new MDCModalDrawerFoundation(adapter);
			else throw new Error("MDCDrawer: Failed to instantiate component. Supported variants are " + DISMISSIBLE + " and " + MODAL + ".");
		};
		return MDCDrawer;
	}(MDCComponent);

//#endregion
//#region Components/Drawer/MBDrawer.ts
	var MBDrawer_exports = /* @__PURE__ */ __exportAll({
		init: () => init$17,
		toggle: () => toggle
	});
	function init$17(elem, isOpen) {
		if (!elem) return;
		elem._drawer = MDCDrawer.attachTo(elem);
		toggle(elem, isOpen);
	}
	function toggle(elem, isOpen) {
		if (!elem) return;
		elem._drawer.open = isOpen;
	}

//#endregion
//#region Components/DragAndDropList/MBDragAndDropList.ts
	var MBDragAndDropList_exports = /* @__PURE__ */ __exportAll({ initDropTarget: () => initDropTarget });
	function initDropTarget(elem) {
		if (!elem) return;
		elem.addEventListener("dragover", (event) => {
			event.preventDefault();
		});
	}

//#endregion
//#region Components/FileUpload/MBFileUpload.ts
	var MBFileUpload_exports = /* @__PURE__ */ __exportAll({ click: () => click$1 });
	function click$1(elem) {
		if (!elem) return;
		elem.querySelector("input").click();
	}

//#endregion
//#region Components/FloatingActionButton/MBFloatingActionButton.ts
	var MBFloatingActionButton_exports = /* @__PURE__ */ __exportAll({
		init: () => init$16,
		setExited: () => setExited
	});
	function init$16(elem, exited) {
		elem._fab = MDCRipple.attachTo(elem);
		elem._exited = false;
		setExited(elem, exited);
	}
	function setExited(elem, exited) {
		if (elem) if (exited != elem._exited) elem.classList.add("mdc-fab--exited");
		else elem.classList.remove("mdc-fab--exited");
	}

//#endregion
//#region Components/IconButton/MBIconButton.ts
	var MBIconButton_exports = /* @__PURE__ */ __exportAll({ init: () => init$15 });
	function init$15(elem) {
		if (!elem) return;
		elem._ripple = MDCRipple.attachTo(elem);
		elem._ripple.unbounded = true;
	}

//#endregion
//#region node_modules/.pnpm/@material+icon-button@14.0.0/node_modules/@material/icon-button/constants.js
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
	var cssClasses$9 = {
		ICON_BUTTON_ON: "mdc-icon-button--on",
		ROOT: "mdc-icon-button"
	};
	var strings$11 = {
		ARIA_LABEL: "aria-label",
		ARIA_PRESSED: "aria-pressed",
		DATA_ARIA_LABEL_OFF: "data-aria-label-off",
		DATA_ARIA_LABEL_ON: "data-aria-label-on",
		CHANGE_EVENT: "MDCIconButtonToggle:change"
	};

//#endregion
//#region node_modules/.pnpm/@material+icon-button@14.0.0/node_modules/@material/icon-button/foundation.js
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
	var MDCIconButtonToggleFoundation = function(_super) {
		__extends(MDCIconButtonToggleFoundation, _super);
		function MDCIconButtonToggleFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCIconButtonToggleFoundation.defaultAdapter), adapter)) || this;
			/**
			* Whether the icon button has an aria label that changes depending on
			* toggled state.
			*/
			_this.hasToggledAriaLabel = false;
			return _this;
		}
		Object.defineProperty(MDCIconButtonToggleFoundation, "cssClasses", {
			get: function() {
				return cssClasses$9;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCIconButtonToggleFoundation, "strings", {
			get: function() {
				return strings$11;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCIconButtonToggleFoundation, "defaultAdapter", {
			get: function() {
				return {
					addClass: function() {},
					hasClass: function() {
						return false;
					},
					notifyChange: function() {},
					removeClass: function() {},
					getAttr: function() {
						return null;
					},
					setAttr: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCIconButtonToggleFoundation.prototype.init = function() {
			var ariaLabelOn = this.adapter.getAttr(strings$11.DATA_ARIA_LABEL_ON);
			var ariaLabelOff = this.adapter.getAttr(strings$11.DATA_ARIA_LABEL_OFF);
			if (ariaLabelOn && ariaLabelOff) {
				if (this.adapter.getAttr(strings$11.ARIA_PRESSED) !== null) throw new Error("MDCIconButtonToggleFoundation: Button should not set `aria-pressed` if it has a toggled aria label.");
				this.hasToggledAriaLabel = true;
			} else this.adapter.setAttr(strings$11.ARIA_PRESSED, String(this.isOn()));
		};
		MDCIconButtonToggleFoundation.prototype.handleClick = function() {
			this.toggle();
			this.adapter.notifyChange({ isOn: this.isOn() });
		};
		MDCIconButtonToggleFoundation.prototype.isOn = function() {
			return this.adapter.hasClass(cssClasses$9.ICON_BUTTON_ON);
		};
		MDCIconButtonToggleFoundation.prototype.toggle = function(isOn) {
			if (isOn === void 0) isOn = !this.isOn();
			if (isOn) this.adapter.addClass(cssClasses$9.ICON_BUTTON_ON);
			else this.adapter.removeClass(cssClasses$9.ICON_BUTTON_ON);
			if (this.hasToggledAriaLabel) {
				var ariaLabel = isOn ? this.adapter.getAttr(strings$11.DATA_ARIA_LABEL_ON) : this.adapter.getAttr(strings$11.DATA_ARIA_LABEL_OFF);
				this.adapter.setAttr(strings$11.ARIA_LABEL, ariaLabel || "");
			} else this.adapter.setAttr(strings$11.ARIA_PRESSED, "" + isOn);
		};
		return MDCIconButtonToggleFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+icon-button@14.0.0/node_modules/@material/icon-button/component.js
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
	var strings$10 = MDCIconButtonToggleFoundation.strings;
	var MDCIconButtonToggle = function(_super) {
		__extends(MDCIconButtonToggle, _super);
		function MDCIconButtonToggle() {
			var _this = _super !== null && _super.apply(this, arguments) || this;
			_this.rippleComponent = _this.createRipple();
			return _this;
		}
		MDCIconButtonToggle.attachTo = function(root) {
			return new MDCIconButtonToggle(root);
		};
		MDCIconButtonToggle.prototype.initialSyncWithDOM = function() {
			var _this = this;
			this.handleClick = function() {
				_this.foundation.handleClick();
			};
			this.listen("click", this.handleClick);
		};
		MDCIconButtonToggle.prototype.destroy = function() {
			this.unlisten("click", this.handleClick);
			this.ripple.destroy();
			_super.prototype.destroy.call(this);
		};
		MDCIconButtonToggle.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCIconButtonToggleFoundation({
				addClass: function(className) {
					return _this.root.classList.add(className);
				},
				hasClass: function(className) {
					return _this.root.classList.contains(className);
				},
				notifyChange: function(evtData) {
					_this.emit(strings$10.CHANGE_EVENT, evtData);
				},
				removeClass: function(className) {
					return _this.root.classList.remove(className);
				},
				getAttr: function(attrName) {
					return _this.root.getAttribute(attrName);
				},
				setAttr: function(attrName, attrValue) {
					return _this.root.setAttribute(attrName, attrValue);
				}
			});
		};
		Object.defineProperty(MDCIconButtonToggle.prototype, "ripple", {
			get: function() {
				return this.rippleComponent;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCIconButtonToggle.prototype, "on", {
			get: function() {
				return this.foundation.isOn();
			},
			set: function(isOn) {
				this.foundation.toggle(isOn);
			},
			enumerable: false,
			configurable: true
		});
		MDCIconButtonToggle.prototype.createRipple = function() {
			var ripple = new MDCRipple(this.root);
			ripple.unbounded = true;
			return ripple;
		};
		return MDCIconButtonToggle;
	}(MDCComponent);

//#endregion
//#region Components/IconButtonToggle/MBIconButtonToggle.ts
	var MBIconButtonToggle_exports = /* @__PURE__ */ __exportAll({
		click: () => click,
		init: () => init$14,
		setOn: () => setOn
	});
	function init$14(elem) {
		if (!elem) return;
		elem._iconButtonToggle = MDCIconButtonToggle.attachTo(elem);
	}
	function setOn(elem, isOn) {
		if (!elem) return;
		elem._iconButtonToggle.on = isOn;
	}
	function click(elem) {
		if (!elem) return;
		elem._iconButtonToggle.root.click();
	}

//#endregion
//#region Components/LinearProgress/MBLinearProgress.ts
	var MBLinearProgress_exports = /* @__PURE__ */ __exportAll({
		init: () => init$13,
		restartAnimation: () => restartAnimation,
		setProgress: () => setProgress
	});
	function init$13(elem, progress, buffer) {
		if (!elem) return;
		elem._linearProgress = MDCLinearProgress.attachTo(elem);
		setProgress(elem, progress, buffer);
	}
	function setProgress(elem, progress, buffer) {
		if (!elem) return;
		elem._linearProgress.progress = progress;
		elem._linearProgress.buffer = buffer;
	}
	function restartAnimation(elem) {
		if (!elem) return;
		elem._linearProgress.foundation.restartAnimation();
	}

//#endregion
//#region Components/List/MBList.ts
	var MBList_exports = /* @__PURE__ */ __exportAll({ init: () => init$12 });
	function init$12(elem, keyboardInteractions, ripple) {
		if (!elem) return;
		if (keyboardInteractions == true) {
			elem._list = MDCList.attachTo(elem);
			if (ripple == true) elem._list.listElements.map((elem) => MDCRipple.attachTo(elem));
		}
	}

//#endregion
//#region Components/Menu/MBMenu.ts
	var MBMenu_exports = /* @__PURE__ */ __exportAll({
		hide: () => hide$2,
		init: () => init$11,
		show: () => show$2
	});
	function init$11(elem, dotNetObject) {
		if (!elem) return;
		elem._menu = MDCMenu.attachTo(elem);
		const closedCallback = () => {
			dotNetObject.invokeMethodAsync("NotifyClosed");
		};
		elem._menu.listen("MDCMenuSurface:closed", closedCallback);
	}
	function show$2(elem) {
		if (!elem) return;
		if (elem._menu) elem._menu.open = true;
	}
	function hide$2(elem) {
		if (!elem) return;
		if (elem._menu) elem._menu.open = false;
	}

//#endregion
//#region Components/MenuSurface/MBMenuSurface.ts
	var MBMenuSurface_exports = /* @__PURE__ */ __exportAll({
		hide: () => hide$1,
		init: () => init$10,
		show: () => show$1
	});
	function init$10(elem, dotNetObject) {
		if (!elem) return;
		elem._menu = MDCMenuSurface.attachTo(elem);
		const openedCallback = () => {
			dotNetObject.invokeMethodAsync("NotifyOpened");
		};
		elem._menu.listen("MDCMenuSurface:opened", openedCallback);
		const closedCallback = () => {
			dotNetObject.invokeMethodAsync("NotifyClosed");
		};
		elem._menu.listen("MDCMenuSurface:closed", closedCallback);
	}
	function show$1(elem) {
		if (!elem) return;
		if (elem._menu) elem._menu.open();
	}
	function hide$1(elem) {
		if (!elem) return;
		if (elem._menu) elem._menu.close();
	}

//#endregion
//#region Components/Popover/MBPopover.ts
	var MBPopover_exports = /* @__PURE__ */ __exportAll({
		hide: () => hide,
		show: () => show
	});
	function show(elem, dotNetObject) {
		if (!elem) return;
		elem._popover = elem._popover || MDCMenuSurface.attachTo(elem);
		elem._dotNetObject = dotNetObject;
		const openedCallback = () => {
			elem._popover.unlisten("MDCMenuSurface:opened", openedCallback);
			dotNetObject.invokeMethodAsync("NotifyOpened");
		};
		elem._popover.listen("MDCMenuSurface:opened", openedCallback);
		const closedCallback = () => {
			elem._popover.unlisten("MDCDialog:closing", closedCallback);
			dotNetObject.invokeMethodAsync("NotifyClosed");
		};
		elem._popover.listen("MDCMenuSurface:closed", closedCallback);
		elem._popover.open();
	}
	function hide(elem) {
		if (!elem) return;
		if (elem._popover) elem._popover.close();
	}

//#endregion
//#region node_modules/.pnpm/@material+radio@14.0.0/node_modules/@material/radio/constants.js
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
	var strings$9 = { NATIVE_CONTROL_SELECTOR: ".mdc-radio__native-control" };
	var cssClasses$8 = {
		DISABLED: "mdc-radio--disabled",
		ROOT: "mdc-radio"
	};

//#endregion
//#region node_modules/.pnpm/@material+radio@14.0.0/node_modules/@material/radio/foundation.js
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
	var MDCRadioFoundation = function(_super) {
		__extends(MDCRadioFoundation, _super);
		function MDCRadioFoundation(adapter) {
			return _super.call(this, __assign(__assign({}, MDCRadioFoundation.defaultAdapter), adapter)) || this;
		}
		Object.defineProperty(MDCRadioFoundation, "cssClasses", {
			get: function() {
				return cssClasses$8;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCRadioFoundation, "strings", {
			get: function() {
				return strings$9;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCRadioFoundation, "defaultAdapter", {
			get: function() {
				return {
					addClass: function() {},
					removeClass: function() {},
					setNativeControlDisabled: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCRadioFoundation.prototype.setDisabled = function(disabled) {
			var DISABLED = MDCRadioFoundation.cssClasses.DISABLED;
			this.adapter.setNativeControlDisabled(disabled);
			if (disabled) this.adapter.addClass(DISABLED);
			else this.adapter.removeClass(DISABLED);
		};
		return MDCRadioFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+radio@14.0.0/node_modules/@material/radio/component.js
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
	var MDCRadio = function(_super) {
		__extends(MDCRadio, _super);
		function MDCRadio() {
			var _this = _super !== null && _super.apply(this, arguments) || this;
			_this.rippleSurface = _this.createRipple();
			return _this;
		}
		MDCRadio.attachTo = function(root) {
			return new MDCRadio(root);
		};
		Object.defineProperty(MDCRadio.prototype, "checked", {
			get: function() {
				return this.nativeControl.checked;
			},
			set: function(checked) {
				this.nativeControl.checked = checked;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCRadio.prototype, "disabled", {
			get: function() {
				return this.nativeControl.disabled;
			},
			set: function(disabled) {
				this.foundation.setDisabled(disabled);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCRadio.prototype, "value", {
			get: function() {
				return this.nativeControl.value;
			},
			set: function(value) {
				this.nativeControl.value = value;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCRadio.prototype, "ripple", {
			get: function() {
				return this.rippleSurface;
			},
			enumerable: false,
			configurable: true
		});
		MDCRadio.prototype.destroy = function() {
			this.rippleSurface.destroy();
			_super.prototype.destroy.call(this);
		};
		MDCRadio.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCRadioFoundation({
				addClass: function(className) {
					return _this.root.classList.add(className);
				},
				removeClass: function(className) {
					return _this.root.classList.remove(className);
				},
				setNativeControlDisabled: function(disabled) {
					return _this.nativeControl.disabled = disabled;
				}
			});
		};
		MDCRadio.prototype.createRipple = function() {
			var _this = this;
			var adapter = __assign(__assign({}, MDCRipple.createAdapter(this)), {
				registerInteractionHandler: function(evtType, handler) {
					_this.nativeControl.addEventListener(evtType, handler, applyPassive());
				},
				deregisterInteractionHandler: function(evtType, handler) {
					_this.nativeControl.removeEventListener(evtType, handler, applyPassive());
				},
				isSurfaceActive: function() {
					return false;
				},
				isUnbounded: function() {
					return true;
				}
			});
			return new MDCRipple(this.root, new MDCRippleFoundation(adapter));
		};
		Object.defineProperty(MDCRadio.prototype, "nativeControl", {
			get: function() {
				var NATIVE_CONTROL_SELECTOR = MDCRadioFoundation.strings.NATIVE_CONTROL_SELECTOR;
				var el = this.root.querySelector(NATIVE_CONTROL_SELECTOR);
				if (!el) throw new Error("Radio component requires a " + NATIVE_CONTROL_SELECTOR + " element");
				return el;
			},
			enumerable: false,
			configurable: true
		});
		return MDCRadio;
	}(MDCComponent);

//#endregion
//#region Components/RadioButton/MBRadioButton.ts
	var MBRadioButton_exports = /* @__PURE__ */ __exportAll({
		init: () => init$9,
		setChecked: () => setChecked,
		setDisabled: () => setDisabled$5
	});
	function init$9(elem, formFieldElem, isChecked) {
		if (!elem) return;
		elem._radio = MDCRadio.attachTo(elem);
		elem._radio.checked = isChecked;
		elem._formField = MDCFormField.attachTo(formFieldElem);
		elem._formField.input = elem._radio;
	}
	function setDisabled$5(elem, value) {
		if (!elem) return;
		elem._radio.disabled = value;
	}
	function setChecked(elem, isChecked) {
		if (!elem) return;
		elem._radio.checked = isChecked;
	}

//#endregion
//#region node_modules/.pnpm/@material+segmented-button@14.0.0/node_modules/@material/segmented-button/segmented-button/constants.js
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
	/**
	* Selectors used by segmented-button
	*/
	var selectors = { SEGMENT: ".mdc-segmented-button__segment" };
	/**
	* Events received or emitted by segmented-button
	*/
	var events$3 = {
		SELECTED: "selected",
		CHANGE: "change"
	};
	/**
	* Style classes for segmented-button
	*/
	var cssClasses$7 = { SINGLE_SELECT: "mdc-segmented-button--single-select" };

//#endregion
//#region node_modules/.pnpm/@material+segmented-button@14.0.0/node_modules/@material/segmented-button/segmented-button/foundation.js
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
	var MDCSegmentedButtonFoundation = function(_super) {
		__extends(MDCSegmentedButtonFoundation, _super);
		function MDCSegmentedButtonFoundation(adapter) {
			return _super.call(this, __assign(__assign({}, MDCSegmentedButtonFoundation.defaultAdapter), adapter)) || this;
		}
		Object.defineProperty(MDCSegmentedButtonFoundation, "defaultAdapter", {
			get: function() {
				return {
					hasClass: function() {
						return false;
					},
					getSegments: function() {
						return [];
					},
					selectSegment: function() {},
					unselectSegment: function() {},
					notifySelectedChange: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		/**
		* Sets identified child segment to be selected
		*
		* @param indexOrSegmentId Number index or string segmentId that identifies
		* child segment
		*/
		MDCSegmentedButtonFoundation.prototype.selectSegment = function(indexOrSegmentId) {
			this.adapter.selectSegment(indexOrSegmentId);
		};
		/**
		* Sets identified child segment to be not selected
		*
		* @param indexOrSegmentId Number index or string segmentId that identifies
		* child segment
		*/
		MDCSegmentedButtonFoundation.prototype.unselectSegment = function(indexOrSegmentId) {
			this.adapter.unselectSegment(indexOrSegmentId);
		};
		/**
		* @return Returns currently selected child segments as readonly list of
		* SegmentDetails
		*/
		MDCSegmentedButtonFoundation.prototype.getSelectedSegments = function() {
			return this.adapter.getSegments().filter(function(segmentDetail) {
				return segmentDetail.selected;
			});
		};
		/**
		* @param indexOrSegmentId Number index or string segmentId that identifies
		* child segment
		* @return Returns true if identified child segment is currently selected,
		* otherwise returns false
		*/
		MDCSegmentedButtonFoundation.prototype.isSegmentSelected = function(indexOrSegmentId) {
			return this.adapter.getSegments().some(function(segmentDetail) {
				return (segmentDetail.index === indexOrSegmentId || segmentDetail.segmentId === indexOrSegmentId) && segmentDetail.selected;
			});
		};
		/**
		* @return Returns true if segmented button is single select, otherwise
		* returns false
		*/
		MDCSegmentedButtonFoundation.prototype.isSingleSelect = function() {
			return this.adapter.hasClass(cssClasses$7.SINGLE_SELECT);
		};
		/**
		* Called when child segment's selected status may have changed. If segmented
		* button is single select, unselects all child segments other than identified
		* child segment. Finally, emits event to client.
		*
		* @param detail Child segment affected represented as SegmentDetail
		* @event change With detail - SegmentDetail
		*/
		MDCSegmentedButtonFoundation.prototype.handleSelected = function(detail) {
			if (this.isSingleSelect()) this.unselectPrevSelected(detail.index);
			this.adapter.notifySelectedChange(detail);
		};
		/**
		* Sets all child segments to be not selected except for child segment
		* identified by index
		*
		* @param index Index of child segment to not unselect
		*/
		MDCSegmentedButtonFoundation.prototype.unselectPrevSelected = function(index) {
			var e_1, _a;
			try {
				for (var _b = __values(this.getSelectedSegments()), _c = _b.next(); !_c.done; _c = _b.next()) {
					var selectedSegment = _c.value;
					if (selectedSegment.index !== index) this.unselectSegment(selectedSegment.index);
				}
			} catch (e_1_1) {
				e_1 = { error: e_1_1 };
			} finally {
				try {
					if (_c && !_c.done && (_a = _b.return)) _a.call(_b);
				} finally {
					if (e_1) throw e_1.error;
				}
			}
		};
		return MDCSegmentedButtonFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+segmented-button@14.0.0/node_modules/@material/segmented-button/segment/constants.js
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
	/**
	* Boolean strings for segment
	*/
	var booleans = {
		TRUE: "true",
		FALSE: "false"
	};
	/**
	* Attributes referenced by segment
	*/
	var attributes$2 = {
		ARIA_CHECKED: "aria-checked",
		ARIA_PRESSED: "aria-pressed",
		DATA_SEGMENT_ID: "data-segment-id"
	};
	/**
	* Events received or emitted by segment
	*/
	var events$2 = {
		CLICK: "click",
		SELECTED: "selected"
	};
	/**
	* Style classes for segment
	*/
	var cssClasses$6 = { SELECTED: "mdc-segmented-button__segment--selected" };

//#endregion
//#region node_modules/.pnpm/@material+segmented-button@14.0.0/node_modules/@material/segmented-button/segment/foundation.js
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
	var emptyClientRect = {
		bottom: 0,
		height: 0,
		left: 0,
		right: 0,
		top: 0,
		width: 0
	};
	var MDCSegmentedButtonSegmentFoundation = function(_super) {
		__extends(MDCSegmentedButtonSegmentFoundation, _super);
		function MDCSegmentedButtonSegmentFoundation(adapter) {
			return _super.call(this, __assign(__assign({}, MDCSegmentedButtonSegmentFoundation.defaultAdapter), adapter)) || this;
		}
		Object.defineProperty(MDCSegmentedButtonSegmentFoundation, "defaultAdapter", {
			get: function() {
				return {
					isSingleSelect: function() {
						return false;
					},
					getAttr: function() {
						return "";
					},
					setAttr: function() {},
					addClass: function() {},
					removeClass: function() {},
					hasClass: function() {
						return false;
					},
					notifySelectedChange: function() {},
					getRootBoundingClientRect: function() {
						return emptyClientRect;
					}
				};
			},
			enumerable: false,
			configurable: true
		});
		/**
		* @return Returns true if segment is currently selected, otherwise returns
		* false
		*/
		MDCSegmentedButtonSegmentFoundation.prototype.isSelected = function() {
			return this.adapter.hasClass(cssClasses$6.SELECTED);
		};
		/**
		* Sets segment to be selected
		*/
		MDCSegmentedButtonSegmentFoundation.prototype.setSelected = function() {
			this.adapter.addClass(cssClasses$6.SELECTED);
			this.setAriaAttr(booleans.TRUE);
		};
		/**
		* Sets segment to be not selected
		*/
		MDCSegmentedButtonSegmentFoundation.prototype.setUnselected = function() {
			this.adapter.removeClass(cssClasses$6.SELECTED);
			this.setAriaAttr(booleans.FALSE);
		};
		/**
		* @return Returns segment's segmentId if it was set by client
		*/
		MDCSegmentedButtonSegmentFoundation.prototype.getSegmentId = function() {
			var _a;
			return (_a = this.adapter.getAttr(attributes$2.DATA_SEGMENT_ID)) !== null && _a !== void 0 ? _a : void 0;
		};
		/**
		* Called when segment is clicked. If the wrapping segmented button is single
		* select, doesn't allow segment to be set to not selected. Otherwise, toggles
		* segment's selected status. Finally, emits event to wrapping segmented
		* button.
		*
		* @event selected With detail - SegmentDetail
		*/
		MDCSegmentedButtonSegmentFoundation.prototype.handleClick = function() {
			if (this.adapter.isSingleSelect()) this.setSelected();
			else this.toggleSelection();
			this.adapter.notifySelectedChange(this.isSelected());
		};
		/**
		* @return Returns bounding rectangle for ripple effect
		*/
		MDCSegmentedButtonSegmentFoundation.prototype.getDimensions = function() {
			return this.adapter.getRootBoundingClientRect();
		};
		/**
		* Sets segment from not selected to selected, or selected to not selected
		*/
		MDCSegmentedButtonSegmentFoundation.prototype.toggleSelection = function() {
			if (this.isSelected()) this.setUnselected();
			else this.setSelected();
		};
		/**
		* Sets appropriate aria attribute, based on wrapping segmented button's
		* single selected value, to new value
		*
		* @param value Value that represents selected status
		*/
		MDCSegmentedButtonSegmentFoundation.prototype.setAriaAttr = function(value) {
			if (this.adapter.isSingleSelect()) this.adapter.setAttr(attributes$2.ARIA_CHECKED, value);
			else this.adapter.setAttr(attributes$2.ARIA_PRESSED, value);
		};
		return MDCSegmentedButtonSegmentFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+segmented-button@14.0.0/node_modules/@material/segmented-button/segment/component.js
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
	/**
	* Implementation of MDCSegmentedButtonSegmentFoundation
	*/
	var MDCSegmentedButtonSegment = function(_super) {
		__extends(MDCSegmentedButtonSegment, _super);
		function MDCSegmentedButtonSegment() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		Object.defineProperty(MDCSegmentedButtonSegment.prototype, "ripple", {
			get: function() {
				return this.rippleComponent;
			},
			enumerable: false,
			configurable: true
		});
		MDCSegmentedButtonSegment.attachTo = function(root) {
			return new MDCSegmentedButtonSegment(root);
		};
		MDCSegmentedButtonSegment.prototype.initialize = function(rippleFactory) {
			var _this = this;
			if (rippleFactory === void 0) rippleFactory = function(el, foundation) {
				return new MDCRipple(el, foundation);
			};
			var rippleAdapter = __assign(__assign({}, MDCRipple.createAdapter(this)), { computeBoundingRect: function() {
				return _this.foundation.getDimensions();
			} });
			this.rippleComponent = rippleFactory(this.root, new MDCRippleFoundation(rippleAdapter));
		};
		MDCSegmentedButtonSegment.prototype.initialSyncWithDOM = function() {
			var _this = this;
			this.handleClick = function() {
				_this.foundation.handleClick();
			};
			this.listen(events$2.CLICK, this.handleClick);
		};
		MDCSegmentedButtonSegment.prototype.destroy = function() {
			this.ripple.destroy();
			this.unlisten(events$2.CLICK, this.handleClick);
			_super.prototype.destroy.call(this);
		};
		MDCSegmentedButtonSegment.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCSegmentedButtonSegmentFoundation({
				isSingleSelect: function() {
					return _this.isSingleSelect;
				},
				getAttr: function(attrName) {
					return _this.root.getAttribute(attrName);
				},
				setAttr: function(attrName, value) {
					_this.root.setAttribute(attrName, value);
				},
				addClass: function(className) {
					_this.root.classList.add(className);
				},
				removeClass: function(className) {
					_this.root.classList.remove(className);
				},
				hasClass: function(className) {
					return _this.root.classList.contains(className);
				},
				notifySelectedChange: function(selected) {
					_this.emit(events$2.SELECTED, {
						index: _this.index,
						selected,
						segmentId: _this.getSegmentId()
					}, true);
				},
				getRootBoundingClientRect: function() {
					return _this.root.getBoundingClientRect();
				}
			});
		};
		/**
		* Sets segment's index value
		*
		* @param index Segment's index within wrapping segmented button
		*/
		MDCSegmentedButtonSegment.prototype.setIndex = function(index) {
			this.index = index;
		};
		/**
		* Sets segment's isSingleSelect value
		*
		* @param isSingleSelect True if wrapping segmented button is single select
		*/
		MDCSegmentedButtonSegment.prototype.setIsSingleSelect = function(isSingleSelect) {
			this.isSingleSelect = isSingleSelect;
		};
		/**
		* @return Returns true if segment is currently selected, otherwise returns
		* false
		*/
		MDCSegmentedButtonSegment.prototype.isSelected = function() {
			return this.foundation.isSelected();
		};
		/**
		* Sets segment to be selected
		*/
		MDCSegmentedButtonSegment.prototype.setSelected = function() {
			this.foundation.setSelected();
		};
		/**
		* Sets segment to be not selected
		*/
		MDCSegmentedButtonSegment.prototype.setUnselected = function() {
			this.foundation.setUnselected();
		};
		/**
		* @return Returns segment's segmentId if it was set by client
		*/
		MDCSegmentedButtonSegment.prototype.getSegmentId = function() {
			return this.foundation.getSegmentId();
		};
		return MDCSegmentedButtonSegment;
	}(MDCComponent);

//#endregion
//#region node_modules/.pnpm/@material+segmented-button@14.0.0/node_modules/@material/segmented-button/segmented-button/component.js
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
	var MDCSegmentedButton = function(_super) {
		__extends(MDCSegmentedButton, _super);
		function MDCSegmentedButton() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCSegmentedButton.attachTo = function(root) {
			return new MDCSegmentedButton(root);
		};
		Object.defineProperty(MDCSegmentedButton.prototype, "segments", {
			get: function() {
				return this.segmentsList.slice();
			},
			enumerable: false,
			configurable: true
		});
		MDCSegmentedButton.prototype.initialize = function(segmentFactory) {
			if (segmentFactory === void 0) segmentFactory = function(el) {
				return new MDCSegmentedButtonSegment(el);
			};
			this.segmentFactory = segmentFactory;
			this.segmentsList = this.instantiateSegments(this.segmentFactory);
		};
		/**
		* @param segmentFactory Factory to create new child segments
		* @return Returns list of child segments found in DOM
		*/
		MDCSegmentedButton.prototype.instantiateSegments = function(segmentFactory) {
			return [].slice.call(this.root.querySelectorAll(selectors.SEGMENT)).map(function(el) {
				return segmentFactory(el);
			});
		};
		MDCSegmentedButton.prototype.initialSyncWithDOM = function() {
			var _this = this;
			this.handleSelected = function(event) {
				_this.foundation.handleSelected(event.detail);
			};
			this.listen(events$3.SELECTED, this.handleSelected);
			var isSingleSelect = this.foundation.isSingleSelect();
			for (var i = 0; i < this.segmentsList.length; i++) {
				var segment = this.segmentsList[i];
				segment.setIndex(i);
				segment.setIsSingleSelect(isSingleSelect);
			}
			var selectedSegments = this.segmentsList.filter(function(segment) {
				return segment.isSelected();
			});
			if (isSingleSelect && selectedSegments.length === 0 && this.segmentsList.length > 0) throw new Error("No segment selected in singleSelect mdc-segmented-button");
			else if (isSingleSelect && selectedSegments.length > 1) throw new Error("Multiple segments selected in singleSelect mdc-segmented-button");
		};
		MDCSegmentedButton.prototype.destroy = function() {
			var e_1, _a;
			try {
				for (var _b = __values(this.segmentsList), _c = _b.next(); !_c.done; _c = _b.next()) _c.value.destroy();
			} catch (e_1_1) {
				e_1 = { error: e_1_1 };
			} finally {
				try {
					if (_c && !_c.done && (_a = _b.return)) _a.call(_b);
				} finally {
					if (e_1) throw e_1.error;
				}
			}
			this.unlisten(events$3.SELECTED, this.handleSelected);
			_super.prototype.destroy.call(this);
		};
		MDCSegmentedButton.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCSegmentedButtonFoundation({
				hasClass: function(className) {
					return _this.root.classList.contains(className);
				},
				getSegments: function() {
					return _this.mappedSegments();
				},
				selectSegment: function(indexOrSegmentId) {
					var segmentDetail = _this.mappedSegments().find(function(detail) {
						return detail.index === indexOrSegmentId || detail.segmentId === indexOrSegmentId;
					});
					if (segmentDetail) _this.segmentsList[segmentDetail.index].setSelected();
				},
				unselectSegment: function(indexOrSegmentId) {
					var segmentDetail = _this.mappedSegments().find(function(detail) {
						return detail.index === indexOrSegmentId || detail.segmentId === indexOrSegmentId;
					});
					if (segmentDetail) _this.segmentsList[segmentDetail.index].setUnselected();
				},
				notifySelectedChange: function(detail) {
					_this.emit(events$3.CHANGE, detail, true);
				}
			});
		};
		/**
		* @return Returns readonly list of selected child segments as SegmentDetails
		*/
		MDCSegmentedButton.prototype.getSelectedSegments = function() {
			return this.foundation.getSelectedSegments();
		};
		/**
		* Sets identified segment to be selected
		*
		* @param indexOrSegmentId Number index or string segmentId that identifies
		* child segment
		*/
		MDCSegmentedButton.prototype.selectSegment = function(indexOrSegmentId) {
			this.foundation.selectSegment(indexOrSegmentId);
		};
		/**
		* Sets identified segment to be not selected
		*
		* @param indexOrSegmentId Number index or string segmentId that identifies
		* child segment
		*/
		MDCSegmentedButton.prototype.unselectSegment = function(indexOrSegmentId) {
			this.foundation.unselectSegment(indexOrSegmentId);
		};
		/**
		* @param indexOrSegmentId Number index or string segmentId that identifies
		* child segment
		* @return Returns true if identified child segment is currently selected,
		* otherwise returns false
		*/
		MDCSegmentedButton.prototype.isSegmentSelected = function(indexOrSegmentId) {
			return this.foundation.isSegmentSelected(indexOrSegmentId);
		};
		/**
		* @return Returns child segments mapped to readonly SegmentDetail list
		*/
		MDCSegmentedButton.prototype.mappedSegments = function() {
			return this.segmentsList.map(function(segment, index) {
				return {
					index,
					selected: segment.isSelected(),
					segmentId: segment.getSegmentId()
				};
			});
		};
		return MDCSegmentedButton;
	}(MDCComponent);

//#endregion
//#region node_modules/.pnpm/@material+segmented-button@14.0.0/node_modules/@material/segmented-button/segmented-button/index.js
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

//#endregion
//#region node_modules/.pnpm/@material+segmented-button@14.0.0/node_modules/@material/segmented-button/segment/index.js
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

//#endregion
//#region node_modules/.pnpm/@material+segmented-button@14.0.0/node_modules/@material/segmented-button/index.js
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

//#endregion
//#region Components/SegmentedButtonMulti/MBSegmentedButtonMulti.ts
	var MBSegmentedButtonMulti_exports = /* @__PURE__ */ __exportAll({
		init: () => init$8,
		setDisabled: () => setDisabled$4,
		setSelected: () => setSelected$1
	});
	function init$8(elem, isSingleSelect, dotNetObject) {
		if (!elem) return;
		elem._segmentedButton = MDCSegmentedButton.attachTo(elem);
		elem._isSingleSelect = isSingleSelect;
		elem._segmentedButton.foundation.adapter.notifySelectedChange = (detail) => {
			if (elem._isSingleSelect) dotNetObject.invokeMethodAsync("NotifySingleSelected", detail.index);
			else dotNetObject.invokeMethodAsync("NotifyMultiSelected", elem._segmentedButton.segments.map((x) => x.isSelected()));
		};
	}
	function setDisabled$4(elem, value) {
		if (!elem) return;
		elem._segmentedButton.disabled = value;
	}
	function setSelected$1(elem, selectedFlags) {
		if (!elem) return;
		for (let i = 0; i < selectedFlags.length; i++) if (selectedFlags[i] == true) elem._segmentedButton.segments[i].setSelected();
		else elem._segmentedButton.segments[i].setUnselected();
	}

//#endregion
//#region Components/Select/MBSelect.ts
	var MBSelect_exports = /* @__PURE__ */ __exportAll({
		init: () => init$7,
		setDisabled: () => setDisabled$3,
		setIndex: () => setIndex
	});
	function init$7(elem, dotNetObject) {
		if (!elem) return;
		elem._select = MDCSelect.attachTo(elem);
		elem._select.listen("MDCSelect:change", () => {
			dotNetObject.invokeMethodAsync("NotifySelected", elem._select.selectedIndex);
		});
	}
	function setDisabled$3(elem, value) {
		if (!elem) return;
		elem._select.disabled = value;
	}
	function setIndex(elem, index) {
		if (!elem) return;
		elem._select.selectedIndex = index;
	}

//#endregion
//#region node_modules/.pnpm/@material+slider@14.0.0/node_modules/@material/slider/constants.js
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
	/** Slider element classes. */
	var cssClasses$5 = {
		DISABLED: "mdc-slider--disabled",
		DISCRETE: "mdc-slider--discrete",
		INPUT: "mdc-slider__input",
		RANGE: "mdc-slider--range",
		THUMB: "mdc-slider__thumb",
		THUMB_FOCUSED: "mdc-slider__thumb--focused",
		THUMB_KNOB: "mdc-slider__thumb-knob",
		THUMB_TOP: "mdc-slider__thumb--top",
		THUMB_WITH_INDICATOR: "mdc-slider__thumb--with-indicator",
		TICK_MARKS: "mdc-slider--tick-marks",
		TICK_MARKS_CONTAINER: "mdc-slider__tick-marks",
		TICK_MARK_ACTIVE: "mdc-slider__tick-mark--active",
		TICK_MARK_INACTIVE: "mdc-slider__tick-mark--inactive",
		TRACK: "mdc-slider__track",
		TRACK_ACTIVE: "mdc-slider__track--active_fill",
		VALUE_INDICATOR_CONTAINER: "mdc-slider__value-indicator-container",
		VALUE_INDICATOR_TEXT: "mdc-slider__value-indicator-text"
	};
	/** Slider numbers. */
	var numbers$4 = {
		STEP_SIZE: 1,
		MIN_RANGE: 0,
		THUMB_UPDATE_MIN_PX: 5
	};
	/** Slider attributes. */
	var attributes$1 = {
		ARIA_VALUETEXT: "aria-valuetext",
		INPUT_DISABLED: "disabled",
		INPUT_MIN: "min",
		INPUT_MAX: "max",
		INPUT_VALUE: "value",
		INPUT_STEP: "step",
		DATA_MIN_RANGE: "data-min-range"
	};
	/** Slider events. */
	var events$1 = {
		CHANGE: "MDCSlider:change",
		INPUT: "MDCSlider:input"
	};
	/** Slider strings. */
	var strings$8 = {
		VAR_VALUE_INDICATOR_CARET_LEFT: "--slider-value-indicator-caret-left",
		VAR_VALUE_INDICATOR_CARET_RIGHT: "--slider-value-indicator-caret-right",
		VAR_VALUE_INDICATOR_CARET_TRANSFORM: "--slider-value-indicator-caret-transform",
		VAR_VALUE_INDICATOR_CONTAINER_LEFT: "--slider-value-indicator-container-left",
		VAR_VALUE_INDICATOR_CONTAINER_RIGHT: "--slider-value-indicator-container-right",
		VAR_VALUE_INDICATOR_CONTAINER_TRANSFORM: "--slider-value-indicator-container-transform"
	};

//#endregion
//#region node_modules/.pnpm/@material+slider@14.0.0/node_modules/@material/slider/types.js
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
	/** Tick mark enum, for discrete sliders. */
	var TickMark;
	(function(TickMark) {
		TickMark[TickMark["ACTIVE"] = 0] = "ACTIVE";
		TickMark[TickMark["INACTIVE"] = 1] = "INACTIVE";
	})(TickMark || (TickMark = {}));
	/**
	* Thumb types: range slider has two thumbs (START, END) whereas single point
	* slider only has one thumb (END).
	*/
	var Thumb;
	(function(Thumb) {
		Thumb[Thumb["START"] = 1] = "START";
		Thumb[Thumb["END"] = 2] = "END";
	})(Thumb || (Thumb = {}));

//#endregion
//#region node_modules/.pnpm/@material+slider@14.0.0/node_modules/@material/slider/foundation.js
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
	var AnimationKeys$1;
	(function(AnimationKeys) {
		AnimationKeys["SLIDER_UPDATE"] = "slider_update";
	})(AnimationKeys$1 || (AnimationKeys$1 = {}));
	var HAS_WINDOW$1 = typeof window !== "undefined";
	/**
	* Foundation class for slider. Responsibilities include:
	* - Updating slider values (internal state and DOM updates) based on client
	*   'x' position.
	* - Updating DOM after slider property updates (e.g. min, max).
	*/
	var MDCSliderFoundation = function(_super) {
		__extends(MDCSliderFoundation, _super);
		function MDCSliderFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCSliderFoundation.defaultAdapter), adapter)) || this;
			_this.initialStylesRemoved = false;
			_this.isDisabled = false;
			_this.isDiscrete = false;
			_this.step = numbers$4.STEP_SIZE;
			_this.minRange = numbers$4.MIN_RANGE;
			_this.hasTickMarks = false;
			_this.isRange = false;
			_this.thumb = null;
			_this.downEventClientX = null;
			_this.startThumbKnobWidth = 0;
			_this.endThumbKnobWidth = 0;
			_this.animFrame = new AnimationFrame();
			return _this;
		}
		Object.defineProperty(MDCSliderFoundation, "defaultAdapter", {
			get: function() {
				return {
					hasClass: function() {
						return false;
					},
					addClass: function() {},
					removeClass: function() {},
					addThumbClass: function() {},
					removeThumbClass: function() {},
					getAttribute: function() {
						return null;
					},
					getInputValue: function() {
						return "";
					},
					setInputValue: function() {},
					getInputAttribute: function() {
						return null;
					},
					setInputAttribute: function() {
						return null;
					},
					removeInputAttribute: function() {
						return null;
					},
					focusInput: function() {},
					isInputFocused: function() {
						return false;
					},
					shouldHideFocusStylesForPointerEvents: function() {
						return false;
					},
					getThumbKnobWidth: function() {
						return 0;
					},
					getValueIndicatorContainerWidth: function() {
						return 0;
					},
					getThumbBoundingClientRect: function() {
						return {
							top: 0,
							right: 0,
							bottom: 0,
							left: 0,
							width: 0,
							height: 0
						};
					},
					getBoundingClientRect: function() {
						return {
							top: 0,
							right: 0,
							bottom: 0,
							left: 0,
							width: 0,
							height: 0
						};
					},
					isRTL: function() {
						return false;
					},
					setThumbStyleProperty: function() {},
					removeThumbStyleProperty: function() {},
					setTrackActiveStyleProperty: function() {},
					removeTrackActiveStyleProperty: function() {},
					setValueIndicatorText: function() {},
					getValueToAriaValueTextFn: function() {
						return null;
					},
					updateTickMarks: function() {},
					setPointerCapture: function() {},
					emitChangeEvent: function() {},
					emitInputEvent: function() {},
					emitDragStartEvent: function() {},
					emitDragEndEvent: function() {},
					registerEventHandler: function() {},
					deregisterEventHandler: function() {},
					registerThumbEventHandler: function() {},
					deregisterThumbEventHandler: function() {},
					registerInputEventHandler: function() {},
					deregisterInputEventHandler: function() {},
					registerBodyEventHandler: function() {},
					deregisterBodyEventHandler: function() {},
					registerWindowEventHandler: function() {},
					deregisterWindowEventHandler: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCSliderFoundation.prototype.init = function() {
			var _this = this;
			this.isDisabled = this.adapter.hasClass(cssClasses$5.DISABLED);
			this.isDiscrete = this.adapter.hasClass(cssClasses$5.DISCRETE);
			this.hasTickMarks = this.adapter.hasClass(cssClasses$5.TICK_MARKS);
			this.isRange = this.adapter.hasClass(cssClasses$5.RANGE);
			var min = this.convertAttributeValueToNumber(this.adapter.getInputAttribute(attributes$1.INPUT_MIN, this.isRange ? Thumb.START : Thumb.END), attributes$1.INPUT_MIN);
			var max = this.convertAttributeValueToNumber(this.adapter.getInputAttribute(attributes$1.INPUT_MAX, Thumb.END), attributes$1.INPUT_MAX);
			var value = this.convertAttributeValueToNumber(this.adapter.getInputAttribute(attributes$1.INPUT_VALUE, Thumb.END), attributes$1.INPUT_VALUE);
			var valueStart = this.isRange ? this.convertAttributeValueToNumber(this.adapter.getInputAttribute(attributes$1.INPUT_VALUE, Thumb.START), attributes$1.INPUT_VALUE) : min;
			var stepAttr = this.adapter.getInputAttribute(attributes$1.INPUT_STEP, Thumb.END);
			var step = stepAttr ? this.convertAttributeValueToNumber(stepAttr, attributes$1.INPUT_STEP) : this.step;
			var minRangeAttr = this.adapter.getAttribute(attributes$1.DATA_MIN_RANGE);
			var minRange = minRangeAttr ? this.convertAttributeValueToNumber(minRangeAttr, attributes$1.DATA_MIN_RANGE) : this.minRange;
			this.validateProperties({
				min,
				max,
				value,
				valueStart,
				step,
				minRange
			});
			this.min = min;
			this.max = max;
			this.value = value;
			this.valueStart = valueStart;
			this.step = step;
			this.minRange = minRange;
			this.numDecimalPlaces = getNumDecimalPlaces(this.step);
			this.valueBeforeDownEvent = value;
			this.valueStartBeforeDownEvent = valueStart;
			this.mousedownOrTouchstartListener = this.handleMousedownOrTouchstart.bind(this);
			this.moveListener = this.handleMove.bind(this);
			this.pointerdownListener = this.handlePointerdown.bind(this);
			this.pointerupListener = this.handlePointerup.bind(this);
			this.thumbMouseenterListener = this.handleThumbMouseenter.bind(this);
			this.thumbMouseleaveListener = this.handleThumbMouseleave.bind(this);
			this.inputStartChangeListener = function() {
				_this.handleInputChange(Thumb.START);
			};
			this.inputEndChangeListener = function() {
				_this.handleInputChange(Thumb.END);
			};
			this.inputStartFocusListener = function() {
				_this.handleInputFocus(Thumb.START);
			};
			this.inputEndFocusListener = function() {
				_this.handleInputFocus(Thumb.END);
			};
			this.inputStartBlurListener = function() {
				_this.handleInputBlur(Thumb.START);
			};
			this.inputEndBlurListener = function() {
				_this.handleInputBlur(Thumb.END);
			};
			this.resizeListener = this.handleResize.bind(this);
			this.registerEventHandlers();
		};
		MDCSliderFoundation.prototype.destroy = function() {
			this.deregisterEventHandlers();
		};
		MDCSliderFoundation.prototype.setMin = function(value) {
			this.min = value;
			if (!this.isRange) this.valueStart = value;
			this.updateUI();
		};
		MDCSliderFoundation.prototype.setMax = function(value) {
			this.max = value;
			this.updateUI();
		};
		MDCSliderFoundation.prototype.getMin = function() {
			return this.min;
		};
		MDCSliderFoundation.prototype.getMax = function() {
			return this.max;
		};
		/**
		* - For single point sliders, returns the thumb value.
		* - For range (two-thumb) sliders, returns the end thumb's value.
		*/
		MDCSliderFoundation.prototype.getValue = function() {
			return this.value;
		};
		/**
		* - For single point sliders, sets the thumb value.
		* - For range (two-thumb) sliders, sets the end thumb's value.
		*/
		MDCSliderFoundation.prototype.setValue = function(value) {
			if (this.isRange && value < this.valueStart + this.minRange) throw new Error("end thumb value (" + value + ") must be >= start thumb " + ("value (" + this.valueStart + ") + min range (" + this.minRange + ")"));
			this.updateValue(value, Thumb.END);
		};
		/**
		* Only applicable for range sliders.
		* @return The start thumb's value.
		*/
		MDCSliderFoundation.prototype.getValueStart = function() {
			if (!this.isRange) throw new Error("`valueStart` is only applicable for range sliders.");
			return this.valueStart;
		};
		/**
		* Only applicable for range sliders. Sets the start thumb's value.
		*/
		MDCSliderFoundation.prototype.setValueStart = function(valueStart) {
			if (!this.isRange) throw new Error("`valueStart` is only applicable for range sliders.");
			if (this.isRange && valueStart > this.value - this.minRange) throw new Error("start thumb value (" + valueStart + ") must be <= end thumb " + ("value (" + this.value + ") - min range (" + this.minRange + ")"));
			this.updateValue(valueStart, Thumb.START);
		};
		MDCSliderFoundation.prototype.setStep = function(value) {
			this.step = value;
			this.numDecimalPlaces = getNumDecimalPlaces(value);
			this.updateUI();
		};
		/**
		* Only applicable for range sliders. Sets the minimum difference between the
		* start and end values.
		*/
		MDCSliderFoundation.prototype.setMinRange = function(value) {
			if (!this.isRange) throw new Error("`minRange` is only applicable for range sliders.");
			if (value < 0) throw new Error("`minRange` must be non-negative. " + ("Current value: " + value));
			if (this.value - this.valueStart < value) throw new Error("start thumb value (" + this.valueStart + ") and end thumb value " + ("(" + this.value + ") must differ by at least " + value + "."));
			this.minRange = value;
		};
		MDCSliderFoundation.prototype.setIsDiscrete = function(value) {
			this.isDiscrete = value;
			this.updateValueIndicatorUI();
			this.updateTickMarksUI();
		};
		MDCSliderFoundation.prototype.getStep = function() {
			return this.step;
		};
		MDCSliderFoundation.prototype.getMinRange = function() {
			if (!this.isRange) throw new Error("`minRange` is only applicable for range sliders.");
			return this.minRange;
		};
		MDCSliderFoundation.prototype.setHasTickMarks = function(value) {
			this.hasTickMarks = value;
			this.updateTickMarksUI();
		};
		MDCSliderFoundation.prototype.getDisabled = function() {
			return this.isDisabled;
		};
		/**
		* Sets disabled state, including updating styles and thumb tabindex.
		*/
		MDCSliderFoundation.prototype.setDisabled = function(disabled) {
			this.isDisabled = disabled;
			if (disabled) {
				this.adapter.addClass(cssClasses$5.DISABLED);
				if (this.isRange) this.adapter.setInputAttribute(attributes$1.INPUT_DISABLED, "", Thumb.START);
				this.adapter.setInputAttribute(attributes$1.INPUT_DISABLED, "", Thumb.END);
			} else {
				this.adapter.removeClass(cssClasses$5.DISABLED);
				if (this.isRange) this.adapter.removeInputAttribute(attributes$1.INPUT_DISABLED, Thumb.START);
				this.adapter.removeInputAttribute(attributes$1.INPUT_DISABLED, Thumb.END);
			}
		};
		/** @return Whether the slider is a range slider. */
		MDCSliderFoundation.prototype.getIsRange = function() {
			return this.isRange;
		};
		/**
		* - Syncs slider boundingClientRect with the current DOM.
		* - Updates UI based on internal state.
		*/
		MDCSliderFoundation.prototype.layout = function(_a) {
			var skipUpdateUI = (_a === void 0 ? {} : _a).skipUpdateUI;
			this.rect = this.adapter.getBoundingClientRect();
			if (this.isRange) {
				this.startThumbKnobWidth = this.adapter.getThumbKnobWidth(Thumb.START);
				this.endThumbKnobWidth = this.adapter.getThumbKnobWidth(Thumb.END);
			}
			if (!skipUpdateUI) this.updateUI();
		};
		/** Handles resize events on the window. */
		MDCSliderFoundation.prototype.handleResize = function() {
			this.layout();
		};
		/**
		* Handles pointer down events on the slider root element.
		*/
		MDCSliderFoundation.prototype.handleDown = function(event) {
			if (this.isDisabled) return;
			this.valueStartBeforeDownEvent = this.valueStart;
			this.valueBeforeDownEvent = this.value;
			var clientX = event.clientX != null ? event.clientX : event.targetTouches[0].clientX;
			this.downEventClientX = clientX;
			var value = this.mapClientXOnSliderScale(clientX);
			this.thumb = this.getThumbFromDownEvent(clientX, value);
			if (this.thumb === null) return;
			this.handleDragStart(event, value, this.thumb);
			this.updateValue(value, this.thumb, { emitInputEvent: true });
		};
		/**
		* Handles pointer move events on the slider root element.
		*/
		MDCSliderFoundation.prototype.handleMove = function(event) {
			if (this.isDisabled) return;
			event.preventDefault();
			var clientX = event.clientX != null ? event.clientX : event.targetTouches[0].clientX;
			var dragAlreadyStarted = this.thumb != null;
			this.thumb = this.getThumbFromMoveEvent(clientX);
			if (this.thumb === null) return;
			var value = this.mapClientXOnSliderScale(clientX);
			if (!dragAlreadyStarted) {
				this.handleDragStart(event, value, this.thumb);
				this.adapter.emitDragStartEvent(value, this.thumb);
			}
			this.updateValue(value, this.thumb, { emitInputEvent: true });
		};
		/**
		* Handles pointer up events on the slider root element.
		*/
		MDCSliderFoundation.prototype.handleUp = function() {
			var _a, _b;
			if (this.isDisabled || this.thumb === null) return;
			if ((_b = (_a = this.adapter).shouldHideFocusStylesForPointerEvents) === null || _b === void 0 ? void 0 : _b.call(_a)) this.handleInputBlur(this.thumb);
			var oldValue = this.thumb === Thumb.START ? this.valueStartBeforeDownEvent : this.valueBeforeDownEvent;
			var newValue = this.thumb === Thumb.START ? this.valueStart : this.value;
			if (oldValue !== newValue) this.adapter.emitChangeEvent(newValue, this.thumb);
			this.adapter.emitDragEndEvent(newValue, this.thumb);
			this.thumb = null;
		};
		/**
		* For range, discrete slider, shows the value indicator on both thumbs.
		*/
		MDCSliderFoundation.prototype.handleThumbMouseenter = function() {
			if (!this.isDiscrete || !this.isRange) return;
			this.adapter.addThumbClass(cssClasses$5.THUMB_WITH_INDICATOR, Thumb.START);
			this.adapter.addThumbClass(cssClasses$5.THUMB_WITH_INDICATOR, Thumb.END);
		};
		/**
		* For range, discrete slider, hides the value indicator on both thumbs.
		*/
		MDCSliderFoundation.prototype.handleThumbMouseleave = function() {
			var _a, _b;
			if (!this.isDiscrete || !this.isRange) return;
			if (!((_b = (_a = this.adapter).shouldHideFocusStylesForPointerEvents) === null || _b === void 0 ? void 0 : _b.call(_a)) && (this.adapter.isInputFocused(Thumb.START) || this.adapter.isInputFocused(Thumb.END)) || this.thumb) return;
			this.adapter.removeThumbClass(cssClasses$5.THUMB_WITH_INDICATOR, Thumb.START);
			this.adapter.removeThumbClass(cssClasses$5.THUMB_WITH_INDICATOR, Thumb.END);
		};
		MDCSliderFoundation.prototype.handleMousedownOrTouchstart = function(event) {
			var _this = this;
			var moveEventType = event.type === "mousedown" ? "mousemove" : "touchmove";
			this.adapter.registerBodyEventHandler(moveEventType, this.moveListener);
			var upHandler = function() {
				_this.handleUp();
				_this.adapter.deregisterBodyEventHandler(moveEventType, _this.moveListener);
				_this.adapter.deregisterEventHandler("mouseup", upHandler);
				_this.adapter.deregisterEventHandler("touchend", upHandler);
			};
			this.adapter.registerBodyEventHandler("mouseup", upHandler);
			this.adapter.registerBodyEventHandler("touchend", upHandler);
			this.handleDown(event);
		};
		MDCSliderFoundation.prototype.handlePointerdown = function(event) {
			if (!(event.button === 0)) return;
			if (event.pointerId != null) this.adapter.setPointerCapture(event.pointerId);
			this.adapter.registerEventHandler("pointermove", this.moveListener);
			this.handleDown(event);
		};
		/**
		* Handles input `change` event by setting internal slider value to match
		* input's new value.
		*/
		MDCSliderFoundation.prototype.handleInputChange = function(thumb) {
			var value = Number(this.adapter.getInputValue(thumb));
			if (thumb === Thumb.START) this.setValueStart(value);
			else this.setValue(value);
			this.adapter.emitChangeEvent(thumb === Thumb.START ? this.valueStart : this.value, thumb);
			this.adapter.emitInputEvent(thumb === Thumb.START ? this.valueStart : this.value, thumb);
		};
		/** Shows activated state and value indicator on thumb(s). */
		MDCSliderFoundation.prototype.handleInputFocus = function(thumb) {
			this.adapter.addThumbClass(cssClasses$5.THUMB_FOCUSED, thumb);
			if (!this.isDiscrete) return;
			this.adapter.addThumbClass(cssClasses$5.THUMB_WITH_INDICATOR, thumb);
			if (this.isRange) {
				var otherThumb = thumb === Thumb.START ? Thumb.END : Thumb.START;
				this.adapter.addThumbClass(cssClasses$5.THUMB_WITH_INDICATOR, otherThumb);
			}
		};
		/** Removes activated state and value indicator from thumb(s). */
		MDCSliderFoundation.prototype.handleInputBlur = function(thumb) {
			this.adapter.removeThumbClass(cssClasses$5.THUMB_FOCUSED, thumb);
			if (!this.isDiscrete) return;
			this.adapter.removeThumbClass(cssClasses$5.THUMB_WITH_INDICATOR, thumb);
			if (this.isRange) {
				var otherThumb = thumb === Thumb.START ? Thumb.END : Thumb.START;
				this.adapter.removeThumbClass(cssClasses$5.THUMB_WITH_INDICATOR, otherThumb);
			}
		};
		/**
		* Emits custom dragStart event, along with focusing the underlying input.
		*/
		MDCSliderFoundation.prototype.handleDragStart = function(event, value, thumb) {
			var _a, _b;
			this.adapter.emitDragStartEvent(value, thumb);
			this.adapter.focusInput(thumb);
			if ((_b = (_a = this.adapter).shouldHideFocusStylesForPointerEvents) === null || _b === void 0 ? void 0 : _b.call(_a)) this.handleInputFocus(thumb);
			event.preventDefault();
		};
		/**
		* @return The thumb to be moved based on initial down event.
		*/
		MDCSliderFoundation.prototype.getThumbFromDownEvent = function(clientX, value) {
			if (!this.isRange) return Thumb.END;
			var thumbStartRect = this.adapter.getThumbBoundingClientRect(Thumb.START);
			var thumbEndRect = this.adapter.getThumbBoundingClientRect(Thumb.END);
			var inThumbStartBounds = clientX >= thumbStartRect.left && clientX <= thumbStartRect.right;
			var inThumbEndBounds = clientX >= thumbEndRect.left && clientX <= thumbEndRect.right;
			if (inThumbStartBounds && inThumbEndBounds) return null;
			if (inThumbStartBounds) return Thumb.START;
			if (inThumbEndBounds) return Thumb.END;
			if (value < this.valueStart) return Thumb.START;
			if (value > this.value) return Thumb.END;
			return value - this.valueStart <= this.value - value ? Thumb.START : Thumb.END;
		};
		/**
		* @return The thumb to be moved based on move event (based on drag
		*     direction from original down event). Only applicable if thumbs
		*     were overlapping in the down event.
		*/
		MDCSliderFoundation.prototype.getThumbFromMoveEvent = function(clientX) {
			if (this.thumb !== null) return this.thumb;
			if (this.downEventClientX === null) throw new Error("`downEventClientX` is null after move event.");
			if (Math.abs(this.downEventClientX - clientX) < numbers$4.THUMB_UPDATE_MIN_PX) return this.thumb;
			if (clientX < this.downEventClientX) return this.adapter.isRTL() ? Thumb.END : Thumb.START;
			else return this.adapter.isRTL() ? Thumb.START : Thumb.END;
		};
		/**
		* Updates UI based on internal state.
		* @param thumb Thumb whose value is being updated. If undefined, UI is
		*     updated for both thumbs based on current internal state.
		*/
		MDCSliderFoundation.prototype.updateUI = function(thumb) {
			if (thumb) this.updateThumbAndInputAttributes(thumb);
			else {
				this.updateThumbAndInputAttributes(Thumb.START);
				this.updateThumbAndInputAttributes(Thumb.END);
			}
			this.updateThumbAndTrackUI(thumb);
			this.updateValueIndicatorUI(thumb);
			this.updateTickMarksUI();
		};
		/**
		* Updates thumb and input attributes based on current value.
		* @param thumb Thumb whose aria attributes to update.
		*/
		MDCSliderFoundation.prototype.updateThumbAndInputAttributes = function(thumb) {
			if (!thumb) return;
			var value = this.isRange && thumb === Thumb.START ? this.valueStart : this.value;
			var valueStr = String(value);
			this.adapter.setInputAttribute(attributes$1.INPUT_VALUE, valueStr, thumb);
			if (this.isRange && thumb === Thumb.START) this.adapter.setInputAttribute(attributes$1.INPUT_MIN, String(value + this.minRange), Thumb.END);
			else if (this.isRange && thumb === Thumb.END) this.adapter.setInputAttribute(attributes$1.INPUT_MAX, String(value - this.minRange), Thumb.START);
			if (this.adapter.getInputValue(thumb) !== valueStr) this.adapter.setInputValue(valueStr, thumb);
			var valueToAriaValueTextFn = this.adapter.getValueToAriaValueTextFn();
			if (valueToAriaValueTextFn) this.adapter.setInputAttribute(attributes$1.ARIA_VALUETEXT, valueToAriaValueTextFn(value, thumb), thumb);
		};
		/**
		* Updates value indicator UI based on current value.
		* @param thumb Thumb whose value indicator to update. If undefined, all
		*     thumbs' value indicators are updated.
		*/
		MDCSliderFoundation.prototype.updateValueIndicatorUI = function(thumb) {
			if (!this.isDiscrete) return;
			var value = this.isRange && thumb === Thumb.START ? this.valueStart : this.value;
			this.adapter.setValueIndicatorText(value, thumb === Thumb.START ? Thumb.START : Thumb.END);
			if (!thumb && this.isRange) this.adapter.setValueIndicatorText(this.valueStart, Thumb.START);
		};
		/**
		* Updates tick marks UI within slider, based on current min, max, and step.
		*/
		MDCSliderFoundation.prototype.updateTickMarksUI = function() {
			if (!this.isDiscrete || !this.hasTickMarks) return;
			var numTickMarksInactiveStart = (this.valueStart - this.min) / this.step;
			var numTickMarksActive = (this.value - this.valueStart) / this.step + 1;
			var numTickMarksInactiveEnd = (this.max - this.value) / this.step;
			var tickMarksInactiveStart = Array.from({ length: numTickMarksInactiveStart }).fill(TickMark.INACTIVE);
			var tickMarksActive = Array.from({ length: numTickMarksActive }).fill(TickMark.ACTIVE);
			var tickMarksInactiveEnd = Array.from({ length: numTickMarksInactiveEnd }).fill(TickMark.INACTIVE);
			this.adapter.updateTickMarks(tickMarksInactiveStart.concat(tickMarksActive).concat(tickMarksInactiveEnd));
		};
		/** Maps clientX to a value on the slider scale. */
		MDCSliderFoundation.prototype.mapClientXOnSliderScale = function(clientX) {
			var pctComplete = (clientX - this.rect.left) / this.rect.width;
			if (this.adapter.isRTL()) pctComplete = 1 - pctComplete;
			var value = this.min + pctComplete * (this.max - this.min);
			if (value === this.max || value === this.min) return value;
			return Number(this.quantize(value).toFixed(this.numDecimalPlaces));
		};
		/** Calculates the quantized value based on step value. */
		MDCSliderFoundation.prototype.quantize = function(value) {
			var numSteps = Math.round((value - this.min) / this.step);
			return this.min + numSteps * this.step;
		};
		/**
		* Updates slider value (internal state and UI) based on the given value.
		*/
		MDCSliderFoundation.prototype.updateValue = function(value, thumb, _a) {
			var emitInputEvent = (_a === void 0 ? {} : _a).emitInputEvent;
			value = this.clampValue(value, thumb);
			if (this.isRange && thumb === Thumb.START) {
				if (this.valueStart === value) return;
				this.valueStart = value;
			} else {
				if (this.value === value) return;
				this.value = value;
			}
			this.updateUI(thumb);
			if (emitInputEvent) this.adapter.emitInputEvent(thumb === Thumb.START ? this.valueStart : this.value, thumb);
		};
		/**
		* Clamps the given value for the given thumb based on slider properties:
		* - Restricts value within [min, max].
		* - If range slider, clamp start value <= end value - min range, and
		*   end value >= start value + min range.
		*/
		MDCSliderFoundation.prototype.clampValue = function(value, thumb) {
			value = Math.min(Math.max(value, this.min), this.max);
			if (this.isRange && thumb === Thumb.START && value > this.value - this.minRange) return this.value - this.minRange;
			if (this.isRange && thumb === Thumb.END && value < this.valueStart + this.minRange) return this.valueStart + this.minRange;
			return value;
		};
		/**
		* Updates the active track and thumb style properties to reflect current
		* value.
		*/
		MDCSliderFoundation.prototype.updateThumbAndTrackUI = function(thumb) {
			var _this = this;
			var _a = this, max = _a.max, min = _a.min;
			var pctComplete = (this.value - this.valueStart) / (max - min);
			var rangePx = pctComplete * this.rect.width;
			var isRtl = this.adapter.isRTL();
			var transformProp = HAS_WINDOW$1 ? getCorrectPropertyName(window, "transform") : "transform";
			if (this.isRange) {
				var thumbLeftPos_1 = this.adapter.isRTL() ? (max - this.value) / (max - min) * this.rect.width : (this.valueStart - min) / (max - min) * this.rect.width;
				var thumbRightPos_1 = thumbLeftPos_1 + rangePx;
				this.animFrame.request(AnimationKeys$1.SLIDER_UPDATE, function() {
					if (!isRtl && thumb === Thumb.START || isRtl && thumb !== Thumb.START) {
						_this.adapter.setTrackActiveStyleProperty("transform-origin", "right");
						_this.adapter.setTrackActiveStyleProperty("left", "auto");
						_this.adapter.setTrackActiveStyleProperty("right", _this.rect.width - thumbRightPos_1 + "px");
					} else {
						_this.adapter.setTrackActiveStyleProperty("transform-origin", "left");
						_this.adapter.setTrackActiveStyleProperty("right", "auto");
						_this.adapter.setTrackActiveStyleProperty("left", thumbLeftPos_1 + "px");
					}
					_this.adapter.setTrackActiveStyleProperty(transformProp, "scaleX(" + pctComplete + ")");
					var thumbStartPos = isRtl ? thumbRightPos_1 : thumbLeftPos_1;
					var thumbEndPos = _this.adapter.isRTL() ? thumbLeftPos_1 : thumbRightPos_1;
					if (thumb === Thumb.START || !thumb || !_this.initialStylesRemoved) {
						_this.adapter.setThumbStyleProperty(transformProp, "translateX(" + thumbStartPos + "px)", Thumb.START);
						_this.alignValueIndicator(Thumb.START, thumbStartPos);
					}
					if (thumb === Thumb.END || !thumb || !_this.initialStylesRemoved) {
						_this.adapter.setThumbStyleProperty(transformProp, "translateX(" + thumbEndPos + "px)", Thumb.END);
						_this.alignValueIndicator(Thumb.END, thumbEndPos);
					}
					_this.removeInitialStyles(isRtl);
					_this.updateOverlappingThumbsUI(thumbStartPos, thumbEndPos, thumb);
				});
			} else this.animFrame.request(AnimationKeys$1.SLIDER_UPDATE, function() {
				var thumbStartPos = isRtl ? _this.rect.width - rangePx : rangePx;
				_this.adapter.setThumbStyleProperty(transformProp, "translateX(" + thumbStartPos + "px)", Thumb.END);
				_this.alignValueIndicator(Thumb.END, thumbStartPos);
				_this.adapter.setTrackActiveStyleProperty(transformProp, "scaleX(" + pctComplete + ")");
				_this.removeInitialStyles(isRtl);
			});
		};
		/**
		* Shifts the value indicator to either side if it would otherwise stick
		* beyond the slider's length while keeping the caret above the knob.
		*/
		MDCSliderFoundation.prototype.alignValueIndicator = function(thumb, thumbPos) {
			if (!this.isDiscrete) return;
			var thumbHalfWidth = this.adapter.getThumbBoundingClientRect(thumb).width / 2;
			var containerWidth = this.adapter.getValueIndicatorContainerWidth(thumb);
			var sliderWidth = this.adapter.getBoundingClientRect().width;
			if (containerWidth / 2 > thumbPos + thumbHalfWidth) {
				this.adapter.setThumbStyleProperty(strings$8.VAR_VALUE_INDICATOR_CARET_LEFT, thumbHalfWidth + "px", thumb);
				this.adapter.setThumbStyleProperty(strings$8.VAR_VALUE_INDICATOR_CARET_RIGHT, "auto", thumb);
				this.adapter.setThumbStyleProperty(strings$8.VAR_VALUE_INDICATOR_CARET_TRANSFORM, "translateX(-50%)", thumb);
				this.adapter.setThumbStyleProperty(strings$8.VAR_VALUE_INDICATOR_CONTAINER_LEFT, "0", thumb);
				this.adapter.setThumbStyleProperty(strings$8.VAR_VALUE_INDICATOR_CONTAINER_RIGHT, "auto", thumb);
				this.adapter.setThumbStyleProperty(strings$8.VAR_VALUE_INDICATOR_CONTAINER_TRANSFORM, "none", thumb);
			} else if (containerWidth / 2 > sliderWidth - thumbPos + thumbHalfWidth) {
				this.adapter.setThumbStyleProperty(strings$8.VAR_VALUE_INDICATOR_CARET_LEFT, "auto", thumb);
				this.adapter.setThumbStyleProperty(strings$8.VAR_VALUE_INDICATOR_CARET_RIGHT, thumbHalfWidth + "px", thumb);
				this.adapter.setThumbStyleProperty(strings$8.VAR_VALUE_INDICATOR_CARET_TRANSFORM, "translateX(50%)", thumb);
				this.adapter.setThumbStyleProperty(strings$8.VAR_VALUE_INDICATOR_CONTAINER_LEFT, "auto", thumb);
				this.adapter.setThumbStyleProperty(strings$8.VAR_VALUE_INDICATOR_CONTAINER_RIGHT, "0", thumb);
				this.adapter.setThumbStyleProperty(strings$8.VAR_VALUE_INDICATOR_CONTAINER_TRANSFORM, "none", thumb);
			} else {
				this.adapter.setThumbStyleProperty(strings$8.VAR_VALUE_INDICATOR_CARET_LEFT, "50%", thumb);
				this.adapter.setThumbStyleProperty(strings$8.VAR_VALUE_INDICATOR_CARET_RIGHT, "auto", thumb);
				this.adapter.setThumbStyleProperty(strings$8.VAR_VALUE_INDICATOR_CARET_TRANSFORM, "translateX(-50%)", thumb);
				this.adapter.setThumbStyleProperty(strings$8.VAR_VALUE_INDICATOR_CONTAINER_LEFT, "50%", thumb);
				this.adapter.setThumbStyleProperty(strings$8.VAR_VALUE_INDICATOR_CONTAINER_RIGHT, "auto", thumb);
				this.adapter.setThumbStyleProperty(strings$8.VAR_VALUE_INDICATOR_CONTAINER_TRANSFORM, "translateX(-50%)", thumb);
			}
		};
		/**
		* Removes initial inline styles if not already removed. `left:<...>%`
		* inline styles can be added to position the thumb correctly before JS
		* initialization. However, they need to be removed before the JS starts
		* positioning the thumb. This is because the JS uses
		* `transform:translateX(<...>)px` (for performance reasons) to position
		* the thumb (which is not possible for initial styles since we need the
		* bounding rect measurements).
		*/
		MDCSliderFoundation.prototype.removeInitialStyles = function(isRtl) {
			if (this.initialStylesRemoved) return;
			var position = isRtl ? "right" : "left";
			this.adapter.removeThumbStyleProperty(position, Thumb.END);
			if (this.isRange) this.adapter.removeThumbStyleProperty(position, Thumb.START);
			this.initialStylesRemoved = true;
			this.resetTrackAndThumbAnimation();
		};
		/**
		* Resets track/thumb animation to prevent animation when adding
		* `transform` styles to thumb initially.
		*/
		MDCSliderFoundation.prototype.resetTrackAndThumbAnimation = function() {
			var _this = this;
			if (!this.isDiscrete) return;
			var transitionProp = HAS_WINDOW$1 ? getCorrectPropertyName(window, "transition") : "transition";
			var transitionDefault = "none 0s ease 0s";
			this.adapter.setThumbStyleProperty(transitionProp, transitionDefault, Thumb.END);
			if (this.isRange) this.adapter.setThumbStyleProperty(transitionProp, transitionDefault, Thumb.START);
			this.adapter.setTrackActiveStyleProperty(transitionProp, transitionDefault);
			requestAnimationFrame(function() {
				_this.adapter.removeThumbStyleProperty(transitionProp, Thumb.END);
				_this.adapter.removeTrackActiveStyleProperty(transitionProp);
				if (_this.isRange) _this.adapter.removeThumbStyleProperty(transitionProp, Thumb.START);
			});
		};
		/**
		* Adds THUMB_TOP class to active thumb if thumb knobs overlap; otherwise
		* removes THUMB_TOP class from both thumbs.
		* @param thumb Thumb that is active (being moved).
		*/
		MDCSliderFoundation.prototype.updateOverlappingThumbsUI = function(thumbStartPos, thumbEndPos, thumb) {
			var thumbsOverlap = false;
			if (this.adapter.isRTL()) {
				var startThumbLeftEdge = thumbStartPos - this.startThumbKnobWidth / 2;
				thumbsOverlap = thumbEndPos + this.endThumbKnobWidth / 2 >= startThumbLeftEdge;
			} else thumbsOverlap = thumbStartPos + this.startThumbKnobWidth / 2 >= thumbEndPos - this.endThumbKnobWidth / 2;
			if (thumbsOverlap) {
				this.adapter.addThumbClass(cssClasses$5.THUMB_TOP, thumb || Thumb.END);
				this.adapter.removeThumbClass(cssClasses$5.THUMB_TOP, thumb === Thumb.START ? Thumb.END : Thumb.START);
			} else {
				this.adapter.removeThumbClass(cssClasses$5.THUMB_TOP, Thumb.START);
				this.adapter.removeThumbClass(cssClasses$5.THUMB_TOP, Thumb.END);
			}
		};
		/**
		* Converts attribute value to a number, e.g. '100' => 100. Throws errors
		* for invalid values.
		* @param attributeValue Attribute value, e.g. 100.
		* @param attributeName Attribute name, e.g. `aria-valuemax`.
		*/
		MDCSliderFoundation.prototype.convertAttributeValueToNumber = function(attributeValue, attributeName) {
			if (attributeValue === null) throw new Error("MDCSliderFoundation: `" + attributeName + "` must be non-null.");
			var value = Number(attributeValue);
			if (isNaN(value)) throw new Error("MDCSliderFoundation: `" + attributeName + "` value is `" + attributeValue + "`, but must be a number.");
			return value;
		};
		/** Checks that the given properties are valid slider values. */
		MDCSliderFoundation.prototype.validateProperties = function(_a) {
			var min = _a.min, max = _a.max, value = _a.value, valueStart = _a.valueStart, step = _a.step, minRange = _a.minRange;
			if (min >= max) throw new Error("MDCSliderFoundation: min must be strictly less than max. " + ("Current: [min: " + min + ", max: " + max + "]"));
			if (step <= 0) throw new Error("MDCSliderFoundation: step must be a positive number. " + ("Current step: " + step));
			if (this.isRange) {
				if (value < min || value > max || valueStart < min || valueStart > max) throw new Error("MDCSliderFoundation: values must be in [min, max] range. " + ("Current values: [start value: " + valueStart + ", end value: ") + (value + ", min: " + min + ", max: " + max + "]"));
				if (valueStart > value) throw new Error("MDCSliderFoundation: start value must be <= end value. " + ("Current values: [start value: " + valueStart + ", end value: " + value + "]"));
				if (minRange < 0) throw new Error("MDCSliderFoundation: minimum range must be non-negative. " + ("Current min range: " + minRange));
				if (value - valueStart < minRange) throw new Error("MDCSliderFoundation: start value and end value must differ by at least " + (minRange + ". Current values: [start value: " + valueStart + ", ") + ("end value: " + value + "]"));
				var numStepsValueStartFromMin = (valueStart - min) / step;
				var numStepsValueFromMin = (value - min) / step;
				if (!Number.isInteger(parseFloat(numStepsValueStartFromMin.toFixed(6))) || !Number.isInteger(parseFloat(numStepsValueFromMin.toFixed(6)))) throw new Error("MDCSliderFoundation: Slider values must be valid based on the " + ("step value (" + step + "). Current values: [start value: ") + (valueStart + ", end value: " + value + ", min: " + min + "]"));
			} else {
				if (value < min || value > max) throw new Error("MDCSliderFoundation: value must be in [min, max] range. " + ("Current values: [value: " + value + ", min: " + min + ", max: " + max + "]"));
				var numStepsValueFromMin = (value - min) / step;
				if (!Number.isInteger(parseFloat(numStepsValueFromMin.toFixed(6)))) throw new Error("MDCSliderFoundation: Slider value must be valid based on the " + ("step value (" + step + "). Current value: " + value));
			}
		};
		MDCSliderFoundation.prototype.registerEventHandlers = function() {
			this.adapter.registerWindowEventHandler("resize", this.resizeListener);
			if (MDCSliderFoundation.SUPPORTS_POINTER_EVENTS) {
				this.adapter.registerEventHandler("pointerdown", this.pointerdownListener);
				this.adapter.registerEventHandler("pointerup", this.pointerupListener);
			} else {
				this.adapter.registerEventHandler("mousedown", this.mousedownOrTouchstartListener);
				this.adapter.registerEventHandler("touchstart", this.mousedownOrTouchstartListener);
			}
			if (this.isRange) {
				this.adapter.registerThumbEventHandler(Thumb.START, "mouseenter", this.thumbMouseenterListener);
				this.adapter.registerThumbEventHandler(Thumb.START, "mouseleave", this.thumbMouseleaveListener);
				this.adapter.registerInputEventHandler(Thumb.START, "change", this.inputStartChangeListener);
				this.adapter.registerInputEventHandler(Thumb.START, "focus", this.inputStartFocusListener);
				this.adapter.registerInputEventHandler(Thumb.START, "blur", this.inputStartBlurListener);
			}
			this.adapter.registerThumbEventHandler(Thumb.END, "mouseenter", this.thumbMouseenterListener);
			this.adapter.registerThumbEventHandler(Thumb.END, "mouseleave", this.thumbMouseleaveListener);
			this.adapter.registerInputEventHandler(Thumb.END, "change", this.inputEndChangeListener);
			this.adapter.registerInputEventHandler(Thumb.END, "focus", this.inputEndFocusListener);
			this.adapter.registerInputEventHandler(Thumb.END, "blur", this.inputEndBlurListener);
		};
		MDCSliderFoundation.prototype.deregisterEventHandlers = function() {
			this.adapter.deregisterWindowEventHandler("resize", this.resizeListener);
			if (MDCSliderFoundation.SUPPORTS_POINTER_EVENTS) {
				this.adapter.deregisterEventHandler("pointerdown", this.pointerdownListener);
				this.adapter.deregisterEventHandler("pointerup", this.pointerupListener);
			} else {
				this.adapter.deregisterEventHandler("mousedown", this.mousedownOrTouchstartListener);
				this.adapter.deregisterEventHandler("touchstart", this.mousedownOrTouchstartListener);
			}
			if (this.isRange) {
				this.adapter.deregisterThumbEventHandler(Thumb.START, "mouseenter", this.thumbMouseenterListener);
				this.adapter.deregisterThumbEventHandler(Thumb.START, "mouseleave", this.thumbMouseleaveListener);
				this.adapter.deregisterInputEventHandler(Thumb.START, "change", this.inputStartChangeListener);
				this.adapter.deregisterInputEventHandler(Thumb.START, "focus", this.inputStartFocusListener);
				this.adapter.deregisterInputEventHandler(Thumb.START, "blur", this.inputStartBlurListener);
			}
			this.adapter.deregisterThumbEventHandler(Thumb.END, "mouseenter", this.thumbMouseenterListener);
			this.adapter.deregisterThumbEventHandler(Thumb.END, "mouseleave", this.thumbMouseleaveListener);
			this.adapter.deregisterInputEventHandler(Thumb.END, "change", this.inputEndChangeListener);
			this.adapter.deregisterInputEventHandler(Thumb.END, "focus", this.inputEndFocusListener);
			this.adapter.deregisterInputEventHandler(Thumb.END, "blur", this.inputEndBlurListener);
		};
		MDCSliderFoundation.prototype.handlePointerup = function() {
			this.handleUp();
			this.adapter.deregisterEventHandler("pointermove", this.moveListener);
		};
		MDCSliderFoundation.SUPPORTS_POINTER_EVENTS = HAS_WINDOW$1 && Boolean(window.PointerEvent) && !isIOS();
		return MDCSliderFoundation;
	}(MDCFoundation);
	function isIOS() {
		return [
			"iPad Simulator",
			"iPhone Simulator",
			"iPod Simulator",
			"iPad",
			"iPhone",
			"iPod"
		].includes(navigator.platform) || navigator.userAgent.includes("Mac") && "ontouchend" in document;
	}
	/**
	* Given a number, returns the number of digits that appear after the
	* decimal point.
	* See
	* https://stackoverflow.com/questions/9539513/is-there-a-reliable-way-in-javascript-to-obtain-the-number-of-decimal-places-of
	*/
	function getNumDecimalPlaces(n) {
		var match = /(?:\.(\d+))?(?:[eE]([+\-]?\d+))?$/.exec(String(n));
		if (!match) return 0;
		var fraction = match[1] || "";
		var exponent = match[2] || 0;
		return Math.max(0, (fraction === "0" ? 0 : fraction.length) - Number(exponent));
	}

//#endregion
//#region node_modules/.pnpm/@material+slider@14.0.0/node_modules/@material/slider/component.js
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
	/** Vanilla JS implementation of slider component. */
	var MDCSlider = function(_super) {
		__extends(MDCSlider, _super);
		function MDCSlider() {
			var _this = _super !== null && _super.apply(this, arguments) || this;
			_this.skipInitialUIUpdate = false;
			_this.valueToAriaValueTextFn = null;
			return _this;
		}
		MDCSlider.attachTo = function(root, options) {
			if (options === void 0) options = {};
			return new MDCSlider(root, void 0, options);
		};
		MDCSlider.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCSliderFoundation({
				hasClass: function(className) {
					return _this.root.classList.contains(className);
				},
				addClass: function(className) {
					_this.root.classList.add(className);
				},
				removeClass: function(className) {
					_this.root.classList.remove(className);
				},
				addThumbClass: function(className, thumb) {
					_this.getThumbEl(thumb).classList.add(className);
				},
				removeThumbClass: function(className, thumb) {
					_this.getThumbEl(thumb).classList.remove(className);
				},
				getAttribute: function(attribute) {
					return _this.root.getAttribute(attribute);
				},
				getInputValue: function(thumb) {
					return _this.getInput(thumb).value;
				},
				setInputValue: function(value, thumb) {
					_this.getInput(thumb).value = value;
				},
				getInputAttribute: function(attribute, thumb) {
					return _this.getInput(thumb).getAttribute(attribute);
				},
				setInputAttribute: function(attribute, value, thumb) {
					_this.getInput(thumb).setAttribute(attribute, value);
				},
				removeInputAttribute: function(attribute, thumb) {
					_this.getInput(thumb).removeAttribute(attribute);
				},
				focusInput: function(thumb) {
					_this.getInput(thumb).focus();
				},
				isInputFocused: function(thumb) {
					return _this.getInput(thumb) === document.activeElement;
				},
				shouldHideFocusStylesForPointerEvents: function() {
					return false;
				},
				getThumbKnobWidth: function(thumb) {
					return _this.getThumbEl(thumb).querySelector("." + cssClasses$5.THUMB_KNOB).getBoundingClientRect().width;
				},
				getThumbBoundingClientRect: function(thumb) {
					return _this.getThumbEl(thumb).getBoundingClientRect();
				},
				getBoundingClientRect: function() {
					return _this.root.getBoundingClientRect();
				},
				getValueIndicatorContainerWidth: function(thumb) {
					return _this.getThumbEl(thumb).querySelector("." + cssClasses$5.VALUE_INDICATOR_CONTAINER).getBoundingClientRect().width;
				},
				isRTL: function() {
					return getComputedStyle(_this.root).direction === "rtl";
				},
				setThumbStyleProperty: function(propertyName, value, thumb) {
					_this.getThumbEl(thumb).style.setProperty(propertyName, value);
				},
				removeThumbStyleProperty: function(propertyName, thumb) {
					_this.getThumbEl(thumb).style.removeProperty(propertyName);
				},
				setTrackActiveStyleProperty: function(propertyName, value) {
					_this.trackActive.style.setProperty(propertyName, value);
				},
				removeTrackActiveStyleProperty: function(propertyName) {
					_this.trackActive.style.removeProperty(propertyName);
				},
				setValueIndicatorText: function(value, thumb) {
					var valueIndicatorEl = _this.getThumbEl(thumb).querySelector("." + cssClasses$5.VALUE_INDICATOR_TEXT);
					valueIndicatorEl.textContent = String(value);
				},
				getValueToAriaValueTextFn: function() {
					return _this.valueToAriaValueTextFn;
				},
				updateTickMarks: function(tickMarks) {
					var tickMarksContainer = _this.root.querySelector("." + cssClasses$5.TICK_MARKS_CONTAINER);
					if (!tickMarksContainer) {
						tickMarksContainer = document.createElement("div");
						tickMarksContainer.classList.add(cssClasses$5.TICK_MARKS_CONTAINER);
						_this.root.querySelector("." + cssClasses$5.TRACK).appendChild(tickMarksContainer);
					}
					if (tickMarks.length !== tickMarksContainer.children.length) {
						while (tickMarksContainer.firstChild) tickMarksContainer.removeChild(tickMarksContainer.firstChild);
						_this.addTickMarks(tickMarksContainer, tickMarks);
					} else _this.updateTickMarks(tickMarksContainer, tickMarks);
				},
				setPointerCapture: function(pointerId) {
					_this.root.setPointerCapture(pointerId);
				},
				emitChangeEvent: function(value, thumb) {
					_this.emit(events$1.CHANGE, {
						value,
						thumb
					});
				},
				emitInputEvent: function(value, thumb) {
					_this.emit(events$1.INPUT, {
						value,
						thumb
					});
				},
				emitDragStartEvent: function(_, thumb) {
					_this.getRipple(thumb).activate();
				},
				emitDragEndEvent: function(_, thumb) {
					_this.getRipple(thumb).deactivate();
				},
				registerEventHandler: function(evtType, handler) {
					_this.listen(evtType, handler);
				},
				deregisterEventHandler: function(evtType, handler) {
					_this.unlisten(evtType, handler);
				},
				registerThumbEventHandler: function(thumb, evtType, handler) {
					_this.getThumbEl(thumb).addEventListener(evtType, handler);
				},
				deregisterThumbEventHandler: function(thumb, evtType, handler) {
					_this.getThumbEl(thumb).removeEventListener(evtType, handler);
				},
				registerInputEventHandler: function(thumb, evtType, handler) {
					_this.getInput(thumb).addEventListener(evtType, handler);
				},
				deregisterInputEventHandler: function(thumb, evtType, handler) {
					_this.getInput(thumb).removeEventListener(evtType, handler);
				},
				registerBodyEventHandler: function(evtType, handler) {
					document.body.addEventListener(evtType, handler);
				},
				deregisterBodyEventHandler: function(evtType, handler) {
					document.body.removeEventListener(evtType, handler);
				},
				registerWindowEventHandler: function(evtType, handler) {
					window.addEventListener(evtType, handler);
				},
				deregisterWindowEventHandler: function(evtType, handler) {
					window.removeEventListener(evtType, handler);
				}
			});
		};
		/**
		* Initializes component, with the following options:
		* - `skipInitialUIUpdate`: Whether to skip updating the UI when initially
		*   syncing with the DOM. This should be enabled when the slider position
		*   is set before component initialization.
		*/
		MDCSlider.prototype.initialize = function(_a) {
			var skipInitialUIUpdate = (_a === void 0 ? {} : _a).skipInitialUIUpdate;
			this.inputs = [].slice.call(this.root.querySelectorAll("." + cssClasses$5.INPUT));
			this.thumbs = [].slice.call(this.root.querySelectorAll("." + cssClasses$5.THUMB));
			this.trackActive = this.root.querySelector("." + cssClasses$5.TRACK_ACTIVE);
			this.ripples = this.createRipples();
			if (skipInitialUIUpdate) this.skipInitialUIUpdate = true;
		};
		MDCSlider.prototype.initialSyncWithDOM = function() {
			this.foundation.layout({ skipUpdateUI: this.skipInitialUIUpdate });
		};
		/** Redraws UI based on DOM (e.g. element dimensions, RTL). */
		MDCSlider.prototype.layout = function() {
			this.foundation.layout();
		};
		MDCSlider.prototype.getValueStart = function() {
			return this.foundation.getValueStart();
		};
		MDCSlider.prototype.setValueStart = function(valueStart) {
			this.foundation.setValueStart(valueStart);
		};
		MDCSlider.prototype.getValue = function() {
			return this.foundation.getValue();
		};
		MDCSlider.prototype.setValue = function(value) {
			this.foundation.setValue(value);
		};
		/** @return Slider disabled state. */
		MDCSlider.prototype.getDisabled = function() {
			return this.foundation.getDisabled();
		};
		/** Sets slider disabled state. */
		MDCSlider.prototype.setDisabled = function(disabled) {
			this.foundation.setDisabled(disabled);
		};
		/**
		* Sets a function that maps the slider value to the value of the
		* `aria-valuetext` attribute on the thumb element.
		*/
		MDCSlider.prototype.setValueToAriaValueTextFn = function(mapFn) {
			this.valueToAriaValueTextFn = mapFn;
		};
		MDCSlider.prototype.getThumbEl = function(thumb) {
			return thumb === Thumb.END ? this.thumbs[this.thumbs.length - 1] : this.thumbs[0];
		};
		MDCSlider.prototype.getInput = function(thumb) {
			return thumb === Thumb.END ? this.inputs[this.inputs.length - 1] : this.inputs[0];
		};
		MDCSlider.prototype.getRipple = function(thumb) {
			return thumb === Thumb.END ? this.ripples[this.ripples.length - 1] : this.ripples[0];
		};
		/** Adds tick mark elements to the given container. */
		MDCSlider.prototype.addTickMarks = function(tickMarkContainer, tickMarks) {
			var fragment = document.createDocumentFragment();
			for (var i = 0; i < tickMarks.length; i++) {
				var div = document.createElement("div");
				var tickMarkClass = tickMarks[i] === TickMark.ACTIVE ? cssClasses$5.TICK_MARK_ACTIVE : cssClasses$5.TICK_MARK_INACTIVE;
				div.classList.add(tickMarkClass);
				fragment.appendChild(div);
			}
			tickMarkContainer.appendChild(fragment);
		};
		/** Updates tick mark elements' classes in the given container. */
		MDCSlider.prototype.updateTickMarks = function(tickMarkContainer, tickMarks) {
			var tickMarkEls = Array.from(tickMarkContainer.children);
			for (var i = 0; i < tickMarkEls.length; i++) if (tickMarks[i] === TickMark.ACTIVE) {
				tickMarkEls[i].classList.add(cssClasses$5.TICK_MARK_ACTIVE);
				tickMarkEls[i].classList.remove(cssClasses$5.TICK_MARK_INACTIVE);
			} else {
				tickMarkEls[i].classList.add(cssClasses$5.TICK_MARK_INACTIVE);
				tickMarkEls[i].classList.remove(cssClasses$5.TICK_MARK_ACTIVE);
			}
		};
		/** Initializes thumb ripples. */
		MDCSlider.prototype.createRipples = function() {
			var ripples = [];
			var rippleSurfaces = [].slice.call(this.root.querySelectorAll("." + cssClasses$5.THUMB));
			var _loop_1 = function(i) {
				var rippleSurface = rippleSurfaces[i];
				var input = this_1.inputs[i];
				var ripple = new MDCRipple(rippleSurface, new MDCRippleFoundation(__assign(__assign({}, MDCRipple.createAdapter(this_1)), {
					addClass: function(className) {
						rippleSurface.classList.add(className);
					},
					computeBoundingRect: function() {
						return rippleSurface.getBoundingClientRect();
					},
					deregisterInteractionHandler: function(evtType, handler) {
						input.removeEventListener(evtType, handler);
					},
					isSurfaceActive: function() {
						return matches(input, ":active");
					},
					isUnbounded: function() {
						return true;
					},
					registerInteractionHandler: function(evtType, handler) {
						input.addEventListener(evtType, handler, applyPassive());
					},
					removeClass: function(className) {
						rippleSurface.classList.remove(className);
					},
					updateCssVariable: function(varName, value) {
						rippleSurface.style.setProperty(varName, value);
					}
				})));
				ripple.unbounded = true;
				ripples.push(ripple);
			};
			var this_1 = this;
			for (var i = 0; i < rippleSurfaces.length; i++) _loop_1(i);
			return ripples;
		};
		return MDCSlider;
	}(MDCComponent);

//#endregion
//#region Scripts/lodashparts.ts
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
	/**
	* Checks if `value` is the
	* [language type](http://www.ecma-international.org/ecma-262/7.0/#sec-ecmascript-language-types)
	* of `Object`. (e.g. arrays, functions, objects, regexes, `new Number(0)`, and `new String('')`)
	*
	* @since 0.1.0
	* @category Lang
	* @param {*} value The value to check.
	* @returns {boolean} Returns `true` if `value` is an object, else `false`.
	* @example
	*
	* isObject({})
	* // => true
	*
	* isObject([1, 2, 3])
	* // => true
	*
	* isObject(Function)
	* // => true
	*
	* isObject(null)
	* // => false
	*/
	function isObject(value) {
		const type = typeof value;
		return value != null && (type === "object" || type === "function");
	}
	const freeGlobal = typeof global === "object" && global !== null && global.Object === Object && global;
	/** Detect free variable `globalThis` */
	const freeGlobalThis = typeof globalThis === "object" && globalThis !== null && globalThis.Object == Object && globalThis;
	/** Detect free variable `self`. */
	const freeSelf = typeof self === "object" && self !== null && self.Object === Object && self;
	/** Used as a reference to the global object. */
	const root = freeGlobalThis || freeGlobal || freeSelf || Function("return this")();
	/**
	* Creates a debounced function that delays invoking `func` until after `wait`
	* milliseconds have elapsed since the last time the debounced function was
	* invoked, or until the next browser frame is drawn. The debounced function
	* comes with a `cancel` method to cancel delayed `func` invocations and a
	* `flush` method to immediately invoke them. Provide `options` to indicate
	* whether `func` should be invoked on the leading and/or trailing edge of the
	* `wait` timeout. The `func` is invoked with the last arguments provided to the
	* debounced function. Subsequent calls to the debounced function return the
	* result of the last `func` invocation.
	*
	* **Note:** If `leading` and `trailing` options are `true`, `func` is
	* invoked on the trailing edge of the timeout only if the debounced function
	* is invoked more than once during the `wait` timeout.
	*
	* If `wait` is `0` and `leading` is `false`, `func` invocation is deferred
	* until the next tick, similar to `setTimeout` with a timeout of `0`.
	*
	* If `wait` is omitted in an environment with `requestAnimationFrame`, `func`
	* invocation will be deferred until the next frame is drawn (typically about
	* 16ms).
	*
	* See [David Corbacho's article](https://css-tricks.com/debouncing-throttling-explained-examples/)
	* for details over the differences between `debounce` and `throttle`.
	*
	* @since 0.1.0
	* @category Function
	* @param {Function} func The function to debounce.
	* @param {number} [wait=0]
	*  The number of milliseconds to delay; if omitted, `requestAnimationFrame` is
	*  used (if available).
	* @param {Object} [options={}] The options object.
	* @param {boolean} [options.leading=false]
	*  Specify invoking on the leading edge of the timeout.
	* @param {number} [options.maxWait]
	*  The maximum time `func` is allowed to be delayed before it's invoked.
	* @param {boolean} [options.trailing=true]
	*  Specify invoking on the trailing edge of the timeout.
	* @returns {Function} Returns the new debounced function.
	* @example
	*
	* // Avoid costly calculations while the window size is in flux.
	* jQuery(window).on('resize', debounce(calculateLayout, 150))
	*
	* // Invoke `sendMail` when clicked, debouncing subsequent calls.
	* jQuery(element).on('click', debounce(sendMail, 300, {
	*   'leading': true,
	*   'trailing': false
	* }))
	*
	* // Ensure `batchLog` is invoked once after 1 second of debounced calls.
	* const debounced = debounce(batchLog, 250, { 'maxWait': 1000 })
	* const source = new EventSource('/stream')
	* jQuery(source).on('message', debounced)
	*
	* // Cancel the trailing debounced invocation.
	* jQuery(window).on('popstate', debounced.cancel)
	*
	* // Check for pending invocations.
	* const status = debounced.pending() ? "Pending..." : "Ready"
	*/
	function debounce(func, wait, options) {
		let lastArgs, lastThis, maxWait, result, timerId, lastCallTime;
		let lastInvokeTime = 0;
		let leading = false;
		let maxing = false;
		let trailing = true;
		const useRAF = !wait && wait !== 0 && typeof root.requestAnimationFrame === "function";
		if (typeof func !== "function") throw new TypeError("Expected a function");
		wait = +wait || 0;
		if (isObject(options)) {
			leading = !!options.leading;
			maxing = "maxWait" in options;
			maxWait = maxing ? Math.max(+options.maxWait || 0, wait) : maxWait;
			trailing = "trailing" in options ? !!options.trailing : trailing;
		}
		function invokeFunc(time) {
			const args = lastArgs;
			const thisArg = lastThis;
			lastArgs = lastThis = void 0;
			lastInvokeTime = time;
			result = func.apply(thisArg, args);
			return result;
		}
		function startTimer(pendingFunc, wait) {
			if (useRAF) {
				root.cancelAnimationFrame(timerId);
				return root.requestAnimationFrame(pendingFunc);
			}
			return setTimeout(pendingFunc, wait);
		}
		function cancelTimer(id) {
			if (useRAF) return root.cancelAnimationFrame(id);
			clearTimeout(id);
		}
		function leadingEdge(time) {
			lastInvokeTime = time;
			timerId = startTimer(timerExpired, wait);
			return leading ? invokeFunc(time) : result;
		}
		function remainingWait(time) {
			const timeSinceLastCall = time - lastCallTime;
			const timeSinceLastInvoke = time - lastInvokeTime;
			const timeWaiting = wait - timeSinceLastCall;
			return maxing ? Math.min(timeWaiting, maxWait - timeSinceLastInvoke) : timeWaiting;
		}
		function shouldInvoke(time) {
			const timeSinceLastCall = time - lastCallTime;
			const timeSinceLastInvoke = time - lastInvokeTime;
			return lastCallTime === void 0 || timeSinceLastCall >= wait || timeSinceLastCall < 0 || maxing && timeSinceLastInvoke >= maxWait;
		}
		function timerExpired() {
			const time = Date.now();
			if (shouldInvoke(time)) return trailingEdge(time);
			timerId = startTimer(timerExpired, remainingWait(time));
		}
		function trailingEdge(time) {
			timerId = void 0;
			if (trailing && lastArgs) return invokeFunc(time);
			lastArgs = lastThis = void 0;
			return result;
		}
		function cancel() {
			if (timerId !== void 0) cancelTimer(timerId);
			lastInvokeTime = 0;
			lastArgs = lastCallTime = lastThis = timerId = void 0;
		}
		function flush() {
			return timerId === void 0 ? result : trailingEdge(Date.now());
		}
		function pending() {
			return timerId !== void 0;
		}
		function debounced(...args) {
			const time = Date.now();
			const isInvoking = shouldInvoke(time);
			lastArgs = args;
			lastThis = this;
			lastCallTime = time;
			if (isInvoking) {
				if (timerId === void 0) return leadingEdge(lastCallTime);
				if (maxing) {
					timerId = startTimer(timerExpired, wait);
					return invokeFunc(lastCallTime);
				}
			}
			if (timerId === void 0) timerId = startTimer(timerExpired, wait);
			return result;
		}
		debounced.cancel = cancel;
		debounced.flush = flush;
		debounced.pending = pending;
		return debounced;
	}
	/**
	* Creates a throttled function that only invokes `func` at most once per
	* every `wait` milliseconds (or once per browser frame). The throttled function
	* comes with a `cancel` method to cancel delayed `func` invocations and a
	* `flush` method to immediately invoke them. Provide `options` to indicate
	* whether `func` should be invoked on the leading and/or trailing edge of the
	* `wait` timeout. The `func` is invoked with the last arguments provided to the
	* throttled function. Subsequent calls to the throttled function return the
	* result of the last `func` invocation.
	*
	* **Note:** If `leading` and `trailing` options are `true`, `func` is
	* invoked on the trailing edge of the timeout only if the throttled function
	* is invoked more than once during the `wait` timeout.
	*
	* If `wait` is `0` and `leading` is `false`, `func` invocation is deferred
	* until the next tick, similar to `setTimeout` with a timeout of `0`.
	*
	* If `wait` is omitted in an environment with `requestAnimationFrame`, `func`
	* invocation will be deferred until the next frame is drawn (typically about
	* 16ms).
	*
	* See [David Corbacho's article](https://css-tricks.com/debouncing-throttling-explained-examples/)
	* for details over the differences between `throttle` and `debounce`.
	*
	* @since 0.1.0
	* @category Function
	* @param {Function} func The function to throttle.
	* @param {number} [wait=0]
	*  The number of milliseconds to throttle invocations to; if omitted,
	*  `requestAnimationFrame` is used (if available).
	* @param {Object} [options={}] The options object.
	* @param {boolean} [options.leading=true]
	*  Specify invoking on the leading edge of the timeout.
	* @param {boolean} [options.trailing=true]
	*  Specify invoking on the trailing edge of the timeout.
	* @returns {Function} Returns the new throttled function.
	* @example
	*
	* // Avoid excessively updating the position while scrolling.
	* jQuery(window).on('scroll', throttle(updatePosition, 100))
	*
	* // Invoke `renewToken` when the click event is fired, but not more than once every 5 minutes.
	* const throttled = throttle(renewToken, 300000, { 'trailing': false })
	* jQuery(element).on('click', throttled)
	*
	* // Cancel the trailing throttled invocation.
	* jQuery(window).on('popstate', throttled.cancel)
	*/
	function throttle(func, wait, options) {
		let leading = true;
		let trailing = true;
		if (typeof func !== "function") throw new TypeError("Expected a function");
		if (isObject(options)) {
			leading = "leading" in options ? !!options.leading : leading;
			trailing = "trailing" in options ? !!options.trailing : trailing;
		}
		return debounce(func, wait, {
			leading,
			trailing,
			"maxWait": wait
		});
	}

//#endregion
//#region Scripts/rtl.ts
	var rtl_exports = /* @__PURE__ */ __exportAll({
		isDocumentRTL: () => isDocumentRTL,
		isElementRTL: () => isElementRTL
	});
	function isDocumentRTL() {
		let dir = document.documentElement.getAttribute("dir");
		return !dir || dir.toLowerCase() === "rtl";
	}
	function isElementRTL(elem) {
		if (!elem) return false;
		let dirElem = elem;
		var dir = "";
		for (; dirElem && dirElem !== document && (!dir || dir === ""); dirElem = dirElem.parentNode) {
			dir = dirElem.getAttribute("dir");
			if (dir && dir.length > 0) {
				dir = dir.toLowerCase();
				if (dir === "ltr" || dir === "auto") break;
			}
		}
		return dir !== null && dir.toLowerCase() === "rtl";
	}

//#endregion
//#region Components/Slider/MBSlider.ts
	var MBSlider_exports = /* @__PURE__ */ __exportAll({
		init: () => init$6,
		setDisabled: () => setDisabled$2,
		setValue: () => setValue$1
	});
	function init$6(mainElem, thumbElem, thumbOffset, dotNetObject, eventType, delay, disabled) {
		if (!mainElem || !thumbElem) return;
		thumbElem.style = (isElementRTL(mainElem) ? "right: " : "left: ") + thumbOffset;
		mainElem._slider = MDCSlider.attachTo(mainElem);
		mainElem._eventType = eventType;
		if (eventType == 0) {
			const thumbUpCallback = () => {
				dotNetObject.invokeMethodAsync("NotifyChanged", mainElem._slider.getValue());
			};
			mainElem._slider.listen("MDCSlider:change", thumbUpCallback);
		} else if (eventType == 1) {
			const debounceNotify = debounce(function() {
				dotNetObject.invokeMethodAsync("NotifyChanged", mainElem._slider.getValue());
			}, delay, {});
			mainElem._slider.listen("MDCSlider:input", debounceNotify);
		} else {
			const throttleNotify = throttle(function() {
				dotNetObject.invokeMethodAsync("NotifyChanged", mainElem._slider.getValue());
			}, delay, {});
			mainElem._slider.listen("MDCSlider:input", throttleNotify);
		}
		mainElem._slider.setDisabled(disabled);
	}
	function setValue$1(elem, value) {
		if (!elem) return;
		elem._slider.setValue(value);
	}
	function setDisabled$2(elem, disabled) {
		if (!elem) return;
		elem._slider.setDisabled(disabled);
	}

//#endregion
//#region node_modules/.pnpm/@material+snackbar@14.0.0/node_modules/@material/snackbar/constants.js
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
	var cssClasses$4 = {
		CLOSING: "mdc-snackbar--closing",
		OPEN: "mdc-snackbar--open",
		OPENING: "mdc-snackbar--opening"
	};
	var strings$7 = {
		ACTION_SELECTOR: ".mdc-snackbar__action",
		ARIA_LIVE_LABEL_TEXT_ATTR: "data-mdc-snackbar-label-text",
		CLOSED_EVENT: "MDCSnackbar:closed",
		CLOSING_EVENT: "MDCSnackbar:closing",
		DISMISS_SELECTOR: ".mdc-snackbar__dismiss",
		LABEL_SELECTOR: ".mdc-snackbar__label",
		OPENED_EVENT: "MDCSnackbar:opened",
		OPENING_EVENT: "MDCSnackbar:opening",
		REASON_ACTION: "action",
		REASON_DISMISS: "dismiss",
		SURFACE_SELECTOR: ".mdc-snackbar__surface"
	};
	var numbers$3 = {
		DEFAULT_AUTO_DISMISS_TIMEOUT_MS: 5e3,
		INDETERMINATE: -1,
		MAX_AUTO_DISMISS_TIMEOUT_MS: 1e4,
		MIN_AUTO_DISMISS_TIMEOUT_MS: 4e3,
		SNACKBAR_ANIMATION_CLOSE_TIME_MS: 75,
		SNACKBAR_ANIMATION_OPEN_TIME_MS: 150,
		/**
		* Number of milliseconds to wait between temporarily clearing the label text
		* in the DOM and subsequently restoring it. This is necessary to force IE 11
		* to pick up the `aria-live` content change and announce it to the user.
		*/
		ARIA_LIVE_DELAY_MS: 1e3
	};

//#endregion
//#region node_modules/.pnpm/@material+snackbar@14.0.0/node_modules/@material/snackbar/util.js
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
	var ARIA_LIVE_DELAY_MS = numbers$3.ARIA_LIVE_DELAY_MS;
	var ARIA_LIVE_LABEL_TEXT_ATTR = strings$7.ARIA_LIVE_LABEL_TEXT_ATTR;
	function announce(ariaEl, labelEl) {
		if (labelEl === void 0) labelEl = ariaEl;
		var priority = ariaEl.getAttribute("aria-live");
		var labelText = labelEl.textContent.trim();
		if (!labelText || !priority) return;
		ariaEl.setAttribute("aria-live", "off");
		labelEl.textContent = "";
		var span = document.createElement("span");
		span.setAttribute("style", "display: inline-block; width: 0; height: 1px;");
		span.textContent = "\xA0";
		labelEl.appendChild(span);
		labelEl.setAttribute(ARIA_LIVE_LABEL_TEXT_ATTR, labelText);
		setTimeout(function() {
			ariaEl.setAttribute("aria-live", priority);
			labelEl.removeAttribute(ARIA_LIVE_LABEL_TEXT_ATTR);
			labelEl.textContent = labelText;
		}, ARIA_LIVE_DELAY_MS);
	}

//#endregion
//#region node_modules/.pnpm/@material+snackbar@14.0.0/node_modules/@material/snackbar/foundation.js
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
	var OPENING = cssClasses$4.OPENING;
	var OPEN = cssClasses$4.OPEN;
	var CLOSING = cssClasses$4.CLOSING;
	var REASON_ACTION = strings$7.REASON_ACTION;
	var REASON_DISMISS = strings$7.REASON_DISMISS;
	var MDCSnackbarFoundation = function(_super) {
		__extends(MDCSnackbarFoundation, _super);
		function MDCSnackbarFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCSnackbarFoundation.defaultAdapter), adapter)) || this;
			_this.opened = false;
			_this.animationFrame = 0;
			_this.animationTimer = 0;
			_this.autoDismissTimer = 0;
			_this.autoDismissTimeoutMs = numbers$3.DEFAULT_AUTO_DISMISS_TIMEOUT_MS;
			_this.closeOnEscape = true;
			return _this;
		}
		Object.defineProperty(MDCSnackbarFoundation, "cssClasses", {
			get: function() {
				return cssClasses$4;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSnackbarFoundation, "strings", {
			get: function() {
				return strings$7;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSnackbarFoundation, "numbers", {
			get: function() {
				return numbers$3;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSnackbarFoundation, "defaultAdapter", {
			get: function() {
				return {
					addClass: function() {},
					announce: function() {},
					notifyClosed: function() {},
					notifyClosing: function() {},
					notifyOpened: function() {},
					notifyOpening: function() {},
					removeClass: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCSnackbarFoundation.prototype.destroy = function() {
			this.clearAutoDismissTimer();
			cancelAnimationFrame(this.animationFrame);
			this.animationFrame = 0;
			clearTimeout(this.animationTimer);
			this.animationTimer = 0;
			this.adapter.removeClass(OPENING);
			this.adapter.removeClass(OPEN);
			this.adapter.removeClass(CLOSING);
		};
		MDCSnackbarFoundation.prototype.open = function() {
			var _this = this;
			this.clearAutoDismissTimer();
			this.opened = true;
			this.adapter.notifyOpening();
			this.adapter.removeClass(CLOSING);
			this.adapter.addClass(OPENING);
			this.adapter.announce();
			this.runNextAnimationFrame(function() {
				_this.adapter.addClass(OPEN);
				_this.animationTimer = setTimeout(function() {
					var timeoutMs = _this.getTimeoutMs();
					_this.handleAnimationTimerEnd();
					_this.adapter.notifyOpened();
					if (timeoutMs !== numbers$3.INDETERMINATE) _this.autoDismissTimer = setTimeout(function() {
						_this.close(REASON_DISMISS);
					}, timeoutMs);
				}, numbers$3.SNACKBAR_ANIMATION_OPEN_TIME_MS);
			});
		};
		/**
		* @param reason Why the snackbar was closed. Value will be passed to CLOSING_EVENT and CLOSED_EVENT via the
		*     `event.detail.reason` property. Standard values are REASON_ACTION and REASON_DISMISS, but custom
		*     client-specific values may also be used if desired.
		*/
		MDCSnackbarFoundation.prototype.close = function(reason) {
			var _this = this;
			if (reason === void 0) reason = "";
			if (!this.opened) return;
			cancelAnimationFrame(this.animationFrame);
			this.animationFrame = 0;
			this.clearAutoDismissTimer();
			this.opened = false;
			this.adapter.notifyClosing(reason);
			this.adapter.addClass(cssClasses$4.CLOSING);
			this.adapter.removeClass(cssClasses$4.OPEN);
			this.adapter.removeClass(cssClasses$4.OPENING);
			clearTimeout(this.animationTimer);
			this.animationTimer = setTimeout(function() {
				_this.handleAnimationTimerEnd();
				_this.adapter.notifyClosed(reason);
			}, numbers$3.SNACKBAR_ANIMATION_CLOSE_TIME_MS);
		};
		MDCSnackbarFoundation.prototype.isOpen = function() {
			return this.opened;
		};
		MDCSnackbarFoundation.prototype.getTimeoutMs = function() {
			return this.autoDismissTimeoutMs;
		};
		MDCSnackbarFoundation.prototype.setTimeoutMs = function(timeoutMs) {
			var minValue = numbers$3.MIN_AUTO_DISMISS_TIMEOUT_MS;
			var maxValue = numbers$3.MAX_AUTO_DISMISS_TIMEOUT_MS;
			var indeterminateValue = numbers$3.INDETERMINATE;
			if (timeoutMs === numbers$3.INDETERMINATE || timeoutMs <= maxValue && timeoutMs >= minValue) this.autoDismissTimeoutMs = timeoutMs;
			else throw new Error("\n        timeoutMs must be an integer in the range " + minValue + "–" + maxValue + "\n        (or " + indeterminateValue + " to disable), but got '" + timeoutMs + "'");
		};
		MDCSnackbarFoundation.prototype.getCloseOnEscape = function() {
			return this.closeOnEscape;
		};
		MDCSnackbarFoundation.prototype.setCloseOnEscape = function(closeOnEscape) {
			this.closeOnEscape = closeOnEscape;
		};
		MDCSnackbarFoundation.prototype.handleKeyDown = function(evt) {
			if ((evt.key === "Escape" || evt.keyCode === 27) && this.getCloseOnEscape()) this.close(REASON_DISMISS);
		};
		MDCSnackbarFoundation.prototype.handleActionButtonClick = function(_evt) {
			this.close(REASON_ACTION);
		};
		MDCSnackbarFoundation.prototype.handleActionIconClick = function(_evt) {
			this.close(REASON_DISMISS);
		};
		MDCSnackbarFoundation.prototype.clearAutoDismissTimer = function() {
			clearTimeout(this.autoDismissTimer);
			this.autoDismissTimer = 0;
		};
		MDCSnackbarFoundation.prototype.handleAnimationTimerEnd = function() {
			this.animationTimer = 0;
			this.adapter.removeClass(cssClasses$4.OPENING);
			this.adapter.removeClass(cssClasses$4.CLOSING);
		};
		/**
		* Runs the given logic on the next animation frame, using setTimeout to factor in Firefox reflow behavior.
		*/
		MDCSnackbarFoundation.prototype.runNextAnimationFrame = function(callback) {
			var _this = this;
			cancelAnimationFrame(this.animationFrame);
			this.animationFrame = requestAnimationFrame(function() {
				_this.animationFrame = 0;
				clearTimeout(_this.animationTimer);
				_this.animationTimer = setTimeout(callback, 0);
			});
		};
		return MDCSnackbarFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+snackbar@14.0.0/node_modules/@material/snackbar/component.js
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
	var SURFACE_SELECTOR = strings$7.SURFACE_SELECTOR;
	var LABEL_SELECTOR = strings$7.LABEL_SELECTOR;
	var ACTION_SELECTOR = strings$7.ACTION_SELECTOR;
	var DISMISS_SELECTOR = strings$7.DISMISS_SELECTOR;
	var OPENING_EVENT = strings$7.OPENING_EVENT;
	var OPENED_EVENT = strings$7.OPENED_EVENT;
	var CLOSING_EVENT = strings$7.CLOSING_EVENT;
	var CLOSED_EVENT = strings$7.CLOSED_EVENT;
	var MDCSnackbar = function(_super) {
		__extends(MDCSnackbar, _super);
		function MDCSnackbar() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCSnackbar.attachTo = function(root) {
			return new MDCSnackbar(root);
		};
		MDCSnackbar.prototype.initialize = function(announcerFactory) {
			if (announcerFactory === void 0) announcerFactory = function() {
				return announce;
			};
			this.announce = announcerFactory();
		};
		MDCSnackbar.prototype.initialSyncWithDOM = function() {
			var _this = this;
			this.surfaceEl = this.root.querySelector(SURFACE_SELECTOR);
			this.labelEl = this.root.querySelector(LABEL_SELECTOR);
			this.actionEl = this.root.querySelector(ACTION_SELECTOR);
			this.handleKeyDown = function(evt) {
				_this.foundation.handleKeyDown(evt);
			};
			this.handleSurfaceClick = function(evt) {
				var target = evt.target;
				if (_this.isActionButton(target)) _this.foundation.handleActionButtonClick(evt);
				else if (_this.isActionIcon(target)) _this.foundation.handleActionIconClick(evt);
			};
			this.registerKeyDownHandler(this.handleKeyDown);
			this.registerSurfaceClickHandler(this.handleSurfaceClick);
		};
		MDCSnackbar.prototype.destroy = function() {
			_super.prototype.destroy.call(this);
			this.deregisterKeyDownHandler(this.handleKeyDown);
			this.deregisterSurfaceClickHandler(this.handleSurfaceClick);
		};
		MDCSnackbar.prototype.open = function() {
			this.foundation.open();
		};
		/**
		* @param reason Why the snackbar was closed. Value will be passed to CLOSING_EVENT and CLOSED_EVENT via the
		*     `event.detail.reason` property. Standard values are REASON_ACTION and REASON_DISMISS, but custom
		*     client-specific values may also be used if desired.
		*/
		MDCSnackbar.prototype.close = function(reason) {
			if (reason === void 0) reason = "";
			this.foundation.close(reason);
		};
		MDCSnackbar.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCSnackbarFoundation({
				addClass: function(className) {
					_this.root.classList.add(className);
				},
				announce: function() {
					_this.announce(_this.labelEl);
				},
				notifyClosed: function(reason) {
					return _this.emit(CLOSED_EVENT, reason ? { reason } : {});
				},
				notifyClosing: function(reason) {
					return _this.emit(CLOSING_EVENT, reason ? { reason } : {});
				},
				notifyOpened: function() {
					return _this.emit(OPENED_EVENT, {});
				},
				notifyOpening: function() {
					return _this.emit(OPENING_EVENT, {});
				},
				removeClass: function(className) {
					return _this.root.classList.remove(className);
				}
			});
		};
		Object.defineProperty(MDCSnackbar.prototype, "timeoutMs", {
			get: function() {
				return this.foundation.getTimeoutMs();
			},
			set: function(timeoutMs) {
				this.foundation.setTimeoutMs(timeoutMs);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSnackbar.prototype, "closeOnEscape", {
			get: function() {
				return this.foundation.getCloseOnEscape();
			},
			set: function(closeOnEscape) {
				this.foundation.setCloseOnEscape(closeOnEscape);
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSnackbar.prototype, "isOpen", {
			get: function() {
				return this.foundation.isOpen();
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSnackbar.prototype, "labelText", {
			get: function() {
				return this.labelEl.textContent;
			},
			set: function(labelText) {
				this.labelEl.textContent = labelText;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCSnackbar.prototype, "actionButtonText", {
			get: function() {
				return this.actionEl.textContent;
			},
			set: function(actionButtonText) {
				this.actionEl.textContent = actionButtonText;
			},
			enumerable: false,
			configurable: true
		});
		MDCSnackbar.prototype.registerKeyDownHandler = function(handler) {
			this.listen("keydown", handler);
		};
		MDCSnackbar.prototype.deregisterKeyDownHandler = function(handler) {
			this.unlisten("keydown", handler);
		};
		MDCSnackbar.prototype.registerSurfaceClickHandler = function(handler) {
			this.surfaceEl.addEventListener("click", handler);
		};
		MDCSnackbar.prototype.deregisterSurfaceClickHandler = function(handler) {
			this.surfaceEl.removeEventListener("click", handler);
		};
		MDCSnackbar.prototype.isActionButton = function(target) {
			return Boolean(closest(target, ACTION_SELECTOR));
		};
		MDCSnackbar.prototype.isActionIcon = function(target) {
			return Boolean(closest(target, DISMISS_SELECTOR));
		};
		return MDCSnackbar;
	}(MDCComponent);

//#endregion
//#region Components/Snackbar/MBSnackbar.ts
	var MBSnackbar_exports = /* @__PURE__ */ __exportAll({ init: () => init$5 });
	function init$5(elem, dotnetReference, timeoutMs) {
		if (!elem) return;
		elem._snackbar = new MDCSnackbar(elem);
		elem._snackbar.listen("MDCSnackbar:closed", (r) => {
			dotnetReference.invokeMethodAsync("Closed", r);
		});
		elem._snackbar.timeoutMs = timeoutMs;
		elem._snackbar.open();
	}

//#endregion
//#region node_modules/.pnpm/@material+switch@14.0.0/node_modules/@material/switch/constants.js
/**
	* @license
	* Copyright 2021 Google Inc.
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
	/**
	* CSS classes used for switch.
	*/
	var CssClasses$1;
	(function(CssClasses) {
		CssClasses["PROCESSING"] = "mdc-switch--processing";
		CssClasses["SELECTED"] = "mdc-switch--selected";
		CssClasses["UNSELECTED"] = "mdc-switch--unselected";
	})(CssClasses$1 || (CssClasses$1 = {}));
	/**
	* Query selectors used for switch.
	*/
	var Selectors;
	(function(Selectors) {
		Selectors["RIPPLE"] = ".mdc-switch__ripple";
	})(Selectors || (Selectors = {}));

//#endregion
//#region node_modules/.pnpm/@material+base@14.0.0/node_modules/@material/base/observer.js
/**
	* @license
	* Copyright 2021 Google Inc.
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
	/**
	* Observe a target's property for changes. When a property changes, the
	* provided `Observer` function will be invoked with the properties current and
	* previous values.
	*
	* The returned cleanup function will stop listening to changes for the
	* provided `Observer`.
	*
	* @template T The observed target type.
	* @template K The observed property.
	* @param target - The target to observe.
	* @param property - The property of the target to observe.
	* @param observer - An observer function to invoke each time the property
	*     changes.
	* @return A cleanup function that will stop observing changes for the provided
	*     `Observer`.
	*/
	function observeProperty(target, property, observer) {
		var observers = installObserver(target, property).getObservers(property);
		observers.push(observer);
		return function() {
			observers.splice(observers.indexOf(observer), 1);
		};
	}
	/**
	* A Map of all `TargetObservers` that have been installed.
	*/
	var allTargetObservers = /* @__PURE__ */ new WeakMap();
	/**
	* Installs a `TargetObservers` for the provided target (if not already
	* installed), and replaces the given property with a getter and setter that
	* will respond to changes and call `TargetObservers`.
	*
	* Subsequent calls to `installObserver()` with the same target and property
	* will not override the property's previously installed getter/setter.
	*
	* @template T The observed target type.
	* @template K The observed property to create a getter/setter for.
	* @param target - The target to observe.
	* @param property - The property to create a getter/setter for, if needed.
	* @return The installed `TargetObservers` for the provided target.
	*/
	function installObserver(target, property) {
		var observersMap = /* @__PURE__ */ new Map();
		if (!allTargetObservers.has(target)) allTargetObservers.set(target, {
			isEnabled: true,
			getObservers: function(key) {
				var observers = observersMap.get(key) || [];
				if (!observersMap.has(key)) observersMap.set(key, observers);
				return observers;
			},
			installedProperties: /* @__PURE__ */ new Set()
		});
		var targetObservers = allTargetObservers.get(target);
		if (targetObservers.installedProperties.has(property)) return targetObservers;
		var descriptor = getDescriptor(target, property) || {
			configurable: true,
			enumerable: true,
			value: target[property],
			writable: true
		};
		var observedDescriptor = __assign({}, descriptor);
		var descGet = descriptor.get, descSet = descriptor.set;
		if ("value" in descriptor) {
			delete observedDescriptor.value;
			delete observedDescriptor.writable;
			var value_1 = descriptor.value;
			descGet = function() {
				return value_1;
			};
			if (descriptor.writable) descSet = function(newValue) {
				value_1 = newValue;
			};
		}
		if (descGet) observedDescriptor.get = function() {
			return descGet.call(this);
		};
		if (descSet) observedDescriptor.set = function(newValue) {
			var e_4, _a;
			var previous = descGet ? descGet.call(this) : newValue;
			descSet.call(this, newValue);
			if (targetObservers.isEnabled && (!descGet || newValue !== previous)) try {
				for (var _b = __values(targetObservers.getObservers(property)), _c = _b.next(); !_c.done; _c = _b.next()) {
					var observer = _c.value;
					observer(newValue, previous);
				}
			} catch (e_4_1) {
				e_4 = { error: e_4_1 };
			} finally {
				try {
					if (_c && !_c.done && (_a = _b.return)) _a.call(_b);
				} finally {
					if (e_4) throw e_4.error;
				}
			}
		};
		targetObservers.installedProperties.add(property);
		Object.defineProperty(target, property, observedDescriptor);
		return targetObservers;
	}
	/**
	* Retrieves the descriptor for a property from the provided target. This
	* function will walk up the target's prototype chain to search for the
	* descriptor.
	*
	* @template T The target type.
	* @template K The property type.
	* @param target - The target to retrieve a descriptor from.
	* @param property - The name of the property to retrieve a descriptor for.
	* @return the descriptor, or undefined if it does not exist. Keep in mind that
	*     plain properties may not have a descriptor defined.
	*/
	function getDescriptor(target, property) {
		var descriptorTarget = target;
		var descriptor;
		while (descriptorTarget) {
			descriptor = Object.getOwnPropertyDescriptor(descriptorTarget, property);
			if (descriptor) break;
			descriptorTarget = Object.getPrototypeOf(descriptorTarget);
		}
		return descriptor;
	}
	/**
	* Enables or disables all observers for a provided target. Changes to observed
	* properties will not call any observers when disabled.
	*
	* @template T The observed target type.
	* @param target - The target to enable or disable observers for.
	* @param enabled - True to enable or false to disable observers.
	*/
	function setObserversEnabled(target, enabled) {
		var targetObservers = allTargetObservers.get(target);
		if (targetObservers) targetObservers.isEnabled = enabled;
	}

//#endregion
//#region node_modules/.pnpm/@material+base@14.0.0/node_modules/@material/base/observer-foundation.js
/**
	* @license
	* Copyright 2021 Google Inc.
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
	var MDCObserverFoundation = function(_super) {
		__extends(MDCObserverFoundation, _super);
		function MDCObserverFoundation(adapter) {
			var _this = _super.call(this, adapter) || this;
			/** A set of cleanup functions to unobserve changes. */
			_this.unobserves = /* @__PURE__ */ new Set();
			return _this;
		}
		MDCObserverFoundation.prototype.destroy = function() {
			_super.prototype.destroy.call(this);
			this.unobserve();
		};
		/**
		* Observe a target's properties for changes using the provided map of
		* property names and observer functions.
		*
		* @template T The target type.
		* @param target - The target to observe.
		* @param observers - An object whose keys are target properties and values
		*     are observer functions that are called when the associated property
		*     changes.
		* @return A cleanup function that can be called to unobserve the
		*     target.
		*/
		MDCObserverFoundation.prototype.observe = function(target, observers) {
			var e_1, _a;
			var _this = this;
			var cleanup = [];
			try {
				for (var _b = __values(Object.keys(observers)), _c = _b.next(); !_c.done; _c = _b.next()) {
					var property = _c.value;
					var observer = observers[property].bind(this);
					cleanup.push(this.observeProperty(target, property, observer));
				}
			} catch (e_1_1) {
				e_1 = { error: e_1_1 };
			} finally {
				try {
					if (_c && !_c.done && (_a = _b.return)) _a.call(_b);
				} finally {
					if (e_1) throw e_1.error;
				}
			}
			var unobserve = function() {
				var e_2, _a;
				try {
					for (var cleanup_1 = __values(cleanup), cleanup_1_1 = cleanup_1.next(); !cleanup_1_1.done; cleanup_1_1 = cleanup_1.next()) {
						var cleanupFn = cleanup_1_1.value;
						cleanupFn();
					}
				} catch (e_2_1) {
					e_2 = { error: e_2_1 };
				} finally {
					try {
						if (cleanup_1_1 && !cleanup_1_1.done && (_a = cleanup_1.return)) _a.call(cleanup_1);
					} finally {
						if (e_2) throw e_2.error;
					}
				}
				_this.unobserves.delete(unobserve);
			};
			this.unobserves.add(unobserve);
			return unobserve;
		};
		/**
		* Observe a target's property for changes. When a property changes, the
		* provided `Observer` function will be invoked with the properties current
		* and previous values.
		*
		* The returned cleanup function will stop listening to changes for the
		* provided `Observer`.
		*
		* @template T The observed target type.
		* @template K The observed property.
		* @param target - The target to observe.
		* @param property - The property of the target to observe.
		* @param observer - An observer function to invoke each time the property
		*     changes.
		* @return A cleanup function that will stop observing changes for the
		*     provided `Observer`.
		*/
		MDCObserverFoundation.prototype.observeProperty = function(target, property, observer) {
			return observeProperty(target, property, observer);
		};
		/**
		* Enables or disables all observers for the provided target. Disabling
		* observers will prevent them from being called until they are re-enabled.
		*
		* @param target - The target to enable or disable observers for.
		* @param enabled - Whether or not observers should be called.
		*/
		MDCObserverFoundation.prototype.setObserversEnabled = function(target, enabled) {
			setObserversEnabled(target, enabled);
		};
		/**
		* Clean up all observers and stop listening for property changes.
		*/
		MDCObserverFoundation.prototype.unobserve = function() {
			var e_3, _a;
			try {
				for (var _b = __values(__spreadArray([], __read(this.unobserves))), _c = _b.next(); !_c.done; _c = _b.next()) {
					var unobserve = _c.value;
					unobserve();
				}
			} catch (e_3_1) {
				e_3 = { error: e_3_1 };
			} finally {
				try {
					if (_c && !_c.done && (_a = _b.return)) _a.call(_b);
				} finally {
					if (e_3) throw e_3.error;
				}
			}
		};
		return MDCObserverFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+switch@14.0.0/node_modules/@material/switch/foundation.js
/**
	* @license
	* Copyright 2021 Google Inc.
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
	/**
	* `MDCSwitchFoundation` provides a state-only foundation for a switch
	* component.
	*
	* State observers and event handler entrypoints update a component's adapter's
	* state with the logic needed for switch to function.
	*/
	var MDCSwitchFoundation = function(_super) {
		__extends(MDCSwitchFoundation, _super);
		function MDCSwitchFoundation(adapter) {
			var _this = _super.call(this, adapter) || this;
			_this.handleClick = _this.handleClick.bind(_this);
			return _this;
		}
		/**
		* Initializes the foundation and starts observing state changes.
		*/
		MDCSwitchFoundation.prototype.init = function() {
			this.observe(this.adapter.state, {
				disabled: this.stopProcessingIfDisabled,
				processing: this.stopProcessingIfDisabled
			});
		};
		/**
		* Event handler for switch click events. Clicking on a switch will toggle its
		* selected state.
		*/
		MDCSwitchFoundation.prototype.handleClick = function() {
			if (this.adapter.state.disabled) return;
			this.adapter.state.selected = !this.adapter.state.selected;
		};
		MDCSwitchFoundation.prototype.stopProcessingIfDisabled = function() {
			if (this.adapter.state.disabled) this.adapter.state.processing = false;
		};
		return MDCSwitchFoundation;
	}(MDCObserverFoundation);
	/**
	* `MDCSwitchRenderFoundation` provides a state and rendering foundation for a
	* switch component.
	*
	* State observers and event handler entrypoints update a component's
	* adapter's state with the logic needed for switch to function.
	*
	* In response to state changes, the rendering foundation uses the component's
	* render adapter to keep the component's DOM updated with the state.
	*/
	var MDCSwitchRenderFoundation = function(_super) {
		__extends(MDCSwitchRenderFoundation, _super);
		function MDCSwitchRenderFoundation() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		/**
		* Initializes the foundation and starts observing state changes.
		*/
		MDCSwitchRenderFoundation.prototype.init = function() {
			_super.prototype.init.call(this);
			this.observe(this.adapter.state, {
				disabled: this.onDisabledChange,
				processing: this.onProcessingChange,
				selected: this.onSelectedChange
			});
		};
		/**
		* Initializes the foundation from a server side rendered (SSR) component.
		* This will sync the adapter's state with the current state of the DOM.
		*
		* This method should be called after `init()`.
		*/
		MDCSwitchRenderFoundation.prototype.initFromDOM = function() {
			this.setObserversEnabled(this.adapter.state, false);
			this.adapter.state.selected = this.adapter.hasClass(CssClasses$1.SELECTED);
			this.onSelectedChange();
			this.adapter.state.disabled = this.adapter.isDisabled();
			this.adapter.state.processing = this.adapter.hasClass(CssClasses$1.PROCESSING);
			this.setObserversEnabled(this.adapter.state, true);
			this.stopProcessingIfDisabled();
		};
		MDCSwitchRenderFoundation.prototype.onDisabledChange = function() {
			this.adapter.setDisabled(this.adapter.state.disabled);
		};
		MDCSwitchRenderFoundation.prototype.onProcessingChange = function() {
			this.toggleClass(this.adapter.state.processing, CssClasses$1.PROCESSING);
		};
		MDCSwitchRenderFoundation.prototype.onSelectedChange = function() {
			this.adapter.setAriaChecked(String(this.adapter.state.selected));
			this.toggleClass(this.adapter.state.selected, CssClasses$1.SELECTED);
			this.toggleClass(!this.adapter.state.selected, CssClasses$1.UNSELECTED);
		};
		MDCSwitchRenderFoundation.prototype.toggleClass = function(addClass, className) {
			if (addClass) this.adapter.addClass(className);
			else this.adapter.removeClass(className);
		};
		return MDCSwitchRenderFoundation;
	}(MDCSwitchFoundation);

//#endregion
//#region node_modules/.pnpm/@material+switch@14.0.0/node_modules/@material/switch/component.js
/**
	* @license
	* Copyright 2021 Google Inc.
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
	/**
	* `MDCSwitch` provides a component implementation of a Material Design switch.
	*/
	var MDCSwitch = function(_super) {
		__extends(MDCSwitch, _super);
		function MDCSwitch(root, foundation) {
			var _this = _super.call(this, root, foundation) || this;
			_this.root = root;
			return _this;
		}
		/**
		* Creates a new `MDCSwitch` and attaches it to the given root element.
		* @param root The root to attach to.
		* @return the new component instance.
		*/
		MDCSwitch.attachTo = function(root) {
			return new MDCSwitch(root);
		};
		MDCSwitch.prototype.initialize = function() {
			this.ripple = new MDCRipple(this.root, this.createRippleFoundation());
		};
		MDCSwitch.prototype.initialSyncWithDOM = function() {
			var rippleElement = this.root.querySelector(Selectors.RIPPLE);
			if (!rippleElement) throw new Error("Switch " + Selectors.RIPPLE + " element is required.");
			this.rippleElement = rippleElement;
			this.root.addEventListener("click", this.foundation.handleClick);
			this.foundation.initFromDOM();
		};
		MDCSwitch.prototype.destroy = function() {
			_super.prototype.destroy.call(this);
			this.ripple.destroy();
			this.root.removeEventListener("click", this.foundation.handleClick);
		};
		MDCSwitch.prototype.getDefaultFoundation = function() {
			return new MDCSwitchRenderFoundation(this.createAdapter());
		};
		MDCSwitch.prototype.createAdapter = function() {
			var _this = this;
			return {
				addClass: function(className) {
					_this.root.classList.add(className);
				},
				hasClass: function(className) {
					return _this.root.classList.contains(className);
				},
				isDisabled: function() {
					return _this.root.disabled;
				},
				removeClass: function(className) {
					_this.root.classList.remove(className);
				},
				setAriaChecked: function(ariaChecked) {
					return _this.root.setAttribute("aria-checked", ariaChecked);
				},
				setDisabled: function(disabled) {
					_this.root.disabled = disabled;
				},
				state: this
			};
		};
		MDCSwitch.prototype.createRippleFoundation = function() {
			return new MDCRippleFoundation(this.createRippleAdapter());
		};
		MDCSwitch.prototype.createRippleAdapter = function() {
			var _this = this;
			return __assign(__assign({}, MDCRipple.createAdapter(this)), {
				computeBoundingRect: function() {
					return _this.rippleElement.getBoundingClientRect();
				},
				isUnbounded: function() {
					return true;
				}
			});
		};
		return MDCSwitch;
	}(MDCComponent);

//#endregion
//#region Components/Switch/MBSwitch.ts
	var MBSwitch_exports = /* @__PURE__ */ __exportAll({
		init: () => init$4,
		setDisabled: () => setDisabled$1,
		setSelected: () => setSelected
	});
	function init$4(elem, selected) {
		if (!elem) return;
		elem._switch = MDCSwitch.attachTo(elem);
		elem._switch.selected = selected;
	}
	function setSelected(elem, selected) {
		if (!elem) return;
		elem._switch.selected = selected;
	}
	function setDisabled$1(elem, disabled) {
		if (!elem) return;
		elem._switch.disabled = disabled;
	}

//#endregion
//#region node_modules/.pnpm/@material+tab-scroller@14.0.0/node_modules/@material/tab-scroller/constants.js
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
	var cssClasses$3 = {
		ANIMATING: "mdc-tab-scroller--animating",
		SCROLL_AREA_SCROLL: "mdc-tab-scroller__scroll-area--scroll",
		SCROLL_TEST: "mdc-tab-scroller__test"
	};
	var strings$6 = {
		AREA_SELECTOR: ".mdc-tab-scroller__scroll-area",
		CONTENT_SELECTOR: ".mdc-tab-scroller__scroll-content"
	};

//#endregion
//#region node_modules/.pnpm/@material+tab-scroller@14.0.0/node_modules/@material/tab-scroller/rtl-scroller.js
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
	var MDCTabScrollerRTL = function() {
		function MDCTabScrollerRTL(adapter) {
			this.adapter = adapter;
		}
		return MDCTabScrollerRTL;
	}();

//#endregion
//#region node_modules/.pnpm/@material+tab-scroller@14.0.0/node_modules/@material/tab-scroller/rtl-default-scroller.js
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
	var MDCTabScrollerRTLDefault = function(_super) {
		__extends(MDCTabScrollerRTLDefault, _super);
		function MDCTabScrollerRTLDefault() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCTabScrollerRTLDefault.prototype.getScrollPositionRTL = function() {
			var currentScrollLeft = this.adapter.getScrollAreaScrollLeft();
			var right = this.calculateScrollEdges().right;
			return Math.round(right - currentScrollLeft);
		};
		MDCTabScrollerRTLDefault.prototype.scrollToRTL = function(scrollX) {
			var edges = this.calculateScrollEdges();
			var currentScrollLeft = this.adapter.getScrollAreaScrollLeft();
			var clampedScrollLeft = this.clampScrollValue(edges.right - scrollX);
			return {
				finalScrollPosition: clampedScrollLeft,
				scrollDelta: clampedScrollLeft - currentScrollLeft
			};
		};
		MDCTabScrollerRTLDefault.prototype.incrementScrollRTL = function(scrollX) {
			var currentScrollLeft = this.adapter.getScrollAreaScrollLeft();
			var clampedScrollLeft = this.clampScrollValue(currentScrollLeft - scrollX);
			return {
				finalScrollPosition: clampedScrollLeft,
				scrollDelta: clampedScrollLeft - currentScrollLeft
			};
		};
		MDCTabScrollerRTLDefault.prototype.getAnimatingScrollPosition = function(scrollX) {
			return scrollX;
		};
		MDCTabScrollerRTLDefault.prototype.calculateScrollEdges = function() {
			return {
				left: 0,
				right: this.adapter.getScrollContentOffsetWidth() - this.adapter.getScrollAreaOffsetWidth()
			};
		};
		MDCTabScrollerRTLDefault.prototype.clampScrollValue = function(scrollX) {
			var edges = this.calculateScrollEdges();
			return Math.min(Math.max(edges.left, scrollX), edges.right);
		};
		return MDCTabScrollerRTLDefault;
	}(MDCTabScrollerRTL);

//#endregion
//#region node_modules/.pnpm/@material+tab-scroller@14.0.0/node_modules/@material/tab-scroller/rtl-negative-scroller.js
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
	var MDCTabScrollerRTLNegative = function(_super) {
		__extends(MDCTabScrollerRTLNegative, _super);
		function MDCTabScrollerRTLNegative() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCTabScrollerRTLNegative.prototype.getScrollPositionRTL = function(translateX) {
			var currentScrollLeft = this.adapter.getScrollAreaScrollLeft();
			return Math.round(translateX - currentScrollLeft);
		};
		MDCTabScrollerRTLNegative.prototype.scrollToRTL = function(scrollX) {
			var currentScrollLeft = this.adapter.getScrollAreaScrollLeft();
			var clampedScrollLeft = this.clampScrollValue(-scrollX);
			return {
				finalScrollPosition: clampedScrollLeft,
				scrollDelta: clampedScrollLeft - currentScrollLeft
			};
		};
		MDCTabScrollerRTLNegative.prototype.incrementScrollRTL = function(scrollX) {
			var currentScrollLeft = this.adapter.getScrollAreaScrollLeft();
			var clampedScrollLeft = this.clampScrollValue(currentScrollLeft - scrollX);
			return {
				finalScrollPosition: clampedScrollLeft,
				scrollDelta: clampedScrollLeft - currentScrollLeft
			};
		};
		MDCTabScrollerRTLNegative.prototype.getAnimatingScrollPosition = function(scrollX, translateX) {
			return scrollX - translateX;
		};
		MDCTabScrollerRTLNegative.prototype.calculateScrollEdges = function() {
			var contentWidth = this.adapter.getScrollContentOffsetWidth();
			return {
				left: this.adapter.getScrollAreaOffsetWidth() - contentWidth,
				right: 0
			};
		};
		MDCTabScrollerRTLNegative.prototype.clampScrollValue = function(scrollX) {
			var edges = this.calculateScrollEdges();
			return Math.max(Math.min(edges.right, scrollX), edges.left);
		};
		return MDCTabScrollerRTLNegative;
	}(MDCTabScrollerRTL);

//#endregion
//#region node_modules/.pnpm/@material+tab-scroller@14.0.0/node_modules/@material/tab-scroller/rtl-reverse-scroller.js
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
	var MDCTabScrollerRTLReverse = function(_super) {
		__extends(MDCTabScrollerRTLReverse, _super);
		function MDCTabScrollerRTLReverse() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCTabScrollerRTLReverse.prototype.getScrollPositionRTL = function(translateX) {
			var currentScrollLeft = this.adapter.getScrollAreaScrollLeft();
			return Math.round(currentScrollLeft - translateX);
		};
		MDCTabScrollerRTLReverse.prototype.scrollToRTL = function(scrollX) {
			var currentScrollLeft = this.adapter.getScrollAreaScrollLeft();
			var clampedScrollLeft = this.clampScrollValue(scrollX);
			return {
				finalScrollPosition: clampedScrollLeft,
				scrollDelta: currentScrollLeft - clampedScrollLeft
			};
		};
		MDCTabScrollerRTLReverse.prototype.incrementScrollRTL = function(scrollX) {
			var currentScrollLeft = this.adapter.getScrollAreaScrollLeft();
			var clampedScrollLeft = this.clampScrollValue(currentScrollLeft + scrollX);
			return {
				finalScrollPosition: clampedScrollLeft,
				scrollDelta: currentScrollLeft - clampedScrollLeft
			};
		};
		MDCTabScrollerRTLReverse.prototype.getAnimatingScrollPosition = function(scrollX, translateX) {
			return scrollX + translateX;
		};
		MDCTabScrollerRTLReverse.prototype.calculateScrollEdges = function() {
			return {
				left: this.adapter.getScrollContentOffsetWidth() - this.adapter.getScrollAreaOffsetWidth(),
				right: 0
			};
		};
		MDCTabScrollerRTLReverse.prototype.clampScrollValue = function(scrollX) {
			var edges = this.calculateScrollEdges();
			return Math.min(Math.max(edges.right, scrollX), edges.left);
		};
		return MDCTabScrollerRTLReverse;
	}(MDCTabScrollerRTL);

//#endregion
//#region node_modules/.pnpm/@material+tab-scroller@14.0.0/node_modules/@material/tab-scroller/foundation.js
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
	var MDCTabScrollerFoundation = function(_super) {
		__extends(MDCTabScrollerFoundation, _super);
		function MDCTabScrollerFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCTabScrollerFoundation.defaultAdapter), adapter)) || this;
			/**
			* Controls whether we should handle the transitionend and interaction events during the animation.
			*/
			_this.isAnimating = false;
			return _this;
		}
		Object.defineProperty(MDCTabScrollerFoundation, "cssClasses", {
			get: function() {
				return cssClasses$3;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTabScrollerFoundation, "strings", {
			get: function() {
				return strings$6;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTabScrollerFoundation, "defaultAdapter", {
			get: function() {
				return {
					eventTargetMatchesSelector: function() {
						return false;
					},
					addClass: function() {},
					removeClass: function() {},
					addScrollAreaClass: function() {},
					setScrollAreaStyleProperty: function() {},
					setScrollContentStyleProperty: function() {},
					getScrollContentStyleValue: function() {
						return "";
					},
					setScrollAreaScrollLeft: function() {},
					getScrollAreaScrollLeft: function() {
						return 0;
					},
					getScrollContentOffsetWidth: function() {
						return 0;
					},
					getScrollAreaOffsetWidth: function() {
						return 0;
					},
					computeScrollAreaClientRect: function() {
						return {
							top: 0,
							right: 0,
							bottom: 0,
							left: 0,
							width: 0,
							height: 0
						};
					},
					computeScrollContentClientRect: function() {
						return {
							top: 0,
							right: 0,
							bottom: 0,
							left: 0,
							width: 0,
							height: 0
						};
					},
					computeHorizontalScrollbarHeight: function() {
						return 0;
					}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCTabScrollerFoundation.prototype.init = function() {
			var horizontalScrollbarHeight = this.adapter.computeHorizontalScrollbarHeight();
			this.adapter.setScrollAreaStyleProperty("margin-bottom", -horizontalScrollbarHeight + "px");
			this.adapter.addScrollAreaClass(MDCTabScrollerFoundation.cssClasses.SCROLL_AREA_SCROLL);
		};
		/**
		* Computes the current visual scroll position
		*/
		MDCTabScrollerFoundation.prototype.getScrollPosition = function() {
			if (this.isRTL()) return this.computeCurrentScrollPositionRTL();
			var currentTranslateX = this.calculateCurrentTranslateX();
			return this.adapter.getScrollAreaScrollLeft() - currentTranslateX;
		};
		/**
		* Handles interaction events that occur during transition
		*/
		MDCTabScrollerFoundation.prototype.handleInteraction = function() {
			if (!this.isAnimating) return;
			this.stopScrollAnimation();
		};
		/**
		* Handles the transitionend event
		*/
		MDCTabScrollerFoundation.prototype.handleTransitionEnd = function(evt) {
			var evtTarget = evt.target;
			if (!this.isAnimating || !this.adapter.eventTargetMatchesSelector(evtTarget, MDCTabScrollerFoundation.strings.CONTENT_SELECTOR)) return;
			this.isAnimating = false;
			this.adapter.removeClass(MDCTabScrollerFoundation.cssClasses.ANIMATING);
		};
		/**
		* Increment the scroll value by the scrollXIncrement using animation.
		* @param scrollXIncrement The value by which to increment the scroll position
		*/
		MDCTabScrollerFoundation.prototype.incrementScroll = function(scrollXIncrement) {
			if (scrollXIncrement === 0) return;
			this.animate(this.getIncrementScrollOperation(scrollXIncrement));
		};
		/**
		* Increment the scroll value by the scrollXIncrement without animation.
		* @param scrollXIncrement The value by which to increment the scroll position
		*/
		MDCTabScrollerFoundation.prototype.incrementScrollImmediate = function(scrollXIncrement) {
			if (scrollXIncrement === 0) return;
			var operation = this.getIncrementScrollOperation(scrollXIncrement);
			if (operation.scrollDelta === 0) return;
			this.stopScrollAnimation();
			this.adapter.setScrollAreaScrollLeft(operation.finalScrollPosition);
		};
		/**
		* Scrolls to the given scrollX value
		*/
		MDCTabScrollerFoundation.prototype.scrollTo = function(scrollX) {
			if (this.isRTL()) {
				this.scrollToImplRTL(scrollX);
				return;
			}
			this.scrollToImpl(scrollX);
		};
		/**
		* @return Browser-specific {@link MDCTabScrollerRTL} instance.
		*/
		MDCTabScrollerFoundation.prototype.getRTLScroller = function() {
			if (!this.rtlScrollerInstance) this.rtlScrollerInstance = this.rtlScrollerFactory();
			return this.rtlScrollerInstance;
		};
		/**
		* @return translateX value from a CSS matrix transform function string.
		*/
		MDCTabScrollerFoundation.prototype.calculateCurrentTranslateX = function() {
			var transformValue = this.adapter.getScrollContentStyleValue("transform");
			if (transformValue === "none") return 0;
			var match = /\((.+?)\)/.exec(transformValue);
			if (!match) return 0;
			var matrixParams = match[1], _a = __read(matrixParams.split(","), 6);
			_a[0];
			_a[1];
			_a[2];
			_a[3];
			var tx = _a[4];
			_a[5];
			return parseFloat(tx);
		};
		/**
		* Calculates a safe scroll value that is > 0 and < the max scroll value
		* @param scrollX The distance to scroll
		*/
		MDCTabScrollerFoundation.prototype.clampScrollValue = function(scrollX) {
			var edges = this.calculateScrollEdges();
			return Math.min(Math.max(edges.left, scrollX), edges.right);
		};
		MDCTabScrollerFoundation.prototype.computeCurrentScrollPositionRTL = function() {
			var translateX = this.calculateCurrentTranslateX();
			return this.getRTLScroller().getScrollPositionRTL(translateX);
		};
		MDCTabScrollerFoundation.prototype.calculateScrollEdges = function() {
			return {
				left: 0,
				right: this.adapter.getScrollContentOffsetWidth() - this.adapter.getScrollAreaOffsetWidth()
			};
		};
		/**
		* Internal scroll method
		* @param scrollX The new scroll position
		*/
		MDCTabScrollerFoundation.prototype.scrollToImpl = function(scrollX) {
			var currentScrollX = this.getScrollPosition();
			var safeScrollX = this.clampScrollValue(scrollX);
			var scrollDelta = safeScrollX - currentScrollX;
			this.animate({
				finalScrollPosition: safeScrollX,
				scrollDelta
			});
		};
		/**
		* Internal RTL scroll method
		* @param scrollX The new scroll position
		*/
		MDCTabScrollerFoundation.prototype.scrollToImplRTL = function(scrollX) {
			var animation = this.getRTLScroller().scrollToRTL(scrollX);
			this.animate(animation);
		};
		/**
		* Internal method to compute the increment scroll operation values.
		* @param scrollX The desired scroll position increment
		* @return MDCTabScrollerAnimation with the sanitized values for performing the scroll operation.
		*/
		MDCTabScrollerFoundation.prototype.getIncrementScrollOperation = function(scrollX) {
			if (this.isRTL()) return this.getRTLScroller().incrementScrollRTL(scrollX);
			var currentScrollX = this.getScrollPosition();
			var targetScrollX = scrollX + currentScrollX;
			var safeScrollX = this.clampScrollValue(targetScrollX);
			return {
				finalScrollPosition: safeScrollX,
				scrollDelta: safeScrollX - currentScrollX
			};
		};
		/**
		* Animates the tab scrolling
		* @param animation The animation to apply
		*/
		MDCTabScrollerFoundation.prototype.animate = function(animation) {
			var _this = this;
			if (animation.scrollDelta === 0) return;
			this.stopScrollAnimation();
			this.adapter.setScrollAreaScrollLeft(animation.finalScrollPosition);
			this.adapter.setScrollContentStyleProperty("transform", "translateX(" + animation.scrollDelta + "px)");
			this.adapter.computeScrollAreaClientRect();
			requestAnimationFrame(function() {
				_this.adapter.addClass(MDCTabScrollerFoundation.cssClasses.ANIMATING);
				_this.adapter.setScrollContentStyleProperty("transform", "none");
			});
			this.isAnimating = true;
		};
		/**
		* Stops scroll animation
		*/
		MDCTabScrollerFoundation.prototype.stopScrollAnimation = function() {
			this.isAnimating = false;
			var currentScrollPosition = this.getAnimatingScrollPosition();
			this.adapter.removeClass(MDCTabScrollerFoundation.cssClasses.ANIMATING);
			this.adapter.setScrollContentStyleProperty("transform", "translateX(0px)");
			this.adapter.setScrollAreaScrollLeft(currentScrollPosition);
		};
		/**
		* Gets the current scroll position during animation
		*/
		MDCTabScrollerFoundation.prototype.getAnimatingScrollPosition = function() {
			var currentTranslateX = this.calculateCurrentTranslateX();
			var scrollLeft = this.adapter.getScrollAreaScrollLeft();
			if (this.isRTL()) return this.getRTLScroller().getAnimatingScrollPosition(scrollLeft, currentTranslateX);
			return scrollLeft - currentTranslateX;
		};
		/**
		* Determines the RTL Scroller to use
		*/
		MDCTabScrollerFoundation.prototype.rtlScrollerFactory = function() {
			var initialScrollLeft = this.adapter.getScrollAreaScrollLeft();
			this.adapter.setScrollAreaScrollLeft(initialScrollLeft - 1);
			var newScrollLeft = this.adapter.getScrollAreaScrollLeft();
			if (newScrollLeft < 0) {
				this.adapter.setScrollAreaScrollLeft(initialScrollLeft);
				return new MDCTabScrollerRTLNegative(this.adapter);
			}
			var rootClientRect = this.adapter.computeScrollAreaClientRect();
			var contentClientRect = this.adapter.computeScrollContentClientRect();
			var rightEdgeDelta = Math.round(contentClientRect.right - rootClientRect.right);
			this.adapter.setScrollAreaScrollLeft(initialScrollLeft);
			if (rightEdgeDelta === newScrollLeft) return new MDCTabScrollerRTLReverse(this.adapter);
			return new MDCTabScrollerRTLDefault(this.adapter);
		};
		MDCTabScrollerFoundation.prototype.isRTL = function() {
			return this.adapter.getScrollContentStyleValue("direction") === "rtl";
		};
		return MDCTabScrollerFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+tab-scroller@14.0.0/node_modules/@material/tab-scroller/util.js
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
	/**
	* Stores result from computeHorizontalScrollbarHeight to avoid redundant processing.
	*/
	var horizontalScrollbarHeight_;
	/**
	* Computes the height of browser-rendered horizontal scrollbars using a self-created test element.
	* May return 0 (e.g. on OS X browsers under default configuration).
	*/
	function computeHorizontalScrollbarHeight(documentObj, shouldCacheResult) {
		if (shouldCacheResult === void 0) shouldCacheResult = true;
		if (shouldCacheResult && typeof horizontalScrollbarHeight_ !== "undefined") return horizontalScrollbarHeight_;
		var el = documentObj.createElement("div");
		el.classList.add(cssClasses$3.SCROLL_TEST);
		documentObj.body.appendChild(el);
		var horizontalScrollbarHeight = el.offsetHeight - el.clientHeight;
		documentObj.body.removeChild(el);
		if (shouldCacheResult) horizontalScrollbarHeight_ = horizontalScrollbarHeight;
		return horizontalScrollbarHeight;
	}

//#endregion
//#region node_modules/.pnpm/@material+tab-scroller@14.0.0/node_modules/@material/tab-scroller/component.js
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
	var MDCTabScroller = function(_super) {
		__extends(MDCTabScroller, _super);
		function MDCTabScroller() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCTabScroller.attachTo = function(root) {
			return new MDCTabScroller(root);
		};
		MDCTabScroller.prototype.initialize = function() {
			this.area = this.root.querySelector(MDCTabScrollerFoundation.strings.AREA_SELECTOR);
			this.content = this.root.querySelector(MDCTabScrollerFoundation.strings.CONTENT_SELECTOR);
		};
		MDCTabScroller.prototype.initialSyncWithDOM = function() {
			var _this = this;
			this.handleInteraction = function() {
				_this.foundation.handleInteraction();
			};
			this.handleTransitionEnd = function(evt) {
				_this.foundation.handleTransitionEnd(evt);
			};
			this.area.addEventListener("wheel", this.handleInteraction, applyPassive());
			this.area.addEventListener("touchstart", this.handleInteraction, applyPassive());
			this.area.addEventListener("pointerdown", this.handleInteraction, applyPassive());
			this.area.addEventListener("mousedown", this.handleInteraction, applyPassive());
			this.area.addEventListener("keydown", this.handleInteraction, applyPassive());
			this.content.addEventListener("transitionend", this.handleTransitionEnd);
		};
		MDCTabScroller.prototype.destroy = function() {
			_super.prototype.destroy.call(this);
			this.area.removeEventListener("wheel", this.handleInteraction, applyPassive());
			this.area.removeEventListener("touchstart", this.handleInteraction, applyPassive());
			this.area.removeEventListener("pointerdown", this.handleInteraction, applyPassive());
			this.area.removeEventListener("mousedown", this.handleInteraction, applyPassive());
			this.area.removeEventListener("keydown", this.handleInteraction, applyPassive());
			this.content.removeEventListener("transitionend", this.handleTransitionEnd);
		};
		MDCTabScroller.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCTabScrollerFoundation({
				eventTargetMatchesSelector: function(evtTarget, selector) {
					return matches(evtTarget, selector);
				},
				addClass: function(className) {
					_this.root.classList.add(className);
				},
				removeClass: function(className) {
					_this.root.classList.remove(className);
				},
				addScrollAreaClass: function(className) {
					_this.area.classList.add(className);
				},
				setScrollAreaStyleProperty: function(prop, value) {
					_this.area.style.setProperty(prop, value);
				},
				setScrollContentStyleProperty: function(prop, value) {
					_this.content.style.setProperty(prop, value);
				},
				getScrollContentStyleValue: function(propName) {
					return window.getComputedStyle(_this.content).getPropertyValue(propName);
				},
				setScrollAreaScrollLeft: function(scrollX) {
					return _this.area.scrollLeft = scrollX;
				},
				getScrollAreaScrollLeft: function() {
					return _this.area.scrollLeft;
				},
				getScrollContentOffsetWidth: function() {
					return _this.content.offsetWidth;
				},
				getScrollAreaOffsetWidth: function() {
					return _this.area.offsetWidth;
				},
				computeScrollAreaClientRect: function() {
					return _this.area.getBoundingClientRect();
				},
				computeScrollContentClientRect: function() {
					return _this.content.getBoundingClientRect();
				},
				computeHorizontalScrollbarHeight: function() {
					return computeHorizontalScrollbarHeight(document);
				}
			});
		};
		/**
		* Returns the current visual scroll position
		*/
		MDCTabScroller.prototype.getScrollPosition = function() {
			return this.foundation.getScrollPosition();
		};
		/**
		* Returns the width of the scroll content
		*/
		MDCTabScroller.prototype.getScrollContentWidth = function() {
			return this.content.offsetWidth;
		};
		/**
		* Increments the scroll value by the given amount
		* @param scrollXIncrement The pixel value by which to increment the scroll value
		*/
		MDCTabScroller.prototype.incrementScroll = function(scrollXIncrement) {
			this.foundation.incrementScroll(scrollXIncrement);
		};
		/**
		* Scrolls to the given pixel position
		* @param scrollX The pixel value to scroll to
		*/
		MDCTabScroller.prototype.scrollTo = function(scrollX) {
			this.foundation.scrollTo(scrollX);
		};
		return MDCTabScroller;
	}(MDCComponent);

//#endregion
//#region node_modules/.pnpm/@material+tab-indicator@14.0.0/node_modules/@material/tab-indicator/constants.js
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
	var cssClasses$2 = {
		ACTIVE: "mdc-tab-indicator--active",
		FADE: "mdc-tab-indicator--fade",
		NO_TRANSITION: "mdc-tab-indicator--no-transition"
	};
	var strings$5 = { CONTENT_SELECTOR: ".mdc-tab-indicator__content" };

//#endregion
//#region node_modules/.pnpm/@material+tab-indicator@14.0.0/node_modules/@material/tab-indicator/foundation.js
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
	var MDCTabIndicatorFoundation = function(_super) {
		__extends(MDCTabIndicatorFoundation, _super);
		function MDCTabIndicatorFoundation(adapter) {
			return _super.call(this, __assign(__assign({}, MDCTabIndicatorFoundation.defaultAdapter), adapter)) || this;
		}
		Object.defineProperty(MDCTabIndicatorFoundation, "cssClasses", {
			get: function() {
				return cssClasses$2;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTabIndicatorFoundation, "strings", {
			get: function() {
				return strings$5;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTabIndicatorFoundation, "defaultAdapter", {
			get: function() {
				return {
					addClass: function() {},
					removeClass: function() {},
					computeContentClientRect: function() {
						return {
							top: 0,
							right: 0,
							bottom: 0,
							left: 0,
							width: 0,
							height: 0
						};
					},
					setContentStyleProperty: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCTabIndicatorFoundation.prototype.computeContentClientRect = function() {
			return this.adapter.computeContentClientRect();
		};
		return MDCTabIndicatorFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+tab-indicator@14.0.0/node_modules/@material/tab-indicator/fading-foundation.js
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
	/* istanbul ignore next: subclass is not a branch statement */
	var MDCFadingTabIndicatorFoundation = function(_super) {
		__extends(MDCFadingTabIndicatorFoundation, _super);
		function MDCFadingTabIndicatorFoundation() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCFadingTabIndicatorFoundation.prototype.activate = function() {
			this.adapter.addClass(MDCTabIndicatorFoundation.cssClasses.ACTIVE);
		};
		MDCFadingTabIndicatorFoundation.prototype.deactivate = function() {
			this.adapter.removeClass(MDCTabIndicatorFoundation.cssClasses.ACTIVE);
		};
		return MDCFadingTabIndicatorFoundation;
	}(MDCTabIndicatorFoundation);

//#endregion
//#region node_modules/.pnpm/@material+tab-indicator@14.0.0/node_modules/@material/tab-indicator/sliding-foundation.js
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
	/* istanbul ignore next: subclass is not a branch statement */
	var MDCSlidingTabIndicatorFoundation = function(_super) {
		__extends(MDCSlidingTabIndicatorFoundation, _super);
		function MDCSlidingTabIndicatorFoundation() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCSlidingTabIndicatorFoundation.prototype.activate = function(previousIndicatorClientRect) {
			if (!previousIndicatorClientRect) {
				this.adapter.addClass(MDCTabIndicatorFoundation.cssClasses.ACTIVE);
				return;
			}
			var currentClientRect = this.computeContentClientRect();
			var widthDelta = previousIndicatorClientRect.width / currentClientRect.width;
			var xPosition = previousIndicatorClientRect.left - currentClientRect.left;
			this.adapter.addClass(MDCTabIndicatorFoundation.cssClasses.NO_TRANSITION);
			this.adapter.setContentStyleProperty("transform", "translateX(" + xPosition + "px) scaleX(" + widthDelta + ")");
			this.computeContentClientRect();
			this.adapter.removeClass(MDCTabIndicatorFoundation.cssClasses.NO_TRANSITION);
			this.adapter.addClass(MDCTabIndicatorFoundation.cssClasses.ACTIVE);
			this.adapter.setContentStyleProperty("transform", "");
		};
		MDCSlidingTabIndicatorFoundation.prototype.deactivate = function() {
			this.adapter.removeClass(MDCTabIndicatorFoundation.cssClasses.ACTIVE);
		};
		return MDCSlidingTabIndicatorFoundation;
	}(MDCTabIndicatorFoundation);

//#endregion
//#region node_modules/.pnpm/@material+tab-indicator@14.0.0/node_modules/@material/tab-indicator/component.js
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
	var MDCTabIndicator = function(_super) {
		__extends(MDCTabIndicator, _super);
		function MDCTabIndicator() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCTabIndicator.attachTo = function(root) {
			return new MDCTabIndicator(root);
		};
		MDCTabIndicator.prototype.initialize = function() {
			this.content = this.root.querySelector(MDCTabIndicatorFoundation.strings.CONTENT_SELECTOR);
		};
		MDCTabIndicator.prototype.computeContentClientRect = function() {
			return this.foundation.computeContentClientRect();
		};
		MDCTabIndicator.prototype.getDefaultFoundation = function() {
			var _this = this;
			var adapter = {
				addClass: function(className) {
					return _this.root.classList.add(className);
				},
				removeClass: function(className) {
					return _this.root.classList.remove(className);
				},
				computeContentClientRect: function() {
					return _this.content.getBoundingClientRect();
				},
				setContentStyleProperty: function(prop, value) {
					_this.content.style.setProperty(prop, value);
				}
			};
			if (this.root.classList.contains(MDCTabIndicatorFoundation.cssClasses.FADE)) return new MDCFadingTabIndicatorFoundation(adapter);
			return new MDCSlidingTabIndicatorFoundation(adapter);
		};
		MDCTabIndicator.prototype.activate = function(previousIndicatorClientRect) {
			this.foundation.activate(previousIndicatorClientRect);
		};
		MDCTabIndicator.prototype.deactivate = function() {
			this.foundation.deactivate();
		};
		return MDCTabIndicator;
	}(MDCComponent);

//#endregion
//#region node_modules/.pnpm/@material+tab@14.0.0/node_modules/@material/tab/constants.js
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
	var cssClasses$1 = { ACTIVE: "mdc-tab--active" };
	var strings$4 = {
		ARIA_SELECTED: "aria-selected",
		CONTENT_SELECTOR: ".mdc-tab__content",
		INTERACTED_EVENT: "MDCTab:interacted",
		RIPPLE_SELECTOR: ".mdc-tab__ripple",
		TABINDEX: "tabIndex",
		TAB_INDICATOR_SELECTOR: ".mdc-tab-indicator"
	};

//#endregion
//#region node_modules/.pnpm/@material+tab@14.0.0/node_modules/@material/tab/foundation.js
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
	var MDCTabFoundation = function(_super) {
		__extends(MDCTabFoundation, _super);
		function MDCTabFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCTabFoundation.defaultAdapter), adapter)) || this;
			_this.focusOnActivate = true;
			return _this;
		}
		Object.defineProperty(MDCTabFoundation, "cssClasses", {
			get: function() {
				return cssClasses$1;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTabFoundation, "strings", {
			get: function() {
				return strings$4;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTabFoundation, "defaultAdapter", {
			get: function() {
				return {
					addClass: function() {},
					removeClass: function() {},
					hasClass: function() {
						return false;
					},
					setAttr: function() {},
					activateIndicator: function() {},
					deactivateIndicator: function() {},
					notifyInteracted: function() {},
					getOffsetLeft: function() {
						return 0;
					},
					getOffsetWidth: function() {
						return 0;
					},
					getContentOffsetLeft: function() {
						return 0;
					},
					getContentOffsetWidth: function() {
						return 0;
					},
					focus: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCTabFoundation.prototype.handleClick = function() {
			this.adapter.notifyInteracted();
		};
		MDCTabFoundation.prototype.isActive = function() {
			return this.adapter.hasClass(cssClasses$1.ACTIVE);
		};
		/**
		* Sets whether the tab should focus itself when activated
		*/
		MDCTabFoundation.prototype.setFocusOnActivate = function(focusOnActivate) {
			this.focusOnActivate = focusOnActivate;
		};
		/**
		* Activates the Tab
		*/
		MDCTabFoundation.prototype.activate = function(previousIndicatorClientRect) {
			this.adapter.addClass(cssClasses$1.ACTIVE);
			this.adapter.setAttr(strings$4.ARIA_SELECTED, "true");
			this.adapter.setAttr(strings$4.TABINDEX, "0");
			this.adapter.activateIndicator(previousIndicatorClientRect);
			if (this.focusOnActivate) this.adapter.focus();
		};
		/**
		* Deactivates the Tab
		*/
		MDCTabFoundation.prototype.deactivate = function() {
			if (!this.isActive()) return;
			this.adapter.removeClass(cssClasses$1.ACTIVE);
			this.adapter.setAttr(strings$4.ARIA_SELECTED, "false");
			this.adapter.setAttr(strings$4.TABINDEX, "-1");
			this.adapter.deactivateIndicator();
		};
		/**
		* Returns the dimensions of the Tab
		*/
		MDCTabFoundation.prototype.computeDimensions = function() {
			var rootWidth = this.adapter.getOffsetWidth();
			var rootLeft = this.adapter.getOffsetLeft();
			var contentWidth = this.adapter.getContentOffsetWidth();
			var contentLeft = this.adapter.getContentOffsetLeft();
			return {
				contentLeft: rootLeft + contentLeft,
				contentRight: rootLeft + contentLeft + contentWidth,
				rootLeft,
				rootRight: rootLeft + rootWidth
			};
		};
		return MDCTabFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+tab@14.0.0/node_modules/@material/tab/component.js
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
	var MDCTab = function(_super) {
		__extends(MDCTab, _super);
		function MDCTab() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCTab.attachTo = function(root) {
			return new MDCTab(root);
		};
		MDCTab.prototype.initialize = function(rippleFactory, tabIndicatorFactory) {
			if (rippleFactory === void 0) rippleFactory = function(el, foundation) {
				return new MDCRipple(el, foundation);
			};
			if (tabIndicatorFactory === void 0) tabIndicatorFactory = function(el) {
				return new MDCTabIndicator(el);
			};
			this.id = this.root.id;
			var rippleFoundation = new MDCRippleFoundation(MDCRipple.createAdapter(this));
			this.ripple = rippleFactory(this.root, rippleFoundation);
			var tabIndicatorElement = this.root.querySelector(MDCTabFoundation.strings.TAB_INDICATOR_SELECTOR);
			this.tabIndicator = tabIndicatorFactory(tabIndicatorElement);
			this.content = this.root.querySelector(MDCTabFoundation.strings.CONTENT_SELECTOR);
		};
		MDCTab.prototype.initialSyncWithDOM = function() {
			var _this = this;
			this.handleClick = function() {
				_this.foundation.handleClick();
			};
			this.listen("click", this.handleClick);
		};
		MDCTab.prototype.destroy = function() {
			this.unlisten("click", this.handleClick);
			this.ripple.destroy();
			_super.prototype.destroy.call(this);
		};
		MDCTab.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCTabFoundation({
				setAttr: function(attr, value) {
					return _this.root.setAttribute(attr, value);
				},
				addClass: function(className) {
					return _this.root.classList.add(className);
				},
				removeClass: function(className) {
					return _this.root.classList.remove(className);
				},
				hasClass: function(className) {
					return _this.root.classList.contains(className);
				},
				activateIndicator: function(previousIndicatorClientRect) {
					_this.tabIndicator.activate(previousIndicatorClientRect);
				},
				deactivateIndicator: function() {
					_this.tabIndicator.deactivate();
				},
				notifyInteracted: function() {
					return _this.emit(MDCTabFoundation.strings.INTERACTED_EVENT, { tabId: _this.id }, true);
				},
				getOffsetLeft: function() {
					return _this.root.offsetLeft;
				},
				getOffsetWidth: function() {
					return _this.root.offsetWidth;
				},
				getContentOffsetLeft: function() {
					return _this.content.offsetLeft;
				},
				getContentOffsetWidth: function() {
					return _this.content.offsetWidth;
				},
				focus: function() {
					return _this.root.focus();
				}
			});
		};
		Object.defineProperty(MDCTab.prototype, "active", {
			/**
			* Getter for the active state of the tab
			*/
			get: function() {
				return this.foundation.isActive();
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTab.prototype, "focusOnActivate", {
			set: function(focusOnActivate) {
				this.foundation.setFocusOnActivate(focusOnActivate);
			},
			enumerable: false,
			configurable: true
		});
		/**
		* Activates the tab
		*/
		MDCTab.prototype.activate = function(computeIndicatorClientRect) {
			this.foundation.activate(computeIndicatorClientRect);
		};
		/**
		* Deactivates the tab
		*/
		MDCTab.prototype.deactivate = function() {
			this.foundation.deactivate();
		};
		/**
		* Returns the indicator's client rect
		*/
		MDCTab.prototype.computeIndicatorClientRect = function() {
			return this.tabIndicator.computeContentClientRect();
		};
		MDCTab.prototype.computeDimensions = function() {
			return this.foundation.computeDimensions();
		};
		/**
		* Focuses the tab
		*/
		MDCTab.prototype.focus = function() {
			this.root.focus();
		};
		return MDCTab;
	}(MDCComponent);

//#endregion
//#region node_modules/.pnpm/@material+tab-bar@14.0.0/node_modules/@material/tab-bar/constants.js
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
	var strings$3 = {
		ARROW_LEFT_KEY: "ArrowLeft",
		ARROW_RIGHT_KEY: "ArrowRight",
		END_KEY: "End",
		ENTER_KEY: "Enter",
		HOME_KEY: "Home",
		SPACE_KEY: "Space",
		TAB_ACTIVATED_EVENT: "MDCTabBar:activated",
		TAB_SCROLLER_SELECTOR: ".mdc-tab-scroller",
		TAB_SELECTOR: ".mdc-tab"
	};
	var numbers$2 = {
		ARROW_LEFT_KEYCODE: 37,
		ARROW_RIGHT_KEYCODE: 39,
		END_KEYCODE: 35,
		ENTER_KEYCODE: 13,
		EXTRA_SCROLL_AMOUNT: 20,
		HOME_KEYCODE: 36,
		SPACE_KEYCODE: 32
	};

//#endregion
//#region node_modules/.pnpm/@material+tab-bar@14.0.0/node_modules/@material/tab-bar/foundation.js
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
	var ACCEPTABLE_KEYS = /* @__PURE__ */ new Set();
	ACCEPTABLE_KEYS.add(strings$3.ARROW_LEFT_KEY);
	ACCEPTABLE_KEYS.add(strings$3.ARROW_RIGHT_KEY);
	ACCEPTABLE_KEYS.add(strings$3.END_KEY);
	ACCEPTABLE_KEYS.add(strings$3.HOME_KEY);
	ACCEPTABLE_KEYS.add(strings$3.ENTER_KEY);
	ACCEPTABLE_KEYS.add(strings$3.SPACE_KEY);
	var KEYCODE_MAP = /* @__PURE__ */ new Map();
	KEYCODE_MAP.set(numbers$2.ARROW_LEFT_KEYCODE, strings$3.ARROW_LEFT_KEY);
	KEYCODE_MAP.set(numbers$2.ARROW_RIGHT_KEYCODE, strings$3.ARROW_RIGHT_KEY);
	KEYCODE_MAP.set(numbers$2.END_KEYCODE, strings$3.END_KEY);
	KEYCODE_MAP.set(numbers$2.HOME_KEYCODE, strings$3.HOME_KEY);
	KEYCODE_MAP.set(numbers$2.ENTER_KEYCODE, strings$3.ENTER_KEY);
	KEYCODE_MAP.set(numbers$2.SPACE_KEYCODE, strings$3.SPACE_KEY);
	var MDCTabBarFoundation = function(_super) {
		__extends(MDCTabBarFoundation, _super);
		function MDCTabBarFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCTabBarFoundation.defaultAdapter), adapter)) || this;
			_this.useAutomaticActivation = false;
			return _this;
		}
		Object.defineProperty(MDCTabBarFoundation, "strings", {
			get: function() {
				return strings$3;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTabBarFoundation, "numbers", {
			get: function() {
				return numbers$2;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTabBarFoundation, "defaultAdapter", {
			get: function() {
				return {
					scrollTo: function() {},
					incrementScroll: function() {},
					getScrollPosition: function() {
						return 0;
					},
					getScrollContentWidth: function() {
						return 0;
					},
					getOffsetWidth: function() {
						return 0;
					},
					isRTL: function() {
						return false;
					},
					setActiveTab: function() {},
					activateTabAtIndex: function() {},
					deactivateTabAtIndex: function() {},
					focusTabAtIndex: function() {},
					getTabIndicatorClientRectAtIndex: function() {
						return {
							top: 0,
							right: 0,
							bottom: 0,
							left: 0,
							width: 0,
							height: 0
						};
					},
					getTabDimensionsAtIndex: function() {
						return {
							rootLeft: 0,
							rootRight: 0,
							contentLeft: 0,
							contentRight: 0
						};
					},
					getPreviousActiveTabIndex: function() {
						return -1;
					},
					getFocusedTabIndex: function() {
						return -1;
					},
					getIndexOfTabById: function() {
						return -1;
					},
					getTabListLength: function() {
						return 0;
					},
					notifyTabActivated: function() {}
				};
			},
			enumerable: false,
			configurable: true
		});
		/**
		* Switches between automatic and manual activation modes.
		* See https://www.w3.org/TR/wai-aria-practices/#tabpanel for examples.
		*/
		MDCTabBarFoundation.prototype.setUseAutomaticActivation = function(useAutomaticActivation) {
			this.useAutomaticActivation = useAutomaticActivation;
		};
		MDCTabBarFoundation.prototype.activateTab = function(index) {
			var previousActiveIndex = this.adapter.getPreviousActiveTabIndex();
			if (!this.indexIsInRange(index) || index === previousActiveIndex) return;
			var previousClientRect;
			if (previousActiveIndex !== -1) {
				this.adapter.deactivateTabAtIndex(previousActiveIndex);
				previousClientRect = this.adapter.getTabIndicatorClientRectAtIndex(previousActiveIndex);
			}
			this.adapter.activateTabAtIndex(index, previousClientRect);
			this.scrollIntoView(index);
			this.adapter.notifyTabActivated(index);
		};
		MDCTabBarFoundation.prototype.handleKeyDown = function(evt) {
			var key = this.getKeyFromEvent(evt);
			if (key === void 0) return;
			if (!this.isActivationKey(key)) evt.preventDefault();
			if (this.useAutomaticActivation) {
				if (this.isActivationKey(key)) return;
				var index = this.determineTargetFromKey(this.adapter.getPreviousActiveTabIndex(), key);
				this.adapter.setActiveTab(index);
				this.scrollIntoView(index);
			} else {
				var focusedTabIndex = this.adapter.getFocusedTabIndex();
				if (this.isActivationKey(key)) this.adapter.setActiveTab(focusedTabIndex);
				else {
					var index = this.determineTargetFromKey(focusedTabIndex, key);
					this.adapter.focusTabAtIndex(index);
					this.scrollIntoView(index);
				}
			}
		};
		/**
		* Handles the MDCTab:interacted event
		*/
		MDCTabBarFoundation.prototype.handleTabInteraction = function(evt) {
			this.adapter.setActiveTab(this.adapter.getIndexOfTabById(evt.detail.tabId));
		};
		/**
		* Scrolls the tab at the given index into view
		* @param index The tab index to make visible
		*/
		MDCTabBarFoundation.prototype.scrollIntoView = function(index) {
			if (!this.indexIsInRange(index)) return;
			if (index === 0) {
				this.adapter.scrollTo(0);
				return;
			}
			if (index === this.adapter.getTabListLength() - 1) {
				this.adapter.scrollTo(this.adapter.getScrollContentWidth());
				return;
			}
			if (this.isRTL()) {
				this.scrollIntoViewImplRTL(index);
				return;
			}
			this.scrollIntoViewImpl(index);
		};
		/**
		* Private method for determining the index of the destination tab based on what key was pressed
		* @param origin The original index from which to determine the destination
		* @param key The name of the key
		*/
		MDCTabBarFoundation.prototype.determineTargetFromKey = function(origin, key) {
			var isRTL = this.isRTL();
			var maxIndex = this.adapter.getTabListLength() - 1;
			var shouldGoToEnd = key === strings$3.END_KEY;
			var shouldDecrement = key === strings$3.ARROW_LEFT_KEY && !isRTL || key === strings$3.ARROW_RIGHT_KEY && isRTL;
			var shouldIncrement = key === strings$3.ARROW_RIGHT_KEY && !isRTL || key === strings$3.ARROW_LEFT_KEY && isRTL;
			var index = origin;
			if (shouldGoToEnd) index = maxIndex;
			else if (shouldDecrement) index -= 1;
			else if (shouldIncrement) index += 1;
			else index = 0;
			if (index < 0) index = maxIndex;
			else if (index > maxIndex) index = 0;
			return index;
		};
		/**
		* Calculates the scroll increment that will make the tab at the given index visible
		* @param index The index of the tab
		* @param nextIndex The index of the next tab
		* @param scrollPosition The current scroll position
		* @param barWidth The width of the Tab Bar
		*/
		MDCTabBarFoundation.prototype.calculateScrollIncrement = function(index, nextIndex, scrollPosition, barWidth) {
			var nextTabDimensions = this.adapter.getTabDimensionsAtIndex(nextIndex);
			var relativeContentLeft = nextTabDimensions.contentLeft - scrollPosition - barWidth;
			var leftIncrement = nextTabDimensions.contentRight - scrollPosition - numbers$2.EXTRA_SCROLL_AMOUNT;
			var rightIncrement = relativeContentLeft + numbers$2.EXTRA_SCROLL_AMOUNT;
			if (nextIndex < index) return Math.min(leftIncrement, 0);
			return Math.max(rightIncrement, 0);
		};
		/**
		* Calculates the scroll increment that will make the tab at the given index visible in RTL
		* @param index The index of the tab
		* @param nextIndex The index of the next tab
		* @param scrollPosition The current scroll position
		* @param barWidth The width of the Tab Bar
		* @param scrollContentWidth The width of the scroll content
		*/
		MDCTabBarFoundation.prototype.calculateScrollIncrementRTL = function(index, nextIndex, scrollPosition, barWidth, scrollContentWidth) {
			var nextTabDimensions = this.adapter.getTabDimensionsAtIndex(nextIndex);
			var relativeContentLeft = scrollContentWidth - nextTabDimensions.contentLeft - scrollPosition;
			var leftIncrement = scrollContentWidth - nextTabDimensions.contentRight - scrollPosition - barWidth + numbers$2.EXTRA_SCROLL_AMOUNT;
			var rightIncrement = relativeContentLeft - numbers$2.EXTRA_SCROLL_AMOUNT;
			if (nextIndex > index) return Math.max(leftIncrement, 0);
			return Math.min(rightIncrement, 0);
		};
		/**
		* Determines the index of the adjacent tab closest to either edge of the Tab Bar
		* @param index The index of the tab
		* @param tabDimensions The dimensions of the tab
		* @param scrollPosition The current scroll position
		* @param barWidth The width of the tab bar
		*/
		MDCTabBarFoundation.prototype.findAdjacentTabIndexClosestToEdge = function(index, tabDimensions, scrollPosition, barWidth) {
			/**
			* Tabs are laid out in the Tab Scroller like this:
			*
			*    Scroll Position
			*    +---+
			*    |   |   Bar Width
			*    |   +-----------------------------------+
			*    |   |                                   |
			*    |   V                                   V
			*    |   +-----------------------------------+
			*    V   |             Tab Scroller          |
			*    +------------+--------------+-------------------+
			*    |    Tab     |      Tab     |        Tab        |
			*    +------------+--------------+-------------------+
			*        |                                   |
			*        +-----------------------------------+
			*
			* To determine the next adjacent index, we look at the Tab root left and
			* Tab root right, both relative to the scroll position. If the Tab root
			* left is less than 0, then we know it's out of view to the left. If the
			* Tab root right minus the bar width is greater than 0, we know the Tab is
			* out of view to the right. From there, we either increment or decrement
			* the index.
			*/
			var relativeRootLeft = tabDimensions.rootLeft - scrollPosition;
			var relativeRootRight = tabDimensions.rootRight - scrollPosition - barWidth;
			var relativeRootDelta = relativeRootLeft + relativeRootRight;
			var leftEdgeIsCloser = relativeRootLeft < 0 || relativeRootDelta < 0;
			var rightEdgeIsCloser = relativeRootRight > 0 || relativeRootDelta > 0;
			if (leftEdgeIsCloser) return index - 1;
			if (rightEdgeIsCloser) return index + 1;
			return -1;
		};
		/**
		* Determines the index of the adjacent tab closest to either edge of the Tab Bar in RTL
		* @param index The index of the tab
		* @param tabDimensions The dimensions of the tab
		* @param scrollPosition The current scroll position
		* @param barWidth The width of the tab bar
		* @param scrollContentWidth The width of the scroller content
		*/
		MDCTabBarFoundation.prototype.findAdjacentTabIndexClosestToEdgeRTL = function(index, tabDimensions, scrollPosition, barWidth, scrollContentWidth) {
			var rootLeft = scrollContentWidth - tabDimensions.rootLeft - barWidth - scrollPosition;
			var rootRight = scrollContentWidth - tabDimensions.rootRight - scrollPosition;
			var rootDelta = rootLeft + rootRight;
			var leftEdgeIsCloser = rootLeft > 0 || rootDelta > 0;
			var rightEdgeIsCloser = rootRight < 0 || rootDelta < 0;
			if (leftEdgeIsCloser) return index + 1;
			if (rightEdgeIsCloser) return index - 1;
			return -1;
		};
		/**
		* Returns the key associated with a keydown event
		* @param evt The keydown event
		*/
		MDCTabBarFoundation.prototype.getKeyFromEvent = function(evt) {
			if (ACCEPTABLE_KEYS.has(evt.key)) return evt.key;
			return KEYCODE_MAP.get(evt.keyCode);
		};
		MDCTabBarFoundation.prototype.isActivationKey = function(key) {
			return key === strings$3.SPACE_KEY || key === strings$3.ENTER_KEY;
		};
		/**
		* Returns whether a given index is inclusively between the ends
		* @param index The index to test
		*/
		MDCTabBarFoundation.prototype.indexIsInRange = function(index) {
			return index >= 0 && index < this.adapter.getTabListLength();
		};
		/**
		* Returns the view's RTL property
		*/
		MDCTabBarFoundation.prototype.isRTL = function() {
			return this.adapter.isRTL();
		};
		/**
		* Scrolls the tab at the given index into view for left-to-right user agents.
		* @param index The index of the tab to scroll into view
		*/
		MDCTabBarFoundation.prototype.scrollIntoViewImpl = function(index) {
			var scrollPosition = this.adapter.getScrollPosition();
			var barWidth = this.adapter.getOffsetWidth();
			var tabDimensions = this.adapter.getTabDimensionsAtIndex(index);
			var nextIndex = this.findAdjacentTabIndexClosestToEdge(index, tabDimensions, scrollPosition, barWidth);
			if (!this.indexIsInRange(nextIndex)) return;
			var scrollIncrement = this.calculateScrollIncrement(index, nextIndex, scrollPosition, barWidth);
			this.adapter.incrementScroll(scrollIncrement);
		};
		/**
		* Scrolls the tab at the given index into view in RTL
		* @param index The tab index to make visible
		*/
		MDCTabBarFoundation.prototype.scrollIntoViewImplRTL = function(index) {
			var scrollPosition = this.adapter.getScrollPosition();
			var barWidth = this.adapter.getOffsetWidth();
			var tabDimensions = this.adapter.getTabDimensionsAtIndex(index);
			var scrollWidth = this.adapter.getScrollContentWidth();
			var nextIndex = this.findAdjacentTabIndexClosestToEdgeRTL(index, tabDimensions, scrollPosition, barWidth, scrollWidth);
			if (!this.indexIsInRange(nextIndex)) return;
			var scrollIncrement = this.calculateScrollIncrementRTL(index, nextIndex, scrollPosition, barWidth, scrollWidth);
			this.adapter.incrementScroll(scrollIncrement);
		};
		return MDCTabBarFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+tab-bar@14.0.0/node_modules/@material/tab-bar/component.js
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
	var strings$2 = MDCTabBarFoundation.strings;
	var tabIdCounter = 0;
	var MDCTabBar = function(_super) {
		__extends(MDCTabBar, _super);
		function MDCTabBar() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCTabBar.attachTo = function(root) {
			return new MDCTabBar(root);
		};
		Object.defineProperty(MDCTabBar.prototype, "focusOnActivate", {
			set: function(focusOnActivate) {
				var e_1, _a;
				try {
					for (var _b = __values(this.tabList), _c = _b.next(); !_c.done; _c = _b.next()) {
						var tab = _c.value;
						tab.focusOnActivate = focusOnActivate;
					}
				} catch (e_1_1) {
					e_1 = { error: e_1_1 };
				} finally {
					try {
						if (_c && !_c.done && (_a = _b.return)) _a.call(_b);
					} finally {
						if (e_1) throw e_1.error;
					}
				}
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTabBar.prototype, "useAutomaticActivation", {
			set: function(useAutomaticActivation) {
				this.foundation.setUseAutomaticActivation(useAutomaticActivation);
			},
			enumerable: false,
			configurable: true
		});
		MDCTabBar.prototype.initialize = function(tabFactory, tabScrollerFactory) {
			if (tabFactory === void 0) tabFactory = function(el) {
				return new MDCTab(el);
			};
			if (tabScrollerFactory === void 0) tabScrollerFactory = function(el) {
				return new MDCTabScroller(el);
			};
			this.tabList = this.instantiateTabs(tabFactory);
			this.tabScroller = this.instantiatetabScroller(tabScrollerFactory);
		};
		MDCTabBar.prototype.initialSyncWithDOM = function() {
			var _this = this;
			this.handleTabInteraction = function(evt) {
				_this.foundation.handleTabInteraction(evt);
			};
			this.handleKeyDown = function(evt) {
				_this.foundation.handleKeyDown(evt);
			};
			this.listen(MDCTabFoundation.strings.INTERACTED_EVENT, this.handleTabInteraction);
			this.listen("keydown", this.handleKeyDown);
			for (var i = 0; i < this.tabList.length; i++) if (this.tabList[i].active) {
				this.scrollIntoView(i);
				break;
			}
		};
		MDCTabBar.prototype.destroy = function() {
			var e_2, _a;
			_super.prototype.destroy.call(this);
			this.unlisten(MDCTabFoundation.strings.INTERACTED_EVENT, this.handleTabInteraction);
			this.unlisten("keydown", this.handleKeyDown);
			try {
				for (var _b = __values(this.tabList), _c = _b.next(); !_c.done; _c = _b.next()) _c.value.destroy();
			} catch (e_2_1) {
				e_2 = { error: e_2_1 };
			} finally {
				try {
					if (_c && !_c.done && (_a = _b.return)) _a.call(_b);
				} finally {
					if (e_2) throw e_2.error;
				}
			}
			if (this.tabScroller) this.tabScroller.destroy();
		};
		MDCTabBar.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCTabBarFoundation({
				scrollTo: function(scrollX) {
					_this.tabScroller.scrollTo(scrollX);
				},
				incrementScroll: function(scrollXIncrement) {
					_this.tabScroller.incrementScroll(scrollXIncrement);
				},
				getScrollPosition: function() {
					return _this.tabScroller.getScrollPosition();
				},
				getScrollContentWidth: function() {
					return _this.tabScroller.getScrollContentWidth();
				},
				getOffsetWidth: function() {
					return _this.root.offsetWidth;
				},
				isRTL: function() {
					return window.getComputedStyle(_this.root).getPropertyValue("direction") === "rtl";
				},
				setActiveTab: function(index) {
					_this.foundation.activateTab(index);
				},
				activateTabAtIndex: function(index, clientRect) {
					_this.tabList[index].activate(clientRect);
				},
				deactivateTabAtIndex: function(index) {
					_this.tabList[index].deactivate();
				},
				focusTabAtIndex: function(index) {
					_this.tabList[index].focus();
				},
				getTabIndicatorClientRectAtIndex: function(index) {
					return _this.tabList[index].computeIndicatorClientRect();
				},
				getTabDimensionsAtIndex: function(index) {
					return _this.tabList[index].computeDimensions();
				},
				getPreviousActiveTabIndex: function() {
					for (var i = 0; i < _this.tabList.length; i++) if (_this.tabList[i].active) return i;
					return -1;
				},
				getFocusedTabIndex: function() {
					var tabElements = _this.getTabElements();
					var activeElement = document.activeElement;
					return tabElements.indexOf(activeElement);
				},
				getIndexOfTabById: function(id) {
					for (var i = 0; i < _this.tabList.length; i++) if (_this.tabList[i].id === id) return i;
					return -1;
				},
				getTabListLength: function() {
					return _this.tabList.length;
				},
				notifyTabActivated: function(index) {
					return _this.emit(strings$2.TAB_ACTIVATED_EVENT, { index }, true);
				}
			});
		};
		/**
		* Activates the tab at the given index
		* @param index The index of the tab
		*/
		MDCTabBar.prototype.activateTab = function(index) {
			this.foundation.activateTab(index);
		};
		/**
		* Scrolls the tab at the given index into view
		* @param index THe index of the tab
		*/
		MDCTabBar.prototype.scrollIntoView = function(index) {
			this.foundation.scrollIntoView(index);
		};
		/**
		* Returns all the tab elements in a nice clean array
		*/
		MDCTabBar.prototype.getTabElements = function() {
			return [].slice.call(this.root.querySelectorAll(strings$2.TAB_SELECTOR));
		};
		/**
		* Instantiates tab components on all child tab elements
		*/
		MDCTabBar.prototype.instantiateTabs = function(tabFactory) {
			return this.getTabElements().map(function(el) {
				el.id = el.id || "mdc-tab-" + ++tabIdCounter;
				return tabFactory(el);
			});
		};
		/**
		* Instantiates tab scroller component on the child tab scroller element
		*/
		MDCTabBar.prototype.instantiatetabScroller = function(tabScrollerFactory) {
			var tabScrollerElement = this.root.querySelector(strings$2.TAB_SCROLLER_SELECTOR);
			if (tabScrollerElement) return tabScrollerFactory(tabScrollerElement);
			return null;
		};
		return MDCTabBar;
	}(MDCComponent);

//#endregion
//#region Components/TabBar/MBTabBar.ts
	var MBTabBar_exports = /* @__PURE__ */ __exportAll({
		activateTab: () => activateTab,
		init: () => init$3
	});
	function init$3(elem, dotNetObject) {
		if (!elem) return;
		elem._tabBar = MDCTabBar.attachTo(elem);
		elem._callback = () => {
			let index = elem._tabBar.foundation.adapter.getFocusedTabIndex();
			dotNetObject.invokeMethodAsync("NotifyActivated", index);
		};
		elem._tabBar.listen("MDCTabBar:activated", elem._callback);
	}
	function activateTab(elem, index) {
		if (!elem) return;
		elem._tabBar.unlisten("MDCTabBar:activated", elem._callback);
		elem._tabBar.activateTab(index);
		elem._tabBar.listen("MDCTabBar:activated", elem._callback);
	}

//#endregion
//#region Components/TextField/MBTextField.ts
	var MBTextField_exports = /* @__PURE__ */ __exportAll({
		init: () => init$2,
		setDisabled: () => setDisabled,
		setHelperText: () => setHelperText,
		setType: () => setType,
		setValue: () => setValue
	});
	function init$2(elem, value, helperTextElem, helperText, helperTextPersistent, performsValidation) {
		if (!elem) return;
		elem._textField = MDCTextField.attachTo(elem);
		setValue(elem, value);
		setHelperText(elem, helperTextElem, helperText, helperTextPersistent, performsValidation, false, "");
	}
	function setValue(elem, value) {
		if (!elem) return;
		elem._textField.value = value;
	}
	function setDisabled(elem, value) {
		if (!elem) return;
		elem._textField.disabled = value;
	}
	function setHelperText(elem, helperTextElem, helperText, helperTextPersistent, performsValidation, shakeLabel, validationMessage) {
		if (!elem || !helperTextElem) return;
		if (helperText !== "" || performsValidation === true) {
			if (!elem._helperText) elem._helperText = MDCTextFieldHelperText.attachTo(helperTextElem);
			if (validationMessage !== "") {
				elem._helperText.root.innerHTML = sanitizeHTMLWithBreaks(validationMessage);
				elem._helperText.foundation.setPersistent(true);
				elem._helperText.foundation.setValidation(true);
				elem._helperText.foundation.setValidity(false);
				elem._textField.foundation.setValid(false);
				if (shakeLabel) elem._textField.foundation.adapter.shakeLabel(true);
			} else if (helperText !== "") {
				elem._helperText.foundation.setContent(helperText);
				elem._helperText.foundation.setPersistent(helperTextPersistent);
				elem._helperText.foundation.setValidation(false);
				elem._helperText.foundation.setValidity(true);
				elem._textField.foundation.setValid(true);
			} else {
				elem._helperText.foundation.setContent("");
				elem._helperText.foundation.setPersistent(false);
				elem._helperText.foundation.setValidation(false);
				elem._helperText.foundation.setValidity(true);
				elem._textField.foundation.setValid(true);
			}
		}
	}
	function setType(elem, value, inputElem, type, formNoValidate) {
		if (!elem || !inputElem) return;
		inputElem.setAttribute("type", type);
		inputElem.setAttribute("formnovalidate", formNoValidate);
		elem._textField.value = value;
		if (formNoValidate && elem._textField.foundation.adapter.isFocused() == true) inputElem.select();
	}
	/*!
	* Sanitize and encode all HTML in a user-submitted string
	* (c) 2018 Chris Ferdinandi, MIT License, https://gomakethings.com
	* @param  {String} str  The user-submitted string
	* @return {String} str  The sanitized string
	*/
	function sanitizeHTMLWithBreaks(str) {
		let tempDiv = document.createElement("div");
		tempDiv.textContent = str;
		let sanitized = tempDiv.innerHTML;
		tempDiv.remove();
		return sanitized.replace(new RegExp(escapeRegExp("&lt;br /&gt;"), "g"), "<br />");
	}
	function escapeRegExp(str) {
		return str.replace(/([.*+?^=!:${}()|\[\]\/\\])/g, "\\$1");
	}

//#endregion
//#region node_modules/.pnpm/@material+tooltip@14.0.0/node_modules/@material/tooltip/constants.js
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
	var CssClasses;
	(function(CssClasses) {
		CssClasses["RICH"] = "mdc-tooltip--rich";
		CssClasses["SHOWN"] = "mdc-tooltip--shown";
		CssClasses["SHOWING"] = "mdc-tooltip--showing";
		CssClasses["SHOWING_TRANSITION"] = "mdc-tooltip--showing-transition";
		CssClasses["HIDE"] = "mdc-tooltip--hide";
		CssClasses["HIDE_TRANSITION"] = "mdc-tooltip--hide-transition";
		CssClasses["MULTILINE_TOOLTIP"] = "mdc-tooltip--multiline";
		CssClasses["SURFACE"] = "mdc-tooltip__surface";
		CssClasses["SURFACE_ANIMATION"] = "mdc-tooltip__surface-animation";
		CssClasses["TOOLTIP_CARET_TOP"] = "mdc-tooltip__caret-surface-top";
		CssClasses["TOOLTIP_CARET_BOTTOM"] = "mdc-tooltip__caret-surface-bottom";
	})(CssClasses || (CssClasses = {}));
	var numbers$1 = {
		BOUNDED_ANCHOR_GAP: 4,
		UNBOUNDED_ANCHOR_GAP: 8,
		MIN_VIEWPORT_TOOLTIP_THRESHOLD: 8,
		HIDE_DELAY_MS: 600,
		SHOW_DELAY_MS: 500,
		MIN_HEIGHT: 24,
		MAX_WIDTH: 200,
		CARET_INDENTATION: 24,
		ANIMATION_SCALE: .8
	};
	var attributes = {
		ARIA_EXPANDED: "aria-expanded",
		ARIA_HASPOPUP: "aria-haspopup",
		PERSISTENT: "data-mdc-tooltip-persistent",
		SCROLLABLE_ANCESTOR: "tooltip-scrollable-ancestor",
		HAS_CARET: "data-mdc-tooltip-has-caret"
	};
	var events = { HIDDEN: "MDCTooltip:hidden" };
	/** Enum for possible tooltip positioning relative to its anchor element. */
	var XPosition;
	(function(XPosition) {
		XPosition[XPosition["DETECTED"] = 0] = "DETECTED";
		XPosition[XPosition["START"] = 1] = "START";
		XPosition[XPosition["CENTER"] = 2] = "CENTER";
		XPosition[XPosition["END"] = 3] = "END";
	})(XPosition || (XPosition = {}));
	var YPosition;
	(function(YPosition) {
		YPosition[YPosition["DETECTED"] = 0] = "DETECTED";
		YPosition[YPosition["ABOVE"] = 1] = "ABOVE";
		YPosition[YPosition["BELOW"] = 2] = "BELOW";
	})(YPosition || (YPosition = {}));
	/**
	* Enum for possible anchor boundary types. This determines the gap between the
	* bottom of the anchor and the tooltip element.
	* Bounded anchors have an identifiable boundary (e.g. buttons).
	* Unbounded anchors don't have a visually declared boundary (e.g. plain text).
	*/
	var AnchorBoundaryType;
	(function(AnchorBoundaryType) {
		AnchorBoundaryType[AnchorBoundaryType["BOUNDED"] = 0] = "BOUNDED";
		AnchorBoundaryType[AnchorBoundaryType["UNBOUNDED"] = 1] = "UNBOUNDED";
	})(AnchorBoundaryType || (AnchorBoundaryType = {}));
	var strings$1 = {
		LEFT: "left",
		RIGHT: "right",
		CENTER: "center",
		TOP: "top",
		BOTTOM: "bottom"
	};
	/**
	* Enum for possible positions of a tooltip with caret (this specifies the
	* positioning of the tooltip relative to the anchor -- the position of the
	* caret will follow that of the tooltip). This can NOT be combined with the
	* above X/YPosition options. Naming for the enums follows: (vertical
	* placement)_(horizontal placement).
	*/
	var PositionWithCaret;
	(function(PositionWithCaret) {
		PositionWithCaret[PositionWithCaret["DETECTED"] = 0] = "DETECTED";
		PositionWithCaret[PositionWithCaret["ABOVE_START"] = 1] = "ABOVE_START";
		PositionWithCaret[PositionWithCaret["ABOVE_CENTER"] = 2] = "ABOVE_CENTER";
		PositionWithCaret[PositionWithCaret["ABOVE_END"] = 3] = "ABOVE_END";
		PositionWithCaret[PositionWithCaret["TOP_SIDE_START"] = 4] = "TOP_SIDE_START";
		PositionWithCaret[PositionWithCaret["CENTER_SIDE_START"] = 5] = "CENTER_SIDE_START";
		PositionWithCaret[PositionWithCaret["BOTTOM_SIDE_START"] = 6] = "BOTTOM_SIDE_START";
		PositionWithCaret[PositionWithCaret["TOP_SIDE_END"] = 7] = "TOP_SIDE_END";
		PositionWithCaret[PositionWithCaret["CENTER_SIDE_END"] = 8] = "CENTER_SIDE_END";
		PositionWithCaret[PositionWithCaret["BOTTOM_SIDE_END"] = 9] = "BOTTOM_SIDE_END";
		PositionWithCaret[PositionWithCaret["BELOW_START"] = 10] = "BELOW_START";
		PositionWithCaret[PositionWithCaret["BELOW_CENTER"] = 11] = "BELOW_CENTER";
		PositionWithCaret[PositionWithCaret["BELOW_END"] = 12] = "BELOW_END";
	})(PositionWithCaret || (PositionWithCaret = {}));
	var YPositionWithCaret;
	(function(YPositionWithCaret) {
		YPositionWithCaret[YPositionWithCaret["ABOVE"] = 1] = "ABOVE";
		YPositionWithCaret[YPositionWithCaret["BELOW"] = 2] = "BELOW";
		YPositionWithCaret[YPositionWithCaret["SIDE_TOP"] = 3] = "SIDE_TOP";
		YPositionWithCaret[YPositionWithCaret["SIDE_CENTER"] = 4] = "SIDE_CENTER";
		YPositionWithCaret[YPositionWithCaret["SIDE_BOTTOM"] = 5] = "SIDE_BOTTOM";
	})(YPositionWithCaret || (YPositionWithCaret = {}));
	var XPositionWithCaret;
	(function(XPositionWithCaret) {
		XPositionWithCaret[XPositionWithCaret["START"] = 1] = "START";
		XPositionWithCaret[XPositionWithCaret["CENTER"] = 2] = "CENTER";
		XPositionWithCaret[XPositionWithCaret["END"] = 3] = "END";
		XPositionWithCaret[XPositionWithCaret["SIDE_START"] = 4] = "SIDE_START";
		XPositionWithCaret[XPositionWithCaret["SIDE_END"] = 5] = "SIDE_END";
	})(XPositionWithCaret || (XPositionWithCaret = {}));

//#endregion
//#region node_modules/.pnpm/@material+tooltip@14.0.0/node_modules/@material/tooltip/foundation.js
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
	var RICH = CssClasses.RICH;
	var SHOWN = CssClasses.SHOWN;
	var SHOWING = CssClasses.SHOWING;
	var SHOWING_TRANSITION = CssClasses.SHOWING_TRANSITION;
	var HIDE = CssClasses.HIDE;
	var HIDE_TRANSITION = CssClasses.HIDE_TRANSITION;
	var MULTILINE_TOOLTIP = CssClasses.MULTILINE_TOOLTIP;
	var AnimationKeys;
	(function(AnimationKeys) {
		AnimationKeys["POLL_ANCHOR"] = "poll_anchor";
	})(AnimationKeys || (AnimationKeys = {}));
	var HAS_WINDOW = typeof window !== "undefined";
	var MDCTooltipFoundation = function(_super) {
		__extends(MDCTooltipFoundation, _super);
		function MDCTooltipFoundation(adapter) {
			var _this = _super.call(this, __assign(__assign({}, MDCTooltipFoundation.defaultAdapter), adapter)) || this;
			_this.tooltipShown = false;
			_this.anchorGap = numbers$1.BOUNDED_ANCHOR_GAP;
			_this.xTooltipPos = XPosition.DETECTED;
			_this.yTooltipPos = YPosition.DETECTED;
			_this.tooltipPositionWithCaret = PositionWithCaret.DETECTED;
			_this.minViewportTooltipThreshold = numbers$1.MIN_VIEWPORT_TOOLTIP_THRESHOLD;
			_this.hideDelayMs = numbers$1.HIDE_DELAY_MS;
			_this.showDelayMs = numbers$1.SHOW_DELAY_MS;
			_this.anchorRect = null;
			_this.parentRect = null;
			_this.frameId = null;
			_this.hideTimeout = null;
			_this.showTimeout = null;
			_this.addAncestorScrollEventListeners = new Array();
			_this.removeAncestorScrollEventListeners = new Array();
			_this.animFrame = new AnimationFrame();
			_this.anchorBlurHandler = function(evt) {
				_this.handleAnchorBlur(evt);
			};
			_this.documentClickHandler = function(evt) {
				_this.handleDocumentClick(evt);
			};
			_this.documentKeydownHandler = function(evt) {
				_this.handleKeydown(evt);
			};
			_this.tooltipMouseEnterHandler = function() {
				_this.handleTooltipMouseEnter();
			};
			_this.tooltipMouseLeaveHandler = function() {
				_this.handleTooltipMouseLeave();
			};
			_this.richTooltipFocusOutHandler = function(evt) {
				_this.handleRichTooltipFocusOut(evt);
			};
			_this.windowScrollHandler = function() {
				_this.handleWindowScrollEvent();
			};
			_this.windowResizeHandler = function() {
				_this.handleWindowChangeEvent();
			};
			return _this;
		}
		Object.defineProperty(MDCTooltipFoundation, "defaultAdapter", {
			get: function() {
				return {
					getAttribute: function() {
						return null;
					},
					setAttribute: function() {},
					removeAttribute: function() {},
					addClass: function() {},
					hasClass: function() {
						return false;
					},
					removeClass: function() {},
					getComputedStyleProperty: function() {
						return "";
					},
					setStyleProperty: function() {},
					setSurfaceAnimationStyleProperty: function() {},
					getViewportWidth: function() {
						return 0;
					},
					getViewportHeight: function() {
						return 0;
					},
					getTooltipSize: function() {
						return {
							width: 0,
							height: 0
						};
					},
					getAnchorBoundingRect: function() {
						return {
							top: 0,
							right: 0,
							bottom: 0,
							left: 0,
							width: 0,
							height: 0
						};
					},
					getParentBoundingRect: function() {
						return {
							top: 0,
							right: 0,
							bottom: 0,
							left: 0,
							width: 0,
							height: 0
						};
					},
					getAnchorAttribute: function() {
						return null;
					},
					setAnchorAttribute: function() {
						return null;
					},
					isRTL: function() {
						return false;
					},
					anchorContainsElement: function() {
						return false;
					},
					tooltipContainsElement: function() {
						return false;
					},
					focusAnchorElement: function() {},
					registerEventHandler: function() {},
					deregisterEventHandler: function() {},
					registerAnchorEventHandler: function() {},
					deregisterAnchorEventHandler: function() {},
					registerDocumentEventHandler: function() {},
					deregisterDocumentEventHandler: function() {},
					registerWindowEventHandler: function() {},
					deregisterWindowEventHandler: function() {},
					notifyHidden: function() {},
					getTooltipCaretBoundingRect: function() {
						return {
							top: 0,
							right: 0,
							bottom: 0,
							left: 0,
							width: 0,
							height: 0
						};
					},
					setTooltipCaretStyle: function() {},
					clearTooltipCaretStyles: function() {},
					getActiveElement: function() {
						return null;
					}
				};
			},
			enumerable: false,
			configurable: true
		});
		MDCTooltipFoundation.prototype.init = function() {
			this.richTooltip = this.adapter.hasClass(RICH);
			this.persistentTooltip = this.adapter.getAttribute(attributes.PERSISTENT) === "true";
			this.interactiveTooltip = !!this.adapter.getAnchorAttribute(attributes.ARIA_EXPANDED) && this.adapter.getAnchorAttribute(attributes.ARIA_HASPOPUP) === "dialog";
			this.hasCaret = this.richTooltip && this.adapter.getAttribute(attributes.HAS_CARET) === "true";
		};
		MDCTooltipFoundation.prototype.isShown = function() {
			return this.tooltipShown;
		};
		MDCTooltipFoundation.prototype.isRich = function() {
			return this.richTooltip;
		};
		MDCTooltipFoundation.prototype.isPersistent = function() {
			return this.persistentTooltip;
		};
		MDCTooltipFoundation.prototype.handleAnchorMouseEnter = function() {
			var _this = this;
			if (this.tooltipShown) this.show();
			else {
				this.clearHideTimeout();
				this.showTimeout = setTimeout(function() {
					_this.show();
				}, this.showDelayMs);
			}
		};
		MDCTooltipFoundation.prototype.handleAnchorTouchstart = function() {
			var _this = this;
			this.showTimeout = setTimeout(function() {
				_this.show();
			}, this.showDelayMs);
			this.adapter.registerWindowEventHandler("contextmenu", this.preventContextMenuOnLongTouch);
		};
		MDCTooltipFoundation.prototype.preventContextMenuOnLongTouch = function(evt) {
			evt.preventDefault();
		};
		MDCTooltipFoundation.prototype.handleAnchorTouchend = function() {
			this.clearShowTimeout();
			if (!this.isShown()) this.adapter.deregisterWindowEventHandler("contextmenu", this.preventContextMenuOnLongTouch);
		};
		MDCTooltipFoundation.prototype.handleAnchorFocus = function(evt) {
			var _this = this;
			var relatedTarget = evt.relatedTarget;
			if (relatedTarget instanceof HTMLElement && this.adapter.tooltipContainsElement(relatedTarget)) return;
			this.showTimeout = setTimeout(function() {
				_this.show();
			}, this.showDelayMs);
		};
		MDCTooltipFoundation.prototype.handleAnchorMouseLeave = function() {
			var _this = this;
			this.clearShowTimeout();
			this.hideTimeout = setTimeout(function() {
				_this.hide();
			}, this.hideDelayMs);
		};
		MDCTooltipFoundation.prototype.handleAnchorClick = function() {
			if (this.tooltipShown) this.hide();
			else this.show();
		};
		MDCTooltipFoundation.prototype.handleDocumentClick = function(evt) {
			var anchorOrTooltipContainsTargetElement = evt.target instanceof HTMLElement && (this.adapter.anchorContainsElement(evt.target) || this.adapter.tooltipContainsElement(evt.target));
			if (this.richTooltip && this.persistentTooltip && anchorOrTooltipContainsTargetElement) return;
			this.hide();
		};
		MDCTooltipFoundation.prototype.handleKeydown = function(evt) {
			if (normalizeKey(evt) === KEY.ESCAPE) {
				var activeElement = this.adapter.getActiveElement();
				if (activeElement instanceof HTMLElement && this.adapter.tooltipContainsElement(activeElement)) this.adapter.focusAnchorElement();
				this.hide();
			}
		};
		MDCTooltipFoundation.prototype.handleAnchorBlur = function(evt) {
			if (this.richTooltip) {
				if (evt.relatedTarget instanceof HTMLElement && this.adapter.tooltipContainsElement(evt.relatedTarget)) return;
				if (evt.relatedTarget === null && this.interactiveTooltip) return;
			}
			this.hide();
		};
		MDCTooltipFoundation.prototype.handleTooltipMouseEnter = function() {
			this.show();
		};
		MDCTooltipFoundation.prototype.handleTooltipMouseLeave = function() {
			var _this = this;
			this.clearShowTimeout();
			this.hideTimeout = setTimeout(function() {
				_this.hide();
			}, this.hideDelayMs);
		};
		MDCTooltipFoundation.prototype.handleRichTooltipFocusOut = function(evt) {
			if (evt.relatedTarget instanceof HTMLElement && (this.adapter.anchorContainsElement(evt.relatedTarget) || this.adapter.tooltipContainsElement(evt.relatedTarget))) return;
			if (evt.relatedTarget === null && this.interactiveTooltip) return;
			this.hide();
		};
		MDCTooltipFoundation.prototype.handleWindowScrollEvent = function() {
			if (this.persistentTooltip) {
				this.handleWindowChangeEvent();
				return;
			}
			this.hide();
		};
		/**
		* On window resize or scroll, check the anchor position and size and
		* repostion tooltip if necessary.
		*/
		MDCTooltipFoundation.prototype.handleWindowChangeEvent = function() {
			var _this = this;
			this.animFrame.request(AnimationKeys.POLL_ANCHOR, function() {
				_this.repositionTooltipOnAnchorMove();
			});
		};
		MDCTooltipFoundation.prototype.show = function() {
			var e_1, _a;
			var _this = this;
			this.clearHideTimeout();
			this.clearShowTimeout();
			if (this.tooltipShown) return;
			this.tooltipShown = true;
			this.adapter.removeAttribute("aria-hidden");
			if (this.richTooltip) {
				if (this.interactiveTooltip) this.adapter.setAnchorAttribute("aria-expanded", "true");
				this.adapter.registerEventHandler("focusout", this.richTooltipFocusOutHandler);
			}
			if (!this.persistentTooltip) {
				this.adapter.registerEventHandler("mouseenter", this.tooltipMouseEnterHandler);
				this.adapter.registerEventHandler("mouseleave", this.tooltipMouseLeaveHandler);
			}
			this.adapter.removeClass(HIDE);
			this.adapter.addClass(SHOWING);
			if (this.isTooltipMultiline() && !this.richTooltip) this.adapter.addClass(MULTILINE_TOOLTIP);
			this.anchorRect = this.adapter.getAnchorBoundingRect();
			this.parentRect = this.adapter.getParentBoundingRect();
			this.richTooltip ? this.positionRichTooltip() : this.positionPlainTooltip();
			this.adapter.registerAnchorEventHandler("blur", this.anchorBlurHandler);
			this.adapter.registerDocumentEventHandler("click", this.documentClickHandler);
			this.adapter.registerDocumentEventHandler("keydown", this.documentKeydownHandler);
			this.adapter.registerWindowEventHandler("scroll", this.windowScrollHandler);
			this.adapter.registerWindowEventHandler("resize", this.windowResizeHandler);
			try {
				for (var _b = __values(this.addAncestorScrollEventListeners), _c = _b.next(); !_c.done; _c = _b.next()) {
					var fn = _c.value;
					fn();
				}
			} catch (e_1_1) {
				e_1 = { error: e_1_1 };
			} finally {
				try {
					if (_c && !_c.done && (_a = _b.return)) _a.call(_b);
				} finally {
					if (e_1) throw e_1.error;
				}
			}
			this.frameId = requestAnimationFrame(function() {
				_this.clearAllAnimationClasses();
				_this.adapter.addClass(SHOWN);
				_this.adapter.addClass(SHOWING_TRANSITION);
			});
		};
		MDCTooltipFoundation.prototype.hide = function() {
			var e_2, _a;
			this.clearHideTimeout();
			this.clearShowTimeout();
			if (!this.tooltipShown) return;
			if (this.frameId) cancelAnimationFrame(this.frameId);
			this.tooltipShown = false;
			this.adapter.setAttribute("aria-hidden", "true");
			this.adapter.deregisterEventHandler("focusout", this.richTooltipFocusOutHandler);
			if (this.richTooltip) {
				if (this.interactiveTooltip) this.adapter.setAnchorAttribute("aria-expanded", "false");
			}
			if (!this.persistentTooltip) {
				this.adapter.deregisterEventHandler("mouseenter", this.tooltipMouseEnterHandler);
				this.adapter.deregisterEventHandler("mouseleave", this.tooltipMouseLeaveHandler);
			}
			this.clearAllAnimationClasses();
			this.adapter.addClass(HIDE);
			this.adapter.addClass(HIDE_TRANSITION);
			this.adapter.removeClass(SHOWN);
			this.adapter.deregisterAnchorEventHandler("blur", this.anchorBlurHandler);
			this.adapter.deregisterDocumentEventHandler("click", this.documentClickHandler);
			this.adapter.deregisterDocumentEventHandler("keydown", this.documentKeydownHandler);
			this.adapter.deregisterWindowEventHandler("scroll", this.windowScrollHandler);
			this.adapter.deregisterWindowEventHandler("resize", this.windowResizeHandler);
			this.adapter.deregisterWindowEventHandler("contextmenu", this.preventContextMenuOnLongTouch);
			try {
				for (var _b = __values(this.removeAncestorScrollEventListeners), _c = _b.next(); !_c.done; _c = _b.next()) {
					var fn = _c.value;
					fn();
				}
			} catch (e_2_1) {
				e_2 = { error: e_2_1 };
			} finally {
				try {
					if (_c && !_c.done && (_a = _b.return)) _a.call(_b);
				} finally {
					if (e_2) throw e_2.error;
				}
			}
		};
		MDCTooltipFoundation.prototype.handleTransitionEnd = function() {
			var isHidingTooltip = this.adapter.hasClass(HIDE);
			this.adapter.removeClass(SHOWING);
			this.adapter.removeClass(SHOWING_TRANSITION);
			this.adapter.removeClass(HIDE);
			this.adapter.removeClass(HIDE_TRANSITION);
			if (isHidingTooltip && this.showTimeout === null) this.adapter.notifyHidden();
		};
		MDCTooltipFoundation.prototype.clearAllAnimationClasses = function() {
			this.adapter.removeClass(SHOWING_TRANSITION);
			this.adapter.removeClass(HIDE_TRANSITION);
		};
		MDCTooltipFoundation.prototype.setTooltipPosition = function(position) {
			var xPos = position.xPos, yPos = position.yPos, withCaretPos = position.withCaretPos;
			if (this.hasCaret && withCaretPos) {
				this.tooltipPositionWithCaret = withCaretPos;
				return;
			}
			if (xPos) this.xTooltipPos = xPos;
			if (yPos) this.yTooltipPos = yPos;
		};
		MDCTooltipFoundation.prototype.setAnchorBoundaryType = function(type) {
			if (type === AnchorBoundaryType.UNBOUNDED) this.anchorGap = numbers$1.UNBOUNDED_ANCHOR_GAP;
			else this.anchorGap = numbers$1.BOUNDED_ANCHOR_GAP;
		};
		MDCTooltipFoundation.prototype.setShowDelay = function(delayMs) {
			this.showDelayMs = delayMs;
		};
		MDCTooltipFoundation.prototype.setHideDelay = function(delayMs) {
			this.hideDelayMs = delayMs;
		};
		MDCTooltipFoundation.prototype.isTooltipMultiline = function() {
			var tooltipSize = this.adapter.getTooltipSize();
			return tooltipSize.height > numbers$1.MIN_HEIGHT && tooltipSize.width >= numbers$1.MAX_WIDTH;
		};
		MDCTooltipFoundation.prototype.positionPlainTooltip = function() {
			var _a = this.calculateTooltipStyles(this.anchorRect), top = _a.top, yTransformOrigin = _a.yTransformOrigin, left = _a.left, xTransformOrigin = _a.xTransformOrigin;
			var transformProperty = HAS_WINDOW ? getCorrectPropertyName(window, "transform") : "transform";
			this.adapter.setSurfaceAnimationStyleProperty(transformProperty + "-origin", xTransformOrigin + " " + yTransformOrigin);
			this.adapter.setStyleProperty("top", top + "px");
			this.adapter.setStyleProperty("left", left + "px");
		};
		MDCTooltipFoundation.prototype.positionRichTooltip = function() {
			var _a, _b, _c, _d;
			var width = this.adapter.getComputedStyleProperty("width");
			this.adapter.setStyleProperty("width", width);
			var _e = this.hasCaret ? this.calculateTooltipWithCaretStyles(this.anchorRect) : this.calculateTooltipStyles(this.anchorRect), top = _e.top, yTransformOrigin = _e.yTransformOrigin, left = _e.left, xTransformOrigin = _e.xTransformOrigin;
			var transformProperty = HAS_WINDOW ? getCorrectPropertyName(window, "transform") : "transform";
			this.adapter.setSurfaceAnimationStyleProperty(transformProperty + "-origin", xTransformOrigin + " " + yTransformOrigin);
			var leftAdjustment = left - ((_b = (_a = this.parentRect) === null || _a === void 0 ? void 0 : _a.left) !== null && _b !== void 0 ? _b : 0);
			var topAdjustment = top - ((_d = (_c = this.parentRect) === null || _c === void 0 ? void 0 : _c.top) !== null && _d !== void 0 ? _d : 0);
			this.adapter.setStyleProperty("top", topAdjustment + "px");
			this.adapter.setStyleProperty("left", leftAdjustment + "px");
		};
		/**
		* Calculates the position of the tooltip. A tooltip will be placed beneath
		* the anchor element and aligned either with the 'start'/'end' edge of the
		* anchor element or the 'center'.
		*
		* Tooltip alignment is selected such that the tooltip maintains a threshold
		* distance away from the viewport (defaulting to 'center' alignment). If the
		* placement of the anchor prevents this threshold distance from being
		* maintained, the tooltip is positioned so that it does not collide with the
		* viewport.
		*
		* Users can specify an alignment, however, if this alignment results in the
		* tooltip colliding with the viewport, this specification is overwritten.
		*/
		MDCTooltipFoundation.prototype.calculateTooltipStyles = function(anchorRect) {
			if (!anchorRect) return {
				top: 0,
				left: 0
			};
			var tooltipSize = this.adapter.getTooltipSize();
			var top = this.calculateYTooltipDistance(anchorRect, tooltipSize.height);
			var left = this.calculateXTooltipDistance(anchorRect, tooltipSize.width);
			return {
				top: top.distance,
				yTransformOrigin: top.yTransformOrigin,
				left: left.distance,
				xTransformOrigin: left.xTransformOrigin
			};
		};
		/**
		* Calculates the `left` distance for the tooltip.
		* Returns the distance value and a string indicating the x-axis transform-
		* origin that should be used when animating the tooltip.
		*/
		MDCTooltipFoundation.prototype.calculateXTooltipDistance = function(anchorRect, tooltipWidth) {
			var isLTR = !this.adapter.isRTL();
			var startPos, endPos, centerPos;
			var startTransformOrigin, endTransformOrigin;
			if (this.richTooltip) {
				startPos = isLTR ? anchorRect.left - tooltipWidth : anchorRect.right;
				endPos = isLTR ? anchorRect.right : anchorRect.left - tooltipWidth;
				startTransformOrigin = isLTR ? strings$1.RIGHT : strings$1.LEFT;
				endTransformOrigin = isLTR ? strings$1.LEFT : strings$1.RIGHT;
			} else {
				startPos = isLTR ? anchorRect.left : anchorRect.right - tooltipWidth;
				endPos = isLTR ? anchorRect.right - tooltipWidth : anchorRect.left;
				centerPos = anchorRect.left + (anchorRect.width - tooltipWidth) / 2;
				startTransformOrigin = isLTR ? strings$1.LEFT : strings$1.RIGHT;
				endTransformOrigin = isLTR ? strings$1.RIGHT : strings$1.LEFT;
			}
			var positionOptions = this.richTooltip ? this.determineValidPositionOptions(startPos, endPos) : this.determineValidPositionOptions(centerPos, startPos, endPos);
			if (this.xTooltipPos === XPosition.START && positionOptions.has(startPos)) return {
				distance: startPos,
				xTransformOrigin: startTransformOrigin
			};
			if (this.xTooltipPos === XPosition.END && positionOptions.has(endPos)) return {
				distance: endPos,
				xTransformOrigin: endTransformOrigin
			};
			if (this.xTooltipPos === XPosition.CENTER && positionOptions.has(centerPos)) return {
				distance: centerPos,
				xTransformOrigin: strings$1.CENTER
			};
			var validPosition = (this.richTooltip ? [{
				distance: endPos,
				xTransformOrigin: endTransformOrigin
			}, {
				distance: startPos,
				xTransformOrigin: startTransformOrigin
			}] : [
				{
					distance: centerPos,
					xTransformOrigin: strings$1.CENTER
				},
				{
					distance: startPos,
					xTransformOrigin: startTransformOrigin
				},
				{
					distance: endPos,
					xTransformOrigin: endTransformOrigin
				}
			]).find(function(_a) {
				var distance = _a.distance;
				return positionOptions.has(distance);
			});
			if (validPosition) return validPosition;
			if (anchorRect.left < 0) return {
				distance: this.minViewportTooltipThreshold,
				xTransformOrigin: strings$1.LEFT
			};
			else return {
				distance: this.adapter.getViewportWidth() - (tooltipWidth + this.minViewportTooltipThreshold),
				xTransformOrigin: strings$1.RIGHT
			};
		};
		/**
		* Given the values for the horizontal alignments of the tooltip, calculates
		* which of these options would result in the tooltip maintaining the required
		* threshold distance vs which would result in the tooltip staying within the
		* viewport.
		*
		* A Set of values is returned holding the distances that would honor the
		* above requirements. Following the logic for determining the tooltip
		* position, if all alignments violate the threshold, then the returned Set
		* contains values that keep the tooltip within the viewport.
		*/
		MDCTooltipFoundation.prototype.determineValidPositionOptions = function() {
			var e_3, _a;
			var positions = [];
			for (var _i = 0; _i < arguments.length; _i++) positions[_i] = arguments[_i];
			var posWithinThreshold = /* @__PURE__ */ new Set();
			var posWithinViewport = /* @__PURE__ */ new Set();
			try {
				for (var positions_1 = __values(positions), positions_1_1 = positions_1.next(); !positions_1_1.done; positions_1_1 = positions_1.next()) {
					var position = positions_1_1.value;
					if (this.positionHonorsViewportThreshold(position)) posWithinThreshold.add(position);
					else if (this.positionDoesntCollideWithViewport(position)) posWithinViewport.add(position);
				}
			} catch (e_3_1) {
				e_3 = { error: e_3_1 };
			} finally {
				try {
					if (positions_1_1 && !positions_1_1.done && (_a = positions_1.return)) _a.call(positions_1);
				} finally {
					if (e_3) throw e_3.error;
				}
			}
			return posWithinThreshold.size ? posWithinThreshold : posWithinViewport;
		};
		MDCTooltipFoundation.prototype.positionHonorsViewportThreshold = function(leftPos) {
			var viewportWidth = this.adapter.getViewportWidth();
			return leftPos + this.adapter.getTooltipSize().width <= viewportWidth - this.minViewportTooltipThreshold && leftPos >= this.minViewportTooltipThreshold;
		};
		MDCTooltipFoundation.prototype.positionDoesntCollideWithViewport = function(leftPos) {
			var viewportWidth = this.adapter.getViewportWidth();
			return leftPos + this.adapter.getTooltipSize().width <= viewportWidth && leftPos >= 0;
		};
		/**
		* Calculates the `top` distance for the tooltip.
		* Returns the distance value and a string indicating the y-axis transform-
		* origin that should be used when animating the tooltip.
		*/
		MDCTooltipFoundation.prototype.calculateYTooltipDistance = function(anchorRect, tooltipHeight) {
			var belowYPos = anchorRect.bottom + this.anchorGap;
			var aboveYPos = anchorRect.top - (this.anchorGap + tooltipHeight);
			var yPositionOptions = this.determineValidYPositionOptions(aboveYPos, belowYPos);
			if (this.yTooltipPos === YPosition.ABOVE && yPositionOptions.has(aboveYPos)) return {
				distance: aboveYPos,
				yTransformOrigin: strings$1.BOTTOM
			};
			else if (this.yTooltipPos === YPosition.BELOW && yPositionOptions.has(belowYPos)) return {
				distance: belowYPos,
				yTransformOrigin: strings$1.TOP
			};
			if (yPositionOptions.has(belowYPos)) return {
				distance: belowYPos,
				yTransformOrigin: strings$1.TOP
			};
			if (yPositionOptions.has(aboveYPos)) return {
				distance: aboveYPos,
				yTransformOrigin: strings$1.BOTTOM
			};
			return {
				distance: belowYPos,
				yTransformOrigin: strings$1.TOP
			};
		};
		/**
		* Given the values for above/below alignment of the tooltip, calculates
		* which of these options would result in the tooltip maintaining the required
		* threshold distance vs which would result in the tooltip staying within the
		* viewport.
		*
		* A Set of values is returned holding the distances that would honor the
		* above requirements. Following the logic for determining the tooltip
		* position, if all possible alignments violate the threshold, then the
		* returned Set contains values that keep the tooltip within the viewport.
		*/
		MDCTooltipFoundation.prototype.determineValidYPositionOptions = function(aboveAnchorPos, belowAnchorPos) {
			var posWithinThreshold = /* @__PURE__ */ new Set();
			var posWithinViewport = /* @__PURE__ */ new Set();
			if (this.yPositionHonorsViewportThreshold(aboveAnchorPos)) posWithinThreshold.add(aboveAnchorPos);
			else if (this.yPositionDoesntCollideWithViewport(aboveAnchorPos)) posWithinViewport.add(aboveAnchorPos);
			if (this.yPositionHonorsViewportThreshold(belowAnchorPos)) posWithinThreshold.add(belowAnchorPos);
			else if (this.yPositionDoesntCollideWithViewport(belowAnchorPos)) posWithinViewport.add(belowAnchorPos);
			return posWithinThreshold.size ? posWithinThreshold : posWithinViewport;
		};
		MDCTooltipFoundation.prototype.yPositionHonorsViewportThreshold = function(yPos) {
			var viewportHeight = this.adapter.getViewportHeight();
			return yPos + this.adapter.getTooltipSize().height + this.minViewportTooltipThreshold <= viewportHeight && yPos >= this.minViewportTooltipThreshold;
		};
		MDCTooltipFoundation.prototype.yPositionDoesntCollideWithViewport = function(yPos) {
			var viewportHeight = this.adapter.getViewportHeight();
			return yPos + this.adapter.getTooltipSize().height <= viewportHeight && yPos >= 0;
		};
		MDCTooltipFoundation.prototype.calculateTooltipWithCaretStyles = function(anchorRect) {
			this.adapter.clearTooltipCaretStyles();
			var caretSize = this.adapter.getTooltipCaretBoundingRect();
			if (!anchorRect || !caretSize) return {
				position: PositionWithCaret.DETECTED,
				top: 0,
				left: 0
			};
			var caretWidth = caretSize.width / numbers$1.ANIMATION_SCALE;
			var caretHeight = caretSize.height / numbers$1.ANIMATION_SCALE / 2;
			var tooltipSize = this.adapter.getTooltipSize();
			var yOptions = this.calculateYWithCaretDistanceOptions(anchorRect, tooltipSize.height, {
				caretWidth,
				caretHeight
			});
			var xOptions = this.calculateXWithCaretDistanceOptions(anchorRect, tooltipSize.width, {
				caretWidth,
				caretHeight
			});
			var positionOptions = this.validateTooltipWithCaretDistances(yOptions, xOptions);
			if (positionOptions.size < 1) positionOptions = this.generateBackupPositionOption(anchorRect, tooltipSize, {
				caretWidth,
				caretHeight
			});
			var _a = this.determineTooltipWithCaretDistance(positionOptions), position = _a.position, xDistance = _a.xDistance, yDistance = _a.yDistance;
			var _b = this.setCaretPositionStyles(position, {
				caretWidth,
				caretHeight
			});
			return {
				yTransformOrigin: _b.yTransformOrigin,
				xTransformOrigin: _b.xTransformOrigin,
				top: yDistance,
				left: xDistance
			};
		};
		MDCTooltipFoundation.prototype.calculateXWithCaretDistanceOptions = function(anchorRect, tooltipWidth, caretSize) {
			var caretWidth = caretSize.caretWidth, caretHeight = caretSize.caretHeight;
			var isLTR = !this.adapter.isRTL();
			var anchorMidpoint = anchorRect.left + anchorRect.width / 2;
			var sideLeftAligned = anchorRect.left - (tooltipWidth + this.anchorGap + caretHeight);
			var sideRightAligned = anchorRect.right + this.anchorGap + caretHeight;
			var sideStartPos = isLTR ? sideLeftAligned : sideRightAligned;
			var sideEndPos = isLTR ? sideRightAligned : sideLeftAligned;
			var verticalLeftAligned = anchorMidpoint - (numbers$1.CARET_INDENTATION + caretWidth / 2);
			var verticalRightAligned = anchorMidpoint - (tooltipWidth - numbers$1.CARET_INDENTATION - caretWidth / 2);
			var verticalStartPos = isLTR ? verticalLeftAligned : verticalRightAligned;
			var verticalEndPos = isLTR ? verticalRightAligned : verticalLeftAligned;
			var verticalCenterPos = anchorMidpoint - tooltipWidth / 2;
			return /* @__PURE__ */ new Map([
				[XPositionWithCaret.START, verticalStartPos],
				[XPositionWithCaret.CENTER, verticalCenterPos],
				[XPositionWithCaret.END, verticalEndPos],
				[XPositionWithCaret.SIDE_END, sideEndPos],
				[XPositionWithCaret.SIDE_START, sideStartPos]
			]);
		};
		MDCTooltipFoundation.prototype.calculateYWithCaretDistanceOptions = function(anchorRect, tooltipHeight, caretSize) {
			var caretWidth = caretSize.caretWidth, caretHeight = caretSize.caretHeight;
			var anchorMidpoint = anchorRect.top + anchorRect.height / 2;
			var belowYPos = anchorRect.bottom + this.anchorGap + caretHeight;
			var aboveYPos = anchorRect.top - (this.anchorGap + tooltipHeight + caretHeight);
			var sideTopYPos = anchorMidpoint - (numbers$1.CARET_INDENTATION + caretWidth / 2);
			var sideCenterYPos = anchorMidpoint - tooltipHeight / 2;
			var sideBottomYPos = anchorMidpoint - (tooltipHeight - numbers$1.CARET_INDENTATION - caretWidth / 2);
			return /* @__PURE__ */ new Map([
				[YPositionWithCaret.ABOVE, aboveYPos],
				[YPositionWithCaret.BELOW, belowYPos],
				[YPositionWithCaret.SIDE_TOP, sideTopYPos],
				[YPositionWithCaret.SIDE_CENTER, sideCenterYPos],
				[YPositionWithCaret.SIDE_BOTTOM, sideBottomYPos]
			]);
		};
		MDCTooltipFoundation.prototype.repositionTooltipOnAnchorMove = function() {
			var newAnchorRect = this.adapter.getAnchorBoundingRect();
			if (!newAnchorRect || !this.anchorRect) return;
			if (newAnchorRect.top !== this.anchorRect.top || newAnchorRect.left !== this.anchorRect.left || newAnchorRect.height !== this.anchorRect.height || newAnchorRect.width !== this.anchorRect.width) {
				this.anchorRect = newAnchorRect;
				this.parentRect = this.adapter.getParentBoundingRect();
				this.richTooltip ? this.positionRichTooltip() : this.positionPlainTooltip();
			}
		};
		/**
		* Given a list of x/y position options for a rich tooltip with caret, checks
		* if valid x/y combinations of these position options are either within the
		* viewport threshold, or simply within the viewport. Returns a map with the
		* valid x/y position combinations that all either honor the viewport
		* threshold or are simply inside within the viewport.
		*/
		MDCTooltipFoundation.prototype.validateTooltipWithCaretDistances = function(yOptions, xOptions) {
			var e_4, _a, e_5, _b, e_6, _c;
			var posWithinThreshold = /* @__PURE__ */ new Map();
			var posWithinViewport = /* @__PURE__ */ new Map();
			var validMappings = /* @__PURE__ */ new Map([
				[YPositionWithCaret.ABOVE, [
					XPositionWithCaret.START,
					XPositionWithCaret.CENTER,
					XPositionWithCaret.END
				]],
				[YPositionWithCaret.BELOW, [
					XPositionWithCaret.START,
					XPositionWithCaret.CENTER,
					XPositionWithCaret.END
				]],
				[YPositionWithCaret.SIDE_TOP, [XPositionWithCaret.SIDE_START, XPositionWithCaret.SIDE_END]],
				[YPositionWithCaret.SIDE_CENTER, [XPositionWithCaret.SIDE_START, XPositionWithCaret.SIDE_END]],
				[YPositionWithCaret.SIDE_BOTTOM, [XPositionWithCaret.SIDE_START, XPositionWithCaret.SIDE_END]]
			]);
			try {
				for (var _d = __values(validMappings.keys()), _e = _d.next(); !_e.done; _e = _d.next()) {
					var y = _e.value;
					var yDistance = yOptions.get(y);
					if (this.yPositionHonorsViewportThreshold(yDistance)) try {
						for (var _f = (e_5 = void 0, __values(validMappings.get(y))), _g = _f.next(); !_g.done; _g = _f.next()) {
							var x = _g.value;
							var xDistance = xOptions.get(x);
							if (this.positionHonorsViewportThreshold(xDistance)) {
								var caretPositionName = this.caretPositionOptionsMapping(x, y);
								posWithinThreshold.set(caretPositionName, {
									xDistance,
									yDistance
								});
							}
						}
					} catch (e_5_1) {
						e_5 = { error: e_5_1 };
					} finally {
						try {
							if (_g && !_g.done && (_b = _f.return)) _b.call(_f);
						} finally {
							if (e_5) throw e_5.error;
						}
					}
					if (this.yPositionDoesntCollideWithViewport(yDistance)) try {
						for (var _h = (e_6 = void 0, __values(validMappings.get(y))), _j = _h.next(); !_j.done; _j = _h.next()) {
							var x = _j.value;
							var xDistance = xOptions.get(x);
							if (this.positionDoesntCollideWithViewport(xDistance)) {
								var caretPositionName = this.caretPositionOptionsMapping(x, y);
								posWithinViewport.set(caretPositionName, {
									xDistance,
									yDistance
								});
							}
						}
					} catch (e_6_1) {
						e_6 = { error: e_6_1 };
					} finally {
						try {
							if (_j && !_j.done && (_c = _h.return)) _c.call(_h);
						} finally {
							if (e_6) throw e_6.error;
						}
					}
				}
			} catch (e_4_1) {
				e_4 = { error: e_4_1 };
			} finally {
				try {
					if (_e && !_e.done && (_a = _d.return)) _a.call(_d);
				} finally {
					if (e_4) throw e_4.error;
				}
			}
			return posWithinThreshold.size ? posWithinThreshold : posWithinViewport;
		};
		/**
		* Method for generating a horizontal and vertical position for the tooltip if
		* all other calculated values are considered invalid. This would only happen
		* in situations of very small viewports/large tooltips.
		*/
		MDCTooltipFoundation.prototype.generateBackupPositionOption = function(anchorRect, tooltipSize, caretSize) {
			var isLTR = !this.adapter.isRTL();
			var xDistance;
			var xPos;
			if (anchorRect.left < 0) {
				xDistance = this.minViewportTooltipThreshold + caretSize.caretHeight;
				xPos = isLTR ? XPositionWithCaret.END : XPositionWithCaret.START;
			} else {
				xDistance = this.adapter.getViewportWidth() - (tooltipSize.width + this.minViewportTooltipThreshold + caretSize.caretHeight);
				xPos = isLTR ? XPositionWithCaret.START : XPositionWithCaret.END;
			}
			var yDistance;
			var yPos;
			if (anchorRect.top < 0) {
				yDistance = this.minViewportTooltipThreshold + caretSize.caretHeight;
				yPos = YPositionWithCaret.BELOW;
			} else {
				yDistance = this.adapter.getViewportHeight() - (tooltipSize.height + this.minViewportTooltipThreshold + caretSize.caretHeight);
				yPos = YPositionWithCaret.ABOVE;
			}
			var caretPositionName = this.caretPositionOptionsMapping(xPos, yPos);
			return /* @__PURE__ */ new Map([[caretPositionName, {
				xDistance,
				yDistance
			}]]);
		};
		/**
		* Given a list of valid position options for a rich tooltip with caret,
		* returns the option that should be used.
		*/
		MDCTooltipFoundation.prototype.determineTooltipWithCaretDistance = function(options) {
			if (options.has(this.tooltipPositionWithCaret)) {
				var tooltipPos = options.get(this.tooltipPositionWithCaret);
				return {
					position: this.tooltipPositionWithCaret,
					xDistance: tooltipPos.xDistance,
					yDistance: tooltipPos.yDistance
				};
			}
			var validPosition = [
				PositionWithCaret.ABOVE_START,
				PositionWithCaret.ABOVE_CENTER,
				PositionWithCaret.ABOVE_END,
				PositionWithCaret.TOP_SIDE_START,
				PositionWithCaret.CENTER_SIDE_START,
				PositionWithCaret.BOTTOM_SIDE_START,
				PositionWithCaret.TOP_SIDE_END,
				PositionWithCaret.CENTER_SIDE_END,
				PositionWithCaret.BOTTOM_SIDE_END,
				PositionWithCaret.BELOW_START,
				PositionWithCaret.BELOW_CENTER,
				PositionWithCaret.BELOW_END
			].find(function(pos) {
				return options.has(pos);
			});
			var pos = options.get(validPosition);
			return {
				position: validPosition,
				xDistance: pos.xDistance,
				yDistance: pos.yDistance
			};
		};
		/**
		* Returns the corresponding PositionWithCaret enum for the proivded
		* XPositionWithCaret and YPositionWithCaret enums. This mapping exists so our
		* public API accepts only PositionWithCaret enums (as all combinations of
		* XPositionWithCaret and YPositionWithCaret are not valid), but internally we
		* can calculate the X and Y positions of a rich tooltip with caret
		* separately.
		*/
		MDCTooltipFoundation.prototype.caretPositionOptionsMapping = function(xPos, yPos) {
			switch (yPos) {
				case YPositionWithCaret.ABOVE:
					if (xPos === XPositionWithCaret.START) return PositionWithCaret.ABOVE_START;
					else if (xPos === XPositionWithCaret.CENTER) return PositionWithCaret.ABOVE_CENTER;
					else if (xPos === XPositionWithCaret.END) return PositionWithCaret.ABOVE_END;
					break;
				case YPositionWithCaret.BELOW:
					if (xPos === XPositionWithCaret.START) return PositionWithCaret.BELOW_START;
					else if (xPos === XPositionWithCaret.CENTER) return PositionWithCaret.BELOW_CENTER;
					else if (xPos === XPositionWithCaret.END) return PositionWithCaret.BELOW_END;
					break;
				case YPositionWithCaret.SIDE_TOP:
					if (xPos === XPositionWithCaret.SIDE_START) return PositionWithCaret.TOP_SIDE_START;
					else if (xPos === XPositionWithCaret.SIDE_END) return PositionWithCaret.TOP_SIDE_END;
					break;
				case YPositionWithCaret.SIDE_CENTER:
					if (xPos === XPositionWithCaret.SIDE_START) return PositionWithCaret.CENTER_SIDE_START;
					else if (xPos === XPositionWithCaret.SIDE_END) return PositionWithCaret.CENTER_SIDE_END;
					break;
				case YPositionWithCaret.SIDE_BOTTOM:
					if (xPos === XPositionWithCaret.SIDE_START) return PositionWithCaret.BOTTOM_SIDE_START;
					else if (xPos === XPositionWithCaret.SIDE_END) return PositionWithCaret.BOTTOM_SIDE_END;
					break;
				default: break;
			}
			throw new Error("MDCTooltipFoundation: Invalid caret position of " + xPos + ", " + yPos);
		};
		/**
		* Given a PositionWithCaret, applies the correct styles to the caret element
		* so that it is positioned properly on the rich tooltip.
		* Returns the x and y positions of the caret, to be used as the
		* transform-origin on the tooltip itself for entrance animations.
		*/
		MDCTooltipFoundation.prototype.setCaretPositionStyles = function(position, caretSize) {
			var e_7, _a;
			var values = this.calculateCaretPositionOnTooltip(position, caretSize);
			if (!values) return {
				yTransformOrigin: 0,
				xTransformOrigin: 0
			};
			this.adapter.clearTooltipCaretStyles();
			this.adapter.setTooltipCaretStyle(values.yAlignment, values.yAxisPx);
			this.adapter.setTooltipCaretStyle(values.xAlignment, values.xAxisPx);
			var skewRadians = values.skew * (Math.PI / 180);
			var scaleX = Math.cos(skewRadians);
			this.adapter.setTooltipCaretStyle("transform", "rotate(" + values.rotation + "deg) skewY(" + values.skew + "deg) scaleX(" + scaleX + ")");
			this.adapter.setTooltipCaretStyle("transform-origin", values.xAlignment + " " + values.yAlignment);
			try {
				for (var _b = __values(values.caretCorners), _c = _b.next(); !_c.done; _c = _b.next()) {
					var corner = _c.value;
					this.adapter.setTooltipCaretStyle(corner, "0");
				}
			} catch (e_7_1) {
				e_7 = { error: e_7_1 };
			} finally {
				try {
					if (_c && !_c.done && (_a = _b.return)) _a.call(_b);
				} finally {
					if (e_7) throw e_7.error;
				}
			}
			return {
				yTransformOrigin: values.yTransformOrigin,
				xTransformOrigin: values.xTransformOrigin
			};
		};
		/**
		* Given a PositionWithCaret, determines the correct styles to position the
		* caret properly on the rich tooltip.
		*/
		MDCTooltipFoundation.prototype.calculateCaretPositionOnTooltip = function(tooltipPos, caretSize) {
			var isLTR = !this.adapter.isRTL();
			var tooltipWidth = this.adapter.getComputedStyleProperty("width");
			var tooltipHeight = this.adapter.getComputedStyleProperty("height");
			if (!tooltipWidth || !tooltipHeight || !caretSize) return;
			var midpointWidth = "calc((" + tooltipWidth + " - " + caretSize.caretWidth + "px) / 2)";
			var midpointHeight = "calc((" + tooltipHeight + " - " + caretSize.caretWidth + "px) / 2)";
			var flushWithEdge = "0";
			var indentedFromEdge = numbers$1.CARET_INDENTATION + "px";
			var indentedFromWidth = "calc(" + tooltipWidth + " - " + indentedFromEdge + ")";
			var indentedFromHeight = "calc(" + tooltipHeight + " - " + indentedFromEdge + ")";
			var verticalRotation = 35;
			var horizontalRotation = Math.abs(90 - verticalRotation);
			var bottomRightTopLeftBorderRadius = ["border-bottom-right-radius", "border-top-left-radius"];
			var bottomLeftTopRightBorderRadius = ["border-bottom-left-radius", "border-top-right-radius"];
			var skewDeg = 20;
			switch (tooltipPos) {
				case PositionWithCaret.BELOW_CENTER: return {
					yAlignment: strings$1.TOP,
					xAlignment: strings$1.LEFT,
					yAxisPx: flushWithEdge,
					xAxisPx: midpointWidth,
					rotation: -1 * verticalRotation,
					skew: -1 * skewDeg,
					xTransformOrigin: midpointWidth,
					yTransformOrigin: flushWithEdge,
					caretCorners: bottomRightTopLeftBorderRadius
				};
				case PositionWithCaret.BELOW_END: return {
					yAlignment: strings$1.TOP,
					xAlignment: isLTR ? strings$1.RIGHT : strings$1.LEFT,
					yAxisPx: flushWithEdge,
					xAxisPx: indentedFromEdge,
					rotation: isLTR ? verticalRotation : -1 * verticalRotation,
					skew: isLTR ? skewDeg : -1 * skewDeg,
					xTransformOrigin: isLTR ? indentedFromWidth : indentedFromEdge,
					yTransformOrigin: flushWithEdge,
					caretCorners: isLTR ? bottomLeftTopRightBorderRadius : bottomRightTopLeftBorderRadius
				};
				case PositionWithCaret.BELOW_START: return {
					yAlignment: strings$1.TOP,
					xAlignment: isLTR ? strings$1.LEFT : strings$1.RIGHT,
					yAxisPx: flushWithEdge,
					xAxisPx: indentedFromEdge,
					rotation: isLTR ? -1 * verticalRotation : verticalRotation,
					skew: isLTR ? -1 * skewDeg : skewDeg,
					xTransformOrigin: isLTR ? indentedFromEdge : indentedFromWidth,
					yTransformOrigin: flushWithEdge,
					caretCorners: isLTR ? bottomRightTopLeftBorderRadius : bottomLeftTopRightBorderRadius
				};
				case PositionWithCaret.TOP_SIDE_END: return {
					yAlignment: strings$1.TOP,
					xAlignment: isLTR ? strings$1.LEFT : strings$1.RIGHT,
					yAxisPx: indentedFromEdge,
					xAxisPx: flushWithEdge,
					rotation: isLTR ? horizontalRotation : -1 * horizontalRotation,
					skew: isLTR ? -1 * skewDeg : skewDeg,
					xTransformOrigin: isLTR ? flushWithEdge : tooltipWidth,
					yTransformOrigin: indentedFromEdge,
					caretCorners: isLTR ? bottomRightTopLeftBorderRadius : bottomLeftTopRightBorderRadius
				};
				case PositionWithCaret.CENTER_SIDE_END: return {
					yAlignment: strings$1.TOP,
					xAlignment: isLTR ? strings$1.LEFT : strings$1.RIGHT,
					yAxisPx: midpointHeight,
					xAxisPx: flushWithEdge,
					rotation: isLTR ? horizontalRotation : -1 * horizontalRotation,
					skew: isLTR ? -1 * skewDeg : skewDeg,
					xTransformOrigin: isLTR ? flushWithEdge : tooltipWidth,
					yTransformOrigin: midpointHeight,
					caretCorners: isLTR ? bottomRightTopLeftBorderRadius : bottomLeftTopRightBorderRadius
				};
				case PositionWithCaret.BOTTOM_SIDE_END: return {
					yAlignment: strings$1.BOTTOM,
					xAlignment: isLTR ? strings$1.LEFT : strings$1.RIGHT,
					yAxisPx: indentedFromEdge,
					xAxisPx: flushWithEdge,
					rotation: isLTR ? -1 * horizontalRotation : horizontalRotation,
					skew: isLTR ? skewDeg : -1 * skewDeg,
					xTransformOrigin: isLTR ? flushWithEdge : tooltipWidth,
					yTransformOrigin: indentedFromHeight,
					caretCorners: isLTR ? bottomLeftTopRightBorderRadius : bottomRightTopLeftBorderRadius
				};
				case PositionWithCaret.TOP_SIDE_START: return {
					yAlignment: strings$1.TOP,
					xAlignment: isLTR ? strings$1.RIGHT : strings$1.LEFT,
					yAxisPx: indentedFromEdge,
					xAxisPx: flushWithEdge,
					rotation: isLTR ? -1 * horizontalRotation : horizontalRotation,
					skew: isLTR ? skewDeg : -1 * skewDeg,
					xTransformOrigin: isLTR ? tooltipWidth : flushWithEdge,
					yTransformOrigin: indentedFromEdge,
					caretCorners: isLTR ? bottomLeftTopRightBorderRadius : bottomRightTopLeftBorderRadius
				};
				case PositionWithCaret.CENTER_SIDE_START: return {
					yAlignment: strings$1.TOP,
					xAlignment: isLTR ? strings$1.RIGHT : strings$1.LEFT,
					yAxisPx: midpointHeight,
					xAxisPx: flushWithEdge,
					rotation: isLTR ? -1 * horizontalRotation : horizontalRotation,
					skew: isLTR ? skewDeg : -1 * skewDeg,
					xTransformOrigin: isLTR ? tooltipWidth : flushWithEdge,
					yTransformOrigin: midpointHeight,
					caretCorners: isLTR ? bottomLeftTopRightBorderRadius : bottomRightTopLeftBorderRadius
				};
				case PositionWithCaret.BOTTOM_SIDE_START: return {
					yAlignment: strings$1.BOTTOM,
					xAlignment: isLTR ? strings$1.RIGHT : strings$1.LEFT,
					yAxisPx: indentedFromEdge,
					xAxisPx: flushWithEdge,
					rotation: isLTR ? horizontalRotation : -1 * horizontalRotation,
					skew: isLTR ? -1 * skewDeg : skewDeg,
					xTransformOrigin: isLTR ? tooltipWidth : flushWithEdge,
					yTransformOrigin: indentedFromHeight,
					caretCorners: isLTR ? bottomRightTopLeftBorderRadius : bottomLeftTopRightBorderRadius
				};
				case PositionWithCaret.ABOVE_CENTER: return {
					yAlignment: strings$1.BOTTOM,
					xAlignment: strings$1.LEFT,
					yAxisPx: flushWithEdge,
					xAxisPx: midpointWidth,
					rotation: verticalRotation,
					skew: skewDeg,
					xTransformOrigin: midpointWidth,
					yTransformOrigin: tooltipHeight,
					caretCorners: bottomLeftTopRightBorderRadius
				};
				case PositionWithCaret.ABOVE_END: return {
					yAlignment: strings$1.BOTTOM,
					xAlignment: isLTR ? strings$1.RIGHT : strings$1.LEFT,
					yAxisPx: flushWithEdge,
					xAxisPx: indentedFromEdge,
					rotation: isLTR ? -1 * verticalRotation : verticalRotation,
					skew: isLTR ? -1 * skewDeg : skewDeg,
					xTransformOrigin: isLTR ? indentedFromWidth : indentedFromEdge,
					yTransformOrigin: tooltipHeight,
					caretCorners: isLTR ? bottomRightTopLeftBorderRadius : bottomLeftTopRightBorderRadius
				};
				default:
				case PositionWithCaret.ABOVE_START: return {
					yAlignment: strings$1.BOTTOM,
					xAlignment: isLTR ? strings$1.LEFT : strings$1.RIGHT,
					yAxisPx: flushWithEdge,
					xAxisPx: indentedFromEdge,
					rotation: isLTR ? verticalRotation : -1 * verticalRotation,
					skew: isLTR ? skewDeg : -1 * skewDeg,
					xTransformOrigin: isLTR ? indentedFromEdge : indentedFromWidth,
					yTransformOrigin: tooltipHeight,
					caretCorners: isLTR ? bottomLeftTopRightBorderRadius : bottomRightTopLeftBorderRadius
				};
			}
		};
		MDCTooltipFoundation.prototype.clearShowTimeout = function() {
			if (this.showTimeout) {
				clearTimeout(this.showTimeout);
				this.showTimeout = null;
			}
		};
		MDCTooltipFoundation.prototype.clearHideTimeout = function() {
			if (this.hideTimeout) {
				clearTimeout(this.hideTimeout);
				this.hideTimeout = null;
			}
		};
		/**
		* Method that allows user to specify additional elements that should have a
		* scroll event listener attached to it. This should be used in instances
		* where the anchor element is placed inside a scrollable container, and will
		* ensure that the tooltip will stay attached to the anchor on scroll.
		*/
		MDCTooltipFoundation.prototype.attachScrollHandler = function(addEventListenerFn) {
			var _this = this;
			this.addAncestorScrollEventListeners.push(function() {
				addEventListenerFn("scroll", _this.windowScrollHandler);
			});
		};
		/**
		* Must be used in conjunction with #attachScrollHandler. Removes the scroll
		* event handler from elements on the page.
		*/
		MDCTooltipFoundation.prototype.removeScrollHandler = function(removeEventHandlerFn) {
			var _this = this;
			this.removeAncestorScrollEventListeners.push(function() {
				removeEventHandlerFn("scroll", _this.windowScrollHandler);
			});
		};
		MDCTooltipFoundation.prototype.destroy = function() {
			var e_8, _a;
			if (this.frameId) {
				cancelAnimationFrame(this.frameId);
				this.frameId = null;
			}
			this.clearHideTimeout();
			this.clearShowTimeout();
			this.adapter.removeClass(SHOWN);
			this.adapter.removeClass(SHOWING_TRANSITION);
			this.adapter.removeClass(SHOWING);
			this.adapter.removeClass(HIDE);
			this.adapter.removeClass(HIDE_TRANSITION);
			if (this.richTooltip) this.adapter.deregisterEventHandler("focusout", this.richTooltipFocusOutHandler);
			if (!this.persistentTooltip) {
				this.adapter.deregisterEventHandler("mouseenter", this.tooltipMouseEnterHandler);
				this.adapter.deregisterEventHandler("mouseleave", this.tooltipMouseLeaveHandler);
			}
			this.adapter.deregisterAnchorEventHandler("blur", this.anchorBlurHandler);
			this.adapter.deregisterDocumentEventHandler("click", this.documentClickHandler);
			this.adapter.deregisterDocumentEventHandler("keydown", this.documentKeydownHandler);
			this.adapter.deregisterWindowEventHandler("scroll", this.windowScrollHandler);
			this.adapter.deregisterWindowEventHandler("resize", this.windowResizeHandler);
			try {
				for (var _b = __values(this.removeAncestorScrollEventListeners), _c = _b.next(); !_c.done; _c = _b.next()) {
					var fn = _c.value;
					fn();
				}
			} catch (e_8_1) {
				e_8 = { error: e_8_1 };
			} finally {
				try {
					if (_c && !_c.done && (_a = _b.return)) _a.call(_b);
				} finally {
					if (e_8) throw e_8.error;
				}
			}
			this.animFrame.cancelAll();
		};
		return MDCTooltipFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+tooltip@14.0.0/node_modules/@material/tooltip/component.js
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
	var MDCTooltip = function(_super) {
		__extends(MDCTooltip, _super);
		function MDCTooltip() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCTooltip.attachTo = function(root) {
			return new MDCTooltip(root);
		};
		MDCTooltip.prototype.initialize = function() {
			var tooltipId = this.root.getAttribute("id");
			if (!tooltipId) throw new Error("MDCTooltip: Tooltip component must have an id.");
			var anchorElem = document.querySelector("[data-tooltip-id=\"" + tooltipId + "\"]") || document.querySelector("[aria-describedby=\"" + tooltipId + "\"]");
			if (!anchorElem) throw new Error("MDCTooltip: Tooltip component requires an anchor element annotated with [aria-describedby] or [data-tooltip-id].");
			this.anchorElem = anchorElem;
		};
		MDCTooltip.prototype.initialSyncWithDOM = function() {
			var _this = this;
			this.isTooltipRich = this.foundation.isRich();
			this.isTooltipPersistent = this.foundation.isPersistent();
			this.handleMouseEnter = function() {
				_this.foundation.handleAnchorMouseEnter();
			};
			this.handleFocus = function(evt) {
				_this.foundation.handleAnchorFocus(evt);
			};
			this.handleMouseLeave = function() {
				_this.foundation.handleAnchorMouseLeave();
			};
			this.handleTransitionEnd = function() {
				_this.foundation.handleTransitionEnd();
			};
			this.handleClick = function() {
				_this.foundation.handleAnchorClick();
			};
			this.handleTouchstart = function() {
				_this.foundation.handleAnchorTouchstart();
			};
			this.handleTouchend = function() {
				_this.foundation.handleAnchorTouchend();
			};
			if (this.isTooltipRich && this.isTooltipPersistent) this.anchorElem.addEventListener("click", this.handleClick);
			else {
				this.anchorElem.addEventListener("mouseenter", this.handleMouseEnter);
				this.anchorElem.addEventListener("focus", this.handleFocus);
				this.anchorElem.addEventListener("mouseleave", this.handleMouseLeave);
				this.anchorElem.addEventListener("touchstart", this.handleTouchstart);
				this.anchorElem.addEventListener("touchend", this.handleTouchend);
			}
			this.listen("transitionend", this.handleTransitionEnd);
		};
		MDCTooltip.prototype.destroy = function() {
			if (this.anchorElem) if (this.isTooltipRich && this.isTooltipPersistent) this.anchorElem.removeEventListener("click", this.handleClick);
			else {
				this.anchorElem.removeEventListener("mouseenter", this.handleMouseEnter);
				this.anchorElem.removeEventListener("focus", this.handleFocus);
				this.anchorElem.removeEventListener("mouseleave", this.handleMouseLeave);
				this.anchorElem.removeEventListener("touchstart", this.handleTouchstart);
				this.anchorElem.removeEventListener("touchend", this.handleTouchend);
			}
			this.unlisten("transitionend", this.handleTransitionEnd);
			_super.prototype.destroy.call(this);
		};
		MDCTooltip.prototype.setTooltipPosition = function(position) {
			this.foundation.setTooltipPosition(position);
		};
		MDCTooltip.prototype.setAnchorBoundaryType = function(type) {
			this.foundation.setAnchorBoundaryType(type);
		};
		MDCTooltip.prototype.setShowDelay = function(delayMs) {
			this.foundation.setShowDelay(delayMs);
		};
		MDCTooltip.prototype.setHideDelay = function(delayMs) {
			this.foundation.setHideDelay(delayMs);
		};
		MDCTooltip.prototype.hide = function() {
			this.foundation.hide();
		};
		MDCTooltip.prototype.isShown = function() {
			return this.foundation.isShown();
		};
		/**
		* Method that allows user to specify additional elements that should have a
		* scroll event listener attached to it. This should be used in instances
		* where the anchor element is placed inside a scrollable container (that is
		* not the body element), and will ensure that the tooltip will stay attached
		* to the anchor on scroll.
		*/
		MDCTooltip.prototype.attachScrollHandler = function(addEventListenerFn) {
			this.foundation.attachScrollHandler(addEventListenerFn);
		};
		/**
		* Must be used in conjunction with #attachScrollHandler. Removes the scroll
		* event handler from elements on the page.
		*/
		MDCTooltip.prototype.removeScrollHandler = function(removeEventHandlerFn) {
			this.foundation.removeScrollHandler(removeEventHandlerFn);
		};
		MDCTooltip.prototype.getDefaultFoundation = function() {
			var _this = this;
			return new MDCTooltipFoundation({
				getAttribute: function(attr) {
					return _this.root.getAttribute(attr);
				},
				setAttribute: function(attr, value) {
					_this.root.setAttribute(attr, value);
				},
				removeAttribute: function(attr) {
					_this.root.removeAttribute(attr);
				},
				addClass: function(className) {
					_this.root.classList.add(className);
				},
				hasClass: function(className) {
					return _this.root.classList.contains(className);
				},
				removeClass: function(className) {
					_this.root.classList.remove(className);
				},
				getComputedStyleProperty: function(propertyName) {
					return window.getComputedStyle(_this.root).getPropertyValue(propertyName);
				},
				setStyleProperty: function(propertyName, value) {
					_this.root.style.setProperty(propertyName, value);
				},
				setSurfaceAnimationStyleProperty: function(propertyName, value) {
					var surface = _this.root.querySelector("." + CssClasses.SURFACE_ANIMATION);
					surface === null || surface === void 0 || surface.style.setProperty(propertyName, value);
				},
				getViewportWidth: function() {
					return window.innerWidth;
				},
				getViewportHeight: function() {
					return window.innerHeight;
				},
				getTooltipSize: function() {
					return {
						width: _this.root.offsetWidth,
						height: _this.root.offsetHeight
					};
				},
				getAnchorBoundingRect: function() {
					return _this.anchorElem ? _this.anchorElem.getBoundingClientRect() : null;
				},
				getParentBoundingRect: function() {
					var _a, _b;
					return (_b = (_a = _this.root.parentElement) === null || _a === void 0 ? void 0 : _a.getBoundingClientRect()) !== null && _b !== void 0 ? _b : null;
				},
				getAnchorAttribute: function(attr) {
					return _this.anchorElem ? _this.anchorElem.getAttribute(attr) : null;
				},
				setAnchorAttribute: function(attr, value) {
					var _a;
					(_a = _this.anchorElem) === null || _a === void 0 || _a.setAttribute(attr, value);
				},
				isRTL: function() {
					return getComputedStyle(_this.root).direction === "rtl";
				},
				anchorContainsElement: function(element) {
					var _a;
					return !!((_a = _this.anchorElem) === null || _a === void 0 ? void 0 : _a.contains(element));
				},
				tooltipContainsElement: function(element) {
					return _this.root.contains(element);
				},
				focusAnchorElement: function() {
					var _a;
					(_a = _this.anchorElem) === null || _a === void 0 || _a.focus();
				},
				registerEventHandler: function(evt, handler) {
					if (_this.root instanceof HTMLElement) _this.root.addEventListener(evt, handler);
				},
				deregisterEventHandler: function(evt, handler) {
					if (_this.root instanceof HTMLElement) _this.root.removeEventListener(evt, handler);
				},
				registerAnchorEventHandler: function(evt, handler) {
					var _a;
					(_a = _this.anchorElem) === null || _a === void 0 || _a.addEventListener(evt, handler);
				},
				deregisterAnchorEventHandler: function(evt, handler) {
					var _a;
					(_a = _this.anchorElem) === null || _a === void 0 || _a.removeEventListener(evt, handler);
				},
				registerDocumentEventHandler: function(evt, handler) {
					document.body.addEventListener(evt, handler);
				},
				deregisterDocumentEventHandler: function(evt, handler) {
					document.body.removeEventListener(evt, handler);
				},
				registerWindowEventHandler: function(evt, handler) {
					window.addEventListener(evt, handler);
				},
				deregisterWindowEventHandler: function(evt, handler) {
					window.removeEventListener(evt, handler);
				},
				notifyHidden: function() {
					_this.emit(events.HIDDEN, {});
				},
				getTooltipCaretBoundingRect: function() {
					var caret = _this.root.querySelector("." + CssClasses.TOOLTIP_CARET_TOP);
					if (!caret) return null;
					return caret.getBoundingClientRect();
				},
				setTooltipCaretStyle: function(propertyName, value) {
					var topCaret = _this.root.querySelector("." + CssClasses.TOOLTIP_CARET_TOP);
					var bottomCaret = _this.root.querySelector("." + CssClasses.TOOLTIP_CARET_BOTTOM);
					if (!topCaret || !bottomCaret) return;
					topCaret.style.setProperty(propertyName, value);
					bottomCaret.style.setProperty(propertyName, value);
				},
				clearTooltipCaretStyles: function() {
					var topCaret = _this.root.querySelector("." + CssClasses.TOOLTIP_CARET_TOP);
					var bottomCaret = _this.root.querySelector("." + CssClasses.TOOLTIP_CARET_BOTTOM);
					if (!topCaret || !bottomCaret) return;
					topCaret.removeAttribute("style");
					bottomCaret.removeAttribute("style");
				},
				getActiveElement: function() {
					return document.activeElement;
				}
			});
		};
		return MDCTooltip;
	}(MDCComponent);

//#endregion
//#region Components/Tooltip/MBTooltip.ts
	var MBTooltip_exports = /* @__PURE__ */ __exportAll({
		init: () => init$1,
		numbers: () => numbers$1
	});
	function init$1(arrayOfReferences) {
		for (const elem of arrayOfReferences) try {
			if (elem) MDCTooltip.attachTo(elem);
		} catch (e) {}
	}

//#endregion
//#region node_modules/.pnpm/@material+top-app-bar@14.0.0/node_modules/@material/top-app-bar/constants.js
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
	var cssClasses = {
		FIXED_CLASS: "mdc-top-app-bar--fixed",
		FIXED_SCROLLED_CLASS: "mdc-top-app-bar--fixed-scrolled",
		SHORT_CLASS: "mdc-top-app-bar--short",
		SHORT_COLLAPSED_CLASS: "mdc-top-app-bar--short-collapsed",
		SHORT_HAS_ACTION_ITEM_CLASS: "mdc-top-app-bar--short-has-action-item"
	};
	var numbers = {
		DEBOUNCE_THROTTLE_RESIZE_TIME_MS: 100,
		MAX_TOP_APP_BAR_HEIGHT: 128
	};
	var strings = {
		ACTION_ITEM_SELECTOR: ".mdc-top-app-bar__action-item",
		NAVIGATION_EVENT: "MDCTopAppBar:nav",
		NAVIGATION_ICON_SELECTOR: ".mdc-top-app-bar__navigation-icon",
		ROOT_SELECTOR: ".mdc-top-app-bar",
		TITLE_SELECTOR: ".mdc-top-app-bar__title"
	};

//#endregion
//#region node_modules/.pnpm/@material+top-app-bar@14.0.0/node_modules/@material/top-app-bar/foundation.js
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
	var MDCTopAppBarBaseFoundation = function(_super) {
		__extends(MDCTopAppBarBaseFoundation, _super);
		/* istanbul ignore next: optional argument is not a branch statement */
		function MDCTopAppBarBaseFoundation(adapter) {
			return _super.call(this, __assign(__assign({}, MDCTopAppBarBaseFoundation.defaultAdapter), adapter)) || this;
		}
		Object.defineProperty(MDCTopAppBarBaseFoundation, "strings", {
			get: function() {
				return strings;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTopAppBarBaseFoundation, "cssClasses", {
			get: function() {
				return cssClasses;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTopAppBarBaseFoundation, "numbers", {
			get: function() {
				return numbers;
			},
			enumerable: false,
			configurable: true
		});
		Object.defineProperty(MDCTopAppBarBaseFoundation, "defaultAdapter", {
			/**
			* See {@link MDCTopAppBarAdapter} for typing information on parameters and return types.
			*/
			get: function() {
				return {
					addClass: function() {},
					removeClass: function() {},
					hasClass: function() {
						return false;
					},
					setStyle: function() {},
					getTopAppBarHeight: function() {
						return 0;
					},
					notifyNavigationIconClicked: function() {},
					getViewportScrollY: function() {
						return 0;
					},
					getTotalActionItems: function() {
						return 0;
					}
				};
			},
			enumerable: false,
			configurable: true
		});
		/** Other variants of TopAppBar foundation overrides this method */
		MDCTopAppBarBaseFoundation.prototype.handleTargetScroll = function() {};
		/** Other variants of TopAppBar foundation overrides this method */
		MDCTopAppBarBaseFoundation.prototype.handleWindowResize = function() {};
		MDCTopAppBarBaseFoundation.prototype.handleNavigationClick = function() {
			this.adapter.notifyNavigationIconClicked();
		};
		return MDCTopAppBarBaseFoundation;
	}(MDCFoundation);

//#endregion
//#region node_modules/.pnpm/@material+top-app-bar@14.0.0/node_modules/@material/top-app-bar/standard/foundation.js
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
	var INITIAL_VALUE = 0;
	var MDCTopAppBarFoundation = function(_super) {
		__extends(MDCTopAppBarFoundation, _super);
		/* istanbul ignore next: optional argument is not a branch statement */
		function MDCTopAppBarFoundation(adapter) {
			var _this = _super.call(this, adapter) || this;
			/**
			* Indicates if the top app bar was docked in the previous scroll handler iteration.
			*/
			_this.wasDocked = true;
			/**
			* Indicates if the top app bar is docked in the fully shown position.
			*/
			_this.isDockedShowing = true;
			/**
			* Variable for current scroll position of the top app bar
			*/
			_this.currentAppBarOffsetTop = 0;
			/**
			* Used to prevent the top app bar from being scrolled out of view during resize events
			*/
			_this.isCurrentlyBeingResized = false;
			/**
			* The timeout that's used to throttle the resize events
			*/
			_this.resizeThrottleId = INITIAL_VALUE;
			/**
			* The timeout that's used to debounce toggling the isCurrentlyBeingResized
			* variable after a resize
			*/
			_this.resizeDebounceId = INITIAL_VALUE;
			_this.lastScrollPosition = _this.adapter.getViewportScrollY();
			_this.topAppBarHeight = _this.adapter.getTopAppBarHeight();
			return _this;
		}
		MDCTopAppBarFoundation.prototype.destroy = function() {
			_super.prototype.destroy.call(this);
			this.adapter.setStyle("top", "");
		};
		/**
		* Scroll handler for the default scroll behavior of the top app bar.
		*/
		MDCTopAppBarFoundation.prototype.handleTargetScroll = function() {
			var currentScrollPosition = Math.max(this.adapter.getViewportScrollY(), 0);
			var diff = currentScrollPosition - this.lastScrollPosition;
			this.lastScrollPosition = currentScrollPosition;
			if (!this.isCurrentlyBeingResized) {
				this.currentAppBarOffsetTop -= diff;
				if (this.currentAppBarOffsetTop > 0) this.currentAppBarOffsetTop = 0;
				else if (Math.abs(this.currentAppBarOffsetTop) > this.topAppBarHeight) this.currentAppBarOffsetTop = -this.topAppBarHeight;
				this.moveTopAppBar();
			}
		};
		/**
		* Top app bar resize handler that throttle/debounce functions that execute updates.
		*/
		MDCTopAppBarFoundation.prototype.handleWindowResize = function() {
			var _this = this;
			if (!this.resizeThrottleId) this.resizeThrottleId = setTimeout(function() {
				_this.resizeThrottleId = INITIAL_VALUE;
				_this.throttledResizeHandler();
			}, numbers.DEBOUNCE_THROTTLE_RESIZE_TIME_MS);
			this.isCurrentlyBeingResized = true;
			if (this.resizeDebounceId) clearTimeout(this.resizeDebounceId);
			this.resizeDebounceId = setTimeout(function() {
				_this.handleTargetScroll();
				_this.isCurrentlyBeingResized = false;
				_this.resizeDebounceId = INITIAL_VALUE;
			}, numbers.DEBOUNCE_THROTTLE_RESIZE_TIME_MS);
		};
		/**
		* Function to determine if the DOM needs to update.
		*/
		MDCTopAppBarFoundation.prototype.checkForUpdate = function() {
			var offscreenBoundaryTop = -this.topAppBarHeight;
			var hasAnyPixelsOffscreen = this.currentAppBarOffsetTop < 0;
			var hasAnyPixelsOnscreen = this.currentAppBarOffsetTop > offscreenBoundaryTop;
			var partiallyShowing = hasAnyPixelsOffscreen && hasAnyPixelsOnscreen;
			if (partiallyShowing) this.wasDocked = false;
			else if (!this.wasDocked) {
				this.wasDocked = true;
				return true;
			} else if (this.isDockedShowing !== hasAnyPixelsOnscreen) {
				this.isDockedShowing = hasAnyPixelsOnscreen;
				return true;
			}
			return partiallyShowing;
		};
		/**
		* Function to move the top app bar if needed.
		*/
		MDCTopAppBarFoundation.prototype.moveTopAppBar = function() {
			if (this.checkForUpdate()) {
				var offset = this.currentAppBarOffsetTop;
				if (Math.abs(offset) >= this.topAppBarHeight) offset = -numbers.MAX_TOP_APP_BAR_HEIGHT;
				this.adapter.setStyle("top", offset + "px");
			}
		};
		/**
		* Throttled function that updates the top app bar scrolled values if the
		* top app bar height changes.
		*/
		MDCTopAppBarFoundation.prototype.throttledResizeHandler = function() {
			var currentHeight = this.adapter.getTopAppBarHeight();
			if (this.topAppBarHeight !== currentHeight) {
				this.wasDocked = false;
				this.currentAppBarOffsetTop -= this.topAppBarHeight - currentHeight;
				this.topAppBarHeight = currentHeight;
			}
			this.handleTargetScroll();
		};
		return MDCTopAppBarFoundation;
	}(MDCTopAppBarBaseFoundation);

//#endregion
//#region node_modules/.pnpm/@material+top-app-bar@14.0.0/node_modules/@material/top-app-bar/fixed/foundation.js
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
	var MDCFixedTopAppBarFoundation = function(_super) {
		__extends(MDCFixedTopAppBarFoundation, _super);
		function MDCFixedTopAppBarFoundation() {
			var _this = _super !== null && _super.apply(this, arguments) || this;
			/**
			* State variable for the previous scroll iteration top app bar state
			*/
			_this.wasScrolled = false;
			return _this;
		}
		/**
		* Scroll handler for applying/removing the modifier class on the fixed top app bar.
		*/
		MDCFixedTopAppBarFoundation.prototype.handleTargetScroll = function() {
			if (this.adapter.getViewportScrollY() <= 0) {
				if (this.wasScrolled) {
					this.adapter.removeClass(cssClasses.FIXED_SCROLLED_CLASS);
					this.wasScrolled = false;
				}
			} else if (!this.wasScrolled) {
				this.adapter.addClass(cssClasses.FIXED_SCROLLED_CLASS);
				this.wasScrolled = true;
			}
		};
		return MDCFixedTopAppBarFoundation;
	}(MDCTopAppBarFoundation);

//#endregion
//#region node_modules/.pnpm/@material+top-app-bar@14.0.0/node_modules/@material/top-app-bar/short/foundation.js
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
	var MDCShortTopAppBarFoundation = function(_super) {
		__extends(MDCShortTopAppBarFoundation, _super);
		/* istanbul ignore next: optional argument is not a branch statement */
		function MDCShortTopAppBarFoundation(adapter) {
			var _this = _super.call(this, adapter) || this;
			_this.collapsed = false;
			_this.isAlwaysCollapsed = false;
			return _this;
		}
		Object.defineProperty(MDCShortTopAppBarFoundation.prototype, "isCollapsed", {
			get: function() {
				return this.collapsed;
			},
			enumerable: false,
			configurable: true
		});
		MDCShortTopAppBarFoundation.prototype.init = function() {
			_super.prototype.init.call(this);
			if (this.adapter.getTotalActionItems() > 0) this.adapter.addClass(cssClasses.SHORT_HAS_ACTION_ITEM_CLASS);
			this.setAlwaysCollapsed(this.adapter.hasClass(cssClasses.SHORT_COLLAPSED_CLASS));
		};
		/**
		* Set if the short top app bar should always be collapsed.
		*
		* @param value When `true`, bar will always be collapsed. When `false`, bar may collapse or expand based on scroll.
		*/
		MDCShortTopAppBarFoundation.prototype.setAlwaysCollapsed = function(value) {
			this.isAlwaysCollapsed = !!value;
			if (this.isAlwaysCollapsed) this.collapse();
			else this.maybeCollapseBar();
		};
		MDCShortTopAppBarFoundation.prototype.getAlwaysCollapsed = function() {
			return this.isAlwaysCollapsed;
		};
		/**
		* Scroll handler for applying/removing the collapsed modifier class on the short top app bar.
		*/
		MDCShortTopAppBarFoundation.prototype.handleTargetScroll = function() {
			this.maybeCollapseBar();
		};
		MDCShortTopAppBarFoundation.prototype.maybeCollapseBar = function() {
			if (this.isAlwaysCollapsed) return;
			if (this.adapter.getViewportScrollY() <= 0) {
				if (this.collapsed) this.uncollapse();
			} else if (!this.collapsed) this.collapse();
		};
		MDCShortTopAppBarFoundation.prototype.uncollapse = function() {
			this.adapter.removeClass(cssClasses.SHORT_COLLAPSED_CLASS);
			this.collapsed = false;
		};
		MDCShortTopAppBarFoundation.prototype.collapse = function() {
			this.adapter.addClass(cssClasses.SHORT_COLLAPSED_CLASS);
			this.collapsed = true;
		};
		return MDCShortTopAppBarFoundation;
	}(MDCTopAppBarBaseFoundation);

//#endregion
//#region node_modules/.pnpm/@material+top-app-bar@14.0.0/node_modules/@material/top-app-bar/component.js
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
	var MDCTopAppBar = function(_super) {
		__extends(MDCTopAppBar, _super);
		function MDCTopAppBar() {
			return _super !== null && _super.apply(this, arguments) || this;
		}
		MDCTopAppBar.attachTo = function(root) {
			return new MDCTopAppBar(root);
		};
		MDCTopAppBar.prototype.initialize = function(rippleFactory) {
			if (rippleFactory === void 0) rippleFactory = function(el) {
				return MDCRipple.attachTo(el);
			};
			this.navIcon = this.root.querySelector(strings.NAVIGATION_ICON_SELECTOR);
			var icons = [].slice.call(this.root.querySelectorAll(strings.ACTION_ITEM_SELECTOR));
			if (this.navIcon) icons.push(this.navIcon);
			this.iconRipples = icons.map(function(icon) {
				var ripple = rippleFactory(icon);
				ripple.unbounded = true;
				return ripple;
			});
			this.scrollTarget = window;
		};
		MDCTopAppBar.prototype.initialSyncWithDOM = function() {
			this.handleNavigationClick = this.foundation.handleNavigationClick.bind(this.foundation);
			this.handleWindowResize = this.foundation.handleWindowResize.bind(this.foundation);
			this.handleTargetScroll = this.foundation.handleTargetScroll.bind(this.foundation);
			this.scrollTarget.addEventListener("scroll", this.handleTargetScroll);
			if (this.navIcon) this.navIcon.addEventListener("click", this.handleNavigationClick);
			var isFixed = this.root.classList.contains(cssClasses.FIXED_CLASS);
			if (!this.root.classList.contains(cssClasses.SHORT_CLASS) && !isFixed) window.addEventListener("resize", this.handleWindowResize);
		};
		MDCTopAppBar.prototype.destroy = function() {
			var e_1, _a;
			try {
				for (var _b = __values(this.iconRipples), _c = _b.next(); !_c.done; _c = _b.next()) _c.value.destroy();
			} catch (e_1_1) {
				e_1 = { error: e_1_1 };
			} finally {
				try {
					if (_c && !_c.done && (_a = _b.return)) _a.call(_b);
				} finally {
					if (e_1) throw e_1.error;
				}
			}
			this.scrollTarget.removeEventListener("scroll", this.handleTargetScroll);
			if (this.navIcon) this.navIcon.removeEventListener("click", this.handleNavigationClick);
			var isFixed = this.root.classList.contains(cssClasses.FIXED_CLASS);
			if (!this.root.classList.contains(cssClasses.SHORT_CLASS) && !isFixed) window.removeEventListener("resize", this.handleWindowResize);
			_super.prototype.destroy.call(this);
		};
		MDCTopAppBar.prototype.setScrollTarget = function(target) {
			this.scrollTarget.removeEventListener("scroll", this.handleTargetScroll);
			this.scrollTarget = target;
			this.handleTargetScroll = this.foundation.handleTargetScroll.bind(this.foundation);
			this.scrollTarget.addEventListener("scroll", this.handleTargetScroll);
		};
		MDCTopAppBar.prototype.getDefaultFoundation = function() {
			var _this = this;
			var adapter = {
				hasClass: function(className) {
					return _this.root.classList.contains(className);
				},
				addClass: function(className) {
					return _this.root.classList.add(className);
				},
				removeClass: function(className) {
					return _this.root.classList.remove(className);
				},
				setStyle: function(property, value) {
					return _this.root.style.setProperty(property, value);
				},
				getTopAppBarHeight: function() {
					return _this.root.clientHeight;
				},
				notifyNavigationIconClicked: function() {
					return _this.emit(strings.NAVIGATION_EVENT, {});
				},
				getViewportScrollY: function() {
					var win = _this.scrollTarget;
					var el = _this.scrollTarget;
					return win.pageYOffset !== void 0 ? win.pageYOffset : el.scrollTop;
				},
				getTotalActionItems: function() {
					return _this.root.querySelectorAll(strings.ACTION_ITEM_SELECTOR).length;
				}
			};
			var foundation;
			if (this.root.classList.contains(cssClasses.SHORT_CLASS)) foundation = new MDCShortTopAppBarFoundation(adapter);
			else if (this.root.classList.contains(cssClasses.FIXED_CLASS)) foundation = new MDCFixedTopAppBarFoundation(adapter);
			else foundation = new MDCTopAppBarFoundation(adapter);
			return foundation;
		};
		return MDCTopAppBar;
	}(MDCComponent);

//#endregion
//#region Components/TopAppBar/MBTopAppBar.ts
	var MBTopAppBar_exports = /* @__PURE__ */ __exportAll({ init: () => init });
	function init(elem, scrollTarget) {
		if (!elem) return;
		elem._topAppBar = MDCTopAppBar.attachTo(elem);
		if (scrollTarget) elem._topAppBar.setScrollTarget(document.querySelector(scrollTarget));
	}

//#endregion
//#region Scripts/material.blazor.ts
	window.MaterialBlazor = {
		MBAutocompletePagedField: MBAutocompletePagedField_exports,
		MBAutocompleteTextField: MBAutocompleteTextField_exports,
		MBBladeSet: MBBladeSet_exports,
		MBButton: MBButton_exports,
		MBCard: MBCard_exports,
		MBCheckbox: MBCheckbox_exports,
		MBCircularProgress: MBCircularProgress_exports,
		MBDataTable: MBDataTable_exports,
		MBDatePicker: MBDatePicker_exports,
		MBDialog: MBDialog_exports,
		MBDrawer: MBDrawer_exports,
		MBDragAndDropList: MBDragAndDropList_exports,
		MBFileUpload: MBFileUpload_exports,
		MBFloatingActionButton: MBFloatingActionButton_exports,
		MBIconButton: MBIconButton_exports,
		MBIconButtonToggle: MBIconButtonToggle_exports,
		MBLinearProgress: MBLinearProgress_exports,
		MBList: MBList_exports,
		MBMenu: MBMenu_exports,
		MBMenuSurface: MBMenuSurface_exports,
		MBPopover: MBPopover_exports,
		MBRadioButton: MBRadioButton_exports,
		MBSegmentedButtonMulti: MBSegmentedButtonMulti_exports,
		MBSelect: MBSelect_exports,
		MBSlider: MBSlider_exports,
		MBSnackbar: MBSnackbar_exports,
		MBSwitch: MBSwitch_exports,
		MBTabBar: MBTabBar_exports,
		MBTextField: MBTextField_exports,
		MBTooltip: MBTooltip_exports,
		MBTopAppBar: MBTopAppBar_exports,
		RTL: rtl_exports
	};

//#endregion
})();