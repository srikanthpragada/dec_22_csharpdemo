using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.ef
{

    class BankContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }

    class Account
    {
        public int Id { get; set; }
        [StringLength (30)]
        public string Customer { get; set; }
        [Column(TypeName = "money")]
        public double Balance { get; set;}
        public List<Transaction> Transactions { get; set; }
    }

    class Transaction
    {
        public int Id { get; set; }
        public Account Account { get; set; }
        public int Type { get; set; }
        [Column ( TypeName = "money")]
        public double Amount { get; set; }
    }

    class  TestBank
    {
        public static void Main()
        {
            BankContext ctx = new BankContext();

            ctx.Accounts.Add(new Account { Id = 1, Customer = "Abc", Balance = 10000 });
            ctx.SaveChanges();

        }
    }
}
