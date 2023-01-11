using System;
using System.Windows.Forms;

namespace DBSender
{
    internal static class Program
    {
        public static Main Form;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        [Obsolete]
        static void Main()
        {
            Form = new Main();
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main());
            Application.Run(Form);
        }
    }
}
