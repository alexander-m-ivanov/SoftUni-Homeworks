function extractCapitalLettersWOrds(arr) {
    let text = arr.join(", ");
    let words = text.split(/\W+/).filter(x => x != "");
    let capitalWords = words.filter(
        x => x.toUpperCase() == x
    );
    console.log(capitalWords.join(", "));
}

extractCapitalLettersWOrds([
   'We start by HTML, CSS, JavaScript, JSON and REST.',
    'Later we touch some PHP, MySQL and SQL.'
]);