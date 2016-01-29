using _05.WebCounterDB.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _05.WebCounterDB
{
    public partial class Home : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VisitorDbContext data = new VisitorDbContext();
            data.Visitors.Add(new Visitor());
            data.SaveChanges();

            var counter = data.Visitors.Count();

            Bitmap generatedInage = new Bitmap(100, 100);
            using (generatedInage)
            {
                Graphics gr = Graphics.FromImage(generatedInage);
                using (gr)
                {
                    gr.FillRectangle(Brushes.SlateGray, 0,0,250,250);
                    gr.DrawString(
                        counter.ToString(),
                        new Font("Time New Roma", 50),
                        new SolidBrush(Color.YellowGreen),
                        new Point(10, 10));

                    Response.ContentType = "image/jpeg";

                    generatedInage.Save(Response.OutputStream, ImageFormat.Jpeg);
                }
            }
        }
    }
}