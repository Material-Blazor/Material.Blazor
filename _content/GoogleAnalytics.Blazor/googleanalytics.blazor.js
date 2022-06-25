window.dataLayer = window.dataLayer || [];
window.gtag = window.gtag || function () { dataLayer.push(arguments); };
gtag("js", new Date());
var GoogleAnalyticsInterop;
(function (GoogleAnalyticsInterop) {
    function configure(trackingId, additionalConfigInfo) {
        this.additionalConfigInfo = additionalConfigInfo;
        var script = document.createElement("script");
        script.async = true;
        script.src = "https://www.googletagmanager.com/gtag/js?id=" + trackingId;
        document.head.appendChild(script);
        var configObject = {};
        configObject.send_page_view = false;
        Object.assign(configObject, additionalConfigInfo);
        gtag("config", trackingId, configObject);
    }
    GoogleAnalyticsInterop.configure = configure;
    function navigate(trackingId, href) {
        var configObject = {};
        configObject.page_location = href;
        Object.assign(configObject, this.additionalConfigInfo);
        gtag("config", trackingId, configObject);
    }
    GoogleAnalyticsInterop.navigate = navigate;
    function trackEvent(eventName, eventParams, globalEventParams) {
        Object.assign(eventParams, globalEventParams);
        gtag("event", eventName, eventParams);
    }
    GoogleAnalyticsInterop.trackEvent = trackEvent;
})(GoogleAnalyticsInterop || (GoogleAnalyticsInterop = {}));
