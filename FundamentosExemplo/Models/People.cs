namespace FundamentosExemplo.Models
{
    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        DateTime data_today = DateTime.Now;
        DateTime data_after = DateTime.Now.AddDays(5);
        string data = DateTime.Now.ToString("dd/MM/yyyy");
        string time = DateTime.Now.ToString("HH:mm");

        public void IntroduceYourself()
        {
            Console.WriteLine($"\nHello, my name is {Name}, I'm {Age} years old!\nYou are executing this code on {data_today}.\nIf you add 5 days, the date will be {data_after}.\nBut if you prefer just the date then {data}.\nOr if you need the time, then {time}.\n");
        }
    }
}
