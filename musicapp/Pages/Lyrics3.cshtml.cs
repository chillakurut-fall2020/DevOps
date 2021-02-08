using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace musicapp.Pages
{
    public class Lyrics3 : PageModel
    {
        private readonly ILogger<Lyrics3> _logger;

        public Lyrics3(ILogger<Lyrics3> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
