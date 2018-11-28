1º Projeto de Linguagens de Programação II 2018/2019

António Louro a21702439
Hugo Martins a21701372

Repositório usado: https://github.com/DaPikachuOnMeth/lp2_2018_p1


António: Games, Library, Program, Render e Sorting
Hugo: Games, Library, Program, Render, README, UML e o fluxograma

Descrição da solução:
		  Este programa tem o objetivo de pegar no ficheiro 'games.cvs' e separar 
		os valores para as respetivas categorias (ID, Name, DLCCount, etc.)
		na classe 'FileManager.cs' , sendo esses valores organizados e verfica
		se o URL e DateTime são valores válidos em 'Games.cs'. Após organizar 
		os valores às suas respetivas categorias, essas	mesmas são lidas pelo
		'Library.cs', sendo depois filtrado pelas opções situadas em 'Sorting.cs'. 
	 	  Com isso em mente, o 'Program.cs' corre as classes 'Render.cs' para
	 	imprimir a interface e o 'FileManager.cs' para ler o ficheiro 'game.cvs',
	 	e dependendo da escolha do utilizador, ele escolhe um dos três modos de
	 	pesquisa ('Search by', 'Sort by' by e 'Search'), ou 0 para sair.
	 	  O 'Search by' procura o que o jogador meter, verificando os objetos que
	 	obdecem as condições dos filtros impostos pelo utilizador.
	 	  O 'Search' procura o que o utilizador meter nos filtro selecionado,
	 	procurando so nesse filtro. 

Referências: Slides das aulas, stackoverflow e código de outro colega devido 
			 a termos iniciado o porjeto antes de sabermos que o projeto só
			 podia ser a pares.

Conclusão: Este projeto não foi tão complexo como se esperava, aplicando matéria
 		   recente que poupou muito código grande e repetido com o lambda.

(Ficheiros incluídos: 'UML.jpg' e 'Fluxograma.jpg')