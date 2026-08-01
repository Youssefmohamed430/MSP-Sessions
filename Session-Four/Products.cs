using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Four;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Category { get; set; } = "";
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public double Rating { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, " +
               $"Name: {Name}, " +
               $"Category: {Category}, " +
               $"Price: {Price:C}, " +
               $"Stock: {Stock}, " +
               $"Rating: {Rating}";
    }
}
