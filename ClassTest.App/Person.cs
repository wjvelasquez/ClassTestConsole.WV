public class Person
{
    public string? Name { get; set; }

    public string? Lastname { get; set; }


    public Person() {}

    public Person(string name, string Lastname)
    {
        Name = name;
        this.Lastname = Lastname;
    }


    public override string ToString() => $"{Name} {Lastname}";

}