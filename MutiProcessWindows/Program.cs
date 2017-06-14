using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutiProcessWindows
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            if (args.Length > 0)
            {

                switch (args[0])
                {
                    case "-forma":
                        {
                            Application.Run(new FormA());
                        }
                        break;
                    case "-formb":
                        {
                            Application.Run(new FormB()
                            {
                                StartPosition = FormStartPosition.CenterParent,
                              
                            });
                        }
                        break;

                }


            }
            else
            {
               Application.Run(new Form1());
               
            }
        }
    }
}
