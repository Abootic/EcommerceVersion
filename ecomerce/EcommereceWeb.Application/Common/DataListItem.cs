
namespace EcommereceWeb.Application.Common
{
    public class DataListItem
    {
        //public bool Disabled { get; set; }
        public int Value { get; set; }
        public string Text { get; set; }
      // public bool Selected { get; set; }

        public DataListItem()
        {

        }
        public DataListItem(int Value)
        {
            this.Value = Value;
        }    
        public DataListItem(string Text)
        {
            this.Text = Text;
        }
        public DataListItem(int Value,string Text)
        {
            this.Value = Value;
            this.Text = Text;
        } 
       
    }
}
