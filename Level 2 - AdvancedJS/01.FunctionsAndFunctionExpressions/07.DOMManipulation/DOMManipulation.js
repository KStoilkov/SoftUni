var domModule = (function () {
    function appendChild(element, child) {
        var parent = retrieveElements(element);
        var childNode = createElement(child);

        if (parent !== null) {
            for (var i = 0; len = parent.length, i < len; i += 1) {
                parent[i].appendChild(childNode.cloneNode());
            }
        }
    }

    function removeChild(element, child) {
        var parent = retrieveElements(element);

        if (parent != null) {
            for (var i = 0; len = parent.length, i < len; i += 1) {

                var ch = findChild(parent[i], child);
                for (var j = 0; childLength = ch.length, j < childLength ; j += 1) {
                    parent[i].removeChild(ch[j]);
                }
            }
        }
    }

    function addHandler(element, eventType, eventHandler) {
        var parent = retrieveElements(element);

        if (parent !== null) {
           for (var i = 0; len = parent.length, i < len; i += 1) {
               parent[i].addEventListener(eventType, eventHandler);
           }
        }
    }

    function retrieveElements(selector) {
        return document.querySelectorAll(selector);
    }

    function createElement(element) {
        return document.createElement(element);
    }

    function findChild (element, selector) {
        return element.querySelectorAll(":scope > " + selector);
    }

    return {
        appendChild : appendChild,
        retrieveElements : retrieveElements,
        removeChild : removeChild,
        addHandler : addHandler
    }
})();

domModule.appendChild(".bird", 'li');
domModule.removeChild('.bird', 'li');
domModule.addHandler('li.bird', 'click', function () {
    alert(" I'm a bird!");
});

var elements = domModule.retrieveElements('.birds');
console.log(elements);