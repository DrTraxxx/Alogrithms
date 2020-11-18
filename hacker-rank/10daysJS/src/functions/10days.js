// //Day 1
// function factorial (n) {
//    let factorial =1;

//     for(let i =n;i>=1;i--){
//       factorial *= i
//    }
//    return factorial;
// } 

// console.log(factorial(4));

// const area = (radius) =>
// {
//    const PI = Math.PI;
     
// }

// const perimeter = (radius) =>
// {
//    const PI = Math.PI;
   
//    return 2*PI*radius;
// } 

// console.log(area(4));
// console.log(perimeter(5)); 


// //Day 2
// const vowels = (word) =>
// {
//    let isVowel =(element) => {return element==='a'|| element==='e'||element==='i'||element==='o'}
//    let temp = Array.from(word);
//    let vowelChars ='';

//    for(let i =0;i<=temp.length;++i)
//    {
//       if(isVowel(temp[i])){
//          vowelChars += temp[i];
//          temp.splice(i,1);
//          --i
//       }
//    }
//    vowelChars+=temp.join("");
   
//    Array.from(vowelChars).forEach(element => console.log(element))
// } 

// vowels('javascriptloops')




// //Day 3
//  const getLetter = (s) => 
// {
//    switch(true)
//    {
//       case (new RegExp(/^[aeiou]/).test(s)):
//          return 'A'
//       case (new RegExp(/^[bcdfg]/).test(s)):
//          return 'B'
//       case (new RegExp(/^[hjklm]/).test(s)):
//          return 'C'
//       case (new RegExp(/^[mpqrstvwxyz]/).test(s)):
//          return 'D'
//    }
// } 

// console.log(getLetter('adfgt')) 

// function reverseString(s) {
//     try {
//         console.log(s.split('').reverse().join(''));
//       } catch (e) {
//         console.log(e.message);
//         console.log(s);
//       }
    
// }

// reverseString(Number(12345));

// function sides(expressions) {
//     let arr = [];
//     arr.push((expressions[1]+Math.sqrt((Math.pow(expressions[1],2))-(16*expressions[0])))/4)
//     arr.push((expressions[1]-Math.sqrt((Math.pow(expressions[1],2))-(16*expressions[0])))/4)
    
//     return arr.sort();
// } 

// console.log(sides([140,48]))

// function modifyArray(nums) {
    
//     let temp =  nums.map(num => num%2===0 ? num*2:num*3);
    
//     return temp;
// } 

// modifyArray([1,2,3,4,5]) 



