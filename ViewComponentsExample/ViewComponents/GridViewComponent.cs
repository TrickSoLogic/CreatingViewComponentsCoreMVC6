﻿using Microsoft.AspNetCore.Mvc;

namespace CreatingViewComponentsCoreMVC6.ViewComponents
{
  public class GridViewComponent : ViewComponent
  {
    public async Task<IViewComponentResult> InvokeAsync()
    {
      return View("Sample"); //invoked a partial view Views/Shared/Components/Grid/Default.cshtml
    }
  }
}
