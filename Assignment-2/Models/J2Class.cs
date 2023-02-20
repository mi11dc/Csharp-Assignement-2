using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2.Models
{
    public class J2Class
    {
        public int TotalNoofPeppers { get; set; }

        public List<string> LstPeppers { get; set; }

        public int TotalSHUValues(J2Class j2Class)
        {
            Pepper pepper = new Pepper();
            int totalPoints = 0;
            for (var i = 0; i < j2Class.LstPeppers.Count; i++)
            {
                Pepper pepperObj = pepper.GetPeppers().Find(x => x.Name == j2Class.LstPeppers[i]);
                if (
                    pepperObj != null &&
                    !String.IsNullOrEmpty(pepperObj.Name) &&
                    !String.IsNullOrEmpty(j2Class.LstPeppers[i]))
                {
                    if (j2Class.LstPeppers[i].Trim() == pepperObj.Name.Trim())
                    {
                        totalPoints += pepperObj.Value;
                    }
                }
            }

            return totalPoints;
        }
    }
}