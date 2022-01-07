# Curso de Programação Orientada a Objetos em C# 🧐

![](https://media4.giphy.com/media/XWeJDaxYa1YrK/giphy.gif?cid=790b7611d487ab85cbd494f6f53469b48da90b21dd6538e8&rid=giphy.gif&ct=g)





## Um pouco sobre C# e .NET 👩🏽‍🚀:

#### O .net é uma plataforma de desenvolvimento que suporta diferentes linguagens de programação, como o C#, por exemplo.

- #### BCL: Base Class Library -> é uma biblioteca(conjunto de funcionalidades) base que ajuda no desenvolvimento

- #### CLR: Common Language RunTime -> Máquina Virtual que executa os programas feitos em .NET e possui garbage collection, onde o programa desaloca os recursos que não estão sendo utilizados.



## CLR 🌐:

#### Linguagens compiladas são aquelas que dependem de um compilador, específico para cada sistema operacional para ser compilada. C++ é um exemplo. Ela é compilada, e dessa forma é gerado um arquivo executável para a execução daquele programa. Uma vez executada, roda muito mais rápido. 

#### Linguagens Interpretadas são aquelas que possuem possuem um interpretador que gradualmente vai fazendo a execução do arquivo. O mesmo código roda em diferentes sistemas, mas precisamos de um interpretados específico para cada um (sistema). Vantagem é a manutenção e a desvantagem é que é mais lento que a compilação. 

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

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img2.png?raw=true)

#### Aqui temos a nossa classe triângulo que contém os atributos que iremos manipular para calcular a área de um triângulo qualquer. 

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img3.png?raw=true)

#### No programa principal, nós criamos duas variáveis, triX e triY que são variáveis do tipo Triangulo, a classe que criamos. Sendo assim, as duas variáveis são referências à um objeto composto. Como a imagem a seguir mostra:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img1.png?raw=true)

#### O triânguloX e trianguloY que criamos, herdam todos os atributos da classe Triangulo que criamos. Assim podemos manipulas do jeito que queremos os tipos.

#### Após criarmos as variáveis triX e triY, precisamos **INSTANCIAR** o objeto. É feito com o comando new:                        *triX = new Triangulo();*

#### Dessa forma, nós estamos garantindo que os atributos da classe estejam realmente presentes nas variáveis que criamos, como a imagem ilustrativa das posições da memória. 



## Alocação dinâmica de Memória👾:

#### Quando criamos uma variável, ela fica em uma área chamada stack, que é a área stack cria as variáveis estáticas conforme as declaramos no programa. Mas ao INSTANCIAR uma classe, precisamos alocar a variável em uma área da memória chamada heap. Cria um objeto composto com seus atributos herdados. A variável da stack conterá o endereço do objeto que está na heap, dessa forma: 

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img4.png?raw=true)

#### O areaY é uma referência do objeto na heap ^



## MÉTODOS 🕵🏽‍♀️:

#### Métodos são funções que fazemos dentro de uma classe. Ele é a ação daquele objeto em que estamos criando. Seus benefícios são muitos, como a delegação de regras, claridade do código e organização. Aqui a adaptação do código do triângulo, só que com os cálculos sendo feitos através de métodos:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img5.png?raw=true)

#### Com os métodos criados, podemos fazer a chamada no programa principal para o cálculo das áreas do triângulo:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img6.png?raw=true)

## ToString🦩:

#### Toda classe no C# é uma subclasse de Object que é uma classe genérica. Ela possui os seguintes métodos:

- #### GetType: retorna o tipo do objeto;

- #### Equals: compara se o objeto é igual ao outro;

- #### GetHashCode: retorna um código hash do objeto;

- #### ToString: converte o objeto para string;

  

#### Para fazermos a concatenação das informações e deixar uma mensagem automática para ser usada sempre que o objeto for chamado, usaremos a ToString:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img7.png?raw=true)

#### Quando colocarmos o objeto dentro de um Write, ele devolverá o objeto na forma de ToString, como definimos anteriormente, dessa forma:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img8.png?raw=true)

#### O resultado sempre será a mensagem que colocamos no override ToString.

# MEMBROS ESTÁTICOS 😗

### Até agora, vimos que as classes possuem membros e que estes membros podem ser *atributos* ou ***métodos()***. Porém, podemos  ter membros estáticos.

#### Também conhecidos como membros de classe (método de classe ou atributo de classe -os que vimos até agora são de instância, como método e atributo de instância), são membros que fazem sentido independente do objeto. Isso significa que são chamados pelo próprio nome da classe e não precisam de objeto para serem chamados. Como exemplo: classes utilitárias são classes que fornecem operações simples que podem ser chamadas de forma isolada. Exemplo: Math.Sqrt

#### Uma classe que só possui membros estáticos, pode ser uma classe estática. Porém classes estáticas não podem ser instanciadas. Uma classe estática SEMPRE dará o mesmo resultado, independentemente de objeto. 

#### Vendo na prática, resolveremos um problema de três formas diferentes. A primeira é usando métodos estáticos na própria classe do Program.



![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img9.png?raw=true)

1. #### Não utilizaremos o public para a criação da função, porque ela será usada dentro da própria classe; 

2. #### Teremos que colocar a função como estática, porque ela será chamada dentro da função estática. Não podemos chamar uma função não estática, dentro de uma mesma classe em uma função estática. Ambas tem de ser estáticas (cafusei hehe);

3. #### Criamos a variável de PI dentro da classe program, para que o valor seja público em todo a classe, para que os métodos consigam acessá-la. Como ele será utilizado em uma função estática, antes do double precisamos definir que é uma variável estática.

   
   
   ### OUTRA FORMA DE FAZER 🧐:
   
   ![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img10.png?raw=true)
   
   #### Nós usamos a classe Dólar e criamos um método estático. Assim quando formos chamar no programa principal, nós só passamos a referência do nome da classe, e assim não é necessário instanciar um objeto. 
   
   ![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img11.png?raw=true)
   
   



# CONSTRUTORES, THIS, SOBRECARGA E ENCAPSULAMENTO 🤯:



## CONSTRUTORES🚜:

#### Operação que executa no momento da instanciação. Ele executa a partir da palavra reservada *new*. Ele é usado para exigir passagem de valores para parâmetros ou para iniciar o objeto com determinados valores. O construtor padrão é o construtor vazio, que a linguagem disponibiliza.

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img12.png?raw=true)

####  Quando fazemos a instanciação dessa forma, o objeto criado receberá todos os seus atributos iniciais como nulos. Com os construtores, obrigamos a passagem de parâmetros para este objeto. 

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img13.png?raw=true)

#### Ao criarmos um construtor informando os parâmetros dessa forma, obrigamos o programador a inserir os valores no momento em que instanciar o objeto. Dessa forma, passamos aos atributos os parâmetros do construtor. 



## SOBRECARGA😶:

#### Recurso da classe que permite sobrescrever um método para receber diferentes parâmetros. Como o exemplo a seguir:

![img14](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img14.png?raw=true)

#### Quando executamos o programa, ele somente pedirá os dois parâmetros passados na sobrecarga, e a quantidade é a que está estabelecida no construtor criado. 

![img15](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img15.png?raw=true) 

 ## ** Sintaxe alternativa para inicializar valores:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img16.png?raw=true)



## PALAVRA THIS😫:

#### É uma referência ao próprio objeto. Ele diferencia atributos de variáveis locais, referencia outro constructor em um constructor e passar o próprio objeto como argumento de chamada de um método ou construtor. Aqui uns exemplos:

## Exemplo 1:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img17.png?raw=true)

## Exemplo 2:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img18.png?raw=true)

#### Podemos também passar o próprio objeto como argumento na chamada de um método ou construtor. Mas isso é exemplo que será explicado mais à frente.



## ENCAPSULAMENTO💊:

#### É um princípio que consiste em esconder detalhes de implementação, deixando apenas operações seguras e que não interfiram diretamente no código. O objeto deve SEMPRE estar em um estado consistente e a classe é responsável por garantir isso. O usuário somente tem acesso a recursos limitados, e os recursos de lógica e processamento ficam encapsulados, protegidos. Uma analogia é um aparelho de rádio. O usuário somente tem acesso aos botões e não aos circuitos internos que são cruciais para o funcionamento do sistema 😏. Nós somente temos acessos à operações básicas para utilizar o aparelho de forma segura. Temos algumas maneiras de explicar o encapsulamento:

## Implementação Manual✍🏽: 

- #### Todo atributo é definido como PRIVATE;

- #### O método GET e SET são utilizados nos atributos, sempre respeitando a regra de negócio;

#### Primeiro vamos fazer um encapsulamento para que os atributos não possam ser usados em outras classes:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img19.png?raw=true)

#### Setando os atributos para private, não conseguimos utilizá-los em outras partes do programa, como por exemplo na main:

![](https://github.com/majuliah/ultimatePOOcSharp/blob/master/imgs/img20.png?raw=true)

#### Quando usamos atributos PRIVADOS, a convenção de nomenclatura muda para:

img 21

#### Sendo dessa forma, para conseguirmos acesso ao atributo em outras classes, seria necessário a criação de um método para acesso dessas infromações: 

img 22

#### E dessa forma conseguiríamos ter acesso aos atributos através dos métodos no main program: 

img 23

#### Agora para fazer a ALTERAÇÃO desses objetos, nós usaremos o método set:

img24

#### 



 



 

























































