using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqExamples
{
    public partial class LinqWithCollections : System.Web.UI.Page
    {
        List<string> Cities = new List<string>() { "Amaravati", "Itanagar", "Dispur", "Patna", "Panaji", "Gandhinagar",
            "Shimla", "Chennai", "Agartala", "Lucknow", "Kolkata", "Raipur","Bikaner",
            "Dehradun", "Ranchi", "Hyderabad", "Delhi", "Noida", "Kanpur", "Varanasi", "Allahabad", "Agra", "Mau", "Pune" };
        protected void Page_Load(object sender, EventArgs e)
        {
            //1- Query to fetch all the Cities as is:
            var Coll1=from s in Cities select s;
            Response.Write(String.Join(",<br/>",Coll1)+ "<hr/>");

            //2-Query to fetch all the Cities in ascending order:
            var Coll2 = from s in Cities orderby s select s;
            Response.Write(String.Join(",<br/>", Coll2) + "<hr/>");

            //3-Query to fetch all the Cities in descending order:
            Response.Write("<h5>fetch all the Cities in descending order</h5><br>");
            var Coll3 = from s in Cities orderby s descending select s;
            Response.Write(String.Join(",<br/>", Coll3) + "<hr/>");

            //4- Query to fetch all the Cities with a length of 6 characters:
            Response.Write("<h5>fetch all the Cities with a length of 6 characters</h5>");
            var Coll4 = from s in Cities where s.Length==6 select s;
            Response.Write(String.Join(",<br/>", Coll4) + "<hr/>");

            //5-Query to fetch cities starting with a particular character:
            Response.Write("<h5> fetch cities starting with a particular character </h5>");
            var Coll5= from s in Cities where s.IndexOf('A')==0 select s;
            Response.Write(String.Join(",<br/>", Coll5) + "<hr/>");

            var Coll6 = from s in Cities where s.StartsWith("N") select s;
            Response.Write(String.Join(",<br/>", Coll6) + "<hr/>");

            var Coll7 = from s in Cities where s.Substring(0, 1) == "B" select s;
            Response.Write(String.Join(", <br/>", Coll7) + "<hr />");

            var Coll8 = from s in Cities where s[0] == 'D' select s;
            Response.Write(String.Join(",<br/> ", Coll8) + "<hr />");

            //6-Query to fetch cities ending with a particular character:
            Response.Write("<h5> fetch cities ending with a particular character </h5>");
            var Coll9 = from s in Cities where s.IndexOf('a')==s.Length-1 select s;
            Response.Write(String.Join(",<br/> ", Coll9) + "<hr />");

            var Coll10 = from s in Cities where s.Substring(s.Length - 1) == "i" select s;
            Response.Write(String.Join(", <br/>", Coll10) + "<hr />");

            var Coll11 = from s in Cities where s.EndsWith("l") select s;
            Response.Write(String.Join(",<br/> ", Coll11) + "<hr />");

            var Coll12 = from s in Cities where s[s.Length - 1] == 'r' select s;
            Response.Write(String.Join(", <br/>", Coll12) + "<hr />");


            //7-Query to fetch cities containing character “a” in third place:
            Response.Write("<h5> fetch cities containing character “a” in third place </h5>");
            var Coll13 = from s in Cities where s.IndexOf('a') == 2 select s;
            Response.Write(String.Join(", <br/>", Coll13) + "<hr />");
            var Coll14 = from s in Cities where s.Substring(2, 1) == "a" select s;
            Response.Write(String.Join(", <br/>", Coll14) + "<hr />");
            var Coll15 = from s in Cities where s[2] == 'a' select s;
            Response.Write(String.Join(", <br/>", Coll15) + "<hr />");

            //8-Query to fetch cities containing character “h” or “H” under them:
            Response.Write("<h5> fetch cities containing character “h” or “H” under them </h5>");
            var Coll16 = from s in Cities where s.IndexOf('h') >= 0 || s.IndexOf('H') >= 0 select s;
            Response.Write(String.Join(",<br/> ", Coll16) + "<hr />");
            var Coll17 = from s in Cities where s.ToLower().IndexOf('h') >= 0 select s;
            Response.Write(String.Join(", <br/>", Coll17) + "<hr />");
            var Coll18 = from s in Cities where s.Contains('h') || s.Contains('H') select s;
            Response.Write(String.Join(",<br/> ", Coll18) + "<hr />");
            var Coll19 = from s in Cities where s.ToUpper().Contains('H') select s;
            Response.Write(String.Join(",<br/> ", Coll19) + "<hr />");

            //9-Query to fetch cities not containing character “h” or “H” under them:
            Response.Write("<h5> fetch cities not containing character “h” or “H” under them </h5>");
            var Coll20 = from s in Cities where s.IndexOf('h') == -1 && s.IndexOf('H') == -1 select s;
            Response.Write(String.Join(", <br/>", Coll20) + "<hr />");
            var Coll21 = from s in Cities where s.ToLower().IndexOf('h') == -1 select s;
            Response.Write(String.Join(", <br/>", Coll21) + "<hr />");
            var Coll22 = from s in Cities where s.Contains('h') == false && s.Contains('H') == false select s;
            Response.Write(String.Join(", <br/>", Coll22) + "<hr />");
            var Coll23 = from s in Cities where s.ToUpper().Contains('H') == false select s;
            Response.Write(String.Join(",<br/> ", Coll23) + "<hr />");


        }
    }
}