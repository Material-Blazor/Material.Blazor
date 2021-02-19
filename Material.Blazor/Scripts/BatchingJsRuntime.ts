
var methodLookup = {};

export function applyBatch(calls) {
    for (var call of calls) {
        const identifier = call.identifier;
        const args = call.args;
        if (!(identifier in methodLookup)) {
            methodLookup[identifier] = eval(identifier);
        }
        var f = methodLookup[identifier];
        f(...args);
    }
}
