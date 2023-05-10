

namespace VCard.Models;

public static class CardExtension
{
    public static void ToVCard(this vCard vCard)
    {
        string Card = $"""
            BEGIN:VCARD
            VERSION:4.1
            ID:{vCard.Id}
            FN:{vCard.FullName}
            N:{vCard.FirstName}
            EMAIL:{vCard.Email}
            TEL:{vCard.Phone}
            ADR:{vCard.Country}
            ADR:{vCard.City}
            SORT-STRING:{vCard.LastName}
            END:VCARD
            """;
        string path = @"C:\\Users\\acer\\Desktop\\VCard\\VCard\\Cards\\"+vCard.FullName+".vcf";
        File.WriteAllText(path, Card);
    }
    public static void ToDeleteVCard(this vCard vCard)
    {
        string path = @"C:\\Users\\acer\\Desktop\\VCard\\VCard\\Cards\\";
        string[] removeFiles = Directory.GetFiles(path, "*.vcf");
        foreach (var item in removeFiles)
        {
            File.Delete(item);
        }
    }
}
