using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Person
/// </summary>
public class Person
{
    private string firstname;
    private string lastname;
    private int age;

	public void SetName(string firstname, string lastname)
    {
        this.firstname = firstname;
        this.lastname = lastname;
    }

    public string GetName()
    {
        return firstname + " " + lastname;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public int GetAge()
    {
        return age;
    }
}