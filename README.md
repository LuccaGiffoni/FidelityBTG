# Teste Técnico | Cadastro de Clientes BTG Pactual
Bem-vindo ao teste técnico do BTG Pactual! Neste projeto, desenvolvi um aplicativo de cadastro de clientes utilizando .NET Maui na versão 8, com todas as vantagens da arquitetura MVVM.

## Requisitos
Os requisitos do teste foram:

1. Utilização do padrão MVVM (Model View ViewModel).
2. Implementação da classe `Client` com os seguintes atributos:
   - Nome (Name)
   - Sobrenome (Lastname)
   - Idade (Age)
   - Endereço (Address)
3. Tela inicial com lista de clientes e operações de inclusão, exclusão e alteração.
   - As telas referentes a essas operações devem abrir em uma nova janela e fechar ao cancelar a operação ou salvar a inclusão/alteração.
   - Para exclusão, pode ser utilizado uma mensagem de confirmação ou uma janela personalizada.
4. Utilização de injeção de dependência.
5. Publicação em um repositório privado no Github.com.

Todos os requisitos foram rigorasamente cumpridos e ainda adicionei mais coisas na classe de `Client`, com validações automáticas e facilitadas.

## Opcionais
1. Persistência dos dados para que, ao executar novamente o aplicativo, os dados possam ser carregados e manipulados, usando o SQLite como banco de dados interno da aplicação.
2. Verificação do tipo de dado digitado em cada campo: todos os campos receberam a validação durante a inserção dos dados por parte do usuário para evitar qualquer tipo de erro.

## Instruções de Uso
1. Clone este repositório em seu ambiente local.
2. Abra a solução no Visual Studio ou em outro ambiente de desenvolvimento compatível com .NET Maui.
3. Execute o aplicativo e teste as funcionalidades conforme descrito nos requisitos.

## Testes da última release
Os testes da aplicação também podem ser testados em máquinas Windows, ao baixar o .zip da última release liberada, instalando em side-load e autenticando com um novo certificado.
