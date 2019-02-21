using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

public partial class Developer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
     String yo=   TextBox1.Text;
       

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        


    }
    public static String SpaceAddition(String w)
    {

        //    String[] keyword = { "int", "String", "double","string","for","foreach","switch","break" };
        char[] keyword1 = { '(', ')', '{', '}', '[', ']', ',', '.', '=', '!', '+', '-', '/', '*', '%', ';', '&', '<', '>' };

        char[] cha = w.ToCharArray();

        String[] o = { };
        foreach (var A in cha)
        {
            foreach (var B in keyword1)
            {
                if (A == B)
                {
                    w = w.Replace(B.ToString(), (" " + B + " ").ToString());
                }


            }
        }




        return w;


    }
    public static String SpaceSubstract(String w)
    {

        //    String[] keyword = { "int", "String", "double","string","for","foreach","switch","break" };
        char[] keyword1 = { '(', ')', '{', '}', '[', ']', ',', '.', '=', '!', '+', '-', '/', '*', '%', ';', '&' };

        char[] cha = w.ToCharArray();

        String[] o = { };






        RegexOptions options = RegexOptions.None;
        Regex regex = new Regex("[ ]{2,}", options);
        w = regex.Replace(w, " ");






        return w;


    }
}
