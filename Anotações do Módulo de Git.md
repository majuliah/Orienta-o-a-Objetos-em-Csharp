# 🪂Anotações do Módulo de Git :octocat:

####  👾 git diff    -> vê alterações de um arquivo pelo terminal

####  💀 git reset   -> tira o commit do staged e desfaz o add .

####  assim pode ser feito um novo git add e commitar novamente

####  🤖 git checkout + o código hash -> deixa o código exatamente do 
####  ponto onde o commit foi feito

####  🎏 git checkout main -> traz o arquivo para o estado normal, do último commit feito

####  🌌 git checkout HEAD~ X -> o X diz quantos commits você quer refazer. 

####  se for git checkout HEAD~ 2, voltaremos 2 commits da branch

####  💫  NÃO SE MODIFICA OS ARQUIVOS DO CHECKOUT, isso pode gerar problemas de versionamento 
#### e pode ferir a integridade do código. 

#### ☃️SE MODIFICARMOS, SEGUIR OS PASSOS:
#### Desfazer as modificações:

#### 🌈 git reset -> reseta modificações
#### 🌬️ git clean -df -> limpa as modificações das branchs
#### 🏯 git checkout -- . -> limpa modificações

#### 🗽agora sim podemos dar um git checkout main
#### e reverter para o último commit salvo



#### 🔮 Como sair do editor VIM: **

#### 🌸deu git commit sem o -m + comment???
#### 🪂abriu o VIM????

#### 🧩Habilita o modo de edição pressionando : i
#### 🧸Sair do VIM salvando as alterações:

#### 🧩Tecla ESC
#### 🕌 :wq
#### 🎡Tecla ENTER

#### 🧮Sair do VIM SEM SALVAR ALTERAÇÕES:

#### 📍Tecla ESC

#### 🍁 :q!

####  🪐 Tecla ENTER



#### 😶‍🌫️APAGANDO UM COMMIT SEM DESFAZER AS ALTERAÇÕES JÁ FEITAS

#### ✍️ git reset --soft HEAD~1

#### 🧯estamos voltando para o último commit mas em uma versão soft, que não apaga os commits :)

#### 🌌APAGANDO UM COMMIT E LEVANDO AS ALTERAÇÕES JUNTO

#### ✍️git reset --hard <hash do commit> 

#### OU

#### ✍️git reset --hard HEAD~1 (ou o número do último commit)

#### ☄️💥⛔ NÃO TEM COMO RETOMAR OS COMMITS E ARQUIVOS APAGADOS ☢️☣️

🪂Para froçar o github a manter a mesma estrutura de arquivos que o seu repo local que acabou de perder arquivos, é só dar um

🚩git push -f -> você estpa forçando a dar um push nas condições especificadas



```
🌌git remote set-url origin https://github.com/majuliah/nome-do-repositorio.git
```

💥Este comando a cima vai adicionar um repositório já existente para um novo. Ou seja, o projeto aponta para um novo.
