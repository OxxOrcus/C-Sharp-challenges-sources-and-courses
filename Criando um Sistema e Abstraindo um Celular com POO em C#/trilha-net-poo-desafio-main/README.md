# DIO - Trilha .NET - Programação orientada a objetos

www.dio.me

## Desafio de projeto

Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto

Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta

Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone.
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações

1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução

O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

## Proposta de atividade

Objetivo: consolidar conceitos de Programação Orientada a Objetos (POO) em C# aplicando abstração, herança e polimorfismo para modelar diferentes comportamentos de celulares.

Tarefas (passo a passo):

- Revisar as classes em `Models/Smartphone.cs`, `Models/Nokia.cs` e `Models/Iphone.cs` e localizar os comentários "TODO".
- Implementar a classe abstrata `Smartphone` com propriedades e métodos compartilhados (por exemplo: `Numero`, `Modelo`, `Ligando()`, `ReceberLigacao()`).
- Implementar as classes filhas `Nokia` e `Iphone` que herdam de `Smartphone` e sobrescrevem o método `InstalarAplicativo(string nomeApp)` com comportamentos diferentes.
- Garantir encapsulamento: propriedades acessíveis com getters/setters apropriados e validações simples (ex.: número não nulo).
- Atualizar `SmartphoneTest.cs` (ou criar testes simples) para demonstrar os comportamentos diferentes entre `Nokia` e `Iphone`.

Entregáveis:

- Código compilável do projeto console (`DesafioPOO.csproj`) com as implementações prontas.
- Um pequeno README (este arquivo atualizado) descrevendo o que foi feito.
- (Opcional) Um ou dois testes que validem o `InstalarAplicativo` para cada modelo.

Critérios de avaliação (aceitação):

- O projeto compila sem erros.
- Não há instância direta de `Smartphone` (classe abstrata).
- `Nokia` e `Iphone` estendem `Smartphone` e implementam `InstalarAplicativo` de formas distintas.
- Exemplo de execução (no console) mostrando instâncias de cada celular executando `InstalarAplicativo`.

Dicas e pontos de atenção:

- Use `abstract` para `Smartphone` e `override` para o método nas classes filhas.
- Mantenha a lógica simples; o objetivo é demonstrar POO, não implementar um instalador real.
- Procure por `TODO` nos arquivos da pasta `Models` para localizar exatamente onde implementar.

Metas de extensão (bônus):

- Adicionar uma interface `IConectividade` para representar ações de rede e implementar apenas no `Iphone` (ex.: `ConectarAInternet()`).
- Implementar registro de histórico de aplicativos instalados por celular.
- Criar testes unitários automáticos em `Tests/` que cubram os casos principais.

Tempo estimado: 1–2 horas para a implementação básica; +1–2 horas para testes e extensões.

Boa sorte — implemente, execute e envie um pequeno print da execução (ou output do console) para demonstrar que tudo funciona.
