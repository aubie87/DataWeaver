using DataWeaver.Core.Models.Statement;

namespace DataWeaver.Generator.App;

/// <summary>
/// Helper class to create sample bank statement data for testing purposes
/// </summary>
public static class SampleStatementBuilder
{
    private static int _nextStatementId = 1001;
    private static int _nextAccountId = 100001;

    /// <summary>
    /// Creates a sample bank statement with checking and savings accounts
    /// </summary>
    /// <returns>A populated BankStatement object</returns>
    public static Statement CreateSampleStatement()
    {
        var statement = new Statement
        {
            StatementId = $"STMT-2024-{_nextStatementId++}",
            BankName = "First National Bank",
            StatementPeriodStart = new DateTime(2024, 1, 1),
            StatementPeriodEnd = new DateTime(2024, 1, 31),
            GeneratedDate = new DateTime(2024, 2, 1),
            Customer = new CustomerInfo
            {
                CustomerId = "CUST-12345",
                Name = "John Doe",
                PhoneNumber = "(555) 123-4567",
                EmailAddress = "john.doe@example.com",
                MailingAddress = new Address
                {
                    Street1 = "123 Main Street",
                    City = "Anytown",
                    State = "CA",
                    PostalCode = "12345",
                    Country = "USA"
                }
            }
        };

        // Add checking account
        var checkingAccount = new Account
        {
            AccountNumber = $"CHK-001-{_nextAccountId++}",
            AccountType = AccountType.Checking,
            AccountName = "Primary Checking",
            CurrentBalance = 2500.00m,
            AvailableBalance = 2350.00m,
            BeginningBalance = 2000.00m,
            EndingBalance = 2500.00m,
            TotalDeposits = 3000.00m,
            TotalWithdrawals = 2500.00m,
            InterestEarned = 0.00m,
            TotalFees = 0.00m,
            MinimumBalance = 1800.00m,
            MaximumBalance = 2500.00m,
            AverageDailyBalance = 2150.00m
        };

        // Add sample check transaction
        checkingAccount.CheckTransactions.Add(new CheckTransaction
        {
            TransactionId = "CHK-TXN-001",
            TransactionDate = new DateTime(2024, 1, 15),
            Amount = -125.00m,
            Description = "Check #1001 - Electric Bill",
            RunningBalance = 2375.00m,
            CheckNumber = "1001",
            DateWritten = new DateTime(2024, 1, 14),
            PayeeName = "City Electric Company",
            MemoLine = "Electric Bill - January",
            Status = CheckStatus.Cleared,
            ClearedDate = new DateTime(2024, 1, 15)
        });

        // Add sample general transactions
        checkingAccount.GeneralTransactions.Add(new GeneralTransaction
        {
            TransactionId = "GEN-TXN-001",
            TransactionDate = new DateTime(2024, 1, 1),
            Amount = 3000.00m,
            Description = "Direct Deposit - Salary",
            RunningBalance = 5000.00m,
            TransactionType = TransactionType.DirectDeposit,
            Category = "Income",
            MerchantName = "ABC Company",
            PostedDate = new DateTime(2024, 1, 1)
        });

        checkingAccount.GeneralTransactions.Add(new GeneralTransaction
        {
            TransactionId = "GEN-TXN-002",
            TransactionDate = new DateTime(2024, 1, 10),
            Amount = -50.00m,
            Description = "ATM Withdrawal",
            RunningBalance = 2450.00m,
            TransactionType = TransactionType.ATM,
            Category = "Cash",
            Location = "Main St ATM",
            ElectronicDetails = new ElectronicTransactionDetails
            {
                AtmId = "ATM-001",
                CardNumber = "****1234",
                AuthorizationCode = "123456"
            }
        });

        statement.Accounts.Add(checkingAccount);

        // Add savings account
        var savingsAccount = new Account
        {
            AccountNumber = $"SAV-001-{_nextAccountId++}",
            AccountType = AccountType.Savings,
            AccountName = "Primary Savings",
            CurrentBalance = 10000.00m,
            AvailableBalance = 10000.00m,
            BeginningBalance = 9500.00m,
            EndingBalance = 10000.00m,
            TotalDeposits = 500.00m,
            TotalWithdrawals = 0.00m,
            InterestEarned = 25.00m,
            TotalFees = 0.00m,
            MinimumBalance = 9500.00m,
            MaximumBalance = 10000.00m,
            AverageDailyBalance = 9750.00m
        };

        // Add interest payment
        savingsAccount.GeneralTransactions.Add(new GeneralTransaction
        {
            TransactionId = "INT-TXN-001",
            TransactionDate = new DateTime(2024, 1, 31),
            Amount = 25.00m,
            Description = "Interest Payment",
            RunningBalance = 10000.00m,
            TransactionType = TransactionType.Interest,
            Category = "Interest"
        });

        statement.Accounts.Add(savingsAccount);

        return statement;
    }
}