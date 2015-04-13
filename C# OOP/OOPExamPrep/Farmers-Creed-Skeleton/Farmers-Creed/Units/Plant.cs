namespace FarmersCreed.Units
{
    using System;

    public abstract class Plant : FarmUnit
    {

        private int growTime;
        private bool hasGrown;


        public Plant(string id, int health, int productionQuantity, int growTime)
            : base(id, health, productionQuantity)
        {
            this.GrowTime = growTime;
            this.DefaultGrowTime = 1;
            this.DefaulWaterAmount = 2;
            this.DefaulWitherTime = 1;
        }

        public bool HasGrown
        {
            get { return this.hasGrown; }
            protected set { this.hasGrown = value; }
        }

        public int GrowTime
        {
            get { return this.growTime; }
            set { this.growTime = value; }
        }
        public int DefaulWitherTime { get; set; }
        public int DefaulWaterAmount { get; set; }
        public int DefaultGrowTime { get; set; }

        public void Water()
        {
            this.Health += this.DefaulWaterAmount;
        }

        public void Wither()
        {
            this.Health -= this.DefaulWitherTime;
            if (this.Health <= 0)
            {
                this.IsAlive = false;
            }
        }

        public virtual void Grow()
        {
            this.GrowTime -= this.DefaultGrowTime;
            if (this.GrowTime <= 0)
            {
                this.HasGrown = true;
            }
        }
    }
}
