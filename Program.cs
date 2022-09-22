//While Loop
while(true){
    Console.WriteLine("Type a number between 10 and 99");
    string user_input = Console.ReadLine();
    if(user_input == "exit"){
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("Thank you for playing!");
        break;}
    int user_num = Convert.ToInt32(user_input);
    if(user_num < 10 || user_num > 99){
        Console.WriteLine("Invalid entry, please try again...");
        continue;}
    if(user_num%23 == 0){
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Clear();
    }
    else{
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
    }
}

//Do While Loop
do{
    Console.WriteLine("Type a number between 10 and 99");
    string user_input = Console.ReadLine();
    if(user_input == "exit"){
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("Thank you for playing!");
        break;}
    int user_num = Convert.ToInt32(user_input);
    if(user_num < 10 || user_num > 99){
        Console.WriteLine("Invalid entry, please try again...");
        continue;}
    if(user_num%34 == 0){
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Clear();
    }
    else{
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
    }
} while(true);

//For Loop
for(bool loop = true; loop == true;){
    Console.WriteLine("Type a number between 10 and 99");
    string user_input = Console.ReadLine();
    if(user_input == "exit"){
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("Thank you for playing!");
        break;}
    int user_num = Convert.ToInt32(user_input);
    if(user_num < 10 || user_num > 99){
        Console.WriteLine("Invalid entry, please try again...");
        continue;}
    if(user_num%33 == 0){
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Clear();
    }
    else{
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
    }
}

while(true){
Console.Write("Please enter either *, /, +, -, or exit.");
string user_opporator = Console.ReadLine();
if(user_opporator == "exit"){break;}
if(user_opporator != "*" && user_opporator != "/" && user_opporator != "+" && user_opporator != "-"){
    Console.WriteLine("Invalid input, please try again...");
    continue;
}
Console.WriteLine("What is the first number?");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the second number?");
int num2 = Convert.ToInt32(Console.ReadLine());

switch(user_opporator){
    case "*":
    Console.WriteLine(num1 * num2);
    break;

    case "/":
    Console.WriteLine(num1 / num2);
    break;

    case "+":
    Console.WriteLine(num1 + num2);
    break;

    case "-":
    Console.WriteLine(num1 - num2);
    break;
}
}