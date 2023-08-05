using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqExamples
{
    public partial class Travel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var data = XElement.Load(Server.MapPath("Travel.xml"));
                var table = data.Elements("Location");

                //Bind DropDownList
                var Continents = from t in table select new { Continent = t.Element("Continent").Value };
                ddlContinents.DataSource = Continents.Distinct();
                ddlContinents.DataTextField = "Continent";
                ddlContinents.DataValueField = "Continent";
                ddlContinents.DataBind();
                ddlContinents.Items.Insert(0, "-Select Continent-");

                //Bind Repeater Control
                rptLocations.DataSource = from t in table
                                          select new
                                          {
                                              Name = t.Element("Name").Value,
                                              Continent = t.Element("Continent").Value,
                                              Photo = t.Element("Image").Value,
                                              Price = t.Element("Price").Value
                                          };
                rptLocations.DataBind();
            }

        }

        protected void ddlContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = XElement.Load(Server.MapPath("Travel.xml"));
            var table = data.Elements("Location");
            if (ddlContinents.SelectedIndex == 0)
            {
                rptLocations.DataSource = from t in table
                                          select new
                                          {
                                              Name = t.Element("Name").Value,
                                              Continent = t.Element("Continent").Value,
                                              Photo = t.Element("Image").Value,
                                              Price = t.Element("Price").Value
                                          };
            }
            else
            {
                rptLocations.DataSource = from t in table
                                          where t.Element("Continent").Value == ddlContinents.SelectedValue
                                          select new
                                          {
                                              Name = t.Element("Name").Value,
                                              Continent = t.Element("Continent").Value,
                                              Photo = t.Element("Image").Value,
                                              Price = t.Element("Price").Value
                                          };
            }
            rptLocations.DataBind();

        }
    }
}