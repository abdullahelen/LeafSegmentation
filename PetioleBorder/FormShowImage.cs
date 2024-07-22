using System.Drawing;
using System.Windows.Forms;

namespace PetioleBorder
{
    public partial class FormShowImage : Form
    {
        public FormShowImage(Bitmap bmp, string title = "")
        {
            InitializeComponent();

            picMain.Image = bmp;
            Text = title;
        }
    }
}
