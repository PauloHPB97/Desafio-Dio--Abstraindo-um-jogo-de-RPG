namespace desafio_iniciante.src.Entities
{
    public class BlackWizard : Wizard
    {
        public BlackWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " Lançou magia negra";
        }
    }
}