using SQLite;

namespace FidelityBTG.MVVM.Models;

[Table("Clients")]
public class Client
{
    [PrimaryKey, AutoIncrement] public int Id { get; set; }
    [NotNull] public string Name { get; set; }
    [NotNull] public string LastName { get; set; }
    [NotNull] public string Address { get; set; }
    [NotNull] public DateTime Birthday { get; set; }
    [NotNull] public bool IsActive { get; set; }

    public string FullName
    {
        get
        {
            return Name + " " + LastName;
        }
    }

    public int GetClientAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - Birthday.Year;
        if (Birthday > today.AddYears(-age)) age--;
        return age;
    }
}