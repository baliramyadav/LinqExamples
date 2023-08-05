using System.Web.UI.WebControls;
using System.Web.UI;


public class VideoPlayer : WebControl
{
    public bool AutoPlay { get; set; } = false;
    public new bool Controls { get; set; } = false;
    public bool Loop { get; set; } = false;
    public bool Muted { get; set; } = false;
    public string Poster { get; set; } = null;
    public string Mp4Url { get; set; } = null;
    public string WebMUrl { get; set; } = null;
    public string OggUrl { get; set; } = null;
    public override void RenderControl(HtmlTextWriter writer)
    {
        writer.AddAttribute(HtmlTextWriterAttribute.Id, this.ID);
        writer.AddAttribute(HtmlTextWriterAttribute.Name, this.ID);
        writer.AddAttribute(HtmlTextWriterAttribute.Width, this.Width.ToString());
        writer.AddAttribute(HtmlTextWriterAttribute.Height, this.Height.ToString());
        if (AutoPlay) { writer.AddAttribute("autoplay", "autoplay"); }
        if (Controls) { writer.AddAttribute("controls", "controls"); }
        if (Loop) { writer.AddAttribute("loop", "loop"); }
        if (Muted) { writer.AddAttribute("muted", "muted"); }
        if (Poster != null) { writer.AddAttribute("poster", this.Poster); }

        writer.RenderBeginTag("video");                     //Generates <video> tag
        if (this.Mp4Url != null)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Src, this.Mp4Url);  //Generates src attribute for <source> tag
            writer.AddAttribute(HtmlTextWriterAttribute.Type, "video/mp4"); //Generates type attribute for <source> tag
            writer.RenderBeginTag("source");                //Generate <source> tag	
            writer.RenderEndTag();                  //Generate end tag for <source>
        }
        if (this.WebMUrl != null)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Src, this.WebMUrl); //Generates src attribute for <source> tag
            writer.AddAttribute(HtmlTextWriterAttribute.Type, "video/webm");//Generates type attribute for <source> tag
            writer.RenderBeginTag("source");                //Generate <source> tag
            writer.RenderEndTag();                  //Generate end tag for <source>
        }
        if (this.OggUrl != null)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Src, this.OggUrl);  //Generates src attribute for <source> tag
            writer.AddAttribute(HtmlTextWriterAttribute.Type, "video/ogg"); //Generates type attribute for <source> tag
            writer.RenderBeginTag("source");                //Generate <source> tag
            writer.RenderEndTag();                  //Generate end tag for <source>
        }
        writer.RenderEndTag();                      //Generates end tag for <video>
    }
}
