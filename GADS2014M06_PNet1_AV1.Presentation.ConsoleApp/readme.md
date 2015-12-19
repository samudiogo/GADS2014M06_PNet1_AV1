# Prova de .NET I - Paulo Mau

## Questões da prova:

> Um cliente pediu para que fosse feito um aplicativo, para o controle de séries de tv.
> Ele deseja controlar todas as séries que ele já baixou e já viu. As séries possuem > Sessões e seus respectivos Episódios.
> Ele gostaria de guardar as seguintes informações:

### Série:
> Nome, criador, País (PaisId), Gênero (GeneroId), sinopse, qual o Canal de TV (CanalDeTvId) oficial que apresenta a série, qual o dia da semana e horário do episódio e uma foto de capa (caminho da foto).

> ##### País, Gênero e Canal de Tv, também devem ser mantidos. Devem possuir pelo menos duas propriedades.
### Sessões:
> As sessões deverão ter um "número" (S01, S02 e etc.), data do lançamento da sessão, sinopse, foto de capa para a sessão (caminho da foto), Série (SerieId).
### Episódio:
> Para cada episódio, você deve ter o título, "número" (E01, E02, E03 e assim por diante...), sinopse, data que o episódio foi ao ar, duração, se baixou, se viu, caminho completo onde se encontra o arquivo, Tipo de arquivo (que deve ser mantido - mp4, mkv...), se é dublado ou legendado, Sessão da série a qual pertence (SessaoId).

#### Como ainda não apresentei uma forma de relacionar as classes entre si. A forma de vincular uma classe na outra deve ser feita pelo ID


##### Então, para isso você vai:

1 - Construir uma solução

2 - Organizar os projetos em pastas de solução (Apresentação e Domínio)

3 - Criar um projeto "Console Application" e um projeto "Class Library"

4 - Não esqueça de adicionar a referência do projeto "Class Library" no projeto "ConsoleApp"

5 - Organizar as entidades e demais classe em pastas, quando necessário.

6 - Criar as classes de entidades

7 - No Console Application, você deve:

*  instanciar um País e apresentar na tela seus dados. Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
*  instanciar um Gênero e apresentar na tela seus dados. Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
*  instanciar um "Canal de Tv" e apresentar na tela seus dados. Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
* instanciar uma Série e apresentar na tela seus dados. Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
* instanciar uma Sessão e apresentar na tela seus dados. Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
* instanciar um Episódio e apresentar na tela seus dados. Acrescente uma instrução que me permita ler a informação, antes de prosseguir.

#### O projeto deve estar compilando e funcionando.

>Compacte a pasta da solução em ZIP e como deverá ser maior que o permitido pelo Moodel, você deve disponibilizar em GoogleDrive, OneDrive, DropBox e me encaminhar o link para donwload. Envie o link dentre de um txt que deverá ser encaminhado como resposta a esta tarefa.

###### Nome base a ser utilizado pela solução e projetos: GADS2014M06_PNet1_AV1, que deve ser utilizada combinando com demais termos apresentados em sala: solução, apresentação, domínio e etc.

---
# Resultado do codigo compilado:
````cmd
País:
Id: 1   Nome: Brasil

Gênero:
Id: 2 - Descrição: Drama

Canal de TV:
id: 1    - Descricao: AXN

Serie:
Id:1     - Nome: CSI .NET
Sinopse: O Detetive samuel ajuda a turma mas não termina p@rra da prova
Criador: Supremo Samuel Diogo    | Data: 27/06/2015 20:28:14
Capa:c:\imagem.png
GeneroId: 2      | PaisId: 1     | CanalTVid: 1


Temporada (Sessão):
Id: S01 | Data: 19/04/2014 20:28:16
Sinopse: nesta temporada muita coisa pode ou não acontecer..
Capa: C:\capa_sessao1.png
SerieId: 1
Episódio:
Id: E01 - Titulo: a volta dos que nao foram p2
Sinopse: acontece que aconteceu o que tinha que acontecer
Data: 04/12/2015 20:28:19       | Duração: 90min        | TIpo Arquivo: mkv
Formato audio: Legendado

Press any key to continue . . .
```
