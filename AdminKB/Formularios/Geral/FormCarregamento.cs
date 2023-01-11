using System;
using System.Threading;
using System.Threading.Tasks;

namespace AdminKB.Formularios.Geral
{
    public partial class FormCarregamento : DevExpress.XtraEditors.XtraForm
    {
        public Action Worker { get; set; }
        public FormCarregamento(Action worker)
        {
            InitializeComponent();
            if (worker == null) throw new ArgumentNullException();

            Worker = worker;
        }


        protected override void OnLoad(EventArgs e)
        {
            Update();
            base.OnLoad(e);

                Task.Factory.StartNew(Worker).ContinueWith(t => {
                    this.Close();
                },
                TaskScheduler.FromCurrentSynchronizationContext()
            );
        }
    }
}