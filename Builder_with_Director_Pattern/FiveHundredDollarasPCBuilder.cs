public class FiveHundredDollarasPCBuilder : IPCAssembler
{
    PC pc = new PC();


    public void GetCaseName()
    {
        pc.CaseName = "Cooler Master MasterCase H500M";
    }

    public void GetRAM()
    {
        pc.RAM = " 64 GB Corsair Vengeance RGB Pro";
    }

    public void GetGPU()
    {
        pc.GPU = "MSI Gaming GeForce RTX 3090 Gaming X Trio";
    }

    public void GetCPU()
    {
        pc.CPU = "AMD Ryzen 9 5950X";
    }

    public void GetMotherboard()
    {
        pc.Motherboard = "Gigabyte X570 AORUS XTREME";
    }

    public void GetHDD()
    {
        pc.HDD = "0";
    }

    public void GetSSD()
    {
        pc.SSD = "Samsung 970 EVo 2000 GB";
    }

    public void GetPSU()
    {
        pc.PSU = "EVGA Supernova P2 1000W";
    }

    public PC GetPC()
    {
        return pc;
    }
}