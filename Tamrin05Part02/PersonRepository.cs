public class PersonRepository : IPersonRepository
{
    List<Person> personList = new List<Person>();
    public void Create(Person person)
    {
        personList.Add(person);
    }
    public void Read(Person person)
    {
        foreach (Person itemPerson in personList)
        {
            if (itemPerson.Id == person.Id)
                Console.WriteLine(itemPerson);
            else
                Console.WriteLine("Not Existed!");
        }
    }
    public void Update(Person person)
    {
        var p = personList.FirstOrDefault(p => p.Id == person.Id);
        p.FirstName = person.FirstName;
        p.LastName = person.LastName;
        p.Age = person.Age;
        p.Id = person.Id;
    }
    public void Delete(Person person)
    {
        var p = personList.Remove(person);
    }
}

