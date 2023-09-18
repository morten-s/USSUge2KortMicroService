namespace SpilleKort
{
    using System;

    public record Kort(String valueRank);
    public class SpilleKort{
        String[] kortNavn = new string[]{"Es","To","Tre","Fire","Fem","Seks","Syv","Otte","Ni","Ti","Knægt","Dame","Konge"};
        String[] kortFarve = new string[]{"Hjerter","Ruder","Spar","Klør","Joker"};
        public SpilleKort()
        {
        }

        public Kort HentKort()
        {
            int kort = new Random().Next(55); // 52kort + 3 joker, værdier mellem 0 - 54
            //Er det en jooker?
            if(kort >= 52 && kort < 55)return new Kort(kortFarve[4] + " " + kort);
            //Er det et alm kort
            return new Kort(kortFarve[(kort/13)] + kortNavn[(kort%13)]+ " " + kort);
        }
    }
}