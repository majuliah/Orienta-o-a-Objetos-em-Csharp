# Curso de Programação Orientada a Objetos em C# 🧐

![](https://media4.giphy.com/media/XWeJDaxYa1YrK/giphy.gif?cid=790b7611d487ab85cbd494f6f53469b48da90b21dd6538e8&rid=giphy.gif&ct=g)





## Um pouco sobre C# e .NET 👩🏽‍🚀:

#### O .net é uma plataforma de desenvolvimento que suporta diferentes linguagens de programação, como o C#, por exemplo.

- #### BCL: Base Class Library -> é uma biblioteca(conjunto de funcionalidades) base que ajuda no desenvolvimento

- #### CLR: Common Language RunTime -> Máquina Virtual que executa os programas feitos em .NET e possui garbage collection, onde o programa desaloca os recursos que não estão sendo utilizados.



## CLR 🌐:

#### Linguagens compiladas são aquelas que dependem de um compilador específico para cada sistema operacional para ser compilada. C++ é um exemplo. Ela é compilada, e dessa forma é gerado um arquivo executável para a execução daquele programa. Uma vez executada, roda muito mais rápido. 

#### Linguagens Interpretadas são aquelas que  possuem um interpretador que gradualmente vai fazendo a execução do arquivo. O mesmo código roda em diferentes sistemas, mas precisamos de um interpretador específico para cada um (sistema). Vantagem é a manutenção e a desvantagem é que é mais lento que a compilação. 

#### Híbrida: Escrevemos um programa no código fonte da linguagem(tipo o c#) e o código passa por um processo de pré compilação, gerando um código intermediário, bytecode, chamada CIL Common Intermediate Language que é universal para quaisquer linguagens escritas na plataforma. O bytecode garante a integridade dos códigos escritos e ele pode ser rodado em diferentes sistemas, com diferentes plataformas de execução. A CLR é uma platafroma que interpreta a pré-compilação. 

#### Escrevemos o código na linguagem fonte -> Programa é transferido pra pré-compilação que gera um código na linguagem intermediária (CIL) -> o CIL roda em cima de uma máquina virtual, a CLR -> Código Convertido em código de máquina e é reproduzido no sistema



## ESTRUTURA DE ARQUIVOS 📚:

#### Um projeto C# é uma solução. Ele tem a extensão .sln e é por ele que abrimos o projeto. 

#### O arquivo de extensão .csproj é um arquivo de configuração das extensões do projeto.

#### O arquivo de extensão .cs é o código em C#, onde você coloca as resoluções. 

#### A pasta bin e obj são as pastas de compilação, onde são guardados os arquivos de execução.



### Uma aplicação em C# é composta por classes, que podem ser agrupadas em namespaces(agrupamento lógico de classes relacionadas). 

### Assembly é uma build, um DLL ou EXE da aplicação = agrupamento físico de classes relacionadas. O projeto pode ser dividido em subsistemas.

### Aplicação é um sistema de assemblies relacionados.

# **Classes, Atributos, Métodos, Membros Estáticos** 🤔

## CLASSES 🥸:

#### Classes são um tipo estruturado que podem ou não conter membros:

- ### Atributos:  São dados da classe, características, campos, são os atributos.

- ### Métodos:  Funções. São ações que uma classe pode executar. É o comportamento da classe.

#### As classes podem ter outros recursos como:

- ### Construtores;

- ### Recarga;

- ### Encapsulamento;

- ### Herança;

- ### Polimorfismo;

#### Serão assuntos tratados futuramente. Voltando às classes:

#### Classes são os nossos próprios tipos personalizados. Assim como ***double, int, float, ...***, as classes também servem como tipos. Desse jeito, podemos criar nossas variáveis com os tipos que criamos:

![img1](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img2.png?raw=true)

#### Aqui temos a nossa classe triângulo que contém os atributos que iremos manipular para calcular a área de um triângulo qualquer. 

![img2](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img3.png?raw=true)

#### No programa principal, nós criamos duas variáveis, triX e triY que são variáveis do tipo Triangulo, a classe que criamos. Sendo assim, as duas variáveis são referências à um objeto composto. Como a imagem a seguir mostra:

![img3](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img1.png?raw=true)

#### O triânguloX e trianguloY herdam todos os atributos da classe Triangulo que criamos. Assim podemos manipular os tipos do jeito que queremos.

#### Após criarmos as variáveis triX e triY, precisamos **INSTANCIAR** o objeto. É feito com o comando new:                        *triX = new Triangulo();*

#### Dessa forma, nós estamos garantindo que os atributos da classe estejam realmente presentes nas variáveis que criamos, como a imagem ilustrativa das posições da memória. 



## Alocação dinâmica de Memória👾:

#### Quando criamos uma variável, ela fica em uma área chamada stack, que é a área stack cria as variáveis estáticas conforme as declaramos no programa. Mas ao INSTANCIAR uma classe, precisamos alocar a variável em uma área da memória chamada heap. Cria um objeto composto com seus atributos herdados. A variável da stack conterá o endereço do objeto que está na heap, dessa forma: 

![img4](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img4.png?raw=true)

#### O areaY é uma referência do objeto na heap ^



## MÉTODOS 🕵🏽‍♀️:

#### Métodos são funções que fazemos dentro de uma classe. Ele é a ação daquele objeto em que estamos criando. Seus benefícios são muitos, como a delegação de regras, claridade do código e organização. Aqui a adaptação do código do triângulo, só que com os cálculos sendo feitos através de métodos:

![img5](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img5.png?raw=true)

#### Com os métodos criados, podemos fazer a chamada no programa principal para o cálculo das áreas do triângulo:

![img6](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img6.png?raw=true)

## ToString🦩:

#### Toda classe no C# é uma subclasse de Object que é uma classe genérica. Ela possui os seguintes métodos:

- #### GetType: retorna o tipo do objeto;

- #### Equals: compara se o objeto é igual ao outro;

- #### GetHashCode: retorna um código hash do objeto;

- #### ToString: converte o objeto para string;

  

#### Para fazermos a concatenação das informações e deixar uma mensagem automática para ser usada sempre que o objeto for chamado, usaremos a ToString:

![img7](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img7.png?raw=true)

#### Quando colocarmos o objeto dentro de um Write, ele devolverá o objeto na forma de ToString, como definimos anteriormente, dessa forma:

![img8](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img8.png?raw=true)

#### O resultado sempre será a mensagem que colocamos no override ToString. Neste caso, vamos sobrescrever o ToString para receber o valor da mensagem e quando um Write for usado, ele irá RETURN, retornar o que foi passado no método.

# MEMBROS ESTÁTICOS 😗

### Até agora, vimos que as classes possuem membros e que estes membros podem ser *atributos* ou ***métodos()***. Porém, podemos  ter membros estáticos.

#### Também conhecidos como membros de classe (método de classe ou atributo de classe -os que vimos até agora são de instância, como método e atributo de instância), são membros que fazem sentido independente do objeto. Isso significa que são chamados pelo próprio nome da classe e não precisam de objeto para serem chamados. Como exemplo: classes utilitárias são classes que fornecem operações simples que podem ser chamadas de forma isolada. Exemplo: Math.Sqrt

#### Uma classe que só possui membros estáticos, pode ser uma classe estática. Porém classes estáticas não podem ser instanciadas. Uma classe estática SEMPRE dará o mesmo resultado, independentemente de objeto. 

#### Vendo na prática, resolveremos um problema de três formas diferentes. A primeira é usando métodos estáticos na própria classe do Program.



![img9](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img9.png?raw=true)

1. #### Não utilizaremos o public para a criação da função, porque ela será usada dentro da própria classe; 

2. #### Teremos que colocar a função como estática, porque ela será chamada dentro da função estática. Não podemos chamar uma função não estática, dentro de uma mesma classe em uma função estática. Ambas tem de ser estáticas (cafusei hehe);

3. #### Criamos a variável de PI dentro da classe program, para que o valor seja público em todo a classe, para que os métodos consigam acessá-la. Como ele será utilizado em uma função estática, antes do double precisamos definir que é uma variável estática.

   
   
   ### OUTRA FORMA DE FAZER 🧐:
   
   ![img10](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img10.png?raw=true)
   
   #### Nós usamos a classe Dólar e criamos um método estático. Assim quando formos chamar no programa principal, nós só passamos a referência do nome da classe, **e assim não é necessário instanciar um objeto**. 
   
   ![img11](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img11.png?raw=true)
   

# CONSTRUTORES, THIS, SOBRECARGA E ENCAPSULAMENTO 🤯:



## CONSTRUTORES🚜:

#### Operação que executa no momento da instanciação. Ele executa a partir da palavra reservada *new*. Ele é usado para exigir passagem de valores para parâmetros ou para iniciar o objeto com determinados valores. O construtor padrão é o construtor vazio, que a linguagem disponibiliza.

![img12](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img12.png?raw=true)

####  Quando fazemos a instanciação dessa forma, o objeto criado receberá todos os seus atributos iniciais como nulos. Com os construtores, obrigamos a passagem de parâmetros para este objeto. 

![img13](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img13.png?raw=true)

#### Ao criarmos um construtor informando os parâmetros dessa forma, obrigamos o programador a inserir os valores no momento em que instanciar o objeto. Dessa forma, passamos aos atributos os parâmetros do construtor. 



## SOBRECARGA😶:

#### Recurso da classe que permite sobrescrever um método para receber diferentes parâmetros. Como o exemplo a seguir:

![img14](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img14.png?raw=true)

#### Quando executamos o programa, ele somente pedirá os dois parâmetros passados na sobrecarga, e a quantidade é a que está estabelecida no construtor criado. 

![img15](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img15.png?raw=true) 

 ## ** Sintaxe alternativa para inicializar valores:

![img16](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img16.png?raw=true)



## PALAVRA THIS😫:

#### É uma referência ao próprio objeto. Ele diferencia atributos de variáveis locais, referencia outro constructor em um constructor e passar o próprio objeto como argumento de chamada de um método ou construtor. Aqui uns exemplos:

## Exemplo 1:

![img17](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img17.png?raw=true)

## Exemplo 2:

![img18](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img18.png?raw=true)

#### Podemos também passar o próprio objeto como argumento na chamada de um método ou construtor. Mas isso é exemplo que será explicado mais à frente.



## ENCAPSULAMENTO💊:

#### É um princípio que consiste em esconder detalhes de implementação, deixando apenas operações seguras e que não interfiram diretamente no código. O objeto deve SEMPRE estar em um estado consistente e a classe é responsável por garantir isso. O usuário somente tem acesso a recursos limitados, e os recursos de lógica e processamento ficam encapsulados, protegidos. Uma analogia é um aparelho de rádio. O usuário somente tem acesso aos botões e não aos circuitos internos que são cruciais para o funcionamento do sistema 😏. Nós somente temos acessos à operações básicas para utilizar o aparelho de forma segura. Temos algumas maneiras de explicar o encapsulamento:

## Implementação Manual✍🏽: 

- #### Todo atributo é definido como PRIVATE;

- #### O método GET e SET são utilizados nos atributos, sempre respeitando a regra de negócio;

#### Primeiro vamos fazer um encapsulamento para que os atributos não possam ser usados em outras classes:

![img19](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img19.png?raw=true)

#### Setando os atributos para private, não conseguimos utilizá-los em outras partes do programa, como por exemplo na main:

![img20](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img20.png?raw=true)

#### Quando usamos atributos PRIVADOS, a convenção de nomenclatura muda para:

![img 21](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img21.png?raw=true)

#### Sendo dessa forma, para conseguirmos acesso ao atributo em outras classes, seria necessário a criação de um método para acesso dessas infromações: 

![img 22](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img22.png?raw=true)

#### E dessa forma conseguiríamos ter acesso aos atributos através dos métodos no main program: 

![img 23](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img23.png?raw=true)

#### Agora para fazer a ALTERAÇÃO desses objetos, nós usaremos o método set:

![img24](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img24.png?raw=true)

#### Também é possível criarmos regras dentro dos métodos. Por exemplo, só é possível alterar o nome se o número de caracteres for maior que 1 e não for nulo:

![img25](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img25.png?raw=true)

#### Dessa forma, se quisermos somente consultar os atributos e não permitir a alteração, simplesmente não se cria o método de alterar. 

## Implementação Através das Properties 🦾: 

#### As PROPERTIES são formas de automatizar o encapsulamento. As properties são uma forma de usarmos atributos mas com comportamentos de métodos:

### Uma propriedade é um membro que fornece um mecanismo, uma forma flexível para ler, gravar ou calcular o valor de um campo particular. Podem ser usadas como atributos públicos mas na verdade são métodos especiais, conhecidos como acessadores. Isso permite que os dados sejam acessados facilmente e ainda ajuda a promover a segurança e a flexibilidade dos métodos. 

#### Agora veremos exemplos:

![img26](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img26.png?raw=true)

![img27](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img27.png?raw=true)

#### Assim o código fica mais legível, desta froma:

![img28](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img28.png?raw=true)

## Auto Properties🦿 :

#### As auto properties servem para otimizar as linhas de código usadas acima, podendo ser feitas dessa forma:

![img29](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img29.png?raw=true)

#### Porém, os atributos em que precisamos de uma lógica, como a do nome por exemplo, não podem usar esta implementação, sendo uma propertie manual.

## Ordem sugerida para estrutura do código🐫 :

1. #### Atributos Privados;

2. #### Auto Properties;

3. #### Constructors;

4. #### Propriedades Costumizadas;

5. #### Outros métodos da classe;

   

##  Modificadores de Acesso🦥 :

#### Pode ser encontrado com melhores definições [neste](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers) link.

# COMPORTAMENTO DE MEMÓRIAS, LISTS E ARRAYS 😁:

#### Tipos por referência ou Reference Types são valores que aceitam null, e eles APONTAM para um mesmo lugar na memória. A stack aponta para uma referência na heap. Assim:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img30.png?raw=true)

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img32.png?raw=true)

#### No caso do null, a memória seria alocada mas com nenhum valor preenchido. 

#### Agora os Value Types, ou tipos valores ou Structs são CÓPIAS. As variáveis realizam uma CÓPIA do valor. Os tipos valor no C# são os primitivos, string, double, float, etc, etc. Assim: 

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img31.png?raw=true)

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img33.png?raw=true)

### Nós também podemos criar os nossos próprios tipos. Eles são bem parecidos com as classes, mas se comportam como Value Types e precisam da declaração Structs no lugar do class:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img34.png?raw=true)

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img35.png?raw=true)

#### Os structs são parecidos com classes, mas nós não precisamos instanciar, embora seja perfeitamente possível. Apenas o Point ponto é capaz de criar os espaços de memória na STACK. Eles se parecem com classes mas se comportam como value types, justamente por manipularem memória da Stack e não da Heap. 



## Agora quanto a valores padrão:👻 

#### Quando alocamos com o new, QUALQUER tipo de valor estruturado, seja classe, struct ou array, são atribuídos valores vazios a eles, estes vazios são valores default:

- ### Números: 0 (zero)

- ### Bool: false;

- ### Char: caractere código 0(zero) - não o número 0(zero), mas o 0(zero) de bit;

- ### Object: null;

#### Uma variável declarada mas não inicializada não é acessada, porque é necessário primeiro atribuir valores a ela.

### Aqui alguns comparativos entre Classes e Structs:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img36.png?raw=true)



## Garbage Collector vs Escopo Local🦢:

## Garbage Collector:

#### cuida da heap

#### Ele é responsável por automatizar o gerenciamento de memória. Monitora a memória HEAP e desaloca objetos que não estão sendo utilizados. 

#### Quando um objeto perde sua referência, o garbage collector o desaloca em um momento futuro, otimizando a nossa aplicação.

## Escopo Local:

#### dentro da stack

#### Assim que uma variável é criada em um escopo, um de if, por exemplo, assim que o loop deixar de ser verdadeiro, a variável será descartada e deixará de existir. 



Rever a aula 67, parte de métodos com escopo local;

## NULLABLE😶:

#### Geralmente utilizamos nullables para dados e parâmetros opcionais, mas quando usamos structs(que não recebem nulo).

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img37.png?raw=true)

### Temos 3 funções para trabalhar com nulos:

- #### GetValueOrDefault🪢:

  #### Ela pega o valor da variável, e se não houver valor, ela pega o valor padrão. Em uma variável declarada como null, por exemplo a podeNull, ele retornará o valor zero, porque o valor default de double é zero.

  #### Se a variável tiver um valor, ele retorna o valor da variável.

  ![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img38.png?raw=true)

- #### HasValue

#### Retorna true ou false, pois ela verifica de a variável possui um valor. 

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img39.png?raw=true)

- #### Value

  #### Ele traz o valor da variável, mas somente se ela tiver um valor. Se for nullable ela não retorna:

  ![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img40.png?raw=true)

- #### Operador de coalescência nula:

  ![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img41.png?raw=true)



## ARRAYS🧩:

#### Quando instanciamos um array, ele fica gravado na HEAP, assim como um objeto. Os valores saem da stack e são armazenados na heap. 

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img42.png?raw=true)

#### Agora usando arrays para armazenar objetos:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img43.png?raw=true)



## Modificador de Parâmetro Params:

#### Vamos fazer uma classe calculadora que tem o objetivo de somar os elementos dentro do array passado como parâmetro:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img44.png?raw=true)

#### A forma de realizar a soma no main program é instanciando um objeto e depois instanciando um array na hora de passar os valores:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img45.png?raw=true)

#### O código funciona, mas está verboso. Nós podemos retirar a instanciação do vetor e colocar apenas os números, de forma direta, apenas colocando no método a palavra ***params***:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img46.png?raw=true)

#### Então a instanciação fica mais bonita e simples:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img47.png?raw=true)

#### Pronto, that's the way it is! 😁 código lindo, cheio de graça 



## REF e OUT:

## ref:

#### É quando queremos pegar valores da heap e jogar na stack. Pegamos a referência do valor na heap, e a apresentamos na stack. Dessa forma, pegamos a referência do atributo ou do parâmetro e passamos direto, dessa forma:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img49.png?raw=true)

#### e no main, utilizamos o ref também, na hora de chamar o método.

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img48.png?raw=true)

 

## out:

#### o out é uma variável de saída. Ele só recebe o valor para armazenar. Ele é o mesmo que o ref, mas não necessita que uma variável seja iniciada. 

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img50.png?raw=true)

#### a variável int de saída result que receberá o valor que está na heap.

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img51.png?raw=true)



## BOXING

#### É a conversão de um objeto do tipo valor para um objeto do tipo referência; 

#### Object é um tipo genérico no c# e recebe quaisquer tipos que forem atribuídos a ele. Então se fazemos Object receber a variável boxing valendo 20, ele criará uma nova referência na heap valendo 20.

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img52.png?raw=true)

## UNBOXING:

#### É a conversão de um tipo referência para um tipo valor compatível. Teremos sempre que fazer o casting. Da heap faz uma variável na stack:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img53.png?raw=true)



## Listas 📜😶:

#### As listas são estruturas de dados homogêneas, acessadas por meio de posições. Ela inicia vazia e os elementos são alocados sob demanda. Cada elemento ocupa um nó ou nodo da lista, ele contém o valor do nodo e a referência para o próximo elemento. É fácil realizar inserções e deleções. Vantagens são tamanhos variáveis, facilidade de realizar inserção e deleções. 

#### A desvantagem é acesso sequencial aos elementos. Mas geralmente podemos implementar listas de formas otimizadas, onde podemos acessar seus elementos como fazemos no vetor. 

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img54.png?raw=true)

#### aqui temos o comportamento das lists

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img55.png?raw=true)

### Maipulando as listas:

- #### **Add:** Adiciona o item no fim da fila(na ordem correta das coisas);

- #### **Insert**: Adiciona na posição em que especificarmos. Caso especifique uma opção já ocupada, ele aloca e manda o item da posição para baixo; Entre parênteses colocamos a posição que queremos e após a vírgula o que queremos colocar;

- ####  **Find**: Encontra o que estamos procurando, o que será passado pelo parâmetro, é o que será retornado.

- #### **FindLast:** Encontra o último incidente na lista que satisfaz o que foi passado no parâmetro;

-  #### **FindIndex:** Encontra o índice da lista que satisfaz o que foi passado no parâmetro; 

- #### **FindLastIndex:** Encontra o índice da última ocorrência do que foi passado no parâmetro;

- #### **FindAll**: Encontra todos os elementos da lista que satisfazem ao que foi passado no parâmetro;

- #### **Remove**: Remove o elemento que satisfazem o que foi passado no parâmetro;

- #### **RemoveAll**: Remove todos os elementos da lista que satisfazem o que foi passado no parâmetro;

- #### **RemoveAt**: Remove o que está na posição passada no parâmetro;

- ####  **RemoveRange**: Remove os elementos que estão dentro da faixa passada dentro dos parâmetros. (5,7 -> irá remover da posição 5 até a posição 7)

- ### Pesquisar outros métodos para listas





## ENUMS e Composições🪂:

- ## Definição Enum:

#### Enumerações são tipos valores especiais para especificar de forma literal um conjunto de constantes. É **semelhante** ao switch case.

#### Aqui uma estrutura de um ENUM:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img56.png?raw=true)

#### Os enums, por default, começam com o número 0, só sendo necessário referir um valor caso não seja desejada a sequência de 0 a N.

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img57.png?raw=true)

#### Aqui estamos criando um atributo do tipo enum OrderStatus chamado StatusOrder. Quando usado, ele conterá todas as informações colocadas no Enum.

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img58.png?raw=true)

#### Aqui estamos instanciando um objeto. O staturOrder recebe o enum Delivered, definido no Enum OrderStatus.

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img59.png?raw=true)

#### Aqui estamos fazendo a conversão.

#### No primeiro exemplo a variável do tipo string recebe o enum OrderStatus com o status shipped convertido para string. Na impressão imprimirá no fomato de string.

#### No segundo exemplo temos uma variável transformingToInt do tipo enum OrderStatus recebendo a conversão de um string para tipo enumerado. Então o Enum.Parse tá fazendo a conversão, e o tipo dentro dos sinais <> estão indicando QUAL ENUM queremos parametrizar. Entre parênteses estamos o valor que queremos converter para o tipo enumerado, e deve ser IGUAL ao que está dentro do enum parametrizado. O resultado é:

#### ![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img60.png?raw=true) 

# 💪😁

- ## Definição Composição:

  #### Composição é um tipo de associação que permite que um objeto contenha outro ou outros objetos. É conhecido também como uma relação de tem um ou tem vários. 

  ![img61](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img61.png?raw=true)

  #### Aqui temos a classe trabalhador que contém um atributo do tipo *Department*, que é uma classe. Quando instanciamos o departamento atribuindo a ele um valor, como por exemplo Designer Gráfico, podemos atribuir este objeto instanciado ao objeto *Worker* posteriormente como na imagem a seguir:

  <img src="https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img62.png?raw=true" alt="img62" style="zoom: 110%;" />

  #### Dessa forma temos uma composição, onde um objeto já instanciado poderá compor outro objeto. 

  #### As vantagens são:

  - #### Organização, onde podemos dividir as responsabilidades e não sobrecarregar uma classe com funções distantes de seu propósito original;

  - #### Coesão, onde podemos atribuir funções coesas para as classes e cada objeto tem funções bem definidas;

  - #### Flexibilidade, trabalhando com responsabilidades divididas é mais simples e confiável que o oposto. 

  - #### Reuso, onde um objeto pode ser utilizado em mais de um lugar;

###### ** Este exemplo se encontra no diretório 00.reviews, EnumsAndComposition



## Herança e Polimorfismo👩‍💻:

#### É um tipo de associação que permite que uma classe herde membros da outra. A herança é uma relação -é um-, é um conceito de generalização e especialização. Superclasse ou classe base é a classe genérica e uma subclasse é uma classe especializada e derivada. Herança e extensão quer dizer que uma classe é extensão e herda membros da outra, e a **herança** é uma **associação** entre **classes** e **não objetos**, quer dizer que instanciamos um único objeto que possui todos os dados de todas as classes herdadas.  

#### Neste capítulo aprendemos mais uma visibilidade: protected:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img63.png?raw=true)

#### Aqui podemos ver que, com a visibilidade estabelecida, não é possível setar valores que não herdem de account:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img64.png?raw=true)



## Upcasting e Downcasting🦕:

#### Upcasting é o casting da subclasse para a superclasse. Uso comum é no polimorfismo. 

#### A conversão de uma subclasse para uma superclasse é perfeitamente aceitável, inclusive para o compilador, porque a herança é uma relação -é um-, e isso significa que a subclasse é do tipo de sua superclasse. Uma superclasse recebe perfeitamente qualquer tipo de suas subclasses, e isso é o upcasting.

![upcasting](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img65.png?raw=true)

#### Downcasting é o casting da superclasse para a subclasse. Uso comum é em métodos que recebem parâmetros genéricos - Equals -

#### O Downcast é desencorajado e só deve ser usado quando for extremamente necessário. O compilador pode não reconhecer algumas falhas e o erro eclode na compilação. Quando usado o downcast, é necessário checar os tipos das variáveis para que não haja erros. Para testar usamos o operador -is-.

![downcasting](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img66.png?raw=true)



## Sobreposição ou Sobrescrita📚: 

#### sobreposição ou sobrescrita é a implementação de um método de uma superclasse na subclasse, e para que um método comum (não abstrato) possa ser sobreposto, deve ser incuído o prefixo virtual. Ao sobrescrever um método, devemos incluir um prefixo override.

#### Na superclasse account, o método de saque cobra uma taxa de R$5.00 para realizar a operação, sendo assim, todas as classes que herdam de account também possui a taxa de de saque. Para permitir que as subclasses alterem o método, inserimos a palavra virtual nos métodos que permitiremos alteração:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img67.png?raw=true)

#### Sendo assim, na classe que desejamos sobrescrever o método, inserimos a palavra reservada override e implementamos as alterações:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img68.png?raw=true)

#### Agora temos um exemplo. Dois objetos instanciados, um Account e um Savings Account:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img69.png?raw=true)

#### O resultado será:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img70.png?raw=true)

#### O primeiro resultado porque sacou 10.0 + a taxa de 5.0 e o segundo resultado se dá porque não tem taxa de saque.

- #### VIRTUAL : Fica no método não abstrato da superclasse e permite que as subclasses sobrescrevam os métodos da superclasse.

- #### OVERRIDE: Fica no método da subclasse que está sendo sobrescrito. Reimplementamos métodos de superclasses dando um novo contexto mais adequado para o que a subclasse está se propondo a fazer.

- #### Ambos independem de visibilidade dos membros da classe.

#### Já a palavra base no contexto de sobrescrita serve para chamarmos a implementação da superclasse na subclasse. Um exemplo seria se a subclasse SavingAccount descontasse o valor normal da superclasse -5.00- mais uma taxa de 2.00 -totalizando 7.00-:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img71.png?raw=true)

#### Dessa forma conseguimos implementar a o método original e customizar do jeito que for necessário. 

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img72.png?raw=true)

#### Quando fazemos construtores e queremos aproveitar o construtor da superclasse, também utilizamos o base.

## Classes e métodos selados🛢️:

#### Se for selada, evitaremos que a classe seja herdada. Ainda é possível extender a funcionalidade de uma classe selada usando extension methods que será visto mais à frente.

#### Se selado, um método que já foi sobreposto não pode se sobrepor novamente. Só pode ser utilizado em métodos já sobrepostos.

### CLASSES:

```c#
namespace MetodosSelados
{
    sealed class MostrandoOmetodoSelado
    { 
        ...
    }
}
```

#### Dessa forma, definiremos a classe SavingAccount como selada:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img73.png?raw=true)

#### E quando tentarmos herdar de SavingAccount:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img74.png?raw=true)

### MÉTODOS:

#### Métodos só podem ser selados se eles já forem sobrescritos. Métodos sem sobreposição não podem ser selados:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img75.png?raw=true)

#### Agora quando tentarmos utilizar um método selado em uma classe que herda de SavingAccount:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img76.png?raw=true)



#### Utilizamos o sealed por questões de segurança e performance. Dependendo das circunstâncias, as vezes é necessário que uma classe não seja herdada e nem um método seja sobreposto. Geralmente sobreposições múltiplas de métodos podem gerar inconsistências. Por performance, atributos de classes seladas são analisados mais rapidamente em tempo de execução por não terem muitas utilizações.

 

## POLIMORFISMO🦛: 

##### rever aula 139. 

##### AQUI NO CURSO o polimorfismo foi apresentado como um recurso que permite que variáveis de um de um mesmo tipo mais genérico possam apontar para objetos de tipos específicos diferentes, tendo comportamentos diferentes conforme cada tipo específico, dessa forma:

```c#
Account conta1 = new Account (1001, Alex, 500.0)
Account conta2 = new SavingAccount (1001, Alex, 500.0, 0.01)
```



## CLASSES ABSTRATAS🖼️:

#### São classes que não são instanciadas por serem o conceito total de abstração e representam conceitos muito genéricos que não vale a pena trabalhar com eles. São incompletas e devem ser preenchidas por suas subclasses, estão no topo da hierarquia de classes.

#### Também é uma forma de garantir herança total, já que somente subclasses não abstratas podem ser instanciadas:

```c#
abstract class Funcionario
    {
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public string Profession { get; set; }
        
        public Funcionario(){}
    }
```

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img77.png?raw=true)

#### Reuso e polimorfismo são os benefícios de se utilizar classes abstratas. A superclasse permite tratar de forma fácil e uniforme todos os tipos de funcionários inclusive com polimorfismo. Podemos colocar diferentes objetos em uma mesma coleção.

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img78.png?raw=true)



## MÉTODOS ABSTRATOS🖼️:

#### São métodos que não possuem implementação, são implementados em classes genéricas demais para conter implementação. Se uma classe possuir pelo menos um método abstrato, então ela também é abstrata. Obrigatoriamente devem ser utilizados em classes abstratas e utilizados em subclasses. Declaração de um método abstrato:

```c#
// declarando o método
public abstract double ValorTotal();

//utilizando o método em subclasses
 public override double ValorTotal()
{
     //implementação
}
```



## EXCESSÕES🛝:

#### Uma exceção é qualquer condição de erro ou um comportamento não esperado encontrado pelo programa em **execução**. No .net, uma exceção é um **objeto** herdado da classe System.Exception, e quando lançada, uma exceção é propagada na pilha de chamadas de métodos em execução, até que seja capturada, tratada ou o programa encerrado. Elas permitem que os erros sejam tratado consistentemente e flexível, utilizando boas práticas. Delega a lógica do erro para a classe / método responsável por conhecer as regras que podem ocasionar os erros. Trata de forma organizada e hierárquica diferentes tipos de exceções, além de poder carregar dados quaisquer, isto é, quando lançada, o programa que receber a exceção, podemos manipular seus dados.

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img79.png?raw=true) hierarquia de classes Exception 

#### Bloco try/catch:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img80.png?raw=true)

#### Bloco finally: é o bloco que será executado independentemente de exceção ocorrer ou não. Exemplo clássico é quando é necessário fechar um arquivo ou conexão de banco de dados ao final do processamento. Sintaxe:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img81.png?raw=true)



## Trabalhando com arquivos📂:

#### File e FileInfo são namespaces de Systen.IO e realizam operações com arquivos e ajudam na criação de objetos FileStream. Realizam operações de create, copy, delete, move, open, etc.

#### File: static members -> simples mas realiza verificação de segurança para cada operação. Um pouco mais lenta.

#### FileInfo: Instance members, deixa o programa um pouco mais rápido e é utilizado quando a performance é importante.

#### IOException: superclasse de quaisquer excessões que possam ocorrer quando trabalhamos com arquivos.



#### FileStream: Disponibiliza uma stream associada a um arquivo permitindo operações de leitura e escrita. Tem suporte a dados binários. Instancia com vários construtores, File/FileInfo também.

![filestream](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img82.png?raw=true)

#### StreamReader: É uma stream capaz de ler caracteres a partir de uma stream binária, exemplo o fileStream. Dá suporte a dados em formato string (texto) e é instanciada com vários construtores, File e fileInfo.

![StreamReader](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img83.png?raw=true)

```c#
   class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\arquivo.txt";
            //FileStream fileStream = null;
            StreamReader streamReader = null;

            try
            {
                //fileStream = new FileStream(path, FileMode.Open);
                //streamReader = new StreamReader(fileStream);
                
                streamReader = File.OpenText(path);

                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    WriteLine(line);                    
                }
            }
            catch (IOException exception)
            {
                WriteLine($"An error ocurred");
                WriteLine(exception.Message);
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
               // if (fileStream != null) fileStream.Close();
            }
        }
    }
```

#### StreamWriter: Capaz de escrever caracteres a partir de uma stream binária, por exemplo o FileStream. Suporte a dados em formato de string(texto) e instancia com vários construtores, como File/FileInfo, createText -> path, AppendText -> string. Funciona como o StreamReader.

#### Using Block: Sintaxe simplificada que garante que os objetos IDisposable (objetos não gerenciados pelo CLR(precisam manualmente ser gerenciados)) serão fechados. Exemplos: Font, FileStream, StreamReader, StreamWriter.



## Directory/ Directory Info 🧧:

#### Realiza operações com pastas.





## INTERFACES🦦:

#### É um tipo que define um conjunto de operações que uma classe ou struct deve implementar. A interface estabelece um contrato em que a classe ou struct deve cumprir. Elas criam sistemas de baixo acoplamento e mais flexíveis.

```c#
interface IShape 
{
	double Area();
	double Perimetro();
}
```



## INVERSÃO DE CONTROLE♟️:

#### Padrão de desenvolvimento que consiste em retirar da classe a responsabilidade de instanciar suas dependências.

## INJEÇÃO DE DEPENDÊNCIA🦛:

#### Forma de realizar a inversão de controle: um componente externo instancia a dependência, que é então injetada no objeto -pai-. Pode ser implementada de várias formas: 

- #### Construtor,

- #### Objeto de instanciação (builder/factory)

- #### Container / framework

## ASPECTOS COMUNS ENTRE HERANÇA E INTERFACES☁️:

#### Em ambos temos a relação - é um -, possui o conceito de generalização e especialização e o polimorfismo. 

#### A diferença fundamental entre ambas é que na herança temos o reuso e na interface temos um contrato a ser cumprido.

#### Em uma superclasse Shape que possui um atributo color, suas duas subclasses rectangle e circle HERDARÃO o atributo color.

#### Em uma interface TaxServices que possui o método tax, as classes que implementarem a interface TaxServices terão um contrato a cumprir, sendo obrigatório a utilização do método em questão.



## PROBLEMA DE DIAMANTE💎:

#### O problema do diamante consiste em uma ambiguidade causada pela existência do mesmo método de uma superclasse. Herança múltipla não é permitida na maioria das linguagens. A solução é a implementação de interfaces que possuem operações específicas. Não há herança múltipla e sim cumprimento de contrato de uma ou mais interfaces.



## INTERFACE  ICOMPARABLE 🏟️:

#### Padrão do C# para realizar comparações entre objetos. Faz verificação entre maior, menor ou igual. 

```c#
public interface IComparable 
{
    int CompareTo(object otherObject);
}
```



## GENERICS🪷:

#### Permitem que classes, métodos e interfaces sejam parametrizados por tipo. Benefícios são reúso, type safety e performance. O uso comum é em coleções.

```c#
List<string> list = new List<string>();
list.Add(Maria);
string name = list[0];
```

#### Isso significa que ao criarmos classes, parametrizamos elas com um tipo genérico, muito comumente chamado T, que realiza operações com qualquer tipo que for instanciado. Nisso, utilizamos reúso nos programas. Se uma classe trabalhar somente com int e futuramente precisar trabalhar com parâmetros do tipo string, teríamos de criar uma classe idêntica somente alterando os parâmetros, e isso não cumpriria com o pilar da OO reuso. Se utilizássemos um tipo object, castings teriam de ser feitos, além de atrapalhar a performance do programa. Isso também não seria seguro pelo fato do TypeSafety não monitorar essas utilizações, gerando erro em tempo de compilação. A alternativa é fazer um tipo genérico que pode ser instanciado posteriormente com qualquer tipo que seja necessário. Dessa forma:

```c#
public class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException($"PrntService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException($"PrntService is empty");
            }
            return _values[0];
        }
```

#### Quando formos instanciar o objeto:

```c#
 PrintService<int> printService = new PrintService<int>();
 WriteLine($"How many values?");
 int howMany = int.Parse(ReadLine());
```



## RESTRIÇÃO DE GENERICS 🦐:

#### Nem só de baderna se vive um código! Nós podemos definir restrições quanto aos tipos em que usaremos no generic para que não seja totalmente volátil e sugestivo a erros. A restrição diz respeito a interface Icomparable. Um objeto só pode ser de qualquer tipo, desde que ele seja comparável um ao outro. A sintaxe:

```c#
 public class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException($"The list can not be empty");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
```

#### Como foi dito antes, não somente as classes podem ter tipos genéricos, mas os métodos também. Acima temos um método genérico que deve só pode ser genérico se o seu tipo for comparável.  Existe outras restrições possíveis que podem ser checadas nos documentos da microsoft.



## GETHASHCODE E EQUALS🐨:

#### são operações da classe object usadas para comparação de objetos.

#### Equals: lento, resposta 100%. Retorna true ou false.

#### GetHashCode: rápido, resposta positiva não 100% (podem haver coincidências). Retorna um número inteiro representado por um código gerado a partir das informações do objeto. Gera um hash diferente a cada execução realizada. Se o código de dois objetos for diferente, com certeza os objetos serão diferentes; Se o código de dois objetos for igual, muito provavelmente eles são iguais. Mas pode haver colisão  e os números serem gerados igualmente para cada objeto. 

#### Em uma lista repleta de objetos, utilizamos o hashcode para procurar o que estamos buscando. Quando acharmos, validamos com o equals para ter certeza de que realmente é o que buscamos.

#### Os tipos pré-definidos (string, int, double, etc) já possuem implementação para estas operações. Classes e structs personalizados precisam sobrepô-la. 

## CONJUNTOS: HashSet<T> e SortedSet<T>🫥:

#### Representam um conjunto de elementos similar ao da álgebra. Não admitem repetições, elementos não possuem posição, acesso inserção e remoção de elementos são rápidos, oferece operações eficientes de conjunto: inserção, união e diferença. 

#### HashSet: armazena os elementos organizando-os em uma tabela hash. Cada elemento possui um código associado e a estrutura de dados que é responsável por gerenciar isto. É um armazenamento extremamente rápido, em ordem de um passo a não ser que ocorram conflitos. A ordem dos elementos não é garantida, quando for percorrer os elementos, a ordem nunca é coesa.

```c#
HashSet<string> hashSet = new HashSet<string>();
hashSet.Add($"TV");
hashSet.Add($"Notebook");
hashSet.Add($"Tablet");
            
WriteLine(hashSet.Contains($"Notebook"));
WriteLine(hashSet.Contains($"Computer"));
```



#### SortedSet: Armazenamento em forma de árvore. É uma busca logarítmica. Os elementos são armazenados ordenadamente conforme na implementação IComparer<T>.

```c#
SortedSet<int> numbers1 = new SortedSet<int>(){ 0, 2, 4, 5, 6, 8, 10};
SortedSet<int> numbers2 = new SortedSet<int>(){ 5, 6, 7, 8, 9, 10};
            
PrintCollection(numbers1);

//union
SortedSet<int> numbers3 = new SortedSet<int>(numbers1);
numbers3.UnionWith(numbers2);
PrintCollection(numbers3);
//sortedSet mantém os elementos ordenados

SortedSet<int> numbers4 = new SortedSet<int>(numbers1);
numbers4.IntersectWith(numbers2);
PrintCollection(numbers4);            
            
//difference
SortedSet<int> numbers5 = new SortedSet<int>(numbers1);
numbers5.ExceptWith(numbers2);
PrintCollection(numbers5);
```



## COMO AS COLEÇÕES HASH  TESTAM IGUALDADE? 🐫🐪:

#### Se getHashCode e Equals estiverem implementados: Primeiro o getHashCode e se der igual, usa o equals para confirmar.

#### Se getHashCode não estiver implementado: Tipo referência compara a referência dos objetos e tipo valor compara o valor dos objetos. 



## DICTIONARY E SORTED DICTIONARY📖:

#### também conhecido em estruturas de dados como map, dictionary é uma coleção de pares chave/valor onde não admite repetições do objeto chave. Os elementos são indexados através do elemento chave e não possuem posição. O acesso, inserção e remoção dos elementos são mais rápidos. Seus usos comuns são cookies, local storage, qualquer modelo de chave-valor etc.

#### Diferenças entre Dictionary e SortedDictionary:

- #### Dictionary

  - #### Armazenamento em tabela hash;

  - #### Extremamente rápido em inserção, remoção e busca O(1)

  - #### A ordem dos elementos não é garantida;

- #### SortedDictionary

  - #### Armazenamento em árvore;

  - #### Rápido em inserção, remoção e busca O(log(n))

  - #### Os elementos estão armazenados ordenadamente conforme implementação IComparer<T>

  #### dictionary[key] - acessa o elemento pelo valor da key informada

  

  ## EXTENSION METHODS 🍭:
  
  #### Métodos que estendem a funcionalidade de um tipo sem precisar alterar código fonte ou herdar dele.
  
  #### Como fazer um extension method:
  
  - #### Cria-se uma classe estática
  
  - #### Na classe, cria um método estático
  
  - #### O primeiro parâmetro do método deverá ter o prefixo this seguido da declaração de um parâmetro do tipo que se deseja estender. Esta será yma referência para o próprio objeto.
  
    



## LAMBDA, DELEGATES, LINQ🔥:

#### Programação funcional e cálculos lambda

#### C# é uma linguagem multiparadigma

|                                              | Programação Imperativa       | Programação Funcional            | Descrição                                                    |
| -------------------------------------------- | ---------------------------- | -------------------------------- | ------------------------------------------------------------ |
| Como se descreve algo a ser computado        | Comandos (como - imperativa) | Expressões (o que - declarativa) | Na imperativa escrevemos comandos e dizemos como fazer. Na funcional descrevemos através de expressões, e dizemos o que queremos. |
| Expressividade/ código conciso               | baixa                        | alta                             | Expressividade baixa: muito código para pouca ação. Expressividade alta: pouco código para mais ações, declarando como queremos. |
| Funções possuem transparência referencial    | fraco                        | forte                            | O resultado da função depende apenas de seus parâmetros. É bom pela função ser mais fácil de entender. Na programação imperativa isso é fraco enquanto na funcional isso é forte. |
| Objetos imutáveis                            | raro                         | comum                            | São mais fáceis de entender e são paralelizados              |
| Funções são objetos de primeira ordem/classe | nçao                         | sim                              | As funções podem ser passadas como parâmetros de métodos bem como retornadas como resultado de métodos. |
| Inferência de tipos                          | raro                         | comum                            | não é necessário inferir tipos às variáveis, o compilador é capaz de entender pelos valores que a ela foram passados (Quando usamos var em c#) |
| Execução tardia (lazy)                       | raro                         | comum                            | uma expressão só é executada quando precisamos de seu resultado |



## INTRODUÇÃO A DELEGATES 🫣:

#### Delegates são tipos em c#, é uma referência com type safety para um ou mais métodos. É um tipo referência e seus usos comuns são em comunicação entre objetos de forma flexível e extensível (eventos e callbacks) e parametrização de operações por métodos - programação funcional.

#### Os principais delegates pré-definidos são Action, Func e Predicate.



#### **MULTICAST DELEGATES🧶:**

#### São delegates que guardam referência para mais de um método. Para adicionar uma referência, pode-se usar o operador += . A chamada Invoke(ou sintaxe reduzida) executa todos os métodos na ordem em que foram adicionados e seu uso faz sentido para métodos void.

#### **PREDICATE🏟️:**

#### É um delegate que recebe um objeto do tipo T e retorna um valor booleano. 

```c#
public delegate bool Predicate<in T>(T obj);
```

#### Basicamente o resultado da função depende de um booleano.

#### **ACTION🤺:**

#### Representa um método void que recebe 0 ou mais argumentos. Ele recebe de 0 a 15 parâmetros. 















# REVER: 

- Como criar métodos
- Opções de como chamá-los
- construtores
- arrays para armazenar objetos;
- Get e Set com diferentes visibilidades;

####  

### UPCASTING & DOWNCASTING:

#### Upcasting: Casting da subclasse para Superclasse -> Convertemos uma subclasse para uma superclasse, usamos isto com polimorfismo

#### Downcasting: Inverso do upcasting, é a conversão da superclasse para a subclasse.



