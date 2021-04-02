using System.Threading;
using System.Windows.Forms;

namespace dental_sys.view
{
    public class WaitFormFunc
    {
        private WaitForm _wait;
        private Thread _loadThread;

        public void Show()
        {
            _loadThread = new Thread(new ThreadStart(LoadingProcess));
            _loadThread.Start();
        }

        public void Show(Form parent)
        {
            _loadThread = new Thread(new ParameterizedThreadStart(LoadingProcess));
            _loadThread.Start(parent);
        }

        public void Close()
        {
            if (_wait != null)
            {
                _wait.BeginInvoke(new ThreadStart(_wait.CloseWaitForm));
                _wait = null;
                _loadThread = null;
            }
        }

        private void LoadingProcess()
        {
            _wait = new WaitForm();
            _wait.ShowDialog();
        }

        private void LoadingProcess(object parent)
        {
            Form parent1 = parent as Form;
            _wait = new WaitForm(parent1) { TopMost = true };
            _wait.ShowDialog();

        }
    }
}
