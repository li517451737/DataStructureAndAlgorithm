using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CnCalendar
{
    public partial class FrmCnCalender : Form
    {
        public FrmCnCalender()
        {
            InitializeComponent();
        }

        private void FrmCnCalender_Load(object sender, EventArgs e)
        {
            txtDate.Value = DateTime.Now;//设置为当前日期
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            CCalender cale = new CCalender(txtDate.Value);
            txtCnYear.Text = cale.GetYearName();
            txtCnMonth.Text = cale.GetMonthName();
            txtCnDay.Text = cale.GetDayName();
            txtCnAnimal.Text = cale.GetAnimalName();
        }
    }
}
