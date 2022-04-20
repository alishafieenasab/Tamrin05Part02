public class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    public string? Id { get; set; }

    public Person(string aFirstName, string aLastName, int aAge, string aId)
    {
        FirstName = aFirstName;
        LastName = aLastName;
        Age = aAge;
        Id = aId;
    }
}

