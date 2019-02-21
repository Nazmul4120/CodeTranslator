using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Web.UI;

public partial class _Default : System.Web.UI.Page
{
  

    protected void Page_Load(object sender, EventArgs e)
    {
      
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       
        String getResult=get.Value;
       
       
      // editor.InnerHtml = "p";
        
        

        Process command = new Process();

        string szMgwGCCPath = "gcc"; // Example of location
            string szArguments = "-g "+Server.MapPath(@"main.c")+"-o a.exe"; // Example of arguments
            ProcessStartInfo gccStartInfo = new ProcessStartInfo(szMgwGCCPath, szArguments);


        //Process.Start(gccStartInfo);






        

















        /*  String appName = "e.exe";
          CSharpCodeProvider codeProvider = new CSharpCodeProvider();

          // For Visual Basic Compiler try this :
          //Microsoft.VisualBasic.VBCodeProvider

          ICodeCompiler compiler = codeProvider.CreateCompiler();
          CompilerParameters parameters = new CompilerParameters();

          parameters.GenerateExecutable = true;

          foreach (Assembly asm in AppDomain.CurrentDomain.GetAssemblies())
          {
              parameters.ReferencedAssemblies.Add(asm.Location);
          }

          String code = TextBox2.Text.ToString();
          CompilerResults results = compiler.CompileAssemblyFromSource(parameters, code);

          if (results.Errors.Count > 0)
          {
              string errors = "Compilation failed:\n";
              foreach (CompilerError err in results.Errors)
              {
                  errors += err.ToString() + "\n";
              }
            TextBox2.Text= ("There were compilation errors"+errors);
          }
          else
          {
              #region Executing generated executable
              // try to execute application

              try
              {
                  if (!System.IO.File.Exists(appName.ToString()))
                  {

                      return;
                  }
                  ProcessStartInfo pInfo = new ProcessStartInfo(appName.ToString());
                  Process.Start(pInfo);
              }
              catch (Exception ex)
              {
                  Label1.Text = (String.Format("Error while executing {0}", appName) + ex.ToString());
              }

              #endregion

          }


      */

       
            String w = (SpaceSubstract(Work1(Work(getResult))));

            w = w.Replace("#include < stdio . h >", "using System;");
            w = w.Replace("return 0 ;", "");
            w = w.Replace("getch ( ) ;", "");


            w = w.Remove(w.Length - 3);
            w = w + "} }";
        getOut.Value = w;
        Button3.Text = w;
        //  Page.ClientScript.RegisterStartupScript(this.GetType(), "SomeUniqueTextHere", String.Format("qwe({0});", w), true);
        //  ScriptManager.RegisterStartupScript(Page, GetType(), "disp_confirm", "<script>var editor = ace.edit(\"editor1\"); editor.setText('"+w+"')   </script>", true);

        //  string myScriptValue = " editor.setText(wwww);   ";

        // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "myScriptName", myScriptValue, true);
        String we = @w;
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage1", "  src=\"ace - builds - master / src - noconflict / ace.js\" ; var editor = ace.edit(\"editor1\"); editor.getSession().setMode(\"ace / mode / javascript\"); editor.getSession().setUseWrapMode(true);  editor.setValue('" + w+"'); alert('"+w+"'); ", true);
    }
    public static String Work1(String Text)
    {








       


        String w = Text;
        String h = SpaceAddition(w);


        String[] q = { String.Empty };




        q = h.Split('\n');

        for (int i = 0; i < q.Length; i++)
        {



            // Console.WriteLine(q[i]);
            if (q[i].Contains("#include <stdio . h>"))
            {
                q[i] = q[i].Replace("#include <stdio . h>", "using System;");
                //    q[i] = q[i].Replace("(", "");
                //  q[i] = q[i].Replace(")", "");
                // q[i] = q[i].Replace("main", "public static void Main(String[] args)");


            }
            if (q[i].Contains("String")) { 
            q[i] = stringdone(q[i]);
        }

            if (q[i].Contains("char")&& q[i].Contains("{"))
            {
                q[i] = characterarray(q[i]);
            }

            if (q[i].Contains("char"))
            {
                q[i] = character(q[i]);
            }

            if (Go(q[i]).Contains("void"))
            {
                q[i] = "public static  " + q[i];
                //    q[i] = q[i].Replace("(", "");
                //  q[i] = q[i].Replace(")", "");
                //                    q[i] = q[i].Replace("main", "public static void Main(String[] args)");


            }



            if (Go(q[i]).Contains("main()"))
            {
                q[i] = q[i].Replace("int", "");
                q[i] = q[i].Replace("void", "");
                q[i] = q[i].Replace("(", "");
                q[i] = q[i].Replace(")", "");
                q[i] = q[i].Replace("main", "namespace Hello \n { \n class Hello \n { \npublic static void Main(String[] args)");


            }
          

            // Console.WriteLine(q[i]);



            // Console.WriteLine(q[i]);


        }

        //  Console.WriteLine(we);
        for (int i = 0; i < q.Length; i++)
        {
            q[i] = q[i] + "\n";
            //  q[q.Length - 1] = "";

        }

        String we = String.Join("", q);
        //  Console.WriteLine(we);







        return we;



    }

    public static String Work(String Text)
    {












        String w = Text;
       
        String h = SpaceAddition(w);

        String[] q = { String.Empty };





        q = h.Split(';');

        for (int i = 0; i < q.Length; i++)
        {



            if (q[i].Contains("printf"))
            {
                //printf

                int u = 0;
                char[] r = q[i].ToCharArray();
                q[i] = q[i].Replace("printf", "Console.Write");
                // q[i] = q[i].Replace(",", "+");

                for (int o = 0; o < r.Length; o++)
                {
                    if (r[i] == '%')
                    {
                        u++;
                    }
                }



                q[i] = q[i].Replace("%d", "{" + u + "}");
                //q[i] = q[i].Replace("", "");


            }

            // Console.WriteLine(q[i]);



            if (q[i].Contains("strcpy"))
            {
                //structure
                q[i] = q[i].Replace(",", "=");
                q[i] = q[i].Replace("strcpy", "");
                q[i] = q[i].Replace("(", "");
                q[i] = q[i].Replace(")", "");
            }


            if (q[i].Contains("return"))
            {
                q[i] = q[i].Replace("return 0 ;","");
                


            }
            if (q[i].Contains("getch ( )"))
            {
                q[i] = q[i].Replace("getch ( )", "");



            }


            // Console.WriteLine(q[i]);

            if (q[i].Contains("scanf"))
            {
                //structure
                q[i] = q[i].Replace("scanf", "Console.ReadLine");
                q[i] = q[i].Replace(",", "+");
                q[i] = q[i].Replace("&", "");
                //  q[i] = q[i].Replace("(", "");
                // q[i] = q[i].Replace(")", "");
            }
        }
        // Console.WriteLine(q[i]);


        for (int i = 0; i < q.Length; i++)
        {
            q[i] = q[i] + ";";
          //  q[q.Length - 1] = "";

        }
        String we = String.Join("", q);
        //  Console.WriteLine(we);








        return we;



    }
















    public static String SpaceAddition(String w)
    {

        //    String[] keyword = { "int", "String", "double","string","for","foreach","switch","break" };
        char[] keyword1 = { '(', ')', '{', '}', '[', ']', ',', '.', '=', '!', '+', '-', '/', '*', '%', ';', '&','<','>' };

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

    public static String Go(String e)
    {

        e = e.Replace(" ", "");




        return e;
    }




    protected void Button2_Click(object sender, EventArgs e)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        //string output = TextBox2.Text;
       // sb.Append(output);
        sb.Append("\r\n");

        string text = sb.ToString();

        Response.Clear();
        Response.ClearHeaders();

        Response.AddHeader("Content-Length", text.Length.ToString());
        Response.ContentType = "text/plain";
        Response.AppendHeader("content-disposition", "attachment;filename=\"Program.txt\"");

        Response.Write(text);
        Response.End();

    }

    public static String character(String input)
    {
      
        var output = String.Join(";", Regex.Matches(input, @"\[(.*?)\]")
                                            .Cast<Match>()
                                            .Select(m => m.Groups[1].Value));
        String code = "";

        Regex r = new Regex(Regex.Escape("r") + "(.*?)" + Regex.Escape("["));
        MatchCollection matches = r.Matches(input);
        foreach (Match match in matches)
            code = match.Groups[1].Value;



        return ("char[ ]" + code + "=new char["+output+"];");
    }
    public static String stringdone(String input )
    {
        
        var output = String.Join(";", Regex.Matches(input, @"\[(.*?)\]")
                                            .Cast<Match>()
                                            .Select(m => m.Groups[1].Value));
        String code = "";

        Regex r = new Regex(Regex.Escape("g") + "(.*?)" + Regex.Escape("["));
        MatchCollection matches = r.Matches(input);
        foreach (Match match in matches)
            code = match.Groups[1].Value;



        return("String[ ]" + code + "=new String["+output+"];");
    }
    public static String characterarray(String input)
    {
      
        var output = String.Join(";", Regex.Matches(input, @"\[(.*?)\]")
                                            .Cast<Match>()
                                            .Select(m => m.Groups[1].Value));
        String code = "";

        Regex r = new Regex(Regex.Escape("r") + "(.*?)" + Regex.Escape("["));
        MatchCollection matches = r.Matches(input);
        foreach (Match match in matches)
            code = match.Groups[1].Value;

        string tobesearched = "=";
        String code1 = "";

        int ix = input.IndexOf(tobesearched);

        if (ix != -1)
        {
            code1 = input.Substring(ix + tobesearched.Length);
            // do something here
        }

        return("char[]" + code + "=new char[]" + code1);
    }

}