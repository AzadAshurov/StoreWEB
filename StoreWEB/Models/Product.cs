namespace StoreWEB.Models
{
    public class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }


        public bool Availability { get; set; }

        public string Description { get; set; }


        //relational
        public int CategoryId { get; set; }
        //public Category Category { get; set; } 

    }
}
