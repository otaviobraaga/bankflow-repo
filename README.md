## 1. Introdução:

O projeto Bankflow é um sistema bancário básico escrito em C#. Ele permite gerenciar contas bancárias, realizar depósitos, saques e transferências de fundos.

### 2. Arquitetura:

O projeto é dividido em três namespaces principais:

BankAccount: Contém a classe ContaBancaria que representa uma conta bancária com atributos como número, nome do proprietário, saldo e métodos para realizar operações financeiras.
TransferFunds: Contém a classe Transfer que representa uma transferência de fundos entre contas bancárias.
Program: Contém o programa principal que executa o sistema e permite aos usuários interagir com as contas.
### 3. Execução:

Para executar o projeto, siga estas etapas:

Clone o repositório GitHub:
git clone https://github.com/otaviobraaga/bankflow-repo
Abra a solução no Visual Studio 2022.

Selecione o projeto Bankflow e execute-o.

### 4. Funcionalidades:

Criação de contas bancárias: Digite o número da conta, nome do proprietário e valor do depósito inicial para criar uma nova conta.
Depósitos: Digite o valor a ser depositado para adicionar fundos à conta.
Saques: Digite o valor a ser sacado para remover fundos da conta.
Transferências: Digite as informações do remetente, do beneficiário e o valor a ser transferido para realizar uma transferência entre contas.
### 5. Comandos:

Criar conta: criar-conta [número da conta] [nome do proprietário] [saldo]
Depositar: depositar [número da conta] [valor]
Sacar: sacar [número da conta] [valor]
Transferir: transferir [número da conta remetente] [número da conta beneficiário] [valor]
### 6. Exemplos:

criar-conta 1234-5678 Fulano 100
depositar 1234-5678 50
sacar 1234-5678 20
transferir 1234-5678 9876-5432 10
### 7. Limitações:

O projeto ainda está em desenvolvimento e pode apresentar bugs.
A interface de usuário é baseada em texto e pode ser melhorada.
A documentação está incompleta e precisa ser expandida.
