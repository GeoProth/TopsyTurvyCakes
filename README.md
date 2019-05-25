# TopsyTurvyCakes
CS 4790 assignment 3

Challenges:

Challenge 3 was tricking me up, but I was over complicating it.  I moved on to the other projects and let a couple days go by before coming back to this,
once I let it sit in my mind for a bit, I was able to finish this within 10 minutes.  

creating the Image property as a Microsoft.AspNetCore.Http.IFormFile object,
then connecting it to the Form Data and wrapping it in a using statement only if the data wasn't Null.

then assign that data to Recipe.Image

I also was forgetting to set the Recipe.Image Content type.  
figured this out pretty quickly.

to assign object values from the Form data,  use Request.Form["asp-for label HERE"];
