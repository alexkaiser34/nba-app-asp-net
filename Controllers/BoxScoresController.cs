using Microsoft.AspNetCore.Mvc;
using nba_app.Data;
using nba_app.Models;

namespace nba_app.Controllers
{
    public class BoxScoresController : Controller
    {
        private readonly IAPIClientService<BoxScores> _api;

        public BoxScoresController(IAPIClientService<BoxScores> api)
        {
            _api = api;
        }
        public async Task<IActionResult> Index()
        {
            string endpoint = "current/boxScores";
            IEnumerable<BoxScores> results = await _api.GetAll(endpoint);
            return View(results);
        }

    }
}
