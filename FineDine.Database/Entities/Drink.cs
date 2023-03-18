using FineDine.Database.Interface;

namespace FineDine.Database.Entities;
public class Drink: IEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool HotDrink { get; set; }
    public bool ColdDrink { get; set; }
    public string ImageUrl { get; set; }
    public virtual ICollection<Dish>? Dishes { get; set; }
}
