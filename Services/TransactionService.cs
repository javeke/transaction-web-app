using WebService.Models;

namespace WebService.Services;

public static class TransactionService {
    static List<Transaction> transactions { get; }

    static int nextId = 1002;

    static TransactionService() {
        transactions = new List<Transaction> {
            new Transaction { id = 1001, firstName = "Javier", lastName = "Bryan", stock = "ONE", orderType = "SELL" }
        };
    }

    public static List<Transaction> getTransactions() => transactions;

    public static Transaction? getTransaction(int id) => transactions.Find( transaction => transaction.id == id );

    public static void add(Transaction transaction) {
        transaction.id = nextId++;
        transactions.Add(transaction);
    }   

    public static void delete(int id){
        Transaction? transaction = getTransaction(id);

        if(transaction is null) {
            return;
        }

        transactions.Remove(transaction);
    }

    public static void update(Transaction transaction) {
        int index = transactions.FindIndex( t => t.id == transaction.id);
        if (index == -1) {
            return;
        }

        transactions[index] = transaction;
    }
}