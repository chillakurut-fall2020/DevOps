using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace musicapp.Pages
{
    public class Lyrics1 : PageModel
    {
        private readonly ILogger<Lyrics1> _logger;

        public Lyrics1(ILogger<Lyrics1> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
