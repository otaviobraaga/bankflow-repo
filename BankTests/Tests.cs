using NUnit.Framework;
using BankAccount;

namespace BankTests {
    [TestFixture]
    public class ContaBancariaTests {
        [Test]
        public void AddBalance_ShouldIncreaseBalance() {
            // Arrange
            ContaBancaria conta = new ContaBancaria();

            // Act
            string result = conta.add_balance(100);

            // Assert
            Assert.AreEqual("Saldo atual: 100.00", result);
        }

        [Test]
        public void WithdrawFunds_WithSufficientBalance_ShouldDecreaseBalance() {
            // Arrange
            ContaBancaria conta = new ContaBancaria();
            conta.add_balance(200);

            // Act
            string result = conta.withdraw_funds(50);

            // Assert
            Assert.AreEqual("Saldo atual: 150,00", result);
        }

        [Test]
        public void WithdrawFunds_WithInsufficientBalance_ShouldReturnErrorMessage() {
            // Arrange
            ContaBancaria conta = new ContaBancaria();
            conta.add_balance(50);

            // Act
            string result = conta.withdraw_funds(100);

            // Assert
            Assert.AreEqual("Saldo insuficiente ou valor inválido", result);
        }
    }
}