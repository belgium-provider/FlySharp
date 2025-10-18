using DotNetEnv;
using FlySharp.Client;
using FlySharp.Client.Abstract;
using FlySharp.Http.Account;
using FlySharp.Http.Customer;
using FlySharp.Models;

namespace FlySharp.Tester;

public class Program
{
    private const string PProviderUrl = "TO_SET";
    private const string PUsername = "TO_SET";
    
    public static async Task Main(string[] args)
    {
        Env.Load("./.env");
        
        //listing accounts
        await ListAccountsAsync();
        
        //listing customers
        await ListCustomersAsync();
    }
    
        /// <summary>
    /// Listing all customers.
    /// </summary>
    private static async Task ListCustomersAsync()
    {
        string? accountPwd = Environment.GetEnvironmentVariable("FLY_SIP_PASSWORD");
        if (string.IsNullOrEmpty(accountPwd))
            return;

        FlySipOptions options = InitOptions(accountPwd);
        using ICustomerClient client = new CustomerClient(options);
        GetCustomersResponse customers = await client.GetCustomersAsync(wholeSalerId:1);
        if (customers.Result != "OK")
        {
            Console.WriteLine("Failed to get customers");
            return;
        }

        foreach (Customer customer in customers.Customers)
        {
            Console.WriteLine($"Customer : {customer.Name} - {customer.Description}");
            
            //print other information.
        }
    }
    
    /// <summary>
    /// Listing all client accounts.
    /// </summary>
    private static async Task ListAccountsAsync()
    {
        string? accountPwd = Environment.GetEnvironmentVariable("FLY_SIP_PASSWORD");
        if (string.IsNullOrEmpty(accountPwd))
            return;

        FlySipOptions options = InitOptions(accountPwd);
        using IAccountClient client = new AccountClient(options);
        GetAccountsResponse accounts = await client.GetAccountsAsync();
        if (accounts.Result != "OK")
        {
            Console.WriteLine("Failed to get accounts");
            return;
        }

        foreach (Account account in accounts.Accounts)
        {
            Console.WriteLine($"Account : {account.Username}");
            
            //print other information.
        }
    }
    
    /// <summary>
    /// init a new FlySip options object
    /// </summary>
    /// <param name="accountPwd"></param>
    /// <returns></returns>
    private static FlySipOptions InitOptions(string accountPwd) => new FlySipOptions(){Password = accountPwd, ProviderUrl = PProviderUrl, Username = PUsername};
}
