 function numbers(arr) {
     var str = arr[0];
     var input = str.split(/[^0-9]/).filter(Boolean);
     var hex = [];
     for (var i = 0; i < input.length; i++) {
        hex[i] = parseInt(input[i]).toString(16).toUpperCase();
         while (hex[i].length < 4 ) {
             hex[i] = '0' + hex[i];
         }
         hex[i] = '0x' + hex[i];
     }
     console.log(hex.join('-'));
 }
 numbers(['5tffwj(//*7837xzc2---34rlxXP%$”.']);