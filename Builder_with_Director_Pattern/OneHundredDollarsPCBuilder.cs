public class OneHundredDollarsPCBuilder: IPCAssembler
{
    PC pc = new PC();


    public void GetCaseName()
    {
        pc.CaseName = " Zalman S2";
    }

    public void GetRAM()
    {
        pc.RAM = "16 GB OLOy";
    }

    public void GetGPU()
    {
        pc.GPU = "ASUS ROG RX 6600 XT";
    }

    public void GetCPU()
    {
        pc.CPU = "i5 - 11400F";
    }

    public void GetMotherboard()
    {
        pc.Motherboard = "MSI H510M-A";
    }

    public void GetHDD()
    {
        pc.HDD = "0";
    }

    public void GetSSD()
    {
        pc.SSD = "Samsung 1000 GB";
    }

    public void GetPSU()
    {
        pc.PSU = "EVGA 650 W";
    }

    public PC GetPC()
    {
        return pc;
    }
}