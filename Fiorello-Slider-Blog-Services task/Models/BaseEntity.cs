namespace Fiorello_Slider_Blog_Services_task.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool SoftDeleted { get; set; }
        public DateTime Createdate { get; set; }

    }
}
