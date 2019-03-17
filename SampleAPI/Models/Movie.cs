using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleAPI.Models
{
	 public class Movie
	 {
		  [Key]
		  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		  public long ID { get; set; }
		  [Required]
		  [StringLength(80)]
		  public string Title { get; set; }
		  public DateTime? ReleaseDate { get; set; }
		  [StringLength(25)]
		  public string Genre { get; set; }
		  [Range(0.0,double.MaxValue)]
		  public decimal Price { get; set; }
	 }
}
