using System;

namespace Knowledge_MVC5_Example01.Models
{
    public class Product
    {
        public int      Id      { get; set; }
        public string   Name    { get; set; }
        public string   Type    { get; set; }
        public DateTime Created { get; private set; } = DateTime.Now;
    }
}
