using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

/// <summary>
/// TabCap
/// </summary>
namespace TabCap
{
    #region ControlsInTab

    /// <summary>
    /// ControlsInTab
    /// </summary>
    public enum ControlsInTab
    {
        /// <summary>
        /// PictureBox
        /// </summary>
        PictureBox = 0,
        /// <summary>
        /// Label
        /// </summary>
        Label = 1,
        /// <summary>
        /// TextBox
        /// </summary>
        TextBox = 2
    }
    #endregion

    /// <summary>
    /// frmTabCap
    /// </summary>
    public partial class FrmTabCap : Form
    {
        /// <summary>
        /// TabCounter
        /// </summary>
        private int TabCounter = 1;

        #region Event

        /// <summary>
        /// Form1
        /// </summary>
        public FrmTabCap()
        {
            InitializeComponent();
        }

        /// <summary>
        /// btnPaste_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (TabCounter == int.MaxValue)
            {
                return;
            }

            var ins = Clipboard.GetImage();

            if (ins == null)
            {
                return;
            }

            TabPage tb = new TabPage();

            tb.Controls.Add(new PictureBox() { Size = ins.Size, Location = new Point() { X = 0, Y = 50 } });
            tb.Controls.Add(new Label()
            {
                Size = new Size() { Height = 20, Width = 60 }
                ,
                Location = new Point() { X = 5, Y = 5 }
                ,
                Text = "TabName："
                ,
                TextAlign = ContentAlignment.MiddleLeft
            });
            tb.Controls.Add(new TextBox()
            {
                Size = new Size() { Height = 20, Width = 100 }
                ,
                Location = new Point() { X = 65, Y = 5 }
                ,
                Text = "(Empty" + TabCounter + ")"
                ,
            });
            tb.Text = "(Empty" + TabCounter + ")";

            tabControl1.TabPages.Add(tb);
            tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
            tabControl1.SelectedTab.AutoScroll = true;

            var a = (PictureBox)(tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls[(int)ControlsInTab.PictureBox]);
            a.Image = ins;

            var b = (TextBox)(tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls[(int)ControlsInTab.TextBox]);
            b.TextChanged += TextChangeControlsInTab;

            TabCounter += 1;
        }

        /// <summary>
        /// btnDelete_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count == 0)
            {
                return;
            }

            tabControl1.TabPages.RemoveAt(tabControl1.TabPages.Count - 1);

            if (tabControl1.TabPages.Count == 0)
            {
                return;
            }

            tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];

        }

        /// <summary>
        /// frmTabCap_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTabCap_Load(object sender, EventArgs e)
        {
            this.Size = new Size() { Height = 500, Width = 500 };
        }

        /// <summary>
        /// btnSaveFocusedTab_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveFocusedTab_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab is null)
            {
                MessageBox.Show("Tab is empty");
                return;
            }

            if (string.IsNullOrEmpty(tabControl1.SelectedTab.Text))
            {
                MessageBox.Show("Name is empty");
                return;
            }

            using (var sa = new SaveFileDialog())
            {
                sa.Filter = "PngFormatImage|*.Png";
                sa.FileName = tabControl1.SelectedTab.Text;

                sa.ShowDialog();

                var ins = (PictureBox)(tabControl1.SelectedTab.Controls[(int)ControlsInTab.PictureBox]);
                ins.Image.Save(sa.FileName, ImageFormat.Png);

            }
        }

        /// <summary>
        /// btnSaveAllTab_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveAllTab_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab is null)
            {
                MessageBox.Show("Tab is empty");
                return;
            }

            using (var sa = new FolderBrowserDialog())
            {
                sa.ShowDialog();
                foreach (TabPage item in tabControl1.TabPages)
                {
                    var ins = (PictureBox)item.Controls[(int)ControlsInTab.PictureBox];
                    ins.Image.Save(sa.SelectedPath + "\\" + item.Text + ".Png", ImageFormat.Png);
                }
            }
        }

        /// <summary>
        /// TextChangeControlsInTab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextChangeControlsInTab(object sender, EventArgs e)
        {
            var ins = (TextBox)(tabControl1.SelectedTab.Controls[(int)ControlsInTab.TextBox]);
            tabControl1.SelectedTab.Text = ins.Text;
        }

        #endregion
    }
}
