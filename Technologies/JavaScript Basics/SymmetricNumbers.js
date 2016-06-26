function symmetricNums(arr) {
    var n = Number (arr[0]);
    result = ' ';
    for ( let i = 1; i <= n; i++) {
        if (isSymmetric("" + i))
            result += i + " "
    }
    console.log(result);

    function isSymmetric(str) {
        for (let i = 0; i<= str.length / 2; i++)
            if (str[i] != str[str.length-1-i])
                return false;
        return true;
    }
}
symmetricNums(['100']);