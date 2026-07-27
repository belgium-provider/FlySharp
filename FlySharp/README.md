```
                              ________      _____ __
                             / ____/ /_  __/ ___// /_  ____ __________
                            / /_  / / / / /\__ \/ __ \/ __ `/ ___/ __ \
                           / __/ / / /_/ /___/ / / / / /_/ / /  / /_/ /
                          /_/   /_/\__, //____/_/ /_/\__,_/_/  / .___/
                                  /____/                      /_/

                                   ----- FlySIP C# SDK -----
```

![NuGet Version](https://img.shields.io/nuget/v/FlySharp?label=NuGet)
![NuGet Downloads](https://img.shields.io/nuget/dt/FlySharp)
![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4)
![MIT License](https://img.shields.io/badge/license-MIT-green)

**FlySharp** is a strongly-typed C# SDK for the [FlySIP](https://flysip.com/) XML-RPC API. It wraps VoIP billing/provisioning operations — accounts, customers, trunks, DIDs, tariffs and payments — behind a clean, async, dependency-free client surface, so you don't have to hand-roll XML-RPC calls and response parsing.

Built and maintained by [Belgium-Provider](https://github.com/belgium-provider) to power its own FlySIP integrations.

> This project started as an internal base library for Belgium-Provider's own tooling. It's shared as-is — feel free to use it, fork it, or build on top of it for your own FlySIP integration.

## Features

| Domain | Client | Covers |
|---|---|---|
| Accounts | `AccountClient` | Create/get/list/block/unblock/delete accounts, reset password, minute plans & rates |
| Trunks | `AccountClient` | Create/update/delete/get/list trunks |
| Trunk Connections | `AccountClient` | Create/update/delete/get/list trunk connections |
| Customers | `CustomerClient` | Create/update/delete/get/list/block/unblock customers, self-care auth |
| DIDs | `DidClient` | Add/update/delete/get/list DIDs, charging groups, delegations |
| Tariffs | `TariffClient` | Create/update/delete/get/list tariffs and their rates |
| Payments | `PaymentClient` | Add funds to accounts, customers, and vendors |

Every client targets .NET 10, exposes a matching interface (`IAccountClient`, `ICustomerClient`, ...) for DI and testing, implements `IDisposable`, and follows a consistent `VerbNounAsync` naming convention across the whole API surface.

## Installation

```
dotnet add package FlySharp
```

## Quickstart

```csharp
using FlySharp;
using FlySharp.Builder;
using FlySharp.Client;
using FlySharp.Client.Abstract;
using FlySharp.Http.Account.Request;
using FlySharp.Http.Account.Response;

// Credentials for your FlySIP reseller/admin account
var options = new FlySipOptions(
    providerUrl: "https://your-reseller.flysip.net",
    username: "admin",
    password: "your-api-password"
);

using IAccountClient accountClient = new AccountClient(options);

GetAccountsRequest request = new ListAccountsRequestBuilder()
    .WithCustomerId(42)
    .SetLimit(50)
    .Build();

GetAccountsResponse response = await accountClient.GetAccountsAsync(request);

if (response.Result != "OK")
{
    Console.WriteLine($"Error: {response.Result}");
    return;
}

foreach (var account in response.Accounts)
    Console.WriteLine($"{account.Username} — balance: {account.Balance} {account.BaseCurrency}");
```

Every domain follows the same pattern: instantiate the client with `FlySipOptions`, build a request (directly or through a fluent `*RequestBuilder` for list endpoints), await the call, and check `Result == "OK"`.

## Project structure

```
FlySharp/
  Client/       One client class per FlySIP domain; all extend BaseClient
    Abstract/   IXxxClient interfaces for DI/testing
  Builder/      Fluent request builders for list endpoints
    Abstract/   Generic BaseListRequestBuilder<TRequest, TBuilder>
  Http/         Request / Response DTOs grouped by domain (Account, Customer, Tariff, Did, Trunk, Payments)
  Models/       Plain domain models (Account, Customer, Tariff, Did, Trunk, ...)
```

All XML-RPC calls funnel through a single `BaseClient.CallAsync<T>(method, parameters)`, which handles endpoint construction, snake_case JSON (de)serialization, and error normalization — every response inherits from `BaseResponse` and exposes a `Result` string.

## Domain reference

### AccountClient — accounts, trunks, trunk connections, minute plans

```csharp
using IAccountClient client = new AccountClient(options);
```

| Method | FlySIP action |
|---|---|
| `CreateAccountAsync` | `createAccount` |
| `GetAccountByIdAsync` / `GetAccountByUsernameAsync` | `getAccountInfo` |
| `GetAccountsAsync` | `listAccounts` |
| `DeleteAccountAsync` / `BlockAccountAsync` / `UnblockAccountAsync` | `deleteAccount` / `blockAccount` / `unblockAccount` |
| `ResetAccountPwdAsync` | `resetAccountOneTimePassword` |
| `CreateTrunkAsync` / `UpdateTrunkAsync` / `DeleteTrunkAsync` / `GetTrunkAsync` / `GetTrunksAsync` | `createTrunk` / `updateTrunk` / `deleteTrunk` / `getTrunkInfo` / `getTrunksList` |
| `CreateTrunkConnectionAsync` / `UpdateTrunkConnectionAsync` / `DeleteTrunkConnectionAsync` / `GetTrunkConnectionAsync` / `GetTrunkConnectionsAsync` | `createTrunkConnection` / `updateTrunkConnection` / `deleteTrunkConnection` / `getTrunkConnectionInfo` / `getTrunkConnectionsList` |
| `GetAccountMinutePlanByIdAsync` | `getAccountMinutePlans` |
| `GetAccountRatesByIdAsync` | `getAccountRates` |

### CustomerClient — customer/reseller management

```csharp
using ICustomerClient client = new CustomerClient(options);
```

| Method | FlySIP action |
|---|---|
| `AddCustomerAsync` | `createCustomer` |
| `GetCustomerByIdAsync` / `GetCustomersAsync` | `getCustomerInfo` / `listCustomers` |
| `UpdateCustomerAsync` | `updateCustomer` |
| `DeleteCustomerAsync` | `deleteCustomer` |
| `BlockCustomerAsync` / `UnblockCustomerAsync` | `blockCustomer` / `unblockCustomer` |
| `AuthCustomerAsync` | `authCustomer` (self-care login) |

### DidClient — DID numbers, charging groups, delegations

```csharp
using IDidClient client = new DidClient(options);
```

| Method | FlySIP action |
|---|---|
| `AddDidAsync` / `UpdateDidAsync` | `addDID` / `updateDID` |
| `DeleteDidByIdAsync` / `DeleteDidByNumberAsync` | `deleteDID` |
| `GetDidByIdAsync` / `GetDidByNumberAsync` / `GetDidsAsync` | `getDIDInfo` / `getDIDsList` |
| `GetDidChargingGroupInfoAsync` | `getDIDChargingGroupInfo` |
| `AddDidDelegationAsync` / `UpdateDidDelegationAsync` / `DeleteDidDelegationAsync` | `addDIDDelegation` / `updateDIDDelegation` / `deleteDIDDelegation` |

`ListDidsRequestBuilder` supports fluent filters, including `.NotAssignedOnly()` for unassigned DID lookups.

### TariffClient — tariffs and rates

```csharp
using ITariffClient client = new TariffClient(options);
```

| Method | FlySIP action |
|---|---|
| `CreateTariffAsync` / `UpdateTariffAsync` | `createTariff` / `updateTariff` |
| `DeleteTariffAsync` / `GetTariffAsync` / `GetTariffsAsync` | `deleteTariff` / `getTariffInfo` / `getTariffsList` |
| `GetTariffRatesAsync` | `getTariffRatesList` |

Note: `currency` and `i_tariff_type` cannot be changed after a tariff is created (FlySIP restriction), so `UpdateTariffRequest` intentionally omits them.

### PaymentClient — manual fund adjustments

```csharp
using IPaymentClient client = new PaymentClient(options);
```

| Method | FlySIP action |
|---|---|
| `AddAccountFundsAsync` | `accountAddFunds` |
| `AddCustomerFundsAsync` | `customerAddFunds` |
| `AddVendorFundsAsync` | `vendorAddFunds` |

## Error handling

FlySharp doesn't throw on API-level errors — it normalizes them. Every response inherits from `BaseResponse`:

```csharp
public class BaseResponse
{
    public string Result { get; set; } = "OK";
}
```

`Result == "OK"` means success; any other value is the error message returned by (or synthesized from) the FlySIP API. Always check `Result` before reading the rest of the response:

```csharp
var response = await client.CreateAccountAsync(request);
if (response.Result != "OK")
{
    // handle/log response.Result
    return;
}
```

## Requirements

- .NET 10.0 SDK or later
- A FlySIP reseller/admin account (providerUrl, username, password)

## Resources

- Official FlySIP XML-RPC API documentation: https://support.flysip.com/en/xml-rpc-rest-api
- Source & issues: https://github.com/belgium-provider/FlySharp

## License

MIT
