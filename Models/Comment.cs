namespace api.Models;

public class Comment
{
   public int ID { get; set; }
   
   public string Title { get; set; } = string.Empty;
   
   public string Content { get; set; } = string.Empty;
   
   public DateTime CreatedOn { get; set; }
  
   public int? StockID { get; set; }
   
   public Stock? Stock {get; set;} //Navigation Property eg. stock.MarketCap
   
}