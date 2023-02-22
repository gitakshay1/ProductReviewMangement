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
        public void GetRecordsRatingsGreaterThanThree(List<ProductReview> listProductReview)
        {
            //fetch record whose rating greater than three and product id 1,4,9
            Console.WriteLine("Print record whose rating > 3 and product id are 1,4,9");
            var result = listProductReview.Where(x => x.Rating > 3 && (x.ProductId == 1 || x.ProductId == 4 || x.ProductId ==9)).ToList();
            ProductPrint(result);
        }
    }
}
