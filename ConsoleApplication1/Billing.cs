using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Billing
    {
        // список пользователей со счетами
        List<account> accounts = new List<account>();
        
        int status = 0;
        //object add
        public IUser addUser(string l, string p)
        {
            IUser user = new IUser(l,p);
            accounts.Add(new account(user,0));
            return user;
        }
        //object delete
        bool userDelete(IUser user)
        {
            account account = accounts.Find(acc => acc.user == user);
            return accounts.Remove(account);
        }
        //object handlers
        //возвращает сумму пополнения меняет статус найденного аккаунта пользователя
        decimal userPay(IUser user, decimal money)
        {
            if (accounts.Find(acc => acc.user == user) == null)
                account.status = "not enoth money";
                return 0;
                account acc = accounts.Find(acc => acc.user == user);
                acc.money += money;
            return money;
        }
        double userCalculate(IUser user, int operation)
        {
            double value = operation_money[operation];
            if (value > account.money)
                return 0;
            account.money -= value;
            return value;
        }

        bool userBlock(IUser user)
        {
            if(accounts.Find(acc => acc.user == user) == null)
                return false;
            return true;
        }
    }
}
