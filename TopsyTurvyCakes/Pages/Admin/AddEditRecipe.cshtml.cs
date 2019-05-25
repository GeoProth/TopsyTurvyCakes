using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopsyTurvyCakes.Models;


namespace TopsyTurvyCakes.Pages.Admin
{

    public class AddEditRecipeModel : PageModel
    {
        [FromRoute]
        public long? Id { get; set; }
        public bool IsNewRecipe
        {
            get { return Id == null; }
        }
        [BindProperty]
        public Recipe Recipe { get; set; }
        [BindProperty]
        public Microsoft.AspNetCore.Http.IFormFile Image { get; set; }

        public IRecipesService recipesService { get; set; }

        public AddEditRecipeModel(IRecipesService recipesService)
        {
            this.recipesService = recipesService;
        }
        [HttpGet]
        public async Task OnGetAsync()
        {
            Recipe = await recipesService.FindAsync(Id.GetValueOrDefault()) ?? new Recipe();
        }
        [HttpPost]
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Recipe = await recipesService.FindAsync(Id.GetValueOrDefault()) ?? new Recipe();

            Recipe.Name = Request.Form["Recipe.Name"];
            Recipe.Description = Request.Form["Recipe.Description"];
            Recipe.Ingredients = Request.Form["Recipe.Ingredients"];
            Recipe.Directions = Request.Form["Recipe.Directions"];
            Recipe.Id = Id.GetValueOrDefault();

            if (Image != null)
            {
                using (var stream = new System.IO.MemoryStream())
                {
                    await Image.CopyToAsync(stream);
                    Recipe.Image = stream.ToArray();
                    Recipe.ImageContentType = Image.ContentType;
                }
            }


            await recipesService.SaveAsync(Recipe);
            return RedirectToPage("/Recipe", new { id = Recipe.Id });
        }
        public async Task<IActionResult> OnPostDelete()
        {
            await recipesService.DeleteAsync(Id.Value);
            return RedirectToPage("/Index");
        }

    }
}