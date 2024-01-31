# Lista de Exercicios - Estrutura de Dados

# Filtro de Strings

## Descrição e Requisitos
Escreva uma função que receba uma lista de strings e retorne uma nova lista contendo somente strings que contenham 10 ou mais caracteres.<br/><br/>

**Objetivo**: Manipulação com listas utilizando a estrutura de dados _'List<>'_.<br/>
**Observação**:  Não use métodos de extensão `Linq`, implemente sua função usando estruturas de repetição (laços, loopings).<br/><br/>
**Entrada**: <br/>
var input = new List<string>{ 
      "Idiossincrasia",
      "Ambivalente",
      "Quimérica",
      "Perpendicular",
      "Efêmero",
      "Pletora",
      "Obnubilado",
      "Xilografia",
      "Quixote",
      "Inefável"
   }<br/>

# Equilíbrio de expressões

## Descrição e Requisitos
Escreva uma função que receba uma expressão mátemática como entrada e verifique se a expressão está balanceada. Uma expressão está balanceada se para cada parênteses de abertura, existe um parênteses de fechamento correspondente.<br/>

**Objetivo**: Manipulação com pilhas utilizando a estrutura de dados _'Stack<>'_.<br/>
**Observação**:  Considere todos os 3 tipos de parênteses como (`()`, `{}`, `[]`). Não use métodos de extensão `Linq`, implemente sua função usando estruturas de repetição (laços, loopings).<br/><br/>
**Entrada**: <br/>
Exemplo de expressão balanceada: (2+1)*80/(7-[√9 + {4² * 0}])<br/>
Exemplo de expressão não balanceada: ([{35 - 2} + 5*3} + 0 / 15) - [3 + 5³] * 11)<br/>

# Batatinha Quente

## Descrição e Requisitos
Escreva uma função que simule o jogo de batata quente. Nesse jogo, jogadores passam a batata quente por um círculo até ela explodir. O jogador que estiver com a batata quando explodir está fora do jogo. <br/>

**Objetivo**: Manipulação com filas utilizando a estrutura de dados _'Queue<>'_.<br/>
**Observação**:  A função deve receber o número de jogadores como parâmetro de entrada. A função deve selecionar um **número aleatório entre 1 e 100** que será a quantidade de passes até a batata explodir. Cada jogador que "sobreviver" à passagem da batata deve ir para o fim da fila, até que a batata exploda.. Não use métodos de extensão `Linq`, implemente sua função usando estruturas de repetição (laços, loopings).<br/><br/>
**Entrada**: Quantidade de jogadores + Nome de cada jogador.

# Contador de Palavras

## Descrição e Requisitos
O programa deve receber como entrada um texto e, usando dicionário, contar quantas ocorrências de cada palavra acontecem nesse texto. <br/>

**Objetivo**: Manipulação com dicionário utilizando a estrutura de dados _'Dictionary<,>'_.<br/>
**Observação**:  Não use métodos de extensão `Linq`.<br/><br/>
**Entrada**: <br/>
var input = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla auctor porta velit a tincidunt. Nam efficitur iaculis placerat. Aenean lectus dui, sollicitudin id rhoncus tristique, aliquet sed quam. Phasellus blandit magna at elementum consequat. Nam vitae nunc vehicula, blandit felis a, placerat augue. Quisque bibendum a ipsum at scelerisque. Duis molestie turpis quis orci vehicula aliquam. Duis non elementum erat. Phasellus et dui odio. Nunc vitae leo sem. Curabitur nec enim id mi aliquet commodo at et sapien. Fusce sit amet nisi elit. Interdum et malesuada fames ac ante ipsum primis in faucibus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Duis vitae dolor at sem ultrices euismod. Morbi aliquet, felis et mattis congue, justo nunc pharetra lectus, a lobortis mauris eros et nulla. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Maecenas sollicitudin posuere nibh malesuada suscipit. Nam a sapien ex. Donec mollis justo est, quis tempus mi pharetra at. Cras fringilla enim eu egestas scelerisque. Praesent tristique imperdiet consectetur. Donec interdum pulvinar nulla vel pharetra. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Aliquam interdum finibus mi, in tempus lorem. Cras diam magna, viverra vitae ante eget, scelerisque sodales velit. Aliquam erat volutpat. Mauris consectetur sapien mi, vel euismod quam consectetur id.";
