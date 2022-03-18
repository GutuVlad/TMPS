public interface IPCAssembler
{
    void GetRAM();
    void GetGPU();
    void GetCPU();
    void GetMotherboard();
    void GetHDD();
    void GetSSD();
    void GetPSU();
    void GetCaseName();

    PC GetPC();
}