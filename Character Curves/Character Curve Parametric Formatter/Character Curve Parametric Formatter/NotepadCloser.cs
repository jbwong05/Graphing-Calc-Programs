using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Curve_Parametric_Formatter
{
    class NotepadCloser
    {
        private Process[] processes;
        private string procName = "Notepad";

        public NotepadCloser()
        {
            processes = Process.GetProcessesByName(procName);
        }

        public void close()
        {
            bool closed = false;
            int index = 0;
            while (!closed)
            {
                if(processes[index].MainWindowTitle.Equals("Parametric Equations - Notepad"))
                {
                    processes[index].Kill();
                    closed = true;
                }
                index++;
            }
        }
    }
}
