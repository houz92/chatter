using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Chatter.Backend.Chatter;
using Microsoft.AspNetCore.SignalR;

namespace Chatter.Backend.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> logger;
        private readonly ISimpleChatterHub chatterHub;

        public IndexModel(ILogger<IndexModel> logger, ISimpleChatterHub chatterHub)
        {
            this.logger = logger;
            this.chatterHub = chatterHub;
        }

        [StringLength(500, MinimumLength = 1)]
        [BindProperty]
        [Required]
        public string Message { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            //if (string.IsNullOrEmpty(this.Message))
            {
                ModelState.AddModelError(nameof(Message), "Message must not be null or empty");
                return Page();
            }
            
            await this.chatterHub.SendMessage(this.Message);
            
            return new PageResult();
        }
    }
}