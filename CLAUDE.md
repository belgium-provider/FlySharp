# FlySharp — Claude Code Guide

## Project overview

FlySharp is a C# SDK (NuGet package) wrapping the FlySIP XML-RPC API. It is used by Belgium-Provider to integrate FlySIP VOIP services. The SDK targets **net8.0** and is currently at **v1.0.5**.

## Official FlySip XML RPC api documentation : 

https://support.flysip.com/en/xml-rpc-rest-api

## Solution layout

```
FlySharp/
├── Client/               # One client class per FlySIP domain; all extend BaseClient
│   └── Abstract/         # IXxxClient interfaces
├── Builder/              # Fluent request builders for list endpoints
│   └── Abstract/         # Generic BaseListRequestBuilder<TRequest, TBuilder>
├── Http/                 # Request / Response DTOs grouped by domain
│   ├── Account/
│   ├── Customer/
│   ├── Tariff/
│   └── Payments/
├── Models/               # Plain domain models (Account, Customer, Tariff, …)
└── artifacts/            # Output .nupkg files

FlySharp.Tester/          # Console integration tester (not shipped)
```

## Architecture rules

### Adding a new FlySIP domain (e.g. `Invoice`)

1. **Interface** — `Client/Abstract/IInvoiceClient.cs` extends `IBaseClient`
2. **Client** — `Client/InvoiceClient.cs` extends `BaseClient`, implements the interface
3. **Request/Response DTOs** — under `Http/Invoice/Request/` and `Http/Invoice/Response/`
4. **Builder** (if list endpoint) — `Builder/ListInvoicesRequestBuilder.cs` extends `BaseListRequestBuilder<GetInvoicesRequest, ListInvoicesRequestBuilder>`
5. All calls go through `CallAsync<T>(string method, object? parameters)` on `BaseClient`

### Key conventions

- JSON property names use snake_case matching the FlySIP API exactly — always use `[JsonProperty("...")]`
- `BaseResponse.Result == "OK"` is the success signal; any other value is an error message
- List endpoints inherit `BaseListRequestObject` for `offset`/`limit` pagination
- Async methods follow `VerbNounAsync` naming (e.g. `GetAccountByIdAsync`)

## Build & release

```bash
# Build SDK and produce .nupkg in FlySharp/artifacts/
bash FlySharp/build-packet.sh

# Run integration tester (requires FlySharp.Tester/.env)
cd FlySharp.Tester && dotnet run
```

**Release:** bump `<Version>` in `FlySharp/FlySharp.csproj`, then push a `vX.Y.Z` tag — CI builds, packs, and publishes to NuGet.org automatically.

## Active skills

Always apply these skills without being asked:

| Skill | When |
|---|---|
| `csharp-coding-standards` | Any new or refactored C# code |
| `git` | Every commit message or branch name |

## Commits & branches

Follow `.claude/skills/git/SKILL.md` for all commit messages and branch naming. Always invoke `/commit` to generate commits.

## Safety

A pre-tool-use Bash hook (`validate-bash-dotnet.sh`) blocks destructive commands (`rm`, SQL deletes, `sudo`) and warns on `git push`/`reset`/`rebase`. Do not bypass it.
