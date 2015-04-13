namespace FarmersCreed.Units
{
    using System;
    using FarmersCreed.Interfaces;

    public abstract class Animal : FarmUnit, IProductProduceable
    {
        public Animal(string id, int health, int productionQuantity)
            : base(id, health, productionQuantity)
        {
            this.DefaultStarveValue = 1;
        }

        public int DefaultStarveValue { get; set; }

        public void Eat(IEdible food, int quantity)
        {
            throw new NotImplementedException();
        }
        public void Starve()
        {
            this.Health -= this.DefaultStarveValue;
        }
    }
}
