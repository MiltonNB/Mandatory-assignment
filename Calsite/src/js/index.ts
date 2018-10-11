
let Gram = 0.0352739619;
let Ounces = 28.3495231;
let Output:HTMLParagraphElement = <HTMLParagraphElement> document.getElementById("output");

document.getElementById("toOunce").addEventListener("click", () => ConvertToOunce());
document.getElementById("toGram").addEventListener("click", () => ConvertToGram());

function ConvertToOunce() {
    let result : number = ToOunce();
    if(result > 0) {
        Output.innerHTML = result.toString() + "  Ounces";
    }
}

function ConvertToGram() {
    let result : number = ToGram();
    if(result > 0) {
        Output.innerHTML = result.toString() + "  Gram";
    }
}

function ToOunce(): number
{
    let value : number = Number((<HTMLInputElement> document.getElementById("valueID")).value);
    return value * Gram;
}

function ToGram(): number
{
    let value : number = Number((<HTMLInputElement> document.getElementById("valueID")).value);
    return value * Ounces;
}