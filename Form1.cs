using System.Xml.Linq;

namespace Laba2_3
{
    public partial class Form1 : Form
    {
        public partial class ChildForm : Form
        {
            public ChildForm()
            {

            }

        }
        public Form1()
        {
            InitializeComponent();
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
            IsMdiContainer = true;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int openDocuments = 0;
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    ChildForm newChild = new ChildForm();
                    newChild.MdiParent = this;
                    newChild.Show();
                    newChild.Text = newChild.Text + " " +
                    ++openDocuments;
                    break;
                case "Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    spWin.Text = "Windows is cascade";
                    break;
                case "Title":
                    this.LayoutMdi
                    (System.Windows.Forms.MdiLayout.TileHorizontal);
                    spWin.Text = "Windows is horizontal";
                    break;
            }
        }
    }
}
