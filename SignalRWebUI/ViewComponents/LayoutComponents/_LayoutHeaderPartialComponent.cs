using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.LayoutComponents
{
    //uygulamaya bunun view cımponen olkduğunu bildirmek için :ViewComponent diyorum
    public class _LayoutHeaderPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //artık buranın bir view component olduğunu bildirmiş oldum
    }
}
