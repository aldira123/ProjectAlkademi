using Microsoft.AspNetCore.Mvc;
using eCommerce.Interface;
using eCommerce.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;


namespace eCommerce.Controllers;

public class AkunController : Controller
{
    private readonly IAkunService _akunService;
    private readonly ILogger<HomeController> _logger;

    public AkunController(ILogger<HomeController> logger, IAkunService akunService)
    {
        _logger = logger;
        _akunService = akunService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Register() {
        return View(new RegisterViewModel());
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel request) {
        if(!ModelState.IsValid){
            return View(request);
        }
        try{
            await _akunService.Register(request);

            return Redirect(nameof(LoginCustomer));   
        }catch(InvalidOperationException ex){
            ViewBag.ErrorMessage = ex.Message;
        }
        catch(Exception) {
            throw;
        }

        return View(request);
    }

    public async Task<IActionResult> Logout(){
        await HttpContext.SignOutAsync(
        CookieAuthenticationDefaults.AuthenticationScheme);

        return RedirectToAction("Index", "Home");
    }


    public IActionResult Login()
    {
        return View(new AkunLoginViewModel());
    }

    [HttpPost]
    public async Task<IActionResult> Login(AkunLoginViewModel request)
    {
        //Cocokan username dan password ke database
        var result = await _akunService.Login(request.Username,request.Password);

        if (result == null)
        {
            return View(new AkunLoginViewModel { });
        }

        try
        {
            #region set session login
            var claims = new List<Claim>
        {
            // new Claim(ClaimTypes.Email,result.Email?? result.Nama),
            new Claim("FullName", result.Nama),
            new Claim(ClaimTypes.Role, "Administrator"),
        };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);
            #endregion

            return RedirectToAction("Index", "Produk");
        }
        catch (System.Exception)
        {
            return View(request);
        }
    }

     public IActionResult LoginCustomer()
    {
        return View(new RegisterViewModel());
    }

    [HttpPost]
    public async Task<IActionResult> LoginCustomer(RegisterViewModel request)
    {
        //Cocokan username dan password ke database
        var result = await _akunService.LoginCustomer(request.Username,request.Password);

        if (result == null)
        {
            return View(new AkunLoginViewModel { });
        }

        try
        {
            #region set session login
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, result.IdCustomer.ToString()),
            new Claim(ClaimTypes.Email,result.Email?? result.Nama),
            new Claim("FullName", result.Nama),
            new Claim(ClaimTypes.Role, "Customer"),
        };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);
            #endregion

            return RedirectToAction("Index", "Home");
        }
        catch (System.Exception)
        {
            return View(request);
        }
    }

   
}
