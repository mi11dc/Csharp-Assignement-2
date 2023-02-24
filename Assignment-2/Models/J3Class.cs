using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2.Models
{
    public class J3Class
    {
        public int NoofPeople { get; set; }
        public List<DaysAvailibilityClass> Availibilities { get; set; }
        public string SuggestedEventDay { get;set; }
        public string ErrorMessage { get; set; }

        public string FirstDay { get;  set; }

        public string GetAvailableDays(List<DaysAvailibilityClass> Availibilities)
        {
            List<int> AvailablePersonsDayWise = (new int[] { 0, 0, 0, 0, 0 }).ToList();
            for(int index = 0; index < Availibilities.Count; index++)
            {
                if (IsAvailableOnDay(Availibilities[index].FirstDay))
                    AvailablePersonsDayWise[0] += 1;

                if (IsAvailableOnDay(Availibilities[index].SecondDay))
                    AvailablePersonsDayWise[1] += 1;

                if (IsAvailableOnDay(Availibilities[index].ThirdDay))
                    AvailablePersonsDayWise[2] += 1;

                if (IsAvailableOnDay(Availibilities[index].FourthDay))
                    AvailablePersonsDayWise[3] += 1;

                if (IsAvailableOnDay(Availibilities[index].FifthDay))
                    AvailablePersonsDayWise[4] += 1;
            }

            return GetAllIndexes(AvailablePersonsDayWise, AvailablePersonsDayWise.Max());
        }

        public bool IsAvailableOnDay(string day)
        {
            return (day == "Y");
        }

        public string GetAllIndexes(List<int> list, int maxValue)
        {
            string Indexes = String.Empty;

            if (maxValue.Equals(0))
                return Indexes;

            for (int index = 0; index < list.Count; index++)
            {
                if (list[index] == maxValue)
                    Indexes += (index + 1) + ", ";
            }
            Indexes = String.IsNullOrEmpty(Indexes) ? String.Empty : Indexes.Substring(0, Indexes.Length - 2);
            return Indexes;
        }
    }
}