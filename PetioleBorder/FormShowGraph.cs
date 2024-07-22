using System.Windows.Forms;
using ZedGraph;

namespace PetioleBorder
{
    public partial class FormShowGraph : Form
    {
        private readonly GraphPane graphPane;

        public FormShowGraph(string title, GraphPane graphPane)
        {
            InitializeComponent();

            Text = title;
            this.graphPane = graphPane;

            DrawGraph(graphX);
        }

        public void DrawGraph(ZedGraphControl zedGraph)
        {
            InitGraph(zedGraph);

            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        public void InitGraph(ZedGraphControl zedGraph)
        {
            zedGraph.GraphPane = graphPane;
        }

        private void FormShowGraph_Shown(object sender, System.EventArgs e)
        {
            Width = 899;
            Height = 550;
            Width++;
        }
    }
}
