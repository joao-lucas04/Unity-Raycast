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

<h1>personagem.cs</h1>
<img src="img/personagem_img.png">
<br>
Esta parte do script é responsável por declarar variáveis, armazenando informações como o Rigidbody do personagem, a velocidade de movimento, a sensibilidade do mouse, o raio para o Raycast e o objeto a ser instanciado quando um alvo é destruído.
<img src="img/personagem_img2.png">
<br>
Ainda no mesmo falando sobre o mesmo script, pode-se falar sobre: 

- if(Input.GetKeyDown(KeyCode.Space)): Este bloco de código é executado quando a tecla de espaço é pressionada.

- if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), 1.5f)): Aqui, estamos lançando um raio para baixo a partir da posição do personagem (transform.position). Se esse raio atingir algum objeto a uma distância máxima de 1.5 unidades, a condição é verdadeira.

- rb.AddForce(pulo * 2.0f, ForceMode.Impulse): Se o raio atingir um objeto, adicionamos uma força de pulo ao Rigidbody (rb) do personagem. O vetor de pulo (pulo) é multiplicado por 2.0 para aumentar a força do pulo, e ForceMode.Impulse indica que a força deve ser aplicada instantaneamente.

- Debug.Log("no ar"): Se o raio não atingir nenhum objeto, isso significa que o personagem está no ar e registramos uma mensagem de depuração.

- if(Input.GetMouseButton(0)): Este bloco de código é executado quando o botão esquerdo do mouse é pressionado.

- raio = Camera.main.ScreenPointToRay(Input.mousePosition): Aqui, criamos um raio que vai da câmera principal (Camera.main) até a posição atual do mouse na tela (Input.mousePosition).

- Lancar(raio): Chamamos a função Lancar passando o raio como argumento.

- private void Lancar(Ray raio): Esta função recebe um raio como entrada e é responsável por lidar com o Raycast para detectar e destruir alvos.

- if(Physics.Raycast(raio, out hit)): Aqui, lançamos um raio a partir da posição e direção fornecidas pelo raio passado como argumento. Se o raio atingir um objeto, a função retorna true e armazena informações sobre o objeto atingido na variável hit.

- string tag = hit.collider.tag;: Aqui, obtemos a tag do colisor do objeto atingido.

- if(tag == "Alvo"): Se o objeto atingido tiver a tag "Alvo", isso significa que é um alvo que deve ser destruído.

- Destroy(obj): Destruímos o objeto atingido.

- Instantiate(botao, hitPosition, Quaternion.identity): Instanciamos um novo GameObject a partir do prefab botao na posição do alvo destruído (hitPosition). Quaternion.identity indica que não aplicamos nenhuma rotação ao GameObject.

  




