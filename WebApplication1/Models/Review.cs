using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public string reviewId { get; set; }
        public string reviewFullText { get; set; }
        public string reviewText { get; set; }
        public int numLikes { get; set; }
        public int numComments { get; set; }
        public int numShares { get; set; }
        public int rating { get; set; }
        public string reviewCreatedOn { get; set; }
        public DateTime reviewCreatedOnDate { get; set; }
        public int reviewCreatedOnTime { get; set; }
        public string? reviewerId { get; set; }
        public string? reviewerUrl { get; set; }
        public string reviewerName { get; set; }
        public string? reviewerEmail { get; set; }
        public string sourceType { get; set; }
        public bool isVerified { get; set; }
        public string source { get; set; }
        public string sourceName { get; set; }
        public string sourceId { get; set; }

        [NotMapped]
        public List<string> tags { get; set; }
        public string? href { get; set; }
        public string? logoHref { get; set; }
        [NotMapped]
        public List<object> photos { get; set; }
    }
}
