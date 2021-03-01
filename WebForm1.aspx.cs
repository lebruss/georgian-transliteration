using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Translation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        class GFG
        {
            static char[] EnglishAlphabets = " abcdefghijklmnopqrstuvwxyz".ToCharArray();
            static char[] GeorgianAlphabets = " აბცდეფგჰიჯკლმნოპქრსტუვწხყზ".ToCharArray();
            // function for converting the string
            public static String conversion(String charSet, char[] str1)
            {
                String s2 = "";
                foreach (char i in str1)
                {
                    var lower = Char.ToLower(i);
                    // find the index of each element of the
                    // string in the modified set of alphabets
                    // replace the element with the one having the
                    // same index in the actual set of alphabets
                    s2 += GeorgianAlphabets[charSet.IndexOf(lower)];
                }
                    

                return s2;
            }

            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                if (englishIn.Value != "")
                {
                    String EnglishChars = " abcdefghijklmnopqrstuvwxyz";
                    String str1 = englishIn.Value;
                    georgianOut.Value = GFG.conversion(EnglishChars, str1.ToCharArray());
                    //Console.Write(GFG.conversion("აბცდეფგჰიჯკლოპქრსტუვწხყზ", str1.ToCharArray()));
                }
                else
                {
                   
                }
                
            }

            //String GeorgianChars = "აბცდეფგჰიჯკლმნოპქრსტუვწხყზ";
            //String str1 = englishIn.Value;
            //georgianOut.Value = GFG.conversion(GeorgianChars, str1.ToCharArray());
            //Console.Write(GFG.conversion("აბცდეფგჰიჯკლოპქრსტუვწხყზ", str1.ToCharArray()));
        }


      

    }
}


