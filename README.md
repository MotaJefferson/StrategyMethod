# Sistema de Pagamento com Padrão Strategy

Este projeto implementa um sistema de pagamento flexível em C# utilizando o padrão de projeto Strategy. O objetivo é permitir a fácil adição e manutenção de diferentes métodos de pagamento (dinheiro, cartão de crédito, cartão de débito e PIX), promovendo uma arquitetura extensível e modular.

## 📜 Descrição do Projeto

Em sistemas de pagamento, é comum a necessidade de oferecer múltiplas opções para que o cliente escolha a que mais se adequa às suas preferências. Neste projeto, usamos o padrão Strategy para encapsular a lógica de cada método de pagamento em classes independentes, permitindo adicionar novas opções de pagamento sem modificar a estrutura principal.

### Motivação e Problemas Resolvidos

- **Separação de Preocupações**: Cada método de pagamento possui sua própria implementação, facilitando a manutenção.
- **Extensibilidade**: Novos métodos podem ser adicionados sem alterar o código existente.
- **Flexibilidade em Tempo de Execução**: O método de pagamento pode ser escolhido dinamicamente, melhorando a experiência do usuário.

## 🚀 Funcionalidades

O projeto está estruturado em classes seguindo o padrão Strategy:

- **Escolha de Método de Pagamento**: Permite selecionar entre quatro métodos (dinheiro, crédito, débito e PIX).
- **Processamento de Pagamento**: Executa o pagamento com base na escolha do usuário.
- **Arquitetura Modular**: Facilita a adição de novos métodos de pagamento.

## 🛠️ Tecnologias

- **C#**
- **Padrão de Projeto Strategy**

  
