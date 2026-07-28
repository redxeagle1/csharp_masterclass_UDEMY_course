#:property PublishAot=false
using static System.Console;
/* A variable Need type name and a data to be stored in
 and it acts as a container or box for our data */   


// examples
int /*type*/ mynumber /*name*/ = 3 /*data*/ ;

// there are a lot of types in c# in general common ones are
// 1. float
float pi = 3.1415F; // floating number
// 2. float
bool isGPSEnabled = true; // flag : true or false
// 3. string 
string username = "Denis"; // to store a string of characters and worders
// 4. char
char at = '@'; // to store 1 character


WriteLine($"hi {username} you have {pi} cash and {mynumber} coins {at} your pocket {isGPSEnabled}? ");