using System;
using System.Collections.Generic;

namespace Opsummering
{
    public class User
    {
        private string login;
        private string password;
        private Job job;

        public bool isAdmin()
        {   
            return true;
        }
    }

    public class Admin : User
    {
        public void changePassword(User user, string newPassword)
        {
            Console.WriteLine("The password has been trundled");
        }
    }

    public class Registry
    {
        List<User> users = new List<User>();

        List<Admin> admins = new List<Admin>();

        public void AddNewUser(User user)
        {
            users.Add(user);
        }

        public bool Login(string login, string password)
        {
            return true;
        }
    }   

    public abstract class Job
    {
        public abstract int GetMonthlyPay();
    }

    public class HourlyPaidJob : Job
    {
        private int HourlyPay;
        public override int GetMonthlyPay()
        {
            int dailyPay = HourlyPay * 8;
            return dailyPay * 30;
        }
    }

    public class DailyPaidJob : Job
    {
        private int DailyPay;

        public override int GetMonthlyPay()
        {
            return DailyPay * 30;
        }
    }
}
