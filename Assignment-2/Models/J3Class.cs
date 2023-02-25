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

        /// <summary>
        /// Every persons available days are in Availibilities parameter. 
        /// This function is calculating available days when most of persons come for the event.
        /// </summary>
        /// <param name="Availibilities">List of available days</param>
        /// <returns>Suggested days for event.</returns>
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

        /// <summary>
        /// if any person is available or not.
        /// </summary>
        /// <param name="day">Value of day which is "Y" or "."</param>
        /// <returns>returns bool value</returns>
        public bool IsAvailableOnDay(string day)
        {
            return (day == "Y");
        }

        /// <summary>
        /// Check all list values which can match with maxValue, so, it can add in suggested days.
        /// </summary>
        /// <param name="list">List of every days number of people comming for event.</param>
        /// <param name="maxValue">Maximum nummber from list.</param>
        /// <returns>All possible days for event in string</returns>
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