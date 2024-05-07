namespace BackToFrontDb.Controllers
{
    public class HomeController : Controller
    {
        //AppDbContext _dbContext;
        //public HomeController(AppDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}
        public IActionResult Index()
        {
            Slider slider = new Slider
            {
                Description= "Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. ",
                Title= "HTML Template 1",
                BackGorundImg="/path/to/your/backImg-1.png"
            };
            Slider slider2 = new Slider
            {
                Description = "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. ",
                Title="HTML Template-2",
                BackGorundImg = "/path/to/your/backImg-2.png"
            };
            Work work = new Work
            {
                Title = "Social media",
                Description = "Instagram,Twitter,Facebook",
                BackGorundImg = "social-media.png"
            };
            Work work2 = new Work
            {
                Title= "Web Marketing",
                Description = " The generated Lorem Ipsum.",
                BackGorundImg = "web-marketing.png"
            };

            Work work3 = new Work
            {
                Title = "R&D",
                Description = "Lorem ipsum dolor sit amet. ",
                BackGorundImg = "r&d.png"
            };
            Work work4 = new Work
            {
                Title = "Public Relation",
                Description = "Lorem ipsum dolor. ",
                BackGorundImg = "watch.png"
            };
            Work work5 = new Work
            {
                Title = "Branding",
                Description = "Cupidatat non proident.",
                BackGorundImg = "branding.png"
            };
            Work work6 = new Work
            {
                Title = "Creative Design",
                Description = "UI/UX Design",
                BackGorundImg = "design.png"
            };

            Card card1 = new Card
            {
                Title = "UI/UX design",
                Description = "Design for you",
                ImageUrl = "services-01.jpg",
                Category = "ui branding"
            };
            Card card2 = new Card
            {
                Title = "Social media",
                Description= "Instagram",
                ImageUrl = "services-02.jpg",
                Category = "ui graphic"
            };
            Card card3 = new Card 
            {
                Title = "Marketing",
                Description = "Marketing cources for you",
                ImageUrl = "services-03.jpg",
                Category = "branding"
            };
            Card card4 = new Card
            {
                Title = "Graphic",
                Description = "Graphic design",
                ImageUrl = "services-04.jpg",
                Category = "ui graphic"
            };
            Card card5 = new Card
            {
                Title = "Digital Marketing",
                Description="SMM Cources",
                ImageUrl = "services-05.jpg",
                Category = "ui graphic"
            };
            Card card6 = new Card
            {
                Title = "Market Research",
                Description = "Vegetables and fruits",
                ImageUrl = "services-06.jpg",
                Category = "branding"
            };
            Card card7 = new Card
            {
                Title = "Business",
                Description = "Business school",
                ImageUrl = "services-07.jpg",
                Category = "branding"
            };
            Card card8 = new Card
            {
                Title = "Branding",
                Description= "Architecture",
                ImageUrl = "services-08.jpg",
                Category = "ui graphic branding"
            };
            List<Card> cards = new List<Card>();
            cards.Add(card1);
            cards.Add(card2);
            cards.Add(card3);
            cards.Add(card4);
            cards.Add(card5);
            cards.Add(card6);
            cards.Add(card7);
            cards.Add(card8);



            List<Slider> sliders = new List<Slider>();
            sliders.Add(slider);
            sliders.Add(slider2);

            List<Work> works = new List<Work>();
            works.Add(work);
            works.Add(work2);
            works.Add(work3);
            works.Add(work4);
            works.Add(work5);
            works.Add(work6);

            HomeVM homeVM = new HomeVM();
            homeVM.Works = works;
            homeVM.Sliders = sliders;
            homeVM.Cards = cards;


            //_dbContext.Sliders.Add(slider);
            //_dbContext.Sliders.Add(slider2);
            //_dbContext.Works.Add(work);
            //_dbContext.Works.Add(work2);
            //_dbContext.Works.Add(work3);
            //_dbContext.Works.Add(work4);
            //_dbContext.Works.Add(work5);
            //_dbContext.Works.Add(work6);
            //_dbContext.SaveChanges();

           
            return View(homeVM);
        }
    }
}
