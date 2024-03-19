<h1 align="center">Olá 👋, somos João Lucas e Filipe Custódio</h1>
<h2 align="center">Atividade de LP - Unity Raycast</h2>

- LINK PARA O PROJETO NO DRIVE: [https://drive.google.com/drive/folders/1P460PHkBUXLBYklIy_QJibNZia2AmqxJ?usp=sharing](https://drive.google.com/drive/folders/1P460PHkBUXLBYklIy_QJibNZia2AmqxJ?usp=sharing)

<h2>Ferramentas Utilizadas:</h2> 
<p align="left"> <a href="https://www.w3schools.com/cs/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" width="40" height="40"/> </a> <a href="https://unity.com/" target="_blank" rel="noreferrer"> <img src="https://www.vectorlogo.zone/logos/unity3d/unity3d-icon.svg" alt="unity" width="40" height="40"/> </a> </p>

<h2>Andamento do projeto:</h2> 
Concluído

<h2>Descrição do Projeto:<h2>
Projeto se trata sobre a elaboração de uma cena teste no Unity, que aplique os conceitos de Raycast, Prefabs e Destroy dentro da game Engine

<h1>Explicação dos Scripts:</h1>
<h1>visao.cs</h1>
<img src="img/visao_unity.png">
<img src="img/visao_img.png">
<br>
Este script faz com que o jogador controle a rotação da câmera usando o mouse, proporcionando uma experiência de visualização mais interativa. Descrição das linhas do código a seguir:

 - Nas linhas 3, 4 e 5 temos uma declaração de variáveis que tem o objetivo de determinar a velocidade com que a câmera irá girar em resposta ao movimento do mouse.
 
 - Na linha 13, atualizamos a variável 'mouseX', adicionando a mudança na posição do mouse ao longo do eixo X, multiplicada pela sensibilidade. Isso permite que a câmera gire horizontalmente conforme movemos o mouse para a esquerda ou direita.
   
 - Na linha 14, temos algo muito semelhante a linha 13, porém o sinal negativo é usado aqui para permitir que a câmera gire verticalmente conforme movemos o mouse para cima ou para baixo.

 - Na linha 16, pode-se notar a rotação da câmera com base nas variáveis mouseX e mouseY. Isso cria um efeito de olhar livre, onde a câmera pode se mover livremente em torno do objeto alvo, mas não estamos aplicando rotação no eixo Z (0), o que significa que a câmera não irá rolar para fora da cena. 




