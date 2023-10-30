namespace CCookbook.WebApp.Components.Main
{
    public partial class DishCard
    {
        public string Title { get; set; }

        public int PreparationTime {get;set;}

        public DishCard()
        {
            Title = "Spicy rice";
            PreparationTime = 120;
        }
    }
}
