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























































