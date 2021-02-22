
var methodLookup = {};

// calls a set of javascript methods by their identifier and arguments
export function applyBatch(calls: { identifier: string, args: object[] }[]) {
    return calls.map((call) => {
        const identifier: string = call.identifier;
        const args: object[] = call.args;
        // the identifier is a string, but we need the actual method, which we get by using eval. We cache the result.
        if (!(identifier in methodLookup)) {
            methodLookup[identifier] = eval(identifier);
        }
        var f = methodLookup[identifier];
        try {
            f(...args);
            return null;
        } catch (e) {
            return "failed";
        }
    })
}
