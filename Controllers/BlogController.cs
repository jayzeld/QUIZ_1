using Microsoft.AspNetCore.Mvc;
using QUIZ_1.Models;
using System.Drawing;

namespace QUIZ_1.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index(int year, int month, string slug)
        {

            var blogModel = new BlogModel();

            if (slug == "slug1")
            {
                blogModel.Title = "Scottish Fold";
                blogModel.Content = "The Scottish Fold is a distinctive and popular breed of domestic cat known for its unique folded ears, which give it an adorable and owl-like appearance. The breed originated in Scotland in the 1960s, when a cat with unusual folded ears named Susie was discovered on a farm.\r\n\r\nScottish Folds have a rounded head, large, round eyes, and a sturdy, medium-sized body. Their most distinguishing feature, of course, is their folded ears, which typically fold forward and downward, giving them their characteristic look. However, not all Scottish Folds have folded ears; some have straight ears, and these cats are often referred to as \"Scottish Straights.\"";
                blogModel.Image = "~/img/slug1.jpg";
                
            }
            else if (slug == "slug2")
            {
                blogModel.Title = "British Shorthair";
                blogModel.Content = "\r\nThe British Shorthair is a popular breed of domestic cat known for its sturdy build, dense coat, and round face with large, expressive eyes. Originating in the United Kingdom, the British Shorthair has a long history and is one of the oldest English cat breeds.\r\n\r\nThese cats are characterized by their calm and easygoing temperament, making them excellent companions. They are typically affectionate with their families but also independent and content to entertain themselves. British Shorthairs come in a variety of colors and patterns, with the most well-known being the blue (gray) coloration, but they also come in black, white, cream, and other colors.";
                blogModel.Image = "~/img/slug2.jpg";
            }
            else if (slug == "slug3")
            {
                blogModel.Title = "Siamese";
                blogModel.Content = "The Siamese cat is one of the most recognizable and beloved breeds in the world. Originating from Thailand (formerly Siam), these cats are known for their striking appearance, vocal nature, and affectionate personality.\r\n\r\nSiamese cats have a distinctive sleek and slender body, with striking blue almond-shaped eyes, large ears, and a short coat that comes in various color points. The points, which are darker areas on the ears, face, paws, and tail, are a result of a temperature-sensitive enzyme that causes pigment to develop only in cooler areas of the body.";
                blogModel.Image = "~/img/slug3.jpg";
            }
            else if (slug == "slug4")
            {
                blogModel.Title = "Ragdoll";
                blogModel.Content = "The Ragdoll is a large, affectionate cat breed known for its striking blue eyes, semi-long fur, and docile temperament. Developed in the 1960s in California, USA, the Ragdoll breed is relatively young compared to some other breeds.\r\n\r\nRagdolls are often characterized by their relaxed and gentle nature, hence the name \"Ragdoll,\" which refers to their tendency to go limp when picked up, similar to a child's ragdoll toy. They are known for their affectionate behavior and are often described as \"puppy-like\" in their devotion to their owners. Ragdolls are typically good with children and other pets, making them excellent family companions.";
                blogModel.Image = "~/img/slug4.jpg";
            }
            else if (slug == "slug5")
            {
                blogModel.Title = "Himalayan";
                blogModel.Content = "The Himalayan cat, also known as the \"Himalayan Persian,\" is a breed known for its striking appearance and sweet temperament. It is a crossbreed between the Persian and the Siamese cat breeds, resulting in a cat with the luxurious long fur of the Persian and the distinctive color points of the Siamese.\r\n\r\nHimalayans have a similar body type to Persians, with a stocky build, round face, and short, cobby legs. They have long, flowing fur that requires regular grooming to prevent matting and tangles. Their most characteristic feature is their color points, which are darker areas on the ears, face, paws, and tail, similar to those of a Siamese cat.";
                blogModel.Image = "~/img/slug5.jpg";
            }
            else if (slug == "slug6")
            {
                blogModel.Title = "Exotic";
                blogModel.Content = "\r\nThe Exotic Shorthair, often simply referred to as the Exotic, is a breed of domestic cat that shares many physical characteristics with the Persian breed but with a shorter, plush coat. It was developed in the 1960s in the United States by crossing Persians with various shorthaired breeds, including the American Shorthair and the Burmese.\r\n\r\nExotics have a similar body type to Persians, featuring a robust build, round face, and short, cobby legs. They have a dense, plush coat that is easy to maintain compared to the long fur of Persians. Exotics come in a wide variety of colors and patterns, similar to Persians, including solid colors, bi-colors, tabby patterns, and more.";
                blogModel.Image = "~/img/slug6.jpg";

            }


            else
            {
                
            }

            return View("Index", blogModel);
        }
    }
}
