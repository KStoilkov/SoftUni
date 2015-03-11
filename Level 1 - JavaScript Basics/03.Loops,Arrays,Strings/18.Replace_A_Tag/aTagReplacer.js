function replaceATag(str){
    str = str.replace(/<a/g, '[URL');
    str = str.replace(/<\/a>/g, '[/URL]');

    return str;
}

console.log(replaceATag('<ul>\n<li>\n<a href=http://softuni.bg>SoftUni</a>\n</li>\n</ul>'));