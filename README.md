# Padrão Composite — exemplo com funcionários

Este repositório é um projeto de estudo do padrão de projeto **Composite** (ou **Composto**), usando uma estrutura de funcionários e liderados para representar uma hierarquia.

## O que é o Composite?

O Composite permite organizar objetos em uma estrutura de árvore e tratar objetos individuais e grupos por meio de uma interface comum. Assim, o código cliente pode trabalhar com o tipo comum sem precisar conhecer a estrutura concreta de cada elemento.

Neste exemplo, tanto um funcionário individual quanto um grupo de funcionários são tratados como `Funcionario`.

## Como o padrão aparece no projeto

- **`Funcionario` — Component:** classe abstrata que define a interface comum. Declara `Operation()` e os métodos de gerenciamento `Add()`, `Remove()` e `Get()`.
- **`FuncionarioLeaf` — Leaf:** representa um funcionário individual. Implementa `Operation()` e não possui filhos.
- **`FuncionarioComposite` — Composite:** representa um funcionário que lidera outros. Armazena uma lista de objetos `Funcionario` e implementa as operações para adicionar, remover e obter liderados.
- **`Program.cs` — cliente:** monta a estrutura e chama operações nos objetos.

Os métodos `Add()`, `Remove()` e `Get()` da classe base lançam `NotImplementedException`. Eles são implementados pelo Composite; a folha não oferece gerenciamento de filhos.

## Estrutura criada pelo exemplo

O programa monta esta hierarquia:

```text
Bill Gate
├── Steve Jobs
├── Jeff Bezos
└── Elon Musk
    ├── Gabriel
    └── Pedro
```

Embora `FuncionarioComposite` permita armazenar filhos de qualquer tipo `Funcionario`, inclusive outros composites, a implementação atual de `Operation()` mostra apenas os nomes dos liderados diretos. Por isso, a operação de `Bill Gate` inclui `Elon Musk`, mas não expande `Gabriel` e `Pedro`; a chamada separada em `Elon Musk` exibe os liderados dele. `FuncionarioLeaf.Operation()` retorna `"Leaf"` e não é chamado por essa implementação do Composite.

## Executar

É necessário ter o SDK do .NET 8 instalado. Na raiz do repositório, execute:

```bash
dotnet run --project Composite/Composite.csproj
```

Saída esperada:

```text
Liderados de Bill Gate (Steve Jobs, Jeff Bezos, Elon Musk)
Liderados de Elon Musk (Gabriel, Pedro)
```
