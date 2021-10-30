using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public class ExportToDocFile : RichTextBox
    {
        private string doc_text;
        private string desktop_path;

        public ExportToDocFile()
        {



        }
        public void exportToDesktop(Form form)
        {
            foreach (Control c in form.Controls)
            {
                if (c is TextBox || c is Label)
                {
                    doc_text = "\n" + c.Text + Environment.NewLine + doc_text + "\n";
                }
                else if (c is Panel)
                {
                    foreach (Control c2 in c.Controls)
                    {
                        if (c2 is TextBox || c2 is Label)
                        {
                            doc_text = "\n" + c2.Text + Environment.NewLine + doc_text + "\n";
                        }

                    }
                }
            }
            desktop_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


            try
            {
                this.AppendText(doc_text);
                this.SaveFile(desktop_path + "/instructions.doc");
                MessageBox.Show("Αποθηκεύτηκε αρχείο με τις οδηγίες στην επιφάνεια εργασίας σας, με Όνομα instructions.doc.");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Το αρχείο κειμένου χρησιμοποιείται ήδη.Παρακαλώ κλείστε το και δοκιμάστε ξανά.\n(ERROR:"+ex+")");
                return;
            }
            

        }
    }

}
