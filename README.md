# DesktopBiblioteca

Sistema de biblioteca desenvolvido em C# .NET 3.1 com Windows Forms.

## 📌 Sobre o Projeto

Este sistema permite o gerenciamento de uma biblioteca, incluindo funcionalidades para:
- Cadastro de livros
- Registro de usuários
- Empréstimo e devolução de livros
- Autenticação de usuários

O projeto utiliza **ADO.NET** para comunicação com um banco de dados **SQL Server**.

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C#
- **Framework:** .NET Core 3.1
- **Interface:** Windows Forms
- **Banco de Dados:** SQL Server
- **ORM:** ADO.NET

## 📌 Pré-requisitos

Para rodar o projeto, você precisará ter instalado:
- .NET Core 3.1 SDK
- SQL Server
- Visual Studio (recomendado)

## 🚀 Como Executar o Projeto

1. Clone o repositório:
   ```sh
   git clone https://github.com/seu-usuario/biblioteca-app.git
   ```
2. Abra o projeto no **Visual Studio**.
3. Configure a string de conexão com o SQL Server em `app.config`.
4. Execute o script `ScriptBanco.sql` para criar o banco de dados.
5. Compile e execute o projeto.

## 🔐 Autenticação

O sistema possui um módulo de login, onde os usuários devem fornecer credenciais válidas para acessar as funcionalidades.

## 🛠️ Contribuição

Se quiser contribuir com o projeto:
1. Faça um fork do repositório
2. Crie uma nova branch (`git checkout -b minha-feature`)
3. Faça suas alterações e commit (`git commit -m 'Minha nova feature'`)
4. Envie para o repositório remoto (`git push origin minha-feature`)
5. Abra um Pull Request

## 📄 Licença

Este projeto está sob a licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

💡 **Dúvidas ou sugestões?** Fique à vontade para abrir uma issue ou entrar em contato!

