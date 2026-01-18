#💄 ARmakeupAPP - Studio Virtual de Maquiagem
Aplicação móvel Android de Realidade Aumentada para teste virtual de cosméticos.

#📋 Sobre o Projeto
Este projeto é uma aplicação móvel desenvolvida para a disciplina de Computação Gráfica. O objetivo é transformar a experiência de teste de cosméticos (Virtual Try-On), permitindo que o usuário visualize aplicações de maquiagem realistas em tempo real ao utilizar a câmera frontal do celular como um espelho virtual.

A aplicação utiliza Realidade Aumentada com Rastreamento Facial (Face Tracking) para instanciar e mapear dinamicamente 8 objetos gráficos (camadas de textura) diferentes:

Batom 

Cílios 

Base 

Blush 

Contorno 

Sombra 

Delineador 

Iluminador 

#🖌️ Pipeline Gráfico
Como iniciativa opcional e diferencial do projeto, optou-se pelo desenvolvimento autoral de todos os ativos gráficos, dispensando o uso de assets prontos (Asset Store). O objetivo foi demonstrar domínio prático sobre a criação de texturas para malhas 3D.

O processo criativo seguiu este pipeline:

Malha de Referência: Utilização do modelo canonical_face_mesh.fbx (Google ARCore) como base para obter as coordenadas UV corretas.

Texture Painting: Pintura digital manual de cada camada utilizando o software Ibis Paint X, respeitando a distorção do mapa UV da face.

Mapeamento: Exportação em canais Alpha (PNG) para a correta sobreposição de materiais na Engine Unity.

🛠 Tecnologias Utilizadas
Engine Gráfica: Unity 2021.3.6f1

Framework AR: Unity AR Foundation

Plugin Android: Google ARCore XR Plugin

Design e Texturização: Ibis Paint X

#⚙️ Requisitos de Sistema
Para garantir a execução correta da Realidade Aumentada, o dispositivo deve atender aos seguintes critérios:

Sistema Operacional: Android 7.0 (Nougat) ou superior (API Level 24+).

Compatibilidade de Hardware: O dispositivo deve ser obrigatoriamente compatível com a tecnologia ARCore.

Software Adicional: É necessário ter o app Google Play Services para RA instalado e atualizado via Play Store.

#📖 Manual de Uso
Ao iniciar o aplicativo, siga os passos abaixo para a melhor experiência:

Iluminação: Certifique-se de estar em um ambiente bem iluminado. A detecção facial funciona melhor com luz direta no rosto.

Posicionamento: Segure o celular na vertical e aponte a câmera para o seu rosto (como se fosse tirar uma selfie).

O sistema identificará automaticamente os marcos faciais e aplicará a "malha invisível" de rastreamento.

Interação (Ativar/Desativar):

Toque uma vez no botão desejado para aplicar a textura de maquiagem.

Toque novamente no mesmo botão para remover a textura e voltar ao rosto limpo (limpar a seleção).

O sistema permite visualizar um componente estético por vez.

Movimentação: Pode virar o rosto levemente para os lados; a maquiagem acompanhará a rotação e a deformação da face (como ao falar ou abrir a boca).

#📲 Instalação e Teste (APK)
A versão compilada está disponível para avaliação.

Instruções:
Acesse a aba deste repositório.

Baixe o arquivo .apk da Versão Final.

Instale no dispositivo Android.

⚠️ IMPORTANTE: Ao abrir o app, conceda permissão de uso da CÂMERA. O rastreamento facial depende do feed de vídeo; sem isso, a tela ficará preta.

#👨‍💻 Autor
Desenvolvido por Marcos Vinícius Jansem Oliveira. Estudante de Computação Gráfica

#📄 Licença
Este software foi desenvolvido para fins acadêmicos e de avaliação (P3/P2).
