namespace Battlefield
{
    class Enemy
    {
        public string Name { get; set; }
        private int _health;
        public int Health
        {
            get
            {
                if (_health == 0)
                    return 0;
                else
                    return _health;
            }
            set { _health = value; }  
        }
        public int MaxHealth { get; set; }
        public int MinAttack { get; set; }
        public int MaxAttack { get; set; }

        public void Attack()
        {
            int dmg = Game.Rnd(MinAttack, MaxAttack);
            if (Game.Rnd(0, 1) == 0)
            {
                Game.Message("Critical Hit!", Color.Red);
                dmg *= 2;
            }
            Data.Health -= dmg;
            Game.Message($"-{dmg} health! You have {Data.Health} left!", Color.Red);
        }
    }
}
