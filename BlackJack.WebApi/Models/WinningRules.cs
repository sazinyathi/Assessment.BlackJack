namespace BlackJack.WebApi.Models
{
    public class WinningRules
    {
        public bool IsPlayerBlackJack { get; set; }
        public bool IsTie { get; set; }
        public bool IsDealerBlackJack { get; set; }
        public bool IsDealerBusts { get; set; }
        public bool IsPlayerBusts { get; set; }
        public bool IsPlayerCloseToBlackJack { get; set; }
        public bool IsDealerCloseToBlackJack { get; set; }
    }
}
