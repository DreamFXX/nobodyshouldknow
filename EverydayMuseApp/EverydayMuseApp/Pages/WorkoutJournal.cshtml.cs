using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EverydayMuse.Pages
{
    public class WorkoutLogModel : PageModel
    {
        [BindProperty]
        public string Exercise { get; set; }
        [BindProperty]
        public string Date { get; set; }
        [BindProperty]
        public string Notes { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Zde m��e� p�idat k�d pro ulo�en� informac� o cvi�en� do datab�ze nebo jin�ho �lo�i�t�

            return RedirectToPage("/WorkoutLog");
        }
    }
}

