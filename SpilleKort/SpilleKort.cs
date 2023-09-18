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
            int kort = new Random().Next(55); // 0 til 51 + 3 joker
            if(kort >= 52)return new Kort(kortFarve[4] + " " + kort);
            return new Kort(kortFarve[(kort/13)] + kortNavn[(kort%13)]+ " " + kort);
        }
    }
}