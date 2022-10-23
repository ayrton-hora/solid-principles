namespace SOLID_Principles.Principles.OCP.Example1.Cohesive
{
    internal class Product
    {
        #region Original Class
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        private decimal _cost { get; set; } = 0;

        public decimal Cost
        {
            get => _cost;

            private set
            {
                if (value > 0) _cost = value;
            }
        }
        private decimal _sale { get; set; } = 1;

        public decimal Sale
        {
            get => _sale;

            private set
            {
                if (value > 0) _sale = value;
            }
        }

        public int Inventory { get; set; }

        public bool Active { get; set; }

        public Product(int id, string name, string description, decimal cost, decimal sale, int inventory, bool active)
        {
            ProductId = id;
            Name = name;
            Description = description;
            Cost = cost;
            Sale = sale;
            Inventory = inventory;
            Active = active;
        }
        #endregion
    }
}
