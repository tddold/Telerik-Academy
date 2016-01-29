using System;

namespace _03.WebAlbum
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [System.Web.Services.WebMethod]
        public static AjaxControlToolkit.Slide[] GetSlides()
        {
            AjaxControlToolkit.Slide[] slides = new AjaxControlToolkit.Slide[9];

            slides[0] = new AjaxControlToolkit.Slide("images/Blue hills.jpg", "Blue Hills", "Go Blue");
            slides[1] = new AjaxControlToolkit.Slide("images/Sunset.jpg", "Sunset", "Setting sun");
            slides[2] = new AjaxControlToolkit.Slide("images/Winter.jpg", "Winter", "Wintery...");
            slides[3] = new AjaxControlToolkit.Slide("images/Water lilies.jpg", "Water lillies", "Lillies in the water");
            slides[4] = new AjaxControlToolkit.Slide("images/VerticalPicture.jpg", "Sedona", "Portrait style picture");
            slides[5] = new AjaxControlToolkit.Slide("images/jon-snow.jpg", "jon", "Jon snow");
            slides[6] = new AjaxControlToolkit.Slide("images/arya-stark.jpg", "arya", "Arya Stark");
            slides[7] = new AjaxControlToolkit.Slide("images/daenerys.jpg", "daenerys", "Daenerys Targaryen");
            slides[8] = new AjaxControlToolkit.Slide("images/tyrion.jpg", "Tyrion", "Tyrion Lannister");
            
            return (slides);
        }
        
    }
}