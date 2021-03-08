
var methodLookup = {};

// calls a set of javascript methods by their identifier and arguments
export function apply(calls) {
    return calls.map((call) => {
        const identifier: string = call.identifier;
        const args: object[] = call.args;
        try {
            // the identifier is a string, but we need the actual method, which we get by using eval. We cache the result.
            if (!(identifier in methodLookup)) {
                methodLookup[identifier] = eval(identifier);
            }
            var f = methodLookup[identifier];
            if (args == null) {
                f();
            } else {
                f(...args);
            }
            return null;
        } catch (e) {
            return e.message;
        }
    });
}
