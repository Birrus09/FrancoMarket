using FrancoMarket;
using Merkuzzi;
using System;

namespace Market
{
    public class Utente
    {
        public int ELO;
        public List<Merluzzo> Merluzzi;
        public Collezione Collezione;

        public Utente(int ELO = 400, List<Merluzzo> merluzzi = {}, Collezione Collezione = new Collezione())
        {
            this.ELO = ELO;
            this.Merluzzi = merluzzi;
            this.Collezione = Collezione;
        }
        
        public string GetInput()
        {
            string input;
            input = Console.readline()
            return input;
        }
       

    }



    public class AI : Utente
    {

        public string GetInput()
        {
            return "scissors";
        }

    }



    public static class ELO
    {
        public void UpdateELO(ref Utente winner, ref Utente loser, int draw = 0)
        {
            int K = 32;
            if (loser.ELO > 1400 && winner.ELO > 1400)
            {
                K = 16;
            }
            float EvaluationA = 1 / (1 + pow(10, (winner.ELO - loser.ELO) / 400));
            float EvaluationB = 1 / (1 + pow(10, (loser.ELO - winner.ELO) / 400));
            if (draw){
                winner.ELO += K * (0.5f - EvaluationA);
                loser.ELO += K * (0.5f - EvaluationB);
                return;
            }
            winner.ELO += K * (1 - EvaluationA);
            loser.ELO += K * (0 - EvaluationB);
        }
    }



    public class Market
    {
        public List<Utente> Players;
        public List<Utente> Active_Players;
        

        public (int, int) Matchup(ref Utente p1)
        {
            Active_Players.Sort((a, b) => b.ELO.CompareTo(a.ELO));
            int index = Active_Players.FindIndex(p => p == p1);
            if (index == 0){
                return (index, index + 1);

            }
            return (index, index - 1);
        }

        public Game(int p1, int p2)
        {
            int winner = 0;
            &Utente P1 = Active_Players[p1];
            &Utente P2 = Active_Players[p2];

            //game



            if (winner == 1)
            {
                ELO.UpdateELO(ref P1, ref P2);

            }
            else if (winner == 2)
            {
                ELO.UpdateELO(ref P2, ref P1);

            }
            else{
                ELO.UpdateELO(ref P2, ref P1, 1);
            }
        }
    }

}
