namespace Monopoly
{
    class PropertyCell : Cell
    {
        public string Label { get; set; }
        public Player Owner { get; set; }
        public double Price { get; set; }
        public double Rent { get; set; }

        public override void PlayerStepped(Player player)
        {
            base.PlayerStepped(player);
            //если есть владелец и игрок им не является
            //взыскать ренту
            //иначе
            //предоставить доступ
        }
    }
}
