namespace desafio_iniciante.src.Entities
{
    public class Hero
    {

        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Hero(){

        }

        public string Name;

        public int Level;

        public string HeroType;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return Attack() + " com bonûs super efetivo de ataque de " + Bonus;
            }
            else
            {
                return Attack() + " com bonûs não efetivo de ataque de " + Bonus;
            }
        }

    }
}