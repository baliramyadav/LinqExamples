using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace LinqExamples
{
    public partial class LinqWithArray : System.Web.UI.Page
    {
        //Data source
        int[] arr = { 13, 56, 29, 74, 31, 45, 91, 7, 34, 86, 24, 62, 19, 3, 98, 16, 36, 41, 52, 83, 38, 79, 67, 27, 5 };
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Count = 0, Index = 0;
            foreach (int i in arr)
            {
                if (i > 40)
                {
                    Count+=1;
                }
            }
            int[] brr = new int[Count];
            foreach (int i in arr)
            {
                if(i>40)
                {
                    brr[Index] = i;
                    Index+= 1;
                }
            }
            Array.Sort(brr);
            Array.Reverse(brr);
            Label1.Text = String.Join(" ",brr);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Write LINQ code
            var brr = from i in arr where i > 40 orderby i descending select i;
            Label2.Text=String.Join(" ",brr);
        }
    }
}