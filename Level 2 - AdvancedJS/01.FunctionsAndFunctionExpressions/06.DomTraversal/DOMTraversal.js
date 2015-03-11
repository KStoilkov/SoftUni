function traverse(selector) {
    var node = document.querySelector(selector);

    if (node !== undefined && node !== null) {
        traverseNode(node, '');
    }

    function traverseNode(node, spacing) {
        spacing = spacing || '  ';
        var nodeId = node.getAttribute("id");
        var nodeClass = node.getAttribute("class");
        var output = spacing + node.nodeName.toLowerCase() + ": ";

        if (nodeId !== null) {
            output += "id=\"" + nodeId + "\", ";
        }

        if (nodeClass !== null) {
            output += "class=\"" + nodeClass + "\"";
        }

        console.log(spacing + output);

        var len = node.childNodes.length;
        for (var i = 0; i < len; i+=1) {
            var child = node.childNodes[i];

            if (child.nodeType === document.ELEMENT_NODE) {
                traverseNode(child, spacing + '  ');
            }
        }

    }
}

traverse(".birds");