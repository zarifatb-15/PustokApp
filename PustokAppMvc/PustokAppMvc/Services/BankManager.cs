namespace PustokAppMvc.Services;

public class BankManager(BankService bankService)
{
    public int ManagerBalance=> bankService.Balance;
    public void Add()
    {
        bankService.Add();
    }
}