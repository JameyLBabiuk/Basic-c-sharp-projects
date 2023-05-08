//  function to estimate the package shipping cost
function packageShippingEstimate() {
  console.log("Welcome to Package Express. Please follow the instructions below.");

  // Prompt user for package weight
  let packageWeight = parseFloat(prompt("Please enter the package weight:"));

  // If package weight is greater than 50, display an error message and end program
  if (packageWeight > 50) {
    console.log("Package too heavy to be shipped via Package Express. Have a good day.");
  } else {
    // Prompt user for package dimensions
    let packageWidth = parseFloat(prompt("Please enter the package width:"));
    let packageHeight = parseFloat(prompt("Please enter the package height:"));
    let packageLength = parseFloat(prompt("Please enter the package length:"));

    // Calculate the total package dimensions
    let totalPackageDimensions = packageWidth + packageHeight + packageLength;

    // If package dimensions total exceeds 50, display an error message and end program
    if (totalPackageDimensions > 50) {
      console.log("Package too big to be shipped via Package Express.");
    } else {
      // Calculate the shipping cost and display it to the user
      let quote = ((packageWidth * packageHeight * packageLength) * packageWeight) / 100;
      console.log("Your estimated total for shipping this package is: $" + quote.toFixed(2));
      console.log("Thank you!");
      return quote.toFixed(2);
    }
  }
}

// Prompt user to run the function
/*
open your terminal or command prompt and navigate to the directory where the file is saved. 
Run the code using the command `node packageShippingEstimate.js` and follow the prompts.

by triggering the packageShippingEstimate.js function, you will get the following prompts

*/



// 1. Welcome to Package Express. Please follow the instructions below.
// 2. Please enter the package weight:
// 3. 40
// 4. Please enter the package width:
// 5. 10
// 6. Please enter the package height:
// 7. 12
// 8. Please enter the package length:
// 9. 11
// Your estimated total for shipping this package is: $528.00
// Thank you!
