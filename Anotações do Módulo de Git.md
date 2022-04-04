# 🪂Anotações do Módulo de Git :octocat:

👾 git diff    -> vê alterações de um arquivo pelo terminal

💀 git reset   -> tira o commit do staged e desfaz o add .
assim pode ser feito um novo git add e commitar novamente

🤖 git checkout + o código hash -> deixa o código exatamente do 
ponto onde o commit foi feito

🎏 git checkout main -> traz o arquivo para o estado normal, do último commit feito

🌌 git checkout HEAD~ X -> o X diz quantos commits você quer refazer.
se for git checkout HEAD~ 2, voltaremos 2 commits da branch

💫  NÃO SE MODIFICA OS ARQUIVOS DO CHECKOUT, isso pode gerar problemas de versionamento 
e pode ferir a integridade do código. 

☃️SE MODIFICARMOS, SEGUIR OS PASSOS:
Desfazer as modificações:

🌈 git reset -> reseta modificações
🌬️ git clean -df -> limpa as modificações das branchs
🏯 git checkout -- . -> limpa modificações

🗽agora sim podemos dar um git checkout main
e reverter para o último commit salvo



🔮 Como sair do editor VIM: **

🌸deu git commit sem o -m + comment???
🪂abriu o VIM????

🪅Habilita o modo de edição pressionando : i
🧸Sair do VIM salvando as alterações:

🧩Tecla ESC
🕌 :wq
🎡Tecla ENTER

🧮Sair do VIM SEM SALVAR ALTERAÇÕES:
📍Tecla ESC
🍁 :q!
🪐 Tecla ENTER
