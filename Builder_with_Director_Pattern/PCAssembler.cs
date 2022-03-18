public class PCAssembler
{
    private readonly IPCAssembler PC;

    public PCAssembler(IPCAssembler builder)
    {
        PC = builder;
    }

    public void CreatePC()
    {
      PC.GetRAM();
      PC.GetGPU();
      PC.GetCPU();
      PC.GetMotherboard();
      PC.GetHDD();
      PC.GetSSD();
      PC.GetPSU();
      PC.GetCaseName();
    }

    public PC GetPC()
    {
        return PC.GetPC();
    }
}