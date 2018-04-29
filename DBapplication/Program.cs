using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


//ALL COPYRIGHTS BELONG TO KHALED SABRY IBRAHIM
//MADE IN 2018
//IF YOU WANT ANY HELP OR ASK ABOUT SOMETHING PLEASE SEND TO ME ON : KHALEDSAB1997@GMAIL.COM


//THIS APP IS ABOUT A RENT APP THE ONE WHO SHOULD INTEREST ABOUT THAT APP IS THE MAN THAT HAS A BLOCKS WHO RENT IT
namespace DBapplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
