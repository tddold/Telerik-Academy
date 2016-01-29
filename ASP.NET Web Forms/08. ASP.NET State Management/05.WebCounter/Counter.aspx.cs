namespace _05.WebCounter
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Web.UI;

    public partial class Counter : Page
    {
        public int? Visitors
        {
            get
            {
                return (int)this.Application["visitors"];
            }
            set
            {
                this.Application["visitors"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Application["visitors"] == null)
            {
                this.Visitors = 0;
            }

            this.Visitors++;
        }

        protected override void OnPreRender(EventArgs e)
        {
            Bitmap generatedImage = new Bitmap(100, 100);

            using (generatedImage)
            {
                Graphics gr = Graphics.FromImage(generatedImage);
                gr.DrawString(
                    this.Visitors.ToString(),
                    new Font("Times New Roman", 50),
                    new SolidBrush(Color.YellowGreen),
                    new Point(10, 10));

                Response.ContentType = "image/jpeg";

                generatedImage.Save(Response.OutputStream, ImageFormat.Jpeg);
            }
        }
    }
}