# Project_cesa

## Sobre o projeto

Project_CESA é uma aplicação construida para gerenciamento escolar.
Com foco na parte acadêmica e financeira. Utilizando a linguagem de programação `C#` e banco de dados `MySQL`.
Sistemas de relatórios utilizando `Report Viewer`, conversão para PDF com a biblioteca `iTextSharp` e captura de imagem com `Aforge`.

# Tecnologias utilizadas
## Back end
- C# 
- MySQL - Banco de dados.
- Report Viewer - Biblioteca para geração de relatórios
- iTextSharp - Biblioteca para conversão para PDF.
- Aforge - Biblioteca de captura de imagens e stream.

## Front end
- C#
- Windows Forms
- MessageBox

## Implantação em produção
- MysqlData - v8.0.23
- Visual Studio Community 2022 - v17
- Aforge - v2.2.5
- Report Viewer - v150.1537.0
- Git - v3.9
- Github

# Como executar o projeto
## Back end
Pré-requisitos:
- .Net-4.7.2
- Mysql-for-visualstudio-1.2.9
- Mysql-installer-community-8.0.16.0


```bash
# clonar repositório
git clone https://github.com/jeffassis/project_cesa.git
## Front end web
Pré-requisitos: SDK .NET-4.7.2
# Criar sistema com dependencia do Projeto
dotnet new winforms
# Após a instalação criar uma pasta chamada 'cesa' no caminho:
C:\cesa
# Após criar mais 2 pastas dentro da 'cesa' com os nomes 'dados' e 'img':
C:\cesa\dados
C:\cesa\img
```

# Feature exploradas

- Utilizar `CRUD`.
- Estilizar formulário.
- Utilização de um arquivo `Conexao` para acesso as funções do `DB`.
- Validação de usuário.
- Utilização de keybind para acesso rápido.
- Criação de nivéis de acesso dentro do sistema.
- Geração de relatórios `Report Viewer`.
- Conversão de relatórios `iTextSharp`.
- Captura e Stream de imagens com `Aforge`.


# Autor

Jefferson Assis de Souza

- Linkedin - [jeffassis](https://www.linkedin.com/in/jefferson-assis-de-souza-bb157297/)