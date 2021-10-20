using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5and6
{
    public class UsersList
    {
        public static event SuccessLoginDelegate SuccesLogin;
        public static event UnsuccessLoginDelegate UnsuccesLogin;
        public static event LogOutDelegate LogOutE;
        public static event UnsuccesWithdrawalDelegate UnsuccesWithdrawal;
        public static event UnsuccesDepositDelegate UnsuccesDeposit;
        public static event RefreshDelegate Refresh;

        static List<User> users = new List<User>()
        {
            new User(){Username = "usama1", Password = "05071", TotalAmount = 1254.12},
            new User(){Username = "usama2", Password = "05072", TotalAmount = 125.58},
            new User(){Username = "usama3", Password = "05073", TotalAmount = 458745.94},
            new User(){Username = "usama4", Password = "05074", TotalAmount = 10.25}
        };

        public static int totalAmountDeposited = 0;

        public static bool Login(string username, string password)
        {
            foreach (User user in users)
            {
                if (username == user.Username)
                {
                    if (password == user.Password)
                    {
                        user.isLogin = true;
                        OnSuccesLogin(user);
                        return true;
                    }
                    else
                    {
                        OnUnsuccesLogin(FailedLoginReasonsEnum.WrongPassword);
                        return false;
                    }
                }
            }
            OnUnsuccesLogin(FailedLoginReasonsEnum.UserNameDoesNotExist);
            return false;
        }

        public static void LogOut(User user)
        {
            user.isLogin = false;
            OnLogOutE(user);
        }

        public static void Withdrawal(int amount, User user)
        {
            if (amount % 100 != 0)
            {
                OnUnsuccesWithdrawal(FailedWithdrawalReasonsEnum.WithdrawalAmountMustBeBanknotesOfAHundred);
            }
            else if(user.TotalAmount  < amount)
            {
                OnUnsuccesWithdrawal(FailedWithdrawalReasonsEnum.NotEnoughAmount);
            }
            else
            {
                user.TotalAmount -= amount;
            }
            OnRefresh();
        }

        public static void Deposit(int amount, User user)
        {
            if (amount % 100 != 0)
            {
                OnUnsuccesDeposit(FailedDepositReasonsEnum.DepositAmountMustBeBanknotesOfAHundred);
            }
            else
            {
                user.TotalAmount += amount;
                totalAmountDeposited += amount;
            }
            OnRefresh();
        }

        private static void OnSuccesLogin(User user)
        {
            if (SuccesLogin != null)
            {
                SuccesLogin(user);
                user.isLogin = true;
            }
        }

        private static void OnUnsuccesLogin(FailedLoginReasonsEnum failedLoginReason)
        {
            if (UnsuccesLogin != null)
                UnsuccesLogin(failedLoginReason);
        }

        private static void OnLogOutE(User user)
        {
            if (LogOutE != null)
                LogOutE(user);
        }

        private static void OnUnsuccesDeposit(FailedDepositReasonsEnum failedDepositReason)
        {
            if(UnsuccesDeposit != null)
                UnsuccesDeposit(failedDepositReason);
        }

        private static void OnUnsuccesWithdrawal(FailedWithdrawalReasonsEnum failedWithdrawalReason)
        {
            if (UnsuccesWithdrawal != null)
                UnsuccesWithdrawal(failedWithdrawalReason);
        }

        private static void OnRefresh()
        {
            if (Refresh != null)
                Refresh();
        }
    }
}
