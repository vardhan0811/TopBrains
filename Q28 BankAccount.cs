using System;


public class BankAccount
{
    /// <summary>
    /// Calculates the final balance after applying deposits and withdrawals to the initial balance.
    /// Withdrawals that would overdraw the account are ignored.
    /// </summary>
    /// <param name="initialBalance">The starting balance of the account.</param>
    /// <param name="transactions">An array of transaction amounts (positive for deposit, negative for withdrawal).</param>
    /// <returns>The final balance after all valid transactions.</returns>
    public static int GetFinalBalance(int initialBalance, int[] transactions)
    {
        int finalBalance = initialBalance;
        foreach (int amount in transactions)
        {
            if (amount >= 0)
            { 
                finalBalance += amount; // Deposit: add to balance
            }
            else
            {
                int withdrawAmount = -amount; // Convert to positive for withdrawal
                if (finalBalance >= withdrawAmount)
                {
                    finalBalance -= withdrawAmount; // Withdraw only if sufficient balance
                }
                // If not enough balance, withdrawal is ignored
            }
        }
        return finalBalance;
    }
}