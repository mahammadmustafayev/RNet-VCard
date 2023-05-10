namespace VCard.Models;



public record vCard
{
    private static int _id = 1;
    public int Id { get => _id++; }
    public string FullName { get; init; }
    public string Title { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string Email { get; init; }
    public string Phone { get; init; }
    public string Country { get; init; }
    public string City { get; init; }
    public string Photo { get; init; }
}


public record Id
{
    private static int _id=1;
    public int id { get => _id++; }
}




public record Location
{
    
    public string city { get; init; }
    
    public string country { get; init; }
   
}



public record Name
{
    public string title { get; init; }
    public string first { get; init; }
    public string last { get; init; }
}

public record Picture
{
    public string medium { get; init; }
}

public record Result
{
    
    public Name name { get; init; }
    public Location location { get; init; }

    public string email { get; init; }
    
    public string phone { get; init; }
    public Picture picture { get; init; }

    public Id id { get; init; }
    
}

public record Root
{
    public List<Result> results { get; init; }
    
}




