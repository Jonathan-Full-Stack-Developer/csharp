namespace FundamentosExemplo.Models
{
    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public void IntroduceYourself()
        {
            Console.WriteLine($"Hello, my name is {Name}, i'm {Age} old!");
        }
    }
}