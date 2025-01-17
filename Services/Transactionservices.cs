using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_MAUI.Components.Model;

public class TransactionService
{
    private readonly List<Transaction> _transactionList;

    public TransactionService(List<Transaction> transactionList)
    {
        _transactionList = transactionList;
    }

    public decimal GetTotalCashIn() =>
        _transactionList.Where(t => t.Type == "CashIn").Sum(t => t.Amount);

    public decimal GetTotalCashOut() =>
        _transactionList.Where(t => t.Type == "CashOut").Sum(t => t.Amount);

    public decimal GetPendingDebts() =>
        _transactionList.Where(t => t.IsDebt).Sum(t => t.Amount);

    public decimal GetCashInOutRatio()
    {
        decimal cashIn = GetTotalCashIn();
        decimal cashOut = GetTotalCashOut();
        return cashOut == 0 ? 0 : cashIn / cashOut;
    }

    public List<Transaction> GetMonthlyTransactions(DateTime month) =>
        _transactionList.Where(t => t.Date.Month == month.Month && t.Date.Year == month.Year).ToList();

    public int CompareMonthlyTransactions(DateTime currentMonth)
    {
        var current = GetMonthlyTransactions(currentMonth).Count;
        var previous = GetMonthlyTransactions(currentMonth.AddMonths(-1)).Count;
        return current - previous;
    }
}

