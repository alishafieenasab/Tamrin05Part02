Console.WriteLine("Please Select an action : ");

Console.WriteLine("1- Create : ");
Console.WriteLine("2- Read : ");
Console.WriteLine("3- Update : ");
Console.WriteLine("4- Delete : ");

IPersonRepository myPerson = new PersonRepository();
Person aPerson = new Person("ali" , "shafiee" , 21 , "100");

do
{
    string? op = Console.ReadLine();
    switch (op)
    {
        case "1":
            myPerson.Create(aPerson);
            break;
        case "2":
            myPerson.Read(aPerson);
            break;
        case "3":
            myPerson.Update(aPerson);
            break;
        case "4":
            myPerson.Delete(aPerson);
            break;
        default:
            Console.WriteLine("Invalid Operator!!");
            break;
    }
}while (true);


