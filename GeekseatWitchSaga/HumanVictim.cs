using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekseatWitchSaga
{
    public class HumanVictim
    {
        public string Name { get; set; }
        public int AgeOfDeath { get; set; }
        public int YearOfBirth { get; set; }
        public int YearOfDeath { get; set; }
        public int TotalDeathWhenBorn { get; set; }

        //Get YearOfBirth
        public int GetYearOfBirth(int xAgeOfDeath, int xYearofDeath)
        {
            try
            {
                int xYearOfBirth = xYearofDeath - xAgeOfDeath;
                return xYearOfBirth;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Get TotalHumanDeathInYear
        public int TotalHumanDeathInYear(int xYearTerror)
        {
            try
            {
                int xTotalHumanDeathInYear = 0;
                for (int i = 1; i <= xYearTerror; i++)
                {
                    if (i == 1)
                    {
                        xTotalHumanDeathInYear = i;
                    }
                    else
                    {
                        xTotalHumanDeathInYear = xTotalHumanDeathInYear + (i - 1);
                    }
                }
                return xTotalHumanDeathInYear;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Get AvgOfTwoKindYearOfTerror
        public double AvgOfTwoKindYearOfTerror(int xFirstYearTerror, int xSecondYearTerror)
        {
            try
            {
                double AvgOfTwoKindYearOfTerror = -1;
                AvgOfTwoKindYearOfTerror = (double)(xFirstYearTerror + xSecondYearTerror) / 2;
                return AvgOfTwoKindYearOfTerror;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
