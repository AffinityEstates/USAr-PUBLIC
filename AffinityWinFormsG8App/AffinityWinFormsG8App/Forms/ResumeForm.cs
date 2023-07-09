using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Diagnostics;

namespace AffinityWinFormsG8App.Forms
{
    public partial class ResumeForm : Form
    {
        public ResumeForm()
        {
            InitializeComponent();
        }

        private void btnSelectPDFType_Click(object sender, EventArgs e)
        {
            this.tbChosenResumeFileType.Text = "PDF";
        }

        private void btnSetResumeWord_Click(object sender, EventArgs e)
        {
            this.tbChosenResumeFileType.Text = "WORD";
        }

        private void btnSubmitToBot_Click(object sender, EventArgs e)
        {
            Word.Application application = new Word.Application();
            Word.Document document = application.Documents.Add();

            object start = 0;
            object end = 0;

            Word.Range rng = document.Range(ref start, ref end);
            rng.Text = "New Text"; // TODO: Do chatbot call here

            object fileName = "C:\\Test\\NewDocument.docx";
            document.SaveAs2(ref fileName);

            // Open new file
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = fileName.ToString(),
                UseShellExecute = true
            });
        }
    }
}
