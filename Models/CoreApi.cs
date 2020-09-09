using System.ComponentModel.DataAnnotations;

namespace CoreApi.Models
{
  public class Api
  {
      
      public int Id { get; set;}
      [Required]
      [MaxLength(250)]
      public string HowTo  { get; set; }
      [Required]
      public string Line { get; set; }
      [Required]
      public string Platform { get; set; }  

  }

  
}


