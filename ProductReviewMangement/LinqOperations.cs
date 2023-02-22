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
    }
}
