using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeekseatWitchSaga
{
    public partial class DispelTheWitch : Form
    {
        public DispelTheWitch()
        {
            InitializeComponent();
        }

        private void DispelTheWitch_Load(object sender, EventArgs e)
        {

        }

        private void txtAgeOfDeathFirstPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtYearOfDeathFirstPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtAgeOfDeathSecondPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtYearOfDeathSecondPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSearchValue_Click(object sender, EventArgs e)
        {
            HumanVictim HV1 = new HumanVictim();
            HumanVictim HV2 = new HumanVictim();

            //First Person
            HV1.Name = txtNameFirstPerson.Text;
            HV1.AgeOfDeath = int.Parse(txtAgeOfDeathFirstPerson.Text);
            HV1.YearOfDeath = int.Parse(txtYearOfDeathFirstPerson.Text);
            HV1.YearOfBirth = HV1.GetYearOfBirth(HV1.AgeOfDeath, HV1.YearOfDeath);
            HV1.TotalDeathWhenBorn = HV1.TotalHumanDeathInYear(HV1.YearOfBirth);


            //Second Person
            HV2.Name = txtNameSecondPerson.Text;
            HV2.AgeOfDeath = int.Parse(txtAgeOfDeathSecondPerson.Text);
            HV2.YearOfDeath = int.Parse(txtYearOfDeathSecondPerson.Text);
            HV2.YearOfBirth = HV2.GetYearOfBirth(HV2.AgeOfDeath, HV2.YearOfDeath);
            HV2.TotalDeathWhenBorn = HV2.TotalHumanDeathInYear(HV2.YearOfBirth);


            txtYearOfBirthFirstPerson.Text = HV1.YearOfBirth.ToString();
            txtTotalDeathWhenFirstPersonBorn.Text = HV1.TotalDeathWhenBorn.ToString();

            txtYearOfBirthSecondPerson.Text = HV2.YearOfBirth.ToString();
            txtTotalDeathWhenSecondPersonBorn.Text = HV2.TotalDeathWhenBorn.ToString();


            if (HV1.YearOfBirth < 0 || HV2.YearOfBirth < 0)
            {
                lblValueAverageDeath.Text = "-1";
                MessageBox.Show("Invalid Data");
                return;
            }
            else {
                double xAverage = (double)(HV1.TotalDeathWhenBorn+HV2.TotalDeathWhenBorn)/2;
                lblValueAverageDeath.Text = xAverage.ToString();
                MessageBox.Show("Average Death = "+ lblValueAverageDeath.Text);
            }

        }
    }
}
