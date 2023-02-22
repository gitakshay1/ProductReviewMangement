using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewMangement
{
    public class LinqOperations
    {
        public void ProductPrint(List<ProductReview> listProductReview)
        {
            Console.WriteLine("Printing product reviewlist");
            //Print products
            foreach (var productReview in listProductReview)
            {
                Console.WriteLine($"ProductID: {productReview.ProductId},UserId: {productReview.UserId}Rating: {productReview.Rating},Review: {productReview.Review}");
            }
        }
        public void PrintTopThreeRecords(List<ProductReview> listProductReview)
        {
            //top 3 recors whose ratings are high
            Console.WriteLine("Print top three records");
            var result =listProductReview.OrderByDescending(x => x.Rating).Take(3).ToList();
            ProductPrint(result);
        }
    }
}
