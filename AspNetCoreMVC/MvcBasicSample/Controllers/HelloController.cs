
using Microsoft.AspNetCore.Mvc;   // ControllerとIActionResult

namespace MvcBasicSample.Controllers;

// URLのHelloに対応する要求を受け取るController
public class HelloController : Controller {

    // ../Hello/Indexで呼び出されるAction
    public IActionResult Index() {

        // Views//Hello/Index.cshtmlを使ってHTMLを生成する
        return View();
    }
}
