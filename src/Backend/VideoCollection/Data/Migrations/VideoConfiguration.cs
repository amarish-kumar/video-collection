using System;
using System.Data.Entity.Migrations;
using VideoCollection.Data;
using VideoCollection.Data.Models;

namespace VideoCollection.Migrations
{
    public class VideoConfiguration
    {
        public static void Seed(VideoCollectionDataContext context) {

            context.Videos.AddOrUpdate(x => x.Title, new Video()
            {
                Title = "RxJS and Angular 2",
                YouTubeVideoId = "xAEFTSMEgIQ",
                Rating = 0                
            });

            context.SaveChanges();
        }
    }
}


//public int Id { get; set; }
//[ForeignKey("Tenant")]
//public int? TenantId { get; set; }
//public string Category { get; set; }
//public string Title { get; set; }
//public string SubTitle { get; set; }
//public string Slug { get; set; }
//public string YouTubeVideoId { get; set; }
//public string Abstract { get; set; }
//public int DurationInSeconds { get; set; }
//public decimal Rating { get; set; }
//public ICollection<VideoRating> Ratings { get; set; }
//public string Description { get; set; }
//public DateTime PublishedOn { get; set; }
//public string PublishedBy { get; set; }
//public DateTime CreatedOn { get; set; }
//public string CreatedBy { get; set; }
//public DateTime LastModifiedOn { get; set; }
//public string LastModifiedBy { get; set; }
//public Tenant Tenant { get; set; }
//public bool IsDeleted { get; set; }