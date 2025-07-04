# Event

**Event** é um sistema desenvolvido em C# utilizando Windows Forms, como parte do projeto para a disciplina de Estrutura de Dados. Seu objetivo principal é proporcionar uma ferramenta local para criar, gerenciar e participar de eventos, **sem utilizar banco de dados**, armazenando todas as informações diretamente na memória principal do computador.

## 🎯 Proposta

O software visa, além de aplicar conceitos de estruturas de dados, oferecer uma plataforma para encontrar eventos de diversas categorias — dança, tecnologia, estudos, música, entre outros — em diferentes regiões. Também busca permitir que usuários interajam entre si e que colaboradores possam gerenciar eventos e participantes.

## 🔑 Funcionalidades principais

✅ **CRUD de eventos**  
✅ **Perfis de colaborador e usuário participante**  
✅ Usuário pode:
- Participar de eventos
- Comentar em comunidades
- Visualizar outros perfis
- Baixar certificado de participação

✅ Colaborador pode:
- Criar eventos
- Gerenciar participantes (marcar presença dos inscritos)

## 🖥️ Tecnologias utilizadas

- Linguagem: **C#**
- Interface: **Windows Forms**
- Plataforma alvo: **Windows**

## ⚙️ Execução do projeto

1. Clone o repositório ou baixe o projeto.
2. Abra a solução no **Visual Studio**.
3. Compile e execute.  
   - O sistema não depende de banco de dados ou arquivos externos.
   - Todos os dados são mantidos apenas em memória enquanto a aplicação está aberta.

## 👤 Perfis de acesso

- **Usuário participante**: pode explorar eventos, se inscrever, interagir em comunidades, ver perfis e baixar certificados.
- **Colaborador**: além das funções do usuário, pode criar e gerenciar eventos, controlando a presença dos participantes.

## 📦 Organização do código

O projeto segue o padrão MVC (Model-View-Controller) com o acréscimo da camada Repository, estruturado em:
- **Models**: classes que representam os dados do sistema, como usuários, colaboradores, eventos e comunidades.
- **Views**: formulários do Windows Forms que compõem a interface gráfica do usuário.
- **Controllers**: classes que implementam a lógica de negócio, processam as ações do usuário e coordenam a comunicação entre Views, Models e Repositories.
- **Repositories**: atuam como o “banco de dados” em memória, sendo responsáveis por armazenar, consultar, atualizar e remover informações enquanto a aplicação está em execução.

## 🚀 Futuras melhorias (ideias)

- Sistema de notificações para novos eventos
- Conexão de usuários
- Melhor organização de código

## 📝 Licença

Projeto acadêmico desenvolvido para fins educacionais. Sem licença comercial.


