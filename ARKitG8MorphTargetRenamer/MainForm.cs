using System.IO;
using System.Windows.Forms;

namespace ARKitG8MorphTargetRenamer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pnlDragFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void pnlDragFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfo.Extension == ".fbx")
                {
                    string str;

                    using (StreamReader streamReader = File.OpenText(file))
                        str = streamReader.ReadToEnd();

                    str = str.Replace("head__", "");

                    using (StreamWriter streamWriter = new StreamWriter(file))
                        streamWriter.Write(str);

                    MessageBox.Show(@"Complete");
                }
            }
        }
    }
}
