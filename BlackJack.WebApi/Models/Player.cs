namespace BlackJack.Models
{
    public class Player : Person
    {
        public decimal Funds { get; set; } = 200M; //$200
        public decimal Bet { get; set; }
        public decimal InsuranceBet { get; set; }
        public decimal Change { get; set; }
        public bool HasStood { get; set; }

        public void Collect()
        {
            Funds += Change;
            Change = 0M;
            InsuranceBet = 0M;
        }
    }
}