// Type definitions for metisMenu 2.4.3
// Project: http://github.com/onokumus/metisMenu
// Definitions by: onokums <https://github.com/onokumus/>
// Definitions: https://github.com/borisyankov/DefinitelyTyped

/// //<reference types="jquery"/>


interface MetisMenuOptions {
    toggle?: boolean;
    doubleTapToGo?: boolean;
    preventDefault?: boolean;
    activeClass?: string;
    collapseClass?: string;
    collapseInClass?: string;
    collapsingClass?: string;
    onTransitionStart?: boolean
    onTransitionEnd?: boolean
}

interface JQuery {
    metisMenu(options?: MetisMenuOptions): JQuery;
}
