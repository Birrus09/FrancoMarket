using FrancoMarket;
using Permanenza1;
using System;

namespace Market
{
    public class Utente
    {
        public int ELO;
        public List<Merluzzo> Merluzzi;
        public Collezione Collezione;

        public Utente(int ELO, List<Merluzzo> merluzzi, Collezione Collezione)
        {
            this.ELO = ELO;
            this.Merluzzi = merluzzi;
            this.Collezione = Collezione;
        }
        
        public GetInput()
        {
            //user input
        }
       

    }



    public class AI : Utente
    {

        public GetInput()
        {
            //overloaded method, generate AI output
        }

    }



    public static class ELO
    {
        public void UpdateELO(ref Utente winner, ref Utente loser)
        {
            int K = 32;
            if (loser.ELO > 1400 && winner.ELO > 1400)
            {
                K = 16;
            }
            EvaluationA = 1 / (1 + pow(10, (winner.ELO - loser.ELO) / 400))
            EvaluationB = 1 / (1 + pow(10, (loser.ELO - winner.ELO) / 400))

            winner.ELO += K * (1 - EvalutationA)
            winner.ELO += K * (0 - EvalutationB)
        }
    }



    public class Market
    {
        public List<Utente> Players;
        

        public (int, int) Matchup()
        {
            //riordina Utenti in base all' ELO
        }

        public Game(int p1, int p2)
        {
            &Utente P1 = Players[p1];
            &Utente P2 = Players[p2];

            //game



            if (winner == 1)
            {

            }
        }

    }


}
