public class PC
{
    public string RAM { get; set; }
    public string GPU { get; set; }
    public string CPU { get; set; }
    public string Motherboard { get; set; }
    public string HDD { get; set; }
    public string SSD { get; set; }
    public string PSU { get; set; }
    public string CaseName { get; set; }




    public void ShowSpecs()
    {
        Console.WriteLine("Case Name: {0}", CaseName);
        Console.WriteLine("Motherboard: {0}", Motherboard);
        Console.WriteLine("GPU: {0}", GPU);
        Console.WriteLine("CPU: {0}", CPU);
        Console.WriteLine("RAM: {0}", RAM);
        Console.WriteLine("HDD: {0}", HDD);
        Console.WriteLine("SSD: {0}", SSD);
        Console.WriteLine("PSU: {0}", PSU);

    }
}