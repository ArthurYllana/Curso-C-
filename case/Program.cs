int x = int.Parse(Console.ReadLine());
string day;

switch (x){
    case 1:
        day = "Monday";
        break;
    case 2:
        day = "Tuesday";
        break;
    case 3:
        day = "Wednesday";
        break;
    case 4:
        day = "Thursday";
        break;
    default:
        day = "Invalid day";
        break;
}
/*
if (x == 1){
    day = "Monday";
}
else if (x == 2){
    day = "Tuesday";
}
else if (x == 3){
    day = "Wednesday";
}
else if (x == 4){
    day = "Thursday";
}
else{
    day = "Invalid Day";
}

*/
System.Console.WriteLine("Day: " + day);