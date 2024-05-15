using Fiorello_Slider_Blog_Services_task.Models;
using Fiorello_Slider_Blog_Services_task.ViewModels.Blog;

namespace Fiorello_Slider_Blog_Services_task.Services.Interfaces
{
    public interface IBlogService
    {
        Task<IEnumerable<BlogVM>> GetAllAsync();
    }
}
