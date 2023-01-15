// See https://aka.ms/new-console-template for more information
using BuilderPattern.Method1;
using BuilderPattern.Method2;
using BuilderPattern.Method3;
using System.Xml.Linq;


#region Method1
EndpointBuilder epBuilder = new EndpointBuilder("https://localhost/");

epBuilder
    .Append("api")
    .Append("user")
    .AppendParams("username", "0the1emre")
    .AppendParams("mail", "emrekurtar007@gmail.com")
    .Append("v2");

//Console.WriteLine(epBuilder.Build());
#endregion

#region Method2

EmployeeM1Builder empM1Builder = new EmployeeM1Builder();

EmployeeM1 empM1 = empM1Builder
    .SetFullName("Merve Emre Emir Kurtar")
    .SetEmail("emrekurtar007@gmail.com")
    .SetUserName("0the1emre")
    .BuildEmployee();


//Console.WriteLine($"Firstname : {empM1.FirstName} \nLastName : {empM1.LastName}");

#endregion

#region Method3

EmployeeM2 GenerateEmployeeM2 (string fullName,string email,string username,EmployeeType empType){

    IEmployeeM2Builder empM2Builder;
    
    switch (empType)
    {
        case EmployeeType.External:
            empM2Builder = new ExternalEmployeeBuilder();
            break;
        case EmployeeType.Internal:
            empM2Builder = new InternalEmployeeBuilder();
            break;
        default:
            empM2Builder = new DefaultEmployeeBuilder();
            break;
    }

    EmployeeM2 emp = empM2Builder
        .SetFullName(fullName)
        .SetEmail(email)
        .SetUserName(username)
        .BuildEmployee();

    return emp;
}

//My email adress will be endwith @gmail.com, in despite of I set to my mail adress to @gmail.com
Console.WriteLine(GenerateEmployeeM2("Emre Can Kurtar","emre.kurtar@gmail.com","0the1emre",EmployeeType.Internal).Email);
#endregion