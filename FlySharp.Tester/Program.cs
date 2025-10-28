using DotNetEnv;
using FlySharp.Builder;
using FlySharp.Client;
using FlySharp.Client.Abstract;
using FlySharp.Http.Account.Request;
using FlySharp.Http.Account.Response;
using FlySharp.Http.Customer.Request;
using FlySharp.Http.Customer.Response;
using FlySharp.Models;

namespace FlySharp.Tester;

public class Program
{
    private const string PProviderUrl = "https://switch1.belgium-voip.com";
    private const string PUsername = "admin";
    
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
        GetCustomersRequest request = new ListCustomersRequestBuilder(wholeSaler: 1).Build();
        GetCustomersResponse customers = await client.GetCustomersAsync(request);
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
        GetAccountsRequest request = new ListAccountsRequestBuilder().Build();
        GetAccountsResponse accounts = await client.GetAccountsAsync(request);
        if (accounts.Result != "OK")
        {
            Console.WriteLine(accounts.Result);
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
    private static FlySipOptions InitOptions(string accountPwd) => new FlySipOptions(PProviderUrl, PUsername, accountPwd);
}
