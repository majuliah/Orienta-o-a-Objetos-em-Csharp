# Curso de Programação Orientada a Objetos em C# 🧐

![](https://media4.giphy.com/media/XWeJDaxYa1YrK/giphy.gif?cid=790b7611d487ab85cbd494f6f53469b48da90b21dd6538e8&rid=giphy.gif&ct=g)





## Um pouco sobre C# e .NET:

#### O .net é uma plataforma de desenvolvimento que suporta diferentes linguagens de programação, como o C#, por exemplo.

- #### BCL: Base Class Library -> é uma biblioteca(conjunto de funcionalidades) base que ajuda no desenvolvimento

- #### CLR: Common Language RunTime -> Máquina Virtual que executa os programas feitos em .NET e possui garbage collection, onde o programa desaloca os recursos que não estão sendo utilizados.



## CLR:

#### Linguagens compiladas são aquelas que dependem de um compilador, específico para cada sistema operacional para ser compilada. C++ é um exemplo. Ela é compilada, e dessa forma é gerado um arquivo executável para a execução daquele programa. Uma vez executada, roda muito mais rápido. 

#### Linguagens Interpretadas são aquelas que possuem possuem um interpretador que gradualmente vai fazendo a execução do arquivo. O mesmo código roda em diferentes sistemas, mas precisamos de um interpretados específico para cada um (sistema). Vantagem é a manutenção e a desvantagem é que é mais lento que a compilação. 

#### Híbrida: Escrevemos um programa no código fonte da linguagem(tipo o c#) e o código passa por um processo de pré compilação, gerando um código intermediário, bytecode, chamada CIL Common Intermediate Language que é universal para quaisquer linguagens escritas na plataforma. O bytecode garante a integridade dos códigos escritos e ele pode ser rodado em diferentes sistemas, com diferentes plataformas de execução. A CLR é uma platafroma que interpreta a pré-compilação. 





#### Escrevemos o código na linguagem fonte -> Programa é transferido pra pré-compilação que gera um código na linguagem intermediária (CIL) -> o CIL roda em cima de uma máquina virtual, a CLR -> Código Convertido em código de máquina e é reproduzido no sistema



## ESTRUTURA DE ARQUIVOS:

#### Um projeto C# é uma solução. Ele tem a extensão .sln e é por ele que abrimos o projeto. 

#### O arquivo de extensão .csproj é um arquivo de configuração das extensões do projeto.

#### O arquivo de extensão .cs é o código em C#, onde você coloca as resoluções. 

#### A pasta bin e obj são as pastas de compilação, onde são guardados os arquivos de execução.



### Uma aplicação em C# é composta por classes, que podem ser agrupadas em namespaces(agrupamento lógico de classes relacionadas). 

### Assembly é uma build, um DLL ou EXE da aplicação = agrupamento físico de classes relacionadas. O projeto pode ser dividido em subsistemas.

### Aplicação é um sistema de assemblies relacionados



















































