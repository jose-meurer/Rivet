## Mapa de cobertura e limites

| Conceito | Onde será construído e verificado |
| --- | --- |
| Solução, projetos e pastas | P01; expansão somente nos passos que usam cada projeto |
| Entidades, relacionamentos, EF, migrations e seed | P02–P03 e P15 |
| Minimal APIs, contratos e validação | P01–P05, P15 e P18 |
| Redis e abstração de armazenamento | P11–P14 |
| gRPC, protobuf e código gerado | P11–P13 e P21 |
| Blazor, HTTP clients, SSR/streaming | P07–P10 e P12–P17 |
| OIDC, cookies, JWT e autorização por recurso | P10–P15 |
| Value Object, classe de enumeração e enum | P15, com C3 |
| Resiliência, idempotência e falhas parciais | P19–P21 |
| Rate limiting | P22 e revisão com escala em P28 |
| Telemetria, health e testes | Base em P06, verificação por entrega, consolidação P23–P24 |
| Containerização, deployment e operação | P25–P30 |

Escolhas deliberadas: não criar um `User` com senha local, um gateway de negócio, repository para cada entidade ou um serviço de domínio vazio. CRUD administrativo, mensageria/outbox, envio de e-mail, pagamento real, reserva de estoque, tratamento de todas as transições de `OrderStatus`, concorrência otimista completa de carrinho e troca de Keycloak por Entra ID podem virar planos de extensão depois da base. A limitação de concorrência do carrinho será demonstrada e documentada em P13, não omitida.

## Referências

Os links W fixam o código analisado; os links M são documentação Microsoft consultada pelo MCP. Conferir novamente versões, suporte, deployment e preços no passo de execução.

[W-src]: https://github.com/dotnet-presentations/eshop-app-workshop/tree/3fcdc98f1fcc6f808fd77fe612e39deca6859550/src
[W-lab1]: https://github.com/dotnet-presentations/eshop-app-workshop/blob/3fcdc98f1fcc6f808fd77fe612e39deca6859550/labs/1-Create-Catalog-API/README.md
[W-lab2]: https://github.com/dotnet-presentations/eshop-app-workshop/blob/3fcdc98f1fcc6f808fd77fe612e39deca6859550/labs/2-Create-Blazor-Frontend/README.md
[W-lab3]: https://github.com/dotnet-presentations/eshop-app-workshop/blob/3fcdc98f1fcc6f808fd77fe612e39deca6859550/labs/3-Add-Identity/README.md
[W-lab4]: https://github.com/dotnet-presentations/eshop-app-workshop/blob/3fcdc98f1fcc6f808fd77fe612e39deca6859550/labs/4-Add-Shopping-Basket/README.md
[W-lab5]: https://github.com/dotnet-presentations/eshop-app-workshop/blob/3fcdc98f1fcc6f808fd77fe612e39deca6859550/labs/5-Add-Checkout/README.md
[W-catalog-api]: https://github.com/dotnet-presentations/eshop-app-workshop/blob/3fcdc98f1fcc6f808fd77fe612e39deca6859550/src/Catalog.API/Apis/CatalogApi.cs
[W-apphost]: https://github.com/dotnet-presentations/eshop-app-workshop/blob/3fcdc98f1fcc6f808fd77fe612e39deca6859550/src/eShop.AppHost/Program.cs
[W-defaults]: https://github.com/dotnet-presentations/eshop-app-workshop/blob/3fcdc98f1fcc6f808fd77fe612e39deca6859550/src/eShop.ServiceDefaults/HostingExtensions.cs
[W-web]: https://github.com/dotnet-presentations/eshop-app-workshop/tree/3fcdc98f1fcc6f808fd77fe612e39deca6859550/src/WebApp
[W-web-hosting]: https://github.com/dotnet-presentations/eshop-app-workshop/blob/3fcdc98f1fcc6f808fd77fe612e39deca6859550/src/WebApp/Extensions/HostingExtensions.cs
[W-proto]: https://github.com/dotnet-presentations/eshop-app-workshop/blob/3fcdc98f1fcc6f808fd77fe612e39deca6859550/src/Basket.API/Proto/basket.proto
[W-basket]: https://github.com/dotnet-presentations/eshop-app-workshop/blob/3fcdc98f1fcc6f808fd77fe612e39deca6859550/src/Basket.API/Grpc/BasketService.cs
[W-store]: https://github.com/dotnet-presentations/eshop-app-workshop/blob/3fcdc98f1fcc6f808fd77fe612e39deca6859550/src/Basket.API/Storage/RedisBasketStore.cs
[W-basket-state]: https://github.com/dotnet-presentations/eshop-app-workshop/blob/3fcdc98f1fcc6f808fd77fe612e39deca6859550/src/WebApp/Services/BasketState.cs
[W-orders]: https://github.com/dotnet-presentations/eshop-app-workshop/blob/3fcdc98f1fcc6f808fd77fe612e39deca6859550/src/Ordering.API/Apis/OrdersApi.cs
[W-order-data]: https://github.com/dotnet-presentations/eshop-app-workshop/tree/3fcdc98f1fcc6f808fd77fe612e39deca6859550/src/Ordering.Data
[W-order-client]: https://github.com/dotnet-presentations/eshop-app-workshop/blob/3fcdc98f1fcc6f808fd77fe612e39deca6859550/src/WebApp/Services/OrderingService.cs
[W-test]: https://github.com/dotnet-presentations/eshop-app-workshop/blob/3fcdc98f1fcc6f808fd77fe612e39deca6859550/src/IntegrationTests/WebAppTests.cs
[W-tests-project]: https://github.com/dotnet-presentations/eshop-app-workshop/blob/3fcdc98f1fcc6f808fd77fe612e39deca6859550/src/IntegrationTests/IntegrationTests.csproj
[W-ci]: https://github.com/dotnet-presentations/eshop-app-workshop/blob/3fcdc98f1fcc6f808fd77fe612e39deca6859550/.github/workflows/ci.yml
[M-sln]: https://learn.microsoft.com/dotnet/core/tools/dotnet-sln
[M-api]: https://learn.microsoft.com/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-10.0
[M-model]: https://learn.microsoft.com/ef/core/modeling/
[M-context]: https://learn.microsoft.com/ef/core/dbcontext-configuration/
[M-relations]: https://learn.microsoft.com/ef/core/modeling/relationships
[M-migrations]: https://learn.microsoft.com/ef/core/managing-schemas/migrations/applying
[M-pagination]: https://learn.microsoft.com/ef/core/querying/pagination
[M-options]: https://learn.microsoft.com/dotnet/core/extensions/options
[M-otel]: https://learn.microsoft.com/dotnet/core/diagnostics/observability-with-otel
[M-render]: https://learn.microsoft.com/aspnet/core/blazor/components/render-modes?view=aspnetcore-10.0
[M-oidc]: https://learn.microsoft.com/aspnet/core/security/authentication/configure-oidc-web-authentication?view=aspnetcore-10.0
[M-jwt]: https://learn.microsoft.com/aspnet/core/security/authentication/configure-jwt-bearer-authentication?view=aspnetcore-10.0
[M-blazor-security]: https://learn.microsoft.com/aspnet/core/blazor/security/?view=aspnetcore-10.0
[M-grpc]: https://learn.microsoft.com/aspnet/core/grpc/?view=aspnetcore-10.0
[M-grpc-retries]: https://learn.microsoft.com/aspnet/core/grpc/retries?view=aspnetcore-10.0
[M-persistence]: https://learn.microsoft.com/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-design
[M-ddd]: https://learn.microsoft.com/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/ddd-oriented-microservice
[M-resilience]: https://learn.microsoft.com/dotnet/core/resilience/http-resilience
[M-rate]: https://learn.microsoft.com/aspnet/core/performance/rate-limit?view=aspnetcore-10.0
[M-rate-samples]: https://learn.microsoft.com/aspnet/core/performance/rate-limit-samples?view=aspnetcore-10.0
[M-middleware]: https://learn.microsoft.com/aspnet/core/fundamentals/middleware/?view=aspnetcore-10.0
[M-probes]: https://learn.microsoft.com/azure/container-apps/health-probes
[M-publish]: https://learn.microsoft.com/dotnet/core/deploying/
[M-connect]: https://learn.microsoft.com/azure/container-apps/connect-apps
[M-azd]: https://learn.microsoft.com/azure/developer/azure-developer-cli/
[M-postgres]: https://learn.microsoft.com/azure/postgresql/flexible-server/overview
[M-postgres-free]: https://learn.microsoft.com/azure/postgresql/configure-maintain/how-to-deploy-on-azure-free-account
[M-postgres-csharp]: https://learn.microsoft.com/azure/postgresql/connectivity/connect-csharp
[M-redis]: https://learn.microsoft.com/azure/redis/overview
[M-ingress]: https://learn.microsoft.com/azure/container-apps/ingress-how-to
[M-blazor-host]: https://learn.microsoft.com/aspnet/core/blazor/host-and-deploy/server/?view=aspnetcore-10.0#azure-container-apps
[M-aca-dotnet]: https://learn.microsoft.com/azure/container-apps/dotnet-overview
[M-revisions]: https://learn.microsoft.com/azure/container-apps/revisions
[M-budget]: https://learn.microsoft.com/azure/cost-management-billing/costs/tutorial-acm-create-budgets
[M-az900]: https://learn.microsoft.com/credentials/certifications/resources/study-guides/az-900
[M-aspire-tests]: https://learn.microsoft.com/dotnet/aspire/testing/overview
[M-aspire-aca]: https://learn.microsoft.com/dotnet/aspire/deployment/azure/aca-deployment
[M-down]: https://learn.microsoft.com/azure/developer/azure-developer-cli/reference#azd-down
[M-redis-operations]: https://learn.microsoft.com/azure/architecture/best-practices/caching#implement-caching-by-using-azure-managed-redis

## Arquitetura e diagramas

Desenho planejado; a existência dos diagramas não comprova implementação. Introduzir somente as partes pertinentes ao passo atual.

## Decisões e fronteiras

- Serviços por capacidade: catálogo, carrinho e pedidos. Blazor Web App é a interface. A composição local fica no Aspire AppHost.
- Catálogo e pedidos usam EF Core/PostgreSQL, com bancos lógicos separados. Carrinho usa Redis como seu armazenamento. Não existe FK nem leitura direta entre os bancos dos serviços.
- APIs HTTP em Minimal APIs, organizadas por funcionalidade. Carrinho em gRPC/protobuf. O frontend integra por clientes, sem referência aos projetos Data das APIs.
- Data contém entidades, contexto e mapeamentos; Data.Manager contém migrations e seed. Essa organização segue a referência e não representa uma Clean Architecture imposta a toda a solução.
- Keycloak mantém usuários e credenciais. Buyer é o cadastro local necessário ao pedido, associado ao subject externo; não é um emissor de tokens nem um usuário com senha local.
- As escolhas de versões e de hospedagem serão verificadas no passo correspondente. Blazor substitui o uso inicial de Razor Pages para seguir a referência; será estudado como tecnologia nova no plano.
- **Complementos identificados:** rate limiting, validações reforçadas, Ordering → Catalog para preço confiável, idempotência persistida, recuperação de falhas, testes ampliados e publicação Azure. O grafo final inclui esses complementos e indica quando entram.
- `PaymentMethod` será adaptado para referência fictícia de pagamento. O número/CVV presentes na entidade original são material para discussão, não dados que o Rivet deve coletar de pessoas.

## A1 — Serviços e armazenamento em execução

```mermaid
flowchart LR
    Browser["Navegador"] -->|HTTP e circuito quando interativo| Web["Rivet.WebApp"]
    Web -->|HTTP · catálogo| Catalog["Rivet.Catalog.API"]
    Web -->|HTTP · pedidos| Ordering["Rivet.Ordering.API"]
    Web -->|gRPC · HTTP/2| Basket["Rivet.Basket.API"]
    Catalog -->|EF Core| CDB[("CatalogDB · PostgreSQL")]
    Ordering -->|EF Core| ODB[("OrderingDB · PostgreSQL")]
    Basket -->|storage| Redis[("Redis · carrinhos")]
    Web -.->|OIDC| IdP["Keycloak"]
    Browser -->|tela de autenticação| IdP
    IdP -->|callback OIDC| Web
    Ordering -.->|HTTP · preço confiável a partir de P18| Catalog
    CM["Catalog.Data.Manager"] -->|migration e seed| CDB
    OM["Ordering.Data.Manager"] -->|migration e seed| ODB
```

As setas contínuas de serviços representam a comunicação de negócio. OIDC não implica consulta ao IdP em cada requisição; APIs validam access tokens do emissor configurado. As bases CatalogDB e OrderingDB podem compartilhar um servidor PostgreSQL local sem compartilhar propriedade dos dados.

O AppHost descreve e inicia recursos; não funciona como gateway no caminho do navegador. ServiceDefaults fornece configuração técnica, não uma API remota de negócio.

## A2 — Dependências de projetos

```mermaid
flowchart TD
    Host["Rivet.AppHost"] --> CA["Rivet.Catalog.API"]
    Host --> CM["Rivet.Catalog.Data.Manager"]
    Host --> BA["Rivet.Basket.API"]
    Host --> OA["Rivet.Ordering.API"]
    Host --> OM["Rivet.Ordering.Data.Manager"]
    Host --> Web["Rivet.WebApp"]
    CA --> CD["Rivet.Catalog.Data"]
    CM --> CD
    OA --> OD["Rivet.Ordering.Data"]
    OM --> OD
    CA --> SD["Rivet.ServiceDefaults"]
    CM --> SD
    BA --> SD
    OA --> SD
    OM --> SD
    Web --> SD
    Tests["Rivet.IntegrationTests"] --> Host
    Proto["Basket.API/Proto/basket.proto"] -.->|gera contrato e cliente| Web
```

Aqui as setas representam referências de projeto ou o vínculo explícito ao contrato, não tráfego de rede. WebApp não referencia Catalog.Data/Ordering.Data. A integração de preço adicionada em P18 também é HTTP: não cria ProjectReference de Ordering.Data para Catalog.Data.

`Shared` será uma pasta de helpers pequenos compilados pelos managers conforme necessário, como no exemplo; não é um projeto de entidades compartilhadas entre os serviços.

## A3 — Estrutura física planejada

As pastas abaixo serão criadas quando a entrega correspondente precisar delas. Nomes e organização interna podem ser refinados com uma justificativa registrada, preservando os IDs dos passos.

```text
Rivet/
├── Rivet.slnx
├── global.json
├── Directory.Build.props
├── .editorconfig                         # convenções do Rivet, quando definidas
├── .gitignore
├── AGENTS.md
├── docs/
│   └── PLANO-DE-DESENVOLVIMENTO.md
├── src/
│   ├── Rivet.AppHost/                    # P06; recursos evoluem por entrega
│   │   ├── Program.cs
│   │   └── KeycloakResource.cs           # P10, se necessário à integração atual
│   ├── Rivet.ServiceDefaults/            # P06; configuração técnica
│   │   ├── HostingExtensions.cs
│   │   ├── OpenApiExtensions.cs
│   │   ├── ConfigurationExtensions.cs
│   │   ├── ServiceDiscoveryExtensions.cs
│   │   ├── AuthenticationExtensions.cs   # P10/P11
│   │   ├── ClaimsPrincipalExtensions.cs
│   │   └── HttpClientExtensions.cs
│   ├── Rivet.Catalog.API/                # P01
│   │   ├── Program.cs
│   │   ├── Apis/CatalogApi.cs
│   │   ├── Extensions/HostingExtensions.cs
│   │   ├── Model/
│   │   │   ├── CatalogServices.cs
│   │   │   ├── PaginationRequest.cs
│   │   │   └── PaginatedItems.cs
│   │   ├── CatalogOptions.cs
│   │   └── Pics/
│   ├── Rivet.Catalog.Data/               # P02
│   │   ├── CatalogBrand.cs
│   │   ├── CatalogType.cs
│   │   ├── CatalogItem.cs
│   │   ├── CatalogDbContext.cs
│   │   └── EntityConfigurations/
│   ├── Rivet.Catalog.Data.Manager/       # P02
│   │   ├── Program.cs
│   │   ├── CatalogContextSeed.cs
│   │   └── Migrations/
│   ├── Rivet.WebApp/                     # P07
│   │   ├── Program.cs
│   │   ├── Extensions/
│   │   ├── Components/
│   │   │   ├── App.razor
│   │   │   ├── Routes.razor
│   │   │   ├── Layout/
│   │   │   ├── Catalog/                 # contratos e componentes do catálogo
│   │   │   ├── Item/
│   │   │   └── Pages/
│   │   │       ├── Catalog/
│   │   │       ├── Item/
│   │   │       ├── User/
│   │   │       ├── Cart/
│   │   │       └── Checkout/
│   │   ├── Services/
│   │   │   ├── CatalogService.cs
│   │   │   ├── IProductImageUrlProvider.cs
│   │   │   ├── ProductImageUrlProvider.cs
│   │   │   ├── LogOutService.cs
│   │   │   ├── BasketService.cs
│   │   │   ├── BasketState.cs
│   │   │   ├── BasketItem.cs
│   │   │   ├── BasketCheckoutInfo.cs
│   │   │   └── OrderingService.cs
│   │   └── wwwroot/
│   ├── Keycloak/data/import/             # P10; sem credenciais reais
│   ├── Rivet.Basket.API/                 # P11
│   │   ├── Program.cs
│   │   ├── Proto/basket.proto
│   │   ├── Grpc/BasketService.cs
│   │   ├── Model/
│   │   ├── Storage/IBasketStore.cs
│   │   ├── Storage/RedisBasketStore.cs
│   │   └── Extensions/
│   ├── Rivet.Ordering.API/               # P15
│   │   ├── Program.cs
│   │   ├── Apis/OrdersApi.cs
│   │   ├── Model/
│   │   ├── Services/IIdentityService.cs
│   │   ├── Services/IdentityService.cs
│   │   ├── Services/OrderCreationService.cs # somente se extraído em P18
│   │   └── Extensions/
│   ├── Rivet.Ordering.Data/              # P15
│   │   ├── Order.cs
│   │   ├── OrderItem.cs
│   │   ├── Buyer.cs
│   │   ├── Address.cs
│   │   ├── ValueObject.cs
│   │   ├── PaymentMethod.cs              # pagamento fictício adaptado
│   │   ├── CardType.cs
│   │   ├── Enumeration.cs
│   │   ├── OrderStatus.cs
│   │   ├── OrderingDbContext.cs
│   │   ├── OrderRequest.cs               # complemento P19
│   │   └── EntityConfigurations/
│   ├── Rivet.Ordering.Data.Manager/      # P15
│   │   ├── Program.cs
│   │   ├── OrderingDbContextSeed.cs
│   │   └── Migrations/
│   ├── Shared/
│   │   ├── MigrateDbContextExtensions.cs
│   │   └── ActivityExtensions.cs
│   └── Rivet.IntegrationTests/           # P06; acompanha novas entregas
│       ├── Infrastructure/
│       ├── WebAppTests.cs
│       └── testes por comportamento
└── .github/workflows/ci.yml              # P24
```

Cada diretório de projeto contém seu `.csproj` e configurações pertinentes, omitidos acima para facilitar a leitura. Arquivos de infraestrutura/deployment em P26 serão produzidos pelo mecanismo escolhido e revisados: não definir uma pasta `infra` ou manifestos fictícios antes de confirmar o fluxo atual.

### Contratos HTTP que devem existir ao final da base

Base do catálogo: `/api/v1/catalog`.

| Método e rota | Função | Passo |
| --- | --- | --- |
| `GET /catalogbrands` | Marcas | P02 |
| `GET /catalogtypes` | Tipos | P02 |
| `GET /items` | Lista paginada | P03 |
| `GET /items/{id:int}` | Detalhe | P03 |
| `GET /items/by?ids=1&ids=2` | Consulta por IDs | P04 |
| `GET /items/by/{name:minlength(1)}` | Prefixo de nome | P04 |
| `GET /items/type/{typeId}/brand/{brandId?}` | Tipo e marca opcional | P04 |
| `GET /items/type/all/brand/{brandId:int?}` | Marca | P04 |
| `GET /items/{catalogItemId:int}/pic` | Imagem | P05 |
| `POST /api/v1/orders/` | Criar pedido autenticado | P15; reforços P18/P19 |
| `GET /api/v1/orders/` | Pedidos da identidade corrente | P15 |

As duas últimas rotas já incluem a base de pedidos, não devem ser prefixadas com a base de catálogo. Rotas públicas web: `/`, `/item/{itemId:int}` e `/product-images/{id}`. Rotas de identidade: `/user/login`, `/user/logout`. Rotas web protegidas: `/cart`, `/checkout` e `/user/orders`.

O contrato de carrinho é gRPC: `package BasketApi`, serviço `Basket`, métodos `GetBasket`, `UpdateBasket`, `DeleteBasket`. Caminho completo de um método: `/BasketApi.Basket/GetBasket`. Mensagens de request/response são geradas do `.proto`; UpdateBasket recebe itens com `product_id` e `quantity`. Não passar um BuyerId arbitrário para selecionar o carrinho de outra pessoa.

Em P20, como complemento explícito, o contrato passa a transportar a versão do carrinho e a versão esperada na exclusão; o store compara e exclui atomicamente. O `.proto` original tem request de exclusão vazio, portanto essa evolução precisa ser explicada e testada no cliente e no servidor.

## C1 — Classes do catálogo

```mermaid
classDiagram
    class CatalogBrand {
        +int Id
        +string Brand
    }
    class CatalogType {
        +int Id
        +string Type
    }
    class CatalogItem {
        +int Id
        +string Name
        +string Description
        +decimal Price
        +string PictureFileName
        +string PictureUri
        +int CatalogBrandId
        +int CatalogTypeId
        +int AvailableStock
        +int RestockThreshold
        +int MaxStockThreshold
        +bool OnReorder
    }
    class CatalogDbContext {
        +CatalogItems
        +CatalogBrands
        +CatalogTypes
        +OnModelCreating()
    }
    class CatalogItemEntityTypeConfiguration {
        +Configure()
    }
    CatalogBrand "1" --> "0..*" CatalogItem : marca
    CatalogType "1" --> "0..*" CatalogItem : tipo
    CatalogDbContext --> CatalogItem
    CatalogDbContext --> CatalogItemEntityTypeConfiguration
```

O diagrama resume campos e relações; navegações e DbSets completos serão explicados ao criar cada classe. Na referência, FK não anulável define associação obrigatória, mesmo com navegação C# anotada como nullable. `PictureUri` é calculada e não persistida; `virtual` sozinho não ativa lazy loading. Os records de resposta da WebApp são tipos de transporte próprios, mesmo quando repetem nomes das entidades.

## C2 — Carrinho, armazenamento e clientes

```mermaid
classDiagram
    class CustomerBasket {
        +string BuyerId
        +List~BasketItem~ Items
        +string Version
    }
    class BasketItem {
        +int ProductId
        +int Quantity
        +Validate()
    }
    class IBasketStore {
        <<interface>>
        +GetBasketAsync(customerId)
        +UpdateBasketAsync(basket)
        +DeleteBasketAsync(customerId)
    }
    class RedisBasketStore {
        -IDatabase database
        +GetBasketAsync(customerId)
        +UpdateBasketAsync(basket)
        +DeleteBasketAsync(customerId)
    }
    class BasketGrpcService {
        +GetBasket()
        +UpdateBasket()
        +DeleteBasket()
    }
    class WebBasketService {
        +GetBasketAsync()
        +UpdateBasketAsync(items)
        +DeleteBasketAsync()
    }
    class BasketState {
        +GetBasketItemsAsync()
        +AddAsync(item)
        +SetQuantityAsync(productId,quantity)
        +NotifyOnChange(callback)
        +CheckoutAsync(info)
    }
    CustomerBasket "1" *-- "0..*" BasketItem
    RedisBasketStore ..|> IBasketStore
    BasketGrpcService --> IBasketStore
    WebBasketService ..> BasketGrpcService : gRPC
    BasketState --> WebBasketService
    BasketState ..> CatalogService : consulta detalhes
    BasketState ..> OrderingService : somente a partir de P16
```

`BasketGrpcService` e `WebBasketService` são rótulos explicativos do diagrama; no código da referência ambos se chamam `BasketService`, em namespaces diferentes. O contrato protobuf possui seu próprio `BasketItem` só com ID/quantidade. O modelo de storage da referência tem campos adicionais; o transporte e a interface não precisam compartilhar sua classe.

A chave Redis é por identidade, como `/basket/{subject}`. No exemplo, UpdateBasket substitui o documento inteiro e não configura versão/TTL. Isso pode perder atualizações simultâneas de abas; P13 demonstra a limitação e a registra. O campo `Version` será acrescentado em P20 para proteger a limpeza após checkout; isso não é um controle otimista completo de todas as atualizações.

## C3 — Pedidos e pagamento fictício

```mermaid
classDiagram
    class Buyer {
        +int Id
        +string IdentityGuid
        +string Name
    }
    class Order {
        +int Id
        +DateTime OrderDate
        +int BuyerId
        +int PaymentMethodId
        +OrderStatus OrderStatus
        +GetTotal() decimal
    }
    class OrderItem {
        +int Id
        +int ProductId
        +string ProductName
        +decimal UnitPrice
        +decimal Discount
        +int Units
        +int OrderId
    }
    class ValueObject {
        <<abstract>>
        +GetEqualityComponents()
    }
    class Address {
        +string Street
        +string City
        +string State
        +string Country
        +string ZipCode
    }
    class PaymentMethod {
        +int Id
        +string Alias
        +string DemoPaymentReference
        +int BuyerId
        +int CardTypeId
    }
    class Enumeration {
        <<abstract>>
        +int Id
        +string Name
    }
    class CardType {
        +Amex
        +Visa
        +MasterCard
    }
    class OrderStatus {
        <<enumeration>>
        Submitted
        AwaitingValidation
        StockConfirmed
        Paid
        Shipped
        Cancelled
    }
    ValueObject <|-- Address
    Enumeration <|-- CardType
    Buyer "1" --> "0..*" Order
    Buyer "1" --> "0..*" PaymentMethod
    Order "1" *-- "1..*" OrderItem
    Order "1" *-- "1" Address
    PaymentMethod "1" --> "0..*" Order
    CardType "1" --> "0..*" PaymentMethod
    Order --> OrderStatus
```

O diagrama é o **alvo do Rivet**, com pelo menos um item validado, associações obrigatórias no fluxo de criação e pagamento fictício adaptado. A referência permite coleção vazia e algumas FKs nullable; esses detalhes não serão copiados sem discussão.

`DemoPaymentReference` é complemento do Rivet em substituição aos campos sensíveis do original. `CardType` continua útil para estudar a classe de enumeração, sem representar uma autorização real de pagamento. O estado inicial do pedido é Submitted; não há motor de logística/cobrança que execute os demais estados automaticamente.

`OrderItem.ProductId` identifica um produto de outro contexto, mas não cria FK para CatalogDB. O pedido guarda o nome/preço confirmados no momento da compra. `Address` usa igualdade por valor e owned mapping. A estrutura não será chamada de agregado rico sem realmente proteger suas invariantes.

Contratos de entrada/saída: `CreateOrderRequest`, `OrderSummary` e o record web `OrderRecord`. `OrderServices` agrupa contexto e identidade; `IIdentityService` obtém a identidade do contexto autenticado.

## C4 — Identidade e contexto do usuário

```mermaid
flowchart LR
    User["Pessoa / usuário de estudo"] --> IdP["Keycloak · credenciais e subject"]
    IdP -->|login OIDC| Cookie["Sessão web · cookie"]
    IdP -->|access token| API["APIs · validação JWT"]
    Cookie --> State["AuthenticationStateProvider"]
    State --> UI["Componentes e ações autorizadas"]
    API --> Owner["Subject autenticado"]
    Owner --> Cart["Chave do carrinho"]
    Owner --> Buyer["Buyer.IdentityGuid"]
```

O token de acesso é enviado pelo cliente servidor para APIs, não utilizado como substituto do cookie em todas as interações do navegador. O armazenamento/propagação precisam respeitar SSR e circuito interativo: `HttpContext` não deve ser presumido válido em todo evento Blazor. Ocultar um botão não substitui autorização na API.

Microsoft Entra ID e identidade gerenciada Azure são assuntos relacionados de estudo, mas têm propósitos/configurações distintos. Trocar o IdP não é um requisito silencioso deste plano.

## C5 — Registro adicional de idempotência

```mermaid
classDiagram
    class OrderRequest {
        +string OwnerSubject
        +Guid RequestId
        +string RequestFingerprint
        +int OrderId
    }
    class Order {
        +int Id
        +DateTime OrderDate
    }
    OrderRequest "1" --> "1" Order : resultado confirmado
```

O diagrama representa um `Order` confirmado na transação. O registro de requisição é complemento de P19. Definir unicidade por identidade/chave e gravar associação/resultado atomicamente com o pedido. Durante processamento, a implementação pode precisar de campos/estados adicionais; isso será projetado e testado em P19.

O fingerprint usa uma representação canônica do conteúdo da solicitação. Uma repetição válida recupera o resultado original; não recalcula um novo pedido só porque o preço do catálogo mudou após a primeira confirmação. Duas requisições concorrentes precisam produzir um único resultado confirmado.

## F1 — Consulta de catálogo

```mermaid
sequenceDiagram
    actor User as Pessoa
    participant Web as WebApp
    participant Client as CatalogService
    participant API as Catalog.API
    participant DB as CatalogDB
    User->>Web: Abre catálogo com filtros e página
    Web->>Client: Solicita lista
    Client->>API: GET /api/v1/catalog/items ou rota filtrada
    API->>API: Valida parâmetros
    API->>DB: Consulta EF com filtro e ordem determinística
    DB-->>API: Contagem e itens da página
    API-->>Client: JSON ou erro HTTP explícito
    Client-->>Web: Contrato de leitura
    Web-->>User: Conteúdo, vazio ou erro
```

## F2 — Imagem de produto

```mermaid
sequenceDiagram
    participant Browser as Navegador
    participant Web as WebApp / YARP
    participant API as Catalog.API
    participant Files as Pics publicadas
    Browser->>Web: GET /product-images/42
    Web->>API: GET /api/v1/catalog/items/42/pic
    API->>API: Confere produto e caminho permitido
    API->>Files: Lê arquivo
    Files-->>API: Imagem
    API-->>Web: Bytes e content type
    Web-->>Browser: Imagem ou erro controlado
```

## F3 — Login e logout

```mermaid
sequenceDiagram
    actor User as Pessoa
    participant Web as WebApp
    participant IdP as Keycloak
    User->>Web: Abre /user/login
    Web-->>User: Challenge OIDC / redirecionamento
    User->>IdP: Autentica com usuário de estudo
    IdP-->>User: Retorno com authorization code
    User->>Web: Callback configurado
    Web->>IdP: Troca código por tokens
    IdP-->>Web: Tokens
    Web->>Web: Valida resposta e cria sessão
    Web-->>User: Cookie e retorno local permitido
    User->>Web: POST logout com antiforgery
    Web->>IdP: Encerra sessão conforme o fluxo OIDC
    Web-->>User: Sessão web encerrada
```

Detalhes como PKCE, proteção de estado/nonce, configuração de callbacks e transporte seguro serão explicados na implementação com a documentação da versão utilizada.

## F4 — Atualização do carrinho

```mermaid
sequenceDiagram
    actor User as Pessoa
    participant Web as WebApp / BasketState
    participant API as Basket.API gRPC
    participant Store as IBasketStore
    participant Redis as Redis
    participant Catalog as Catalog.API
    User->>Web: Adiciona produto ou altera quantidade
    Web->>API: UpdateBasket com itens e bearer token
    API->>API: Valida token, subject, IDs e quantidades
    API->>Store: Atualiza carrinho do subject autenticado
    Store->>Redis: Substitui documento do carrinho
    Redis-->>Store: Resultado
    Store-->>API: Carrinho persistido
    API-->>Web: Resposta gRPC
    Web->>Catalog: Consulta nomes, imagens e preços por IDs
    Catalog-->>Web: Detalhes atuais
    Web-->>User: Atualiza itens, totais e menu
```

Falhas precisam ser refletidas na interface; não atualizar o estado como se o write remoto tivesse funcionado. Apagar o carrinho é um RPC separado. Preços exibidos no carrinho não substituem a confirmação do servidor na criação do pedido.

## F5 — Checkout funcional e histórico

```mermaid
sequenceDiagram
    actor User as Pessoa
    participant Web as WebApp
    participant Orders as Ordering.API
    participant Catalog as Catalog.API
    participant DB as OrderingDB
    participant Basket as Basket.API
    User->>Web: Confirma compra fictícia
    Web->>Orders: POST /api/v1/orders com token e x-requestid
    Orders->>Orders: Valida identidade, endereço e itens
    opt Complemento de P18
        Orders->>Catalog: Confirma dados e preços por IDs
        Catalog-->>Orders: Valores confiáveis
    end
    Orders->>DB: Grava pedido e itens
    DB-->>Orders: Confirmação
    Orders-->>Web: Sucesso confirmado
    Web->>Basket: DeleteBasket autenticado e condicional em P20
    Basket-->>Web: Resultado da limpeza
    Web->>Orders: GET /api/v1/orders
    Orders->>DB: Consulta filtrada pela identidade
    DB-->>Orders: Pedidos do comprador
    Orders-->>Web: Resumo dos pedidos
    Web-->>User: Confirmação e histórico
```

Antes de P19/P20, o fluxo já precisa verificar o sucesso HTTP e preservar carrinho em falha do POST. P19 acrescenta deduplicação; P20 acrescenta recuperação explícita quando o pedido foi confirmado e a limpeza falhou.

## F6 — Repetição e falha parcial

```mermaid
sequenceDiagram
    participant Web as WebApp
    participant Orders as Ordering.API
    participant DB as OrderingDB
    participant Basket as Basket.API / Redis
    Web->>Orders: Criar pedido com chave K e conteúdo H
    Orders->>DB: Consulta identidade + K
    alt Chave reutilizada com outro conteúdo
        Orders-->>Web: Conflito controlado
        Web->>Web: Preserva carrinho e não executa limpeza
    else Conteúdo compatível
        alt Pedido já confirmado
            DB-->>Orders: Pedido original
            Orders-->>Web: Mesmo resultado
        else Primeira solicitação
            Orders->>DB: Transação com pedido e registro único de K
            DB-->>Orders: Commit confirmado
            Orders-->>Web: Pedido confirmado
        end
        Web->>Basket: Limpa somente se a versão esperada corresponder
        alt Carrinho alterado depois da compra
            Basket-->>Web: Conflito de versão, preserva carrinho
            Web->>Web: Informa pedido confirmado e carrinho alterado
        else Limpeza falha por indisponibilidade
            Basket-->>Web: Falha
            Web->>Web: Mantém resultado e sinaliza limpeza pendente
            Web->>Basket: Recupera limpeza com a mesma condição de versão
        else Limpeza funciona
            Basket-->>Web: Carrinho removido
        end
    end
```

O desenho não é uma transação distribuída. A unicidade em banco precisa ser testada sob concorrência, não apenas com duas requisições sequenciais. Após confirmação, uma falha de transporte não autoriza gerar outra chave e outro pedido automaticamente.

## F7 — Rate limiting HTTP

```mermaid
flowchart LR
    Request["Requisição HTTP"] --> Route["Routing"]
    Route --> Authn["Autenticação"]
    Authn --> Authz["Autorização quando exigida"]
    Authz --> Limit["Política e partição do rate limiter"]
    Limit --> Allowed{"Há permissão disponível?"}
    Allowed -->|sim| Endpoint["Endpoint HTTP"]
    Allowed -->|não| Rejected["429 · Retry-After se disponível"]
```

Este é um recorte do pipeline, não a lista completa de middleware. A política por endpoint exige routing anterior; partição por usuário depende de autenticação anterior. Configurar 429 explicitamente, pois o comportamento padrão não deve ser presumido. A escolha de fila/janela influencia o teste e a disponibilidade de Retry-After.

O limiter local mantém estado por processo/réplica. Quando houver escala, explicar essa fronteira; uma quota global pode exigir outro desenho. Rejeição de RPC gRPC é assunto separado, com semântica de status própria.

## A4 — Alvo de publicação no Azure

```mermaid
flowchart TB
    Browser["Navegador"] -->|HTTPS| Web["Container App · WebApp"]
    Browser -->|HTTPS · login| IdP["Container App · Keycloak"]
    subgraph Environment["Ambiente Azure Container Apps"]
        IdP
        Web -->|HTTP interno| Catalog["Catalog.API"]
        Web -->|HTTP interno| Orders["Ordering.API"]
        Web -->|HTTP/2 interno · gRPC| Basket["Basket.API"]
        Orders -.->|Complemento P18| Catalog
    end
    Catalog --> CDB[("CatalogDB")]
    Orders --> ODB[("OrderingDB")]
    PG["Azure Database for PostgreSQL · avaliar configuração"] --- CDB
    PG --- ODB
    Basket --> Redis[("Azure Managed Redis · avaliar configuração")]
    IdP --> IdPData["Persistência própria do IdP · definir em P26"]
    Jobs["Migrations controladas · jobs ou outro fluxo validado"] --> CDB
    Jobs --> ODB
    Registry["Registry de imagens"] -.->|deploy| Environment
    Environment -.->|logs, métricas e traces| Monitor["Monitoramento configurado"]
```

É um **alvo sujeito à validação em P26**, não um conjunto de recursos já provisionados. Componentes do IdP também precisam de configuração de rede/ambiente adequada. Container Apps é a opção planejada para estudar a composição; escolhas de SKU, região e mecanismo de deploy dependem da disponibilidade e das condições atuais.

Web/IdP precisam ser alcançados pelo navegador nos fluxos previstos. As APIs podem usar ingress interno. Basket exige HTTP/2; não basta presumir que qualquer ingress atende gRPC. Evitar `localhost` como endereço entre containers.

Assets do catálogo serão inicialmente publicados na imagem da API, com acesso consistente em todas as réplicas. Armazenamento Blob pode ser uma extensão de estudo futura; não é um serviço presente no workshop que precisa ser inventado agora.

Planejar antes de escalar: Data Protection, session affinity do Interactive Server quando aplicável, persistência do Keycloak, TLS, issuer público, segredos/conexões, readiness e migrations. O AppHost não é publicado como um servidor que precisa encaminhar todas as requisições da aplicação.

## Relação com a AZ-900

| Prática | Conceitos que vamos relacionar |
| --- | --- |
| Containers locais e ACA | Opções de computação e modelo de responsabilidade |
| Serviços com dados separados | Recursos, rede, endpoints e responsabilidade pelos dados |
| PostgreSQL/Redis gerenciados | Serviços gerenciados, disponibilidade e fatores de custo |
| Login e acesso às APIs | Identidade, autenticação e autorização; comparar com Entra sem trocar o IdP automaticamente |
| Telemetria e probes | Monitoramento e diagnóstico; comparação com Azure Monitor/Application Insights |
| IaC e ciclo de implantação | Resource Manager, grupos de recursos, governança e ferramentas de gerenciamento |
| Escala, revisão e remoção | Escalabilidade, confiabilidade, custos, tags e ciclo de vida |

Implementar esses recursos aprofunda desenvolvimento além do escopo conceitual da certificação. Os tópicos restantes da AZ-900 continuarão no Microsoft Learn, conforme o [guia oficial](https://learn.microsoft.com/credentials/certifications/resources/study-guides/az-900).
