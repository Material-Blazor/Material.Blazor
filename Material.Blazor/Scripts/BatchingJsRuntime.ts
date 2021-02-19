
var methodLookup = {};

// calls a set of javascript methods by their identifier and arguments
export function applyBatch(calls) {
    for (var call of calls) {
        const identifier = call.identifier;
        const args = call.args;
        // the identifier is a string, but we need the actual method, which we get by using eval. We cache the result.
        if (!(identifier in methodLookup)) {
            methodLookup[identifier] = eval(identifier);
        }
        var f = methodLookup[identifier];
        f(...args);
    }
}
