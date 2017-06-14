using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace MutiProcessWindows
{
    public partial class ProcessAgent : Form
    {
        #region Win32 API

        //https://msdn.microsoft.com/zh-tw/library/windows/desktop/ms633541(v=vs.85).aspx
        [DllImport("user32.dll", SetLastError = true)]
        private static extern long SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        //https://msdn.microsoft.com/zh-tw/library/windows/desktop/ms633534(v=vs.85).aspx
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);

        //https://msdn.microsoft.com/en-us/library/windows/desktop/ms633591(v=vs.85).aspx
        [DllImport("user32.dll", EntryPoint = "SetWindowLongA", SetLastError = true)]
        private static extern long SetWindowLong(IntPtr hwnd, int nIndex, int dwNewLong);

        #endregion


        #region Const
        //請參考 https://msdn.microsoft.com/zh-tw/library/windows/desktop/ms633591(v=vs.85).aspx
        private const int GWL_STYLE = -16;
        private const int WS_VISIBLE = 0x10000000;
        #endregion


        public Process MProcess { get; set; }

        public ProcessAgent(string param)
        {

            //初始化Process ，並且設定執行自己exe 但是有帶參數
            //param 可傳入 -forma, -formb
            MProcess = new Process()
            {
                SynchronizingObject = this,
                StartInfo = new ProcessStartInfo()
                {
                    FileName = Application.ExecutablePath,
                    Arguments = param
                }
            };
            //啟動
            MProcess.Start();


            InitializeComponent();
        }

        private void ProcessAgent_Load(object sender, EventArgs e)
        {

            //https://msdn.microsoft.com/zh-tw/library/system.diagnostics.process.waitforinputidle(v=vs.110).aspx
            //讓 Process 元件等候相關聯處理序進入閒置狀態。
            MProcess.WaitForInputIdle();
            while (!MProcess.HasExited && MProcess.MainWindowHandle == IntPtr.Zero)
            {
                Application.DoEvents();
                Thread.Sleep(100);
            }

            //取得或設定是否應該在處理序終止時引發事件
            MProcess.EnableRaisingEvents = true;
            //設定裡面的視窗被關掉時，此中介曾的ProceeAgent 所以要處理的
            MProcess.Exited += M_Process_Exited;

            var handle = MProcess.MainWindowHandle;

            //將發動的handle 爸爸設成此中介層
            SetParent(handle, this.Handle);
            //設定該發動handle(視窗) 顯示樣式
            SetWindowLong(handle, GWL_STYLE, WS_VISIBLE);

            //移動至相關位置
            MoveWindow(handle, 0, 0, (this.MdiParent as Form).Width, (this.MdiParent as Form).Height, true);

        }

        private void M_Process_Exited(object sender, EventArgs e)
        {
            //當然就是把自己關掉
            this.Close();
        }
    }
}
