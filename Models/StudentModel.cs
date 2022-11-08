using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KendoUIDropDownListApp.Controllers;

namespace KendoUIDropDownListApp.Models
{
    public class StudentModel
    {
        public string Emplid { get; set; }
        public string Last_Name { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Sex { get; set; }
        public string Ethnic_Grp_CD { get; set; }
        public Nullable<System.DateTime> BIRTHDATE { get; set; }
        public string studentname { get; set; }
        public string Email_Addr { get; set; }
        public string emaddr { get; set; }
        public string mdyr { get; set; }
        public string gyr { get; set; }
        public string campuscode { get; set; }
        public string Acad_Prog { get; set; }
        public string desk { get; set; }
        public string advisor_name { get; set; }
        public string advisor_email { get; set; }
        public string advisor_campus_id { get; set; }
        public string Prog_status { get; set; }
        public string CW_PREF_FIRST_NAME { get; set; }
        public string reduced_fee { get; set; }
        public string gender_identity { get; set; }
        public string gender_pronoun { get; set; }
    }
}