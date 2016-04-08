using FoodGuard.Email.Provider;
using SFP.Core.ServiceInjection;
using SFP.Data.Dapper.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FoodGuard.Email.Service
{
    public partial class Service1 : ServiceBase
    {
        private static System.Timers.Timer timer;

        //private EmailHelper emailHelper;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer = new System.Timers.Timer();
            timer.Elapsed += Timer_Elapsed;
            timer.Interval = 1000 * 60;

            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
            }
            catch(Exception ex)
            {
            }
            finally
            {
            }
        }

        protected override void OnStop()
        {
            timer.Stop();
        }
    }
}
