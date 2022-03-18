class Program
{
    static void Main(string[] args)
    {
        var PCAssembler = new PCAssembler(new OneHundredDollarsPCBuilder());
        PCAssembler.CreatePC();
        var PC = PCAssembler.GetPC();
        PC.ShowSpecs();

        Console.WriteLine("---------------------------------------------");

        PCAssembler = new PCAssembler(new TwoHundredDollarasPCBuilder());
        PCAssembler.CreatePC();
        PC = PCAssembler.GetPC();
        PC.ShowSpecs();

        Console.WriteLine("---------------------------------------------");

        PCAssembler = new PCAssembler(new FiveHundredDollarasPCBuilder());
        PCAssembler.CreatePC();
        PC = PCAssembler.GetPC();
        PC.ShowSpecs();

        Console.ReadKey();
    }
}