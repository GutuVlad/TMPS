public class TwoHundredDollarasPCBuilder : IPCAssembler
{
    PC pc = new PC();


    public void GetCaseName()
    {
        pc.CaseName = " Pure Base 500DC Black";
    }

    public void GetRAM()
    {
        pc.RAM = "16 GB Corsair Vengeance RGB Pro";
    }

    public void GetGPU()
    {
        pc.GPU = "Zotac GeForce RTX 3070 Ti Holoblack";
    }

    public void GetCPU()
    {
        pc.CPU = "AMD Ryzen 5 5600X";
    }

    public void GetMotherboard()
    {
        pc.Motherboard = "Gigabyte B550 AORUS Elite AX V2";
    }

    public void GetHDD()
    {
        pc.HDD = "Western Digital 1000 GB";
    }

    public void GetSSD()
    {
        pc.SSD = "Samsung 980 1000 GB";
    }

    public void GetPSU()
    {
        pc.PSU = "Corsair RM750x 750 W";
    }

    public PC GetPC()
    {
        return pc;
    }
}