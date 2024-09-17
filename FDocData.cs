using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab_3
{
    public partial class FDocData : Form
    {
        public FDocData()
        {
            InitializeComponent();
        }

        private void tbDocumentInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddDocumentData_Click(object sender, EventArgs e)
        {
            Passport_document pass_doc = new Passport_document();
            FDoc fp = new FDoc(pass_doc);
            if (fp.ShowDialog() == DialogResult.OK)
            {
                tbDocumentInfo.Text += string.Format(
                    " ID: {0},\r\n Ім'я: {1},\r\n Прізвище: {2},\r\n Дата народження: {3},\r\n Національність: {4}, " +
                    "\r\n Дата видачі: {5},\r\n Дата закінчення: {6},\r\n Індивідуальний податковий номер: {7},\r\n Стать: {8}\r\n" +
                    "Дія паспорту закінчується через: {9} років",
                    pass_doc.ID.Trim(),
                    pass_doc.Name.Trim(),
                    pass_doc.Surname.Trim(),
                    pass_doc.Date_Of_Birth.Trim(),
                    pass_doc.Nationality.Trim(),
                    pass_doc.Date_Of_Issue.Trim(),
                    pass_doc.Date_Of_expire.Trim(),
                    pass_doc.Individual_tax_number.Trim(),
                    pass_doc.sex ? "Чоловіча" : "Жіноча",
                    pass_doc.Passport_Expired_in()
                );
            }
        }

        private void FDocData_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу",
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }

        }
    }
}
