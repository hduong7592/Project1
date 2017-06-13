using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string FirstName = FirstNameTxt.Text;
        string LastName = LastNameTxt.Text;

        Person person = new Person();
        person.SetName(FirstName, LastName);
        person.SetAge(18);

        Label1.Text = "Name: " + person.GetName() + "<br>Age: " + person.GetAge();
    }
}