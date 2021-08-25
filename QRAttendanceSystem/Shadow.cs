using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRAttendanceSystem
{
    public partial class Shadow : Form
    {
        double opacity_interval = 0.02;
        double opacity = 0.70;
        int interval = 1;
        public Sheets sheets;

        public Shadow()
        {
            this.Opacity = 0;
            InitializeComponent();
        }

        public void OpenAdminForm()
        {
            FadeIn();
            Admin result = new Admin();
            result.sheets = this.sheets;
            result.shadow = this;
            result.ShowDialog();
        }

        public void OpenResultForm(string[] values, Homepage homepage)
        {
            FadeIn();
            Result result = new Result();
            result.sheets = this.sheets;
            result.values = values;
            result.shadow = this;
            result.ShowDialog();
        }

        public void CloseForm(Form form = null)
        {
            FadeOut();
        }

        private async void FadeIn()
        {
            this.Show();
            while (this.Opacity < this.opacity)
            {
                await Task.Delay(this.interval);
                this.Opacity += this.opacity_interval;
            }
            this.Opacity = this.opacity;
        }

        private async void FadeOut()
        {
            while (this.Opacity > 0.0)
            {
                await Task.Delay(this.interval);
                this.Opacity -= this.opacity_interval;
            }
            this.Opacity = 0;
            this.Hide();
        }
    }
}
