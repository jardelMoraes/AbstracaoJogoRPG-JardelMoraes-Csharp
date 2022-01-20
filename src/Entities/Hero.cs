namespace AbstracaoJogoRPG_JardelMoraes_Csharp.src.Entities
{
    public class Hero
    {
        public Hero(string Name,int Level,string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public override string ToString()
        {
            return this.Name + " " + this.HeroType + " " + this.Level;
            
        }
         public virtual string Attack(){
            return this.Name + " Atacou com sua espada";
        }
    }
}
