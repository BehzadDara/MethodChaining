using MethodChaining;

var userName = "BehzadDara";
var userAge = 25;


    var userDescription =
        UserMethods
        .CreateUser()
        .SetName(userName)
        .SetAge(userAge)
        .ReturnDescription();


Console.WriteLine(userDescription);
Console.ReadLine();