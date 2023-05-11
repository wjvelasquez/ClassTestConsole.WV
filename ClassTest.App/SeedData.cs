static class SeedData
{
    public static List<Person> Load()
    {
        var p0 = new Person("William", "Velasquez");
        
        Person? p2 = new Person("Jose", "Fuentes");
        
        var p3 = new Person
        {
            Name = "Yo",
            Lastname = "merp"
        };
        
        var p4 = new Person
        {
            Name = "Fulano",
            Lastname = "De tal"
        };
        
        var p5 = new Person();
        p5.Name = "Nombreeee";
        p5.Lastname = "Apeeeellido";
        
        var p6 = new Person
        {
            Name = "Mengano",
            Lastname = "De tal"
        };
        
        var p8 = new Person
        {
            Name = "sutano",
            Lastname = "De tal"
        };

        var people = new List<Person> { p0, p2, p3, p4, p5, p6, p8 };

        return people;
    }
}
