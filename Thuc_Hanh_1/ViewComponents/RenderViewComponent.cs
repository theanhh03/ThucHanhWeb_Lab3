using Microsoft.AspNetCore.Mvc;
using ThucHanh3.Models;

namespace ThucHanh3.ViewComponents
{
    public class RenderViewComponent:ViewComponent
    {
        private List<MenuItem> MenuItems = new List<MenuItem>();                                                                                                                                                                                                                                                                                                                                                   
        public RenderViewComponent() 
        {
            MenuItems = new List<MenuItem>()
            {
                new MenuItem() {ID=1, Name="Branches", Link="Branches/List"},
                new MenuItem() {ID=2, Name="Students", Link="Students/List"},
                new MenuItem() {ID=3, Name="Subjects", Link="Subjects/List"},
                new MenuItem() {ID=4, Name="Courses", Link="Courses/List"}
            };
        }    
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderLeftMenu", MenuItems);
        }
    }
}
