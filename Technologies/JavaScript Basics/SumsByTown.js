function calcSums(arr) {
    let objects = arr.map(JSON.parse);
    let sum = {};
    for (let obj of objects){
        sum[obj.town] = sum[obj.town] || 0;
        sum[obj.town] += obj.income;
    }
    let towns = Object.keys(sum);
    towns.sort();
    for (let t of towns){
        console.log(`${t} -> ${sum[t]}`);
    }
}

calcSums([
    '{"town":"Sofia","income":200}',
    '{"town":"Varna","income":50}',
    '{"town":"Sofia","income":100}',
    '{"town":"Sofia","income":100}',
    '{"town":"Asenovgrad","income":300}'
]);