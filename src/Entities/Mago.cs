namespace AbstracaoJogoRPG_JardelMoraes_Csharp.src.Entities
{
    public class Mago : Hero
    {
         public Mago(string Name,int Level,string HeroType)  :  base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
    }
}
