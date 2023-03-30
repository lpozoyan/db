using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp7.DB;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BillingContext _ef;


        public MainWindow()
        {
            InitializeComponent();
            _ef = new BillingContext();
            account t1 = new account();
            t1.Login = "admin"; t1.Password = "pass1";

            account t2 = new account();
            t2.Login = "sgk"; t2.Password = "nyam";

            _ef.Add(t1);
            _ef.Add(t2);
            _ef.SaveChanges();

             var account = _ef.Acoounts.FirstOrDefault(x
                 => x.Login == "admin");
            if(account != null)
            {
                Bill bill = new Bill();
                bill.Balance = 9000;
                bill.Account = account;

                _ef.Add(bill);
                _ef.SaveChanges();
            }
                //data_table.ItemsSourse = _ef.Accounts.ToList();





        }
    }
}
