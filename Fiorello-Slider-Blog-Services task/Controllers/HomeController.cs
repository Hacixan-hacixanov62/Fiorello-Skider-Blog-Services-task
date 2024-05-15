using Fiorello_Slider_Blog_Services_task.Services.Interfaces;
using Fiorello_Slider_Blog_Services_task.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello_Slider_Blog_Services_task.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IBlogService _blogService;
        public HomeController(ISliderService sliderService,
                                  IBlogService blogService)
        {
            _sliderService = sliderService;
            _blogService = blogService;

        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new()
            {
                Sliders = await _sliderService.GetAllAsync(),
                SliderInfo = await _sliderService.GetSliderInfoAsync(),
                Blogs = await _blogService.GetAllAsync()
            };

            return View(model);
        }
    }
}


