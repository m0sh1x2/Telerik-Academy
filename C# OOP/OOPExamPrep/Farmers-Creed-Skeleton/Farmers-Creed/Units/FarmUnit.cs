using FarmersCreed.Interfaces;

namespace FarmersCreed.Units
{
    using System;

    public abstract class FarmUnit : GameObject, IProductProduceable 
    {
        private int health;
        private bool isAlive;
        private int productionQuanity;
        protected Product product;


        public FarmUnit(string id, int health, int productionQuantity)
            : base(id)
        {
            this.IsAlive = true;
            this.Health = health;
            this.ProductionQuantity = productionQuanity;

            //this.product = new Product();
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public bool IsAlive
        {
            get { return this.isAlive; }
            protected set { this.isAlive = value; }
        }

        public int ProductionQuantity
        {
            get { return this.productionQuanity; }
            set { this.productionQuanity = value; }
        }

        public Product GetProduct()
        {
            return this.product;
        }
    }
}
