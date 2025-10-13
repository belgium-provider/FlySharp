```

                              ________      _____ __                   
                             / ____/ /_  __/ ___// /_  ____ __________ 
                            / /_  / / / / /\__ \/ __ \/ __ `/ ___/ __ \
                           / __/ / / /_/ /___/ / / / / /_/ / /  / /_/ /
                          /_/   /_/\__, //____/_/ /_/\__,_/_/  / .___/ 
                                  /____/                      /_/      

                                   ----- FlySIP C# SDK -----

```

FlySharp is a base C# SDK aiming to facilitate FlySIP api integration into Belgium-Provider VOIP solutions using FlySIP as voip service.

>[!Important]
>This project was developped as a base lib to other tools and is based on my personnal needs. Feel free to use it as a base for your own work.

## Project Struct

- **CLIENT** : contains all "logical" business layers in the FlySIP api like account management, customer management, minutes plans managements etc. All class are using XmlRpcClient.
- **HTTP** : due to high differences in response based on the business layer, we have create a dedicated HTTP folder containing Responses & Requests objects.
- **MODELS** : base models used in requests & responses like Account, Customer, MinutePlan, Rates etc.

---

## Official doc

You can consul the official FlySIP xmlrpc api documentation here : <a href="https://support.flysip.com/en/xml-rpc-rest-api" targat="_blank">OFFICIAL DOCUMENTATION</a>
