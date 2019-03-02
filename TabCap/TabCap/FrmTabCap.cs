using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Linq;

/// <summary>
/// TabCap
/// </summary>
namespace TabCap
{
    #region Enum

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

    #region ModeAddForTab

    /// <summary>
    /// ModeAddForTab
    /// </summary>
    public enum ModeAddForTab
    {
        /// <summary>
        /// Normal
        /// </summary>
        Normal = 0,

        /// <summary>
        /// Read
        /// </summary>
        Read = 1
    }
    #endregion

    #region FormatListImage

    /// <summary>
    /// FormatListImage
    /// </summary>
    public enum FormatListImage
    {
        /// <summary>
        /// Image
        /// </summary>
        Image = 0,

        /// <summary>
        /// FileName
        /// </summary>
        FileName = 1
    }
    #endregion

    #endregion

    /// <summary>
    /// frmTabCap
    /// </summary>
    public partial class FrmTabCap : Form
    {
        #region Field

        /// <summary>
        /// TabCounter
        /// </summary>
        private int TabCounter = 1;

        /// <summary>
        /// NameNowGroup
        /// </summary>
        private string NameNowTab = string.Empty;

        #endregion

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
            AddForTab(mode: ModeAddForTab.Normal);
        }

        /// <summary>
        /// btnDelete_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            TabControl nowTab = GetNowTabControl();
            if (nowTab.TabPages.Count == 0)
            {
                return;
            }

            nowTab.TabPages.RemoveAt(nowTab.TabPages.Count - 1);

            if (nowTab.TabPages.Count == 0)
            {
                return;
            }

            nowTab.SelectedTab = nowTab.TabPages[nowTab.TabPages.Count - 1];

        }

        /// <summary>
        /// frmTabCap_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTabCap_Load(object sender, EventArgs e)
        {
            this.Size = new Size() { Height = 500, Width = 700 };

            short marginSize = 2;
            pnlTab.Size = new Size()
            {
                Height = this.ClientSize.Height - this.pnlBtn.ClientSize.Height - (this.Margin.Size.Height),
                Width = this.ClientSize.Width - (this.Margin.Size.Width)
            };
            pnlTab.Location = new Point() { X = marginSize, Y = marginSize };

            string pnlName = "new";
            pnlTab.Controls.Add(new TabControl()
            {
                Size = new Size()
                {
                    Height = pnlTab.Height - (marginSize * 2),
                    Width = pnlTab.Width - (marginSize * 2)
                },
                Name = pnlName,
                Location = new Point() { X = marginSize, Y = marginSize },
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            });
            NameNowTab = pnlName;
        }

        /// <summary>
        /// btnSaveFocusedTab_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveFocusedTab_Click(object sender, EventArgs e)
        {
            TabControl nowTab = GetNowTabControl();
            if (nowTab.SelectedTab is null)
            {
                MessageBox.Show("Tab is empty");
                return;
            }

            if (string.IsNullOrEmpty(nowTab.SelectedTab.Text))
            {
                MessageBox.Show("Name is empty");
                return;
            }

            using (var sa = new SaveFileDialog())
            {
                sa.Filter = "PngFormatImage|*.Png";
                sa.FileName = nowTab.SelectedTab.Text;

                sa.ShowDialog();

                var ins = (PictureBox)(nowTab.SelectedTab.Controls[(int)ControlsInTab.PictureBox]);
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
            TabControl nowTab = GetNowTabControl();

            if (nowTab.SelectedTab is null)
            {
                MessageBox.Show("Tab is empty");
                return;
            }

            using (var sa = new FolderBrowserDialog())
            {
                var result = sa.ShowDialog();

                if (result != DialogResult.OK)
                {
                    return;
                }

                foreach (TabPage item in nowTab.TabPages)
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
            TabControl nowTabControl = GetNowTabControl();

            // A system get an object.
            var targetTextBox = (TextBox)(nowTabControl.SelectedTab.Controls[(int)ControlsInTab.TextBox]);
            nowTabControl.SelectedTab.Text = targetTextBox.Text;

            // The tab get a length of text.
            if (targetTextBox.Text.Length != 0)
            {
                short space = 10;
                targetTextBox.Width = TextRenderer.MeasureText(targetTextBox.Text, this.Font).Width + space;
            }
        }

        /// <summary>
        /// FrmTabCap_FormClosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTabCap_FormClosing(object sender, FormClosingEventArgs e)
        {
            TabControl nowTab = GetNowTabControl();

            if (nowTab.TabCount == 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Do you accept to close this?", "Select", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                return;
            }

            e.Cancel = true;
        }

        /// <summary>
        /// btnReadCap_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadCap_Click(object sender, EventArgs e)
        {
            using (var ins = new OpenFileDialog())
            {
                ins.Filter = "PngFormatImage|*.Png";
                ins.Multiselect = true;
                ins.ShowDialog();

                var select = ins.FileNames;

                if (select.Length == 0)
                {
                    return;
                }

                AddForTab(mode: ModeAddForTab.Read, path: select);
            }
        }

        #endregion

        #region Method

        private void AddForTab(ModeAddForTab mode, string[] path = null)
        {
            if (TabCounter == int.MaxValue)
            {
                return;
            }

            List<ImageTabCap> ins = null;

            switch (mode)
            {
                case ModeAddForTab.Normal:
                    ins = GetImage();
                    break;
                case ModeAddForTab.Read:
                    ins = GetImage(path);
                    break;
                default:
                    break;
            }

            if (ins == null || ins.Count == 0)
            {
                return;
            }

            foreach (var item in ins.OrderBy(x => x.CreationTime))
            {
                TabPage tb = new TabPage();

                tb.Controls.Add(new PictureBox() { Size = item.Image.Size, Location = new Point() { X = 0, Y = 50 } });
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
                    Text = string.IsNullOrEmpty(item.FileName) ? "(Empty" + TabCounter + ")"
                            : item.FileName
                });
                tb.Text = string.IsNullOrEmpty(item.FileName) ? "(Empty" + TabCounter + ")"
                            : item.FileName;

                var nowTab = (TabControl)this.Controls.Find(NameNowTab, true)[0];

                nowTab.TabPages.Add(tb);
                nowTab.SelectedTab = nowTab.TabPages[nowTab.TabPages.Count - 1];
                nowTab.SelectedTab.AutoScroll = true;

                var a = (PictureBox)(nowTab.TabPages[nowTab.TabPages.Count - 1].Controls[(int)ControlsInTab.PictureBox]);
                a.Image = item.Image;

                var b = (TextBox)(nowTab.TabPages[nowTab.TabPages.Count - 1].Controls[(int)ControlsInTab.TextBox]);
                b.TextChanged += TextChangeControlsInTab;

                TabCounter += 1;
            }
        }

        private static List<ImageTabCap> GetImage()
        {
            Image result = Clipboard.GetImage();

            if (result is null)
            {
                return null;
            }

            return new List<ImageTabCap>() { new ImageTabCap(result, "", null) };
        }

        private static List<ImageTabCap> GetImage(string[] path)
        {
            if (path == null || path.Length == 0)
            {
                return null;
            }

            List<ImageTabCap> result = new List<ImageTabCap>();

            foreach (var item in path)
            {
                using (FileStream fs = File.OpenRead(item))
                {
                    result.Add(new ImageTabCap(Image.FromStream(fs, false, false),
                                    Path.GetFileNameWithoutExtension(item),
                                    File.GetCreationTime(item)));
                }
            }

            return result;
        }

        private TabControl GetNowTabControl()
        {
            var result = this.Controls.Find(NameNowTab, true);

            if (result.Length == 0)
            {
                return null;
            }

            return (TabControl)result[0];
        }

        #endregion
    }

    #region Class

    public class ImageTabCap
    {
        public Image Image { get; set; }
        public string FileName { get; set; }
        public DateTime? CreationTime { get; set; }

        public ImageTabCap(Image image, string fileName, DateTime? creationTime)
        {
            Image = image;
            FileName = fileName;
            CreationTime = creationTime;
        }
    }
    #endregion
}
