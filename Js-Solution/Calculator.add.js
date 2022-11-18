function add(inputData) {
    if (!inputData || !(inputData.trim())) {
        return 0;
    }

    const splitData = inputData.trim().replace(/ /g, ',').split(',');

    const result = splitData.reduce((total, sValue) => {
        if (!sValue || isNaN(sValue)) {
            return total;
        }
        return total + parseInt(sValue);
    }, 0);

    return result;
}

console.log('add("1,2,3") => 6', add('1,2,3'));
console.log('add("") => 0', add(''));
console.log('add("42") => 42', add('42'));
console.log('add("-1,1") => 0', add('-1,1'));
console.log('add("1 3 5") => 9', add('1 3 5'));
console.log('add("what is this all about?, I mean, come on dude! this has been broken since 1969") => 1969', add('what is this all about?, I mean, come on dude! this has been broken since 1969'));
