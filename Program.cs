using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjFinal
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Schedule scheduleForm = new Schedule();
            scheduleForm.FormClosed += new FormClosedEventHandler(OnFormClosed);
            scheduleForm.Show();
            Application.Run();
        }

        static void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= OnFormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += OnFormClosed;
        }
    }
}