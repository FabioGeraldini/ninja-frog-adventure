# 🐸 Ninja Frog Adventure

> Jogo de plataforma 2D desenvolvido na Unity 6.4 como projeto final da disciplina de Game Development — UniFECAF 2026.

---

## 🎮 Sobre o Jogo

**Ninja Frog Adventure** é um jogo de plataforma 2D onde você controla um sapo ninja que deve coletar todas as frutas de cada fase para liberar o troféu e avançar para o próximo nível.

O jogo possui **3 fases** com dificuldade progressiva, sistema de pontuação, vidas, efeitos sonoros e trilha sonora.

---

## 🕹️ Controles

| Tecla | Ação |
|-------|------|
| ← → ou A D | Mover para esquerda/direita |
| Espaço | Pular |
| Botão Sair | Fechar o jogo |

---

## 📋 Fases

| Fase | Descrição | Dificuldade |
|------|-----------|-------------|
| Nível 1 | Plataformas próximas, frutas acessíveis | ⭐ Fácil |
| Nível 2 | Plataformas com caixas, espaçamento maior | ⭐⭐ Médio |
| Nível 3 | Plataformas pequenas e muito espaçadas | ⭐⭐⭐ Difícil |

---

## ✅ Mecânicas Implementadas

- Movimentação horizontal e pulo responsivos
- Personagem vira para o lado do movimento
- Sistema de coletáveis com pontuação (+10 por fruta)
- Troféu aparece somente após coletar todas as frutas
- Transição automática entre os 3 níveis
- Sistema de vidas (3 vidas) com respawn ao cair do mapa
- HUD com pontuação e vidas em tempo real
- Câmera que segue o personagem suavemente
- Trilha sonora contínua entre os níveis
- Efeitos sonoros de pulo e coleta
- Botão de sair em todas as fases

---

## 🛠️ Tecnologias Utilizadas

- **Engine:** Unity 6.4 (Universal 2D)
- **Linguagem:** C#
- **IDE:** Visual Studio Code
- **Assets:** Pixel Adventure (itch.io) + Kenney Pixel Platformer
- **Áudio:** OpenGameArt + FreeSound

---

## 📁 Estrutura do Projeto

```
Assets/
├── Animations/       # Animator Controllers e clips de animação
├── Audio/            # Trilha sonora e efeitos sonoros
├── Scenes/           # Level1, Level2, Level3
├── Scripts/          # Scripts C#
│   ├── PlayerController.cs
│   ├── GameManager.cs
│   ├── Collectible.cs
│   ├── LevelExit.cs
│   ├── CameraFollow.cs
│   └── ExitGame.cs
├── Sprites/          # Todos os assets visuais
│   ├── Free/         # Pixel Adventure assets
│   └── Tiles/        # Kenney tiles
└── Tiles/            # Tile assets configurados
```

---

## 🚀 Como Executar

### Executável (Windows)
1. Baixe a pasta `Build` 
2. Execute o arquivo `PlatformerGame.exe`
3. Aproveite o jogo!

### No Editor Unity
1. Clone este repositório
2. Abra o Unity Hub e adicione o projeto
3. Abra a cena `Scenes/Level1`
4. Pressione Play ▶

---

## 📜 Scripts — Descrição

### `PlayerController.cs`
Controla toda a movimentação do personagem. Usa o novo Input System do Unity 6 para capturar entradas do teclado. Gerencia pulo, movimento horizontal, virar o sprite e detecção de queda do mapa.

### `GameManager.cs`
Singleton que persiste entre cenas com `DontDestroyOnLoad`. Gerencia pontuação, vidas, contagem de coletáveis e ativação do troféu. Controla a trilha sonora contínua.

### `Collectible.cs`
Detecta colisão via trigger com o personagem. Ao coletar, reproduz o som, notifica o GameManager e destrói o objeto.

### `LevelExit.cs`
Gerencia a transição entre níveis via `SceneManager.LoadScene()`. O nome da próxima cena é configurável no Inspector.

### `CameraFollow.cs`
Câmera que segue o personagem com interpolação linear (`Vector3.Lerp`) no método `LateUpdate()`.

### `ExitGame.cs`
Fecha o jogo via `Application.Quit()`. No editor Unity usa `EditorApplication.isPlaying = false`.

---

## 🎨 Créditos dos Assets

- **Personagem e itens:** [Pixel Adventure 1](https://pixelfrog-assets.itch.io/pixel-adventure-1) — Pixel Frog (gratuito)
- **Tiles de cenário:** [Pixel Platformer](https://kenney.nl/assets/pixel-platformer) — Kenney (CC0)
- **Áudio:** OpenGameArt.org e FreeSound.org (licença gratuita)

---

## 📚 Referências

- [Unity Documentation](https://docs.unity3d.com)
- [Unity Learn — Get Started](https://unity.com/pt/learn/get-started)
- [Sentry Unity Tutorial](https://blog.sentry.io/unity-tutorial-developing-your-first-unity-game-part-1/)

---

## 👨‍💻 Autor

Desenvolvido como projeto final da disciplina de **Game Development**  
**UniFECAF — 2026**
